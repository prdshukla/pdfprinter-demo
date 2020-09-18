'Imports System.Diagnostics
'Imports System.Windows.Forms

'Module PdfPrinterConsole
'    Sub Main()
'        Const waitTimeout = 10000
'        ' Dim pdfFilePath = GetPdfFilePath()
'        Dim browse As New WebBrowser
'        Dim pdfFilePath = "http://localhost/RIMSBusinessWeb/GetDocumentPreview.aspx/DeficiencyLetter?transactionId=11205&documentId=513"

'        'If (pdfFilePath IsNot Nothing) Then
'        '    PrintPdfFile(pdfFilePath, waitTimeout)
'        'End If

'        AddHandler browse.DocumentCompleted, New  _
'            WebBrowserDocumentCompletedEventHandler(AddressOf PrintDocument)

'        ' Set the Url property to load the document.
'        browse.Url = New Uri(pdfFilePath)
'        ' browse.Navigate()
'    End Sub

'    Private Sub PrintDocument(ByVal sender As Object, _
'        ByVal e As WebBrowserDocumentCompletedEventArgs)

'        Dim webBrowserForPrinting As WebBrowser = CType(sender, WebBrowser)

'        ' Print the document now that it is fully loaded.
'        webBrowserForPrinting.Print()
'        MessageBox.Show("print")

'        ' Dispose the WebBrowser now that the task is complete. 
'        webBrowserForPrinting.Dispose()

'    End Sub


'    ''' <summary>
'    ''' Obtains a file path for a PDF
'    ''' </summary>
'    ''' <returns>PDF file path or null</returns>
'    ''' <remarks></remarks>
'    Private Function GetPdfFilePath() As String
'        Trace.WriteLine("Obtaining file path from open dialog")
'        Dim fd = New OpenFileDialog()
'        fd.Title = "Open File Dialog"
'        fd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
'        'fd.Filter = "Adobe PDF files (*.pdf)|*.pdf"
'        fd.RestoreDirectory = True
'        If fd.ShowDialog() = DialogResult.OK Then
'            Return fd.FileName
'        End If
'        Return Nothing
'    End Function

'    ''' <summary>
'    ''' Starts whatever process is registered for printing PDFs on and waits for a configurable amount of time for the process to return
'    ''' </summary>
'    ''' <param name="pdfFilePath">Path to PDF file</param>
'    ''' <param name="waitTimeout">Milliseconds to wait for printing process to return</param>
'    ''' <remarks></remarks>
'    Private Sub PrintPdfFile(pdfFilePath As String, waitTimeout As Integer)
'        Trace.WriteLine(String.Format("Starting process to print file ""{0}""", pdfFilePath))
'        Dim printProcessStartInfo As New ProcessStartInfo() With {.Verb = "print", .WindowStyle = ProcessWindowStyle.Hidden, .FileName = pdfFilePath, .UseShellExecute = True}
'        Dim printProcess = Process.Start(printProcessStartInfo)
'        'Process may return immediately depending on whether process was already open, etc., but this ensures that we won't wait forever for it to return
'        'Note that we don't know if document was actually printed
'        printProcess.WaitForExit(waitTimeout)
'    End Sub
'End Module
