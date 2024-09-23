using Memory;

namespace GameOffsetTool
{
    public partial class Form1 : Form
    {
        public static Mem m = new Mem();
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)

        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string offtext = textBox1.Text;
            string textBox = textBox2.Text;

            var PID = m.GetProcIdFromName(textBox);
            if (PID > 0)
            {
                while (true)
                {
                    m.OpenProcess(PID);
                    m.WriteMemory(offtext.ToString(), "int","100");
                }
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
