namespace copyzomboidmods
{
    public partial class Form1 : Form
    {
        String workshopDirectory;
        String zomboidModsDirectory;
        public Form1()
        {
            InitializeComponent();
        }

        private void workshopDirectoryButton_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    workshopDirectory = fbd.SelectedPath;
                    System.Windows.Forms.MessageBox.Show("Chosen directory: " + workshopDirectory, "Message");
                }
            }

        }

        private void modFolderDirectoryButton_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    zomboidModsDirectory = fbd.SelectedPath;
                    System.Windows.Forms.MessageBox.Show("Chosen directory: " + zomboidModsDirectory, "Message");
                }
            }
        }

        private void extractModFoldersButton_Click(object sender, EventArgs e)
        {
            if(workshopDirectory == null || zomboidModsDirectory == null)
            {
                System.Windows.Forms.MessageBox.Show("You must select both workshop folder and mod folder.");
            }
            if (workshopDirectory != null || zomboidModsDirectory != null)
            {
                var workshopModFolders = Directory.GetDirectories(workshopDirectory);
                foreach (var workshopModFolder in workshopModFolders)
                {
                    if(Directory.GetDirectories(workshopModFolder).Contains("mods"))
                    {
                        string directory = workshopModFolder + "/mods";
                        var modFoldersToExtract = Directory.GetDirectories(directory);
                        foreach(var modFolderToExtract in modFoldersToExtract)
                        {
                            File.Copy(modFolderToExtract, zomboidModsDirectory, true);
                        }
                    }
                }
                System.Windows.Forms.MessageBox.Show("Mod Folders: " + String.Join(", ", workshopModFolders), "Message");
            }
        }
    }
}