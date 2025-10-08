using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using static FinalProject.Form2;
using static FinalProject.Form3;
using static FinalProject.Form4;
using static FinalProject.Form5;
using static FinalProject.Form6;

namespace FinalProject
{
    public partial class Form1 : Form
    {

        string dbPath = @"C:\Users\daniel.csilva66\Downloads\logistica.db";

        string connectionString;
        public Form1()
        {
            InitializeComponent();
            connectionString = $"Data Source={dbPath};Version=3;";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ConnectDb();
            searchDriver();
            searchRoute();
            searchVehicle();
            panel1.Width = 2000;
        }
        private void ConnectDb()
        {
            try
            {
                using (var connect = new SQLiteConnection(connectionString))
                {
                    connect.Open();
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

        private void btn_edit_Click(object sender, EventArgs e)
        {
            editForm();
        }

        private void editForm()
        {
            int indice = tabControl1.SelectedIndex;
            if (indice == 0)
            {
                if (!double.TryParse(Txt_Avarage.Text.Replace(",", "."),
                  System.Globalization.NumberStyles.Any,
                  System.Globalization.CultureInfo.InvariantCulture, out _))
                {
                    MessageBox.Show("Digite um número válido (ex: 12,5 ou 12.5).");
                    return;
                }

                if (!double.TryParse(Txt_Max_Weight.Text.Replace(",", "."),
                  System.Globalization.NumberStyles.Any,
                  System.Globalization.CultureInfo.InvariantCulture, out _))
                {
                    MessageBox.Show("Digite um número válido (ex: 3000,5 ou 3000.5).");
                    return;
                }


                if (Txt_Vehicle_Model.Text.Length == 0 || txtmsk_plate.Text.Length == 0 || Txt_Avarage.Text.Length == 0 || Txt_Max_Weight.Text.Length == 0)
                {
                    MessageBox.Show("Por favor preencha todos os campos.", "Atenção ao Editar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {
                    using (var connect = new SQLiteConnection(connectionString))
                    {
                        connect.Open();
                        string updateQuery = "UPDATE VEICULO SET MODELO = @Modelo, CONSUMO_MEDIO = @ConsMedio, CARGA_MAXIMA = @CargaMax WHERE VEICULOID = @VeiculoID";
                        using (var cmd = new SQLiteCommand(updateQuery, connect))
                        {
                            cmd.Parameters.AddWithValue("@VeiculoID", ID_Vehicle_Txt.Text);
                            cmd.Parameters.AddWithValue("@Modelo", Txt_Vehicle_Model.Text);
                            cmd.Parameters.AddWithValue("@ConsMedio", Txt_Avarage.Text);
                            cmd.Parameters.AddWithValue("@CargaMax", Txt_Max_Weight.Text);
                            cmd.Parameters.AddWithValue("@Placa", txtmsk_plate.Text);
                            cmd.ExecuteNonQuery();
                        }
                        btn_delete.Enabled = false;
                        btn_edit.Enabled = false;
                        txtmsk_plate.Enabled = true;
                        MessageBox.Show("Veículo editado com Sucesso!");
                        FieldsCleaning();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }
            else if (indice == 1)
            {

                if (Txt_DriverName.Text.Length == 0 || txtmsk_driverlicense.Text.Length == 0 || txtmsk_phone.Text.Length == 0)
                {
                    MessageBox.Show("Por favor preencha todos os campos.", "Atenção ao Editar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {
                    using (var connect = new SQLiteConnection(connectionString))
                    {
                        connect.Open();
                        string updateQuery = "UPDATE MOTORISTA SET NOME = @Nome, TELEFONE = @Phone WHERE MOTORISTAID = @MotoristaID";
                        using (var cmd = new SQLiteCommand(updateQuery, connect))
                        {
                            cmd.Parameters.AddWithValue("@MotoristaID", Txt_Driver_ID.Text);
                            cmd.Parameters.AddWithValue("@Nome", Txt_DriverName.Text);
                            cmd.Parameters.AddWithValue("@Phone", txtmsk_phone.Text);
                            cmd.Parameters.AddWithValue("@CNH", txtmsk_driverlicense.Text);
                            cmd.ExecuteNonQuery();
                        }
                        btn_delete.Enabled = false;
                        btn_edit.Enabled = false;
                        txtmsk_driverlicense.Enabled = true;


                        MessageBox.Show("Motorista editado com sucesso!");
                        FieldsCleaning();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else if (indice == 2)
            {

                if (Txt_RouteOrigin.Text.Length == 0 || Txt_RouteDestiny.Text.Length == 0 || Txt_RoutePath.Text.Length == 0)
                {
                    MessageBox.Show("Por favor preencha todos os campos.", "Atenção ao Editar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {
                    using (var connect = new SQLiteConnection(connectionString))
                    {
                        connect.Open();
                        string updateQuery = "UPDATE ROTA SET DESTINO = @Destino, DISTANCIA = @Dist, ORIGEM = @Origem WHERE ROTAID = @RotaID";
                        using (var cmd = new SQLiteCommand(updateQuery, connect))
                        {
                            cmd.Parameters.AddWithValue("@RotaID", Txt_Route_ID.Text);
                            cmd.Parameters.AddWithValue("@Destino", Txt_RouteDestiny.Text);
                            cmd.Parameters.AddWithValue("@Dist", Txt_RoutePath.Text);
                            cmd.Parameters.AddWithValue("@Origem", Txt_RouteOrigin.Text);
                            cmd.ExecuteNonQuery();
                        }
                        btn_delete.Enabled = false;
                        btn_edit.Enabled = false;

                        MessageBox.Show("Rota editada com sucesso");
                        FieldsCleaning();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else if (indice == 3)
            {
                if (cb_TypeFuel.SelectedIndex == -1 || txtmsk_fuelprice.Text.Length == 0)
                {
                    MessageBox.Show("Por favor preencha todos os campos.", "Atenção ao Editar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {
                    using (var connect = new SQLiteConnection(connectionString))
                    {
                        connect.Open();
                        string updateQuery = "UPDATE PRECO_COMBUSTIVEL SET COMBUSTIVEL = @Combustível, PRECO = @Preco, DATA_CONSULTA = @DataConsulta WHERE PRECOID = @PrecoID";
                        using (var cmd = new SQLiteCommand(updateQuery, connect))
                        {
                            cmd.Parameters.AddWithValue("@PrecoID", Txt_FuelId.Text);
                            cmd.Parameters.AddWithValue("@Combustível", cb_TypeFuel.Text);
                            cmd.Parameters.AddWithValue("@Preco", txtmsk_fuelprice.Text);
                            cmd.Parameters.AddWithValue("@DataConsulta", DateTimeFuel.Value.ToString("yyyy-MM-dd"));
                            cmd.Parameters.AddWithValue("@Combustivel", Txt_FuelId.Text);
                            cmd.ExecuteNonQuery();
                        }
                        btn_delete.Enabled = false;
                        btn_edit.Enabled = false;

                        MessageBox.Show("Combustível editado com sucesso");
                        FieldsCleaning();
                    }

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
                        string updateQuery = "UPDATE VIAGEM SET DATA_SAIDA = @DataSaida, DATA_CHEGADA = @DataChegada, VEICULOID = @Veiculo, SITUACAO = @Situacao, ROTAID = @Rota, MOTORISTAID = @Motorista WHERE VIAGEMID = @Viagem";
                        using (var cmd = new SQLiteCommand(updateQuery, connect))
                        {
                            cmd.Parameters.AddWithValue("@DataSaida", DateTimeStartTravel.Value.ToString("yyyy-MM-dd"));
                            cmd.Parameters.AddWithValue("@DataChegada", DateTimeBring.Value.ToString("yyyy-MM-dd"));
                            cmd.Parameters.AddWithValue("@Veiculo", cb_vehicle.SelectedValue);
                            cmd.Parameters.AddWithValue("@Rota", cb_travel.SelectedValue);
                            cmd.Parameters.AddWithValue("@Motorista", cb_driver.SelectedValue);
                            cmd.Parameters.AddWithValue("@Viagem", Txt_TravelID.Text);
                            cmd.Parameters.AddWithValue("@Situacao", cb_situation.SelectedValue);

                            if (cb_situation.SelectedIndex == 0)
                            {
                                cmd.Parameters.AddWithValue("@Situacao", "Em Agendamento");
                            }
                            else if (cb_situation.SelectedIndex == 1)
                            {
                                cmd.Parameters.AddWithValue("@Situacao", "Em Andamento");
                            }
                            else if (cb_situation.SelectedIndex == 2)
                            {
                                cmd.Parameters.AddWithValue("@Situacao", "Recluso");
                            }
                            else if (cb_situation.SelectedIndex == 3)
                            {
                                cmd.Parameters.AddWithValue("@Situacao", "Entregue");
                            }
                            else if (cb_situation.SelectedIndex == 4)
                            {
                                cmd.Parameters.AddWithValue("@Situacao", "Cancelado");
                            }
                            else if (cb_situation.SelectedIndex == -1)
                            {
                                cmd.Parameters.AddWithValue("@Situacao", "Em Agendamento");
                            }
                            cmd.ExecuteNonQuery();
                        }
                        btn_delete.Enabled = false;
                        btn_edit.Enabled = false;
                        MessageBox.Show("Viagem editada com Sucesso");
                        FieldsCleaning();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }
        }


        private void deleteForm()
        {
            int indice = tabControl1.SelectedIndex;
            if (indice == 0)
            {
                try
                {
                    using (var connect = new SQLiteConnection(connectionString))
                    {
                        connect.Open();
                        string deleteQuery = "DELETE FROM VEICULO WHERE VEICULOID = @VeiculoID";
                        using (var cmd = new SQLiteCommand(deleteQuery, connect))
                        {
                            cmd.Parameters.AddWithValue("@VeiculoID", ID_Vehicle_Txt.Text);
                            cmd.Parameters.AddWithValue("@Placa", txtmsk_plate.Text);
                            cmd.ExecuteNonQuery();
                        }

                        btn_delete.Enabled = false;
                        btn_edit.Enabled = false;
                        txtmsk_plate.Enabled = true;
                        MessageBox.Show("Veículo deletado com sucesso!");
                        FieldsCleaning();
                    }

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
                        string deleteQuery = "DELETE FROM MOTORISTA WHERE CNH = @CNH";
                        using (var cmd = new SQLiteCommand(deleteQuery, connect))
                        {
                            cmd.Parameters.AddWithValue("@CNH", txtmsk_plate.Text);
                            cmd.ExecuteNonQuery();
                        }
                        btn_delete.Enabled = false;
                        btn_edit.Enabled = false;
                        txtmsk_driverlicense.Enabled = true;
                        MessageBox.Show("Motorista deletado com sucesso!");
                        FieldsCleaning();
                    }
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
                        string deleteQuery = "DELETE FROM ROTA WHERE ORIGEM = @Origem";
                        using (var cmd = new SQLiteCommand(deleteQuery, connect))
                        {
                            cmd.Parameters.AddWithValue("@Origem", Txt_RouteOrigin.Text);
                            cmd.ExecuteNonQuery();
                        }
                        btn_delete.Enabled = false;
                        btn_edit.Enabled = false;
                        MessageBox.Show("Rota deletada com sucesso!");
                        FieldsCleaning();
                    }
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
                        string deleteQuery = "DELETE FROM PRECO_COMBUSTIVEL WHERE PRECOID = @Combustivel";
                        using (var cmd = new SQLiteCommand(deleteQuery, connect))
                        {
                            cmd.Parameters.AddWithValue("@Combustivel", Txt_FuelId.Text);
                            cmd.ExecuteNonQuery();
                        }
                        btn_delete.Enabled = false;
                        btn_edit.Enabled = false;
                        MessageBox.Show("Preço de combustível deletado com sucesso!");
                        FieldsCleaning();
                    }

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
                        string deleteQuery = "DELETE FROM VIAGEM WHERE VIAGEMID = @Viagem";
                        using (var cmd = new SQLiteCommand(deleteQuery, connect))
                        {
                            cmd.Parameters.AddWithValue("@Viagem", Txt_TravelID.Text);
                            cmd.ExecuteNonQuery();
                        }
                        btn_delete.Enabled = false;
                        btn_edit.Enabled = false;
                        MessageBox.Show("Viagem deletada com sucesso!");
                        FieldsCleaning();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void DataBridgeVehicle(VehicleDatas vehicle)
        {
            ID_Vehicle_Txt.Text = vehicle.VehicleId;
            Txt_Vehicle_Model.Text = vehicle.Model;
            txtmsk_plate.Text = vehicle.Plate;
            Txt_Avarage.Text = vehicle.AverageCons;
            Txt_Max_Weight.Text = vehicle.MaxLoad;


        }

        private void DataBridgeDriver(DriverDatas driver)
        {
            Txt_Driver_ID.Text = driver.DriverId;
            Txt_DriverName.Text = driver.Name;
            txtmsk_driverlicense.Text = driver.Cnh;
            txtmsk_phone.Text = driver.Phone;
        }

        private void DataBridgeRoute(RoutesDatas route)
        {
            Txt_Route_ID.Text = route.RouteId;
            Txt_RouteOrigin.Text = route.Origin;
            Txt_RouteDestiny.Text = route.Destination;
            Txt_RoutePath.Text = route.Distance;
        }

        private void DataBridgeFuel(FuelDatas fuel)
        {
            Txt_FuelId.Text = fuel.FuelId;
            cb_TypeFuel.Text = fuel.Type;
            txtmsk_fuelprice.Text = fuel.Price;
            DateTimeFuel.Value = DateTime.Parse(fuel.DateSearch);
        }

        private void DataBridgeTravel(TravelDatas travel)
        {
            //Vehicles Vars
            string Plate = travel.Plate;
            string Model = travel.Model;
            string VehicleID = travel.VehicleId;

            // Driver Vars
            string Name = travel.name;
            string cnh = travel.cnh;
            string DriverID = travel.DriverId;

            // Route Vars
            string Origin = travel.Origin;
            string Destination = travel.path;
            string RouteID = travel.RouteId;



            cb_situation.Text = travel.Situation;
            Txt_TravelID.Text = travel.TravelId;
            DateTimeStartTravel.Value = DateTime.Parse(travel.DepartureDate);
            DateTimeBring.Value = DateTime.Parse(travel.ArrivalDate);

            if (int.TryParse(VehicleID, out int vId))
            {
                cb_vehicle.SelectedValue = vId;
            }

            if (int.TryParse(RouteID, out int rId))
            {
                cb_travel.SelectedValue = rId;
            }

            if (int.TryParse(DriverID, out int dId))
            {
                cb_driver.SelectedValue = dId;
            }

        }
        private void searchForm()
        {
            int indice = tabControl1.SelectedIndex;
            if (indice == 0)
            {
                using (Form2 frm2 = new Form2())
                {
                    var resultado = frm2.ShowDialog();
                    if (resultado == DialogResult.OK)
                    {
                        VehicleDatas vehicle = frm2.VehicleSelected;
                        if (vehicle != null)
                        {

                            DataBridgeVehicle(vehicle);
                            btn_delete.Enabled = true;
                            btn_edit.Enabled = true;
                            txtmsk_plate.Enabled = false;
                        }
                    }
                    else
                    {

                    }
                }
                this.Show();
            }
            else if (indice == 1)
            {
                using (Form3 frm3 = new Form3())
                {
                    var resultado = frm3.ShowDialog();
                    if (resultado == DialogResult.OK)
                    {
                        DriverDatas driver = frm3.driverDataSelected;
                        if (driver != null)
                        {
                            DataBridgeDriver(driver);
                            btn_delete.Enabled = true;
                            btn_edit.Enabled = true;
                            txtmsk_driverlicense.Enabled = false;

                        }
                    }

                }


            }
            else if (indice == 2)
            {
                using (Form4 frm4 = new Form4())
                {
                    var resultado = frm4.ShowDialog();
                    if (resultado == DialogResult.OK)
                    {
                        RoutesDatas routes = frm4.routeDataSelected;
                        if (routes != null)
                        {
                            DataBridgeRoute(routes);
                            btn_delete.Enabled = true;
                            btn_edit.Enabled = true;
                        }
                    }
                }
            }
            else if (indice == 3)
            {
                using (Form5 frm5 = new Form5())
                {
                    var resultado = frm5.ShowDialog();
                    if (resultado == DialogResult.OK)
                    {
                        FuelDatas fuel = frm5.fuelDataSelected;
                        if (fuel != null)
                        {
                            DataBridgeFuel(fuel);
                            btn_delete.Enabled = true;
                            btn_edit.Enabled = true;
                        }
                    }
                }
            }
            else if (indice == 4)
            {
                using (Form6 frm6 = new Form6())
                {
                    var resultado = frm6.ShowDialog();
                    if (resultado == DialogResult.OK)
                    {
                        TravelDatas travel = frm6.TravelSelected;
                        if (travel != null)
                        {
                            DataBridgeTravel(travel);
                            btn_delete.Enabled = true;
                            btn_edit.Enabled = true;
                        }
                    }
                }
            }
        }

        private void includingForm()
        {
            int indice = tabControl1.SelectedIndex;

            if (indice == 0)
            {

                if (!double.TryParse(Txt_Avarage.Text.Replace(",", "."),
                    System.Globalization.NumberStyles.Any,
                    System.Globalization.CultureInfo.InvariantCulture, out _))
                {
                    MessageBox.Show("Digite um número válido (ex: 12,5 ou 12.5).", "Atenção ao Inserir!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                if (!double.TryParse(Txt_Max_Weight.Text.Replace(",", "."),
                  System.Globalization.NumberStyles.Any,
                  System.Globalization.CultureInfo.InvariantCulture, out _))
                {
                    MessageBox.Show("Digite um número válido (ex: 3000,5 ou 3000.5).", "Atenção ao Inserir!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (Txt_Vehicle_Model.Text.Length == 0 || txtmsk_plate.Text.Length == 0 || Txt_Avarage.Text.Length == 0 || Txt_Max_Weight.Text.Length == 0)
                {
                    MessageBox.Show("Por favor preencha todos os campos.", "Atenção ao Inserir!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

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
                            cmd.Parameters.AddWithValue("@Placa", txtmsk_plate.Text);
                            cmd.Parameters.AddWithValue("@ConsMedio", Txt_Avarage.Text);
                            cmd.Parameters.AddWithValue("@CargaMax", Txt_Max_Weight.Text);

                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Veículo salvo com Sucesso!");
                    FieldsCleaning();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else if (indice == 1)
            {

                if (Txt_DriverName.Text.Length == 0 || txtmsk_driverlicense.Text.Length == 0 || txtmsk_phone.Text.Length == 0)
                {
                    MessageBox.Show("Por favor preencha todos os campos.", "Atenção ao Inserir!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
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
                            cmd.Parameters.AddWithValue("@CNH", txtmsk_driverlicense.Text);
                            cmd.Parameters.AddWithValue("@Phone", txtmsk_phone.Text);

                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Motorista salvo com Sucesso!");
                    FieldsCleaning();
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
                    if (Txt_RouteOrigin.Text.Length == 0 || Txt_RouteDestiny.Text.Length == 0 || Txt_RoutePath.Text.Length == 0)
                    {
                        MessageBox.Show("Por favor preencha todos os campos.", "Atenção ao Inserir!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

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
                    MessageBox.Show("Nova rota salva com Sucesso!");
                    FieldsCleaning();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else if (indice == 3)
            {

                if (cb_TypeFuel.SelectedIndex == -1 || txtmsk_fuelprice.Text.Length == 0)
                {
                    MessageBox.Show("Por favor preencha todos os campos.", "Atenção ao Inserir!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DateTime dataConsulta = DateTimeFuel.Value;
                DateTime dataHoje = DateTime.Today;

                if (dataConsulta != dataHoje)
                {
                    MessageBox.Show("A data de consulta deve ser a data de Hoje!.", "Atenção (Problemas nas Datas)", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
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
                            cmd.Parameters.AddWithValue("@DataConsulta", DateTimeFuel.Value.ToString("yyyy-MM-dd"));

                            string precoSuja = txtmsk_fuelprice.Text;


                            string precoLimpa = precoSuja
                                .Replace("R$", "")
                                .Trim()
                                .Replace(",", ".");


                            if (double.TryParse(
                                    precoLimpa,
                                    System.Globalization.NumberStyles.Any,
                                    System.Globalization.CultureInfo.InvariantCulture,
                                    out double precoDouble))
                            {

                                cmd.Parameters.AddWithValue("@Preco", precoDouble);
                            }
                            else
                            {

                                MessageBox.Show("Erro na formatação do preço. Verifique o valor.");
                                return;
                            }

                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("O Preço de Combustível foi salvo com Sucesso!");
                    FieldsCleaning();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }
            else if (indice == 4)
            {

                if (cb_vehicle.SelectedIndex == -1 || cb_travel.SelectedIndex == -1 || cb_driver.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor preencha todos os campos.", "Atenção ao Inserir!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DateTime DataSaida = DateTimeStartTravel.Value;
                DateTime DataChegada = DateTimeBring.Value;

                DateTime Hoje = DateTime.Today;

                if (DataSaida < Hoje)
                {
                    MessageBox.Show("A Data de Saída não pode ser antes da data de Hoje.", "Atenção (Problemas nas Datas)", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (DataChegada < DataSaida)
                {
                    MessageBox.Show("A Data de Chegada não pode ser antes da Data de Saída.", "Atenção (Problemas nas Datas)", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

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
                            cmd.Parameters.AddWithValue("@Veiculo", cb_vehicle.SelectedValue);

                            if (cb_situation.SelectedIndex == 0)
                            {
                                cmd.Parameters.AddWithValue("@Situacao", "Em Agendamento");
                            }
                            else if (cb_situation.SelectedIndex == 1)
                            {
                                cmd.Parameters.AddWithValue("@Situacao", "Em Andamento");
                            }
                            else if (cb_situation.SelectedIndex == 2)
                            {
                                cmd.Parameters.AddWithValue("@Situacao", "Recluso");
                            }
                            else if (cb_situation.SelectedIndex == 3)
                            {
                                cmd.Parameters.AddWithValue("@Situacao", "Entregue");
                            }
                            else if (cb_situation.SelectedIndex == 4)
                            {
                                cmd.Parameters.AddWithValue("@Situacao", "Cancelado");
                            }
                            else if (cb_situation.SelectedIndex == -1)
                            {
                                cmd.Parameters.AddWithValue("@Situacao", "Em Agendamento");
                            }
                            cmd.Parameters.AddWithValue("@Rota", cb_travel.SelectedValue);
                            cmd.Parameters.AddWithValue("@Motorista", cb_driver.SelectedValue);

                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Nova viagem foi salva com Sucesso!");
                    FieldsCleaning();
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
                    string searchQuery = "SELECT (VEICULOID || ' - ' || MODELO || ' - ' || PLACA) AS DESCRICAO, VEICULOID FROM VEICULO ORDER BY MODELO";
                    using (var cmd = new SQLiteDataAdapter(searchQuery, connect))
                    {

                        DataTable tabelaVeiculos = new DataTable();

                        cmd.Fill(tabelaVeiculos);

                        cb_vehicle.DataSource = tabelaVeiculos;

                        cb_vehicle.DisplayMember = "DESCRICAO";

                        cb_vehicle.ValueMember = "VEICULOID";
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
                    string searchQuery = "SELECT (ROTAID || ' - ' || ORIGEM || ' - Até - ' || DESTINO) AS DESCRICAO, ROTAID FROM ROTA ORDER BY ORIGEM";
                    using (var cmd = new SQLiteDataAdapter(searchQuery, connect))
                    {
                        DataTable tabelaRotas = new DataTable();
                        cmd.Fill(tabelaRotas);
                        cb_travel.DataSource = tabelaRotas;
                        cb_travel.DisplayMember = "DESCRICAO";
                        cb_travel.ValueMember = "ROTAID";
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
                    string searchQuery = "SELECT(MOTORISTAID || ' - ' || NOME || ' - CNH: ' || CNH) AS NOME, MOTORISTAID FROM MOTORISTA ORDER BY NOME";
                    using (var cmd = new SQLiteDataAdapter(searchQuery, connect))
                    {
                        DataTable tabelaMotoristas = new DataTable();
                        cmd.Fill(tabelaMotoristas);
                        cb_driver.DataSource = tabelaMotoristas;
                        cb_driver.DisplayMember = "NOME";
                        cb_driver.ValueMember = "MOTORISTAID";
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

        private void FieldsCleaning()
        {
            //Veículo
            ID_Vehicle_Txt.Clear();
            Txt_Vehicle_Model.Clear();
            txtmsk_plate.Clear();
            Txt_Avarage.Clear();
            Txt_Max_Weight.Clear();

            //Motorista
            Txt_Driver_ID.Clear();
            Txt_DriverName.Clear();
            txtmsk_driverlicense.Clear();
            txtmsk_phone.Clear();

            //Rota
            Txt_Route_ID.Clear();
            Txt_RouteOrigin.Clear();
            Txt_RouteDestiny.Clear();
            Txt_RoutePath.Clear();

            //Preço Combustível
            Txt_FuelId.Clear();
            cb_TypeFuel.SelectedIndex = -1;
            DateTimeFuel.Value = DateTime.Today;
            txtmsk_fuelprice.Clear();

            //Viagem
            Txt_TravelID.Clear();
            DateTimeStartTravel.Value = DateTime.Today;
            DateTimeBring.Value = DateTime.Today;
            cb_vehicle.SelectedIndex = -1;
            cb_travel.SelectedIndex = -1;
            cb_driver.SelectedIndex = -1;
            cb_situation.SelectedIndex = -1;

            btn_delete.Enabled = false;
            btn_edit.Enabled = false;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FieldsCleaning();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}