using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppPracticaArrays
{
    public partial class Form1 : Form
    {
        private int cont = 0;
        private const int MAX= 100;
        private double[] vector = new double[MAX];


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try {
                if (cont < MAX)
                {
                    vector[cont] = int.Parse(this.txtNumero.Text);
                    llenarlista();
                    MessageBox.Show("Elemento agregado");
                }
                cont++;
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());            
            }
        }
        private void llenarlista()
        {
            // agregar elemento al listbox
            this.lstNum.Items.Clear();
            for (int i = 0; i <= cont; i++)
            {
                this.lstNum.Items.Add(vector[i]);
            }
        }
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            this.txtSuma.Text = sumatoria().ToString();
            this.txtPromedio.Text = promedio().ToString();
        }

        private double sumatoria()
        {
            double suma = 0;
            for (int i = 0; i < cont; i++)
            {
                suma = suma + vector[i];
            }
            return suma;
        }
        private double promedio()
        {
            return (sumatoria() / cont);
        }

    }
}
