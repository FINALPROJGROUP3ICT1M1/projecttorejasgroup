Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        pnlfood.Visible = True
        pnldrink.Visible = False
        pnldesert.Visible = False
        pnlcart.Visible = False
        pnlabout.Visible = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        pnlfood.Visible = False
        pnldrink.Visible = True
        pnldesert.Visible = False
        pnlcart.Visible = False
        pnlabout.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        pnlfood.Visible = False
        pnldrink.Visible = False
        pnldesert.Visible = True
        pnlcart.Visible = False
        pnlabout.Visible = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        pnlfood.Visible = False
        pnldrink.Visible = False
        pnldesert.Visible = False
        pnlcart.Visible = True
        pnlabout.Visible = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        pnlfood.Visible = False
        pnldrink.Visible = False
        pnldesert.Visible = False
        pnlcart.Visible = False
        pnlabout.Visible = True

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Button6.Hide()

        While pnlleft.Width < 257
            pnlleft.Width += 1
        End While
        Button7.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Button7.Hide()
        While (pnlleft.Width > 78)
            pnlleft.Width -= 1
        End While
        Button6.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click


        lblfdorder1.Text = lblfood1.Text & " Ordered"
        lblfprice1.Text = lblfoodprice1.Text


    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        lblfdorder2.Text = lblfood2.Text & " Ordered"
        lblfprice2.Text = lblfoodprice2.Text

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        lblfdorder3.Text = lblfood3.Text & " Ordered"
        lblfprice3.Text = lblfoodprice3.Text

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub

    Private Sub lbldrinks1_Click(sender As Object, e As EventArgs) Handles lbldrinks1.Click

    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        lbldorder1.Text = lbldrinks1.Text & " Ordered"
        lbldprice1.Text = lbldrinksprice1.Text
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        lbldorder2.Text = lbldrinks2.Text & " Ordered"
        lbldprice2.Text = lbldrinksprice2.Text
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        lbldorder3.Text = lbldrinks3.Text & " Ordered"
        lbldprice3.Text = lbldrinksprice3.Text
    End Sub

    Private Sub PictureBox17_Click(sender As Object, e As EventArgs) Handles PictureBox17.Click
        lbltorder1.Text = lbldesert1.Text & " Ordered"
        lbltprice1.Text = lbldeserprice1.Text
    End Sub

    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles PictureBox15.Click
        lbltorder2.Text = lbldesert2.Text & " Ordered"
        lbltprice2.Text = lbldeserprice2.Text
    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        lbltorder3.Text = lbldesert3.Text & " Ordered"
        lbltprice3.Text = lbldeserprice3.Text
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        lblfdorder1.Text = " "
        lblfprice1.Text = " "
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        lblfdorder2.Text = " "
        lblfprice2.Text = " "
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        lblfdorder3.Text = " "
        lblfprice3.Text = " "
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        lbldorder1.Text = " "
        lbldprice1.Text = " "
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        lbldorder2.Text = " "
        lbldprice2.Text = " "
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        lbldorder3.Text = " "
        lbldprice3.Text = " "
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        lbltorder1.Text = " "
        lbltprice1.Text = " "

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        lbltorder2.Text = " "
        lbltprice2.Text = " "
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        lbltorder3.Text = " "
        lbltprice3.Text = " "
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Dim num1 As Double = Val(lblfprice1.Text)
        Dim num2 As Double = Val(lblfprice2.Text)
        Dim num3 As Double = Val(lblfprice3.Text)
        Dim num4 As Double = Val(lbldprice1.Text)
        Dim num5 As Double = Val(lbldprice2.Text)
        Dim num6 As Double = Val(lbldprice3.Text)
        Dim num7 As Double = Val(lbltprice1.Text)
        Dim num8 As Double = Val(lbltprice2.Text)
        Dim num9 As Double = Val(lbltprice3.Text)
        lbltoshowanswer.Text = num1 + num2 + num3 + num4 + num5 + num6 + num7 + num8 + num9 & "$"
    End Sub

    Private Sub pnldrink_Paint(sender As Object, e As PaintEventArgs) Handles pnldrink.Paint

    End Sub
End Class
