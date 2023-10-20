using System.Diagnostics.Metrics;

namespace game
{
    public partial class Form1 : Form
    {
        int counter = 0;
        string[,] arr = new string[3, 3];
        int x_win = 0;
        int y_win = 0;

        public Form1()
        {
            InitializeComponent();
            this.ActiveControl = exitButton;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            textBox1.Text = "Ход за: X";
        }
        public void function(Button button)
        {
            if (counter % 2 == 0)
            {
                button.Text = "X";
                textBox1.Text = "Ход за: 0";
            }
            else
            {
                button.Text = "0";
                textBox1.Text = "Ход за: X";
            }
            button.Enabled = false;
            counter++;
        }


        public void check()
        {
            checkLine(arr);
            checkColumn(arr);
            checkDiagonalLeft(arr);
            checkDiagonalRight(arr);
        }


        public void checkDiagonalLeft(string[,] arr)
        {
            string str = arr[0, 0] + arr[1, 1] + arr[2, 2];
            if (str == "XXX")
            {
                MessageBox.Show("Победа за X!");
                Application.Restart();
            }
            else if (str == "000")
            {
                MessageBox.Show("Победа за 0!");
                Application.Restart();
            }
        }

        public void checkDiagonalRight(string[,] arr)
        {
            string str = arr[0, 2] + arr[1, 1] + arr[2, 0];
            if (str == "XXX")
            {
                MessageBox.Show("Победа за X!");
                Application.Restart();
            }
            else if (str == "000")
            {
                MessageBox.Show("Победа за 0!");
                Application.Restart();
            }
        }

        public void checkColumn(string[,] arr)
        {
            for (int j = 0; j < 3; j++)
            {
                string str = "";
                for (int i = 0; i < 3; i++)
                {
                    str += arr[i, j];
                    if (str.Length == 3)
                    {
                        if (str == "XXX")
                        {
                            MessageBox.Show("Победа за X!");
                            Application.Restart();
                        }
                        else if (str == "000")
                        {
                            MessageBox.Show("Победа за 0!");
                            Application.Restart();
                        }
                    }
                }
            }

        }

        public void checkLine(string[,] arr)
        {
            for (int i = 0; i < 3; i++)
            {
                string str = "";

                for (int j = 0; j < 3; j++)
                {
                    str += arr[i, j];
                    if (str.Length == 3)
                    {
                        if (str == "XXX")
                        {
                            MessageBox.Show("Победа за X!");
                            Application.Restart();

                        }
                        else if (str == "000")
                        {
                            MessageBox.Show("Победа за 0!");
                            Application.Restart();
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            function(button1);
            this.ActiveControl = exitButton;
            arr[0, 0] = button1.Text;
            check();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            function(button2);
            this.ActiveControl = exitButton;
            arr[0, 1] = button2.Text;
            check();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            function(button3);
            this.ActiveControl = exitButton;
            arr[0, 2] = button3.Text;
            check();

        }

        private void button4_Click(object sender, EventArgs e)
        {

            function(button4);
            this.ActiveControl = exitButton;
            arr[1, 0] = button4.Text;
            check();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            function(button5);
            this.ActiveControl = exitButton;
            arr[1, 1] = button5.Text;
            check();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            function(button6);
            this.ActiveControl = exitButton;
            arr[1, 2] = button6.Text;
            check();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            function(button7);
            this.ActiveControl = exitButton;
            arr[2, 0] = button7.Text;
            check();
        }

        private void button8_Click(object sender, EventArgs e)
        {

            function(button8);
            this.ActiveControl = exitButton;
            arr[2, 1] = button8.Text;
            check();
        }

        private void button9_Click(object sender, EventArgs e)
        {

            function(button9);
            this.ActiveControl = exitButton;
            arr[2, 2] = button9.Text;
            check();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}