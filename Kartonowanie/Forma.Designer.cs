namespace Kartonowanie
{
    partial class Forma
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
            this.readBoxesbtn = new System.Windows.Forms.Button();
            this.readItemsBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // readBoxesbtn
            // 
            this.readBoxesbtn.Location = new System.Drawing.Point(43, 36);
            this.readBoxesbtn.Name = "readBoxesbtn";
            this.readBoxesbtn.Size = new System.Drawing.Size(147, 31);
            this.readBoxesbtn.TabIndex = 0;
            this.readBoxesbtn.Text = "Wczytaj kartony";
            this.readBoxesbtn.UseVisualStyleBackColor = true;
            this.readBoxesbtn.Click += new System.EventHandler(this.ReadBoxesbtn_Click);
            // 
            // readItemsBtn
            // 
            this.readItemsBtn.Location = new System.Drawing.Point(43, 103);
            this.readItemsBtn.Name = "readItemsBtn";
            this.readItemsBtn.Size = new System.Drawing.Size(157, 32);
            this.readItemsBtn.TabIndex = 1;
            this.readItemsBtn.Text = "Wczytaj przedmioty";
            this.readItemsBtn.UseVisualStyleBackColor = true;
            this.readItemsBtn.Click += new System.EventHandler(this.ReadItemsBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 26);
            this.button1.TabIndex = 2;
            this.button1.Text = "Oblicz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(43, 230);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 32);
            this.button2.TabIndex = 3;
            this.button2.Text = "Zapisz do excela";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(237, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 6;
            // 
            // Forma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.readItemsBtn);
            this.Controls.Add(this.readBoxesbtn);
            this.Name = "Forma";
            this.Text = "Forma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button readBoxesbtn;
        private System.Windows.Forms.Button readItemsBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}