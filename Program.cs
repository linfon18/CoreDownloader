using System;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

namespace CoreDownloader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tempDirectory = Path.GetTempPath();
            string customDirectory = Path.Combine(tempDirectory, "MCZLFAPP", "Temp");
            Directory.CreateDirectory(customDirectory);
            Directory.SetCurrentDirectory(customDirectory);
            string fileName = "main.exe";
            string fileMd5 = "886c8ef10288d546fe254b531870318d";
            string fileMd532 = "e8f1007a43eb520eecf9c0fade0300b0";
            bool needsDownload = false;
            if (File.Exists(fileName))
            {
                string md5Hash = GetFileMD5Hash(fileName);
                if (md5Hash == fileMd5)
                {
                    Console.Write("64位核心已存在且安全校验通过\n");
                }
                else
                {
                    if (md5Hash == fileMd532)
                    {
                        Console.Write("32位核心已存在且安全校验通过\n");
                        needsDownload = false;
                    }
                    else
                    {
                        Console.Write("核心不存在或安全校验不通过,重新Download中\n");
                        needsDownload = true;
                    }
                }
            }
            else
            {
                Console.Write("核心不存在或安全校验不通过,重新Download中\n");
                needsDownload = true;
            }


            if (needsDownload)
            {
                Console.Write("当前下载器版本 0.0.1.020 MCZLFConnectToolP2PMode适用\n");
            string url = Environment.Is64BitOperatingSystem ? "https://pan.29o.cn/down.php/886c8ef10288d546fe254b531870318d.exe" : "https://pan.29o.cn/down.php/e8f1007a43eb520eecf9c0fade0300b0.exe";
            string tempPath = Path.Combine(Environment.GetEnvironmentVariable("TEMP"), "MCZLFAPP", "Temp");
            if (!Directory.Exists(tempPath)) Directory.CreateDirectory(tempPath);
            string downloadFilePath = Path.Combine(tempPath, "main.exe");
            using (WebClient webClient = new WebClient())
            {
                webClient.DownloadProgressChanged += DownloadProgressCallback;
                webClient.DownloadFileAsync(new Uri(url), downloadFilePath);
                ManualResetEvent downloadCompleted = new ManualResetEvent(false);
                webClient.DownloadFileCompleted += (sender, e) =>
                {
                    if (e.Error != null) Console.WriteLine("\n下载失败：" + e.Error.Message);
                    else Console.WriteLine("\ncomplete");
                    downloadCompleted.Set();
                };
                downloadCompleted.WaitOne();
            }
        }
        }
        static void DownloadProgressCallback(object sender, DownloadProgressChangedEventArgs e)
        {
            Console.Write("\r下载进度: {0}%", e.ProgressPercentage);
        }
        public static string GetFileMD5Hash(string filePath)
        {
            try
            {
                using (FileStream stream = File.OpenRead(filePath))
                {
                    MD5 md5 = MD5.Create();
                    byte[] hashValue = md5.ComputeHash(stream);
                    StringBuilder hex = new StringBuilder(hashValue.Length * 2);
                    foreach (byte b in hashValue)
                    {
                        hex.AppendFormat("{0:x2}", b);
                    }
                    return hex.ToString();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error computing MD5 hash for file " + filePath, ex);
            }
        }
        //此后代码不会大改,功能正常就行了
    }
}
