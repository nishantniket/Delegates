using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    public class PhotoProcessor
    {
        // This is a custom delegate
        //public delegate void PhotoFilterHandler(Photo photo);
       // public void Process(string path, PhotoFilterHandler filterHandler)
        public void Process(string path, Action<Photo> filterHandler)
        {
            var photo = Photo.Load(path);
            filterHandler(photo);
            //var filters = new PhotoFilters();
            //filters.ApplyBrightness(photo);
            //filters.ApplyContrast(photo);
            //filters.Resize(photo);
            photo.Save();

        }
    }
}
