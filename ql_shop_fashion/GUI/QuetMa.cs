using AForge.Video.DirectShow;
using System;
using System.Drawing;
using System.Windows.Forms;
using ZXing;

namespace GUI
{
    public partial class QuetMa : Form
    {
        
        public event EventHandler<string> NumberSubmitted;
        public QuetMa()
        {
            InitializeComponent();
            this.Load += QuetMa_Load1;
        }

        private void QuetMa_Load1(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(filter[2].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
            timer1.Start();
        }

        // Phương thức tĩnh để lấy hoặc tạo thể hiện duy nhất của QuetMa



        FilterInfoCollection filter;
        VideoCaptureDevice captureDevice;

        private void QuetMa_Load(object sender, EventArgs e)
        {
            this.FormClosing += QuetMa_FormClosing;
            filter = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filter)
            {
                cboCam.Items.Add(filterInfo.Name);
            }
            cboCam.SelectedIndex = 0;
        }

        private void QuetMa_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (captureDevice != null && captureDevice.IsRunning)
            {
                captureDevice.Stop();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //captureDevice = new VideoCaptureDevice(filter[cboCam.SelectedIndex].MonikerString);
            //captureDevice.NewFrame += CaptureDevice_NewFrame;
            //captureDevice.Start();
            //timer1.Start();
        }

        private void CaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            picHinh.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (picHinh.Image != null)
            {
                BarcodeReader barcode = new BarcodeReader();
                Result result = barcode.Decode((Bitmap)picHinh.Image);
                if (result != null)
                {
                    txtMa.Text = result.ToString();
                    timer1.Stop(); // Ngừng timer để tránh quét lại mã liên tục

                    if (captureDevice.IsRunning)
                    {
                        captureDevice.Stop();
                        NumberSubmitted?.Invoke(this, result.ToString());
                        this.Close();
                        // Lấy hoặc hiển thị form BanHang duy nhất với mã sản phẩm mới
                        //var banHangForm = BanHang.GetInstance(result.ToString());
                        //banHangForm.Show();
                        //banHangForm.Focus(); // Đưa form lên phía trước nếu đã tồn tại
                    }
                }
            }
        }
    }
}
