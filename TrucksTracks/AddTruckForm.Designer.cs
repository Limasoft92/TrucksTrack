namespace TrucksTracks
{
    partial class AddTruckForm
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
            this.lbl_TypeTruck = new System.Windows.Forms.Label();
            this.cb_TypeTruck = new System.Windows.Forms.ComboBox();
            this.lbl_Brand = new System.Windows.Forms.Label();
            this.cb_Brand = new System.Windows.Forms.ComboBox();
            this.lbl_Model = new System.Windows.Forms.Label();
            this.tb_Model = new System.Windows.Forms.TextBox();
            this.lbl_NumberTruck = new System.Windows.Forms.Label();
            this.tb_NumberTruck = new System.Windows.Forms.TextBox();
            this.lbl_NumberTrailer = new System.Windows.Forms.Label();
            this.tb_NumberTrailer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_TypeTruck
            // 
            this.lbl_TypeTruck.AutoSize = true;
            this.lbl_TypeTruck.Location = new System.Drawing.Point(231, 43);
            this.lbl_TypeTruck.Name = "lbl_TypeTruck";
            this.lbl_TypeTruck.Size = new System.Drawing.Size(154, 13);
            this.lbl_TypeTruck.TabIndex = 0;
            this.lbl_TypeTruck.Text = "Тип транспортного средства";
            // 
            // cb_TypeTruck
            // 
            this.cb_TypeTruck.FormattingEnabled = true;
            this.cb_TypeTruck.Location = new System.Drawing.Point(234, 60);
            this.cb_TypeTruck.Name = "cb_TypeTruck";
            this.cb_TypeTruck.Size = new System.Drawing.Size(121, 21);
            this.cb_TypeTruck.TabIndex = 1;
            // 
            // lbl_Brand
            // 
            this.lbl_Brand.AutoSize = true;
            this.lbl_Brand.Location = new System.Drawing.Point(232, 88);
            this.lbl_Brand.Name = "lbl_Brand";
            this.lbl_Brand.Size = new System.Drawing.Size(40, 13);
            this.lbl_Brand.TabIndex = 2;
            this.lbl_Brand.Text = "Марка";
            // 
            // cb_Brand
            // 
            this.cb_Brand.FormattingEnabled = true;
            this.cb_Brand.Location = new System.Drawing.Point(235, 105);
            this.cb_Brand.Name = "cb_Brand";
            this.cb_Brand.Size = new System.Drawing.Size(121, 21);
            this.cb_Brand.TabIndex = 3;
            // 
            // lbl_Model
            // 
            this.lbl_Model.AutoSize = true;
            this.lbl_Model.Location = new System.Drawing.Point(397, 88);
            this.lbl_Model.Name = "lbl_Model";
            this.lbl_Model.Size = new System.Drawing.Size(46, 13);
            this.lbl_Model.TabIndex = 4;
            this.lbl_Model.Text = "Модель";
            // 
            // tb_Model
            // 
            this.tb_Model.Location = new System.Drawing.Point(400, 105);
            this.tb_Model.Name = "tb_Model";
            this.tb_Model.Size = new System.Drawing.Size(100, 20);
            this.tb_Model.TabIndex = 5;
            // 
            // lbl_NumberTruck
            // 
            this.lbl_NumberTruck.AutoSize = true;
            this.lbl_NumberTruck.Location = new System.Drawing.Point(235, 133);
            this.lbl_NumberTruck.Name = "lbl_NumberTruck";
            this.lbl_NumberTruck.Size = new System.Drawing.Size(105, 13);
            this.lbl_NumberTruck.TabIndex = 6;
            this.lbl_NumberTruck.Text = "Номер автомобиля";
            this.lbl_NumberTruck.Click += new System.EventHandler(this.lbl_NumberTruck_Click);
            // 
            // tb_NumberTruck
            // 
            this.tb_NumberTruck.Location = new System.Drawing.Point(234, 150);
            this.tb_NumberTruck.Name = "tb_NumberTruck";
            this.tb_NumberTruck.Size = new System.Drawing.Size(100, 20);
            this.tb_NumberTruck.TabIndex = 7;
            // 
            // lbl_NumberTrailer
            // 
            this.lbl_NumberTrailer.AutoSize = true;
            this.lbl_NumberTrailer.Location = new System.Drawing.Point(400, 132);
            this.lbl_NumberTrailer.Name = "lbl_NumberTrailer";
            this.lbl_NumberTrailer.Size = new System.Drawing.Size(109, 13);
            this.lbl_NumberTrailer.TabIndex = 8;
            this.lbl_NumberTrailer.Text = "Номер полуприцепа";
            // 
            // tb_NumberTrailer
            // 
            this.tb_NumberTrailer.Location = new System.Drawing.Point(400, 150);
            this.tb_NumberTrailer.Name = "tb_NumberTrailer";
            this.tb_NumberTrailer.Size = new System.Drawing.Size(100, 20);
            this.tb_NumberTrailer.TabIndex = 9;
            // 
            // AddTruckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 562);
            this.Controls.Add(this.tb_NumberTrailer);
            this.Controls.Add(this.lbl_NumberTrailer);
            this.Controls.Add(this.tb_NumberTruck);
            this.Controls.Add(this.lbl_NumberTruck);
            this.Controls.Add(this.tb_Model);
            this.Controls.Add(this.lbl_Model);
            this.Controls.Add(this.cb_Brand);
            this.Controls.Add(this.lbl_Brand);
            this.Controls.Add(this.cb_TypeTruck);
            this.Controls.Add(this.lbl_TypeTruck);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddTruckForm";
            this.Text = "Добавить автомобиль";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_TypeTruck;
        private System.Windows.Forms.ComboBox cb_TypeTruck;
        private System.Windows.Forms.Label lbl_Brand;
        private System.Windows.Forms.ComboBox cb_Brand;
        private System.Windows.Forms.Label lbl_Model;
        private System.Windows.Forms.TextBox tb_Model;
        private System.Windows.Forms.Label lbl_NumberTruck;
        private System.Windows.Forms.TextBox tb_NumberTruck;
        private System.Windows.Forms.Label lbl_NumberTrailer;
        private System.Windows.Forms.TextBox tb_NumberTrailer;
    }
}