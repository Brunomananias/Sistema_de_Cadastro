Imports System.Data.SqlClient
Public Class FrmCadastroClientes

    Private Sub BtnCadastrar_Click(sender As Object, e As EventArgs) Handles BtnCadastrar.Click
        InserirClientes()
    End Sub
    Private Sub InserirClientes()
        Try
            Dim sql = ""
            If CLng(0 & LblID.Text) = 0 Then
                sql = "INSERT INTO Clientes (Nome, Email, RG, CPF, Sexo, SexoFem, Endereco, Bairro, Estado, Complemento, Cep, Cidade, Telefone, Celular) 
                                    VALUES (@Nome, @Email, @RG, @CPF, @Sexo, @SexoFem, @Endereco, @Bairro, @Estado, @Complemento, @Cep, @Cidade, @Telefone, @Celular)"
            Else
                sql = ("UPDATE Clientes SET nome=@nome, email=@email, RG=@RG, CPF=@CPF, Sexo=@Sexo, sexoFem=@sexoFem,
                                    endereco=@endereco, bairro=@bairro, estado=@estado, complemento=@complemento, cep=@cep, cidade=@cidade, telefone=@telefone, celular=@celular WHERE ID" & LblID.Text)

            End If

            Using conexao As New SqlConnection(conn)
                conexao.Open()
                Using cmd As New SqlCommand(sql, conexao)
                    cmd.Parameters.AddWithValue("Nome", TxtNome.Text)
                    cmd.Parameters.AddWithValue("Email", TxtEmail.Text)
                    cmd.Parameters.AddWithValue("RG", TxtRG.Text)
                    cmd.Parameters.AddWithValue("CPF", TxtCPF.Text)
                    cmd.Parameters.AddWithValue("Sexo", IIf(ChkMasc.Checked, "S", "N"))
                    cmd.Parameters.AddWithValue("SexoFem", IIf(ChkFem.Checked, "S", "N"))
                    cmd.Parameters.AddWithValue("Endereco", TxtEndereco.Text)
                    cmd.Parameters.AddWithValue("Bairro", TxtBairro.Text)
                    cmd.Parameters.AddWithValue("Estado", TxtEstado.Text)
                    cmd.Parameters.AddWithValue("Complemento", TxtComplemento.Text)
                    cmd.Parameters.AddWithValue("Cep", TxtCEP.Text)
                    cmd.Parameters.AddWithValue("Cidade", TxtCidade.Text)
                    cmd.Parameters.AddWithValue("Telefone", TxtTel.Text)
                    cmd.Parameters.AddWithValue("Celular", TxtCel.Text)

                    cmd.ExecuteNonQuery()
                    MsgBox("Cadastrado com sucesso!")

                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


End Class