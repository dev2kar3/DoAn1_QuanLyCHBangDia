﻿using QuanLyCHChoThueBangDia.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCHChoThueBangDia
{
    public partial class fAccountManager : Form
    {
        public fAccountManager()
        {
            InitializeComponent();

            loadMemberInfo();
        }

        void loadMemberInfo()
        {
            dtgv_member.DataSource = memberInfoDAO.Instance.loadMemberInfoList();
        }

        private void fAccountManager_Click(object sender, EventArgs e)
        {
            
        }
    }
}
