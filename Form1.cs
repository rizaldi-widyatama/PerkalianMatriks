using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //button1.Text = $"Hello {float.Parse(A1.Text)}" ;
            float num = float.Parse(A1.Text) * float.Parse(B1.Text);
            C1.Text = num.ToString();

            float[,] matrixA = new float[3,3];
            float[,] matrixB = new float[3, 3];
            float[,] matrixC = new float[3, 3];
            matrixA[0, 0] = float.Parse(A1.Text);
            matrixA[0, 1] = float.Parse(A2.Text);
            matrixA[0, 2] = float.Parse(A3.Text);
            matrixA[1, 0] = float.Parse(A4.Text);
            matrixA[1, 1] = float.Parse(A5.Text);
            matrixA[1, 2] = float.Parse(A6.Text);
            matrixA[2, 0] = float.Parse(A7.Text);
            matrixA[2, 1] = float.Parse(A8.Text);
            matrixA[2, 2] = float.Parse(A9.Text);

            matrixB[0, 0] = float.Parse(B1.Text);
            matrixB[0, 1] = float.Parse(B2.Text);
            matrixB[0, 2] = float.Parse(B3.Text);
            matrixB[1, 0] = float.Parse(B4.Text);
            matrixB[1, 1] = float.Parse(B5.Text);
            matrixB[1, 2] = float.Parse(B6.Text);
            matrixB[2, 0] = float.Parse(B7.Text);
            matrixB[2, 1] = float.Parse(B8.Text);
            matrixB[2, 2] = float.Parse(B9.Text);

            for(int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    matrixC[x, y] = 0; // Inisialisasi elemen matrixC
                    for (int k = 0; k < 3; k++) // Loop untuk melakukan perkalian
                    {
                        matrixC[x, y] += matrixA[x, k] * matrixB[k, y];
                    }
                }
            }

            C1.Text = matrixC[0, 0].ToString();
            C2.Text = matrixC[0, 1].ToString();
            C3.Text = matrixC[0, 2].ToString();
            C4.Text = matrixC[1, 0].ToString();
            C5.Text = matrixC[1, 1].ToString();
            C6.Text = matrixC[1, 2].ToString();
            C7.Text = matrixC[2, 0].ToString();
            C8.Text = matrixC[2, 1].ToString();
            C9.Text = matrixC[2, 2].ToString();
            //float kali = matrixA[0,0] * matrixB[0,0];
            //C1.Text = kali.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
