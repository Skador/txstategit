Imports System.Data
Imports System.Data.SqlClient
Public Class StudentConDB
    Dim myConS As String = "Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True"
    Dim myConn As New SqlConnection(myConS)
    Dim myDA As New SqlDataAdapter
    Dim myDS As New DataSet
    Dim myBDS As New BindingSource

    Public Sub InsertDB(ByVal pStudentID, ByVal pName, ByVal pType, ByVal pNoOfCourses, ByRef pMyDA)
        pMyDA.InsertCommand = New SqlCommand("insert into STUDENT(StudentID, Name, Type, NoOfCourses) values (@StudentID, @Name, @Type, @NoOfCourses)", myConn)

        pMyDA.InsertCommand.Parameters.Add("@StudentID", SqlDbType.BigInt).Value = CInt(pStudentID)
        pMyDA.InsertCommand.Parameters.Add("@Name", SqlDbType.VarChar).Value = pName
        pMyDA.InsertCommand.Parameters.Add("@Type", SqlDbType.VarChar).Value = pType
        pMyDA.InsertCommand.Parameters.Add("@NoOfCourses", SqlDbType.BigInt).Value = CInt(pNoOfCourses)

        myConn.Open()
        pMyDA.InsertCommand.ExecuteNonQuery()
        myConn.Close()

        myDS.Clear()
        pMyDA.Fill(myDS, "STUDENT")
    End Sub

    Public Shared Function GetStudentList() As DataSet

    End Function
End Class
