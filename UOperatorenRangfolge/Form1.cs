namespace UOperatorenRangfolge
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void CmdAnzeigen1_Click(object sender, EventArgs e)
        {
            int a = 5;
            int b = 10;
            LblAnzeige.Text = $"a > 0 AND b != 10 is {a > 0 && b != 10}\n" +
                $"a > 0 OR b != 10 is {a > 0 || b != 10}";
        }

        private void CmdAnzeigen2_Click(object sender, EventArgs e)
        {
            int z = 10;
            int w = 100;
            LblAnzeige.Text = $"z != 0 OR z > w OR w - z == 90 is { z != 0 || z > w || w - z == 90 }\n" +
                $"z == 11 AND z > w OR w - z == 90 is { z == 11 && z > w || w - z == 90}";
        }

        private void CmdAnzeigen3_Click(object sender, EventArgs e)
        {
            double x = 1.0;
            double y = 5.7;
            LblAnzeige.Text = $"x >= .9 AND y < 5.8 is {x >= .9 && y <  5.8}\n" +
                $"x >= .9 AND !(y <= 5.8) is {x >= .9 && !(y <= 5.8)}";
        }

        private void CmdAnzeigen4_Click(object sender, EventArgs e)
        {
            int n1 = 1;
            int n2 = 17;
            LblAnzeige.Text = $"n1 > 0 AND n2 > 0 OR n1 > n2 AND n2 != 17 is {n1 > 0 && n2 > 0 || n1 > n2 && n2 != 17}\n" +
                $"n1 > 0 AND (n2 > 0 OR n1 > n2) AND n2 != 17 is {n1 > 0 && (n2 > 0 || n1 > n2) && n2 != 17}";
        }

        private void CmdBeenden_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}