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
	class GameLighter
	{
		public bool greencolor;

		public int switchtime;

		public delegate void OnSwitchColor();
		public OnSwitchColor SwitchColor;

		public bool workstatus;

		public Thread LighterThread;
		void LighterFunc()
		{
			while(workstatus)
			{
				greencolor = true;
				VEHICLE.drive = true;
				SwitchColor();
				Thread.Sleep(switchtime);

				greencolor = false;
				VEHICLE.drive = false;
				SwitchColor();
				Thread.Sleep(switchtime);
			}
		}
		public GameLighter()
		{
			LighterThread = new Thread(new ThreadStart(LighterFunc));
			workstatus = true;
		}
		public void DrawLighter(Graphics ds)
		{
			if(greencolor)
			{
				ds.FillEllipse(Brushes.Green, 325, 180, 30, 30);
			}
			else
			{
				ds.FillEllipse(Brushes.Red, 325, 180, 30, 30);
			}
		}
	}
}
