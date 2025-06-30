namespace FinancialCrm
{
    partial class FrmSpendings
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSpendingUpdate = new System.Windows.Forms.Button();
            this.btnSpendingDelete = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSpendingAdd = new System.Windows.Forms.Button();
            this.btnSpendingList = new System.Windows.Forms.Button();
            this.txtSpendingPeriod = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSpendingAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSpendingTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSpendingId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.btnSpendings = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnBanksForm = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(1, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1207, 43);
            this.panel4.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.RosyBrown;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "Harcamalar Formu";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(898, 315);
            this.dataGridView2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView2);
            this.panel3.Location = new System.Drawing.Point(284, 305);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(898, 315);
            this.panel3.TabIndex = 15;
            // 
            // btnSpendingUpdate
            // 
            this.btnSpendingUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpendingUpdate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSpendingUpdate.ForeColor = System.Drawing.Color.Brown;
            this.btnSpendingUpdate.Location = new System.Drawing.Point(654, 190);
            this.btnSpendingUpdate.Name = "btnSpendingUpdate";
            this.btnSpendingUpdate.Size = new System.Drawing.Size(175, 46);
            this.btnSpendingUpdate.TabIndex = 11;
            this.btnSpendingUpdate.Text = "Güncelle";
            this.btnSpendingUpdate.UseVisualStyleBackColor = true;
            this.btnSpendingUpdate.Click += new System.EventHandler(this.btnSpendingUpdate_Click);
            // 
            // btnSpendingDelete
            // 
            this.btnSpendingDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpendingDelete.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSpendingDelete.ForeColor = System.Drawing.Color.Brown;
            this.btnSpendingDelete.Location = new System.Drawing.Point(487, 190);
            this.btnSpendingDelete.Name = "btnSpendingDelete";
            this.btnSpendingDelete.Size = new System.Drawing.Size(149, 46);
            this.btnSpendingDelete.TabIndex = 10;
            this.btnSpendingDelete.Text = "Sil";
            this.btnSpendingDelete.UseVisualStyleBackColor = true;
            this.btnSpendingDelete.Click += new System.EventHandler(this.btnSpendingDelete_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSpendingUpdate);
            this.panel2.Controls.Add(this.btnSpendingDelete);
            this.panel2.Controls.Add(this.btnSpendingAdd);
            this.panel2.Controls.Add(this.btnSpendingList);
            this.panel2.Controls.Add(this.txtSpendingPeriod);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtSpendingAmount);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtSpendingTitle);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtSpendingId);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(284, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(898, 238);
            this.panel2.TabIndex = 14;
            // 
            // btnSpendingAdd
            // 
            this.btnSpendingAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpendingAdd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSpendingAdd.ForeColor = System.Drawing.Color.Brown;
            this.btnSpendingAdd.Location = new System.Drawing.Point(321, 190);
            this.btnSpendingAdd.Name = "btnSpendingAdd";
            this.btnSpendingAdd.Size = new System.Drawing.Size(149, 46);
            this.btnSpendingAdd.TabIndex = 9;
            this.btnSpendingAdd.Text = "Ekle";
            this.btnSpendingAdd.UseVisualStyleBackColor = true;
            this.btnSpendingAdd.Click += new System.EventHandler(this.btnSpendingAdd_Click);
            // 
            // btnSpendingList
            // 
            this.btnSpendingList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpendingList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSpendingList.ForeColor = System.Drawing.Color.Brown;
            this.btnSpendingList.Location = new System.Drawing.Point(141, 190);
            this.btnSpendingList.Name = "btnSpendingList";
            this.btnSpendingList.Size = new System.Drawing.Size(164, 46);
            this.btnSpendingList.TabIndex = 8;
            this.btnSpendingList.Text = "Listele";
            this.btnSpendingList.UseVisualStyleBackColor = true;
            this.btnSpendingList.Click += new System.EventHandler(this.btnSpendingList_Click);
            // 
            // txtSpendingPeriod
            // 
            this.txtSpendingPeriod.BackColor = System.Drawing.Color.PeachPuff;
            this.txtSpendingPeriod.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSpendingPeriod.Location = new System.Drawing.Point(127, 143);
            this.txtSpendingPeriod.Name = "txtSpendingPeriod";
            this.txtSpendingPeriod.Size = new System.Drawing.Size(719, 32);
            this.txtSpendingPeriod.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Brown;
            this.label4.Location = new System.Drawing.Point(41, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Periyot:";
            // 
            // txtSpendingAmount
            // 
            this.txtSpendingAmount.BackColor = System.Drawing.Color.PeachPuff;
            this.txtSpendingAmount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSpendingAmount.Location = new System.Drawing.Point(127, 105);
            this.txtSpendingAmount.Name = "txtSpendingAmount";
            this.txtSpendingAmount.Size = new System.Drawing.Size(719, 32);
            this.txtSpendingAmount.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Brown;
            this.label3.Location = new System.Drawing.Point(45, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Miktar:";
            // 
            // txtSpendingTitle
            // 
            this.txtSpendingTitle.BackColor = System.Drawing.Color.PeachPuff;
            this.txtSpendingTitle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSpendingTitle.Location = new System.Drawing.Point(127, 67);
            this.txtSpendingTitle.Name = "txtSpendingTitle";
            this.txtSpendingTitle.Size = new System.Drawing.Size(719, 32);
            this.txtSpendingTitle.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(52, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Başlık:";
            // 
            // txtSpendingId
            // 
            this.txtSpendingId.BackColor = System.Drawing.Color.PeachPuff;
            this.txtSpendingId.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSpendingId.Location = new System.Drawing.Point(127, 29);
            this.txtSpendingId.Name = "txtSpendingId";
            this.txtSpendingId.Size = new System.Drawing.Size(719, 32);
            this.txtSpendingId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(18, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Harcama ID:";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(31, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "Kategoriler";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.btnSpendings);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.btnBanksForm);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(1, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 595);
            this.panel1.TabIndex = 13;
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button5.Location = new System.Drawing.Point(31, 491);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(203, 46);
            this.button5.TabIndex = 7;
            this.button5.Text = "Çıkış Yap";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button6.Location = new System.Drawing.Point(31, 425);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(203, 46);
            this.button6.TabIndex = 6;
            this.button6.Text = "Ayarlar";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button7.Location = new System.Drawing.Point(31, 362);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(203, 46);
            this.button7.TabIndex = 5;
            this.button7.Text = "Dashbord";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button8.Location = new System.Drawing.Point(31, 297);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(203, 46);
            this.button8.TabIndex = 4;
            this.button8.Text = "Banka Hareketleri";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnSpendings
            // 
            this.btnSpendings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpendings.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSpendings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSpendings.Location = new System.Drawing.Point(31, 231);
            this.btnSpendings.Name = "btnSpendings";
            this.btnSpendings.Size = new System.Drawing.Size(203, 46);
            this.btnSpendings.TabIndex = 3;
            this.btnSpendings.Text = "Giderler";
            this.btnSpendings.UseVisualStyleBackColor = true;
            this.btnSpendings.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button4.Location = new System.Drawing.Point(31, 166);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(203, 46);
            this.button4.TabIndex = 2;
            this.button4.Text = "Faturalar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnBanksForm
            // 
            this.btnBanksForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanksForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBanksForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnBanksForm.Location = new System.Drawing.Point(31, 102);
            this.btnBanksForm.Name = "btnBanksForm";
            this.btnBanksForm.Size = new System.Drawing.Size(203, 46);
            this.btnBanksForm.TabIndex = 1;
            this.btnBanksForm.Text = "Bankalar";
            this.btnBanksForm.UseVisualStyleBackColor = true;
            this.btnBanksForm.Click += new System.EventHandler(this.btnBanksForm_Click);
            // 
            // FrmSpendings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(1208, 637);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSpendings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSpendings";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSpendingUpdate;
        private System.Windows.Forms.Button btnSpendingDelete;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSpendingAdd;
        private System.Windows.Forms.Button btnSpendingList;
        private System.Windows.Forms.TextBox txtSpendingPeriod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSpendingAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSpendingTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSpendingId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button btnSpendings;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnBanksForm;
    }
}