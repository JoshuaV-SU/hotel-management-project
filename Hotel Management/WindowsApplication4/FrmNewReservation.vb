Imports IBM.Data.DB2
Public Class FrmNewReservation
    Dim HotelConn As Common.DbConnection
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim str As String
        Dim cmd As DB2Command
        Dim rdr As DB2DataReader
        Dim row As String()
        Try
            HotelConn = New DB2Connection("server=localhost;database=hotel;" + "uid = db2admin;password=db2admin;")
            HotelConn.Open()
            DgvRoomView.ReadOnly = True
            DgvRoomView.AllowUserToResizeRows = False
            DgvRoomView.AllowUserToResizeColumns = False
            With Me.DgvRoomView
                .ColumnCount = 4
                .Columns(0).Name = "Room ID"
                .Columns(1).Name = "Room Type"
                .Columns(2).Name = "Room Cost"
                .Columns(3).Name = "Rooms Available"
            End With

            With Me.DgvGuest
                .ColumnCount = 2
                .Columns(0).Name = "Guest ID"
                .Columns(1).Name = "Guest Name"
            End With

            str = "select * from table(REFRESHTableROOM())As udf"
            cmd = New DB2Command(str, HotelConn)
            rdr = cmd.ExecuteReader
            While rdr.Read
                row = New String() {rdr.GetString(0), rdr.GetString(1), rdr.GetString(2), rdr.GetString(3)}
                Me.DgvRoomView.Rows.Add(row)
            End While

            str = "select * from table(GET_GUEST_LIST())As udf"
            cmd = New DB2Command(str, HotelConn)
            rdr = cmd.ExecuteReader
            While rdr.Read
                row = New String() {rdr.GetString(0), rdr.GetString(1)}
                Me.DgvGuest.Rows.Add(row)
            End While

            rdr.Close()

            Me.BtnReserve.Enabled = False
            Me.DgvRoomView.ClearSelection()
            Me.DgvGuest.ClearSelection()


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        HotelConn.Close()
        Me.Close()

    End Sub

    Private Sub RoomView_MouseUp(sender As Object, e As MouseEventArgs) Handles DgvRoomView.MouseUp
        Me.roomIdText.Text = Me.DgvRoomView.CurrentRow.Cells(0).Value
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnReserve.Click
        Dim str As String
        Dim cmd As DB2Command
        Dim rdr As DB2DataReader
        Dim row As String()
        Dim p1, p2, p3, p4, p5, p6

        Dim billExists As Boolean

        Try
            str = "Call RESERVATIONINSERT(?,?,?,?,?,?)"
            cmd = New DB2Command(str, HotelConn)

            p1 = cmd.Parameters.Add("@n1", DB2Type.Integer)
            p1.Direction = ParameterDirection.Input
            cmd.Parameters("@n1").Value = guestIdTxt.Text

            p2 = cmd.Parameters.Add("@n2", DB2Type.VarChar)
            p2.Direction = ParameterDirection.Input
            cmd.Parameters("@n2").Value = checkInTxt.Text

            p3 = cmd.Parameters.Add("@n3", DB2Type.VarChar)
            p3.Direction = ParameterDirection.Input
            cmd.Parameters("@n3").Value = checkOutTxt.Text

            p4 = cmd.Parameters.Add("@n4", DB2Type.Integer)
            p4.Direction = ParameterDirection.Input
            cmd.Parameters("@n4").Value = roomIdText.Text

            p5 = cmd.Parameters.Add("@n5", DB2Type.VarChar)
            p5.Direction = ParameterDirection.Input
            cmd.Parameters("@n5").Value = statusTxt.Text

            p6 = cmd.Parameters.Add("@n6", DB2Type.Integer)
            p6.Direction = ParameterDirection.Input
            cmd.Parameters("@n6").Value = noGuestTxt.Text
            rdr = cmd.ExecuteReader

            billExists = HasBill()

            If (billExists = True) Then
                Call UpdateBill()
            Else
                Call InsertBill()
            End If

            str = "select * from table(REFRESHTableROOM())As udf"
            cmd = New DB2Command(str, HotelConn)
            rdr = cmd.ExecuteReader
            Me.DgvRoomView.Rows.Clear()
            While rdr.Read
                row = New String() {rdr.GetString(0), rdr.GetString(1), rdr.GetString(2), rdr.GetString(3)}
                Me.DgvRoomView.Rows.Add(row)
            End While
            rdr.Close()

            MsgBox("Reservation Successful", , "New Reservation")

            Call clear()

        Catch ex As Exception
            MsgBox("Invalid Values")
        End Try

    End Sub

    Private Sub clear()
        Me.statusTxt.SelectedIndex = -1
        Me.guestIdTxt.Clear()
        Me.checkInTxt.Clear()
        Me.checkOutTxt.Clear()
        Me.roomIdText.Clear()
        Me.noGuestTxt.Clear()
        Me.DgvGuest.ClearSelection()
        Me.DgvRoomView.ClearSelection()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim str As String
        Dim cmd As DB2Command
        Dim rdr As DB2DataReader
        Dim row As String()
        Try
            str = "select * from table(REFRESHTableROOM())As udf"
            cmd = New DB2Command(str, HotelConn)
            rdr = cmd.ExecuteReader
            Me.DgvRoomView.Rows.Clear()
            While rdr.Read
                row = New String() {rdr.GetString(0), rdr.GetString(1), rdr.GetString(2), rdr.GetString(3)}
                Me.DgvRoomView.Rows.Add(row)
            End While
            rdr.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub NoEntry()
        If (Me.guestIdTxt.Text <> "") And (Me.checkInTxt.Text <> "") And (Me.checkOutTxt.Text <> "") And (Me.noGuestTxt.Text <> "") And (Me.statusTxt.SelectedIndex <> -1) And (Me.roomIdText.Text <> "") Then
            Me.BtnReserve.Enabled = True
        Else
            Me.BtnReserve.Enabled = False

        End If
    End Sub

    Function HasBill() As Integer
        Dim str As String
        Dim cmd As DB2Command
        Dim rdr As DB2DataReader
        Dim guestID As Integer

        Dim billExists As Boolean
        guestID = Me.guestIdTxt.Text

        Try
            str = "select * from table(GET_BILL('" & guestID & "'))As udf"
            cmd = New DB2Command(str, HotelConn)
            rdr = cmd.ExecuteReader
            rdr.Read()

            If (rdr.HasRows) Then
                billExists = True
            Else
                billExists = False
            End If

            rdr.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


        Return billExists

    End Function

    Private Sub InsertBill()
        Dim str As String
        Dim cmd As DB2Command
        Dim rdr As DB2DataReader
        Dim p1, p2

        Try
            str = "Call INSERT_BILL(?,?)"
            cmd = New DB2Command(str, HotelConn)

            p1 = cmd.Parameters.Add("@n1", DB2Type.Integer)
            p1.Direction = ParameterDirection.Input
            cmd.Parameters("@n1").Value = guestIdTxt.Text

            p2 = cmd.Parameters.Add("@n2", DB2Type.Integer)
            p2.Direction = ParameterDirection.Input
            cmd.Parameters("@n2").Value = roomIdText.Text

            rdr = cmd.ExecuteReader

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub UpdateBill()
        Dim str As String
        Dim cmd As DB2Command
        Dim rdr As DB2DataReader
        Dim p1, p2

        Try
            str = "Call UPDATE_BILL_RESERVATION(?,?)"
            cmd = New DB2Command(str, HotelConn)

            p1 = cmd.Parameters.Add("@n1", DB2Type.Integer)
            p1.Direction = ParameterDirection.Input
            cmd.Parameters("@n1").Value = guestIdTxt.Text

            p2 = cmd.Parameters.Add("@n2", DB2Type.Integer)
            p2.Direction = ParameterDirection.Input
            cmd.Parameters("@n2").Value = roomIdText.Text

            rdr = cmd.ExecuteReader

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub guestIdTxt_TextChanged(sender As Object, e As EventArgs) Handles guestIdTxt.TextChanged
        Call NoEntry()
    End Sub

    Private Sub checkInTxt_TextChanged(sender As Object, e As EventArgs) Handles checkInTxt.TextChanged
        Call NoEntry()
    End Sub

    Private Sub checkOutTxt_TextChanged(sender As Object, e As EventArgs) Handles checkOutTxt.TextChanged
        Call NoEntry()
    End Sub

    Private Sub noGuestTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles noGuestTxt.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub noGuestTxt_TextChanged(sender As Object, e As EventArgs) Handles noGuestTxt.TextChanged
        Call NoEntry()
    End Sub

    Private Sub roomIdText_TextChanged(sender As Object, e As EventArgs) Handles roomIdText.TextChanged
        Call NoEntry()
    End Sub

    Private Sub statusTxt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles statusTxt.SelectedIndexChanged
        Call NoEntry()
    End Sub

    Private Sub roomIdTxt_TextChanged(sender As Object, e As EventArgs) Handles roomIdTxt.TextChanged
        Dim roomType As String
        Dim str As String
        Dim cmd As DB2Command
        Dim rdr As DB2DataReader
        Dim row As String()

        Me.DgvRoomView.Rows.Clear()

        roomType = "%" + roomIdTxt.Text + "%"
        str = "select * from table(GETROOMTABLE('" & roomType & "'))As udf"

        cmd = New DB2Command(str, HotelConn)
        rdr = cmd.ExecuteReader
        While rdr.Read
            row = New String() {rdr.GetString(0), rdr.GetString(1), rdr.GetString(2), rdr.GetString(3)}
            Me.DgvRoomView.Rows.Add(row)
        End While
        rdr.Close()
    End Sub

    Private Sub DgvGuest_MouseUp(sender As Object, e As MouseEventArgs) Handles DgvGuest.MouseUp
        Me.guestIdTxt.Text = Me.DgvGuest.CurrentRow.Cells(0).Value
    End Sub
End Class
