using System.Drawing;

namespace WindowsFormsPartC.Unit5
{
    /// <summary>
    /// This class contains code similar to the Animation form and
    /// is a way to avoid unecessary code duplication as this class
    /// can be used for all animation using GIF images that are 
    /// numbered 0..maxnImages
    /// 
    /// Refactored by: Derek Peacock
    /// </summary>
    public class Animation
    {
        private Image[] images;
        private int maxnImages = 0;
        private int currentImageNo = 0;

        public Animation(int maxnImages)
        {
            this.maxnImages = maxnImages;
            images = new Image[maxnImages];
        }

        public void LoadImages(string baseName)
        {
            for (int count = 0; count < maxnImages; count++)
            {
                string filename = baseName + count + ".gif";
                images[count] = Image.FromFile(filename);
            }
        }

        public Image GetNextImage()
        {
            Image image = images[currentImageNo];

            if (currentImageNo < maxnImages - 1)
                currentImageNo++;
            else
                currentImageNo = 0;

            return image;
        }
    }

}
