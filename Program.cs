using System;

namespace preliminarilyEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            string remoteUri = "https://effigis.com/wp-content/uploads/2015/02/Iunctus_SPOT5_5m_8bit_RGB_DRA_torngat_mountains_national_park_8bits_1.jpg";
            string fileName = "bigimage.jpg";

            var imageDownloader = new ImageDownloader();
            imageDownloader.ImageStarted += message => Console.WriteLine(message);
            imageDownloader.Download(remoteUri, fileName);
            imageDownloader.ImageCompleted += message => Console.WriteLine(message);
            Console.WriteLine("Нажмите любую клавишу для выхода");
            Console.ReadKey();

        }

    }
}
