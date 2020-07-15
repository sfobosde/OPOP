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
	public partial class GameForm : Form
	{
		GameLighter Lighter;

		VEHICLE CAR1;
		VEHICLE CAR2;
		VEHICLE CAR3;
		VEHICLE CAR4;

		public GameForm()
		{
			InitializeComponent();
			Lighter = new GameLighter();
			Lighter.switchtime = 10000;
			Lighter.SwitchColor = new GameLighter.OnSwitchColor(Invalidate);

			CAR1 = new VEHICLE(Vehicle1, 1, 12);
			CAR1.VehicleDrive = new VEHICLE.OnVehicleDrive(Invalidate);

			CAR2 = new VEHICLE(Vehicle2, 4, 15);
			CAR2.VehicleDrive = new VEHICLE.OnVehicleDrive(Invalidate);

			CAR3 = new VEHICLE(Vehicle3, 2, 17);
			CAR3.VehicleDrive = new VEHICLE.OnVehicleDrive(Invalidate);

			CAR4 = new VEHICLE(Vehicle4, 3, 20);
			CAR4.VehicleDrive = new VEHICLE.OnVehicleDrive(Invalidate);

			CAR1.VehThr.Start();
			CAR2.VehThr.Start();
			CAR3.VehThr.Start();
			CAR4.VehThr.Start();

			Lighter.LighterThread.Start();
		}

		private void GameForm_Paint(object sender, PaintEventArgs e)
		{
			GFVisual.DrawRoads(e.Graphics, Brushes.Gray);

			Lighter.DrawLighter(e.Graphics);
		}

		private void GameForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			Lighter.workstatus = false;

			CAR1.workstatus = false;
			CAR2.workstatus = false;
			CAR3.workstatus = false;
			CAR4.workstatus = false;
		}
	}
}
