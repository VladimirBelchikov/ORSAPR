using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hammer.MODEL;


namespace Hammer
{
    public partial class MainForm : Form
    {
        private readonly HammerParameters _hammerParameters;

        public MainForm()
        {
            InitializeComponent();

            _hammerParameters = new HammerParameters();
        }

        private void buildButton_Click(object sender, EventArgs e)
        {
            try
            {
                _hammerParameters.HandleParametrs.Length = int.Parse(HandleLengthTextBox.Text);
                _hammerParameters.HandleParametrs.Height = int.Parse(HandleHeightTextBox.Text);
                _hammerParameters.HandleParametrs.Width = int.Parse(HandleWidthTextBox.Text);
                _hammerParameters.HeadParametrs.Length = int.Parse(HeadLengthTextBox.Text);
                _hammerParameters.HeadParametrs.Width = int.Parse(HeadWidthTextBox.Text);
                _hammerParameters.HeadParametrs.TipWidth = int.Parse(TipWidthTextBox.Text);
                _hammerParameters.HeadParametrs.ToeLength = int.Parse(ToeLengthTextBox.Text);
                _hammerParameters.HeadParametrs.HoleDiameter = int.Parse(HoleDiameterTextBox.Text);


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
