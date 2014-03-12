using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WynnDC
{
    public partial class WynnDC : Form
    {
        #region Init
        public WynnDC()
        {
            InitializeComponent();
            helmet.ImageLocation = "http://hydra-media.cursecdn.com/minecraft.gamepedia.com/e/ec/Grid_Iron_Helmet.png";
            chestplate.ImageLocation = "http://hydra-media.cursecdn.com/minecraft.gamepedia.com/8/8d/Grid_Iron_Chestplate.png";
            leggings.ImageLocation = "http://hydra-media.cursecdn.com/minecraft.gamepedia.com/9/99/Grid_Iron_Leggings.png";
            boots.ImageLocation = "http://hydra-media.cursecdn.com/minecraft.gamepedia.com/f/f5/Grid_Iron_Boots.png";
            cls.SelectedIndex = 0;
            powder.SelectedIndex = 0;
            opRes.SelectedIndex = 0;
        }
        string sclass = String.Empty;
        #endregion
        #region calcDmg
        public void calcDmg()
        {
            double r = 1;
            if (opRes.SelectedIndex == 0) { r = 1; }
            else if (opRes.SelectedIndex == 1) { r = 0.85; }
            else if (opRes.SelectedIndex == 2) { r = 0.8; }
            double oc = 1;
            if (opClass.SelectedIndex == 0) { oc = 0.9; }
            else if (opClass.SelectedIndex == 1) { oc = 1.2; }
            else if (opClass.SelectedIndex == 2) { oc = 1; }
            else if (opClass.SelectedIndex == 3) { oc = 1.1; }
            double def = 1;
            if (opDef.Text == "") { def = 1; }
            else { def = 1 - (Double.Parse(opDef.Text) / 100); }
            double p = 1;
            if (powder.SelectedIndex == 0) { p = 1; }
            else if (powder.SelectedIndex == 1) { p = 1.1; }
            else if (powder.SelectedIndex == 2) { p = 1.15; }
            double s = 1;
            switch (spell.SelectedItem.ToString())
            {
                case "Bash I": s = 1; break; case "Bash II": s = 1.15; break; case "Bash III": s = 1.3; break;
                case "Charge II": s = 1; break; case "Charge III": s = 1; break; 
                case "Uppercut I": s = 1.5; break; case "Uppercut II": s = 2.2; break; case "Uppercut III": s = 2.7; break; 
                case "War Scream II": s = 0.2; break; case "War Scream III": s = 0.2; break;
                case "Arrow Storm I": s = 4; break; case "Arrow Storm II": s = 6; break; case "Arrow Storm III": s = 12; break;
                case "Escape III": s = 1; break;
                case "Arrow Bomb I": s = 2; break; case "Arrow Bomb II": s = 2; break; case "Arrow Bomb III": s = 2; break;
                case "Arrow Shield I": s = 1.5; break; case "Arrow Shield II": s = 1.5; break; case "Arrow Shield III": s = 2.5; break;
                case "Spin Attack I": s = 1.5; break; case "Spin Attack II": s = 1.5; break; case "Spin Attack III": s = 1.5; break;
                case "Mulithits I": s = 2.5; break; case "Mulithits II": s = 3.5; break; case "Mulithits III": s = 3.5; break;
                case "Smoke Bomb I": s = 0.6; break; case "Smoke Bomb II": s = 0.6; break; case "Smoke Bomb III": s = 0.6; break;
                case "Teleport II": s = 1; break; case "Teleport III": s = 1; break;
                case "Meteore I": s = 2.5; break; case "Meteore II": s = 2.5; break; case "Meteore III": s = 3; break;
                case "Ice Snake I": s = 0.5; break; case "Ice Snake II": s = 0.5; break; case "Ice Snake III": s = 0.5; break;
                default: s = 1; break;
            }
            double de = 1;
            if (dex.Checked) { de = 2; }
            double a = 0; if (maxDmg.Text == "") { a = 0; } else { a = Double.Parse(maxDmg.Text); }
            double b = 1; if (str.Text == "") { b = 1; } else { b = (Double.Parse(str.Text) / 100) + 1; }
            double c = 0; if (helmetDef.Text == String.Empty) { c = 0; } else { c = Double.Parse(helmetDef.Text); }
            double d = 0; if (chestplateDef.Text == "") { d = 0; } else { d = Double.Parse(chestplateDef.Text); }
            double e = 0; if (leggingsDef.Text == "") { e = 0; } else { e = Double.Parse(leggingsDef.Text); }
            double f = 0; if (bootsDef.Text == "") { f = 0; } else { f = Double.Parse(bootsDef.Text); }
            double g = 0; if (weaponDef.Text == "") { g = 0; } else { g = Double.Parse(weaponDef.Text); }
            if (spell.SelectedIndex == 0) { c = 0; d = 0; e = 0; f = 0; g = 0; }
            double damage = p * s * de * a * b * def * oc * r * ((c + d + e + f + g + 100) / 100);
            totalDmg.Text = damage.ToString();
        }
        private void totalDmg_TextChanged(object sender, EventArgs e)
        {
            double a = Double.Parse(totalDmg.Text);
            a = Math.Round(a, 3, MidpointRounding.AwayFromZero);
            totalDmg.Text = a.ToString();
        }
        #endregion
        #region class, spell
        private void opClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            calcDmg();
        }
        private void opRes_SelectedIndexChanged(object sender, EventArgs e)
        {
            calcDmg();
        }
        private void powder_SelectedIndexChanged(object sender, EventArgs e)
        {
            calcDmg();
        }
        private void dex_CheckedChanged(object sender, EventArgs e)
        {
            calcDmg();
        }
        private void spell_SelectedIndexChanged(object sender, EventArgs e)
        {
            calcDmg();
        }
        private void cls_SelectedIndexChanged(object sender, EventArgs e)
        {
            spell.Items.Clear();
            spell.Items.Add("None");
            switch (cls.SelectedItem.ToString())
            {
                case "Warrior":
                    sclass = "wa";
                    spell.Items.Add("Bash I"); spell.Items.Add("Bash II"); spell.Items.Add("Bash III");
                    spell.Items.Add("Charge II"); spell.Items.Add("Charge III");
                    spell.Items.Add("Uppercut I"); spell.Items.Add("Uppercut II"); spell.Items.Add("Uppercut III");
                    spell.Items.Add("War Scream II"); spell.Items.Add("War Scream III");
                    weapon.ImageLocation = "http://hydra-media.cursecdn.com/minecraft.gamepedia.com/0/01/Grid_Iron_Shovel.png";
                    break;
                case "Archer":
                    sclass = "ar";
                    spell.Items.Add("Arrow Storm I"); spell.Items.Add("Arrow Storm II"); spell.Items.Add("Arrow Storm III");
                    spell.Items.Add("Escape III");
                    spell.Items.Add("Bomb Arrow I"); spell.Items.Add("Bomb Arrow II"); spell.Items.Add("Bomb Arrow III");
                    spell.Items.Add("Arrow Shield I"); spell.Items.Add("Arrow Shield II"); spell.Items.Add("Arrow Shield III");
                    weapon.ImageLocation = "http://hydra-media.cursecdn.com/minecraft.gamepedia.com/4/49/Grid_Bow.png";
                    break;
                case "Assassin":
                    sclass = "as";
                    spell.Items.Add("Spin Attack I"); spell.Items.Add("Spin Attack II"); spell.Items.Add("Spin Attack III");
                    spell.Items.Add("Multihits I"); spell.Items.Add("Multihits II"); spell.Items.Add("Multihits III");
                    spell.Items.Add("Smoke Bomb I"); spell.Items.Add("Smoke Bomb II"); spell.Items.Add("Smoke Bomb III");
                    weapon.ImageLocation = "http://hydra-media.cursecdn.com/minecraft.gamepedia.com/1/13/Grid_Shears.png";
                    break;
                case "Mage":
                    spell.Items.Add("Teleport II"); spell.Items.Add("Teleport III");
                    spell.Items.Add("Meteore I"); spell.Items.Add("Meteore II"); spell.Items.Add("Meteore III");
                    spell.Items.Add("Ice Snake I"); spell.Items.Add("Ice Snake II"); spell.Items.Add("Ice Snake III");
                    weapon.ImageLocation = "http://hydra-media.cursecdn.com/minecraft.gamepedia.com/e/e9/Grid_Stick.png";
                    sclass = "ma";
                    break;
            }
            spell.SelectedIndex = 0;
            calcDmg();
        }
        #endregion
        #region checkInt
        public bool checkInt(string check)
        {
            short result = 0;
            if (Int16.TryParse(check, out result)) { return true; }
            else { return false; }
        }
        private void opDef_TextChanged(object sender, EventArgs e)
        {
            if (!checkInt(opDef.Text)) { opDef.Text = ""; }
            calcDmg();
        }
        private void maxDmg_TextChanged(object sender, EventArgs e)
        {
            if (!checkInt(maxDmg.Text)) { maxDmg.Text = ""; }
            calcDmg();
        }
        private void str_TextChanged(object sender, EventArgs e)
        {
            if (!checkInt(str.Text)) { str.Text = ""; }
            calcDmg();
        }
        private void helmetDef_TextChanged(object sender, EventArgs e)
        {
            if (!checkInt(helmetDef.Text)) { helmetDef.Text = ""; }
            calcDmg();
        }
        private void chestplateDef_TextChanged(object sender, EventArgs e)
        {
            if (!checkInt(chestplateDef.Text)) { chestplateDef.Text = ""; }
            calcDmg();
        }
        private void leggingsDef_TextChanged(object sender, EventArgs e)
        {
            if (!checkInt(leggingsDef.Text)) { leggingsDef.Text = ""; }
            calcDmg();
        }
        private void bootsDef_TextChanged(object sender, EventArgs e)
        {
            if (!checkInt(bootsDef.Text)) { bootsDef.Text = ""; }
            calcDmg();
        }
        private void weaponDef_TextChanged(object sender, EventArgs e)
        {
            if (!checkInt(weaponDef.Text)) { weaponDef.Text = ""; }
            calcDmg();
        }
        #endregion
    }
}
