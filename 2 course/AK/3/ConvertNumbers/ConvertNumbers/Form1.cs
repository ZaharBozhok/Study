using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Management;
using System.Runtime.InteropServices;

namespace ConvertNumbers
{
    public partial class FormConvert : Form
    {
        // Наступна частина коду використовується для реалізації функції пересування вікна
        #region DragWindow
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion

        public FormConvert()
        {
            InitializeComponent();
        }

        // Обробник зміни даних елемента "TextBox"
        private void textBoxSource_TextChanged(object sender, EventArgs e)
        {
            int source = 0; // Локальна змінна, що утримує тимчасові дані під час переведення
            try
            {
                if (radioButton_Source2.Checked && !string.IsNullOrWhiteSpace(textBoxSource.Text))
                {
                    source = Convert.ToInt32(textBoxSource.Text, 2);
                    label2.Text = textBoxSource.Text + "\u2082" + "\u2B62";
                }
                else if (radioButton_Source8.Checked && !string.IsNullOrWhiteSpace(textBoxSource.Text))
                {
                    source = Convert.ToInt32(textBoxSource.Text, 8);
                    label2.Text = textBoxSource.Text + "\u2088" + "\u2B62";
                }
                else if (radioButton_Source10.Checked && !string.IsNullOrWhiteSpace(textBoxSource.Text))
                {
                    source = Convert.ToInt32(textBoxSource.Text);
                    label2.Text = textBoxSource.Text + "\u2081\u2080" + "\u2B62";
                }
                else if (radioButton_Source16.Checked && !string.IsNullOrWhiteSpace(textBoxSource.Text))
                {
                    source = Convert.ToInt32(textBoxSource.Text, 16);
                    label2.Text = textBoxSource.Text + "\u2081\u2086" + "\u2B62";
                }
                else
                {
                    textBoxResult.Text = "Виберіть параметри переводу та введіть число";
                    label2.Text = "Немає історії переведень";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Число завелике або введенні символи не є характерними для вибраної системи счислення");
            }

            try
            {
                if (radioButton_Result2.Checked && !string.IsNullOrWhiteSpace(textBoxSource.Text))
                {
                    textBoxResult.Text = Convert.ToString(source, 2);
                    label2.Text += textBoxResult.Text + "\u2082";
                }
                else if (radioButton_Result8.Checked && !string.IsNullOrWhiteSpace(textBoxSource.Text))
                {
                    textBoxResult.Text = Convert.ToString(source, 8);
                    label2.Text += textBoxResult.Text + "\u2088";
                }
                else if (radioButton_Result10.Checked && !string.IsNullOrWhiteSpace(textBoxSource.Text))
                {
                    textBoxResult.Text = Convert.ToString(source);
                    label2.Text += textBoxResult.Text + "\u2081\u2080";
                }
                else if (radioButton_Result16.Checked && !string.IsNullOrWhiteSpace(textBoxSource.Text))
                {
                    textBoxResult.Text = Convert.ToString(source, 16);
                    label2.Text += textBoxResult.Text + "\u2081\u2086";
                }
                else textBoxResult.Text = "Виберіть параметри переводу та введіть число";
            }
            catch (Exception exc)
            {
                MessageBox.Show(Convert.ToString(exc));
            }
        }

        // Реалізація функції пересування вікна
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void FormConvert_Load(object sender, EventArgs e)
        {

        }
    }
}
