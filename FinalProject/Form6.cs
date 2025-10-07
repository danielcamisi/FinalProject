using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            searchAllTravel();
        }

        private void Form6_FormClosing(object sender, FormClosingEventArgs e)
        {
            using (var conexao = Connection.ObterConexao())
            {
                conexao.Close();
            }
            Application.OpenForms["Form1"].Show();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            searchTravel();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            searchAllTravel();
        }

        public class TravelDatas()
        {
            public string TravelId { get; set; }
            public string VehicleId { get; set; }
            public string DriverId { get; set; }
            public string RouteId { get; set; }
            public string DepartureDate { get; set; }
            public string ArrivalDate { get; set; }
            public string Situation { get; set; }


            //new Vars
            public string Model { get; set; }
            public string Plate { get; set; }

            public string Origin { get; set; }
            public string path { get; set; }
            public string name { get; set; }
            public string cnh { get; set; }

        }

        public TravelDatas TravelSelected { get; private set; }

        private void searchAllTravel()
        {
            try
            {
                using var conexao = Connection.ObterConexao();
                string query = "SELECT v.*, c.modelo AS MODELO, c.placa AS PLACA, m.NOME AS NOME, m.CNH AS CNH, r.ORIGEM AS ORIGEM, r.DESTINO AS DESTINO\r\n\t\tFROM VIAGEM AS v \r\n\t\tINNER JOIN VEICULO AS c ON v.VEICULOID = c.VEICULOID\r\n\t\tINNER JOIN MOTORISTA AS m ON v.MOTORISTAID = m.MOTORISTAID\r\n\t\tINNER JOIN ROTA AS r ON v.ROTAID = r.ROTAID";

                using (var grid = new SQLiteDataAdapter(query, conexao))
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

        private void searchTravel()
        {
            try
            {
                using var conexao = Connection.ObterConexao();
                string query = @"SELECT 
                                    v.*, 
                                    c.modelo AS MODELO, 
                                    c.placa AS PLACA, 
                                    m.NOME AS NOME, 
                                    m.CNH AS CNH, 
                                    r.ORIGEM AS ORIGEM, 
                                    r.DESTINO AS DESTINO
                                    FROM VIAGEM AS v
                                    INNER JOIN VEICULO AS c ON v.VEICULOID = c.VEICULOID
                                    INNER JOIN MOTORISTA AS m ON v.MOTORISTAID = m.MOTORISTAID
                                    INNER JOIN ROTA AS r ON v.ROTAID = r.ROTAID
                                    WHERE
                                    c.modelo LIKE @Termo OR
                                    c.placa LIKE @Termo OR
                                    m.nome LIKE @Termo OR
                                    v.situacao LIKE @Termo OR
                                    r.origem LIKE @Termo";
                using (var cmd = new SQLiteCommand(query, conexao))
                {
                    cmd.Parameters.AddWithValue("@Termo", txt_search_grid.Text);

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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                TravelSelected = new TravelDatas
                {
                    path = row.Cells["DESTINO"].Value.ToString(),
                    cnh = row.Cells["CNH"].Value.ToString(),
                    name = row.Cells["NOME"].Value.ToString(),
                    Origin = row.Cells["ORIGEM"].Value.ToString(),
                    Plate = row.Cells["PLACA"].Value.ToString(),
                    Model = row.Cells["MODELO"].Value.ToString(),
                    TravelId = row.Cells["VIAGEMID"].Value.ToString(),
                    VehicleId = row.Cells["VEICULOID"].Value.ToString(),
                    DriverId = row.Cells["MOTORISTAID"].Value.ToString(),
                    RouteId = row.Cells["ROTAID"].Value.ToString(),
                    DepartureDate = row.Cells["DATA_SAIDA"].Value.ToString(),
                    ArrivalDate = row.Cells["DATA_CHEGADA"].Value.ToString(),
                    Situation = row.Cells["SITUACAO"].Value.ToString()
                };
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
