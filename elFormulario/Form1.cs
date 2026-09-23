using System.Numerics;

namespace elFormulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnArriba_Click(object sender, EventArgs e)
        {
            if (laMover.Top <= -laMover.Height)
            {
                laMover.Top = Height - 44;
            }

            laMover.Top -= 2;
        }

        private void btnDerecha_Click(object sender, EventArgs e)
        {
            if (laMover.Left >= Width)
            {
                laMover.Left = -laMover.Width;
            }

            laMover.Left += 2;
        }

        private void btnAbajo_Click(object sender, EventArgs e)
        {
            if (laMover.Top <= laMover.Height)
            {
                laMover.Top = -laMover.Height;
            }

            laMover.Top += 2;
        }

        private void btnIzquierda_Click(object sender, EventArgs e)
        {
            if (laMover.Right <= -laMover.Width)
            {
                laMover.Left = Width - 44;
            }
            laMover.Left -= 2;
        }

        private void pnBotones_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnVisible_Click(object sender, EventArgs e)
        {
            pnBotones.Visible = !pnBotones.Visible;
            if (pnBotones.Visible)
            {
                btnVisible.Text = "Pon No Visible";
                btnVisible.ForeColor = Color.Green;
            }
            else
            {
                btnVisible.Text = "Pon Visible";
                btnVisible.ForeColor = Color.Red;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Adios");
            this.Close();
        }

        private void btnAumenta_Click(object sender, EventArgs e)
        {
            float fAumenta = laMover.Font.Size;
            fAumenta++;

            if (fAumenta <= 100)
            {
                laTamanyo.Text = Convert.ToString(fAumenta);

                btnAumenta.Text = "Suma: " + Convert.ToString(fAumenta);

                btnDisminuye.Text = "Resta: " + Convert.ToString(fAumenta);

                laMover.Font = new Font("", fAumenta, FontStyle.Regular, GraphicsUnit.Point);
            }
        }

        private void btnDisminuye_Click(object sender, EventArgs e)
        {
            float fDisminuye = laMover.Font.Size;
            fDisminuye--;

            if (fDisminuye >= 10)
            {
                laTamanyo.Text = Convert.ToString(fDisminuye);

                btnAumenta.Text = "Suma: " + Convert.ToString(fDisminuye);

                btnDisminuye.Text = "Resta: " + Convert.ToString(fDisminuye);

                laMover.Font = new Font("", fDisminuye, FontStyle.Regular, GraphicsUnit.Point);
            }
        }

        private void btnDelante_Click(object sender, EventArgs e)
        {
            laMover.BringToFront();
        }

        private void btnDetras_Click(object sender, EventArgs e)
        {
            laMover.SendToBack();
        }

        private void btnControles_Click(object sender, EventArgs e)
        {
            foreach (Control micontrol in Controls)
            {
                if (micontrol is Button)
                {
                    micontrol.ForeColor = Color.Red;
                }

                MessageBox.Show(micontrol.Name);
            }
            MessageBox.Show("Total Controles en el Formulario: " + Controls.Count);
        }

        private void btrnBotonesPanel_Click(object sender, EventArgs e)
        {
            foreach (Control panelControl in pnBotones.Controls)
            {
                if (panelControl is Button)
                {
                    panelControl.ForeColor = Color.Green;
                }
                MessageBox.Show(panelControl.Name);
            }
            MessageBox.Show("Total Controles en el Panel: " + pnBotones.Controls.Count);
        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            if (sender == btnUno)
            {
                MessageBox.Show("es el uno");
            }
            if (sender == btnDos)
            {
                MessageBox.Show("es el dos");
            }
            if (sender == btnTres)
            {
                MessageBox.Show("es el tres");
            }

            (sender as Button).BackColor = Color.Red;
            Button miBoton = (Button)sender;
            MessageBox.Show("Es el boton" + miBoton.Text);
        }

        private void btnCrea_Click(object sender, EventArgs e)
        {
            Button miboton = new Button();
            miboton.Text = "Mi botón";
            miboton.Size = new System.Drawing.Size(100, 25);
            miboton.Location = new System.Drawing.Point(470, 300);
            miboton.Parent = this;
            miboton.TabIndex = 25;
            miboton.UseVisualStyleBackColor = true;
            miboton.Click += new System.EventHandler(miboton_Click);

            btnCrea.Enabled = false;
        }

        private void miboton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click del Nuevo Botón Creado");
        }
    }
}
