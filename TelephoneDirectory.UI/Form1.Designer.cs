
namespace TelephoneDirectory.UI
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbxUpdate = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbxPhoneNumberUpdate = new System.Windows.Forms.TextBox();
            this.tbxSurnameUpdate = new System.Windows.Forms.TextBox();
            this.tbxNameUpdate = new System.Windows.Forms.TextBox();
            this.lblPhoneNumberUpdate = new System.Windows.Forms.Label();
            this.lblSurnameUpdate = new System.Windows.Forms.Label();
            this.lblNameUpdate = new System.Windows.Forms.Label();
            this.gbxKisiEkle = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txbPhoneNumber = new System.Windows.Forms.TextBox();
            this.txbSurname = new System.Windows.Forms.TextBox();
            this.txbName = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbxUpdate.SuspendLayout();
            this.gbxKisiEkle.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 59);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(820, 300);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(554, 14);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(159, 36);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Kişi Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // gbxUpdate
            // 
            this.gbxUpdate.Controls.Add(this.btnUpdate);
            this.gbxUpdate.Controls.Add(this.tbxPhoneNumberUpdate);
            this.gbxUpdate.Controls.Add(this.tbxSurnameUpdate);
            this.gbxUpdate.Controls.Add(this.tbxNameUpdate);
            this.gbxUpdate.Controls.Add(this.lblPhoneNumberUpdate);
            this.gbxUpdate.Controls.Add(this.lblSurnameUpdate);
            this.gbxUpdate.Controls.Add(this.lblNameUpdate);
            this.gbxUpdate.Location = new System.Drawing.Point(405, 379);
            this.gbxUpdate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.gbxUpdate.Name = "gbxUpdate";
            this.gbxUpdate.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.gbxUpdate.Size = new System.Drawing.Size(428, 286);
            this.gbxUpdate.TabIndex = 7;
            this.gbxUpdate.TabStop = false;
            this.gbxUpdate.Text = "Kişi Güncelle";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(146, 208);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(204, 51);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbxPhoneNumberUpdate
            // 
            this.tbxPhoneNumberUpdate.Location = new System.Drawing.Point(147, 159);
            this.tbxPhoneNumberUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxPhoneNumberUpdate.Name = "tbxPhoneNumberUpdate";
            this.tbxPhoneNumberUpdate.Size = new System.Drawing.Size(203, 27);
            this.tbxPhoneNumberUpdate.TabIndex = 5;
            // 
            // tbxSurnameUpdate
            // 
            this.tbxSurnameUpdate.Location = new System.Drawing.Point(146, 110);
            this.tbxSurnameUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxSurnameUpdate.Name = "tbxSurnameUpdate";
            this.tbxSurnameUpdate.Size = new System.Drawing.Size(203, 27);
            this.tbxSurnameUpdate.TabIndex = 4;
            // 
            // tbxNameUpdate
            // 
            this.tbxNameUpdate.Location = new System.Drawing.Point(146, 61);
            this.tbxNameUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxNameUpdate.Name = "tbxNameUpdate";
            this.tbxNameUpdate.Size = new System.Drawing.Size(203, 27);
            this.tbxNameUpdate.TabIndex = 3;
            // 
            // lblPhoneNumberUpdate
            // 
            this.lblPhoneNumberUpdate.AutoSize = true;
            this.lblPhoneNumberUpdate.Location = new System.Drawing.Point(42, 163);
            this.lblPhoneNumberUpdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhoneNumberUpdate.Name = "lblPhoneNumberUpdate";
            this.lblPhoneNumberUpdate.Size = new System.Drawing.Size(100, 20);
            this.lblPhoneNumberUpdate.TabIndex = 2;
            this.lblPhoneNumberUpdate.Text = "Telefon No :";
            // 
            // lblSurnameUpdate
            // 
            this.lblSurnameUpdate.AutoSize = true;
            this.lblSurnameUpdate.Location = new System.Drawing.Point(76, 110);
            this.lblSurnameUpdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSurnameUpdate.Name = "lblSurnameUpdate";
            this.lblSurnameUpdate.Size = new System.Drawing.Size(65, 20);
            this.lblSurnameUpdate.TabIndex = 1;
            this.lblSurnameUpdate.Text = "Soyad :";
            // 
            // lblNameUpdate
            // 
            this.lblNameUpdate.AutoSize = true;
            this.lblNameUpdate.Location = new System.Drawing.Point(102, 61);
            this.lblNameUpdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNameUpdate.Name = "lblNameUpdate";
            this.lblNameUpdate.Size = new System.Drawing.Size(39, 20);
            this.lblNameUpdate.TabIndex = 0;
            this.lblNameUpdate.Text = "Ad :";
            // 
            // gbxKisiEkle
            // 
            this.gbxKisiEkle.Controls.Add(this.btnAdd);
            this.gbxKisiEkle.Controls.Add(this.txbPhoneNumber);
            this.gbxKisiEkle.Controls.Add(this.txbSurname);
            this.gbxKisiEkle.Controls.Add(this.txbName);
            this.gbxKisiEkle.Controls.Add(this.lblPhoneNumber);
            this.gbxKisiEkle.Controls.Add(this.lblSurname);
            this.gbxKisiEkle.Controls.Add(this.lblName);
            this.gbxKisiEkle.Location = new System.Drawing.Point(13, 379);
            this.gbxKisiEkle.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.gbxKisiEkle.Name = "gbxKisiEkle";
            this.gbxKisiEkle.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.gbxKisiEkle.Size = new System.Drawing.Size(382, 286);
            this.gbxKisiEkle.TabIndex = 6;
            this.gbxKisiEkle.TabStop = false;
            this.gbxKisiEkle.Text = "Yeni Kişi Ekle";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(144, 208);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(204, 51);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Kaydet";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txbPhoneNumber
            // 
            this.txbPhoneNumber.Location = new System.Drawing.Point(144, 162);
            this.txbPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbPhoneNumber.Name = "txbPhoneNumber";
            this.txbPhoneNumber.Size = new System.Drawing.Size(203, 27);
            this.txbPhoneNumber.TabIndex = 5;
            // 
            // txbSurname
            // 
            this.txbSurname.Location = new System.Drawing.Point(144, 117);
            this.txbSurname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbSurname.Name = "txbSurname";
            this.txbSurname.Size = new System.Drawing.Size(203, 27);
            this.txbSurname.TabIndex = 4;
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(144, 68);
            this.txbName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(203, 27);
            this.txbName.TabIndex = 3;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(42, 166);
            this.lblPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.lblPhoneNumber.TabIndex = 2;
            this.lblPhoneNumber.Text = "Telefon No :";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(77, 117);
            this.lblSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(65, 20);
            this.lblSurname.TabIndex = 1;
            this.lblSurname.Text = "Soyad :";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(103, 68);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Ad :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 675);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.gbxUpdate);
            this.Controls.Add(this.gbxKisiEkle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbxUpdate.ResumeLayout(false);
            this.gbxUpdate.PerformLayout();
            this.gbxKisiEkle.ResumeLayout(false);
            this.gbxKisiEkle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox gbxUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbxPhoneNumberUpdate;
        private System.Windows.Forms.TextBox tbxSurnameUpdate;
        private System.Windows.Forms.TextBox tbxNameUpdate;
        private System.Windows.Forms.Label lblPhoneNumberUpdate;
        private System.Windows.Forms.Label lblSurnameUpdate;
        private System.Windows.Forms.Label lblNameUpdate;
        private System.Windows.Forms.GroupBox gbxKisiEkle;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txbPhoneNumber;
        private System.Windows.Forms.TextBox txbSurname;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblName;
    }
}

