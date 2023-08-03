using Raylib_cs;

namespace main {
    
    public class Data {
        // cover
        public string cover_image = "assets/images/curse_of_sherwood_casette_cover.png";

        // player
        public List<string> monk_images = new List<string> {"assets/images/monk/monk_left_1.png", // Color(252,249,252,120)
                                                            "assets/images/monk/monk_left_2.png",
                                                            "assets/images/monk/monk_left_3.png",
                                                            "assets/images/monk/monk_left_2.png"};

        public List<string> monk_images_death = new List<string> {"assets/images/monk/monk_left_1.png", // Color(252,249,252,120)
                                                                  "assets/images/monk/monk_left_death_1.png",
                                                                  "assets/images/monk/monk_left_1.png",
                                                                  "assets/images/monk/monk_left_death_1.png",
                                                                  "assets/images/monk/monk_left_death_2.png",
                                                                  "assets/images/monk/monk_left_death_3.png"};

        public List<string> monk_images_sink = new List<string> {"assets/images/monk/monk_left_sink_1.png", // Color(252,249,252,120)
                                                                 "assets/images/monk/monk_left_sink_2.png",
                                                                 "assets/images/monk/monk_left_sink_3.png",
                                                                 "assets/images/monk/monk_left_sink_4.png",
                                                                 "assets/images/monk/monk_left_sink_5.png",
                                                                 "assets/images/monk/monk_left_sink_6.png",
                                                                 "assets/images/monk/monk_left_sink_7.png",
                                                                 "assets/images/monk/monk_left_sink_8.png",
                                                                 "assets/images/monk/monk_left_sink_9.png"};

        public List<string> monk_walk_sounds = new List<string> {"assets/sounds/monk_walk_1.mp3",
                                                                 "assets/sounds/monk_walk_2.mp3",
                                                                 "assets/sounds/monk_walk_3.mp3",
                                                                 "assets/sounds/monk_walk_4.mp3",
                                                                 "assets/sounds/monk_walk_5.mp3",
                                                                 "assets/sounds/monk_walk_6.mp3",
                                                                 "assets/sounds/monk_walk_7.mp3",
                                                                 "assets/sounds/monk_walk_8.mp3",
                                                                 "assets/sounds/monk_walk_9.mp3"};

        public List<string> monk_death_sounds = new List<string> {"assets/sounds/monk_death_1.mp3"};

        // monsters
        public List<string> monster_death_sounds = new List<string> {"assets/sounds/monster_death_1.mp3"};
        public List<string> monster_bullet_sounds = new List<string> {"assets/sounds/monster_bullet_1.mp3"};

        public List<string> death_images_small = new List<string> {"assets/images/death_stars_small_1.png", // Color(163,167,167,255) bat
                                                                   "assets/images/death_stars_small_2.png",
                                                                   "assets/images/death_stars_small_1.png",
                                                                   "assets/images/death_stars_small_2.png"};
        
        public List<string> death_images_large = new List<string> {"assets/images/death_stars_large_1.png", // Color(183,251,191,255) troll
                                                                   "assets/images/death_stars_large_2.png",
                                                                   "assets/images/death_stars_large_1.png",
                                                                   "assets/images/death_stars_large_2.png"};

        public List<string> bat_images = new List<string> {"assets/images/monster/bat_left_1.png",
                                                           "assets/images/monster/bat_left_2.png",
                                                           "assets/images/monster/bat_left_3.png",
                                                           "assets/images/monster/bat_left_4.png"};

        public List<string> troll_images = new List<string> {"assets/images/monster/troll_left_1.png",
                                                             "assets/images/monster/troll_left_2.png",
                                                             "assets/images/monster/troll_left_3.png",
                                                             "assets/images/monster/troll_left_2.png"};

        public List<string> archer_images = new List<string> {"assets/images/monster/archer_left_1.png",
                                                              "assets/images/monster/archer_left_2.png",
                                                              "assets/images/monster/archer_left_3.png",
                                                              "assets/images/monster/archer_left_2.png"};

        public List<string> brigand_images = new List<string> {"assets/images/monster/brigand_left_1.png",
                                                               "assets/images/monster/brigand_left_2.png",
                                                               "assets/images/monster/brigand_left_3.png",
                                                               "assets/images/monster/brigand_left_2.png"};

        public List<string> skeleton_images = new List<string> {"assets/images/monster/skeleton_left_1.png",
                                                                "assets/images/monster/skeleton_left_2.png",
                                                                "assets/images/monster/skeleton_left_3.png",
                                                                "assets/images/monster/skeleton_left_2.png"};

        public List<string> evil_witch_images = new List<string> {"assets/images/monster/evil_witch_left_1.png",
                                                                  "assets/images/monster/evil_witch_left_2.png",
                                                                  "assets/images/monster/evil_witch_left_3.png",
                                                                  "assets/images/monster/evil_witch_left_4.png"};

        public List<string> bee_images = new List<string> {"assets/images/monster/bee_left_1.png",
                                                           "assets/images/monster/bee_left_2.png",
                                                           "assets/images/monster/bee_left_3.png",
                                                           "assets/images/monster/bee_left_4.png"};

        public List<string> wolf_images = new List<string> {"assets/images/monster/wolf_left_1.png",
                                                            "assets/images/monster/wolf_left_2.png",
                                                            "assets/images/monster/wolf_left_3.png",
                                                            "assets/images/monster/wolf_left_4.png"};
        
        public List<string> ice_wizard_images = new List<string> {"assets/images/monster/ice_wiz_left_1.png",
                                                                  "assets/images/monster/ice_wiz_left_2.png",
                                                                  "assets/images/monster/ice_wiz_left_3.png",
                                                                  "assets/images/monster/ice_wiz_left_2.png"};

        public List<string> dragon_images = new List<string> {"assets/images/monster/dragon_left_1.png",
                                                              "assets/images/monster/dragon_left_2.png",
                                                              "assets/images/monster/dragon_left_3.png",
                                                              "assets/images/monster/dragon_left_4.png"};

        public List<string> fire_spirit_images = new List<string> {"assets/images/monster/fire_spirit_left_1.png",
                                                                   "assets/images/monster/fire_spirit_left_2.png",
                                                                   "assets/images/monster/fire_spirit_left_3.png",
                                                                   "assets/images/monster/fire_spirit_left_4.png"};

        public List<string> swamp_spirit_images = new List<string> {"assets/images/monster/swamp_spirit_left_1.png",
                                                                    "assets/images/monster/swamp_spirit_left_2.png",
                                                                    "assets/images/monster/swamp_spirit_left_3.png",
                                                                    "assets/images/monster/swamp_spirit_left_2.png"};

        public Color death_images_small_color = new Color(163,167,167,255);
        public Color death_images_large_color = new Color(183,251,191,255);
        public Color bat_color =                new Color(163,167,167,255);
        public Color troll_color =              new Color(183,251,191,255);
        public Color archer_color =             new Color(239,233,231,255);
        public Color brigand_color =            new Color(252,249,252,255);
        public Color skeleton_color =           new Color(251,251,139,255);
        public Color evil_witch_color =         new Color(252,249,252,255);
        public Color bee_color =                new Color(251,251,139,255);
        public Color wolf_color =               new Color(127,83,7,255);
        public Color ice_wizard_color =         new Color(239,233,231,255);
        public Color dragon_color =             new Color(239,131,159,255);
        public Color fire_spirit_color =        new Color(252,249,252,255);
        public Color swamp_spirit_color =       new Color(252,249,252,255);

        // weapons
        public IDictionary<string, List<string>> weapons_data_dict = new Dictionary<string, List<string>>{};

        public List<string> sword_data = new List<string> {"assets/images/weapon/weapon_sword_icon_1.png", // icon img
                                                           "assets/images/weapon/weapon_sword_bullet_left_1.png", // bullet img
                                                           "assets/sounds/weapon_sword_bullet_1.mp3", // shoot sound
                                                           "0.11", // sound delay
                                                           "1", //damage
                                                           "3"}; // bullet speed
        
        public List<string> rock_data = new List<string> {"assets/images/weapon/weapon_rock_icon_1.png", // icon img
                                                          "assets/images/weapon/weapon_rock_bullet_left_1.png", // bullet img
                                                          "assets/sounds/weapon_rock_bullet_1.mp3", // shoot sound
                                                          "0.11", // sound delay
                                                          "1", //damage
                                                          "3"}; // bullet speed

        public List<string> club_data = new List<string> {"assets/images/weapon/weapon_club_icon_1.png", // icon img
                                                          "assets/images/weapon/weapon_club_bullet_left_1.png", // bullet img
                                                          "assets/sounds/weapon_club_bullet_1.mp3", // shoot sound
                                                          "0.11", // sound delay
                                                          "1", //damage
                                                          "3"}; // bullet speed

        public List<string> silver_dagger_data = new List<string> {"assets/images/weapon/weapon_silver_dagger_icon_1.png", // icon img
                                                                   "assets/images/weapon/weapon_silver_dagger_bullet_left_1.png", // bullet img
                                                                   "assets/sounds/weapon_silver_dagger_bullet_1.mp3", // shoot sound
                                                                   "0.11", // sound delay
                                                                   "1", //damage
                                                                   "3"}; // bullet speed

        public List<string> pollen_data = new List<string> {"assets/images/weapon/weapon_pollen_icon_1.png", // icon img
                                                            "assets/images/weapon/weapon_pollen_bullet_left_1.png", // bullet img
                                                            "assets/sounds/weapon_pollen_bullet_1.mp3", // shoot sound
                                                            "0.11", // sound delay
                                                            "1", //damage
                                                            "3"}; // bullet speed

        public List<string> ice_wand_data = new List<string> {"assets/images/weapon/weapon_ice_wand_icon_1.png", // icon img
                                                              "assets/images/weapon/weapon_ice_wand_bullet_left_1.png", // bullet img
                                                              "assets/sounds/weapon_ice_wand_bullet_1.mp3", // shoot sound
                                                              "0.11", // sound delay
                                                              "1", //damage
                                                              "3"}; // bullet speed

        public List<string> crossbow_data = new List<string> {"assets/images/weapon/weapon_crossbow_icon_1.png", // icon img
                                                              "assets/images/weapon/weapon_crossbow_bullet_left_1.png", // bullet img
                                                              "assets/sounds/weapon_crossbow_bullet_1.mp3", // shoot sound
                                                              "0.11", // sound delay
                                                              "1", //damage
                                                              "3"}; // bullet speed

        public List<string> fire_breath_data = new List<string> {"assets/images/weapon/weapon_fire_breath_icon_1.png", // icon img
                                                                 "assets/images/weapon/weapon_fire_breath_bullet_left_1.png", // bullet img
                                                                 "assets/sounds/weapon_fire_breath_bullet_1.mp3", // shoot sound
                                                                 "0.11", // sound delay
                                                                 "1", //damage
                                                                 "3"}; // bullet speed

        // items
        public IDictionary<string, List<string>> items_data_dict = new Dictionary<string, List<string>>{};

        public List<string> shield_data = new List<string> {"assets/images/item/item_shield_1.png"};
        public List<string> scrying_glass_data = new List<string> {"assets/images/item/item_scrying_glass_1.png"};
        public List<string> cross_data = new List<string> {"assets/images/item/item_cross_1.png"};
        public List<string> fangs_data = new List<string> {"assets/images/item/item_fangs_1.png"};
        public List<string> f_elixir_data = new List<string> {"assets/images/item/item_f-elixir_1.png"};
        public List<string> bag_gold_data = new List<string> {"assets/images/item/item_bag_gold_1.png"};
        public List<string> key_data = new List<string> {"assets/images/item/item_key_1.png"};
        public List<string> map_data = new List<string> {"assets/images/item/item_map_1.png"};

        // npcs
        public List<string> good_witch_images = new List<string> {"assets/images/npc/good_witch_left_1.png",
                                                                  "assets/images/npc/good_witch_left_2.png",
                                                                  "assets/images/npc/good_witch_left_3.png",
                                                                  "assets/images/npc/good_witch_left_2.png"};

        public List<string> hermit_images = new List<string> {"assets/images/npc/hermit_left_1.png",
                                                              "assets/images/npc/hermit_left_2.png",
                                                              "assets/images/npc/hermit_left_3.png",
                                                              "assets/images/npc/hermit_left_2.png"};

        public Color good_witch_color = new Color(252,249,252,255);
        public Color hermit_color = new Color(252,249,252,255);

        // scenes
        public List<string> scene_1 = new List<string>() {"assets/images/map/map_001_start.png"};
        public List<string> scene_2 = new List<string>() {"assets/images/map/map_002_001right.png"};
        public List<string> scene_3 = new List<string>() {"assets/images/map/map_003_002right.png"};
        public List<string> scene_4 = new List<string>() {"assets/images/map/map_004_003right.png"};
        public List<string> scene_5 = new List<string>() {"assets/images/map/map_005_004right.png"};
        public List<string> scene_6 = new List<string>() {"assets/images/map/map_006_005right.png"};
        public List<string> scene_7 = new List<string>() {"assets/images/map/map_007_006right.png",
                                                          "assets/images/map/map_007_006right_extra_1.png"};
        public List<string> scene_8 = new List<string>() {"assets/images/map/map_008_007up.png",
                                                          "assets/images/map/map_008_007up_extra_1.png"};
        public List<string> scene_9 = new List<string>() {"assets/images/map/map_009_006down.png"};
        public List<string> scene_10 = new List<string>() {"assets/images/map/map_010_009right.png",
                                                           "assets/images/map/map_010_009right_extra_1.png"};
        public List<string> scene_11 = new List<string>() {"assets/images/map/map_011_010mushroom.png",
                                                           "assets/images/map/map_011_010mushroom_extra_1.png"};
        public List<string> scene_11_2 = new List<string>() {"assets/images/map/map_011_010mushroom_door_broken.png",
                                                             "assets/images/map/map_011_010mushroom_extra_1.png"};
        public List<string> scene_12 = new List<string>() {"assets/images/map/map_012_011right.png",
                                                           "assets/images/map/map_012_011right_extra_1.png"};
        public List<string> scene_13 = new List<string>() {"assets/images/map/map_013_012down.png"};
        public List<string> scene_14 = new List<string>() {"assets/images/map/map_014_001left.png"};
        public List<string> scene_15 = new List<string>() {"assets/images/map/map_015_014left.png"};
        public List<string> scene_16 = new List<string>() {"assets/images/map/map_016_015left.png",
                                                           "assets/images/map/map_016_015left_extra_1.png"};
        public List<string> scene_17 = new List<string>() {"assets/images/map/map_017_016up.png",
                                                           "assets/images/map/map_017_016up_extra_1.png"};
        public List<string> scene_18 = new List<string>() {"assets/images/map/map_018_016left.png"};
        public List<string> scene_19 = new List<string>() {"assets/images/map/map_019_016down.png"};
        public List<string> scene_20 = new List<string>() {"assets/images/map/map_020_014up.png"};
        public List<string> scene_21 = new List<string>() {"assets/images/map/map_021_020right.png"};

        public List<string> scene_22 = new List<string>() {"assets/images/map/map_022_021right.png"};
        public List<string> scene_23 = new List<string>() {"assets/images/map/map_023_022right.png"};
        public List<string> scene_24 = new List<string>() {"assets/images/map/map_024_023right_river.png"};
        public List<string> scene_24_2 = new List<string>() {"assets/images/map/map_024_023right_river_frozen.png",
                                                             "assets/images/map/map_024_023right_river_frozen_extra_1.png"};
        public List<string> scene_25 = new List<string>() {"assets/images/map/map_025_024right.png"};
        public List<string> scene_26 = new List<string>() {"assets/images/map/map_026_025right.png"};
        public List<string> scene_27 = new List<string>() {"assets/images/map/map_027_022up.png"};
        public List<string> scene_27_2 = new List<string>() {"assets/images/map/map_027_022up_gate_open.png"};
        public List<string> scene_28 = new List<string>() {"assets/images/map/map_028_027up.png"};
        public List<string> scene_29 = new List<string>() {"assets/images/map/map_029_028left.png",
                                                           "assets/images/map/map_029_028left_extra_1.png"};
        public List<string> scene_30 = new List<string>() {"assets/images/map/map_030_029up.png",
                                                           "assets/images/map/map_030_029up_extra_1.png"};
        public List<string> scene_31 = new List<string>() {"assets/images/map/map_031_029left.png"};

        public List<string> scene_32 = new List<string>() {"assets/images/map/map_032_031up_swamp.png"};
        public List<string> scene_33 = new List<string>() {"assets/images/map/map_033_032up_swamp.png"};
        public List<string> scene_34 = new List<string>() {"assets/images/map/map_034_033left_swamp.png"};
        public List<string> scene_35 = new List<string>() {"assets/images/map/map_035_034up_swamp.png"};
        public List<string> scene_36 = new List<string>() {"assets/images/map/map_036_035up.png"};
        public List<string> scene_37 = new List<string>() {"assets/images/map/map_037_036right.png"};
        public List<string> scene_38 = new List<string>() {"assets/images/map/map_038_037right.png"};
        public List<string> scene_39 = new List<string>() {"assets/images/map/map_039_038down.png"};
        public List<string> scene_40 = new List<string>() {"assets/images/map/map_040_039right.png"};
        public List<string> scene_41 = new List<string>() {"assets/images/map/map_041_040right.png"};
        public List<string> scene_42 = new List<string>() {"assets/images/map/map_042_041right.png"};
        public List<string> scene_43 = new List<string>() {"assets/images/map/map_043_041up.png",
                                                           "assets/images/map/map_043_041up_extra_1.png",
                                                           "assets/images/map/map_043_041up_extra_2.png"};

        // general
        public string topbar = "assets/images/topbar_1.png";
        public string general_item_sound = "assets/sounds/item_general_sound_1.mp3";
        public List<string> sink_sounds = new List<string> {"assets/sounds/swamp_sink_1.mp3",
                                                            "assets/sounds/swamp_sink_2.mp3",
                                                            "assets/sounds/swamp_sink_3.mp3",
                                                            "assets/sounds/swamp_sink_4.mp3",
                                                            "assets/sounds/swamp_sink_5.mp3",
                                                            "assets/sounds/swamp_sink_6.mp3",
                                                            "assets/sounds/swamp_sink_7.mp3",
                                                            "assets/sounds/swamp_sink_8.mp3",
                                                            "assets/sounds/swamp_sink_9.mp3"};
        //public List<string> rise_sounds = new List<string> {"assets/sounds/swamp_rise_1.mp3"};
        public Color bg = new Color(25,29,25,255); // asset images background color, replace with Color(0,0,0,0) in code for transparency
        public Color transparent = new Color(0,0,0,0); // replace with this color for transparency in images
        public string swamp_map = "assets/images/swamp_map_2.png";
        public string end_screen = "assets/images/end_screen_1.png";
        public float default_unit_speed = 0.8f;
        public int native_screen_width = 254; // used to scale images to different screen resolutions

        // guide poem
        public List<string> guide = new List<string>(){
            "For fire protection you must amass",
            "Werewolves fangs and a Scrying glass",
            "Then travel through the misty wood",
            "To take them to the Witch of Good",
            "",
            "From the man of solitary means",
            "A parchment guide is what you need",
            "Without it you may go astray",
            "And in the forest lose your way",
            "",
            "To buy the means to safety walk",
            "A firey monster you must stalk",
            "He holds the price with precious metal",
            "Convey to the hermit without much fettle",
            "",
            "A silver cross must be found",
            "Before you feel safe and sound",
            "On the pentagon it must be dropped",
            "And the portal of evil will be stopped",
        };

        // constructor
        public Data()
        {
            weapons_data_dict.Add("sword", sword_data);
            weapons_data_dict.Add("rock", rock_data);
            weapons_data_dict.Add("club", club_data);
            weapons_data_dict.Add("silver dagger", silver_dagger_data);
            weapons_data_dict.Add("pollen", pollen_data);
            weapons_data_dict.Add("ice wand", ice_wand_data);
            weapons_data_dict.Add("crossbow", crossbow_data);
            weapons_data_dict.Add("fire breath", fire_breath_data);

            items_data_dict.Add("shield", shield_data);
            items_data_dict.Add("scrying glass", scrying_glass_data);
            items_data_dict.Add("cross", cross_data);
            items_data_dict.Add("fangs", fangs_data);
            items_data_dict.Add("f-elixir",f_elixir_data);
            items_data_dict.Add("bag gold", bag_gold_data);
            items_data_dict.Add("key", key_data);
            items_data_dict.Add("map", map_data);

        }
    }
}