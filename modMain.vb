Module modMain

    Public Sub Init()

    End Sub
    Sub New()
        SwitchCCType(1)
    End Sub

    Public Sub SwitchCCType(ByVal intType As Integer)
        modPointWrapper.InitializeCreditCards(intType)
    End Sub
End Module
