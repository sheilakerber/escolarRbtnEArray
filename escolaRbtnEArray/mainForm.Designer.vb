<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAluno = New System.Windows.Forms.TextBox()
        Me.rbtDevSist = New System.Windows.Forms.RadioButton()
        Me.rbtMecanica = New System.Windows.Forms.RadioButton()
        Me.rbtEletrotec = New System.Windows.Forms.RadioButton()
        Me.cbxDisciplinas = New System.Windows.Forms.ComboBox()
        Me.btnMatricular = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Aluno: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Curso:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(34, 174)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Disciplina:"
        '
        'txtAluno
        '
        Me.txtAluno.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAluno.Location = New System.Drawing.Point(103, 30)
        Me.txtAluno.Name = "txtAluno"
        Me.txtAluno.Size = New System.Drawing.Size(138, 24)
        Me.txtAluno.TabIndex = 3
        '
        'rbtDevSist
        '
        Me.rbtDevSist.AutoSize = True
        Me.rbtDevSist.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtDevSist.Location = New System.Drawing.Point(103, 71)
        Me.rbtDevSist.Name = "rbtDevSist"
        Me.rbtDevSist.Size = New System.Drawing.Size(113, 20)
        Me.rbtDevSist.TabIndex = 4
        Me.rbtDevSist.Text = "Dev. Sistemas"
        Me.rbtDevSist.UseVisualStyleBackColor = True
        '
        'rbtMecanica
        '
        Me.rbtMecanica.AutoSize = True
        Me.rbtMecanica.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtMecanica.Location = New System.Drawing.Point(103, 122)
        Me.rbtMecanica.Name = "rbtMecanica"
        Me.rbtMecanica.Size = New System.Drawing.Size(85, 20)
        Me.rbtMecanica.TabIndex = 5
        Me.rbtMecanica.Text = "Mecânica"
        Me.rbtMecanica.UseVisualStyleBackColor = True
        '
        'rbtEletrotec
        '
        Me.rbtEletrotec.AutoSize = True
        Me.rbtEletrotec.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtEletrotec.Location = New System.Drawing.Point(103, 96)
        Me.rbtEletrotec.Name = "rbtEletrotec"
        Me.rbtEletrotec.Size = New System.Drawing.Size(104, 20)
        Me.rbtEletrotec.TabIndex = 6
        Me.rbtEletrotec.Text = "Eletrotécnica"
        Me.rbtEletrotec.UseVisualStyleBackColor = True
        '
        'cbxDisciplinas
        '
        Me.cbxDisciplinas.FormattingEnabled = True
        Me.cbxDisciplinas.Location = New System.Drawing.Point(120, 173)
        Me.cbxDisciplinas.Name = "cbxDisciplinas"
        Me.cbxDisciplinas.Size = New System.Drawing.Size(121, 21)
        Me.cbxDisciplinas.TabIndex = 7
        '
        'btnMatricular
        '
        Me.btnMatricular.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMatricular.Location = New System.Drawing.Point(37, 236)
        Me.btnMatricular.Name = "btnMatricular"
        Me.btnMatricular.Size = New System.Drawing.Size(204, 39)
        Me.btnMatricular.TabIndex = 8
        Me.btnMatricular.Text = "Matricular"
        Me.btnMatricular.UseVisualStyleBackColor = True
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(277, 313)
        Me.Controls.Add(Me.btnMatricular)
        Me.Controls.Add(Me.cbxDisciplinas)
        Me.Controls.Add(Me.rbtEletrotec)
        Me.Controls.Add(Me.rbtMecanica)
        Me.Controls.Add(Me.rbtDevSist)
        Me.Controls.Add(Me.txtAluno)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "mainForm"
        Me.Text = "Escola 2.0"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtAluno As System.Windows.Forms.TextBox
    Friend WithEvents rbtDevSist As System.Windows.Forms.RadioButton
    Friend WithEvents rbtMecanica As System.Windows.Forms.RadioButton
    Friend WithEvents rbtEletrotec As System.Windows.Forms.RadioButton
    Friend WithEvents cbxDisciplinas As System.Windows.Forms.ComboBox
    Friend WithEvents btnMatricular As System.Windows.Forms.Button

End Class
