namespace OdevTeslim.Formlar
{
    partial class MetroFrameWorkDemoForm
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
            this.metroBtnDemo = new MetroFramework.Controls.MetroButton();
            this.metroLbl = new MetroFramework.Controls.MetroLabel();
            this.metroCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.metroRadiobtn1 = new MetroFramework.Controls.MetroRadioButton();
            this.metroToggle = new MetroFramework.Controls.MetroToggle();
            this.htmlLabel = new MetroFramework.Drawing.Html.HtmlLabel();
            this.metroRadiobtn2 = new MetroFramework.Controls.MetroRadioButton();
            this.SuspendLayout();
            // 
            // metroBtnDemo
            // 
            this.metroBtnDemo.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroBtnDemo.Location = new System.Drawing.Point(570, 29);
            this.metroBtnDemo.Name = "metroBtnDemo";
            this.metroBtnDemo.Size = new System.Drawing.Size(207, 86);
            this.metroBtnDemo.TabIndex = 1;
            this.metroBtnDemo.Text = "Test Et";
            this.metroBtnDemo.UseSelectable = true;
            this.metroBtnDemo.Click += new System.EventHandler(this.metroBtnDemo_Click);
            // 
            // metroLbl
            // 
            this.metroLbl.AutoSize = true;
            this.metroLbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLbl.Location = new System.Drawing.Point(216, 76);
            this.metroLbl.Name = "metroLbl";
            this.metroLbl.Size = new System.Drawing.Size(143, 25);
            this.metroLbl.TabIndex = 2;
            this.metroLbl.Text = "Bu bir metrolabel";
            // 
            // metroCheckBox
            // 
            this.metroCheckBox.AutoSize = true;
            this.metroCheckBox.Location = new System.Drawing.Point(23, 80);
            this.metroCheckBox.Name = "metroCheckBox";
            this.metroCheckBox.Size = new System.Drawing.Size(113, 15);
            this.metroCheckBox.TabIndex = 3;
            this.metroCheckBox.Text = "metroCheckBox1";
            this.metroCheckBox.UseSelectable = true;
            // 
            // metroRadiobtn1
            // 
            this.metroRadiobtn1.AutoSize = true;
            this.metroRadiobtn1.Location = new System.Drawing.Point(23, 116);
            this.metroRadiobtn1.Name = "metroRadiobtn1";
            this.metroRadiobtn1.Size = new System.Drawing.Size(127, 15);
            this.metroRadiobtn1.TabIndex = 4;
            this.metroRadiobtn1.Text = "metroRadioButton1";
            this.metroRadiobtn1.UseSelectable = true;
            // 
            // metroToggle
            // 
            this.metroToggle.AutoSize = true;
            this.metroToggle.Location = new System.Drawing.Point(216, 116);
            this.metroToggle.Name = "metroToggle";
            this.metroToggle.Size = new System.Drawing.Size(80, 17);
            this.metroToggle.TabIndex = 5;
            this.metroToggle.Text = "Off";
            this.metroToggle.UseSelectable = true;
            // 
            // htmlLabel
            // 
            this.htmlLabel.AutoScroll = true;
            this.htmlLabel.AutoScrollMinSize = new System.Drawing.Size(10, 10);
            this.htmlLabel.AutoSize = false;
            this.htmlLabel.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel.Location = new System.Drawing.Point(23, 201);
            this.htmlLabel.Name = "htmlLabel";
            this.htmlLabel.Size = new System.Drawing.Size(754, 239);
            this.htmlLabel.TabIndex = 6;
            // 
            // metroRadiobtn2
            // 
            this.metroRadiobtn2.AutoSize = true;
            this.metroRadiobtn2.Location = new System.Drawing.Point(23, 151);
            this.metroRadiobtn2.Name = "metroRadiobtn2";
            this.metroRadiobtn2.Size = new System.Drawing.Size(127, 15);
            this.metroRadiobtn2.TabIndex = 7;
            this.metroRadiobtn2.Text = "metroRadioButton2";
            this.metroRadiobtn2.UseSelectable = true;
            // 
            // MetroFrameWorkDemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackLocation = MetroFramework.Forms.BackLocation.TopLeft;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroRadiobtn2);
            this.Controls.Add(this.metroLbl);
            this.Controls.Add(this.htmlLabel);
            this.Controls.Add(this.metroToggle);
            this.Controls.Add(this.metroRadiobtn1);
            this.Controls.Add(this.metroCheckBox);
            this.Controls.Add(this.metroBtnDemo);
            this.Name = "MetroFrameWorkDemoForm";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.Flat;
            this.Text = "Metro Frame Work Demo Formu";
            this.Load += new System.EventHandler(this.MetroFrameWorkDemoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroBtnDemo;
        private MetroFramework.Controls.MetroLabel metroLbl;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox;
        private MetroFramework.Controls.MetroRadioButton metroRadiobtn1;
        private MetroFramework.Controls.MetroToggle metroToggle;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel;
        private MetroFramework.Controls.MetroRadioButton metroRadiobtn2;
    }
}