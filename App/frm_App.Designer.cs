namespace App
{
    partial class frm_App
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.mtb_names = new System.Windows.Forms.MaskedTextBox();
            this.mtb_lastname = new System.Windows.Forms.MaskedTextBox();
            this.mtb_phone = new System.Windows.Forms.MaskedTextBox();
            this.mtb_address = new System.Windows.Forms.MaskedTextBox();
            this.cmb_countries = new System.Windows.Forms.ComboBox();
            this.cmb_states = new System.Windows.Forms.ComboBox();
            this.cmb_cities = new System.Windows.Forms.ComboBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.dtg_users = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_users)).BeginInit();
            this.SuspendLayout();
            // 
            // mtb_names
            // 
            this.mtb_names.Location = new System.Drawing.Point(77, 12);
            this.mtb_names.Name = "mtb_names";
            this.mtb_names.Size = new System.Drawing.Size(249, 20);
            this.mtb_names.TabIndex = 1;
            // 
            // mtb_lastname
            // 
            this.mtb_lastname.Location = new System.Drawing.Point(77, 46);
            this.mtb_lastname.Name = "mtb_lastname";
            this.mtb_lastname.Size = new System.Drawing.Size(249, 20);
            this.mtb_lastname.TabIndex = 2;
            // 
            // mtb_phone
            // 
            this.mtb_phone.Location = new System.Drawing.Point(77, 82);
            this.mtb_phone.Name = "mtb_phone";
            this.mtb_phone.Size = new System.Drawing.Size(249, 20);
            this.mtb_phone.TabIndex = 3;
            // 
            // mtb_address
            // 
            this.mtb_address.Location = new System.Drawing.Point(77, 118);
            this.mtb_address.Name = "mtb_address";
            this.mtb_address.Size = new System.Drawing.Size(249, 20);
            this.mtb_address.TabIndex = 4;
            // 
            // cmb_countries
            // 
            this.cmb_countries.FormattingEnabled = true;
            this.cmb_countries.Location = new System.Drawing.Point(464, 7);
            this.cmb_countries.Name = "cmb_countries";
            this.cmb_countries.Size = new System.Drawing.Size(229, 21);
            this.cmb_countries.TabIndex = 5;
            this.cmb_countries.SelectedIndexChanged += new System.EventHandler(this.cmb_countries_SelectedIndexChanged);
            // 
            // cmb_states
            // 
            this.cmb_states.FormattingEnabled = true;
            this.cmb_states.Location = new System.Drawing.Point(464, 47);
            this.cmb_states.Name = "cmb_states";
            this.cmb_states.Size = new System.Drawing.Size(229, 21);
            this.cmb_states.TabIndex = 6;
            this.cmb_states.SelectedIndexChanged += new System.EventHandler(this.cmb_states_SelectedIndexChanged);
            // 
            // cmb_cities
            // 
            this.cmb_cities.FormattingEnabled = true;
            this.cmb_cities.Location = new System.Drawing.Point(464, 85);
            this.cmb_cities.Name = "cmb_cities";
            this.cmb_cities.Size = new System.Drawing.Size(229, 21);
            this.cmb_cities.TabIndex = 7;
            this.cmb_cities.SelectedIndexChanged += new System.EventHandler(this.cmb_cities_SelectedIndexChanged);
            // 
            // btn_add
            // 
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(464, 121);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(229, 23);
            this.btn_add.TabIndex = 8;
            this.btn_add.Text = "Agregar Usuario";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // dtg_users
            // 
            this.dtg_users.AllowDrop = true;
            this.dtg_users.AllowUserToAddRows = false;
            this.dtg_users.AllowUserToDeleteRows = false;
            this.dtg_users.AllowUserToResizeColumns = false;
            this.dtg_users.AllowUserToResizeRows = false;
            this.dtg_users.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtg_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_users.GridColor = System.Drawing.SystemColors.Desktop;
            this.dtg_users.Location = new System.Drawing.Point(12, 150);
            this.dtg_users.Name = "dtg_users";
            this.dtg_users.ReadOnly = true;
            this.dtg_users.RowHeadersVisible = false;
            this.dtg_users.Size = new System.Drawing.Size(681, 249);
            this.dtg_users.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nombres:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Apellidos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Dirección:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Teléfono:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(417, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Paises:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(404, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Ciudades:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(376, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Estados / Dept:";
            // 
            // frm_App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(705, 411);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtg_users);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.cmb_cities);
            this.Controls.Add(this.cmb_states);
            this.Controls.Add(this.cmb_countries);
            this.Controls.Add(this.mtb_address);
            this.Controls.Add(this.mtb_phone);
            this.Controls.Add(this.mtb_lastname);
            this.Controls.Add(this.mtb_names);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_App";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prueba API ";
            this.Load += new System.EventHandler(this.frm_App_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_users)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox mtb_names;
        private System.Windows.Forms.MaskedTextBox mtb_lastname;
        private System.Windows.Forms.MaskedTextBox mtb_phone;
        private System.Windows.Forms.MaskedTextBox mtb_address;
        private System.Windows.Forms.ComboBox cmb_countries;
        private System.Windows.Forms.ComboBox cmb_states;
        private System.Windows.Forms.ComboBox cmb_cities;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridView dtg_users;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

