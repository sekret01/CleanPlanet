using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CleanPlanet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Font = new Font("Franklin Gothic Medium", 10, FontStyle.Bold, GraphicsUnit.Point);
            FillPartbers();
        }


        private void FillPartbers()
        {
            partner_table.Controls.Clear();
            List<Partner> partners = DBGetter.GetPartners();
            foreach (Partner partner in partners)
            {
                CreatePartnerPanel(partner);
            }
            Panel filler = new Panel();
            filler.Height = 0;
            partner_table.Controls.Add(filler);

        }

        private void CreatePartnerPanel(Partner partner)
        {
            Panel pattern_panel = new Panel();
            Label type_pattern = new Label();
            Label stick_pattern = new Label();
            Label name_pattern = new Label();
            Label director_pattern = new Label();
            Label phone_pattern = new Label();
            Label _rating_text = new Label();
            Label rating_pattern = new Label();
            Button info_btn = new Button();

            // type_pattern
            // 
            type_pattern.Location = new System.Drawing.Point(12, 9);
            type_pattern.Name = "type_pattern";
            type_pattern.Size = new System.Drawing.Size(65, 23);
            type_pattern.TabIndex = 0;
            type_pattern.Text = partner.type;
            type_pattern.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // stick_pattern
            // 
            stick_pattern.Location = new System.Drawing.Point(83, 9);
            stick_pattern.Name = "stick_pattern";
            stick_pattern.Size = new System.Drawing.Size(24, 23);
            stick_pattern.TabIndex = 0;
            stick_pattern.Text = "|";
            stick_pattern.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // name_pattern
            // 
            name_pattern.Location = new System.Drawing.Point(113, 9);
            name_pattern.Name = "name_pattern";
            name_pattern.Size = new System.Drawing.Size(370, 23);
            name_pattern.TabIndex = 0;
            name_pattern.Text = partner.name;
            name_pattern.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // director_pattern
            // 
            director_pattern.Location = new System.Drawing.Point(12, 34);
            director_pattern.Name = "director_pattern";
            director_pattern.Size = new System.Drawing.Size(358, 23);
            director_pattern.TabIndex = 0;
            director_pattern.Text = partner.director;
            director_pattern.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // phone_pattern
            // 
            phone_pattern.Location = new System.Drawing.Point(12, 58);
            phone_pattern.Name = "phone_pattern";
            phone_pattern.Size = new System.Drawing.Size(358, 23);
            phone_pattern.TabIndex = 0;
            phone_pattern.Text = partner.phone;
            phone_pattern.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // _rating_text
            // 
            _rating_text.Location = new System.Drawing.Point(12, 82);
            _rating_text.Name = "_rating_text";
            _rating_text.Size = new System.Drawing.Size(95, 23);
            _rating_text.TabIndex = 0;
            _rating_text.Text = "Рейтинг:";
            _rating_text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // rating_pattern
            // 
            rating_pattern.Location = new System.Drawing.Point(113, 82);
            rating_pattern.Name = "rating_pattern";
            rating_pattern.Size = new System.Drawing.Size(95, 23);
            rating_pattern.TabIndex = 0;
            rating_pattern.Text = partner.rating.ToString();
            rating_pattern.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // info_btn
            //
            info_btn.Location = new System.Drawing.Point(468, 70);
            info_btn.Name = "info_btn";
            info_btn.Size = new System.Drawing.Size(76, 35);
            info_btn.TabIndex = 1;
            info_btn.Text = "инфо";
            info_btn.UseVisualStyleBackColor = true;
            info_btn.Click += new System.EventHandler(this.info_btn_Click);

            // pattern_panel
            // 
            pattern_panel.BackColor = System.Drawing.Color.White;
            pattern_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            pattern_panel.Controls.Add(stick_pattern);
            pattern_panel.Controls.Add(name_pattern);
            pattern_panel.Controls.Add(rating_pattern);
            pattern_panel.Controls.Add(_rating_text);
            pattern_panel.Controls.Add(phone_pattern);
            pattern_panel.Controls.Add(director_pattern);
            pattern_panel.Controls.Add(type_pattern);
            pattern_panel.Controls.Add(info_btn);
            pattern_panel.Location = new System.Drawing.Point(8, 8);
            pattern_panel.Name = "pattern_panel";
            pattern_panel.Size = new System.Drawing.Size(563, 120);
            pattern_panel.TabIndex = 0;

            pattern_panel.Parent = partner_table;
        }

        private void info_btn_Click(object sender, EventArgs e)
        {
            string name = "";
            foreach (Control el in ((Button)sender).Parent.Controls)
            {
                if (el.Name == "name_pattern")
                {
                    name = el.Text;
                    break;
                }
            }
            if (name == "")
            {
                return;
            }

            Partner select_partner = DBGetter.GetPartners(name)[0];
            ViewPartner win = new ViewPartner(select_partner);
            win.ShowDialog();
            FillPartbers();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // add new

            ViewPartner win = new ViewPartner(new Partner(), true);
            win.ShowDialog();
            FillPartbers();
        }
    }
}
