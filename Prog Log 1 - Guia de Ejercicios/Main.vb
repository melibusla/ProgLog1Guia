Public Class Main
    'Variables para tab 2, el de N numeros
    Dim mayor As Integer = 0
    Dim menor As Integer = 2147483647
    Dim Cantidad As Integer = 0
    Dim promedio As Decimal
    Dim acumulador As Integer = 0
    ' variables tab 4 fecha valida
    Dim D, M, A As Integer
    
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
        acumulador = 0
        promedio = 0
    End Sub

    Private Sub tab2btnIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tab2btnIngresar.Click
        Dim numero As Integer = Val(tab2txtNumero.Text)
        If numero > mayor Then
            mayor = numero
            tab2lblMayor.Text = mayor
        End If

        If numero < menor Then
            menor = numero
            tab2lblMenor.Text = menor
        End If

        Cantidad = Cantidad + 1
        tab2lblCantidad.Text = Cantidad

        acumulador = acumulador + numero

        promedio = acumulador / Cantidad
        tab2lblPromedio.Text = promedio
    End Sub
    'Codigo de 3er tab COMPARADOR DE NUMEROS
    Private Sub tab3btnComparar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tab3btnComparar.Click
        Dim mayor3, menor3 As Integer
        tab3lblIguales.Text = ""

        If tab3txtNroA.Text > tab3txtNroB.Text And tab3txtNroA.Text > tab3txtNroC.Text Then
            mayor3 = tab3txtNroA.Text
        Else
            If tab3txtNroB.Text > tab3txtNroC.Text Then
                mayor3 = tab3txtNroB.Text
            Else
                mayor3 = tab3txtNroC.Text
            End If
        End If

        tab3lblMayor.Text = mayor3

        If tab3txtNroA.Text < tab3txtNroB.Text And tab3txtNroA.Text < tab3txtNroC.Text Then
            menor3 = tab3txtNroA.Text
        Else
            If tab3txtNroB.Text < tab3txtNroC.Text Then
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
    'TAB 4 - VALIDAR FECHA 
    Public Sub tab4btnValidar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tab4btnValidar.Click
        If FechaValida(Val(tab4txtDia.Text), Val(tab4txtMes.Text), Val(tab4txtAño.Text)) = True Then
            tab4lblResultado.Text = "Fecha Valida"
        Else
            tab4lblResultado.Text = "Fecha INVALIDA!"
        End If
    End Sub
    Public Function FechaValida(ByVal D, ByVal M, ByVal A) As Boolean
        Dim Valida As Boolean = True
        If M < 1 Or M > 12 Then
            Valida = False
        Else
            If (M = 1 Or M = 3 Or M = 5 Or M = 7 Or M = 8 Or M = 10 Or M = 12) And (D < 1 Or D > 31) Then
                Valida = False
            Else
                If (M = 4 Or M = 6 Or M = 9 Or M = 11) And (D < 1 Or D > 30) Then
                    Valida = False
                Else
                    If M = 2 And Bisiesto(A) = True And (D < 1 Or D > 29) Then
                        Valida = False
                    Else
                        If M = 2 And Bisiesto(A) = False And (D < 1 Or D > 28) Then
                            Valida = False
                        End If
                    End If
                End If
            End If
        End If
        Return Valida
    End Function

    Public Function Bisiesto(ByVal A) As Boolean
        Dim esBisiesto As Boolean = False

        If A Mod 4 = 0 Then
            If A Mod 100 = 0 Then
                If A Mod 400 = 0 Then
                    esBisiesto = True
                End If
            Else
                esBisiesto = True
            End If
        End If
        Return esBisiesto
    End Function

    Private Sub tab5btnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tab5btnCalcular.Click
        tab5lblResultado.Text = MayorFecha(tab5txtA.Text, tab5txtB.Text)
    End Sub

    Function MayorFecha(ByVal fA As String, ByVal fB As String) As String
        Dim auxA, auxB As String
        auxA = fA.Substring(6, 4) & fA.Substring(3, 2) & fA.Substring(0, 2)
        auxB = fB.Substring(6, 4) & fB.Substring(3, 2) & fB.Substring(0, 2)

        If auxA > auxB Then
            Return fA
        Else
            Return fB
        End If
    End Function
End Class
