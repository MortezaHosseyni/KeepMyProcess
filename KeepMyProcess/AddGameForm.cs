using DevExpress.XtraEditors;
using KeepMyProcess.Database;
using KeepMyProcess.Database.Entities;
using System;
using System.IO;
using System.Windows.Forms;

namespace KeepMyProcess
{
    public partial class AddGameForm : XtraForm
    {
        private string _gameLocation;
        private string _gameSaveLocation;
        private string _gameName;

        public AddGameForm()
        {
            InitializeComponent();
        }

        private void AddGameForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_SelectGameLocation_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Executable Files|*.exe";
            openFileDialog.Title = "Select an Game";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;

                _gameLocation = openFileDialog.FileName;
                _gameName = !string.IsNullOrEmpty(txt_GameName.Text) ? txt_GameName.Text : openFileDialog.SafeFileName;

                txt_GameLocation.Text = _gameLocation;
            }
            else
            {
                MessageBox.Show("Please select a Game.", "Select a Game!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_SelectSaveLocation_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog saveLocation = new FolderBrowserDialog();
            saveLocation.RootFolder = Environment.SpecialFolder.MyComputer;
            saveLocation.Description = "Please select game save location.";

            if (saveLocation.ShowDialog() == DialogResult.OK)
            {
                _gameSaveLocation = saveLocation.SelectedPath;
                txt_SaveLocation.Text = _gameSaveLocation;
            }
            else
            {
                MessageBox.Show("Please select save location.", "Select save location!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void btn_Add_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_gameName) || !string.IsNullOrEmpty(_gameLocation) || !string.IsNullOrEmpty(_gameSaveLocation))
            {
                MessageBox.Show("Please ensure to selected a game and game save location.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!File.Exists(_gameLocation))
            {
                MessageBox.Show("Please select a Game!", "Game Location!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Directory.Exists(_gameSaveLocation))
            {
                MessageBox.Show("Please select game save location!", "Game Save Location!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var db = new AppDbContext();

            await db.Games.AddAsync(new Game()
            {
                Name = _gameName,
                GamePath = _gameLocation,
                GameSavePath = _gameSaveLocation,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            });
            await db.SaveChangesAsync();

            Close();
        }

        private void txt_GameLocation_TextChanged(object sender, EventArgs e)
        {
            _gameLocation = txt_GameLocation.Text;
        }

        private void txt_SaveLocation_TextChanged(object sender, EventArgs e)
        {
            _gameSaveLocation = txt_SaveLocation.Text;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}