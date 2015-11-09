'
' Created by SharpDevelop.
' User: s800239049
' Date: 07/04/2015
' Time: 9:40 AM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Partial Class MainForm
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	

	
	Sub Button1Click(sender As Object, e As EventArgs)
		If folderBrowserDialog1.ShowDialog()=DialogResult.OK Then
			
		
		
		labela.visible=True
		Dim AppNameNoSpaces=App_Name.Text.Replace(" ","")
		Dim template As String
		try
			template=IO.File.ReadAllText(Application.StartupPath+"\template.bat")
		Catch
			Try
				template=IO.File.ReadAllText("template.bat")
			
			Catch
				MsgBox("Cannot find template.bat")
				Exit Sub
			End Try
			End try
				
			
			
		template=template.Replace("App Name",App_Name.Text)
		template=template.replace("AppName",AppNameNoSpaces)
		template=template.Replace("AppAuthor",AppAuthor.Text)
		template=template.Replace("AppHomepage",AppHomepage.Text)
		template=template.Replace("AppCategory",AppCategory.Text)
		template=template.Replace("AppDescription",AppDescription.Text)
		template=template.Replace("AppLanguage",AppLanguage.Text)
		template=template.Replace("AppVersion",AppVersion.Text)
		template=template.Replace("AppFriendlyVersion",AppFriendlyVersion.Text)
		template=template.Replace("AppUsesGhostscript",AppUsesGhostscript.Text)
		template=template.Replace("AppUsesJava",AppUsesJava.Text)
		template=template.Replace("AppUsesDotNetVersion",AppUsesDotNetVersion.Text)
		template=template.Replace("RelativeAppLaunchPath",RelativeAppLaunchPath.Text)
		template=template.Replace("AppLaunchPath",AppLaunchPath.Text)
		System.IO.File.WriteAllText(folderBrowserDialog1.SelectedPath+"\generator.bat",template)
		
		System.Diagnostics.Process.Start(folderBrowserDialog1.SelectedPath+"\generator.bat").WaitForExit()
		Try
			System.Diagnostics.Process.Start("c:\windows\explorer.exe"," /select,"+folderBrowserDialog1.SelectedPath+"/generator.bat")
		Catch
			
		
		End Try
		MsgBox("Please run generator.bat in: "+folderBrowserDialog1.SelectedPath)
		
		labela.Visible=False
		Me.Close()
		Else
MsgBox("Please choose a folder.")			
		End If
		
	
	End Sub
	
	
	Sub Label14Click(sender As Object, e As EventArgs)
		
	End Sub
	
	Sub Button2Click(sender As Object, e As EventArgs)
LayoutPreview.showdialog()		
	End Sub
	
	Sub LinkLabel1LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
		
	End Sub
	
	Sub FolderBrowserDialog1HelpRequest(sender As Object, e As EventArgs)
		
	End Sub
End Class
