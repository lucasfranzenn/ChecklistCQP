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
            txt_senha = new MaskedTextBox();
            lbl_senha = new Label();
            txt_nome = new TextBox();
            lbl_nome = new Label();
            bttn_login = new Button();
            bttn_registrarCQP = new Button();
            tabpage_checklist = new TabPage();
            memo_tela = new RichTextBox();
            lbl_tela = new Label();
            lbl_datahora = new Label();
            lbl_testador = new Label();
            txt_idtarefa = new TextBox();
            lbl_idtarefa = new Label();
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
            tabControl1.Size = new Size(606, 427);
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
            tabpage_login.Size = new Size(598, 399);
            tabpage_login.TabIndex = 0;
            tabpage_login.Text = "Cadastro de Testador";
            tabpage_login.UseVisualStyleBackColor = true;
            // 
            // txt_senha
            // 
            txt_senha.BorderStyle = BorderStyle.FixedSingle;
            txt_senha.Location = new Point(279, 168);
            txt_senha.Name = "txt_senha";
            txt_senha.PasswordChar = '*';
            txt_senha.Size = new Size(100, 23);
            txt_senha.TabIndex = 1;
            // 
            // lbl_senha
            // 
            lbl_senha.AutoSize = true;
            lbl_senha.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_senha.Location = new Point(217, 168);
            lbl_senha.Name = "lbl_senha";
            lbl_senha.Size = new Size(55, 20);
            lbl_senha.TabIndex = 4;
            lbl_senha.Text = "Senha:";
            // 
            // txt_nome
            // 
            txt_nome.BorderStyle = BorderStyle.FixedSingle;
            txt_nome.Location = new Point(279, 129);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(100, 23);
            txt_nome.TabIndex = 0;
            // 
            // lbl_nome
            // 
            lbl_nome.AutoSize = true;
            lbl_nome.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_nome.Location = new Point(217, 129);
            lbl_nome.Name = "lbl_nome";
            lbl_nome.Size = new Size(56, 20);
            lbl_nome.TabIndex = 2;
            lbl_nome.Text = "Nome:";
            // 
            // bttn_login
            // 
            bttn_login.Cursor = Cursors.Hand;
            bttn_login.Location = new Point(314, 237);
            bttn_login.Name = "bttn_login";
            bttn_login.Size = new Size(85, 38);
            bttn_login.TabIndex = 3;
            bttn_login.Text = "Logar";
            bttn_login.UseVisualStyleBackColor = true;
            bttn_login.Click += bttn_login_Click;
            // 
            // bttn_registrarCQP
            // 
            bttn_registrarCQP.Cursor = Cursors.Hand;
            bttn_registrarCQP.Location = new Point(207, 237);
            bttn_registrarCQP.Name = "bttn_registrarCQP";
            bttn_registrarCQP.Size = new Size(85, 38);
            bttn_registrarCQP.TabIndex = 2;
            bttn_registrarCQP.Text = "Registrar";
            bttn_registrarCQP.UseVisualStyleBackColor = true;
            bttn_registrarCQP.Click += bttn_registrarCQP_Click;
            // 
            // tabpage_checklist
            // 
            tabpage_checklist.Controls.Add(memo_tela);
            tabpage_checklist.Controls.Add(lbl_tela);
            tabpage_checklist.Controls.Add(lbl_datahora);
            tabpage_checklist.Controls.Add(lbl_testador);
            tabpage_checklist.Controls.Add(txt_idtarefa);
            tabpage_checklist.Controls.Add(lbl_idtarefa);
            tabpage_checklist.Controls.Add(lbl_logue);
            tabpage_checklist.Location = new Point(4, 24);
            tabpage_checklist.Name = "tabpage_checklist";
            tabpage_checklist.Padding = new Padding(3);
            tabpage_checklist.Size = new Size(598, 399);
            tabpage_checklist.TabIndex = 1;
            tabpage_checklist.Text = "Checklist Tarefa";
            tabpage_checklist.UseVisualStyleBackColor = true;
            // 
            // memo_tela
            // 
            memo_tela.BorderStyle = BorderStyle.FixedSingle;
            memo_tela.Location = new Point(356, 19);
            memo_tela.Name = "memo_tela";
            memo_tela.Size = new Size(233, 69);
            memo_tela.TabIndex = 6;
            memo_tela.Text = "";
            memo_tela.Visible = false;
            // 
            // lbl_tela
            // 
            lbl_tela.AutoSize = true;
            lbl_tela.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_tela.Location = new Point(449, 3);
            lbl_tela.Name = "lbl_tela";
            lbl_tela.Size = new Size(37, 15);
            lbl_tela.TabIndex = 5;
            lbl_tela.Text = "TELA:";
            lbl_tela.Visible = false;
            // 
            // lbl_datahora
            // 
            lbl_datahora.AutoSize = true;
            lbl_datahora.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_datahora.Location = new Point(15, 69);
            lbl_datahora.Name = "lbl_datahora";
            lbl_datahora.Size = new Size(122, 15);
            lbl_datahora.TabIndex = 4;
            lbl_datahora.Text = "DATA/HORA INICIO: ";
            lbl_datahora.Visible = false;
            // 
            // lbl_testador
            // 
            lbl_testador.AutoSize = true;
            lbl_testador.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_testador.Location = new Point(15, 44);
            lbl_testador.Name = "lbl_testador";
            lbl_testador.Size = new Size(70, 15);
            lbl_testador.TabIndex = 3;
            lbl_testador.Text = "TESTADOR:";
            lbl_testador.Visible = false;
            // 
            // txt_idtarefa
            // 
            txt_idtarefa.BorderStyle = BorderStyle.FixedSingle;
            txt_idtarefa.Location = new Point(88, 17);
            txt_idtarefa.Name = "txt_idtarefa";
            txt_idtarefa.Size = new Size(100, 23);
            txt_idtarefa.TabIndex = 2;
            txt_idtarefa.Visible = false;
            // 
            // lbl_idtarefa
            // 
            lbl_idtarefa.AutoSize = true;
            lbl_idtarefa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_idtarefa.Location = new Point(15, 19);
            lbl_idtarefa.Name = "lbl_idtarefa";
            lbl_idtarefa.Size = new Size(67, 15);
            lbl_idtarefa.TabIndex = 1;
            lbl_idtarefa.Text = "ID TAREFA:";
            lbl_idtarefa.Visible = false;
            // 
            // lbl_logue
            // 
            lbl_logue.AutoSize = true;
            lbl_logue.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_logue.ForeColor = Color.Red;
            lbl_logue.Location = new Point(15, 178);
            lbl_logue.Name = "lbl_logue";
            lbl_logue.Size = new Size(574, 30);
            lbl_logue.TabIndex = 0;
            lbl_logue.Text = "FAÇA O LOGIN PARA PROSSEGUIR COM O CHECKLIST!";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(612, 428);
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
        private Label lbl_senha;
        private TextBox txt_nome;
        private Label lbl_nome;
        private Label lbl_logue;
        private MaskedTextBox txt_senha;
        private TextBox txt_idtarefa;
        private Label lbl_idtarefa;
        private Label lbl_testador;
        private Label lbl_datahora;
        private RichTextBox memo_tela;
        private Label lbl_tela;
    }
}