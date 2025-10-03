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

        public class DriverDatas()
        {
            public string DriverId { get; set; }
            public string Name { get; set; }
            public string Cnh { get; set; }
            public string Phone { get; set; }
            public string Address { get; set; }
        }
        public DriverDatas driverDataSelected { get; private set; }

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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                driverDataSelected = new DriverDatas
                {
                    DriverId = row.Cells["MOTORISTAID"].Value.ToString(),
                    Name = row.Cells["NOME"].Value.ToString(),
                    Cnh = row.Cells["CNH"].Value.ToString(),
                    Phone = row.Cells["TELEFONE"].Value.ToString()
                };

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
