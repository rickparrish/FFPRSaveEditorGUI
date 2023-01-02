namespace FFPRSaveEditorGUI {
    public class NormalItems {
        public static Dictionary<int, string> FF1Items = new Dictionary<int, string>() {
            { 2, "Potion" },
            { 3, "Hi-Potion" },
            { 4, "X-Potion" },
            { 5, "Ether" },
            { 7, "Dry Ether" },
            { 8, "Elixir" },
            { 10, "Phoenix Down" },
            { 11, "Antidote" },
            { 12, "Eye Drops" },
            { 13, "Echo Grass" },
            { 14, "Gold Needle" },
            { 15, "Remedy" },
            { 17, "Sleeping Bag" },
            { 18, "Tent" },
            { 19, "Cottage" },
            { 62, "N/A (Unequipped weapon)" },
            { 80, "Razer" },
            { 82, "Vorpal Sword" },
            { 83, "Flame Sword" },
            { 86, "Ice Brand" },
            { 87, "Defender" },
            { 89, "Sun Blade" },
            { 92, "Excalibur" },
            { 100, "Sasuke's Blade" },
            { 103, "Masamune" },
            { 110, "Light Axe" },
            { 115, "Mythril Hammer" },
            { 116, "Thor's Hammer" },
            { 119, "Healing Staff" },
            { 121, "Mage's Staff" },
            { 123, "Wizard's Staff" },
            { 130, "N/A (Unequipped shield)" },
            { 131, "N/A (Unequipped body)" },
            { 132, "N/A (Unequipped head)" },
            { 133, "N/A (Unequipped arms)" },
            { 134, "Clothes" },
            { 136, "White Robe" },
            { 137, "Black Robe" },
            { 149, "Ice Armor" },
            { 150, "Flame Mail" },
            { 153, "Diamond Armor" },
            { 154, "Dragon Mail" },
            { 158, "Ruby Armlet" },
            { 160, "Diamond Armlet" },
            { 162, "Buckler" },
            { 165, "Ice Shield" },
            { 166, "Flame Shield" },
            { 168, "Diamond Shield" },
            { 170, "Aegis Shield" },
            { 173, "Protect Cloak" },
            { 175, "Leather Cap" },
            { 183, "Ribbon" },
            { 186, "Healing Helm" },
            { 187, "Mythril Helm" },
            { 188, "Diamond Helm" },
            { 194, "Gauntlets" },
            { 195, "Giant's Gloves" },
            { 198, "Diamond Gloves" },
            { 202, "Protect Ring" },
        };

        public static string GetName(int contentId, Type saveType) {
            if (saveType.FullName.Contains("FF1")) {
                return FF1Items.ContainsKey(contentId) ? FF1Items[contentId] : $"Unknown Item #{contentId:d3}";
            } else {
                return $"Unknown Item #{contentId:d3}";
            }
        }
    }
}
