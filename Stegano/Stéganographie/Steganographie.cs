using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProjet_Stéganographie
{
    public class Steganographie
    {
        public static int intervale = 10;
        
        public static bool encoder(Bitmap img, string txtMessage)
        {
            try
            {
                int k = 0;

                for (int i = 0; i < img.Width; i += intervale)
                {
                    for (int j = 0; j < img.Height; j += intervale)
                    {
                        if (k < txtMessage.Length)
                        {
                            char car = Convert.ToChar(txtMessage[k]);
                            int valCar = Convert.ToInt32(car);



                            Color pixel = img.GetPixel(i, j);

                            img.SetPixel(i, j, Color.FromArgb(pixel.R, pixel.G, valCar));

                            k++;
                        }
                    }
                }

                //Affecter la longueur du msg dans le dernier Pixel
                img.SetPixel(img.Width - 1, img.Height - 1, Color.FromArgb(130, 130, txtMessage.Length));
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public static string decoder(Bitmap img)
        {

            try
            {
                int lnMsg = img.GetPixel(img.Width - 1, img.Height - 1).B;


                string msg = "";
                int k = 0;

                for (int i = 0; i < img.Width; i += intervale)
                {
                    for (int j = 0; j < img.Height; j += intervale)
                    {
                        if (k < lnMsg)
                        {
                            Color pixel = img.GetPixel(i, j);
                            int val = pixel.B;
                            char c = Convert.ToChar(val);

                            msg = msg + c;

                            k++;
                        }

                    }
                }

                return msg;
            }
            catch (Exception)
            {
                return "";
            }
        }
    }
}
