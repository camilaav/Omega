using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Omega
{
    public partial class Suma : Form
    {
        public Suma()
        {
            InitializeComponent();
        }
        void CargarFuentes()
        {
            lblNumero1.Font = new Font("Patchwork Stitchlings", lblNumero1.Font.Size);
            lblNumero2.Font = new Font("Patchwork Stitchlings", lblNumero2.Font.Size);
            lblRespuesta.Font = new Font("Patchwork Stitchlings", lblRespuesta.Font.Size);
            lblOp1.Font = new Font("Patchwork Stitchlings", lblOp1.Font.Size);
            lblOp2.Font = new Font("Patchwork Stitchlings", lblOp2.Font.Size);
            lblOp3.Font = new Font("Patchwork Stitchlings", lblOp3.Font.Size);
            lblMas.Font = new Font("Patchwork Stitchlings", lblMas.Font.Size);
            lblIgual.Font = new Font("Patchwork Stitchlings", lblIgual.Font.Size);
            lblP.Font = new Font("Patchwork Stitchlings", lblP.Font.Size);
            lblPuntaje.Font = new Font("Patchwork Stitchlings", lblPuntaje.Font.Size);
        }
        int num1, num2, rpt, op1, op2, orden, intentos, seg = 0;
        Random rdm = new Random();
        void NumerosRandom()
        {
            lblRespuesta.Visible = false;
            num1 = rdm.Next(1, 11);
            num2 = rdm.Next(1, 11);
            rpt = num1 + num2;
            op1 = rdm.Next(1, 11);
            op2 = rdm.Next(1, 11);
            orden = rdm.Next(1, 4);
            if (rpt < 11 && rpt != op1 && rpt != op2 && op1 != op2)
            {
                if (orden == 1)
                {
                    lblNumero1.Text = num1.ToString();
                    lblNumero2.Text = num2.ToString();
                    lblOp1.Text = rpt.ToString();
                    lblOp2.Text = op1.ToString();
                    lblOp3.Text = op2.ToString();
                }
                else if (orden == 2)
                {
                    lblNumero1.Text = num1.ToString();
                    lblNumero2.Text = num2.ToString();
                    lblOp1.Text = op1.ToString();
                    lblOp2.Text = rpt.ToString();
                    lblOp3.Text = op2.ToString();
                }
                else if (orden == 3)
                {
                    lblNumero1.Text = num1.ToString();
                    lblNumero2.Text = num2.ToString();
                    lblOp1.Text = op1.ToString();
                    lblOp2.Text = op2.ToString();
                    lblOp3.Text = rpt.ToString();
                }
            }
            else
            {
                NumerosRandom();
            }
        }
        private void LblOp1_Click(object sender, EventArgs e)
        {
            if (rpt == int.Parse(lblOp1.Text))
            {
                RespuestaCorrecta();
            }
            else
            {
                RespuestaIncorrecta();
            }
        }
        private void LblOp2_Click(object sender, EventArgs e)
        {
            if (rpt == int.Parse(lblOp2.Text))
            {
                RespuestaCorrecta();
            }
            {
                RespuestaIncorrecta();
            }
        }
        private void LblOp3_Click(object sender, EventArgs e)
        {
            if (rpt == int.Parse(lblOp3.Text))
            {
                RespuestaCorrecta();
            }
            else
            {
                RespuestaIncorrecta();
            }
        }
        void RespuestaCorrecta()
        {
            lblRespuesta.Text = rpt.ToString();
            lblRespuesta.Visible = true;
            tiempo.Stop();
            MessageBox.Show("bien");
            if (intentos == 0)
            {
                lblPuntaje.Text = (int.Parse(lblPuntaje.Text) + 100).ToString();
                intentos = 0;
            }
            else if (intentos == 1)
            {
                lblPuntaje.Text = (int.Parse(lblPuntaje.Text) + 50).ToString();
                intentos = 0;
            }
            else if (intentos == 2)
            {
                lblPuntaje.Text = (int.Parse(lblPuntaje.Text) + 25).ToString();
                intentos = 0;
            }
            else if (intentos >= 3)
            {
                lblPuntaje.Text = (int.Parse(lblPuntaje.Text) + 0).ToString();
                intentos = 0;
            }
            NumerosRandom();
        }
        void RespuestaIncorrecta()
        {
            lblRespuesta.Text = "X";
            lblRespuesta.Visible = true;
            seg = 3;
            tiempo.Start();
            intentos++;
        }
        private void tiempo_Tick(object sender, EventArgs e)
        {
            seg -= 1;
            if (seg == 0)
            {
                tiempo.Stop();
                lblRespuesta.Visible = false;
            }
        }
        private void Suma_Load(object sender, EventArgs e)
        {
            CargarFuentes();
            NumerosRandom();
        }
    }
}
