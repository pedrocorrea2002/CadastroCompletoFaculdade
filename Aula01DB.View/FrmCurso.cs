using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aula01DB.View.Control;
using Aula01DB.Model;

namespace Aula01DB.View
{
    public partial class FrmCurso : Form
    {
        private CCurso _Control;
        private Curso oCurso;

        public FrmCurso()
        {
            InitializeComponent();
            _Control = new CCurso();
        }

        private void CarregaGrid()
        {
            GrdItens.AutoGenerateColumns = false;
            GrdItens.DataSource = _Control.TodosCursos();
        }

        private void FrmCurso_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Control.Dispose();
        }

        private void FrmCurso_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        public void LimparControles()
        {
            TxtCodigoCurso.Text = "";
            TxtNome.Text = "";
        }

        private bool VerificaControles()
        {
            if (TxtNome.Text == "")
            {
                MessageBox.Show("Preencha o conteúdo do campo Nome", ProductName, MessageBoxButtons.OK);
                TxtNome.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (VerificaControles())
            {
                if (TxtCodigoCurso.Text.Trim() == "")
                {
                    Curso oCurso = new Curso();
                    oCurso.Nome = TxtNome.Text;

                    _Control.Incluir(oCurso);
                    CarregaGrid();
                    LimparControles();
                    MessageBox.Show("Registro incluído com sucesso", ProductName, MessageBoxButtons.OK);
                }
                else
                {
                    oCurso.Nome = TxtNome.Text;
                    _Control.Alterar(oCurso);
                    CarregaGrid();
                    LimparControles();
                    MessageBox.Show("Registro alterado com sucesso", ProductName, MessageBoxButtons.OK);
                }
            }
        }

        private void GrdItens_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(GrdItens.Rows[e.RowIndex].DataBoundItem != null)
            {
                if(GrdItens.Columns[e.ColumnIndex].Name == "Alterar")
                {
                    oCurso = (Curso)GrdItens.Rows[e.RowIndex].DataBoundItem;
                    TxtCodigoCurso.Text = oCurso.CodigoCurso.ToString();
                    TxtNome.Text = oCurso.Nome;
                    TxtNome.Focus();
                }
                else if (GrdItens.Columns[e.ColumnIndex].Name == "Excluir")
                {
                    if(MessageBox.Show("Deseja realmente excluir esse registro?", ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        oCurso = (Curso)GrdItens.Rows[e.RowIndex].DataBoundItem;
                        _Control.Excluir(oCurso);
                        CarregaGrid();
                    }
                }
            }
        }
    }
}
