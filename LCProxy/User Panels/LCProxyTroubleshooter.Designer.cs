namespace LCProxy
{
    partial class LCProxyTroubleshooter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.troubleshootBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.statusTxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(18, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(353, 45);
            this.label4.TabIndex = 15;
            this.label4.Text = "If you\'re having any issues  you can simply run this troubleshooter\r\nbefore openi" +
    "ng a ticket on our Discord server. This will save ours \r\nand yours time.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(15, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(258, 32);
            this.label3.TabIndex = 14;
            this.label3.Text = "LCProxy Troubleshooter";
            // 
            // troubleshootBtn
            // 
            this.troubleshootBtn.BackColor = System.Drawing.Color.Crimson;
            this.troubleshootBtn.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.troubleshootBtn.FlatAppearance.BorderSize = 0;
            this.troubleshootBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Crimson;
            this.troubleshootBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.troubleshootBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.troubleshootBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.troubleshootBtn.ForeColor = System.Drawing.Color.White;
            this.troubleshootBtn.Location = new System.Drawing.Point(21, 114);
            this.troubleshootBtn.Name = "troubleshootBtn";
            this.troubleshootBtn.Size = new System.Drawing.Size(126, 25);
            this.troubleshootBtn.TabIndex = 16;
            this.troubleshootBtn.Text = "Run troubleshooter";
            this.troubleshootBtn.UseVisualStyleBackColor = false;
            this.troubleshootBtn.Click += new System.EventHandler(this.troubleshootBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Status:";
            // 
            // statusTxt
            // 
            this.statusTxt.AutoSize = true;
            this.statusTxt.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusTxt.ForeColor = System.Drawing.Color.Gray;
            this.statusTxt.Location = new System.Drawing.Point(60, 151);
            this.statusTxt.Name = "statusTxt";
            this.statusTxt.Size = new System.Drawing.Size(142, 15);
            this.statusTxt.TabIndex = 18;
            this.statusTxt.Text = "Waiting to troubleshoot...";
            // 
            // LCProxyTroubleshooter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Controls.Add(this.statusTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.troubleshootBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "LCProxyTroubleshooter";
            this.Size = new System.Drawing.Size(393, 260);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button troubleshootBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label statusTxt;
    }
}
