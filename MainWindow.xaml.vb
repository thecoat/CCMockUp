Class MainWindow
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Init()
    End Sub

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        ProcessTransaction()
    End Sub

    Private Sub Button_Click_1(sender As Object, e As RoutedEventArgs)
        SwitchCCType(1)
    End Sub

    Private Sub Button_Click_2(sender As Object, e As RoutedEventArgs)
        SwitchCCType(2)
    End Sub
End Class
