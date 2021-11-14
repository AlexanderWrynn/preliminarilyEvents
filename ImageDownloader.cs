using System;
using System.Net;

namespace preliminarilyEvents
{
    class ImageDownloader
    {
        public event Action<string> ImageStarted;
        public event Action<string> ImageCompleted;

        public void Download(string remoteUri, string fileName)
        {
            var myWebClient = new WebClient();
            ImageStarted?.Invoke("Скачивание файла началось");
            Console.WriteLine("Качаю \"{0}\" из \"{1}\" .......\n\n", fileName, remoteUri);
            myWebClient.DownloadFile(remoteUri, fileName);
            ImageCompleted?.Invoke("Скачивание файла закончилось");
            Console.WriteLine("Успешно скачал \"{0}\" из \"{1}\"", fileName, remoteUri);

        }
    }
}
