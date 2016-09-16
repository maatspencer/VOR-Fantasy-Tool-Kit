Imports System.IO
Imports System.Net

Public Class readWeekly
	Public Shared Function createObject(myFile As String) As List(Of Player)
		' Loop Variables
        Dim CurrentLine As String = ""
        Dim Count As Integer = 0
        Dim p As List(Of Player) = New List(Of Player)
        
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
                
                p.Add(t)

                CurrentLine = sr.ReadLine
            Loop
        End Using
        
        Return p
	End Function
End Class
