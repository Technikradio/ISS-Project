Public Class fm_Main
    Dim strg As Boolean = False

    Private Sub fm_Main_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Control Or e.KeyCode = Keys.ControlKey Then
            strg = True
        End If
        If e.KeyCode = Keys.Q And strg = True Then
            MsgBox("Quellen:")
        End If
    End Sub

    Private Sub fm_Main_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Control Or e.KeyCode = Keys.ControlKey Then
            strg = False
        End If
    End Sub

    Private Sub fm_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MsgBox("Hallo Welt")
    End Sub

    Private Sub AToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AToolStripMenuItem.Click
        MsgBox("http://www.nasa.gov/mission_pages/station/expeditions/past.html" & Chr(13) _
               & "http://www.nasa.gov/mission_pages/station/expeditions/future.html" & Chr(13), MsgBoxStyle.Information, "Quellen")
    End Sub
End Class


