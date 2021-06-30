namespace Aula01DB.View
{
    partial class FrmCurso
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtCodigoCurso = new System.Windows.Forms.TextBox();
            this.LblCodigoCurso = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.LblNome = new System.Windows.Forms.Label();
            this.GrdItens = new System.Windows.Forms.DataGridView();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.CodigoCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alterar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Excluir = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GrdItens)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtCodigoCurso
            // 
            this.TxtCodigoCurso.Enabled = false;
            this.TxtCodigoCurso.Location = new System.Drawing.Point(64, 12);
            this.TxtCodigoCurso.MaxLength = 9;
            this.TxtCodigoCurso.Name = "TxtCodigoCurso";
            this.TxtCodigoCurso.Size = new System.Drawing.Size(178, 23);
            this.TxtCodigoCurso.TabIndex = 0;
            // 
            // LblCodigoCurso
            // 
            this.LblCodigoCurso.AutoSize = true;
            this.LblCodigoCurso.Location = new System.Drawing.Point(12, 15);
            this.LblCodigoCurso.Name = "LblCodigoCurso";
            this.LblCodigoCurso.Size = new System.Drawing.Size(46, 15);
            this.LblCodigoCurso.TabIndex = 1;
            this.LblCodigoCurso.Text = "Código";
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(58, 46);
            this.TxtNome.MaxLength = 50;
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(730, 23);
            this.TxtNome.TabIndex = 2;
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Location = new System.Drawing.Point(12, 49);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(40, 15);
            this.LblNome.TabIndex = 3;
            this.LblNome.Text = "Nome";
            // 
            // GrdItens
            // 
            this.GrdItens.AllowUserToAddRows = false;
            this.GrdItens.AllowUserToDeleteRows = false;
            this.GrdItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoCurso,
            this.Nome,
            this.Alterar,
            this.Excluir});
            this.GrdItens.Location = new System.Drawing.Point(12, 104);
            this.GrdItens.Name = "GrdItens";
            this.GrdItens.RowTemplate.Height = 25;
            this.GrdItens.Size = new System.Drawing.Size(776, 334);
            this.GrdItens.TabIndex = 4;
            this.GrdItens.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdItens_CellClick);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(58, 75);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(75, 23);
            this.BtnSalvar.TabIndex = 5;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // CodigoCurso
            // 
            this.CodigoCurso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CodigoCurso.DataPropertyName = "CodigoCurso";
            this.CodigoCurso.FillWeight = 40F;
            this.CodigoCurso.HeaderText = "C-Curso";
            this.CodigoCurso.Name = "CodigoCurso";
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nome.DataPropertyName = "Nome";
            this.Nome.FillWeight = 180F;
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // Alterar
            // 
            this.Alterar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Alterar.FillWeight = 20F;
            this.Alterar.HeaderText = "Alterar";
            this.Alterar.Name = "Alterar";
            // 
            // Excluir
            // 
            this.Excluir.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Excluir.FillWeight = 20F;
            this.Excluir.HeaderText = "Excluir";
            this.Excluir.Name = "Excluir";
            // 
            // FrmCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.GrdItens);
            this.Controls.Add(this.LblNome);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.LblCodigoCurso);
            this.Controls.Add(this.TxtCodigoCurso);
            this.Name = "FrmCurso";
            this.Text = "Cadastro de curso";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmCurso_FormClosed);
            this.Load += new System.EventHandler(this.FrmCurso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdItens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtCodigoCurso;
        private System.Windows.Forms.Label LblCodigoCurso;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.DataGridView GrdItens;
        private System.Windows.Forms.DataGridViewButtonColumn Deletar;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewButtonColumn Alterar;
        private System.Windows.Forms.DataGridViewButtonColumn Excluir;
    }
}

