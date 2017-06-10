using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Updater
{
    public partial class UpdaterForm : Form
    {
        public static string AppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        public static string AppDataCTW = AppData + "\\AzyIsCool\\Click To Website";
        public string CTWLoc = "";
        static DateTime DateAndTimeNow = DateTime.Now;

        public UpdaterForm()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                CTWLoc = File.ReadAllText(AppDataCTW + "\\CTWLoc.txt");
                Uri uri = new Uri("https://raw.githubusercontent.com/DMP9Labs/ClickToWebsite/master/Click%20To%20Website/bin/Release/Click%20To%20Website.exe", UriKind.Absolute);

                WebClient client = new WebClient();

                byte[] downloadupdater = await client.DownloadDataTaskAsync(uri);
                File.WriteAllBytes(CTWLoc + "\\Click To Website.exe", downloadupdater);
            }
            catch (WebException)
            {
                DateAndTimeNow = DateTime.Now;

                string[] log = { $"{DateAndTimeNow}: Can't get update infomation" };

                File.AppendAllLines(AppDataCTW + "\\log.txt", log);
                Console.WriteLine($"{DateAndTimeNow}: Can't get update infomation");
            }
            catch (FileNotFoundException)
            {
                DateAndTimeNow = DateTime.Now;

                string[] log = { $"{DateAndTimeNow}: Can't find Click To Website.exe" };

                File.AppendAllLines(AppDataCTW + "\\log.txt", log);
                Console.WriteLine($"{DateAndTimeNow}: Can't find Click To Website.exe");

                MessageBox.Show("Can't find Click To Website (Did you not run Click To Website before running this)", "Click To Website", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            catch (OutOfMemoryException)
            {
                DateAndTimeNow = DateTime.Now;

                string[] log = { $"{DateAndTimeNow}: No Memory Avablie for use" };

                File.AppendAllLines(AppDataCTW + "\\log.txt", log);
                Console.WriteLine($"{DateAndTimeNow}: No Memory Avablie for use");
            }
        }

        void Client_DownloadCompleted(DownloadDataCompletedEventArgs e)
        {
            File.Delete(AppDataCTW + "\\CTWLoc.txt");

            Done_Label.Visible = true;
            Open_Button.Visible = true;
        }

        private void Open_Button_Click(object sender, EventArgs e)
        {
            Process openCTW = new Process();
            openCTW.StartInfo.FileName = CTWLoc + "\\Click To Website.exe";
            openCTW.Start();
            Application.Exit();
        }
    }
}
