using System;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var processor= new PhotoProcessor();
            var filters = new PhotoFilters();
            //  PhotoProcessor.PhotoFilterHandler filterHandler = filters.ApplyBrightness;
            Action<Photo> filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyContrast;
            filterHandler += RemoveRedFilter;
            processor.Process("photo.jpg",filterHandler);
        }

        static void RemoveRedFilter(Photo photo)
        {
            Console.WriteLine("Apply RemoveRed");
        }
    }
}
