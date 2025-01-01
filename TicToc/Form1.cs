namespace TicToc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Panel panel = new Panel();

            bool g = true;

            for (int i = 0; i < 3 * 3; i++)
            {
                Button button = new Button();
                button.Size = new Size(sdxvf, sdxvf);
                button.Location = new Point(sdxvf * (i % 3), sdxvf * (i / 3));
                button.Click += (object? sender, EventArgs e) =>
                {
                    int a = (sender as Button).TabIndex;
                    if (g && (sender as Button).Text == "") { (sender as Button).Text = "A"; g = false; }
                    else if (g == false && (sender as Button).Text == "") { (sender as Button).Text = "B"; g = true; }


                    if (a % 3 == 0 && panel.Controls[a].Text == panel.Controls[a + 1].Text && panel.Controls[a].Text == panel.Controls[a + 2].Text)
                    {
                        MessageBox.Show(panel.Controls[a].Text);
                        return;
                    }
                    if (a % 3 == 1 && panel.Controls[a].Text == panel.Controls[a - 1].Text && panel.Controls[a].Text == panel.Controls[a + 1].Text)
                    {
                        MessageBox.Show(panel.Controls[a].Text);
                        return;
                    }
                    if (a % 3 == 2 && panel.Controls[a].Text == panel.Controls[a - 1].Text && panel.Controls[a].Text == panel.Controls[a - 2].Text)
                    {
                        MessageBox.Show(panel.Controls[a].Text);
                        return;
                    }

                    if (a / 3 == 0 && panel.Controls[a].Text == panel.Controls[a + 3].Text && panel.Controls[a].Text == panel.Controls[a + 6].Text)
                    {
                        MessageBox.Show(panel.Controls[a].Text);
                        return;
                    }
                    if (a / 3 == 1 && panel.Controls[a].Text == panel.Controls[a - 3].Text && panel.Controls[a].Text == panel.Controls[a + 3].Text)
                    {
                        MessageBox.Show(panel.Controls[a].Text);
                        return;
                    }
                    if (a / 3 == 2 && panel.Controls[a].Text == panel.Controls[a - 3].Text && panel.Controls[a].Text == panel.Controls[a - 6].Text)
                    {
                        MessageBox.Show(panel.Controls[a].Text);
                        return;
                    }

                    if (a % 4 == 0 && panel.Controls[0].Text == panel.Controls[4].Text && panel.Controls[0].Text == panel.Controls[8].Text)
                    {
                        MessageBox.Show(panel.Controls[0].Text);
                        return;
                    }
                    if (a % 2 == 0 && a != 0 && a != 8 && panel.Controls[2].Text == panel.Controls[4].Text && panel.Controls[2].Text == panel.Controls[6].Text)
                    {
                        MessageBox.Show(panel.Controls[2].Text);
                        return;
                    }

                };


                button.TabIndex = i;

                panel.Controls.Add(button);
            }

            panel.Size = new Size(sdxvf*3, sdxvf*3);

            this.Controls.Add(panel);
        }
        int sdxvf = 100;
    }
}
