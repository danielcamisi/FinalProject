using System.Data.SQLite;

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

        private void RecarregarFormulario()
        {
            this.Hide();
            var novoForm = new Form1(); // ou o nome do seu form
            novoForm.Show();
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
                    RecarregarFormulario();
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
                            cmd.Parameters.AddWithValue("@Combustível", Txt_RouteOrigin.Text);
                            cmd.Parameters.AddWithValue("@Preco", Txt_RouteDestiny.Text);
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
                        string insertQuery = @"INSERT INTO PRECO_COMBUSTIVEL (COMBUSTIVEL, PRECO, DATA_CONSULTA) " +
                            "VALUES (@Combustível, @Preco, @DataConsulta)";
                        using (var cmd = new SQLiteCommand(insertQuery, connect))
                        {
                            cmd.Parameters.AddWithValue("@Combustível", Txt_RouteOrigin.Text);
                            cmd.Parameters.AddWithValue("@Preco", Txt_RouteDestiny.Text);
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

        }



        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void searchVehicle()
        {
            try
            {
                using (var connect = new SQLiteConnection(connectionString))
                {
                    connect.Open();
                    string searchQuery = "SELECT * FROM VEICULO";
                    using (var cmd = new SQLiteCommand(searchQuery, connect))
                    {

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string model = reader["MODELO"].ToString();
                                string plate = reader["PLACA"].ToString();
                                string novoItem = $"{model} - {plate}";

                                bool existe = false;
                                foreach (string item in comboBox2.Items)
                                {
                                    if (item.EndsWith(plate))
                                    {
                                        existe = true;
                                        break;
                                    }
                                }

                                if (!existe)
                                {
                                    comboBox2.Items.Add(novoItem);
                                }

                            }
                            else
                            {
                                MessageBox.Show("Vehicle not found.");
                            }
                        }
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
    }
}