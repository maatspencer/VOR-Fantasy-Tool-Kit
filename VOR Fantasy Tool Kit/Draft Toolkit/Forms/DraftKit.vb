Imports VOR_Fantasy_Tool_Kit.globalCounters

Public Partial Class DraftKit
	Public Sub New()
		Me.InitializeComponent()
	End Sub
	
	Sub DraftKitLoad(sender As Object, e As EventArgs) Handles Me.Load
		' Pull and format all the data
		buildDraftData.Build
		
		' Load Data into List boxes
		updateListboxes
		
		' Initialize globalCounters
		VOR_Fantasy_Tool_Kit.globalCounters.init
		
		' Initialize Labels
		updateLabels(oOvr.Item(0))
		
	End Sub
	
	' Flush and refill the listboxes dynamically
	Private Sub updateListboxes
		
		'QB
		lbQB.Items.Clear
		For i = 0 To oQB.Count - 1
			Dim v As Decimal = Math.Truncate(oQB.Item(i).VORPoints*100)/100
			Dim p As Decimal = Math.Truncate(oQB.Item(i).Points*100)/100
            lbQB.Items.Add(v & vbTab & p & vbTab & oQB.Item(i).name)
        Next
        lbQB.Update()
        
        'RB
        lbRB.Items.Clear
        For i = 0 To oRB.Count - 1
			Dim v As Decimal = Math.Truncate(oRB.Item(i).VORPoints*100)/100
			Dim p As Decimal = Math.Truncate(oRB.Item(i).Points*100)/100
            lbRB.Items.Add(v & vbTab & p & vbTab & oRB.Item(i).name)
        Next
        lbRB.Update()
        
        'WR
        lbWR.Items.Clear
        For i = 0 To oWR.Count - 1
			Dim v As Decimal = Math.Truncate(oWR.Item(i).VORPoints*100)/100
			Dim p As Decimal = Math.Truncate(oWR.Item(i).Points*100)/100
            lbWR.Items.Add(v & vbTab & p & vbTab & oWR.Item(i).name)
        Next
        lbWR.Update()
        
        'TE
        lbTE.Items.Clear
        For i = 0 To oTE.Count - 1
			Dim v As Decimal = Math.Truncate(oTE.Item(i).VORPoints*100)/100
			Dim p As Decimal = Math.Truncate(oTE.Item(i).Points*100)/100
            lbTE.Items.Add(v & vbTab & p & vbTab & oTE.Item(i).name)
        Next
        lbTE.Update()
        
        'PK
        lbPK.Items.Clear
        For i = 0 To oPK.Count - 1
			Dim v As Decimal = Math.Truncate(oPK.Item(i).VORPoints*100)/100
			Dim p As Decimal = Math.Truncate(oPK.Item(i).Points*100)/100
            lbPK.Items.Add(v & vbTab & p & vbTab & oPK.Item(i).name)
        Next
        lbPK.Update()
        
        'DST
        lbDST.Items.Clear
        For i = 0 To oDST.Count - 1
			Dim v As Decimal = Math.Truncate(oDST.Item(i).VORPoints*100)/100
			Dim p As Decimal = Math.Truncate(oDST.Item(i).Points*100)/100
            lbDST.Items.Add(v & vbTab & p & vbTab & oDST.Item(i).name)
        Next
        lbDST.Update()
        
        'FLEX
        lbFLEX.Items.Clear
        For i = 0 To oFLEX.Count - 1
			Dim v As Decimal = Math.Truncate(oFLEX.Item(i).VORPoints*100)/100
			Dim p As Decimal = Math.Truncate(oFLEX.Item(i).Points*100)/100
            lbFLEX.Items.Add(v & vbTab & p & vbTab & oFLEX.Item(i).name)
        Next
        lbFLEX.Update()
        
        'OVR
        lbOverall.Items.Clear
        For i = 0 To oOVR.Count - 1
			Dim v As Decimal = Math.Truncate(oOVR.Item(i).VORPoints*100)/100
			Dim p As Decimal = Math.Truncate(oOVR.Item(i).Points*100)/100
            lbOverall.Items.Add(v & vbTab & p & vbTab & oOVR.Item(i).name)
        Next
        lbOverall.Update()
        
	End Sub
	
	' Dynamically update all of the labels
	Sub updateLabels(t As Player)
		If t IsNot Nothing then
			lPosition.Text = t.Pos.ToString
			lName.Text = t.name & ", " & t.team
			lBirthday.Text = "Birthday: " & t.FFA_Birthdate & " (" & t.Exp & " years)"
			
			lLower.Text = (Math.Truncate(t.LowerPoints * 100)/100).ToString
			lPoints.Text = (Math.Truncate(t.Points * 100)/100).ToString
			lUpper.Text = (Math.Truncate(t.UpperPoints * 100)/100).ToString
			lVOR.Text = (Math.Truncate(t.VORPoints * 100)/100).ToString
			
			lADP.Text = "ADP: " & t.ADP.ToString & " (" & t.ADPDiff.ToString & ")"
			
			lOverall.Text = "Overall Rank: " & t.OvrRank.ToString
			lPosRank.Text = "Position Rank: " & t.PosRank.ToString
			
			lECR.Text = "ECR: " & t.ecrRank.ToString
			lECRPos.Text = "ECR Position: " & t.ecrPosition.ToString
			
			lDropoff.Text = "Dropoff: " & (Math.Truncate(t.Dropoff*100)/100).ToString
			lTier.Text = "Tier: " & (Math.Truncate(t.Tier*100)/100).ToString
			
			lRisk.Text = "Player Risk: " & (Math.Truncate(t.Risk*100)/100).ToString
			
			' Update Chart
			Dim u As Decimal = 5
			Dim sd As Decimal = 1
			Dim p1 As Double = 1.0 / Math.Sqrt(2 * 1 * 3.14)
			Dim p2 As Double
			Dim r As Decimal = Math.Truncate(t.Risk * 10)/10
			
			chart1.Series("Risk").Points.Clear
			For i = 0 To 10 Step .5
				p2 = -1.0 * ((i - u) ^ 2)/ 2
				chart1.Series("Risk").Points.AddXY(i, p1 * Math.E^p2)
			Next

			p2 = -1.0 * ((r - u) ^ 2)/ 2
			chart1.Series("Risk").Points.AddXY(r, p1 * Math.E^p2)
			chart1.Series("Risk").Points.Item(21).Color = Color.Red
			
			chart1.Update
		End if
	End Sub
	
	' Draft Player Button Handler
	Sub DraftClick(sender As Object, e As EventArgs)
		Dim t As Player = getPlayer
		UpdateItems.Start(t.name, t.Pos, True)
		updateListboxes
		try
		Select Case t.Pos
			Case "QB"
				If tQB.text.Contains("QB") Then
					tQB.Text = t.name
				Else
					setBenchLabels(t)
				End If
			Case "RB"
				If tRB1.text.Contains("RB1") Then
					tRB1.Text = t.name
				ElseIf tRB2.Text.Contains("RB2") Then
					tRB2.Text = t.name
				ElseIf tFLEX1.Text.Contains("FLEX1") Then
					tFLEX1.Text = t.name
				ElseIf tFLEX2.Text.Contains("FLEX2") Then
					tFLEX2.Text = t.name
				Else
					setBenchLabels(t)
				End If
			Case "WR"
				If tWR1.text.Contains("WR1") Then
					tWR1.Text = t.name
				ElseIf tFLEX1.Text.Contains("FLEX1") Then
					tFLEX1.Text = t.name
				ElseIf tFLEX2.Text.Contains("FLEX2") Then
					tFLEX2.Text = t.name
				Else
					setBenchLabels(t)
				End If
			Case "TE"
				If tFLEX1.Text.Contains("FLEX1") Then
					tFLEX1.Text = t.name
				ElseIf tFLEX2.Text.Contains("FLEX2") Then
					tFLEX2.Text = t.name
				Else
					setBenchLabels(t)
				End If
			Case "K"
				If tPK.text.Contains("PK") Then
					tPK.Text = t.name
				Else
					setBenchLabels(t)
				End If
			Case "DST"
				If tDST.text.Contains("DST") Then
					tDST.Text = t.name
				Else
					setBenchLabels(t)
				End If				
		End Select
		
		' Update Rosters
			dQBs.Text = "QBs: " & aQB.ToString
			dRBs.Text = "RBs: " & aRB.ToString
			dWRs.Text = "WRs: " & aWR.ToString
			dTEs.Text = "TEs: " & aTE.ToString
			dDSTs.Text = "DSTs: " & aDST.ToString
			dPKs.Text = "PKs: " & aPK.ToString
			dTotal.Text = "Total: " & aRoster.ToString
			dFLEX.Text = "Flex: " & aFLEX.ToString
		Catch
		End Try
		
	End Sub
	
	Sub setBenchLabels (t As Player)
		If tB1.Text.Contains("BENCH") Then
			tB1.Text = t.name & ", " & t.Pos
		ElseIf tB2.Text.Contains("BENCH") Then
			tB2.Text = t.name & ", " & t.Pos
		ElseIf tB3.Text.Contains("BENCH") Then
			tB3.Text = t.name & ", " & t.Pos
		ElseIf tB4.Text.Contains("BENCH") Then
			tB4.Text = t.name & ", " & t.Pos
		ElseIf tB5.Text.Contains("BENCH") Then
			tB5.Text = t.name & ", " & t.Pos
		ElseIf tB6.Text.Contains("BENCH") Then
			tB6.Text = t.name & ", " & t.Pos
		ElseIf tB7.Text.Contains("BENCH") Then
			tB7.Text = t.name & ", " & t.Pos
		ElseIf tB8.Text.Contains("BENCH") Then
			tB8.Text = t.name & ", " & t.Pos
		End If
	End Sub
	
	' Remove Player Button Handler
	Sub RemoveClick(sender As Object, e As EventArgs)
		Dim t As Player = getPlayer
		UpdateItems.Start(t.name, t.Pos, False)
		updateListboxes
		
		Try
			' Update Rosters
			dQBs.Text = "QBs: " & aQB.ToString
			dRBs.Text = "RBs: " & aRB.ToString
			dWRs.Text = "WRs: " & aWR.ToString
			dTEs.Text = "TEs: " & aTE.ToString
			dDSTs.Text = "DSTs: " & aDST.ToString
			dPKs.Text = "PKs: " & aPK.ToString
			dTotal.Text = "Total: " & aRoster.ToString
			dFLEX.Text = "Flex: " & aFLEX.ToString
		Catch
		End Try
	End Sub	
	
	' Funtion to return selected player
	Function getPlayer As Player
		Dim t As Player
		' Overall
		If Not lbOverall.SelectedIndex = -1 Then
			t = oOvr.Item(lbOverall.SelectedIndex)
		' QB	
		ElseIf Not lbQB.SelectedIndex = -1 Then
			t = oQB.Item(lbQB.SelectedIndex)
		' RB	
		ElseIf Not lbRB.SelectedIndex = -1 Then
			t = oRB.Item(lbRB.SelectedIndex)
		' WR	
		ElseIf Not lbWR.SelectedIndex = -1 Then
			t = oWR.Item(lbWR.SelectedIndex)
		'TE	
		ElseIf Not lbTE.SelectedIndex = -1 Then
			t = oTE.Item(lbTE.SelectedIndex)
		'PK	
		ElseIf Not lbPK.SelectedIndex = -1 Then
			t = oPK.Item(lbPK.SelectedIndex)
		'DST	
		ElseIf Not lbDST.SelectedIndex = -1 Then
			t = oDST.Item(lbDST.SelectedIndex)
		'FLEX	
		ElseIf Not lbFLEX.SelectedIndex = -1 Then
			t = oFLEX.Item(lbFLEX.SelectedIndex)
			Else return Nothing
		End If
		
		Return t
	End Function
	
	' Overall index changed
	Sub LbOverallSelectedIndexChanged(sender As Object, e As EventArgs)
		updateLabels(getPlayer)
	End Sub
	
	' QB index changed
	Sub LbQBSelectedIndexChanged(sender As Object, e As EventArgs)
		updateLabels(getPlayer)
	End Sub
	
	' Flex index changed
	Sub LbFLEXSelectedIndexChanged(sender As Object, e As EventArgs)
		updateLabels(getPlayer)		
	End Sub

	' RB index changed
	Sub LbRBSelectedIndexChanged(sender As Object, e As EventArgs)
		updateLabels(getPlayer)
	End Sub
	
	' WR index changed
	Sub LbWRSelectedIndexChanged(sender As Object, e As EventArgs)
		updateLabels(getPlayer)
	End Sub
	
	' TE index changed
	Sub LbTESelectedIndexChanged(sender As Object, e As EventArgs)
		updateLabels(getPlayer)
	End Sub
	
	' PK index changed
	Sub LbPKSelectedIndexChanged(sender As Object, e As EventArgs)
		updateLabels(getPlayer)
	End Sub
	
	' DST index changed
	Sub LbDSTSelectedIndexChanged(sender As Object, e As EventArgs)
		updateLabels(getPlayer)
	End Sub
	
	Sub TabControl1SelectedIndexChanged(sender As Object, e As EventArgs)
		lbOverall.SelectedIndex = -1
		lbRB.SelectedIndex = -1
		lbWR.SelectedIndex = -1
		lbQB.SelectedIndex = -1
		lbTE.SelectedIndex = -1
		lbPK.SelectedIndex = -1
		lbDST.SelectedIndex = -1
		lbFLEX.SelectedIndex = -1
	End Sub
End Class
