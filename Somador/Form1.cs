using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Somador
{
    public partial class Form1 : Form
    {
        private float SomaTotal, SomaMarcados;
        public Form1()
        {
            InitializeComponent();

            lSomaTotal.ResetText();
            lSomaMarcados.ResetText();
            lErro.ResetText();
        }
        private void bSomar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstValores.Items.Count; i++)
            {
                try
                {
                    float v = float.Parse(lstValores.Items[i].ToString());
                    if (lstValores.GetItemChecked(i))
                    {
                        SomaMarcados += v;
                    }

                    SomaTotal += v;
                } catch
                {
                    //lstValores.Items.Clear();
                    lErro.Text = $"O valor '{lstValores.Items[i]}' não é um número válido";
                    lstValores.SetSelected(i, true);
                    return;
                }
            }

            lSomaTotal.Text = "A soma total dos valores é " + SomaTotal;
            if (SomaMarcados != 0)
            {
                lSomaMarcados.Text = "A soma sem os valores marcados é " + (SomaTotal - SomaMarcados);
            }

            SomaTotal = 0;
            SomaMarcados = 0;
        }

        private void bRemover_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstValores.Items.Count; i++)
            {
                if (lstValores.GetSelected(i))
                {
                    lstValores.Items.RemoveAt(i);
                    break;
                }
            }
        }

        private void bAdicionar_Click(object sender, EventArgs e)
        {
            lstValores.Items.Add(tValor.Text);
            tValor.ResetText();
            tValor.Focus();
        }
    }
}
