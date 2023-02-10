using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba2
{
    public partial class Invercion : Form
    {
        public Invercion()
        {
            InitializeComponent();
        }

        private void Invercion_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte fila;
            byte columna;
            double b, aux;
            double IngI,Ing;

            if (maskedTextBox1.Text == "")
            {
                MessageBox.Show("No se aceptan espacios, digite un ingreso inicial");
                maskedTextBox1.Focus();
            }
            else if (comboBox1.Text == " ")
            {
                MessageBox.Show("No se aceptan espacios, digite un plazo");
                comboBox1.Focus();
            }
            else if (maskedTextBox2.Text == "")
            {
                MessageBox.Show("No se aceptan espacios, digite su salario mensual");
                maskedTextBox2.Focus();
            }
            else
            {
                if (comboBox1.Text == "1 - 3")
                {
                    IngI = Convert.ToDouble(maskedTextBox1.Text);
                    Ing= Convert.ToDouble(maskedTextBox2.Text);
                    fila = 5; columna = 4;
                    data.ColumnCount = columna;
                    data.RowCount = fila;

                    for (int i = 0; i < data.ColumnCount; i++)
                    {
                            data[i, 0].Value = "Año " + (i);
                    }
                    data[0, 1].Value = IngI;

                    for (int i = 1; i < data.ColumnCount; i++)
                    {
                        for (int j = 1; j < data.RowCount; j++)
                        {

                            data[i, 2].Value = Ing;
                            Ing =Ing+ (Ing * 0.10);

                        }
                    }
                    IngI = IngI * 0.10;
                }

            }
        }
    }
}
