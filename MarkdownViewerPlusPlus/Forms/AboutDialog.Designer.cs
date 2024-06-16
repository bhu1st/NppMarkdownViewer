namespace com.insanitydesign.MarkdownViewerPlusPlus.Forms
{
    partial class AboutDialog
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnVisit = new System.Windows.Forms.Button();
            this.lblAbout = new System.Windows.Forms.Label();
            this.picBoxDonate = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDonate)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(325, 313);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(83, 28);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnVisit
            // 
            this.btnVisit.Location = new System.Drawing.Point(13, 313);
            this.btnVisit.Margin = new System.Windows.Forms.Padding(4);
            this.btnVisit.Name = "btnVisit";
            this.btnVisit.Size = new System.Drawing.Size(104, 28);
            this.btnVisit.TabIndex = 1;
            this.btnVisit.Text = "Visit Website";
            this.btnVisit.UseVisualStyleBackColor = true;
            this.btnVisit.Click += new System.EventHandler(this.btnVisit_Click);
            // 
            // lblAbout
            // 
            this.lblAbout.Location = new System.Drawing.Point(17, 16);
            this.lblAbout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(345, 293);
            this.lblAbout.TabIndex = 2;
            this.lblAbout.Click += new System.EventHandler(this.lblAbout_Click);
            // 
            // picBoxDonate
            // 
            this.picBoxDonate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picBoxDonate.Image = global::com.insanitydesign.MarkdownViewerPlusPlus.Properties.Resources.bmc;
            this.picBoxDonate.InitialImage = null;
            this.picBoxDonate.Location = new System.Drawing.Point(137, 304);
            this.picBoxDonate.Margin = new System.Windows.Forms.Padding(4);
            this.picBoxDonate.Name = "picBoxDonate";
            this.picBoxDonate.Size = new System.Drawing.Size(160, 42);
            this.picBoxDonate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBoxDonate.TabIndex = 3;
            this.picBoxDonate.TabStop = false;
            this.picBoxDonate.Click += new System.EventHandler(this.picBoxDonate_Click);
            // 
            // AboutDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 356);
            this.Controls.Add(this.picBoxDonate);
            this.Controls.Add(this.lblAbout);
            this.Controls.Add(this.btnVisit);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About MarkdownViewer++";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDonate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnVisit;
        private System.Windows.Forms.Label lblAbout;
        private System.Windows.Forms.PictureBox picBoxDonate;
    }
}