namespace TelefonRehberii
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.text_id = new System.Windows.Forms.TextBox();
            this.text_Adi = new System.Windows.Forms.TextBox();
            this.text_Soyadi = new System.Windows.Forms.TextBox();
            this.text_Numara = new System.Windows.Forms.TextBox();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.text_Arama = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(80, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kişi ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(102, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(77, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soyadı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(1, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefon Numarası";
            // 
            // text_id
            // 
            this.text_id.Location = new System.Drawing.Point(143, 27);
            this.text_id.Name = "text_id";
            this.text_id.Size = new System.Drawing.Size(123, 20);
            this.text_id.TabIndex = 4;
            // 
            // text_Adi
            // 
            this.text_Adi.Location = new System.Drawing.Point(143, 64);
            this.text_Adi.Name = "text_Adi";
            this.text_Adi.Size = new System.Drawing.Size(123, 20);
            this.text_Adi.TabIndex = 5;
            // 
            // text_Soyadi
            // 
            this.text_Soyadi.Location = new System.Drawing.Point(143, 100);
            this.text_Soyadi.Name = "text_Soyadi";
            this.text_Soyadi.Size = new System.Drawing.Size(123, 20);
            this.text_Soyadi.TabIndex = 6;
            // 
            // text_Numara
            // 
            this.text_Numara.Location = new System.Drawing.Point(143, 138);
            this.text_Numara.Name = "text_Numara";
            this.text_Numara.Size = new System.Drawing.Size(123, 20);
            this.text_Numara.TabIndex = 7;
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Ekle.Location = new System.Drawing.Point(363, 50);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(88, 32);
            this.btn_Ekle.TabIndex = 8;
            this.btn_Ekle.Text = "EKLE";
            this.btn_Ekle.UseVisualStyleBackColor = true;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // btn_Sil
            // 
            this.btn_Sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Sil.Location = new System.Drawing.Point(484, 50);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(88, 32);
            this.btn_Sil.TabIndex = 9;
            this.btn_Sil.Text = "SİL";
            this.btn_Sil.UseVisualStyleBackColor = true;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Guncelle.Location = new System.Drawing.Point(423, 100);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(105, 36);
            this.btn_Guncelle.TabIndex = 10;
            this.btn_Guncelle.Text = "GÜNCELLE";
            this.btn_Guncelle.UseVisualStyleBackColor = true;
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(176, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "İsime Göre Ara :";
            // 
            // text_Arama
            // 
            this.text_Arama.Location = new System.Drawing.Point(323, 184);
            this.text_Arama.Name = "text_Arama";
            this.text_Arama.Size = new System.Drawing.Size(219, 20);
            this.text_Arama.TabIndex = 12;
            this.text_Arama.TextChanged += new System.EventHandler(this.text_Arama_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 210);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(623, 221);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(696, 443);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.text_Arama);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_Guncelle);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.text_Numara);
            this.Controls.Add(this.text_Soyadi);
            this.Controls.Add(this.text_Adi);
            this.Controls.Add(this.text_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_id;
        private System.Windows.Forms.TextBox text_Adi;
        private System.Windows.Forms.TextBox text_Soyadi;
        private System.Windows.Forms.TextBox text_Numara;
        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Button btn_Guncelle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox text_Arama;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

