using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Cronometro
{
    public partial class Cronometro : Form
    {
        private Stopwatch stopwatch;
        public Cronometro()
        {
            InitializeComponent();
        }

       
        private void Cronometro_Load(object sender, EventArgs e)
        {
            stopwatch = new Stopwatch();
        }

       

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label.Text = String.Format("{0:hh\\:mm\\:ss\\:fff}", stopwatch.Elapsed);
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desejas sair da aplicação?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            Application.Exit();
        }

        private void Btn_Iniciar_Click(object sender, EventArgs e)
        {
            stopwatch.Start();
        }

        private void Btn_Parar_Click(object sender, EventArgs e)
        {
            stopwatch.Stop();
        }

        private void Btn_Zerar_Click(object sender, EventArgs e)
        {
            stopwatch.Reset();
        }

       

       
    }
}
