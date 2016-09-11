Public Class Player
	' Name
    Public Property name() As String
        Get
            Return m_name
        End Get
        Set(value As String)
            m_name = value
        End Set
    End Property
    Private m_name As String
	
	' Position
    Public Property Pos() As String
        Get
            Return mPos
        End Get
        Set(value As String)
            mPos = value
        End Set
    End Property
    Private mPos As String
    
    ' Player Team
    Public Property team() As String
        Get
            Return m_team
        End Get
        Set(value As String)
            m_team = value
        End Set
    End Property
    Private m_team As String
    
    ' playerId
    Public Property FFA_playerID() As String
        Get
            Return mFFA_playerID
        End Get
        Set(value As String)
            mFFA_playerID = value
        End Set
    End Property
    Private mFFA_playerID As String
    
    ' Birthdate
    Public Property FFA_Birthdate() As String
        Get
            Return mFFA_Birthdate
        End Get
        Set(value As String)
            mFFA_Birthdate = value
        End Set
    End Property
    Private mFFA_Birthdate As String
    
     ' Points
    Public Property Points() As Decimal
        Get
            Return mPoints
        End Get
        Set(value As Decimal)
            mPoints = value
        End Set
    End Property
    Private mPoints As Decimal
    
    ' LowerPoints
    Public Property LowerPoints() As Decimal
        Get
            Return mLowerPoints
        End Get
        Set(value As Decimal)
            mLowerPoints = value
        End Set
    End Property
    Private mLowerPoints As Decimal
    
    ' Upper
    Public Property UpperPoints() As Decimal
        Get
            Return mUpperPoints
        End Get
        Set(value As Decimal)
            mUpperPoints = value
        End Set
    End Property
    Private mUpperPoints As Decimal
    
    ' Standard Deviation
    Public Property sdPoints() As Decimal
        Get
            Return msdPoints
        End Get
        Set(value As Decimal)
            msdPoints = value
        End Set
    End Property
    Private msdPoints As Decimal
    
    ' Pos Rank
    Public Property PosRank() As Decimal
        Get
            Return mPosRank
        End Get
        Set(value As Decimal)
            mPosRank = value
        End Set
    End Property
    Private mPosRank As Decimal
    
    ' Dropoff
    Public Property Dropoff() As Decimal
        Get
            Return mDropoff
        End Get
        Set(value As Decimal)
            mDropoff = value
        End Set
    End Property
    Private mDropoff As Decimal
    
    ' Pos Rank
    Public Property Tier() As Decimal
        Get
            Return mTier
        End Get
        Set(value As Decimal)
            mTier = value
        End Set
    End Property
    Private mTier As Decimal
    
    ' VOR
    Public Property VORPoints() As Decimal
        Get
            Return m_VORPoints
        End Get
        Set(value As Decimal)
            m_VORPoints = value
        End Set
    End Property
    Private m_VORPoints As Decimal
    
    ' Overall Rank
    Public Property OvrRank() As Decimal
        Get
            Return mOvrRank
        End Get
        Set(value As Decimal)
            mOvrRank = value
        End Set
    End Property
    Private mOvrRank As Decimal
    
    ' ADP
    Public Property ADP() As Decimal
        Get
            Return mADP
        End Get
        Set(value As Decimal)
            mADP = value
        End Set
    End Property
    Private mADP As Decimal
    
    ' AAV
    Public Property AAV() As Decimal
        Get
            Return mAAV
        End Get
        Set(value As Decimal)
            mAAV = value
        End Set
    End Property
    Private mAAV As Decimal
    
    ' ADP Difference
    Public Property ADPDiff() As Decimal
        Get
            Return mADPDiff
        End Get
        Set(value As Decimal)
            mADPDiff = value
        End Set
    End Property
    Private mADPDiff As Decimal
    
    ' Experience
    Public Property Exp() As Decimal
        Get
            Return mExp
        End Get
        Set(value As Decimal)
            mExp = value
        End Set
    End Property
    Private mExp As Decimal
    
    ' ecrPosition
    Public Property ecrPosition() As Decimal
        Get
            Return mecrPosition
        End Get
        Set(value As Decimal)
            mecrPosition = value
        End Set
    End Property
    Private mecrPosition As Decimal
    
    ' sdRank
    Public Property sdRank() As Decimal
        Get
            Return msdRank
        End Get
        Set(value As Decimal)
            msdRank = value
        End Set
    End Property
    Private msdRank As Decimal
    
    ' ecrRank
    Public Property ecrRank() As Decimal
        Get
            Return mecrRank
        End Get
        Set(value As Decimal)
            mecrRank = value
        End Set
    End Property
    Private mecrRank As Decimal
    
    ' Risk
    Public Property Risk() As Decimal
        Get
            Return mRisk
        End Get
        Set(value As Decimal)
            mRisk = value
        End Set
    End Property
    Private mRisk As Decimal

    ' Flex Points
    Public Property FlexPoints() As Decimal
        Get
            Return m_FlexPoints
        End Get
        Set(value As Decimal)
            m_FlexPoints = value
        End Set
    End Property
    Private m_FlexPoints As Decimal
End Class
