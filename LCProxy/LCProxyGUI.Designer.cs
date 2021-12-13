namespace LCProxy
{
    partial class LCProxyGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LCProxyGUI));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.homeTabBtn = new System.Windows.Forms.Button();
            this.troubleshootTabBtn = new System.Windows.Forms.Button();
            this.installerTabBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.installNowBtn = new System.Windows.Forms.Button();
            this.havingIssuesBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.exitApplicationBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.installerPanel = new LCProxy.LCProxyInstallerGUI();
            this.troubleShootPanel = new LCProxy.LCProxyTroubleshooter();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.homeTabBtn);
            this.panel1.Controls.Add(this.troubleshootTabBtn);
            this.panel1.Controls.Add(this.installerTabBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-12, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(152, 365);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(106, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "V1.0.2";
            // 
            // homeTabBtn
            // 
            this.homeTabBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.homeTabBtn.FlatAppearance.BorderSize = 0;
            this.homeTabBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.homeTabBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.homeTabBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeTabBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeTabBtn.ForeColor = System.Drawing.Color.White;
            this.homeTabBtn.Location = new System.Drawing.Point(12, 59);
            this.homeTabBtn.Name = "homeTabBtn";
            this.homeTabBtn.Size = new System.Drawing.Size(140, 25);
            this.homeTabBtn.TabIndex = 4;
            this.homeTabBtn.Text = "Home";
            this.homeTabBtn.UseVisualStyleBackColor = false;
            this.homeTabBtn.Click += new System.EventHandler(this.homeTabBtn_Click);
            // 
            // troubleshootTabBtn
            // 
            this.troubleshootTabBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.troubleshootTabBtn.FlatAppearance.BorderSize = 0;
            this.troubleshootTabBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.troubleshootTabBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.troubleshootTabBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.troubleshootTabBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.troubleshootTabBtn.ForeColor = System.Drawing.Color.Gray;
            this.troubleshootTabBtn.Location = new System.Drawing.Point(12, 125);
            this.troubleshootTabBtn.Name = "troubleshootTabBtn";
            this.troubleshootTabBtn.Size = new System.Drawing.Size(140, 25);
            this.troubleshootTabBtn.TabIndex = 3;
            this.troubleshootTabBtn.Text = "Troubleshoot";
            this.troubleshootTabBtn.UseVisualStyleBackColor = false;
            this.troubleshootTabBtn.Click += new System.EventHandler(this.troubleshootTabBtn_Click);
            // 
            // installerTabBtn
            // 
            this.installerTabBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.installerTabBtn.FlatAppearance.BorderSize = 0;
            this.installerTabBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.installerTabBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.installerTabBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.installerTabBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.installerTabBtn.ForeColor = System.Drawing.Color.Gray;
            this.installerTabBtn.Location = new System.Drawing.Point(12, 91);
            this.installerTabBtn.Name = "installerTabBtn";
            this.installerTabBtn.Size = new System.Drawing.Size(140, 25);
            this.installerTabBtn.TabIndex = 2;
            this.installerTabBtn.Text = "Installer";
            this.installerTabBtn.UseVisualStyleBackColor = false;
            this.installerTabBtn.Click += new System.EventHandler(this.installerTabBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "LCProxy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(154, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Welcome to LCProxy!";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(157, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(351, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "The only proxy you\'ll ever need for your favourite Minecraft client.";
            // 
            // installNowBtn
            // 
            this.installNowBtn.BackColor = System.Drawing.Color.Crimson;
            this.installNowBtn.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.installNowBtn.FlatAppearance.BorderSize = 0;
            this.installNowBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Crimson;
            this.installNowBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.installNowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.installNowBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.installNowBtn.ForeColor = System.Drawing.Color.White;
            this.installNowBtn.Location = new System.Drawing.Point(160, 86);
            this.installNowBtn.Name = "installNowBtn";
            this.installNowBtn.Size = new System.Drawing.Size(99, 25);
            this.installNowBtn.TabIndex = 8;
            this.installNowBtn.Text = "Install now!";
            this.installNowBtn.UseVisualStyleBackColor = false;
            this.installNowBtn.Click += new System.EventHandler(this.installNowBtn_Click);
            // 
            // havingIssuesBtn
            // 
            this.havingIssuesBtn.BackColor = System.Drawing.Color.Crimson;
            this.havingIssuesBtn.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.havingIssuesBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Crimson;
            this.havingIssuesBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.havingIssuesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.havingIssuesBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.havingIssuesBtn.ForeColor = System.Drawing.Color.White;
            this.havingIssuesBtn.Location = new System.Drawing.Point(265, 86);
            this.havingIssuesBtn.Name = "havingIssuesBtn";
            this.havingIssuesBtn.Size = new System.Drawing.Size(99, 25);
            this.havingIssuesBtn.TabIndex = 9;
            this.havingIssuesBtn.Text = "Having issues?";
            this.havingIssuesBtn.UseVisualStyleBackColor = false;
            this.havingIssuesBtn.Click += new System.EventHandler(this.havingIssuesBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(157, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(359, 45);
            this.label5.TabIndex = 10;
            this.label5.Text = "LCProxy is a proxy for Lunar, allowing you to unlock additional \r\nfeatures unavai" +
    "lable normally, like cosmetics. LCProxy is completely \r\nfree of charge but donta" +
    "tions are greatly appreciated.\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(154, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 32);
            this.label6.TabIndex = 11;
            this.label6.Text = "What is LCProxy?";
            // 
            // exitApplicationBtn
            // 
            this.exitApplicationBtn.FlatAppearance.BorderSize = 0;
            this.exitApplicationBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.exitApplicationBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.exitApplicationBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitApplicationBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitApplicationBtn.ForeColor = System.Drawing.Color.Gray;
            this.exitApplicationBtn.Location = new System.Drawing.Point(534, 3);
            this.exitApplicationBtn.Name = "exitApplicationBtn";
            this.exitApplicationBtn.Size = new System.Drawing.Size(21, 20);
            this.exitApplicationBtn.TabIndex = 6;
            this.exitApplicationBtn.Text = "X";
            this.exitApplicationBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.exitApplicationBtn.UseVisualStyleBackColor = false;
            this.exitApplicationBtn.Click += new System.EventHandler(this.exitApplicationBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Crimson;
            this.panel2.Location = new System.Drawing.Point(-31, -84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(609, 87);
            this.panel2.TabIndex = 12;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // installerPanel
            // 
            this.installerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.installerPanel.Location = new System.Drawing.Point(140, 5);
            this.installerPanel.Name = "installerPanel";
            this.installerPanel.Size = new System.Drawing.Size(393, 260);
            this.installerPanel.TabIndex = 13;
            this.installerPanel.Load += new System.EventHandler(this.installerPanel_Load);
            // 
            // troubleShootPanel
            // 
            this.troubleShootPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.troubleShootPanel.Location = new System.Drawing.Point(140, 4);
            this.troubleShootPanel.Name = "troubleShootPanel";
            this.troubleShootPanel.Size = new System.Drawing.Size(393, 260);
            this.troubleShootPanel.TabIndex = 14;
            // 
            // LCProxyGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(555, 259);
            this.Controls.Add(this.installerPanel);
            this.Controls.Add(this.troubleShootPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.exitApplicationBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.havingIssuesBtn);
            this.Controls.Add(this.installNowBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LCProxyGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LCProxyGUI_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button homeTabBtn;
        private System.Windows.Forms.Button troubleshootTabBtn;
        private System.Windows.Forms.Button installerTabBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button installNowBtn;
        private System.Windows.Forms.Button havingIssuesBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button exitApplicationBtn;
        private System.Windows.Forms.Panel panel2;
        private LCProxyInstallerGUI installerPanel;
        private LCProxyTroubleshooter troubleShootPanel;
    }
}

