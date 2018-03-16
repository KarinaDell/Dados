using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dados_Karina
{
    public partial class Form1 : Form
    {

        Dado dado = new Dado();
        Dado dado2 = new Dado();
        int[] caras;
        int[] caras2;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLanzar1_Click(object sender, EventArgs e)
        {
            dado.lanzar();
            txtResultado.Text += dado.Lado.ToString() + Environment.NewLine;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();
        }

        private void btnLanzar100_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();
            cienLanzamientos();
            mostrarCien();
        }

        public void cienLanzamientos()
        {
            caras = new int[6];
            for (int i = 0; i < 100; i++)
            {
                dado.lanzar();
                caras[dado.Lado - 1]++;
            }
        }

        public void mostrarCien()
        {
            for (int i = 0; i < 6; i++)
            {
                txtResultado.Text += (i + 1) + ": " + caras[i] + Environment.NewLine;
            }
        }
       

        private void btn2Dados_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();
            sumaDados();
            mostrarSuma();
        }

        public void sumaDados()
        {
            caras2 = new int[11];
            for (int i = 0; i < 100; i++)
            {
                int d = dado.lanzar() + dado2.lanzar();
                caras2[d - 2]++;
            }

        }

        public void mostrarSuma()
        {
            for (int i = 0; i < 11; i++)
            {
                txtResultado.Text += (i + 2) + ": " + caras2[i] + Environment.NewLine;
            }
        }

        private void btnLanzar200_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();
            dosCienLanzamientos();
            mostrarDosCien();
        }

        public void dosCienLanzamientos()
        {
            caras = new int[6];
            for (int i = 0; i < 200; i++)
            {
                dado.lanzar();
                caras[dado.Lado - 1]++;
            }
        }

        public void mostrarDosCien()
        {
            for (int i = 0; i < 6; i++)
            {
                txtResultado.Text += (i + 1) + ": " + caras[i] + Environment.NewLine;
            }
        }
    }
}
