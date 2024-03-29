﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using login;
using connector;
using ChecklistCQP.Properties;
using MySqlConnector;
using System.Reflection.Emit;

namespace ChecklistCQP
{
    public partial class Form2 : Form
    {
        private string tester = Settings.Default.login;
        private const int num_requisitos = 21;
        private System.Windows.Forms.Label l = new System.Windows.Forms.Label();
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        public string Tester { get => tester; set => tester = value; }

        public Form2()
        {
            InitializeComponent();
            ConfigurarToolTip();
            timer.Interval = 1000;
            timer.Tick += (sender, e) =>
            {
                l.Visible = !l.Visible;
            };
        }

        private void ConfigurarToolTip()
        {
            ToolTip toolTip = new ToolTip();

            toolTip.SetToolTip(lbl_tarefa, "Tarefa Relacionada");

            toolTip.InitialDelay = 500;
            toolTip.AutoPopDelay = 2000;
            toolTip.Active = true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lbl_testador.Text += $"TESTADOR: {tester}";
        }

        private void lbl_status_Click(object sender, EventArgs e)
        {
            int tarefa = Convert.ToInt32(txt_idtarefa.Text);
            string tela = string.IsNullOrEmpty(memo_tela.Text) ? null : memo_tela.Text;
            string post = string.IsNullOrEmpty(txt_post.Text) ? null : txt_post.Text;

            connection con = new connection();
            string query = "UPDATE tarefas SET tela = @tela, post_forum = @post WHERE id_tarefa = @tarefa";
            MySqlCommand cmd = new MySqlCommand(query, con.Con);
            cmd.Parameters.AddWithValue("@tela", tela);
            cmd.Parameters.AddWithValue("@post", post);
            cmd.Parameters.AddWithValue("@tarefa", tarefa);
            cmd.ExecuteNonQuery();

            for (int i = 1; i <= num_requisitos; i++)
            {
                string checkbox = "cb_id" + i;

                CheckBox cb = (CheckBox)this.Controls.Find(checkbox, true).FirstOrDefault();

                if (cb.Checked == true)
                {
                    cmd = new MySqlCommand($"UPDATE requisitos SET finalizado = 1 where id_requisito = {i} and id_Tarefa = {tarefa}", con.Con);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    cmd = new MySqlCommand($"UPDATE requisitos SET finalizado = 0 where id_requisito = {i} and id_Tarefa = {tarefa}", con.Con);
                    cmd.ExecuteNonQuery();
                }

            }

            for (int i = 1; i <= num_requisitos; i++)
            {
                string tarefaRelacionada = "txt_TarefaRelacionada" + i;

                TextBox tb = (TextBox)this.Controls.Find(tarefaRelacionada, true).FirstOrDefault();

                if (string.IsNullOrEmpty(tb.Text))
                {
                    continue;
                }
                else
                {
                    cmd = new MySqlCommand($"UPDATE requisitos SET BugRelacionado = {tb.Text} where id_requisito = {i} and id_Tarefa = {tarefa}", con.Con);
                    cmd.ExecuteNonQuery();
                }
            }

            for (int i = 1; i <= num_requisitos; i++)
            {
                string Obs = "txt_obs" + i;

                TextBox tb = (TextBox)this.Controls.Find(Obs, true).FirstOrDefault();

                if (string.IsNullOrEmpty(tb.Text))
                {
                    continue;
                }
                else
                {
                    using (cmd = new MySqlCommand("UPDATE requisitos SET Observacao = @Observacao WHERE id_requisito = @id_requisito AND id_Tarefa = @id_Tarefa", con.Con))
                    {
                        cmd.Parameters.AddWithValue("@Observacao", tb.Text);
                        cmd.Parameters.AddWithValue("@id_requisito", i);
                        cmd.Parameters.AddWithValue("@id_Tarefa", tarefa);

                        cmd.ExecuteNonQuery();
                    }
                }
            }

            if (checkTaskFinished(tarefa))
            {
                DialogResult result = MessageBox.Show("Deseja finalizar a tarefa?", "..::MENU::..", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    cmd = new MySqlCommand($"Update tarefas SET finalizada = 1, dataHora_fim = CURRENT_TIMESTAMP() where id_tarefa = {tarefa}", con.Con);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Tarefa finalizada", "..::MENU::..");
                    updateTask();
                }
            }
        }

        private bool checkTaskFinished(int tarefa)
        {
            connection con = new connection();
            MySqlCommand cmd = new MySqlCommand($"select count(*) finalizadas from requisitos where id_tarefa = {tarefa} and finalizado = 1", con.Con);
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                if (Convert.ToInt32(reader["finalizadas"]) == 21)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        private void txt_idtarefa_Leave(object sender, EventArgs e)
        {
            try
            {
                if (!checkTaskExists())
                {
                    createTask();
                }
            }
            finally
            {
                updateTask();
            }
        }

        private void updateTask()
        {
            Int64 tarefa = Convert.ToInt64(txt_idtarefa.Text);

            lbl_testador.Visible = true;
            lbl_tela.Visible = true;
            lbl_datahora.Visible = true;
            lbl_postFórum.Visible = true;
            lbl_status.Visible = true;
            lbl_statusTarefa.Visible = true;
            lbl_dataHoraFim.Visible = true;
            txt_post.Visible = true;
            memo_tela.Visible = true;
            bttn_gravar.Visible = true;
            tableLayoutPanel1.Enabled = true;

            connection con = new connection();
            MySqlCommand cmd = new MySqlCommand($"select * from tarefas where id_Tarefa = {tarefa}", con.Con);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                lbl_testador.Text = "TESTADOR:  " + reader["nome_testador"].ToString();
                lbl_datahora.Text = "DATA/HORA INICIO:   " + reader["dataHora_inicio"].ToString();
                memo_tela.Text = reader["tela"].ToString();
                txt_post.Text = reader["post_forum"].ToString();
                lbl_statusTarefa.Text = (Convert.ToBoolean(reader["finalizada"])) ? setFinalizada() : setAberta();
                lbl_dataHoraFim.Text = "DATA/HORA FIM:   " + reader["dataHora_fim"].ToString();
            }

            reader.Close();


            for (int i = 1; i <= num_requisitos; i++)
            {
                cmd = new MySqlCommand($"Select finalizado from requisitos where id_tarefa = {tarefa} and id_requisito = {i}", con.Con);
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string checkbox = "cb_id" + i;
                    CheckBox cb = (CheckBox)this.Controls.Find(checkbox, true).FirstOrDefault();
                    cb.Checked = (reader["finalizado"] == DBNull.Value) ? false : Convert.ToBoolean(reader["finalizado"]);
                }
                reader.Close();
            }

            reader.Close();

            for (int i = 0; i <= num_requisitos; i++)
            {
                cmd = new MySqlCommand($"Select BugRelacionado from requisitos where id_tarefa = {tarefa} and id_requisito = {i}", con.Con);
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string text = "txt_TarefaRelacionada" + i;
                    TextBox tb = (TextBox)this.Controls.Find(text, true).FirstOrDefault();

                    tb.Text = (reader["BugRelacionado"] == DBNull.Value) ? null : reader["BugRelacionado"].ToString();
                }
                reader.Close();
            }

            reader.Close();

            for (int i = 0; i <= num_requisitos; i++)
            {
                cmd = new MySqlCommand($"Select Observacao from requisitos where id_tarefa = {tarefa} and id_requisito = {i}", con.Con);
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string text = "txt_obs" + i;
                    TextBox tb = (TextBox)this.Controls.Find(text, true).FirstOrDefault();

                    tb.Text = (reader["Observacao"] == DBNull.Value) ? null : reader["Observacao"].ToString();
                }
                reader.Close();
            }

        }

        private string setAberta()
        {
            lbl_statusTarefa.ForeColor = Color.Green;
            
            bttn_gravar.Enabled = true;
            timer.Stop();
            this.Controls.Remove(l);

            return "ABERTA";
        }

        private string setFinalizada()
        {
            lbl_statusTarefa.ForeColor = Color.Red;
            tableLayoutPanel1.Enabled = false;
            
            this.Controls.Add(l);
            bttn_gravar.Enabled = false;
            l.BringToFront();
            l.AutoSize = true;
            l.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            l.Location = new Point(70, 294);
            l.Name = "label22";
            l.Size = new Size(752, 74);
            l.TabIndex = 56;
            l.Text = "TAREFA FINALIZADA, CASO QUEIRA TESTAR NOVAMENTE\r\n PEÇA LIBERAÇÃO A UM SUPERVISOR";
            l.TextAlign = ContentAlignment.MiddleCenter;
            timer.Start();

            return "FINALIZADA";
        }

        private void createTask()
        {
            connection con = new connection();
            MySqlCommand cmd = new MySqlCommand($"Insert into tarefas values ({(txt_idtarefa.Text)}, '{tester}', NULL, CURRENT_TIMESTAMP(), NULL, NULL, 0)", con.Con);
            cmd.ExecuteNonQuery();

            for (int i = 1; i <= num_requisitos; i++)
            {
                cmd = new MySqlCommand($"Insert into requisitos values ({i}, {(txt_idtarefa.Text)}, 0, NULL, NULL)", con.Con);
                cmd.ExecuteNonQuery();
            }
        }

        private bool checkTaskExists()
        {
            connection con = new connection();
            MySqlCommand cmd = new MySqlCommand($"select * from Tarefas where id_tarefa = {(txt_idtarefa.Text)}", con.Con);
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void txt_idtarefa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    if (!checkTaskExists())
                    {
                        createTask();
                    }
                }
                finally
                {
                    updateTask();
                }
            }
        }
        private void NumericTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
