using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DaWae.Scripts
{
    
    public partial class Design
    {
        int left = 50; //Смещение панелей из-за уменьшенного размера формы (дефолт ширины формы = 900, дефолт left = 0)
        public void ResetPersonalAccountPanel(ref Panel panel)
        {
            panel.Width = 650;
            panel.Height = 350;
        }
        public void centerPanel(ref Panel panel, int height, int width) //Центрировать панель
        {
            panel.Left = (width / 2) - (panel.Width/2);
            panel.Top = (height / 2) - (panel.Height/2);
            //panel.Width = 200;
            //panel.Height = 272;
        }
        public void ResetRegisterPanel(ref Panel panel)
        {
            panel.Left = 300 - left;
            panel.Top = 70;
            panel.Width = 300;
            panel.Height = 300;
        }
        public void ResetSigninPanel(ref Panel panel)
        {
            panel.Left = 290;
            panel.Top = 90;
            panel.Width = 214;
            panel.Height = 266;
        }
        public Bitmap AlphaBlending(Bitmap x, Bitmap y, byte s) // Для правильного рендера скина с !альфа каналом! Наложение двух картинок с альфа каналом.
        {
            if (x == null || y == null)
                throw new NullReferenceException();

            Bitmap bmp = new Bitmap(
                Math.Min(x.Width, y.Width),
                Math.Min(x.Height, y.Height),
                PixelFormat.Format24bppRgb
                );

            Color clr0, clr1;

            for (int _x = 0; _x < bmp.Width; _x++)
                for (int _y = 0; _y < bmp.Height; _y++)
                {
                    clr0 = x.GetPixel(_x, _y);
                    clr1 = y.GetPixel(_x, _y);
                    //MessageBox.Show($"x{_x} y{_y} = {clr0}\r\nx{_x} y{_y} = {clr1}");
                    if (clr1.R != 0 && clr1.G != 0 && clr1.B != 0)
                    {
                        bmp.SetPixel(_x, _y,
                            Color.FromArgb(
                                Math.Min(255, clr0.R * (255 - s) / 255 + clr1.R * s / 255),
                                Math.Min(255, clr0.G * (255 - s) / 255 + clr1.G * s / 255),
                                Math.Min(255, clr0.B * (255 - s) / 255 + clr1.B * s / 255)
                            )
                        );
                    }
                    else
                    {
                        bmp.SetPixel(_x, _y,
                            Color.FromArgb(
                                Math.Min(255, clr0.R * (255 - 0) / 255 + clr1.R * 0 / 255),
                                Math.Min(255, clr0.G * (255 - 0) / 255 + clr1.G * 0 / 255),
                                Math.Min(255, clr0.B * (255 - 0) / 255 + clr1.B * 0 / 255)
                            )
                        );
                    }
                }
            return bmp;
        }
        public Bitmap CreateImage(int Width, int Height, ref string text)
        {
            Random rnd = new Random();

            //Создадим изображение
            Bitmap result = new Bitmap(Width, Height);

            //Вычислим позицию текста
            int Xpos = rnd.Next(0, Width - 50);
            int Ypos = rnd.Next(15, Height - 15);

            //Добавим различные цвета
            Brush[] colors = { Brushes.Black,
                     Brushes.Red,
                     Brushes.RoyalBlue,
                     Brushes.Green };

            //Укажем где рисовать
            Graphics g = Graphics.FromImage((Image)result);

            //Пусть фон картинки будет серым
            g.Clear(Color.Gray);

            //Сгенерируем текст
            text = String.Empty;
            string ALF = "1234567890QWERTYUIOPASDFGHJKLZXCVBNM";
            for (int i = 0; i < 5; ++i)
                text += ALF[rnd.Next(ALF.Length)];

            //Нарисуем сгенирируемый текст
            g.DrawString(text,
                         new Font("Arial", 15),
                         colors[rnd.Next(colors.Length)],
                         new PointF(Xpos, Ypos));

            //Добавим немного помех
            /////Линии из углов
            g.DrawLine(Pens.Black,
                       new Point(0, 0),
                       new Point(Width - 1, Height - 1));
            g.DrawLine(Pens.Black,
                       new Point(0, Height - 1),
                       new Point(Width - 1, 0));
            ////Белые точки
            for (int i = 0; i < Width; ++i)
                for (int j = 0; j < Height; ++j)
                    if (rnd.Next() % 60 == 0)
                        result.SetPixel(i, j, Color.White);
            for (int i = 0; i < Width; ++i)
                for (int j = 0; j < Height; ++j)
                    if (rnd.Next() % 60 == 0)
                        result.SetPixel(i, j, Color.DarkBlue);
            for (int i = 0; i < Width; ++i)
                for (int j = 0; j < Height; ++j)
                    if (rnd.Next() % 60 == 0)
                        result.SetPixel(i, j, Color.Black);

            return result;
        } //Создание капчи
    }
}
