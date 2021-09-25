using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParserFor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string irl = textBox1.Text;

            string irl = "https://github.com/NickFate/ParserFor";
            
            WebClient client = new WebClient();
            string res = client.DownloadString(irl);

            res = res.Substring(res.IndexOf("<title>") + 7);
            res = res.Replace(res.Substring(res.IndexOf("</title>")), "");
            res = res.Substring(res.IndexOf("/") + 1);
            res = res.Replace(res.Substring(res.IndexOf(":")), "");

            textBox2.Text = res;

        }
    }
}
