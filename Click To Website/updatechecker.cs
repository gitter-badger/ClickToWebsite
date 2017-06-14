using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Reflection;

namespace Click_To_Website
{
    class updatechecker
    {
        static string AppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        static string AppDataCTW = AppData + "\\AzyIsCool\\Click To Website";
        static DateTime DateAndTimeNow = DateTime.Now;
        string UpdateVer = "";

        public void UpdateMessageBox()
        {
            DialogResult result;
            result = MessageBox.Show($"There is a new update ({UpdateVer}) to Click To Website \r\nDo you what to update?", "Click To Website", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                Process updateprocess = new Process();
                string FileLoc = Application.StartupPath;
                Console.WriteLine("The File start Location is: {0}", FileLoc);
                File.WriteAllText(AppDataCTW + "\\CTWLoc.txt", FileLoc);
                updateprocess.StartInfo.FileName = AppDataCTW + "\\Updater.exe";
                updateprocess.Start();
                Application.Exit();
            }
        }

        public async Task CheckForUpdates(Label LabelAt)
        {
            if (!Directory.Exists(AppDataCTW))
            {
                Directory.CreateDirectory(AppDataCTW);
            }
            try
            {
                WebClient client = new WebClient();
                Uri uri = new Uri("https://raw.githubusercontent.com/DMP9Labs/ClickToWebsite/master/Click%20To%20Website/ver.txt", UriKind.Absolute);

                Stream stream = await client.OpenReadTaskAsync(uri);
                StreamReader reader = new StreamReader(stream);
                String content = reader.ReadToEnd();

                UpdateVer = content.Replace("newestver =", "");
                UpdateVer = UpdateVer.Replace(" ", "");

                if (Convert.ToDecimal(0.012) < Convert.ToDecimal(UpdateVer))
                {
                    uri = new Uri("https://raw.githubusercontent.com/DMP9Labs/ClickToWebsite/master/Updater/bin/Release/Updater.exe", UriKind.Absolute);
                    byte[] downloadupdater = await client.DownloadDataTaskAsync(uri);
                    File.WriteAllBytes(AppDataCTW + "\\Updater.txt", downloadupdater);
                    if (File.Exists(AppDataCTW + "\\Updater.exe"))
                    {
                        File.Delete(AppDataCTW + "\\Updater.exe");
                    }
                    File.Move(AppDataCTW + "\\Updater.txt", AppDataCTW + "\\Updater.exe");

                    LabelAt.Visible = true;
                }
            }
            catch (WebException)
            {
                DateAndTimeNow = DateTime.Now;

                string[] log = { $"{DateAndTimeNow} (Click To Website): Can't get update infomation" };

                File.AppendAllLines(AppDataCTW + "\\log.txt", log);
                Console.WriteLine($"{DateAndTimeNow} (Click To Website): Can't get update infomation");
            }
            catch (IOException)
            {
                DateAndTimeNow = DateTime.Now;

                string[] log = { $"{DateAndTimeNow} (Click To Website): I/O Exception" };

                File.AppendAllLines(AppDataCTW + "\\log.txt", log);
                Console.WriteLine($"{DateAndTimeNow} (Click To Website): I/O Exception");
            }
            catch (OutOfMemoryException)
            {
                DateAndTimeNow = DateTime.Now;

                string[] log = { $"{DateAndTimeNow} (Click To Website): No Memory Avablie for use" };

                File.AppendAllLines(AppDataCTW + "\\log.txt", log);
                Console.WriteLine($"{DateAndTimeNow} (Click To Website): No Memory Avablie for use");
            }
            catch (OverflowException)
            {
                DateAndTimeNow = DateTime.Now;
                string[] log = { $"{DateAndTimeNow} (Click To Website): Overflow Exception" };

                File.AppendAllLines(AppDataCTW + "\\log.txt", log);
                Console.WriteLine($"{DateAndTimeNow} (Click To Website): Overflow Exception");
            }
        }
    }
}
