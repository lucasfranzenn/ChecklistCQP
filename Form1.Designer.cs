using login;

namespace login
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
            txt_senha = new MaskedTextBox();
            lbl_senha = new Label();
            txt_nome = new TextBox();
            lbl_nome = new Label();
            lbl_status = new Label();
            SuspendLayout();
            // 
            // txt_senha
            // 
            txt_senha.BorderStyle = BorderStyle.FixedSingle;
            txt_senha.Location = new Point(113, 109);
            txt_senha.Name = "txt_senha";
            txt_senha.PasswordChar = '*';
            txt_senha.Size = new Size(100, 23);
            txt_senha.TabIndex = 1;
            txt_senha.KeyPress += txt_senha_KeyPress;
            txt_senha.Leave += txt_senha_Leave;
            // 
            // lbl_senha
            // 
            lbl_senha.AutoSize = true;
            lbl_senha.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_senha.Location = new Point(52, 109);
            lbl_senha.Name = "lbl_senha";
            lbl_senha.Size = new Size(61, 21);
            lbl_senha.TabIndex = 4;
            lbl_senha.Text = "Senha:";
            // 
            // txt_nome
            // 
            txt_nome.BorderStyle = BorderStyle.FixedSingle;
            txt_nome.Location = new Point(113, 72);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(100, 23);
            txt_nome.TabIndex = 0;
            // 
            // lbl_nome
            // 
            lbl_nome.AutoSize = true;
            lbl_nome.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_nome.Location = new Point(52, 72);
            lbl_nome.Name = "lbl_nome";
            lbl_nome.Size = new Size(61, 21);
            lbl_nome.TabIndex = 2;
            lbl_nome.Text = "Nome:";
            // 
            // lbl_status
            // 
            lbl_status.AutoSize = true;
            lbl_status.BackColor = SystemColors.Control;
            lbl_status.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_status.ForeColor = Color.Gray;
            lbl_status.Location = new Point(42, 22);
            lbl_status.Name = "lbl_status";
            lbl_status.Size = new Size(171, 21);
            lbl_status.TabIndex = 5;
            lbl_status.Text = "STATUS: DESLOGADO";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(254, 171);
            Controls.Add(lbl_status);
            Controls.Add(txt_senha);
            Controls.Add(lbl_senha);
            Controls.Add(txt_nome);
            Controls.Add(lbl_nome);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "..::LOGIN::..";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbl_senha;
        private TextBox txt_nome;
        private Label lbl_nome;
        private Label lbl_status;
        private MaskedTextBox txt_senha;
    }
}