namespace ChecklistCQP
{
    partial class Form1
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
            tabControl1 = new TabControl();
            tabpage_login = new TabPage();
            txt_senha = new TextBox();
            lbl_senha = new Label();
            txt_nome = new TextBox();
            lbl_nome = new Label();
            bttn_login = new Button();
            bttn_registrarCQP = new Button();
            tabpage_checklist = new TabPage();
            lbl_logue = new Label();
            tabControl1.SuspendLayout();
            tabpage_login.SuspendLayout();
            tabpage_checklist.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabpage_login);
            tabControl1.Controls.Add(tabpage_checklist);
            tabControl1.Location = new Point(4, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(388, 223);
            tabControl1.TabIndex = 1;
            // 
            // tabpage_login
            // 
            tabpage_login.Controls.Add(txt_senha);
            tabpage_login.Controls.Add(lbl_senha);
            tabpage_login.Controls.Add(txt_nome);
            tabpage_login.Controls.Add(lbl_nome);
            tabpage_login.Controls.Add(bttn_login);
            tabpage_login.Controls.Add(bttn_registrarCQP);
            tabpage_login.Location = new Point(4, 24);
            tabpage_login.Name = "tabpage_login";
            tabpage_login.Padding = new Padding(3);
            tabpage_login.Size = new Size(380, 195);
            tabpage_login.TabIndex = 0;
            tabpage_login.Text = "Cadastro de Testador";
            tabpage_login.UseVisualStyleBackColor = true;
            // 
            // txt_senha
            // 
            txt_senha.BorderStyle = BorderStyle.FixedSingle;
            txt_senha.Location = new Point(162, 82);
            txt_senha.Name = "txt_senha";
            txt_senha.Size = new Size(100, 23);
            txt_senha.TabIndex = 5;
            // 
            // lbl_senha
            // 
            lbl_senha.AutoSize = true;
            lbl_senha.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_senha.Location = new Point(100, 82);
            lbl_senha.Name = "lbl_senha";
            lbl_senha.Size = new Size(55, 20);
            lbl_senha.TabIndex = 4;
            lbl_senha.Text = "Senha:";
            // 
            // txt_nome
            // 
            txt_nome.BorderStyle = BorderStyle.FixedSingle;
            txt_nome.Location = new Point(162, 43);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(100, 23);
            txt_nome.TabIndex = 3;
            // 
            // lbl_nome
            // 
            lbl_nome.AutoSize = true;
            lbl_nome.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_nome.Location = new Point(100, 43);
            lbl_nome.Name = "lbl_nome";
            lbl_nome.Size = new Size(56, 20);
            lbl_nome.TabIndex = 2;
            lbl_nome.Text = "Nome:";
            // 
            // bttn_login
            // 
            bttn_login.Location = new Point(197, 151);
            bttn_login.Name = "bttn_login";
            bttn_login.Size = new Size(85, 38);
            bttn_login.TabIndex = 1;
            bttn_login.Text = "Logar";
            bttn_login.UseVisualStyleBackColor = true;
            bttn_login.Click += bttn_login_Click;
            // 
            // bttn_registrarCQP
            // 
            bttn_registrarCQP.Location = new Point(90, 151);
            bttn_registrarCQP.Name = "bttn_registrarCQP";
            bttn_registrarCQP.Size = new Size(85, 38);
            bttn_registrarCQP.TabIndex = 0;
            bttn_registrarCQP.Text = "Registrar";
            bttn_registrarCQP.UseVisualStyleBackColor = true;
            bttn_registrarCQP.Click += bttn_registrarCQP_Click;
            // 
            // tabpage_checklist
            // 
            tabpage_checklist.Controls.Add(lbl_logue);
            tabpage_checklist.Location = new Point(4, 24);
            tabpage_checklist.Name = "tabpage_checklist";
            tabpage_checklist.Padding = new Padding(3);
            tabpage_checklist.Size = new Size(380, 195);
            tabpage_checklist.TabIndex = 1;
            tabpage_checklist.Text = "Checklist Tarefa";
            tabpage_checklist.UseVisualStyleBackColor = true;
            // 
            // lbl_logue
            // 
            lbl_logue.AutoSize = true;
            lbl_logue.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_logue.ForeColor = Color.Red;
            lbl_logue.Location = new Point(6, 81);
            lbl_logue.Name = "lbl_logue";
            lbl_logue.Size = new Size(369, 19);
            lbl_logue.TabIndex = 0;
            lbl_logue.Text = "FAÇA O LOGIN PARA PROSSEGUIR COM O CHECKLIST!";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 235);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabpage_login.ResumeLayout(false);
            tabpage_login.PerformLayout();
            tabpage_checklist.ResumeLayout(false);
            tabpage_checklist.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControl1;
        private TabPage tabpage_login;
        private TabPage tabpage_checklist;
        private Button bttn_login;
        private Button bttn_registrarCQP;
        private TextBox txt_senha;
        private Label lbl_senha;
        private TextBox txt_nome;
        private Label lbl_nome;
        private Label lbl_logue;
    }
}