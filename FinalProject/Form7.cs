using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {

            if (txt_email.Text.Length == 0 || txt_pword.Text.Length == 0)
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }
            try
            {
                using var conexao = Connection.ObterConexao();
                string query = "SELECT * FROM USERS WHERE uEmail = @email AND uPword = @password";
                using (var cmd = new SQLiteCommand(query, conexao))
                {
                    cmd.Parameters.AddWithValue("@email", txt_email.Text);
                    cmd.Parameters.AddWithValue("@password", txt_pword.Text);

                    cmd.ExecuteNonQuery();
                }
                Form1 frm1 = new Form1();
                frm1.Show();
                MessageBox.Show("Usuário logado com sucesso!");
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Logar: " + ex.Message);
            }
        }

        private void btn_register_Click(object sender, EventArgs e)
        {

            if (txt_confirmpword.Text.Length == 0 || txt_emailregister.Text.Length == 0 || txt_name.Text.Length == 0 || txt_registerpword.Text.Length == 0)
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }

            if (txt_confirmpword.Text != txt_registerpword.Text)
            {
                MessageBox.Show("As senhas não coincidem.");
                return;
            }

            try
            {
                using var conexao = Connection.ObterConexao();
                string registerQuery = "INSERT INTO USERS (uName, uEmail, uPword) VALUES (@username, @email, @pword)";
                using (var cmd = new SQLiteCommand(registerQuery, conexao))
                {
                    cmd.Parameters.AddWithValue("@username", txt_name.Text);
                    cmd.Parameters.AddWithValue("@email", txt_emailregister.Text);
                    cmd.Parameters.AddWithValue("@pword", txt_registerpword.Text);
                    cmd.ExecuteNonQuery();
                }
                Form1 frm1 = new Form1();
                frm1.Show();
                MessageBox.Show("Usuário registrado com sucesso!");
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Registrar: " + ex.Message);
            }
        }

        private void Form7_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            Connection.CriarBancoSeNaoExistir();
        }
    }
}
