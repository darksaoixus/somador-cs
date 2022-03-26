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
    public partial class Somador : Form
    {
        private float SomaTotal, SomaMarcados;
        public Somador()
        {
            InitializeComponent();
        }
        private void bSomar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstValores.Items.Count; i++)
            {
                float v = float.Parse(lstValores.Items[i].ToString());
                if (lstValores.GetItemChecked(i))
                    SomaMarcados += v;

                SomaTotal += v;
            }

            lSomaTotal.Text = "A soma total dos valores é " + SomaTotal;
            if (SomaMarcados != 0)
                lSomaMarcados.Text = "A soma sem os valores marcados é " + (SomaTotal - SomaMarcados);

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

        private void tValor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                bAdicionar_Click(sender, e);
        }

        private void Somador_Load(object sender, EventArgs e)
        {
            lSomaTotal.ResetText();
            lSomaMarcados.ResetText();

            tValor.ResetText();
        }

        private void bAdicionar_Click(object sender, EventArgs e)
        {
            if (tValor.Text != string.Empty)
                lstValores.Items.Add(tValor.Text);

            tValor.ResetText();
            tValor.Focus();
        }
    }
}
