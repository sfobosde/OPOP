namespace OPOP
{
	partial class GameForm
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
			this.Vehicle1 = new System.Windows.Forms.PictureBox();
			this.Vehicle2 = new System.Windows.Forms.PictureBox();
			this.Vehicle3 = new System.Windows.Forms.PictureBox();
			this.Vehicle4 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.Vehicle1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Vehicle2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Vehicle3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Vehicle4)).BeginInit();
			this.SuspendLayout();
			// 
			// Vehicle1
			// 
			this.Vehicle1.Image = global::OPOP.Properties.Resources.CAR1UPVIEW;
			this.Vehicle1.Location = new System.Drawing.Point(51, 262);
			this.Vehicle1.Name = "Vehicle1";
			this.Vehicle1.Size = new System.Drawing.Size(100, 50);
			this.Vehicle1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.Vehicle1.TabIndex = 0;
			this.Vehicle1.TabStop = false;
			// 
			// Vehicle2
			// 
			this.Vehicle2.BackColor = System.Drawing.SystemColors.ControlDark;
			this.Vehicle2.Image = global::OPOP.Properties.Resources.CAR2UPVIEW;
			this.Vehicle2.Location = new System.Drawing.Point(339, 37);
			this.Vehicle2.Name = "Vehicle2";
			this.Vehicle2.Size = new System.Drawing.Size(100, 50);
			this.Vehicle2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.Vehicle2.TabIndex = 1;
			this.Vehicle2.TabStop = false;
			// 
			// Vehicle3
			// 
			this.Vehicle3.BackColor = System.Drawing.SystemColors.ControlDark;
			this.Vehicle3.Image = global::OPOP.Properties.Resources.CAR3UPVIEW;
			this.Vehicle3.Location = new System.Drawing.Point(476, 398);
			this.Vehicle3.Name = "Vehicle3";
			this.Vehicle3.Size = new System.Drawing.Size(100, 50);
			this.Vehicle3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.Vehicle3.TabIndex = 2;
			this.Vehicle3.TabStop = false;
			// 
			// Vehicle4
			// 
			this.Vehicle4.BackColor = System.Drawing.SystemColors.ControlDark;
			this.Vehicle4.Image = global::OPOP.Properties.Resources.CAR4UPVIEW;
			this.Vehicle4.Location = new System.Drawing.Point(735, 186);
			this.Vehicle4.Name = "Vehicle4";
			this.Vehicle4.Size = new System.Drawing.Size(100, 50);
			this.Vehicle4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.Vehicle4.TabIndex = 3;
			this.Vehicle4.TabStop = false;
			// 
			// GameForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(878, 514);
			this.Controls.Add(this.Vehicle4);
			this.Controls.Add(this.Vehicle3);
			this.Controls.Add(this.Vehicle2);
			this.Controls.Add(this.Vehicle1);
			this.Name = "GameForm";
			this.Text = "GameForm";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameForm_FormClosing);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameForm_Paint);
			((System.ComponentModel.ISupportInitialize)(this.Vehicle1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Vehicle2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Vehicle3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Vehicle4)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox Vehicle1;
		private System.Windows.Forms.PictureBox Vehicle2;
		private System.Windows.Forms.PictureBox Vehicle3;
		private System.Windows.Forms.PictureBox Vehicle4;
	}
}