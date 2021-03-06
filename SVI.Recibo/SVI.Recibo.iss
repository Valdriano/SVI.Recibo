; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "SVI Recibo"
#define MyAppVersion "1.0.0.3"
#define MyAppPublisher "Empresa de desenvolvimento de Software"
;#define MyAppURL "https://valdriano.github.io/"
#define MyAppURL "https:google.com.br"
#define MyAppExeName "SVI.Recibo.exe"

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{D0D8E8A3-76B1-4473-B5B8-BCE2887A6833}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={pf}\{#MyAppName}
DisableProgramGroupPage=yes
OutputDir=C:\Users\VALDRIANO\source\repos\SVI.Recibo\Output
OutputBaseFilename=setup
;SetupIconFile=C:\Users\VALDRIANO\Desktop\favicon.ico
Compression=lzma
SolidCompression=yes

[Languages]
Name: "brazilianportuguese"; MessagesFile: "compiler:Languages\BrazilianPortuguese.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
;Source: "C:\Program Files (x86)\Inno Setup 5\Examples\MyProg.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\VALDRIANO\source\repos\SVI.Recibo\SVI.Recibo\bin\Debug\EntityFramework.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\VALDRIANO\source\repos\SVI.Recibo\SVI.Recibo\bin\Debug\EntityFramework.SqlServer.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\VALDRIANO\source\repos\SVI.Recibo\SVI.Recibo\bin\Debug\EntityFramework.SqlServer.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\VALDRIANO\source\repos\SVI.Recibo\SVI.Recibo\bin\Debug\EntityFramework.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\VALDRIANO\source\repos\SVI.Recibo\SVI.Recibo\bin\Debug\EnvDTE.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\VALDRIANO\source\repos\SVI.Recibo\SVI.Recibo\bin\Debug\EnvDTE80.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\VALDRIANO\source\repos\SVI.Recibo\SVI.Recibo\bin\Debug\Microsoft.Build.Framework.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\VALDRIANO\source\repos\SVI.Recibo\SVI.Recibo\bin\Debug\Microsoft.Build.Tasks.Core.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\VALDRIANO\source\repos\SVI.Recibo\SVI.Recibo\bin\Debug\Microsoft.Build.Utilities.Core.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\VALDRIANO\source\repos\SVI.Recibo\SVI.Recibo\bin\Debug\Microsoft.MSXML.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\VALDRIANO\source\repos\SVI.Recibo\SVI.Recibo\bin\Debug\Microsoft.ReportViewer.Common.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\VALDRIANO\source\repos\SVI.Recibo\SVI.Recibo\bin\Debug\Microsoft.ReportViewer.DataVisualization.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\VALDRIANO\source\repos\SVI.Recibo\SVI.Recibo\bin\Debug\Microsoft.ReportViewer.Design.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\VALDRIANO\source\repos\SVI.Recibo\SVI.Recibo\bin\Debug\Microsoft.ReportViewer.ProcessingObjectModel.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\VALDRIANO\source\repos\SVI.Recibo\SVI.Recibo\bin\Debug\Microsoft.ReportViewer.WinForms.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\VALDRIANO\source\repos\SVI.Recibo\SVI.Recibo\bin\Debug\Microsoft.SqlServer.Types.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\VALDRIANO\source\repos\SVI.Recibo\SVI.Recibo\bin\Debug\Microsoft.VisualStudio.ComponentModelHost.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\VALDRIANO\source\repos\SVI.Recibo\SVI.Recibo\bin\Debug\Microsoft.VisualStudio.Data.Core.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\VALDRIANO\source\repos\SVI.Recibo\SVI.Recibo\bin\Debug\Microsoft.VisualStudio.Data.Services.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\VALDRIANO\source\repos\SVI.Recibo\SVI.Recibo\bin\Debug\Microsoft.VisualStudio.Debugger.Interop.11.0.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\VALDRIANO\source\repos\SVI.Recibo\SVI.Recibo\bin\Debug\Microsoft.VisualStudio.Debugger.InteropA.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\VALDRIANO\source\repos\SVI.Recibo\SVI.Recibo\bin\Debug\Microsoft.VisualStudio.GraphModel.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\VALDRIANO\source\repos\SVI.Recibo\SVI.Recibo\bin\Debug\Microsoft.VisualStudio.ManagedInterfaces.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\VALDRIANO\source\repos\SVI.Recibo\SVI.Recibo\bin\Debug\Microsoft.VisualStudio.OLE.Interop.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\VALDRIANO\source\repos\SVI.Recibo\SVI.Recibo\bin\Debug\Microsoft.VisualStudio.ProjectAggregator.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\VALDRIANO\source\repos\SVI.Recibo\SVI.Recibo\bin\Debug\Microsoft.VisualStudio.Shell.Interop.10.0.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\VALDRIANO\source\repos\SVI.Recibo\SVI.Recibo\bin\Debug\Microsoft.VisualStudio.Shell.Interop.11.0.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\VALDRIANO\source\repos\SVI.Recibo\SVI.Recibo\bin\Debug\Microsoft.VisualStudio.Shell.Interop.8.0.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\VALDRIANO\source\repos\SVI.Recibo\SVI.Recibo\bin\Debug\Microsoft.VisualStudio.Shell.Interop.9.0.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\VALDRIANO\source\repos\SVI.Recibo\SVI.Recibo\bin\Debug\Microsoft.VisualStudio.Shell.Interop.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\VALDRIANO\source\repos\SVI.Recibo\SVI.Recibo\bin\Debug\Microsoft.VisualStudio.TemplateWizardInterface.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\VALDRIANO\source\repos\SVI.Recibo\SVI.Recibo\bin\Debug\Microsoft.VisualStudio.TemplateWizardInterface.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\VALDRIANO\source\repos\SVI.Recibo\SVI.Recibo\bin\Debug\Microsoft.VisualStudio.TextManager.Interop.10.0.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\VALDRIANO\source\repos\SVI.Recibo\SVI.Recibo\bin\Debug\Microsoft.VisualStudio.TextManager.Interop.8.0.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\VALDRIANO\source\repos\SVI.Recibo\SVI.Recibo\bin\Debug\Microsoft.VisualStudio.TextManager.Interop.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\VALDRIANO\source\repos\SVI.Recibo\SVI.Recibo\bin\Debug\Microsoft.VisualStudio.VSHelp.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\VALDRIANO\source\repos\SVI.Recibo\SVI.Recibo\bin\Debug\Microsoft.VisualStudio.WCFReference.Interop.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\VALDRIANO\source\repos\SVI.Recibo\SVI.Recibo\bin\Debug\Newtonsoft.Json.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\VALDRIANO\source\repos\SVI.Recibo\SVI.Recibo\bin\Debug\stdole.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\VALDRIANO\source\repos\SVI.Recibo\SVI.Recibo\bin\Debug\SVI.Recibo.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\VALDRIANO\source\repos\SVI.Recibo\SVI.Recibo\bin\Debug\SVI.Recibo.exe.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\VALDRIANO\source\repos\SVI.Recibo\SVI.Recibo\bin\Debug\SVI.Recibo.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\VALDRIANO\source\repos\SVI.Recibo\SVI.Recibo\bin\Debug\VSLangProj.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\VALDRIANO\source\repos\SVI.Recibo\SVI.Recibo\bin\Debug\VSLangProj2.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\VALDRIANO\source\repos\SVI.Recibo\SVI.Recibo\bin\Debug\VSLangProj80.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\VALDRIANO\source\repos\SVI.Recibo\SVI.Recibo\bin\Debug\WPFToolkit.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\VALDRIANO\source\repos\SVI.Recibo\SVI.Recibo\bin\Debug\Xceed.Wpf.Toolkit.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\VALDRIANO\source\repos\SVI.Recibo\SVI.Recibo\bin\Debug\de\*"; DestDir: "{app}\de"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "C:\Users\VALDRIANO\source\repos\SVI.Recibo\SVI.Recibo\bin\Debug\es\*"; DestDir: "{app}\es"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "C:\Users\VALDRIANO\source\repos\SVI.Recibo\SVI.Recibo\bin\Debug\fr\*"; DestDir: "{app}\fr"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "C:\Users\VALDRIANO\source\repos\SVI.Recibo\SVI.Recibo\bin\Debug\it\*"; DestDir: "{app}\it"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "C:\Users\VALDRIANO\source\repos\SVI.Recibo\SVI.Recibo\bin\Debug\ja\*"; DestDir: "{app}\ja"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "C:\Users\VALDRIANO\source\repos\SVI.Recibo\SVI.Recibo\bin\Debug\ko\*"; DestDir: "{app}\ko"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "C:\Users\VALDRIANO\source\repos\SVI.Recibo\SVI.Recibo\bin\Debug\pt\*"; DestDir: "{app}\pt"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "C:\Users\VALDRIANO\source\repos\SVI.Recibo\SVI.Recibo\bin\Debug\pt-BR\*"; DestDir: "{app}\pt-BR"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "C:\Users\VALDRIANO\source\repos\SVI.Recibo\SVI.Recibo\bin\Debug\ru\*"; DestDir: "{app}\ru"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "C:\Users\VALDRIANO\source\repos\SVI.Recibo\SVI.Recibo\bin\Debug\SqlServerTypes\*"; DestDir: "{app}\SqlServerTypes"; Flags: ignoreversion recursesubdirs createallsubdirs
;Source: "C:\Users\VALDRIANO\source\repos\SVI.Recibo\SVI.Recibo\bin\Debug\SqlServerTypes\x86\*"; DestDir: "{app}\x86"; Flags: ignoreversion recursesubdirs createallsubdirs
;Source: "C:\Users\VALDRIANO\source\repos\SVI.Recibo\SVI.Recibo\bin\Debug\SqlServerTypes\x64\*"; DestDir: "{app}\x64"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "C:\Users\VALDRIANO\source\repos\SVI.Recibo\SVI.Recibo\bin\Debug\zh-CHS\*"; DestDir: "{app}\zh-CHS"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "C:\Users\VALDRIANO\source\repos\SVI.Recibo\SVI.Recibo\bin\Debug\zh-CHT\*"; DestDir: "{app}\zh-CHT"; Flags: ignoreversion recursesubdirs createallsubdirs
;Source: "C:\Users\VALDRIANO\source\repos\SVI.Recibo\SVI.Recibo\bin\Debug\App_Data\*"; DestDir: "{app}\App_Data"; Flags: ignoreversion recursesubdirs createallsubdirs
;Source: "C:\Program Files\Microsoft SQL Server\120\Tools\Binn\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

;Icone padr�o SVI RECIBO
Source: "C:\Users\VALDRIANO\source\repos\SVI.Recibo\SVI.Recibo\bin\Debug\favicon.ico"; DestDir: {app}; Flags: ignoreversion

[Icons]
Name: "{commonprograms}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{commondesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent
