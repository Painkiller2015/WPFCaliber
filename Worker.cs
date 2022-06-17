using AutoItX3Lib;
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

namespace Caliber
{
    public class Worker
    {
        private readonly ILogger<Worker> _logger;
        private static GlobalHotKeyManager _hotKeyManager = new();
        private static byte[] _imageCaliber;
        static readonly int _maxCountResourses = Resourse.DictNumResources.Count;
        public static void StartProcessOpenCase(ResourseValue resourseValue)
        {
            OpenCase();
            Thread.Sleep(3500);

            PrintScreen printScreen = new();
            Image rectangleResourses = GetResourceRectangle(printScreen.Screen);

            string textOnScreen = GetTextOnRectangleResourse(rectangleResourses);

            ResoursesCollectionEng[] caseContain = GetContainResourses(textOnScreen);
            //List<Resourse> priority = GetPriority(resourseValue);

            IEnumerable<Resourse>? priority = Resourse.DictNumResources.OrderBy(res => res.Value).Select(el => el.Value);

            GetResourse(caseContain, priority, resourseValue);

            OpenCase();
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
            var img = Pix.LoadFromMemory(_imageCaliber);
            //var img = Pix.LoadFromFile("../test.png");
            var res = ocrengine.Process(img);
            return res.GetText();
        }
        private static ResoursesCollectionEng[] GetContainResourses(string inputString)
        {
            if (string.IsNullOrWhiteSpace(inputString))
            {
                return default;
            }

            ResoursesCollectionEng[] caseContain = new ResoursesCollectionEng[5];
            int[] arrayResoursePosition = new int[5];
            string sysLang = SysConfig.GetSystemLanguage();

            for (int resCell = 0, numResourses = 0; numResourses < _maxCountResourses; numResourses++)
            {
                string? resourseName = sysLang switch
                {
                    "rus" => ((ResoursesCollectionRus)numResourses).ToString(),
                    "eng" => ((ResoursesCollectionEng)numResourses).ToString(),
                    _ => null
                };

                if (string.IsNullOrEmpty(resourseName))
                    continue;

                int resoursesPosition = inputString.IndexOf(resourseName, StringComparison.OrdinalIgnoreCase);

                if (resoursesPosition != -1)
                {
                    arrayResoursePosition[resCell] = resoursesPosition;
                    caseContain[resCell] = (ResoursesCollectionEng)numResourses;
                    resCell++;
                }
            }
            Array.Sort(arrayResoursePosition, caseContain);
            return caseContain;
        }
        private static void GetResourse(ResoursesCollectionEng[] caseContain, IEnumerable<Resourse> priority, WPFCaliber.Value.ResourseValue resourseValue)
        {
            for (int i = 0; i < priority.Count(); i++)
            {
                for (int j = 0; j < caseContain.Length; j++)
                {
                    if (priority.ElementAt(i).Name == caseContain[j])
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
            int y = (int)(SysConfig.GetHeightScreen() / 1.6);
            int x = 0;

            switch (cell)
            {
                case 0:
                    x = (int)(SysConfig.GetWidthScreen() / 5);
                    break;
                case 1:
                    x = (int)(SysConfig.GetWidthScreen() / 2.8);
                    break;
                case 2:
                    x = (int)(SysConfig.GetWidthScreen() / 1.93);
                    break;
                case 3:
                    x = (int)(SysConfig.GetWidthScreen() / 1.5);
                    break;
                case 4:
                    x = (int)(SysConfig.GetWidthScreen() / 1.2);
                    break;
            }

            AutoItX3 takeCell = new();

            takeCell.MouseClick("LEFT", x, y);
        }
    }
}