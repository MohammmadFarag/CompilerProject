using System;
using System.IO;
using System.Windows.Forms;

namespace Analyzer {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        private void button2_Click(object sender,EventArgs e) {
            richTextBox1.Text = "";
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                string path = ofd.FileName;
                richTextBox1.Text = File.ReadAllText(path);
            }

        }

        private void button1_Click(object sender,EventArgs e) {
            var str = richTextBox1.Text;
            richTextBox2.Text = new Analyze().Result(str);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }
    }
}
