using System;
using System.Windows.Forms;

namespace Versioner
{
    public partial class VersionerWindowForm : Form
    {
        public VersionerWindowForm()
        {
            InitializeComponent();
        }

        private void VersionerWindowForm_Load(object sender, EventArgs e)
        {
            OperatingSystem os = Environment.OSVersion;

            if (os.Platform == PlatformID.Win32NT)
            {
                VersionerText1.Text = "Windows NT or compatible OS";
            }
            else
            {
                VersionerText1.Text = Convert.ToString(os.Platform);
            }

            VersionerText2.Text = os.VersionString;
            VersionerText3.Text = os.ServicePack;
        }
    }
}
