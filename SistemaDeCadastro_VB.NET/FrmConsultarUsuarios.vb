﻿Imports System.Data.SqlClient
Imports System.Data
Public Class FrmConsultarUsuarios


    Private Sub FrmConsultarUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Vincula o DataGridView ao BindingSource e carrega os dados do banco de dados
        Me.DataGridView1.DataSource = Me.BindingSource1
        ExibeDados("SELECT * From Usuarios")
    End Sub

    Private Sub ExibeDados(ByVal selectCommand As String)
        Try
            'String de conexão.
            Dim connectionString As String = "Data Source=DESKTOP-05IP2B2\SQLEXPRESS ;Database=Cadastro;User Id=sa;Password=Pardini2021!;"
            'Cria um dataAdapter com o comando select.
            Dim dataAdapter As New SqlDataAdapter(selectCommand, connectionString)
            'Cria um command builder para gerar os SQL para atualizar, incluir e
            'deletar baseados no selectCommand.
            Dim commandBuilder As New SqlCommandBuilder(dataAdapter)
            'Preenche um novo dataTable e vincula ao binding source
            Dim table As New DataTable()
            table.Locale = System.Globalization.CultureInfo.InvariantCulture
            dataAdapter.Fill(table)
            BindingSource1.DataSource = table ' redimensiona as colunas do DataGridView
            DataGridView1.AutoResizeColumn(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader)


        Catch ex As Exception
            MsgBox("Erro ao carregar a tabela")
        End Try
    End Sub
End Class