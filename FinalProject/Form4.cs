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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            searchAllRoutes();
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            using (var conexao = Connection.ObterConexao())
            {
                conexao.Close();
            }
            Application.OpenForms["Form1"].Show();
        }

        private void searchAllRoutes()
        {
            try
            {
                using var conexao = Connection.ObterConexao();
                string query = "SELECT * FROM ROTA";
                using (var grid = new SQLiteDataAdapter(query, conexao))
                {
                    DataTable dt = new DataTable(); //cria o Data table
                    grid.Fill(dt); //preenche o data table
                    dataGridView1.DataSource = dt; //atribui o data table ao data grid view
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro");
            }
        }

        private void searchRoute()
        {
            try
            {
                using var conexao = Connection.ObterConexao();
                string searchQuery = "SELECT * FROM ROTA \r\nWHERE ORIGEM LIKE @Termo \r\n   OR DESTINO LIKE @Termo \r\n   OR DISTANCIA LIKE @Termo \r\n   OR TEMPO_ESTIMADO LIKE @Termo";
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

        private void btn_search_Click(object sender, EventArgs e)
        {
            searchRoute();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            searchAllRoutes();
        }
    }
}
