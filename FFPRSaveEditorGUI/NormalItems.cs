﻿// TODOX List:
// - Maybe have a custom class instead of Dictionary<int, string>, so then we can also record the group (ie potion or sword or shield)
//   and maybe also the details like potion heals 50, sword adds +10 power, relic adds +2 magic, etc.

namespace FFPRSaveEditorGUI {
    public class NormalItems {
        public static string GetName(int contentId, Type saveType) {
            if (saveType.FullName.Contains("FF1")) {
                return FF1Items.ContainsKey(contentId) ? FF1Items[contentId] : $"Unknown Item #{contentId:d3}";
            } else if (saveType.FullName.Contains("FF2")) {
                return FF2Items.ContainsKey(contentId) ? FF2Items[contentId] : $"Unknown Item #{contentId:d3}";
            } else if (saveType.FullName.Contains("FF3")) {
                return FF3Items.ContainsKey(contentId) ? FF3Items[contentId] : $"Unknown Item #{contentId:d3}";
            } else if (saveType.FullName.Contains("FF4")) {
                return FF4Items.ContainsKey(contentId) ? FF4Items[contentId] : $"Unknown Item #{contentId:d3}";
            } else if (saveType.FullName.Contains("FF5")) {
                return FF5Items.ContainsKey(contentId) ? FF5Items[contentId] : $"Unknown Item #{contentId:d3}";
            } else if (saveType.FullName.Contains("FF6")) {
                return FF6Items.ContainsKey(contentId) ? FF6Items[contentId] : $"Unknown Item #{contentId:d3}";
            } else {
                return $"Unknown Item #{contentId:d3}";
            }
        }
        
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

        // TODOX No items for FF2 yet
        public static Dictionary<int, string> FF2Items = new Dictionary<int, string>() {
        };

        // TODOX No items for FF3 yet
        public static Dictionary<int, string> FF3Items = new Dictionary<int, string>() {
        };

        public static Dictionary<int, string> FF4Items = new Dictionary<int, string>() {
            { 2, "Potion" },
            { 3, "Hi-Potion" },
            { 4, "X-Potion" },
            { 5, "Ether" },
            { 6, "Dry Ether" },
            { 7, "Elixir" },
            { 9, "Phoenix Down" },
            { 10, "Gold Needle" },
            { 11, "Maiden's Kiss" },
            { 12, "Mallet" },
            { 13, "Diet Food" },
            { 14, "Echo Herbs" },
            { 15, "Eye Drops" },
            { 16, "Antidote" },
            { 17, "Cross" },
            { 18, "Remedy" },
            { 19, "Alarm Clock" },
            { 20, "Unicorn Horn" },
            { 21, "Tent" },
            { 22, "Cottage" },
            { 23, "Emergency Exit" },
            { 24, "Dwarven Bread" },
            { 25, "Gysahl Greens" },
            { 26, "Gysahl Whistle" },
            { 29, "Soma Drop" },
            { 30, "Siren" },
            { 33, "Red Fang" },
            { 34, "White Fang" },
            { 35, "Blue Fang" },
            { 36, "Bomb Fragment" },
            { 37, "Bomb Arm" },
            { 38, "Antarctic Wind" },
            { 39, "Arctic Wind" },
            { 40, "Zeus's Wrath" },
            { 41, "Rage of the Gods" },
            { 43, "Bomb Core" },
            { 44, "Stardust" },
            { 45, "Lilith's Kiss" },
            { 46, "Vampire Fang" },
            { 47, "Spider's Silk" },
            { 48, "Bell of Silence" },
            { 49, "Coeurl Whisker" },
            { 50, "Bestiary" },
            { 51, "Hourglass" },
            { 52, "Silver Hourglass" },
            { 54, "Bacchus's Cider" },
            { 55, "Hermes Shoes" },
            { 56, "Decoy" },
            { 57, "Light Curtain" },
            { 58, "Lunar Curtain" },
            { 127, "N/A (Unequipped weapon)" },
            { 132, "Light Sword" },
            { 133, "Excalibur" },
            { 134, "Ragnarok" },
            { 135, "Ancient Sword" },
            { 136, "Blood Sword" },
            { 137, "Mythril Sword" },
            { 138, "Sleep Blade" },
            { 139, "Flame Sword" },
            { 140, "Icebrand" },
            { 142, "Avenger" },
            { 143, "Defender" },
            { 149, "Wind Spear" },
            { 150, "Fire Lance" },
            { 151, "Ice Lance" },
            { 152, "Blood Lance" },
            { 153, "Gungnir" },
            { 154, "Wyvern Lance" },
            { 155, "Holy Lance" },
            { 156, "Mythril Knife" },
            { 158, "Mage Masher" },
            { 159, "Knife" },
            { 160, "Dreamer's Harp" },
            { 161, "Lamia's Harp" },
            { 164, "Thunder Claw" },
            { 165, "Fairy Claw" },
            { 166, "Hell Claw" },
            { 167, "Cat Claw" },
            { 169, "Mythril Hammer" },
            { 170, "Gaia Hammer" },
            { 171, "Dwarven Axe" },
            { 172, "Ogrekiller" },
            { 173, "Poison Axe" },
            { 175, "Kunai" },
            { 176, "Ashura" },
            { 177, "Kotetsu" },
            { 178, "Kikuichimonji" },
            { 179, "Murasame" },
            { 180, "Masamune" },
            { 186, "Rod of Change" },
            { 187, "Fairy Rod" },
            { 188, "Stardust Rod" },
            { 189, "Staff" },
            { 190, "Healing Staff" },
            { 191, "Mythril Staff" },
            { 193, "Kinesis Staff" },
            { 194, "Sage's Staff" },
            { 198, "Great Bow" },
            { 199, "Killer Bow" },
            { 200, "Elven Bow" },
            { 201, "Yoichi's Bow" },
            { 205, "Holy Arrow" },
            { 206, "Fire Arrow" },
            { 207, "Ice Arrow" },
            { 208, "Thunder Arrow" },
            { 209, "Blinding Arrow" },
            { 210, "Poison Arrow" },
            { 211, "Mute Arrow" },
            { 212, "Angel Arrow" },
            { 213, "Yoichi Arrow" },
            { 214, "Artemis Arrow" },
            { 215, "Whip" },
            { 216, "Chain Whip" },
            { 218, "Flame Whip" },
            { 221, "Moonring Blade" },
            { 222, "Shuriken" },
            { 223, "Fuma Shuriken" },
            { 224, "N/A (Unequipped shield)" },
            { 225, "N/A (Unequipped body)" },
            { 226, "N/A (Unequipped head)" },
            { 227, "N/A (Unequipped arms)" },
            { 230, "Demon Shield" },
            { 231, "Light Shield" },
            { 232, "Mythril Shield" },
            { 233, "Flame Shield" },
            { 234, "Ice Shield" },
            { 235, "Diamond Shield" },
            { 237, "Genji Shield" },
            { 238, "Dragon Shield" },
            { 239, "Crystal Shield" },
            { 241, "Leather Cap" },
            { 242, "Headband" },
            { 243, "Feathered Cap" },
            { 245, "Wizard's Hat" },
            { 246, "Green Beret" },
            { 247, "Dark Helm" },
            { 249, "Sage's Miter" },
            { 250, "Black Cowl" },
            { 251, "Demon Helm" },
            { 252, "Light Helm" },
            { 253, "Gold Hairpin" },
            { 254, "Mythril Helm" },
            { 255, "Diamond Helm" },
            { 256, "Ribbon" },
            { 257, "Genji Helm" },
            { 258, "Dragon Helm" },
            { 259, "Crystal Helm" },
            { 265, "Bard's Tunic" },
            { 266, "Gaia Gear" },
            { 269, "Sage's Surplice" },
            { 270, "Kenpo Gi" },
            { 273, "Demon Armor" },
            { 274, "Black Belt Gi" },
            { 275, "Knight's Amor" },
            { 276, "Light Robe" },
            { 277, "Mythril Armor" },
            { 278, "Flame Mail" },
            { 280, "Ice Armour" },
            { 281, "White Robe" },
            { 282, "Diamond Armour" },
            { 283, "Minerva Bustier" },
            { 284, "Genji Armour" },
            { 285, "Dragon Mail" },
            { 286, "Black Garb" },
            { 287, "Crystal Mail" },
            { 288, "Adamant Armor" },
            { 290, "Ruby Ring" },
            { 295, "Power Armlet" },
            { 297, "Demon Gloves" },
            { 298, "Silver Armlet" },
            { 300, "Rune Armlet" },
            { 301, "Mythril Gloves" },
            { 302, "Diamond Armlet" },
            { 303, "Diamond Gloves" },
            { 304, "Genji Gloves" },
            { 305, "Dragon Gloves" },
            { 306, "Giant's Gloves" },
            { 307, "Crystal Gloves" },
            { 308, "Protect Ring" },
            { 520, "Grimoire" },
        };

        // TODOX No items for FF5 yet
        public static Dictionary<int, string> FF5Items = new Dictionary<int, string>() {
        };

        public static Dictionary<int, string> FF6Items = new Dictionary<int, string>() {
            { 2, "Potion" },
            { 3, "Hi-Potion" },
            { 4, "X-Potion" },
            { 5, "Ether" },
            { 6, "Hi-Ether" },
            { 7, "X-Ether" },
            { 8, "Elixir" },
            { 9, "Megalixir" },
            { 10, "Phoenix Down" },
            { 11, "Holy Water" },
            { 12, "Antidote" },
            { 13, "Eye Drops" },
            { 14, "Gold Needle" },
            { 15, "Remedy" },
            { 16, "Sleeping Bag" },
            { 17, "Tent" },
            { 18, "Green Cherry" },
            { 19, "Magicite Shard" },
            { 21, "Echo Screen" },
            { 22, "Smoke Bomb" },
            { 23, "Teleport Stone" },
            { 24, "Dried Meat" },
            { 25, "Rename Card" },
            { 26, "Flame Scroll" },
            { 27, "Water Scroll" },
            { 28, "Lightning Scroll" },
            { 29, "Invisibility Scroll" },
            { 31, "Noiseblaster" },
            { 32, "Bioblaster" },
            { 33, "Flash" },
            { 34, "Chainsaw" },
            { 35, "Debilitator" },
            { 36, "Drill" },
            { 37, "Air Anchor" },
            { 38, "Auto Crossbow" },
            { 93, "N/A" },
            { 94, "Dagger" },
            { 95, "Mythril Knife" },
            { 96, "Main Gauche" },
            { 97, "Air Knife" },
            { 98, "Thief's Knife" },
            { 99, "Assassin's Dagger" },
            { 100, "Man-Eater" },
            { 101, "Swordbreaker" },
            { 102, "Gladius" },
            { 103, "Valiant Knife" },
            { 104, "Mythril Sword" },
            { 105, "Great Sword" },
            { 106, "Rune Blade" },
            { 107, "Flametongue" },
            { 108, "Icebrand" },
            { 109, "Thunder Blade" },
            { 110, "Bastard Sword" },
            { 111, "Stoneblade" },
            { 112, "Blood Sword" },
            { 113, "Enhancer" },
            { 115, "Falchion" },
            { 116, "Soul Saber" },
            { 118, "Excalibur" },
            { 119, "Zantetsuken" },
            { 122, "Ultima Weapon" },
            { 123, "Mythril Spear" },
            { 125, "Heavy Lance" },
            { 126, "Partisan" },
            { 127, "Holy Lance" },
            { 128, "Golden Spear" },
            { 129, "Radiant Lance" },
            { 130, "Impartisan" },
            { 131, "Kunai" },
            { 134, "Sasuke" },
            { 135, "Ichigeki" },
            { 136, "Kagenui" },
            { 137, "Ashura" },
            { 138, "Kotetsu" },
            { 140, "Kazekiri" },
            { 142, "Masamune" },
            { 143, "Murakumo" },
            { 144, "Mutsunokami" },
            { 145, "Healing Rod" },
            { 146, "Mythril Rod" },
            { 147, "Flame Rod" },
            { 148, "Ice Rod" },
            { 150, "Poison Rod" },
            { 151, "Holy Rod" },
            { 152, "Gravity Rod" },
            { 153, "Punisher" },
            { 154, "Magus Rod" },
            { 155, "Chocobo Brush" },
            { 157, "Magical Brush" },
            { 158, "Rainbow Brush" },
            { 159, "Shuriken" },
            { 160, "Fuma Shuriken" },
            { 161, "Pinwheel" },
            { 162, "Chain Flail" },
            { 164, "Morning Star" },
            { 165, "Boomerang" },
            { 167, "Hawkeye" },
            { 168, "N/A" },
            { 170, "Wing Edge" },
            { 171, "Cards" },
            { 172, "Darts" },
            { 173, "Death Tarot" },
            { 174, "Viper Darts" },
            { 175, "Dice" },
            { 176, "Fixed Dice" },
            { 177, "Metal Knuckles" },
            { 178, "Mythril Claws" },
            { 181, "Burning Fist" },
            { 182, "Dragon Claws" },
            { 183, "Tigerfang" },
            { 197, "N/A" },
            { 198, "N/A" },
            { 199, "N/A" },
            { 200, "N/A" },
            { 201, "Buckler" },
            { 202, "Heavy Shield" },
            { 203, "Mythril Shield" },
            { 204, "Golden Shield" },
            { 205, "Aegis Shield" },
            { 206, "Diamond Shield" },
            { 207, "Flame Shield" },
            { 208, "Ice Shield" },
            { 209, "Thunder Shield" },
            { 210, "Crystal Shield" },
            { 211, "Genji Shield" },
            { 213, "Cursed Shield" },
            { 215, "Force Shield" },
            { 216, "Leather Cap" },
            { 217, "Hairband" },
            { 218, "Plumed Hat" },
            { 219, "Beret" },
            { 221, "Bandana" },
            { 222, "Iron Helm" },
            { 223, "Hypno Crown" },
            { 224, "Priest's Miter" },
            { 225, "Green Beret" },
            { 227, "Mythril Helm" },
            { 229, "Golden Helm" },
            { 230, "Tiger Mask" },
            { 231, "Red Cap" },
            { 232, "Mystery Veil" },
            { 233, "Circlet" },
            { 234, "Royal Crown" },
            { 235, "Diamond Helm" },
            { 236, "Black Cowl" },
            { 237, "Crystal Helm" },
            { 238, "Oath Veil" },
            { 240, "Genji Helm" },
            { 244, "Leather Armor" },
            { 245, "Cotton Robe" },
            { 246, "Kenpo Gi" },
            { 247, "Iron Armor" },
            { 248, "Silk Robe" },
            { 249, "Mythril Vest" },
            { 250, "Ninja Gear" },
            { 251, "White Dress" },
            { 253, "Gaia Gear" },
            { 255, "Golden Armor" },
            { 258, "Diamond Vest" },
            { 259, "Red Jacket" },
            { 260, "Force Armor" },
            { 261, "Diamond Armor" },
            { 262, "Black Garb" },
            { 264, "Crystal Mail" },
            { 266, "Genji Armor" },
            { 268, "Minerva Bustier" },
            { 269, "Tabby Suit" },
            { 270, "Chocobo Suit" },
            { 271, "Moogle Suit" },
            { 272, "Nutkin Suit" },
            { 273, "Behemoth Suit" },
            { 274, "Silver Spectales" },
            { 275, "Silver Spectales" },
            { 276, "Star Pendant" },
            { 277, "Peace Ring" },
            { 278, "Amulet" },
            { 279, "White Cape" },
            { 280, "Jeweled Ring" },
            { 282, "Barrier Ring" },
            { 283, "Mythril Glove" },
            { 285, "Hermes Sandals" },
            { 286, "Reflect Ring" },
            { 287, "Angel Wings" },
            { 288, "Angel Ring" },
            { 289, "Knight's Code" },
            { 290, "Dragoon Boots" },
            { 291, "Zephyr Cloak" },
            { 292, "Princess Ring" },
            { 294, "Earring" },
            { 295, "Gigas Glove" },
            { 296, "Blizzard Orb" },
            { 297, "Berserker Ring" },
            { 298, "Thief's Bracer" },
            { 299, "Guard Bracelet" },
            { 300, "Hero's Ring" },
            { 301, "Ribbon" },
            { 302, "Muscle Belt" },
            { 303, "Crystal Orb" },
            { 304, "Gold Hairpin" },
            { 305, "Celestriad" },
            { 306, "Brigand's Glove" },
            { 307, "Gauntlet" },
            { 308, "Genji Glove" },
            { 309, "Hyper Wrist" },
            { 310, "Master's Scroll" },
            { 311, "Prayer Beads" },
            { 312, "Black Belt" },
            { 313, "Heiji's Jitte" },
            { 314, "Fake Mustache" },
            { 318, "Memento Ring" },
            { 319, "Safety Bit" },
            { 320, "Lich Ring" },
            { 321, "Molulu's Charm" },
            { 322, "Ward Bangle" },
            { 324, "Alarm Earring" },
            { 325, "Gale Hairpin" },
            { 326, "Sniper Eye" },
            { 327, "Growth Egg" },
        };
    }
}