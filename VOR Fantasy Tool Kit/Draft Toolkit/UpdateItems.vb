Imports VOR_Fantasy_Tool_Kit.globalCounters

Public Class UpdateItems
	Public Shared Sub Start(name As String, pos As String, isDraft As Boolean)
        globalVars(pos, isDraft)
        removeItem(name)
    End Sub

    Public Shared Sub removeItem(name As String)
    	' QB
    	For i = 0 To oQB.Count - 1
         Dim index As Integer = oQB.FindIndex(Function(a) a.name.Equals(name, StringComparison.Ordinal))
          If Not index = -1 Then
          	oQB.RemoveAt(index)
          	Exit For		
          End If
        Next

        ' RB
        For i = 0 To oRB.Count - 1
            Dim index As Integer = oRB.FindIndex(Function(a) a.name.Equals(name, StringComparison.Ordinal))
            If Not index = -1 Then
                oRB.RemoveAt(index)
                Exit For
            End If
        Next

        ' WR
        For i = 0 To oWR.Count - 1
            Dim index As Integer = oWR.FindIndex(Function(a) a.name.Equals(name, StringComparison.Ordinal))
            If Not index = -1 Then
                oWR.RemoveAt(index)
                Exit For
            End If
        Next

        ' TE
        For i = 0 To oTE.Count - 1
            Dim index As Integer = oTE.FindIndex(Function(a) a.name.Equals(name, StringComparison.Ordinal))
            If Not index = -1 Then
                oTE.RemoveAt(index)
                Exit For
            End If
        Next
        
        ' PK
        For i = 0 To oPK.Count - 1
            Dim index As Integer = oPK.FindIndex(Function(a) a.name.Equals(name, StringComparison.Ordinal))
            If Not index = -1 Then
                oPK.RemoveAt(index)
                Exit For
            End If
        Next
        
        ' DST
        For i = 0 To oDST.Count - 1
            Dim index As Integer = oDST.FindIndex(Function(a) a.name.Equals(name, StringComparison.Ordinal))
            If Not index = -1 Then
                oDST.RemoveAt(index)
                Exit For
            End If
        Next
        
        ' OVerall
        For i = 0 To oOVR.Count - 1
            Dim index As Integer = oOVR.FindIndex(Function(a) a.name.Equals(name, StringComparison.Ordinal))
            If Not index = -1 Then
                oOVR.RemoveAt(index)
                Exit For
            End If
        Next
        
       ' Flex
        For i = 0 To oFlex.Count - 1
            Dim index As Integer = oFlex.FindIndex(Function(a) a.name.Equals(name, StringComparison.Ordinal))
            If Not index = -1 Then
                oFlex.RemoveAt(index)
                Exit For
            End If
        Next
End Sub
        
Private Shared Sub globalVars(pos As String, isDraft As Boolean)
        Select Case pos
            Case "QB"
                If isDraft Then
                    mQB += 1
                    aQB += 1
                Else
                    aQB += 1
                End If
            Case "WR"
                If isDraft Then
                        mWR += 1
                        aWR += 1
                Else
                    aWR += 1
                End If
            Case "RB"
                    If isDraft Then
                        mRB += 1
                    aRB += 1
                    Else
                        aRB += 1
                    End If
            Case "TE"
                    If isDraft Then
                        mTE += 1
                    	aTE += 1
                    Else
                        aTE += 1
                    End If
            Case "PK"
                    If isDraft Then
                        mPK += 1
                    	aPK += 1
                    Else
                        aPK += 1
                    End If
                    
            Case "DST"
                    If isDraft Then
                        mDST += 1
                    	aDST += 1
                    Else
                        aDST += 1
                    End If
        End Select

        If isDraft Then
            mRoster += 1
            aRoster += 1
        Else
            aRoster += 1
        End If
        
        If aWR > 12 Then
        	aFLEX = aWR - 12
        End If
        
        If aRB > 24 Then
        	aFLEX = aFLEX + aRB - 24
        End If
        
        aFLEX = aFLEX + aTE
        mFLEX = mWR + mRB + mTE
End Sub

End Class
