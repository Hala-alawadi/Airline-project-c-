namespace p1
{
    partial class ViewFlights
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.T = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.D = new System.Windows.Forms.ComboBox();
            this.S = new System.Windows.Forms.ComboBox();
            this.N = new System.Windows.Forms.TextBox();
            this.F = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.airline0bDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.airline0bDataSet = new p1.Airline0bDataSet();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airline0bDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airline0bDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Goudy Stout", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(177, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(396, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sky Jet Airline";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Goudy Stout", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(79, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(590, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "View Scheduled Flights";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // T
            // 
            this.T.CalendarForeColor = System.Drawing.Color.Red;
            this.T.Location = new System.Drawing.Point(138, 266);
            this.T.Name = "T";
            this.T.Size = new System.Drawing.Size(222, 24);
            this.T.TabIndex = 27;
            this.T.Value = new System.DateTime(2023, 12, 7, 23, 59, 59, 0);
            this.T.ValueChanged += new System.EventHandler(this.T_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(12, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 23);
            this.label7.TabIndex = 26;
            this.label7.Text = "Take of Date";
            // 
            // D
            // 
            this.D.FormattingEnabled = true;
            this.D.Items.AddRange(new object[] {
            "United States Of America",
            "Brazil",
            "Mexico",
            "Canada",
            "Russia",
            "Argentina",
            "Colombia",
            "South Africa",
            "Germany",
            "China",
            "Chile",
            "Australia",
            "Jordan",
            "Qatar",
            "Kingdom Of Saudi Arabi",
            "Yemen ",
            "Syria",
            "Lobnon",
            "Egypt",
            "Moroco",
            "United Arab Emirates",
            "Kuwait"});
            this.D.Location = new System.Drawing.Point(488, 266);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(192, 24);
            this.D.TabIndex = 25;
            // 
            // S
            // 
            this.S.FormattingEnabled = true;
            this.S.Items.AddRange(new object[] {
            "United States Of America",
            "Brazil",
            "Mexico",
            "Canada",
            "Russia",
            "Argentina",
            "Colombia",
            "South Africa",
            "Germany",
            "China",
            "Chile",
            "Australia",
            "Jordan",
            "Qatar",
            "Kingdom Of Saudi Arabi",
            "Yemen ",
            "Syria",
            "Lobnon",
            "Egypt",
            "Moroco",
            "United Arab Emirates",
            "Kuwait"});
            this.S.Location = new System.Drawing.Point(477, 180);
            this.S.Name = "S";
            this.S.Size = new System.Drawing.Size(192, 24);
            this.S.TabIndex = 24;
            // 
            // N
            // 
            this.N.Location = new System.Drawing.Point(336, 339);
            this.N.Name = "N";
            this.N.Size = new System.Drawing.Size(222, 24);
            this.N.TabIndex = 23;
            // 
            // F
            // 
            this.F.Location = new System.Drawing.Point(145, 184);
            this.F.Name = "F";
            this.F.Size = new System.Drawing.Size(215, 24);
            this.F.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(376, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 23);
            this.label6.TabIndex = 21;
            this.label6.Text = "Destination";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(210, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 23);
            this.label5.TabIndex = 20;
            this.label5.Text = "Num Of Seats";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(397, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 23);
            this.label4.TabIndex = 19;
            this.label4.Text = "Source";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(12, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 23);
            this.label3.TabIndex = 18;
            this.label3.Text = "Flight Code";
            // 
            // dgv2
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Blue;
            this.dgv2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv2.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv2.Location = new System.Drawing.Point(0, 467);
            this.dgv2.Name = "dgv2";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv2.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv2.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgv2.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv2.RowTemplate.Height = 26;
            this.dgv2.Size = new System.Drawing.Size(737, 237);
            this.dgv2.TabIndex = 28;
            this.dgv2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_Click);
            this.dgv2.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv2_CellFormatting);
            this.dgv2.Click += new System.EventHandler(this.dgv2_Click);
            // 
            // airline0bDataSetBindingSource
            // 
            this.airline0bDataSetBindingSource.DataSource = this.airline0bDataSet;
            this.airline0bDataSetBindingSource.Position = 0;
            // 
            // airline0bDataSet
            // 
            this.airline0bDataSet.DataSetName = "Airline0bDataSet";
            this.airline0bDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.ForeColor = System.Drawing.Color.Maroon;
            this.button2.Location = new System.Drawing.Point(388, 395);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 62);
            this.button2.TabIndex = 30;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(540, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 62);
            this.button1.TabIndex = 29;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.ForeColor = System.Drawing.Color.Maroon;
            this.button3.Location = new System.Drawing.Point(236, 395);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 62);
            this.button3.TabIndex = 32;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.ForeColor = System.Drawing.Color.Maroon;
            this.button4.Location = new System.Drawing.Point(83, 395);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(127, 62);
            this.button4.TabIndex = 31;
            this.button4.Text = "Update";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.label13);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(737, 40);
            this.panel1.TabIndex = 64;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Navy;
            this.label13.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DarkRed;
            this.label13.Location = new System.Drawing.Point(710, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 33);
            this.label13.TabIndex = 39;
            this.label13.Text = "X";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // ViewFlights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 716);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv2);
            this.Controls.Add(this.T);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.D);
            this.Controls.Add(this.S);
            this.Controls.Add(this.N);
            this.Controls.Add(this.F);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewFlights";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewFlights";
            this.Load += new System.EventHandler(this.ViewFlights_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airline0bDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airline0bDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker T;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox D;
        private System.Windows.Forms.ComboBox S;
        private System.Windows.Forms.TextBox N;
        private System.Windows.Forms.TextBox F;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.BindingSource airline0bDataSetBindingSource;
        private Airline0bDataSet airline0bDataSet;
    }
}