using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using T5DuckClassLibrary;

namespace T5DuckForm
{
    public partial class Form1 : Form
    {
        Duck _duck;

        public Form1()
        {
            InitializeComponent();
        }

        private void rdoMallardDuck_CheckedChanged(object sender, EventArgs e)
        {
            _duck = new MallardDuck();
        }

        private void rdoRedHeadDuck_CheckedChanged(object sender, EventArgs e)
        {
            _duck = new RedHeadDuck();
        }

        private void rdoRubberDuck_CheckedChanged(object sender, EventArgs e)
        {
            _duck = new RubberDuck();
        }

        private void rdoDecoyDuck_CheckedChanged(object sender, EventArgs e)
        {
            _duck = new DecoyDuck();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = _duck.Display();
        }

        private void btnFly_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = _duck.PerformFly();
        }

        private void btnQuack_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = _duck.PerformQuack();
        }

        private void rdoNotChange_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void rdoFlyWithWings_CheckedChanged(object sender, EventArgs e)
        {
            _duck.SetFlyBehavior(new FlyWithWings());
        }

        private void rdoFlyNoWay_CheckedChanged(object sender, EventArgs e)
        {
            _duck.SetFlyBehavior(new FlyNoWay());
        }
    }
}
