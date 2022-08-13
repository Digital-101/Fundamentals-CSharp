using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCS._20_OOP_Principles
{
    public class ImageCollection
    {
        private IList<Image> images;
        public ImageCollection(IList<Image> images)
        {
            this.images = images;
        }

        public IList<Thumbnail> CreateThumbnails()
        {
            IList<Thumbnail> thumbnails = new List<Thumbnail>(images.Count);
            foreach (Image thumb in images)
            {
                thumbnails.Add(thumb.CreateThumbnail());
            }
            return thumbnails;
        }
    }
}
