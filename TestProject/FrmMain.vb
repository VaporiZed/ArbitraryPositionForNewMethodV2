Friend Class FrmMain

	Private ReadOnly DataContainer As New DataContainer

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		DataContainer.Baz
	End Sub
End Class
