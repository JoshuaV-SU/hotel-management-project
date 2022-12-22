Imports IBM.Data.DB2
Public Class FrmPayment
    Dim DbConnection As Common.DbConnection
    Private Sub FrmMenuCashier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            DbConnection = New DB2Connection("server=localhost;database=hotel;" + "uid=db2admin;password=db2admin;")
            DbConnection.Open()

            With Me.DgvBills
                .ColumnCount = 2
                .Columns(0).Name = "Guest ID"
                .Columns(1).Name = "Bill Total"
            End With
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Call DisplayBills()

        Me.DgvBills.ClearSelection()
        Me.BtnPay.Enabled = False
    End Sub

    Private Sub DisplayBills()
        Dim Str As String
        Dim Cmd As DB2Command
        Dim Rdr As DB2DataReader
        Dim row As String()

        Str = "select * from table(GET_BILL_UNPAID()) as udf"

        Cmd = New DB2Command(Str, DbConnection)
        Rdr = Cmd.ExecuteReader

        While Rdr.Read
            row = New String() {Rdr.GetString(0), Rdr.GetString(1)}
            Me.DgvBills.Rows.Add(row)
        End While
    End Sub

    Private Sub DgvBills_MouseUp(sender As Object, e As MouseEventArgs) Handles DgvBills.MouseUp
        Me.TxtGuestID.Text = Me.DgvBills.CurrentRow.Cells(0).Value
        Me.TxtTotal.Text = Me.DgvBills.CurrentRow.Cells(1).Value

        Call NoEntry()
    End Sub

    Private Sub NoEntry()
        If (Me.DgvBills.SelectedRows.Count > 0) Then
            Me.BtnPay.Enabled = True
        Else
            Me.BtnPay.Enabled = False
        End If
    End Sub

    Private Sub BtnPay_Click(sender As Object, e As EventArgs) Handles BtnPay.Click
        Dim Str As String
        Dim Cmd As DB2Command
        Dim Rdr As DB2DataReader
        Dim P1 As DB2Parameter

        Dim guestID As Integer

        guestID = Me.TxtGuestID.Text

        Str = "call db2admin.PAYBILL(?)"
        Cmd = New DB2Command(Str, DbConnection)

        P1 = Cmd.Parameters.Add("@n1", DB2Type.Integer)
        P1.Direction = ParameterDirection.Input
        Cmd.Parameters("@n1").Value = guestID

        Rdr = Cmd.ExecuteReader

        MsgBox("Payment Confirmed")

        Rdr.Close()

        Me.DgvBills.Rows.Clear()
        Call DisplayBills()
        Call Reset()
    End Sub

    Private Sub Reset()
        Me.DgvBills.ClearSelection()
        Me.BtnPay.Enabled = False
        Me.TxtGuestID.Clear()
        Me.TxtTotal.Clear()

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TxtTotal_TextChanged(sender As Object, e As EventArgs) Handles TxtTotal.TextChanged

    End Sub
End Class