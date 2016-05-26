using System;
using System.Windows.Forms;

namespace Analyzer {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        private void button2_Click(object sender,EventArgs e) {
            richTextBox1.Text = "";
        }

        private void button1_Click(object sender,EventArgs e) {
            var str = richTextBox1.Text;
            richTextBox2.Text = new Analyze().Result(str);
        }
    }
}
