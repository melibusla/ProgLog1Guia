<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabGuia = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lblResultado = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnClasificar = New System.Windows.Forms.Button()
        Me.txtNum = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.tab2btnReiniciar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tab2lblPromedio = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tab2lblCantidad = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tab2lblMenor = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tab2lblMayor = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tab2btnIngresar = New System.Windows.Forms.Button()
        Me.tab2txtNumero = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.tab3lblIguales = New System.Windows.Forms.Label()
        Me.tab3lblMenor = New System.Windows.Forms.Label()
        Me.tab3lblMayor = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.tab3btnComparar = New System.Windows.Forms.Button()
        Me.tab3txtNroC = New System.Windows.Forms.TextBox()
        Me.tab3txtNroB = New System.Windows.Forms.TextBox()
        Me.tab3txtNroA = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.tab4txtDia = New System.Windows.Forms.TextBox()
        Me.tab4txtMes = New System.Windows.Forms.TextBox()
        Me.tab4txtAño = New System.Windows.Forms.TextBox()
        Me.tab4lblResultado = New System.Windows.Forms.Label()
        Me.tab4btnValidar = New System.Windows.Forms.Button()
        Me.TabGuia.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabGuia
        '
        Me.TabGuia.Controls.Add(Me.TabPage1)
        Me.TabGuia.Controls.Add(Me.TabPage2)
        Me.TabGuia.Controls.Add(Me.TabPage3)
        Me.TabGuia.Controls.Add(Me.TabPage4)
        Me.TabGuia.Location = New System.Drawing.Point(12, 12)
        Me.TabGuia.Multiline = True
        Me.TabGuia.Name = "TabGuia"
        Me.TabGuia.SelectedIndex = 0
        Me.TabGuia.Size = New System.Drawing.Size(322, 374)
        Me.TabGuia.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.TabGuia.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lblResultado)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.btnClasificar)
        Me.TabPage1.Controls.Add(Me.txtNum)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 40)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(314, 330)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "1- Clasificación de Números"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'lblResultado
        '
        Me.lblResultado.AutoSize = True
        Me.lblResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultado.Location = New System.Drawing.Point(103, 166)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(71, 16)
        Me.lblResultado.TabIndex = 5
        Me.lblResultado.Text = "_________"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 164)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Resultado:"
        '
        'btnClasificar
        '
        Me.btnClasificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClasificar.Location = New System.Drawing.Point(203, 99)
        Me.btnClasificar.Name = "btnClasificar"
        Me.btnClasificar.Size = New System.Drawing.Size(75, 23)
        Me.btnClasificar.TabIndex = 3
        Me.btnClasificar.Text = "Clasificar"
        Me.btnClasificar.UseVisualStyleBackColor = True
        '
        'txtNum
        '
        Me.txtNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNum.Location = New System.Drawing.Point(101, 99)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Size = New System.Drawing.Size(57, 24)
        Me.txtNum.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Número:"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(274, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingrese un número y presione el botón para establecer su tipo."
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.tab2btnReiniciar)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Controls.Add(Me.tab2btnIngresar)
        Me.TabPage2.Controls.Add(Me.tab2txtNumero)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 40)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(314, 330)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "2- Estadística de Números"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'tab2btnReiniciar
        '
        Me.tab2btnReiniciar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab2btnReiniciar.Location = New System.Drawing.Point(206, 327)
        Me.tab2btnReiniciar.Name = "tab2btnReiniciar"
        Me.tab2btnReiniciar.Size = New System.Drawing.Size(75, 23)
        Me.tab2btnReiniciar.TabIndex = 5
        Me.tab2btnReiniciar.Text = "Reiniciar Datos"
        Me.tab2btnReiniciar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tab2lblPromedio)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.tab2lblCantidad)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.tab2lblMenor)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.tab2lblMayor)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(28, 142)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(253, 167)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Resultados"
        '
        'tab2lblPromedio
        '
        Me.tab2lblPromedio.AutoSize = True
        Me.tab2lblPromedio.Location = New System.Drawing.Point(75, 128)
        Me.tab2lblPromedio.Name = "tab2lblPromedio"
        Me.tab2lblPromedio.Size = New System.Drawing.Size(64, 16)
        Me.tab2lblPromedio.TabIndex = 7
        Me.tab2lblPromedio.Text = "________"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(7, 128)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(70, 16)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Promedio:"
        '
        'tab2lblCantidad
        '
        Me.tab2lblCantidad.AutoSize = True
        Me.tab2lblCantidad.Location = New System.Drawing.Point(127, 95)
        Me.tab2lblCantidad.Name = "tab2lblCantidad"
        Me.tab2lblCantidad.Size = New System.Drawing.Size(64, 16)
        Me.tab2lblCantidad.TabIndex = 5
        Me.tab2lblCantidad.Text = "________"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(7, 95)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(123, 16)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Cantidad de Datos:"
        '
        'tab2lblMenor
        '
        Me.tab2lblMenor.AutoSize = True
        Me.tab2lblMenor.Location = New System.Drawing.Point(54, 63)
        Me.tab2lblMenor.Name = "tab2lblMenor"
        Me.tab2lblMenor.Size = New System.Drawing.Size(64, 16)
        Me.tab2lblMenor.TabIndex = 3
        Me.tab2lblMenor.Text = "________"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 63)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 16)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Menor:"
        '
        'tab2lblMayor
        '
        Me.tab2lblMayor.AutoSize = True
        Me.tab2lblMayor.Location = New System.Drawing.Point(54, 32)
        Me.tab2lblMayor.Name = "tab2lblMayor"
        Me.tab2lblMayor.Size = New System.Drawing.Size(64, 16)
        Me.tab2lblMayor.TabIndex = 1
        Me.tab2lblMayor.Text = "________"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Mayor:"
        '
        'tab2btnIngresar
        '
        Me.tab2btnIngresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab2btnIngresar.Location = New System.Drawing.Point(206, 86)
        Me.tab2btnIngresar.Name = "tab2btnIngresar"
        Me.tab2btnIngresar.Size = New System.Drawing.Size(75, 23)
        Me.tab2btnIngresar.TabIndex = 3
        Me.tab2btnIngresar.Text = "Ingresar!"
        Me.tab2btnIngresar.UseVisualStyleBackColor = True
        '
        'tab2txtNumero
        '
        Me.tab2txtNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab2txtNumero.Location = New System.Drawing.Point(97, 92)
        Me.tab2txtNumero.Name = "tab2txtNumero"
        Me.tab2txtNumero.Size = New System.Drawing.Size(81, 22)
        Me.tab2txtNumero.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(28, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 16)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Número"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(256, 55)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Ingrese los números que quiera. Por cada número ingresado, se actualizarán los re" & _
            "sultados de manera automática."
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.tab3lblIguales)
        Me.TabPage3.Controls.Add(Me.tab3lblMenor)
        Me.TabPage3.Controls.Add(Me.tab3lblMayor)
        Me.TabPage3.Controls.Add(Me.Label15)
        Me.TabPage3.Controls.Add(Me.Label14)
        Me.TabPage3.Controls.Add(Me.tab3btnComparar)
        Me.TabPage3.Controls.Add(Me.tab3txtNroC)
        Me.TabPage3.Controls.Add(Me.tab3txtNroB)
        Me.TabPage3.Controls.Add(Me.tab3txtNroA)
        Me.TabPage3.Controls.Add(Me.Label13)
        Me.TabPage3.Controls.Add(Me.Label11)
        Me.TabPage3.Controls.Add(Me.Label9)
        Me.TabPage3.Controls.Add(Me.Label7)
        Me.TabPage3.Location = New System.Drawing.Point(4, 40)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(314, 330)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "3 - Comparador de Números"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'tab3lblIguales
        '
        Me.tab3lblIguales.AutoSize = True
        Me.tab3lblIguales.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab3lblIguales.ForeColor = System.Drawing.Color.DarkGreen
        Me.tab3lblIguales.Location = New System.Drawing.Point(23, 303)
        Me.tab3lblIguales.Name = "tab3lblIguales"
        Me.tab3lblIguales.Size = New System.Drawing.Size(0, 16)
        Me.tab3lblIguales.TabIndex = 12
        '
        'tab3lblMenor
        '
        Me.tab3lblMenor.AutoSize = True
        Me.tab3lblMenor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab3lblMenor.Location = New System.Drawing.Point(202, 267)
        Me.tab3lblMenor.Name = "tab3lblMenor"
        Me.tab3lblMenor.Size = New System.Drawing.Size(57, 16)
        Me.tab3lblMenor.TabIndex = 11
        Me.tab3lblMenor.Text = "_______"
        '
        'tab3lblMayor
        '
        Me.tab3lblMayor.AutoSize = True
        Me.tab3lblMayor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab3lblMayor.Location = New System.Drawing.Point(65, 267)
        Me.tab3lblMayor.Name = "tab3lblMayor"
        Me.tab3lblMayor.Size = New System.Drawing.Size(57, 16)
        Me.tab3lblMayor.TabIndex = 10
        Me.tab3lblMayor.Text = "_______"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(147, 267)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(49, 16)
        Me.Label15.TabIndex = 9
        Me.Label15.Text = "Menor:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(20, 267)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(49, 16)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "Mayor:"
        '
        'tab3btnComparar
        '
        Me.tab3btnComparar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab3btnComparar.Location = New System.Drawing.Point(57, 215)
        Me.tab3btnComparar.Name = "tab3btnComparar"
        Me.tab3btnComparar.Size = New System.Drawing.Size(88, 23)
        Me.tab3btnComparar.TabIndex = 7
        Me.tab3btnComparar.Text = "Comparar..."
        Me.tab3btnComparar.UseVisualStyleBackColor = True
        '
        'tab3txtNroC
        '
        Me.tab3txtNroC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab3txtNroC.Location = New System.Drawing.Point(79, 172)
        Me.tab3txtNroC.Name = "tab3txtNroC"
        Me.tab3txtNroC.Size = New System.Drawing.Size(66, 22)
        Me.tab3txtNroC.TabIndex = 6
        '
        'tab3txtNroB
        '
        Me.tab3txtNroB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab3txtNroB.Location = New System.Drawing.Point(79, 133)
        Me.tab3txtNroB.Name = "tab3txtNroB"
        Me.tab3txtNroB.Size = New System.Drawing.Size(66, 22)
        Me.tab3txtNroB.TabIndex = 5
        '
        'tab3txtNroA
        '
        Me.tab3txtNroA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab3txtNroA.Location = New System.Drawing.Point(79, 91)
        Me.tab3txtNroA.Name = "tab3txtNroA"
        Me.tab3txtNroA.Size = New System.Drawing.Size(66, 22)
        Me.tab3txtNroA.TabIndex = 4
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(20, 178)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(34, 16)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "N° C"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(20, 139)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(34, 16)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "N° B"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(20, 97)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 16)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "N° A"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(17, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(276, 63)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Ingrese tres números para compararlos y determinar automáticamente el Mayor y el " & _
            "Menor de ellos."
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.tab4btnValidar)
        Me.TabPage4.Controls.Add(Me.tab4lblResultado)
        Me.TabPage4.Controls.Add(Me.tab4txtAño)
        Me.TabPage4.Controls.Add(Me.tab4txtMes)
        Me.TabPage4.Controls.Add(Me.tab4txtDia)
        Me.TabPage4.Controls.Add(Me.Label20)
        Me.TabPage4.Controls.Add(Me.Label19)
        Me.TabPage4.Controls.Add(Me.Label18)
        Me.TabPage4.Controls.Add(Me.Label17)
        Me.TabPage4.Controls.Add(Me.Label16)
        Me.TabPage4.Location = New System.Drawing.Point(4, 40)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(314, 330)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "4- Fecha Valida?"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(32, 23)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(262, 70)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Ingrese día, mes y año de una fecha para determinar si se trata de una fecha váli" & _
            "da o no."
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(35, 106)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(29, 16)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "Día"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(35, 144)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(34, 16)
        Me.Label18.TabIndex = 2
        Me.Label18.Text = "Mes"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(35, 182)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(32, 16)
        Me.Label19.TabIndex = 3
        Me.Label19.Text = "Año"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(35, 237)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(73, 16)
        Me.Label20.TabIndex = 4
        Me.Label20.Text = "Resultado:"
        '
        'tab4txtDia
        '
        Me.tab4txtDia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab4txtDia.Location = New System.Drawing.Point(71, 106)
        Me.tab4txtDia.Name = "tab4txtDia"
        Me.tab4txtDia.Size = New System.Drawing.Size(61, 22)
        Me.tab4txtDia.TabIndex = 5
        '
        'tab4txtMes
        '
        Me.tab4txtMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab4txtMes.Location = New System.Drawing.Point(71, 144)
        Me.tab4txtMes.Name = "tab4txtMes"
        Me.tab4txtMes.Size = New System.Drawing.Size(61, 22)
        Me.tab4txtMes.TabIndex = 6
        '
        'tab4txtAño
        '
        Me.tab4txtAño.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab4txtAño.Location = New System.Drawing.Point(74, 182)
        Me.tab4txtAño.Name = "tab4txtAño"
        Me.tab4txtAño.Size = New System.Drawing.Size(58, 22)
        Me.tab4txtAño.TabIndex = 7
        '
        'tab4lblResultado
        '
        Me.tab4lblResultado.AutoSize = True
        Me.tab4lblResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab4lblResultado.Location = New System.Drawing.Point(114, 237)
        Me.tab4lblResultado.Name = "tab4lblResultado"
        Me.tab4lblResultado.Size = New System.Drawing.Size(92, 16)
        Me.tab4lblResultado.TabIndex = 8
        Me.tab4lblResultado.Text = "____________"
        '
        'tab4btnValidar
        '
        Me.tab4btnValidar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab4btnValidar.Location = New System.Drawing.Point(175, 136)
        Me.tab4btnValidar.Name = "tab4btnValidar"
        Me.tab4btnValidar.Size = New System.Drawing.Size(75, 23)
        Me.tab4btnValidar.TabIndex = 9
        Me.tab4btnValidar.Text = "Validar"
        Me.tab4btnValidar.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(349, 395)
        Me.Controls.Add(Me.TabGuia)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Programación Logica 1 - Guia de Ejercicios"
        Me.TabGuia.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabGuia As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblResultado As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnClasificar As System.Windows.Forms.Button
    Friend WithEvents txtNum As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tab2btnReiniciar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tab2lblPromedio As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents tab2lblCantidad As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents tab2lblMenor As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tab2lblMayor As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tab2btnIngresar As System.Windows.Forms.Button
    Friend WithEvents tab2txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents tab3lblMenor As System.Windows.Forms.Label
    Friend WithEvents tab3lblMayor As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents tab3btnComparar As System.Windows.Forms.Button
    Friend WithEvents tab3txtNroC As System.Windows.Forms.TextBox
    Friend WithEvents tab3txtNroB As System.Windows.Forms.TextBox
    Friend WithEvents tab3txtNroA As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tab3lblIguales As System.Windows.Forms.Label
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents tab4btnValidar As System.Windows.Forms.Button
    Friend WithEvents tab4lblResultado As System.Windows.Forms.Label
    Friend WithEvents tab4txtAño As System.Windows.Forms.TextBox
    Friend WithEvents tab4txtMes As System.Windows.Forms.TextBox
    Friend WithEvents tab4txtDia As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label

End Class
