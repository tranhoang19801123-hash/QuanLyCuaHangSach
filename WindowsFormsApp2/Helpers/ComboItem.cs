namespace WindowsFormsApp2.Helpers
{
    /// <summary>Phần tử dùng chung cho ComboBox (Value = mã, Text = nội dung hiển thị).</summary>
    public class ComboItem
    {
        public string Value { get; set; }
        public string Text { get; set; }
        public override string ToString() { return Text; }
    }
}
