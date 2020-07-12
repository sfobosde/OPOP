namespace OPOP
{
	partial class SettingsWindow
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
			this.label1 = new System.Windows.Forms.Label();
			this.ThemeBox = new System.Windows.Forms.ListBox();
			this.SelectThemeButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(28, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 17);
			this.label1.TabIndex = 2;
			this.label1.Text = "Тема";
			// 
			// ThemeBox
			// 
			this.ThemeBox.FormattingEnabled = true;
			this.ThemeBox.ItemHeight = 16;
			this.ThemeBox.Location = new System.Drawing.Point(31, 53);
			this.ThemeBox.Name = "ThemeBox";
			this.ThemeBox.Size = new System.Drawing.Size(117, 36);
			this.ThemeBox.TabIndex = 3;
			// 
			// SelectThemeButton
			// 
			this.SelectThemeButton.Location = new System.Drawing.Point(155, 53);
			this.SelectThemeButton.Name = "SelectThemeButton";
			this.SelectThemeButton.Size = new System.Drawing.Size(101, 36);
			this.SelectThemeButton.TabIndex = 4;
			this.SelectThemeButton.Text = "Установить";
			this.SelectThemeButton.UseVisualStyleBackColor = true;
			this.SelectThemeButton.Click += new System.EventHandler(this.SelectThemeButton_Click);
			// 
			// SettingsWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLight;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.SelectThemeButton);
			this.Controls.Add(this.ThemeBox);
			this.Controls.Add(this.label1);
			this.Name = "SettingsWindow";
			this.Text = "SettingsWindow";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox ThemeBox;
		private System.Windows.Forms.Button SelectThemeButton;
	}
}