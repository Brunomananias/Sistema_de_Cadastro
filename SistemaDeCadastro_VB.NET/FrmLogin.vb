Imports System.Data.SqlClient
Public Class FrmLogin
    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        If Not ValidarUsuario() Then
            MsgBox("Usuário ou senha inválidos")
        Else
            Me.Close()

        End If
    End Sub

    Private Function ValidarUsuario() As Boolean
        Dim Sql = "SELECT * FROM Usuarios WHERE login=@login AND senha=@senha"
        Dim result = False

        Try
            Using cn = New SqlConnection(conn)
                cn.Open()

                Using cmd = New SqlCommand(Sql, cn)
                    cmd.Parameters.AddWithValue("@login", TxtUsuario.Text)
                    cmd.Parameters.AddWithValue("@senha", TxtSenha.Text)

                    Using dr = cmd.ExecuteReader()

                        If dr.HasRows Then
                            If dr.Read() Then
                                pIdUsuario = dr("id")
                                pNomeUsuario = dr("login")
                                pAdministrador = IIf(dr("Administrador") = "S", True, False)
                                If dr("ativo") = "S" Then
                                    pAcessoPermitido = True
                                    result = True
                                Else
                                    pAcessoPermitido = False
                                    result = False

                                End If
                            End If
                        End If


                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        Return result

    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FrmUsuarioCadastro.Show()
    End Sub
End Class