﻿Public Class mainForm

    ' arrays para armazenar as disciplinas de cada curso
    Dim arrDiscpDesSist As Object = {"Lógica de Programãção", "Banco de Dados", "Programação Desktop", "Programação Web"}
    Dim arrDiscpEletrotec As Object = {"Cálculo", "Eletricidade", "Instalações Prediais", "Instalações Industriais"}
    Dim arrDiscpMecanica As Object = {"Cálculo", "Metrologia", "Resistência dos Materiais", "Manutenção Mecânica"}

    ' chama a funcao de validação dos campos utilizando o modValidarCampos
    Private Sub btnMatricular_Click(sender As Object, e As EventArgs) Handles btnMatricular.Click
        modValidarCampos.validarcampos(txtAluno.Text)
        modLimparCampos.limparCampos()
        Exit Sub
    End Sub

    ' atualiza o array de disciplinas no combobox do curso Des. Sistemas
    Private Sub rbtDevSist_CheckedChanged(sender As Object, e As EventArgs) Handles rbtDevSist.CheckedChanged
        If (rbtDevSist.Checked) Then
            cbxDisciplinas.DataSource = arrDiscpDesSist
        End If
    End Sub

    ' atualiza o array de disciplinas no combobox do curso Eletrotecnica
    Private Sub rbtEletrotec_CheckedChanged(sender As Object, e As EventArgs) Handles rbtEletrotec.CheckedChanged
        If (rbtEletrotec.Checked) Then
            cbxDisciplinas.DataSource = arrDiscpEletrotec
        End If
    End Sub

    ' atualiza o array de disciplinasno combobox do curso Mecanica
    Private Sub rbtMecanica_CheckedChanged(sender As Object, e As EventArgs) Handles rbtMecanica.CheckedChanged
        If (rbtMecanica.Checked) Then
            cbxDisciplinas.DataSource = arrDiscpMecanica
        End If
    End Sub
End Class
