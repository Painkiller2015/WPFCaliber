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

namespace WPFCaliber.Model
{
    public class Worker
    {
        private readonly ILogger<Worker> _logger;
        private static GlobalHotKeyManager _hotKeyManager = new();
        private static byte[] _imageCaliber;
        private static readonly int _maxCountResourses = Resourse.DictNumResources.Count;

        //TODO запускать StartProcessOpenCase по кнопке пуска
        public static void StartProcessOpenCase()
        {
            OpenCase();
            Thread.Sleep(3500);
            PrintScreen printScreen = new();
            Image rectangleResourses = GetResourceRectangle(printScreen.Screen);
            string textOnScreen = GetTextOnRectangleResourse(rectangleResourses);

            ResoursesCollectionEng[] caseContain = GetContainResourses(textOnScreen);

            GetResourse(caseContain);
            OpenCase();
            //TODO переделать на асинк
            Thread.Sleep(500);
        }
        private static void OpenCase()
        {
            int y = (int)(SysConfig.GetHeightScreen() / 1.23);
            int x = (int)(SysConfig.GetWidthScreen() / 1.2);

            AutoItX3 openCase = new();
            openCase.MouseClick("LEFT", x, y);
        }
        private static Image GetResourceRectangle(Image screen)
        {
            int x1 = 200;
            int y1 = (int)(screen.Height / 3.7);
            int with = screen.Width - 2 * x1;
            int height = 50;

            Rectangle rectangle = new(x1, y1, with, height);
            Bitmap pic = (Bitmap)screen;
            Bitmap temp = pic.Clone(rectangle, PixelFormat.Format8bppIndexed);
            //temp.Save("test.png", System.Drawing.Imaging.ImageFormat.Png);      

            using (MemoryStream memoryStream = new())
            {
                temp.Save(memoryStream, ImageFormat.Png);
                _imageCaliber = memoryStream.ToArray();
            }
            return pic;
        }

        private static string GetTextOnRectangleResourse(Image screen)
        {
            var ocrengine = new TesseractEngine(@"..\tessdata", SysConfig.GetSystemLanguage(), EngineMode.Default);
            Pix img = Pix.LoadFromMemory(_imageCaliber);
            Page res = ocrengine.Process(img);
            return res.GetText();
        }
        private static ResoursesCollectionEng[] GetContainResourses(string inputString)
        {
            if (string.IsNullOrWhiteSpace(inputString)) return default;

            ResoursesCollectionEng[] caseContain = new ResoursesCollectionEng[5];
            int[] arrayResoursePosition = new int[5];
            string sysLang = VMLoader.Resolve<LanguageSetterViewModel>().Language;

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
        private static void GetResourse(ResoursesCollectionEng[] caseContain)
        {
            foreach (var resourse in Resourse.DictNumResources)
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
        private static void GetCellById(int cell)
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