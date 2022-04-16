Public Class Form1
    Dim QR_Generator As New MessagingToolkit.QRCode.Codec.QRCodeEncoder
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

     
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        SaveFileDialog1.ShowDialog()
    End Sub

    Private Sub SaveFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        Try
            Dim img As New Bitmap(PictureBox1.Image)
            img.Save(SaveFileDialog1.FileName, Imaging.ImageFormat.Png)
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub None_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles None.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            PictureBox1.Image = QR_Generator.Encode(TextBox1.Text + " " + TextBox2.Text + " " + TextBox3.Text + " " + TextBox4.Text + " " + TextBox5.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
