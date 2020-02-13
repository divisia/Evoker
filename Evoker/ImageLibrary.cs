using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Timers;

namespace Evoker
{
    class ImageLibrary
    {
        private static int nowIndex { get; set; }
        private static List<string> files = new List<string>();
        private static Timer timer = new Timer();

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);

        public static void SetWallpaper(string wpPath)
        {
            const int SPI_SETDESKWALLPAPER = 20;
            const int SPIF_UPDATEINIFILE = 0x01;
            const int SPIF_SENDWININICHANGE = 0x02;

            
            var key = Registry.CurrentUser.OpenSubKey(@"Control Panel\Desktop", true);
            key.SetValue(@"WallpaperStyle", "1");
            key.SetValue(@"TileWallpaper", "0");

            SystemParametersInfo(SPI_SETDESKWALLPAPER,
            0,
            wpPath,
            SPIF_UPDATEINIFILE | SPIF_SENDWININICHANGE);
        }

        public static void LoadDynamicWallpapers(Rectangle resolution, string[] texts, Color frontColor, Color backColor, Font font, bool append=false, int interval=5)
        {
            string tempdir = Path.GetTempPath();
            if (!append) files.Clear();
            foreach (var txt in texts)
            {
                var fd = tempdir + txt + ".jpg";
                files.Add(fd);
                CreateWallpaper(resolution, txt, frontColor, backColor, font).Save(fd);
            }

            timer.Interval = interval * 1000 * 10;
            timer.Elapsed += new ElapsedEventHandler(DynamicHandler);
            timer.AutoReset = true;
            timer.Enabled = true;

            DynamicHandler(null, null);
        }

        private static void DynamicHandler(object sender, ElapsedEventArgs e)
        {
            nowIndex %= files.Count();
            var fd = files[nowIndex];
            nowIndex++;

            SetWallpaper(fd);
        }

        public static Image CreateWallpaper(Rectangle resolution, string text, Color frontColor, Color backColor, Font font, Boolean alignVertical = true)
        {
            var resx = resolution.Width;
            var resy = resolution.Height;
            var wp = new Bitmap(resx, resy);
            var graph = Graphics.FromImage(wp);
            var pen = new Pen(frontColor);
            var brush = new SolidBrush(frontColor);

            var punto = (resx + resy) / 2 * 150;
            var lineweight = punto / 10;

            graph.Clear(backColor);
            var tps = new Dictionary<string, Point>();

            tps[text] = new Point(resx / 2, resy / 2);
            PutTextOnImage(ref graph, tps, font, brush);

            return wp;
        }

        public static Image CreateWallpaper(Rectangle resolution, string[] texts, Color frontColor, Color backColor, Font font, Boolean alignVertical=true)
        {
            timer.Enabled = false;

            var resx = resolution.Width;
            var resy = resolution.Height;
            var wp = new Bitmap(resx, resy);
            var graph = Graphics.FromImage(wp);
            var pen = new Pen(frontColor);
            var brush = new SolidBrush(frontColor);

            var punto = (resx + resy) / 2 * 150;
            var lineweight = punto / 10;

            graph.Clear(backColor);
            var tps = new Dictionary<string, Point>();

            switch (texts.Length)
            {
                case 1:
                    tps[texts[0]] = new Point(resx / 2, resy / 2);
                    break;
                case 2:
                    if (alignVertical)
                    {
                        tps[texts[0]] = new Point(resx / 2, resy / 4);
                        tps[texts[1]] = new Point(resx / 2, resy * 3 / 4);
                    } else {
                        tps[texts[0]] = new Point(resx / 4, resy / 2);
                        tps[texts[1]] = new Point(resx *3 / 4, resy / 2);
                    }
                    break;
                case 4:
                    tps[texts[0]] = new Point(resx / 4, resy / 4);
                    tps[texts[1]] = new Point(resx * 3 / 4, resy / 4);
                    tps[texts[2]] = new Point(resx / 4, resy * 3 / 4);
                    tps[texts[3]] = new Point(resx * 3 / 4, resy *3 / 4);
                    break;

            }
            PutTextOnImage(ref graph, tps, font, brush);

            return wp;
        }

        private static Graphics PutTextOnImage(ref Graphics org, Dictionary<string, Point> values, Font font, Brush brush)
        {
            var sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
            var valuesCount = values.Count();
            if (valuesCount == 0 || valuesCount == 3 || valuesCount > 4)
            {
                throw new ArgumentException("Given dictionary's length is not suitable.");
            }
            foreach(var vi in values)
            {
                org.DrawString(vi.Key, font, brush, vi.Value, sf);
            }
            return org;
        }


    }
}
