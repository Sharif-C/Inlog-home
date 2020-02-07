namespace WFA_Inlog
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Row1 = new System.Windows.Forms.Panel();
            this.innerRow = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.subText = new System.Windows.Forms.Label();
            this.headText = new System.Windows.Forms.Label();
            this.Row2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.usernameField = new System.Windows.Forms.TextBox();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.Row1.SuspendLayout();
            this.innerRow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Row2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Row1
            // 
            this.Row1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Row1.BackColor = System.Drawing.Color.White;
            this.Row1.Controls.Add(this.innerRow);
            this.Row1.Location = new System.Drawing.Point(0, 1);
            this.Row1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.Row1.Name = "Row1";
            this.Row1.Size = new System.Drawing.Size(611, 295);
            this.Row1.TabIndex = 0;
            // 
            // innerRow
            // 
            this.innerRow.BackColor = System.Drawing.Color.Transparent;
            this.innerRow.Controls.Add(this.pictureBox1);
            this.innerRow.Controls.Add(this.subText);
            this.innerRow.Controls.Add(this.headText);
            this.innerRow.Location = new System.Drawing.Point(80, 71);
            this.innerRow.Margin = new System.Windows.Forms.Padding(100, 3, 100, 3);
            this.innerRow.Name = "innerRow";
            this.innerRow.Size = new System.Drawing.Size(421, 128);
            this.innerRow.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // subText
            // 
            this.subText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.subText.AutoSize = true;
            this.subText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subText.Location = new System.Drawing.Point(110, 81);
            this.subText.Name = "subText";
            this.subText.Size = new System.Drawing.Size(151, 25);
            this.subText.TabIndex = 2;
            this.subText.Text = "Development UI";
            this.subText.Click += new System.EventHandler(this.subText_Click);
            // 
            // headText
            // 
            this.headText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headText.AutoSize = true;
            this.headText.Font = new System.Drawing.Font("Impact", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headText.Location = new System.Drawing.Point(107, 26);
            this.headText.Name = "headText";
            this.headText.Size = new System.Drawing.Size(255, 46);
            this.headText.TabIndex = 1;
            this.headText.Text = "Share logistics";
            this.headText.Click += new System.EventHandler(this.label1_Click);
            // 
            // Row2
            // 
            this.Row2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Row2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Row2.BackColor = System.Drawing.Color.Silver;
            this.Row2.Controls.Add(this.passwordField);
            this.Row2.Controls.Add(this.button1);
            this.Row2.Controls.Add(this.usernameField);
            this.Row2.Location = new System.Drawing.Point(0, 297);
            this.Row2.Name = "Row2";
            this.Row2.Size = new System.Drawing.Size(611, 308);
            this.Row2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Arial", 12F);
            this.button1.ForeColor = System.Drawing.Color.LightSlateGray;
            this.button1.Location = new System.Drawing.Point(189, 175);
            this.button1.Margin = new System.Windows.Forms.Padding(180, 3, 180, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // usernameField
            // 
            this.usernameField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usernameField.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameField.ForeColor = System.Drawing.Color.LightSlateGray;
            this.usernameField.Location = new System.Drawing.Point(80, 40);
            this.usernameField.Margin = new System.Windows.Forms.Padding(80, 40, 80, 3);
            this.usernameField.Name = "usernameField";
            this.usernameField.Size = new System.Drawing.Size(441, 29);
            this.usernameField.TabIndex = 0;
            this.usernameField.TabStop = false;
            this.usernameField.Tag = "";
            this.usernameField.Text = "Username";
            this.usernameField.TextChanged += new System.EventHandler(this.usernameField_TextChanged);
            this.usernameField.Enter += new System.EventHandler(this.usernameField_Enter);
            this.usernameField.Leave += new System.EventHandler(this.usernameField_Leave);
            // 
            // passwordField
            // 
            this.passwordField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordField.Font = new System.Drawing.Font("Arial", 14F);
            this.passwordField.ForeColor = System.Drawing.Color.LightSlateGray;
            this.passwordField.Location = new System.Drawing.Point(80, 112);
            this.passwordField.Margin = new System.Windows.Forms.Padding(80, 40, 80, 3);
            this.passwordField.Name = "passwordField";
            this.passwordField.Size = new System.Drawing.Size(441, 29);
            this.passwordField.TabIndex = 3;
            this.passwordField.TabStop = false;
            this.passwordField.Tag = "";
            this.passwordField.Text = "Password";
            this.passwordField.Enter += new System.EventHandler(this.passwordField_Enter);
            this.passwordField.Leave += new System.EventHandler(this.passwordField_Leave);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(610, 601);
            this.Controls.Add(this.Row2);
            this.Controls.Add(this.Row1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(630, 644);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(630, 644);
            this.Name = "Login";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Row1.ResumeLayout(false);
            this.innerRow.ResumeLayout(false);
            this.innerRow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Row2.ResumeLayout(false);
            this.Row2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Row1;
        private System.Windows.Forms.Panel Row2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label headText;
        private System.Windows.Forms.Label subText;
        private System.Windows.Forms.TextBox usernameField;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel innerRow;
        private System.Windows.Forms.TextBox passwordField;
    }
}

