using System;
using System.Windows.Forms;
using Hammer.MODEL.Models;
using Hammer.MODEL.Parameters;


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

        /// <summary>
        /// Кнопка, вызывающая методы построения модели
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BuildButton_Click(object sender, EventArgs e)
        {
            try
            {
                _hammerParameters.HeadParameters.Width = double.Parse(HeadWidthTextBox.Text);
                _hammerParameters.HeadParameters.Length = double.Parse(HeadLengthTextBox.Text);
                _hammerParameters.HeadParameters.Height = double.Parse(HeadHeightTextBox.Text);
                _hammerParameters.HeadParameters.ToeLength = double.Parse(ToeLengthTextBox.Text);
                _hammerParameters.HeadParameters.TipWidth = double.Parse(TipWidthTextBox.Text);
                _hammerParameters.HandleParameters.Diameter = double.Parse(HandleDiameterTextBox.Text);
                _hammerParameters.HandleParameters.Length = double.Parse(HandleLengthTextBox.Text);

                var validatorParameters = new ParametersValidator(_hammerParameters);
                validatorParameters.CheckParameters();
                
                if (HeadCheckBox.Checked)
                {
                    _hammerBuilder.CreateHammerWithPeenHead();
                }
                else
                {
                    _hammerBuilder.CreateHammerWithToeHead();
                }
            }
            catch(ArgumentException message)
            {
                MessageBox.Show(message.Message, "OutOfRange", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //  MessageBox.Show(_parametersValidator.ExceptionMessage, "OutOfRange", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Очиста всех TextBox полей
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
        /// Запрет на ввод любых символов, кроме цифр, клавиши Backspace и запятой
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 44 && e.KeyChar != 8)
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

        /// <summary>
        /// Проверка чекбокса
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HeadCheckBox_CheckedChanged(object sender, EventArgs e)
        {

            if (HeadCheckBox.Checked)
            {
                _hammerParameters.Denominator = 2;
                ToeLengthTextBox.Enabled = false;
                TipWidthTextBox.Enabled = false;
            }
            else
            {
                _hammerParameters.Denominator = 4;
                ToeLengthTextBox.Enabled = true;
                TipWidthTextBox.Enabled = true;
            }
        }


        // ТЕСТОВАЯ КНОПКА, УДАЛЮ НА РЕЛИЗЕ!
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
