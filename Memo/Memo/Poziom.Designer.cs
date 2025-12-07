namespace Memo {
    partial class Poziom {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.Easy = new System.Windows.Forms.Button();
            this.Hard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(296, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wybierz poziom rozgrywki:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Easy
            // 
            this.Easy.Location = new System.Drawing.Point(158, 175);
            this.Easy.Name = "Easy";
            this.Easy.Size = new System.Drawing.Size(141, 79);
            this.Easy.TabIndex = 1;
            this.Easy.Text = "Łatwy";
            this.Easy.UseVisualStyleBackColor = true;
            this.Easy.Click += new System.EventHandler(this.Easy_Click);
            // 
            // Hard
            // 
            this.Hard.Location = new System.Drawing.Point(437, 175);
            this.Hard.Name = "Hard";
            this.Hard.Size = new System.Drawing.Size(143, 79);
            this.Hard.TabIndex = 2;
            this.Hard.Text = "Trudny";
            this.Hard.UseVisualStyleBackColor = true;
            this.Hard.Click += new System.EventHandler(this.button2_Click);
            // 
            // Poziom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Hard);
            this.Controls.Add(this.Easy);
            this.Controls.Add(this.label1);
            this.Name = "Poziom";
            this.Text = "Poziom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Easy;
        private System.Windows.Forms.Button Hard;
    }
}