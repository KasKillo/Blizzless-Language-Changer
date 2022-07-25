using Microsoft.Win32;
namespace StarCraft_Remastered_Language_Changer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistryKey LanguageText = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Blizzard Entertainment\\Battle.net\\Launch Options\\S1");
            LanguageText.SetValue("LOCALE", listBox1.SelectedIndex,RegistryValueKind.String);
            LanguageText.SetValue("LOCALE_AUDIO", listBox1.SelectedIndex, RegistryValueKind.String);
        }
    }
}