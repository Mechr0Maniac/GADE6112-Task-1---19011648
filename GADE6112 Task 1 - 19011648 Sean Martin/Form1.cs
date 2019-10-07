using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GADE6112_Task_1___19011648_Sean_Martin
{
    public partial class Form1 : Form
    {
        GameEngine engine;
        public Form1()
        {
            InitializeComponent();
        }

        private void TmrRounds_Tick(object sender, EventArgs e)
        {
            lblRound.Text = "Round: " + engine.Round.ToString();
            engine.Update();
        }

        private void BtnControl_Click(object sender, EventArgs e)
        {
            if (tmrRounds.Enabled == false)
            {
                tmrRounds.Enabled = true;
                btnControl.Text = "Pause";
            }
            else
            {
                tmrRounds.Enabled = false;
                btnControl.Text = "Play";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            engine = new GameEngine(20, txtOut, gpbxMap);
        }
    }
}
