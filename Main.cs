﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EveControlPanelApplication
{
    public partial class Main : Form
    {
        private DBConnect dbConnect;
        public Main()
        {
            InitializeComponent();
        }

        private void loginPrefToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mySqlLogin dlg = new mySqlLogin();
            dlg.Show();
        }

        private void testMysql_Click(object sender, EventArgs e)
        {
            dbConnect = new DBConnect();
            dbConnect.Insert();
        }

       
    }
}
