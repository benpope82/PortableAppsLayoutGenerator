'
' Created by SharpDevelop.
' User: S800239049
' Date: 07/04/2015
' Time: 11:47 AM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class LayoutPreview
	Inherits System.Windows.Forms.Form
	
	''' <summary>
	''' Designer variable used to keep track of non-visual components.
	''' </summary>
	Private components As System.ComponentModel.IContainer
	
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
	Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LayoutPreview))
		Me.tabControl1 = New System.Windows.Forms.TabControl()
		Me.tabPage1 = New System.Windows.Forms.TabPage()
		Me.textBox1 = New System.Windows.Forms.TextBox()
		Me.tabPage2 = New System.Windows.Forms.TabPage()
		Me.textBox2 = New System.Windows.Forms.TextBox()
		Me.tabControl1.SuspendLayout
		Me.tabPage1.SuspendLayout
		Me.tabPage2.SuspendLayout
		Me.SuspendLayout
		'
		'tabControl1
		'
		Me.tabControl1.Controls.Add(Me.tabPage1)
		Me.tabControl1.Controls.Add(Me.tabPage2)
		Me.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.tabControl1.Location = New System.Drawing.Point(0, 0)
		Me.tabControl1.Name = "tabControl1"
		Me.tabControl1.SelectedIndex = 0
		Me.tabControl1.Size = New System.Drawing.Size(465, 230)
		Me.tabControl1.TabIndex = 0
		'
		'tabPage1
		'
		Me.tabPage1.Controls.Add(Me.textBox1)
		Me.tabPage1.Location = New System.Drawing.Point(4, 22)
		Me.tabPage1.Name = "tabPage1"
		Me.tabPage1.Padding = New System.Windows.Forms.Padding(3)
		Me.tabPage1.Size = New System.Drawing.Size(457, 204)
		Me.tabPage1.TabIndex = 0
		Me.tabPage1.Text = "Directories"
		Me.tabPage1.UseVisualStyleBackColor = true
		'
		'textBox1
		'
		Me.textBox1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.textBox1.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.textBox1.Location = New System.Drawing.Point(3, 3)
		Me.textBox1.Multiline = true
		Me.textBox1.Name = "textBox1"
		Me.textBox1.ReadOnly = true
		Me.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
		Me.textBox1.Size = New System.Drawing.Size(451, 198)
		Me.textBox1.TabIndex = 0
		Me.textBox1.Text = resources.GetString("textBox1.Text")
		'
		'tabPage2
		'
		Me.tabPage2.Controls.Add(Me.textBox2)
		Me.tabPage2.Location = New System.Drawing.Point(4, 22)
		Me.tabPage2.Name = "tabPage2"
		Me.tabPage2.Padding = New System.Windows.Forms.Padding(3)
		Me.tabPage2.Size = New System.Drawing.Size(457, 204)
		Me.tabPage2.TabIndex = 1
		Me.tabPage2.Text = "appinfo.ini"
		Me.tabPage2.UseVisualStyleBackColor = true
		'
		'textBox2
		'
		Me.textBox2.Dock = System.Windows.Forms.DockStyle.Fill
		Me.textBox2.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.textBox2.Location = New System.Drawing.Point(3, 3)
		Me.textBox2.Multiline = true
		Me.textBox2.Name = "textBox2"
		Me.textBox2.ReadOnly = true
		Me.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.textBox2.Size = New System.Drawing.Size(451, 198)
		Me.textBox2.TabIndex = 1
		Me.textBox2.Text = resources.GetString("textBox2.Text")
		'
		'LayoutPreview
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(465, 230)
		Me.Controls.Add(Me.tabControl1)
		Me.Name = "LayoutPreview"
		Me.Text = "LayoutPreview"
		AddHandler Load, AddressOf Me.LayoutPreviewLoad
		Me.tabControl1.ResumeLayout(false)
		Me.tabPage1.ResumeLayout(false)
		Me.tabPage1.PerformLayout
		Me.tabPage2.ResumeLayout(false)
		Me.tabPage2.PerformLayout
		Me.ResumeLayout(false)
	End Sub
	Private textBox2 As System.Windows.Forms.TextBox
	Private tabPage2 As System.Windows.Forms.TabPage
	Private textBox1 As System.Windows.Forms.TextBox
	Private tabPage1 As System.Windows.Forms.TabPage
	Private tabControl1 As System.Windows.Forms.TabControl
End Class
