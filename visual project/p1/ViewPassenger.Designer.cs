namespace p1
{
    partial class ViewPassenger
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Pid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Na = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Pass = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Ph = new System.Windows.Forms.TextBox();
            this.Gen = new System.Windows.Forms.ComboBox();
            this.Nat = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.airline0bDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.airline0bDataSet = new p1.Airline0bDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
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
            this.label2.Location = new System.Drawing.Point(160, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(396, 31);
            this.label2.TabIndex = 8;
            this.label2.Text = "Sky Jet Airline";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Goudy Stout", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(155, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "View Passengers";
            // 
            // Pid
            // 
            this.Pid.Location = new System.Drawing.Point(157, 158);
            this.Pid.Name = "Pid";
            this.Pid.Size = new System.Drawing.Size(166, 24);
            this.Pid.TabIndex = 26;
            this.Pid.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(33, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 23);
            this.label3.TabIndex = 25;
            this.label3.Text = "Passenger Id";
            // 
            // Na
            // 
            this.Na.Location = new System.Drawing.Point(449, 159);
            this.Na.Name = "Na";
            this.Na.Size = new System.Drawing.Size(216, 24);
            this.Na.TabIndex = 28;
            this.Na.TextChanged += new System.EventHandler(this.Na_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(361, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 23);
            this.label4.TabIndex = 27;
            this.label4.Text = "Name";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(449, 212);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(216, 24);
            this.Add.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(361, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 23);
            this.label5.TabIndex = 31;
            this.label5.Text = "Address";
            // 
            // Pass
            // 
            this.Pass.Location = new System.Drawing.Point(157, 213);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(166, 24);
            this.Pass.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(33, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 23);
            this.label6.TabIndex = 29;
            this.label6.Text = "Passport";
            // 
            // Ph
            // 
            this.Ph.Location = new System.Drawing.Point(158, 320);
            this.Ph.Name = "Ph";
            this.Ph.Size = new System.Drawing.Size(166, 24);
            this.Ph.TabIndex = 42;
            // 
            // Gen
            // 
            this.Gen.FormattingEnabled = true;
            this.Gen.Items.AddRange(new object[] {
            "Male",
            "Famale"});
            this.Gen.Location = new System.Drawing.Point(449, 263);
            this.Gen.Name = "Gen";
            this.Gen.Size = new System.Drawing.Size(216, 24);
            this.Gen.TabIndex = 41;
            // 
            // Nat
            // 
            this.Nat.FormattingEnabled = true;
            this.Nat.Items.AddRange(new object[] {
            "Algerian",
            "American",
            "British",
            "Bahraini",
            "Chinese",
            "Canadian",
            "Egyptian",
            "Emirati",
            "French",
            "Greek",
            "German",
            "Iraqi",
            "Indian",
            "Italian",
            "Jordanian",
            "Japanese",
            "Kuwaiti",
            "Korean",
            "Libyan",
            "Lebanese",
            "Moroccan",
            "Mauritian",
            "Malaysian",
            "Oman",
            "Pakistani",
            "Polish",
            "Portuguese",
            "Qatari",
            "Russian",
            "Romanian",
            "Syrian",
            "Swiss",
            "Swedish",
            "Sudanese",
            "Spanish",
            "Saudi",
            "Turkish",
            "Tunisian",
            "Yemeni"});
            this.Nat.Location = new System.Drawing.Point(157, 266);
            this.Nat.Name = "Nat";
            this.Nat.Size = new System.Drawing.Size(166, 24);
            this.Nat.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label9.Location = new System.Drawing.Point(34, 321);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 23);
            this.label9.TabIndex = 39;
            this.label9.Text = "Phone";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label8.Location = new System.Drawing.Point(361, 264);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 23);
            this.label8.TabIndex = 38;
            this.label8.Text = "Gender";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(33, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 23);
            this.label7.TabIndex = 37;
            this.label7.Text = "Nationality";
            this.label7.Click += new System.EventHandler(this.label7_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.ForeColor = System.Drawing.Color.Maroon;
            this.button3.Location = new System.Drawing.Point(227, 382);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 62);
            this.button3.TabIndex = 46;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.ForeColor = System.Drawing.Color.Maroon;
            this.button4.Location = new System.Drawing.Point(74, 382);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(127, 62);
            this.button4.TabIndex = 45;
            this.button4.Text = "Update";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.ForeColor = System.Drawing.Color.Maroon;
            this.button2.Location = new System.Drawing.Point(379, 382);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 62);
            this.button2.TabIndex = 44;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(531, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 62);
            this.button1.TabIndex = 43;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgv1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv1.Location = new System.Drawing.Point(-2, 467);
            this.dgv1.Name = "dgv1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv1.RowHeadersWidth = 51;
            this.dgv1.RowTemplate.Height = 26;
            this.dgv1.Size = new System.Drawing.Size(725, 237);
            this.dgv1.TabIndex = 47;
            this.dgv1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(723, 40);
            this.panel1.TabIndex = 48;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Navy;
            this.label11.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkRed;
            this.label11.Location = new System.Drawing.Point(692, 1);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 33);
            this.label11.TabIndex = 40;
            this.label11.Text = "X";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Navy;
            this.label10.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkRed;
            this.label10.Location = new System.Drawing.Point(728, 2);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 33);
            this.label10.TabIndex = 39;
            this.label10.Text = "X";
            // 
            // ViewPassenger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 685);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Ph);
            this.Controls.Add(this.Gen);
            this.Controls.Add(this.Nat);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Na);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Pid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewPassenger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewPassenger";
            this.Load += new System.EventHandler(this.ViewPassenger_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
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
        private System.Windows.Forms.TextBox Pid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Na;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Add;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Pass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Ph;
        private System.Windows.Forms.ComboBox Gen;
        private System.Windows.Forms.ComboBox Nat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.BindingSource airline0bDataSetBindingSource;
        private Airline0bDataSet airline0bDataSet;
    }
}