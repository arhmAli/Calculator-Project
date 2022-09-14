namespace Calculator
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
            this.button_decimal = new System.Windows.Forms.Button();
            this.button_binary = new System.Windows.Forms.Button();
            this.button_octal = new System.Windows.Forms.Button();
            this.button_hexa = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.userControl11 = new Calculator.UserControl1();
            this.userControl21 = new Calculator.UserControl2();
            this.userControl31 = new Calculator.UserControl3();
            this.userControl41 = new Calculator.UserControl4();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_decimal
            // 
            this.button_decimal.BackColor = System.Drawing.Color.White;
            this.button_decimal.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.button_decimal.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.HotTrack;
            this.button_decimal.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.button_decimal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.button_decimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_decimal.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_decimal.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button_decimal.Location = new System.Drawing.Point(0, 68);
            this.button_decimal.Name = "button_decimal";
            this.button_decimal.Size = new System.Drawing.Size(120, 40);
            this.button_decimal.TabIndex = 6;
            this.button_decimal.Text = "Decimal To";
            this.button_decimal.UseVisualStyleBackColor = false;
            this.button_decimal.Click += new System.EventHandler(this.Button_decimal_Click);
            this.button_decimal.MouseCaptureChanged += new System.EventHandler(this.Button_decimal_MouseCaptureChanged);
            // 
            // button_binary
            // 
            this.button_binary.BackColor = System.Drawing.Color.White;
            this.button_binary.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.button_binary.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.HotTrack;
            this.button_binary.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.button_binary.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.button_binary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_binary.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_binary.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button_binary.Location = new System.Drawing.Point(0, 106);
            this.button_binary.Name = "button_binary";
            this.button_binary.Size = new System.Drawing.Size(120, 40);
            this.button_binary.TabIndex = 7;
            this.button_binary.Text = "Binary To";
            this.button_binary.UseVisualStyleBackColor = false;
            this.button_binary.Click += new System.EventHandler(this.Button_binary_Click);
            // 
            // button_octal
            // 
            this.button_octal.BackColor = System.Drawing.Color.White;
            this.button_octal.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.button_octal.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.HotTrack;
            this.button_octal.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.button_octal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.button_octal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_octal.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_octal.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button_octal.Location = new System.Drawing.Point(0, 144);
            this.button_octal.Name = "button_octal";
            this.button_octal.Size = new System.Drawing.Size(120, 40);
            this.button_octal.TabIndex = 8;
            this.button_octal.Text = "Octal To";
            this.button_octal.UseVisualStyleBackColor = false;
            this.button_octal.Click += new System.EventHandler(this.Button_octal_Click);
            // 
            // button_hexa
            // 
            this.button_hexa.BackColor = System.Drawing.Color.White;
            this.button_hexa.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.button_hexa.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.HotTrack;
            this.button_hexa.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.button_hexa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.button_hexa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_hexa.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_hexa.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button_hexa.Location = new System.Drawing.Point(0, 182);
            this.button_hexa.Name = "button_hexa";
            this.button_hexa.Size = new System.Drawing.Size(120, 40);
            this.button_hexa.TabIndex = 9;
            this.button_hexa.Text = "Hexa To";
            this.button_hexa.UseVisualStyleBackColor = false;
            this.button_hexa.Click += new System.EventHandler(this.Button_hexa_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.button_hexa);
            this.panel1.Controls.Add(this.button_octal);
            this.panel1.Controls.Add(this.button_binary);
            this.panel1.Controls.Add(this.button_decimal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(121, 322);
            this.panel1.TabIndex = 0;
            // 
            // userControl11
            // 
            this.userControl11.BackColor = System.Drawing.Color.White;
            this.userControl11.Location = new System.Drawing.Point(122, 0);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(400, 322);
            this.userControl11.TabIndex = 10;
            // 
            // userControl21
            // 
            this.userControl21.BackColor = System.Drawing.Color.White;
            this.userControl21.Location = new System.Drawing.Point(122, 0);
            this.userControl21.Name = "userControl21";
            this.userControl21.Size = new System.Drawing.Size(400, 322);
            this.userControl21.TabIndex = 11;
            // 
            // userControl31
            // 
            this.userControl31.BackColor = System.Drawing.Color.White;
            this.userControl31.Location = new System.Drawing.Point(122, 0);
            this.userControl31.Name = "userControl31";
            this.userControl31.Size = new System.Drawing.Size(400, 322);
            this.userControl31.TabIndex = 12;
            // 
            // userControl41
            // 
            this.userControl41.BackColor = System.Drawing.Color.White;
            this.userControl41.Location = new System.Drawing.Point(122, 0);
            this.userControl41.Name = "userControl41";
            this.userControl41.Size = new System.Drawing.Size(400, 322);
            this.userControl41.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 322);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.userControl21);
            this.Controls.Add(this.userControl31);
            this.Controls.Add(this.userControl41);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programming Calculator";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_decimal;
        private System.Windows.Forms.Button button_binary;
        private System.Windows.Forms.Button button_octal;
        private System.Windows.Forms.Button button_hexa;
        private System.Windows.Forms.Panel panel1;
        private UserControl1 userControl11;
        private UserControl2 userControl21;
        private UserControl3 userControl31;
        private UserControl4 userControl41;
    }
}

