// In FF1 parameter.currentMpCountList and addtionalMaxMpCountList has an array for the MP available at each level

using FFPRSaveEditor.Common.Models;
using System.Collections;
using System.Collections.Specialized;
using System.Data;

namespace FFPRSaveEditorGUI.Forms {
    public partial class CharacterEditorForm : Form {
        private List<OwnedCharacterList_Target> characters;
        private BaseSaveGame save;
        private Type saveType;
        private UserData userData;

        public CharacterEditorForm() {
            InitializeComponent();
        }

        public CharacterEditorForm(BaseSaveGame save) {
            InitializeComponent();

            this.save = save;
            this.saveType = save.GetType();

            this.userData = ((dynamic)save).userData;
            this.characters = userData.ownedCharacterList.target;

            mnuAddAllMagic.Visible = saveType.FullName.Contains("FF5");
            mnuMaxJobLevels.Visible = saveType.FullName.Contains("FF3") || saveType.FullName.Contains("FF5");
            mnuMaxMagicLevels.Visible = saveType.FullName.Contains("FF2");
            mnuMaxWeaponLevels.Visible = saveType.FullName.Contains("FF2");

            AddColumns();

            UpdateDisplay();
        }

        private void AddColumns() {
            var columns = new OrderedDictionary();

            if (saveType.FullName.Contains("FF1")) {
                columns.Add("Strength", "addtionalPower");
                columns.Add("Agility", "addtionalAgility");
                columns.Add("Stamina", "addtionalVitality");
                columns.Add("Intellect", "addtionalIntelligence");
                columns.Add("Luck", "addtionalLuck");
                columns.Add("Accuracy", "addtionalAccuracyRate");
                columns.Add("Evasion", "addtionalEvasionRate");
                columns.Add("Magic", "addtionalMagic");
                columns.Add("Spirit", "addtionalSpirit");
            } else if (saveType.FullName.Contains("FF2")) {
                columns.Add("Max MP", "addtionalMaxMp");
                columns.Add("Strength", "addtionalPower");
                columns.Add("Spirit", "addtionalSpirit");
                columns.Add("Intellect", "addtionalIntelligence");
                columns.Add("Stamina", "addtionalVitality");
                columns.Add("Agility", "addtionalAgility");
                columns.Add("Magic", "addtionalMagic");
            } else if (saveType.FullName.Contains("FF3")) {
                columns.Add("Strength", "addtionalPower");
                columns.Add("Agility", "addtionalAgility");
                columns.Add("Stamina", "addtionalVitality");
                columns.Add("Intellect", "addtionalIntelligence");
                columns.Add("Spirit", "addtionalSpirit");
            } else if (saveType.FullName.Contains("FF4")) {
                columns.Add("Strength", "addtionalPower");
                columns.Add("Agility", "addtionalAgility");
                columns.Add("Stamina", "addtionalVitality");
                columns.Add("Intellect", "addtionalIntelligence");
                columns.Add("Spirit", "addtionalSpirit");
            } else if (saveType.FullName.Contains("FF5")) {
                columns.Add("Max MP", "addtionalMaxMp");
                columns.Add("Strength", "addtionalPower");
                columns.Add("Agility", "addtionalAgility");
                columns.Add("Stamina", "addtionalVitality");
                columns.Add("Magic", "addtionalMagic");
            } else if (saveType.FullName.Contains("FF6")) {
                columns.Add("Max MP", "addtionalMaxMp");
                columns.Add("Strength", "addtionalPower");
                columns.Add("Agility", "addtionalAgility");
                columns.Add("Stamina", "addtionalVitality");
                columns.Add("Magic", "addtionalMagic");
            } else {
                columns.Add("MaxMp", "addtionalMaxMp");
                columns.Add("Power", "addtionalPower");
                columns.Add("Vitality", "addtionalVitality");
                columns.Add("Agility", "addtionalAgility");
                columns.Add("Weight", "addionalWeight");
                columns.Add("Intelligence", "addtionalIntelligence");
                columns.Add("Spirit", "addtionalSpirit");
                columns.Add("Attack", "addtionalAttack");
                columns.Add("Defense", "addtionalDefense");
                columns.Add("AbilityDefense", "addtionalAbilityDefense");
                columns.Add("AbilityEvasionRate", "addtionalAbilityEvasionRate");
                columns.Add("Magic", "addtionalMagic");
                columns.Add("Luck", "addtionalLuck");
                columns.Add("AccuracyRate", "addtionalAccuracyRate");
                columns.Add("EvasionRate", "addtionalEvasionRate");
                columns.Add("AbilityDisturbedRate", "addtionalAbilityDisturbedRate");
                columns.Add("CriticalRate", "addtionalCriticalRate");
                columns.Add("DamageDirmeter", "addtionalDamageDirmeter");
                columns.Add("AbilityDefenseRate", "addtionalAbilityDefenseRate");
                columns.Add("AccuracyCount", "addtionalAccuracyCount");
                columns.Add("EvasionCount", "addtionalEvasionCount");
                columns.Add("DefenseCount", "addtionalDefenseCount");
                columns.Add("MagicDefenseCount", "addtionalMagicDefenseCount");
            }

            foreach (DictionaryEntry column in columns) {
                var ch = new ColumnHeader();
                ch.Text = column.Key.ToString();
                ch.Tag = column.Value;
                ch.Width = 75;
                lvCharacters.Columns.Add(ch);
            }

            // First column is 100 wide, rest are 75 wide, then 50 for scrollbar
            this.Size = new Size(100 + ((lvCharacters.Columns.Count - 1) * 75) + 50, this.Size.Height);
        }

        private void AddJobAbilities(OwnedCharacterList_Target character, int jobId) {
            if (saveType.FullName.Contains("FF5")) {
                var abilityContentIds = new List<int>();

                // From learning.csv
                switch (jobId) {
                    case 2:
                        abilityContentIds.AddRange(new int[] { 345, 884, 349, 885, 343, 886, 327, });
                        break;
                    case 3:
                        abilityContentIds.AddRange(new int[] { 882, 333, 883, 338, 328, 329, 330, });
                        break;
                    case 4:
                        abilityContentIds.AddRange(new int[] { 947, 948, 949, 950, });
                        break;
                    case 5:
                        abilityContentIds.AddRange(new int[] { 924, 925, 926, 927, 928, 929, 331, });
                        break;
                    case 6:
                        abilityContentIds.AddRange(new int[] { 930, 931, 932, 933, 934, 935, 332, });
                        break;
                    case 7:
                        abilityContentIds.AddRange(new int[] { 337, 880, 334, 317, 318, 320, });
                        break;
                    case 8:
                        abilityContentIds.AddRange(new int[] { 889, 890, 344, 891, 335, });
                        break;
                    case 9:
                        abilityContentIds.AddRange(new int[] { 895, 896, 324, 897, });
                        break;
                    case 10:
                        abilityContentIds.AddRange(new int[] { 909, 346, 347, });
                        break;
                    case 11:
                        abilityContentIds.AddRange(new int[] { 887, 888, 321, });
                        break;
                    case 12:
                        abilityContentIds.AddRange(new int[] { 911, 326, 914, });
                        break;
                    case 13:
                        abilityContentIds.AddRange(new int[] { 942, 943, 944, 945, 946, 898, });
                        break;
                    case 14:
                        abilityContentIds.AddRange(new int[] { 342, 323, });
                        break;
                    case 15:
                        abilityContentIds.AddRange(new int[] { 892, 893, 339, 322, 894, });
                        break;
                    case 16:
                        abilityContentIds.AddRange(new int[] { 936, 937, 938, 939, 940, 941, 348, });
                        break;
                    case 17:
                        abilityContentIds.AddRange(new int[] { 336, 905, 906, 907, 908, });
                        break;
                    case 18:
                        abilityContentIds.AddRange(new int[] { 915, 916, 319, });
                        break;
                    case 19:
                        abilityContentIds.AddRange(new int[] { 899, 340, 951, 900, });
                        break;
                    case 20:
                        abilityContentIds.AddRange(new int[] { 341, 918, 919, 920, 921, 922, 923, });
                        break;
                    case 21:
                        abilityContentIds.AddRange(new int[] { 901, 902, 325, 903, });
                        break;
                    case 22:
                        abilityContentIds.AddRange(new int[] { 917, });
                        break;
                }

                if (abilityContentIds.Any()) {
                    foreach (int id in abilityContentIds) {
                        if (!character.learningAbilitys.target.Contains(id)) {
                            character.learningAbilitys.target.Add(id);
                        }
                    }
                }
            }
        }

        private int GetInt(string column, string name, int value, int min = 0, int max = int.MaxValue) {
            return Helpers.GetInt($"Enter a new {column} for {name}", column, value, min, max);
        }

        private void lvCharacters_MouseDoubleClick(object sender, MouseEventArgs e) {
            // From: https://stackoverflow.com/a/61779401/342378
            var hitInfo = lvCharacters.HitTest(e.Location);
            if ((hitInfo.SubItem == null) || string.IsNullOrEmpty(hitInfo.SubItem.Text)) {
                return;
            }

            int subItemIndex = hitInfo.Item.SubItems.IndexOf(hitInfo.SubItem);
            var column = lvCharacters.Columns[subItemIndex];

            var character = (OwnedCharacterList_Target)hitInfo.Item.Tag;

            switch (column.Tag) {
                case "name":
                    character.name = Helpers.GetString($"Enter a new {column.Text} for {character.name}", column.Text, character.name);
                    break;
                case "currentExp":
                    character.currentExp = GetInt(column.Text, character.name, character.currentExp, 0, 9999999);
                    break;
                case "addtionalLevel":
                    MessageBox.Show("Level is read-only and can be adjusted by changing the Experience instead", "Level", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "addtionalMaxHp":
                    character.parameter.addtionalMaxHp = GetInt(column.Text, character.name, character.parameter.addtionalMaxHp, 1, 9999);
                    character.parameter.currentHP = character.parameter.addtionalMaxHp;
                    break;
                case "addtionalMaxMp":
                    character.parameter.addtionalMaxMp = GetInt(column.Text, character.name, character.parameter.addtionalMaxMp, 0, 999);
                    character.parameter.currentMP = character.parameter.addtionalMaxMp;
                    break;
                default:
                    try {
                        var pi = character.parameter.GetType().GetProperty(column.Tag.ToString());
                        int oldValue = (int)pi.GetValue(character.parameter);

                        int newValue = GetInt(column.Text, character.name, oldValue, 0, 255);
                        pi.SetValue(character.parameter, newValue);
                    } catch (Exception ex) {
                        MessageBox.Show($"Unexpected tag in column header: '{column.Tag}'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    break;
            }

            UpdateDisplay();
        }

        private void mnuAddAllMagic_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Are you sure you want to add all magic?", "Confirm Add All Magic", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) {
                return;
            }

            if (saveType.FullName.Contains("FF5")) {
                foreach (var magic in Magics.GetMagics(saveType)) {
                    if (!userData.ownedMagicList.target.Contains(magic.contentId)) {
                        userData.ownedMagicList.target.Add(magic.contentId);
                    }
                    if (!userData.learnedAbilityList.target.Contains(magic.abilityId)) {
                        userData.learnedAbilityList.target.Add(magic.abilityId);
                    }
                    foreach (ListViewItem lvi in lvCharacters.Items) {
                        var character = (OwnedCharacterList_Target)lvi.Tag;

                        // Add magic
                        if (!character.abilityList.target.Any(x => x.contentId == magic.contentId)) {
                            character.abilityList.target.Add(new AbilityList_Target() {
                                abilityId = magic.abilityId,
                                contentId = magic.contentId,
                                skillLevel = 0, // Not used in FF5
                            });
                        }
                        if (!character.additionOrderOwnedAbilityIds.target.Contains(magic.contentId)) {
                            // Name says AbilityIds but game seems to store ContentIds
                            character.additionOrderOwnedAbilityIds.target.Add(magic.contentId);
                        }
                    }
                }
            } else {
                MessageBox.Show("Not Implemented Yet");
            }

            MessageBox.Show("Success!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mnuMaxCharacterStats_Click(object sender, EventArgs e) {
            if (lvCharacters.SelectedItems.Count == 0) {
                return;
            }

            if (MessageBox.Show("Are you sure you want to max the character stats?", "Confirm Max Character Stats", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) {
                return;
            }

            foreach (ListViewItem lvi in lvCharacters.SelectedItems) {
                var character = (OwnedCharacterList_Target)lvi.Tag;

                foreach (ColumnHeader column in lvCharacters.Columns) {
                    switch (column.Tag) {
                        case "name":
                            // Do not modify
                            break;
                        case "currentExp":
                            character.currentExp = 9999999;
                            break;
                        case "addtionalLevel":
                            // Do not modify
                            break;
                        case "addtionalMaxHp":
                            character.parameter.addtionalMaxHp = 9999;
                            character.parameter.currentHP = character.parameter.addtionalMaxHp;
                            break;
                        case "addtionalMaxMp":
                            character.parameter.addtionalMaxMp = 999;
                            character.parameter.currentMP = character.parameter.addtionalMaxMp;
                            break;
                        default:
                            try {
                                var pi = character.parameter.GetType().GetProperty(column.Tag.ToString());
                                pi.SetValue(character.parameter, 255);
                            } catch (Exception ex) {
                                MessageBox.Show($"Unexpected tag in column header: '{column.Tag}'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            break;
                    }
                }
            }

            UpdateDisplay();
        }

        private void mnuMaxJobLevels_Click(object sender, EventArgs e) {
            if (lvCharacters.SelectedItems.Count == 0) {
                return;
            }

            if (MessageBox.Show("Are you sure you want to max job levels?", "Confirm Max Job Levels", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) {
                return;
            }

            foreach (ListViewItem lvi in lvCharacters.SelectedItems) {
                var character = (OwnedCharacterList_Target)lvi.Tag;

                // Max jobs
                for (int i = 0; i < character.jobList.target.Count; i++) {
                    character.jobList.target[i].currentProficiency = 9999;

                    // In FF5 each job level adds abilities, which the game doesn't add automatically if you cheat
                    AddJobAbilities(character, character.jobList.target[i].id);
                }
            }

            MessageBox.Show("Success!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mnuMaxMagicLevels_Click(object sender, EventArgs e) {
            if (lvCharacters.SelectedItems.Count == 0) {
                return;
            }

            if (MessageBox.Show("Are you sure you want to max magic levels?", "Confirm Max Magic Levels", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) {
                return;
            }

            foreach (ListViewItem lvi in lvCharacters.SelectedItems) {
                var character = (OwnedCharacterList_Target)lvi.Tag;

                // Max magic levels for equipped spells
                for (int i = 0; i < character.abilityDictionary.values.First().target.Count; i++) {
                    var abilityDict = character.abilityDictionary.values.First().target[i];

                    // Ensure this is a magical ability (5 is level 1 fire, 644 is level 16 ultima)
                    if ((abilityDict.abilityId >= 5) && (abilityDict.abilityId <= 644)) {
                        var abilityList = character.abilityList.target.Single(x => x.abilityId == abilityDict.abilityId);

                        // Will result in 0 for level 16, so we only adjust > 0 values
                        var level = (abilityDict.abilityId - 4) % 16;
                        if (level > 0) {
                            // Calculate how many levels this spell needs to raise, then raise it
                            int offset = 16 - level;

                            abilityDict.abilityId += offset;
                            abilityDict.contentId += offset;
                            abilityDict.skillLevel = 860;

                            abilityList.abilityId += offset;
                            abilityList.contentId += offset;
                            abilityList.skillLevel = 860;
                        }
                    }
                }
            }

            MessageBox.Show("Success!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mnuMaxWeaponLevels_Click(object sender, EventArgs e) {
            if (lvCharacters.SelectedItems.Count == 0) {
                return;
            }

            if (MessageBox.Show("Are you sure you want to max weapon levels?", "Confirm Max Weapon Levels", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) {
                return;
            }

            foreach (ListViewItem lvi in lvCharacters.SelectedItems) {
                var character = (OwnedCharacterList_Target)lvi.Tag;

                // Max weapon levels
                for (int i = 0; i < character.skillLevelTargets.values.Count; i++) {
                    character.skillLevelTargets.values[i] = 860;
                }
            }

            MessageBox.Show("Success!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UpdateDisplay() {
            lvCharacters.Items.Clear();

            foreach (var character in characters.Where(x => x.isEnableCorps)) {
                var lvi = new ListViewItem();

                lvi.Tag = character;
                lvi.Text = character.name;

                // Can't seem to order columns by DisplayIndex without putting them into a list first
                var columns = new List<ColumnHeader>();
                foreach (ColumnHeader column in lvCharacters.Columns) {
                    columns.Add(column);
                }

                foreach (var column in columns.OrderBy(x => x.DisplayIndex)) {
                    switch (column.Tag) {
                        case "name":
                            // Do nothing, name is already added as lvi.Text
                            break;
                        case "currentExp":
                            lvi.SubItems.Add(character.currentExp.ToString("n0"));
                            break;
                        default:
                            try {
                                var pi = character.parameter.GetType().GetProperty(column.Tag.ToString());
                                lvi.SubItems.Add(((int)pi.GetValue(character.parameter)).ToString("n0"));
                            } catch (Exception ex) {
                                throw new Exception($"Unexpected tag in column header: '{column.Tag}'");
                            }
                            break;
                    }
                }

                lvCharacters.Items.Add(lvi);
            }
        }
    }
}
