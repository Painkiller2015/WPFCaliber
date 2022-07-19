using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Tesseract;
using System.Linq;
using ImageFormat = System.Drawing.Imaging.ImageFormat;
using WPFCaliber.Value;
using Caliber.ViewModels;
using Caliber;
using System.Runtime.InteropServices;
using AutoItX3Lib;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Page = Tesseract.Page;
using System.Diagnostics;

namespace WPFCaliber.Model
{
    public class Worker : ISingleton
    {
        private static GlobalHotKeyManager _hotKeyManager = new();
        private static byte[] _imageCaliber;
        private static readonly int _maxCountResourses = Resourse.DictNumResources.Count;
        public bool StartProcess { get; set; }
        private GlobalHotKeyManager _GHKManager = new();
        private static CancellationTokenSource? sourse = null;

        public Worker()
        {
            _GHKManager.StatusProcessEvent += async (obj, status) =>
             {
                 StartProcess = status;

                 if (StartProcess)
                 {
                     Debug.WriteLine("startProcess");
                     if (sourse == null)
                     {
                         Debug.WriteLine("startProcess and sourse == null");
                         sourse = new CancellationTokenSource();
                         await Task.Run(() => StartProcessOpenCase(), sourse.Token);
                     }
                 }
                 else
                 {
                     Debug.WriteLine("stopProcess");
                     if (sourse != null)
                     {
                         Debug.WriteLine("deleteSourse");

                         sourse.Cancel();
                         sourse = null;
                     }
                 }
             };
        }

        public async Task StartProcessOpenCase()
        {
            while (StartProcess)
            {
                OpenCase();
                Thread.Sleep(3500);
                Image rectangleResourses = GetResourceRectangle(new PrintScreen().Screen);
                string textOnScreen = GetTextOnRectangleResourse(rectangleResourses);

                ResoursesCollectionEng[] caseContain = GetContainResourses(textOnScreen);

                GetResourse(caseContain);
                OpenCase();
                Thread.Sleep(500);

                //TODO переделать
                Priority.UpdateData();
            }
        }
        private void OpenCase()
        {
            int y = (int)(SysConfig.GetHeightScreen() / 1.23);
            int x = (int)(SysConfig.GetWidthScreen() / 1.2);

            AutoItX3 openCase = new();
            openCase.MouseClick("LEFT", x, y);
        }
        private Image GetResourceRectangle(Image screen)
        {
            int x1 = 200;
            int y1 = (int)(screen.Height / 3.7);
            int with = screen.Width - 2 * x1;
            int height = 50;

            Rectangle rectangle = new(x1, y1, with, height);
            Bitmap pic = (Bitmap)screen;
            Bitmap temp = pic.Clone(rectangle, PixelFormat.Format8bppIndexed);
            temp.Save("test.png", ImageFormat.Png);

            using (MemoryStream memoryStream = new())
            {
                temp.Save(memoryStream, ImageFormat.Png);
                _imageCaliber = memoryStream.ToArray();
            }
            return pic;
        }
        private string GetTextOnRectangleResourse(Image screen)
        {
            string language = VMLoader.Resolve<LanguageSetterViewModel>().SelectLanguage;

            string tessPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "tessdata");

            using (TesseractEngine ocrengine = new(tessPath, language, EngineMode.Default))
            {
                Pix img = Pix.LoadFromMemory(_imageCaliber);

                Page res = ocrengine.Process(img);
                return res.GetText();
            }
        }
        private ResoursesCollectionEng[] GetContainResourses(string inputString)
        {
            if (string.IsNullOrWhiteSpace(inputString)) return default;

            ResoursesCollectionEng[] caseContain = new ResoursesCollectionEng[5];
            int[] arrayResoursePosition = new int[5];
            string sysLang = VMLoader.Resolve<LanguageSetterViewModel>().SelectLanguage;

            for (int resCell = 0, numResourses = 0; numResourses < _maxCountResourses; numResourses++)
            {
                string? resourseName = sysLang switch
                {
                    "rus" => ((ResoursesCollectionRus)numResourses).ToString(),
                    "eng" => ((ResoursesCollectionEng)numResourses).ToString(),
                    _ => null
                };

                if (string.IsNullOrEmpty(resourseName)) continue;

                int resoursesPosition = inputString.IndexOf(resourseName, StringComparison.OrdinalIgnoreCase);

                if (resoursesPosition == -1) continue;

                arrayResoursePosition[resCell] = resoursesPosition;
                caseContain[resCell] = (ResoursesCollectionEng)numResourses;
                resCell++;
            }
            Array.Sort(arrayResoursePosition, caseContain);
            return caseContain;
        }
        private void GetResourse(ResoursesCollectionEng[] caseContain)
        {
            foreach (var resourse in Resourse.DictNumResources.OrderBy(el => el.Value.Priority))
            {
                for (int j = 0; j < caseContain.Length; j++)
                {
                    if (resourse.Value.Name == caseContain[j])
                    {
                        GetCellById(j);
                        goto LoopEnd;
                    }
                }
            }
        LoopEnd:;
        }
        private void GetCellById(int cell)
        {
            int height = (int)(SysConfig.GetHeightScreen() / 1.6);
            int width = SysConfig.GetWidthScreen();

            width = cell switch
            {
                0 => width = width / 5,
                1 => width = (int)(width / 2.8),
                2 => width = (int)(width / 1.93),
                3 => width = (int)(width / 1.5),
                4 => width = (int)(width / 1.2),
                _ => throw new Exception("не верный номер €чейки")
            };

            AutoItX3 takeCell = new();
            takeCell.MouseClick("LEFT", width, height);
        }
    }
}