using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CleanPlanet
{
    public partial class ViewPartner : Form
    {
        private Partner partner;
        private bool is_new;
        public ViewPartner(Partner partner, bool is_create_new = false)
        {
            InitializeComponent();
            this.partner = partner;
            is_new = is_create_new;

            if (!is_create_new)
                FillFields();
        }


        private void FillFields()
        {
            p_name.Text = partner.name;
            p_type.SelectedIndex = p_type.Items.IndexOf(partner.type);
            p_director.Text = partner.director;
            p_email.Text = partner.email;
            p_phone.Text = partner.phone;
            p_address.Text = partner.address;
            p_inn.Text = partner.inn;
            p_rating.Value = partner.rating;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // save
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // cancel

            this.Close();
        }
    }
}
