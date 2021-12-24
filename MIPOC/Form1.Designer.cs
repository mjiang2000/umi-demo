
namespace MIPOC
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGetToken = new System.Windows.Forms.Button();
            this.txtToken = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnCallApi = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnCallApiWithoutToken = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGetToken
            // 
            this.btnGetToken.Location = new System.Drawing.Point(12, 27);
            this.btnGetToken.Name = "btnGetToken";
            this.btnGetToken.Size = new System.Drawing.Size(216, 63);
            this.btnGetToken.TabIndex = 0;
            this.btnGetToken.Text = "1. Get Token";
            this.btnGetToken.UseVisualStyleBackColor = true;
            this.btnGetToken.Click += new System.EventHandler(this.btnGetToken_Click);
            // 
            // txtToken
            // 
            this.txtToken.Location = new System.Drawing.Point(243, 27);
            this.txtToken.Multiline = true;
            this.txtToken.Name = "txtToken";
            this.txtToken.Size = new System.Drawing.Size(529, 175);
            this.txtToken.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(243, 217);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(529, 175);
            this.textBox1.TabIndex = 3;
            // 
            // btnCallApi
            // 
            this.btnCallApi.Location = new System.Drawing.Point(12, 217);
            this.btnCallApi.Name = "btnCallApi";
            this.btnCallApi.Size = new System.Drawing.Size(216, 63);
            this.btnCallApi.TabIndex = 2;
            this.btnCallApi.Text = "2. Call app service with Token";
            this.btnCallApi.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(243, 398);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(529, 175);
            this.textBox2.TabIndex = 5;
            // 
            // btnCallApiWithoutToken
            // 
            this.btnCallApiWithoutToken.Location = new System.Drawing.Point(12, 398);
            this.btnCallApiWithoutToken.Name = "btnCallApiWithoutToken";
            this.btnCallApiWithoutToken.Size = new System.Drawing.Size(216, 63);
            this.btnCallApiWithoutToken.TabIndex = 4;
            this.btnCallApiWithoutToken.Text = "3. Call app service without token";
            this.btnCallApiWithoutToken.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 577);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnCallApiWithoutToken);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCallApi);
            this.Controls.Add(this.txtToken);
            this.Controls.Add(this.btnGetToken);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetToken;
        private System.Windows.Forms.TextBox txtToken;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnCallApi;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnCallApiWithoutToken;
    }
}

