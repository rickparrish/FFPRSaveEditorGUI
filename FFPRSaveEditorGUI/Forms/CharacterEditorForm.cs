// In FF1 parameter.currentMpCountList and addtionalMaxMpCountList has an array for the MP available at each level

// TODOX List:
// - Add a button to max the stats for the selected character
// - Add a button to max the stats for all characters

using FFPRSaveEditor.Common.Models;
using System.Collections;
using System.Collections.Specialized;
using System.Data;

namespace FFPRSaveEditorGUI.Forms {
    public partial class CharacterEditorForm : Form {
        private List<OwnedCharacterList_Target> characters;

        public CharacterEditorForm() {
            InitializeComponent();
        }

        public CharacterEditorForm(List<OwnedCharacterList_Target> characters, Type saveType) {
            InitializeComponent();

            this.characters = characters;

            AddColumns(saveType);

            UpdateDisplay();
        }

        private void AddColumns(Type saveType) {
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
                // TODOX Not 100% sure on the stat names, need a look at the stats screen
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
                // TODOX Not 100% sure on the stat names, need a look at the stats screen
                columns.Add("Max MP", "addtionalMaxMp");
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
                    character.currentExp = GetInt(column.Text, character.name, character.currentExp);
                    break;
                case "addtionalLevel":
                    MessageBox.Show("Level is read-only and can be adjusted by changing the Experience instead", "Level", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "addtionalMaxHp":
                    character.parameter.addtionalMaxHp = GetInt(column.Text, character.name, character.parameter.addtionalMaxHp, 1, 9999);
                    character.parameter.currentHP = character.parameter.addtionalMaxHp;
                    break;
                case "addtionalMaxMp":
                    character.parameter.addtionalMaxMp = GetInt(column.Text, character.name, character.parameter.addtionalMaxMp, 0, 9999);
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
