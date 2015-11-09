'
' Created by SharpDevelop.
' User: S800239049
' Date: 07/04/2015
' Time: 11:47 AM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Partial Class LayoutPreview
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	Sub LayoutPreviewLoad(sender As Object, e As EventArgs)
		Dim AppNameNoSpaces=MainForm.App_Name.Text.Replace(" ","")
		
		textbox2.text=textbox2.text.Replace("App Name",MainForm.App_Name.Text)
		textbox2.text=textbox2.text.replace("AppName",AppNameNoSpaces)
		textbox2.text=textbox2.text.Replace("AppAuthor",MainForm.AppAuthor.Text)
		textbox2.text=textbox2.text.Replace("AppHomepage",MainForm.AppHomepage.Text)
		textbox2.text=textbox2.text.Replace("AppCategory",MainForm.AppCategory.Text)
		textbox2.text=textbox2.text.Replace("AppDescription",MainForm.AppDescription.Text)
		textbox2.text=textbox2.text.Replace("AppLanguage",MainForm.AppLanguage.Text)
		textbox2.text=textbox2.text.Replace("AppVersion",MainForm.AppVersion.Text)
		textbox2.text=textbox2.text.Replace("AppFriendlyVersion",MainForm.AppFriendlyVersion.Text)
		textbox2.text=textbox2.text.Replace("AppUsesGhostscript",MainForm.AppUsesGhostscript.Text)
		textbox2.text=textbox2.text.Replace("AppUsesJava",MainForm.AppUsesJava.Text)
		textbox2.text=textbox2.text.Replace("AppUsesDotNetVersion",MainForm.AppUsesDotNetVersion.Text)
		textbox2.text=textbox2.text.Replace("RelativeAppLaunchPath",MainForm.RelativeAppLaunchPath.Text)
		textbox2.text=textbox2.text.Replace("AppLaunchPath",MainForm.AppLaunchPath.Text)
		
		
		textbox1.text=textbox1.text.Replace("App Name",MainForm.App_Name.Text)
		textbox1.text=textbox1.text.replace("AppName",AppNameNoSpaces)
		textbox1.text=textbox1.text.Replace("AppAuthor",MainForm.AppAuthor.Text)
		textbox1.text=textbox1.text.Replace("AppHomepage",MainForm.AppHomepage.Text)
		textbox1.text=textbox1.text.Replace("AppCategory",MainForm.AppCategory.Text)
		textbox1.text=textbox1.text.Replace("AppDescription",MainForm.AppDescription.Text)
		textbox1.text=textbox1.text.Replace("AppLanguage",MainForm.AppLanguage.Text)
		textbox1.text=textbox1.text.Replace("AppVersion",MainForm.AppVersion.Text)
		textbox1.text=textbox1.text.Replace("AppFriendlyVersion",MainForm.AppFriendlyVersion.Text)
		textbox1.text=textbox1.text.Replace("AppUsesGhostscript",MainForm.AppUsesGhostscript.Text)
		textbox1.text=textbox1.text.Replace("AppUsesJava",MainForm.AppUsesJava.Text)
		textbox1.text=textbox1.text.Replace("AppUsesDotNetVersion",MainForm.AppUsesDotNetVersion.Text)
		textbox1.text=textbox1.text.Replace("RelativeAppLaunchPath",MainForm.RelativeAppLaunchPath.Text)
		textbox1.text=textbox1.text.Replace("AppLaunchPath",MainForm.AppLaunchPath.Text)
	End Sub
End Class
