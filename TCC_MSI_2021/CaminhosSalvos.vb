Public Class CaminhosSalvos
    Dim telaSalvar As Integer
    Public Sub CaminhosSalvos()
        caminho1 = My.Settings.Caminho1
        caminho2 = My.Settings.Caminho2
        caminho3 = My.Settings.Caminho3
        caminho4 = My.Settings.Caminho4
        caminho5 = My.Settings.Caminho5
        caminho6 = My.Settings.Caminho6

        label1 = My.Settings.Label1
        label2 = My.Settings.Label2
        label3 = My.Settings.Label3
        label4 = My.Settings.Label4
        label5 = My.Settings.Label5
        label6 = My.Settings.Label6

        Tela1 = My.Settings.Tela1
        Tela2 = My.Settings.Tela2
        Tela3 = My.Settings.Tela3
        Tela4 = My.Settings.Tela4
        Tela5 = My.Settings.Tela5
        Tela6 = My.Settings.Tela6

    End Sub
    Public Property TelaAtual
        Get
            Return telaSalvar
        End Get
        Set(value)
            telaSalvar = value
        End Set
    End Property
    Public Property caminho1
        Get
            Return My.Settings.Caminho1
        End Get
        Set(value)
            My.Settings.Caminho1 = value
            My.Settings.Save()
        End Set

    End Property
    Public Property caminho2
        Get
            Return My.Settings.Caminho2
        End Get
        Set(value)
            My.Settings.Caminho2 = value
            My.Settings.Save()
        End Set
    End Property
    Public Property caminho3
        Get
            Return My.Settings.Caminho3
        End Get
        Set(value)
            My.Settings.Caminho3 = value
            My.Settings.Save()
        End Set
    End Property
    Public Property caminho4
        Get
            Return My.Settings.Caminho4
        End Get
        Set(value)
            My.Settings.Caminho4 = value
            My.Settings.Save()
        End Set
    End Property
    Public Property caminho5
        Get
            Return My.Settings.Caminho5
        End Get
        Set(value)
            My.Settings.Caminho5 = value
            My.Settings.Save()
        End Set
    End Property
    Public Property caminho6
        Get
            Return My.Settings.Caminho1
        End Get
        Set(value)
            My.Settings.Caminho6 = value
            My.Settings.Save()
        End Set
    End Property

    Public Property label1
        Get
            Return My.Settings.Label1
        End Get
        Set(value)
            My.Settings.Label1 = value
            My.Settings.Save()
        End Set
    End Property

    Public Property label2
        Get
            Return My.Settings.Label2
        End Get
        Set(value)
            My.Settings.Label2 = value
            My.Settings.Save()
        End Set
    End Property

    Public Property label3
        Get
            Return My.Settings.Label3
        End Get
        Set(value)
            My.Settings.Label3 = value
            My.Settings.Save()
        End Set
    End Property

    Public Property label4
        Get
            Return My.Settings.Label4
        End Get
        Set(value)
            My.Settings.Label4 = value
            My.Settings.Save()
        End Set
    End Property

    Public Property label5
        Get
            Return My.Settings.Label5
        End Get
        Set(value)
            My.Settings.Label5 = value
            My.Settings.Save()
        End Set
    End Property

    Public Property label6
        Get
            Return My.Settings.Label6
        End Get
        Set(value)
            My.Settings.Label6 = value
            My.Settings.Save()
        End Set
    End Property

    Public Property Tela1
        Get
            Return My.Settings.Tela1
        End Get
        Set(value)
            My.Settings.Tela1 = value
            My.Settings.Save()
        End Set
    End Property

    Public Property Tela2
        Get
            Return My.Settings.Tela2
        End Get
        Set(value)
            My.Settings.Tela2 = value
            My.Settings.Save()
        End Set
    End Property

    Public Property Tela3
        Get
            Return My.Settings.Tela3
        End Get
        Set(value)
            My.Settings.Tela3 = value
            My.Settings.Save()
        End Set
    End Property

    Public Property Tela4
        Get
            Return My.Settings.Tela4
        End Get
        Set(value)
            My.Settings.Tela4 = value
            My.Settings.Save()
        End Set
    End Property

    Public Property Tela5
        Get
            Return My.Settings.Tela5
        End Get
        Set(value)
            My.Settings.Tela5 = value
            My.Settings.Save()
        End Set
    End Property

    Public Property Tela6
        Get
            Return My.Settings.Tela6
        End Get
        Set(value)
            My.Settings.Tela6 = value
            My.Settings.Save()
        End Set
    End Property

End Class
