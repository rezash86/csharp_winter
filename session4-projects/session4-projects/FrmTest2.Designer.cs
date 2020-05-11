namespace session4_projects
{
    partial class FrmTest2
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
            this.lstboxSample = new System.Windows.Forms.ListBox();
            this.btnFillValues = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstboxSample
            // 
            this.lstboxSample.Dock = System.Windows.Forms.DockStyle.Top;
            this.lstboxSample.FormattingEnabled = true;
            this.lstboxSample.Items.AddRange(new object[] {
            "Apple",
            "Banana",
            "Orange"});
            this.lstboxSample.Location = new System.Drawing.Point(0, 0);
            this.lstboxSample.Name = "lstboxSample";
            this.lstboxSample.Size = new System.Drawing.Size(418, 95);
            this.lstboxSample.TabIndex = 0;
            // 
            // btnFillValues
            // 
            this.btnFillValues.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFillValues.Location = new System.Drawing.Point(0, 95);
            this.btnFillValues.Name = "btnFillValues";
            this.btnFillValues.Size = new System.Drawing.Size(418, 23);
            this.btnFillValues.TabIndex = 1;
            this.btnFillValues.Text = "fill data";
            this.btnFillValues.UseVisualStyleBackColor = true;
            this.btnFillValues.Click += new System.EventHandler(this.btnFillValues_Click);
            // 
            // FrmTest2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 293);
            this.Controls.Add(this.btnFillValues);
            this.Controls.Add(this.lstboxSample);
            this.Name = "FrmTest2";
            this.Text = "FrmTest2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstboxSample;
        private System.Windows.Forms.Button btnFillValues;
    }
}