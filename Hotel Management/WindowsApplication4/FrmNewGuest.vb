Imports IBM.Data.DB2
Public Class FrmNewGuest
    Dim DbConnection As Common.DbConnection
    Private Sub FrmNewGuest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DbConnection = New DB2Connection("server=localhost;database=hotel;" + "uid=db2admin;password=db2admin;")
        DbConnection.Open()

        Me.BtnConfirm.Enabled = False
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnConfirm.Click

        Dim Str As String
        Dim Cmd As DB2Command
        Dim Rdr As DB2DataReader
        Dim P1 As DB2Parameter
        Dim P2 As DB2Parameter
        Dim P3 As DB2Parameter

        Try

            Str = "call db2admin.INSERT_GUEST(?,?,?)"
            Cmd = New DB2Command(Str, DbConnection)

            P1 = Cmd.Parameters.Add("@n1", DB2Type.VarChar)
            P1.Direction = ParameterDirection.Input
            Cmd.Parameters("@n1").Value = Me.TxtGuestName.Text

            P2 = Cmd.Parameters.Add("@n2", DB2Type.VarChar)
            P2.Direction = ParameterDirection.Input
            Cmd.Parameters("@n2").Value = Me.TxtGuestAdd.Text

            P3 = Cmd.Parameters.Add("@n3", DB2Type.Char)
            P2.Direction = ParameterDirection.Input
            Cmd.Parameters("@n3").Value = Me.TxtGuestPhoneNo.Text

            Rdr = Cmd.ExecuteReader

            MsgBox("Successfully Added", , "New Guest")

            Call Reset()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub Reset()
        Me.TxtGuestAdd.Clear()
        Me.TxtGuestName.Clear()
        Me.TxtGuestPhoneNo.Clear()
        Me.BtnConfirm.Enabled = False
        Me.TxtGuestName.Focus()
    End Sub

    Private Sub NoEntry()
        If (Me.TxtGuestAdd.Text <> "") And (Me.TxtGuestName.Text <> "") And (Me.TxtGuestPhoneNo.Text <> "") Then
            Me.BtnConfirm.Enabled = True
        Else
            Me.BtnConfirm.Enabled = False
        End If
    End Sub

    Private Sub TxtGuestName_TextChanged(sender As Object, e As EventArgs) Handles TxtGuestName.TextChanged
        Call NoEntry()
    End Sub

    Private Sub TxtGuestAdd_TextChanged(sender As Object, e As EventArgs) Handles TxtGuestAdd.TextChanged
        Call NoEntry()
    End Sub

    Private Sub TxtGuestPhoneNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtGuestPhoneNo.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtGuestPhoneNo_TextChanged(sender As Object, e As EventArgs) Handles TxtGuestPhoneNo.TextChanged
        Call NoEntry()
    End Sub
End Class