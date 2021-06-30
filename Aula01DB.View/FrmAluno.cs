using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aula01DB.Model;
using Aula01DB.View.Control;

namespace Aula01DB.View
{
    public partial class FrmAluno : Form
    {
        private CAluno _Control = new CAluno();
        private bool Incluir = false;
        private Aluno oAluno;

        public FrmAluno()
        {
            InitializeComponent();
        }

        private bool ValidarControles()
        {
            if (TxtNome.Text.Trim() == "")
            {
                MessageBox.Show("Preencha o conteúdo do campo Nome", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtNome.Focus();
                return false;
            }
            return true;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidarControles())
            {
                if (Incluir)
                {
                    oAluno = new Aluno();
                    oAluno.Matricula = TxtMatricula.Text;
                    oAluno.Nome = TxtNome.Text;
                    _Control.Incluir(oAluno);
                    BtnExcluir.Enabled = true;
                    MessageBox.Show("Registro incluído com sucesso");
                    BtnCancelar_Click(sender, e);
                }
                else
                {
                    oAluno.Nome = TxtNome.Text;
                    _Control.Alterar(oAluno);
                    MessageBox.Show("Registro alterado com sucesso");
                    BtnCancelar_Click(sender, e);
                }
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluir o aluno?", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _Control.Excluir(oAluno);
                BtnCancelar_Click(sender, e);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TxtMatricula.Text = "";
            TxtNome.Text = "";
            BtnExcluir.Enabled = false;
            BtnSalvar.Enabled = false;
            TxtMatricula.Enabled = true;
            TxtMatricula.Focus();
        }

        private void TxtMatricula_Leave(object sender, EventArgs e)
        {
            if (TxtMatricula.Text.Trim() != "")
            {
                //SE HOUVER O ALUNO É UMA ALTERAÇÃO, SE NÃO É UMA INCLUSÃO

                oAluno = _Control.SelecionarAluno(TxtMatricula.Text);
                TxtMatricula.Enabled = false;

                BtnSalvar.Enabled = true;

                if (oAluno == null)
                {
                    //INCLUIR
                    Incluir = true;
                    BtnExcluir.Enabled = false;
                }
                else
                {
                    //ALTERAÇÃO
                    Incluir = false;
                    BtnExcluir.Enabled = true;
                    TxtNome.Text = oAluno.Nome;
                    TxtNome.Focus();
                }

            }
            else
            {
                BtnSalvar.Enabled = false;
                BtnExcluir.Enabled = false;
            }
        }
    }
}
