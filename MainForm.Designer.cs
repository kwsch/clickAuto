/*
 * Created by SharpDevelop.
 * User: Austyn
 * Date: 10/30/2015
 * Time: 8:04 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace clickAuto
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label L_Position;
		private System.Windows.Forms.Button B_Go;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.L_Position = new System.Windows.Forms.Label();
            this.B_Go = new System.Windows.Forms.Button();
            this.nud_x1 = new System.Windows.Forms.NumericUpDown();
            this.nud_y1 = new System.Windows.Forms.NumericUpDown();
            this.nud_y2 = new System.Windows.Forms.NumericUpDown();
            this.nud_x2 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nud_sleep = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_x1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_y1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_y2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_x2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_sleep)).BeginInit();
            this.SuspendLayout();
            // 
            // L_Position
            // 
            this.L_Position.Location = new System.Drawing.Point(12, 9);
            this.L_Position.Name = "L_Position";
            this.L_Position.Size = new System.Drawing.Size(100, 30);
            this.L_Position.TabIndex = 3;
            this.L_Position.Text = "X: {0}\r\nY: {1}";
            // 
            // B_Go
            // 
            this.B_Go.Location = new System.Drawing.Point(54, 9);
            this.B_Go.Name = "B_Go";
            this.B_Go.Size = new System.Drawing.Size(75, 30);
            this.B_Go.TabIndex = 5;
            this.B_Go.Text = "Run";
            this.B_Go.UseVisualStyleBackColor = true;
            this.B_Go.Click += new System.EventHandler(this.B_Go_Click);
            // 
            // nud_x1
            // 
            this.nud_x1.Location = new System.Drawing.Point(35, 45);
            this.nud_x1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nud_x1.Name = "nud_x1";
            this.nud_x1.Size = new System.Drawing.Size(57, 20);
            this.nud_x1.TabIndex = 6;
            this.nud_x1.Value = new decimal(new int[] {
            270,
            0,
            0,
            0});
            // 
            // nud_y1
            // 
            this.nud_y1.Location = new System.Drawing.Point(35, 64);
            this.nud_y1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nud_y1.Name = "nud_y1";
            this.nud_y1.Size = new System.Drawing.Size(57, 20);
            this.nud_y1.TabIndex = 7;
            this.nud_y1.Value = new decimal(new int[] {
            270,
            0,
            0,
            0});
            // 
            // nud_y2
            // 
            this.nud_y2.Location = new System.Drawing.Point(98, 64);
            this.nud_y2.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nud_y2.Name = "nud_y2";
            this.nud_y2.Size = new System.Drawing.Size(57, 20);
            this.nud_y2.TabIndex = 9;
            this.nud_y2.Value = new decimal(new int[] {
            800,
            0,
            0,
            0});
            // 
            // nud_x2
            // 
            this.nud_x2.Location = new System.Drawing.Point(98, 45);
            this.nud_x2.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nud_x2.Name = "nud_x2";
            this.nud_x2.Size = new System.Drawing.Size(57, 20);
            this.nud_x2.TabIndex = 8;
            this.nud_x2.Value = new decimal(new int[] {
            1250,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "X1\r\nY1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 26);
            this.label2.TabIndex = 11;
            this.label2.Text = "X2\r\nY2";
            // 
            // nud_sleep
            // 
            this.nud_sleep.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud_sleep.Location = new System.Drawing.Point(135, 19);
            this.nud_sleep.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nud_sleep.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nud_sleep.Name = "nud_sleep";
            this.nud_sleep.Size = new System.Drawing.Size(57, 20);
            this.nud_sleep.TabIndex = 2;
            this.nud_sleep.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "sleep (ms)";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 96);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nud_sleep);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nud_y2);
            this.Controls.Add(this.nud_x2);
            this.Controls.Add(this.nud_y1);
            this.Controls.Add(this.nud_x1);
            this.Controls.Add(this.B_Go);
            this.Controls.Add(this.L_Position);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AUTOCLICK";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.nud_x1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_y1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_y2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_x2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_sleep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        private System.Windows.Forms.NumericUpDown nud_x1;
        private System.Windows.Forms.NumericUpDown nud_y1;
        private System.Windows.Forms.NumericUpDown nud_y2;
        private System.Windows.Forms.NumericUpDown nud_x2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nud_sleep;
        private System.Windows.Forms.Label label3;
    }
}
