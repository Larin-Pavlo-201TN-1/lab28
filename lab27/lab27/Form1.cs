using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab27
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string sourceFilePath;

        private void Form1_Load(object sender, EventArgs e)
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                TreeNode node = new TreeNode(drive.Name);
                node.Tag = drive.RootDirectory.FullName;
                node.Nodes.Add(new TreeNode());
                treeView1.Nodes.Add(node);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TreeNode node = treeView1.SelectedNode;
            if (node.Nodes.Count == 1 && node.Nodes[0].Tag == null)
            {
                node.Nodes.Clear();

                string path = node.Tag.ToString();
                DirectoryInfo directory = new DirectoryInfo(path);
                try
                {
                    foreach (DirectoryInfo subdirectory in directory.GetDirectories())
                    {
                        TreeNode subnode = new TreeNode(subdirectory.Name);
                        subnode.Tag = subdirectory.FullName;
                        subnode.Nodes.Add(new TreeNode());
                        node.Nodes.Add(subnode);
                    }
                }
                catch (UnauthorizedAccessException)
                {
                    MessageBox.Show("Доступ обмежений.");
                }

                foreach (FileInfo file in directory.GetFiles())
                {
                    TreeNode subnode = new TreeNode(file.Name);
                    subnode.Tag = file.FullName;
                    node.Nodes.Add(subnode);
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TreeNode node = treeView1.SelectedNode;
            string path = node.Tag.ToString();
            DirectoryInfo directory = new DirectoryInfo(path);
            proper proper = new proper();
            proper.direc = directory;
            proper.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TreeNode node = treeView1.SelectedNode;
            string path = node.Tag.ToString();
            DirectoryInfo directory = new DirectoryInfo(path);
            Atributes_txt.Text = directory.Attributes.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TreeNode node = treeView1.SelectedNode;
            string path = node.Tag.ToString();
            DirectoryInfo directory = new DirectoryInfo(path);
            if(directory.Extension == ".txt")
            {
                try
                {
                    Process.Start("notepad.exe", path);
                }
                catch
                {
                    MessageBox.Show("Упс! щось пішло не так.");
                }
            }
            else
                MessageBox.Show("Потрібне ррозширення: txt");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TreeNode node = treeView1.SelectedNode;
            string path = node.Tag.ToString();
            DirectoryInfo directory = new DirectoryInfo(path);
            if (directory.Extension == ".png" || directory.Extension == ".jpg")
            {
                try
                {
                    Process.Start("iexplore.exe", path);
                }
                catch
                {
                    MessageBox.Show("Упс! щось пішло не так.");
                }
            }
            else
                MessageBox.Show("Потрібне розширення: jpg та png");
        }

        private void CreateCat_Click(object sender, EventArgs e)
        {
            TreeNode node = treeView1.SelectedNode;
            string path = node.Tag.ToString();
            if(!Directory.Exists(path))
            {
                MessageBox.Show("Виберіть каталог");
                return;
            }
            else
            {
                string directoryPath = path + Name_txt.Text;

                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                    MessageBox.Show("Каталог було успішно створено.");
                }
                else
                {
                    MessageBox.Show("Каталог вже існує.");
                }
            }
        }

        private void CreateFile_Click(object sender, EventArgs e)
        {
            TreeNode node = treeView1.SelectedNode;
            string path = node.Tag.ToString();
            if (!Directory.Exists(path))
            {
                MessageBox.Show("Виберіть каталог");
                return;
            }
            else
            {
                string filePath = path + Name_txt.Text;

                if (!File.Exists(filePath))
                {
                    File.Create(filePath).Close();
                    MessageBox.Show("Файл було успішно створено.");
                }
                else
                {
                    MessageBox.Show("Файл вже існує.");
                }

            }
        }

        private void CopyFile_Click(object sender, EventArgs e)
        {
            TreeNode node = treeView1.SelectedNode;
            string path = node.Tag.ToString();
            sourceFilePath = path;
        }

        private void CopyFile2_Click(object sender, EventArgs e)
        {
            TreeNode node = treeView1.SelectedNode;
            string path = node.Tag.ToString();
            string destFilePath = path;

            if (File.Exists(sourceFilePath))
            {
                File.Copy(sourceFilePath, destFilePath, true);
                MessageBox.Show("Файл було успішно скопійовано.");
            }
            else
            {
                MessageBox.Show("Файл не знайдено.");
            }

        }

        private void CopyCat_Click(object sender, EventArgs e)
        {
            TreeNode node = treeView1.SelectedNode;
            string path = node.Tag.ToString();
            sourceFilePath = path;
        }

        private void CopyCat2_Click(object sender, EventArgs e)
        {
            TreeNode node = treeView1.SelectedNode;
            string path = node.Tag.ToString();
            string destDirectoryPath = path;

            if (!Directory.Exists(path))
            {
                MessageBox.Show("Виберіть каталог");
            }
            else
            {
                Directory.CreateDirectory(destDirectoryPath);
                string[] files = Directory.GetFiles(sourceFilePath);

                foreach (string file in files)
                {
                    string fileName = Path.GetFileName(file);
                    string destinationFilePath = Path.Combine(destDirectoryPath, fileName);
                    File.Copy(file, destinationFilePath, true);
                }

                MessageBox.Show("Каталог було успішно скопійовано.");
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            TreeNode node = treeView1.SelectedNode;
            string path = node.Tag.ToString();
            sourceFilePath = path;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string destDirectoryPath = sourceFilePath + "1";

            if (Directory.Exists(sourceFilePath))
            {
                Directory.Move(sourceFilePath, destDirectoryPath);
                MessageBox.Show("Каталог було успішно переміщено.");
            }
            else
            {
                MessageBox.Show("Каталог не знайдено.");
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            TreeNode node = treeView1.SelectedNode;
            string path = node.Tag.ToString();
            sourceFilePath = path;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            TreeNode node = treeView1.SelectedNode;
            string path = node.Tag.ToString();
            string destDirectoryPath = path;

            if (File.Exists(sourceFilePath))
            {
                File.Move(sourceFilePath, destDirectoryPath);
                MessageBox.Show("Файл було успішно переміщено.");
            }
            else
            {
                MessageBox.Show("Файл не знайдено.");
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            TreeNode node = treeView1.SelectedNode;
            string path = node.Tag.ToString();
            string direcPath = path;

            if (Directory.Exists(direcPath))
            {
                Directory.Delete(direcPath, true);
                MessageBox.Show("Каталог видалено.");
            }
            else
            {
                MessageBox.Show("Каталог не знайдено.");
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            TreeNode node = treeView1.SelectedNode;
            string path = node.Tag.ToString();
            string filePath = path;

            if (File.Exists(filePath))
            {
                File.Delete(filePath);
                MessageBox.Show("Файл видалено.");
            }
            else
            {
                MessageBox.Show("Файл не знайдено.");
            }

        }
    }
}
