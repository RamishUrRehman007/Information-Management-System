using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace PasswordManagement
{
    public partial class SplashScreen : Form
    {
        List<Color> colors = new List<Color>();
        int currentcolor = 0, a = 0;
        public SplashScreen()
        {
            InitializeComponent();
            colors.Add(Color.FromArgb(3, 169, 244));
            colors.Add(Color.FromArgb(102, 45, 144));
            colors.Add(Color.FromArgb(66, 115, 164));
            colors.Add(Color.FromArgb(53, 181, 90));
            colors.Add(Color.FromArgb(255, 255, 255));
            colors.Add(Color.FromArgb(102, 45, 144));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            if (currentcolor < colors.Count - 1)
            {
                this.BackColor = Bunifu.Framework.UI.BunifuColorTransition.getColorScale(a, colors[currentcolor], colors[currentcolor + 1]);
                if (a < 100)
                {
                    a++;
                }
                else
                {
                    a = 0;
                    currentcolor++;
                }
                timer1.Enabled = true;
            }
            if (currentcolor == 2)
            {
            }

            if (timer1.Enabled == false)
            {
                this.Hide();
                UserDashboard UD = new UserDashboard();
                UD.Show();
            }
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
           
        }
    }
}
