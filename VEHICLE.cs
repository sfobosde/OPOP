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
	class VEHICLE
	{
		public static bool drive = true;
		int dx, dy;

		public PictureBox VehicleImage;

		public delegate void OnVehicleDrive();
		public OnVehicleDrive VehicleDrive;
		public bool workstatus;

		public Thread VehThr;

		Bitmap vehimg;

		Rectangle VR;

		void VehicleFunc()
		{
			while(workstatus)
			{
				if (VehicleImage.Location.X > 570)
				{
					dx = -dx;
					VehicleImage.Location = new Point(VehicleImage.Location.X + dx, 150);
					vehimg.RotateFlip(RotateFlipType.Rotate180FlipY);
					VehicleImage.Image = vehimg;
				}
				if (VehicleImage.Location.X < 30)
				{
					dx = -dx;
					VehicleImage.Location = new Point(VehicleImage.Location.X + dx, 215);
					vehimg.RotateFlip(RotateFlipType.Rotate180FlipY);
					VehicleImage.Image = vehimg;
				}
				if (VehicleImage.Location.Y < 10)
				{
					dy = -dy;
					VehicleImage.Location = new Point( 250, VehicleImage.Location.Y + dy);
					vehimg.RotateFlip(RotateFlipType.Rotate180FlipX);
					VehicleImage.Image = vehimg;
				}
				if (VehicleImage.Location.Y > 370)
				{
					dy = -dy;
					VehicleImage.Location = new Point(350, VehicleImage.Location.Y + dy);
					vehimg.RotateFlip(RotateFlipType.Rotate180FlipX);
					VehicleImage.Image = vehimg;
				}

				VR = new Rectangle(VehicleImage.Location, VehicleImage.Size);

				if (drive || GFVisual.IsVehAbleToDrive(VR))
				{
					VehicleImage.Location = new Point(VehicleImage.Location.X + dx, VehicleImage.Location.Y + dy);
				}
				VehicleDrive();
				Thread.Sleep(100);
			}
		}
		public VEHICLE(PictureBox VehicleImage, int pos, int speed)
		{
			VehThr = new Thread(new ThreadStart(VehicleFunc));
			this.VehicleImage = VehicleImage;
			vehimg = (Bitmap)VehicleImage.Image;
			switch(pos)
			{
				case 1:
					dx = speed;
					VehicleImage.Size = new Size(100, 50);
					break;
				case 2:
					vehimg.RotateFlip(RotateFlipType.Rotate90FlipY);
					VehicleImage.Image = vehimg;
					VehicleImage.Size = new Size(50, 100);
					dy = -speed;
					break;
				case 3:
					vehimg.RotateFlip(RotateFlipType.Rotate180FlipY);
					VehicleImage.Image = vehimg;
					VehicleImage.Size = new Size(100, 50);
					dx = -speed;
					break;
				case 4:
					vehimg.RotateFlip(RotateFlipType.Rotate270FlipY);
					VehicleImage.Image = vehimg;
					VehicleImage.Size = new Size(50, 100);
					dy = speed;
					break;
			}
			workstatus = true;
		}
	}
}
