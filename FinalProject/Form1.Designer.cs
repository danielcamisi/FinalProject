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
            Txt_Plate = new TextBox();
            Txt_Avarage = new TextBox();
            Txt_Max_Weight = new TextBox();
            tabControl1 = new TabControl();
            CarPage = new TabPage();
            DriverPage = new TabPage();
            Txt_DriverName = new TextBox();
            Txt_DriverLicense = new TextBox();
            label6 = new Label();
            label7 = new Label();
            Txt_DriverPhone = new TextBox();
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
            comboBox1 = new ComboBox();
            DateTimeFuel = new DateTimePicker();
            label14 = new Label();
            label15 = new Label();
            textBox16 = new TextBox();
            label16 = new Label();
            label17 = new Label();
            textBox17 = new TextBox();
            TravelPage = new TabPage();
            comboBox4 = new ComboBox();
            label23 = new Label();
            comboBox3 = new ComboBox();
            label22 = new Label();
            comboBox2 = new ComboBox();
            dateTimePicker3 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            textBox15 = new TextBox();
            pageSetupDialog1 = new PageSetupDialog();
            panel1 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            btn_save = new Button();
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
            label1.Location = new Point(45, 122);
            label1.Name = "label1";
            label1.Size = new Size(104, 22);
            label1.TabIndex = 0;
            label1.Text = "Veículo ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14.25F);
            label2.Location = new Point(45, 168);
            label2.Name = "label2";
            label2.Size = new Size(174, 22);
            label2.TabIndex = 1;
            label2.Text = "Modelo do Veículo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14.25F);
            label3.Location = new Point(45, 214);
            label3.Name = "label3";
            label3.Size = new Size(158, 22);
            label3.TabIndex = 2;
            label3.Text = "Placa do Veículo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 14.25F);
            label4.Location = new Point(45, 267);
            label4.Name = "label4";
            label4.Size = new Size(217, 22);
            label4.TabIndex = 3;
            label4.Text = "Consumo médio (Km/L):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 14.25F);
            label5.Location = new Point(45, 320);
            label5.Name = "label5";
            label5.Size = new Size(176, 22);
            label5.TabIndex = 4;
            label5.Text = "Carga Máxima (Kg):";
            // 
            // ID_Vehicle_Txt
            // 
            ID_Vehicle_Txt.Location = new Point(282, 115);
            ID_Vehicle_Txt.Name = "ID_Vehicle_Txt";
            ID_Vehicle_Txt.Size = new Size(108, 29);
            ID_Vehicle_Txt.TabIndex = 5;
            // 
            // Txt_Vehicle_Model
            // 
            Txt_Vehicle_Model.Location = new Point(282, 165);
            Txt_Vehicle_Model.Name = "Txt_Vehicle_Model";
            Txt_Vehicle_Model.Size = new Size(154, 29);
            Txt_Vehicle_Model.TabIndex = 6;
            // 
            // Txt_Plate
            // 
            Txt_Plate.Location = new Point(282, 214);
            Txt_Plate.Name = "Txt_Plate";
            Txt_Plate.Size = new Size(88, 29);
            Txt_Plate.TabIndex = 7;
            // 
            // Txt_Avarage
            // 
            Txt_Avarage.Location = new Point(282, 267);
            Txt_Avarage.Name = "Txt_Avarage";
            Txt_Avarage.Size = new Size(46, 29);
            Txt_Avarage.TabIndex = 8;
            // 
            // Txt_Max_Weight
            // 
            Txt_Max_Weight.Location = new Point(282, 317);
            Txt_Max_Weight.Name = "Txt_Max_Weight";
            Txt_Max_Weight.Size = new Size(88, 29);
            Txt_Max_Weight.TabIndex = 9;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(CarPage);
            tabControl1.Controls.Add(DriverPage);
            tabControl1.Controls.Add(RoutePage);
            tabControl1.Controls.Add(FuelPage);
            tabControl1.Controls.Add(TravelPage);
            tabControl1.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(12, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1002, 512);
            tabControl1.TabIndex = 11;
            // 
            // CarPage
            // 
            CarPage.BackColor = SystemColors.Control;
            CarPage.Controls.Add(Txt_Vehicle_Model);
            CarPage.Controls.Add(Txt_Plate);
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
            CarPage.Size = new Size(994, 479);
            CarPage.TabIndex = 0;
            CarPage.Text = "Veículo";
            // 
            // DriverPage
            // 
            DriverPage.Controls.Add(Txt_DriverName);
            DriverPage.Controls.Add(Txt_DriverLicense);
            DriverPage.Controls.Add(label6);
            DriverPage.Controls.Add(label7);
            DriverPage.Controls.Add(Txt_DriverPhone);
            DriverPage.Controls.Add(label8);
            DriverPage.Controls.Add(label9);
            DriverPage.Controls.Add(Txt_Driver_ID);
            DriverPage.Location = new Point(4, 29);
            DriverPage.Name = "DriverPage";
            DriverPage.Padding = new Padding(3);
            DriverPage.Size = new Size(994, 479);
            DriverPage.TabIndex = 1;
            DriverPage.Text = "Motorista";
            DriverPage.UseVisualStyleBackColor = true;
            // 
            // Txt_DriverName
            // 
            Txt_DriverName.Location = new Point(288, 222);
            Txt_DriverName.Name = "Txt_DriverName";
            Txt_DriverName.Size = new Size(154, 26);
            Txt_DriverName.TabIndex = 16;
            // 
            // Txt_DriverLicense
            // 
            Txt_DriverLicense.Location = new Point(288, 271);
            Txt_DriverLicense.Name = "Txt_DriverLicense";
            Txt_DriverLicense.Size = new Size(154, 26);
            Txt_DriverLicense.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 14.25F);
            label6.Location = new Point(65, 173);
            label6.Name = "label6";
            label6.Size = new Size(117, 22);
            label6.TabIndex = 10;
            label6.Text = "Motorista ID:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 14.25F);
            label7.Location = new Point(65, 222);
            label7.Name = "label7";
            label7.Size = new Size(175, 22);
            label7.TabIndex = 11;
            label7.Text = "Nome do Motorista:";
            // 
            // Txt_DriverPhone
            // 
            Txt_DriverPhone.Location = new Point(288, 323);
            Txt_DriverPhone.Name = "Txt_DriverPhone";
            Txt_DriverPhone.Size = new Size(154, 26);
            Txt_DriverPhone.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 14.25F);
            label8.Location = new Point(65, 271);
            label8.Name = "label8";
            label8.Size = new Size(164, 22);
            label8.TabIndex = 12;
            label8.Text = "CNH do Motorista:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 14.25F);
            label9.Location = new Point(65, 324);
            label9.Name = "label9";
            label9.Size = new Size(198, 22);
            label9.TabIndex = 13;
            label9.Text = "Telefone do Motorista:";
            // 
            // Txt_Driver_ID
            // 
            Txt_Driver_ID.Location = new Point(288, 172);
            Txt_Driver_ID.Name = "Txt_Driver_ID";
            Txt_Driver_ID.Size = new Size(154, 26);
            Txt_Driver_ID.TabIndex = 15;
            // 
            // RoutePage
            // 
            RoutePage.Controls.Add(Txt_RouteOrigin);
            RoutePage.Controls.Add(Txt_RouteDestiny);
            RoutePage.Controls.Add(label10);
            RoutePage.Controls.Add(label11);
            RoutePage.Controls.Add(Txt_RoutePath);
            RoutePage.Controls.Add(label12);
            RoutePage.Controls.Add(label13);
            RoutePage.Controls.Add(Txt_Route_ID);
            RoutePage.Location = new Point(4, 29);
            RoutePage.Name = "RoutePage";
            RoutePage.Size = new Size(994, 479);
            RoutePage.TabIndex = 2;
            RoutePage.Text = "Rota";
            RoutePage.UseVisualStyleBackColor = true;
            // 
            // Txt_RouteOrigin
            // 
            Txt_RouteOrigin.Location = new Point(307, 194);
            Txt_RouteOrigin.Name = "Txt_RouteOrigin";
            Txt_RouteOrigin.Size = new Size(192, 26);
            Txt_RouteOrigin.TabIndex = 24;
            // 
            // Txt_RouteDestiny
            // 
            Txt_RouteDestiny.Location = new Point(307, 243);
            Txt_RouteDestiny.Name = "Txt_RouteDestiny";
            Txt_RouteDestiny.Size = new Size(192, 26);
            Txt_RouteDestiny.TabIndex = 25;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 14.25F);
            label10.Location = new Point(84, 145);
            label10.Name = "label10";
            label10.Size = new Size(80, 22);
            label10.TabIndex = 19;
            label10.Text = "Rota ID:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 14.25F);
            label11.Location = new Point(84, 194);
            label11.Name = "label11";
            label11.Size = new Size(149, 22);
            label11.TabIndex = 20;
            label11.Text = "Origem da Rota:";
            // 
            // Txt_RoutePath
            // 
            Txt_RoutePath.Location = new Point(307, 295);
            Txt_RoutePath.Name = "Txt_RoutePath";
            Txt_RoutePath.Size = new Size(192, 26);
            Txt_RoutePath.TabIndex = 26;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 14.25F);
            label12.Location = new Point(84, 243);
            label12.Name = "label12";
            label12.Size = new Size(151, 22);
            label12.TabIndex = 21;
            label12.Text = "Destino da Rota:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial", 14.25F);
            label13.Location = new Point(84, 296);
            label13.Name = "label13";
            label13.Size = new Size(163, 22);
            label13.TabIndex = 22;
            label13.Text = "Distância da Rota:";
            // 
            // Txt_Route_ID
            // 
            Txt_Route_ID.Location = new Point(307, 144);
            Txt_Route_ID.Name = "Txt_Route_ID";
            Txt_Route_ID.Size = new Size(192, 26);
            Txt_Route_ID.TabIndex = 23;
            // 
            // FuelPage
            // 
            FuelPage.Controls.Add(comboBox1);
            FuelPage.Controls.Add(DateTimeFuel);
            FuelPage.Controls.Add(label14);
            FuelPage.Controls.Add(label15);
            FuelPage.Controls.Add(textBox16);
            FuelPage.Controls.Add(label16);
            FuelPage.Controls.Add(label17);
            FuelPage.Controls.Add(textBox17);
            FuelPage.Location = new Point(4, 29);
            FuelPage.Name = "FuelPage";
            FuelPage.Size = new Size(994, 479);
            FuelPage.TabIndex = 3;
            FuelPage.Text = "Preço Combustível";
            FuelPage.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Etanol", "Diesel", "Gasolina", "Pódium" });
            comboBox1.Location = new Point(338, 184);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(141, 28);
            comboBox1.TabIndex = 36;
            // 
            // DateTimeFuel
            // 
            DateTimeFuel.Format = DateTimePickerFormat.Short;
            DateTimeFuel.Location = new Point(338, 236);
            DateTimeFuel.Name = "DateTimeFuel";
            DateTimeFuel.Size = new Size(141, 26);
            DateTimeFuel.TabIndex = 35;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial", 14.25F);
            label14.Location = new Point(84, 141);
            label14.Name = "label14";
            label14.Size = new Size(92, 22);
            label14.TabIndex = 27;
            label14.Text = "Comb ID:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Arial", 14.25F);
            label15.Location = new Point(84, 190);
            label15.Name = "label15";
            label15.Size = new Size(232, 22);
            label15.TabIndex = 28;
            label15.Text = "Combustível de Precomb:";
            // 
            // textBox16
            // 
            textBox16.Location = new Point(338, 291);
            textBox16.Name = "textBox16";
            textBox16.Size = new Size(277, 26);
            textBox16.TabIndex = 34;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Arial", 14.25F);
            label16.Location = new Point(84, 239);
            label16.Name = "label16";
            label16.Size = new Size(248, 22);
            label16.TabIndex = 29;
            label16.Text = "Data Consulta do Precomb: ";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Arial", 14.25F);
            label17.Location = new Point(84, 292);
            label17.Name = "label17";
            label17.Size = new Size(176, 22);
            label17.TabIndex = 30;
            label17.Text = "Preço do Precomb:";
            // 
            // textBox17
            // 
            textBox17.Location = new Point(338, 137);
            textBox17.Name = "textBox17";
            textBox17.Size = new Size(141, 26);
            textBox17.TabIndex = 31;
            // 
            // TravelPage
            // 
            TravelPage.Controls.Add(comboBox4);
            TravelPage.Controls.Add(label23);
            TravelPage.Controls.Add(comboBox3);
            TravelPage.Controls.Add(label22);
            TravelPage.Controls.Add(comboBox2);
            TravelPage.Controls.Add(dateTimePicker3);
            TravelPage.Controls.Add(dateTimePicker2);
            TravelPage.Controls.Add(label18);
            TravelPage.Controls.Add(label19);
            TravelPage.Controls.Add(label20);
            TravelPage.Controls.Add(label21);
            TravelPage.Controls.Add(textBox15);
            TravelPage.Location = new Point(4, 29);
            TravelPage.Name = "TravelPage";
            TravelPage.Size = new Size(994, 479);
            TravelPage.TabIndex = 4;
            TravelPage.Text = "Viagem";
            TravelPage.UseVisualStyleBackColor = true;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "Teste", "Teste" });
            comboBox4.Location = new Point(287, 374);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(145, 28);
            comboBox4.TabIndex = 49;
            comboBox4.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Arial", 14.25F);
            label23.Location = new Point(25, 374);
            label23.Name = "label23";
            label23.Size = new Size(92, 22);
            label23.TabIndex = 48;
            label23.Text = "Motorista:";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Teste", "Teste" });
            comboBox3.Location = new Point(287, 324);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(145, 28);
            comboBox3.TabIndex = 47;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Arial", 14.25F);
            label22.Location = new Point(25, 324);
            label22.Name = "label22";
            label22.Size = new Size(151, 22);
            label22.TabIndex = 46;
            label22.Text = "Rota da Viagem:";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(287, 271);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(145, 28);
            comboBox2.TabIndex = 45;
            comboBox2.DropDown += comboBox2_DropDown;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Format = DateTimePickerFormat.Short;
            dateTimePicker3.Location = new Point(287, 170);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(103, 26);
            dateTimePicker3.TabIndex = 44;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(287, 220);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(103, 26);
            dateTimePicker2.TabIndex = 43;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Arial", 14.25F);
            label18.Location = new Point(25, 121);
            label18.Name = "label18";
            label18.Size = new Size(105, 22);
            label18.TabIndex = 37;
            label18.Text = "Viagem ID:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Arial", 14.25F);
            label19.Location = new Point(25, 170);
            label19.Name = "label19";
            label19.Size = new Size(232, 22);
            label19.TabIndex = 38;
            label19.Text = "Data de Saída da Viagem:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Arial", 14.25F);
            label20.Location = new Point(25, 219);
            label20.Name = "label20";
            label20.Size = new Size(259, 22);
            label20.TabIndex = 39;
            label20.Text = "Data de Chegada da Viagem:";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Arial", 14.25F);
            label21.Location = new Point(25, 272);
            label21.Name = "label21";
            label21.Size = new Size(175, 22);
            label21.TabIndex = 40;
            label21.Text = "Veículo da Viagem:";
            // 
            // textBox15
            // 
            textBox15.Location = new Point(287, 121);
            textBox15.Name = "textBox15";
            textBox15.Size = new Size(103, 26);
            textBox15.TabIndex = 41;
            // 
            // panel1
            // 
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btn_save);
            panel1.Location = new Point(12, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(1002, 90);
            panel1.TabIndex = 10;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.Cursor = Cursors.Hand;
            button4.Location = new Point(250, 3);
            button4.Name = "button4";
            button4.Size = new Size(75, 84);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Location = new Point(169, 3);
            button3.Name = "button3";
            button3.Size = new Size(75, 84);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Location = new Point(88, 3);
            button2.Name = "button2";
            button2.Size = new Size(75, 84);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = false;
            // 
            // btn_save
            // 
            btn_save.BackColor = Color.White;
            btn_save.BackgroundImage = (Image)resources.GetObject("btn_save.BackgroundImage");
            btn_save.BackgroundImageLayout = ImageLayout.Stretch;
            btn_save.Location = new Point(7, 3);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(75, 84);
            btn_save.TabIndex = 0;
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Click += btn_save_Click;
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
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
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
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox ID_Vehicle_Txt;
        private TextBox Txt_Vehicle_Model;
        private TextBox Txt_Plate;
        private TextBox Txt_Avarage;
        private TextBox Txt_Max_Weight;
        private TabControl tabControl1;
        private TabPage CarPage;
        private TabPage DriverPage;
        private TabPage RoutePage;
        private PageSetupDialog pageSetupDialog1;
        private TabPage FuelPage;
        private TabPage TravelPage;
        private Panel panel1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button btn_save;
        private TextBox Txt_DriverName;
        private TextBox Txt_DriverLicense;
        private Label label6;
        private Label label7;
        private TextBox Txt_DriverPhone;
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
        private TextBox textBox16;
        private Label label16;
        private Label label17;
        private TextBox textBox17;
        private DateTimePicker DateTimeFuel;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker2;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private TextBox textBox15;
        private DateTimePicker dateTimePicker3;
        private ComboBox comboBox4;
        private Label label23;
        private ComboBox comboBox3;
        private Label label22;
        private ComboBox comboBox2;
    }
}
