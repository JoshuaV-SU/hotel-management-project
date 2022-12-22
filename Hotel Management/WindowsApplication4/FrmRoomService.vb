Imports IBM.Data.DB2
Public Class FrmRoomService
    Dim DbConnection As Common.DbConnection
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            DbConnection = New DB2Connection("server=localhost;database=hotel;" + "uid=db2admin;password=db2admin;")
            DbConnection.Open()

            With Me.DgvServices
                .ColumnCount = 1
                .Columns(0).Name = "Service Name"
            End With

            With Me.DgvInHotel
                .ColumnCount = 2
                .Columns(0).Name = "Guest ID"
                .Columns(1).Name = "Room ID"
            End With
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Call DisplayRoomServices()
        Call DisplayInHotel()

        Me.DgvInHotel.ClearSelection()
        Me.DgvServices.ClearSelection()
        Me.BtnConfirm.Enabled = False

    End Sub

    Private Sub DisplayRoomServices()
        Dim Str As String
        Dim Cmd As DB2Command
        Dim Rdr As DB2DataReader
        Dim row As String()

        Str = "select * from table(GET_ROOM_SERVICE_LIST()) as udf"

        Cmd = New DB2Command(Str, DbConnection)
        Rdr = Cmd.ExecuteReader

        While Rdr.Read
            row = New String() {Rdr.GetString(0)}
            Me.DgvServices.Rows.Add(row)
        End While
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

    Private Sub BtnConfirm_Click(sender As Object, e As EventArgs) Handles BtnConfirm.Click
        Dim Str As String
        Dim Cmd As DB2Command
        Dim Rdr As DB2DataReader
        Dim P1 As DB2Parameter
        Dim P2 As DB2Parameter

        Dim serviceName As String
        Dim guestID As Integer
        Dim serviceID As Integer

        Try

            serviceName = DgvServices.CurrentRow.Cells(0).Value
            guestID = DgvInHotel.CurrentRow.Cells(0).Value

            serviceID = GetServiceID(serviceName)


            Str = "call db2admin.INSERT_AVAILEDSERVICE(?, ?)"
            Cmd = New DB2Command(Str, DbConnection)

            P1 = Cmd.Parameters.Add("@n1", DB2Type.Integer)
            P1.Direction = ParameterDirection.Input
            Cmd.Parameters("@n1").Value = guestID

            P2 = Cmd.Parameters.Add("@n2", DB2Type.Integer)
            P2.Direction = ParameterDirection.Input
            Cmd.Parameters("@n2").Value = serviceID

            Rdr = Cmd.ExecuteReader

            MsgBox("Order Confirmed", , "Room Service")

            Rdr.Close()

            Call Reset()

        Catch ex As Exception
            MsgBox(ex.ToString)
            Call Reset()
        End Try

    End Sub

    Function GetServiceID(servicename As String) As Integer
        Dim Str As String
        Dim Cmd As DB2Command
        Dim Rdr As DB2DataReader
        Dim P1 As DB2Parameter
        Dim P2 As DB2Parameter

        Dim serviceID As Integer

        Str = "call db2admin.GET_SERVICEID(?, ?)"
        Cmd = New DB2Command(Str, DbConnection)

        P1 = Cmd.Parameters.Add("@n1", DB2Type.VarChar)
        P1.Direction = ParameterDirection.Input
        Cmd.Parameters("@n1").Value = servicename

        P2 = Cmd.Parameters.Add("@n2", DB2Type.Integer)
        P2.Direction = ParameterDirection.Output

        Rdr = Cmd.ExecuteReader

        serviceID = P2.Value

        Return serviceID
    End Function

    Private Sub Reset()

        Me.DgvInHotel.ClearSelection()
        Me.DgvServices.ClearSelection()
        Me.BtnConfirm.Enabled = False

    End Sub

    Private Sub NoEntry()
        If (Me.DgvInHotel.SelectedRows.Count <> 0) And (Me.DgvServices.SelectedRows.Count <> 0) Then
            Me.BtnConfirm.Enabled = True
        Else
            Me.BtnConfirm.Enabled = False
        End If
    End Sub

    Private Sub DgvInHotel_MouseUp(sender As Object, e As MouseEventArgs) Handles DgvInHotel.MouseUp
        Call NoEntry()
    End Sub

    Private Sub DgvServices_MouseUp(sender As Object, e As MouseEventArgs) Handles DgvServices.MouseUp
        Call NoEntry()
    End Sub


End Class
