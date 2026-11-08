#define MyAppName "Quan Ly Cua Hang Sach"
#define MyAppVersion "1.0"
#define MyAppPublisher "Nhom Bookstore"
#define MyAppExeName "WindowsFormsApp2.exe"  

[Setup]
AppId={{120B781D-59C7-4E54-9692-E5C906F6B3D9}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
AppPublisher={#MyAppPublisher}
DefaultDirName={autopf}\{#MyAppName}
DisableProgramGroupPage=yes
UninstallDisplayIcon={app}\bookstore.ico
OutputDir=..\DEVUP_Setup
OutputBaseFilename=QuanLySach_Setup
SolidCompression=yes
WizardStyle=modern
SetupIconFile=bookstore.ico

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"

[Files]
; Duong dan tuong doi so voi thu muc chua file .iss
Source: "bin\Release\*"; DestDir: "{app}"; Excludes: "*.pdb,*.vshost.*,*.xml"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "bookstore.ico"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\Database_QuanLyNhaSach\*.sql"; DestDir: "{app}\SQL"; Flags: ignoreversion

[Dirs]
; Cho phep app ghi App.config / du lieu trong thu muc cai dat
Name: "{app}"; Permissions: users-modify

[Icons]
Name: "{autoprograms}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; IconFilename: "{app}\bookstore.ico"
Name: "{autodesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; IconFilename: "{app}\bookstore.ico"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent