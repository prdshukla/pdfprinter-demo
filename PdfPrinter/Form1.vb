Imports System.Windows.Forms
Imports System.Net
Imports System.IO

Public Class Form1

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        Try
            Dim pdfFilePath As String = "http://localhost/RIMSBusinesWeb/GetDocumentPreview.aspx/DeficiencyLetter?transactionId=11205&documentId=513"
            CreateIfMissingFolder("C:\programdata\RIMS\OutputDocuments\")
            Using client As WebClient = New WebClient()
                client.DownloadFile(pdfFilePath, "C:\programdata\RIMS\OutputDocuments\Temp.pdf")
            End Using
        Catch ex As WebException
            MessageBox.Show("error")
        End Try
    End Sub

    Private Shared Sub CreateIfMissingFolder(ByVal path As String)

        Dim folderExists As Boolean = Directory.Exists(path)

        If (Not folderExists) Then
            Directory.CreateDirectory(path)
        End If

    End Sub
    
End Class