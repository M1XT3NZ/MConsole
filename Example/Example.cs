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

        SConsole.MConsole mconsole = new SConsole.MConsole();//define the console
        private void Form1_Load(object sender, EventArgs e)
        {
            mconsole.Init("The Mighty Console");//This initiates the Console window this is not needed if writetofile is true
            mconsole.writetofile = true; //If its true it will write to a file which exists in the program folder
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mconsole.DEBUGMSG("I'M A DEFAULT COLORED DEBUGMSG");//Default Debugmessage log
            mconsole.DEBUGMSG("I'M AN AQUA COLORED DEBUGMSG",Color.Aqua);//Aqua colored Debugmessage log

            mconsole.LOG("I'M THE DEFAULT COLOR");//Default Log messasge
            mconsole.LOG("I'M A DARKGOLDENROD COLOR",Color.DarkGoldenrod);//DarkGoldenrod log message
        }
    }
}
