using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
            mconsole.testmessage = false; //This writes a test Message to the console if you want to quickly test the console... //Set to false to deactivate it

            foreach (PropertyInfo property in typeof(Color).GetProperties(BindingFlags.Static | BindingFlags.Public))
                if (property.PropertyType == typeof(Color))
                {
                    DEBUGMSG_BOX.Items.Add(property.Name);
                    LOG_BOX.Items.Add(property.Name);
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mconsole.DEBUGMSG("I'M A DEFAULT COLORED DEBUGMSG");//Default Debugmessage log
            mconsole.LOG("I'M THE DEFAULT COLOR LOG MESSAGE");//Default Log messasge
        }

        private void Selected_Btn_Click(object sender, EventArgs e)
        {
            if(DEBUGMSG_BOX.SelectedItem == null || LOG_BOX.SelectedItem == null)
            {
                MessageBox.Show("Please select Colors for both Logs");
            }
            else
            {
                string debug;
                debug = DEBUGMSG_BOX.SelectedItem.ToString();
                string log;
                log = LOG_BOX.SelectedItem.ToString();

                mconsole.DEBUGMSG("I' a custom colored DebugMSG",ColorTranslator.FromHtml(debug));
                mconsole.LOG("I'm a custom colored Log", ColorTranslator.FromHtml(log));

            }
        }
    }
}
