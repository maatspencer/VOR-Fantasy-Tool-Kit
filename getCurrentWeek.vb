'
' Created by SharpDevelop.
' User: spen6722
' Date: 9/12/2016
' Time: 5:13 PM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Class getCurrentWeek
	Public Shared Sub scrapeHTML
		Dim sourceString As String = New System.Net.WebClient().DownloadString("http://www.fantasysharks.com/apps/Projections/WeeklyProjections.php?pos=ALL")
		
	End Sub
End Class
