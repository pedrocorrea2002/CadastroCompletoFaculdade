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
    public partial class FrmTurma : Form
    {
        private CTurma _Control = new CTurma();

        public FrmTurma()
        {
            InitializeComponent();
        }

        public void CarregaGrid()
        {
            GrdItems.AutoGenerateColumns = false;
            if (TxtCodigoTurma.Text.Trim() == "")
            {
                GrdItems.DataSource = null;
            }
            else
            {
                GrdItems.DataSource = _Control.SelecionarAlunosTurma(int.Parse(TxtCodigoTurma.Text));
            }
        }

        private void CarregaCombos()
        {
            CboCurso.ValueMember = "CodigoCurso";
            CboCurso.DisplayMember = "Nome";
            CboCurso.DataSource = _Control.SelecionarTodosCursos();

            for (int i = 1999; i <= _Control.DataHora().Year; i++)
            {
                CboAno.Items.Add(i.ToString());
            }
            CboAno.SelectedIndex = CboAno.Items.Count - 1;

            CboAluno.ValueMember = "Matricula";
            CboAluno.DisplayMember = "Nome";
            CboAluno.DataSource = _Control.SelecionarTodosAlunos();
        }


        private void FrmTurma_Load(object sender, EventArgs e)
        {
            CarregaCombos();
            CarregaGrid();
        }

        private void TxtMatricula_TextChanged(object sender, EventArgs e)
        {
            if(TxtMatricula.Text == "")
            {
                CboAluno.SelectedIndex = -1;
            }
            else
            {
                CboAluno.SelectedValue = TxtMatricula.Text;
            }
        }

        private bool ValidarControles()
        {
            if(CboCurso.SelectedValue == "" || CboSemestre.SelectedValue == "" || CboAno.SelectedValue == "" || CboAluno.SelectedValue == "" )
            {
                MessageBox.Show("Existe algum valor em branco ou o aluno selecionado não existe", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidarControles())
            {
                if (TxtCodigoTurma.Text.Trim() == "")
                {
                    try
                    {
                        Turma oTurma = new Turma();

                        oTurma.CodigoCurso = (int)CboCurso.SelectedValue;
                        oTurma.Semestre = int.Parse(CboSemestre.Text);
                        oTurma.Ano = int.Parse(CboAno.Text);

                        TurmaAluno oTurmaAluno = new TurmaAluno();
                        oTurmaAluno.MatriculaAluno = TxtMatricula.Text;
                        oTurmaAluno.DataEntrada = DateTime.Now;

                        oTurma.TurmaAluno.Add(oTurmaAluno);

                        oTurma = _Control.IncluirTurma(oTurma);
                        TxtCodigoTurma.Text = oTurma.CodigoTurma.ToString();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(MyGlobal.MontaMensagemErro(ex), ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    try
                    {
                        TurmaAluno oTurmaAluno = new TurmaAluno();
                        oTurmaAluno.MatriculaAluno = TxtMatricula.Text;
                        oTurmaAluno.CodigoTurma = int.Parse(TxtCodigoTurma.Text);
                        oTurmaAluno.DataEntrada = DateTime.Now;
                        _Control.IncluirAlunoTurma(oTurmaAluno);
                        TxtMatricula.Text = "";
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(MyGlobal.MontaMensagemErro(ex), ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                CarregaGrid();
            }
        }

        private void CboAluno_SelectedIndexChanged(object sender, EventArgs e)
        {

            if(CboAluno.SelectedValue != null)
            {
                TxtMatricula.Text = CboAluno.SelectedValue.ToString();
            }
            else
            {

            }
        }

        private void TxtCodigoTurma_Leave(object sender, EventArgs e)
        {
            if (TxtCodigoTurma.Text.Trim() == "")
            {

            }
            else
            {
                try { 
                    Turma oTurma = _Control.SelecionarTurma(int.Parse(TxtCodigoTurma.Text));

                    if (oTurma == null)
                    {

                    }
                    else
                    {
                        CboCurso.SelectedValue = oTurma.CodigoCurso;
                        CboSemestre.SelectedValue = oTurma.Semestre;
                        CboAno.SelectedValue = oTurma.Ano;
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(MyGlobal.MontaMensagemErro(ex), ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            CarregaGrid();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            TxtCodigoTurma.Text = "";
            TxtCodigoTurma.Focus();
            CboSemestre.SelectedIndex = -1;
            CboAno.SelectedIndex = -1;
            CboCurso.SelectedIndex = -1;
            TxtMatricula.Text = "";

            CarregaGrid();
        }

        private void GrdItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GrdItems.Rows[e.RowIndex].DataBoundItem != null)
            {
                if (GrdItems.Columns[e.ColumnIndex].Name == "btnExcluirAluno")
                {
                    if(MessageBox.Show("Se excluir, será impossível recuperar o registro. Deseja continuar?",ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            VwTurmaAluno oVwTurmaAluno = (VwTurmaAluno)GrdItems.Rows[e.RowIndex].DataBoundItem;
                            TurmaAluno oTurmaAluno = new TurmaAluno();
                            oTurmaAluno.CodigoTurma = oVwTurmaAluno.CodigoTurma;
                            oTurmaAluno.MatriculaAluno = oVwTurmaAluno.MatriculaAluno;
                            _Control.RemoverAlunoTurma(oTurmaAluno);
                            CarregaGrid();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(MyGlobal.MontaMensagemErro(ex), ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
    }
}
