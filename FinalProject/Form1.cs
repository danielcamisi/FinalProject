using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Form1 : Form
    {

        string dbPath = @"C:\Users\daniel.csilva66\Desktop\logistica.db";

        string connectionString;
        public Form1()
        {
            InitializeComponent();
            connectionString = $"Data Source={dbPath};Version=3;";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            ConnectDb();

        }



        private void ConnectDb()
        {
            try
            {
                using (var connect = new SQLiteConnection(connectionString))
                {
                    connect.Open();
                    MessageBox.Show("Database connected successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            includingForm();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            searchForm();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            deleteForm();
        }

        private void deleteForm()
        {
            int indice = tabControl1.SelectedIndex;
            if (indice == 0)
            {
                try
                {
                    using(var connect = new SQLiteConnection(connectionString))
                    {
                        connect.Open();
                        string deleteQuery = "DELETE FROM VEICULO WHERE PLACA = @Placa";
                        using (var cmd = new SQLiteCommand(deleteQuery, connect))
                        {
                            cmd.Parameters.AddWithValue("@Placa", Txt_Plate.Text);
                            cmd.ExecuteNonQuery();
                        }
                    }

                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else if (indice == 1)
            {
                try
                {
                    using(var connect = new SQLiteConnection(connectionString))
                    {
                        connect.Open();
                        string deleteQuery = "DELETE FROM MOTORISTA WHERE CNH = @CNH";
                        using (var cmd = new SQLiteCommand(deleteQuery, connect))
                        {
                            cmd.Parameters.AddWithValue("@Placa", Txt_Plate.Text);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }catch(Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else if (indice == 2)
            {
                try
                {
                    using (var connect = new SQLiteConnection(connectionString))
                    {
                        connect.Open();
                        string deleteQuery = "DELETE FROM ROTA WHERE ORIGEM = @Origem";
                        using (var cmd = new SQLiteCommand(deleteQuery, connect))
                        {
                            cmd.Parameters.AddWithValue("@Origem", Txt_RouteOrigin.Text);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    }catch(Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else if (indice == 3)
            {
                try
                {
                    using(var connect = new SQLiteConnection(connectionString))
                    {
                        connect.Open();
                        string deleteQuery = "DELETE FROM PRECO_COMBUSTIVEL WHERE PRECOID = @Combustivel";
                        using (var cmd = new SQLiteCommand(deleteQuery, connect))
                        {
                            cmd.Parameters.AddWithValue("@Combustivel", Txt_FuelId.Text);
                            cmd.ExecuteNonQuery();
                        }
                    }

                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else if (indice == 4)
            {
                try
                {
                    using(var connect = new SQLiteConnection(connectionString))
                    {
                        connect.Open();
                        string deleteQuery = "DELETE FROM VIAGEM WHERE VIAGEMID = @Viagem";
                        using(var cmd = new SQLiteCommand(deleteQuery, connect))
                        {
                            cmd.Parameters.AddWithValue("@Viagem", Txt_TravelID.Text);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }catch(Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void searchForm()
        {
            int indice = tabControl1.SelectedIndex;
            if (indice == 0)
            {
                this.Hide();
                Form2 frm2 = new Form2();
                frm2.Show();
            }
            else if (indice == 1)
            {
                this.Hide();
                Form3 frm3 = new Form3();
                frm3.Show();
            }
            else if (indice == 2)
            {
                this.Hide();
                Form4 frm4 = new Form4();
                frm4.Show();
            }
            else if (indice == 3)
            {
                this.Hide();
                Form5 frm5 = new Form5();
                frm5.Show();
            }
            else if (indice == 4)
            {
                this.Hide();
                Form6 frm6 = new Form6();
                frm6.Show();
            }
        }

        private void includingForm()
        {
            int indice = tabControl1.SelectedIndex;

            if (indice == 0)
            {
                try
                {
                    using (var connect = new SQLiteConnection(connectionString))
                    {
                        connect.Open();
                        string insertQuery = @"INSERT INTO VEICULO (MODELO, PLACA, CONSUMO_MEDIO, CARGA_MAXIMA) " +
                            "VALUES (@Modelo, @Placa, @ConsMedio, @CargaMax)";
                        using (var cmd = new SQLiteCommand(insertQuery, connect))
                        {
                            cmd.Parameters.AddWithValue("@Modelo", Txt_Vehicle_Model.Text);
                            cmd.Parameters.AddWithValue("@Placa", Txt_Plate.Text);
                            cmd.Parameters.AddWithValue("@ConsMedio", Txt_Avarage.Text);
                            cmd.Parameters.AddWithValue("@CargaMax", Txt_Max_Weight.Text);

                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Vehicle data saved successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else if (indice == 1)
            {
                try
                {
                    using (var connect = new SQLiteConnection(connectionString))
                    {
                        connect.Open();
                        string insertQuery = @"INSERT INTO MOTORISTA (NOME, CNH,TELEFONE) " +
                            "VALUES (@Nome, @CNH, @Phone)";
                        using (var cmd = new SQLiteCommand(insertQuery, connect))
                        {
                            cmd.Parameters.AddWithValue("@Nome", Txt_DriverName.Text);
                            cmd.Parameters.AddWithValue("@CNH", Txt_DriverLicense.Text);
                            cmd.Parameters.AddWithValue("@Phone", Txt_DriverPhone.Text);

                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Driver Saved Successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else if (indice == 2)
            {
                try
                {
                    using (var connect = new SQLiteConnection(connectionString))
                    {
                        connect.Open();
                        string insertQuery = @"INSERT INTO ROTA (ORIGEM, DESTINO,DISTANCIA) " +
                            "VALUES (@Origem, @Destino, @Dist)";
                        using (var cmd = new SQLiteCommand(insertQuery, connect))
                        {
                            cmd.Parameters.AddWithValue("@Origem", Txt_RouteOrigin.Text);
                            cmd.Parameters.AddWithValue("@Destino", Txt_RouteDestiny.Text);
                            cmd.Parameters.AddWithValue("@Dist", Txt_RoutePath.Text);

                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Route Saved Successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else if (indice == 3)
            {
                try
                {
                    using (var connect = new SQLiteConnection(connectionString))
                    {
                        connect.Open();
                        string insertQuery = @"INSERT INTO PRECO_COMBUSTIVEL (COMBUSTIVEL, PRECO, DATA_CONSULTA) " +
                            "VALUES (@Combustível, @Preco, @DataConsulta)";
                        using (var cmd = new SQLiteCommand(insertQuery, connect))
                        {
                            cmd.Parameters.AddWithValue("@Combustível", cb_TypeFuel.Text);
                            cmd.Parameters.AddWithValue("@Preco", Txt_FuelPrice.Text);
                            cmd.Parameters.AddWithValue("@DataConsulta", DateTimeFuel.Value.ToString("yyyy-MM-dd"));

                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Fuel Price Was Saved Successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }
            else if (indice == 4)
            {
                try
                {
                    using (var connect = new SQLiteConnection(connectionString))
                    {
                        connect.Open();
                        string insertQuery = @"INSERT INTO VIAGEM (DATA_SAIDA, DATA_CHEGADA, SITUACAO, VEICULOID , ROTAID, MOTORISTAID) " +
                            "VALUES (@DataSaida, @DataChegada, @Situacao, @Veiculo,@Rota, @Motorista )";
                        using (var cmd = new SQLiteCommand(insertQuery, connect))
                        {
                            cmd.Parameters.AddWithValue("@DataSaida", DateTimeStartTravel.Value.ToString("yyyy-MM-dd"));
                            cmd.Parameters.AddWithValue("@DataChegada", DateTimeBring.Value.ToString("yyyy-MM-dd"));
                            cmd.Parameters.AddWithValue("@Situacao", "Em Andamento");
                            cmd.Parameters.AddWithValue("@Veiculo", cb_vehicle.SelectedValue.ToString());
                            cmd.Parameters.AddWithValue("@Rota", cb_travel.SelectedValue.ToString());
                            cmd.Parameters.AddWithValue("@Motorista", cb_driver.SelectedValue.ToString());

                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("New Journey Was Saved Successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }

        private void searchVehicle()
        {
            try
            {
                using (var connect = new SQLiteConnection(connectionString))
                {
                    connect.Open();
                    string searchQuery = "SELECT (MODELO || ' - ' || PLACA) AS DESCRICAO, PLACA FROM VEICULO ORDER BY MODELO";
                    using (var cmd = new SQLiteDataAdapter(searchQuery, connect))
                    {

                        DataTable tabelaVeiculos = new DataTable();

                        cmd.Fill(tabelaVeiculos);

                        cb_vehicle.DataSource = tabelaVeiculos;

                        cb_vehicle.DisplayMember = "DESCRICAO";

                        cb_vehicle.ValueMember = "PLACA";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void searchRoute()
        {
            try
            {
                using (var connect = new SQLiteConnection(connectionString))
                {
                    connect.Open();
                    string searchQuery = "SELECT (ORIGEM || ' - Até - ' || DESTINO) AS DESCRICAO, ORIGEM FROM ROTA ORDER BY ORIGEM";
                    using (var cmd = new SQLiteDataAdapter(searchQuery, connect))
                    {
                        DataTable tabelaRotas = new DataTable();
                        cmd.Fill(tabelaRotas);
                        cb_travel.DataSource = tabelaRotas;
                        cb_travel.DisplayMember = "DESCRICAO";
                        cb_travel.ValueMember = "ORIGEM";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void searchDriver()
        {
            try
            {
                using (var connect = new SQLiteConnection(connectionString))
                {
                    connect.Open();
                    string searchQuery = "SELECT(NOME || ' - CNH: ' || CNH) AS NOME, CNH FROM MOTORISTA ORDER BY NOME";
                    using (var cmd = new SQLiteDataAdapter(searchQuery, connect))
                    {
                        DataTable tabelaMotoristas = new DataTable();
                        cmd.Fill(tabelaMotoristas);
                        cb_driver.DataSource = tabelaMotoristas;
                        cb_driver.DisplayMember = "NOME";
                        cb_driver.ValueMember = "CNH";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void comboBox2_DropDown(object sender, EventArgs e)
        {
            searchVehicle();
        }

        private void comboBox3_DropDown(object sender, EventArgs e)
        {
            searchRoute();
        }

        private void comboBox4_DropDown(object sender, EventArgs e)
        {
            searchDriver();
        }

    
    }
}