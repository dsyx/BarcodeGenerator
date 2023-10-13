using ZXing;
using ZXing.Common;
using ZXing.Windows.Compatibility;

namespace BarcodeGenerator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            _barcodeFormatMap = new Dictionary<string, BarcodeFormat> {
                {"Aztec Code", BarcodeFormat.AZTEC},
                {"Codabar", BarcodeFormat.CODABAR},
                {"Code 39", BarcodeFormat.CODE_39},
                {"Code 93", BarcodeFormat.CODE_93},
                {"Code 128", BarcodeFormat.CODE_128},
                {"Data Matrix", BarcodeFormat.DATA_MATRIX},
                {"EAN-8", BarcodeFormat.EAN_8},
                {"EAN-13", BarcodeFormat.EAN_13},
                {"ITF", BarcodeFormat.ITF},
                {"MaxiCode", BarcodeFormat.MAXICODE},
                {"PDF417", BarcodeFormat.PDF_417},
                {"QR Code", BarcodeFormat.QR_CODE},
                {"RSS 14", BarcodeFormat.RSS_14},
                {"RSS EXPANDED", BarcodeFormat.RSS_EXPANDED},
                {"UPC-A", BarcodeFormat.UPC_A},
                {"UPC-E", BarcodeFormat.UPC_E},
                {"UPC/EAN Extension", BarcodeFormat.UPC_EAN_EXTENSION},
                {"MSI", BarcodeFormat.MSI},
                {"Plessey Code", BarcodeFormat.PLESSEY},
                {"IMb", BarcodeFormat.IMB},
                {"Pharmacode", BarcodeFormat.PHARMA_CODE},
            };

            _barcodeFormatComboBox.Items.AddRange(_barcodeFormatMap.Keys.ToArray());
            _barcodeFormatComboBox.SelectedIndex = 0;

            _barcodeWidthTextBox.Text = "200";
            _barcodeHeightTextBox.Text = "200";
        }

        private void HandleGenerateButtonClicked(object sender, EventArgs e)
        {
            string data = _textBox.Text.Trim();

            if (string.IsNullOrEmpty(data))
            {
                MessageBox.Show("Data used to generate barcode is empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int width = int.Parse(_barcodeWidthTextBox.Text);
                int height = int.Parse(_barcodeHeightTextBox.Text);
                BarcodeFormat format = _barcodeFormatMap[key: (string)_barcodeFormatComboBox.SelectedItem];

                BarcodeWriter writer = new()
                {
                    Format = format,
                    Options = new EncodingOptions
                    {
                        Width = width,
                        Height = height,
                    }
                };
                Bitmap bitmap = writer.Write(data);
                _previewBox.Image = bitmap;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private readonly Dictionary<string, BarcodeFormat> _barcodeFormatMap;
    }
}
