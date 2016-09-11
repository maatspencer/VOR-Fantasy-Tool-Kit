Public Class globalCounters
    ' Lists
    Public Shared oQB As List(Of Player)
    Public Shared oWR As List(Of Player)
    Public Shared oRB As List(Of Player)
    Public Shared oTE As List(Of Player)
    Public Shared oPK As List(Of Player)
    Public Shared oDST As List(Of Player)
    Public Shared oFlex As List(Of Player)

    Public Shared oOvr As List(Of Player)

    ' My Drafted Players
    Public Shared mQB As Integer
    Public Shared mWR As Integer
    Public Shared mRB As Integer
    Public Shared mTE As Integer
    Public Shared mPK As Integer
    Public Shared mDST As Integer
    Public Shared mFLEX As Integer
    Public Shared mRoster As Integer

    ' All Drafted Players
    Public Shared aQB As Integer
    Public Shared aWR As Integer
    Public Shared aRB As Integer
    Public Shared aTE As Integer
    Public Shared aPK As Integer
    Public Shared aDST As Integer
    Public Shared aFLEX As Integer
    Public Shared aRoster As Integer

    ' POS VOR Baseline
    Public Shared cQB As Integer
    Public Shared cWR As Integer
    Public Shared cRB As Integer
    Public Shared cTE As Integer
    Public Shared cPK As Integer
    Public Shared cDST As Integer
    Public Shared cFLEX As Integer
    
    Public Shared Sub init
    	mQB = 0
    	aQB = 0
    	
    	mWR = 0
    	aWR = 0
    	
    	mRB = 0
    	aRB = 0
    	
    	mTE = 0
    	aTE = 0
    	
    	mPK = 0
    	aPK = 0
    	
    	mDST = 0
    	aDST = 0
    	
    	mFLEX = 0
    	aFLEX = 0
    	
    	mRoster = 0
    	aRoster = 0
    End Sub
End Class