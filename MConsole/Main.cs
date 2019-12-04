using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;
using From;
using System.IO;

namespace SConsole
{
    public class MConsole
    {
        From.Console cc = new From.Console();
        static string dtime = DateTime.Now.ToString("HH:mm dd MM yyyy").Replace(":", "_").Replace(" ", "_").Replace("/","_");
        static string txt = dtime + "_log.txt";
        StreamWriter sw = new StreamWriter(txt,true);
        public MConsole()
        {
            
        }
        public bool writetofile = false;
        public void Init()
        {
            cc.Show();
        }
        public void Init(string name)
        {                    
            cc.Show();
            cc.Cname.Text = name;
        }
        public void DEBUGMSG(string dbgmsg)
        {
            cc.Console_Text.SelectionColor = Color.Orange;
            cc.Console_Text.AppendText(dbgmsg + Environment.NewLine);
            if(writetofile)
            {
                sw.WriteLine(dbgmsg);
                sw.Flush();
            }
        }
        public void DEBUGMSG(string dbgmsg,Color color)
        {
            cc.Console_Text.SelectionColor = color;
            cc.Console_Text.AppendText(dbgmsg + Environment.NewLine);
            if (writetofile)
            {
                sw.WriteLine(dbgmsg);
                sw.Flush();
            }
        }
        public void LOG(string logmsg)
        {
            cc.Console_Text.SelectionColor = Color.White;
            cc.Console_Text.AppendText(logmsg + Environment.NewLine);
            if (writetofile)
            {
                sw.WriteLine(logmsg);
                sw.Flush();
            }
        }
        public void LOG(string logmsg,Color color)
        {
            cc.Console_Text.SelectionColor = color;
            //cc.Console_Text.ForeColor = color;
            cc.Console_Text.AppendText(logmsg + Environment.NewLine);
            if (writetofile)
            {
                sw.WriteLine(logmsg);
                sw.Flush();
            }
        }
    }
}
