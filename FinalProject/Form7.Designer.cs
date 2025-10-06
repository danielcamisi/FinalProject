namespace FinalProject
{
    partial class Form7
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            Login = new TabPage();
            Register = new TabPage();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btn_login = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            txt_name = new TextBox();
            txt_emailregister = new TextBox();
            txt_registerpword = new TextBox();
            txt_confirmpword = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            btn_register = new Button();
            tabControl1.SuspendLayout();
            Login.SuspendLayout();
            Register.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Login);
            tabControl1.Controls.Add(Register);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(533, 676);
            tabControl1.TabIndex = 0;
            // 
            // Login
            // 
            Login.Controls.Add(textBox2);
            Login.Controls.Add(textBox1);
            Login.Controls.Add(btn_login);
            Login.Controls.Add(label3);
            Login.Controls.Add(label2);
            Login.Controls.Add(label1);
            Login.Location = new Point(4, 24);
            Login.Name = "Login";
            Login.Padding = new Padding(3);
            Login.Size = new Size(525, 648);
            Login.TabIndex = 0;
            Login.Text = "Entrar";
            Login.UseVisualStyleBackColor = true;
            // 
            // Register
            // 
            Register.Controls.Add(btn_register);
            Register.Controls.Add(label8);
            Register.Controls.Add(label7);
            Register.Controls.Add(label6);
            Register.Controls.Add(label5);
            Register.Controls.Add(label4);
            Register.Controls.Add(txt_confirmpword);
            Register.Controls.Add(txt_registerpword);
            Register.Controls.Add(txt_emailregister);
            Register.Controls.Add(txt_name);
            Register.Location = new Point(4, 24);
            Register.Name = "Register";
            Register.Padding = new Padding(3);
            Register.Size = new Size(525, 648);
            Register.TabIndex = 1;
            Register.Text = "Cadastrar";
            Register.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(198, 136);
            label1.Name = "label1";
            label1.Size = new Size(101, 40);
            label1.TabIndex = 0;
            label1.Text = "Entrar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(142, 223);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(142, 302);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 2;
            label3.Text = "Senha:";
            // 
            // btn_login
            // 
            btn_login.Location = new Point(198, 407);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(101, 43);
            btn_login.TabIndex = 3;
            btn_login.Text = "Entrar";
            btn_login.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(142, 250);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(211, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(142, 331);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(211, 23);
            textBox2.TabIndex = 5;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(166, 220);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(177, 23);
            txt_name.TabIndex = 0;
            // 
            // txt_emailregister
            // 
            txt_emailregister.Location = new Point(166, 288);
            txt_emailregister.Name = "txt_emailregister";
            txt_emailregister.Size = new Size(177, 23);
            txt_emailregister.TabIndex = 1;
            // 
            // txt_registerpword
            // 
            txt_registerpword.Location = new Point(166, 343);
            txt_registerpword.Name = "txt_registerpword";
            txt_registerpword.Size = new Size(177, 23);
            txt_registerpword.TabIndex = 2;
            // 
            // txt_confirmpword
            // 
            txt_confirmpword.Location = new Point(166, 405);
            txt_confirmpword.Name = "txt_confirmpword";
            txt_confirmpword.Size = new Size(177, 23);
            txt_confirmpword.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(178, 120);
            label4.Name = "label4";
            label4.Size = new Size(149, 40);
            label4.TabIndex = 4;
            label4.Text = "Cadastrar";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(166, 193);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 5;
            label5.Text = "Nome:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(166, 260);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 6;
            label6.Text = "Email:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(166, 325);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 7;
            label7.Text = "Senha:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(166, 387);
            label8.Name = "label8";
            label8.Size = new Size(116, 15);
            label8.TabIndex = 8;
            label8.Text = "Confirme sua Senha:";
            // 
            // btn_register
            // 
            btn_register.Location = new Point(211, 459);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(95, 49);
            btn_register.TabIndex = 9;
            btn_register.Text = "Cadastrar";
            btn_register.UseVisualStyleBackColor = true;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(529, 677);
            Controls.Add(tabControl1);
            Name = "Form7";
            Text = "Bem-Vindo Gestão de Logística";
            tabControl1.ResumeLayout(false);
            Login.ResumeLayout(false);
            Login.PerformLayout();
            Register.ResumeLayout(false);
            Register.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage Login;
        private Label label1;
        private TabPage Register;
        private Button btn_login;
        private Label label3;
        private Label label2;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button btn_register;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txt_confirmpword;
        private TextBox txt_registerpword;
        private TextBox txt_emailregister;
        private TextBox txt_name;
    }
}