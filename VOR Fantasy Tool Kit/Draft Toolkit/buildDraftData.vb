Imports System.IO
Imports System.Net
Imports VOR_Fantasy_Tool_Kit.globalCounters

Public Class buildDraftData
	Public Shared Sub Build
		' Download CSV's
		pullTables
		' Create a list of Player Objects for each position
		buildObjectLists
		' Read the data into Lists of Player Objects
		readPlayer(My.Application.Info.DirectoryPath & "/Tables/AvgOverall.csv")
		' Sort and put the lists in proper Order
		sortAndRank
	End Sub
	
	Private Shared Sub pullTables
		' Create Directory
        If Not My.Computer.FileSystem.DirectoryExists(My.Application.Info.DirectoryPath & "/Tables") Then
            My.Computer.FileSystem.CreateDirectory(My.Application.Info.DirectoryPath & "/Tables")
        End If
        
        ' Establish New Web Client
        Dim web_client As WebClient = New WebClient
        
        ' Fantasy Sharks
        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "/Tables/Fantasy Sharks.csv") Then
            My.Computer.FileSystem.DeleteFile(My.Application.Info.DirectoryPath & "/Tables/Fantasy Sharks.csv")
        End If
        
        web_client.DownloadFile("http://www.fantasysharks.com/apps/Projections/WeeklyProjections.php?pos=ALL&format=csv", _
        	My.Application.Info.DirectoryPath & "/Tables/Fantasy Sharks.csv")
        
        ' R Script Overall
        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "/Tables/AvgOverall.csv") Then
            My.Computer.FileSystem.DeleteFile(My.Application.Info.DirectoryPath & "/Tables/AvgOverall.csv")
        End If
  
        web_client.DownloadFile("https://dl.dropboxusercontent.com/u/106837742/AvgOverall.csv", _
        	My.Application.Info.DirectoryPath & "/Tables/AvgOverall.csv")
        
        ' R Script Player Data
        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "/Tables/PlayerData.csv") Then
            My.Computer.FileSystem.DeleteFile(My.Application.Info.DirectoryPath & "/Tables/PlayerData.csv")
        End If
       
        web_client.DownloadFile("https://dl.dropboxusercontent.com/u/106837742/playerData.csv", _
        	My.Application.Info.DirectoryPath & "/Tables/PlayerData.csv")
        
        web_client.Dispose
	End Sub
	
	Private Shared Sub buildObjectLists
		 ' Build Lists
        oQB = New List(Of Player)
        oWR = New List(Of Player)
        oRB = New List(Of Player)
        oTE = New List(Of Player)
        oPK = New List(Of Player)
        oDST = New List(Of Player)
        oOvr = New List(Of Player)
        oFlex = New List(Of Player)
        
	End Sub
	
	Private Shared Sub readPlayer(myFile As String)
		' Loop Variables
        Dim CurrentLine As String = ""
        Dim Count As Integer = 0
        
        ' Open Stream Reader
        Using sr As StreamReader = New StreamReader(MyFile)
            sr.ReadLine()
            CurrentLine = sr.ReadLine
            Do While (Not CurrentLine Is Nothing)
            	Dim t As Player = New Player
            	
            	CurrentLine = CurrentLine.Replace("""", "").Replace("/","-")
            	CurrentLine = CurrentLine.Replace("Inf", "999")
            	CurrentLine = CurrentLine.Replace("NA", "999")

                'RANK
                t.name = CurrentLine.Split(","c)(1)
                t.Pos = CurrentLine.Split(","c)(2)
                t.team = CurrentLine.Split(","c)(3)
                t.FFA_playerID = CurrentLine.Split(","c)(4)
                t.FFA_Birthdate = CurrentLine.Split(","c)(5)
                t.Points = Decimal.Parse(CurrentLine.Split(","c)(6))
                t.LowerPoints = Decimal.Parse(CurrentLine.Split(","c)(7))
                t.UpperPoints = Decimal.Parse(CurrentLine.Split(","c)(8))
                t.sdPoints = Decimal.Parse(CurrentLine.Split(","c)(9))
                t.PosRank = Decimal.Parse(CurrentLine.Split(","c)(10))
                t.Dropoff = Decimal.Parse(CurrentLine.Split(","c)(11))
                t.Tier = Decimal.Parse(CurrentLine.Split(","c)(12))
                t.VORPoints = Decimal.Parse(CurrentLine.Split(","c)(13))
                t.OvrRank = Decimal.Parse(CurrentLine.Split(","c)(14))
                t.ADP = Decimal.Parse(CurrentLine.Split(","c)(15))
                t.AAV = Decimal.Parse(CurrentLine.Split(","c)(16))
                t.ADPDiff = Decimal.Parse(CurrentLine.Split(","c)(17))
                t.Exp = Decimal.Parse(CurrentLine.Split(","c)(18))
                t.ecrPosition = Decimal.Parse(CurrentLine.Split(","c)(19))
                t.sdRank = Decimal.Parse(CurrentLine.Split(","c)(20))
                t.ecrRank = Decimal.Parse(CurrentLine.Split(","c)(21))                
                t.Risk = Decimal.Parse(CurrentLine.Split(","c)(22))               
                
                If t.Pos.Equals("QB", StringComparison.Ordinal) Then
                    oQB.Add(t)
                ElseIf t.Pos.Equals("WR", StringComparison.Ordinal) Then
                	oWR.Add(t)
                	oFlex.Add(t)
                ElseIf t.Pos.Equals("RB", StringComparison.Ordinal) Then
                	oRB.Add(t)
                	oFlex.Add(t)
                ElseIf t.Pos.Equals("TE", StringComparison.Ordinal) Then
                	oTE.Add(t)
                	oFlex.Add(t)
                ElseIf t.Pos.Equals("K", StringComparison.Ordinal) Then
                	oPK.Add(t)
                ElseIf t.Pos.Equals("DST", StringComparison.Ordinal) Then
                	oDST.Add(t)
                End If
                
                oOvr.Add(t)

                CurrentLine = sr.ReadLine
            Loop
        End Using
	End Sub
	
	Public Shared Sub sortAndRank
		' Overall
        oQB.Sort(Function(x, y) y.VORPoints.CompareTo(x.VORPoints))
		
		' QB
        oQB.Sort(Function(x, y) y.VORPoints.CompareTo(x.VORPoints))

        ' WR
        oWR.Sort(Function(x, y) y.VORPoints.CompareTo(x.VORPoints))

        ' RB
        oRB.Sort(Function(x, y) y.VORPoints.CompareTo(x.VORPoints))

        ' TE
        oTE.Sort(Function(x, y) y.VORPoints.CompareTo(x.VORPoints))
        
        ' PK
        oPK.Sort(Function(x, y) y.VORPoints.CompareTo(x.VORPoints))
        
        ' DST
        oDST.Sort(Function(x, y) y.VORPoints.CompareTo(x.VORPoints))
        
        ' FLEX
        oFLEX.Sort(Function(x, y) y.Points.CompareTo(x.Points))
	End Sub
	
End Class
