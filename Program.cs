using System;
using System.Drawing; 


namespace Image
{
    public class Get_picture
    {
        public static void Main()
        {
           string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+@"293061222_1684717695243304_5795784653463535659_n.jpg";
           Bitmap image = new Bitmap(path,true);
           for(int x=0;x<image.Width;x++)
           {
              for(int y=0;y<image.Height;x++)
              {
                Color clr = image.GetPixel(x,y);
                Color newclr = Color.FromArgb(clr.R,0,0)l
            
              }
           }
        }
        image.Save(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"293061222_1684717695243304_5795784653463535659_n.jpg");
        Console.WriteLine("wqeqeqwewqeqweqwewqeqweqweqweqw");
        Console.ReadKey();

    }

        public class Get_picture
    {
        public static void Main()
        {
            Bitmap image = new Bitmap();
        }
    }


}