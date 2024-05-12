Imports System.Net.Mail
Public Class Validations
    Public Shared Function ValidateName(input As String) As Boolean
        For Each c As Char In input
            If Not Char.IsLetter(c) AndAlso Not Char.IsWhiteSpace(c) Then
                Return False
            End If
        Next
        Return True
    End Function

    Public Shared Function ValidateEmail(email As String) As Boolean
        Try
            Dim email_ad As New MailAddress(email)
            Return True
        Catch e As FormatException
            Return False
        End Try
    End Function

    Public Shared Function ValidateMobile(num As String) As Boolean
        Dim count_num As Integer = 0
        For Each c As Char In num.ToString
            If Char.IsDigit(c) Then
                count_num += 1
            End If
        Next
        If Not count_num = 10 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Shared Function ValidateEmptyTextBox(textbox As TextBox) As Boolean
        If String.IsNullOrWhiteSpace(textbox.Text) OrElse String.IsNullOrEmpty(textbox.Text) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Shared Function ValidateEmptyComboBox(comboBox As ComboBox) As Boolean
        If String.IsNullOrWhiteSpace(comboBox.Text) OrElse String.IsNullOrEmpty(comboBox.Text) Then
            Return True
        Else
            Return False
        End If
    End Function
End Class