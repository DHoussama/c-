namespace Signals
{
    partial class GraphicsSignalView
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
            this.zoomo = new System.Windows.Forms.Button();
            this.zoomI = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // zoomo
            // 
            this.zoomo.Location = new System.Drawing.Point(10, 15);
            this.zoomo.Name = "zoomo";
            this.zoomo.Size = new System.Drawing.Size(70, 37);
            this.zoomo.TabIndex = 0;
            this.zoomo.Text = "+";
            this.zoomo.UseVisualStyleBackColor = true;
            this.zoomo.Click += new System.EventHandler(this.zoomo_Click);
            // 
            // zoomI
            // 
            this.zoomI.Location = new System.Drawing.Point(101, 15);
            this.zoomI.Name = "zoomI";
            this.zoomI.Size = new System.Drawing.Size(70, 36);
            this.zoomI.TabIndex = 1;
            this.zoomI.Text = "-";
            this.zoomI.UseVisualStyleBackColor = true;
            this.zoomI.Click += new System.EventHandler(this.zoomI_Click);
            // 
            // GraphicsSignalView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.zoomI);
            this.Controls.Add(this.zoomo);
            this.Name = "GraphicsSignalView";
            this.Size = new System.Drawing.Size(310, 190);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button zoomo;
        private System.Windows.Forms.Button zoomI;
    }
}
