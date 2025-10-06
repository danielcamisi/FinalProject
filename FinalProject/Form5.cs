using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FinalProject
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            searchFuel();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            searchAllFuel();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            searchAllFuel();

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.AllowUserToAddRows = false;

            dataGridView1.AllowUserToResizeColumns = false;
        }

        public class FuelDatas()
        {
            public string FuelId { get; set; }
            public string Type { get; set; }
            public string Date { get; set; }
            public string Price { get; set; }


        }

        public FuelDatas fuelDataSelected { get; private set; }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            using (var conexao = Connection.ObterConexao())
            {
                conexao.Close();
            }
            Application.OpenForms["Form1"].Show();
        }

        private void searchAllFuel()
        {
            try
            {
                using var conexao = Connection.ObterConexao();
                string query = "SELECT * FROM PRECO_COMBUSTIVEL";
                using (var grid = new System.Data.SQLite.SQLiteDataAdapter(query, conexao))
                {
                    DataTable dt = new DataTable(); //cria o Data table
                    grid.Fill(dt); //preenche o data table
                    dataGridView1.DataSource = dt; //atribui o data table ao data grid view
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"O erro foi aqui! {ex.Message}");
            }
        }

        private void searchFuel()
        {
            try
            {
                using var conexao = Connection.ObterConexao();
                string searchQuery = "SELECT * FROM PRECO_COMBUSTIVEL \r\nWHERE TIPO LIKE @Termo  \r\n   OR PRECO_LITRO LIKE @Termo";
                using (var cmd = new System.Data.SQLite.SQLiteCommand(searchQuery, conexao))
                {
                    cmd.Parameters.AddWithValue("@Termo", txt_search_grid.Text);
                    cmd.ExecuteNonQuery();
                    using (var grid = new System.Data.SQLite.SQLiteDataAdapter(cmd))
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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                fuelDataSelected = new FuelDatas
                {
                    FuelId = row.Cells["PRECOID"].Value.ToString(),
                    Type = row.Cells["COMBUSTIVEL"].Value.ToString(),
                    Date = row.Cells["DATA_CONSULTA"].Value.ToString(),
                    Price = row.Cells["PRECO"].Value.ToString()
                };
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}