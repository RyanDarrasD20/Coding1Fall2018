using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace FindTheFile
{
    public partial class Form1 : Form
    {
        //string[] folderNames = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
        string[] folderNames = new string[] { "A", "B", "C" };
        int howDeep = 5;
        string parentName = "FolderTree";

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// We want to generate the file structure here
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(Application.StartupPath + "\\" + parentName))
            {
                UpdateNotification("Creating folder");
                Directory.CreateDirectory(Application.StartupPath + "\\" + parentName);
                Task.Factory.StartNew(() => GenerateDirectory(Application.StartupPath + "\\" + parentName, 0));
            }
            else
            {
               
            }
        }

        private void GenerateDirectory(string path, int layer)
        {
            if (layer == howDeep)
            {
                return;
            }
            foreach (string s in folderNames)
            {
                Thread.Sleep(10);
                Directory.CreateDirectory(path + "\\" + s);
                GenerateDirectory(path + "\\" + s, layer + 1);
            }
        }

        private void UpdateNotification(string message)
        {
            textBox2.Text = message;
        }
    }
}
