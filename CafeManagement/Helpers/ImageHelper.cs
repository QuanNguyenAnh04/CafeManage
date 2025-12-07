using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace CafeManagement.Helpers
{
    internal static class ImageHelper
    {
        public static byte[] ImageToBytes(Image img)
        {
            if (img == null) return Array.Empty<byte>();
            using MemoryStream ms = new MemoryStream();
            img.Save(ms, ImageFormat.Png);
            return ms.ToArray();
        }

        public static Image BytesToImage(byte[] bytes)
        {
            if (bytes == null || bytes.Length == 0) return null;
            using MemoryStream ms = new MemoryStream(bytes);
            return Image.FromStream(ms);
        }
    }
}
