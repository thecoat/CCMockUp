Imports CCMockUp

Public Class VerifoneTerminal
    Implements ICreditCardProcessing

    Public Sub ProcessTransaction() Implements ICreditCardProcessing.ProcessTransaction
        MsgBox("I am a VerifoneTerminal")
    End Sub

    Public Sub CancelTransaction() Implements ICreditCardProcessing.CancelTransaction
        Throw New NotImplementedException()
    End Sub
End Class
