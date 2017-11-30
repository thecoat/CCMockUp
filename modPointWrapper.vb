Module modPointWrapper
    Private _creditProcessing As ICreditCardProcessing
    Sub New()

    End Sub

    Public Sub InitializeCreditCards(ByVal ccType As Integer)

        Select Case ccType
            Case 1
                _creditProcessing = New VerifoneTerminal
            Case Else
                _creditProcessing = New BankTerminal
        End Select
    End Sub

    Public Sub ProcessTransaction()
        If _creditProcessing IsNot Nothing Then _creditProcessing.ProcessTransaction()
    End Sub
End Module
