namespace bitlancer
{
    partial class loginForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.username_textbox = new System.Windows.Forms.TextBox();
            this.userpassword_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.logup_button = new System.Windows.Forms.Button();
            this.login_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // username_textbox
            // 
            this.username_textbox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.username_textbox.Location = new System.Drawing.Point(258, 123);
            this.username_textbox.Name = "username_textbox";
            this.username_textbox.Size = new System.Drawing.Size(248, 26);
            this.username_textbox.TabIndex = 0;
            // 
            // userpassword_textbox
            // 
            this.userpassword_textbox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.userpassword_textbox.Location = new System.Drawing.Point(258, 173);
            this.userpassword_textbox.Name = "userpassword_textbox";
            this.userpassword_textbox.PasswordChar = '•';
            this.userpassword_textbox.Size = new System.Drawing.Size(248, 26);
            this.userpassword_textbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F);
            this.label1.Location = new System.Drawing.Point(255, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F);
            this.label2.Location = new System.Drawing.Point(255, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifre:";
            // 
            // logup_button
            // 
            this.logup_button.BackColor = System.Drawing.Color.Orange;
            this.logup_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logup_button.Font = new System.Drawing.Font("Arial", 12F);
            this.logup_button.Location = new System.Drawing.Point(258, 205);
            this.logup_button.Name = "logup_button";
            this.logup_button.Size = new System.Drawing.Size(123, 28);
            this.logup_button.TabIndex = 4;
            this.logup_button.Text = "KAYIT";
            this.logup_button.UseVisualStyleBackColor = false;
            // 
            // login_button
            // 
            this.login_button.BackColor = System.Drawing.Color.SpringGreen;
            this.login_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_button.Font = new System.Drawing.Font("Arial", 12F);
            this.login_button.Location = new System.Drawing.Point(387, 205);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(119, 28);
            this.login_button.TabIndex = 5;
            this.login_button.Text = "GİRİŞ";
            this.login_button.UseVisualStyleBackColor = false;
            this.login_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.logup_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userpassword_textbox);
            this.Controls.Add(this.username_textbox);
            this.Name = "loginForm";
            this.Text = "Kullanıcı Girişi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox username_textbox;
        private System.Windows.Forms.TextBox userpassword_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button logup_button;
        private System.Windows.Forms.Button login_button;
    }
}

