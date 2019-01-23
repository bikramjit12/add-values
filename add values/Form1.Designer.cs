namespace add_values
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
            this.number4 = new System.Windows.Forms.TextBox();
            this.number3 = new System.Windows.Forms.TextBox();
            this.number2 = new System.Windows.Forms.TextBox();
            this.number1 = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.button = new System.Windows.Forms.Button();
            this.btnGo3 = new System.Windows.Forms.Button();
            this.lbxOutput = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // number4
            // 
            this.number4.Location = new System.Drawing.Point(458, 77);
            this.number4.Name = "number4";
            this.number4.Size = new System.Drawing.Size(100, 20);
            this.number4.TabIndex = 0;
            // 
            // number3
            // 
            this.number3.Location = new System.Drawing.Point(322, 77);
            this.number3.Name = "number3";
            this.number3.Size = new System.Drawing.Size(100, 20);
            this.number3.TabIndex = 0;
            // 
            // number2
            // 
            this.number2.Location = new System.Drawing.Point(180, 77);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(100, 20);
            this.number2.TabIndex = 0;
            // 
            // number1
            // 
            this.number1.Location = new System.Drawing.Point(46, 77);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(100, 20);
            this.number1.TabIndex = 0;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(116, 126);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 1;
            this.btnGo.Text = "Additional";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(259, 126);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(75, 23);
            this.button.TabIndex = 1;
            this.button.Text = "Multiply";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click_1);
            // 
            // btnGo3
            // 
            this.btnGo3.Location = new System.Drawing.Point(405, 126);
            this.btnGo3.Name = "btnGo3";
            this.btnGo3.Size = new System.Drawing.Size(75, 23);
            this.btnGo3.TabIndex = 1;
            this.btnGo3.Text = "Average";
            this.btnGo3.UseVisualStyleBackColor = true;
            this.btnGo3.Click += new System.EventHandler(this.btnGo3_Click);
            // 
            // lbxOutput
            // 
            this.lbxOutput.FormattingEnabled = true;
            this.lbxOutput.Location = new System.Drawing.Point(259, 199);
            this.lbxOutput.Name = "lbxOutput";
            this.lbxOutput.ScrollAlwaysVisible = true;
            this.lbxOutput.Size = new System.Drawing.Size(120, 95);
            this.lbxOutput.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(519, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbxOutput);
            this.Controls.Add(this.btnGo3);
            this.Controls.Add(this.button);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.number1);
            this.Controls.Add(this.number2);
            this.Controls.Add(this.number3);
            this.Controls.Add(this.number4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox number4;
        private System.Windows.Forms.TextBox number3;
        private System.Windows.Forms.TextBox number2;
        private System.Windows.Forms.TextBox number1;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Button btnGo3;
        private System.Windows.Forms.ListBox lbxOutput;
        private System.Windows.Forms.Button button1;
    }
}

