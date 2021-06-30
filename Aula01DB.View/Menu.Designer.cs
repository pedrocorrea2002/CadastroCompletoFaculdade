
namespace Aula01DB.View
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAluno = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCurso = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuTurma = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCadastrar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuCadastrar
            // 
            this.MenuCadastrar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuAluno,
            this.MenuCurso,
            this.MenuTurma});
            this.MenuCadastrar.Name = "MenuCadastrar";
            this.MenuCadastrar.Size = new System.Drawing.Size(69, 20);
            this.MenuCadastrar.Text = "Cadastrar";
            // 
            // MenuAluno
            // 
            this.MenuAluno.Name = "MenuAluno";
            this.MenuAluno.Size = new System.Drawing.Size(180, 22);
            this.MenuAluno.Text = "Aluno";
            // 
            // MenuCurso
            // 
            this.MenuCurso.Name = "MenuCurso";
            this.MenuCurso.Size = new System.Drawing.Size(180, 22);
            this.MenuCurso.Text = "Curso";
            // 
            // MenuTurma
            // 
            this.MenuTurma.Name = "MenuTurma";
            this.MenuTurma.Size = new System.Drawing.Size(180, 22);
            this.MenuTurma.Text = "Turma";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuCadastrar;
        private System.Windows.Forms.ToolStripMenuItem MenuAluno;
        private System.Windows.Forms.ToolStripMenuItem MenuCurso;
        private System.Windows.Forms.ToolStripMenuItem MenuTurma;
    }
}