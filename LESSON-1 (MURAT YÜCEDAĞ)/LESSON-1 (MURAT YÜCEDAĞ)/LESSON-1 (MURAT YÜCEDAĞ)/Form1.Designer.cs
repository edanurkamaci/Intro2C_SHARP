
namespace LESSON_1__MURAT_YÜCEDAĞ_
{
    partial class Form
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
            this.name1 = new System.Windows.Forms.Label();
            this.surname1 = new System.Windows.Forms.Label();
            this.city1 = new System.Windows.Forms.Label();
            this.address1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.save = new System.Windows.Forms.Button();
            this.info = new System.Windows.Forms.Label();
            this.name2 = new System.Windows.Forms.Label();
            this.surname2 = new System.Windows.Forms.Label();
            this.city2 = new System.Windows.Forms.Label();
            this.address2 = new System.Windows.Forms.Label();
            this.name3 = new System.Windows.Forms.Label();
            this.surname3 = new System.Windows.Forms.Label();
            this.city3 = new System.Windows.Forms.Label();
            this.address3 = new System.Windows.Forms.Label();
            this.count = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // name1
            // 
            this.name1.AllowDrop = true;
            this.name1.AutoSize = true;
            this.name1.Font = new System.Drawing.Font("Arial Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.name1.ForeColor = System.Drawing.Color.White;
            this.name1.Location = new System.Drawing.Point(61, 38);
            this.name1.Name = "name1";
            this.name1.Size = new System.Drawing.Size(164, 48);
            this.name1.TabIndex = 0;
            this.name1.Text = "NAME : ";
            // 
            // surname1
            // 
            this.surname1.AllowDrop = true;
            this.surname1.AutoSize = true;
            this.surname1.Font = new System.Drawing.Font("Arial Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.surname1.ForeColor = System.Drawing.Color.White;
            this.surname1.Location = new System.Drawing.Point(61, 103);
            this.surname1.Name = "surname1";
            this.surname1.Size = new System.Drawing.Size(243, 48);
            this.surname1.TabIndex = 1;
            this.surname1.Text = "SURNAME : ";
            // 
            // city1
            // 
            this.city1.AllowDrop = true;
            this.city1.AutoSize = true;
            this.city1.Font = new System.Drawing.Font("Arial Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.city1.ForeColor = System.Drawing.Color.White;
            this.city1.Location = new System.Drawing.Point(61, 178);
            this.city1.Name = "city1";
            this.city1.Size = new System.Drawing.Size(143, 48);
            this.city1.TabIndex = 2;
            this.city1.Text = "CITY : ";
            // 
            // address1
            // 
            this.address1.AllowDrop = true;
            this.address1.AutoSize = true;
            this.address1.Font = new System.Drawing.Font("Arial Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.address1.ForeColor = System.Drawing.Color.White;
            this.address1.Location = new System.Drawing.Point(61, 254);
            this.address1.Name = "address1";
            this.address1.Size = new System.Drawing.Size(232, 48);
            this.address1.TabIndex = 3;
            this.address1.Text = "ADDRESS : ";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(331, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(271, 34);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(331, 115);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(271, 34);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox3.Location = new System.Drawing.Point(331, 266);
            this.textBox3.MaxLength = 120;
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(271, 185);
            this.textBox3.TabIndex = 6;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ADANA",
            "ANKARA",
            "ANTALYA",
            "ARTVİN",
            "BURSA",
            "ÇANAKKALE",
            "ERZURUM",
            "GAZİANTEP",
            "GİRESUN",
            "İSTANBUL",
            "İZMİR",
            "MUĞLA",
            "ORDU",
            "RİZE",
            "SAMSUN",
            "TEKİRDAĞ",
            "TOKAT",
            "TRABZON",
            "VAN",
            "ZONGULDAK"});
            this.comboBox1.Location = new System.Drawing.Point(331, 187);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(271, 35);
            this.comboBox1.TabIndex = 7;
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.Aqua;
            this.save.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.save.Location = new System.Drawing.Point(88, 396);
            this.save.Name = "save";
            this.save.Padding = new System.Windows.Forms.Padding(5);
            this.save.Size = new System.Drawing.Size(152, 55);
            this.save.TabIndex = 8;
            this.save.Text = "SAVE";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.info.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.info.Location = new System.Drawing.Point(810, 50);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(314, 48);
            this.info.TabIndex = 9;
            this.info.Text = "INFROMATIONS";
            // 
            // name2
            // 
            this.name2.AutoSize = true;
            this.name2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.name2.ForeColor = System.Drawing.Color.White;
            this.name2.Location = new System.Drawing.Point(708, 152);
            this.name2.Name = "name2";
            this.name2.Size = new System.Drawing.Size(123, 36);
            this.name2.TabIndex = 10;
            this.name2.Text = "Name: ";
            // 
            // surname2
            // 
            this.surname2.AutoSize = true;
            this.surname2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.surname2.ForeColor = System.Drawing.Color.White;
            this.surname2.Location = new System.Drawing.Point(708, 208);
            this.surname2.Name = "surname2";
            this.surname2.Size = new System.Drawing.Size(170, 36);
            this.surname2.TabIndex = 11;
            this.surname2.Text = "Surname: ";
            // 
            // city2
            // 
            this.city2.AutoSize = true;
            this.city2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.city2.ForeColor = System.Drawing.Color.White;
            this.city2.Location = new System.Drawing.Point(708, 266);
            this.city2.Name = "city2";
            this.city2.Size = new System.Drawing.Size(93, 36);
            this.city2.TabIndex = 12;
            this.city2.Text = "City: ";
            // 
            // address2
            // 
            this.address2.AutoSize = true;
            this.address2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.address2.ForeColor = System.Drawing.Color.White;
            this.address2.Location = new System.Drawing.Point(708, 328);
            this.address2.Name = "address2";
            this.address2.Size = new System.Drawing.Size(155, 36);
            this.address2.TabIndex = 13;
            this.address2.Text = "Address: ";
            // 
            // name3
            // 
            this.name3.AutoSize = true;
            this.name3.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.name3.ForeColor = System.Drawing.Color.White;
            this.name3.Location = new System.Drawing.Point(891, 152);
            this.name3.Name = "name3";
            this.name3.Size = new System.Drawing.Size(24, 36);
            this.name3.TabIndex = 14;
            this.name3.Text = " ";
            // 
            // surname3
            // 
            this.surname3.AutoSize = true;
            this.surname3.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.surname3.ForeColor = System.Drawing.Color.White;
            this.surname3.Location = new System.Drawing.Point(891, 208);
            this.surname3.Name = "surname3";
            this.surname3.Size = new System.Drawing.Size(24, 36);
            this.surname3.TabIndex = 15;
            this.surname3.Text = " ";
            // 
            // city3
            // 
            this.city3.AutoSize = true;
            this.city3.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.city3.ForeColor = System.Drawing.Color.White;
            this.city3.Location = new System.Drawing.Point(891, 266);
            this.city3.Name = "city3";
            this.city3.Size = new System.Drawing.Size(24, 36);
            this.city3.TabIndex = 16;
            this.city3.Text = " ";
            // 
            // address3
            // 
            this.address3.AutoSize = true;
            this.address3.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.address3.ForeColor = System.Drawing.Color.White;
            this.address3.Location = new System.Drawing.Point(891, 328);
            this.address3.Name = "address3";
            this.address3.Size = new System.Drawing.Size(24, 36);
            this.address3.TabIndex = 17;
            this.address3.Text = " ";
            // 
            // count
            // 
            this.count.AutoSize = true;
            this.count.BackColor = System.Drawing.Color.Snow;
            this.count.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.count.ForeColor = System.Drawing.Color.Black;
            this.count.Location = new System.Drawing.Point(546, 411);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(46, 29);
            this.count.TabIndex = 18;
            this.count.Text = "120";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1295, 609);
            this.Controls.Add(this.count);
            this.Controls.Add(this.address3);
            this.Controls.Add(this.city3);
            this.Controls.Add(this.surname3);
            this.Controls.Add(this.name3);
            this.Controls.Add(this.address2);
            this.Controls.Add(this.city2);
            this.Controls.Add(this.surname2);
            this.Controls.Add(this.name2);
            this.Controls.Add(this.info);
            this.Controls.Add(this.save);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.address1);
            this.Controls.Add(this.city1);
            this.Controls.Add(this.surname1);
            this.Controls.Add(this.name1);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ForeColor = System.Drawing.Color.SlateGray;
            this.Name = "Form";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name1;
        private System.Windows.Forms.Label surname1;
        private System.Windows.Forms.Label city1;
        private System.Windows.Forms.Label address1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.Label name2;
        private System.Windows.Forms.Label surname2;
        private System.Windows.Forms.Label city2;
        private System.Windows.Forms.Label address2;
        private System.Windows.Forms.Label name3;
        private System.Windows.Forms.Label surname3;
        private System.Windows.Forms.Label city3;
        private System.Windows.Forms.Label address3;
        private System.Windows.Forms.Label count;
    }
}

