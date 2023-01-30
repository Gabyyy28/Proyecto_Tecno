Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.Data
Public Class Form1
    Public Conexion As SqlConnection = New SqlConnection(My.Settings.Conexion)
    Private cmb As SqlCommandBuilder
    Public ds As DataSet = New DataSet
    Public da As SqlDataAdapter = New SqlDataAdapter
    Public cmd As SqlCommand

    'Método - Consulta'
    Public Sub consulta(ByVal sql As String, ByVal tabla As String)

        ds.Tables.Clear()
        da = New SqlDataAdapter(sql, Conexion)
        cmb = New SqlCommandBuilder(da)
        da.Fill(ds, tabla)

    End Sub

    'Metodo - Verificacion'
    Function Verificacion(ByVal sql)
        Conexion.Open()
        cmd = New SqlCommand(sql, Conexion)
        Dim i As Integer = cmd.ExecuteNonQuery
        Conexion.Close()
        If (i > 0) Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub Label1_click(sender As Object e As EvenventArgs) Handles 
           Dim fin = Crud
        Dim verificar As String = "update PRACTC set TIPO=TIPO where USUARIO='" + txt_usuario.Text + "' and CONTRASEÑA='" + txt_contraseña.Text + "' and TIPO='ADMINISTRADOR'"
        Dim verificar2 As String = "update PRACTC set TIPO=TIPO where USUARIO='" + txt_usuario.Text + "' and CONTRASEÑA='" + txt_contraseña.Text + "' and TIPO='SECRETARIA'"
        Dim verificar3 As String = "update PRACTC set TIPO=TIPO where USUARIO='" + txt_usuario.Text + "' and CONTRASEÑA='" + txt_contraseña.Text + "' and TIPO='USUARIO'"

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles txt_usuario.Click
        Dim USUARIO As String
        USUARIO = txt_contraseña.Text


    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim USUARIO As String
        USUARIO = TextBox1.Text





    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Dim CONTRASEÑA As String
        CONTRASEÑA = TextBox2.Text

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click


        End
    End Sub

    Private Sub Privatesub(sender As Object, e As EventArgs) Handles txt_contraseña.Click
        Contraseña = txt_contraseña.Text











    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles btn_ingresar.Click
        Dim f2 = ADMINISTRADOR
        Dim verificar As String = "update SECCION set ROLL=ROLL where USUARIO='" + txt_usuario.Text + "' and CONTRASEÑA='" + txt_contraseña.Text + "' and ROLL='administrador'"
        Dim verificar2 As String = "update SECCION set ROLL=ROLL where USUARIO='" + txt_usuario.Text + "' and CONTRASEÑA='" + txt_contraseña.Text + "' and ROLL='usuario'"
        Dim verificar3 As String = "update SECCION set ROLL=ROLL where USUARIO='" + txt_usuario.Text + "' and CONTRASEÑA='" + txt_contraseña.Text + "' and ROLL='secretaria'"

        If con.Verificacion(verificar) Then
            ADMINISTRADOR.BringToFront()
    End Sub
End Class

