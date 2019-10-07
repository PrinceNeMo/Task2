namespace Task1
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
            this.components = new System.ComponentModel.Container();
            this.strtBtn1 = new System.Windows.Forms.Button();
            this.PSBtn1 = new System.Windows.Forms.Button();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.GroupMap = new System.Windows.Forms.GroupBox();
            this.Rndlbl1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Savebtn = new System.Windows.Forms.Button();
            this.recbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // strtBtn1
            // 
            this.strtBtn1.Location = new System.Drawing.Point(667, 226);
            this.strtBtn1.Name = "strtBtn1";
            this.strtBtn1.Size = new System.Drawing.Size(75, 23);
            this.strtBtn1.TabIndex = 0;
            this.strtBtn1.Text = "Strat";
            this.strtBtn1.UseVisualStyleBackColor = true;
            this.strtBtn1.Click += new System.EventHandler(this.StrtBtn1_Click);
            // 
            // PSBtn1
            // 
            this.PSBtn1.Location = new System.Drawing.Point(667, 255);
            this.PSBtn1.Name = "PSBtn1";
            this.PSBtn1.Size = new System.Drawing.Size(75, 23);
            this.PSBtn1.TabIndex = 1;
            this.PSBtn1.Text = "Pause";
            this.PSBtn1.UseVisualStyleBackColor = true;
            this.PSBtn1.Click += new System.EventHandler(this.PSBtn1_Click);
            // 
            // Timer1
            // 
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // GroupMap
            // 
            this.GroupMap.Location = new System.Drawing.Point(12, 12);
            this.GroupMap.Name = "GroupMap";
            this.GroupMap.Size = new System.Drawing.Size(467, 352);
            this.GroupMap.TabIndex = 4;
            this.GroupMap.TabStop = false;
            this.GroupMap.Text = "GB1";
            // 
            // Rndlbl1
            // 
            this.Rndlbl1.AutoSize = true;
            this.Rndlbl1.Location = new System.Drawing.Point(614, 34);
            this.Rndlbl1.Name = "Rndlbl1";
            this.Rndlbl1.Size = new System.Drawing.Size(42, 13);
            this.Rndlbl1.TabIndex = 7;
            this.Rndlbl1.Text = "Round:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(642, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // Savebtn
            // 
            this.Savebtn.Location = new System.Drawing.Point(664, 341);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(75, 23);
            this.Savebtn.TabIndex = 8;
            this.Savebtn.Text = "Save";
            this.Savebtn.UseVisualStyleBackColor = true;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // recbtn
            // 
            this.recbtn.Location = new System.Drawing.Point(664, 370);
            this.recbtn.Name = "recbtn";
            this.recbtn.Size = new System.Drawing.Size(75, 23);
            this.recbtn.TabIndex = 9;
            this.recbtn.Text = "Load";
            this.recbtn.UseVisualStyleBackColor = true;
            this.recbtn.Click += new System.EventHandler(this.Recbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.recbtn);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Rndlbl1);
            this.Controls.Add(this.GroupMap);
            this.Controls.Add(this.PSBtn1);
            this.Controls.Add(this.strtBtn1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button strtBtn1;
        private System.Windows.Forms.Button PSBtn1;
        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.GroupBox GroupMap;
        private System.Windows.Forms.Label Rndlbl1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.Button recbtn;
    }
}

