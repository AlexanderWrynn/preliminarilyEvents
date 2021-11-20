using System;
using System.Net;
using System.Threading.Tasks;

namespace preliminarilyEvents
{
    class ImageDownloader
    {
        public event Action<string> ImageStarted;
        public event Action<string> ImageCompleted;

        public async Task Download(string remoteUri, string fileName)
        {
            var myWebClient = new WebClient();

            ImageStarted?.Invoke("Скачивание файла началось");
            Console.WriteLine("Качаю \"{0}\" из \"{1}\" .......\n\n", fileName, remoteUri);

            await myWebClient.DownloadFileTaskAsync(remoteUri, fileName);

            ImageCompleted?.Invoke("Скачивание файла закончилось");
            Console.WriteLine("Успешно скачал \"{0}\" из \"{1}\"", fileName, remoteUri);
        }

    }
}
