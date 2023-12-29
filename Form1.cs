using connector;
using MySqlConnector;

namespace ChecklistCQP
{
    public partial class Form1 : Form
    {
        private string testador;

        public string Testador { get => testador; set => testador = value; }

        public Form1()
        {
            InitializeComponent();
        }

        private void bttn_registrarCQP_Click(object sender, EventArgs e)
        {
            if (!checkLoginNull())
            {
                MessageBox.Show("Por favor, preencha os campos vazios", "..::AVISO::..", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            createRegister();
        }

        private void createRegister()
        {
            if (!checkUser())
            {
                MessageBox.Show("Nome de usuário já existente!", "..::AVISO::..", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            connection con = new connection();
            MySqlCommand cmd = new MySqlCommand($"Insert into Testadores values ('{txt_nome.Text.Trim()}', '{txt_senha.Text}')", con.Con);
            cmd.ExecuteNonQuery();
        }

        private bool checkUser()
        {
            connection con = new connection();

            MySqlCommand cmd = new MySqlCommand($"Select * from Testadores where nome like '{txt_nome.Text.Trim()}'", con.Con);
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool checkLoginNull()
        {
            if (txt_nome.Text == "" || txt_senha.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void bttn_login_Click(object sender, EventArgs e)
        {
            if (!checkLoginNull())
            {
                MessageBox.Show("Por favor, preencha os campos vazios", "..::AVISO::..", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            userLogin();

        }

        private void userLogin()
        {
            connection con = new connection();
            MySqlCommand cmd = new MySqlCommand($"select * from testadores where nome like '{txt_nome.Text.Trim()}' and senha = '{txt_senha.Text.Trim()}'", con.Con);
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                MessageBox.Show("Logado com sucesso!", "..::Sucesso::..", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                testador = txt_nome.Text;
                loginProcedures();
                return;
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos. Tente novamente!", "..::ERRO::..", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loginProcedures()
        {
            lbl_testador.Text += $" {testador.ToUpper()}";
            lbl_datahora.Text += DateTime.Now.ToString();
            lbl_logue.Enabled = false;
            lbl_logue.Visible = false;

            lbl_datahora.Visible = true;
            lbl_idtarefa.Visible = true;
            lbl_testador.Visible = true;
            lbl_tela.Visible = true;
            txt_idtarefa.Visible = true;
            memo_tela.Visible = true;


            tabControl1.SelectTab(1);
        }
    }
}