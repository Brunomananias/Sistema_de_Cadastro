Imports System.Data.SqlClient
Module ConexãoSQL

    Public conn = "Data Source=DESKTOP-05IP2B2\SQLEXPRESS ;Database=Cadastro;User Id=sa;Password=Pardini2021!;"

    Public sistema = "Controle de Acesso"

    Public pIdUsuario As Integer
    Public pNomeUsuario As String
    Public pAdministrador As Boolean
    Public pAcessoPermitido = False


End Module
