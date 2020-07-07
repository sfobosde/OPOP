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
			public LIGHTER()
			{
				LighterThread = new Thread(new ThreadStart(LighterFunc));
				LighterThread.Name = "Lighter";
				live = true;
				LighterThread.Start();
			}
		}
		LIGHTER Lighter;
		public StartForm()
		{
			InitializeComponent();
			Lighter = new LIGHTER();
			Lighter.SwitchColor += new LIGHTER.OnSwitchColor(Invalidate);
		}

		private void StartForm_Paint(object sender, PaintEventArgs e)
		{
			Lighter.SetColor(e.Graphics);
		}

		private void StartForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			Lighter.live = false;
		}
	}
}
