using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using App.BLL;
using App.Models;

namespace App
{
    public partial class frm_App : Form
    {   
        private List<MOD_UserSP> ListUsers = new List<MOD_UserSP>();
        private List<MOD_LocationSP> ListLocations = new List<MOD_LocationSP>();        

        public frm_App()
        {
            InitializeComponent();
        }

        private void frm_App_Load(object sender, EventArgs e)
        {
            LoadDefaultSettings();
        }

        private void LoadDefaultSettings()
        {
            ListUsers = BLL_UserRegistration.GetListUser();
            ListLocations = BLL_UserRegistration.GetListLocations();
            SetGridView();
            SetCountryComboBox();
        }

        private void SetGridView()
        {
            dtg_users.DataSource = null;
            dtg_users.DataSource = ListUsers;
            dtg_users.AutoResizeColumns();
        }
        
        private void SetCountryComboBox()
        {
            var cty = ListLocations.Select(s => new { s.Id_cty, s.Name_cty }).Distinct().OrderBy(o => o.Name_cty).ToList();

            cmb_countries.SelectedIndexChanged -= cmb_countries_SelectedIndexChanged;
            cmb_countries.DataSource = null;
            cmb_countries.DataSource = cty;
            cmb_countries.DisplayMember = "Name_cty";
            cmb_countries.ValueMember = "Id_cty";
            cmb_countries.SelectedIndex = -1;
            cmb_countries.SelectedIndexChanged += cmb_countries_SelectedIndexChanged;
        }

        private void cmb_countries_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_countries.SelectedIndex == -1) return;

            var id_cty = (int)cmb_countries.SelectedValue;

            SetStateComboBox(id_cty);
        }

        private void SetStateComboBox(int id_cty)
        {
            var ste = ListLocations.Where(w => w.Id_cty == id_cty).Select(s => new { s.Id_ste, s.Name_ste }).Distinct().OrderBy(o => o.Name_ste).ToList(); ;

            cmb_states.SelectedIndexChanged -= cmb_states_SelectedIndexChanged;
            cmb_states.DataSource = null;
            cmb_states.DataSource = ste;
            cmb_states.DisplayMember = "Name_ste";
            cmb_states.ValueMember = "Id_ste";
            cmb_states.SelectedIndex = -1;
            cmb_states.SelectedIndexChanged += cmb_states_SelectedIndexChanged;
            cmb_cities.SelectedIndex = -1;
        }

        private void cmb_states_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_states.SelectedIndex == -1) return;

            var id_ste = (int)cmb_states.SelectedValue;

            SetCitiesComboBox(id_ste);
        }

        private void SetCitiesComboBox(int id_ste)
        {
            var cit = ListLocations.Where(w => w.Id_ste == id_ste).Select(s => new { s.Id_cit, s.Name_cit }).Distinct().OrderBy(o => o.Name_cit).ToList(); ;

            cmb_cities.SelectedIndexChanged -= cmb_cities_SelectedIndexChanged;
            cmb_cities.DataSource = null;
            cmb_cities.DataSource = cit;
            cmb_cities.DisplayMember = "Name_cit";
            cmb_cities.ValueMember = "Id_cit";
            cmb_cities.SelectedIndex = -1;
            cmb_cities.SelectedIndexChanged += cmb_cities_SelectedIndexChanged;
        }

        private void cmb_cities_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_cities.SelectedIndex == -1) return;            
        }


        public void AddNewUser()
        {
            MOD_UserTable NewUser = new MOD_UserTable()
            {
                first_names_usr = mtb_names.Text,
                last_names_usr = mtb_lastname.Text,
                phone_usr = mtb_phone.Text,
                address_usr = mtb_address.Text,
                city_usr = Convert.ToInt32(cmb_cities.SelectedValue)
            };

            var r = BLL_UserRegistration.AddNewUser(NewUser);

            MessageBox.Show(r);
            
            Clean();
            LoadDefaultSettings();           
        }       
        private void btn_add_Click(object sender, EventArgs e)
        {
            AddNewUser();
        }

        private void Clean()
        {
            mtb_names.Clear();
            mtb_lastname.Clear();
            mtb_phone.Clear();
            mtb_address.Clear();
            cmb_countries.DataSource = null;
            cmb_states.DataSource = null;
            cmb_cities.DataSource = null;
        }        
    }
}

