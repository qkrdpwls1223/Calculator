Public Class Form1
    Dim ParensCnt As Integer = 0        ' 괄호 개수
    Function txtInput(c As String)
        If c = "+" Or c = "-" Or c = "*" Or c = "/" Then
            ' 연산자 입력 시
            If txtFormula.Text = "" Then
                ' 숫자가 아무것도 없다면 0을 추가 해준 후 연산자를 추가 한다
                txtFormula.Text &= "0" & c
            ElseIf txtFormula.Text.Last = "(" Then
                ' 위에랑 똑같음
                txtFormula.Text &= "0" & c
            ElseIf txtFormula.Text.Last() = "+" Or txtFormula.Text.Last() = "-" Or
            txtFormula.Text.Last() = "*" Or txtFormula.Text.Last() = "/" Then
                ' 끝에 있는게 연산자 일경우 새로이 입력한 연산자로 변경 한다
                txtFormula.Text = txtFormula.Text.Remove(txtFormula.TextLength - 1) & c
            Else
                txtFormula.Text &= c
            End If

        ElseIf c = "(" Then
            ' 여는 소괄호일 때
            If txtFormula.TextLength > 0 Then
                If txtFormula.Text.Last = "(" Then
                    ' 앞에 여는 괄호가 있는데 또 괄호 입력시 1* 추가
                    txtFormula.Text &= "1*"
                ElseIf txtFormula.Text.Last = "." Then
                    txtFormula.Text = txtFormula.Text.Remove(txtFormula.TextLength - 1) & "*"
                ElseIf txtFormula.Text.Last >= "0" And txtFormula.Text.Last <= "9" Then
                    ' 앞에 숫자 있을 때
                    txtFormula.Text &= "*"
                End If
            End If

            txtFormula.Text &= "("
            ParensCnt += 1

        ElseIf c = ")" Then
            ' 닫는 소괄호일 때
            If ParensCnt > 0 Then
                ' 앞서 열어 놓은 괄호의 개수가 1개 이상일 때
                If txtFormula.Text.Last = "(" Then
                    ' 열자마자 닫으면 0 추가 후 괄호닫음
                    txtFormula.Text &= "0"
                ElseIf txtFormula.Text.Last = "+" Or txtFormula.Text.Last = "-" Or txtFormula.Text.Last = "*" Or txtFormula.Text.Last = "/" Or txtFormula.Text.Last = "." Then
                    ' 연산자가 있는데 괄호를 닫으려고 할때 연산자를 지우고 괄호를 닫음
                    txtFormula.Text = txtFormula.Text.Remove(txtFormula.TextLength - 1)
                End If
                ' 괄호닫고 괄호 카운트 -1
                txtFormula.Text &= ")"
                ParensCnt -= 1
            End If
        ElseIf c = "." Then
            If txtFormula.TextLength > 0 Then
                If txtFormula.Text.Last >= "0" And txtFormula.Text.Last <= "9" Then
                    txtFormula.Text &= c
                End If
            End If
        Else
            ' 숫자일 때
            If txtFormula.TextLength > 0 Then
                If txtFormula.Text.Last = ")" Then
                    ' )으로 끝났다면 곱하기 추가 후 숫자 입력
                    txtFormula.Text &= "*" & c
                Else
                    txtFormula.Text &= c
                End If
            Else
                txtFormula.Text &= c
            End If
        End If

        Return 0
    End Function
    Shared Function ArrayJoin(a As ArrayList, b As ArrayList)
        'ArrayList끼리 더하기
        For i = 0 To b.Count - 1
            a.Add(b(i))
        Next
        Return a
    End Function
    Shared Function Postfix(charArray As ArrayList)
        Dim Calc As New ArrayList()         ' 표현식 저장 배열
        Dim Oper As New Stack()             ' 연산자 저상 스택

        Dim Parens As New ArrayList()       ' 괄호안 표현식 저장 배열
        Dim ParensStart As Boolean = False
        Dim ParensCnt As Integer = 0

        Dim tmp As String = ""

        For i = 0 To charArray.Count - 1
            If ParensStart = True Then
                '괄호 안에 있는 수식 저장
                If charArray(i) = ")" Then
                    If ParensCnt > 1 Then
                        ' "(" 개수 만큼 ")" 저장
                        ParensCnt -= 1
                        Parens.Add(charArray(i))
                    Else
                        '괄호 안에 있는 식 후위 표기식으로 바꾼 후 calc에 더함
                        ParensStart = False
                        Calc = ArrayJoin(Calc, Postfix(Parens))
                        Parens.Clear()
                        ParensCnt = 0
                    End If
                Else
                    If charArray(i) = "(" Then
                        ' "("개수 카운트
                        ParensCnt += 1
                    End If
                    Parens.Add(charArray(i))
                End If
            Else
                If charArray(i) = "(" Then
                    ' 괄호가 시작됐을 때
                    ParensStart = True
                    ParensCnt += 1
                ElseIf charArray(i) = "+" Or charArray(i) = "-" Or charArray(i) = "*" Or charArray(i) = "/" Then
                    ' 연산자가 나오면 저장했던 숫자를 배열에 추가
                    If tmp <> "" Then
                        Calc.Add(CDbl(tmp))
                        tmp = ""
                    End If

                    If Oper.Count > 0 Then
                        ' 더하기와 빼기가 나오면 스택에 저장했던 연산자들을 배열에 추가
                        If charArray(i) = "+" Or charArray(i) = "-" Then
                            While Oper.Count > 0
                                Calc.Add(Oper.Pop())
                            End While
                        End If
                    End If
                    ' 저장되어있는 연산자가 없다면 스택에 연산자 추가
                    Oper.Push(charArray(i))
                Else
                    ' 십의 자리수 이상인 숫자를 저장하기 위해서 변수에 한자리씩 저장했다가 추가함
                    tmp &= charArray(i)
                End If
            End If
        Next
        ' for문으로는 배열에 다 들어가지 않기 때문에 남은것 저장
        If tmp <> "" Then
            Calc.Add(CDbl(tmp))
        End If
        While Oper.Count > 0
            calc.Add(Oper.Pop())
        End While

        Return calc
    End Function
    Private Sub btnResult_Click(sender As Object, e As EventArgs) Handles btnResult.Click
        'String To ArrayList
        Dim charArray As New ArrayList()

        If txtFormula.Text.Length = 0 Then
            Exit Sub
        End If

        For i = 0 To txtFormula.Text.Length - 1
            charArray.Add(txtFormula.Text(i))
        Next
        If ParensCnt > 0 Then
            charArray.Add("0")
            While ParensCnt > 0
                charArray.Add(")")
                ParensCnt -= 1
            End While
        End If

        '마지막이 연산자(+,-,*,/)로 끝났을 경우 제거
        If txtFormula.Text.Last() = "+" Or txtFormula.Text.Last() = "-" Or
            txtFormula.Text.Last() = "*" Or txtFormula.Text.Last() = "/" Then
            charArray.RemoveAt(charArray.Count - 1)
        End If

        '후위 표기법으로 바꾸기
        Dim formula As ArrayList = Postfix(charArray)

        '바꾼 수식 라벨에 출력
        lblPostfix.Text = ""
        For i = 0 To formula.Count - 1
            lblPostfix.Text &= formula(i)
        Next

        '더하기
        Dim stack As New Stack()
        For i = 0 To formula.Count - 1
            If TypeOf formula(i) Is Integer Or TypeOf formula(i) Is Double Then
                stack.Push(formula(i))
            Else
                If formula(i) = "+" Then
                    stack.Push(stack.Pop() + stack.Pop())
                ElseIf formula(i) = "-" Then
                    Dim num As Integer = stack.Pop()
                    stack.Push(stack.Pop() - num)
                ElseIf formula(i) = "*" Then
                    stack.Push(stack.Pop() * stack.Pop())
                ElseIf formula(i) = "/" Then
                    stack.Push(stack.Pop() / stack.Pop())
                End If
            End If
        Next
        '괄호개수 초기화
        ParensCnt = 0
        '값 출력
        txtFormula.Text = Format(stack.Pop(), "#,##0.###############################")
    End Sub

    Private Sub InputBtn_Click(sender As Object, e As EventArgs) Handles btnNum0.Click, btnNum1.Click, btnNum2.Click, btnNum3.Click, btnNum4.Click, btnNum5.Click, btnNum6.Click, btnNum7.Click, btnNum8.Click, btnNum9.Click, btnDiv.Click, btnMul.Click, btnMinus.Click, btnPlus.Click, btnParensOpen.Click, btnParensClose.Click, btnDot.Click
        '버튼 클릭시 버튼.Text 값이 추가 됨
        txtInput(DirectCast(sender, Button).Text)

        txtFormula.Focus()
        txtFormula.SelectionStart = txtFormula.TextLength
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'TextBox 초기화
        txtFormula.Text = ""
        lblPostfix.Text = ""
        txtFormula.Focus()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtFormula.Focus()
    End Sub

    ' 입력 불가랬지만 키이벤트는 괜찮지 않을까......?
    Private Sub txtFormula_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFormula.KeyPress
        If (e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = "+" Or e.KeyChar <= "-" Or
            e.KeyChar = "*" Or e.KeyChar = "/" Or e.KeyChar = "(" Or e.KeyChar = ")" Or e.KeyChar = "." Then
            txtInput(e.KeyChar)
        End If
    End Sub
End Class