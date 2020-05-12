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
            this.cmboxDate = new System.Windows.Forms.ComboBox();
            this.comboBoxDynamic = new System.Windows.Forms.ComboBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.btnCheked = new System.Windows.Forms.Button();
            this.rbtnRed = new System.Windows.Forms.RadioButton();
            this.rbtnBlue = new System.Windows.Forms.RadioButton();
            this.rbtnGreen = new System.Windows.Forms.RadioButton();
            this.gboxColors = new System.Windows.Forms.GroupBox();
            this.btnColor = new System.Windows.Forms.Button();
            this.rbtnsquare = new System.Windows.Forms.RadioButton();
            this.rbtnRectangle = new System.Windows.Forms.RadioButton();
            this.gboxShapes = new System.Windows.Forms.GroupBox();
            this.gboxColors.SuspendLayout();
            this.gboxShapes.SuspendLayout();
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
            this.lblAge.Location = new System.Drawing.Point(29, 227);
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
            this.btnSample.Location = new System.Drawing.Point(369, 452);
            this.btnSample.Name = "btnSample";
            this.btnSample.Size = new System.Drawing.Size(219, 124);
            this.btnSample.TabIndex = 4;
            this.btnSample.Text = "Click on me!";
            this.btnSample.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSample.UseVisualStyleBackColor = true;
            this.btnSample.Click += new System.EventHandler(this.btnSample_Click);
            // 
            // cmboxGender
            // 
            this.cmboxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboxGender.FormattingEnabled = true;
            this.cmboxGender.Items.AddRange(new object[] {
            "man",
            "woman"});
            this.cmboxGender.Location = new System.Drawing.Point(96, 284);
            this.cmboxGender.Name = "cmboxGender";
            this.cmboxGender.Size = new System.Drawing.Size(121, 21);
            this.cmboxGender.TabIndex = 5;
            this.cmboxGender.SelectedIndexChanged += new System.EventHandler(this.cmboxGender_SelectedIndexChanged);
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
            // cmboxDate
            // 
            this.cmboxDate.FormattingEnabled = true;
            this.cmboxDate.Items.AddRange(new object[] {
            "Year",
            "Month",
            "Day"});
            this.cmboxDate.Location = new System.Drawing.Point(51, 123);
            this.cmboxDate.Name = "cmboxDate";
            this.cmboxDate.Size = new System.Drawing.Size(121, 21);
            this.cmboxDate.TabIndex = 7;
            this.cmboxDate.SelectedIndexChanged += new System.EventHandler(this.cmboxDate_SelectedIndexChanged);
            // 
            // comboBoxDynamic
            // 
            this.comboBoxDynamic.FormattingEnabled = true;
            this.comboBoxDynamic.Location = new System.Drawing.Point(225, 123);
            this.comboBoxDynamic.Name = "comboBoxDynamic";
            this.comboBoxDynamic.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDynamic.TabIndex = 8;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(96, 405);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox1.TabIndex = 9;
            // 
            // btnCheked
            // 
            this.btnCheked.Location = new System.Drawing.Point(97, 376);
            this.btnCheked.Name = "btnCheked";
            this.btnCheked.Size = new System.Drawing.Size(120, 23);
            this.btnCheked.TabIndex = 10;
            this.btnCheked.Text = "checkec/unchecked";
            this.btnCheked.UseVisualStyleBackColor = true;
            this.btnCheked.Click += new System.EventHandler(this.btnCheked_Click);
            // 
            // rbtnRed
            // 
            this.rbtnRed.AutoSize = true;
            this.rbtnRed.Checked = true;
            this.rbtnRed.Location = new System.Drawing.Point(46, 31);
            this.rbtnRed.Name = "rbtnRed";
            this.rbtnRed.Size = new System.Drawing.Size(45, 17);
            this.rbtnRed.TabIndex = 11;
            this.rbtnRed.TabStop = true;
            this.rbtnRed.Text = "Red";
            this.rbtnRed.UseVisualStyleBackColor = true;
            // 
            // rbtnBlue
            // 
            this.rbtnBlue.AutoSize = true;
            this.rbtnBlue.Location = new System.Drawing.Point(46, 73);
            this.rbtnBlue.Name = "rbtnBlue";
            this.rbtnBlue.Size = new System.Drawing.Size(45, 17);
            this.rbtnBlue.TabIndex = 12;
            this.rbtnBlue.Text = "blue";
            this.rbtnBlue.UseVisualStyleBackColor = true;
            // 
            // rbtnGreen
            // 
            this.rbtnGreen.AutoSize = true;
            this.rbtnGreen.Location = new System.Drawing.Point(46, 120);
            this.rbtnGreen.Name = "rbtnGreen";
            this.rbtnGreen.Size = new System.Drawing.Size(54, 17);
            this.rbtnGreen.TabIndex = 13;
            this.rbtnGreen.Text = "Green";
            this.rbtnGreen.UseVisualStyleBackColor = true;
            // 
            // gboxColors
            // 
            this.gboxColors.Controls.Add(this.rbtnRed);
            this.gboxColors.Controls.Add(this.rbtnGreen);
            this.gboxColors.Controls.Add(this.rbtnBlue);
            this.gboxColors.ForeColor = System.Drawing.Color.Tomato;
            this.gboxColors.Location = new System.Drawing.Point(799, 125);
            this.gboxColors.Name = "gboxColors";
            this.gboxColors.Size = new System.Drawing.Size(284, 205);
            this.gboxColors.TabIndex = 14;
            this.gboxColors.TabStop = false;
            this.gboxColors.Text = "Colors";
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(704, 356);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(152, 43);
            this.btnColor.TabIndex = 14;
            this.btnColor.Text = "Choose a color";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // rbtnsquare
            // 
            this.rbtnsquare.AutoSize = true;
            this.rbtnsquare.Checked = true;
            this.rbtnsquare.Location = new System.Drawing.Point(46, 44);
            this.rbtnsquare.Name = "rbtnsquare";
            this.rbtnsquare.Size = new System.Drawing.Size(59, 17);
            this.rbtnsquare.TabIndex = 15;
            this.rbtnsquare.TabStop = true;
            this.rbtnsquare.Text = "Square";
            this.rbtnsquare.UseVisualStyleBackColor = true;
            // 
            // rbtnRectangle
            // 
            this.rbtnRectangle.AutoSize = true;
            this.rbtnRectangle.Location = new System.Drawing.Point(46, 86);
            this.rbtnRectangle.Name = "rbtnRectangle";
            this.rbtnRectangle.Size = new System.Drawing.Size(74, 17);
            this.rbtnRectangle.TabIndex = 16;
            this.rbtnRectangle.Text = "Rectangle";
            this.rbtnRectangle.UseVisualStyleBackColor = true;
            // 
            // gboxShapes
            // 
            this.gboxShapes.Controls.Add(this.rbtnsquare);
            this.gboxShapes.Controls.Add(this.rbtnRectangle);
            this.gboxShapes.ForeColor = System.Drawing.Color.RoyalBlue;
            this.gboxShapes.Location = new System.Drawing.Point(479, 125);
            this.gboxShapes.Name = "gboxShapes";
            this.gboxShapes.Size = new System.Drawing.Size(284, 205);
            this.gboxShapes.TabIndex = 17;
            this.gboxShapes.TabStop = false;
            this.gboxShapes.Text = "shapes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 604);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.gboxShapes);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.gboxColors);
            this.Controls.Add(this.btnCheked);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.comboBoxDynamic);
            this.Controls.Add(this.cmboxDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmboxGender);
            this.Controls.Add(this.btnSample);
            this.Controls.Add(this.txtboxAge);
            this.Controls.Add(this.txtboxSample);
            this.Controls.Add(this.lblWelcome);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.gboxColors.ResumeLayout(false);
            this.gboxColors.PerformLayout();
            this.gboxShapes.ResumeLayout(false);
            this.gboxShapes.PerformLayout();
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
        private System.Windows.Forms.ComboBox cmboxDate;
        private System.Windows.Forms.ComboBox comboBoxDynamic;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button btnCheked;
        private System.Windows.Forms.RadioButton rbtnRed;
        private System.Windows.Forms.RadioButton rbtnBlue;
        private System.Windows.Forms.RadioButton rbtnGreen;
        private System.Windows.Forms.GroupBox gboxColors;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.RadioButton rbtnsquare;
        private System.Windows.Forms.RadioButton rbtnRectangle;
        private System.Windows.Forms.GroupBox gboxShapes;
    }
}

