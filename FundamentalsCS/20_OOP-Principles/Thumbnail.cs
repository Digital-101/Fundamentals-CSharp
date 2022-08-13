using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS._20_OOP_Principles
{
    public class Thumbnail
    {
    }

    public interface Image
    {
        Thumbnail CreateThumbnail();
    }

    public class GifImage : Image
    {
        public Thumbnail CreateThumbnail()
        {
            // ... Create a GIF thumbnail here ...
            //return gifThumbnail;
            throw new NotImplementedException();
        }
    }

    public class JpegImage : Image
    {
        public Thumbnail CreateThumbnail()
        {

            // … Create a JPEG thumbnail here …
            //return jpegThumbnail;
            throw new NotImplementedException();
        }
    }
}
