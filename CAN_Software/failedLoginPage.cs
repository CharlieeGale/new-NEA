﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAN_Software
{
	public partial class failedLoginPage : Form
	{
		public failedLoginPage()
		{
			InitializeComponent();
			this.ControlBox = false;
		}

		private void failedLogin_Load(object sender, EventArgs e)
		{

		}

		private void closeButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
