using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp2.Helpers
{
    /// <summary>Một dòng dữ liệu đọc từ Excel (Row = số dòng trong file, để báo lỗi chính xác).</summary>
    public class ExcelRow
    {
        public int Row { get; set; }
        public object[] Cells { get; set; }
    }

    /// <summary>
    /// Xuất DataGridView ra file .xlsx bằng EPPlus (khuyến nghị bản 4.5.3.3 - miễn phí).
    /// Nếu dùng EPPlus 5 trở lên, thêm dòng: ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
    /// </summary>
    public static class ExcelHelper
    {
        static ExcelHelper()
        {
            ExcelPackage.License.SetNonCommercialPersonal("BookStore - Do an mon hoc");
        }
        public static void XuatDataGridView(DataGridView dgv, string tieuDe, string tenFileMacDinh)
        {
            if (dgv.Rows.Count == 0)
            {
                UiHelper.Warn("Không có dữ liệu để xuất.");
                return;
            }

            using (var sfd = new SaveFileDialog())
            {
                sfd.Title = "Xuất ra Excel";
                sfd.Filter = "Excel Workbook (*.xlsx)|*.xlsx";
                sfd.FileName = tenFileMacDinh + "_" + DateTime.Now.ToString("yyyyMMdd_HHmm") + ".xlsx";
                if (sfd.ShowDialog() != DialogResult.OK) return;

                try
                {
                    using (var pkg = new ExcelPackage())
                    {
                        var ws = pkg.Workbook.Worksheets.Add("Dữ liệu");
                        var cols = dgv.Columns.Cast<DataGridViewColumn>()
                                      .Where(c => c.Visible)
                                      .OrderBy(c => c.DisplayIndex).ToList();
                        int nCol = cols.Count;
                        const int hang0 = 4;                       // dòng tiêu đề cột

                        // Tiêu đề báo cáo
                        ws.Cells[1, 1].Value = tieuDe.ToUpper();
                        ws.Cells[1, 1, 1, nCol].Merge = true;
                        ws.Cells[1, 1].Style.Font.Bold = true;
                        ws.Cells[1, 1].Style.Font.Size = 16;
                        ws.Cells[1, 1].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                        ws.Cells[2, 1].Value = "Ngày xuất: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm")
                                               + "   |   Người xuất: " + Session.TenDangNhap;
                        ws.Cells[2, 1, 2, nCol].Merge = true;
                        ws.Cells[2, 1].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                        ws.Cells[2, 1].Style.Font.Italic = true;

                        // Hàng tiêu đề cột
                        for (int c = 0; c < nCol; c++)
                            ws.Cells[hang0, c + 1].Value = cols[c].HeaderText;
                        using (var rng = ws.Cells[hang0, 1, hang0, nCol])
                        {
                            rng.Style.Font.Bold = true;
                            rng.Style.Font.Color.SetColor(Color.White);
                            rng.Style.Fill.PatternType = ExcelFillStyle.Solid;
                            rng.Style.Fill.BackgroundColor.SetColor(UiTheme.Primary);
                            rng.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                        }

                        // Dữ liệu
                        for (int r = 0; r < dgv.Rows.Count; r++)
                        {
                            for (int c = 0; c < nCol; c++)
                            {
                                object v = dgv.Rows[r].Cells[cols[c].Index].Value;
                                if (v != null) ws.Cells[hang0 + 1 + r, c + 1].Value = v;
                            }
                        }

                        // Định dạng số theo cột
                        for (int c = 0; c < nCol; c++)
                        {
                            string fmt = cols[c].DefaultCellStyle.Format;
                            if (fmt == "N0") ws.Column(c + 1).Style.Numberformat.Format = "#,##0";
                            else if (!string.IsNullOrEmpty(fmt)) ws.Column(c + 1).Style.Numberformat.Format = fmt;
                        }

                        // Kẻ khung
                        int hangCuoi = hang0 + dgv.Rows.Count;
                        using (var rng = ws.Cells[hang0, 1, hangCuoi, nCol])
                        {
                            rng.Style.Border.Top.Style = ExcelBorderStyle.Thin;
                            rng.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                            rng.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                            rng.Style.Border.Right.Style = ExcelBorderStyle.Thin;
                        }

                        ws.Cells[hang0, 1, hangCuoi, nCol].AutoFitColumns();
                        ws.View.FreezePanes(hang0 + 1, 1);
                        pkg.SaveAs(new FileInfo(sfd.FileName));
                    }

                    if (UiHelper.Confirm("Xuất Excel thành công!\nBạn có muốn mở file ngay không?"))
                        Process.Start(sfd.FileName);
                }
                catch (IOException)
                {
                    UiHelper.Error("Không ghi được file. Hãy đóng file Excel đang mở (nếu có) rồi thử lại.");
                }
                catch (Exception ex)
                {
                    UiHelper.Error("Lỗi khi xuất Excel: " + ex.Message);
                }
            }
        }

        // ====================== NHẬP EXCEL ======================

        /// <summary>Hộp thoại chọn file .xlsx, đọc sheet đầu tiên từ dòng 2 (dòng 1 là tiêu đề). Trả về null nếu hủy/lỗi.</summary>
        public static List<ExcelRow> DocFile(string tieuDeHopThoai, int soCot)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Title = tieuDeHopThoai;
                ofd.Filter = "Excel Workbook (*.xlsx)|*.xlsx";
                if (ofd.ShowDialog() != DialogResult.OK) return null;

                try
                {
                    var ds = new List<ExcelRow>();
                    using (var fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                    using (var pkg = new ExcelPackage(fs))
                    {
                        if (pkg.Workbook.Worksheets.Count == 0)
                        { UiHelper.Warn("File Excel không có sheet nào."); return null; }
                        var ws = pkg.Workbook.Worksheets.First();
                        if (ws.Dimension == null)
                        { UiHelper.Warn("Sheet đầu tiên đang trống."); return null; }

                        int cuoi = ws.Dimension.End.Row;
                        for (int r = 2; r <= cuoi; r++)
                        {
                            var cells = new object[soCot];
                            bool coDuLieu = false;
                            for (int c = 0; c < soCot; c++)
                            {
                                object v = ws.Cells[r, c + 1].Value;
                                if (v is string && string.IsNullOrWhiteSpace((string)v)) v = null;
                                if (v != null) coDuLieu = true;
                                cells[c] = v;
                            }
                            if (coDuLieu) ds.Add(new ExcelRow { Row = r, Cells = cells });
                        }
                    }
                    if (ds.Count == 0)
                    { UiHelper.Warn("Không có dòng dữ liệu nào (dữ liệu bắt đầu từ dòng 2)."); return null; }
                    return ds;
                }
                catch (IOException)
                {
                    UiHelper.Error("Không đọc được file. Hãy đóng file trong Excel rồi thử lại.");
                    return null;
                }
                catch (Exception ex)
                {
                    UiHelper.Error("File không đúng định dạng .xlsx: " + ex.Message);
                    return null;
                }
            }
        }

        /// <summary>Tạo file Excel mẫu (tiêu đề cột + vài dòng ví dụ) cho người dùng điền rồi nhập lại.</summary>
        public static void TaoFileMau(string tenFile, string tieuDe, string[] cot, object[][] viDu, string ghiChu)
        {
            using (var sfd = new SaveFileDialog())
            {
                sfd.Title = "Lưu file mẫu";
                sfd.Filter = "Excel Workbook (*.xlsx)|*.xlsx";
                sfd.FileName = tenFile + ".xlsx";
                if (sfd.ShowDialog() != DialogResult.OK) return;
                try
                {
                    using (var pkg = new ExcelPackage())
                    {
                        var ws = pkg.Workbook.Worksheets.Add(tieuDe);
                        for (int c = 0; c < cot.Length; c++) ws.Cells[1, c + 1].Value = cot[c];
                        using (var rng = ws.Cells[1, 1, 1, cot.Length])
                        {
                            rng.Style.Font.Bold = true;
                            rng.Style.Font.Color.SetColor(Color.White);
                            rng.Style.Fill.PatternType = ExcelFillStyle.Solid;
                            rng.Style.Fill.BackgroundColor.SetColor(UiTheme.Primary);
                        }
                        for (int r = 0; r < viDu.Length; r++)
                            for (int c = 0; c < viDu[r].Length; c++)
                                ws.Cells[r + 2, c + 1].Value = viDu[r][c];
                        ws.Cells[viDu.Length + 4, 1].Value = ghiChu;
                        ws.Cells[viDu.Length + 4, 1].Style.Font.Italic = true;
                        ws.Cells[1, 1, viDu.Length + 2, cot.Length].AutoFitColumns();
                        pkg.SaveAs(new FileInfo(sfd.FileName));
                    }
                    if (UiHelper.Confirm("Đã tạo file mẫu.\nBạn có muốn mở file ngay không?"))
                        Process.Start(sfd.FileName);
                }
                catch (IOException) { UiHelper.Error("Không ghi được file. Hãy đóng file Excel đang mở rồi thử lại."); }
                catch (Exception ex) { UiHelper.Error("Lỗi khi tạo file mẫu: " + ex.Message); }
            }
        }

        // ---- đọc giá trị ô ----
        public static string Chuoi(object v)
        {
            if (v == null) return null;
            if (v is double && ((double)v) == Math.Floor((double)v)) return ((double)v).ToString("0");  // 123.0 -> "123"
            string s = Convert.ToString(v, System.Globalization.CultureInfo.InvariantCulture).Trim();
            return s.Length == 0 ? null : s;
        }

        public static bool TryDecimal(object v, out decimal kq)
        {
            kq = 0;
            if (v == null) return false;
            if (v is double) { kq = Convert.ToDecimal((double)v); return true; }
            string s = Convert.ToString(v, System.Globalization.CultureInfo.InvariantCulture).Trim()
                              .Replace(" ", "").Replace(",", "");
            return decimal.TryParse(s, System.Globalization.NumberStyles.Number,
                                    System.Globalization.CultureInfo.InvariantCulture, out kq);
        }
    }
}
