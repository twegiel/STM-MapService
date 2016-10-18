using System.IO;
using System.Drawing;
using System;

namespace MapService
{
    public class MapConverter
    {
        private Image _image;

        public MapConverter(string mapPath)
        {
            _image = Image.FromFile(mapPath);
        }

        public MapConverter TransformToThumbnail(Size thumbnailSize)
        {
            _image = _image.GetThumbnailImage(thumbnailSize.Width, thumbnailSize.Width, 
                () => false, IntPtr.Zero);
            return this;
        }

        public MapConverter CropImage(int x1, int y1, int x2, int y2)
        {
            var width = Math.Abs(x2 - x1);
            var height = Math.Abs(y2 - y1);

            Rectangle rectangle = new Rectangle(x1, y1, width, height);
            Bitmap original = new Bitmap(_image);
            Bitmap cropped = original.Clone(rectangle, original.PixelFormat);

            _image = cropped;

            return this;
        }

        public byte[] GetBytesOfTransformedImage()
        {
            using (var ms = new MemoryStream())
            {
                _image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }
    }
}
