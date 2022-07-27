using Microsoft.Win32;
namespace StarCraft_Remastered_Language_Changer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //OLD CODE
            //if (comboBox1.SelectedIndex == 0 || comboBox1.SelectedIndex == 1)
            //{
            //    if (comboBox1.SelectedIndex == 0)
            //    {
            //        pictureBox1.Image = Properties.Resources._17877_warcraft_iii_reforged_story_campaign_backgrounds_2285155037;
            //    }
            //    else if (comboBox1.SelectedIndex == 1)
            //    {
            //        pictureBox1.Image = Properties.Resources.thumb_1920_534457_3676262569;
            //    }
            //    label2.Visible = true;
            //    comboBox2.Visible = true;
            //}

            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    pictureBox1.Image = Properties.Resources._17877_warcraft_iii_reforged_story_campaign_backgrounds_2285155037;
                    label2.Visible = true;
                    comboBox2.Visible = true;
                    break;
                case 1:
                    pictureBox1.Image = Properties.Resources.thumb_1920_534457_3676262569;
                    label2.Visible = true;
                    comboBox2.Visible = true;
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.Starcraft_II;
                    label2.Visible = true;
                    comboBox2.Visible = true;
                    break;
                default:
                    pictureBox1.Image = Properties.Resources.CTcLVGb_758766784;
                    break;

 

            }
                    

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                label3.Visible = true;
                comboBox3.Visible = true;
                label3.Text = "TEXT and AUDIO";

                label4.Visible = false;
                comboBox4.Visible = false;
            }
            else if (comboBox2.SelectedIndex == 1)
            {
                label3.Visible = true;
                comboBox3.Visible = true;
                label3.Text = "Select TEXT";

                label4.Visible = true;
                comboBox4.Visible = true;
                label4.Text = "Select AUDIO";
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Update(comboBox1.SelectedIndex, comboBox2.SelectedIndex);
        }

        private void Update(int Game, int Opts)
        {
            if (Game == 0)
            {
                RegistryKey LanguageText = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Blizzard Entertainment\\Battle.net\\Launch Options\\W3");
                if (Opts == 0)
                {
                    LanguageText.SetValue("LOCALE", comboBox3.Text, RegistryValueKind.String);
                    LanguageText.SetValue("LOCALE_AUDIO", comboBox3.Text, RegistryValueKind.String);

                    MessageBox.Show("The Game " + comboBox1.Text + " has been updated with the " + comboBox3.Text + " Language", "Informations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (Opts == 1)
                {
                    LanguageText.SetValue("LOCALE", comboBox3.Text, RegistryValueKind.String);
                    LanguageText.SetValue("LOCALE_AUDIO", comboBox4.Text, RegistryValueKind.String);

                    MessageBox.Show("The Game " + comboBox1.Text + " has been updated with the " + comboBox3.Text + " TEXT Language and the " + comboBox4.Text + " AUDIO Language", "Informations", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else if (Game == 1)
            {
                RegistryKey LanguageText = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Blizzard Entertainment\\Battle.net\\Launch Options\\S1");
                if (Opts == 0)
                {
                    LanguageText.SetValue("LOCALE", comboBox3.Text, RegistryValueKind.String);
                    LanguageText.SetValue("LOCALE_AUDIO", comboBox3.Text, RegistryValueKind.String);

                    MessageBox.Show("The Game " + comboBox1.Text + " has been updated with the " + comboBox3.Text + " Language", "Informations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (Opts == 1)
                {
                    LanguageText.SetValue("LOCALE", comboBox3.Text, RegistryValueKind.String);
                    LanguageText.SetValue("LOCALE_AUDIO", comboBox4.Text, RegistryValueKind.String);

                    MessageBox.Show("The Game " + comboBox1.Text + " has been updated with the " + comboBox3.Text + " TEXT Language and the " + comboBox4.Text + " AUDIO Language", "Informations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (Game == 2)
            {
                RegistryKey LanguageText = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Blizzard Entertainment\\Battle.net\\Launch Options\\S2");
                if (Opts == 0)
                {
                    LanguageText.SetValue("LOCALE", comboBox3.Text, RegistryValueKind.String);
                    LanguageText.SetValue("LOCALE_AUDIO", comboBox3.Text, RegistryValueKind.String);

                    MessageBox.Show("The Game " + comboBox1.Text + " has been updated with the " + comboBox3.Text + " Language", "Informations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (Opts == 1)
                {
                    LanguageText.SetValue("LOCALE", comboBox3.Text, RegistryValueKind.String);
                    LanguageText.SetValue("LOCALE_AUDIO", comboBox4.Text, RegistryValueKind.String);

                    MessageBox.Show("The Game " + comboBox1.Text + " has been updated with the " + comboBox3.Text + " TEXT Language and the " + comboBox4.Text + " AUDIO Language", "Informations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }
    }
}