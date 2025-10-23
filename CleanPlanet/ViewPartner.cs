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
            {
                FillFields();
                button3.Visible = true;
                button3.Enabled = true;
            }
            else
            {
                button3.Visible = false;
                button3.Enabled = false;
            }
                
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

        private void LoadPartnerData()
        {
            partner.old_name = partner.name;
            partner.name = p_name.Text;
            partner.type = p_type.Items[p_type.SelectedIndex].ToString();
            partner.director = p_director.Text;
            partner.email = p_email.Text;
            partner.phone = p_phone.Text;
            partner.address = p_address.Text;
            partner.inn = p_inn.Text;
            partner.rating = (int)p_rating.Value;
        }

        private bool ValidateData()
        {
            if (
            p_name.Text == "" ||
            p_director.Text == "" ||
            p_email.Text == "" ||
            p_phone.Text == "" ||
            p_address.Text == "" ||
            p_inn.Text == ""
                )
            {
                MessageBox.Show("input error", "есть пустые поля ввода");
                return false;
            }
            try { long.Parse(p_inn.Text); }
            catch
            {
                MessageBox.Show("input error", "ИНН должен быть числом");
                return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // save
            if (!ValidateData()) return;
            LoadPartnerData();
            if (is_new)
            {
                if (!DBGetter.AddPartner(partner))
                {
                    MessageBox.Show("database error", "не удалось сделать запись в БД");
                }
            }
            else
            {
                if (!DBGetter.EditPartner(partner))
                {
                    MessageBox.Show("database error", "не удалось сделать запись в БД");
                }
            }
            this.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // cancel

            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadPartnerData();
            if (!DBGetter.DeletePartner(partner.name))
            {
                MessageBox.Show("database error", "не удалось удалить запись в БД");
            }
            this.Close();
        }
    }
}
