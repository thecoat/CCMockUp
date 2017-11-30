Imports CCMockUp

Public Class BankTerminal
    Implements ICreditCardProcessing

    Public Sub ProcessTransaction() Implements ICreditCardProcessing.ProcessTransaction
        MsgBox("I am a BankTerminal")
    End Sub

    Public Sub CancelTransaction() Implements ICreditCardProcessing.CancelTransaction
        Throw New NotImplementedException()
    End Sub
End Class
