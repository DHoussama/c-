namespace homework4
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
            this.pTarget = new System.Windows.Forms.Panel();
            this.bStart = new System.Windows.Forms.Button();
            this.bBike1 = new System.Windows.Forms.Button();
            this.bBike2 = new System.Windows.Forms.Button();
            this.bBike3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.step1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pTarget
            // 
            this.pTarget.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pTarget.Location = new System.Drawing.Point(592, 43);
            this.pTarget.Name = "pTarget";
            this.pTarget.Size = new System.Drawing.Size(176, 250);
            this.pTarget.TabIndex = 0;
            // 
            // bStart
            // 
            this.bStart.Location = new System.Drawing.Point(41, 331);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(107, 76);
            this.bStart.TabIndex = 1;
            this.bStart.Text = "Start";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // bBike1
            // 
            this.bBike1.Font = new System.Drawing.Font("Webdings", 31.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.bBike1.Location = new System.Drawing.Point(52, 25);
            this.bBike1.Name = "bBike1";
            this.bBike1.Size = new System.Drawing.Size(86, 74);
            this.bBike1.TabIndex = 2;
            this.bBike1.Text = "b";
            this.bBike1.UseVisualStyleBackColor = true;
            this.bBike1.Click += new System.EventHandler(this.bBike1_Click_1);
            // 
            // bBike2
            // 
            this.bBike2.Font = new System.Drawing.Font("Webdings", 31.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.bBike2.Location = new System.Drawing.Point(52, 124);
            this.bBike2.Name = "bBike2";
            this.bBike2.Size = new System.Drawing.Size(80, 71);
            this.bBike2.TabIndex = 3;
            this.bBike2.Text = "b1";
            this.bBike2.UseVisualStyleBackColor = true;
            this.bBike2.Click += new System.EventHandler(this.bBike2_Click);
            // 
            // bBike3
            // 
            this.bBike3.Font = new System.Drawing.Font("Webdings", 31.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.bBike3.Location = new System.Drawing.Point(52, 227);
            this.bBike3.Name = "bBike3";
            this.bBike3.Size = new System.Drawing.Size(75, 66);
            this.bBike3.TabIndex = 4;
            this.bBike3.Text = "b2";
            this.bBike3.UseVisualStyleBackColor = true;
            this.bBike3.Click += new System.EventHandler(this.bBike3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(209, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(132, 259);
            this.panel1.TabIndex = 5;
            // 
            // step1
            // 
            this.step1.Location = new System.Drawing.Point(221, 331);
            this.step1.Name = "step1";
            this.step1.Size = new System.Drawing.Size(120, 76);
            this.step1.TabIndex = 6;
            this.step1.Text = "step1";
            this.step1.UseVisualStyleBackColor = true;
            this.step1.Click += new System.EventHandler(this.step1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Location = new System.Drawing.Point(396, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(74, 250);
            this.panel2.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(387, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 76);
            this.button1.TabIndex = 8;
            this.button1.Text = "step2";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(631, 331);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 67);
            this.button3.TabIndex = 10;
            this.button3.Text = "0";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.step1);
            this.Controls.Add(this.bBike3);
            this.Controls.Add(this.bBike2);
            this.Controls.Add(this.bBike1);
            this.Controls.Add(this.bStart);
            this.Controls.Add(this.pTarget);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pTarget;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.Button bBike1;
        private System.Windows.Forms.Button bBike2;
        private System.Windows.Forms.Button bBike3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button step1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}

