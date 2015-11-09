'
' Created by SharpDevelop.
' User: s800239049
' Date: 07/04/2015
' Time: 9:40 AM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class MainForm
	Inherits System.Windows.Forms.Form
	
	''' <summary>
	''' Designer variable used to keep track of non-visual components.
	''' </summary>
	Public components As System.ComponentModel.IContainer
	
	''' <summary>
	''' Disposes resources used by the form.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
	
	''' <summary>
	''' This method is required for Windows Forms designer support.
	''' Do not change the method contents inside the source code editor. The Forms designer might
	''' not be able to load this method if it was changed manually.
	''' </summary>
	Public Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
		Me.button1 = New System.Windows.Forms.Button()
		Me.App_Name = New System.Windows.Forms.TextBox()
		Me.label1 = New System.Windows.Forms.Label()
		Me.label2 = New System.Windows.Forms.Label()
		Me.AppAuthor = New System.Windows.Forms.TextBox()
		Me.label3 = New System.Windows.Forms.Label()
		Me.AppHomepage = New System.Windows.Forms.TextBox()
		Me.label4 = New System.Windows.Forms.Label()
		Me.label5 = New System.Windows.Forms.Label()
		Me.AppDescription = New System.Windows.Forms.TextBox()
		Me.label7 = New System.Windows.Forms.Label()
		Me.AppLanguage = New System.Windows.Forms.TextBox()
		Me.label8 = New System.Windows.Forms.Label()
		Me.AppVersion = New System.Windows.Forms.TextBox()
		Me.AppCategory = New System.Windows.Forms.ComboBox()
		Me.label6 = New System.Windows.Forms.Label()
		Me.AppFriendlyVersion = New System.Windows.Forms.TextBox()
		Me.label9 = New System.Windows.Forms.Label()
		Me.AppUsesGhostscript = New System.Windows.Forms.ComboBox()
		Me.AppUsesJava = New System.Windows.Forms.ComboBox()
		Me.label10 = New System.Windows.Forms.Label()
		Me.AppUsesDotNetVersion = New System.Windows.Forms.ComboBox()
		Me.label11 = New System.Windows.Forms.Label()
		Me.label12 = New System.Windows.Forms.Label()
		Me.RelativeAppLaunchPath = New System.Windows.Forms.TextBox()
		Me.label13 = New System.Windows.Forms.Label()
		Me.AppLaunchPath = New System.Windows.Forms.TextBox()
		Me.labela = New System.Windows.Forms.Label()
		Me.label14 = New System.Windows.Forms.Label()
		Me.button2 = New System.Windows.Forms.Button()
		Me.label15 = New System.Windows.Forms.Label()
		Me.folderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
		Me.SuspendLayout
		'
		'button1
		'
		Me.button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.button1.Location = New System.Drawing.Point(526, 350)
		Me.button1.Name = "button1"
		Me.button1.Size = New System.Drawing.Size(75, 23)
		Me.button1.TabIndex = 0
		Me.button1.Text = "Go"
		Me.button1.UseVisualStyleBackColor = true
		AddHandler Me.button1.Click, AddressOf Me.Button1Click
		'
		'App_Name
		'
		Me.App_Name.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
						Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.App_Name.Location = New System.Drawing.Point(153, 13)
		Me.App_Name.Name = "App_Name"
		Me.App_Name.Size = New System.Drawing.Size(437, 20)
		Me.App_Name.TabIndex = 1
		Me.App_Name.Text = "App Name"
		'
		'label1
		'
		Me.label1.Location = New System.Drawing.Point(12, 12)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(135, 20)
		Me.label1.TabIndex = 2
		Me.label1.Text = "App Name"
		Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'label2
		'
		Me.label2.Location = New System.Drawing.Point(12, 38)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(135, 20)
		Me.label2.TabIndex = 4
		Me.label2.Text = "AppAuthor"
		Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'AppAuthor
		'
		Me.AppAuthor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
						Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.AppAuthor.Location = New System.Drawing.Point(153, 39)
		Me.AppAuthor.Name = "AppAuthor"
		Me.AppAuthor.Size = New System.Drawing.Size(437, 20)
		Me.AppAuthor.TabIndex = 3
		Me.AppAuthor.Text = "Person and Person 2"
		'
		'label3
		'
		Me.label3.Location = New System.Drawing.Point(12, 64)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(135, 20)
		Me.label3.TabIndex = 6
		Me.label3.Text = "AppHomepage"
		Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'AppHomepage
		'
		Me.AppHomepage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
						Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.AppHomepage.Location = New System.Drawing.Point(153, 65)
		Me.AppHomepage.Name = "AppHomepage"
		Me.AppHomepage.Size = New System.Drawing.Size(437, 20)
		Me.AppHomepage.TabIndex = 5
		Me.AppHomepage.Text = "http://www.website.com"
		'
		'label4
		'
		Me.label4.Location = New System.Drawing.Point(12, 90)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(135, 20)
		Me.label4.TabIndex = 8
		Me.label4.Text = "AppCategory"
		Me.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'label5
		'
		Me.label5.Location = New System.Drawing.Point(12, 116)
		Me.label5.Name = "label5"
		Me.label5.Size = New System.Drawing.Size(135, 20)
		Me.label5.TabIndex = 10
		Me.label5.Text = "AppDescription"
		Me.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'AppDescription
		'
		Me.AppDescription.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
						Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.AppDescription.Location = New System.Drawing.Point(153, 117)
		Me.AppDescription.Name = "AppDescription"
		Me.AppDescription.Size = New System.Drawing.Size(437, 20)
		Me.AppDescription.TabIndex = 9
		Me.AppDescription.Text = "AppName is an app."
		'
		'label7
		'
		Me.label7.Location = New System.Drawing.Point(12, 142)
		Me.label7.Name = "label7"
		Me.label7.Size = New System.Drawing.Size(135, 20)
		Me.label7.TabIndex = 14
		Me.label7.Text = "AppLanguage"
		Me.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'AppLanguage
		'
		Me.AppLanguage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
						Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.AppLanguage.Location = New System.Drawing.Point(153, 143)
		Me.AppLanguage.Name = "AppLanguage"
		Me.AppLanguage.Size = New System.Drawing.Size(437, 20)
		Me.AppLanguage.TabIndex = 13
		Me.AppLanguage.Text = "English"
		'
		'label8
		'
		Me.label8.Location = New System.Drawing.Point(12, 164)
		Me.label8.Name = "label8"
		Me.label8.Size = New System.Drawing.Size(135, 20)
		Me.label8.TabIndex = 16
		Me.label8.Text = "AppVersion"
		Me.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'AppVersion
		'
		Me.AppVersion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
						Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.AppVersion.Location = New System.Drawing.Point(153, 165)
		Me.AppVersion.Name = "AppVersion"
		Me.AppVersion.Size = New System.Drawing.Size(437, 20)
		Me.AppVersion.TabIndex = 15
		Me.AppVersion.Text = "0.0.0.0"
		'
		'AppCategory
		'
		Me.AppCategory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
						Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.AppCategory.FormattingEnabled = true
		Me.AppCategory.Items.AddRange(New Object() {"Accessibility", "Development", "Education", "Games", "Graphics & Pictures", "Internet", "Music & Video", "Office", "Security", "Utilities"})
		Me.AppCategory.Location = New System.Drawing.Point(153, 91)
		Me.AppCategory.Name = "AppCategory"
		Me.AppCategory.Size = New System.Drawing.Size(437, 21)
		Me.AppCategory.TabIndex = 17
		'
		'label6
		'
		Me.label6.Location = New System.Drawing.Point(12, 184)
		Me.label6.Name = "label6"
		Me.label6.Size = New System.Drawing.Size(135, 20)
		Me.label6.TabIndex = 19
		Me.label6.Text = "AppFriendlyVersion"
		Me.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'AppFriendlyVersion
		'
		Me.AppFriendlyVersion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
						Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.AppFriendlyVersion.Location = New System.Drawing.Point(153, 185)
		Me.AppFriendlyVersion.Name = "AppFriendlyVersion"
		Me.AppFriendlyVersion.Size = New System.Drawing.Size(437, 20)
		Me.AppFriendlyVersion.TabIndex = 18
		Me.AppFriendlyVersion.Text = "1.2 Beta 1"
		'
		'label9
		'
		Me.label9.Location = New System.Drawing.Point(12, 204)
		Me.label9.Name = "label9"
		Me.label9.Size = New System.Drawing.Size(135, 20)
		Me.label9.TabIndex = 21
		Me.label9.Text = "AppUsesGhostscript"
		Me.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'AppUsesGhostscript
		'
		Me.AppUsesGhostscript.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
						Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.AppUsesGhostscript.FormattingEnabled = true
		Me.AppUsesGhostscript.Items.AddRange(New Object() {"no", "yes", "optional"})
		Me.AppUsesGhostscript.Location = New System.Drawing.Point(153, 205)
		Me.AppUsesGhostscript.Name = "AppUsesGhostscript"
		Me.AppUsesGhostscript.Size = New System.Drawing.Size(437, 21)
		Me.AppUsesGhostscript.TabIndex = 23
		'
		'AppUsesJava
		'
		Me.AppUsesJava.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
						Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.AppUsesJava.FormattingEnabled = true
		Me.AppUsesJava.Items.AddRange(New Object() {"no", "yes", "optional"})
		Me.AppUsesJava.Location = New System.Drawing.Point(153, 225)
		Me.AppUsesJava.Name = "AppUsesJava"
		Me.AppUsesJava.Size = New System.Drawing.Size(437, 21)
		Me.AppUsesJava.TabIndex = 25
		'
		'label10
		'
		Me.label10.Location = New System.Drawing.Point(12, 224)
		Me.label10.Name = "label10"
		Me.label10.Size = New System.Drawing.Size(135, 20)
		Me.label10.TabIndex = 24
		Me.label10.Text = "AppUsesJava"
		Me.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'AppUsesDotNetVersion
		'
		Me.AppUsesDotNetVersion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
						Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.AppUsesDotNetVersion.FormattingEnabled = true
		Me.AppUsesDotNetVersion.Items.AddRange(New Object() {"1.1", "2.0", "2.0SP2", "3.0", "3.0SP1", "3.5", "4.0", "4.0F"})
		Me.AppUsesDotNetVersion.Location = New System.Drawing.Point(153, 245)
		Me.AppUsesDotNetVersion.Name = "AppUsesDotNetVersion"
		Me.AppUsesDotNetVersion.Size = New System.Drawing.Size(437, 21)
		Me.AppUsesDotNetVersion.TabIndex = 27
		'
		'label11
		'
		Me.label11.Location = New System.Drawing.Point(12, 244)
		Me.label11.Name = "label11"
		Me.label11.Size = New System.Drawing.Size(135, 20)
		Me.label11.TabIndex = 26
		Me.label11.Text = "AppUsesDotNetVersion"
		Me.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'label12
		'
		Me.label12.Location = New System.Drawing.Point(12, 265)
		Me.label12.Name = "label12"
		Me.label12.Size = New System.Drawing.Size(135, 20)
		Me.label12.TabIndex = 29
		Me.label12.Text = "RelativeAppLaunchPath"
		Me.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'RelativeAppLaunchPath
		'
		Me.RelativeAppLaunchPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
						Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.RelativeAppLaunchPath.Location = New System.Drawing.Point(153, 265)
		Me.RelativeAppLaunchPath.Name = "RelativeAppLaunchPath"
		Me.RelativeAppLaunchPath.Size = New System.Drawing.Size(437, 20)
		Me.RelativeAppLaunchPath.TabIndex = 28
		Me.RelativeAppLaunchPath.Text = "App\AppName\AppName.exe"
		'
		'label13
		'
		Me.label13.Location = New System.Drawing.Point(12, 288)
		Me.label13.Name = "label13"
		Me.label13.Size = New System.Drawing.Size(135, 20)
		Me.label13.TabIndex = 31
		Me.label13.Text = "AppLaunchPath"
		Me.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'AppLaunchPath
		'
		Me.AppLaunchPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
						Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.AppLaunchPath.Location = New System.Drawing.Point(153, 288)
		Me.AppLaunchPath.Name = "AppLaunchPath"
		Me.AppLaunchPath.Size = New System.Drawing.Size(437, 20)
		Me.AppLaunchPath.TabIndex = 30
		Me.AppLaunchPath.Text = "AppName\AppName.exe"
		'
		'labela
		'
		Me.labela.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
		Me.labela.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.labela.Location = New System.Drawing.Point(12, 350)
		Me.labela.Name = "labela"
		Me.labela.Size = New System.Drawing.Size(100, 23)
		Me.labela.TabIndex = 32
		Me.labela.Text = "Generating..."
		Me.labela.Visible = false
		'
		'label14
		'
		Me.label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.label14.Location = New System.Drawing.Point(200, 355)
		Me.label14.Name = "label14"
		Me.label14.Size = New System.Drawing.Size(199, 18)
		Me.label14.TabIndex = 33
		Me.label14.Text = "This generator was made by Patrick G."
		AddHandler Me.label14.Click, AddressOf Me.Label14Click
		'
		'button2
		'
		Me.button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.button2.Location = New System.Drawing.Point(405, 350)
		Me.button2.Name = "button2"
		Me.button2.Size = New System.Drawing.Size(114, 23)
		Me.button2.TabIndex = 34
		Me.button2.Text = "Preview Result"
		Me.button2.UseVisualStyleBackColor = true
		AddHandler Me.button2.Click, AddressOf Me.Button2Click
		'
		'label15
		'
		Me.label15.Location = New System.Drawing.Point(12, 324)
		Me.label15.Name = "label15"
		Me.label15.Size = New System.Drawing.Size(578, 23)
		Me.label15.TabIndex = 35
		Me.label15.Text = resources.GetString("label15.Text")
		'
		'folderBrowserDialog1
		'
		Me.folderBrowserDialog1.Description = "Choose the folder to put the generated layout in"
		Me.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer
		AddHandler Me.folderBrowserDialog1.HelpRequest, AddressOf Me.FolderBrowserDialog1HelpRequest
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(602, 373)
		Me.Controls.Add(Me.label15)
		Me.Controls.Add(Me.button2)
		Me.Controls.Add(Me.label14)
		Me.Controls.Add(Me.labela)
		Me.Controls.Add(Me.label13)
		Me.Controls.Add(Me.AppLaunchPath)
		Me.Controls.Add(Me.label12)
		Me.Controls.Add(Me.RelativeAppLaunchPath)
		Me.Controls.Add(Me.AppUsesDotNetVersion)
		Me.Controls.Add(Me.label11)
		Me.Controls.Add(Me.AppUsesJava)
		Me.Controls.Add(Me.label10)
		Me.Controls.Add(Me.AppUsesGhostscript)
		Me.Controls.Add(Me.label9)
		Me.Controls.Add(Me.label6)
		Me.Controls.Add(Me.AppFriendlyVersion)
		Me.Controls.Add(Me.AppCategory)
		Me.Controls.Add(Me.label8)
		Me.Controls.Add(Me.AppVersion)
		Me.Controls.Add(Me.label7)
		Me.Controls.Add(Me.AppLanguage)
		Me.Controls.Add(Me.label5)
		Me.Controls.Add(Me.AppDescription)
		Me.Controls.Add(Me.label4)
		Me.Controls.Add(Me.label3)
		Me.Controls.Add(Me.AppHomepage)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.AppAuthor)
		Me.Controls.Add(Me.label1)
		Me.Controls.Add(Me.App_Name)
		Me.Controls.Add(Me.button1)
		Me.Name = "MainForm"
		Me.Text = "PortableAppsGenerator"
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private folderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
	Private label15 As System.Windows.Forms.Label
	Public button2 As System.Windows.Forms.Button
	Public label14 As System.Windows.Forms.Label
	Public labela As System.Windows.Forms.Label
	Public AppLaunchPath As System.Windows.Forms.TextBox
	Public label13 As System.Windows.Forms.Label
	Public RelativeAppLaunchPath As System.Windows.Forms.TextBox
	Public label12 As System.Windows.Forms.Label
	Public label11 As System.Windows.Forms.Label
	Public AppUsesDotNetVersion As System.Windows.Forms.ComboBox
	Public label10 As System.Windows.Forms.Label
	Public AppUsesJava As System.Windows.Forms.ComboBox
	Public AppUsesGhostscript As System.Windows.Forms.ComboBox
	Public label9 As System.Windows.Forms.Label
	Public AppFriendlyVersion As System.Windows.Forms.TextBox
	Public label6 As System.Windows.Forms.Label
	Public AppCategory As System.Windows.Forms.ComboBox
	Public AppVersion As System.Windows.Forms.TextBox
	Public label8 As System.Windows.Forms.Label
	Public AppLanguage As System.Windows.Forms.TextBox
	Public label7 As System.Windows.Forms.Label
	Public AppDescription As System.Windows.Forms.TextBox
	Public label5 As System.Windows.Forms.Label
	Public label4 As System.Windows.Forms.Label
	Public AppHomepage As System.Windows.Forms.TextBox
	Public label3 As System.Windows.Forms.Label
	Public AppAuthor As System.Windows.Forms.TextBox
	Public label2 As System.Windows.Forms.Label
	Public label1 As System.Windows.Forms.Label
	Public App_Name As System.Windows.Forms.TextBox
	Public button1 As System.Windows.Forms.Button
End Class
