namespace OPOP
{
	partial class StartForm
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
			this.startbutton = new System.Windows.Forms.Button();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.VEH1 = new System.Windows.Forms.PictureBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.VEH1)).BeginInit();
			this.SuspendLayout();
			// 
			// startbutton
			// 
			this.startbutton.Location = new System.Drawing.Point(229, 307);
			this.startbutton.Name = "startbutton";
			this.startbutton.Size = new System.Drawing.Size(316, 75);
			this.startbutton.TabIndex = 0;
			this.startbutton.Text = "СТАРТ";
			this.startbutton.UseVisualStyleBackColor = true;
			this.startbutton.Click += new System.EventHandler(this.startbutton_Click);
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = global::OPOP.Properties.Resources.CAR4PREV;
			this.pictureBox4.Location = new System.Drawing.Point(588, 134);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(137, 113);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox4.TabIndex = 5;
			this.pictureBox4.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = global::OPOP.Properties.Resources.CAR3PREV;
			this.pictureBox3.Location = new System.Drawing.Point(408, 134);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(137, 113);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 4;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::OPOP.Properties.Resources.CAR2PREV;
			this.pictureBox2.Location = new System.Drawing.Point(229, 134);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(137, 113);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 3;
			this.pictureBox2.TabStop = false;
			// 
			// VEH1
			// 
			this.VEH1.ErrorImage = global::OPOP.Properties.Resources.CAR1PREV;
			this.VEH1.Image = global::OPOP.Properties.Resources.CAR1PREV;
			this.VEH1.InitialImage = ((System.Drawing.Image)(resources.GetObject("VEH1.InitialImage")));
			this.VEH1.Location = new System.Drawing.Point(50, 134);
			this.VEH1.Name = "VEH1";
			this.VEH1.Size = new System.Drawing.Size(137, 113);
			this.VEH1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.VEH1.TabIndex = 2;
			this.VEH1.TabStop = false;
			this.VEH1.WaitOnLoad = true;
			// 
			// StartForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(791, 464);
			this.Controls.Add(this.pictureBox4);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.VEH1);
			this.Controls.Add(this.startbutton);
			this.Name = "StartForm";
			this.Text = "Светофор";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StartForm_FormClosing);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.StartForm_Paint);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.VEH1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button startbutton;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox4;
		public System.Windows.Forms.PictureBox VEH1;
		private System.Windows.Forms.Timer timer1;
	}
}

