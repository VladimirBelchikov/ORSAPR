using System;
using System.Windows.Forms;
using Hammer.MODEL;
using Hammer.MODEL.Exceptions;
using Hammer.MODEL.Models;


namespace Hammer
{
    public partial class MainForm : Form
    {
        private readonly HammerParameters _hammerParameters;
        private readonly HammerBuilder _hammerBuilder;

        public MainForm()
        {
            InitializeComponent();

            _hammerParameters = new HammerParameters();
            _hammerBuilder = new HammerBuilder(_hammerParameters);
        }

        private void BuildButton_Click(object sender, EventArgs e)
        {
            try
            {
                _hammerParameters.HandleParameters.Length = int.Parse(HandleLengthTextBox.Text);
                _hammerParameters.HandleParameters.Diameter = int.Parse(HandleDiameterTextBox.Text);
                _hammerParameters.HeadParameters.Length = int.Parse(HeadLengthTextBox.Text);
                _hammerParameters.HeadParameters.Width = int.Parse(HeadWidthTextBox.Text);
                _hammerParameters.HeadParameters.TipWidth = int.Parse(TipWidthTextBox.Text);
                _hammerParameters.HeadParameters.ToeLength = int.Parse(ToeLengthTextBox.Text);
                _hammerParameters.HeadParameters.Height = int.Parse(HeadHeightTextBox.Text);

                var validatorParameters = new ValidatorParameters(_hammerParameters);

                validatorParameters.CheckParametersHead();
                validatorParameters.CheckParametersHandle();

                _hammerBuilder.CreateHammer();
            }
            catch (ParametersExceptions exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        /// <summary>
        /// Очиста всех TextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearEditLinesButton_Click(object sender, EventArgs e)
        {
            HeadLengthTextBox.Clear();
            HeadWidthTextBox.Clear();
            TipWidthTextBox.Clear();
            ToeLengthTextBox.Clear();
            HeadHeightTextBox.Clear();
            HandleLengthTextBox.Clear();
            HandleDiameterTextBox.Clear();
        }

        /// <summary>
        /// Запрет на ввод любых символов, кроме цифр
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 58) && e.KeyChar != 8)
                e.Handled = true;
        }

        /// <summary>
        /// Запуск программы SolidWorks
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartSolidWorksButton_Click(object sender, EventArgs e)
        {
            _hammerBuilder.OpenSolidWorks();
        }

        // ТЕСТОВАЯ КНОПКА, УДАЛИТЬ!
        private void TESTBUTTON_Click(object sender, EventArgs e)
        {
            HeadLengthTextBox.Text = "60";
            HeadWidthTextBox.Text = "30";
            HeadHeightTextBox.Text = "30";
            TipWidthTextBox.Text = "2";
            ToeLengthTextBox.Text = "50";
            HandleLengthTextBox.Text = "130";
            HandleDiameterTextBox.Text = "20";
        }
    }
}
