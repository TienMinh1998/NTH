''' <summary>
''' Service người dùng, chuyên cung cấp các hàm liên quan đến người dùng
''' Ngày viết 20-09-2022
''' Chỉnh sửa : Chưa chỉnh sửa
''' Lưu ý: Project có sử dụng SQLSERVE
''' </summary>
Public Class UserService
    Public context As databaseDataContext = New databaseDataContext()

    ''' <summary>
    ''' Return Users
    ''' </summary>
    ''' <returns></returns>
    Public Function GetAllUser() As Object
        Dim users = From u In context.tbl_users
                    Where u.Id > 0
                    Select u

        Return users
    End Function

    ''' <summary>
    ''' Get User BY Id
    ''' </summary>
    ''' <param name="Id"></param>
    ''' <returns></returns>
    Public Function GetUserById(Id As Integer) As Object
        Return context.tbl_users.Where(Function(x) x.Id = Id).FirstOrDefault()
    End Function

    ''' <summary>
    ''' Hàm Đăng nhập, Trả về thông tin của người dùng
    ''' </summary>
    ''' <param name="tk"></param>
    ''' <param name="Mk"></param>
    ''' <returns></returns>
    Public Function Login(tk As String, Mk As String) As tbl_user
        Dim user = context.tbl_users.Where(Function(x) x.AcountName = tk And x.PassWord = Mk).FirstOrDefault()
        If user Is Nothing Then
            Return Nothing
        End If
        Return user
    End Function

    ''' <summary>
    ''' Thêm mới 1 người dùng vào trong cơ sử dữ liệu
    ''' </summary>
    ''' <param name="user"></param>
    ''' <returns></returns>
    Public Function InsertUser(user As tbl_user) As Boolean
        Try
            context.tbl_users.InsertOnSubmit(user)
            context.SubmitChanges()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class
