
namespace Aula01DB.View
{
    partial class FrmTurma
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTurma));
            this.LblCodigoTurma = new System.Windows.Forms.Label();
            this.TxtCodigoTurma = new System.Windows.Forms.TextBox();
            this.LblCurso = new System.Windows.Forms.Label();
            this.CboCurso = new System.Windows.Forms.ComboBox();
            this.LblSemestre = new System.Windows.Forms.Label();
            this.CboSemestre = new System.Windows.Forms.ComboBox();
            this.CboAno = new System.Windows.Forms.ComboBox();
            this.LblAno = new System.Windows.Forms.Label();
            this.GrdItems = new System.Windows.Forms.DataGridView();
            this.MatriculaAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExcluirAluno = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TxtAluno = new System.Windows.Forms.Label();
            this.TxtMatricula = new System.Windows.Forms.TextBox();
            this.CboAluno = new System.Windows.Forms.ComboBox();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GrdItems)).BeginInit();
            this.SuspendLayout();
            // 
            // LblCodigoTurma
            // 
            resources.ApplyResources(this.LblCodigoTurma, "LblCodigoTurma");
            this.LblCodigoTurma.Name = "LblCodigoTurma";
            // 
            // TxtCodigoTurma
            // 
            resources.ApplyResources(this.TxtCodigoTurma, "TxtCodigoTurma");
            this.TxtCodigoTurma.Name = "TxtCodigoTurma";
            this.TxtCodigoTurma.Leave += new System.EventHandler(this.TxtCodigoTurma_Leave);
            // 
            // LblCurso
            // 
            resources.ApplyResources(this.LblCurso, "LblCurso");
            this.LblCurso.Name = "LblCurso";
            // 
            // CboCurso
            // 
            this.CboCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboCurso.FormattingEnabled = true;
            resources.ApplyResources(this.CboCurso, "CboCurso");
            this.CboCurso.Name = "CboCurso";
            // 
            // LblSemestre
            // 
            resources.ApplyResources(this.LblSemestre, "LblSemestre");
            this.LblSemestre.Name = "LblSemestre";
            // 
            // CboSemestre
            // 
            this.CboSemestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboSemestre.FormattingEnabled = true;
            this.CboSemestre.Items.AddRange(new object[] {
            resources.GetString("CboSemestre.Items"),
            resources.GetString("CboSemestre.Items1"),
            resources.GetString("CboSemestre.Items2"),
            resources.GetString("CboSemestre.Items3"),
            resources.GetString("CboSemestre.Items4"),
            resources.GetString("CboSemestre.Items5"),
            resources.GetString("CboSemestre.Items6"),
            resources.GetString("CboSemestre.Items7"),
            resources.GetString("CboSemestre.Items8"),
            resources.GetString("CboSemestre.Items9")});
            resources.ApplyResources(this.CboSemestre, "CboSemestre");
            this.CboSemestre.Name = "CboSemestre";
            // 
            // CboAno
            // 
            this.CboAno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboAno.FormattingEnabled = true;
            resources.ApplyResources(this.CboAno, "CboAno");
            this.CboAno.Name = "CboAno";
            // 
            // LblAno
            // 
            resources.ApplyResources(this.LblAno, "LblAno");
            this.LblAno.Name = "LblAno";
            // 
            // GrdItems
            // 
            resources.ApplyResources(this.GrdItems, "GrdItems");
            this.GrdItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MatriculaAluno,
            this.Nome,
            this.DataEntrada,
            this.btnExcluirAluno});
            this.GrdItems.Name = "GrdItems";
            this.GrdItems.RowTemplate.Height = 25;
            this.GrdItems.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdItems_CellClick);
            // 
            // MatriculaAluno
            // 
            this.MatriculaAluno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MatriculaAluno.DataPropertyName = "MatriculaAluno";
            this.MatriculaAluno.FillWeight = 50F;
            resources.ApplyResources(this.MatriculaAluno, "MatriculaAluno");
            this.MatriculaAluno.Name = "MatriculaAluno";
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nome.DataPropertyName = "Nome";
            this.Nome.FillWeight = 200F;
            resources.ApplyResources(this.Nome, "Nome");
            this.Nome.Name = "Nome";
            // 
            // DataEntrada
            // 
            this.DataEntrada.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataEntrada.DataPropertyName = "DataEntrada";
            this.DataEntrada.FillWeight = 50F;
            resources.ApplyResources(this.DataEntrada, "DataEntrada");
            this.DataEntrada.Name = "DataEntrada";
            // 
            // btnExcluirAluno
            // 
            this.btnExcluirAluno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.btnExcluirAluno.FillWeight = 50F;
            resources.ApplyResources(this.btnExcluirAluno, "btnExcluirAluno");
            this.btnExcluirAluno.Name = "btnExcluirAluno";
            // 
            // TxtAluno
            // 
            resources.ApplyResources(this.TxtAluno, "TxtAluno");
            this.TxtAluno.Name = "TxtAluno";
            // 
            // TxtMatricula
            // 
            resources.ApplyResources(this.TxtMatricula, "TxtMatricula");
            this.TxtMatricula.Name = "TxtMatricula";
            this.TxtMatricula.TextChanged += new System.EventHandler(this.TxtMatricula_TextChanged);
            // 
            // CboAluno
            // 
            this.CboAluno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboAluno.FormattingEnabled = true;
            resources.ApplyResources(this.CboAluno, "CboAluno");
            this.CboAluno.Name = "CboAluno";
            this.CboAluno.SelectedIndexChanged += new System.EventHandler(this.CboAluno_SelectedIndexChanged);
            // 
            // BtnSalvar
            // 
            resources.ApplyResources(this.BtnSalvar, "BtnSalvar");
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // BtnLimpar
            // 
            resources.ApplyResources(this.BtnLimpar, "BtnLimpar");
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // FrmTurma
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.CboAluno);
            this.Controls.Add(this.TxtMatricula);
            this.Controls.Add(this.TxtAluno);
            this.Controls.Add(this.GrdItems);
            this.Controls.Add(this.CboAno);
            this.Controls.Add(this.LblAno);
            this.Controls.Add(this.CboSemestre);
            this.Controls.Add(this.LblSemestre);
            this.Controls.Add(this.CboCurso);
            this.Controls.Add(this.LblCurso);
            this.Controls.Add(this.TxtCodigoTurma);
            this.Controls.Add(this.LblCodigoTurma);
            this.Name = "FrmTurma";
            this.TransparencyKey = System.Drawing.Color.Maroon;
            this.Load += new System.EventHandler(this.FrmTurma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCodigoTurma;
        private System.Windows.Forms.TextBox TxtCodigoTurma;
        private System.Windows.Forms.Label LblCurso;
        private System.Windows.Forms.ComboBox CboCurso;
        private System.Windows.Forms.Label LblSemestre;
        private System.Windows.Forms.ComboBox CboSemestre;
        private System.Windows.Forms.ComboBox CboAno;
        private System.Windows.Forms.Label LblAno;
        private System.Windows.Forms.DataGridView GrdItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatriculaAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataEntrada;
        private System.Windows.Forms.DataGridViewButtonColumn btnExcluirAluno;
        private System.Windows.Forms.Label TxtAluno;
        private System.Windows.Forms.TextBox TxtMatricula;
        private System.Windows.Forms.ComboBox CboAluno;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button BtnLimpar;
    }
}