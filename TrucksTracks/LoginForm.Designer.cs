namespace TrucksTracks
{
    partial class LoginForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Login = new System.Windows.Forms.Label();
            this.lbl_Pass = new System.Windows.Forms.Label();
            this.lbl_TrucksTracks = new System.Windows.Forms.Label();
            this.tb_Login = new System.Windows.Forms.TextBox();
            this.tb_Pass = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Login
            // 
            this.lbl_Login.AutoSize = true;
            this.lbl_Login.Location = new System.Drawing.Point(88, 86);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(103, 13);
            this.lbl_Login.TabIndex = 0;
            this.lbl_Login.Text = "Имя пользователя";
            // 
            // lbl_Pass
            // 
            this.lbl_Pass.AutoSize = true;
            this.lbl_Pass.Location = new System.Drawing.Point(88, 128);
            this.lbl_Pass.Name = "lbl_Pass";
            this.lbl_Pass.Size = new System.Drawing.Size(45, 13);
            this.lbl_Pass.TabIndex = 1;
            this.lbl_Pass.Text = "Пароль";
            // 
            // lbl_TrucksTracks
            // 
            this.lbl_TrucksTracks.AutoSize = true;
            this.lbl_TrucksTracks.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_TrucksTracks.Location = new System.Drawing.Point(57, 35);
            this.lbl_TrucksTracks.Name = "lbl_TrucksTracks";
            this.lbl_TrucksTracks.Size = new System.Drawing.Size(166, 31);
            this.lbl_TrucksTracks.TabIndex = 3;
            this.lbl_TrucksTracks.Text = "TrucksTrack";
            // 
            // tb_Login
            // 
            this.tb_Login.Location = new System.Drawing.Point(91, 103);
            this.tb_Login.Name = "tb_Login";
            this.tb_Login.Size = new System.Drawing.Size(102, 20);
            this.tb_Login.TabIndex = 4;
            this.tb_Login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_Pass
            // 
            this.tb_Pass.Location = new System.Drawing.Point(91, 145);
            this.tb_Pass.Name = "tb_Pass";
            this.tb_Pass.Size = new System.Drawing.Size(102, 20);
            this.tb_Pass.TabIndex = 5;
            this.tb_Pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(104, 177);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(75, 23);
            this.btn_Login.TabIndex = 6;
            this.btn_Login.Text = "Войти";
            this.btn_Login.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.tb_Pass);
            this.Controls.Add(this.tb_Login);
            this.Controls.Add(this.lbl_TrucksTracks);
            this.Controls.Add(this.lbl_Pass);
            this.Controls.Add(this.lbl_Login);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добро пожаловать";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Login;
        private System.Windows.Forms.Label lbl_Pass;
        private System.Windows.Forms.Label lbl_TrucksTracks;
        private System.Windows.Forms.TextBox tb_Login;
        private System.Windows.Forms.TextBox tb_Pass;
        private System.Windows.Forms.Button btn_Login;
    }
}

