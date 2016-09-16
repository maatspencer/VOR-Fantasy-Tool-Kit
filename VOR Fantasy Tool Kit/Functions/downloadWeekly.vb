Imports System.IO
Imports System.Net

Public Class downloadWeekly
	Public Shared Sub pullTables
		' Create Directory
        If Not My.Computer.FileSystem.DirectoryExists(My.Application.Info.DirectoryPath & "/Tables") Then
            My.Computer.FileSystem.CreateDirectory(My.Application.Info.DirectoryPath & "/Tables")
        End If
        
        ' Establish New Web Client
        Dim web_client As WebClient = New WebClient
        
        ' R Script Player Data
        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "/Tables/PlayerData.csv") Then
            My.Computer.FileSystem.DeleteFile(My.Application.Info.DirectoryPath & "/Tables/PlayerData.csv")
        End If
       
        web_client.DownloadFile("https://dl.dropboxusercontent.com/u/106837742/playerData.csv", _
        	My.Application.Info.DirectoryPath & "/Tables/PlayerData.csv")
        
        ' Week 1
        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "/Tables/1_Ovr.csv") Then
            My.Computer.FileSystem.DeleteFile(My.Application.Info.DirectoryPath & "/Tables/1_Ovr.csv")
        End If
  
        web_client.DownloadFile("https://dl.dropboxusercontent.com/u/106837742/1_Ovr.csv", _
        	My.Application.Info.DirectoryPath & "/Tables/1_Ovr.csv.csv")
        
        ' Week 2
        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "/Tables/2_Ovr.csv") Then
            My.Computer.FileSystem.DeleteFile(My.Application.Info.DirectoryPath & "/Tables/2_Ovr.csv")
        End If
  
        web_client.DownloadFile("https://dl.dropboxusercontent.com/u/106837742/2_Ovr.csv", _
        	My.Application.Info.DirectoryPath & "/Tables/2_Ovr.csv.csv")
        
        ' Week 3
        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "/Tables/3_Ovr.csv") Then
            My.Computer.FileSystem.DeleteFile(My.Application.Info.DirectoryPath & "/Tables/3_Ovr.csv")
        End If
  
        web_client.DownloadFile("https://dl.dropboxusercontent.com/u/106837742/3_Ovr.csv", _
        	My.Application.Info.DirectoryPath & "/Tables/3_Ovr.csv.csv")
        
        ' Week 4
        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "/Tables/4_Ovr.csv") Then
            My.Computer.FileSystem.DeleteFile(My.Application.Info.DirectoryPath & "/Tables/4_Ovr.csv")
        End If
  
        web_client.DownloadFile("https://dl.dropboxusercontent.com/u/106837742/4_Ovr.csv", _
        	My.Application.Info.DirectoryPath & "/Tables/4_Ovr.csv.csv")
        
        ' Week 5
        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "/Tables/5_Ovr.csv") Then
            My.Computer.FileSystem.DeleteFile(My.Application.Info.DirectoryPath & "/Tables/5_Ovr.csv")
        End If
  
        web_client.DownloadFile("https://dl.dropboxusercontent.com/u/106837742/5_Ovr.csv", _
        	My.Application.Info.DirectoryPath & "/Tables/5_Ovr.csv.csv")
        
        ' Week 6
        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "/Tables/6_Ovr.csv") Then
            My.Computer.FileSystem.DeleteFile(My.Application.Info.DirectoryPath & "/Tables/6_Ovr.csv")
        End If
  
        web_client.DownloadFile("https://dl.dropboxusercontent.com/u/106837742/6_Ovr.csv", _
        	My.Application.Info.DirectoryPath & "/Tables/6_Ovr.csv.csv")
        
        ' Week 7
        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "/Tables/7_Ovr.csv") Then
            My.Computer.FileSystem.DeleteFile(My.Application.Info.DirectoryPath & "/Tables/7_Ovr.csv")
        End If
  
        web_client.DownloadFile("https://dl.dropboxusercontent.com/u/106837742/7_Ovr.csv", _
        	My.Application.Info.DirectoryPath & "/Tables/7_Ovr.csv.csv")
        
        ' Week 8
        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "/Tables/8_Ovr.csv") Then
            My.Computer.FileSystem.DeleteFile(My.Application.Info.DirectoryPath & "/Tables/8_Ovr.csv")
        End If
  
        web_client.DownloadFile("https://dl.dropboxusercontent.com/u/106837742/8_Ovr.csv", _
        	My.Application.Info.DirectoryPath & "/Tables/8_Ovr.csv.csv")
        
        ' Week 9
        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "/Tables/9_Ovr.csv") Then
            My.Computer.FileSystem.DeleteFile(My.Application.Info.DirectoryPath & "/Tables/9_Ovr.csv")
        End If
  
        web_client.DownloadFile("https://dl.dropboxusercontent.com/u/106837742/9_Ovr.csv", _
        	My.Application.Info.DirectoryPath & "/Tables/9_Ovr.csv.csv")
        
        ' Week 10
        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "/Tables/10_Ovr.csv") Then
            My.Computer.FileSystem.DeleteFile(My.Application.Info.DirectoryPath & "/Tables/10_Ovr.csv")
        End If
  
        web_client.DownloadFile("https://dl.dropboxusercontent.com/u/106837742/10_Ovr.csv", _
        	My.Application.Info.DirectoryPath & "/Tables/10_Ovr.csv.csv")
        
        ' Week 11
        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "/Tables/11_Ovr.csv") Then
            My.Computer.FileSystem.DeleteFile(My.Application.Info.DirectoryPath & "/Tables/11_Ovr.csv")
        End If
  
        web_client.DownloadFile("https://dl.dropboxusercontent.com/u/106837742/11_Ovr.csv", _
        	My.Application.Info.DirectoryPath & "/Tables/11_Ovr.csv.csv")
        
        ' Week 12
        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "/Tables/12_Ovr.csv") Then
            My.Computer.FileSystem.DeleteFile(My.Application.Info.DirectoryPath & "/Tables/12_Ovr.csv")
        End If
  
        web_client.DownloadFile("https://dl.dropboxusercontent.com/u/106837742/12_Ovr.csv", _
        	My.Application.Info.DirectoryPath & "/Tables/12_Ovr.csv.csv")
        
        ' Week 13
        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "/Tables/13_Ovr.csv") Then
            My.Computer.FileSystem.DeleteFile(My.Application.Info.DirectoryPath & "/Tables/13_Ovr.csv")
        End If
  
        web_client.DownloadFile("https://dl.dropboxusercontent.com/u/106837742/13_Ovr.csv", _
        	My.Application.Info.DirectoryPath & "/Tables/13_Ovr.csv.csv")
        
        ' Week 14
        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "/Tables/14_Ovr.csv") Then
            My.Computer.FileSystem.DeleteFile(My.Application.Info.DirectoryPath & "/Tables/14_Ovr.csv")
        End If
  
        web_client.DownloadFile("https://dl.dropboxusercontent.com/u/106837742/14_Ovr.csv", _
        	My.Application.Info.DirectoryPath & "/Tables/14_Ovr.csv.csv")
        
        ' Week 15
        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "/Tables/15_Ovr.csv") Then
            My.Computer.FileSystem.DeleteFile(My.Application.Info.DirectoryPath & "/Tables/15_Ovr.csv")
        End If
  
        web_client.DownloadFile("https://dl.dropboxusercontent.com/u/106837742/15_Ovr.csv", _
        	My.Application.Info.DirectoryPath & "/Tables/15_Ovr.csv.csv")
        
        ' Week 16
        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "/Tables/16_Ovr.csv") Then
            My.Computer.FileSystem.DeleteFile(My.Application.Info.DirectoryPath & "/Tables/16_Ovr.csv")
        End If
  
        web_client.DownloadFile("https://dl.dropboxusercontent.com/u/106837742/16_Ovr.csv", _
        	My.Application.Info.DirectoryPath & "/Tables/16_Ovr.csv.csv")
        
        web_client.Dispose
	End Sub
End Class
