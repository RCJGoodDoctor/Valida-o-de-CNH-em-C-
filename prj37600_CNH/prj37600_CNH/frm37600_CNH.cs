using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prj37600_CNH
{
    public partial class frm37600_CNH : Form
    {
        public frm37600_CNH()
        {
            InitializeComponent();
        }
        #region FormClosing
        private void frm37600_CNH_FormClosing(object sender, FormClosingEventArgs e)
        {

            if(MessageBox.Show("Deseja Sair","Sair?",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        #endregion

        #region Button Validar
        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(mtbCNH.Text))
            {
                MessageBox.Show("CNH Não pode ser vazio", "erro");
            }
            if(mtbCNH.Text.Length < 11)
            {
                MessageBox.Show("Digite 11 digitos", "erro");
            }
            if (ClsCNH.ValidarCNH(mtbCNH.Text))
            {
                lblSituacao.Text = "Válido";
                lblSituacao.ForeColor = Color.Green;
            }
            else
            {
                lblSituacao.Text = "Inválido";
                lblSituacao.ForeColor = Color.Red;
            }
        }
        #endregion
    }
}
