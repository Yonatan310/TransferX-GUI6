using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using TransferX_GUI.Server;
using Renci.SshNet;
using MySql.Data.MySqlClient;
using Renci.SshNet.Common;
using Renci.SshNet.Sftp;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TransferX_GUI.client
{
    static class UsersFiles
    {
        private static TreeView User1Files;
        private static TreeView User2Files;
        private static ImageList imageList;

        public static void SetUser1TreeView(TreeView treeView)
        {
            User1Files = treeView;
        }

        public static void SetUser2TreeView(TreeView treeView)
        {
            User2Files = treeView;
        }

        public static void ShowTreeViewForUser1()
        {
            ShowTreeView1(User1Files);

        }


        

        public static void ShowTreeViewForUser2()
        {
            string FolderPath;
            FolderPath = @"/sftp_root";
            ShowTreeView2(User2Files, FolderPath);
        }



        public static void ShowTreeView1(TreeView treeView)
        {
            imageList = new ImageList();

            imageList.Images.Add("folder", Image.FromFile(@"C:\Users\Yonatan-PC\Desktop\Projects\TransferX\TransferX GUI\TransferX GUI\Images\folder.png"));
            imageList.Images.Add("file", Image.FromFile(@"C:\Users\Yonatan-PC\Desktop\Projects\TransferX\TransferX GUI\TransferX GUI\Images\file.png"));

            treeView.ImageList = imageList;

            string[] drives = Directory.GetLogicalDrives();

            foreach (string drive in drives)
            {
                TreeNode DrivesNode = new TreeNode(drive)
                {
                    Tag = drive,
                    ImageKey = "folder",
                    SelectedImageKey = "folder"
                };
                DrivesNode.Nodes.Add("...");
                treeView.Nodes.Add(DrivesNode);
            }

            AddSpecificFolderNode(treeView, Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Desktop");
            AddSpecificFolderNode(treeView, Environment.GetFolderPath(Environment.SpecialFolder.MyPictures), "Pictures");
            AddSpecificFolderNode(treeView, Environment.GetFolderPath(Environment.SpecialFolder.MyVideos), "Videos");
            AddSpecificFolderNode(treeView, Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Documents");
            AddSpecificFolderNode(treeView, Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads", "Downloads");
            treeView.BeforeExpand += UserFiles_Details;


        }
        public static void ShowTreeView2(TreeView treeView, string FolderPath)
        {
            imageList = new ImageList();
            imageList.Images.Add("folder", Image.FromFile(@"C:\Users\Yonatan-PC\Desktop\Projects\TransferX\TransferX GUI\TransferX GUI\Images\folder.png"));
            imageList.Images.Add("file", Image.FromFile(@"C:\Users\Yonatan-PC\Desktop\Projects\TransferX\TransferX GUI\TransferX GUI\Images\file.png"));
            treeView.ImageList = imageList;

            treeView.Nodes.Clear(); 

            using (var transferxclient = new SftpClient(ConnectDetails.IpAddress, int.Parse(ConnectDetails.Port), ConnectDetails.Username, ConnectDetails.Password))
            {
                try
                {
                    transferxclient.Connect();
                    if (transferxclient.IsConnected)
                    {
                        AddRootFolderToServerNode(treeView, transferxclient, FolderPath);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to connect: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private static void AddSpecificFolderNode(TreeView treeView, string folderPath, string folderName)
        {
            TreeNode specificNode = new TreeNode(folderName)
            {
                Tag = folderPath,
                ImageKey = "folder",
                SelectedImageKey = "folder"
            };
            specificNode.Nodes.Add("...");
            treeView.Nodes.Add(specificNode);
            
        }
        private static void AddRootFolderToServerNode(TreeView treeView, SftpClient transferxclient, string FolderPath)
        {
            TreeNode specificNode = new TreeNode(FolderPath)
            {
                Tag = FolderPath,
                ImageKey = "folder",
                SelectedImageKey = "folder"
            };

            try
            {
                var direcotry = transferxclient.ListDirectory(FolderPath);
                foreach (var dir in direcotry)
                {
                    if (dir.Name != "." && dir.Name != "..")
                    {
                        TreeNode node = new TreeNode(dir.Name)
                        {
                            Tag = $"{FolderPath}/{dir.Name}",
                            ImageKey = dir.IsDirectory ? "folder" : "file",
                            SelectedImageKey = dir.IsDirectory ? "folder" : "file"
                        };
                        
                        if (dir.IsDirectory)
                        {
                            node.Nodes.Add("...");
                            TreeNode secondfolder = AddFolderToServerNode(node, transferxclient, $"{FolderPath}/{dir.Name}");
                            
                            if (secondfolder != null)
                                node.Nodes.Add(secondfolder);
                        }

                        specificNode.Nodes.Add(node);
                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error accessing directory {FolderPath}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            treeView.Nodes.Add(specificNode);
        }

        private static TreeNode AddFolderToServerNode(TreeNode treeView, SftpClient transferxclient, string FolderPath)
        {
            TreeNode node = null;
            if (treeView == null)
                return null;
            try
            {
                var direcotry = transferxclient.ListDirectory(FolderPath);
                foreach (var dir in direcotry)
                {
                    if (dir.Name != "." && dir.Name != "..")
                    {
                        node = new TreeNode(dir.Name)
                        {
                            Tag = $"{FolderPath}/{dir.Name}",
                            ImageKey = dir.IsDirectory ? "folder" : "file",
                            SelectedImageKey = dir.IsDirectory ? "folder" : "file"
                        };

                        if (dir.IsDirectory)
                        {
                            TreeNode otherfolders = AddFolderToServerNode(node, transferxclient, $"{FolderPath}/{dir.Name}");
                            if (otherfolders != null)
                            {
                                node.Nodes.Add(otherfolders);
                                
                            }
                        }
                        else {
                            treeView.Nodes.Add(node);
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error accessing directory {FolderPath}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return node;
        }


        public static void UserFiles_Details(object sender, TreeViewCancelEventArgs e)
        {
            TreeView treeView = sender as TreeView;
            TreeNode node = e.Node;

            if (node.Nodes[0].Text == "..." && node.Nodes.Count == 1)
            {
                string path = node.Tag.ToString();

                try
                {
                    string[] directories = Directory.GetDirectories(path);
                    foreach (string directory in directories)
                    {
                        TreeNode directoryNode = new TreeNode(Path.GetFileName(directory))
                        {
                            Tag = directory,
                            ImageKey = "folder",
                            SelectedImageKey = "folder"
                        };
                        directoryNode.Nodes.Add("...");
                        node.Nodes.Add(directoryNode);
                    }

                    string[] files = Directory.GetFiles(path);
                    foreach (string file in files)
                    {
                        string fileName = Path.GetFileName(file);
                        TreeNode fileNode = new TreeNode(fileName)
                        {
                            Tag = file,
                            ImageKey = "file",
                            SelectedImageKey = "file"
                        };
                        node.Nodes.Add(fileNode);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error accessing directory {path}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }




    }
}
