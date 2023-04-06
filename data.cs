using Raylib_cs;

namespace main {
    
    public class Data {
        // cover
        public string cover_image = "assets/images/curse_of_sherwood_01.png";

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

        public List<string> bat_images = new List<string> {"assets/images/bat_left_1.png",
                                                           "assets/images/bat_left_2.png",
                                                           "assets/images/bat_left_3.png",
                                                           "assets/images/bat_left_4.png"};

        public List<string> troll_images = new List<string> {"assets/images/troll_left_1.png",
                                                             "assets/images/troll_left_2.png",
                                                             "assets/images/troll_left_3.png",
                                                             "assets/images/troll_left_2.png"};

        public List<string> archer_images = new List<string> {"assets/images/archer_left_1.png",
                                                              "assets/images/archer_left_2.png",
                                                              "assets/images/archer_left_3.png",
                                                              "assets/images/archer_left_2.png"};

        public List<string> brigand_images = new List<string> {"assets/images/brigand_left_1.png",
                                                               "assets/images/brigand_left_2.png",
                                                               "assets/images/brigand_left_3.png",
                                                               "assets/images/brigand_left_2.png"};

        public List<string> skeleton_images = new List<string> {"assets/images/skeleton_left_1.png",
                                                                "assets/images/skeleton_left_2.png",
                                                                "assets/images/skeleton_left_3.png",
                                                                "assets/images/skeleton_left_2.png"};

        public List<string> evil_witch_images = new List<string> {"assets/images/evil_witch_left_1.png",
                                                                  "assets/images/evil_witch_left_2.png",
                                                                  "assets/images/evil_witch_left_3.png",
                                                                  "assets/images/evil_witch_left_4.png"};

        public List<string> bee_images = new List<string> {"assets/images/bee_left_1.png",
                                                           "assets/images/bee_left_2.png",
                                                           "assets/images/bee_left_3.png",
                                                           "assets/images/bee_left_4.png"};

        public List<string> wolf_images = new List<string> {"assets/images/wolf_left_1.png",
                                                            "assets/images/wolf_left_2.png",
                                                            "assets/images/wolf_left_3.png",
                                                            "assets/images/wolf_left_4.png"};
        
        public List<string> ice_wizard_images = new List<string> {"assets/images/ice_wiz_left_1.png",
                                                                  "assets/images/ice_wiz_left_2.png",
                                                                  "assets/images/ice_wiz_left_3.png",
                                                                  "assets/images/ice_wiz_left_2.png"};

        public List<string> dragon_images = new List<string> {"assets/images/dragon_left_1.png",
                                                              "assets/images/dragon_left_2.png",
                                                              "assets/images/dragon_left_3.png",
                                                              "assets/images/dragon_left_4.png"};

        public Color death_images_small_color = new Color(163,167,167,255);
        public Color death_images_large_color = new Color(183,251,191,255);
        public Color bat_color = new Color(163,167,167,255);
        public Color troll_color = new Color(183,251,191,255);
        public Color archer_color = new Color(239,233,231,255);
        public Color brigand_color = new Color(252,249,252,255);
        public Color skeleton_color = new Color(251,251,139,255);
        public Color evil_witch_color = new Color(252,249,252,255);
        public Color bee_color = new Color(251,251,139,255);
        public Color wolf_color = new Color(127,83,7,255);
        public Color ice_wizard_color = new Color(239,233,231,255);
        public Color dragon_color = new Color(239,131,159,255);

        // weapons
        public IDictionary<string, List<string>> weapons_data_dict = new Dictionary<string, List<string>>{};

        public List<string> sword_data = new List<string> {"assets/images/weapon_sword_icon_1.png", // icon img
                                                           "assets/images/weapon_sword_bullet_1.png", // bullet img
                                                           "assets/sounds/weapon_sword_bullet_1.mp3", // shoot sound
                                                           "0.11", // sound delay
                                                           "1", //damage
                                                           "3"}; // bullet speed
        
        public List<string> rock_data = new List<string> {"assets/images/weapon_rock_icon_1.png", // icon img
                                                          "assets/images/weapon_rock_bullet_1.png", // bullet img
                                                          "assets/sounds/weapon_rock_bullet_1.mp3", // shoot sound
                                                          "0.11", // sound delay
                                                          "1", //damage
                                                          "3"}; // bullet speed

        public List<string> club_data = new List<string> {"assets/images/weapon_club_icon_1.png", // icon img
                                                          "assets/images/weapon_club_bullet_1.png", // bullet img
                                                          "assets/sounds/weapon_club_bullet_1.mp3", // shoot sound
                                                          "0.11", // sound delay
                                                          "1", //damage
                                                          "3"}; // bullet speed

        public List<string> silver_dagger_data = new List<string> {"assets/images/weapon_silver_dagger_icon_1.png", // icon img
                                                                   "assets/images/weapon_silver_dagger_bullet_1.png", // bullet img
                                                                   "assets/sounds/weapon_silver_dagger_bullet_1.mp3", // shoot sound
                                                                   "0.11", // sound delay
                                                                   "1", //damage
                                                                   "3"}; // bullet speed

        public List<string> pollen_data = new List<string> {"assets/images/weapon_pollen_icon_1.png", // icon img
                                                            "assets/images/weapon_pollen_bullet_1.png", // bullet img
                                                            "assets/sounds/weapon_pollen_bullet_1.mp3", // shoot sound
                                                            "0.11", // sound delay
                                                            "1", //damage
                                                            "3"}; // bullet speed

        public List<string> ice_wand_data = new List<string> {"assets/images/weapon_ice_wand_icon_1.png", // icon img
                                                              "assets/images/weapon_ice_wand_bullet_1.png", // bullet img
                                                              "assets/sounds/weapon_ice_wand_bullet_1.mp3", // shoot sound
                                                              "0.11", // sound delay
                                                              "1", //damage
                                                              "3"}; // bullet speed

        public List<string> crossbow_data = new List<string> {"assets/images/weapon_crossbow_icon_1.png", // icon img
                                                              "assets/images/weapon_crossbow_bullet_1.png", // bullet img
                                                              "assets/sounds/weapon_crossbow_bullet_1.mp3", // shoot sound
                                                              "0.11", // sound delay
                                                              "1", //damage
                                                              "3"}; // bullet speed

        public List<string> fire_breath_data = new List<string> {"assets/images/weapon_fire_breath_icon_1.png", // icon img
                                                                 "assets/images/weapon_fire_breath_bullet_1.png", // bullet img
                                                                 "assets/sounds/weapon_fire_breath_bullet_1.mp3", // shoot sound
                                                                 "0.11", // sound delay
                                                                 "1", //damage
                                                                 "3"}; // bullet speed

        // items
        public IDictionary<string, List<string>> items_data_dict = new Dictionary<string, List<string>>{};

        public List<string> shield_data = new List<string> {"assets/images/item_shield_1.png"};
        public List<string> crystal_ball_data = new List<string> {"assets/images/item_crystal_ball_1.png"};
        public List<string> cross_data = new List<string> {"assets/images/item_cross_1.png"};
        public List<string> fangs_data = new List<string> {"assets/images/item_fangs_1.png"};
        public List<string> f_elixir_data = new List<string> {"assets/images/item_f-elixir_1.png"};
        public List<string> bag_gold_data = new List<string> {"assets/images/item_bag_gold_1.png"};
        public List<string> key_data = new List<string> {"assets/images/item_key_1.png"};
        public List<string> map_data = new List<string> {"assets/images/item_map_1.png"};

        // npcs
        public List<string> good_witch_images = new List<string> {"assets/images/good_witch_left_1.png",
                                                                  "assets/images/good_witch_left_2.png",
                                                                  "assets/images/good_witch_left_3.png",
                                                                  "assets/images/good_witch_left_2.png"};

        public List<string> hermit_images = new List<string> {"assets/images/hermit_left_1.png",
                                                              "assets/images/hermit_left_2.png",
                                                              "assets/images/hermit_left_3.png",
                                                              "assets/images/hermit_left_2.png"};

        public Color good_witch_color = new Color(252,249,252,255);
        public Color hermit_color = new Color(252,249,252,255);

        // scenes
        public List<string> scene_1 = new List<string>() {"assets/images/map/map_1_start.png"};
        public List<string> scene_2 = new List<string>() {"assets/images/map/map_2_1right.png"};
        public List<string> scene_3 = new List<string>() {"assets/images/map/map_3_2right.png"};
        public List<string> scene_4 = new List<string>() {"assets/images/map/map_4_3right.png"};
        public List<string> scene_5 = new List<string>() {"assets/images/map/map_5_4right.png"};
        public List<string> scene_6 = new List<string>() {"assets/images/map/map_6_5right.png"};
        public List<string> scene_7 = new List<string>() {"assets/images/map/map_7_6right.png",
                                                          "assets/images/map/map_7_6right_extra_1.png"};
        public List<string> scene_8 = new List<string>() {"assets/images/map/map_8_7up.png",
                                                          "assets/images/map/map_8_7up_extra_1.png"};
        public List<string> scene_9 = new List<string>() {"assets/images/map/map_9_6down.png"};
        public List<string> scene_10 = new List<string>() {"assets/images/map/map_10_9right.png",
                                                           "assets/images/map/map_10_9right_extra_1.png"};
        public List<string> scene_11 = new List<string>() {"assets/images/map/map_11_10mushroom.png",
                                                           "assets/images/map/map_11_10mushroom_extra_1.png"};
        public List<string> scene_11_2 = new List<string>() {"assets/images/map/map_11_10mushroom_door_broken.png",
                                                             "assets/images/map/map_11_10mushroom_extra_1.png"};
        public List<string> scene_12 = new List<string>() {"assets/images/map/map_12_11right.png"};
        public List<string> scene_13 = new List<string>() {"assets/images/map/map_13_12down.png"};
        public List<string> scene_14 = new List<string>() {"assets/images/map/map_14_1left.png"};
        public List<string> scene_15 = new List<string>() {"assets/images/map/map_15_14left.png"};
        public List<string> scene_16 = new List<string>() {"assets/images/map/map_16_15left.png",
                                                           "assets/images/map/map_16_15left_extra_1.png"};
        public List<string> scene_17 = new List<string>() {"assets/images/map/map_17_16up.png",
                                                           "assets/images/map/map_17_16up_extra_1.png"};
        public List<string> scene_18 = new List<string>() {"assets/images/map/map_18_16left.png"};
        public List<string> scene_19 = new List<string>() {"assets/images/map/map_19_16down.png"};
        public List<string> scene_20 = new List<string>() {"assets/images/map/map_20_14up.png"};
        public List<string> scene_21 = new List<string>() {"assets/images/map/map_21_20right.png"};

        public List<string> scene_22 = new List<string>() {"assets/images/map/map_22_21right.png"};
        public List<string> scene_23 = new List<string>() {"assets/images/map/map_23_22right.png"};
        public List<string> scene_24 = new List<string>() {"assets/images/map/map_24_23right_river.png"};
        public List<string> scene_24_2 = new List<string>() {"assets/images/map/map_24_23right_river_frozen.png",
                                                             "assets/images/map/map_24_23right_river_frozen_extra_1.png"};
        public List<string> scene_25 = new List<string>() {"assets/images/map/map_25_24right.png"};
        public List<string> scene_26 = new List<string>() {"assets/images/map/map_26_25right.png"};
        public List<string> scene_27 = new List<string>() {"assets/images/map/map_27_22up.png"};
        public List<string> scene_27_2 = new List<string>() {"assets/images/map/map_27_22up_gate_open.png"};
        public List<string> scene_28 = new List<string>() {"assets/images/map/map_28_27up.png"};
        public List<string> scene_29 = new List<string>() {"assets/images/map/map_29_28left.png",
                                                           "assets/images/map/map_29_28left_extra_1.png"};
        public List<string> scene_30 = new List<string>() {"assets/images/map/map_30_29up.png",
                                                           "assets/images/map/map_30_29up_extra_1.png"};
        public List<string> scene_31 = new List<string>() {"assets/images/map/map_31_29left.png"};

        // topbar
        public string topbar = "assets/images/map_topbar.png";

        // general
        public string general_item_sound = "assets/sounds/item_general_sound_1.mp3";
        public List<string> sink_sounds = new List<string> {"assets/sounds/swamp_sink_1.mp3"};
        public List<string> rise_sounds = new List<string> {"assets/sounds/swamp_rise_1.mp3"};
        public Color bg = new Color(25,29,25,255); // asset images background color, replace with Color(0,0,0,0) in code

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
            items_data_dict.Add("crystal ball", crystal_ball_data);
            items_data_dict.Add("cross", cross_data);
            items_data_dict.Add("fangs", fangs_data);
            items_data_dict.Add("f-elixir",f_elixir_data);
            items_data_dict.Add("bag gold", bag_gold_data);
            items_data_dict.Add("key", key_data);
            items_data_dict.Add("map", map_data);
        }
    }
}