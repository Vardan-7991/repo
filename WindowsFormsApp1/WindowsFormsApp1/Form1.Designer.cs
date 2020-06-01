namespace WindowsFormsApp1
{
    partial class HomePage
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
            this.admin_btn = new System.Windows.Forms.Button();
            this.vacharox_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // admin_btn
            // 
            this.admin_btn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.admin_btn.BackColor = System.Drawing.Color.DarkGreen;
            this.admin_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.admin_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.admin_btn.Location = new System.Drawing.Point(150, 333);
            this.admin_btn.Name = "admin_btn";
            this.admin_btn.Size = new System.Drawing.Size(151, 34);
            this.admin_btn.TabIndex = 0;
            this.admin_btn.Text = "Ադմին";
            this.admin_btn.UseVisualStyleBackColor = false;
            this.admin_btn.Click += new System.EventHandler(this.admin_btn_Click);
            // 
            // vacharox_btn
            // 
            this.vacharox_btn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.vacharox_btn.BackColor = System.Drawing.Color.DarkGreen;
            this.vacharox_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vacharox_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vacharox_btn.Location = new System.Drawing.Point(499, 333);
            this.vacharox_btn.Name = "vacharox_btn";
            this.vacharox_btn.Size = new System.Drawing.Size(151, 34);
            this.vacharox_btn.TabIndex = 1;
            this.vacharox_btn.Text = "Վաճառող";
            this.vacharox_btn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(694, 55);
            this.label1.TabIndex = 2;
            this.label1.Text = "Բարի Գալուստ Մեր Խանութ";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.photo_1532982116380_02ce47a3e03c;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vacharox_btn);
            this.Controls.Add(this.admin_btn);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button admin_btn;
        private System.Windows.Forms.Button vacharox_btn;
        private System.Windows.Forms.Label label1;
    }
}

