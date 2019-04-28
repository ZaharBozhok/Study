using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Management;
using System.Runtime.InteropServices;

namespace PC_AIDA64
{
    public partial class AIDA_LIGHT : Form
    {
        //Наступна частина коду використовується для реалізації функції пересування вікна
        #region DragWindow
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion

        public AIDA_LIGHT()
        {
            InitializeComponent();
        }

        //Визначення параметрів операційної системи за натиском кнопки
        private void buttonOS_Click(object sender, EventArgs e)
        {
            textBoxInfo.Text = "";
            InfoOS();
        }

        //Визначення параметрів CPU за натиском кнопки
        private void buttonCPU_Click(object sender, EventArgs e)
        {
            textBoxInfo.Text = "";
            InfoCPU();
        }

        //Визначення параметрів графічного процесора за натиском кнопки
        private void buttonGPU_Click(object sender, EventArgs e)
        {
            textBoxInfo.Text = "";
            InfoGPU();
        }

        //Визначення параметрів носіїв даних за натиском кнопки
        private void buttonHDD_Click(object sender, EventArgs e)
        {
            textBoxInfo.Text = "";
            InfoHDD();
        }

        //Визначення параметрів модулів оперативної пам'яті за натиском кнопки
        private void buttonRAM_Click(object sender, EventArgs e)
        {
            textBoxInfo.Text = "";
            InfoRAM();
        }

        //Виведення загальної інформації про ПК за натиском кнопки
        private void buttonAll_Click(object sender, EventArgs e)
        {
            textBoxInfo.Text = "";
            InfoOS();
            textBoxInfo.Text += Environment.NewLine + Environment.NewLine;
            InfoCPU();
            textBoxInfo.Text += Environment.NewLine + Environment.NewLine;
            InfoGPU();
            textBoxInfo.Text += Environment.NewLine;
            InfoHDD();
            textBoxInfo.Text += Environment.NewLine;
            InfoRAM();
        }

        //Виклик вікна з інформацією про розробника
        private void buttonDeveloper_Click(object sender, EventArgs e)
        {
            List<string> about = new List<string>() { "Соболевський Іван", "студент групи 123-17-1", "Національний технічний університет ", "'Дніпровська політехніка'" };
            string aboutInfo = "";
            foreach (string aboutString in about)
            {
                aboutInfo += aboutString + '\n';
            }
            MessageBox.Show(aboutInfo);
        }

        void InfoOS()
        {
            textBoxInfo.Text += "Інформація про ОС:" + Environment.NewLine;
            ManagementObjectSearcher OperatingSystem = new ManagementObjectSearcher //ініціалізація нової колекції керуючих елементів 
            ("SELECT  BuildNumber, Version, RegisteredUser,OSArchitecture, Caption, CSName FROM Win32_OperatingSystem"); // WMI - запит

            foreach (ManagementObject queryObj in OperatingSystem.Get())
            {
                textBoxInfo.Text += Environment.NewLine + string.Format("Назва: {0}", queryObj["Caption"]);
                textBoxInfo.Text += Environment.NewLine + string.Format("Архітектура: {0}", queryObj["OSArchitecture"]);
                textBoxInfo.Text += Environment.NewLine + string.Format("Версія: {0}", queryObj["Version"]);
                textBoxInfo.Text += Environment.NewLine + string.Format("Номер збірки: {0}", queryObj["BuildNumber"]);
                textBoxInfo.Text += Environment.NewLine + string.Format("Ім'я комп'ютера: {0}", queryObj["CSName"]);
                textBoxInfo.Text += Environment.NewLine + string.Format("Користувач: {0}", queryObj["RegisteredUser"]);
            }
        }

        void InfoCPU()
        {
            textBoxInfo.Text += "Інформація про ЦП:" + Environment.NewLine;
            ManagementObjectSearcher Processor = new ManagementObjectSearcher
             ("SELECT NumberOfLogicalProcessors, NumberOfCores,Manufacturer,Description,CurrentClockSpeed FROM Win32_Processor");

            foreach (ManagementObject queryObj in Processor.Get())
            {
                textBoxInfo.Text += Environment.NewLine + string.Format("Виробник: {0}", queryObj["Manufacturer"]);
                textBoxInfo.Text += Environment.NewLine + string.Format("Модель: {0}", queryObj["Description"]);
                textBoxInfo.Text += Environment.NewLine + string.Format("Тактова частота : {0}", queryObj["CurrentClockSpeed"]) + " МГц";
                textBoxInfo.Text += Environment.NewLine + string.Format("Кількість ядер: {0}", queryObj["NumberOfCores"]);
                textBoxInfo.Text += Environment.NewLine + string.Format("Кількість логічних процесорів: {0}", queryObj["NumberOfLogicalProcessors"]);
            }
        }

        void InfoGPU()
        {
            textBoxInfo.Text += "Інформація про відеоадаптер:" + Environment.NewLine;
            ManagementObjectSearcher VideoAdapter = new ManagementObjectSearcher
                   ("SELECT Caption, VideoProcessor,AdapterDACType,AdapterRAM  FROM Win32_VideoController");
            foreach (ManagementObject queryObj in VideoAdapter.Get())
            {
                textBoxInfo.Text += Environment.NewLine + string.Format("Модель: {0}", queryObj["Caption"]);
                textBoxInfo.Text += Environment.NewLine + string.Format("Графічний процесор: {0}", queryObj["VideoProcessor"]);
                textBoxInfo.Text += Environment.NewLine + string.Format("Тип адаптера: {0}", queryObj["AdapterDACType"]);
                textBoxInfo.Text += Environment.NewLine + string.Format("Розмір графічної пам'яті: {0}",
                Math.Round(System.Convert.ToDouble(queryObj["AdapterRAM"]) / 1024 / 1024, 2)) + " Мб";
                textBoxInfo.Text += Environment.NewLine;
            }
        }

        void InfoHDD()
        {
            textBoxInfo.Text += "Інформація про ЖД:" + Environment.NewLine;
            ManagementObjectSearcher DiskDrive = new ManagementObjectSearcher
                ("SELECT Manufacturer,Model,InterfaceType,Size,MediaType FROM Win32_DiskDrive");

            foreach (ManagementObject queryObj in DiskDrive.Get())
            {
                textBoxInfo.Text += Environment.NewLine + string.Format("Виробник: {0}", queryObj["Manufacturer"]);
                textBoxInfo.Text += Environment.NewLine + string.Format("Модель: {0}", queryObj["Model"]);
                textBoxInfo.Text += Environment.NewLine + string.Format("Тип інтерфейсу: {0}", queryObj["InterfaceType"]);
                textBoxInfo.Text += Environment.NewLine + string.Format("Розмір: {0}",
                Math.Round(System.Convert.ToDouble(queryObj["Size"]) / 1024 / 1024 / 1024, 2)) + " Гб";
                textBoxInfo.Text += Environment.NewLine + string.Format("Тип носія: {0}", queryObj["MediaType"]);
                textBoxInfo.Text += Environment.NewLine;
            }
        }

        void InfoRAM()
        {
            textBoxInfo.Text += "Інформація про ОЗП:" + Environment.NewLine;
            ManagementObjectSearcher PhysicalMemory = new ManagementObjectSearcher
    ("SELECT Manufacturer,Capacity,Speed,Description FROM Win32_PhysicalMemory");

            foreach (ManagementObject queryObj in PhysicalMemory.Get())
            {
                textBoxInfo.Text += Environment.NewLine + string.Format("Опис: {0}", queryObj["Description"]);
                textBoxInfo.Text += Environment.NewLine + string.Format("Виробник: {0}", queryObj["Manufacturer"]);
                textBoxInfo.Text += Environment.NewLine + string.Format("Ємність: {0}",
                Math.Round(System.Convert.ToDouble(queryObj["Capacity"]) / 1024 / 1024, 2)) + " Мб";
                textBoxInfo.Text += Environment.NewLine + string.Format("Швидкість пам'яті: {0}", queryObj["Speed"]) + " MT/s";
                textBoxInfo.Text += Environment.NewLine;
            }
        }

        //Реалізація функції пересування вікна
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxInfo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
