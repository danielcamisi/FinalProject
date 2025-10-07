namespace FinalProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ID_Vehicle_Txt = new TextBox();
            Txt_Vehicle_Model = new TextBox();
            Txt_Avarage = new TextBox();
            tabControl1 = new TabControl();
            CarPage = new TabPage();
            txtmsk_plate = new MaskedTextBox();
            Txt_Max_Weight = new TextBox();
            DriverPage = new TabPage();
            label24 = new Label();
            txtmsk_phone = new MaskedTextBox();
            txtmsk_driverlicense = new MaskedTextBox();
            Txt_DriverName = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            Txt_Driver_ID = new TextBox();
            RoutePage = new TabPage();
            Txt_RouteOrigin = new TextBox();
            Txt_RouteDestiny = new TextBox();
            label10 = new Label();
            label11 = new Label();
            Txt_RoutePath = new TextBox();
            label12 = new Label();
            label13 = new Label();
            Txt_Route_ID = new TextBox();
            FuelPage = new TabPage();
            txtmsk_fuelprice = new MaskedTextBox();
            cb_TypeFuel = new ComboBox();
            DateTimeFuel = new DateTimePicker();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            Txt_FuelId = new TextBox();
            TravelPage = new TabPage();
            cb_situation = new ComboBox();
            cb_travel = new ComboBox();
            cb_driver = new ComboBox();
            label23 = new Label();
            label22 = new Label();
            cb_vehicle = new ComboBox();
            DateTimeStartTravel = new DateTimePicker();
            DateTimeBring = new DateTimePicker();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            Txt_TravelID = new TextBox();
            panel1 = new Panel();
            btn_delete = new Button();
            btn_search = new Button();
            btn_edit = new Button();
            btn_save = new Button();
            label25 = new Label();
            tabControl1.SuspendLayout();
            CarPage.SuspendLayout();
            DriverPage.SuspendLayout();
            RoutePage.SuspendLayout();
            FuelPage.SuspendLayout();
            TravelPage.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F);
            label1.Location = new Point(88, 179);
            label1.Name = "label1";
            label1.Size = new Size(104, 22);
            label1.TabIndex = 0;
            label1.Text = "Veículo ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14.25F);
            label2.Location = new Point(88, 225);
            label2.Name = "label2";
            label2.Size = new Size(174, 22);
            label2.TabIndex = 1;
            label2.Text = "Modelo do Veículo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14.25F);
            label3.Location = new Point(88, 271);
            label3.Name = "label3";
            label3.Size = new Size(158, 22);
            label3.TabIndex = 2;
            label3.Text = "Placa do Veículo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 14.25F);
            label4.Location = new Point(88, 324);
            label4.Name = "label4";
            label4.Size = new Size(217, 22);
            label4.TabIndex = 3;
            label4.Text = "Consumo médio (Km/L):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 14.25F);
            label5.Location = new Point(88, 377);
            label5.Name = "label5";
            label5.Size = new Size(176, 22);
            label5.TabIndex = 4;
            label5.Text = "Carga Máxima (Kg):";
            // 
            // ID_Vehicle_Txt
            // 
            ID_Vehicle_Txt.Location = new Point(325, 172);
            ID_Vehicle_Txt.Name = "ID_Vehicle_Txt";
            ID_Vehicle_Txt.ReadOnly = true;
            ID_Vehicle_Txt.Size = new Size(86, 29);
            ID_Vehicle_Txt.TabIndex = 5;
            // 
            // Txt_Vehicle_Model
            // 
            Txt_Vehicle_Model.Location = new Point(325, 222);
            Txt_Vehicle_Model.Name = "Txt_Vehicle_Model";
            Txt_Vehicle_Model.Size = new Size(154, 29);
            Txt_Vehicle_Model.TabIndex = 6;
            // 
            // Txt_Avarage
            // 
            Txt_Avarage.Location = new Point(325, 324);
            Txt_Avarage.MaxLength = 4;
            Txt_Avarage.Name = "Txt_Avarage";
            Txt_Avarage.Size = new Size(154, 29);
            Txt_Avarage.TabIndex = 8;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(CarPage);
            tabControl1.Controls.Add(DriverPage);
            tabControl1.Controls.Add(RoutePage);
            tabControl1.Controls.Add(FuelPage);
            tabControl1.Controls.Add(TravelPage);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1026, 517);
            tabControl1.TabIndex = 11;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // CarPage
            // 
            CarPage.BackColor = SystemColors.Control;
            CarPage.Controls.Add(txtmsk_plate);
            CarPage.Controls.Add(Txt_Vehicle_Model);
            CarPage.Controls.Add(label1);
            CarPage.Controls.Add(Txt_Max_Weight);
            CarPage.Controls.Add(label2);
            CarPage.Controls.Add(Txt_Avarage);
            CarPage.Controls.Add(label3);
            CarPage.Controls.Add(label4);
            CarPage.Controls.Add(ID_Vehicle_Txt);
            CarPage.Controls.Add(label5);
            CarPage.Font = new Font("Arial", 14.25F);
            CarPage.Location = new Point(4, 29);
            CarPage.Name = "CarPage";
            CarPage.Padding = new Padding(3);
            CarPage.Size = new Size(1018, 484);
            CarPage.TabIndex = 0;
            CarPage.Text = "Veículo";
            // 
            // txtmsk_plate
            // 
            txtmsk_plate.Location = new Point(325, 271);
            txtmsk_plate.Mask = "AAA-0A00";
            txtmsk_plate.Name = "txtmsk_plate";
            txtmsk_plate.Size = new Size(154, 29);
            txtmsk_plate.TabIndex = 10;
            // 
            // Txt_Max_Weight
            // 
            Txt_Max_Weight.Location = new Point(325, 374);
            Txt_Max_Weight.Name = "Txt_Max_Weight";
            Txt_Max_Weight.Size = new Size(154, 29);
            Txt_Max_Weight.TabIndex = 9;
            // 
            // DriverPage
            // 
            DriverPage.BackColor = SystemColors.Control;
            DriverPage.Controls.Add(label24);
            DriverPage.Controls.Add(txtmsk_phone);
            DriverPage.Controls.Add(txtmsk_driverlicense);
            DriverPage.Controls.Add(Txt_DriverName);
            DriverPage.Controls.Add(label6);
            DriverPage.Controls.Add(label7);
            DriverPage.Controls.Add(label8);
            DriverPage.Controls.Add(label9);
            DriverPage.Controls.Add(Txt_Driver_ID);
            DriverPage.Font = new Font("Arial", 14.25F);
            DriverPage.Location = new Point(4, 29);
            DriverPage.Name = "DriverPage";
            DriverPage.Padding = new Padding(3);
            DriverPage.Size = new Size(1018, 484);
            DriverPage.TabIndex = 1;
            DriverPage.Text = "Motorista";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Arial Narrow", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label24.ForeColor = Color.Coral;
            label24.Location = new Point(313, 307);
            label24.Name = "label24";
            label24.Size = new Size(101, 15);
            label24.TabIndex = 19;
            label24.Text = "Categoria após o barra";
            // 
            // txtmsk_phone
            // 
            txtmsk_phone.Location = new Point(313, 328);
            txtmsk_phone.Mask = "(00) 99999-9999";
            txtmsk_phone.Name = "txtmsk_phone";
            txtmsk_phone.Size = new Size(167, 29);
            txtmsk_phone.TabIndex = 18;
            // 
            // txtmsk_driverlicense
            // 
            txtmsk_driverlicense.Location = new Point(313, 275);
            txtmsk_driverlicense.Mask = "00000000000/AA";
            txtmsk_driverlicense.Name = "txtmsk_driverlicense";
            txtmsk_driverlicense.Size = new Size(167, 29);
            txtmsk_driverlicense.TabIndex = 17;
            // 
            // Txt_DriverName
            // 
            Txt_DriverName.Location = new Point(313, 229);
            Txt_DriverName.Name = "Txt_DriverName";
            Txt_DriverName.Size = new Size(167, 29);
            Txt_DriverName.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 14.25F);
            label6.Location = new Point(90, 180);
            label6.Name = "label6";
            label6.Size = new Size(117, 22);
            label6.TabIndex = 10;
            label6.Text = "Motorista ID:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 14.25F);
            label7.Location = new Point(90, 229);
            label7.Name = "label7";
            label7.Size = new Size(175, 22);
            label7.TabIndex = 11;
            label7.Text = "Nome do Motorista:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 14.25F);
            label8.Location = new Point(90, 278);
            label8.Name = "label8";
            label8.Size = new Size(164, 22);
            label8.TabIndex = 12;
            label8.Text = "CNH do Motorista:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 14.25F);
            label9.Location = new Point(90, 331);
            label9.Name = "label9";
            label9.Size = new Size(198, 22);
            label9.TabIndex = 13;
            label9.Text = "Telefone do Motorista:";
            // 
            // Txt_Driver_ID
            // 
            Txt_Driver_ID.Location = new Point(313, 179);
            Txt_Driver_ID.Name = "Txt_Driver_ID";
            Txt_Driver_ID.ReadOnly = true;
            Txt_Driver_ID.Size = new Size(167, 29);
            Txt_Driver_ID.TabIndex = 15;
            // 
            // RoutePage
            // 
            RoutePage.BackColor = SystemColors.Control;
            RoutePage.Controls.Add(Txt_RouteOrigin);
            RoutePage.Controls.Add(Txt_RouteDestiny);
            RoutePage.Controls.Add(label10);
            RoutePage.Controls.Add(label11);
            RoutePage.Controls.Add(Txt_RoutePath);
            RoutePage.Controls.Add(label12);
            RoutePage.Controls.Add(label13);
            RoutePage.Controls.Add(Txt_Route_ID);
            RoutePage.Font = new Font("Arial", 14.25F);
            RoutePage.Location = new Point(4, 29);
            RoutePage.Name = "RoutePage";
            RoutePage.Size = new Size(1018, 484);
            RoutePage.TabIndex = 2;
            RoutePage.Text = "Rota";
            // 
            // Txt_RouteOrigin
            // 
            Txt_RouteOrigin.Location = new Point(311, 228);
            Txt_RouteOrigin.Name = "Txt_RouteOrigin";
            Txt_RouteOrigin.Size = new Size(192, 29);
            Txt_RouteOrigin.TabIndex = 24;
            // 
            // Txt_RouteDestiny
            // 
            Txt_RouteDestiny.Location = new Point(311, 277);
            Txt_RouteDestiny.Name = "Txt_RouteDestiny";
            Txt_RouteDestiny.Size = new Size(192, 29);
            Txt_RouteDestiny.TabIndex = 25;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 14.25F);
            label10.Location = new Point(88, 179);
            label10.Name = "label10";
            label10.Size = new Size(80, 22);
            label10.TabIndex = 19;
            label10.Text = "Rota ID:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 14.25F);
            label11.Location = new Point(88, 228);
            label11.Name = "label11";
            label11.Size = new Size(149, 22);
            label11.TabIndex = 20;
            label11.Text = "Origem da Rota:";
            // 
            // Txt_RoutePath
            // 
            Txt_RoutePath.Location = new Point(311, 329);
            Txt_RoutePath.Name = "Txt_RoutePath";
            Txt_RoutePath.Size = new Size(192, 29);
            Txt_RoutePath.TabIndex = 26;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 14.25F);
            label12.Location = new Point(88, 277);
            label12.Name = "label12";
            label12.Size = new Size(151, 22);
            label12.TabIndex = 21;
            label12.Text = "Destino da Rota:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial", 14.25F);
            label13.Location = new Point(88, 330);
            label13.Name = "label13";
            label13.Size = new Size(163, 22);
            label13.TabIndex = 22;
            label13.Text = "Distância da Rota:";
            // 
            // Txt_Route_ID
            // 
            Txt_Route_ID.Location = new Point(311, 178);
            Txt_Route_ID.Name = "Txt_Route_ID";
            Txt_Route_ID.ReadOnly = true;
            Txt_Route_ID.Size = new Size(192, 29);
            Txt_Route_ID.TabIndex = 23;
            // 
            // FuelPage
            // 
            FuelPage.BackColor = SystemColors.Control;
            FuelPage.Controls.Add(txtmsk_fuelprice);
            FuelPage.Controls.Add(cb_TypeFuel);
            FuelPage.Controls.Add(DateTimeFuel);
            FuelPage.Controls.Add(label14);
            FuelPage.Controls.Add(label15);
            FuelPage.Controls.Add(label16);
            FuelPage.Controls.Add(label17);
            FuelPage.Controls.Add(Txt_FuelId);
            FuelPage.Font = new Font("Arial", 14.25F);
            FuelPage.Location = new Point(4, 29);
            FuelPage.Name = "FuelPage";
            FuelPage.Size = new Size(1018, 484);
            FuelPage.TabIndex = 3;
            FuelPage.Text = "Preço Combustível";
            // 
            // txtmsk_fuelprice
            // 
            txtmsk_fuelprice.Location = new Point(342, 331);
            txtmsk_fuelprice.Mask = "$ 00,00";
            txtmsk_fuelprice.Name = "txtmsk_fuelprice";
            txtmsk_fuelprice.Size = new Size(175, 29);
            txtmsk_fuelprice.TabIndex = 37;
            // 
            // cb_TypeFuel
            // 
            cb_TypeFuel.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_TypeFuel.FormattingEnabled = true;
            cb_TypeFuel.Items.AddRange(new object[] { "Etanol", "Diesel", "Gasolina", "Pódium" });
            cb_TypeFuel.Location = new Point(342, 223);
            cb_TypeFuel.Name = "cb_TypeFuel";
            cb_TypeFuel.Size = new Size(175, 30);
            cb_TypeFuel.TabIndex = 36;
            // 
            // DateTimeFuel
            // 
            DateTimeFuel.Format = DateTimePickerFormat.Short;
            DateTimeFuel.Location = new Point(342, 275);
            DateTimeFuel.MaxDate = new DateTime(2025, 10, 7, 0, 0, 0, 0);
            DateTimeFuel.MinDate = new DateTime(1999, 1, 1, 0, 0, 0, 0);
            DateTimeFuel.Name = "DateTimeFuel";
            DateTimeFuel.Size = new Size(175, 29);
            DateTimeFuel.TabIndex = 35;
            DateTimeFuel.Value = new DateTime(2025, 10, 7, 0, 0, 0, 0);
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial", 14.25F);
            label14.Location = new Point(88, 180);
            label14.Name = "label14";
            label14.Size = new Size(92, 22);
            label14.TabIndex = 27;
            label14.Text = "Comb ID:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Arial", 14.25F);
            label15.Location = new Point(88, 229);
            label15.Name = "label15";
            label15.Size = new Size(232, 22);
            label15.TabIndex = 28;
            label15.Text = "Combustível de Precomb:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Arial", 14.25F);
            label16.Location = new Point(88, 278);
            label16.Name = "label16";
            label16.Size = new Size(248, 22);
            label16.TabIndex = 29;
            label16.Text = "Data Consulta do Precomb: ";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Arial", 14.25F);
            label17.Location = new Point(88, 331);
            label17.Name = "label17";
            label17.Size = new Size(176, 22);
            label17.TabIndex = 30;
            label17.Text = "Preço do Precomb:";
            // 
            // Txt_FuelId
            // 
            Txt_FuelId.Location = new Point(342, 176);
            Txt_FuelId.Name = "Txt_FuelId";
            Txt_FuelId.ReadOnly = true;
            Txt_FuelId.Size = new Size(175, 29);
            Txt_FuelId.TabIndex = 31;
            // 
            // TravelPage
            // 
            TravelPage.BackColor = SystemColors.Control;
            TravelPage.Controls.Add(label25);
            TravelPage.Controls.Add(cb_situation);
            TravelPage.Controls.Add(cb_travel);
            TravelPage.Controls.Add(cb_driver);
            TravelPage.Controls.Add(label23);
            TravelPage.Controls.Add(label22);
            TravelPage.Controls.Add(cb_vehicle);
            TravelPage.Controls.Add(DateTimeStartTravel);
            TravelPage.Controls.Add(DateTimeBring);
            TravelPage.Controls.Add(label18);
            TravelPage.Controls.Add(label19);
            TravelPage.Controls.Add(label20);
            TravelPage.Controls.Add(label21);
            TravelPage.Controls.Add(Txt_TravelID);
            TravelPage.Font = new Font("Arial", 14.25F);
            TravelPage.Location = new Point(4, 29);
            TravelPage.Name = "TravelPage";
            TravelPage.Size = new Size(1018, 484);
            TravelPage.TabIndex = 4;
            TravelPage.Text = "Viagem";
            // 
            // cb_situation
            // 
            cb_situation.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_situation.FormattingEnabled = true;
            cb_situation.Items.AddRange(new object[] { "Em Agendamento", "Em Andamento", "Recluso", "Entregue", "Cancelado" });
            cb_situation.Location = new Point(629, 136);
            cb_situation.Name = "cb_situation";
            cb_situation.Size = new Size(221, 30);
            cb_situation.TabIndex = 51;
            // 
            // cb_travel
            // 
            cb_travel.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_travel.FormattingEnabled = true;
            cb_travel.Location = new Point(350, 339);
            cb_travel.Name = "cb_travel";
            cb_travel.Size = new Size(500, 30);
            cb_travel.TabIndex = 50;
            // 
            // cb_driver
            // 
            cb_driver.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_driver.FormattingEnabled = true;
            cb_driver.Location = new Point(350, 392);
            cb_driver.Name = "cb_driver";
            cb_driver.Size = new Size(500, 30);
            cb_driver.TabIndex = 49;
            cb_driver.DropDown += comboBox4_DropDown;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Arial", 14.25F);
            label23.Location = new Point(88, 392);
            label23.Name = "label23";
            label23.Size = new Size(92, 22);
            label23.TabIndex = 48;
            label23.Text = "Motorista:";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Arial", 14.25F);
            label22.Location = new Point(88, 342);
            label22.Name = "label22";
            label22.Size = new Size(151, 22);
            label22.TabIndex = 46;
            label22.Text = "Rota da Viagem:";
            // 
            // cb_vehicle
            // 
            cb_vehicle.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_vehicle.FormattingEnabled = true;
            cb_vehicle.Location = new Point(350, 289);
            cb_vehicle.Name = "cb_vehicle";
            cb_vehicle.Size = new Size(500, 30);
            cb_vehicle.TabIndex = 45;
            cb_vehicle.DropDown += comboBox2_DropDown;
            // 
            // DateTimeStartTravel
            // 
            DateTimeStartTravel.Format = DateTimePickerFormat.Short;
            DateTimeStartTravel.Location = new Point(350, 188);
            DateTimeStartTravel.MinDate = new DateTime(2025, 10, 1, 0, 0, 0, 0);
            DateTimeStartTravel.Name = "DateTimeStartTravel";
            DateTimeStartTravel.Size = new Size(193, 29);
            DateTimeStartTravel.TabIndex = 44;
            DateTimeStartTravel.Value = new DateTime(2025, 10, 6, 0, 0, 0, 0);
            // 
            // DateTimeBring
            // 
            DateTimeBring.Format = DateTimePickerFormat.Short;
            DateTimeBring.Location = new Point(350, 238);
            DateTimeBring.MinDate = new DateTime(2025, 10, 6, 0, 0, 0, 0);
            DateTimeBring.Name = "DateTimeBring";
            DateTimeBring.Size = new Size(193, 29);
            DateTimeBring.TabIndex = 43;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Arial", 14.25F);
            label18.Location = new Point(88, 139);
            label18.Name = "label18";
            label18.Size = new Size(105, 22);
            label18.TabIndex = 37;
            label18.Text = "Viagem ID:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Arial", 14.25F);
            label19.Location = new Point(88, 188);
            label19.Name = "label19";
            label19.Size = new Size(232, 22);
            label19.TabIndex = 38;
            label19.Text = "Data de Saída da Viagem:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Arial", 14.25F);
            label20.Location = new Point(88, 237);
            label20.Name = "label20";
            label20.Size = new Size(259, 22);
            label20.TabIndex = 39;
            label20.Text = "Data de Chegada da Viagem:";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Arial", 14.25F);
            label21.Location = new Point(88, 290);
            label21.Name = "label21";
            label21.Size = new Size(175, 22);
            label21.TabIndex = 40;
            label21.Text = "Veículo da Viagem:";
            // 
            // Txt_TravelID
            // 
            Txt_TravelID.Location = new Point(350, 139);
            Txt_TravelID.Name = "Txt_TravelID";
            Txt_TravelID.ReadOnly = true;
            Txt_TravelID.Size = new Size(105, 29);
            Txt_TravelID.TabIndex = 41;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(btn_delete);
            panel1.Controls.Add(btn_search);
            panel1.Controls.Add(btn_edit);
            panel1.Controls.Add(btn_save);
            panel1.ForeColor = Color.Transparent;
            panel1.Location = new Point(4, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(1018, 90);
            panel1.TabIndex = 10;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.Transparent;
            btn_delete.BackgroundImage = (Image)resources.GetObject("btn_delete.BackgroundImage");
            btn_delete.BackgroundImageLayout = ImageLayout.Stretch;
            btn_delete.Cursor = Cursors.Hand;
            btn_delete.Enabled = false;
            btn_delete.Location = new Point(250, 3);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(75, 84);
            btn_delete.TabIndex = 3;
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_search
            // 
            btn_search.BackColor = Color.Transparent;
            btn_search.BackgroundImage = (Image)resources.GetObject("btn_search.BackgroundImage");
            btn_search.BackgroundImageLayout = ImageLayout.Stretch;
            btn_search.Location = new Point(169, 3);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(75, 84);
            btn_search.TabIndex = 2;
            btn_search.UseVisualStyleBackColor = false;
            btn_search.Click += btn_search_Click;
            // 
            // btn_edit
            // 
            btn_edit.BackColor = Color.Transparent;
            btn_edit.BackgroundImage = (Image)resources.GetObject("btn_edit.BackgroundImage");
            btn_edit.BackgroundImageLayout = ImageLayout.Stretch;
            btn_edit.Enabled = false;
            btn_edit.Location = new Point(88, 3);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(75, 84);
            btn_edit.TabIndex = 1;
            btn_edit.UseVisualStyleBackColor = false;
            btn_edit.Click += btn_edit_Click;
            // 
            // btn_save
            // 
            btn_save.BackColor = Color.Transparent;
            btn_save.BackgroundImage = (Image)resources.GetObject("btn_save.BackgroundImage");
            btn_save.BackgroundImageLayout = ImageLayout.Stretch;
            btn_save.Location = new Point(7, 3);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(75, 84);
            btn_save.TabIndex = 0;
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Click += btn_save_Click;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(555, 139);
            label25.Name = "label25";
            label25.Size = new Size(68, 22);
            label25.TabIndex = 52;
            label25.Text = "Status:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1026, 517);
            Controls.Add(panel1);
            Controls.Add(tabControl1);
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestão de Logística";
            WindowState = FormWindowState.Maximized;
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            CarPage.ResumeLayout(false);
            CarPage.PerformLayout();
            DriverPage.ResumeLayout(false);
            DriverPage.PerformLayout();
            RoutePage.ResumeLayout(false);
            RoutePage.PerformLayout();
            FuelPage.ResumeLayout(false);
            FuelPage.PerformLayout();
            TravelPage.ResumeLayout(false);
            TravelPage.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox ID_Vehicle_Txt;
        private TextBox Txt_Vehicle_Model;
        private TextBox Txt_Avarage;
        private TabControl tabControl1;
        private TabPage CarPage;
        private TabPage DriverPage;
        private TabPage RoutePage;
        private TabPage FuelPage;
        private TabPage TravelPage;
        private Panel panel1;
        private Button btn_delete;
        private Button btn_search;
        private Button btn_edit;
        private Button btn_save;
        private TextBox Txt_DriverName;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox Txt_Driver_ID;
        private TextBox Txt_RouteOrigin;
        private TextBox Txt_RouteDestiny;
        private Label label10;
        private Label label11;
        private TextBox Txt_RoutePath;
        private Label label12;
        private Label label13;
        private TextBox Txt_Route_ID;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private TextBox Txt_FuelId;
        private DateTimePicker DateTimeFuel;
        private ComboBox cb_TypeFuel;
        private DateTimePicker DateTimeBring;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private TextBox Txt_TravelID;
        private DateTimePicker DateTimeStartTravel;
        private ComboBox cb_driver;
        private Label label23;
        private Label label22;
        private ComboBox cb_vehicle;
        private MaskedTextBox txtmsk_plate;
        private TextBox Txt_Max_Weight;
        private MaskedTextBox txtmsk_phone;
        private MaskedTextBox txtmsk_driverlicense;
        private Label label24;
        private ComboBox cb_travel;
        private MaskedTextBox txtmsk_fuelprice;
        private ComboBox cb_situation;
        private Label label25;
    }
}
