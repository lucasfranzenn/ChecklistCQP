using connector;
using ChecklistCQP;
using MySqlConnector;
using ChecklistCQP.Properties;

namespace login
{
    public partial class Form1 : Form
    {
        private string testador;

        public string Testador { get => testador; set => testador = value; }

        public Form1()
        {
            InitializeComponent();
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
            MySqlCommand cmd = new MySqlCommand($"select * from testadores where nome like '{txt_nome.Text.Trim()}' and senha = AES_ENCRYPT('{txt_senha.Text.Trim()}', 2037)", con.Con);
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                lbl_status.Text = "STATUS: LOGANDO";
                lbl_status.ForeColor = Color.Green;
                Settings.Default.login = txt_nome.Text;
                Settings.Default.Save();

                this.Hide();

                Form2 form2 = new Form2();
                form2.Show();

                form2.FormClosed += (s, args) => this.Close();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos. Tente novamente!", "..::ERRO::..", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_senha_Leave(object sender, EventArgs e)
        {
            userLogin();
        }

        private void txt_senha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                userLogin();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            if (Settings.Default.login != "")
            {
                txt_nome.Text = Settings.Default.login.ToUpper().Trim();
            }
        }
    }
}