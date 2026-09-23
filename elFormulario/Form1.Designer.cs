namespace elFormulario
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnArriba = new Button();
            btnIzquierda = new Button();
            btnDerecha = new Button();
            btnAbajo = new Button();
            btnCrea = new Button();
            btnVisible = new Button();
            laBienvenido = new Label();
            groupBox1 = new GroupBox();
            btnDos = new Button();
            btnTres = new Button();
            btnUno = new Button();
            pnBotones = new Panel();
            btnSalir = new Button();
            btnDisminuye = new Button();
            btnDelante = new Button();
            btnControlesForm = new Button();
            btnControlesPanel = new Button();
            btnAcercaDe = new Button();
            btnDetras = new Button();
            btnAumenta = new Button();
            laTamanyo = new Label();
            laMover = new Label();
            groupBox1.SuspendLayout();
            pnBotones.SuspendLayout();
            SuspendLayout();
            // 
            // btnArriba
            // 
            btnArriba.Location = new Point(138, 118);
            btnArriba.Name = "btnArriba";
            btnArriba.Size = new Size(75, 23);
            btnArriba.TabIndex = 0;
            btnArriba.Text = "Arriba";
            btnArriba.UseVisualStyleBackColor = true;
            btnArriba.Click += btnArriba_Click;
            // 
            // btnIzquierda
            // 
            btnIzquierda.Location = new Point(69, 147);
            btnIzquierda.Name = "btnIzquierda";
            btnIzquierda.Size = new Size(75, 23);
            btnIzquierda.TabIndex = 1;
            btnIzquierda.Text = "Izquierda";
            btnIzquierda.UseVisualStyleBackColor = true;
            btnIzquierda.Click += btnIzquierda_Click;
            // 
            // btnDerecha
            // 
            btnDerecha.Location = new Point(208, 147);
            btnDerecha.Name = "btnDerecha";
            btnDerecha.Size = new Size(75, 23);
            btnDerecha.TabIndex = 2;
            btnDerecha.Text = "Derecha";
            btnDerecha.UseVisualStyleBackColor = true;
            btnDerecha.Click += btnDerecha_Click;
            // 
            // btnAbajo
            // 
            btnAbajo.Location = new Point(138, 176);
            btnAbajo.Name = "btnAbajo";
            btnAbajo.Size = new Size(75, 23);
            btnAbajo.TabIndex = 3;
            btnAbajo.Text = "Abajo";
            btnAbajo.UseVisualStyleBackColor = true;
            btnAbajo.Click += btnAbajo_Click;
            // 
            // btnCrea
            // 
            btnCrea.Location = new Point(377, 299);
            btnCrea.Name = "btnCrea";
            btnCrea.Size = new Size(75, 23);
            btnCrea.TabIndex = 4;
            btnCrea.Text = "Crea Botón";
            btnCrea.UseVisualStyleBackColor = true;
            btnCrea.Click += btnCrea_Click;
            // 
            // btnVisible
            // 
            btnVisible.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnVisible.Location = new Point(650, 309);
            btnVisible.Name = "btnVisible";
            btnVisible.Size = new Size(155, 23);
            btnVisible.TabIndex = 5;
            btnVisible.Text = "Pon no Visible";
            btnVisible.UseVisualStyleBackColor = true;
            btnVisible.Click += btnVisible_Click;
            // 
            // laBienvenido
            // 
            laBienvenido.BackColor = SystemColors.AppWorkspace;
            laBienvenido.Dock = DockStyle.Top;
            laBienvenido.Font = new Font("Segoe UI", 18F);
            laBienvenido.ForeColor = SystemColors.ActiveCaptionText;
            laBienvenido.Image = Properties.Resources.imagen;
            laBienvenido.ImageAlign = ContentAlignment.MiddleRight;
            laBienvenido.Location = new Point(0, 0);
            laBienvenido.Name = "laBienvenido";
            laBienvenido.Size = new Size(832, 44);
            laBienvenido.TabIndex = 6;
            laBienvenido.Text = "Bienvenido a la aplicación";
            laBienvenido.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveBorder;
            groupBox1.Controls.Add(btnDos);
            groupBox1.Controls.Add(btnTres);
            groupBox1.Controls.Add(btnUno);
            groupBox1.FlatStyle = FlatStyle.Popup;
            groupBox1.Location = new Point(503, 79);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(302, 100);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Prueba de Sender";
            // 
            // btnDos
            // 
            btnDos.Location = new Point(116, 48);
            btnDos.Name = "btnDos";
            btnDos.Size = new Size(75, 23);
            btnDos.TabIndex = 2;
            btnDos.Text = "Dos";
            btnDos.UseVisualStyleBackColor = true;
            btnDos.Click += btnUno_Click;
            // 
            // btnTres
            // 
            btnTres.Location = new Point(221, 48);
            btnTres.Name = "btnTres";
            btnTres.Size = new Size(75, 23);
            btnTres.TabIndex = 1;
            btnTres.Text = "Tres";
            btnTres.UseVisualStyleBackColor = true;
            btnTres.Click += btnUno_Click;
            // 
            // btnUno
            // 
            btnUno.Location = new Point(6, 48);
            btnUno.Name = "btnUno";
            btnUno.Size = new Size(75, 23);
            btnUno.TabIndex = 0;
            btnUno.Text = "Uno";
            btnUno.UseVisualStyleBackColor = true;
            btnUno.Click += btnUno_Click;
            // 
            // pnBotones
            // 
            pnBotones.BorderStyle = BorderStyle.Fixed3D;
            pnBotones.Controls.Add(btnSalir);
            pnBotones.Controls.Add(btnDisminuye);
            pnBotones.Controls.Add(btnDelante);
            pnBotones.Controls.Add(btnControlesForm);
            pnBotones.Controls.Add(btnControlesPanel);
            pnBotones.Controls.Add(btnAcercaDe);
            pnBotones.Controls.Add(btnDetras);
            pnBotones.Controls.Add(btnAumenta);
            pnBotones.Cursor = Cursors.Hand;
            pnBotones.Dock = DockStyle.Bottom;
            pnBotones.Location = new Point(0, 350);
            pnBotones.Name = "pnBotones";
            pnBotones.Size = new Size(832, 100);
            pnBotones.TabIndex = 10;
            pnBotones.Paint += pnBotones_Paint;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(378, 70);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(83, 23);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnDisminuye
            // 
            btnDisminuye.Location = new Point(168, 27);
            btnDisminuye.Name = "btnDisminuye";
            btnDisminuye.Size = new Size(75, 23);
            btnDisminuye.TabIndex = 6;
            btnDisminuye.Text = "Disminuye";
            btnDisminuye.UseVisualStyleBackColor = true;
            btnDisminuye.Click += btnDisminuye_Click;
            // 
            // btnDelante
            // 
            btnDelante.Location = new Point(272, 27);
            btnDelante.Name = "btnDelante";
            btnDelante.Size = new Size(75, 23);
            btnDelante.TabIndex = 5;
            btnDelante.Text = "Delante";
            btnDelante.UseVisualStyleBackColor = true;
            btnDelante.Click += btnDelante_Click;
            // 
            // btnControlesForm
            // 
            btnControlesForm.Location = new Point(474, 27);
            btnControlesForm.Name = "btnControlesForm";
            btnControlesForm.Size = new Size(108, 23);
            btnControlesForm.TabIndex = 4;
            btnControlesForm.Text = "ControlesForm";
            btnControlesForm.UseVisualStyleBackColor = true;
            btnControlesForm.Click += btnControles_Click;
            // 
            // btnControlesPanel
            // 
            btnControlesPanel.Location = new Point(617, 27);
            btnControlesPanel.Name = "btnControlesPanel";
            btnControlesPanel.Size = new Size(75, 23);
            btnControlesPanel.TabIndex = 3;
            btnControlesPanel.Text = "Botones Panel";
            btnControlesPanel.UseVisualStyleBackColor = true;
            btnControlesPanel.Click += btrnBotonesPanel_Click;
            // 
            // btnAcercaDe
            // 
            btnAcercaDe.Location = new Point(714, 27);
            btnAcercaDe.Name = "btnAcercaDe";
            btnAcercaDe.Size = new Size(83, 23);
            btnAcercaDe.TabIndex = 2;
            btnAcercaDe.Text = "Acerca de";
            btnAcercaDe.UseVisualStyleBackColor = true;
            // 
            // btnDetras
            // 
            btnDetras.Location = new Point(378, 27);
            btnDetras.Name = "btnDetras";
            btnDetras.Size = new Size(75, 23);
            btnDetras.TabIndex = 1;
            btnDetras.Text = "Detrás";
            btnDetras.UseVisualStyleBackColor = true;
            btnDetras.Click += btnDetras_Click;
            // 
            // btnAumenta
            // 
            btnAumenta.Location = new Point(58, 27);
            btnAumenta.Name = "btnAumenta";
            btnAumenta.Size = new Size(75, 23);
            btnAumenta.TabIndex = 0;
            btnAumenta.Text = "Aumenta";
            btnAumenta.UseVisualStyleBackColor = true;
            btnAumenta.Click += btnAumenta_Click;
            // 
            // laTamanyo
            // 
            laTamanyo.AutoSize = true;
            laTamanyo.Dock = DockStyle.Bottom;
            laTamanyo.ForeColor = SystemColors.InactiveCaptionText;
            laTamanyo.Location = new Point(0, 335);
            laTamanyo.Name = "laTamanyo";
            laTamanyo.Size = new Size(19, 15);
            laTamanyo.TabIndex = 11;
            laTamanyo.Text = "16";
            // 
            // laMover
            // 
            laMover.AutoSize = true;
            laMover.BackColor = SystemColors.ActiveCaption;
            laMover.Font = new Font("Segoe UI", 16F);
            laMover.Location = new Point(377, 139);
            laMover.Name = "laMover";
            laMover.Size = new Size(78, 30);
            laMover.TabIndex = 12;
            laMover.Text = "XXXXX";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 450);
            Controls.Add(laMover);
            Controls.Add(laTamanyo);
            Controls.Add(pnBotones);
            Controls.Add(groupBox1);
            Controls.Add(laBienvenido);
            Controls.Add(btnVisible);
            Controls.Add(btnCrea);
            Controls.Add(btnAbajo);
            Controls.Add(btnDerecha);
            Controls.Add(btnIzquierda);
            Controls.Add(btnArriba);
            Name = "Form1";
            Text = "ElFormulario";
            groupBox1.ResumeLayout(false);
            pnBotones.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnArriba;
        private Button btnIzquierda;
        private Button btnDerecha;
        private Button btnAbajo;
        private Button btnCrea;
        private Button btnVisible;
        private Label laBienvenido;
        private GroupBox groupBox1;
        private Button btnUno;
        private Button btnDos;
        private Button btnTres;
        private Panel pnBotones;
        private Button btnDisminuye;
        private Button btnDelante;
        private Button btnControlesForm;
        private Button btnControlesPanel;
        private Button btnAcercaDe;
        private Button btnDetras;
        private Button btnAumenta;
        private Label laTamanyo;
        private Label laMover;
        private Button btnSalir;
    }
}
