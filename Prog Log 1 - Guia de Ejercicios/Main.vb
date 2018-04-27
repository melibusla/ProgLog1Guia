Public Class Main
    
    'Codigo de Primer tab, programa clasificar numeros
    Private Sub btnClasificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClasificar.Click
        If txtNum.Text < 0 Then
            lblResultado.Text = "Negativo"
        Else
            If txtNum.Text > 0 Then
                lblResultado.Text = "Positivo"
            Else
                lblResultado.Text = "Cero"
            End If
        End If
    End Sub
    'Codigo de 2do tab ESTADISTICA DE NUMEROS
    Private Sub tab2btnReiniciar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tab2btnReiniciar.Click
        tab2txtNumero.Text = ""
        tab2lblCantidad.Text = "________"
        tab2lblMayor.Text = "________"
        tab2lblMenor.Text = "________"
        tab2lblPromedio.Text = "________"
    End Sub

    Private Sub tab2btnIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tab2btnIngresar.Click
        Dim numero As Integer = Val(tab2txtNumero.Text)
        Dim mayor As Integer = 0
        Dim menor, cantidad As Integer
        Dim promedio As Decimal
        Dim acumulador As Integer = 0
        'For i = 1 To numero do
        If numero > acumulador Then
            acumulador = numero
        End If
        If acumulador > mayor Then
            acumulador = mayor
        End If
        tab2lblMayor.Text = mayor
    End Sub
    'Codigo de 3er tab COMPARADOR DE NUMEROS
    Private Sub tab3btnComparar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tab3btnComparar.Click
        Dim mayor3, menor3 As Integer
        tab3lblIguales.Text = ""

        If tab3txtNroA.Text > tab3txtNroB.Text And tab3txtNroA.Text > tab3txtNroC.Text Then
            mayor3 = tab3txtNroA.Text
        Else
            If tab3txtNroB.Text > tab3txtNroA.Text And tab3txtNroB.Text > tab3txtNroC.Text Then
                mayor3 = tab3txtNroB.Text
            Else
                 mayor3 = tab3txtNroC.Text
            End If
         End If

        tab3lblMayor.Text = mayor3

        If tab3txtNroA.Text < tab3txtNroB.Text And tab3txtNroA.Text < tab3txtNroC.Text Then
            menor3 = tab3txtNroA.Text
        Else
            If tab3txtNroB.Text < tab3txtNroA.Text And tab3txtNroB.Text < tab3txtNroC.Text Then
                menor3 = tab3txtNroB.Text
            Else
                menor3 = tab3txtNroC.Text
            End If
        End If

        tab3lblMenor.Text = menor3

        If tab3txtNroA.Text = tab3txtNroB.Text And tab3txtNroB.Text = tab3txtNroC.Text Then
            tab3lblMayor.Text = "_______"
            tab3lblMenor.Text = "_______"
            tab3lblIguales.Text = "Todos los números son iguales."
        End If
    End Sub
End Class
