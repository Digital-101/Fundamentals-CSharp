using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS._20_OOP_Principles
{
    public class Example
    {
        static void MEGC()
        {
            IList<Image> images = new List<Image>();

            images.Add(new JpegImage());
            images.Add(new GifImage());

            ImageCollection imageRepository = new ImageCollection(images);
            Console.WriteLine(imageRepository.CreateThumbnails());
        }
    }
}
