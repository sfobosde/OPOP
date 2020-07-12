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
	class GFVisual
	{
		public static Rectangle Crossroad = new Rectangle(240, 140, 200, 125);

		public static Rectangle LeftDA = new Rectangle(0, 140, 240, 60);
		public static Rectangle StopLineAreaLeft = new Rectangle(200, 205, 35, 60);
		public static Rectangle LeftBeforeSL = new Rectangle(0, 205, 200, 60);

		public static Rectangle RightDA = new Rectangle(440, 205, 240, 65);
		public static Rectangle StopLineAreaRight = new Rectangle(445, 140, 35, 60);
		public static Rectangle RightBeforeSL = new Rectangle(470, 140, 200, 60);

		public static Rectangle UpDA = new Rectangle(340, 0, 100, 140);
		public static Rectangle StopLineAreaUP = new Rectangle(240, 0, 95, 130);
		public static Rectangle UPBeforeSL = new Rectangle(240, 130, 95, 5);

		public static Rectangle DownDA = new Rectangle(240, 265, 100, 150);
		public static Rectangle StopLineAreaDown = new Rectangle(345, 270, 100, 35);
		public static Rectangle DownBeforeSL = new Rectangle(345, 300, 100, 120);

		public static void DrawRoads(Graphics GF, Brush RoadColor)
		{
			GF.FillRectangle(RoadColor, Crossroad);

			GF.FillRectangle(RoadColor, LeftDA);
			GF.FillRectangle(RoadColor, StopLineAreaLeft);
			GF.FillRectangle(RoadColor, LeftBeforeSL);

			GF.FillRectangle(RoadColor, RightDA);
			GF.FillRectangle(RoadColor, StopLineAreaRight);
			GF.FillRectangle(RoadColor, RightBeforeSL);

			GF.FillRectangle(RoadColor, UpDA);
			GF.FillRectangle(RoadColor, StopLineAreaUP);
			GF.FillRectangle(RoadColor, UPBeforeSL);

			GF.FillRectangle(RoadColor, DownDA);
			GF.FillRectangle(RoadColor, StopLineAreaDown);
			GF.FillRectangle(RoadColor, DownBeforeSL);
		}

		public static bool IsVehAbleToDrive(Rectangle veh)
		{
			Rectangle check;

			check = veh;
			check.Intersect(Crossroad);
			if(!check.IsEmpty)
				return true;

			check = veh;
			check.Intersect(LeftDA);
			if (!check.IsEmpty)
				return true;

			check = veh;
			check.Intersect(RightDA);
			if (!check.IsEmpty)
				return true;

			check = veh;
			check.Intersect(UpDA);
			if (!check.IsEmpty)
				return true;

			check = veh;
			check.Intersect(DownDA);
			if (!check.IsEmpty)
				return true;

			check = veh;
			check.Intersect(StopLineAreaLeft);
			if (!check.IsEmpty)
				return false;
			check = veh;
			check.Intersect(LeftBeforeSL);
			if (!check.IsEmpty)
				return true;

			check = veh;
			check.Intersect(StopLineAreaRight);
			if (!check.IsEmpty)
				return false;
			check = veh;
			check.Intersect(RightBeforeSL);
			if (!check.IsEmpty)
				return true;

			check = veh;
			check.Intersect(StopLineAreaUP);
			if (!check.IsEmpty)
				return false;
			check = veh;
			check.Intersect(UPBeforeSL);
			if (!check.IsEmpty)
				return true;

			check = veh;
			check.Intersect(StopLineAreaDown);
			if (!check.IsEmpty)
				return false;
			check = veh;
			check.Intersect(DownBeforeSL);
			if (!check.IsEmpty)
				return true;

			return false;

		}
	}
}
