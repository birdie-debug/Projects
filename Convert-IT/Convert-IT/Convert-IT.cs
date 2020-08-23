using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Convert_IT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Home.Visible = true;
        }

        private void audio_Click(object sender, EventArgs e)
        {
            
            Home.Visible = false;
            
           
        }

        private void video_Click(object sender, EventArgs e)
        {
           
            Home.Visible = false;
            
        }

        private void image_Click(object sender, EventArgs e)
        {
           

            Home.Visible = false;
            

        }

        private void document_Click(object sender, EventArgs e)
        {
            
            Home.Visible = false;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Home.Visible = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            Home.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Home.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            Home.Visible = true;
        }

        public void button1_Click_2(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = openFileDialog1.FileName;

                // The file path is in selectedFileName
                Home.Visible = false;


                string strPath = selectedFileName;
                string name = Path.GetFileName(strPath);


                string FILE_PATH = selectedFileName;
                    string FILE_NAME = name;

                System.IO.Directory.CreateDirectory(@"C:\Convert-IT_Dependencies");
                System.IO.Directory.CreateDirectory(@"C:\Convert-IT_Dependencies\My Files");
                string writepath = FILE_PATH;  // Create a text string
                File.WriteAllText(@"C:\Convert-IT_Dependencies\file-path.txt", writepath);
                string writename = FILE_NAME;  // Create a text string
                File.WriteAllText(@"C:\Convert-IT_Dependencies\file-plus-ext.txt", writename);
                FileInfo fi = new FileInfo(FILE_PATH);
                string ext = fi.Extension;
                File.WriteAllText(@"C:\Convert-IT_Dependencies\ext.txt", ext);

                string namewithext = File.ReadAllText(@"C:\Convert-IT_Dependencies\file-plus-ext.txt");
                string justname = namewithext.Replace($"{ext}", "");
                File.WriteAllText(@"C:\Convert-IT_Dependencies\name.txt", justname);




                userfile.Text = name;
                
               
     
               
                Convert_Screen.Visible = true;
                // This the function that changes the label yo whatever file that you want to be converted
                

            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
            string path = File.ReadAllText(@"C:\Convert-IT_Dependencies\file-path.txt");
            string name = File.ReadAllText(@"C:\Convert-IT_Dependencies\file-plus-ext.txt");
            string ext = File.ReadAllText(@"C:\Convert-IT_Dependencies\ext.txt");
            string justname = File.ReadAllText(@"C:\Convert-IT_Dependencies\name.txt");
            string comboinput = this.Filetypes.GetItemText(this.Filetypes.SelectedItem);
            // Converting Event
            // Msgbox as placeholder for the event
            if (comboinput == "JPG")
            {

                System.Drawing.Image image = System.Drawing.Image.FromFile(path);
                
                image.Save($"C:\\Convert-IT_Dependencies\\{justname}.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                // write to file $"C:\\Convert-IT_Dependencies\\{justname}.jpg"

                string convertedfile = $@"C:\Convert-IT_Dependencies\{justname}.jpg";
                File.WriteAllText(@"C:\Convert-IT_Dependencies\converted-path.txt", convertedfile);

                // ;

                string convertedname = $@"{justname}.jpg";
                File.WriteAllText(@"C:\Convert-IT_Dependencies\converted-name.txt", convertedname);

                //  @"C:\Convert-IT_Dependencies\converted-name.txt"




                Download_Name.Text = $"{justname}.jpg";

                Download_Panel.Visible = true;
                Convert_Screen.Visible = false;

                
            }
            if (comboinput == "PNG") 
            {
                
                System.Drawing.Image image = System.Drawing.Image.FromFile(path);

                image.Save($"C:\\Convert-IT_Dependencies\\{justname}.png", System.Drawing.Imaging.ImageFormat.Png);
                // write to file $"C:\\Convert-IT_Dependencies\\{justname}.jpg"

                string convertedfile = $@"C:\Convert-IT_Dependencies\{justname}.png";
                File.WriteAllText(@"C:\Convert-IT_Dependencies\converted-path.txt", convertedfile);

                // ;

                string convertedname = $@"{justname}.png";
                File.WriteAllText(@"C:\Convert-IT_Dependencies\converted-name.txt", convertedname);

                //  @"C:\Convert-IT_Dependencies\converted-name.txt"




                Download_Name.Text = $"{justname}.png";

                Download_Panel.Visible = true;
                Convert_Screen.Visible = false;
            }
            
            
           
            if (comboinput == "GIF")
            {
                System.Drawing.Image image = System.Drawing.Image.FromFile(path);

                image.Save($"C:\\Convert-IT_Dependencies\\{justname}.gif", System.Drawing.Imaging.ImageFormat.Gif);
                // write to file $"C:\\Convert-IT_Dependencies\\{justname}.jpg"

                string convertedfile = $@"C:\Convert-IT_Dependencies\{justname}.gif";
                File.WriteAllText(@"C:\Convert-IT_Dependencies\converted-path.txt", convertedfile);

                // ;

                string convertedname = $@"{justname}.gif";
                File.WriteAllText(@"C:\Convert-IT_Dependencies\converted-name.txt", convertedname);

                //  @"C:\Convert-IT_Dependencies\converted-name.txt"




                Download_Name.Text = $"{justname}.gif";

                Download_Panel.Visible = true;
                Convert_Screen.Visible = false;

            }
            
            
            
            if (comboinput == "ICO")
            {
                System.Drawing.Image image = System.Drawing.Image.FromFile(path);

                image.Save($"C:\\Convert-IT_Dependencies\\{justname}.ico", System.Drawing.Imaging.ImageFormat.Icon);
                // write to file $"C:\\Convert-IT_Dependencies\\{justname}.jpg"

                string convertedfile = $@"C:\Convert-IT_Dependencies\{justname}.ico";
                File.WriteAllText(@"C:\Convert-IT_Dependencies\converted-path.txt", convertedfile);

                // ;

                string convertedname = $@"{justname}.ico";
                File.WriteAllText(@"C:\Convert-IT_Dependencies\converted-name.txt", convertedname);

                //  @"C:\Convert-IT_Dependencies\converted-name.txt"




                Download_Name.Text = $"{justname}.ico";

                Download_Panel.Visible = true;
                Convert_Screen.Visible = false;
            }

            if (comboinput == "BMP")
            {
                System.Drawing.Image image = System.Drawing.Image.FromFile(path);

                image.Save($"C:\\Convert-IT_Dependencies\\{justname}.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
                // write to file $"C:\\Convert-IT_Dependencies\\{justname}.jpg"

                string convertedfile = $@"C:\Convert-IT_Dependencies\{justname}.bmp";
                File.WriteAllText(@"C:\Convert-IT_Dependencies\converted-path.txt", convertedfile);

                // ;

                string convertedname = $@"{justname}.bmp";
                File.WriteAllText(@"C:\Convert-IT_Dependencies\converted-name.txt", convertedname);

                //  @"C:\Convert-IT_Dependencies\converted-name.txt"




                Download_Name.Text = $"{justname}.bmp";

                Download_Panel.Visible = true;
                Convert_Screen.Visible = false;
            }
            /*
            if (comboinput == "")
            {
                System.Drawing.Image image = System.Drawing.Image.FromFile(path);

                image.Save($"C:\\Convert-IT_Dependencies\\{justname}.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                // write to file $"C:\\Convert-IT_Dependencies\\{justname}.jpg"

                string convertedfile = $@"C:\Convert-IT_Dependencies\{justname}.jpg";
                File.WriteAllText(@"C:\Convert-IT_Dependencies\converted-path.txt", convertedfile);

                // ;

                string convertedname = $@"{justname}.jpg";
                File.WriteAllText(@"C:\Convert-IT_Dependencies\converted-name.txt", convertedname);

                //  @"C:\Convert-IT_Dependencies\converted-name.txt"




                Download_Name.Text = $"{justname}.jpg";

                Download_Panel.Visible = true;
                Convert_Screen.Visible = false;
            }
            /*
            if (comboinput == "Something")
            {

            }


            if (comboinput == "Something")
            {

            }

            if (comboinput == "Something")
            {

            }

            if (comboinput == "Something")
            {

            }

            if (comboinput == "Something")
            {

            }

            if (comboinput == "Something")
            {

            }

            if (comboinput == "Something")
            {

            }

            if (comboinput == "Something")
            {

            }
            

            MessageBox.Show("Converting"+" "+name+" "+"into"+" "+justname+"."+comboinput);
        */
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Convert_Screen.Visible = false;
            Home.Visible = true;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Download_Panel.Visible = false;
            Convert_Screen.Visible = true;

        }

        private void Download_Click(object sender, EventArgs e)
        {
            string path = File.ReadAllText(@"C:\Convert-IT_Dependencies\file-path.txt");
            string name = File.ReadAllText(@"C:\Convert-IT_Dependencies\file-plus-ext.txt");
            string ext = File.ReadAllText(@"C:\Convert-IT_Dependencies\ext.txt");
            string justname = File.ReadAllText(@"C:\Convert-IT_Dependencies\name.txt");
            string converted_file = File.ReadAllText(@"C:\Convert-IT_Dependencies\converted-path.txt");
            string converted_name = File.ReadAllText(@"C:\Convert-IT_Dependencies\converted-name.txt");

            using (var dialog = new System.Windows.Forms.FolderBrowserDialog())
            {

                System.Windows.Forms.DialogResult result = dialog.ShowDialog();

                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    string selectedFolder = dialog.SelectedPath;


                    string sourceFile = converted_file;
                    string destinationFile = $@"{selectedFolder}\{converted_name}";





                    File.Copy(converted_file, $@"C:\Convert-IT_Dependencies\My Files\{converted_name}", true);


                    System.IO.File.Move(sourceFile, destinationFile);

                    




                }

            }

            // selectedFolder is the mmoving file destination

            


        }

        private void Convert_Screen_Paint(object sender, PaintEventArgs e)
        {
            // Do nothing here
        }

        private void Download_Name_Click(object sender, EventArgs e)
        {
            // Do nothing here
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Download_Panel.Visible = false;
            Home.Visible = true;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
            {
                FileName = "C:\\Convert-IT_Dependencies\\My Files",
                UseShellExecute = true,
                Verb = "open"
            });

        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = openFileDialog1.FileName;

                // The file path is in selectedFileName
                


                string strPath = selectedFileName;
                string name = Path.GetFileName(strPath);


                string FILE_PATH = selectedFileName;
                string FILE_NAME = name;

                System.IO.Directory.CreateDirectory(@"C:\Convert-IT_Dependencies");
                System.IO.Directory.CreateDirectory(@"C:\Convert-IT_Dependencies\My Files");
                string writepath = FILE_PATH;  // Create a text string
                File.WriteAllText(@"C:\Convert-IT_Dependencies\file-path.txt", writepath);
                string writename = FILE_NAME;  // Create a text string
                File.WriteAllText(@"C:\Convert-IT_Dependencies\file-plus-ext.txt", writename);
                FileInfo fi = new FileInfo(FILE_PATH);
                string ext = fi.Extension;
                File.WriteAllText(@"C:\Convert-IT_Dependencies\ext.txt", ext);

                string namewithext = File.ReadAllText(@"C:\Convert-IT_Dependencies\file-plus-ext.txt");
                string justname = namewithext.Replace($"{ext}", "");
                File.WriteAllText(@"C:\Convert-IT_Dependencies\name.txt", justname);




                userfile.Text = name;




                Convert_Screen.Visible = true;
                // This the function that changes the label yo whatever file that you want to be converted


            }
        }

       
    }
}
