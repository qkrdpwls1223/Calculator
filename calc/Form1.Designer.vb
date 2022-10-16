<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtFormula = New System.Windows.Forms.TextBox()
        Me.lblPostfix = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnDiv = New System.Windows.Forms.Button()
        Me.btnMul = New System.Windows.Forms.Button()
        Me.btnNum9 = New System.Windows.Forms.Button()
        Me.btnNum8 = New System.Windows.Forms.Button()
        Me.btnNum7 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnPlus = New System.Windows.Forms.Button()
        Me.btnNum6 = New System.Windows.Forms.Button()
        Me.btnNum5 = New System.Windows.Forms.Button()
        Me.btnNum4 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnMinus = New System.Windows.Forms.Button()
        Me.btnNum3 = New System.Windows.Forms.Button()
        Me.btnNum2 = New System.Windows.Forms.Button()
        Me.btnNum1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnResult = New System.Windows.Forms.Button()
        Me.btnNum0 = New System.Windows.Forms.Button()
        Me.btnParensOpen = New System.Windows.Forms.Button()
        Me.btnParensClose = New System.Windows.Forms.Button()
        Me.btnDot = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtFormula
        '
        Me.txtFormula.Font = New System.Drawing.Font("맑은 고딕", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtFormula.Location = New System.Drawing.Point(12, 12)
        Me.txtFormula.Name = "txtFormula"
        Me.txtFormula.ReadOnly = True
        Me.txtFormula.Size = New System.Drawing.Size(218, 34)
        Me.txtFormula.TabIndex = 0
        Me.txtFormula.TabStop = False
        Me.txtFormula.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblPostfix
        '
        Me.lblPostfix.AutoSize = True
        Me.lblPostfix.Font = New System.Drawing.Font("굴림", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblPostfix.Location = New System.Drawing.Point(254, 16)
        Me.lblPostfix.Name = "lblPostfix"
        Me.lblPostfix.Size = New System.Drawing.Size(0, 13)
        Me.lblPostfix.TabIndex = 2
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("휴먼둥근헤드라인", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnClear.Location = New System.Drawing.Point(12, 52)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(162, 50)
        Me.btnClear.TabIndex = 3
        Me.btnClear.TabStop = False
        Me.btnClear.Text = "C"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnDiv
        '
        Me.btnDiv.Font = New System.Drawing.Font("휴먼둥근헤드라인", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnDiv.Location = New System.Drawing.Point(180, 52)
        Me.btnDiv.Name = "btnDiv"
        Me.btnDiv.Size = New System.Drawing.Size(50, 50)
        Me.btnDiv.TabIndex = 4
        Me.btnDiv.TabStop = False
        Me.btnDiv.Text = "/"
        Me.btnDiv.UseVisualStyleBackColor = True
        '
        'btnMul
        '
        Me.btnMul.Font = New System.Drawing.Font("휴먼둥근헤드라인", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnMul.Location = New System.Drawing.Point(180, 108)
        Me.btnMul.Name = "btnMul"
        Me.btnMul.Size = New System.Drawing.Size(50, 50)
        Me.btnMul.TabIndex = 4
        Me.btnMul.TabStop = False
        Me.btnMul.Text = "*"
        Me.btnMul.UseVisualStyleBackColor = True
        '
        'btnNum9
        '
        Me.btnNum9.Font = New System.Drawing.Font("휴먼둥근헤드라인", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnNum9.Location = New System.Drawing.Point(124, 108)
        Me.btnNum9.Name = "btnNum9"
        Me.btnNum9.Size = New System.Drawing.Size(50, 50)
        Me.btnNum9.TabIndex = 4
        Me.btnNum9.TabStop = False
        Me.btnNum9.Text = "9"
        Me.btnNum9.UseVisualStyleBackColor = True
        '
        'btnNum8
        '
        Me.btnNum8.Font = New System.Drawing.Font("휴먼둥근헤드라인", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnNum8.Location = New System.Drawing.Point(68, 108)
        Me.btnNum8.Name = "btnNum8"
        Me.btnNum8.Size = New System.Drawing.Size(50, 50)
        Me.btnNum8.TabIndex = 4
        Me.btnNum8.TabStop = False
        Me.btnNum8.Text = "8"
        Me.btnNum8.UseVisualStyleBackColor = True
        '
        'btnNum7
        '
        Me.btnNum7.Font = New System.Drawing.Font("휴먼둥근헤드라인", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnNum7.Location = New System.Drawing.Point(12, 108)
        Me.btnNum7.Name = "btnNum7"
        Me.btnNum7.Size = New System.Drawing.Size(50, 50)
        Me.btnNum7.TabIndex = 4
        Me.btnNum7.TabStop = False
        Me.btnNum7.Text = "7"
        Me.btnNum7.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("휴먼둥근헤드라인", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(32, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 21)
        Me.Label2.TabIndex = 2
        '
        'btnPlus
        '
        Me.btnPlus.Font = New System.Drawing.Font("휴먼둥근헤드라인", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnPlus.Location = New System.Drawing.Point(180, 164)
        Me.btnPlus.Name = "btnPlus"
        Me.btnPlus.Size = New System.Drawing.Size(50, 50)
        Me.btnPlus.TabIndex = 4
        Me.btnPlus.TabStop = False
        Me.btnPlus.Text = "+"
        Me.btnPlus.UseVisualStyleBackColor = True
        '
        'btnNum6
        '
        Me.btnNum6.Font = New System.Drawing.Font("휴먼둥근헤드라인", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnNum6.Location = New System.Drawing.Point(124, 164)
        Me.btnNum6.Name = "btnNum6"
        Me.btnNum6.Size = New System.Drawing.Size(50, 50)
        Me.btnNum6.TabIndex = 4
        Me.btnNum6.TabStop = False
        Me.btnNum6.Text = "6"
        Me.btnNum6.UseVisualStyleBackColor = True
        '
        'btnNum5
        '
        Me.btnNum5.Font = New System.Drawing.Font("휴먼둥근헤드라인", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnNum5.Location = New System.Drawing.Point(68, 164)
        Me.btnNum5.Name = "btnNum5"
        Me.btnNum5.Size = New System.Drawing.Size(50, 50)
        Me.btnNum5.TabIndex = 4
        Me.btnNum5.TabStop = False
        Me.btnNum5.Text = "5"
        Me.btnNum5.UseVisualStyleBackColor = True
        '
        'btnNum4
        '
        Me.btnNum4.Font = New System.Drawing.Font("휴먼둥근헤드라인", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnNum4.Location = New System.Drawing.Point(12, 164)
        Me.btnNum4.Name = "btnNum4"
        Me.btnNum4.Size = New System.Drawing.Size(50, 50)
        Me.btnNum4.TabIndex = 4
        Me.btnNum4.TabStop = False
        Me.btnNum4.Text = "4"
        Me.btnNum4.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("휴먼둥근헤드라인", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(32, 208)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 21)
        Me.Label3.TabIndex = 2
        '
        'btnMinus
        '
        Me.btnMinus.Font = New System.Drawing.Font("휴먼둥근헤드라인", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnMinus.Location = New System.Drawing.Point(180, 220)
        Me.btnMinus.Name = "btnMinus"
        Me.btnMinus.Size = New System.Drawing.Size(50, 50)
        Me.btnMinus.TabIndex = 4
        Me.btnMinus.TabStop = False
        Me.btnMinus.Text = "-"
        Me.btnMinus.UseVisualStyleBackColor = True
        '
        'btnNum3
        '
        Me.btnNum3.Font = New System.Drawing.Font("휴먼둥근헤드라인", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnNum3.Location = New System.Drawing.Point(124, 220)
        Me.btnNum3.Name = "btnNum3"
        Me.btnNum3.Size = New System.Drawing.Size(50, 50)
        Me.btnNum3.TabIndex = 4
        Me.btnNum3.TabStop = False
        Me.btnNum3.Text = "3"
        Me.btnNum3.UseVisualStyleBackColor = True
        '
        'btnNum2
        '
        Me.btnNum2.Font = New System.Drawing.Font("휴먼둥근헤드라인", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnNum2.Location = New System.Drawing.Point(68, 220)
        Me.btnNum2.Name = "btnNum2"
        Me.btnNum2.Size = New System.Drawing.Size(50, 50)
        Me.btnNum2.TabIndex = 4
        Me.btnNum2.TabStop = False
        Me.btnNum2.Text = "2"
        Me.btnNum2.UseVisualStyleBackColor = True
        '
        'btnNum1
        '
        Me.btnNum1.Font = New System.Drawing.Font("휴먼둥근헤드라인", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnNum1.Location = New System.Drawing.Point(12, 220)
        Me.btnNum1.Name = "btnNum1"
        Me.btnNum1.Size = New System.Drawing.Size(50, 50)
        Me.btnNum1.TabIndex = 4
        Me.btnNum1.TabStop = False
        Me.btnNum1.Text = "1"
        Me.btnNum1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("휴먼둥근헤드라인", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(32, 237)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 21)
        Me.Label4.TabIndex = 2
        '
        'btnResult
        '
        Me.btnResult.Font = New System.Drawing.Font("휴먼둥근헤드라인", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnResult.Location = New System.Drawing.Point(120, 276)
        Me.btnResult.Name = "btnResult"
        Me.btnResult.Size = New System.Drawing.Size(110, 50)
        Me.btnResult.TabIndex = 4
        Me.btnResult.TabStop = False
        Me.btnResult.Text = "="
        Me.btnResult.UseVisualStyleBackColor = True
        '
        'btnNum0
        '
        Me.btnNum0.Font = New System.Drawing.Font("휴먼둥근헤드라인", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnNum0.Location = New System.Drawing.Point(12, 276)
        Me.btnNum0.Name = "btnNum0"
        Me.btnNum0.Size = New System.Drawing.Size(102, 50)
        Me.btnNum0.TabIndex = 4
        Me.btnNum0.TabStop = False
        Me.btnNum0.Text = "0"
        Me.btnNum0.UseVisualStyleBackColor = True
        '
        'btnParensOpen
        '
        Me.btnParensOpen.Font = New System.Drawing.Font("휴먼둥근헤드라인", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnParensOpen.Location = New System.Drawing.Point(236, 52)
        Me.btnParensOpen.Name = "btnParensOpen"
        Me.btnParensOpen.Size = New System.Drawing.Size(50, 50)
        Me.btnParensOpen.TabIndex = 4
        Me.btnParensOpen.TabStop = False
        Me.btnParensOpen.Text = "("
        Me.btnParensOpen.UseVisualStyleBackColor = True
        '
        'btnParensClose
        '
        Me.btnParensClose.Font = New System.Drawing.Font("휴먼둥근헤드라인", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnParensClose.Location = New System.Drawing.Point(236, 108)
        Me.btnParensClose.Name = "btnParensClose"
        Me.btnParensClose.Size = New System.Drawing.Size(50, 50)
        Me.btnParensClose.TabIndex = 4
        Me.btnParensClose.TabStop = False
        Me.btnParensClose.Text = ")"
        Me.btnParensClose.UseVisualStyleBackColor = True
        '
        'btnDot
        '
        Me.btnDot.Font = New System.Drawing.Font("휴먼둥근헤드라인", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnDot.Location = New System.Drawing.Point(236, 164)
        Me.btnDot.Name = "btnDot"
        Me.btnDot.Size = New System.Drawing.Size(50, 50)
        Me.btnDot.TabIndex = 4
        Me.btnDot.TabStop = False
        Me.btnDot.Text = "."
        Me.btnDot.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(478, 340)
        Me.Controls.Add(Me.btnNum0)
        Me.Controls.Add(Me.btnNum1)
        Me.Controls.Add(Me.btnNum4)
        Me.Controls.Add(Me.btnNum2)
        Me.Controls.Add(Me.btnNum5)
        Me.Controls.Add(Me.btnNum7)
        Me.Controls.Add(Me.btnResult)
        Me.Controls.Add(Me.btnNum3)
        Me.Controls.Add(Me.btnNum6)
        Me.Controls.Add(Me.btnMinus)
        Me.Controls.Add(Me.btnNum8)
        Me.Controls.Add(Me.btnPlus)
        Me.Controls.Add(Me.btnNum9)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnMul)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnDot)
        Me.Controls.Add(Me.btnParensClose)
        Me.Controls.Add(Me.btnParensOpen)
        Me.Controls.Add(Me.btnDiv)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblPostfix)
        Me.Controls.Add(Me.txtFormula)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtFormula As TextBox
    Friend WithEvents lblPostfix As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnDiv As Button
    Friend WithEvents btnMul As Button
    Friend WithEvents btnNum9 As Button
    Friend WithEvents btnNum8 As Button
    Friend WithEvents btnNum7 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnPlus As Button
    Friend WithEvents btnNum6 As Button
    Friend WithEvents btnNum5 As Button
    Friend WithEvents btnNum4 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents btnMinus As Button
    Friend WithEvents btnNum3 As Button
    Friend WithEvents btnNum2 As Button
    Friend WithEvents btnNum1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents btnResult As Button
    Friend WithEvents btnNum0 As Button
    Friend WithEvents btnParensOpen As Button
    Friend WithEvents btnParensClose As Button
    Friend WithEvents btnDot As Button
End Class
