using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checkbox
{
    public partial class FrmCheckbox : Form
    {
        public FrmCheckbox()
        {
            InitializeComponent();
        }

        private void btnVerif_Click(object sender, EventArgs e)
        {
            if (cbEntretenimento.Checked && cbNoticias.Checked && cbTecnologia.Checked)
            {
                lblResult.Text = "Você selecionou as três opções";
            }
            else if (cbEntretenimento.Checked && cbTecnologia.Checked)
            {
                lblResult.Text = "Você selecionou Entretenimento e Tecnologia";
            }
            else if (cbEntretenimento.Checked && cbNoticias.Checked)
            {
                lblResult.Text = "você selecionou Entretenimento e Noticias";
            }
            else if (cbTecnologia.Checked && cbNoticias.Checked)
            {
                lblResult.Text = "Você selecionou Tecnologia e Noticias";
            }
            else if (cbEntretenimento.Checked)
            {
                lblResult.Text = "Você selecionou Entretenimento";
            }
            else if (cbTecnologia.Checked)
            {
                lblResult.Text = "Você selecionou Tecnologia";
            }
            else if (cbNoticias.Checked)
            {
                lblResult.Text = "Você selecionou Noticias";
            }
            else
            {
                lblResult.Text = "Você não selecionou nenhuma opção";
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
