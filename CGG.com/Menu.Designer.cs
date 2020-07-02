namespace CGG.com
{
    partial class FormMenu
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
            this.buttonFirms = new System.Windows.Forms.Button();
            this.buttonCars = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonFirms
            // 
            this.buttonFirms.BackColor = System.Drawing.Color.Black;
            this.buttonFirms.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFirms.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonFirms.Location = new System.Drawing.Point(52, 172);
            this.buttonFirms.Name = "buttonFirms";
            this.buttonFirms.Size = new System.Drawing.Size(233, 38);
            this.buttonFirms.TabIndex = 1;
            this.buttonFirms.Text = "Данные о фирмах";
            this.buttonFirms.UseVisualStyleBackColor = false;
            this.buttonFirms.Click += new System.EventHandler(this.buttonFirms_Click);
            // 
            // buttonCars
            // 
            this.buttonCars.BackColor = System.Drawing.Color.Black;
            this.buttonCars.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCars.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCars.Location = new System.Drawing.Point(52, 216);
            this.buttonCars.Name = "buttonCars";
            this.buttonCars.Size = new System.Drawing.Size(233, 38);
            this.buttonCars.TabIndex = 2;
            this.buttonCars.Text = "Данные об автомобилях";
            this.buttonCars.UseVisualStyleBackColor = false;
            this.buttonCars.Click += new System.EventHandler(this.buttonCars_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(52, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "Наличие";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(78, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Добро Пожаловать!";
            // 
            // Logo
            // 
            this.Logo.Image = global::CGG.com.Properties.Resources._96_963045_sun_closed_call_for_drop_offs_or_pick;
            this.Logo.Location = new System.Drawing.Point(11, 44);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(323, 114);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(346, 314);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonCars);
            this.Controls.Add(this.buttonFirms);
            this.Controls.Add(this.Logo);
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button buttonFirms;
        private System.Windows.Forms.Button buttonCars;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

