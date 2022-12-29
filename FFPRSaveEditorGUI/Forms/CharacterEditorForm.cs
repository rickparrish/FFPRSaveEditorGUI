// In FF1 parameter.currentMpCountList and addtionalMaxMpCountList has an array for the MP available at each level

using FFPRSaveEditor.Common.Models.BaseModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            } else if (saveType.FullName.Contains("FF4")) {
                columns.Add("Strength", "addtionalPower");
                columns.Add("Agility", "addtionalAgility");
                columns.Add("Stamina", "addtionalVitality");
                columns.Add("Intellect", "addtionalIntelligence");
                columns.Add("Spirit", "addtionalSpirit");
            } else if (saveType.FullName.Contains("FF6")) {
                columns.Add("Max MP", "addtionalMaxMp");
                columns.Add("Strength", "addtionalPower");
                columns.Add("Agility", "addtionalAgility");
                columns.Add("Stamina", "addtionalVitality");
                columns.Add("Magic", "addtionalMagic");
            } else {
                throw new Exception($"Unexpected saveType '{saveType.FullName}'");
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
                case "addtionalPower":
                    character.parameter.addtionalPower = GetInt(column.Text, character.name, character.parameter.addtionalPower, 0, 255);
                    break;
                case "addtionalVitality":
                    character.parameter.addtionalVitality = GetInt(column.Text, character.name, character.parameter.addtionalVitality, 0, 255);
                    break;
                case "addtionalAgility":
                    character.parameter.addtionalAgility = GetInt(column.Text, character.name, character.parameter.addtionalAgility, 0, 255);
                    break;
                case "addtionalIntelligence":
                    character.parameter.addtionalIntelligence = GetInt(column.Text, character.name, character.parameter.addtionalIntelligence, 0, 255);
                    break;
                case "addtionalSpirit":
                    character.parameter.addtionalSpirit = GetInt(column.Text, character.name, character.parameter.addtionalSpirit, 0, 255);
                    break;
                case "addtionalMagic":
                    character.parameter.addtionalMagic = GetInt(column.Text, character.name, character.parameter.addtionalMagic, 0, 255);
                    break;
                case "addtionalLuck":
                    character.parameter.addtionalLuck = GetInt(column.Text, character.name, character.parameter.addtionalLuck, 0, 255);
                    break;
                case "addtionalAccuracyRate":
                    character.parameter.addtionalAccuracyRate = GetInt(column.Text, character.name, character.parameter.addtionalAccuracyRate, 0, 255);
                    break;
                case "addtionalEvasionRate":
                    character.parameter.addtionalEvasionRate = GetInt(column.Text, character.name, character.parameter.addtionalEvasionRate, 0, 255);
                    break;
                default:
                    MessageBox.Show($"Unexpected tag in column header: '{column.Tag}'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                        case "addtionalLevel":
                            lvi.SubItems.Add(character.parameter.addtionalLevel.ToString("n0"));
                            break;
                        case "addtionalMaxHp":
                            lvi.SubItems.Add(character.parameter.addtionalMaxHp.ToString("n0"));
                            break;
                        case "addtionalMaxMp":
                            lvi.SubItems.Add(character.parameter.addtionalMaxMp.ToString("n0"));
                            break;
                        case "addtionalPower":
                            lvi.SubItems.Add(character.parameter.addtionalPower.ToString("n0"));
                            break;
                        case "addtionalVitality":
                            lvi.SubItems.Add(character.parameter.addtionalVitality.ToString("n0"));
                            break;
                        case "addtionalAgility":
                            lvi.SubItems.Add(character.parameter.addtionalAgility.ToString("n0"));
                            break;
                        case "addtionalIntelligence":
                            lvi.SubItems.Add(character.parameter.addtionalIntelligence.ToString("n0"));
                            break;
                        case "addtionalSpirit":
                            lvi.SubItems.Add(character.parameter.addtionalSpirit.ToString("n0"));
                            break;
                        case "addtionalMagic":
                            lvi.SubItems.Add(character.parameter.addtionalMagic.ToString("n0"));
                            break;
                        case "addtionalLuck":
                            lvi.SubItems.Add(character.parameter.addtionalLuck.ToString("n0"));
                            break;
                        case "addtionalAccuracyRate":
                            lvi.SubItems.Add(character.parameter.addtionalAccuracyRate.ToString("n0"));
                            break;
                        case "addtionalEvasionRate":
                            lvi.SubItems.Add(character.parameter.addtionalEvasionRate.ToString("n0"));
                            break;
                        default:
                            throw new Exception($"Unexpected tag in column header: '{column.Tag}'");
                    }
                }

                lvCharacters.Items.Add(lvi);
            }
        }
    }
}
