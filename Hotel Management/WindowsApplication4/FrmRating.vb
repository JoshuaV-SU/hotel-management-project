Imports IBM.Data.DB2
Public Class FrmRating
    Dim DbConnection As Common.DbConnection
    Private Sub Rating_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            DbConnection = New DB2Connection("server=localhost;database=hotel;" + "uid=db2admin;password=db2admin;")
            DbConnection.Open()

            With Me.DgvInHotel
                .ColumnCount = 2
                .Columns(0).Name = "Guest ID"
                .Columns(1).Name = "Room ID"
            End With
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Call DisplayInHotel()
        Me.DgvInHotel.ClearSelection()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnConfirm.Click
        Dim item As String = ComboBox1.SelectedItem.ToString
        Dim rating As Integer = Convert.ToInt32(item)
        Dim guestID As Integer

        Dim Str As String
        Dim Cmd As DB2Command
        Dim Rdr As DB2DataReader
        Dim P1 As DB2Parameter
        Dim P2 As DB2Parameter

        Try
            guestID = DgvInHotel.CurrentRow.Cells(0).Value

            Str = "call db2admin.INSERT_RATING(?, ?)"
            Cmd = New DB2Command(Str, DbConnection)

            P1 = Cmd.Parameters.Add("@n1", DB2Type.Integer)
            P1.Direction = ParameterDirection.Input
            Cmd.Parameters("@n1").Value = rating

            P2 = Cmd.Parameters.Add("@n2", DB2Type.Integer)
            P2.Direction = ParameterDirection.Input
            Cmd.Parameters("@n2").Value = guestID

            Rdr = Cmd.ExecuteReader

            MsgBox("Rating Confirmed")

            Call Reset()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


    End Sub

    Private Sub DisplayInHotel()
        Dim Str As String
        Dim Cmd As DB2Command
        Dim Rdr As DB2DataReader
        Dim row As String()

        Str = "select * from table(GET_INHOTEL_LIST()) as udf"

        Cmd = New DB2Command(Str, DbConnection)
        Rdr = Cmd.ExecuteReader

        While Rdr.Read
            row = New String() {Rdr.GetString(0), Rdr.GetString(1)}
            Me.DgvInHotel.Rows.Add(row)
        End While
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Call NoEntry()
    End Sub

    Private Sub Reset()
        Me.DgvInHotel.ClearSelection()
        Me.BtnConfirm.Enabled = False
        Me.ComboBox1.SelectedIndex = -1
        Me.ComboBox1.Text = "Rating"
    End Sub

    Private Sub NoEntry()
        If (Me.DgvInHotel.SelectedRows.Count > 0) And (Me.ComboBox1.SelectedIndex <> -1) Then
            Me.BtnConfirm.Enabled = True
        Else
            Me.BtnConfirm.Enabled = False
        End If
    End Sub

    Private Sub DgvInHotel_MouseUp(sender As Object, e As MouseEventArgs) Handles DgvInHotel.MouseUp
        Call NoEntry()
    End Sub


End Class