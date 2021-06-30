using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula01DB.View
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            MenuAluno.Click += MenuAluno_Click;
            MenuCurso.Click += MenuCurso_Click;
            MenuTurma.Click += MenuTurma_Click;
        }

        private void MenuAluno_Click(object sender, EventArgs e)
        {
            FrmAluno oFrmAluno = new FrmAluno();
            oFrmAluno.MdiParent = this;
            oFrmAluno.Show();
        }

        private void MenuCurso_Click(object sender, EventArgs e)
        {
            FrmCurso oFrmCurso = new FrmCurso();
            oFrmCurso.MdiParent = this;
            oFrmCurso.Show();
        }

        private void MenuTurma_Click(object sender, EventArgs e)
        {
            FrmTurma oFrmTurma = new FrmTurma();
            oFrmTurma.MdiParent = this;
            oFrmTurma.Show();
        }

    }
}
