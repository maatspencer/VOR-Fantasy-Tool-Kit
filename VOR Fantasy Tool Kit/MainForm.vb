'
' Created by SharpDevelop.
' User: spen6722
' Date: 8/29/2016
' Time: 12:43 PM
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Partial Class MainForm
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	Sub Button1Click(sender As Object, e As EventArgs)
		DraftKit.show()
	End Sub
	
	Sub MainFormLoad(sender As Object, e As EventArgs)
		splashScreen.show()
	End Sub
End Class
