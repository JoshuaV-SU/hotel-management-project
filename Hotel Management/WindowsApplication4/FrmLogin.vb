Imports IBM.Data.DB2
Public Class FrmLogin
    Dim DbConnection As Common.DbConnection



    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DbConnection = New DB2Connection("server=localhost;database=hotel;" + "uid=db2admin;password=db2admin;")
        DbConnection.Open()

        Me.OK.Enabled = True

    End Sub

    Function GetPosition(EmpID As Integer) As String
        Dim Str As String
        Dim Cmd As DB2Command
        Dim Rdr As DB2DataReader
        Dim P1 As DB2Parameter
        Dim P2 As DB2Parameter
        Dim EmpPos As String

        Str = "call db2admin.GET_POS(?, ?)"
        Cmd = New DB2Command(Str, DbConnection)

        P1 = Cmd.Parameters.Add("@n1", DB2Type.Integer)
        P1.Direction = ParameterDirection.Input
        Cmd.Parameters("@n1").Value = EmpID

        P2 = Cmd.Parameters.Add("@n2", DB2Type.VarChar)
        P2.Direction = ParameterDirection.Output

        Rdr = Cmd.ExecuteReader

        EmpPos = P2.Value

        Rdr.Close()

        Return EmpPos
    End Function


    Private Sub NoEntry()
        If (Me.TxtUsername.Text <> "") And (Me.TxtPassword.Text <> "") Then
            Me.OK.Enabled = True
        Else
            Me.OK.Enabled = False
        End If
    End Sub





    Private Sub TxtUsername_TextChanged(sender As Object, e As EventArgs)
        Call NoEntry()
    End Sub



    Private Sub OK_Click_1(sender As Object, e As EventArgs) Handles OK.Click
        Dim Str As String
        Dim Cmd As DB2Command
        Dim Rdr As DB2DataReader
        Dim P1 As DB2Parameter
        Dim P2 As DB2Parameter
        Dim P3 As DB2Parameter


        Dim EmpID As Integer
        Dim EmpPos As String

        Try

            Str = "call db2admin.GET_EMPID(?, ?, ?)"
            Cmd = New DB2Command(Str, DbConnection)

            P1 = Cmd.Parameters.Add("@n1", DB2Type.VarChar)
            P1.Direction = ParameterDirection.Input
            Cmd.Parameters("@n1").Value = Me.TxtUsername.Text

            P2 = Cmd.Parameters.Add("@n2", DB2Type.VarChar)
            P2.Direction = ParameterDirection.Input
            Cmd.Parameters("@n2").Value = Me.TxtPassword.Text

            P3 = Cmd.Parameters.Add("@n3", DB2Type.Integer)
            P3.Direction = ParameterDirection.Output

            Rdr = Cmd.ExecuteReader

            EmpID = P3.Value

            Rdr.Close()

            EmpPos = GetPosition(EmpID)

            If EmpPos = "Front Desk Clerk" Then
                MenuClerk.Show()
            ElseIf EmpPos = "Cashier" Then
                MenuCashier.Show()
            End If
            Me.Close()

        Catch ex As Exception
            MsgBox("Invalid Username/Password")
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TxtPassword.TextChanged
        Call NoEntry()
    End Sub
End Class
