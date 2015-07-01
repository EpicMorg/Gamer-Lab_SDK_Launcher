using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using glSDK.Pocos;
using glSDK.UI.ModernUITemplate;
using MetroFramework;

namespace glSDK.UI.SystemForms
{
    public partial class FrmSettings : FrmTmp
    {
        public FrmSettings()
        {
            InitializeComponent();
            Theme = Program.Settings.Theme;

            cmbLang.DataSource = new[] { "ru", "en", "uk" }.Select( a => new CultureWrapper( a ) ).ToArray();
            cmbTheme.DataSource = Enum.GetValues( typeof( MetroThemeStyle ) );

            cmbTheme.SelectedItem = Program.Settings.Theme;
        }

        private void FrmSettings_Load(object sender, System.EventArgs e)
        {
            FocusMe();
            
        }

        private void metroButtonReset_Click(object sender, System.EventArgs e)
        {
            //MetroMessageBox.Show(this, "This option will reset settings to defaults. Are you sure?", "Reset settings", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            Program.LoadSettings();
        }

        private void metroButtonSave_Click(object sender, System.EventArgs e)
        {
            if ( MetroMessageBox.Show( this, "Saved", "Save settings", MessageBoxButtons.YesNo, MessageBoxIcon.Question )
                 == DialogResult.Yes ) {
                DataManager.SaveSettings( Constants.SettingsPath, Program.Settings );
                Application.Restart();
            }

        }

        private void cmbLang_SelectedValueChanged(object sender, EventArgs e) { Program.Settings.Language = (cmbLang.SelectedItem as CultureWrapper).Name; }

        private void cmbTheme_SelectedValueChanged(object sender, EventArgs e) {
            Program.Settings.Theme = (MetroThemeStyle) cmbTheme.SelectedItem;
        }
        internal class CultureWrapper
        {
            private CultureInfo _info;

            public CultureWrapper(string s)
            {
                _info = CultureInfo.GetCultureInfo(s);
            }

            public string Name => _info.Name;

            public override string ToString() => _info.NativeName;
        }

    }
}
