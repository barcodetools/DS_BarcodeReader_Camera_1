using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            axBarcodeDecoder1.AboutBox();
        }

        void OnBarcodeIn(object sender, AxBarcodeReaderLib._IReaderEvents_BarcodeInEvent e)
        {
            textBox1.Text = e.barcode;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //axBarcodeDecoder1.SetProperty("VideoDelayAfterDec", 300);
            //axBarcodeDecoder1.SetProperty("VideoStretch", 1);
            //axBarcodeDecoder1.SetProperty("VideoBeep", 0);
            //axBarcodeDecoder1.VideoStart(0, 170, 120);

            AxBarcodeReaderLib._IReaderEvents_BarcodeInEventHandler barcodeIn = new AxBarcodeReaderLib._IReaderEvents_BarcodeInEventHandler(OnBarcodeIn);
            axBarcodeDecoder1.BarcodeIn += barcodeIn;

            axBarcodeDecoder1.SetProperty("LinearVerify", true);
            axBarcodeDecoder1.ShowImage = true;
            //axBarcodeDecoder1.BarcodeTypes |= (int)BarcodeReaderLib.EBarcodeTypes.DataMatrix;
            axBarcodeDecoder1.VideoStart(0, 0, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            axBarcodeDecoder1.VideoStop();
        }

    }
}
