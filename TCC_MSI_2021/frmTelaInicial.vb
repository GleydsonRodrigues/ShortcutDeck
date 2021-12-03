Imports IO.Ports.SerialPort
Public Class frmTelaInicial

    'importaçôes 
    Dim dados As New CaminhosSalvos
    Dim newpoint As New System.Drawing.Point
    Dim clickBotao As New MetodoClick
    Dim mouseX, mouseY As Integer
    Dim imagem As String
    Dim leitura As String
    Dim comport = ""

    Private Sub Header_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles panelTopo.MouseDown
        mouseX = Control.MousePosition.X - Me.Location.X
        mouseY = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub btnPesquisa_Click(sender As Object, e As EventArgs) Handles btnPesquisa.Click
        OpenFileDialog1.ShowDialog()
        Dim caminho As String = OpenFileDialog1.FileName
        If caminho <> "" Then
            txtCaminho.Text = caminho
        End If

    End Sub

    Private Sub btnTela1_Click_1(sender As Object, e As EventArgs) Handles btnTela1.Click
        clickBotao.clickMetodo(1)
    End Sub
    Private Sub btnTela2_Click(sender As Object, e As EventArgs) Handles btnTela2.Click

        clickBotao.clickMetodo(2)
    End Sub

    Private Sub btnTela3_Click(sender As Object, e As EventArgs) Handles btnTela3.Click
        clickBotao.clickMetodo(3)
    End Sub

    Private Sub btnTela4_Click(sender As Object, e As EventArgs) Handles btnTela4.Click
        clickBotao.clickMetodo(4)
    End Sub

    Private Sub btnTela5_Click(sender As Object, e As EventArgs) Handles btnTela5.Click
        clickBotao.clickMetodo(5)
    End Sub

    Private Sub btnTela6_Click(sender As Object, e As EventArgs) Handles btnTela6.Click
        clickBotao.clickMetodo(6)
    End Sub


    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles imgMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub imgFechar_Click(sender As Object, e As EventArgs) Handles imgFechar.Click
        SplashScreen.Close()
        Me.Close()
    End Sub

    Private Sub Header_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles panelTopo.MouseMove
        If e.Button = MouseButtons.Left Then
            newpoint = Control.MousePosition
            newpoint.X -= mouseX
            newpoint.Y -= mouseY
            Me.Location = newpoint
        End If
    End Sub

    Public Sub copiarImagem(copiar, colar)
        If System.IO.File.Exists(copiar) = True Then

            FileSystem.FileCopy(copiar, colar)
        Else
            MsgBox("falha ao concluir a ação")
        End If
    End Sub

    Private Sub rdbTela1_CheckedChanged_1(sender As Object, e As EventArgs) Handles rdbTela1.CheckedChanged
        If dados.Tela1 <> "" Then
            ImgTroca.Image = Image.FromFile(dados.Tela1)
        Else
            ImgTroca.Image = Nothing
        End If
        txtNome.Text = dados.label1
        txtCaminho.Text = dados.caminho1
        imagem = dados.Tela1
        dados.TelaAtual = 1
    End Sub

    Private Sub rdbTela2_CheckedChanged(sender As Object, e As EventArgs) Handles rdbTela2.CheckedChanged
        If dados.Tela2 <> "" Then
            ImgTroca.Image = Image.FromFile(dados.Tela2)
        Else
            ImgTroca.Image = Nothing
        End If
        txtNome.Text = dados.label2
        txtCaminho.Text = dados.caminho2
        imagem = dados.Tela2
        dados.TelaAtual = 2
    End Sub

    Private Sub rdbTela3_CheckedChanged(sender As Object, e As EventArgs) Handles rdbTela3.CheckedChanged
        If dados.Tela3 <> "" Then
            ImgTroca.Image = Image.FromFile(dados.Tela3)
        Else
            ImgTroca.Image = Nothing
        End If
        txtNome.Text = dados.label3
        txtCaminho.Text = dados.caminho3
        imagem = dados.Tela3
        dados.TelaAtual = 3
    End Sub

    Private Sub rdbTela4_CheckedChanged(sender As Object, e As EventArgs) Handles rdbTela4.CheckedChanged
        If dados.Tela4 <> "" Then
            ImgTroca.Image = Image.FromFile(dados.Tela4)
        Else
            ImgTroca.Image = Nothing
        End If
        txtNome.Text = dados.label4
        txtCaminho.Text = dados.caminho4
        imagem = dados.Tela4
        dados.TelaAtual = 4
    End Sub

    Private Sub rdbTela5_CheckedChanged(sender As Object, e As EventArgs) Handles rdbTela5.CheckedChanged
        If dados.Tela5 <> "" Then
            ImgTroca.Image = Image.FromFile(dados.Tela5)
        Else
            ImgTroca.Image = Nothing
        End If
        txtNome.Text = dados.label5
        txtCaminho.Text = dados.caminho5
        imagem = dados.Tela5
        dados.TelaAtual = 5
    End Sub

    Private Sub rdbTela6_CheckedChanged(sender As Object, e As EventArgs) Handles rdbTela6.CheckedChanged
        If dados.Tela6 <> "" Then
            ImgTroca.Image = Image.FromFile(dados.Tela6)
        Else
            ImgTroca.Image = Nothing
        End If
        txtNome.Text = dados.label6
        txtCaminho.Text = dados.caminho6
        imagem = dados.Tela6
        dados.TelaAtual = 6
    End Sub

    Private Sub frmTelaInicial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dados.CaminhosSalvos()
        carregarComponentes()
        For Each sp As String In My.Computer.Ports.SerialPortNames
            ComboBox1.Items.Add(sp)
        Next

    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        telaSalvar()
    End Sub

    Private Sub ImgTroca_Click(sender As Object, e As EventArgs) Handles ImgTroca.Click

        Dim ImagemCopiada As String
        OpenFileDialog2.ShowDialog()
        ImagemCopiada = OpenFileDialog2.FileName

        imagem = ImagemCopiada
        If imagem <> "" Then
            ImgTroca.Image = Image.FromFile(imagem)
        End If

    End Sub
    Private Sub carregarComponentes()
        If (Not String.IsNullOrEmpty(dados.Tela1)) Then
            btnTela1.Image = Image.FromFile(dados.Tela1)
        End If
        If (Not String.IsNullOrEmpty(dados.Tela2)) Then
            btnTela2.Image = Image.FromFile(dados.Tela2)
        End If
        If (Not String.IsNullOrEmpty(dados.Tela3)) Then
            btnTela3.Image = Image.FromFile(dados.Tela3)
        End If
        If (Not String.IsNullOrEmpty(dados.Tela4)) Then
            btnTela4.Image = Image.FromFile(dados.Tela4)
        End If
        If (Not String.IsNullOrEmpty(dados.Tela5)) Then
            btnTela5.Image = Image.FromFile(dados.Tela5)
        End If
        If (Not String.IsNullOrEmpty(dados.Tela6)) Then
            btnTela6.Image = Image.FromFile(dados.Tela6)
        End If

        lblTela1.Text = dados.label1
        lblTela2.Text = dados.label2
        lblTela3.Text = dados.label3
        lblTela4.Text = dados.label4
        lblTela5.Text = dados.label5
        lblTela6.Text = dados.label6
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        'If SerialPort1.Then Then
        If SerialPort1.IsOpen = True Then
            leitura = SerialPort1.ReadExisting
            If leitura = "1" + vbCrLf Then
                clickBotao.clickMetodo(1)
            ElseIf leitura = "2" + vbCrLf Then
                clickBotao.clickMetodo(2)
            ElseIf leitura = "3" + vbCrLf Then
                clickBotao.clickMetodo(3)
            ElseIf leitura = "4" + vbCrLf Then
                clickBotao.clickMetodo(4)
            ElseIf leitura = "5" + vbCrLf Then
                clickBotao.clickMetodo(5)
            ElseIf leitura = "6" + vbCrLf Then
                clickBotao.clickMetodo(6)
            End If
        Else
            Timer1.Stop()
            MsgBox("Porta Fechada, escolha outra porta")
            btnConectar.Text = "Conectar"
        End If



    End Sub

    Private Sub btnConectar_Click(sender As Object, e As EventArgs) Handles btnConectar.Click
        comport = ComboBox1.SelectedItem

        If SerialPort1.IsOpen = False Then
            If comport = "" Then
                MsgBox("Selecione alguma COMx")
            Else
                btnConectar.Text = "Desconectar"
                SerialPort1.Close()
                SerialPort1.PortName = comport
                SerialPort1.BaudRate = 9600
                SerialPort1.DataBits = 8
                SerialPort1.Encoding = System.Text.Encoding.Default
                SerialPort1.Open()
                Timer1.Start()
            End If

        Else
            Timer1.Stop()
            btnConectar.Text = "Conectar"
            SerialPort1.Close()
        End If

    End Sub

    Private Sub telaSalvar()
        If dados.TelaAtual = 1 Then
            dados.Tela1 = imagem
            dados.caminho1 = txtCaminho.Text
            dados.label1 = txtNome.Text
            Refresh()
        ElseIf dados.TelaAtual = 2 Then
            dados.Tela2 = imagem
            dados.caminho2 = txtCaminho.Text
            dados.label2 = txtNome.Text
            Refresh()
        ElseIf dados.TelaAtual = 3 Then
            dados.Tela3 = imagem
            dados.caminho3 = txtCaminho.Text
            dados.label3 = txtNome.Text
            Refresh()
        ElseIf dados.TelaAtual = 4 Then
            dados.Tela4 = imagem
            dados.caminho4 = txtCaminho.Text
            dados.label4 = txtNome.Text
            Refresh()
        ElseIf dados.TelaAtual = 5 Then
            dados.Tela5 = imagem
            dados.caminho5 = txtCaminho.Text
            dados.label5 = txtNome.Text
            Refresh()
        ElseIf dados.TelaAtual = 6 Then
            dados.Tela6 = imagem
            dados.caminho6 = txtCaminho.Text
            dados.label6 = txtNome.Text
            Refresh()
        End If
        carregarComponentes()
    End Sub

End Class
