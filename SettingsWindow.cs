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
	public partial class SettingsWindow : Form
	{
		static Color theme = Color.White;
		public SettingsWindow()
		{
			InitializeComponent();
			this.BackColor = theme;

			ThemeBox.Items.Add("Дневная");
			ThemeBox.Items.Add("Ночная");

			SwitchTheme += new OnSwitchTheme(SettingsWindow.SetTheme);
		}
		public static void SetTheme(Color thm)
		{
			theme = thm;
		}

		public delegate void OnSwitchTheme(Color theme);
		public OnSwitchTheme SwitchTheme;

		private void SelectThemeButton_Click(object sender, EventArgs e)
		{
			Color thm = Color.White;

			if (ThemeBox.SelectedIndex == 0)
				thm = Color.White;
			else if (ThemeBox.SelectedIndex == 1)
				thm = Color.Gray;

			SwitchTheme(thm);
		}
	}
}
