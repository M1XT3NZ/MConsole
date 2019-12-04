using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Test
{
    public partial class Example : Form
    {
        public Example()
        {
            InitializeComponent();
        }

        SConsole.MConsole mconsole = new SConsole.MConsole();
        private void Form1_Load(object sender, EventArgs e)
        {
            mconsole.Init("The Mighty Console");
            mconsole.writetofile = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mconsole.DEBUGMSG("I'M A DEFAULT COLORED DEBUGMSG");
            mconsole.DEBUGMSG("I'M AN AQUA COLORED DEBUGMSG",Color.Aqua);
            //Thread.Sleep(600);
            mconsole.LOG("I'M THE DEFAULT COLOR");
            mconsole.LOG("I'M A DARKGOLDENROD COLOR",Color.DarkGoldenrod);
        }
    }
}
