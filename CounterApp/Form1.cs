namespace CounterApp
{
    public partial class Form1 : Form
    {
        private Counter counter1;
        private Counter counter2;

        public Form1()
        {
            InitializeComponent();
            counter1 = new Counter(lblCount1);
            counter2 = new Counter(lblCount2);
        }

        private void btnStart1_Click(object sender, EventArgs e)
        {
            counter1.Click();
        }

        private void btnStart2_Click(object sender, EventArgs e)
        {
            counter2.Click();
        }
    }
}
