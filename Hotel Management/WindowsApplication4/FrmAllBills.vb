Imports IBM.Data.DB2
Public Class FrmAllBills
    Dim HotelConn As Common.DbConnection
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Str As String
        Dim Cmd As DB2Command
        Dim Rdr As DB2DataReader
        Dim row As String()

        HotelConn = New DB2Connection("server=localhost;database=hotel;" + "uid = db2admin;password=db2admin;")
        HotelConn.Open()

        With Me.DgvBills
            .ColumnCount = 4
            .Columns(0).Name = "Bill ID"
            .Columns(1).Name = "Bill Total"
            .Columns(2).Name = "Guest ID"
            .Columns(3).Name = "Bill Status"
        End With

        Str = "select * from table(GET_BILL_ALL()) as udf"

        Cmd = New DB2Command(Str, HotelConn)
        Rdr = Cmd.ExecuteReader

        While Rdr.Read
            row = New String() {Rdr.GetString(0), Rdr.GetString(1), Rdr.GetString(2), Rdr.GetString(3)}
            Me.DgvBills.Rows.Add(row)
        End While

    End Sub

    Private Sub DgvBills_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvBills.CellContentClick

    End Sub
End Class