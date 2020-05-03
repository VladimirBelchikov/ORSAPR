using System;
using System.Windows.Forms;
using Hammer.MODEL;


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

                _hammerBuilder.CreateHammer();

                
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        /// <summary>
        /// Очиста всех TextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearEditLinesButton_Click(object sender, EventArgs e)
        {
            HeadLengthTextBox.Clear();
            HeadWidthTextBox.Clear();
            HoleDiameterTextBox.Clear();
            TipWidthTextBox.Clear();
            ToeLengthTextBox.Clear();
            HandleHeightTextBox.Clear();
            HandleLengthTextBox.Clear();
            HandleWidthTextBox.Clear();
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
        private void startSolidWorksButton_Click(object sender, EventArgs e)
        {
            _hammerBuilder.OpenSolidWorks();
        }
        // ТЕСТОВАЯ КНОПКА, УДАЛИТЬ!
        private void TESTBUTTON_Click(object sender, EventArgs e)
        {
            HeadLengthTextBox.Text = "60";
            HeadWidthTextBox.Text = "30";
            HoleDiameterTextBox.Text = "20";
            TipWidthTextBox.Text = "1";
            ToeLengthTextBox.Text = "50";
            HandleHeightTextBox.Text = "140";
            HandleLengthTextBox.Text = "30";
            HandleWidthTextBox.Text = "20";
        }
    }
}
