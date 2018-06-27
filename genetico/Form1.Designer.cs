namespace genetico
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxMutacion = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbxGeneraciones = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbxCruce = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbxPoblacion = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTitulo = new System.Windows.Forms.Button();
            this.lblFunción = new System.Windows.Forms.Label();
            this.btnCalcular = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalir = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnMochila = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnGenetico = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnGanancias = new Bunifu.Framework.UI.BunifuThinButton2();
            this.gbxMochila = new System.Windows.Forms.GroupBox();
            this.cbOpciones = new System.Windows.Forms.ComboBox();
            this.btnCapacidadMochila = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPesos = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnResOpt = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ofdAbrirArchivo = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbxMochila.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxMutacion);
            this.groupBox1.Controls.Add(this.tbxGeneraciones);
            this.groupBox1.Controls.Add(this.tbxCruce);
            this.groupBox1.Controls.Add(this.tbxPoblacion);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(135, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(614, 165);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // tbxMutacion
            // 
            this.tbxMutacion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxMutacion.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbxMutacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbxMutacion.HintForeColor = System.Drawing.Color.Empty;
            this.tbxMutacion.HintText = "Probabilidad de mutación [0.001, 0.01]";
            this.tbxMutacion.isPassword = false;
            this.tbxMutacion.LineFocusedColor = System.Drawing.SystemColors.MenuHighlight;
            this.tbxMutacion.LineIdleColor = System.Drawing.Color.Gray;
            this.tbxMutacion.LineMouseHoverColor = System.Drawing.Color.LightSkyBlue;
            this.tbxMutacion.LineThickness = 3;
            this.tbxMutacion.Location = new System.Drawing.Point(23, 105);
            this.tbxMutacion.Margin = new System.Windows.Forms.Padding(4);
            this.tbxMutacion.Name = "tbxMutacion";
            this.tbxMutacion.Size = new System.Drawing.Size(277, 33);
            this.tbxMutacion.TabIndex = 17;
            this.tbxMutacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxGeneraciones
            // 
            this.tbxGeneraciones.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxGeneraciones.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbxGeneraciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbxGeneraciones.HintForeColor = System.Drawing.Color.Empty;
            this.tbxGeneraciones.HintText = "Cantidad de generaciones";
            this.tbxGeneraciones.isPassword = false;
            this.tbxGeneraciones.LineFocusedColor = System.Drawing.SystemColors.MenuHighlight;
            this.tbxGeneraciones.LineIdleColor = System.Drawing.Color.Gray;
            this.tbxGeneraciones.LineMouseHoverColor = System.Drawing.Color.LightSkyBlue;
            this.tbxGeneraciones.LineThickness = 3;
            this.tbxGeneraciones.Location = new System.Drawing.Point(315, 105);
            this.tbxGeneraciones.Margin = new System.Windows.Forms.Padding(4);
            this.tbxGeneraciones.Name = "tbxGeneraciones";
            this.tbxGeneraciones.Size = new System.Drawing.Size(277, 33);
            this.tbxGeneraciones.TabIndex = 18;
            this.tbxGeneraciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxCruce
            // 
            this.tbxCruce.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxCruce.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbxCruce.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbxCruce.HintForeColor = System.Drawing.Color.Empty;
            this.tbxCruce.HintText = "Probalidad de cruce [0.65, 0.80]";
            this.tbxCruce.isPassword = false;
            this.tbxCruce.LineFocusedColor = System.Drawing.SystemColors.MenuHighlight;
            this.tbxCruce.LineIdleColor = System.Drawing.Color.Gray;
            this.tbxCruce.LineMouseHoverColor = System.Drawing.Color.LightSkyBlue;
            this.tbxCruce.LineThickness = 3;
            this.tbxCruce.Location = new System.Drawing.Point(315, 51);
            this.tbxCruce.Margin = new System.Windows.Forms.Padding(4);
            this.tbxCruce.Name = "tbxCruce";
            this.tbxCruce.Size = new System.Drawing.Size(277, 33);
            this.tbxCruce.TabIndex = 16;
            this.tbxCruce.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxPoblacion
            // 
            this.tbxPoblacion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxPoblacion.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbxPoblacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbxPoblacion.HintForeColor = System.Drawing.Color.Empty;
            this.tbxPoblacion.HintText = "Tamaño de la población";
            this.tbxPoblacion.isPassword = false;
            this.tbxPoblacion.LineFocusedColor = System.Drawing.SystemColors.MenuHighlight;
            this.tbxPoblacion.LineIdleColor = System.Drawing.Color.Gray;
            this.tbxPoblacion.LineMouseHoverColor = System.Drawing.Color.LightSkyBlue;
            this.tbxPoblacion.LineThickness = 3;
            this.tbxPoblacion.Location = new System.Drawing.Point(23, 51);
            this.tbxPoblacion.Margin = new System.Windows.Forms.Padding(4);
            this.tbxPoblacion.Name = "tbxPoblacion";
            this.tbxPoblacion.Size = new System.Drawing.Size(277, 33);
            this.tbxPoblacion.TabIndex = 15;
            this.tbxPoblacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(246, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 21);
            this.label5.TabIndex = 14;
            this.label5.Text = "Datos genéticos";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.Location = new System.Drawing.Point(120, 427);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(0, 21);
            this.lblX.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 21);
            this.label1.TabIndex = 18;
            this.label1.Text = "Mejores resultados";
            // 
            // btnTitulo
            // 
            this.btnTitulo.BackColor = System.Drawing.Color.SteelBlue;
            this.btnTitulo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTitulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnTitulo.Location = new System.Drawing.Point(-1, -1);
            this.btnTitulo.Name = "btnTitulo";
            this.btnTitulo.Size = new System.Drawing.Size(779, 71);
            this.btnTitulo.TabIndex = 17;
            this.btnTitulo.Text = "ALGORITMO GENÉTICO PURO";
            this.btnTitulo.UseVisualStyleBackColor = false;
            // 
            // lblFunción
            // 
            this.lblFunción.AutoSize = true;
            this.lblFunción.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFunción.Location = new System.Drawing.Point(139, 87);
            this.lblFunción.Name = "lblFunción";
            this.lblFunción.Size = new System.Drawing.Size(398, 21);
            this.lblFunción.TabIndex = 16;
            this.lblFunción.Text = "Función    f(x) = sen (Pi x/256)     donde    0 < x < 255";
            // 
            // btnCalcular
            // 
            this.btnCalcular.ActiveBorderThickness = 1;
            this.btnCalcular.ActiveCornerRadius = 20;
            this.btnCalcular.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnCalcular.ActiveForecolor = System.Drawing.Color.White;
            this.btnCalcular.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnCalcular.BackColor = System.Drawing.Color.White;
            this.btnCalcular.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCalcular.BackgroundImage")));
            this.btnCalcular.ButtonText = "Calcular";
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnCalcular.IdleBorderThickness = 1;
            this.btnCalcular.IdleCornerRadius = 20;
            this.btnCalcular.IdleFillColor = System.Drawing.Color.White;
            this.btnCalcular.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnCalcular.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnCalcular.Location = new System.Drawing.Point(193, 321);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(166, 37);
            this.btnCalcular.TabIndex = 19;
            this.btnCalcular.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.btnMochila);
            this.panel1.Controls.Add(this.btnGenetico);
            this.panel1.Location = new System.Drawing.Point(2, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 481);
            this.panel1.TabIndex = 22;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSalir.color = System.Drawing.Color.SeaGreen;
            this.btnSalir.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImagePosition = 17;
            this.btnSalir.ImageZoom = 30;
            this.btnSalir.LabelPosition = 36;
            this.btnSalir.LabelText = "Salir";
            this.btnSalir.Location = new System.Drawing.Point(0, 204);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(6);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 100);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnMochila
            // 
            this.btnMochila.BackColor = System.Drawing.Color.SeaGreen;
            this.btnMochila.color = System.Drawing.Color.SeaGreen;
            this.btnMochila.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnMochila.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMochila.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnMochila.ForeColor = System.Drawing.Color.White;
            this.btnMochila.Image = ((System.Drawing.Image)(resources.GetObject("btnMochila.Image")));
            this.btnMochila.ImagePosition = 17;
            this.btnMochila.ImageZoom = 40;
            this.btnMochila.LabelPosition = 36;
            this.btnMochila.LabelText = "Mochila";
            this.btnMochila.Location = new System.Drawing.Point(0, 102);
            this.btnMochila.Margin = new System.Windows.Forms.Padding(6);
            this.btnMochila.Name = "btnMochila";
            this.btnMochila.Size = new System.Drawing.Size(100, 100);
            this.btnMochila.TabIndex = 1;
            this.btnMochila.Click += new System.EventHandler(this.btnMochila_Click);
            // 
            // btnGenetico
            // 
            this.btnGenetico.BackColor = System.Drawing.Color.SeaGreen;
            this.btnGenetico.color = System.Drawing.Color.SeaGreen;
            this.btnGenetico.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnGenetico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenetico.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnGenetico.ForeColor = System.Drawing.Color.White;
            this.btnGenetico.Image = ((System.Drawing.Image)(resources.GetObject("btnGenetico.Image")));
            this.btnGenetico.ImagePosition = 17;
            this.btnGenetico.ImageZoom = 40;
            this.btnGenetico.LabelPosition = 36;
            this.btnGenetico.LabelText = "Genético";
            this.btnGenetico.Location = new System.Drawing.Point(0, 0);
            this.btnGenetico.Margin = new System.Windows.Forms.Padding(6);
            this.btnGenetico.Name = "btnGenetico";
            this.btnGenetico.Size = new System.Drawing.Size(100, 100);
            this.btnGenetico.TabIndex = 0;
            this.btnGenetico.Click += new System.EventHandler(this.btnGenetico_Click);
            // 
            // btnGanancias
            // 
            this.btnGanancias.ActiveBorderThickness = 1;
            this.btnGanancias.ActiveCornerRadius = 20;
            this.btnGanancias.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnGanancias.ActiveForecolor = System.Drawing.Color.White;
            this.btnGanancias.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnGanancias.BackColor = System.Drawing.Color.White;
            this.btnGanancias.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGanancias.BackgroundImage")));
            this.btnGanancias.ButtonText = "Buscar ganancias";
            this.btnGanancias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGanancias.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnGanancias.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnGanancias.IdleBorderThickness = 1;
            this.btnGanancias.IdleCornerRadius = 20;
            this.btnGanancias.IdleFillColor = System.Drawing.Color.White;
            this.btnGanancias.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnGanancias.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnGanancias.Location = new System.Drawing.Point(17, 119);
            this.btnGanancias.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGanancias.Name = "btnGanancias";
            this.btnGanancias.Size = new System.Drawing.Size(277, 37);
            this.btnGanancias.TabIndex = 23;
            this.btnGanancias.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGanancias.Visible = false;
            this.btnGanancias.Click += new System.EventHandler(this.btnGanancias_Click);
            // 
            // gbxMochila
            // 
            this.gbxMochila.Controls.Add(this.cbOpciones);
            this.gbxMochila.Controls.Add(this.btnCapacidadMochila);
            this.gbxMochila.Controls.Add(this.label2);
            this.gbxMochila.Controls.Add(this.btnPesos);
            this.gbxMochila.Controls.Add(this.btnResOpt);
            this.gbxMochila.Controls.Add(this.btnGanancias);
            this.gbxMochila.Location = new System.Drawing.Point(440, 292);
            this.gbxMochila.Name = "gbxMochila";
            this.gbxMochila.Size = new System.Drawing.Size(309, 242);
            this.gbxMochila.TabIndex = 24;
            this.gbxMochila.TabStop = false;
            this.gbxMochila.Visible = false;
            // 
            // cbOpciones
            // 
            this.cbOpciones.BackColor = System.Drawing.Color.SeaGreen;
            this.cbOpciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbOpciones.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.cbOpciones.ForeColor = System.Drawing.Color.White;
            this.cbOpciones.FormattingEnabled = true;
            this.cbOpciones.Items.AddRange(new object[] {
            "Igualar a 0",
            "Formula",
            "Reparación aleatoria",
            "Reparación voraz"});
            this.cbOpciones.Location = new System.Drawing.Point(41, 197);
            this.cbOpciones.Name = "cbOpciones";
            this.cbOpciones.Size = new System.Drawing.Size(246, 28);
            this.cbOpciones.TabIndex = 25;
            this.cbOpciones.Text = "Tipo de penalización";
            // 
            // btnCapacidadMochila
            // 
            this.btnCapacidadMochila.ActiveBorderThickness = 1;
            this.btnCapacidadMochila.ActiveCornerRadius = 20;
            this.btnCapacidadMochila.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnCapacidadMochila.ActiveForecolor = System.Drawing.Color.White;
            this.btnCapacidadMochila.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnCapacidadMochila.BackColor = System.Drawing.Color.White;
            this.btnCapacidadMochila.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCapacidadMochila.BackgroundImage")));
            this.btnCapacidadMochila.ButtonText = "Capacidad de la mochila";
            this.btnCapacidadMochila.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCapacidadMochila.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnCapacidadMochila.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnCapacidadMochila.IdleBorderThickness = 1;
            this.btnCapacidadMochila.IdleCornerRadius = 20;
            this.btnCapacidadMochila.IdleFillColor = System.Drawing.Color.White;
            this.btnCapacidadMochila.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnCapacidadMochila.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnCapacidadMochila.Location = new System.Drawing.Point(17, 55);
            this.btnCapacidadMochila.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCapacidadMochila.Name = "btnCapacidadMochila";
            this.btnCapacidadMochila.Size = new System.Drawing.Size(277, 37);
            this.btnCapacidadMochila.TabIndex = 26;
            this.btnCapacidadMochila.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCapacidadMochila.Click += new System.EventHandler(this.btnCapacidadMochila_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label2.Location = new System.Drawing.Point(117, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 21);
            this.label2.TabIndex = 25;
            this.label2.Text = "Mochila";
            // 
            // btnPesos
            // 
            this.btnPesos.ActiveBorderThickness = 1;
            this.btnPesos.ActiveCornerRadius = 20;
            this.btnPesos.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnPesos.ActiveForecolor = System.Drawing.Color.White;
            this.btnPesos.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnPesos.BackColor = System.Drawing.Color.White;
            this.btnPesos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPesos.BackgroundImage")));
            this.btnPesos.ButtonText = "Buscar pesos";
            this.btnPesos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnPesos.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnPesos.IdleBorderThickness = 1;
            this.btnPesos.IdleCornerRadius = 20;
            this.btnPesos.IdleFillColor = System.Drawing.Color.White;
            this.btnPesos.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnPesos.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnPesos.Location = new System.Drawing.Point(17, 152);
            this.btnPesos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPesos.Name = "btnPesos";
            this.btnPesos.Size = new System.Drawing.Size(277, 37);
            this.btnPesos.TabIndex = 25;
            this.btnPesos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPesos.Visible = false;
            this.btnPesos.Click += new System.EventHandler(this.btnPesos_Click);
            // 
            // btnResOpt
            // 
            this.btnResOpt.ActiveBorderThickness = 1;
            this.btnResOpt.ActiveCornerRadius = 20;
            this.btnResOpt.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnResOpt.ActiveForecolor = System.Drawing.Color.White;
            this.btnResOpt.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnResOpt.BackColor = System.Drawing.Color.White;
            this.btnResOpt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnResOpt.BackgroundImage")));
            this.btnResOpt.ButtonText = "Buscar respuesta optima";
            this.btnResOpt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResOpt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnResOpt.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnResOpt.IdleBorderThickness = 1;
            this.btnResOpt.IdleCornerRadius = 20;
            this.btnResOpt.IdleFillColor = System.Drawing.Color.White;
            this.btnResOpt.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnResOpt.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnResOpt.Location = new System.Drawing.Point(17, 86);
            this.btnResOpt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnResOpt.Name = "btnResOpt";
            this.btnResOpt.Size = new System.Drawing.Size(277, 37);
            this.btnResOpt.TabIndex = 24;
            this.btnResOpt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnResOpt.Visible = false;
            this.btnResOpt.Click += new System.EventHandler(this.btnResOpt_Click);
            // 
            // ofdAbrirArchivo
            // 
            this.ofdAbrirArchivo.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(778, 551);
            this.Controls.Add(this.gbxMochila);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTitulo);
            this.Controls.Add(this.lblFunción);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(794, 590);
            this.MinimumSize = new System.Drawing.Size(794, 590);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.gbxMochila.ResumeLayout(false);
            this.gbxMochila.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTitulo;
        private System.Windows.Forms.Label lblFunción;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbxGeneraciones;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbxCruce;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbxPoblacion;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCalcular;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbxMutacion;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuTileButton btnSalir;
        private Bunifu.Framework.UI.BunifuTileButton btnMochila;
        private Bunifu.Framework.UI.BunifuTileButton btnGenetico;
        private Bunifu.Framework.UI.BunifuThinButton2 btnGanancias;
        private System.Windows.Forms.GroupBox gbxMochila;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuThinButton2 btnPesos;
        private Bunifu.Framework.UI.BunifuThinButton2 btnResOpt;
        private System.Windows.Forms.OpenFileDialog ofdAbrirArchivo;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCapacidadMochila;
        private System.Windows.Forms.ComboBox cbOpciones;
    }
}