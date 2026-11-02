namespace CounterApp
{
    public class Counter
    {
        private int current = 1;
        private Label display;
        private System.Windows.Forms.Timer timer;
        private int state = 0;

        public Counter(Label labelToUpdate)
        {
            display = labelToUpdate;
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 200;
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            current++;
            if (current > 99)
            {
                current = 1;
            }
            display.Text = current.ToString();
        }

        public void Click()
        {
            if (state == 0)
            {
                timer.Start();
                state = 1;
            }
            else if (state == 1)
            {
                timer.Stop();
                state = 2;
            }
            else
            {
                current = 1;
                display.Text = "1";
                state = 0;
            }
                
        }

    }
}