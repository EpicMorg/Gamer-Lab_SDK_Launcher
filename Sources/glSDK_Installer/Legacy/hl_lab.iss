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
OutputBaseFilename=setup 
DefaultDirName={pf}\Hl-Lab\
;-------------
AppName=GoldSource SDK
AppVerName=GoldSource SDK
DefaultGroupName=GoldSource SDK
VersionInfoDescription=GoldSource SDK
VersionInfoProductTextVersion=GoldSource SDK
VersionInfoProductName=GoldSource SDK
;-------------
AppPublisher=EpicMorg & Hl-Lab.ru
AppCopyright=STAM, Hl-Lab.ru 
VersionInfoCompany=EpicMorg & Hl-Lab.ru
VersionInfoCopyright=STAM, Hl-Lab.ru
;-------------
AppVersion=1.0.0.2
VersionInfoVersion=1.0.0.2
VersionInfoProductVersion=1.0.0.2
VersionInfoTextVersion=1.0.0.2
;-------------
AppPublisherURL=http://ww.epicm.org/
AppSupportURL=http://ww.epicm.org/
AppUpdatesURL=http://ww.epicm.org/
;-------------
AllowNoIcons=yes
;InfoBeforeFile=C:\Sources\programs\hl-lab\release_info.rtf         отключил, тк это инфо о релизе нельзя локализовать. точнее можно, и так это и сделано.
WizardImageFile=C:\Sources\programs\hl-lab\WizModernImage.bmp
WizardSmallImageFile=C:\Sources\programs\hl-lab\WizModernSmallImage.bmp
SetupIconFile=C:\Sources\programs\hl-lab\sdk-000.ico
;WindowVisible=no
;WindowShowCaption=no
;WindowResizable=no
;DiskSpanning=yes
;DiskSliceSize=700000000
;SlicesPerDisk=1
;Encryption=True 
ShowTasksTreeLines=True
AppComments=RC Version
UserInfoPage=True 
UsePreviousSetupType=False
UsePreviousTasks=False
UsePreviousLanguage=False
;InternalCompressLevel=none
;SolidCompression=True
;Compression=zip/1
Compression=lzma2/ultra64
InternalCompressLevel=ultra
RestartIfNeededByRun=False
EnableDirDoesntExistWarning=True

[Languages]
Name: "russian"; MessagesFile: "compiler:Languages\Russian.isl"; LicenseFile: "C:\Sources\programs\hl-lab\license_en.rtf"; InfoBeforeFile: "C:\Sources\programs\hl-lab\release_info_ru.rtf"
Name: "english"; MessagesFile: "compiler:Default.isl"; LicenseFile: "C:\Sources\programs\hl-lab\license_en.rtf"; InfoBeforeFile: "C:\Sources\programs\hl-lab\release_info_en.rtf"
Name: "es"; MessagesFile: "compiler:Languages\Spanish.isl"; LicenseFile: "C:\Sources\programs\hl-lab\license_en.rtf"; InfoBeforeFile: "C:\Sources\programs\hl-lab\release_info_en.rtf"
Name: "by"; MessagesFile: "compiler:Languages\Belarusian.isl"; LicenseFile: "C:\Sources\programs\hl-lab\license_en.rtf"; InfoBeforeFile: "C:\Sources\programs\hl-lab\release_info_ru.rtf"

[Messages]
;Надпись которая будет на разделительной линии
BeveledLabel=Hl-Lab.ru © 2014

[CustomMessages] 
russian.otherGroup=Прочее:
russian.hour= часов
russian.min= мин
russian.sec= сек
russian.waitabout=Примерно осталось:
russian.waitplease=Завершение...
russian.hdprotect=Нельзя писать в корень системного диска!
;---
english.otherGroup=Misc:
english.hour= hours
english.min= min
english.sec= sec
english.waitabout=Please wait about:
english.waitplease=Please wait...
english.hdprotect=Please, select another path to install!
;---
es.otherGroup=Otros: 
es.hour= horas
es.min= min
es.sec= s
es.waitabout=Aproximadamente la izquierda:
es.waitplease=Finalización...
es.hdprotect=No escriba a la raíz de la unidad del sistema!
;---
by.otherGroup=Іншае: 
by.hour= гадзін 
by.min= мін 
by.sec= сек
by.waitabout=Прыкладна засталос:
by.waitplease=Завяршэнне...
by.hdprotect=Нельга пісаць у корань сістэмнага дыска!
;---

[Types]
;Name: "Fullest"; Description: "Полная установка, для модостроителей"
Name: "Fullest"; Description: "Максимально-полная установка"; Languages: russian by
Name: "Fullest"; Description: "Ultimate Installation"; Languages: english
Name: "Fullest"; Description: "Máxima de instalación completa "; Languages: es

Name: "Full"; Description: "Полная установка"; Languages: russian by
Name: "Full"; Description: "Full Installation"; Languages: english
Name: "Full"; Description: "Instalación completa "; Languages: es

Name: "Base"; Description: "Минимальная установка"; Languages: russian by
Name: "Base"; Description: "Compact Installation"; Languages: english
Name: "Base"; Description: "Mínimo"; Languages: es

;перевод этого элемента идет кодом
Name: "Custom"; Description: "Custom Installation"; Flags: iscustom 

[Components]
Name: "Launcher"; Description: "Меню запуска программ"; Types: Base Custom Full Fullest; Flags: fixed; Languages: russian by
Name: "Launcher"; Description: "Required Components:"; Types: Base Custom Full Fullest; Flags: fixed; Languages: english es
Name: "Launcher\starter"; Description: "Launcher (.Net 4.0 CP)"; Types: Base Custom Full Fullest; Flags: fixed
;--
Name: "gSDK"; Description: "GoldSource SDK"; Types: Base Custom Full Fullest; Flags: fixed
Name: "gSDK\sdk"; Description: "Valve Hammer Editor 3.5 (Base)"; Types: Base Custom Full Fullest; Flags: fixed
;--
Name: "additional"; Description: "Дополнительно:"; Types: Custom Full Fullest; Languages: russian by
Name: "additional"; Description: "Addons:"; Types: Custom Full Fullest; Languages: english es
;--
Name: "additional\editors"; Description: "Редакторы:"; Types: Custom Full Fullest; Languages: russian by
Name: "additional\editors"; Description: "Editors:"; Types: Custom Full Fullest; Languages: english es
Name: "additional\editors\hammer34"; Description: "Valve Hammer Editor 3.4"; Types: Custom Full Fullest
Name: "additional\editors\wc"; Description: "Valve WorldCraft Editor 3.3"; Types: Custom Full Fullest
Name: "additional\editors\csm"; Description: "CSM Hammer Editor 3.5"; Types: Custom Full Fullest
Name: "additional\editors\neo"; Description: "Neo Hammer Editor 3.5"; Types: Custom Full Fullest
Name: "additional\editors\neon"; Description: "Neo Hammer Editor 3.5"; Types: Custom Full Fullest
Name: "additional\editors\neon\r"; Description: "Neo Hammer Editor 3.5 rus"; Types: Custom Full Fullest
Name: "additional\editors\quark"; Description: "QuArK Editor"; Types: Custom Full Fullest
Name: "additional\editors\Sledge"; Description: "Sledge Editor"; Types: Custom Full Fullest
;--
Name: "additional\mapping"; Description: "Картостроение:"; Types: Custom Full Fullest; Languages: russian by
Name: "additional\mapping"; Description: "Mapping:"; Types: Custom Full Fullest; Languages: english es
Name: "additional\mapping\Automap"; Description: "Automap"; Types: Custom Full Fullest
Name: "additional\mapping\BSPViewer"; Description: "BSPViewer"; Types: Custom Full Fullest
Name: "additional\mapping\BSPTools"; Description: "BSP Tools"; Types: Custom Full Fullest
Name: "additional\mapping\LeakMarker"; Description: "Leak Marker"; Types: Custom Full Fullest
Name: "additional\mapping\RESGen"; Description: "RES Gen"; Types: Custom Full Fullest
Name: "additional\mapping\RandMap"; Description: "RandMap"; Types: Custom Full Fullest
Name: "additional\mapping\MAPViewer"; Description: "MAPViewer"; Types: Custom Full Fullest
Name: "additional\mapping\Crafty"; Description: "Crafty (Object Viewer)"; Types: Custom Full Fullest
Name: "additional\mapping\GENSURF"; Description: "GENSURF"; Types: Custom Full Fullest
Name: "additional\mapping\TerrainGenerator"; Description: "Terrain Generator"; Types: Custom Full Fullest
Name: "additional\mapping\TBLux"; Description: "Tool Box Lux"; Types: Custom Full Fullest
;--
Name: "additional\compdecomp"; Description: "Компиляция и Декомпиляция:"; Types: Custom Full Fullest; Languages: russian by
Name: "additional\compdecomp"; Description: "Compilation & Decompilation:"; Types: Custom Full Fullest; Languages: english es
Name: "additional\compdecomp\bcomp"; Description: "Batch Compiler"; Types: Custom Full Fullest
Name: "additional\compdecomp\GUIRipnet"; Description: "GUIRipnet"; Types: Custom Full Fullest
Name: "additional\compdecomp\UCompiler"; Description: "UCompiler"; Types: Custom Full Fullest
Name: "additional\compdecomp\BSPTwoMap"; Description: "BSPTwoMap"; Types: Custom Full Fullest
Name: "additional\compdecomp\BSP_MAP"; Description: "BSP_MAP"; Types: Custom Full Fullest
Name: "additional\compdecomp\winbspc"; Description: "Winbspc"; Types: Custom Full Fullest
;--
Name: "additional\cnt_mgr"; Description: "Работа с контентом:"; Types: Custom Full Fullest; Languages: russian by
Name: "additional\cnt_mgr"; Description: "Content managment:"; Types: Custom Full Fullest; Languages: english es
Name: "additional\cnt_mgr\PakExpl"; Description: "PakExpl"; Types: Custom Full Fullest
Name: "additional\cnt_mgr\PakScape"; Description: "PakScape"; Types: Custom Full Fullest
Name: "additional\cnt_mgr\bsp2zip"; Description: "Bsp2Zip or 17Ims"; Types: Custom Full Fullest
Name: "additional\cnt_mgr\GameCfgManager"; Description: "GameCfgManager"; Types: Base Custom Full Fullest; Flags: fixed
;--
Name: "additional\mdl"; Description: "Моделирование:"; Types: Custom Full Fullest; Languages: russian by
Name: "additional\mdl"; Description: "Modeling:"; Types: Custom Full Fullest; Languages: english es
Name: "additional\mdl\hmdl"; Description: "Jed's HL model Viever 1.36"; Types: Custom Full Fullest
Name: "additional\mdl\guistudiomdl"; Description: "GUI studiomdl"; Types: Custom Full Fullest
;--
Name: "additional\texture"; Description: "Работа с текстурами и спрайтами:"; Types: Custom Full Fullest; Languages: russian by
Name: "additional\texture"; Description: "Texturing & Spriting:"; Types: Custom Full Fullest; Languages: english es
Name: "additional\texture\Autoscr"; Description: "Auto Seamer"; Types: Custom Full Fullest
Name: "additional\texture\OrbitalTexTiler"; Description: "Orbital TexTiler"; Types: Custom Full Fullest
Name: "additional\texture\QLumpy"; Description: "QLumpy"; Types: Custom Full Fullest
Name: "additional\texture\SPRAttrib"; Description: "SPRAttrib"; Types: Custom Full Fullest
Name: "additional\texture\SprExplorer"; Description: "SprExplorer"; Types: Custom Full Fullest
Name: "additional\texture\Wally"; Description: "Wally"; Types: Custom Full Fullest
Name: "additional\texture\TExtractSuite"; Description: "TExtract Suite"; Types: Custom Full Fullest
Name: "additional\texture\WinTextract"; Description: "Win Textract"; Types: Custom Full Fullest
;--
Name: "additional\help"; Description: "Справка, помощь, учебники:"; Types: Custom Full Fullest; Languages: russian by
Name: "additional\help"; Description: "Help, support, manuals:"; Types: Custom Full Fullest; Languages: english es
Name: "additional\help\h1"; Description: "C++"; Types: Custom Full Fullest
Name: "additional\help\h2"; Description: "Counter-Strike Mapping"; Types: Custom Full Fullest
Name: "additional\help\h3"; Description: "Dmitrich!"; Types: Custom Full Fullest
Name: "additional\help\h4"; Description: "HL-SDKT"; Types: Custom Full Fullest
Name: "additional\help\h5"; Description: "Mapping"; Types: Custom Full Fullest
Name: "additional\help\h6"; Description: "MilkShape3D"; Types: Custom Full Fullest
Name: "additional\help\h7"; Description: "RussianVHE"; Types: Custom Full Fullest
Name: "additional\help\h8"; Description: "Zhlt"; Types: Custom Full Fullest
;--
Name: "additional\mod"; Description: "Создание модов:"; Types: Custom Full Fullest; Languages: russian by
Name: "additional\mod"; Description: "Mod Making:"; Types: Custom Full Fullest; Languages: english es
Name: "additional\mod\Hlcsm"; Description: "Hlcsm sprite manager"; Types: Custom Full Fullest
Name: "additional\mod\HILogoGen"; Description: "HILogoGen"; Types: Custom Full Fullest
Name: "additional\mod\HLC"; Description: "HLC"; Types: Custom Full Fullest
Name: "additional\mod\Backchanger"; Description: "Backchanger"; Types: Custom Full Fullest
Name: "additional\mod\Sources"; Description: "Исходники:"; Types: Custom  Fullest
Name: "additional\mod\Sources\hl1"; Description: "Half-Life 1 Sources"; Types: Custom  Fullest
Name: "additional\mod\Sources\zhsrc"; Description: "Zonner's Compilers Src"; Types: Custom  Fullest
Name: "additional\mod\Sources\vlsrc"; Description: "Vluzacn's Compilers Src"; Types: Custom  Fullest
;--
Name: "additional\Compillers"; Description: "Альтернативные компиляторы:"; Types: Custom Full Fullest; Languages: russian by
Name: "additional\Compillers"; Description: "Another compilers:"; Types: Custom Full Fullest; Languages: english es
Name: "additional\Compillers\zsse1"; Description: "Zonner's x32 SSE"; Types: Custom Full Fullest
Name: "additional\Compillers\zsse2"; Description: "Zonner's x32 SSE2"; Types: Custom Full Fullest
Name: "additional\Compillers\zx64"; Description: "Zonner's x64"; Types: Custom Full Fullest
Name: "additional\Compillers\Vluzacn31"; Description: "Vluzacn x32 2014 v31"; Types: Custom Full Fullest

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"
Name: "fw"; Description: ".Net Framework 4.0 (Полная авт. установка)"; GroupDescription: "Дополнительно:"; Flags: unchecked; Languages: russian by
Name: "fw"; Description: ".Net Framework 4.0 (Full install)"; GroupDescription: "Дополнительно:"; Flags: unchecked; Languages: english es

[Files]
;------system-----
Source: "compiler:\innocallback.dll"; DestDir: "{tmp}"; Flags: dontcopy
Source: "C:\Sources\programs\hl-lab\dotNetFx40_Full_x86_x64.exe"; DestDir: "{tmp}\hllab\"; Tasks: fw
;Source: compiler:CallbackCtrl.dll; DestDir: {tmp}; Flags: dontcopy;
;-------always----
;-launcher---
Source: "C:\Sources\files\HL-LAB\launcher\*"; DestDir: "{app}\Launcher"; Flags: ignoreversion recursesubdirs createallsubdirs sortfilesbyextension; Components: Launcher\starter
;-base sdk---
Source: "C:\Sources\files\HL-LAB\dist\*"; DestDir: "{app}\SDK"; Flags: ignoreversion recursesubdirs createallsubdirs sortfilesbyextension; Components: gSDK\sdk
;------/always----
;---additional----
;-edotors-
Source: "C:\Sources\files\HL-LAB\hammer\34en\hammer34.exe"; DestDir: "{app}\SDK\"; Flags: ignoreversion recursesubdirs createallsubdirs sortfilesbyextension; Components: additional\editors\hammer34
Source: "C:\Sources\files\HL-LAB\hammer\wc\wc.exe"; DestDir: "{app}\SDK\"; Flags: ignoreversion recursesubdirs createallsubdirs sortfilesbyextension; Components: additional\editors\wc
Source: "C:\Sources\files\HL-LAB\hammer\wc\wc.chm"; DestDir: "{app}\SDK\"; Flags: ignoreversion recursesubdirs createallsubdirs sortfilesbyextension; Components: additional\editors\wc
Source: "C:\Sources\files\HL-LAB\hammer\wc\sierra.inf"; DestDir: "{app}\SDK\"; Flags: ignoreversion recursesubdirs createallsubdirs sortfilesbyextension; Components: additional\editors\wc
Source: "C:\Sources\files\HL-LAB\hammer\csm\editor.exe"; DestDir: "{app}\SDK\"; Flags: ignoreversion recursesubdirs createallsubdirs sortfilesbyextension; Components: additional\editors\csm
Source: "C:\Sources\files\HL-LAB\hammer\csm\CSMHE_Readme.txt"; DestDir: "{app}\SDK\"; Flags: ignoreversion recursesubdirs createallsubdirs sortfilesbyextension; Components: additional\editors\csm
Source: "C:\Sources\files\HL-LAB\hammer\csm\editor.wad"; DestDir: "{app}\SDK\"; Flags: ignoreversion recursesubdirs createallsubdirs sortfilesbyextension; Components: additional\editors\csm
Source: "C:\Sources\files\HL-LAB\hammer\neo\neo.exe"; DestDir: "{app}\SDK\"; Flags: ignoreversion recursesubdirs createallsubdirs sortfilesbyextension; Components: additional\editors\neo
Source: "C:\Sources\files\HL-LAB\hammer\neon\neon.exe"; DestDir: "{app}\SDK\"; Flags: ignoreversion recursesubdirs createallsubdirs sortfilesbyextension; Components: additional\editors\neon
Source: "C:\Sources\files\HL-LAB\hammer\neon\neon_rus.exe"; DestDir: "{app}\SDK\"; Flags: ignoreversion recursesubdirs createallsubdirs sortfilesbyextension; Components: additional\editors\neon\r
Source: "C:\Sources\files\HL-LAB\addons\QuArK\*"; DestDir: "{app}\SDK\addons\QuArK\"; Flags: ignoreversion recursesubdirs createallsubdirs sortfilesbyextension; Components: additional\editors\quark
Source: "C:\Sources\files\HL-LAB\addons\Sledge\*"; DestDir: "{app}\SDK\addons\Sledge\"; Flags: ignoreversion recursesubdirs createallsubdirs sortfilesbyextension; Components: additional\editors\Sledge
;-mapping
Source: "C:\Sources\files\HL-LAB\addons\Automap\*"; DestDir: "{app}\SDK\addons\Automap\"; Flags: ignoreversion recursesubdirs createallsubdirs sortfilesbyextension; Components: additional\mapping\Automap
Source: "C:\Sources\files\HL-LAB\addons\BSPViewer\*"; DestDir: "{app}\SDK\addons\BSPViewer\"; Flags: ignoreversion recursesubdirs createallsubdirs sortfilesbyextension; Components: additional\mapping\BSPViewer
Source: "C:\Sources\files\HL-LAB\addons\BSP Tools\*"; DestDir: "{app}\SDK\addons\BSP Tools\"; Flags: ignoreversion recursesubdirs createallsubdirs sortfilesbyextension; Components: additional\mapping\BSPTools
Source: "C:\Sources\files\HL-LAB\addons\LeakMarker01\*"; DestDir: "{app}\SDK\addons\LeakMarker01\"; Flags: ignoreversion recursesubdirs createallsubdirs sortfilesbyextension; Components: additional\mapping\LeakMarker
Source: "C:\Sources\files\HL-LAB\addons\RESGen\*"; DestDir: "{app}\SDK\addons\RESGen\"; Flags: ignoreversion recursesubdirs createallsubdirs sortfilesbyextension; Components: additional\mapping\RESGen
Source: "C:\Sources\files\HL-LAB\addons\RandMap\*"; DestDir: "{app}\SDK\addons\RandMap\"; Flags: ignoreversion recursesubdirs createallsubdirs sortfilesbyextension; Components: additional\mapping\RandMap
Source: "C:\Sources\files\HL-LAB\addons\map viewer\*"; DestDir: "{app}\SDK\addons\map viewer\"; Flags: ignoreversion recursesubdirs createallsubdirs sortfilesbyextension; Components: additional\mapping\MAPViewer
Source: "C:\Sources\files\HL-LAB\addons\Crafty\*"; DestDir: "{app}\SDK\addons\Crafty\"; Flags: ignoreversion recursesubdirs createallsubdirs sortfilesbyextension; Components: additional\mapping\Crafty
Source: "C:\Sources\files\HL-LAB\addons\gensurf\*"; DestDir: "{app}\SDK\addons\gensurf\"; Flags: ignoreversion recursesubdirs createallsubdirs sortfilesbyextension; Components: additional\mapping\GENSURF
Source: "C:\Sources\files\HL-LAB\addons\TerrainGenerator\*"; DestDir: "{app}\SDK\addons\TerrainGenerator\"; Flags: ignoreversion recursesubdirs createallsubdirs sortfilesbyextension; Components: additional\mapping\TerrainGenerator
Source: "C:\Sources\files\HL-LAB\addons\TBLux\*"; DestDir: "{app}\SDK\addons\TBLux\"; Flags: ignoreversion recursesubdirs createallsubdirs sortfilesbyextension; Components: additional\mapping\TBLux
;-coDEmpillers---
Source: "C:\Sources\files\HL-LAB\addons\Batch Compiler\*"; DestDir: "{app}\SDK\addons\Batch Compiler\"; Flags: ignoreversion recursesubdirs createallsubdirs sortfilesbyextension; Components: additional\compdecomp\bcomp
Source: "C:\Sources\files\HL-LAB\addons\GUIRipnet\*"; DestDir: "{app}\SDK\addons\GUIRipnet\"; Flags: ignoreversion recursesubdirs createallsubdirs sortfilesbyextension; Components: additional\compdecomp\GUIRipnet
Source: "C:\Sources\files\HL-LAB\addons\UCompiler\*"; DestDir: "{app}\SDK\addons\UCompiler\"; Flags: ignoreversion recursesubdirs createallsubdirs sortfilesbyextension; Components: additional\compdecomp\UCompiler
Source: "C:\Sources\files\HL-LAB\addons\BSPTwoMap Launcher\*"; DestDir: "{app}\SDK\addons\BSPTwoMap Launcher\"; Flags: ignoreversion recursesubdirs createallsubdirs sortfilesbyextension; Components: additional\compdecomp\BSPTwoMap
Source: "C:\Sources\files\HL-LAB\addons\bsp map\*"; DestDir: "{app}\SDK\addons\bsp map\"; Flags: ignoreversion recursesubdirs createallsubdirs sortfilesbyextension; Components: additional\compdecomp\BSP_MAP
Source: "C:\Sources\files\HL-LAB\addons\winbspc\*"; DestDir: "{app}\SDK\addons\winbspc\"; Flags: ignoreversion recursesubdirs createallsubdirs sortfilesbyextension; Components: additional\compdecomp\winbspc
;-content_mng---
Source: "C:\Sources\files\HL-LAB\addons\PakExpl\*"; DestDir: "{app}\SDK\addons\PakExpl\"; Flags: ignoreversion recursesubdirs createallsubdirs sortfilesbyextension; Components: additional\cnt_mgr\PakExpl
Source: "C:\Sources\files\HL-LAB\addons\PakScape\*"; DestDir: "{app}\SDK\addons\PakScape\"; Flags: ignoreversion recursesubdirs createallsubdirs sortfilesbyextension; Components: additional\cnt_mgr\PakScape
Source: "C:\Sources\files\HL-LAB\addons\bsp2zip\*"; DestDir: "{app}\SDK\addons\bsp2zip\"; Flags: ignoreversion recursesubdirs createallsubdirs sortfilesbyextension; Components: additional\cnt_mgr\bsp2zip
Source: "C:\Sources\files\HL-LAB\dist\GameCfgManager.exe"; DestDir: "{app}\SDK\"; Flags: ignoreversion recursesubdirs createallsubdirs sortfilesbyextension; Components: additional\cnt_mgr\GameCfgManager
;-modeling---
Source: "C:\Sources\files\HL-LAB\addons\hlmv\*"; DestDir: "{app}\SDK\addons\hlmv\"; Flags: ignoreversion recursesubdirs createallsubdirs sortfilesbyextension; Components: additional\mdl\hmdl
Source: "C:\Sources\files\HL-LAB\addons\guistudiomdl\*"; DestDir: "{app}\SDK\addons\guistudiomdl\"; Flags: ignoreversion recursesubdirs createallsubdirs sortfilesbyextension; Components: additional\mdl\guistudiomdl
;-Texturing---
Source: "C:\Sources\files\HL-LAB\addons\Auto Seamer\*"; DestDir: "{app}\SDK\addons\Auto Seamer\"; Flags: ignoreversion recursesubdirs createallsubdirs sortfilesbyextension; Components: additional\texture\Autoscr
Source: "C:\Sources\files\HL-LAB\addons\Orbital TexTiler\*"; DestDir: "{app}\SDK\addons\Orbital TexTiler\"; Flags: ignoreversion recursesubdirs createallsubdirs sortfilesbyextension; Components: additional\texture\OrbitalTexTiler
Source: "C:\Sources\files\HL-LAB\addons\QLumpy\*"; DestDir: "{app}\SDK\addons\QLumpy\"; Flags: ignoreversion recursesubdirs createallsubdirs sortfilesbyextension; Components: additional\texture\QLumpy
Source: "C:\Sources\files\HL-LAB\addons\SPR Attrib\*"; DestDir: "{app}\SDK\addons\SPR Attrib\"; Flags: ignoreversion recursesubdirs createallsubdirs sortfilesbyextension; Components: additional\texture\SPRAttrib
Source: "C:\Sources\files\HL-LAB\addons\SprExplorer\*"; DestDir: "{app}\SDK\addons\SprExplorer\"; Flags: ignoreversion recursesubdirs createallsubdirs sortfilesbyextension; Components: additional\texture\SprExplorer
Source: "C:\Sources\files\HL-LAB\addons\Wally\*"; DestDir: "{app}\SDK\addons\Wally\"; Flags: ignoreversion recursesubdirs createallsubdirs sortfilesbyextension; Components: additional\texture\Wally
Source: "C:\Sources\files\HL-LAB\addons\textract\*"; DestDir: "{app}\SDK\addons\textract\"; Flags: ignoreversion recursesubdirs createallsubdirs sortfilesbyextension; Components: additional\texture\TExtractSuite
Source: "C:\Sources\files\HL-LAB\addons\WinTextract\*"; DestDir: "{app}\SDK\addons\WinTextract\"; Flags: ignoreversion recursesubdirs createallsubdirs sortfilesbyextension; Components: additional\texture\WinTextract
;-help------
Source: "C:\Sources\files\HL-LAB\manuals\C++.chm"; DestDir: "{app}\SDK\Manuals\"; Flags: ignoreversion recursesubdirs createallsubdirs sortfilesbyextension; Components: additional\help\h1
Source: "C:\Sources\files\HL-LAB\manuals\Counter-Strike Mapping.chm"; DestDir: "{app}\SDK\Manuals\"; Flags: ignoreversion recursesubdirs createallsubdirs sortfilesbyextension; Components: additional\help\h2
Source: "C:\Sources\files\HL-LAB\manuals\dmitrich!.chm"; DestDir: "{app}\SDK\Manuals\"; Flags: ignoreversion recursesubdirs createallsubdirs sortfilesbyextension; Components: additional\help\h3
Source: "C:\Sources\files\HL-LAB\manuals\HL-SDKT.chm"; DestDir: "{app}\SDK\Manuals\"; Flags: ignoreversion recursesubdirs createallsubdirs sortfilesbyextension; Components: additional\help\h4
Source: "C:\Sources\files\HL-LAB\manuals\mapping.chm"; DestDir: "{app}\SDK\Manuals\"; Flags: ignoreversion recursesubdirs createallsubdirs sortfilesbyextension; Components: additional\help\h5
Source: "C:\Sources\files\HL-LAB\manuals\MilkShape3D.chm"; DestDir: "{app}\SDK\Manuals\"; Flags: ignoreversion recursesubdirs createallsubdirs sortfilesbyextension; Components: additional\help\h6
Source: "C:\Sources\files\HL-LAB\manuals\RussianVHE.chm"; DestDir: "{app}\SDK\Manuals\"; Flags: ignoreversion recursesubdirs createallsubdirs sortfilesbyextension; Components: additional\help\h7
Source: "C:\Sources\files\HL-LAB\manuals\zhlt.chm"; DestDir: "{app}\SDK\Manuals\"; Flags: ignoreversion recursesubdirs createallsubdirs sortfilesbyextension; Components: additional\help\h8

;-modding---
Source: "C:\Sources\files\HL-LAB\addons\hlcsm\*"; DestDir: "{app}\SDK\addons\hlcsm\"; Flags: ignoreversion recursesubdirs createallsubdirs sortfilesbyextension; Components: additional\mod\Hlcsm
Source: "C:\Sources\files\HL-LAB\addons\HILogoGen\*"; DestDir: "{app}\SDK\addons\HILogoGen\"; Flags: ignoreversion recursesubdirs createallsubdirs sortfilesbyextension; Components: additional\mod\HILogoGen
Source: "C:\Sources\files\HL-LAB\addons\HLC\*"; DestDir: "{app}\SDK\addons\HLC\"; Flags: ignoreversion recursesubdirs createallsubdirs sortfilesbyextension; Components: additional\mod\HLC
Source: "C:\Sources\files\HL-LAB\addons\Backchanger\*"; DestDir: "{app}\SDK\addons\Backchanger\"; Flags: ignoreversion recursesubdirs createallsubdirs sortfilesbyextension; Components: additional\mod\Backchanger
Source: "C:\Sources\files\HL-LAB\sources\HL1SDK\*"; DestDir: "{app}\SDK\sources\HL1SDK"; Flags: ignoreversion recursesubdirs createallsubdirs sortfilesbyextension; Components: additional\mod\Sources\hl1
Source: "C:\Sources\files\HL-LAB\sources\Zoner-compiler\*"; DestDir: "{app}\SDK\sources\Zoner-compiler"; Flags: ignoreversion recursesubdirs createallsubdirs sortfilesbyextension; Components: additional\mod\Sources\zhsrc
Source: "C:\Sources\files\HL-LAB\sources\Vluzacn-compiler\*"; DestDir: "{app}\SDK\sources\Vluzacn-compiler"; Flags: ignoreversion recursesubdirs createallsubdirs sortfilesbyextension; Components: additional\mod\Sources\vlsrc
;-compillers---
Source: "C:\Sources\files\HL-LAB\compillers\zonner-sse\*"; DestDir: "{app}\SDK\tools\zonner-sse"; Flags: ignoreversion recursesubdirs createallsubdirs sortfilesbyextension; Components: additional\Compillers\zsse1
Source: "C:\Sources\files\HL-LAB\compillers\zonner-sse2\*"; DestDir: "{app}\SDK\tools\zonner-sse2"; Flags: ignoreversion recursesubdirs createallsubdirs sortfilesbyextension; Components: additional\Compillers\zsse2
Source: "C:\Sources\files\HL-LAB\compillers\zonner-64\*"; DestDir: "{app}\SDK\tools\zonner-64"; Flags: ignoreversion recursesubdirs createallsubdirs sortfilesbyextension; Components: additional\Compillers\zx64
Source: "C:\Sources\files\HL-LAB\compillers\vluzacn\*"; DestDir: "{app}\SDK\tools\vluzacn"; Flags: ignoreversion recursesubdirs createallsubdirs sortfilesbyextension; Components: additional\Compillers\Vluzacn31

[Icons]
Name: "{group}\GoldSrc SDK"; Filename: "{app}\launcher\gSDK_Launcher.exe"; WorkingDir: "{app}\launcher\"; Components: Launcher\starter
Name: "{userdesktop}\GoldSrc SDK"; Filename: "{app}\launcher\gSDK_Launcher.exe"; WorkingDir: "{app}\launcher\"; Tasks: desktopicon; Components: Launcher\starter

[Run]
Filename: "{app}\launcher\gSDK_Launcher.exe"; WorkingDir: "{app}\launcher\"; Flags: nowait postinstall skipifsilent unchecked; Description: "{cm:LaunchProgram, GoldSrc SDK}"; Components: Launcher\starter
Filename: "{tmp}\hllab\dotNetFx40_Full_x86_x64.exe"; Parameters: "/q"; WorkingDir: "{tmp}\hllab\"; Flags: runhidden shellexec waituntilterminated; Description: "Пожалуйста, подождите..."; StatusMsg: "Идет установка\обновление .Net Framework 4.0"; Tasks: fw; Languages: russian by
Filename: "{tmp}\hllab\dotNetFx40_Full_x86_x64.exe"; Parameters: "/q"; WorkingDir: "{tmp}\hllab\"; Flags: runhidden shellexec waituntilterminated; Description: "Please wait..."; StatusMsg: "Installing\updating .Net Framework 4.0"; Tasks: fw; Languages: english es

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
//system drive protect
var
  text_protect: TLabel; 
//сколько осталось
type
TTimerProc = procedure(HandleW, Msg, idEvent, TimeSys: LongWord);

var
StartInstall: Integer;
TimeLabel: TLabel;
TimerID: Longword;

function GetTickCount: DWord; external 'GetTickCount@kernel32';
function WrapTimerProc(callback: TTimerProc; Paramcount: Integer): longword; external 'wrapcallback@files:innocallback.dll stdcall';
function SetTimer(hWnd, nIDEvent, uElapse, lpTimerFunc: LongWord): longword; external 'SetTimer@user32';
function KillTimer(hWnd, nIDEvent: LongWord): LongWord; external 'KillTimer@user32 stdcall delayload';

Function cm(Message: String): String; Begin Result:= ExpandConstant('{cm:'+ Message +'}') End;

Function TicksToTime(Ticks: DWord; h,m,s: String; detail: Boolean): String;
Begin
    if detail then            {hh: mm:ss format}
        Result:= PADZ(IntToStr(Ticks/3600000), 2) +':'+ PADZ(IntToStr((Ticks/1000 - Ticks/1000/3600*3600)/60), 2) +':'+ PADZ(IntToStr(Ticks/1000 - Ticks/1000/60*60), 2)
    else if Ticks/3600 >= 1000 then    {more than hour}
        Result:= IntToStr(Ticks/3600000) +h+' '+ PADZ(IntToStr((Ticks/1000 - Ticks/1000/3600*3600)/60), 2) +m
    else if Ticks/60 >= 1000 then    {1..60 minutes}
        Result:= IntToStr(Ticks/60000) +m+' '+ IntToStr(Ticks/1000 - Ticks/1000/60*60) +s
    else Result:= Format('%.1n', [Abs(Ticks/1000)]) +s    {less than one minute}
End;

procedure GetTime(HandleW, Msg, idEvent, TimeSys: LongWord);
var Remaining: Integer;
begin
with WizardForm.ProgressGauge do begin
  if position > 0 then Remaining:= trunc((GetTickCount - StartInstall) * Abs((max - position)/position));
    TimeLabel.Caption:= cm('waitabout') + TicksToTime(Remaining, cm('hour'), cm('min'), cm('sec'), false);
    if (Remaining = 0) then TimeLabel.Caption:= cm('waitplease')
  end;
end;

//system drive protect
function NextButtonClick(CurPageID: Integer): Boolean;
var
  i, n: Integer;
  str: string;
begin
  Result:= True;
  if CurPageID = wpSelectDir then
    begin
      str:= WizardForm.DirEdit.Text;
      for i:= 1 to Length(str) do if str[i] = '\' then n:= n + 1;
      if (n = 1) and (Pos(ExpandConstant('{sd}'), WizardForm.DirEdit.Text) > 0) then
        begin
          text_protect.Caption:= cm('hdprotect');
          Result:= False;
        end
      else text_protect.Caption:= '';
    end;
end;

procedure InitializeWizard();
  begin
  //fix of icon
  WizardForm.WizardSmallBitmapImage.Left:=327;
  WizardForm.WizardSmallBitmapImage.Top:=0;
  WizardForm.WizardSmallBitmapImage.Width:=170;
  WizardForm.WizardSmallBitmapImage.Height:=58;
  WizardForm.PageDescriptionLabel.Width:=285;
  WizardForm.PageNameLabel.Width:=300;  
  //system drive protect
  text_protect:= TLabel.Create(WizardForm);
  with text_protect do
    begin
      SetBounds(WizardForm.DirEdit.Left,120,300,100);
      AutoSize:= True;
      Font.Style:= [fsBold];
      Font.Color:= clRed;
      Parent:= WizardForm.SelectDirPage;
    end;
  //сколько осталось
  TimeLabel:= TLabel.Create(WizardForm)
  TimeLabel.SetBounds(ScaleX(0), ScaleY(80), ScaleX(457), ScaleY(20));
  TimeLabel.AutoSize:= False
  TimeLabel.Transparent:= True;
  TimeLabel.Parent:= WizardForm.InstallingPage;
end;

//сколько осталось
procedure CurStepChanged(CurStep: TSetupStep);
begin
If CurStep = ssInstall then
  begin
    StartInstall:= GetTickCount
    TimerID:= SetTimer(0,0, 500, WrapTimerProc(@GetTime, 4))
  end;
end;

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
      if (SetupTypesCombo.Items[3] <> 'Выборочная установка') then
      begin
        SetupTypesCombo.Items[3] := 'Выборочная установка';
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
      if (SetupTypesCombo.Items[3] <> 'Custom install') then
      begin
        SetupTypesCombo.Items[3] := 'Custom install';
      end;
    end;
  end;

    if (CurPageID = wpSelectComponents) and (ActiveLanguage() = 'by') then
  begin
    OptionsPage := PageFromID(CurPageID);
    PageSurface := OptionsPage.Surface;
    SetupTypesCombo := TComboBox(PageSurface.Controls[2]);
    if (SetupTypesCombo <> nil) then
    begin
      if (SetupTypesCombo.Items[3] <> 'Выборочная установка') then
      begin
        SetupTypesCombo.Items[3] := 'Выборочная установка';
      end;
    end;
  end;

    if (CurPageID = wpSelectComponents) and (ActiveLanguage() = 'es') then
  begin
    OptionsPage := PageFromID(CurPageID);
    PageSurface := OptionsPage.Surface;
    SetupTypesCombo := TComboBox(PageSurface.Controls[2]);
    if (SetupTypesCombo <> nil) then
    begin
      if (SetupTypesCombo.Items[3] <> 'Instalación personalizada') then
      begin
        SetupTypesCombo.Items[3] := 'Instalación personalizada';
      end;
    end;
  end;

end;

  //setup ending
procedure DeinitializeSetup();
begin
//сколько осталось
KillTimer(0, TimerID)
end;
