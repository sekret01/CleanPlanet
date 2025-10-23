namespace CleanPlanet
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.partner_table = new System.Windows.Forms.FlowLayoutPanel();
            this.pattern_panel = new System.Windows.Forms.Panel();
            this.type_pattern = new System.Windows.Forms.Label();
            this.director_pattern = new System.Windows.Forms.Label();
            this.phone_pattern = new System.Windows.Forms.Label();
            this._rating_text = new System.Windows.Forms.Label();
            this.rating_pattern = new System.Windows.Forms.Label();
            this.name_pattern = new System.Windows.Forms.Label();
            this.stick_pattern = new System.Windows.Forms.Label();
            this.info_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.partner_table.SuspendLayout();
            this.pattern_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // partner_table
            // 
            this.partner_table.AutoScroll = true;
            this.partner_table.BackColor = System.Drawing.Color.LightCyan;
            this.partner_table.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.partner_table.Controls.Add(this.pattern_panel);
            this.partner_table.Location = new System.Drawing.Point(38, 48);
            this.partner_table.Name = "partner_table";
            this.partner_table.Padding = new System.Windows.Forms.Padding(5);
            this.partner_table.Size = new System.Drawing.Size(661, 548);
            this.partner_table.TabIndex = 0;
            // 
            // pattern_panel
            // 
            this.pattern_panel.BackColor = System.Drawing.Color.White;
            this.pattern_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pattern_panel.Controls.Add(this.info_btn);
            this.pattern_panel.Controls.Add(this.stick_pattern);
            this.pattern_panel.Controls.Add(this.name_pattern);
            this.pattern_panel.Controls.Add(this.rating_pattern);
            this.pattern_panel.Controls.Add(this._rating_text);
            this.pattern_panel.Controls.Add(this.phone_pattern);
            this.pattern_panel.Controls.Add(this.director_pattern);
            this.pattern_panel.Controls.Add(this.type_pattern);
            this.pattern_panel.Location = new System.Drawing.Point(8, 8);
            this.pattern_panel.Name = "pattern_panel";
            this.pattern_panel.Size = new System.Drawing.Size(563, 120);
            this.pattern_panel.TabIndex = 0;
            // 
            // type_pattern
            // 
            this.type_pattern.Location = new System.Drawing.Point(12, 9);
            this.type_pattern.Name = "type_pattern";
            this.type_pattern.Size = new System.Drawing.Size(65, 23);
            this.type_pattern.TabIndex = 0;
            this.type_pattern.Text = "type";
            this.type_pattern.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // director_pattern
            // 
            this.director_pattern.Location = new System.Drawing.Point(12, 35);
            this.director_pattern.Name = "director_pattern";
            this.director_pattern.Size = new System.Drawing.Size(358, 23);
            this.director_pattern.TabIndex = 0;
            this.director_pattern.Text = "director";
            this.director_pattern.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // phone_pattern
            // 
            this.phone_pattern.Location = new System.Drawing.Point(12, 58);
            this.phone_pattern.Name = "phone_pattern";
            this.phone_pattern.Size = new System.Drawing.Size(358, 23);
            this.phone_pattern.TabIndex = 0;
            this.phone_pattern.Text = "phone";
            this.phone_pattern.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _rating_text
            // 
            this._rating_text.Location = new System.Drawing.Point(12, 82);
            this._rating_text.Name = "_rating_text";
            this._rating_text.Size = new System.Drawing.Size(95, 23);
            this._rating_text.TabIndex = 0;
            this._rating_text.Text = "Рейтинг:";
            this._rating_text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rating_pattern
            // 
            this.rating_pattern.Location = new System.Drawing.Point(113, 82);
            this.rating_pattern.Name = "rating_pattern";
            this.rating_pattern.Size = new System.Drawing.Size(95, 23);
            this.rating_pattern.TabIndex = 0;
            this.rating_pattern.Text = "0";
            this.rating_pattern.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // name_pattern
            // 
            this.name_pattern.Location = new System.Drawing.Point(113, 9);
            this.name_pattern.Name = "name_pattern";
            this.name_pattern.Size = new System.Drawing.Size(294, 23);
            this.name_pattern.TabIndex = 0;
            this.name_pattern.Text = "name";
            this.name_pattern.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // stick_pattern
            // 
            this.stick_pattern.Location = new System.Drawing.Point(83, 9);
            this.stick_pattern.Name = "stick_pattern";
            this.stick_pattern.Size = new System.Drawing.Size(24, 23);
            this.stick_pattern.TabIndex = 0;
            this.stick_pattern.Text = "|";
            this.stick_pattern.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // info_btn
            // 
            this.info_btn.Location = new System.Drawing.Point(443, 70);
            this.info_btn.Name = "info_btn";
            this.info_btn.Size = new System.Drawing.Size(101, 35);
            this.info_btn.TabIndex = 1;
            this.info_btn.Text = "изменить";
            this.info_btn.UseVisualStyleBackColor = true;
            this.info_btn.Click += new System.EventHandler(this.info_btn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(609, 627);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(779, 686);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.partner_table);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.partner_table.ResumeLayout(false);
            this.pattern_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel partner_table;
        private System.Windows.Forms.Panel pattern_panel;
        private System.Windows.Forms.Label stick_pattern;
        private System.Windows.Forms.Label name_pattern;
        private System.Windows.Forms.Label rating_pattern;
        private System.Windows.Forms.Label _rating_text;
        private System.Windows.Forms.Label phone_pattern;
        private System.Windows.Forms.Label director_pattern;
        private System.Windows.Forms.Label type_pattern;
        private System.Windows.Forms.Button info_btn;
        private System.Windows.Forms.Button button1;
    }
}

