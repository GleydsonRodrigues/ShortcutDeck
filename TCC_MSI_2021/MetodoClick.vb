Public Class MetodoClick
    Dim dados As New CaminhosSalvos
    Public Sub clickMetodo(valor As Integer)

        If valor = 1 Then
            If dados.caminho1 <> "" Then
                abrirApp(dados.caminho1)
            End If
        ElseIf valor = 2 Then
            If dados.caminho2 <> "" Then
                abrirApp(dados.caminho2)
            End If
        ElseIf valor = 3 Then
            If dados.caminho3 <> "" Then
                abrirApp(dados.caminho3)
            End If
        ElseIf valor = 4 Then

            If dados.caminho4 <> "" Then
                abrirApp(dados.caminho4)
            End If
        ElseIf valor = 5 Then

            If dados.caminho5 <> "" Then
                abrirApp(dados.caminho5)
            End If
        ElseIf valor = 6 Then

            If dados.caminho6 <> "" Then
                abrirApp(dados.caminho6)
            End If
        End If
    End Sub
    Public Sub abrirApp(caminhoApp)
        Shell("cmd.exe /c call """ & caminhoApp & """")
    End Sub
End Class
