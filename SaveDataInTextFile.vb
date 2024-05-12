Imports System.IO

Public Class SaveDataInTextFile
    Public Sub SaveDataTableToTxt(filePath As String, dataTable As DataTable)
        ' Use a StringBuilder to build the CSV content
        Dim csvData As New System.Text.StringBuilder()

        ' Add headers from the DataTable columns
        For i As Integer = 0 To dataTable.Columns.Count - 1
            csvData.Append(dataTable.Columns(i).ColumnName)
            If i < dataTable.Columns.Count - 1 Then
                csvData.Append(",")
            End If
        Next
        csvData.AppendLine()

        ' Add rows from the DataTable
        For Each row As DataRow In dataTable.Rows
            For i As Integer = 0 To dataTable.Columns.Count - 1
                Dim cellValue As String = row(i).ToString()
                ' Escape any commas within cell values by using quotes
                If cellValue.Contains(",") Then
                    cellValue = $"""{cellValue}"""
                End If
                csvData.Append(cellValue)
                If i < dataTable.Columns.Count - 1 Then
                    csvData.Append(",")
                End If
            Next
            csvData.AppendLine()
        Next

        ' Save the CSV content to the file
        System.IO.File.WriteAllText(filePath, csvData.ToString())
    End Sub

    Public Sub LoadDataTableFromTxt(filePath As String, dataTable As DataTable)
        ' Check if the file exists
        If Not System.IO.File.Exists(filePath) Then
            MessageBox.Show("File not found.")
            Return
        End If

        ' Clear the existing data from the DataTable
        dataTable.Clear()

        ' Read the CSV file line by line
        Dim lines As String() = System.IO.File.ReadAllLines(filePath)

        ' Process the data rows
        For i As Integer = 1 To lines.Length - 1
            Dim line As String = lines(i)
            Dim values As String() = line.Split(","c)

            ' Check if the number of values matches the number of columns in the DataTable
            If values.Length <> dataTable.Columns.Count Then
                ' Log a warning or skip the row if the length does not match
                MessageBox.Show($"Row {i} has a length of {values.Length} which does not match the number of columns in the DataTable ({dataTable.Columns.Count}). Skipping row.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Continue For
            End If

            ' Add a new row and populate it with the values
            Dim newRow As DataRow = dataTable.NewRow()
            newRow.ItemArray = values
            dataTable.Rows.Add(newRow)
        Next
    End Sub

    ' Function to check whether a file has any values or data while ignoring the first line
    Public Function FileHasDataIgnoreFirstLine(filePath As String) As Boolean
        ' Check if the file exists
        If Not File.Exists(filePath) Then
            ' File does not exist, return False
            Return False
        End If

        ' Initialize a counter to track the number of lines read
        Dim lineCounter As Integer = 0

        ' Read the file line by line
        For Each line As String In File.ReadLines(filePath)
            ' Increment the line counter
            lineCounter += 1

            ' Ignore the first line (header) and continue to the next line
            If lineCounter = 1 Then
                Continue For
            End If

            ' Trim the line to remove leading/trailing whitespace
            Dim trimmedLine As String = line.Trim()

            ' Check if the line is non-empty
            If Not String.IsNullOrEmpty(trimmedLine) Then
                ' If a non-empty line is found after ignoring the first line, return True
                Return True
            End If
        Next

        ' If no non-empty lines are found after ignoring the first line, return False
        Return False
    End Function

    ' Function to get the row count from a text file while ignoring the first line (header row)
    Public Function GetRowCountIgnoringFirstLine(filePath As String) As Integer
        ' Check if the file exists
        If Not File.Exists(filePath) Then
            ' File does not exist, return 0
            Return 0
        End If

        ' Initialize a counter to track the row count
        Dim rowCount As Integer = 0
        ' Initialize a flag to check if the first line has been skipped
        Dim isFirstLine As Boolean = True

        ' Read the file line by line
        For Each line As String In File.ReadLines(filePath)
            ' Check if this is the first line
            If isFirstLine Then
                ' Skip the first line
                isFirstLine = False
                Continue For
            End If

            ' Increment the row count for each line after the first line
            rowCount += 1
        Next

        ' Return the row count excluding the first line
        Return rowCount
    End Function


End Class