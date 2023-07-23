﻿namespace FFPRSaveEditorGUI {
    public class Magic {
        public int contentId { get; set; }
        public int abilityId { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Magics {
        public static Magic GetMagic(int contentId, int abilityId, Type saveType) {
            Magic magic = null;

            if (saveType.FullName.Contains("FF1")) {
                // TODOX magic = FF1Magics.SingleOrDefault(x => x.contentId == contentId);
            } else if (saveType.FullName.Contains("FF2")) {
                // TODOX magic = FF2Magics.SingleOrDefault(x => x.contentId == contentId);
            } else if (saveType.FullName.Contains("FF3")) {
                // TODOX magic = FF3Magics.SingleOrDefault(x => x.contentId == contentId);
            } else if (saveType.FullName.Contains("FF4")) {
                // TODOX magic = FF4Magics.SingleOrDefault(x => x.contentId == contentId);
            } else if (saveType.FullName.Contains("FF5")) {
                magic = FF5Magics.SingleOrDefault(x => x.contentId == contentId);
            } else if (saveType.FullName.Contains("FF6")) {
                // TODOX magic = FF6Magics.SingleOrDefault(x => x.contentId == contentId);
            }

            return magic != null ? magic : new Magic() { contentId = contentId, abilityId = abilityId, name = $"Unknown Magic #{contentId:d3}", description = "Unknown", type = "Unknown" };
        }

        public static List<Magic> GetMagics(Type saveType) {
            if (saveType.FullName.Contains("FF1")) {
                // TODOX return FF1Magics;
            } else if (saveType.FullName.Contains("FF2")) {
                // TODOX return FF2Magics;
            } else if (saveType.FullName.Contains("FF3")) {
                // TODOX return FF3Magics;
            } else if (saveType.FullName.Contains("FF4")) {
                // TODOX return FF4Magics;
            } else if (saveType.FullName.Contains("FF5")) {
                return FF5Magics;
            } else if (saveType.FullName.Contains("FF6")) {
                // TODOX return FF6Magics;
            }

            return null;
        }

        #region Magic Classes
        public static List<Magic> FF5Magics = new List<Magic>() {
            new Magic() { contentId = 356, abilityId = 90, name = "Fire", type = "Magic - Spellblade", description = "Enchants blade to deal fire damage." },
            new Magic() { contentId = 357, abilityId = 91, name = "Blizzard", type = "Magic - Spellblade", description = "Enchants blade to deal ice damage." },
            new Magic() { contentId = 358, abilityId = 92, name = "Thunder", type = "Magic - Spellblade", description = "Enchants blade to deal lightning damage." },
            new Magic() { contentId = 359, abilityId = 93, name = "Poison", type = "Magic - Spellblade", description = "Enchants blade to deal viral damage and cause poison." },
            new Magic() { contentId = 360, abilityId = 94, name = "Silence", type = "Magic - Spellblade", description = "Enchants blade to cause silence." },
            new Magic() { contentId = 361, abilityId = 95, name = "Sleep", type = "Magic - Spellblade", description = "Enchants blade to cause sleep." },
            new Magic() { contentId = 362, abilityId = 96, name = "Fira", type = "Magic - Spellblade", description = "Enchants blade to deal fire damage." },
            new Magic() { contentId = 363, abilityId = 97, name = "Blizzara", type = "Magic - Spellblade", description = "Enchants blade to deal ice damage." },
            new Magic() { contentId = 364, abilityId = 98, name = "Thundara", type = "Magic - Spellblade", description = "Enchants blade to deal lightning damage." },
            new Magic() { contentId = 365, abilityId = 99, name = "Drain", type = "Magic - Spellblade", description = "Enchants blade to absorb HP." },
            new Magic() { contentId = 366, abilityId = 100, name = "Break", type = "Magic - Spellblade", description = "Enchants blade to cause petrification." },
            new Magic() { contentId = 367, abilityId = 101, name = "Bio", type = "Magic - Spellblade", description = "Enchants blade to deal viral damage." },
            new Magic() { contentId = 368, abilityId = 102, name = "Firaga", type = "Magic - Spellblade", description = "Enchants blade to deal fire damage." },
            new Magic() { contentId = 369, abilityId = 103, name = "Blizzaga", type = "Magic - Spellblade", description = "Enchants blade to deal ice damage." },
            new Magic() { contentId = 370, abilityId = 104, name = "Thundaga", type = "Magic - Spellblade", description = "Enchants blade to deal lightning damage." },
            new Magic() { contentId = 371, abilityId = 105, name = "Holy", type = "Magic - Spellblade", description = "Enchants blade to deal holy damage." },
            new Magic() { contentId = 372, abilityId = 106, name = "Flare", type = "Magic - Spellblade", description = "Increases attack and enchants blade to reduce the enemy's defense." },
            new Magic() { contentId = 373, abilityId = 107, name = "Osmose", type = "Magic - Spellblade", description = "Enchants blade to absorb MP." },
            new Magic() { contentId = 374, abilityId = 108, name = "Cure", type = "Magic - White", description = "Restores HP." },
            new Magic() { contentId = 375, abilityId = 109, name = "Libra", type = "Magic - White", description = "Determines the enemy's HP, weakness, current condition, and level." },
            new Magic() { contentId = 376, abilityId = 110, name = "Poisona", type = "Magic - White", description = "Cures poison." },
            new Magic() { contentId = 377, abilityId = 111, name = "Silence", type = "Magic - White", description = "Causes silence." },
            new Magic() { contentId = 378, abilityId = 112, name = "Protect", type = "Magic - White", description = "Reduces physical damage received." },
            new Magic() { contentId = 379, abilityId = 113, name = "Mini", type = "Magic - White", description = "Shrinks the target or restores their normal state." },
            new Magic() { contentId = 380, abilityId = 114, name = "Cura", type = "Magic - White", description = "Restores HP." },
            new Magic() { contentId = 381, abilityId = 115, name = "Raise", type = "Magic - White", description = "Revives a single target." },
            new Magic() { contentId = 382, abilityId = 116, name = "Confuse", type = "Magic - White", description = "Causes confusion." },
            new Magic() { contentId = 383, abilityId = 117, name = "Blink", type = "Magic - White", description = "Creates illusions of oneself to trick the enemy." },
            new Magic() { contentId = 384, abilityId = 118, name = "Shell", type = "Magic - White", description = "Reduces magic damage received." },
            new Magic() { contentId = 385, abilityId = 119, name = "Esuna", type = "Magic - White", description = "Cures all status effects except KO and zombie." },
            new Magic() { contentId = 386, abilityId = 120, name = "Curaga", type = "Magic - White", description = "Restores HP." },
            new Magic() { contentId = 387, abilityId = 121, name = "Reflect", type = "Magic - White", description = "Creates a barrier that reflects magic back at the caster." },
            new Magic() { contentId = 388, abilityId = 122, name = "Berserk", type = "Magic - White", description = "Causes berserk." },
            new Magic() { contentId = 389, abilityId = 123, name = "Arise", type = "Magic - White", description = "Revives and restores full HP to a single target." },
            new Magic() { contentId = 390, abilityId = 124, name = "Holy", type = "Magic - White", description = "Deals holy damage." },
            new Magic() { contentId = 391, abilityId = 125, name = "Dispel", type = "Magic - White", description = "Removes magic effects." },
            new Magic() { contentId = 392, abilityId = 126, name = "Fire", type = "Magic - Black", description = "Deals fire damage." },
            new Magic() { contentId = 393, abilityId = 127, name = "Blizzard", type = "Magic - Black", description = "Deals ice damage." },
            new Magic() { contentId = 394, abilityId = 128, name = "Thunder", type = "Magic - Black", description = "Deals lightning damage." },
            new Magic() { contentId = 395, abilityId = 129, name = "Poison", type = "Magic - Black", description = "Causes poison." },
            new Magic() { contentId = 396, abilityId = 130, name = "Sleep", type = "Magic - Black", description = "Causes sleep." },
            new Magic() { contentId = 397, abilityId = 131, name = "Toad", type = "Magic - Black", description = "Turns the target into a toad or restores their normal state." },
            new Magic() { contentId = 398, abilityId = 132, name = "Fira", type = "Magic - Black", description = "Deals fire damage." },
            new Magic() { contentId = 399, abilityId = 133, name = "Blizzara", type = "Magic - Black", description = "Deals ice damage." },
            new Magic() { contentId = 400, abilityId = 134, name = "Thundara", type = "Magic - Black", description = "Deals lightning damage." },
            new Magic() { contentId = 401, abilityId = 135, name = "Drain", type = "Magic - Black", description = "Absorbs HP." },
            new Magic() { contentId = 402, abilityId = 136, name = "Break", type = "Magic - Black", description = "Causes petrification." },
            new Magic() { contentId = 403, abilityId = 137, name = "Bio", type = "Magic - Black", description = "Attacks with a poison that deals sapping damage." },
            new Magic() { contentId = 404, abilityId = 138, name = "Firaga", type = "Magic - Black", description = "Deals fire damage." },
            new Magic() { contentId = 405, abilityId = 139, name = "Blizzaga", type = "Magic - Black", description = "Deals ice damage." },
            new Magic() { contentId = 406, abilityId = 140, name = "Thundaga", type = "Magic - Black", description = "Deals lightning damage." },
            new Magic() { contentId = 407, abilityId = 141, name = "Flare", type = "Magic - Black", description = "Deals damage by combustion." },
            new Magic() { contentId = 408, abilityId = 142, name = "Death", type = "Magic - Black", description = "Causes instant death." },
            new Magic() { contentId = 409, abilityId = 143, name = "Osmose", type = "Magic - Black", description = "Absorbs MP." },
            new Magic() { contentId = 410, abilityId = 144, name = "Speed", type = "Magic - Time", description = "Slows the pace of the battle." },
            new Magic() { contentId = 411, abilityId = 145, name = "Slow", type = "Magic - Time", description = "Slows the passing of time for one enemy." },
            new Magic() { contentId = 412, abilityId = 146, name = "Regen", type = "Magic - Time", description = "Gradually restores HP." },
            new Magic() { contentId = 413, abilityId = 147, name = "Mute", type = "Magic - Time", description = "Silences all allies and enemies." },
            new Magic() { contentId = 414, abilityId = 148, name = "Haste", type = "Magic - Time", description = "Hastens the passing of time for one ally." },
            new Magic() { contentId = 415, abilityId = 149, name = "Float", type = "Magic - Time", description = "Levitates the target." },
            new Magic() { contentId = 416, abilityId = 150, name = "Gravity", type = "Magic - Time", description = "Halves one enemy's HP." },
            new Magic() { contentId = 417, abilityId = 151, name = "Stop", type = "Magic - Time", description = "Causes time to stop, halting the target's actions." },
            new Magic() { contentId = 418, abilityId = 152, name = "Teleport", type = "Magic - Time", description = "Warps the party out of a dungeon or battle." },
            new Magic() { contentId = 419, abilityId = 153, name = "Comet", type = "Magic - Time", description = "Calls forth meteors that damage one enemy." },
            new Magic() { contentId = 420, abilityId = 154, name = "Slowga", type = "Magic - Time", description = "Slows the passing of time for all enemies." },
            new Magic() { contentId = 421, abilityId = 155, name = "Return", type = "Magic - Time", description = "Turns back time to the beginning of the battle." },
            new Magic() { contentId = 422, abilityId = 156, name = "Graviga", type = "Magic - Time", description = "Reduces the target's HP to 1/8th of its total." },
            new Magic() { contentId = 423, abilityId = 157, name = "Hastega", type = "Magic - Time", description = "Hastens the passing of time for all allies." },
            new Magic() { contentId = 424, abilityId = 158, name = "Old", type = "Magic - Time", description = "Causes the target to age." },
            new Magic() { contentId = 425, abilityId = 159, name = "Meteor", type = "Magic - Time", description = "Calls forth meteors that damage all enemies." },
            new Magic() { contentId = 426, abilityId = 160, name = "Quick", type = "Magic - Time", description = "Stops the passing of time for all but the caster." },
            new Magic() { contentId = 427, abilityId = 161, name = "Banish", type = "Magic - Time", description = "Erases one enemy from the battlefield." },
            new Magic() { contentId = 428, abilityId = 162, name = "Chocobo", type = "Magic - Summon", description = "Triggers the \"Choco Kick\" attack against one enemy.\nTriggers the \"Fat Chocobo\" attack against all enemies." },
            new Magic() { contentId = 429, abilityId = 163, name = "Sylph", type = "Magic - Summon", description = "Absorbs HP from one enemy to heal all allies.\nTriggers \"Whisperwind.\"" },
            new Magic() { contentId = 430, abilityId = 164, name = "Remora", type = "Magic - Summon", description = "Paralyzes one enemy.\nTriggers \"Constrict.\"" },
            new Magic() { contentId = 431, abilityId = 165, name = "Shiva", type = "Magic - Summon", description = "Attacks all enemies with ice.\nTriggers \"Diamond Dust.\"" },
            new Magic() { contentId = 432, abilityId = 166, name = "Ramuh", type = "Magic - Summon", description = "Attacks all enemies with lightning.\nTriggers \"Judgment Bolt.\"" },
            new Magic() { contentId = 433, abilityId = 167, name = "Ifrit", type = "Magic - Summon", description = "Attacks all enemies with fire.\nTriggers \"Hellfire.\"" },
            new Magic() { contentId = 434, abilityId = 168, name = "Titan", type = "Magic - Summon", description = "Damages all enemies in an earthquake.\nTriggers \"Gaia's Wrath.\"" },
            new Magic() { contentId = 435, abilityId = 169, name = "Golem", type = "Magic - Summon", description = "Protects all allies from physical damage under a certain limit.\nTriggers \"Earthen Wall.\"" },
            new Magic() { contentId = 436, abilityId = 170, name = "Catoblepas", type = "Magic - Summon", description = "Petrifies one enemy.\nTriggers \"Demon Eye.\"" },
            new Magic() { contentId = 437, abilityId = 171, name = "Carbuncle", type = "Magic - Summon", description = "Deflects magical attacks with a barrier for all allies.\nTriggers \"Ruby Light.\"" },
            new Magic() { contentId = 438, abilityId = 172, name = "Syldra", type = "Magic - Summon", description = "Attacks all enemies with wind.\nTriggers \"Thunderstorm.\"" },
            new Magic() { contentId = 439, abilityId = 173, name = "Odin", type = "Magic - Summon", description = "Triggers the \"Zantetsuken\" attack which kills all enemies.\nTriggers the \"Gungnir\" attack which deals major damage to one enemy." },
            new Magic() { contentId = 440, abilityId = 174, name = "Phoenix", type = "Magic - Summon", description = "Revives on KO'd party member up to full health.\nTriggers \"Flames of Rebirth\" which attacks all enemies with fire." },
            new Magic() { contentId = 441, abilityId = 175, name = "Leviathan", type = "Magic - Summon", description = "Deals major water damage to all enemies.\nTriggers \"Tsunami.\"" },
            new Magic() { contentId = 442, abilityId = 176, name = "Bahamut", type = "Magic - Summon", description = "Deals major damage to all enemies with white-hot energy.\nTriggers \"Mega Flare.\"" },
            new Magic() { contentId = 461, abilityId = 195, name = "Sinewy Etude", type = "Magic - Song", description = "Increases the party's strength while being performed." },
            new Magic() { contentId = 462, abilityId = 196, name = "Swift Song", type = "Magic - Song", description = "Increases the party's speed while being performed." },
            new Magic() { contentId = 463, abilityId = 197, name = "Mighty March", type = "Magic - Song", description = "Casts Regen on all party members." },
            new Magic() { contentId = 464, abilityId = 198, name = "Mana's Paean", type = "Magic - Song", description = "Boosts the party's magic while being performed." },
            new Magic() { contentId = 465, abilityId = 199, name = "Hero's Rime", type = "Magic - Song", description = "Increases all stats for all party members while being performed." },
            new Magic() { contentId = 466, abilityId = 200, name = "Requiem", type = "Magic - Song", description = "Damages the undead." },
            new Magic() { contentId = 467, abilityId = 201, name = "Romeo's Ballad", type = "Magic - Song", description = "Stops all enemies for a short while." },
            new Magic() { contentId = 468, abilityId = 202, name = "Alluring Air", type = "Magic - Song", description = "Confuses all enemies." },
            new Magic() { contentId = 480, abilityId = 214, name = "Potion", type = "Magic - Mix", description = "" },
            new Magic() { contentId = 481, abilityId = 215, name = "Lifewater", type = "Magic - Mix", description = "" },
            new Magic() { contentId = 482, abilityId = 216, name = "X-Potion", type = "Magic - Mix", description = "" },
            new Magic() { contentId = 483, abilityId = 217, name = "Elixir", type = "Magic - Mix", description = "" },
            new Magic() { contentId = 484, abilityId = 218, name = "Resurrection", type = "Magic - Mix", description = "" },
            new Magic() { contentId = 485, abilityId = 219, name = "Maiden's Kiss", type = "Magic - Mix", description = "" },
            new Magic() { contentId = 486, abilityId = 220, name = "Ether", type = "Magic - Mix", description = "" },
            new Magic() { contentId = 488, abilityId = 222, name = "Neutralizer", type = "Magic - Mix", description = "" },
            new Magic() { contentId = 489, abilityId = 223, name = "Cure Blindness", type = "Magic - Mix", description = "" },
            new Magic() { contentId = 490, abilityId = 224, name = "Dragon Power", type = "Magic - Mix", description = "" },
            new Magic() { contentId = 491, abilityId = 225, name = "Devil's Juice", type = "Magic - Mix", description = "" },
            new Magic() { contentId = 492, abilityId = 226, name = "Hi-Potion", type = "Magic - Mix", description = "" },
            new Magic() { contentId = 493, abilityId = 227, name = "Balm of Gilead", type = "Magic - Mix", description = "" },
            new Magic() { contentId = 494, abilityId = 228, name = "Triple Ether", type = "Magic - Mix", description = "" },
            new Magic() { contentId = 495, abilityId = 229, name = "Reincarnate", type = "Magic - Mix", description = "" },
            new Magic() { contentId = 496, abilityId = 230, name = "Lilith's Kiss", type = "Magic - Mix", description = "" },
            new Magic() { contentId = 497, abilityId = 231, name = "Resist Poison", type = "Magic - Mix", description = "" },
            new Magic() { contentId = 498, abilityId = 232, name = "Resist Fire", type = "Magic - Mix", description = "" },
            new Magic() { contentId = 499, abilityId = 233, name = "Dragon Shielding", type = "Magic - Mix", description = "" },
            new Magic() { contentId = 500, abilityId = 234, name = "Dark Ether", type = "Magic - Mix", description = "" },
            new Magic() { contentId = 501, abilityId = 235, name = "Dud Potion", type = "Magic - Mix", description = "" },
            new Magic() { contentId = 502, abilityId = 236, name = "Goliath Tonic", type = "Magic - Mix", description = "" },
            new Magic() { contentId = 503, abilityId = 237, name = "Antilixir", type = "Magic - Mix", description = "" },
            new Magic() { contentId = 504, abilityId = 238, name = "Phoenix Down", type = "Magic - Mix", description = "" },
            new Magic() { contentId = 505, abilityId = 239, name = "Kiss of Life", type = "Magic - Mix", description = "" },
            new Magic() { contentId = 506, abilityId = 240, name = "Lifeshield", type = "Magic - Mix", description = "" },
            new Magic() { contentId = 507, abilityId = 241, name = "Remedy", type = "Magic - Mix", description = "" },
            new Magic() { contentId = 508, abilityId = 242, name = "Resist Ice", type = "Magic - Mix", description = "" },
            new Magic() { contentId = 509, abilityId = 243, name = "Resist Thunder", type = "Magic - Mix", description = "" },
            new Magic() { contentId = 510, abilityId = 244, name = "Dragon Defense", type = "Magic - Mix", description = "" },
            new Magic() { contentId = 511, abilityId = 245, name = "Death Potion", type = "Magic - Mix", description = "" },
            new Magic() { contentId = 512, abilityId = 246, name = "Blessed Kiss", type = "Magic - Mix", description = "" },
            new Magic() { contentId = 513, abilityId = 247, name = "Succubus Kiss", type = "Magic - Mix", description = "" },
            new Magic() { contentId = 514, abilityId = 248, name = "Levisalve", type = "Magic - Mix", description = "" },
            new Magic() { contentId = 515, abilityId = 249, name = "Lamia's Kiss", type = "Magic - Mix", description = "" },
            new Magic() { contentId = 516, abilityId = 250, name = "Dragon Kiss", type = "Magic - Mix", description = "" },
            new Magic() { contentId = 517, abilityId = 251, name = "Toad Kiss", type = "Magic - Mix", description = "" },
            new Magic() { contentId = 518, abilityId = 252, name = "Holy Water", type = "Magic - Mix", description = "" },
            new Magic() { contentId = 519, abilityId = 253, name = "Bacchus's Cider", type = "Magic - Mix", description = "" },
            new Magic() { contentId = 520, abilityId = 254, name = "Samson's Might", type = "Magic - Mix", description = "" },
            new Magic() { contentId = 521, abilityId = 255, name = "Elemental Power", type = "Magic - Mix", description = "" },
            new Magic() { contentId = 522, abilityId = 256, name = "Holy Breath", type = "Magic - Mix", description = "" },
            new Magic() { contentId = 523, abilityId = 257, name = "Dud Potion", type = "Magic - Mix", description = "" },
            new Magic() { contentId = 524, abilityId = 258, name = "Protect Potion", type = "Magic - Mix", description = "" },
            new Magic() { contentId = 525, abilityId = 259, name = "Turtle Soup", type = "Magic - Mix", description = "" },
            new Magic() { contentId = 526, abilityId = 260, name = "Hasty-ade", type = "Magic - Mix", description = "" },
            new Magic() { contentId = 527, abilityId = 261, name = "Dud Potion", type = "Magic - Mix", description = "" },
            new Magic() { contentId = 528, abilityId = 262, name = "TNT", type = "Magic - Mix", description = "" },
            new Magic() { contentId = 529, abilityId = 263, name = "Antidote", type = "Magic - Mix", description = "" },
            new Magic() { contentId = 530, abilityId = 264, name = "Smelling Salts", type = "Magic - Mix", description = "" },
            new Magic() { contentId = 531, abilityId = 265, name = "Poison Breath", type = "Magic - Mix", description = "" },
            new Magic() { contentId = 532, abilityId = 266, name = "Poison", type = "Magic - Mix", description = "" },
            new Magic() { contentId = 533, abilityId = 267, name = "Eye Drop", type = "Magic - Mix", description = "" },
            new Magic() { contentId = 534, abilityId = 268, name = "Dark Sigh", type = "Magic - Mix", description = "" },
            new Magic() { contentId = 535, abilityId = 269, name = "Dark Gas", type = "Magic - Mix", description = "" },
            new Magic() { contentId = 536, abilityId = 270, name = "Dragon Breath", type = "Magic - Mix", description = "" },
            new Magic() { contentId = 537, abilityId = 271, name = "Dark Breath", type = "Magic - Mix", description = "" },
            new Magic() { contentId = 538, abilityId = 272, name = "Shadowflare", type = "Magic - Mix", description = "" },
            new Magic() { contentId = 539, abilityId = 273, name = "Mysidian Rabbit", type = "Magic - Animal", description = "" },
            new Magic() { contentId = 540, abilityId = 274, name = "Squirrel", type = "Magic - Animal", description = "" },
            new Magic() { contentId = 541, abilityId = 275, name = "Bee Swarm", type = "Magic - Animal", description = "" },
            new Magic() { contentId = 542, abilityId = 276, name = "Nightingale", type = "Magic - Animal", description = "" },
            new Magic() { contentId = 543, abilityId = 277, name = "Flying Squirrel", type = "Magic - Animal", description = "" },
            new Magic() { contentId = 544, abilityId = 278, name = "Falcon", type = "Magic - Animal", description = "" },
            new Magic() { contentId = 545, abilityId = 279, name = "Skunk", type = "Magic - Animal", description = "" },
            new Magic() { contentId = 546, abilityId = 280, name = "Wild Boar", type = "Magic - Animal", description = "" },
            new Magic() { contentId = 547, abilityId = 281, name = "Unicorn", type = "Magic - Animal", description = "" },
            new Magic() { contentId = 548, abilityId = 282, name = "Gust", type = "Magic - Gaia", description = "" },
            new Magic() { contentId = 549, abilityId = 283, name = "Earthquake", type = "Magic - Gaia", description = "" },
            new Magic() { contentId = 550, abilityId = 284, name = "Wind Slash", type = "Magic - Gaia", description = "" },
            new Magic() { contentId = 551, abilityId = 285, name = "Twister", type = "Magic - Gaia", description = "" },
            new Magic() { contentId = 552, abilityId = 286, name = "Branch Arrow", type = "Magic - Gaia", description = "" },
            new Magic() { contentId = 553, abilityId = 287, name = "Leaf Swirl", type = "Magic - Gaia", description = "" },
            new Magic() { contentId = 554, abilityId = 288, name = "Branch Spear", type = "Magic - Gaia", description = "" },
            new Magic() { contentId = 555, abilityId = 289, name = "Bindweed", type = "Magic - Gaia", description = "" },
            new Magic() { contentId = 556, abilityId = 290, name = "Sandstorm", type = "Magic - Gaia", description = "" },
            new Magic() { contentId = 557, abilityId = 291, name = "Quicksand", type = "Magic - Gaia", description = "" },
            new Magic() { contentId = 558, abilityId = 292, name = "Desert Storm", type = "Magic - Gaia", description = "" },
            new Magic() { contentId = 559, abilityId = 293, name = "Burning Sands", type = "Magic - Gaia", description = "" },
            new Magic() { contentId = 560, abilityId = 294, name = "Tsunami", type = "Magic - Gaia", description = "" },
            new Magic() { contentId = 561, abilityId = 295, name = "Whirlpool", type = "Magic - Gaia", description = "" },
            new Magic() { contentId = 562, abilityId = 296, name = "Big Wave", type = "Magic - Gaia", description = "" },
            new Magic() { contentId = 564, abilityId = 298, name = "Phantom", type = "Magic - Gaia", description = "" },
            new Magic() { contentId = 565, abilityId = 299, name = "Ignus Fatuus", type = "Magic - Gaia", description = "" },
            new Magic() { contentId = 566, abilityId = 300, name = "Bottomless Bog", type = "Magic - Gaia", description = "" },
            new Magic() { contentId = 567, abilityId = 301, name = "Poison Mist", type = "Magic - Gaia", description = "" },
            new Magic() { contentId = 568, abilityId = 302, name = "Waterfall", type = "Magic - Gaia", description = "" },
            new Magic() { contentId = 569, abilityId = 303, name = "Stalactite", type = "Magic - Gaia", description = "" },
            new Magic() { contentId = 570, abilityId = 304, name = "Cave-In", type = "Magic - Gaia", description = "" },
            new Magic() { contentId = 571, abilityId = 305, name = "Sonic Boom", type = "Magic - Gaia", description = "" },
            new Magic() { contentId = 649, abilityId = 383, name = "Doom", type = "Magic - Blue", description = "Curses one enemy to die in 30 seconds." },
            new Magic() { contentId = 650, abilityId = 384, name = "Roulette", type = "Magic - Blue", description = "KO's a randomly chosen target." },
            new Magic() { contentId = 651, abilityId = 385, name = "Aqua Breath", type = "Magic - Blue", description = "Uses bubbles to surround and damage all enemies." },
            new Magic() { contentId = 652, abilityId = 386, name = "Level 5 Death", type = "Magic - Blue", description = "Hits enemies with levels that are multiples of 5." },
            new Magic() { contentId = 653, abilityId = 387, name = "Level 4 Graviga", type = "Magic - Blue", description = "Hits enemies with levels that are multiples of 4." },
            new Magic() { contentId = 654, abilityId = 388, name = "Level 2 Old", type = "Magic - Blue", description = "Hits enemies with levels that are multiples of 2." },
            new Magic() { contentId = 655, abilityId = 389, name = "Level 3 Flare", type = "Magic - Blue", description = "Hits enemies with levels that are multiples of 3." },
            new Magic() { contentId = 656, abilityId = 390, name = "Pond's Chorus", type = "Magic - Blue", description = "Turns one enemy into a toad." },
            new Magic() { contentId = 657, abilityId = 391, name = "Lilliputian Lyric", type = "Magic - Blue", description = "Shrinks one enemy." },
            new Magic() { contentId = 658, abilityId = 392, name = "Flash", type = "Magic - Blue", description = "Inflicts all enemies with darkness." },
            new Magic() { contentId = 659, abilityId = 393, name = "Time Slip", type = "Magic - Blue", description = "Inflicts one enemy with sleep, and causes it to age." },
            new Magic() { contentId = 660, abilityId = 394, name = "Moon Flute", type = "Magic - Blue", description = "Causes berserk for all allies." },
            new Magic() { contentId = 661, abilityId = 395, name = "Death Claw", type = "Magic - Blue", description = "Brings one enemy to the point of death, and inflicts paralysis." },
            new Magic() { contentId = 662, abilityId = 396, name = "Aero", type = "Magic - Blue", description = "Deals wind damage." },
            new Magic() { contentId = 663, abilityId = 397, name = "Aera", type = "Magic - Blue", description = "Deals wind damage." },
            new Magic() { contentId = 664, abilityId = 398, name = "Aeroga", type = "Magic - Blue", description = "Deals wind damage." },
            new Magic() { contentId = 665, abilityId = 399, name = "Flame Thrower", type = "Magic - Blue", description = "Engulfs one enemy in flames." },
            new Magic() { contentId = 666, abilityId = 400, name = "Goblin Punch", type = "Magic - Blue", description = "Attacks one enemy with a goblin's strength." },
            new Magic() { contentId = 667, abilityId = 401, name = "Dark Spark", type = "Magic - Blue", description = "Halves one enemy's level." },
            new Magic() { contentId = 668, abilityId = 402, name = "Off-Guard", type = "Magic - Blue", description = "Reduces the defense of one enemy." },
            new Magic() { contentId = 669, abilityId = 403, name = "Transfusion", type = "Magic - Blue", description = "Sacrifices the caster to completely restore one ally's HP and MP." },
            new Magic() { contentId = 670, abilityId = 404, name = "Mind Blast", type = "Magic - Blue", description = "Attacks and deals sapping damage to one enemy.\nCauses paralysis." },
            new Magic() { contentId = 671, abilityId = 405, name = "Vampire", type = "Magic - Blue", description = "Absorbs HP from one enemy." },
            new Magic() { contentId = 672, abilityId = 406, name = "Magic Hammer", type = "Magic - Blue", description = "Halves one enemy's MP." },
            new Magic() { contentId = 673, abilityId = 407, name = "Mighty Guard", type = "Magic - Blue", description = "Casts Protect, Shell, and Levitate on all allies." },
            new Magic() { contentId = 674, abilityId = 408, name = "Self-Destruct", type = "Magic - Blue", description = "Sacrifices the caster to deal massive damage to one enemy." },
            new Magic() { contentId = 675, abilityId = 409, name = "???", type = "Magic - Blue", description = "???" },
            new Magic() { contentId = 676, abilityId = 410, name = "1000 Needles", type = "Magic - Blue", description = "Deals 1000 damage to one enemy." },
            new Magic() { contentId = 677, abilityId = 411, name = "White Wind", type = "Magic - Blue", description = "Restores each party member's HP by an amount equal to the caster's current HP." },
            new Magic() { contentId = 678, abilityId = 412, name = "Missile", type = "Magic - Blue", description = "Quarters one enemy's HP." },
            new Magic() { contentId = 818, abilityId = 552, name = "Mystery Waltz", type = "Magic - Dance", description = "" },
            new Magic() { contentId = 819, abilityId = 553, name = "Jitterbug", type = "Magic - Dance", description = "" },
            new Magic() { contentId = 820, abilityId = 554, name = "Tempting Tango", type = "Magic - Dance", description = "" },
            new Magic() { contentId = 822, abilityId = 556, name = "Sword Dance", type = "Magic - Dance", description = "" },
        };
        #endregion
    }
}
