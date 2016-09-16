'
' Created by SharpDevelop.
' User: spen6722
' Date: 8/29/2016
' Time: 12:43 PM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class MainForm
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
		Me.button1 = New System.Windows.Forms.Button()
		Me.button2 = New System.Windows.Forms.Button()
		Me.button3 = New System.Windows.Forms.Button()
		Me.button4 = New System.Windows.Forms.Button()
		Me.horDiv = New System.Windows.Forms.Label()
		Me.button5 = New System.Windows.Forms.Button()
		Me.button6 = New System.Windows.Forms.Button()
		Me.button7 = New System.Windows.Forms.Button()
		Me.button8 = New System.Windows.Forms.Button()
		Me.button9 = New System.Windows.Forms.Button()
		Me.progressBar1 = New System.Windows.Forms.ProgressBar()
		Me.label1 = New System.Windows.Forms.Label()
		Me.SuspendLayout
		'
		'button1
		'
		Me.button1.BackColor = System.Drawing.SystemColors.ButtonFace
		Me.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace
		Me.button1.FlatAppearance.BorderSize = 2
		Me.button1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonHighlight
		Me.button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight
		Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.button1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.button1.Location = New System.Drawing.Point(2, 88)
		Me.button1.Margin = New System.Windows.Forms.Padding(2)
		Me.button1.Name = "button1"
		Me.button1.Size = New System.Drawing.Size(110, 50)
		Me.button1.TabIndex = 0
		Me.button1.Text = "Draft Kit"
		Me.button1.UseVisualStyleBackColor = false
		AddHandler Me.button1.Click, AddressOf Me.Button1Click
		'
		'button2
		'
		Me.button2.Enabled = false
		Me.button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace
		Me.button2.FlatAppearance.BorderSize = 2
		Me.button2.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonHighlight
		Me.button2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight
		Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.button2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.button2.Location = New System.Drawing.Point(330, 229)
		Me.button2.Margin = New System.Windows.Forms.Padding(2)
		Me.button2.Name = "button2"
		Me.button2.Size = New System.Drawing.Size(124, 25)
		Me.button2.TabIndex = 1
		Me.button2.Text = "League Settings"
		Me.button2.UseVisualStyleBackColor = true
		'
		'button3
		'
		Me.button3.BackColor = System.Drawing.SystemColors.ButtonFace
		Me.button3.Enabled = false
		Me.button3.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace
		Me.button3.FlatAppearance.BorderSize = 2
		Me.button3.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonHighlight
		Me.button3.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight
		Me.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.button3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.button3.Location = New System.Drawing.Point(116, 34)
		Me.button3.Margin = New System.Windows.Forms.Padding(2)
		Me.button3.Name = "button3"
		Me.button3.Size = New System.Drawing.Size(110, 50)
		Me.button3.TabIndex = 2
		Me.button3.Text = "Weekly Projections"
		Me.button3.UseVisualStyleBackColor = false
		'
		'button4
		'
		Me.button4.BackColor = System.Drawing.SystemColors.ButtonFace
		Me.button4.Enabled = false
		Me.button4.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace
		Me.button4.FlatAppearance.BorderSize = 2
		Me.button4.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonHighlight
		Me.button4.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight
		Me.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.button4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.button4.Location = New System.Drawing.Point(344, 88)
		Me.button4.Margin = New System.Windows.Forms.Padding(2)
		Me.button4.Name = "button4"
		Me.button4.Size = New System.Drawing.Size(110, 50)
		Me.button4.TabIndex = 3
		Me.button4.Text = "Rate my Team"
		Me.button4.UseVisualStyleBackColor = false
		'
		'horDiv
		'
		Me.horDiv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.horDiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.horDiv.Location = New System.Drawing.Point(2, 223)
		Me.horDiv.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.horDiv.Name = "horDiv"
		Me.horDiv.Size = New System.Drawing.Size(460, 4)
		Me.horDiv.TabIndex = 4
		'
		'button5
		'
		Me.button5.BackColor = System.Drawing.SystemColors.ButtonFace
		Me.button5.Enabled = false
		Me.button5.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace
		Me.button5.FlatAppearance.BorderSize = 2
		Me.button5.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonHighlight
		Me.button5.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight
		Me.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.button5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.button5.Location = New System.Drawing.Point(116, 88)
		Me.button5.Margin = New System.Windows.Forms.Padding(2)
		Me.button5.Name = "button5"
		Me.button5.Size = New System.Drawing.Size(110, 50)
		Me.button5.TabIndex = 5
		Me.button5.Text = "Playoffs"
		Me.button5.UseVisualStyleBackColor = false
		'
		'button6
		'
		Me.button6.BackColor = System.Drawing.SystemColors.ButtonFace
		Me.button6.Enabled = false
		Me.button6.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace
		Me.button6.FlatAppearance.BorderSize = 2
		Me.button6.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonHighlight
		Me.button6.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight
		Me.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.button6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.button6.Location = New System.Drawing.Point(116, 142)
		Me.button6.Margin = New System.Windows.Forms.Padding(2)
		Me.button6.Name = "button6"
		Me.button6.Size = New System.Drawing.Size(110, 50)
		Me.button6.TabIndex = 6
		Me.button6.Text = "Regular Season"
		Me.button6.UseVisualStyleBackColor = false
		'
		'button7
		'
		Me.button7.BackColor = System.Drawing.SystemColors.ButtonFace
		Me.button7.Enabled = false
		Me.button7.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace
		Me.button7.FlatAppearance.BorderSize = 2
		Me.button7.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonHighlight
		Me.button7.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight
		Me.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.button7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.button7.Location = New System.Drawing.Point(230, 142)
		Me.button7.Margin = New System.Windows.Forms.Padding(2)
		Me.button7.Name = "button7"
		Me.button7.Size = New System.Drawing.Size(110, 50)
		Me.button7.TabIndex = 9
		Me.button7.Text = "Trade Judge"
		Me.button7.UseVisualStyleBackColor = false
		'
		'button8
		'
		Me.button8.BackColor = System.Drawing.SystemColors.ButtonFace
		Me.button8.Enabled = false
		Me.button8.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace
		Me.button8.FlatAppearance.BorderSize = 2
		Me.button8.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonHighlight
		Me.button8.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight
		Me.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.button8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.button8.Location = New System.Drawing.Point(230, 88)
		Me.button8.Margin = New System.Windows.Forms.Padding(2)
		Me.button8.Name = "button8"
		Me.button8.Size = New System.Drawing.Size(110, 50)
		Me.button8.TabIndex = 8
		Me.button8.Text = "Trade Finder"
		Me.button8.UseVisualStyleBackColor = false
		'
		'button9
		'
		Me.button9.BackColor = System.Drawing.SystemColors.ButtonFace
		Me.button9.Enabled = false
		Me.button9.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace
		Me.button9.FlatAppearance.BorderSize = 2
		Me.button9.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonHighlight
		Me.button9.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight
		Me.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.button9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.button9.Location = New System.Drawing.Point(230, 34)
		Me.button9.Margin = New System.Windows.Forms.Padding(2)
		Me.button9.Name = "button9"
		Me.button9.Size = New System.Drawing.Size(110, 50)
		Me.button9.TabIndex = 7
		Me.button9.Text = "Waiver Wire Analysis"
		Me.button9.UseVisualStyleBackColor = false
		'
		'progressBar1
		'
		Me.progressBar1.Location = New System.Drawing.Point(7, 52)
		Me.progressBar1.Name = "progressBar1"
		Me.progressBar1.Size = New System.Drawing.Size(442, 34)
		Me.progressBar1.TabIndex = 10
		'
		'label1
		'
		Me.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.label1.Font = New System.Drawing.Font("Verdana", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label1.Location = New System.Drawing.Point(12, 19)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(437, 30)
		Me.label1.TabIndex = 11
		Me.label1.Text = "Loading..."
		Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.ClientSize = New System.Drawing.Size(461, 262)
		Me.Controls.Add(Me.label1)
		Me.Controls.Add(Me.progressBar1)
		Me.Controls.Add(Me.button7)
		Me.Controls.Add(Me.button8)
		Me.Controls.Add(Me.button9)
		Me.Controls.Add(Me.button6)
		Me.Controls.Add(Me.button5)
		Me.Controls.Add(Me.horDiv)
		Me.Controls.Add(Me.button4)
		Me.Controls.Add(Me.button3)
		Me.Controls.Add(Me.button2)
		Me.Controls.Add(Me.button1)
		Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
		Me.Margin = New System.Windows.Forms.Padding(2)
		Me.Name = "MainForm"
		Me.Text = "VOR Fantasy Tool Kit"
		AddHandler Load, AddressOf Me.MainFormLoad
		Me.ResumeLayout(false)
	End Sub
	Private label1 As System.Windows.Forms.Label
	Private progressBar1 As System.Windows.Forms.ProgressBar
	Private button9 As System.Windows.Forms.Button
	Private button8 As System.Windows.Forms.Button
	Private button7 As System.Windows.Forms.Button
	Private button6 As System.Windows.Forms.Button
	Private button5 As System.Windows.Forms.Button
	Private horDiv As System.Windows.Forms.Label
	Private button4 As System.Windows.Forms.Button
	Private button3 As System.Windows.Forms.Button
	Private button2 As System.Windows.Forms.Button
	Private button1 As System.Windows.Forms.Button
End Class
