namespace session5_projects
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.txtboxSample = new System.Windows.Forms.TextBox();
            this.txtboxAge = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.btnSample = new System.Windows.Forms.Button();
            this.cmboxGender = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(26, 30);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(86, 31);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "label1";
            // 
            // txtboxSample
            // 
            this.txtboxSample.Location = new System.Drawing.Point(236, 41);
            this.txtboxSample.Multiline = true;
            this.txtboxSample.Name = "txtboxSample";
            this.txtboxSample.Size = new System.Drawing.Size(292, 20);
            this.txtboxSample.TabIndex = 1;
            this.txtboxSample.TextChanged += new System.EventHandler(this.txtboxSample_TextChanged);
            this.txtboxSample.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtboxSample_KeyDown);
            // 
            // txtboxAge
            // 
            this.txtboxAge.Location = new System.Drawing.Point(96, 227);
            this.txtboxAge.Name = "txtboxAge";
            this.txtboxAge.Size = new System.Drawing.Size(121, 20);
            this.txtboxAge.TabIndex = 2;
            this.txtboxAge.BackColorChanged += new System.EventHandler(this.txtboxAge_BackColorChanged);
            this.txtboxAge.ForeColorChanged += new System.EventHandler(this.txtboxAge_ForeColorChanged);
            this.txtboxAge.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtboxAge_KeyDown);
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(29, 230);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(26, 13);
            this.lblAge.TabIndex = 3;
            this.lblAge.Text = "Age";
            // 
            // btnSample
            // 
            this.btnSample.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSample.Image = ((System.Drawing.Image)(resources.GetObject("btnSample.Image")));
            this.btnSample.Location = new System.Drawing.Point(391, 215);
            this.btnSample.Name = "btnSample";
            this.btnSample.Size = new System.Drawing.Size(101, 90);
            this.btnSample.TabIndex = 4;
            this.btnSample.Text = "Click on me!";
            this.btnSample.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSample.UseVisualStyleBackColor = true;
            this.btnSample.Click += new System.EventHandler(this.btnSample_Click);
            // 
            // cmboxGender
            // 
            this.cmboxGender.FormattingEnabled = true;
            this.cmboxGender.Items.AddRange(new object[] {
            "man",
            "woman"});
            this.cmboxGender.Location = new System.Drawing.Point(96, 284);
            this.cmboxGender.Name = "cmboxGender";
            this.cmboxGender.Size = new System.Drawing.Size(121, 21);
            this.cmboxGender.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "gender";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 344);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmboxGender);
            this.Controls.Add(this.btnSample);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.txtboxAge);
            this.Controls.Add(this.txtboxSample);
            this.Controls.Add(this.lblWelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.TextBox txtboxSample;
        private System.Windows.Forms.TextBox txtboxAge;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Button btnSample;
        private System.Windows.Forms.ComboBox cmboxGender;
        private System.Windows.Forms.Label label1;
    }
}

