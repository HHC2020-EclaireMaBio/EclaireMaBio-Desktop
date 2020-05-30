using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Tesseract;


namespace BioDiag.Pages
{
    /// <summary>
    /// Logique d'interaction pour DragDropAnalysisPage.xaml
    /// </summary>
    public partial class DragDropAnalysisPage : System.Windows.Controls.Page
    {
        public DragDropAnalysisPage()
        {
            InitializeComponent();
            // ExtractTextFromPdf();
        }

        private void AnalysisDropped(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                if (files.Length > 1)
                {
                    DebugTextBlock.Text = $"Too many files dropped at once ({files.Length})";
                }
                else if (files.Length == 0)
                {
                    DebugTextBlock.Text = "No file dropped";
                }
                else
                {
                    DropBoxTextBlock.Text = files[0];
                    ExtractTextFromPdf(files[0]);
                }
            }
        }

        private void TakePicture_OnClick(object sender, RoutedEventArgs e)
        {
            // ToDo : Make cam work.
            DebugTextBlock.Text = "Take picture";
        }

        private void ExtractTextFromPdf(string pathtofile)
        {
            if (!File.Exists(pathtofile))
            {
                Console.WriteLine($"ERROR : File does not exist at path {pathtofile}");
            }

            //var myImg = @"C:\Users\jbeaudaux\Desktop\BioDagtic\input-sample-image.png";
            //var myImg = @"C:\Users\jbeaudaux\Desktop\BioDagtic\exemple1_nopwd-1.png";
            var myImg = @"C:\Users\jbeaudaux\Desktop\BioDagtic\exemple1_nopwd.pdf";
            var ocrEngine = new TesseractEngine(@"C:\Users\jbeaudaux\Desktop\BioDagtic\tessdata", "fra", EngineMode.Default);

            // ToDo : Filtrage (augmentation du contraste)
            // im = im.filter(ImageFilter.MedianFilter())
            // enhancer = ImageEnhance.Contrast(im)
            // im = enhancer.enhance(2)
            // im = im.convert('1')


            using (var imageWithText = Pix.LoadFromFile(myImg))
            {
                using (var page = ocrEngine.Process(imageWithText))
                {
                    var text = page.GetText();
                    //DebugBox.Text += text;
                }
            }

            //var ocrtext = string.Empty;
            //using (var engine = new TesseractEngine(@"./tessdata", "eng", EngineMode.Default))
            //{
            //    var myImg = Tesseract.

            //    using (var page = engine.Process(img))
            //    {
            //        ocrtext = page.GetText();
            //    }
            //    PixConverter.ToPix()

            //    using (var img = PixConverter.ToPix(imgsource))
            //    {

            //    }
            //}

        }
    }
}
