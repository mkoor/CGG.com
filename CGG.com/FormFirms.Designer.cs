namespace CGG.com
{
    partial class FormFirms
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
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.listViewFirm = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameFirm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Telephone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.textBoxNameFirm = new System.Windows.Forms.TextBox();
            this.labelNameFirm = new System.Windows.Forms.Label();
            this.City = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxTelephone = new System.Windows.Forms.TextBox();
            this.labelTelephone = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDel.Location = new System.Drawing.Point(525, 285);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(233, 38);
            this.buttonDel.TabIndex = 36;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEdit.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEdit.Location = new System.Drawing.Point(266, 285);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(233, 38);
            this.buttonEdit.TabIndex = 35;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAdd.Location = new System.Drawing.Point(10, 285);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(233, 38);
            this.buttonAdd.TabIndex = 34;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // listViewFirm
            // 
            this.listViewFirm.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.NameFirm,
            this.Address,
            this.City,
            this.Telephone});
            this.listViewFirm.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewFirm.FullRowSelect = true;
            this.listViewFirm.GridLines = true;
            this.listViewFirm.HideSelection = false;
            this.listViewFirm.Location = new System.Drawing.Point(199, 12);
            this.listViewFirm.MultiSelect = false;
            this.listViewFirm.Name = "listViewFirm";
            this.listViewFirm.Size = new System.Drawing.Size(559, 255);
            this.listViewFirm.TabIndex = 33;
            this.listViewFirm.UseCompatibleStateImageBehavior = false;
            this.listViewFirm.View = System.Windows.Forms.View.Details;
            this.listViewFirm.SelectedIndexChanged += new System.EventHandler(this.listViewFirm_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 39;
            // 
            // NameFirm
            // 
            this.NameFirm.Text = "Название фирмы";
            this.NameFirm.Width = 107;
            // 
            // Address
            // 
            this.Address.Text = "Адрес";
            this.Address.Width = 123;
            // 
            // Telephone
            // 
            this.Telephone.Text = "Номер телефона";
            this.Telephone.Width = 121;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(10, 202);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(183, 20);
            this.textBoxCity.TabIndex = 32;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(10, 157);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(183, 20);
            this.textBoxAddress.TabIndex = 31;
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCity.Location = new System.Drawing.Point(6, 180);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(55, 19);
            this.labelCity.TabIndex = 30;
            this.labelCity.Text = "Город*";
            this.labelCity.Click += new System.EventHandler(this.labelMiddleName_Click);
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAddress.Location = new System.Drawing.Point(6, 135);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(58, 19);
            this.labelAddress.TabIndex = 29;
            this.labelAddress.Text = "Адрес*";
            this.labelAddress.Click += new System.EventHandler(this.labelLastName_Click);
            // 
            // textBoxNameFirm
            // 
            this.textBoxNameFirm.Location = new System.Drawing.Point(10, 112);
            this.textBoxNameFirm.Name = "textBoxNameFirm";
            this.textBoxNameFirm.Size = new System.Drawing.Size(183, 20);
            this.textBoxNameFirm.TabIndex = 28;
            // 
            // labelNameFirm
            // 
            this.labelNameFirm.AutoSize = true;
            this.labelNameFirm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameFirm.Location = new System.Drawing.Point(6, 90);
            this.labelNameFirm.Name = "labelNameFirm";
            this.labelNameFirm.Size = new System.Drawing.Size(84, 19);
            this.labelNameFirm.TabIndex = 27;
            this.labelNameFirm.Text = "Название*";
            this.labelNameFirm.Click += new System.EventHandler(this.labelFirstName_Click);
            // 
            // City
            // 
            this.City.Text = "Город";
            // 
            // textBoxTelephone
            // 
            this.textBoxTelephone.Location = new System.Drawing.Point(10, 247);
            this.textBoxTelephone.Name = "textBoxTelephone";
            this.textBoxTelephone.Size = new System.Drawing.Size(183, 20);
            this.textBoxTelephone.TabIndex = 38;
            // 
            // labelTelephone
            // 
            this.labelTelephone.AutoSize = true;
            this.labelTelephone.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTelephone.Location = new System.Drawing.Point(6, 225);
            this.labelTelephone.Name = "labelTelephone";
            this.labelTelephone.Size = new System.Drawing.Size(75, 19);
            this.labelTelephone.TabIndex = 37;
            this.labelTelephone.Text = "Телефон*";
            // 
            // Logo
            // 
            this.Logo.Image = global::CGG.com.Properties.Resources._96_963045_sun_closed_call_for_drop_offs_or_pick;
            this.Logo.Location = new System.Drawing.Point(10, 9);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(183, 75);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 39;
            this.Logo.TabStop = false;
            // 
            // FormFirms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 339);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.textBoxTelephone);
            this.Controls.Add(this.labelTelephone);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listViewFirm);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.textBoxNameFirm);
            this.Controls.Add(this.labelNameFirm);
            this.Name = "FormFirms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Фирмы";
            this.Load += new System.EventHandler(this.FormFirms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ListView listViewFirm;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader NameFirm;
        private System.Windows.Forms.ColumnHeader Address;
        private System.Windows.Forms.ColumnHeader Telephone;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox textBoxNameFirm;
        private System.Windows.Forms.Label labelNameFirm;
        private System.Windows.Forms.ColumnHeader City;
        private System.Windows.Forms.TextBox textBoxTelephone;
        private System.Windows.Forms.Label labelTelephone;
        private System.Windows.Forms.PictureBox Logo;
    }
}