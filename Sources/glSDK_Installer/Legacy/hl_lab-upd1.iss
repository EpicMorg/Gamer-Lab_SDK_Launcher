; 
; Created By STAM (c) 2014; EpicMorg Dev.
;
; OH! my fucking bugs..
; *************************************************************************************
; Tis file is distributed under MIT license:
; *************************************************************************************
; The MIT License (MIT)
; 
; Copyright © 2013-2014 EpicMorg
; 
; Permission is hereby granted, free of charge, to any person obtaining a copy
; of this software and associated documentation files (the ''Software''), to deal
; in the Software without restriction, including without limitation the rights
; to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
; copies of the Software, and to permit persons to whom the Software is
; furnished to do so, subject to the following conditions:

; The above copyright notice and this permission notice shall be included in
; all copies or substantial portions of the Software.

; THE SOFTWARE IS PROVIDED ''AS IS'', WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
; IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
; FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
; AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
; LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
; OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
; THE SOFTWARE.", @"The MIT License (MIT)
; *************************************************************************************
; 

[Setup]
AppId={{458A532B-AAC6-48F0-AEA6-311BC67A8167}
SourceDir=.
OutputDir=Setup_hllab
OutputBaseFilename=update
DefaultDirName={pf}\Hl-Lab\
;-------------
AppName=GoldSource SDK [Minor Update 1]
AppVerName=GoldSource SDK [Minor Update 1]
DefaultGroupName=GoldSource SDK
VersionInfoDescription=GoldSource SDK [Minor Update 1]
VersionInfoProductTextVersion=GoldSource SDK [Minor Update 1]
VersionInfoProductName=GoldSource SDK [Minor Update 1]
;-------------
AppPublisher=EpicMorg & Hl-Lab.ru
AppCopyright=STAM, Hl-Lab.ru 
VersionInfoCompany=EpicMorg & Hl-Lab.ru
VersionInfoCopyright=STAM, Hl-Lab.ru
;-------------
AppVersion=1.1.0.0
VersionInfoVersion=1.1.0.0
VersionInfoProductVersion=1.1.0.0
VersionInfoTextVersion=1.1.0.0
;-------------
AppPublisherURL=http://ww.epicm.org/
AppSupportURL=http://ww.epicm.org/
AppUpdatesURL=http://ww.epicm.org/
;-------------
AllowNoIcons=yes
;InfoBeforeFile=B:\Repack\Sources\programs\hl-lab\release_info.rtf         отключил, тк это инфо о релизе нельзя локализовать. точнее можно, и так это и сделано.
WizardImageFile=B:\Repack\Sources\programs\hl-lab\WizModernImage.bmp
WizardSmallImageFile=B:\Repack\Sources\programs\hl-lab\WizModernSmallImage.bmp
SetupIconFile=B:\Repack\Sources\programs\hl-lab\sdk-000.ico
;WindowVisible=no
;WindowShowCaption=no
;WindowResizable=no
;DiskSpanning=yes
;DiskSliceSize=700000000
;SlicesPerDisk=1
;Encryption=True 
ShowTasksTreeLines=True
AppComments=[Minor Update 1]
UserInfoPage=True 
;InternalCompressLevel=none
;SolidCompression=True
;Compression=zip/1
Compression=lzma2/ultra64
InternalCompressLevel=ultra
RestartIfNeededByRun=False
EnableDirDoesntExistWarning=True
Uninstallable=no

[Languages]
Name: "russian"; MessagesFile: "compiler:Languages\Russian.isl"; InfoBeforeFile: "B:\Repack\Sources\programs\hl-lab\minor_update1_ru.rtf"
Name: "english"; MessagesFile: "compiler:Default.isl"; InfoBeforeFile: "B:\Repack\Sources\programs\hl-lab\minor_update1_en.rtf"
;Name: "es"; MessagesFile: "compiler:Languages\Spanish.isl"; LicenseFile: "B:\Repack\Sources\programs\hl-lab\license_en.rtf"; InfoBeforeFile: "B:\Repack\Sources\programs\hl-lab\release_info_en.rtf"
;Name: "by"; MessagesFile: "compiler:Languages\Belarusian.isl"; LicenseFile: "B:\Repack\Sources\programs\hl-lab\license_en.rtf"; InfoBeforeFile: "B:\Repack\Sources\programs\hl-lab\release_info_ru.rtf"

[Messages]
;Надпись которая будет на разделительной линии
BeveledLabel=Hl-Lab.ru © 2014

 
[Types]
;Name: "Update1"; Description: "Полная установка, для модостроителей"
Name: "Update1"; Description: "Промежуточное обновление 1 + Новые компоненты"; Languages: russian 
Name: "Update1"; Description: "Minor Update 1 + New Feachures"; Languages: english

Name: "Base"; Description: "Промежуточное обновление 1"; Languages: russian 
Name: "Base"; Description: "Minor Update 1"; Languages: english 

;перевод этого элемента идет кодом
Name: "Custom"; Description: "Custom Installation"; Flags: iscustom 

[Components]
Name: "Launcher"; Description: "Меню запуска программ"; Types: Base Custom Update1; Flags: fixed; Languages: russian
Name: "Launcher"; Description: "Required Components:"; Types: Base Custom Update1; Flags: fixed; Languages: english
Name: "Launcher\starter"; Description: "Launcher 1.5.0.0 (New)"; Types: Base Custom Update1; Flags: fixed
Name: "additional"; Description: "Дополнительно:"; Types: Base Custom Update1; Flags: fixed; Languages: russian
Name: "additional"; Description: "Addons:"; Types: Base Custom Update1; Flags: fixed; Languages: english 
Name: "additional\editors"; Description: "Редакторы:"; Types: Base Custom Update1; Flags: fixed; Languages: russian
Name: "additional\editors"; Description: "Editors:"; Types: Base Custom Update1; Flags: fixed; Languages: english
Name: "additional\editors\neo"; Description: "Neo Hammer Editor 3.5.1 (Update)"; Types: Update1 Custom Base
Name: "additional\editors\Sledge"; Description: "Sledge Editor 0.1.0.24 (Update)"; Types: Update1 Custom Base
Name: "additional\editors\Jackhammer"; Description: "Jackhammer 1.0.155 (New)"; Types: Update1  

[Files]  
;-------always----
;-launcher---
Source: "B:\Repack\Sources\files\HL-LAB-SDK-update1\launcher\*"; DestDir: "{app}\Launcher"; Flags: ignoreversion recursesubdirs createallsubdirs sortfilesbyextension; Components: Launcher\starter
;-base sdk---
;Source: "B:\Repack\Sources\files\HL-LAB-SDK-update1\dist\*"; DestDir: "{app}\SDK"; Flags: ignoreversion recursesubdirs createallsubdirs sortfilesbyextension; Components: gSDK\sdk
;------/always----
;---additional----
;-edotors- 
Source: "B:\Repack\Sources\files\HL-LAB-SDK-update1\hammer\neo\neo.exe"; DestDir: "{app}\SDK\"; Flags: ignoreversion recursesubdirs createallsubdirs sortfilesbyextension; Components: additional\editors\neo
Source: "B:\Repack\Sources\files\HL-LAB-SDK-update1\addons\Sledge\*"; DestDir: "{app}\SDK\addons\Sledge\"; Flags: ignoreversion recursesubdirs createallsubdirs sortfilesbyextension; Components: additional\editors\Sledge
Source: "B:\Repack\Sources\files\HL-LAB-SDK-update1\addons\Jackhammer\*"; DestDir: "{app}\SDK\addons\Jackhammer\"; Flags: ignoreversion recursesubdirs createallsubdirs sortfilesbyextension; Components: additional\editors\Jackhammer
 
 

[Run]
;Filename: "{app}\launcher\gSDK_Launcher.exe"; WorkingDir: "{app}\launcher\"; Flags: nowait postinstall skipifsilent unchecked; Description: "{cm:LaunchProgram, GoldSrc SDK}"; Components: Launcher\starter
Filename: "{app}\launcher\gSDK_Launcher.exe"; Parameters: "--refresh"; Flags: postinstall shellexec; Description: "Обновить конфигурацию"; Languages: russian
Filename: "{app}\launcher\gSDK_Launcher.exe"; Parameters: "--refresh"; Flags: postinstall shellexec; Description: "Update config"; Languages: english 

[UninstallDelete]
Type: filesandordirs; Name: "{app}"
 
[Dirs]
Name: "{app}\SDK"
Name: "{app}\Launcher"

 

;[Registry]
;-rad---
;Root: HKCR; SubKey: ".rad"; ValueType: string; ValueData: "rad"; Flags: uninsdeletekey
;Root: HKCR; SubKey: "rad"; ValueType: string; ValueData: "Rad file"; Flags: uninsdeletekey
;Root: HKCR; SubKey: "rad\Shell\Open\Command"; ValueType: string; ValueData: """notepad.exe"" ""%1"""; Flags: uninsdeletekey
;Root: HKCR; Subkey: "rad\DefaultIcon"; ValueType: string; ValueData: "{app}\launcher\icons\rad.ico,0"; Flags: uninsdeletevalue
;-wc---
;Root: HKCR; SubKey: ".wc"; ValueType: string; ValueData: "rad"; Flags: uninsdeletekey
;Root: HKCR; SubKey: "wc"; ValueType: string; ValueData: "Wc file"; Flags: uninsdeletekey
;Root: HKCR; SubKey: "wc\Shell\Open\Command"; ValueType: string; ValueData: """notepad.exe"" ""%1"""; Flags: uninsdeletekey
;Root: HKCR; Subkey: "wc\DefaultIcon"; ValueType: string; ValueData: "{app}\launcher\icons\wc.ico,0"; Flags: uninsdeletevalue

[Code]
  //hack of custom selected
procedure CurPageChanged(CurPageID: Integer);
var
  OptionsPage: TWizardPage;
  PageSurface: TNewNotebookPage;
  SetupTypesCombo: TComboBox;
begin
   if (CurPageID = wpSelectComponents) and (ActiveLanguage() = 'russian') then
  begin
    OptionsPage := PageFromID(CurPageID);
    PageSurface := OptionsPage.Surface;
    SetupTypesCombo := TComboBox(PageSurface.Controls[2]);
    if (SetupTypesCombo <> nil) then
    begin
      if (SetupTypesCombo.Items[2] <> 'Выборочная установка') then
      begin
        SetupTypesCombo.Items[2] := 'Выборочная установка';
      end;
    end;
  end;

    if (CurPageID = wpSelectComponents) and (ActiveLanguage() = 'english') then
  begin
    OptionsPage := PageFromID(CurPageID);
    PageSurface := OptionsPage.Surface;
    SetupTypesCombo := TComboBox(PageSurface.Controls[2]);
    if (SetupTypesCombo <> nil) then
    begin
      if (SetupTypesCombo.Items[2] <> 'Custom install') then
      begin
        SetupTypesCombo.Items[2] := 'Custom install';
      end;
    end;
  end;
  end;