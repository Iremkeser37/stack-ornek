namespace stack_ornek
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
            this.btnGetir1 = new System.Windows.Forms.Button();
            this.btnGetir2 = new System.Windows.Forms.Button();
            this.btnGetir3 = new System.Windows.Forms.Button();
            this.lblSıra1 = new System.Windows.Forms.Label();
            this.lblSıra2 = new System.Windows.Forms.Label();
            this.lblSıra3 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.btnSatinAl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGetir1
            // 
            this.btnGetir1.Location = new System.Drawing.Point(67, 45);
            this.btnGetir1.Name = "btnGetir1";
            this.btnGetir1.Size = new System.Drawing.Size(98, 73);
            this.btnGetir1.TabIndex = 0;
            this.btnGetir1.Text = "getir1";
            this.btnGetir1.UseVisualStyleBackColor = true;
            this.btnGetir1.Click += new System.EventHandler(this.btnGetir1_Click);
            // 
            // btnGetir2
            // 
            this.btnGetir2.Location = new System.Drawing.Point(211, 45);
            this.btnGetir2.Name = "btnGetir2";
            this.btnGetir2.Size = new System.Drawing.Size(98, 70);
            this.btnGetir2.TabIndex = 1;
            this.btnGetir2.Text = "getir2";
            this.btnGetir2.UseVisualStyleBackColor = true;
            this.btnGetir2.Click += new System.EventHandler(this.btnGetir2_Click);
            // 
            // btnGetir3
            // 
            this.btnGetir3.Location = new System.Drawing.Point(354, 45);
            this.btnGetir3.Name = "btnGetir3";
            this.btnGetir3.Size = new System.Drawing.Size(98, 69);
            this.btnGetir3.TabIndex = 2;
            this.btnGetir3.Text = "getir3";
            this.btnGetir3.UseVisualStyleBackColor = true;
            this.btnGetir3.Click += new System.EventHandler(this.btnGetir3_Click);
            // 
            // lblSıra1
            // 
            this.lblSıra1.AutoSize = true;
            this.lblSıra1.Location = new System.Drawing.Point(102, 160);
            this.lblSıra1.Name = "lblSıra1";
            this.lblSıra1.Size = new System.Drawing.Size(35, 13);
            this.lblSıra1.TabIndex = 3;
            this.lblSıra1.Text = "label1";
            // 
            // lblSıra2
            // 
            this.lblSıra2.AutoSize = true;
            this.lblSıra2.Location = new System.Drawing.Point(241, 160);
            this.lblSıra2.Name = "lblSıra2";
            this.lblSıra2.Size = new System.Drawing.Size(35, 13);
            this.lblSıra2.TabIndex = 4;
            this.lblSıra2.Text = "label2";
            // 
            // lblSıra3
            // 
            this.lblSıra3.AutoSize = true;
            this.lblSıra3.Location = new System.Drawing.Point(389, 160);
            this.lblSıra3.Name = "lblSıra3";
            this.lblSıra3.Size = new System.Drawing.Size(35, 13);
            this.lblSıra3.TabIndex = 5;
            this.lblSıra3.Text = "label3";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(86, 219);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(153, 20);
            this.txtAd.TabIndex = 6;
            // 
            // btnSatinAl
            // 
            this.btnSatinAl.Location = new System.Drawing.Point(86, 283);
            this.btnSatinAl.Name = "btnSatinAl";
            this.btnSatinAl.Size = new System.Drawing.Size(120, 53);
            this.btnSatinAl.TabIndex = 7;
            this.btnSatinAl.Text = "satın al";
            this.btnSatinAl.UseVisualStyleBackColor = true;
            this.btnSatinAl.Click += new System.EventHandler(this.btnSatinAl_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 398);
            this.Controls.Add(this.btnSatinAl);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.lblSıra3);
            this.Controls.Add(this.lblSıra2);
            this.Controls.Add(this.lblSıra1);
            this.Controls.Add(this.btnGetir3);
            this.Controls.Add(this.btnGetir2);
            this.Controls.Add(this.btnGetir1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetir1;
        private System.Windows.Forms.Button btnGetir2;
        private System.Windows.Forms.Button btnGetir3;
        private System.Windows.Forms.Label lblSıra1;
        private System.Windows.Forms.Label lblSıra2;
        private System.Windows.Forms.Label lblSıra3;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Button btnSatinAl;
    }
}

