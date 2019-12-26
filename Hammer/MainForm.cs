using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hammer
{
    public partial class MainForm : Form
    {
        public HammerParameters _hammerParameters;
        public MainForm()
        {
            InitializeComponent();
        }

        private void buildButton_Click(object sender, EventArgs e)
        {
            try
            {
                _hammerParameters.Param1 = int.Parse(Param1textBox.Text);
                _hammerParameters.Param2 = int.Parse(Param2textBox.Text);
                _hammerParameters.Param3 = int.Parse(Param3textBox.Text);
                _hammerParameters.Param4 = int.Parse(Param4textBox.Text);
                _hammerParameters.Param5 = int.Parse(Param5textBox.Text);
                _hammerParameters.Param6 = int.Parse(Param6textBox.Text);
                _hammerParameters.Param7 = int.Parse(Param7textBox.Text);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
