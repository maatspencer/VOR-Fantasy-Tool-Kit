Partial Class DraftKit
	Inherits System.Windows.Forms.Form
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
		Dim chartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
		Dim legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
		Dim series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
		Dim title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DraftKit))
		Me.tbFLEX = New System.Windows.Forms.TabPage()
		Me.button13 = New System.Windows.Forms.Button()
		Me.button14 = New System.Windows.Forms.Button()
		Me.lbFLEX = New System.Windows.Forms.ListBox()
		Me.tbDST = New System.Windows.Forms.TabPage()
		Me.button11 = New System.Windows.Forms.Button()
		Me.button12 = New System.Windows.Forms.Button()
		Me.lbDST = New System.Windows.Forms.ListBox()
		Me.tbPK = New System.Windows.Forms.TabPage()
		Me.button9 = New System.Windows.Forms.Button()
		Me.button10 = New System.Windows.Forms.Button()
		Me.lbPK = New System.Windows.Forms.ListBox()
		Me.tbTE = New System.Windows.Forms.TabPage()
		Me.removeTE = New System.Windows.Forms.Button()
		Me.draftTE = New System.Windows.Forms.Button()
		Me.lbTE = New System.Windows.Forms.ListBox()
		Me.tbWR = New System.Windows.Forms.TabPage()
		Me.removeWR = New System.Windows.Forms.Button()
		Me.draftWR = New System.Windows.Forms.Button()
		Me.lbWR = New System.Windows.Forms.ListBox()
		Me.tbRB = New System.Windows.Forms.TabPage()
		Me.removeRB = New System.Windows.Forms.Button()
		Me.draftRB = New System.Windows.Forms.Button()
		Me.lbRB = New System.Windows.Forms.ListBox()
		Me.tbQB = New System.Windows.Forms.TabPage()
		Me.removeQB = New System.Windows.Forms.Button()
		Me.draftQB = New System.Windows.Forms.Button()
		Me.lbQB = New System.Windows.Forms.ListBox()
		Me.Overall = New System.Windows.Forms.TabPage()
		Me.Remove = New System.Windows.Forms.Button()
		Me.Draft = New System.Windows.Forms.Button()
		Me.lbOverall = New System.Windows.Forms.ListBox()
		Me.tabControl1 = New System.Windows.Forms.TabControl()
		Me.lPosition = New System.Windows.Forms.Label()
		Me.lName = New System.Windows.Forms.Label()
		Me.lBirthday = New System.Windows.Forms.Label()
		Me.lLower = New System.Windows.Forms.Label()
		Me.lPoints = New System.Windows.Forms.Label()
		Me.lUpper = New System.Windows.Forms.Label()
		Me.lVOR = New System.Windows.Forms.Label()
		Me.lOverall = New System.Windows.Forms.Label()
		Me.lPosRank = New System.Windows.Forms.Label()
		Me.lDropoff = New System.Windows.Forms.Label()
		Me.lTier = New System.Windows.Forms.Label()
		Me.lADP = New System.Windows.Forms.Label()
		Me.lECR = New System.Windows.Forms.Label()
		Me.lECRPos = New System.Windows.Forms.Label()
		Me.lRisk = New System.Windows.Forms.Label()
		Me.chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
		Me.divLine = New System.Windows.Forms.Label()
		Me.myTeam = New System.Windows.Forms.Label()
		Me.tQB = New System.Windows.Forms.Label()
		Me.tRB1 = New System.Windows.Forms.Label()
		Me.tRB2 = New System.Windows.Forms.Label()
		Me.tWR1 = New System.Windows.Forms.Label()
		Me.tFLEX1 = New System.Windows.Forms.Label()
		Me.tFLEX2 = New System.Windows.Forms.Label()
		Me.tPK = New System.Windows.Forms.Label()
		Me.tDST = New System.Windows.Forms.Label()
		Me.label8 = New System.Windows.Forms.Label()
		Me.tB8 = New System.Windows.Forms.Label()
		Me.tB7 = New System.Windows.Forms.Label()
		Me.tB6 = New System.Windows.Forms.Label()
		Me.tB5 = New System.Windows.Forms.Label()
		Me.tB4 = New System.Windows.Forms.Label()
		Me.tB3 = New System.Windows.Forms.Label()
		Me.tB2 = New System.Windows.Forms.Label()
		Me.tB1 = New System.Windows.Forms.Label()
		Me.dQBs = New System.Windows.Forms.Label()
		Me.dRBs = New System.Windows.Forms.Label()
		Me.dWRs = New System.Windows.Forms.Label()
		Me.dTEs = New System.Windows.Forms.Label()
		Me.dPKs = New System.Windows.Forms.Label()
		Me.dDSTs = New System.Windows.Forms.Label()
		Me.dTotal = New System.Windows.Forms.Label()
		Me.dFLEX = New System.Windows.Forms.Label()
		Me.tbFLEX.SuspendLayout
		Me.tbDST.SuspendLayout
		Me.tbPK.SuspendLayout
		Me.tbTE.SuspendLayout
		Me.tbWR.SuspendLayout
		Me.tbRB.SuspendLayout
		Me.tbQB.SuspendLayout
		Me.Overall.SuspendLayout
		Me.tabControl1.SuspendLayout
		CType(Me.chart1,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'tbFLEX
		'
		Me.tbFLEX.Controls.Add(Me.button13)
		Me.tbFLEX.Controls.Add(Me.button14)
		Me.tbFLEX.Controls.Add(Me.lbFLEX)
		Me.tbFLEX.Location = New System.Drawing.Point(4, 25)
		Me.tbFLEX.Name = "tbFLEX"
		Me.tbFLEX.Size = New System.Drawing.Size(397, 502)
		Me.tbFLEX.TabIndex = 7
		Me.tbFLEX.Text = "FLEX"
		Me.tbFLEX.UseVisualStyleBackColor = true
		'
		'button13
		'
		Me.button13.Location = New System.Drawing.Point(211, 462)
		Me.button13.Name = "button13"
		Me.button13.Size = New System.Drawing.Size(164, 23)
		Me.button13.TabIndex = 4
		Me.button13.Text = "Remove"
		Me.button13.UseVisualStyleBackColor = true
		AddHandler Me.button13.Click, AddressOf Me.RemoveClick
		'
		'button14
		'
		Me.button14.Location = New System.Drawing.Point(22, 462)
		Me.button14.Name = "button14"
		Me.button14.Size = New System.Drawing.Size(164, 23)
		Me.button14.TabIndex = 3
		Me.button14.Text = "Draft"
		Me.button14.UseVisualStyleBackColor = true
		AddHandler Me.button14.Click, AddressOf Me.DraftClick
		'
		'lbFLEX
		'
		Me.lbFLEX.FormattingEnabled = true
		Me.lbFLEX.ItemHeight = 16
		Me.lbFLEX.Location = New System.Drawing.Point(22, 20)
		Me.lbFLEX.Name = "lbFLEX"
		Me.lbFLEX.Size = New System.Drawing.Size(353, 436)
		Me.lbFLEX.TabIndex = 1
		AddHandler Me.lbFLEX.SelectedIndexChanged, AddressOf Me.LbFLEXSelectedIndexChanged
		'
		'tbDST
		'
		Me.tbDST.Controls.Add(Me.button11)
		Me.tbDST.Controls.Add(Me.button12)
		Me.tbDST.Controls.Add(Me.lbDST)
		Me.tbDST.Location = New System.Drawing.Point(4, 25)
		Me.tbDST.Name = "tbDST"
		Me.tbDST.Size = New System.Drawing.Size(397, 502)
		Me.tbDST.TabIndex = 6
		Me.tbDST.Text = "DST"
		Me.tbDST.UseVisualStyleBackColor = true
		'
		'button11
		'
		Me.button11.Location = New System.Drawing.Point(211, 460)
		Me.button11.Name = "button11"
		Me.button11.Size = New System.Drawing.Size(164, 23)
		Me.button11.TabIndex = 4
		Me.button11.Text = "Remove"
		Me.button11.UseVisualStyleBackColor = true
		AddHandler Me.button11.Click, AddressOf Me.RemoveClick
		'
		'button12
		'
		Me.button12.Location = New System.Drawing.Point(22, 460)
		Me.button12.Name = "button12"
		Me.button12.Size = New System.Drawing.Size(164, 23)
		Me.button12.TabIndex = 3
		Me.button12.Text = "Draft"
		Me.button12.UseVisualStyleBackColor = true
		AddHandler Me.button12.Click, AddressOf Me.DraftClick
		'
		'lbDST
		'
		Me.lbDST.FormattingEnabled = true
		Me.lbDST.ItemHeight = 16
		Me.lbDST.Location = New System.Drawing.Point(22, 18)
		Me.lbDST.Name = "lbDST"
		Me.lbDST.Size = New System.Drawing.Size(353, 436)
		Me.lbDST.TabIndex = 1
		AddHandler Me.lbDST.SelectedIndexChanged, AddressOf Me.LbDSTSelectedIndexChanged
		'
		'tbPK
		'
		Me.tbPK.Controls.Add(Me.button9)
		Me.tbPK.Controls.Add(Me.button10)
		Me.tbPK.Controls.Add(Me.lbPK)
		Me.tbPK.Location = New System.Drawing.Point(4, 25)
		Me.tbPK.Name = "tbPK"
		Me.tbPK.Size = New System.Drawing.Size(397, 502)
		Me.tbPK.TabIndex = 5
		Me.tbPK.Text = "PK"
		Me.tbPK.UseVisualStyleBackColor = true
		'
		'button9
		'
		Me.button9.Location = New System.Drawing.Point(211, 464)
		Me.button9.Name = "button9"
		Me.button9.Size = New System.Drawing.Size(164, 23)
		Me.button9.TabIndex = 4
		Me.button9.Text = "Remove"
		Me.button9.UseVisualStyleBackColor = true
		AddHandler Me.button9.Click, AddressOf Me.RemoveClick
		'
		'button10
		'
		Me.button10.Location = New System.Drawing.Point(22, 464)
		Me.button10.Name = "button10"
		Me.button10.Size = New System.Drawing.Size(164, 23)
		Me.button10.TabIndex = 3
		Me.button10.Text = "Draft"
		Me.button10.UseVisualStyleBackColor = true
		AddHandler Me.button10.Click, AddressOf Me.DraftClick
		'
		'lbPK
		'
		Me.lbPK.FormattingEnabled = true
		Me.lbPK.ItemHeight = 16
		Me.lbPK.Location = New System.Drawing.Point(22, 22)
		Me.lbPK.Name = "lbPK"
		Me.lbPK.Size = New System.Drawing.Size(353, 436)
		Me.lbPK.TabIndex = 1
		AddHandler Me.lbPK.SelectedIndexChanged, AddressOf Me.LbPKSelectedIndexChanged
		'
		'tbTE
		'
		Me.tbTE.Controls.Add(Me.removeTE)
		Me.tbTE.Controls.Add(Me.draftTE)
		Me.tbTE.Controls.Add(Me.lbTE)
		Me.tbTE.Location = New System.Drawing.Point(4, 25)
		Me.tbTE.Name = "tbTE"
		Me.tbTE.Size = New System.Drawing.Size(397, 502)
		Me.tbTE.TabIndex = 4
		Me.tbTE.Text = "TE"
		Me.tbTE.UseVisualStyleBackColor = true
		'
		'removeTE
		'
		Me.removeTE.Location = New System.Drawing.Point(211, 462)
		Me.removeTE.Name = "removeTE"
		Me.removeTE.Size = New System.Drawing.Size(164, 23)
		Me.removeTE.TabIndex = 4
		Me.removeTE.Text = "Remove"
		Me.removeTE.UseVisualStyleBackColor = true
		AddHandler Me.removeTE.Click, AddressOf Me.RemoveClick
		'
		'draftTE
		'
		Me.draftTE.Location = New System.Drawing.Point(22, 462)
		Me.draftTE.Name = "draftTE"
		Me.draftTE.Size = New System.Drawing.Size(164, 23)
		Me.draftTE.TabIndex = 3
		Me.draftTE.Text = "Draft"
		Me.draftTE.UseVisualStyleBackColor = true
		AddHandler Me.draftTE.Click, AddressOf Me.DraftClick
		'
		'lbTE
		'
		Me.lbTE.FormattingEnabled = true
		Me.lbTE.ItemHeight = 16
		Me.lbTE.Location = New System.Drawing.Point(22, 20)
		Me.lbTE.Name = "lbTE"
		Me.lbTE.Size = New System.Drawing.Size(353, 436)
		Me.lbTE.TabIndex = 1
		AddHandler Me.lbTE.SelectedIndexChanged, AddressOf Me.LbTESelectedIndexChanged
		'
		'tbWR
		'
		Me.tbWR.Controls.Add(Me.removeWR)
		Me.tbWR.Controls.Add(Me.draftWR)
		Me.tbWR.Controls.Add(Me.lbWR)
		Me.tbWR.Location = New System.Drawing.Point(4, 25)
		Me.tbWR.Name = "tbWR"
		Me.tbWR.Size = New System.Drawing.Size(397, 502)
		Me.tbWR.TabIndex = 3
		Me.tbWR.Text = "WR"
		Me.tbWR.UseVisualStyleBackColor = true
		'
		'removeWR
		'
		Me.removeWR.Location = New System.Drawing.Point(211, 467)
		Me.removeWR.Name = "removeWR"
		Me.removeWR.Size = New System.Drawing.Size(164, 23)
		Me.removeWR.TabIndex = 4
		Me.removeWR.Text = "Remove"
		Me.removeWR.UseVisualStyleBackColor = true
		AddHandler Me.removeWR.Click, AddressOf Me.RemoveClick
		'
		'draftWR
		'
		Me.draftWR.Location = New System.Drawing.Point(22, 467)
		Me.draftWR.Name = "draftWR"
		Me.draftWR.Size = New System.Drawing.Size(164, 23)
		Me.draftWR.TabIndex = 3
		Me.draftWR.Text = "Draft"
		Me.draftWR.UseVisualStyleBackColor = true
		AddHandler Me.draftWR.Click, AddressOf Me.DraftClick
		'
		'lbWR
		'
		Me.lbWR.FormattingEnabled = true
		Me.lbWR.ItemHeight = 16
		Me.lbWR.Location = New System.Drawing.Point(22, 25)
		Me.lbWR.Name = "lbWR"
		Me.lbWR.Size = New System.Drawing.Size(353, 436)
		Me.lbWR.TabIndex = 1
		AddHandler Me.lbWR.SelectedIndexChanged, AddressOf Me.LbWRSelectedIndexChanged
		'
		'tbRB
		'
		Me.tbRB.Controls.Add(Me.removeRB)
		Me.tbRB.Controls.Add(Me.draftRB)
		Me.tbRB.Controls.Add(Me.lbRB)
		Me.tbRB.Location = New System.Drawing.Point(4, 25)
		Me.tbRB.Name = "tbRB"
		Me.tbRB.Size = New System.Drawing.Size(397, 502)
		Me.tbRB.TabIndex = 2
		Me.tbRB.Text = "RB"
		Me.tbRB.UseVisualStyleBackColor = true
		'
		'removeRB
		'
		Me.removeRB.Location = New System.Drawing.Point(211, 462)
		Me.removeRB.Name = "removeRB"
		Me.removeRB.Size = New System.Drawing.Size(164, 23)
		Me.removeRB.TabIndex = 4
		Me.removeRB.Text = "Remove"
		Me.removeRB.UseVisualStyleBackColor = true
		AddHandler Me.removeRB.Click, AddressOf Me.RemoveClick
		'
		'draftRB
		'
		Me.draftRB.AllowDrop = true
		Me.draftRB.Location = New System.Drawing.Point(22, 462)
		Me.draftRB.Name = "draftRB"
		Me.draftRB.Size = New System.Drawing.Size(164, 23)
		Me.draftRB.TabIndex = 3
		Me.draftRB.Text = "Draft"
		Me.draftRB.UseVisualStyleBackColor = true
		AddHandler Me.draftRB.Click, AddressOf Me.DraftClick
		'
		'lbRB
		'
		Me.lbRB.FormattingEnabled = true
		Me.lbRB.ItemHeight = 16
		Me.lbRB.Location = New System.Drawing.Point(22, 20)
		Me.lbRB.Name = "lbRB"
		Me.lbRB.Size = New System.Drawing.Size(353, 436)
		Me.lbRB.TabIndex = 1
		AddHandler Me.lbRB.SelectedIndexChanged, AddressOf Me.LbRBSelectedIndexChanged
		'
		'tbQB
		'
		Me.tbQB.Controls.Add(Me.removeQB)
		Me.tbQB.Controls.Add(Me.draftQB)
		Me.tbQB.Controls.Add(Me.lbQB)
		Me.tbQB.Location = New System.Drawing.Point(4, 25)
		Me.tbQB.Name = "tbQB"
		Me.tbQB.Padding = New System.Windows.Forms.Padding(3)
		Me.tbQB.Size = New System.Drawing.Size(397, 502)
		Me.tbQB.TabIndex = 1
		Me.tbQB.Text = "QB"
		Me.tbQB.UseVisualStyleBackColor = true
		'
		'removeQB
		'
		Me.removeQB.Location = New System.Drawing.Point(211, 461)
		Me.removeQB.Name = "removeQB"
		Me.removeQB.Size = New System.Drawing.Size(164, 23)
		Me.removeQB.TabIndex = 4
		Me.removeQB.Text = "Remove"
		Me.removeQB.UseVisualStyleBackColor = true
		AddHandler Me.removeQB.Click, AddressOf Me.RemoveClick
		'
		'draftQB
		'
		Me.draftQB.Location = New System.Drawing.Point(22, 461)
		Me.draftQB.Name = "draftQB"
		Me.draftQB.Size = New System.Drawing.Size(164, 23)
		Me.draftQB.TabIndex = 3
		Me.draftQB.Text = "Draft"
		Me.draftQB.UseVisualStyleBackColor = true
		AddHandler Me.draftQB.Click, AddressOf Me.DraftClick
		'
		'lbQB
		'
		Me.lbQB.FormattingEnabled = true
		Me.lbQB.ItemHeight = 16
		Me.lbQB.Location = New System.Drawing.Point(22, 19)
		Me.lbQB.Name = "lbQB"
		Me.lbQB.Size = New System.Drawing.Size(353, 436)
		Me.lbQB.TabIndex = 1
		AddHandler Me.lbQB.SelectedIndexChanged, AddressOf Me.LbQBSelectedIndexChanged
		'
		'Overall
		'
		Me.Overall.Controls.Add(Me.Remove)
		Me.Overall.Controls.Add(Me.Draft)
		Me.Overall.Controls.Add(Me.lbOverall)
		Me.Overall.Location = New System.Drawing.Point(4, 25)
		Me.Overall.Name = "Overall"
		Me.Overall.Padding = New System.Windows.Forms.Padding(3)
		Me.Overall.Size = New System.Drawing.Size(397, 502)
		Me.Overall.TabIndex = 0
		Me.Overall.Text = "Overall"
		Me.Overall.UseVisualStyleBackColor = true
		'
		'Remove
		'
		Me.Remove.Location = New System.Drawing.Point(208, 461)
		Me.Remove.Name = "Remove"
		Me.Remove.Size = New System.Drawing.Size(164, 23)
		Me.Remove.TabIndex = 2
		Me.Remove.Text = "Remove"
		Me.Remove.UseVisualStyleBackColor = true
		AddHandler Me.Remove.Click, AddressOf Me.RemoveClick
		'
		'Draft
		'
		Me.Draft.Location = New System.Drawing.Point(19, 461)
		Me.Draft.Name = "Draft"
		Me.Draft.Size = New System.Drawing.Size(164, 23)
		Me.Draft.TabIndex = 1
		Me.Draft.Text = "Draft"
		Me.Draft.UseVisualStyleBackColor = true
		AddHandler Me.Draft.Click, AddressOf Me.DraftClick
		'
		'lbOverall
		'
		Me.lbOverall.FormattingEnabled = true
		Me.lbOverall.ItemHeight = 16
		Me.lbOverall.Location = New System.Drawing.Point(19, 19)
		Me.lbOverall.Name = "lbOverall"
		Me.lbOverall.Size = New System.Drawing.Size(353, 436)
		Me.lbOverall.TabIndex = 0
		AddHandler Me.lbOverall.SelectedIndexChanged, AddressOf Me.LbOverallSelectedIndexChanged
		'
		'tabControl1
		'
		Me.tabControl1.Controls.Add(Me.Overall)
		Me.tabControl1.Controls.Add(Me.tbQB)
		Me.tabControl1.Controls.Add(Me.tbRB)
		Me.tabControl1.Controls.Add(Me.tbWR)
		Me.tabControl1.Controls.Add(Me.tbTE)
		Me.tabControl1.Controls.Add(Me.tbPK)
		Me.tabControl1.Controls.Add(Me.tbDST)
		Me.tabControl1.Controls.Add(Me.tbFLEX)
		Me.tabControl1.Location = New System.Drawing.Point(12, 12)
		Me.tabControl1.Name = "tabControl1"
		Me.tabControl1.SelectedIndex = 0
		Me.tabControl1.Size = New System.Drawing.Size(405, 531)
		Me.tabControl1.TabIndex = 0
		AddHandler Me.tabControl1.SelectedIndexChanged, AddressOf Me.TabControl1SelectedIndexChanged
		'
		'lPosition
		'
		Me.lPosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.lPosition.Font = New System.Drawing.Font("Imprint MT Shadow", 16!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lPosition.Location = New System.Drawing.Point(430, 37)
		Me.lPosition.Name = "lPosition"
		Me.lPosition.Size = New System.Drawing.Size(93, 35)
		Me.lPosition.TabIndex = 1
		Me.lPosition.Text = "RB"
		'
		'lName
		'
		Me.lName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.lName.Font = New System.Drawing.Font("Verdana", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lName.Location = New System.Drawing.Point(430, 72)
		Me.lName.Name = "lName"
		Me.lName.Size = New System.Drawing.Size(331, 35)
		Me.lName.TabIndex = 2
		Me.lName.Text = "Antonio Brown, PIT"
		'
		'lBirthday
		'
		Me.lBirthday.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.lBirthday.Font = New System.Drawing.Font("Verdana", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lBirthday.Location = New System.Drawing.Point(430, 96)
		Me.lBirthday.Name = "lBirthday"
		Me.lBirthday.Size = New System.Drawing.Size(368, 35)
		Me.lBirthday.TabIndex = 3
		Me.lBirthday.Text = "Birthday: 7-10-1988 (6 years)"
		'
		'lLower
		'
		Me.lLower.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.lLower.Font = New System.Drawing.Font("Verdana", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lLower.ForeColor = System.Drawing.Color.Red
		Me.lLower.Location = New System.Drawing.Point(430, 131)
		Me.lLower.Name = "lLower"
		Me.lLower.Size = New System.Drawing.Size(99, 35)
		Me.lLower.TabIndex = 4
		Me.lLower.Text = "Lower"
		'
		'lPoints
		'
		Me.lPoints.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.lPoints.Font = New System.Drawing.Font("Verdana", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lPoints.Location = New System.Drawing.Point(430, 154)
		Me.lPoints.Name = "lPoints"
		Me.lPoints.Size = New System.Drawing.Size(99, 35)
		Me.lPoints.TabIndex = 5
		Me.lPoints.Text = "Points"
		'
		'lUpper
		'
		Me.lUpper.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.lUpper.Font = New System.Drawing.Font("Verdana", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lUpper.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(192,Byte),Integer), CType(CType(0,Byte),Integer))
		Me.lUpper.Location = New System.Drawing.Point(430, 176)
		Me.lUpper.Name = "lUpper"
		Me.lUpper.Size = New System.Drawing.Size(99, 35)
		Me.lUpper.TabIndex = 6
		Me.lUpper.Text = "Upper"
		'
		'lVOR
		'
		Me.lVOR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.lVOR.Font = New System.Drawing.Font("Verdana", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lVOR.Location = New System.Drawing.Point(542, 154)
		Me.lVOR.Name = "lVOR"
		Me.lVOR.Size = New System.Drawing.Size(97, 35)
		Me.lVOR.TabIndex = 7
		Me.lVOR.Text = "VOR"
		'
		'lOverall
		'
		Me.lOverall.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.lOverall.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lOverall.Location = New System.Drawing.Point(430, 221)
		Me.lOverall.Name = "lOverall"
		Me.lOverall.Size = New System.Drawing.Size(163, 22)
		Me.lOverall.TabIndex = 8
		Me.lOverall.Text = "Overall Rank: 1"
		'
		'lPosRank
		'
		Me.lPosRank.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.lPosRank.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lPosRank.Location = New System.Drawing.Point(430, 243)
		Me.lPosRank.Name = "lPosRank"
		Me.lPosRank.Size = New System.Drawing.Size(163, 25)
		Me.lPosRank.TabIndex = 9
		Me.lPosRank.Text = "Position Rank: 1"
		'
		'lDropoff
		'
		Me.lDropoff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.lDropoff.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lDropoff.Location = New System.Drawing.Point(430, 338)
		Me.lDropoff.Name = "lDropoff"
		Me.lDropoff.Size = New System.Drawing.Size(331, 25)
		Me.lDropoff.TabIndex = 10
		Me.lDropoff.Text = "Dropoff: ...."
		'
		'lTier
		'
		Me.lTier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.lTier.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lTier.Location = New System.Drawing.Point(430, 363)
		Me.lTier.Name = "lTier"
		Me.lTier.Size = New System.Drawing.Size(331, 24)
		Me.lTier.TabIndex = 11
		Me.lTier.Text = "Tier: ...."
		'
		'lADP
		'
		Me.lADP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.lADP.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lADP.Location = New System.Drawing.Point(430, 313)
		Me.lADP.Name = "lADP"
		Me.lADP.Size = New System.Drawing.Size(331, 25)
		Me.lADP.TabIndex = 12
		Me.lADP.Text = "ADP: ...."
		'
		'lECR
		'
		Me.lECR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.lECR.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lECR.Location = New System.Drawing.Point(430, 268)
		Me.lECR.Name = "lECR"
		Me.lECR.Size = New System.Drawing.Size(331, 22)
		Me.lECR.TabIndex = 13
		Me.lECR.Text = "ECR: ...."
		'
		'lECRPos
		'
		Me.lECRPos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.lECRPos.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lECRPos.Location = New System.Drawing.Point(430, 290)
		Me.lECRPos.Name = "lECRPos"
		Me.lECRPos.Size = New System.Drawing.Size(331, 23)
		Me.lECRPos.TabIndex = 14
		Me.lECRPos.Text = "ECR Position: ...."
		'
		'lRisk
		'
		Me.lRisk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.lRisk.Font = New System.Drawing.Font("Verdana", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.lRisk.Location = New System.Drawing.Point(804, 56)
		Me.lRisk.Name = "lRisk"
		Me.lRisk.Size = New System.Drawing.Size(288, 35)
		Me.lRisk.TabIndex = 17
		Me.lRisk.Text = "Risk"
		'
		'chart1
		'
		Me.chart1.BackColor = System.Drawing.SystemColors.Control
		Me.chart1.BackImageTransparentColor = System.Drawing.SystemColors.Control
		Me.chart1.BackSecondaryColor = System.Drawing.SystemColors.Control
		Me.chart1.BorderlineColor = System.Drawing.SystemColors.Control
		Me.chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Raised
		chartArea1.Area3DStyle.Enable3D = true
		chartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic
		chartArea1.Name = "ChartArea1"
		Me.chart1.ChartAreas.Add(chartArea1)
		legend1.Name = "Legend1"
		Me.chart1.Legends.Add(legend1)
		Me.chart1.Location = New System.Drawing.Point(804, 94)
		Me.chart1.Name = "chart1"
		Me.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel
		series1.ChartArea = "ChartArea1"
		series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point
		series1.Legend = "Legend1"
		series1.Name = "Risk"
		Me.chart1.Series.Add(series1)
		Me.chart1.Size = New System.Drawing.Size(440, 269)
		Me.chart1.TabIndex = 16
		Me.chart1.Text = "chart1"
		title1.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		title1.Name = "Risk"
		title1.Text = "Risk"
		Me.chart1.Titles.Add(title1)
		'
		'divLine
		'
		Me.divLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.divLine.Location = New System.Drawing.Point(430, 385)
		Me.divLine.Name = "divLine"
		Me.divLine.Size = New System.Drawing.Size(814, 3)
		Me.divLine.TabIndex = 18
		'
		'myTeam
		'
		Me.myTeam.Font = New System.Drawing.Font("Verdana", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.myTeam.Location = New System.Drawing.Point(430, 398)
		Me.myTeam.Name = "myTeam"
		Me.myTeam.Size = New System.Drawing.Size(209, 23)
		Me.myTeam.TabIndex = 19
		Me.myTeam.Text = "My Starters"
		'
		'tQB
		'
		Me.tQB.Font = New System.Drawing.Font("Verdana", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.tQB.ForeColor = System.Drawing.Color.Blue
		Me.tQB.Location = New System.Drawing.Point(430, 421)
		Me.tQB.Name = "tQB"
		Me.tQB.Size = New System.Drawing.Size(303, 23)
		Me.tQB.TabIndex = 20
		Me.tQB.Text = "QB"
		'
		'tRB1
		'
		Me.tRB1.Font = New System.Drawing.Font("Verdana", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.tRB1.ForeColor = System.Drawing.Color.Red
		Me.tRB1.Location = New System.Drawing.Point(430, 444)
		Me.tRB1.Name = "tRB1"
		Me.tRB1.Size = New System.Drawing.Size(303, 23)
		Me.tRB1.TabIndex = 21
		Me.tRB1.Text = "RB1"
		'
		'tRB2
		'
		Me.tRB2.Font = New System.Drawing.Font("Verdana", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.tRB2.ForeColor = System.Drawing.Color.Red
		Me.tRB2.Location = New System.Drawing.Point(430, 467)
		Me.tRB2.Name = "tRB2"
		Me.tRB2.Size = New System.Drawing.Size(303, 23)
		Me.tRB2.TabIndex = 22
		Me.tRB2.Text = "RB2"
		'
		'tWR1
		'
		Me.tWR1.Font = New System.Drawing.Font("Verdana", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.tWR1.ForeColor = System.Drawing.Color.Fuchsia
		Me.tWR1.Location = New System.Drawing.Point(430, 490)
		Me.tWR1.Name = "tWR1"
		Me.tWR1.Size = New System.Drawing.Size(303, 23)
		Me.tWR1.TabIndex = 23
		Me.tWR1.Text = "WR1"
		'
		'tFLEX1
		'
		Me.tFLEX1.Font = New System.Drawing.Font("Verdana", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.tFLEX1.ForeColor = System.Drawing.Color.Green
		Me.tFLEX1.Location = New System.Drawing.Point(430, 513)
		Me.tFLEX1.Name = "tFLEX1"
		Me.tFLEX1.Size = New System.Drawing.Size(303, 23)
		Me.tFLEX1.TabIndex = 24
		Me.tFLEX1.Text = "FLEX1"
		'
		'tFLEX2
		'
		Me.tFLEX2.Font = New System.Drawing.Font("Verdana", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.tFLEX2.ForeColor = System.Drawing.Color.Green
		Me.tFLEX2.Location = New System.Drawing.Point(430, 534)
		Me.tFLEX2.Name = "tFLEX2"
		Me.tFLEX2.Size = New System.Drawing.Size(303, 23)
		Me.tFLEX2.TabIndex = 25
		Me.tFLEX2.Text = "FLEX2"
		'
		'tPK
		'
		Me.tPK.Font = New System.Drawing.Font("Verdana", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.tPK.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(128,Byte),Integer), CType(CType(0,Byte),Integer))
		Me.tPK.Location = New System.Drawing.Point(430, 555)
		Me.tPK.Name = "tPK"
		Me.tPK.Size = New System.Drawing.Size(303, 23)
		Me.tPK.TabIndex = 26
		Me.tPK.Text = "PK"
		'
		'tDST
		'
		Me.tDST.Font = New System.Drawing.Font("Verdana", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.tDST.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
		Me.tDST.Location = New System.Drawing.Point(430, 576)
		Me.tDST.Name = "tDST"
		Me.tDST.Size = New System.Drawing.Size(303, 23)
		Me.tDST.TabIndex = 27
		Me.tDST.Text = "DST"
		'
		'label8
		'
		Me.label8.Font = New System.Drawing.Font("Verdana", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline),System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.label8.Location = New System.Drawing.Point(741, 398)
		Me.label8.Name = "label8"
		Me.label8.Size = New System.Drawing.Size(123, 23)
		Me.label8.TabIndex = 28
		Me.label8.Text = "My Bench"
		'
		'tB8
		'
		Me.tB8.Font = New System.Drawing.Font("Verdana", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.tB8.Location = New System.Drawing.Point(741, 576)
		Me.tB8.Name = "tB8"
		Me.tB8.Size = New System.Drawing.Size(303, 23)
		Me.tB8.TabIndex = 36
		Me.tB8.Text = "BENCH 8"
		'
		'tB7
		'
		Me.tB7.Font = New System.Drawing.Font("Verdana", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.tB7.Location = New System.Drawing.Point(741, 555)
		Me.tB7.Name = "tB7"
		Me.tB7.Size = New System.Drawing.Size(303, 23)
		Me.tB7.TabIndex = 35
		Me.tB7.Text = "BENCH 7"
		'
		'tB6
		'
		Me.tB6.Font = New System.Drawing.Font("Verdana", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.tB6.Location = New System.Drawing.Point(741, 534)
		Me.tB6.Name = "tB6"
		Me.tB6.Size = New System.Drawing.Size(303, 23)
		Me.tB6.TabIndex = 34
		Me.tB6.Text = "BENCH 6"
		'
		'tB5
		'
		Me.tB5.Font = New System.Drawing.Font("Verdana", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.tB5.Location = New System.Drawing.Point(741, 513)
		Me.tB5.Name = "tB5"
		Me.tB5.Size = New System.Drawing.Size(303, 23)
		Me.tB5.TabIndex = 33
		Me.tB5.Text = "BENCH 5"
		'
		'tB4
		'
		Me.tB4.Font = New System.Drawing.Font("Verdana", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.tB4.Location = New System.Drawing.Point(741, 490)
		Me.tB4.Name = "tB4"
		Me.tB4.Size = New System.Drawing.Size(303, 23)
		Me.tB4.TabIndex = 32
		Me.tB4.Text = "BENCH 4"
		'
		'tB3
		'
		Me.tB3.Font = New System.Drawing.Font("Verdana", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.tB3.Location = New System.Drawing.Point(741, 467)
		Me.tB3.Name = "tB3"
		Me.tB3.Size = New System.Drawing.Size(303, 23)
		Me.tB3.TabIndex = 31
		Me.tB3.Text = "BENCH 3"
		'
		'tB2
		'
		Me.tB2.Font = New System.Drawing.Font("Verdana", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.tB2.Location = New System.Drawing.Point(741, 444)
		Me.tB2.Name = "tB2"
		Me.tB2.Size = New System.Drawing.Size(303, 23)
		Me.tB2.TabIndex = 30
		Me.tB2.Text = "BENCH 2"
		'
		'tB1
		'
		Me.tB1.Font = New System.Drawing.Font("Verdana", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.tB1.Location = New System.Drawing.Point(741, 421)
		Me.tB1.Name = "tB1"
		Me.tB1.Size = New System.Drawing.Size(303, 23)
		Me.tB1.TabIndex = 29
		Me.tB1.Text = "BENCH 1"
		'
		'dQBs
		'
		Me.dQBs.Font = New System.Drawing.Font("Verdana", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.dQBs.ForeColor = System.Drawing.Color.Navy
		Me.dQBs.Location = New System.Drawing.Point(1050, 421)
		Me.dQBs.Name = "dQBs"
		Me.dQBs.Size = New System.Drawing.Size(303, 23)
		Me.dQBs.TabIndex = 37
		Me.dQBs.Text = "QBs: 0"
		'
		'dRBs
		'
		Me.dRBs.Font = New System.Drawing.Font("Verdana", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.dRBs.ForeColor = System.Drawing.Color.Navy
		Me.dRBs.Location = New System.Drawing.Point(1050, 444)
		Me.dRBs.Name = "dRBs"
		Me.dRBs.Size = New System.Drawing.Size(303, 23)
		Me.dRBs.TabIndex = 38
		Me.dRBs.Text = "RBs: 0"
		'
		'dWRs
		'
		Me.dWRs.Font = New System.Drawing.Font("Verdana", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.dWRs.ForeColor = System.Drawing.Color.Navy
		Me.dWRs.Location = New System.Drawing.Point(1050, 467)
		Me.dWRs.Name = "dWRs"
		Me.dWRs.Size = New System.Drawing.Size(303, 23)
		Me.dWRs.TabIndex = 39
		Me.dWRs.Text = "WRs: 0"
		'
		'dTEs
		'
		Me.dTEs.Font = New System.Drawing.Font("Verdana", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.dTEs.ForeColor = System.Drawing.Color.Navy
		Me.dTEs.Location = New System.Drawing.Point(1050, 490)
		Me.dTEs.Name = "dTEs"
		Me.dTEs.Size = New System.Drawing.Size(303, 23)
		Me.dTEs.TabIndex = 40
		Me.dTEs.Text = "TEs: 0"
		'
		'dPKs
		'
		Me.dPKs.Font = New System.Drawing.Font("Verdana", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.dPKs.ForeColor = System.Drawing.Color.Navy
		Me.dPKs.Location = New System.Drawing.Point(1050, 513)
		Me.dPKs.Name = "dPKs"
		Me.dPKs.Size = New System.Drawing.Size(303, 23)
		Me.dPKs.TabIndex = 41
		Me.dPKs.Text = "PKs: 0"
		'
		'dDSTs
		'
		Me.dDSTs.Font = New System.Drawing.Font("Verdana", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.dDSTs.ForeColor = System.Drawing.Color.Navy
		Me.dDSTs.Location = New System.Drawing.Point(1050, 534)
		Me.dDSTs.Name = "dDSTs"
		Me.dDSTs.Size = New System.Drawing.Size(303, 23)
		Me.dDSTs.TabIndex = 42
		Me.dDSTs.Text = "DSTs: 0"
		'
		'dTotal
		'
		Me.dTotal.Font = New System.Drawing.Font("Verdana", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.dTotal.ForeColor = System.Drawing.Color.Navy
		Me.dTotal.Location = New System.Drawing.Point(1050, 576)
		Me.dTotal.Name = "dTotal"
		Me.dTotal.Size = New System.Drawing.Size(303, 23)
		Me.dTotal.TabIndex = 43
		Me.dTotal.Text = "Total: 0"
		'
		'dFLEX
		'
		Me.dFLEX.Font = New System.Drawing.Font("Verdana", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.dFLEX.ForeColor = System.Drawing.Color.Navy
		Me.dFLEX.Location = New System.Drawing.Point(1050, 555)
		Me.dFLEX.Name = "dFLEX"
		Me.dFLEX.Size = New System.Drawing.Size(303, 23)
		Me.dFLEX.TabIndex = 44
		Me.dFLEX.Text = "Flex: 0"
		'
		'DraftKit
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 16!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1256, 597)
		Me.Controls.Add(Me.dFLEX)
		Me.Controls.Add(Me.dTotal)
		Me.Controls.Add(Me.dDSTs)
		Me.Controls.Add(Me.dPKs)
		Me.Controls.Add(Me.dTEs)
		Me.Controls.Add(Me.dWRs)
		Me.Controls.Add(Me.dRBs)
		Me.Controls.Add(Me.dQBs)
		Me.Controls.Add(Me.tB8)
		Me.Controls.Add(Me.tB7)
		Me.Controls.Add(Me.tB6)
		Me.Controls.Add(Me.tB5)
		Me.Controls.Add(Me.tB4)
		Me.Controls.Add(Me.tB3)
		Me.Controls.Add(Me.tB2)
		Me.Controls.Add(Me.tB1)
		Me.Controls.Add(Me.label8)
		Me.Controls.Add(Me.tDST)
		Me.Controls.Add(Me.tPK)
		Me.Controls.Add(Me.tFLEX2)
		Me.Controls.Add(Me.tFLEX1)
		Me.Controls.Add(Me.tWR1)
		Me.Controls.Add(Me.tRB2)
		Me.Controls.Add(Me.tRB1)
		Me.Controls.Add(Me.tQB)
		Me.Controls.Add(Me.myTeam)
		Me.Controls.Add(Me.divLine)
		Me.Controls.Add(Me.chart1)
		Me.Controls.Add(Me.lRisk)
		Me.Controls.Add(Me.lECRPos)
		Me.Controls.Add(Me.lECR)
		Me.Controls.Add(Me.lADP)
		Me.Controls.Add(Me.lTier)
		Me.Controls.Add(Me.lDropoff)
		Me.Controls.Add(Me.lPosRank)
		Me.Controls.Add(Me.lOverall)
		Me.Controls.Add(Me.lVOR)
		Me.Controls.Add(Me.lUpper)
		Me.Controls.Add(Me.lPoints)
		Me.Controls.Add(Me.lLower)
		Me.Controls.Add(Me.lBirthday)
		Me.Controls.Add(Me.lName)
		Me.Controls.Add(Me.lPosition)
		Me.Controls.Add(Me.tabControl1)
		Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
		Me.Name = "DraftKit"
		Me.Text = "DraftKit"
		AddHandler Load, AddressOf Me.DraftKitLoad
		Me.tbFLEX.ResumeLayout(false)
		Me.tbDST.ResumeLayout(false)
		Me.tbPK.ResumeLayout(false)
		Me.tbTE.ResumeLayout(false)
		Me.tbWR.ResumeLayout(false)
		Me.tbRB.ResumeLayout(false)
		Me.tbQB.ResumeLayout(false)
		Me.Overall.ResumeLayout(false)
		Me.tabControl1.ResumeLayout(false)
		CType(Me.chart1,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)
	End Sub
	Private dFLEX As System.Windows.Forms.Label
	Private dTotal As System.Windows.Forms.Label
	Private dDSTs As System.Windows.Forms.Label
	Private dPKs As System.Windows.Forms.Label
	Private dTEs As System.Windows.Forms.Label
	Private dWRs As System.Windows.Forms.Label
	Private dRBs As System.Windows.Forms.Label
	Private dQBs As System.Windows.Forms.Label
	Private tB1 As System.Windows.Forms.Label
	Private tB2 As System.Windows.Forms.Label
	Private tB3 As System.Windows.Forms.Label
	Private tB4 As System.Windows.Forms.Label
	Private tB5 As System.Windows.Forms.Label
	Private tB6 As System.Windows.Forms.Label
	Private tB7 As System.Windows.Forms.Label
	Private tB8 As System.Windows.Forms.Label
	Private label8 As System.Windows.Forms.Label
	Private tDST As System.Windows.Forms.Label
	Private tPK As System.Windows.Forms.Label
	Private tFLEX2 As System.Windows.Forms.Label
	Private tFLEX1 As System.Windows.Forms.Label
	Private tWR1 As System.Windows.Forms.Label
	Private tRB2 As System.Windows.Forms.Label
	Private tRB1 As System.Windows.Forms.Label
	Private tQB As System.Windows.Forms.Label
	Private myTeam As System.Windows.Forms.Label
	Private divLine As System.Windows.Forms.Label
	Private chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
	Private lRisk As System.Windows.Forms.Label
	Private lECRPos As System.Windows.Forms.Label
	Private lECR As System.Windows.Forms.Label
	Private lADP As System.Windows.Forms.Label
	Private lTier As System.Windows.Forms.Label
	Private lDropoff As System.Windows.Forms.Label
	Private lPosRank As System.Windows.Forms.Label
	Private lOverall As System.Windows.Forms.Label
	Private lVOR As System.Windows.Forms.Label
	Private lUpper As System.Windows.Forms.Label
	Private lPoints As System.Windows.Forms.Label
	Private lLower As System.Windows.Forms.Label
	Private lBirthday As System.Windows.Forms.Label
	Private lName As System.Windows.Forms.Label
	Private lPosition As System.Windows.Forms.Label
	Private Draft As System.Windows.Forms.Button
	Private Remove As System.Windows.Forms.Button
	Private draftQB As System.Windows.Forms.Button
	Private removeQB As System.Windows.Forms.Button
	Private draftRB As System.Windows.Forms.Button
	Private removeRB As System.Windows.Forms.Button
	Private draftWR As System.Windows.Forms.Button
	Private removeWR As System.Windows.Forms.Button
	Private draftTE As System.Windows.Forms.Button
	Private removeTE As System.Windows.Forms.Button
	Private button10 As System.Windows.Forms.Button
	Private button9 As System.Windows.Forms.Button
	Private button12 As System.Windows.Forms.Button
	Private button11 As System.Windows.Forms.Button
	Private button14 As System.Windows.Forms.Button
	Private button13 As System.Windows.Forms.Button
	Private lbQB As System.Windows.Forms.ListBox
	Private lbRB As System.Windows.Forms.ListBox
	Private lbWR As System.Windows.Forms.ListBox
	Private lbTE As System.Windows.Forms.ListBox
	Private lbPK As System.Windows.Forms.ListBox
	Private lbDST As System.Windows.Forms.ListBox
	Private lbFLEX As System.Windows.Forms.ListBox
	Private tbFLEX As System.Windows.Forms.TabPage
	Private tbDST As System.Windows.Forms.TabPage
	Private tbPK As System.Windows.Forms.TabPage
	Private tbTE As System.Windows.Forms.TabPage
	Private tbWR As System.Windows.Forms.TabPage
	Private tbRB As System.Windows.Forms.TabPage
	Private tbQB As System.Windows.Forms.TabPage
	Private lbOverall As System.Windows.Forms.ListBox
	Private Overall As System.Windows.Forms.TabPage
	Private tabControl1 As System.Windows.Forms.TabControl
End Class
