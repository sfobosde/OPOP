using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace OPOP
{
	public partial class StartForm : Form
	{
		class LIGHTER
		{
			public bool live;

			public delegate void OnSwitchColor();
			public OnSwitchColor SwitchColor;

			public Thread LighterThread;

			public bool gc = true;

			void LighterFunc()
			{
				while(live)
				{
					Thread.Sleep(1000);
					SwitchColor();
				}
				SwitchColor();
			}
			public void SetColor(Graphics fc)
			{
				if(gc)
				{
					fc.FillEllipse(Brushes.Green, 30, 30, 50, 50);
					gc = false;
				}
				else
				{
					fc.FillEllipse(Brushes.Red, 30, 30, 50, 50);
					gc = true;
				}
			}
			public void SetTextMessage(Graphics fc)
			{
				Font fnt = new Font("Times New Romana", 10);
				if (gc)
				{
					fc.DrawString("Не смей ехать на красный!", fnt, Brushes.Red, 120, 45);
				}
				else
				{
					fc.DrawString("Не тормози, Зеленый - Стартуй!", fnt, Brushes.Green, 120, 45);
				}
			}
			public LIGHTER()
			{
				LighterThread = new Thread(new ThreadStart(LighterFunc));
				LighterThread.Name = "Lighter";
				live = true;
				LighterThread.Start();
			}
		}

		LIGHTER Lighter;

		MenuItem exititem;
		MenuItem viewitem;

		MenuItem fileitem;
		MenuItem settingsitem;
		MenuItem infoitem;

		MainMenu StartFormMenu;
		public StartForm()
		{
			InitializeComponent();

			Lighter = new LIGHTER();
			Lighter.SwitchColor += new LIGHTER.OnSwitchColor(Invalidate);

			viewitem = new MenuItem("Обзор", new EventHandler(OnClickViewItemMenu));
			exititem = new MenuItem("Выход", new EventHandler(OnClickExitItemMenu));

			fileitem = new MenuItem("Файл", new MenuItem[] { viewitem, exititem });

			settingsitem = new MenuItem("Настройки", new EventHandler(OnClickSettingsItemMenu));

			infoitem = new MenuItem("Информация", new EventHandler(OnClickInfoItemMenu));

			StartFormMenu = new MainMenu(new MenuItem[] { fileitem, settingsitem, infoitem });
			this.Menu = StartFormMenu;
		}

		void OnClickExitItemMenu(object sr, EventArgs e)
		{

		}
		void OnClickViewItemMenu(object sr, EventArgs e)
		{

		}
		void OnClickSettingsItemMenu(object sr, EventArgs e)
		{

		}
		void OnClickInfoItemMenu(object sr, EventArgs e)
		{

		}
		private void StartForm_Paint(object sender, PaintEventArgs e)
		{
			Lighter.SetColor(e.Graphics);
			Lighter.SetTextMessage(e.Graphics);
		}

		private void StartForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			Lighter.live = false;
		}
	}
}
