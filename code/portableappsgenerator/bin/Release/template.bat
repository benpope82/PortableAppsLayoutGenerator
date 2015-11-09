md AppNamePortable
cd AppNamePortable
echo App Name Portable Help >help.html
md Data
md App
md Other
cd App
echo ->PUT PROGRAM FILES HERE
md DefaultData
md AppName
md AppInfo
cd AppInfo
md Launcher
echo PUT ICON HERE>appicon.ico

rem appinfo.ini
echo [Format]>appinfo.ini
echo Type=PortableApps.comFormat>>appinfo.ini
echo Version=3.0>>appinfo.ini
echo [Details]>>appinfo.ini
echo Name=App Name Portable>>appinfo.ini
echo AppID=AppNamePortable>>appinfo.ini
echo Publisher=AppAuthor>>appinfo.ini
echo Homepage=AppHomepage>>appinfo.ini
echo Category=AppCategory>>appinfo.ini
echo Description=AppDescription>>appinfo.ini
echo Language=AppLanguage>>appinfo.ini
echo Trademarks=>>appinfo.ini
echo InstallType=>>appinfo.ini
echo [License]>>appinfo.ini
echo Shareable=true>>appinfo.ini
echo OpenSource=false>>appinfo.ini
echo Freeware=true>>appinfo.ini
echo CommercialUse=true>>appinfo.ini
echo EULAVersion=1>>appinfo.ini
echo [Version]>>appinfo.ini
echo PackageVersion=AppVersion>>appinfo.ini
echo DisplayVersion=AppFriendlyVersion>>appinfo.ini
echo [SpecialPaths]>>appinfo.ini
echo Plugins=NONE>>appinfo.ini
echo [Dependencies]>>appinfo.ini
echo UsesGhostscript=AppUsesGhostscript>>appinfo.ini
echo UsesJava=AppUsesJava>>appinfo.ini
echo UsesDotNetVersion=AppUsesDotNetVersion>>appinfo.ini
echo [Control]>>appinfo.ini
echo Icons=1>>appinfo.ini
echo Start=RelativeAppLaunchPath>>appinfo.ini
echo ExtractIcon=RelativeAppLaunchPath>>appinfo.ini

cd Launcher
rem launcher.ini
echo [Launch]>launcher.ini
echo ProgramExecutable=AppLaunchPath>>launcher.ini
echo [LiveMode]>>launcher.ini
echo CopyApp=false>>launcher.ini
