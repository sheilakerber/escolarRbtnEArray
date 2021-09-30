Module modValidarCampos

    Public Function validarcampos(aluno) As Boolean

        If (aluno = Nothing Or IsNumeric(aluno)) Then
            MsgBox("Campo aluno está em branco ou não é um valor válido. Por favor, verifique.", MsgBoxStyle.Critical, "Atenção!")
            Return False
        End If

        If (Not mainForm.rbtDevSist.Checked And Not mainForm.rbtEletrotec.Checked And Not mainForm.rbtMecanica.Checked) Then
            MsgBox("Campo curso está em branco. Por favor, verifique.", MsgBoxStyle.Critical, "Atenção!")
            Return False
        End If

        MsgBox("Aluno(a): " & aluno & vbCrLf & "Curso: " & mainForm.cursoChecked & vbCrLf & "Disciplina: " & mainForm.disciplinaCadastrada, MsgBoxStyle.OkOnly, "Confirmação de matrícula")
        Return True
    End Function



End Module