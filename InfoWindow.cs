using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OPOP
{
	public partial class InfoWindow : Form
	{
		public InfoWindow()
		{
			InitializeComponent();
			TextLabel.Text = "Приложение было разработано студентом группы 4207 Васильевым Григорием. " +
				"\nРабота приложения построена с использованием простых графических возможностей," +
				"\nа так же с использованием потоковых объектов." +
				"\nКНИТУ-КАИ им. Туполева, Институт Компьютерных Технологий и Защиты Информации " +
				"\nКафедра АСОиУ, июль 2020 г.";
		}
	}
}
