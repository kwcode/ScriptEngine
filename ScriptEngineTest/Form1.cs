using ScriptEngine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ScriptEngineTest
{
    /// <summary>
    /// 1.0
    /// 
    /// DD
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var demoJS = System.IO.File.ReadAllText("js/demo.js");

            Script scriptEngine = new Script(demoJS);
            var d = scriptEngine.Eval("say(2)");

            var d2 = scriptEngine.Run("jisuan", 1, 2);

            var d3 = scriptEngine.Eval("jisuan(1,3)");

            var d2_1 = scriptEngine.Eval("jsonV");

            var msg = scriptEngine.Eval("jsonData.msg");//调用对象 中的属性
        }
    }
}
