using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLiteDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string message = "";
            //bool b = DBHelperSQLite.CreateDataBase("SQLiteDemo.db", ref message);
            //MessageBox.Show(message);
            //if (!b)
            //    return;
            //b = DBHelperSQLite.CreateDataTable("SQLiteDemo.db", "tb_Demo", "name, score", ref message);
            //MessageBox.Show(message);
            //if (!b)
            //    return;
            

        }
    }
}
