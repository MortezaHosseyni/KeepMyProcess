using KeepMyProcess.Database.Seeds;
using System.Windows.Forms;

namespace KeepMyProcess
{
    public partial class MainPage : DevExpress.XtraEditors.XtraForm
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void MainPage_Load(object sender, System.EventArgs e)
        {
            // Seeding database
            var seeder = new BackupLocationsSeeder();
            if (!await seeder.Seed())
            {
                MessageBox.Show("Error occurred when connecting to database.", "Database Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
