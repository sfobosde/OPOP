﻿using System;
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
		MenuItem exititem;
		MenuItem viewitem;

		MenuItem fileitem;
		MenuItem infoitem;

		MainMenu StartFormMenu;
		public StartForm()
		{
			InitializeComponent();

			viewitem = new MenuItem("Обзор", new EventHandler(OnClickViewItemMenu));
			exititem = new MenuItem("Выход", new EventHandler(OnClickExitItemMenu));

			fileitem = new MenuItem("Файл", new MenuItem[] { viewitem, exititem });

			infoitem = new MenuItem("Информация", new EventHandler(OnClickInfoItemMenu));

			StartFormMenu = new MainMenu(new MenuItem[] { fileitem, infoitem });
			this.Menu = StartFormMenu;
		}

		void OnClickExitItemMenu(object sr, EventArgs e)
		{
			this.Close();
		}
		void OnClickViewItemMenu(object sr, EventArgs e)
		{
			//on click view in menu
			ViewWindow viewWindow = new ViewWindow();
			viewWindow.Show();
		}
		void OnClickInfoItemMenu(object sr, EventArgs e)
		{
			//on click info in menu
			InfoWindow iw = new InfoWindow();
			iw.Show();
		}
		private void StartForm_Paint(object sender, PaintEventArgs e)
		{
		}

		private void StartForm_FormClosing(object sender, FormClosingEventArgs e)
		{
		}

		private void startbutton_Click(object sender, EventArgs e)
		{
			GameForm field = new GameForm();
			field.Show();
		}
	}
}
