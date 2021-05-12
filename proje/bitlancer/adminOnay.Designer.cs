
namespace bitlancer
{
    partial class adminOnay
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnAdminOnay = new System.Windows.Forms.Button();
            this.cbAdminOnay = new System.Windows.Forms.CheckBox();
            this.adminOnayDataGrid = new System.Windows.Forms.DataGridView();
            this.adminOnayDataGrid2 = new System.Windows.Forms.DataGridView();
            this.txtAdminOnay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminOnayDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminOnayDataGrid2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1039, 539);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtAdminOnay);
            this.tabPage1.Controls.Add(this.adminOnayDataGrid);
            this.tabPage1.Controls.Add(this.cbAdminOnay);
            this.tabPage1.Controls.Add(this.btnAdminOnay);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1031, 513);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Bekleyen";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.adminOnayDataGrid2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1031, 513);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Onaylı";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnAdminOnay
            // 
            this.btnAdminOnay.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdminOnay.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdminOnay.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnAdminOnay.Location = new System.Drawing.Point(6, 435);
            this.btnAdminOnay.Name = "btnAdminOnay";
            this.btnAdminOnay.Size = new System.Drawing.Size(171, 72);
            this.btnAdminOnay.TabIndex = 0;
            this.btnAdminOnay.Text = "Kaydet";
            this.btnAdminOnay.UseVisualStyleBackColor = false;
            this.btnAdminOnay.Click += new System.EventHandler(this.btnAdminOnay_Click);
            // 
            // cbAdminOnay
            // 
            this.cbAdminOnay.AutoSize = true;
            this.cbAdminOnay.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbAdminOnay.Location = new System.Drawing.Point(6, 397);
            this.cbAdminOnay.Name = "cbAdminOnay";
            this.cbAdminOnay.Size = new System.Drawing.Size(79, 32);
            this.cbAdminOnay.TabIndex = 1;
            this.cbAdminOnay.Text = "Onay";
            this.cbAdminOnay.UseVisualStyleBackColor = true;
            // 
            // adminOnayDataGrid
            // 
            this.adminOnayDataGrid.AllowUserToAddRows = false;
            this.adminOnayDataGrid.AllowUserToDeleteRows = false;
            this.adminOnayDataGrid.AllowUserToOrderColumns = true;
            this.adminOnayDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.adminOnayDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.adminOnayDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.OldLace;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.adminOnayDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.adminOnayDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.adminOnayDataGrid.GridColor = System.Drawing.Color.Plum;
            this.adminOnayDataGrid.Location = new System.Drawing.Point(6, 6);
            this.adminOnayDataGrid.MultiSelect = false;
            this.adminOnayDataGrid.Name = "adminOnayDataGrid";
            this.adminOnayDataGrid.ReadOnly = true;
            this.adminOnayDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.adminOnayDataGrid.ShowEditingIcon = false;
            this.adminOnayDataGrid.Size = new System.Drawing.Size(1019, 383);
            this.adminOnayDataGrid.TabIndex = 2;
            // 
            // adminOnayDataGrid2
            // 
            this.adminOnayDataGrid2.AllowUserToAddRows = false;
            this.adminOnayDataGrid2.AllowUserToDeleteRows = false;
            this.adminOnayDataGrid2.AllowUserToOrderColumns = true;
            this.adminOnayDataGrid2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.adminOnayDataGrid2.BackgroundColor = System.Drawing.Color.White;
            this.adminOnayDataGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.OldLace;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.adminOnayDataGrid2.DefaultCellStyle = dataGridViewCellStyle4;
            this.adminOnayDataGrid2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.adminOnayDataGrid2.GridColor = System.Drawing.Color.Plum;
            this.adminOnayDataGrid2.Location = new System.Drawing.Point(6, 6);
            this.adminOnayDataGrid2.MultiSelect = false;
            this.adminOnayDataGrid2.Name = "adminOnayDataGrid2";
            this.adminOnayDataGrid2.ReadOnly = true;
            this.adminOnayDataGrid2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.adminOnayDataGrid2.ShowEditingIcon = false;
            this.adminOnayDataGrid2.Size = new System.Drawing.Size(1019, 501);
            this.adminOnayDataGrid2.TabIndex = 3;
            // 
            // txtAdminOnay
            // 
            this.txtAdminOnay.Location = new System.Drawing.Point(197, 435);
            this.txtAdminOnay.Multiline = true;
            this.txtAdminOnay.Name = "txtAdminOnay";
            this.txtAdminOnay.Size = new System.Drawing.Size(828, 72);
            this.txtAdminOnay.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(192, 415);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Açıklama";
            // 
            // adminOnay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1063, 563);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "adminOnay";
            this.Text = "adminOnay";
            this.Load += new System.EventHandler(this.adminOnay_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.adminOnayDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminOnayDataGrid2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox cbAdminOnay;
        private System.Windows.Forms.Button btnAdminOnay;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView adminOnayDataGrid;
        private System.Windows.Forms.DataGridView adminOnayDataGrid2;
        private System.Windows.Forms.TextBox txtAdminOnay;
        private System.Windows.Forms.Label label1;
    }
}