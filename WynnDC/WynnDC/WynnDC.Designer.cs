namespace WynnDC
{
    partial class WynnDC
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WynnDC));
            this.credits = new System.Windows.Forms.Label();
            this.maxDmg = new System.Windows.Forms.TextBox();
            this.maxDmgTxt = new System.Windows.Forms.Label();
            this.powderTxt = new System.Windows.Forms.Label();
            this.powder = new System.Windows.Forms.ComboBox();
            this.you = new System.Windows.Forms.Label();
            this.opponent = new System.Windows.Forms.Label();
            this.str = new System.Windows.Forms.TextBox();
            this.strTxt = new System.Windows.Forms.Label();
            this.cls = new System.Windows.Forms.ComboBox();
            this.clsTxt = new System.Windows.Forms.Label();
            this.spell = new System.Windows.Forms.ComboBox();
            this.spellTxt = new System.Windows.Forms.Label();
            this.helmet = new System.Windows.Forms.PictureBox();
            this.boots = new System.Windows.Forms.PictureBox();
            this.leggings = new System.Windows.Forms.PictureBox();
            this.chestplate = new System.Windows.Forms.PictureBox();
            this.chestplateDef = new System.Windows.Forms.TextBox();
            this.helmetDef = new System.Windows.Forms.TextBox();
            this.leggingsDef = new System.Windows.Forms.TextBox();
            this.bootsDef = new System.Windows.Forms.TextBox();
            this.spellDamTxt = new System.Windows.Forms.Label();
            this.weaponDef = new System.Windows.Forms.TextBox();
            this.weapon = new System.Windows.Forms.PictureBox();
            this.dex = new System.Windows.Forms.CheckBox();
            this.totalDmg = new System.Windows.Forms.TextBox();
            this.totalDmgTxt = new System.Windows.Forms.Label();
            this.opClassTxt = new System.Windows.Forms.Label();
            this.opClass = new System.Windows.Forms.ComboBox();
            this.opDefTxt = new System.Windows.Forms.Label();
            this.opDef = new System.Windows.Forms.TextBox();
            this.opResTxt = new System.Windows.Forms.Label();
            this.opRes = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.helmet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boots)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leggings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chestplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weapon)).BeginInit();
            this.SuspendLayout();
            // 
            // credits
            // 
            this.credits.AutoSize = true;
            this.credits.Font = new System.Drawing.Font("Minecraft", 8F);
            this.credits.Location = new System.Drawing.Point(377, 9);
            this.credits.Name = "credits";
            this.credits.Size = new System.Drawing.Size(168, 22);
            this.credits.TabIndex = 0;
            this.credits.Text = "WynnDC v1.11_1 made \r\nby Acer78. Icon by Luxio.";
            // 
            // maxDmg
            // 
            this.maxDmg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maxDmg.Font = new System.Drawing.Font("Minecraft", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxDmg.Location = new System.Drawing.Point(15, 134);
            this.maxDmg.Name = "maxDmg";
            this.maxDmg.Size = new System.Drawing.Size(162, 23);
            this.maxDmg.TabIndex = 1;
            this.maxDmg.TextChanged += new System.EventHandler(this.maxDmg_TextChanged);
            // 
            // maxDmgTxt
            // 
            this.maxDmgTxt.AutoSize = true;
            this.maxDmgTxt.Font = new System.Drawing.Font("Minecraft", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxDmgTxt.Location = new System.Drawing.Point(12, 116);
            this.maxDmgTxt.Name = "maxDmgTxt";
            this.maxDmgTxt.Size = new System.Drawing.Size(114, 15);
            this.maxDmgTxt.TabIndex = 2;
            this.maxDmgTxt.Text = "Max. Damage";
            // 
            // powderTxt
            // 
            this.powderTxt.AutoSize = true;
            this.powderTxt.Font = new System.Drawing.Font("Minecraft", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.powderTxt.Location = new System.Drawing.Point(12, 176);
            this.powderTxt.Name = "powderTxt";
            this.powderTxt.Size = new System.Drawing.Size(73, 15);
            this.powderTxt.TabIndex = 4;
            this.powderTxt.Text = "Powder";
            // 
            // powder
            // 
            this.powder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.powder.Font = new System.Drawing.Font("Minecraft", 12F);
            this.powder.FormattingEnabled = true;
            this.powder.Items.AddRange(new object[] {
            "None",
            "Sharpness I",
            "Sharpness II"});
            this.powder.Location = new System.Drawing.Point(16, 194);
            this.powder.Name = "powder";
            this.powder.Size = new System.Drawing.Size(161, 24);
            this.powder.TabIndex = 5;
            this.powder.SelectedIndexChanged += new System.EventHandler(this.powder_SelectedIndexChanged);
            // 
            // you
            // 
            this.you.AutoSize = true;
            this.you.Font = new System.Drawing.Font("Minecraft", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.you.Location = new System.Drawing.Point(12, 18);
            this.you.Name = "you";
            this.you.Size = new System.Drawing.Size(54, 19);
            this.you.TabIndex = 6;
            this.you.Text = "You";
            // 
            // opponent
            // 
            this.opponent.AutoSize = true;
            this.opponent.Font = new System.Drawing.Font("Minecraft", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opponent.Location = new System.Drawing.Point(376, 59);
            this.opponent.Name = "opponent";
            this.opponent.Size = new System.Drawing.Size(125, 19);
            this.opponent.TabIndex = 7;
            this.opponent.Text = "Opponent";
            // 
            // str
            // 
            this.str.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.str.Font = new System.Drawing.Font("Minecraft", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.str.Location = new System.Drawing.Point(16, 261);
            this.str.Name = "str";
            this.str.Size = new System.Drawing.Size(161, 23);
            this.str.TabIndex = 8;
            this.str.TextChanged += new System.EventHandler(this.str_TextChanged);
            // 
            // strTxt
            // 
            this.strTxt.AutoSize = true;
            this.strTxt.Font = new System.Drawing.Font("Minecraft", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strTxt.Location = new System.Drawing.Point(12, 243);
            this.strTxt.Name = "strTxt";
            this.strTxt.Size = new System.Drawing.Size(89, 15);
            this.strTxt.TabIndex = 9;
            this.strTxt.Text = "Strength";
            // 
            // cls
            // 
            this.cls.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cls.Font = new System.Drawing.Font("Minecraft", 12F);
            this.cls.FormattingEnabled = true;
            this.cls.Items.AddRange(new object[] {
            "Warrior",
            "Archer",
            "Assassin",
            "Mage"});
            this.cls.Location = new System.Drawing.Point(16, 77);
            this.cls.Name = "cls";
            this.cls.Size = new System.Drawing.Size(161, 24);
            this.cls.TabIndex = 12;
            this.cls.SelectedIndexChanged += new System.EventHandler(this.cls_SelectedIndexChanged);
            // 
            // clsTxt
            // 
            this.clsTxt.AutoSize = true;
            this.clsTxt.Font = new System.Drawing.Font("Minecraft", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clsTxt.Location = new System.Drawing.Point(13, 59);
            this.clsTxt.Name = "clsTxt";
            this.clsTxt.Size = new System.Drawing.Size(57, 15);
            this.clsTxt.TabIndex = 13;
            this.clsTxt.Text = "Class";
            // 
            // spell
            // 
            this.spell.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.spell.Font = new System.Drawing.Font("Minecraft", 12F);
            this.spell.FormattingEnabled = true;
            this.spell.Location = new System.Drawing.Point(15, 324);
            this.spell.Name = "spell";
            this.spell.Size = new System.Drawing.Size(162, 24);
            this.spell.TabIndex = 14;
            this.spell.SelectedIndexChanged += new System.EventHandler(this.spell_SelectedIndexChanged);
            // 
            // spellTxt
            // 
            this.spellTxt.AutoSize = true;
            this.spellTxt.Font = new System.Drawing.Font("Minecraft", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spellTxt.Location = new System.Drawing.Point(12, 306);
            this.spellTxt.Name = "spellTxt";
            this.spellTxt.Size = new System.Drawing.Size(52, 15);
            this.spellTxt.TabIndex = 15;
            this.spellTxt.Text = "Spell";
            // 
            // helmet
            // 
            this.helmet.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.helmet.Location = new System.Drawing.Point(183, 77);
            this.helmet.Name = "helmet";
            this.helmet.Size = new System.Drawing.Size(32, 32);
            this.helmet.TabIndex = 16;
            this.helmet.TabStop = false;
            // 
            // boots
            // 
            this.boots.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.boots.Location = new System.Drawing.Point(183, 191);
            this.boots.Name = "boots";
            this.boots.Size = new System.Drawing.Size(32, 32);
            this.boots.TabIndex = 17;
            this.boots.TabStop = false;
            // 
            // leggings
            // 
            this.leggings.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.leggings.Location = new System.Drawing.Point(183, 153);
            this.leggings.Name = "leggings";
            this.leggings.Size = new System.Drawing.Size(32, 32);
            this.leggings.TabIndex = 18;
            this.leggings.TabStop = false;
            // 
            // chestplate
            // 
            this.chestplate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.chestplate.Location = new System.Drawing.Point(183, 115);
            this.chestplate.Name = "chestplate";
            this.chestplate.Size = new System.Drawing.Size(32, 32);
            this.chestplate.TabIndex = 19;
            this.chestplate.TabStop = false;
            // 
            // chestplateDef
            // 
            this.chestplateDef.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chestplateDef.Font = new System.Drawing.Font("Minecraft", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chestplateDef.Location = new System.Drawing.Point(221, 120);
            this.chestplateDef.Name = "chestplateDef";
            this.chestplateDef.Size = new System.Drawing.Size(128, 23);
            this.chestplateDef.TabIndex = 20;
            this.chestplateDef.TextChanged += new System.EventHandler(this.chestplateDef_TextChanged);
            // 
            // helmetDef
            // 
            this.helmetDef.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.helmetDef.Font = new System.Drawing.Font("Minecraft", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helmetDef.Location = new System.Drawing.Point(221, 83);
            this.helmetDef.Name = "helmetDef";
            this.helmetDef.Size = new System.Drawing.Size(128, 23);
            this.helmetDef.TabIndex = 21;
            this.helmetDef.TextChanged += new System.EventHandler(this.helmetDef_TextChanged);
            // 
            // leggingsDef
            // 
            this.leggingsDef.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.leggingsDef.Font = new System.Drawing.Font("Minecraft", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leggingsDef.Location = new System.Drawing.Point(221, 157);
            this.leggingsDef.Name = "leggingsDef";
            this.leggingsDef.Size = new System.Drawing.Size(128, 23);
            this.leggingsDef.TabIndex = 22;
            this.leggingsDef.TextChanged += new System.EventHandler(this.leggingsDef_TextChanged);
            // 
            // bootsDef
            // 
            this.bootsDef.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bootsDef.Font = new System.Drawing.Font("Minecraft", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bootsDef.Location = new System.Drawing.Point(221, 194);
            this.bootsDef.Name = "bootsDef";
            this.bootsDef.Size = new System.Drawing.Size(128, 23);
            this.bootsDef.TabIndex = 23;
            this.bootsDef.TextChanged += new System.EventHandler(this.bootsDef_TextChanged);
            // 
            // spellDamTxt
            // 
            this.spellDamTxt.AutoSize = true;
            this.spellDamTxt.Font = new System.Drawing.Font("Minecraft", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spellDamTxt.Location = new System.Drawing.Point(180, 59);
            this.spellDamTxt.Name = "spellDamTxt";
            this.spellDamTxt.Size = new System.Drawing.Size(122, 15);
            this.spellDamTxt.TabIndex = 24;
            this.spellDamTxt.Text = "Spell Damage";
            // 
            // weaponDef
            // 
            this.weaponDef.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.weaponDef.Font = new System.Drawing.Font("Minecraft", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weaponDef.Location = new System.Drawing.Point(221, 232);
            this.weaponDef.Name = "weaponDef";
            this.weaponDef.Size = new System.Drawing.Size(128, 23);
            this.weaponDef.TabIndex = 26;
            this.weaponDef.TextChanged += new System.EventHandler(this.weaponDef_TextChanged);
            // 
            // weapon
            // 
            this.weapon.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.weapon.Location = new System.Drawing.Point(183, 229);
            this.weapon.Name = "weapon";
            this.weapon.Size = new System.Drawing.Size(32, 32);
            this.weapon.TabIndex = 25;
            this.weapon.TabStop = false;
            // 
            // dex
            // 
            this.dex.AutoSize = true;
            this.dex.Font = new System.Drawing.Font("Minecraft", 11.25F, System.Drawing.FontStyle.Italic);
            this.dex.Location = new System.Drawing.Point(183, 267);
            this.dex.Name = "dex";
            this.dex.Size = new System.Drawing.Size(112, 19);
            this.dex.TabIndex = 27;
            this.dex.Text = "Dexterity";
            this.dex.UseVisualStyleBackColor = true;
            this.dex.CheckedChanged += new System.EventHandler(this.dex_CheckedChanged);
            // 
            // totalDmg
            // 
            this.totalDmg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalDmg.Font = new System.Drawing.Font("Minecraft", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalDmg.Location = new System.Drawing.Point(380, 324);
            this.totalDmg.Name = "totalDmg";
            this.totalDmg.ReadOnly = true;
            this.totalDmg.Size = new System.Drawing.Size(153, 26);
            this.totalDmg.TabIndex = 28;
            this.totalDmg.TextChanged += new System.EventHandler(this.totalDmg_TextChanged);
            // 
            // totalDmgTxt
            // 
            this.totalDmgTxt.AutoSize = true;
            this.totalDmgTxt.Font = new System.Drawing.Font("Minecraft", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalDmgTxt.Location = new System.Drawing.Point(205, 326);
            this.totalDmgTxt.Name = "totalDmgTxt";
            this.totalDmgTxt.Size = new System.Drawing.Size(169, 19);
            this.totalDmgTxt.TabIndex = 29;
            this.totalDmgTxt.Text = "Total Damage";
            // 
            // opClassTxt
            // 
            this.opClassTxt.AutoSize = true;
            this.opClassTxt.Font = new System.Drawing.Font("Minecraft", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opClassTxt.Location = new System.Drawing.Point(377, 92);
            this.opClassTxt.Name = "opClassTxt";
            this.opClassTxt.Size = new System.Drawing.Size(57, 15);
            this.opClassTxt.TabIndex = 31;
            this.opClassTxt.Text = "Class";
            // 
            // opClass
            // 
            this.opClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.opClass.Font = new System.Drawing.Font("Minecraft", 12F);
            this.opClass.FormattingEnabled = true;
            this.opClass.Items.AddRange(new object[] {
            "Warrior",
            "Archer",
            "Assassin",
            "Mage"});
            this.opClass.Location = new System.Drawing.Point(380, 110);
            this.opClass.Name = "opClass";
            this.opClass.Size = new System.Drawing.Size(161, 24);
            this.opClass.TabIndex = 30;
            this.opClass.SelectedIndexChanged += new System.EventHandler(this.opClass_SelectedIndexChanged);
            // 
            // opDefTxt
            // 
            this.opDefTxt.AutoSize = true;
            this.opDefTxt.Font = new System.Drawing.Font("Minecraft", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opDefTxt.Location = new System.Drawing.Point(376, 147);
            this.opDefTxt.Name = "opDefTxt";
            this.opDefTxt.Size = new System.Drawing.Size(82, 15);
            this.opDefTxt.TabIndex = 33;
            this.opDefTxt.Text = "Defence";
            // 
            // opDef
            // 
            this.opDef.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.opDef.Font = new System.Drawing.Font("Minecraft", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opDef.Location = new System.Drawing.Point(380, 165);
            this.opDef.Name = "opDef";
            this.opDef.Size = new System.Drawing.Size(161, 23);
            this.opDef.TabIndex = 32;
            this.opDef.TextChanged += new System.EventHandler(this.opDef_TextChanged);
            // 
            // opResTxt
            // 
            this.opResTxt.AutoSize = true;
            this.opResTxt.Font = new System.Drawing.Font("Minecraft", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opResTxt.Location = new System.Drawing.Point(376, 205);
            this.opResTxt.Name = "opResTxt";
            this.opResTxt.Size = new System.Drawing.Size(107, 15);
            this.opResTxt.TabIndex = 35;
            this.opResTxt.Text = "Resistance";
            // 
            // opRes
            // 
            this.opRes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.opRes.Font = new System.Drawing.Font("Minecraft", 12F);
            this.opRes.FormattingEnabled = true;
            this.opRes.Items.AddRange(new object[] {
            "None",
            "15% Resistance",
            "20% Resistance"});
            this.opRes.Location = new System.Drawing.Point(379, 223);
            this.opRes.Name = "opRes";
            this.opRes.Size = new System.Drawing.Size(161, 24);
            this.opRes.TabIndex = 34;
            this.opRes.SelectedIndexChanged += new System.EventHandler(this.opRes_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Minecraft", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(15, 372);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(518, 23);
            this.textBox1.TabIndex = 36;
            // 
            // WynnDC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(556, 407);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.opResTxt);
            this.Controls.Add(this.opRes);
            this.Controls.Add(this.opDefTxt);
            this.Controls.Add(this.opDef);
            this.Controls.Add(this.opClassTxt);
            this.Controls.Add(this.opClass);
            this.Controls.Add(this.totalDmgTxt);
            this.Controls.Add(this.totalDmg);
            this.Controls.Add(this.dex);
            this.Controls.Add(this.weaponDef);
            this.Controls.Add(this.weapon);
            this.Controls.Add(this.spellDamTxt);
            this.Controls.Add(this.bootsDef);
            this.Controls.Add(this.leggingsDef);
            this.Controls.Add(this.helmetDef);
            this.Controls.Add(this.chestplateDef);
            this.Controls.Add(this.chestplate);
            this.Controls.Add(this.leggings);
            this.Controls.Add(this.boots);
            this.Controls.Add(this.helmet);
            this.Controls.Add(this.spellTxt);
            this.Controls.Add(this.spell);
            this.Controls.Add(this.clsTxt);
            this.Controls.Add(this.cls);
            this.Controls.Add(this.strTxt);
            this.Controls.Add(this.str);
            this.Controls.Add(this.opponent);
            this.Controls.Add(this.you);
            this.Controls.Add(this.powder);
            this.Controls.Add(this.powderTxt);
            this.Controls.Add(this.maxDmgTxt);
            this.Controls.Add(this.maxDmg);
            this.Controls.Add(this.credits);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "WynnDC";
            this.Text = "WynnDC v1.11_1";
            ((System.ComponentModel.ISupportInitialize)(this.helmet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boots)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leggings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chestplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weapon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label credits;
        private System.Windows.Forms.TextBox maxDmg;
        private System.Windows.Forms.Label maxDmgTxt;
        private System.Windows.Forms.Label powderTxt;
        private System.Windows.Forms.ComboBox powder;
        private System.Windows.Forms.Label you;
        private System.Windows.Forms.Label opponent;
        private System.Windows.Forms.TextBox str;
        private System.Windows.Forms.Label strTxt;
        private System.Windows.Forms.ComboBox cls;
        private System.Windows.Forms.Label clsTxt;
        private System.Windows.Forms.ComboBox spell;
        private System.Windows.Forms.Label spellTxt;
        private System.Windows.Forms.PictureBox helmet;
        private System.Windows.Forms.PictureBox boots;
        private System.Windows.Forms.PictureBox leggings;
        private System.Windows.Forms.PictureBox chestplate;
        private System.Windows.Forms.TextBox chestplateDef;
        private System.Windows.Forms.TextBox helmetDef;
        private System.Windows.Forms.TextBox leggingsDef;
        private System.Windows.Forms.TextBox bootsDef;
        private System.Windows.Forms.Label spellDamTxt;
        private System.Windows.Forms.TextBox weaponDef;
        private System.Windows.Forms.PictureBox weapon;
        private System.Windows.Forms.CheckBox dex;
        private System.Windows.Forms.TextBox totalDmg;
        private System.Windows.Forms.Label totalDmgTxt;
        private System.Windows.Forms.Label opClassTxt;
        private System.Windows.Forms.ComboBox opClass;
        private System.Windows.Forms.Label opDefTxt;
        private System.Windows.Forms.TextBox opDef;
        private System.Windows.Forms.Label opResTxt;
        private System.Windows.Forms.ComboBox opRes;
        private System.Windows.Forms.TextBox textBox1;
    }
}

