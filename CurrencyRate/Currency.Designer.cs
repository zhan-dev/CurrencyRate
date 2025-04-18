namespace CurrencyRate
{
    partial class main
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
            this.get_btn = new System.Windows.Forms.Button();
            this.USD_lbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.HKD_lbl = new System.Windows.Forms.Label();
            this.CAD_lbl = new System.Windows.Forms.Label();
            this.CZK_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // get_btn
            // 
            this.get_btn.Location = new System.Drawing.Point(13, 97);
            this.get_btn.Margin = new System.Windows.Forms.Padding(4);
            this.get_btn.Name = "get_btn";
            this.get_btn.Size = new System.Drawing.Size(110, 32);
            this.get_btn.TabIndex = 1;
            this.get_btn.Text = "курс";
            this.get_btn.UseVisualStyleBackColor = true;
            this.get_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // USD_lbl
            // 
            this.USD_lbl.AutoSize = true;
            this.USD_lbl.Location = new System.Drawing.Point(13, 9);
            this.USD_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.USD_lbl.Name = "USD_lbl";
            this.USD_lbl.Size = new System.Drawing.Size(41, 21);
            this.USD_lbl.TabIndex = 3;
            this.USD_lbl.Text = "USD";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(178, 6);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(498, 345);
            this.textBox1.TabIndex = 2;
            // 
            // HKD_lbl
            // 
            this.HKD_lbl.AutoSize = true;
            this.HKD_lbl.Location = new System.Drawing.Point(13, 30);
            this.HKD_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HKD_lbl.Name = "HKD_lbl";
            this.HKD_lbl.Size = new System.Drawing.Size(42, 21);
            this.HKD_lbl.TabIndex = 3;
            this.HKD_lbl.Text = "HKD";
            // 
            // CAD_lbl
            // 
            this.CAD_lbl.AutoSize = true;
            this.CAD_lbl.Location = new System.Drawing.Point(13, 51);
            this.CAD_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CAD_lbl.Name = "CAD_lbl";
            this.CAD_lbl.Size = new System.Drawing.Size(48, 21);
            this.CAD_lbl.TabIndex = 3;
            this.CAD_lbl.Text = "CAD";
            // 
            // CZK_lbl
            // 
            this.CZK_lbl.AutoSize = true;
            this.CZK_lbl.Location = new System.Drawing.Point(13, 72);
            this.CZK_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CZK_lbl.Name = "CZK_lbl";
            this.CZK_lbl.Size = new System.Drawing.Size(40, 21);
            this.CZK_lbl.TabIndex = 3;
            this.CZK_lbl.Text = "CZK";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 361);
            this.Controls.Add(this.CZK_lbl);
            this.Controls.Add(this.CAD_lbl);
            this.Controls.Add(this.HKD_lbl);
            this.Controls.Add(this.USD_lbl);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.get_btn);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximumSize = new System.Drawing.Size(704, 400);
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Курс UAN согласно НБУ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button get_btn;
        private System.Windows.Forms.Label USD_lbl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label HKD_lbl;
        private System.Windows.Forms.Label CAD_lbl;
        private System.Windows.Forms.Label CZK_lbl;
    }
}

