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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            searchAllDrivers();
        }

        private void searchAllDrivers()
        {
            try
            {
                using var conexao = Connection.ObterConexao();
                string query = "SELECT * FROM MOTORISTA";
                using (var grid = new SQLiteDataAdapter(query, conexao))
                {
                    DataTable drivertable = new DataTable();
                    grid.Fill(drivertable);
                    dataGridView1.DataSource = drivertable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro");
            }
        }
        private void searchDriver()
        {
            try
            {
                using var conexao = Connection.ObterConexao();
                string searchQuery = "SELECT * FROM MOTORISTA \r\nWHERE NOME LIKE @Termo  \r\n   OR CNH LIKE @Termo";
                using (var cmd = new SQLiteCommand(searchQuery, conexao))
                {
                    cmd.Parameters.AddWithValue("@Termo", Txt_search_grid.Text);
                    cmd.ExecuteNonQuery();
                    using (var grid = new SQLiteDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable(); //cria o Data table
                        grid.Fill(dt); //preenche o data table
                        dataGridView1.DataSource = dt; //atribui o data table ao data grid view
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            searchDriver();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            searchAllDrivers();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            using (var conexao = Connection.ObterConexao())
            {
                conexao.Close();
            }
            Application.OpenForms["Form1"].Show();
        }
    }
}
