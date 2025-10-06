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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            searchDataGridVehicle();

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.AllowUserToAddRows = false;

            dataGridView1.AllowUserToResizeColumns = false;
        }

        public class VehicleDatas()
        {
            public string VehicleId { get; set; }
            public string Model { get; set; }
            public string Plate { get; set; }
            public string AverageCons { get; set; }
            public string MaxLoad { get; set; }
        }
        public VehicleDatas VehicleSelected { get; private set; }
            private void searchDataGridVehicle()
        {
            try
            {
                using var conexao = Connection.ObterConexao();
                string query = "SELECT * FROM VEICULO";
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

        private void searchVehicle()
        {
            try
            {
                using var conexao = Connection.ObterConexao();

                string searchQuery = "SELECT * FROM VEICULO \r\nWHERE MODELO LIKE @Termo \r\n   OR PLACA LIKE @Termo \r\n   OR CONSUMO_MEDIO LIKE @Termo \r\n   OR CARGA_MAXIMA LIKE @Termo";
                using (var cmd = new SQLiteCommand(searchQuery, conexao))
                {
                    cmd.Parameters.AddWithValue("@Termo", Txt_Search_grid.Text);

                    cmd.ExecuteNonQuery();



                    using (var adpt = new SQLiteDataAdapter(cmd))
                    {
                        DataTable datatable = new DataTable();
                        adpt.Fill(datatable);
                        dataGridView1.DataSource = datatable;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao pesquisar um Veículo: " + ex.Message);
            }
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            using (var conexao = Connection.ObterConexao())
            {
                conexao.Close();
            }
            Application.OpenForms["Form1"].Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            searchVehicle();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            resetSearch();
        }

        private void resetSearch()
        {
            try
            {
                using var conexao = Connection.ObterConexao();
                string query = "SELECT * FROM VEICULO";
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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                VehicleSelected = new VehicleDatas
                {
                    VehicleId = row.Cells["VEICULOID"].Value.ToString(),
                    Model = row.Cells["MODELO"].Value.ToString(),
                    Plate = row.Cells["PLACA"].Value.ToString(),
                    AverageCons = row.Cells["CONSUMO_MEDIO"].Value.ToString(),
                    MaxLoad = row.Cells["CARGA_MAXIMA"].Value.ToString()
                };

                this.DialogResult = DialogResult.OK; 
                this.Close();
            }
     
        }
    }
}
    