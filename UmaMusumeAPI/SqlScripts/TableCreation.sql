--
-- Set character set the client will use to send SQL statements to the server
--
SET NAMES 'utf8mb4';

--
-- Set default database
--
USE umamusume;

--
-- Drop table `announce_character`
--
DROP TABLE IF EXISTS announce_character;

--
-- Drop table `announce_data`
--
DROP TABLE IF EXISTS announce_data;

--
-- Drop table `announce_event`
--
DROP TABLE IF EXISTS announce_event;

--
-- Drop table `announce_support_card`
--
DROP TABLE IF EXISTS announce_support_card;

--
-- Drop table `audience_data`
--
DROP TABLE IF EXISTS audience_data;

--
-- Drop table `audience_dress_color_set`
--
DROP TABLE IF EXISTS audience_dress_color_set;

--
-- Drop table `audience_hair_color_set`
--
DROP TABLE IF EXISTS audience_hair_color_set;

--
-- Drop table `audience_impostor`
--
DROP TABLE IF EXISTS audience_impostor;

--
-- Drop table `audience_impostor_color_set`
--
DROP TABLE IF EXISTS audience_impostor_color_set;

--
-- Drop table `audience_impostor_lottery`
--
DROP TABLE IF EXISTS audience_impostor_lottery;

--
-- Drop table `audio_cuesheet`
--
DROP TABLE IF EXISTS audio_cuesheet;

--
-- Drop table `audio_ignored_cue_on_highspeed`
--
DROP TABLE IF EXISTS audio_ignored_cue_on_highspeed;

--
-- Drop table `audio_story_effect`
--
DROP TABLE IF EXISTS audio_story_effect;

--
-- Drop table `available_skill_set`
--
DROP TABLE IF EXISTS available_skill_set;

--
-- Drop table `background_data`
--
DROP TABLE IF EXISTS background_data;

--
-- Drop table `background_offset_data`
--
DROP TABLE IF EXISTS background_offset_data;

--
-- Drop table `banner_data`
--
DROP TABLE IF EXISTS banner_data;

--
-- Drop table `campaign_chara_story_schedule`
--
DROP TABLE IF EXISTS campaign_chara_story_schedule;

--
-- Drop table `campaign_cutt_data`
--
DROP TABLE IF EXISTS campaign_cutt_data;

--
-- Drop table `campaign_data`
--
DROP TABLE IF EXISTS campaign_data;

--
-- Drop table `campaign_n_present_bonus_data`
--
DROP TABLE IF EXISTS campaign_n_present_bonus_data;

--
-- Drop table `campaign_present_bonus_detail`
--
DROP TABLE IF EXISTS campaign_present_bonus_detail;

--
-- Drop table `campaign_rental_support_card`
--
DROP TABLE IF EXISTS campaign_rental_support_card;

--
-- Drop table `campaign_rental_support_data`
--
DROP TABLE IF EXISTS campaign_rental_support_data;

--
-- Drop table `campaign_single_race_add_data`
--
DROP TABLE IF EXISTS campaign_single_race_add_data;

--
-- Drop table `campaign_single_race_add_reward`
--
DROP TABLE IF EXISTS campaign_single_race_add_reward;

--
-- Drop table `campaign_sp_present_bonus_data`
--
DROP TABLE IF EXISTS campaign_sp_present_bonus_data;

--
-- Drop table `campaign_story_data`
--
DROP TABLE IF EXISTS campaign_story_data;

--
-- Drop table `campaign_swap_motion_data`
--
DROP TABLE IF EXISTS campaign_swap_motion_data;

--
-- Drop table `campaign_walking_chara`
--
DROP TABLE IF EXISTS campaign_walking_chara;

--
-- Drop table `campaign_walking_data`
--
DROP TABLE IF EXISTS campaign_walking_data;

--
-- Drop table `campaign_walking_friend`
--
DROP TABLE IF EXISTS campaign_walking_friend;

--
-- Drop table `campaign_walking_location`
--
DROP TABLE IF EXISTS campaign_walking_location;

--
-- Drop table `campaign_walking_reward_set`
--
DROP TABLE IF EXISTS campaign_walking_reward_set;

--
-- Drop table `card_data`
--
DROP TABLE IF EXISTS card_data;

--
-- Drop table `card_rarity_data`
--
DROP TABLE IF EXISTS card_rarity_data;

--
-- Drop table `card_talent_hint_upgrade`
--
DROP TABLE IF EXISTS card_talent_hint_upgrade;

--
-- Drop table `card_talent_upgrade`
--
DROP TABLE IF EXISTS card_talent_upgrade;

--
-- Drop table `challenge_match_boss_npc`
--
DROP TABLE IF EXISTS challenge_match_boss_npc;

--
-- Drop table `challenge_match_data`
--
DROP TABLE IF EXISTS challenge_match_data;

--
-- Drop table `challenge_match_race`
--
DROP TABLE IF EXISTS challenge_match_race;

--
-- Drop table `challenge_match_raw_point`
--
DROP TABLE IF EXISTS challenge_match_raw_point;

--
-- Drop table `champions_bgm`
--
DROP TABLE IF EXISTS champions_bgm;

--
-- Drop table `champions_entry_reward`
--
DROP TABLE IF EXISTS champions_entry_reward;

--
-- Drop table `champions_evaluation_rate`
--
DROP TABLE IF EXISTS champions_evaluation_rate;

--
-- Drop table `champions_news_chara_comment`
--
DROP TABLE IF EXISTS champions_news_chara_comment;

--
-- Drop table `champions_news_race`
--
DROP TABLE IF EXISTS champions_news_race;

--
-- Drop table `champions_news_title`
--
DROP TABLE IF EXISTS champions_news_title;

--
-- Drop table `champions_news_win_comment`
--
DROP TABLE IF EXISTS champions_news_win_comment;

--
-- Drop table `champions_news_win_title`
--
DROP TABLE IF EXISTS champions_news_win_title;

--
-- Drop table `champions_race_condition`
--
DROP TABLE IF EXISTS champions_race_condition;

--
-- Drop table `champions_reward_rate`
--
DROP TABLE IF EXISTS champions_reward_rate;

--
-- Drop table `champions_round_detail`
--
DROP TABLE IF EXISTS champions_round_detail;

--
-- Drop table `champions_round_schedule`
--
DROP TABLE IF EXISTS champions_round_schedule;

--
-- Drop table `champions_schedule`
--
DROP TABLE IF EXISTS champions_schedule;

--
-- Drop table `champions_stand_motion`
--
DROP TABLE IF EXISTS champions_stand_motion;

--
-- Drop table `character_prop_animation`
--
DROP TABLE IF EXISTS character_prop_animation;

--
-- Drop table `character_system_lottery`
--
DROP TABLE IF EXISTS character_system_lottery;

--
-- Drop table `character_system_text`
--
DROP TABLE IF EXISTS character_system_text;

--
-- Drop table `chara_category_motion`
--
DROP TABLE IF EXISTS chara_category_motion;

--
-- Drop table `chara_data`
--
DROP TABLE IF EXISTS chara_data;

--
-- Drop table `chara_data_group`
--
DROP TABLE IF EXISTS chara_data_group;

--
-- Drop table `chara_dress_color_set`
--
DROP TABLE IF EXISTS chara_dress_color_set;

--
-- Drop table `chara_dress_color_set_default`
--
DROP TABLE IF EXISTS chara_dress_color_set_default;

--
-- Drop table `chara_motion_act`
--
DROP TABLE IF EXISTS chara_motion_act;

--
-- Drop table `chara_motion_set`
--
DROP TABLE IF EXISTS chara_motion_set;

--
-- Drop table `chara_story_data`
--
DROP TABLE IF EXISTS chara_story_data;

--
-- Drop table `chara_type`
--
DROP TABLE IF EXISTS chara_type;

--
-- Drop table `circle_rank_data`
--
DROP TABLE IF EXISTS circle_rank_data;

--
-- Drop table `circle_stamp_data`
--
DROP TABLE IF EXISTS circle_stamp_data;

--
-- Drop table `collect_event_map_bg_data`
--
DROP TABLE IF EXISTS collect_event_map_bg_data;

--
-- Drop table `collect_event_map_master`
--
DROP TABLE IF EXISTS collect_event_map_master;

--
-- Drop table `collect_raid_all_reward`
--
DROP TABLE IF EXISTS collect_raid_all_reward;

--
-- Drop table `collect_raid_dress_color`
--
DROP TABLE IF EXISTS collect_raid_dress_color;

--
-- Drop table `collect_raid_individual_reward`
--
DROP TABLE IF EXISTS collect_raid_individual_reward;

--
-- Drop table `collect_raid_master`
--
DROP TABLE IF EXISTS collect_raid_master;

--
-- Drop table `collect_raid_mission`
--
DROP TABLE IF EXISTS collect_raid_mission;

--
-- Drop table `collect_raid_mission_top_chara`
--
DROP TABLE IF EXISTS collect_raid_mission_top_chara;

--
-- Drop table `collect_raid_segment_cutt`
--
DROP TABLE IF EXISTS collect_raid_segment_cutt;

--
-- Drop table `collect_raid_staging_mini_chara`
--
DROP TABLE IF EXISTS collect_raid_staging_mini_chara;

--
-- Drop table `collect_raid_story`
--
DROP TABLE IF EXISTS collect_raid_story;

--
-- Drop table `collect_raid_top_data`
--
DROP TABLE IF EXISTS collect_raid_top_data;

--
-- Drop table `crane_game_arm_swing`
--
DROP TABLE IF EXISTS crane_game_arm_swing;

--
-- Drop table `crane_game_catch_result`
--
DROP TABLE IF EXISTS crane_game_catch_result;

--
-- Drop table `crane_game_define_param`
--
DROP TABLE IF EXISTS crane_game_define_param;

--
-- Drop table `crane_game_extra_odds_condition`
--
DROP TABLE IF EXISTS crane_game_extra_odds_condition;

--
-- Drop table `crane_game_hidden_odds`
--
DROP TABLE IF EXISTS crane_game_hidden_odds;

--
-- Drop table `crane_game_prize_face`
--
DROP TABLE IF EXISTS crane_game_prize_face;

--
-- Drop table `crane_game_prize_pattern`
--
DROP TABLE IF EXISTS crane_game_prize_pattern;

--
-- Drop table `crane_game_prop`
--
DROP TABLE IF EXISTS crane_game_prop;

--
-- Drop table `daily_legend_race`
--
DROP TABLE IF EXISTS daily_legend_race;

--
-- Drop table `daily_pack`
--
DROP TABLE IF EXISTS daily_pack;

--
-- Drop table `daily_race`
--
DROP TABLE IF EXISTS daily_race;

--
-- Drop table `daily_race_billing`
--
DROP TABLE IF EXISTS daily_race_billing;

--
-- Drop table `daily_race_npc`
--
DROP TABLE IF EXISTS daily_race_npc;

--
-- Drop table `deck_recommend_exception`
--
DROP TABLE IF EXISTS deck_recommend_exception;

--
-- Drop table `deck_recommend_lv_correction`
--
DROP TABLE IF EXISTS deck_recommend_lv_correction;

--
-- Drop table `deck_recommend_organize`
--
DROP TABLE IF EXISTS deck_recommend_organize;

--
-- Drop table `directory`
--
DROP TABLE IF EXISTS directory;

--
-- Drop table `dress_data`
--
DROP TABLE IF EXISTS dress_data;

--
-- Drop table `event_motion_data`
--
DROP TABLE IF EXISTS event_motion_data;

--
-- Drop table `event_motion_plus_data`
--
DROP TABLE IF EXISTS event_motion_plus_data;

--
-- Drop table `exchange_ticket_detail`
--
DROP TABLE IF EXISTS exchange_ticket_detail;

--
-- Drop table `face_type_data`
--
DROP TABLE IF EXISTS face_type_data;

--
-- Drop table `facial_mouth_change`
--
DROP TABLE IF EXISTS facial_mouth_change;

--
-- Drop table `factor_research_animation_data`
--
DROP TABLE IF EXISTS factor_research_animation_data;

--
-- Drop table `factor_research_box`
--
DROP TABLE IF EXISTS factor_research_box;

--
-- Drop table `factor_research_box_reward`
--
DROP TABLE IF EXISTS factor_research_box_reward;

--
-- Drop table `factor_research_data`
--
DROP TABLE IF EXISTS factor_research_data;

--
-- Drop table `factor_research_factor_upgrade`
--
DROP TABLE IF EXISTS factor_research_factor_upgrade;

--
-- Drop table `factor_research_top`
--
DROP TABLE IF EXISTS factor_research_top;

--
-- Drop table `fan_raid_all_reward`
--
DROP TABLE IF EXISTS fan_raid_all_reward;

--
-- Drop table `fan_raid_bonus_chara`
--
DROP TABLE IF EXISTS fan_raid_bonus_chara;

--
-- Drop table `fan_raid_bonus_support_card`
--
DROP TABLE IF EXISTS fan_raid_bonus_support_card;

--
-- Drop table `fan_raid_data`
--
DROP TABLE IF EXISTS fan_raid_data;

--
-- Drop table `fan_raid_individual_reward`
--
DROP TABLE IF EXISTS fan_raid_individual_reward;

--
-- Drop table `fan_raid_story_data`
--
DROP TABLE IF EXISTS fan_raid_story_data;

--
-- Drop table `fan_raid_top_chara`
--
DROP TABLE IF EXISTS fan_raid_top_chara;

--
-- Drop table `fan_raid_top_data`
--
DROP TABLE IF EXISTS fan_raid_top_data;

--
-- Drop table `gacha_available`
--
DROP TABLE IF EXISTS gacha_available;

--
-- Drop table `gacha_data`
--
DROP TABLE IF EXISTS gacha_data;

--
-- Drop table `gacha_exchange`
--
DROP TABLE IF EXISTS gacha_exchange;

--
-- Drop table `gacha_free_campaign`
--
DROP TABLE IF EXISTS gacha_free_campaign;

--
-- Drop table `gacha_group`
--
DROP TABLE IF EXISTS gacha_group;

--
-- Drop table `gacha_piece`
--
DROP TABLE IF EXISTS gacha_piece;

--
-- Drop table `gacha_prize_odds`
--
DROP TABLE IF EXISTS gacha_prize_odds;

--
-- Drop table `gacha_stepup`
--
DROP TABLE IF EXISTS gacha_stepup;

--
-- Drop table `gacha_top_bg`
--
DROP TABLE IF EXISTS gacha_top_bg;

--
-- Drop table `gift_message`
--
DROP TABLE IF EXISTS gift_message;

--
-- Drop table `heroes_data`
--
DROP TABLE IF EXISTS heroes_data;

--
-- Drop table `heroes_final_stage_race`
--
DROP TABLE IF EXISTS heroes_final_stage_race;

--
-- Drop table `heroes_gauge`
--
DROP TABLE IF EXISTS heroes_gauge;

--
-- Drop table `heroes_league_rank`
--
DROP TABLE IF EXISTS heroes_league_rank;

--
-- Drop table `heroes_league_rank_reward_group`
--
DROP TABLE IF EXISTS heroes_league_rank_reward_group;

--
-- Drop table `heroes_league_score`
--
DROP TABLE IF EXISTS heroes_league_score;

--
-- Drop table `heroes_lottery_message`
--
DROP TABLE IF EXISTS heroes_lottery_message;

--
-- Drop table `heroes_race_condition`
--
DROP TABLE IF EXISTS heroes_race_condition;

--
-- Drop table `heroes_race_default_npc`
--
DROP TABLE IF EXISTS heroes_race_default_npc;

--
-- Drop table `heroes_race_default_user`
--
DROP TABLE IF EXISTS heroes_race_default_user;

--
-- Drop table `heroes_race_mob_npc`
--
DROP TABLE IF EXISTS heroes_race_mob_npc;

--
-- Drop table `heroes_skill`
--
DROP TABLE IF EXISTS heroes_skill;

--
-- Drop table `heroes_skill_item`
--
DROP TABLE IF EXISTS heroes_skill_item;

--
-- Drop table `heroes_skill_motion`
--
DROP TABLE IF EXISTS heroes_skill_motion;

--
-- Drop table `heroes_special_reward`
--
DROP TABLE IF EXISTS heroes_special_reward;

--
-- Drop table `heroes_stage_schedule`
--
DROP TABLE IF EXISTS heroes_stage_schedule;

--
-- Drop table `highlight_interpolate`
--
DROP TABLE IF EXISTS highlight_interpolate;

--
-- Drop table `homestory_hip_offset`
--
DROP TABLE IF EXISTS homestory_hip_offset;

--
-- Drop table `home_character_type`
--
DROP TABLE IF EXISTS home_character_type;

--
-- Drop table `home_eat`
--
DROP TABLE IF EXISTS home_eat;

--
-- Drop table `home_env_setting`
--
DROP TABLE IF EXISTS home_env_setting;

--
-- Drop table `home_event_schedule`
--
DROP TABLE IF EXISTS home_event_schedule;

--
-- Drop table `home_poster_data`
--
DROP TABLE IF EXISTS home_poster_data;

--
-- Drop table `home_prop_setting`
--
DROP TABLE IF EXISTS home_prop_setting;

--
-- Drop table `home_story_trigger`
--
DROP TABLE IF EXISTS home_story_trigger;

--
-- Drop table `home_walk_group`
--
DROP TABLE IF EXISTS home_walk_group;

--
-- Drop table `honor_data`
--
DROP TABLE IF EXISTS honor_data;

--
-- Drop table `item_data`
--
DROP TABLE IF EXISTS item_data;

--
-- Drop table `item_exchange`
--
DROP TABLE IF EXISTS item_exchange;

--
-- Drop table `item_exchange_top`
--
DROP TABLE IF EXISTS item_exchange_top;

--
-- Drop table `item_group`
--
DROP TABLE IF EXISTS item_group;

--
-- Drop table `item_place`
--
DROP TABLE IF EXISTS item_place;

--
-- Drop table `jobs_genre`
--
DROP TABLE IF EXISTS jobs_genre;

--
-- Drop table `jobs_place`
--
DROP TABLE IF EXISTS jobs_place;

--
-- Drop table `jobs_point_limit`
--
DROP TABLE IF EXISTS jobs_point_limit;

--
-- Drop table `jobs_random_drop_reward`
--
DROP TABLE IF EXISTS jobs_random_drop_reward;

--
-- Drop table `jobs_reward`
--
DROP TABLE IF EXISTS jobs_reward;

--
-- Drop table `jobs_reward_sort_disp_order`
--
DROP TABLE IF EXISTS jobs_reward_sort_disp_order;

--
-- Drop table `jukebox_comment`
--
DROP TABLE IF EXISTS jukebox_comment;

--
-- Drop table `jukebox_motion_data`
--
DROP TABLE IF EXISTS jukebox_motion_data;

--
-- Drop table `jukebox_music_data`
--
DROP TABLE IF EXISTS jukebox_music_data;

--
-- Drop table `jukebox_setlist_data`
--
DROP TABLE IF EXISTS jukebox_setlist_data;

--
-- Drop table `jukebox_setlist_music_data`
--
DROP TABLE IF EXISTS jukebox_setlist_music_data;

--
-- Drop table `jukebox_setlist_singer_data`
--
DROP TABLE IF EXISTS jukebox_setlist_singer_data;

--
-- Drop table `legend_race`
--
DROP TABLE IF EXISTS legend_race;

--
-- Drop table `legend_race_billing`
--
DROP TABLE IF EXISTS legend_race_billing;

--
-- Drop table `legend_race_boss_npc`
--
DROP TABLE IF EXISTS legend_race_boss_npc;

--
-- Drop table `legend_race_cutt_chara_data`
--
DROP TABLE IF EXISTS legend_race_cutt_chara_data;

--
-- Drop table `legend_race_npc`
--
DROP TABLE IF EXISTS legend_race_npc;

--
-- Drop table `live_data`
--
DROP TABLE IF EXISTS live_data;

--
-- Drop table `live_extra_data`
--
DROP TABLE IF EXISTS live_extra_data;

--
-- Drop table `live_permission_data`
--
DROP TABLE IF EXISTS live_permission_data;

--
-- Drop table `login_bonus_chara`
--
DROP TABLE IF EXISTS login_bonus_chara;

--
-- Drop table `login_bonus_data`
--
DROP TABLE IF EXISTS login_bonus_data;

--
-- Drop table `login_bonus_detail`
--
DROP TABLE IF EXISTS login_bonus_detail;

--
-- Drop table `love_rank`
--
DROP TABLE IF EXISTS love_rank;

--
-- Drop table `main_story_data`
--
DROP TABLE IF EXISTS main_story_data;

--
-- Drop table `main_story_part`
--
DROP TABLE IF EXISTS main_story_part;

--
-- Drop table `main_story_race_bonus`
--
DROP TABLE IF EXISTS main_story_race_bonus;

--
-- Drop table `main_story_race_bonus_condition`
--
DROP TABLE IF EXISTS main_story_race_bonus_condition;

--
-- Drop table `main_story_race_chara_data`
--
DROP TABLE IF EXISTS main_story_race_chara_data;

--
-- Drop table `main_story_race_data`
--
DROP TABLE IF EXISTS main_story_race_data;

--
-- Drop table `map_event_area_data`
--
DROP TABLE IF EXISTS map_event_area_data;

--
-- Drop table `map_event_data`
--
DROP TABLE IF EXISTS map_event_data;

--
-- Drop table `map_event_flavor_text`
--
DROP TABLE IF EXISTS map_event_flavor_text;

--
-- Drop table `map_event_map_point`
--
DROP TABLE IF EXISTS map_event_map_point;

--
-- Drop table `map_event_mini_motion`
--
DROP TABLE IF EXISTS map_event_mini_motion;

--
-- Drop table `map_event_story_data`
--
DROP TABLE IF EXISTS map_event_story_data;

--
-- Drop table `meta_a`
--
DROP TABLE IF EXISTS meta_a;

--
-- Drop table `meta_c`
--
DROP TABLE IF EXISTS meta_c;

--
-- Drop table `meta_i`
--
DROP TABLE IF EXISTS meta_i;

--
-- Drop table `meta_r`
--
DROP TABLE IF EXISTS meta_r;

--
-- Drop table `mini_bg`
--
DROP TABLE IF EXISTS mini_bg;

--
-- Drop table `mini_bg_chara_motion`
--
DROP TABLE IF EXISTS mini_bg_chara_motion;

--
-- Drop table `mini_face_type_data`
--
DROP TABLE IF EXISTS mini_face_type_data;

--
-- Drop table `mini_mob`
--
DROP TABLE IF EXISTS mini_mob;

--
-- Drop table `mini_motion_set`
--
DROP TABLE IF EXISTS mini_motion_set;

--
-- Drop table `mini_mouth_type`
--
DROP TABLE IF EXISTS mini_mouth_type;

--
-- Drop table `mission_data`
--
DROP TABLE IF EXISTS mission_data;

--
-- Drop table `mission_race_equate`
--
DROP TABLE IF EXISTS mission_race_equate;

--
-- Drop table `mission_race_scenario_group`
--
DROP TABLE IF EXISTS mission_race_scenario_group;

--
-- Drop table `mob_data`
--
DROP TABLE IF EXISTS mob_data;

--
-- Drop table `mob_dress_color_set`
--
DROP TABLE IF EXISTS mob_dress_color_set;

--
-- Drop table `mob_hair_color_set`
--
DROP TABLE IF EXISTS mob_hair_color_set;

--
-- Drop table `name_card_bg`
--
DROP TABLE IF EXISTS name_card_bg;

--
-- Drop table `need_piece_num_data`
--
DROP TABLE IF EXISTS need_piece_num_data;

--
-- Drop table `nickname`
--
DROP TABLE IF EXISTS nickname;

--
-- Drop table `note_profile`
--
DROP TABLE IF EXISTS note_profile;

--
-- Drop table `note_profile_text_type`
--
DROP TABLE IF EXISTS note_profile_text_type;

--
-- Drop table `paid_gacha_button_type`
--
DROP TABLE IF EXISTS paid_gacha_button_type;

--
-- Drop table `piece_data`
--
DROP TABLE IF EXISTS piece_data;

--
-- Drop table `price_change`
--
DROP TABLE IF EXISTS price_change;

--
-- Drop table `race`
--
DROP TABLE IF EXISTS race;

--
-- Drop table `race_bgm`
--
DROP TABLE IF EXISTS race_bgm;

--
-- Drop table `race_bgm_cutin`
--
DROP TABLE IF EXISTS race_bgm_cutin;

--
-- Drop table `race_bgm_pattern`
--
DROP TABLE IF EXISTS race_bgm_pattern;

--
-- Drop table `race_bib_color`
--
DROP TABLE IF EXISTS race_bib_color;

--
-- Drop table `race_condition`
--
DROP TABLE IF EXISTS race_condition;

--
-- Drop table `race_course_set`
--
DROP TABLE IF EXISTS race_course_set;

--
-- Drop table `race_course_set_status`
--
DROP TABLE IF EXISTS race_course_set_status;

--
-- Drop table `race_env_define`
--
DROP TABLE IF EXISTS race_env_define;

--
-- Drop table `race_fence_set`
--
DROP TABLE IF EXISTS race_fence_set;

--
-- Drop table `race_instance`
--
DROP TABLE IF EXISTS race_instance;

--
-- Drop table `race_jikkyo_base`
--
DROP TABLE IF EXISTS race_jikkyo_base;

--
-- Drop table `race_jikkyo_base_venus`
--
DROP TABLE IF EXISTS race_jikkyo_base_venus;

--
-- Drop table `race_jikkyo_comment`
--
DROP TABLE IF EXISTS race_jikkyo_comment;

--
-- Drop table `race_jikkyo_cue`
--
DROP TABLE IF EXISTS race_jikkyo_cue;

--
-- Drop table `race_jikkyo_message`
--
DROP TABLE IF EXISTS race_jikkyo_message;

--
-- Drop table `race_jikkyo_race`
--
DROP TABLE IF EXISTS race_jikkyo_race;

--
-- Drop table `race_jikkyo_trigger`
--
DROP TABLE IF EXISTS race_jikkyo_trigger;

--
-- Drop table `race_motivation_rate`
--
DROP TABLE IF EXISTS race_motivation_rate;

--
-- Drop table `race_overrun_pattern`
--
DROP TABLE IF EXISTS race_overrun_pattern;

--
-- Drop table `race_player_camera`
--
DROP TABLE IF EXISTS race_player_camera;

--
-- Drop table `race_proper_distance_rate`
--
DROP TABLE IF EXISTS race_proper_distance_rate;

--
-- Drop table `race_proper_ground_rate`
--
DROP TABLE IF EXISTS race_proper_ground_rate;

--
-- Drop table `race_proper_runningstyle_rate`
--
DROP TABLE IF EXISTS race_proper_runningstyle_rate;

--
-- Drop table `race_single_mode_team_status`
--
DROP TABLE IF EXISTS race_single_mode_team_status;

--
-- Drop table `race_track`
--
DROP TABLE IF EXISTS race_track;

--
-- Drop table `race_trophy`
--
DROP TABLE IF EXISTS race_trophy;

--
-- Drop table `random_ear_tail_motion`
--
DROP TABLE IF EXISTS random_ear_tail_motion;

--
-- Drop table `rating_race_condition`
--
DROP TABLE IF EXISTS rating_race_condition;

--
-- Drop table `rating_race_data`
--
DROP TABLE IF EXISTS rating_race_data;

--
-- Drop table `rating_race_finale_reward`
--
DROP TABLE IF EXISTS rating_race_finale_reward;

--
-- Drop table `rating_race_phase_schedule`
--
DROP TABLE IF EXISTS rating_race_phase_schedule;

--
-- Drop table `rating_race_rating_rank`
--
DROP TABLE IF EXISTS rating_race_rating_rank;

--
-- Drop table `rating_race_reward_group`
--
DROP TABLE IF EXISTS rating_race_reward_group;

--
-- Drop table `rating_race_weekend_reward`
--
DROP TABLE IF EXISTS rating_race_weekend_reward;

--
-- Drop table `room_match_training_rank`
--
DROP TABLE IF EXISTS room_match_training_rank;

--
-- Drop table `season_data`
--
DROP TABLE IF EXISTS season_data;

--
-- Drop table `select_pickup`
--
DROP TABLE IF EXISTS select_pickup;

--
-- Drop table `short_episode`
--
DROP TABLE IF EXISTS short_episode;

--
-- Drop table `single_mode_09_board`
--
DROP TABLE IF EXISTS single_mode_09_board;

--
-- Drop table `single_mode_09_chip`
--
DROP TABLE IF EXISTS single_mode_09_chip;

--
-- Drop table `single_mode_09_chip_effect`
--
DROP TABLE IF EXISTS single_mode_09_chip_effect;

--
-- Drop table `single_mode_09_learning_bonus`
--
DROP TABLE IF EXISTS single_mode_09_learning_bonus;

--
-- Drop table `single_mode_09_link_effect`
--
DROP TABLE IF EXISTS single_mode_09_link_effect;

--
-- Drop table `single_mode_09_progress_rate`
--
DROP TABLE IF EXISTS single_mode_09_progress_rate;

--
-- Drop table `single_mode_09_schedule`
--
DROP TABLE IF EXISTS single_mode_09_schedule;

--
-- Drop table `single_mode_09_training_boost`
--
DROP TABLE IF EXISTS single_mode_09_training_boost;

--
-- Drop table `single_mode_analyze_condition`
--
DROP TABLE IF EXISTS single_mode_analyze_condition;

--
-- Drop table `single_mode_analyze_message`
--
DROP TABLE IF EXISTS single_mode_analyze_message;

--
-- Drop table `single_mode_analyze_ticket`
--
DROP TABLE IF EXISTS single_mode_analyze_ticket;

--
-- Drop table `single_mode_aoharu_cutt_type`
--
DROP TABLE IF EXISTS single_mode_aoharu_cutt_type;

--
-- Drop table `single_mode_aoharu_result_cutt`
--
DROP TABLE IF EXISTS single_mode_aoharu_result_cutt;

--
-- Drop table `single_mode_aoharu_schedule`
--
DROP TABLE IF EXISTS single_mode_aoharu_schedule;

--
-- Drop table `single_mode_ao_offset`
--
DROP TABLE IF EXISTS single_mode_ao_offset;

--
-- Drop table `single_mode_arc_debuff`
--
DROP TABLE IF EXISTS single_mode_arc_debuff;

--
-- Drop table `single_mode_arc_potential`
--
DROP TABLE IF EXISTS single_mode_arc_potential;

--
-- Drop table `single_mode_arc_potential_bonus`
--
DROP TABLE IF EXISTS single_mode_arc_potential_bonus;

--
-- Drop table `single_mode_arc_potential_buff`
--
DROP TABLE IF EXISTS single_mode_arc_potential_buff;

--
-- Drop table `single_mode_arc_potential_cond`
--
DROP TABLE IF EXISTS single_mode_arc_potential_cond;

--
-- Drop table `single_mode_arc_potential_level`
--
DROP TABLE IF EXISTS single_mode_arc_potential_level;

--
-- Drop table `single_mode_arc_race_debuff`
--
DROP TABLE IF EXISTS single_mode_arc_race_debuff;

--
-- Drop table `single_mode_arc_schedule`
--
DROP TABLE IF EXISTS single_mode_arc_schedule;

--
-- Drop table `single_mode_arc_taiman_peff_grp`
--
DROP TABLE IF EXISTS single_mode_arc_taiman_peff_grp;

--
-- Drop table `single_mode_arc_training_eff`
--
DROP TABLE IF EXISTS single_mode_arc_training_eff;

--
-- Drop table `single_mode_arc_win_pt`
--
DROP TABLE IF EXISTS single_mode_arc_win_pt;

--
-- Drop table `single_mode_change_chara_route`
--
DROP TABLE IF EXISTS single_mode_change_chara_route;

--
-- Drop table `single_mode_chara_effect`
--
DROP TABLE IF EXISTS single_mode_chara_effect;

--
-- Drop table `single_mode_chara_effect_buff`
--
DROP TABLE IF EXISTS single_mode_chara_effect_buff;

--
-- Drop table `single_mode_chara_grade`
--
DROP TABLE IF EXISTS single_mode_chara_grade;

--
-- Drop table `single_mode_chara_program`
--
DROP TABLE IF EXISTS single_mode_chara_program;

--
-- Drop table `single_mode_conclusion_set`
--
DROP TABLE IF EXISTS single_mode_conclusion_set;

--
-- Drop table `single_mode_cook_coin_rate`
--
DROP TABLE IF EXISTS single_mode_cook_coin_rate;

--
-- Drop table `single_mode_cook_cooking_cutt`
--
DROP TABLE IF EXISTS single_mode_cook_cooking_cutt;

--
-- Drop table `single_mode_cook_cooking_rate`
--
DROP TABLE IF EXISTS single_mode_cook_cooking_rate;

--
-- Drop table `single_mode_cook_cooking_type`
--
DROP TABLE IF EXISTS single_mode_cook_cooking_type;

--
-- Drop table `single_mode_cook_dish`
--
DROP TABLE IF EXISTS single_mode_cook_dish;

--
-- Drop table `single_mode_cook_dish_cutt`
--
DROP TABLE IF EXISTS single_mode_cook_dish_cutt;

--
-- Drop table `single_mode_cook_dish_cutt_se`
--
DROP TABLE IF EXISTS single_mode_cook_dish_cutt_se;

--
-- Drop table `single_mode_cook_dish_effect`
--
DROP TABLE IF EXISTS single_mode_cook_dish_effect;

--
-- Drop table `single_mode_cook_dish_icon`
--
DROP TABLE IF EXISTS single_mode_cook_dish_icon;

--
-- Drop table `single_mode_cook_dish_material`
--
DROP TABLE IF EXISTS single_mode_cook_dish_material;

--
-- Drop table `single_mode_cook_dish_name`
--
DROP TABLE IF EXISTS single_mode_cook_dish_name;

--
-- Drop table `single_mode_cook_garden`
--
DROP TABLE IF EXISTS single_mode_cook_garden;

--
-- Drop table `single_mode_cook_garden_bg`
--
DROP TABLE IF EXISTS single_mode_cook_garden_bg;

--
-- Drop table `single_mode_cook_garden_effect`
--
DROP TABLE IF EXISTS single_mode_cook_garden_effect;

--
-- Drop table `single_mode_cook_garden_level`
--
DROP TABLE IF EXISTS single_mode_cook_garden_level;

--
-- Drop table `single_mode_cook_listener`
--
DROP TABLE IF EXISTS single_mode_cook_listener;

--
-- Drop table `single_mode_cook_material_rate`
--
DROP TABLE IF EXISTS single_mode_cook_material_rate;

--
-- Drop table `single_mode_cook_message`
--
DROP TABLE IF EXISTS single_mode_cook_message;

--
-- Drop table `single_mode_cook_motion_group`
--
DROP TABLE IF EXISTS single_mode_cook_motion_group;

--
-- Drop table `single_mode_cook_motion_status`
--
DROP TABLE IF EXISTS single_mode_cook_motion_status;

--
-- Drop table `single_mode_cook_power_data`
--
DROP TABLE IF EXISTS single_mode_cook_power_data;

--
-- Drop table `single_mode_cook_stand_motion`
--
DROP TABLE IF EXISTS single_mode_cook_stand_motion;

--
-- Drop table `single_mode_cook_success_effect`
--
DROP TABLE IF EXISTS single_mode_cook_success_effect;

--
-- Drop table `single_mode_cook_success_odds`
--
DROP TABLE IF EXISTS single_mode_cook_success_odds;

--
-- Drop table `single_mode_cook_success_type`
--
DROP TABLE IF EXISTS single_mode_cook_success_type;

--
-- Drop table `single_mode_difficulty_box`
--
DROP TABLE IF EXISTS single_mode_difficulty_box;

--
-- Drop table `single_mode_difficulty_box_gauge`
--
DROP TABLE IF EXISTS single_mode_difficulty_box_gauge;

--
-- Drop table `single_mode_difficulty_box_reward`
--
DROP TABLE IF EXISTS single_mode_difficulty_box_reward;

--
-- Drop table `single_mode_difficulty_data`
--
DROP TABLE IF EXISTS single_mode_difficulty_data;

--
-- Drop table `single_mode_difficulty_mode`
--
DROP TABLE IF EXISTS single_mode_difficulty_mode;

--
-- Drop table `single_mode_evaluation`
--
DROP TABLE IF EXISTS single_mode_evaluation;

--
-- Drop table `single_mode_event_conclusion`
--
DROP TABLE IF EXISTS single_mode_event_conclusion;

--
-- Drop table `single_mode_event_item_detail`
--
DROP TABLE IF EXISTS single_mode_event_item_detail;

--
-- Drop table `single_mode_event_production`
--
DROP TABLE IF EXISTS single_mode_event_production;

--
-- Drop table `single_mode_fan_count`
--
DROP TABLE IF EXISTS single_mode_fan_count;

--
-- Drop table `single_mode_free_coin_race`
--
DROP TABLE IF EXISTS single_mode_free_coin_race;

--
-- Drop table `single_mode_free_shop`
--
DROP TABLE IF EXISTS single_mode_free_shop;

--
-- Drop table `single_mode_free_shop_bg`
--
DROP TABLE IF EXISTS single_mode_free_shop_bg;

--
-- Drop table `single_mode_free_shop_effect`
--
DROP TABLE IF EXISTS single_mode_free_shop_effect;

--
-- Drop table `single_mode_free_shop_item`
--
DROP TABLE IF EXISTS single_mode_free_shop_item;

--
-- Drop table `single_mode_free_training_plate`
--
DROP TABLE IF EXISTS single_mode_free_training_plate;

--
-- Drop table `single_mode_free_win_point`
--
DROP TABLE IF EXISTS single_mode_free_win_point;

--
-- Drop table `single_mode_hide_chara_text`
--
DROP TABLE IF EXISTS single_mode_hide_chara_text;

--
-- Drop table `single_mode_hint_gain`
--
DROP TABLE IF EXISTS single_mode_hint_gain;

--
-- Drop table `single_mode_live_live_data`
--
DROP TABLE IF EXISTS single_mode_live_live_data;

--
-- Drop table `single_mode_live_master_bonus`
--
DROP TABLE IF EXISTS single_mode_live_master_bonus;

--
-- Drop table `single_mode_live_song_list`
--
DROP TABLE IF EXISTS single_mode_live_song_list;

--
-- Drop table `single_mode_live_square`
--
DROP TABLE IF EXISTS single_mode_live_square;

--
-- Drop table `single_mode_member_rank`
--
DROP TABLE IF EXISTS single_mode_member_rank;

--
-- Drop table `single_mode_member_rank_points`
--
DROP TABLE IF EXISTS single_mode_member_rank_points;

--
-- Drop table `single_mode_message`
--
DROP TABLE IF EXISTS single_mode_message;

--
-- Drop table `single_mode_npc`
--
DROP TABLE IF EXISTS single_mode_npc;

--
-- Drop table `single_mode_outing`
--
DROP TABLE IF EXISTS single_mode_outing;

--
-- Drop table `single_mode_outing_set`
--
DROP TABLE IF EXISTS single_mode_outing_set;

--
-- Drop table `single_mode_preview_bgm`
--
DROP TABLE IF EXISTS single_mode_preview_bgm;

--
-- Drop table `single_mode_program`
--
DROP TABLE IF EXISTS single_mode_program;

--
-- Drop table `single_mode_race_group`
--
DROP TABLE IF EXISTS single_mode_race_group;

--
-- Drop table `single_mode_race_limit_reward`
--
DROP TABLE IF EXISTS single_mode_race_limit_reward;

--
-- Drop table `single_mode_race_live`
--
DROP TABLE IF EXISTS single_mode_race_live;

--
-- Drop table `single_mode_race_restrict_turn`
--
DROP TABLE IF EXISTS single_mode_race_restrict_turn;

--
-- Drop table `single_mode_rank`
--
DROP TABLE IF EXISTS single_mode_rank;

--
-- Drop table `single_mode_recommend`
--
DROP TABLE IF EXISTS single_mode_recommend;

--
-- Drop table `single_mode_recommend_setting`
--
DROP TABLE IF EXISTS single_mode_recommend_setting;

--
-- Drop table `single_mode_restrict_support`
--
DROP TABLE IF EXISTS single_mode_restrict_support;

--
-- Drop table `single_mode_reward_set`
--
DROP TABLE IF EXISTS single_mode_reward_set;

--
-- Drop table `single_mode_rival`
--
DROP TABLE IF EXISTS single_mode_rival;

--
-- Drop table `single_mode_route`
--
DROP TABLE IF EXISTS single_mode_route;

--
-- Drop table `single_mode_route_announce`
--
DROP TABLE IF EXISTS single_mode_route_announce;

--
-- Drop table `single_mode_route_condition`
--
DROP TABLE IF EXISTS single_mode_route_condition;

--
-- Drop table `single_mode_route_race`
--
DROP TABLE IF EXISTS single_mode_route_race;

--
-- Drop table `single_mode_scenario`
--
DROP TABLE IF EXISTS single_mode_scenario;

--
-- Drop table `single_mode_scenario_group`
--
DROP TABLE IF EXISTS single_mode_scenario_group;

--
-- Drop table `single_mode_scenario_record`
--
DROP TABLE IF EXISTS single_mode_scenario_record;

--
-- Drop table `single_mode_scenario_update`
--
DROP TABLE IF EXISTS single_mode_scenario_update;

--
-- Drop table `single_mode_scout_chara`
--
DROP TABLE IF EXISTS single_mode_scout_chara;

--
-- Drop table `single_mode_skill_need_point`
--
DROP TABLE IF EXISTS single_mode_skill_need_point;

--
-- Drop table `single_mode_special_chara`
--
DROP TABLE IF EXISTS single_mode_special_chara;

--
-- Drop table `single_mode_sport_competition`
--
DROP TABLE IF EXISTS single_mode_sport_competition;

--
-- Drop table `single_mode_sport_compe_effect`
--
DROP TABLE IF EXISTS single_mode_sport_compe_effect;

--
-- Drop table `single_mode_sport_compe_se`
--
DROP TABLE IF EXISTS single_mode_sport_compe_se;

--
-- Drop table `single_mode_sport_item_effect`
--
DROP TABLE IF EXISTS single_mode_sport_item_effect;

--
-- Drop table `single_mode_sport_link`
--
DROP TABLE IF EXISTS single_mode_sport_link;

--
-- Drop table `single_mode_sport_mob`
--
DROP TABLE IF EXISTS single_mode_sport_mob;

--
-- Drop table `single_mode_sport_sport_type`
--
DROP TABLE IF EXISTS single_mode_sport_sport_type;

--
-- Drop table `single_mode_sport_stance`
--
DROP TABLE IF EXISTS single_mode_sport_stance;

--
-- Drop table `single_mode_sport_stance_effect`
--
DROP TABLE IF EXISTS single_mode_sport_stance_effect;

--
-- Drop table `single_mode_sport_training_cut`
--
DROP TABLE IF EXISTS single_mode_sport_training_cut;

--
-- Drop table `single_mode_story_data`
--
DROP TABLE IF EXISTS single_mode_story_data;

--
-- Drop table `single_mode_story_guide`
--
DROP TABLE IF EXISTS single_mode_story_guide;

--
-- Drop table `single_mode_tag_card_pos`
--
DROP TABLE IF EXISTS single_mode_tag_card_pos;

--
-- Drop table `single_mode_team_name`
--
DROP TABLE IF EXISTS single_mode_team_name;

--
-- Drop table `single_mode_team_race_set`
--
DROP TABLE IF EXISTS single_mode_team_race_set;

--
-- Drop table `single_mode_top_bg`
--
DROP TABLE IF EXISTS single_mode_top_bg;

--
-- Drop table `single_mode_top_bg_chara`
--
DROP TABLE IF EXISTS single_mode_top_bg_chara;

--
-- Drop table `single_mode_training`
--
DROP TABLE IF EXISTS single_mode_training;

--
-- Drop table `single_mode_training_bg_chara`
--
DROP TABLE IF EXISTS single_mode_training_bg_chara;

--
-- Drop table `single_mode_training_effect`
--
DROP TABLE IF EXISTS single_mode_training_effect;

--
-- Drop table `single_mode_training_plate`
--
DROP TABLE IF EXISTS single_mode_training_plate;

--
-- Drop table `single_mode_training_se`
--
DROP TABLE IF EXISTS single_mode_training_se;

--
-- Drop table `single_mode_turn`
--
DROP TABLE IF EXISTS single_mode_turn;

--
-- Drop table `single_mode_unique_chara`
--
DROP TABLE IF EXISTS single_mode_unique_chara;

--
-- Drop table `single_mode_venus_crystal_group`
--
DROP TABLE IF EXISTS single_mode_venus_crystal_group;

--
-- Drop table `single_mode_venus_spirit_effect`
--
DROP TABLE IF EXISTS single_mode_venus_spirit_effect;

--
-- Drop table `single_mode_venus_spirit_group`
--
DROP TABLE IF EXISTS single_mode_venus_spirit_group;

--
-- Drop table `single_mode_venus_sprace_data`
--
DROP TABLE IF EXISTS single_mode_venus_sprace_data;

--
-- Drop table `single_mode_wins_saddle`
--
DROP TABLE IF EXISTS single_mode_wins_saddle;

--
-- Drop table `skill_data`
--
DROP TABLE IF EXISTS skill_data;

--
-- Drop table `skill_exp`
--
DROP TABLE IF EXISTS skill_exp;

--
-- Drop table `skill_level_value`
--
DROP TABLE IF EXISTS skill_level_value;

--
-- Drop table `skill_set`
--
DROP TABLE IF EXISTS skill_set;

--
-- Drop table `skill_upgrade_condition`
--
DROP TABLE IF EXISTS skill_upgrade_condition;

--
-- Drop table `skill_upgrade_description`
--
DROP TABLE IF EXISTS skill_upgrade_description;

--
-- Drop table `skill_upgrade_speciality`
--
DROP TABLE IF EXISTS skill_upgrade_speciality;

--
-- Drop table `skill_up_scenario_condition`
--
DROP TABLE IF EXISTS skill_up_scenario_condition;

--
-- Drop table `story_event_bingo_reward`
--
DROP TABLE IF EXISTS story_event_bingo_reward;

--
-- Drop table `story_event_bonus_card`
--
DROP TABLE IF EXISTS story_event_bonus_card;

--
-- Drop table `story_event_bonus_group_support_card`
--
DROP TABLE IF EXISTS story_event_bonus_group_support_card;

--
-- Drop table `story_event_bonus_support_card`
--
DROP TABLE IF EXISTS story_event_bonus_support_card;

--
-- Drop table `story_event_data`
--
DROP TABLE IF EXISTS story_event_data;

--
-- Drop table `story_event_mission`
--
DROP TABLE IF EXISTS story_event_mission;

--
-- Drop table `story_event_mission_top_chara`
--
DROP TABLE IF EXISTS story_event_mission_top_chara;

--
-- Drop table `story_event_nickname_bonus`
--
DROP TABLE IF EXISTS story_event_nickname_bonus;

--
-- Drop table `story_event_point_reward`
--
DROP TABLE IF EXISTS story_event_point_reward;

--
-- Drop table `story_event_roulette_bingo`
--
DROP TABLE IF EXISTS story_event_roulette_bingo;

--
-- Drop table `story_event_story_data`
--
DROP TABLE IF EXISTS story_event_story_data;

--
-- Drop table `story_event_top_chara`
--
DROP TABLE IF EXISTS story_event_top_chara;

--
-- Drop table `story_extra_data`
--
DROP TABLE IF EXISTS story_extra_data;

--
-- Drop table `story_extra_movie_data`
--
DROP TABLE IF EXISTS story_extra_movie_data;

--
-- Drop table `story_extra_story_data`
--
DROP TABLE IF EXISTS story_extra_story_data;

--
-- Drop table `story_hip_offset`
--
DROP TABLE IF EXISTS story_hip_offset;

--
-- Drop table `story_live_position`
--
DROP TABLE IF EXISTS story_live_position;

--
-- Drop table `story_still`
--
DROP TABLE IF EXISTS story_still;

--
-- Drop table `story_wipe_dictionary`
--
DROP TABLE IF EXISTS story_wipe_dictionary;

--
-- Drop table `subscription_effect`
--
DROP TABLE IF EXISTS subscription_effect;

--
-- Drop table `succession_factor`
--
DROP TABLE IF EXISTS succession_factor;

--
-- Drop table `succession_factor_effect`
--
DROP TABLE IF EXISTS succession_factor_effect;

--
-- Drop table `succession_initial_factor`
--
DROP TABLE IF EXISTS succession_initial_factor;

--
-- Drop table `succession_relation`
--
DROP TABLE IF EXISTS succession_relation;

--
-- Drop table `succession_relation_member`
--
DROP TABLE IF EXISTS succession_relation_member;

--
-- Drop table `succession_relation_rank`
--
DROP TABLE IF EXISTS succession_relation_rank;

--
-- Drop table `succession_rental`
--
DROP TABLE IF EXISTS succession_rental;

--
-- Drop table `support_card_data`
--
DROP TABLE IF EXISTS support_card_data;

--
-- Drop table `support_card_effect_filter`
--
DROP TABLE IF EXISTS support_card_effect_filter;

--
-- Drop table `support_card_effect_filter_group`
--
DROP TABLE IF EXISTS support_card_effect_filter_group;

--
-- Drop table `support_card_effect_table`
--
DROP TABLE IF EXISTS support_card_effect_table;

--
-- Drop table `support_card_group`
--
DROP TABLE IF EXISTS support_card_group;

--
-- Drop table `support_card_level`
--
DROP TABLE IF EXISTS support_card_level;

--
-- Drop table `support_card_limit`
--
DROP TABLE IF EXISTS support_card_limit;

--
-- Drop table `support_card_limit_break`
--
DROP TABLE IF EXISTS support_card_limit_break;

--
-- Drop table `support_card_team_score_bonus`
--
DROP TABLE IF EXISTS support_card_team_score_bonus;

--
-- Drop table `support_card_unique_effect`
--
DROP TABLE IF EXISTS support_card_unique_effect;

--
-- Drop table `team_building_chara_count`
--
DROP TABLE IF EXISTS team_building_chara_count;

--
-- Drop table `team_building_chara_group`
--
DROP TABLE IF EXISTS team_building_chara_group;

--
-- Drop table `team_building_collection_chara`
--
DROP TABLE IF EXISTS team_building_collection_chara;

--
-- Drop table `team_building_collection_set`
--
DROP TABLE IF EXISTS team_building_collection_set;

--
-- Drop table `team_building_consecutive_wins`
--
DROP TABLE IF EXISTS team_building_consecutive_wins;

--
-- Drop table `team_building_data`
--
DROP TABLE IF EXISTS team_building_data;

--
-- Drop table `team_building_discount_point`
--
DROP TABLE IF EXISTS team_building_discount_point;

--
-- Drop table `team_building_race_npc`
--
DROP TABLE IF EXISTS team_building_race_npc;

--
-- Drop table `team_building_rank`
--
DROP TABLE IF EXISTS team_building_rank;

--
-- Drop table `team_building_rank_reward_group`
--
DROP TABLE IF EXISTS team_building_rank_reward_group;

--
-- Drop table `team_building_retry_bonus`
--
DROP TABLE IF EXISTS team_building_retry_bonus;

--
-- Drop table `team_building_scout_point`
--
DROP TABLE IF EXISTS team_building_scout_point;

--
-- Drop table `team_building_sp_race_schedule`
--
DROP TABLE IF EXISTS team_building_sp_race_schedule;

--
-- Drop table `team_building_team_race_set`
--
DROP TABLE IF EXISTS team_building_team_race_set;

--
-- Drop table `team_building_win_reward`
--
DROP TABLE IF EXISTS team_building_win_reward;

--
-- Drop table `team_stadium`
--
DROP TABLE IF EXISTS team_stadium;

--
-- Drop table `team_stadium_bgm`
--
DROP TABLE IF EXISTS team_stadium_bgm;

--
-- Drop table `team_stadium_class`
--
DROP TABLE IF EXISTS team_stadium_class;

--
-- Drop table `team_stadium_class_reward`
--
DROP TABLE IF EXISTS team_stadium_class_reward;

--
-- Drop table `team_stadium_evaluation_rate`
--
DROP TABLE IF EXISTS team_stadium_evaluation_rate;

--
-- Drop table `team_stadium_race_result_motion`
--
DROP TABLE IF EXISTS team_stadium_race_result_motion;

--
-- Drop table `team_stadium_rank`
--
DROP TABLE IF EXISTS team_stadium_rank;

--
-- Drop table `team_stadium_raw_score`
--
DROP TABLE IF EXISTS team_stadium_raw_score;

--
-- Drop table `team_stadium_score_bonus`
--
DROP TABLE IF EXISTS team_stadium_score_bonus;

--
-- Drop table `team_stadium_stand_motion`
--
DROP TABLE IF EXISTS team_stadium_stand_motion;

--
-- Drop table `team_stadium_support_text`
--
DROP TABLE IF EXISTS team_stadium_support_text;

--
-- Drop table `text_data`
--
DROP TABLE IF EXISTS text_data;

--
-- Drop table `timezone_data`
--
DROP TABLE IF EXISTS timezone_data;

--
-- Drop table `topics`
--
DROP TABLE IF EXISTS topics;

--
-- Drop table `trained_chara_trade_item`
--
DROP TABLE IF EXISTS trained_chara_trade_item;

--
-- Drop table `training_challenge_exam`
--
DROP TABLE IF EXISTS training_challenge_exam;

--
-- Drop table `training_challenge_master`
--
DROP TABLE IF EXISTS training_challenge_master;

--
-- Drop table `training_challenge_score`
--
DROP TABLE IF EXISTS training_challenge_score;

--
-- Drop table `training_cutt_chara_data`
--
DROP TABLE IF EXISTS training_cutt_chara_data;

--
-- Drop table `training_cutt_data`
--
DROP TABLE IF EXISTS training_cutt_data;

--
-- Drop table `training_cutt_flash`
--
DROP TABLE IF EXISTS training_cutt_flash;

--
-- Drop table `training_cutt_group_data`
--
DROP TABLE IF EXISTS training_cutt_group_data;

--
-- Drop table `training_report_inflation`
--
DROP TABLE IF EXISTS training_report_inflation;

--
-- Drop table `training_report_normal_reward`
--
DROP TABLE IF EXISTS training_report_normal_reward;

--
-- Drop table `training_report_pass`
--
DROP TABLE IF EXISTS training_report_pass;

--
-- Drop table `training_report_ratio`
--
DROP TABLE IF EXISTS training_report_ratio;

--
-- Drop table `training_report_special_reward`
--
DROP TABLE IF EXISTS training_report_special_reward;

--
-- Drop table `transfer_event_data`
--
DROP TABLE IF EXISTS transfer_event_data;

--
-- Drop table `transfer_event_detail`
--
DROP TABLE IF EXISTS transfer_event_detail;

--
-- Drop table `transfer_event_reward`
--
DROP TABLE IF EXISTS transfer_event_reward;

--
-- Drop table `transfer_rotation_data`
--
DROP TABLE IF EXISTS transfer_rotation_data;

--
-- Drop table `transfer_rotation_detail`
--
DROP TABLE IF EXISTS transfer_rotation_detail;

--
-- Drop table `transfer_rotation_reward`
--
DROP TABLE IF EXISTS transfer_rotation_reward;

--
-- Drop table `transfer_rotation_schedule`
--
DROP TABLE IF EXISTS transfer_rotation_schedule;

--
-- Drop table `tutorial_guide_data`
--
DROP TABLE IF EXISTS tutorial_guide_data;

--
-- Drop table `ultimate_race_contents`
--
DROP TABLE IF EXISTS ultimate_race_contents;

--
-- Drop table `ultimate_race_contents_change`
--
DROP TABLE IF EXISTS ultimate_race_contents_change;

--
-- Drop table `ultimate_race_data`
--
DROP TABLE IF EXISTS ultimate_race_data;

--
-- Drop table `ultimate_race_npc`
--
DROP TABLE IF EXISTS ultimate_race_npc;

--
-- Drop table `ultimate_race_select_top`
--
DROP TABLE IF EXISTS ultimate_race_select_top;

--
-- Set default database
--
USE umamusume;

--
-- Create table `ultimate_race_select_top`
--
CREATE TABLE ultimate_race_select_top (
  id int(11) NOT NULL,
  group_id int(11) NOT NULL,
  chara_id int(11) NOT NULL,
  dress_id int(11) NOT NULL,
  clear_history_racetitle int(11) NOT NULL,
  clear_history_racetitle_sub int(11) NOT NULL
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 910,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `ultimate_race_select_top_0_group_id` on table `ultimate_race_select_top`
--
ALTER TABLE ultimate_race_select_top
ADD INDEX ultimate_race_select_top_0_group_id (group_id);

--
-- Create table `ultimate_race_npc`
--
CREATE TABLE ultimate_race_npc (
  id int(11) NOT NULL,
  npc_group_id int(11) NOT NULL,
  chara_id int(11) NOT NULL,
  mob_id int(11) NOT NULL,
  race_dress_id int(11) NOT NULL,
  cutin_flag int(11) NOT NULL,
  speed int(11) NOT NULL,
  stamina int(11) NOT NULL,
  pow int(11) NOT NULL,
  guts int(11) NOT NULL,
  wiz int(11) NOT NULL,
  proper_distance_short int(11) NOT NULL,
  proper_distance_mile int(11) NOT NULL,
  proper_distance_middle int(11) NOT NULL,
  proper_distance_long int(11) NOT NULL,
  proper_running_style_nige int(11) NOT NULL,
  proper_running_style_senko int(11) NOT NULL,
  proper_running_style_sashi int(11) NOT NULL,
  proper_running_style_oikomi int(11) NOT NULL,
  proper_ground_turf int(11) NOT NULL,
  proper_ground_dirt int(11) NOT NULL,
  skill_set_id int(11) NOT NULL,
  skill_set_id_1 int(11) NOT NULL,
  skill_set_id_2 int(11) NOT NULL,
  use_replacing int(11) NOT NULL,
  replace_npc_id int(11) NOT NULL,
  replace_midboss_id int(11) NOT NULL,
  replace_boss_id int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 154,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `ultimate_race_npc_0_npc_group_id` on table `ultimate_race_npc`
--
ALTER TABLE ultimate_race_npc
ADD INDEX ultimate_race_npc_0_npc_group_id (npc_group_id);

--
-- Create table `ultimate_race_data`
--
CREATE TABLE ultimate_race_data (
  id int(11) NOT NULL,
  bg_id int(11) NOT NULL,
  bg_sub_id int(11) NOT NULL,
  notice_date int(11) NOT NULL,
  start_date int(11) NOT NULL,
  end_date int(11) NOT NULL,
  bgm_cue_name text NOT NULL,
  bgm_cuesheet_name text NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 4096,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `ultimate_race_contents_change`
--
CREATE TABLE ultimate_race_contents_change (
  id int(11) NOT NULL,
  race_instance_id int(11) NOT NULL,
  npc_id int(11) NOT NULL,
  change_race_instance_id int(11) NOT NULL,
  add_clear_item_category_1 int(11) NOT NULL,
  add_clear_item_id_1 int(11) NOT NULL,
  add_clear_item_num_1 int(11) NOT NULL,
  add_clear_item_category_2 int(11) NOT NULL,
  add_clear_item_id_2 int(11) NOT NULL,
  add_clear_item_num_2 int(11) NOT NULL,
  add_clear_item_category_3 int(11) NOT NULL,
  add_clear_item_id_3 int(11) NOT NULL,
  add_clear_item_num_3 int(11) NOT NULL
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 260,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `ultimate_race_contents_change_0_race_instance_id` on table `ultimate_race_contents_change`
--
ALTER TABLE ultimate_race_contents_change
ADD INDEX ultimate_race_contents_change_0_race_instance_id (race_instance_id);

--
-- Create table `ultimate_race_contents`
--
CREATE TABLE ultimate_race_contents (
  id int(11) NOT NULL,
  event_id int(11) NOT NULL,
  group_id int(11) NOT NULL,
  difficulty int(11) NOT NULL,
  race_instance_id int(11) NOT NULL,
  season int(11) NOT NULL,
  weather int(11) NOT NULL,
  ground int(11) NOT NULL,
  first_clear_item_category_1 int(11) NOT NULL,
  first_clear_item_id_1 int(11) NOT NULL,
  first_clear_item_num_1 int(11) NOT NULL,
  first_clear_item_category_2 int(11) NOT NULL,
  first_clear_item_id_2 int(11) NOT NULL,
  first_clear_item_num_2 int(11) NOT NULL,
  first_clear_item_category_3 int(11) NOT NULL,
  first_clear_item_id_3 int(11) NOT NULL,
  first_clear_item_num_3 int(11) NOT NULL,
  start_date int(11) NOT NULL
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 303,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `ultimate_race_contents_0_event_id` on table `ultimate_race_contents`
--
ALTER TABLE ultimate_race_contents
ADD INDEX ultimate_race_contents_0_event_id (event_id);

--
-- Create index `ultimate_race_contents_0_event_id_1_group_id_2_difficulty` on table `ultimate_race_contents`
--
ALTER TABLE ultimate_race_contents
ADD INDEX ultimate_race_contents_0_event_id_1_group_id_2_difficulty (event_id, group_id, difficulty);

--
-- Create index `ultimate_race_contents_0_id` on table `ultimate_race_contents`
--
ALTER TABLE ultimate_race_contents
ADD INDEX ultimate_race_contents_0_id (id);

--
-- Create table `tutorial_guide_data`
--
CREATE TABLE tutorial_guide_data (
  id int(11) NOT NULL,
  group_id int(11) NOT NULL,
  page_index int(11) NOT NULL,
  image_index int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 146,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `tutorial_guide_data_0_group_id` on table `tutorial_guide_data`
--
ALTER TABLE tutorial_guide_data
ADD INDEX tutorial_guide_data_0_group_id (group_id);

--
-- Create index `tutorial_guide_data_0_group_id_1_page_index` on table `tutorial_guide_data`
--
ALTER TABLE tutorial_guide_data
ADD UNIQUE INDEX tutorial_guide_data_0_group_id_1_page_index (group_id, page_index);

--
-- Create table `transfer_rotation_schedule`
--
CREATE TABLE transfer_rotation_schedule (
  id int(11) NOT NULL,
  rotation_start_day int(11) NOT NULL,
  rotation_start_time text NOT NULL,
  base_date int(11) NOT NULL,
  start_date int(11) NOT NULL,
  end_date int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `transfer_rotation_reward`
--
CREATE TABLE transfer_rotation_reward (
  id int(11) NOT NULL,
  rotation_id int(11) NOT NULL,
  item_category int(11) NOT NULL,
  item_id int(11) NOT NULL,
  item_num int(11) NOT NULL,
  odds int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 63,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `transfer_rotation_reward_0_rotation_id` on table `transfer_rotation_reward`
--
ALTER TABLE transfer_rotation_reward
ADD INDEX transfer_rotation_reward_0_rotation_id (rotation_id);

--
-- Create table `transfer_rotation_detail`
--
CREATE TABLE transfer_rotation_detail (
  id int(11) NOT NULL,
  rotation_id int(11) NOT NULL,
  trainer_type int(11) NOT NULL,
  difficulty int(11) NOT NULL,
  limited_type int(11) NOT NULL,
  condition1_type int(11) NOT NULL,
  condition1_value1 int(11) NOT NULL,
  condition1_value2 int(11) NOT NULL,
  condition2_type int(11) NOT NULL,
  condition2_value1 int(11) NOT NULL,
  condition2_value2 int(11) NOT NULL,
  condition3_type int(11) NOT NULL,
  condition3_value1 int(11) NOT NULL,
  condition3_value2 int(11) NOT NULL,
  condition4_type int(11) NOT NULL,
  condition4_value1 int(11) NOT NULL,
  condition4_value2 int(11) NOT NULL,
  condition5_type int(11) NOT NULL,
  condition5_value1 int(11) NOT NULL,
  condition5_value2 int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 273,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `transfer_rotation_detail_0_rotation_id` on table `transfer_rotation_detail`
--
ALTER TABLE transfer_rotation_detail
ADD INDEX transfer_rotation_detail_0_rotation_id (rotation_id);

--
-- Create table `transfer_rotation_data`
--
CREATE TABLE transfer_rotation_data (
  id int(11) NOT NULL,
  schedule_id int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 819,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `transfer_event_reward`
--
CREATE TABLE transfer_event_reward (
  transfer_reward_id int(11) NOT NULL,
  transfer_detail_id int(11) NOT NULL,
  reward_rank int(11) NOT NULL,
  item_category int(11) NOT NULL,
  item_id int(11) NOT NULL,
  item_num int(11) NOT NULL,
  odds int(11) NOT NULL,
  PRIMARY KEY (transfer_reward_id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 130,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `transfer_event_reward_0_transfer_detail_id` on table `transfer_event_reward`
--
ALTER TABLE transfer_event_reward
ADD INDEX transfer_event_reward_0_transfer_detail_id (transfer_detail_id);

--
-- Create table `transfer_event_detail`
--
CREATE TABLE transfer_event_detail (
  transfer_detail_id int(11) NOT NULL,
  transfer_event_id int(11) NOT NULL,
  trainer_type int(11) NOT NULL,
  difficulty int(11) NOT NULL,
  limited_type int(11) NOT NULL,
  start_date int(11) NOT NULL,
  end_date int(11) NOT NULL,
  cool_time int(11) NOT NULL,
  condition1_type int(11) NOT NULL,
  condition1_value1 int(11) NOT NULL,
  condition1_value2 int(11) NOT NULL,
  condition2_type int(11) NOT NULL,
  condition2_value1 int(11) NOT NULL,
  condition2_value2 int(11) NOT NULL,
  condition3_type int(11) NOT NULL,
  condition3_value1 int(11) NOT NULL,
  condition3_value2 int(11) NOT NULL,
  condition4_type int(11) NOT NULL,
  condition4_value1 int(11) NOT NULL,
  condition4_value2 int(11) NOT NULL,
  condition5_type int(11) NOT NULL,
  condition5_value1 int(11) NOT NULL,
  condition5_value2 int(11) NOT NULL,
  PRIMARY KEY (transfer_detail_id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 303,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `transfer_event_detail_0_transfer_event_id` on table `transfer_event_detail`
--
ALTER TABLE transfer_event_detail
ADD INDEX transfer_event_detail_0_transfer_event_id (transfer_event_id);

--
-- Create table `transfer_event_data`
--
CREATE TABLE transfer_event_data (
  transfer_event_id int(11) NOT NULL,
  pre_start_date int(11) NOT NULL,
  start_date int(11) NOT NULL,
  end_date int(11) NOT NULL,
  logo_id int(11) NOT NULL,
  bg_id int(11) NOT NULL,
  bg_sub_id int(11) NOT NULL,
  tutorial_guide_id int(11) NOT NULL,
  bgm_cue_name text NOT NULL,
  bgm_cuesheet_name text NOT NULL,
  top_trigger int(11) NOT NULL,
  finish_trigger int(11) NOT NULL,
  clear_trigger int(11) NOT NULL,
  PRIMARY KEY (transfer_event_id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 2048,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `training_report_special_reward`
--
CREATE TABLE training_report_special_reward (
  id int(11) NOT NULL,
  reward_set int(11) NOT NULL,
  is_pickup int(11) NOT NULL,
  base_point int(11) NOT NULL,
  reward_item_id int(11) NOT NULL,
  reward_item_category int(11) NOT NULL,
  reward_item_num int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 109,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `training_report_special_reward_0_reward_set` on table `training_report_special_reward`
--
ALTER TABLE training_report_special_reward
ADD INDEX training_report_special_reward_0_reward_set (reward_set);

--
-- Create table `training_report_ratio`
--
CREATE TABLE training_report_ratio (
  id int(11) NOT NULL,
  type int(11) NOT NULL,
  value int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 5461,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `training_report_ratio_0_type` on table `training_report_ratio`
--
ALTER TABLE training_report_ratio
ADD UNIQUE INDEX training_report_ratio_0_type (type);

--
-- Create table `training_report_pass`
--
CREATE TABLE training_report_pass (
  id int(11) NOT NULL,
  season_id int(11) NOT NULL,
  product_master_id int(11) NOT NULL,
  inflation_coef int(11) NOT NULL,
  normal_reward_set int(11) NOT NULL,
  special_reward_set int(11) NOT NULL,
  remind_date text NOT NULL,
  start_date text NOT NULL,
  end_date text NOT NULL,
  bg_image text NOT NULL,
  jobs_training_report_point_limit int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1489,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `training_report_pass_0_season_id` on table `training_report_pass`
--
ALTER TABLE training_report_pass
ADD UNIQUE INDEX training_report_pass_0_season_id (season_id);

--
-- Create table `training_report_normal_reward`
--
CREATE TABLE training_report_normal_reward (
  id int(11) NOT NULL,
  reward_set int(11) NOT NULL,
  is_pickup int(11) NOT NULL,
  base_point int(11) NOT NULL,
  reward_item_id int(11) NOT NULL,
  reward_item_category int(11) NOT NULL,
  reward_item_num int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 109,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `training_report_normal_reward_0_reward_set` on table `training_report_normal_reward`
--
ALTER TABLE training_report_normal_reward
ADD INDEX training_report_normal_reward_0_reward_set (reward_set);

--
-- Create table `training_report_inflation`
--
CREATE TABLE training_report_inflation (
  id int(11) NOT NULL,
  point_threshold int(11) NOT NULL,
  value int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 268,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `training_cutt_group_data`
--
CREATE TABLE training_cutt_group_data (
  group_id int(11) NOT NULL,
  `order` int(11) NOT NULL,
  command_id int(11) NOT NULL,
  sub_id int(11) NOT NULL
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 5461,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `group_id` on table `training_cutt_group_data`
--
ALTER TABLE training_cutt_group_data
ADD UNIQUE INDEX group_id (group_id, `order`);

--
-- Create index `training_cutt_group_data_0_group_id` on table `training_cutt_group_data`
--
ALTER TABLE training_cutt_group_data
ADD INDEX training_cutt_group_data_0_group_id (group_id);

--
-- Create table `training_cutt_flash`
--
CREATE TABLE training_cutt_flash (
  command_id int(11) NOT NULL,
  sub_folder text NOT NULL,
  file_format text NOT NULL,
  control_type int(11) NOT NULL,
  PRIMARY KEY (command_id)
)
ENGINE = INNODB,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `training_cutt_data`
--
CREATE TABLE training_cutt_data (
  command_id int(11) NOT NULL,
  sub_id int(11) NOT NULL,
  chara_num int(11) NOT NULL,
  target_chara_index int(11) NOT NULL,
  target_value int(11) NOT NULL,
  cutt_index int(11) NOT NULL,
  success_flg int(11) NOT NULL
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 227,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `training_cutt_data_0_command_id_1_sub_id` on table `training_cutt_data`
--
ALTER TABLE training_cutt_data
ADD INDEX training_cutt_data_0_command_id_1_sub_id (command_id, sub_id);

--
-- Create table `training_cutt_chara_data`
--
CREATE TABLE training_cutt_chara_data (
  id int(11) NOT NULL,
  command_id int(11) NOT NULL,
  sub_id int(11) NOT NULL,
  chara_num int(11) NOT NULL,
  chara_id int(11) NOT NULL,
  target_timeline int(11) NOT NULL,
  target_list_index int(11) NOT NULL,
  prop_target int(11) NOT NULL,
  dress_id int(11) NOT NULL,
  selector_label int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 58,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `training_cutt_chara_data_0_command_id_1_sub_id` on table `training_cutt_chara_data`
--
ALTER TABLE training_cutt_chara_data
ADD INDEX training_cutt_chara_data_0_command_id_1_sub_id (command_id, sub_id);

--
-- Create table `training_challenge_score`
--
CREATE TABLE training_challenge_score (
  id int(11) NOT NULL,
  score_group_id int(11) NOT NULL,
  score_type int(11) NOT NULL,
  data int(11) NOT NULL,
  disp_order int(11) NOT NULL,
  bonus_score int(11) NOT NULL,
  reward_coin int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 130,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `training_challenge_score_0_score_group_id` on table `training_challenge_score`
--
ALTER TABLE training_challenge_score
ADD INDEX training_challenge_score_0_score_group_id (score_group_id);

--
-- Create table `training_challenge_master`
--
CREATE TABLE training_challenge_master (
  id int(11) NOT NULL,
  target_main_scenario int(11) NOT NULL,
  exam_id_1 int(11) NOT NULL,
  exam_id_2 int(11) NOT NULL,
  exam_id_3 int(11) NOT NULL,
  exam_id_4 int(11) NOT NULL,
  exam_id_5 int(11) NOT NULL,
  ex_exam_id int(11) NOT NULL,
  free_exam_id int(11) NOT NULL,
  shop_id int(11) NOT NULL,
  start_date int(11) NOT NULL,
  end_date int(11) NOT NULL,
  start_result_date int(11) NOT NULL,
  end_result_date int(11) NOT NULL,
  notice_date int(11) NOT NULL,
  rental_value int(11) NOT NULL,
  consume_tp_ratio int(11) NOT NULL,
  bonus_reward_ratio int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 16384,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `training_challenge_exam`
--
CREATE TABLE training_challenge_exam (
  id int(11) NOT NULL,
  feature_type int(11) NOT NULL,
  good_score int(11) NOT NULL,
  good_score_reward_coin int(11) NOT NULL,
  great_score int(11) NOT NULL,
  great_score_reward_coin int(11) NOT NULL,
  exellent_score int(11) NOT NULL,
  exellent_score_reward_coin int(11) NOT NULL,
  score_group_id int(11) NOT NULL,
  item_category_1 int(11) NOT NULL,
  item_id_1 int(11) NOT NULL,
  item_num_1 int(11) NOT NULL,
  item_category_2 int(11) NOT NULL,
  item_id_2 int(11) NOT NULL,
  item_num_2 int(11) NOT NULL,
  item_category_3 int(11) NOT NULL,
  item_id_3 int(11) NOT NULL,
  item_num_3 int(11) NOT NULL,
  item_category_4 int(11) NOT NULL,
  item_id_4 int(11) NOT NULL,
  item_num_4 int(11) NOT NULL,
  item_category_5 int(11) NOT NULL,
  item_id_5 int(11) NOT NULL,
  item_num_5 int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 2340,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `trained_chara_trade_item`
--
CREATE TABLE trained_chara_trade_item (
  id int(11) NOT NULL,
  trained_chara_rank int(11) NOT NULL,
  trade_item_category int(11) NOT NULL,
  trade_item_id int(11) NOT NULL,
  trade_item_num int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 167,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `trained_chara_trade_item_0_trained_chara_rank` on table `trained_chara_trade_item`
--
ALTER TABLE trained_chara_trade_item
ADD UNIQUE INDEX trained_chara_trade_item_0_trained_chara_rank (trained_chara_rank);

--
-- Create table `topics`
--
CREATE TABLE topics (
  id int(11) NOT NULL,
  type int(11) NOT NULL,
  value int(11) NOT NULL,
  `index` int(11) NOT NULL,
  start_date text NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 144,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `topics_0_type` on table `topics`
--
ALTER TABLE topics
ADD INDEX topics_0_type (type);

--
-- Create table `timezone_data`
--
CREATE TABLE timezone_data (
  timezone int(11) NOT NULL,
  priority int(11) NOT NULL,
  start_hour text NOT NULL,
  end_hour text NOT NULL,
  PRIMARY KEY (timezone)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 4096,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `text_data`
--
CREATE TABLE text_data (
  id int(11) NOT NULL,
  category int(11) NOT NULL,
  `index` int(11) NOT NULL,
  text text NOT NULL,
  PRIMARY KEY (category, `index`)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 112,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `team_stadium_support_text`
--
CREATE TABLE team_stadium_support_text (
  id int(11) NOT NULL,
  type int(11) NOT NULL,
  min_bonus int(11) NOT NULL,
  max_bonus int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1638,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `team_stadium_support_text_0_type` on table `team_stadium_support_text`
--
ALTER TABLE team_stadium_support_text
ADD INDEX team_stadium_support_text_0_type (type);

--
-- Create table `team_stadium_stand_motion`
--
CREATE TABLE team_stadium_stand_motion (
  character_id int(11) NOT NULL,
  type int(11) NOT NULL,
  race_dress_id int(11) NOT NULL,
  `position` int(11) NOT NULL,
  motion_set int(11) NOT NULL,
  rotation int(11) NOT NULL,
  position_x int(11) NOT NULL
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1170,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `team_stadium_stand_motion_0_character_id_1_type` on table `team_stadium_stand_motion`
--
ALTER TABLE team_stadium_stand_motion
ADD INDEX team_stadium_stand_motion_0_character_id_1_type (character_id, type);

--
-- Create table `team_stadium_score_bonus`
--
CREATE TABLE team_stadium_score_bonus (
  id int(11) NOT NULL,
  priority int(11) NOT NULL,
  condition_type int(11) NOT NULL,
  condition_value_1 int(11) NOT NULL,
  condition_value_2 int(11) NOT NULL,
  score_rate int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 2340,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `team_stadium_score_bonus_0_condition_type` on table `team_stadium_score_bonus`
--
ALTER TABLE team_stadium_score_bonus
ADD INDEX team_stadium_score_bonus_0_condition_type (condition_type);

--
-- Create table `team_stadium_raw_score`
--
CREATE TABLE team_stadium_raw_score (
  id int(11) NOT NULL,
  priority int(11) NOT NULL,
  condition_type int(11) NOT NULL,
  condition_value_1 int(11) NOT NULL,
  condition_value_2 int(11) NOT NULL,
  score int(11) NOT NULL,
  race_score_name_id int(11) NOT NULL,
  sort_order int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 172,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `team_stadium_raw_score_0_condition_type` on table `team_stadium_raw_score`
--
ALTER TABLE team_stadium_raw_score
ADD INDEX team_stadium_raw_score_0_condition_type (condition_type);

--
-- Create index `team_stadium_raw_score_0_race_score_name_id` on table `team_stadium_raw_score`
--
ALTER TABLE team_stadium_raw_score
ADD INDEX team_stadium_raw_score_0_race_score_name_id (race_score_name_id);

--
-- Create table `team_stadium_rank`
--
CREATE TABLE team_stadium_rank (
  id int(11) NOT NULL,
  team_rank int(11) NOT NULL,
  team_rank_group int(11) NOT NULL,
  team_min_value int(11) NOT NULL,
  team_max_value int(11) NOT NULL,
  item_category int(11) NOT NULL,
  item_id int(11) NOT NULL,
  item_num int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 546,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `team_stadium_race_result_motion`
--
CREATE TABLE team_stadium_race_result_motion (
  character_id int(11) NOT NULL,
  win_1 int(11) NOT NULL,
  win_2 int(11) NOT NULL,
  win_2_position_y int(11) NOT NULL,
  win_3 int(11) NOT NULL,
  win_3_position_y int(11) NOT NULL,
  win_4 int(11) NOT NULL,
  win_4_position_y int(11) NOT NULL,
  win_5 int(11) NOT NULL,
  lose_1 int(11) NOT NULL,
  lose_2 int(11) NOT NULL,
  lose_3 int(11) NOT NULL,
  lose_4 int(11) NOT NULL,
  lose_5 int(11) NOT NULL,
  draw_1 int(11) NOT NULL,
  draw_2 int(11) NOT NULL,
  draw_3 int(11) NOT NULL,
  draw_4 int(11) NOT NULL,
  draw_5 int(11) NOT NULL,
  position_y int(11) NOT NULL
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 230,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `team_stadium_race_result_motion_0_character_id` on table `team_stadium_race_result_motion`
--
ALTER TABLE team_stadium_race_result_motion
ADD INDEX team_stadium_race_result_motion_0_character_id (character_id);

--
-- Create table `team_stadium_evaluation_rate`
--
CREATE TABLE team_stadium_evaluation_rate (
  id int(11) NOT NULL,
  proper_type int(11) NOT NULL,
  proper_rank int(11) NOT NULL,
  rate int(11) NOT NULL,
  PRIMARY KEY (proper_type, proper_rank)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 682,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `team_stadium_class_reward`
--
CREATE TABLE team_stadium_class_reward (
  id int(11) NOT NULL,
  team_stadium_id int(11) NOT NULL,
  team_class int(11) NOT NULL,
  class_reward_type int(11) NOT NULL,
  item_category_1 int(11) NOT NULL,
  item_id_1 int(11) NOT NULL,
  item_num_1 int(11) NOT NULL,
  item_category_2 int(11) NOT NULL,
  item_id_2 int(11) NOT NULL,
  item_num_2 int(11) NOT NULL,
  item_category_3 int(11) NOT NULL,
  item_id_3 int(11) NOT NULL,
  item_num_3 int(11) NOT NULL,
  item_category_4 int(11) NOT NULL,
  item_id_4 int(11) NOT NULL,
  item_num_4 int(11) NOT NULL,
  item_category_5 int(11) NOT NULL,
  item_id_5 int(11) NOT NULL,
  item_num_5 int(11) NOT NULL,
  disp_start_date int(11) NOT NULL,
  disp_end_date int(11) NOT NULL,
  start_date int(11) NOT NULL,
  end_date int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 963,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `team_stadium_class_reward_0_team_stadium_id_1_class_reward_type` on table `team_stadium_class_reward`
--
ALTER TABLE team_stadium_class_reward
ADD INDEX team_stadium_class_reward_0_team_stadium_id_1_class_reward_type (team_stadium_id, class_reward_type);

--
-- Create table `team_stadium_class`
--
CREATE TABLE team_stadium_class (
  id int(11) NOT NULL,
  team_stadium_id int(11) NOT NULL,
  team_class int(11) NOT NULL,
  unit_max_num int(11) NOT NULL,
  class_up_range int(11) NOT NULL,
  class_down_range int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 2730,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `team_stadium_class_0_team_stadium_id` on table `team_stadium_class`
--
ALTER TABLE team_stadium_class
ADD INDEX team_stadium_class_0_team_stadium_id (team_stadium_id);

--
-- Create table `team_stadium_bgm`
--
CREATE TABLE team_stadium_bgm (
  id int(11) NOT NULL,
  scene_type int(11) NOT NULL,
  priority int(11) NOT NULL,
  cue_name text NOT NULL,
  cuesheet_name text NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1489,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `team_stadium_bgm_0_scene_type` on table `team_stadium_bgm`
--
ALTER TABLE team_stadium_bgm
ADD INDEX team_stadium_bgm_0_scene_type (scene_type);

--
-- Create table `team_stadium`
--
CREATE TABLE team_stadium (
  id int(11) NOT NULL,
  race_start_date int(11) NOT NULL,
  race_start_time text NOT NULL,
  race_end_date int(11) NOT NULL,
  race_end_time text NOT NULL,
  interval_start_date int(11) NOT NULL,
  interval_start_time text NOT NULL,
  interval_end_date int(11) NOT NULL,
  interval_end_time text NOT NULL,
  calc_start_date int(11) NOT NULL,
  calc_start_time text NOT NULL,
  calc_end_date int(11) NOT NULL,
  calc_end_time text NOT NULL,
  start_date text NOT NULL,
  end_date text NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 16384,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `team_building_win_reward`
--
CREATE TABLE team_building_win_reward (
  id int(11) NOT NULL,
  win_loop_num int(11) NOT NULL,
  item_category int(11) NOT NULL,
  item_id int(11) NOT NULL,
  item_num int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 8192,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `team_building_team_race_set`
--
CREATE TABLE team_building_team_race_set (
  id int(11) NOT NULL,
  npc_group_id int(11) NOT NULL,
  motion_id int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 546,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `team_building_team_race_set_0_npc_group_id` on table `team_building_team_race_set`
--
ALTER TABLE team_building_team_race_set
ADD INDEX team_building_team_race_set_0_npc_group_id (npc_group_id);

--
-- Create table `team_building_sp_race_schedule`
--
CREATE TABLE team_building_sp_race_schedule (
  id int(11) NOT NULL,
  event_id int(11) NOT NULL,
  special_race_instance_id int(11) NOT NULL,
  race_condition_id int(11) NOT NULL,
  start_date int(11) NOT NULL,
  end_date int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 682,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `team_building_sp_race_schedule_0_event_id` on table `team_building_sp_race_schedule`
--
ALTER TABLE team_building_sp_race_schedule
ADD INDEX team_building_sp_race_schedule_0_event_id (event_id);

--
-- Create table `team_building_scout_point`
--
CREATE TABLE team_building_scout_point (
  id int(11) NOT NULL,
  chara_rank int(11) NOT NULL,
  scout_value int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 167,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `team_building_scout_point_0_chara_rank` on table `team_building_scout_point`
--
ALTER TABLE team_building_scout_point
ADD UNIQUE INDEX team_building_scout_point_0_chara_rank (chara_rank);

--
-- Create table `team_building_retry_bonus`
--
CREATE TABLE team_building_retry_bonus (
  id int(11) NOT NULL,
  retry_min int(11) NOT NULL,
  retry_max int(11) NOT NULL,
  bonus_rate int(11) NOT NULL,
  resimulate_num int(11) NOT NULL,
  down_rate int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 3276,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `team_building_rank_reward_group`
--
CREATE TABLE team_building_rank_reward_group (
  id int(11) NOT NULL,
  reward_group_id int(11) NOT NULL,
  item_category int(11) NOT NULL,
  item_id int(11) NOT NULL,
  item_num int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 399,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `team_building_rank_reward_group_0_reward_group_id` on table `team_building_rank_reward_group`
--
ALTER TABLE team_building_rank_reward_group
ADD INDEX team_building_rank_reward_group_0_reward_group_id (reward_group_id);

--
-- Create table `team_building_rank`
--
CREATE TABLE team_building_rank (
  id int(11) NOT NULL,
  team_rank int(11) NOT NULL,
  team_min_value int(11) NOT NULL,
  team_max_value int(11) NOT NULL,
  reward_group_id int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 546,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `team_building_rank_0_team_rank` on table `team_building_rank`
--
ALTER TABLE team_building_rank
ADD INDEX team_building_rank_0_team_rank (team_rank);

--
-- Create table `team_building_race_npc`
--
CREATE TABLE team_building_race_npc (
  id int(11) NOT NULL,
  npc_group_id int(11) NOT NULL,
  chara_id int(11) NOT NULL,
  mob_id int(11) NOT NULL,
  race_dress_id int(11) NOT NULL,
  speed int(11) NOT NULL,
  stamina int(11) NOT NULL,
  pow int(11) NOT NULL,
  guts int(11) NOT NULL,
  wiz int(11) NOT NULL,
  proper_distance_short int(11) NOT NULL,
  proper_distance_mile int(11) NOT NULL,
  proper_distance_middle int(11) NOT NULL,
  proper_distance_long int(11) NOT NULL,
  proper_running_style_nige int(11) NOT NULL,
  proper_running_style_senko int(11) NOT NULL,
  proper_running_style_sashi int(11) NOT NULL,
  proper_running_style_oikomi int(11) NOT NULL,
  proper_ground_turf int(11) NOT NULL,
  proper_ground_dirt int(11) NOT NULL,
  skill_set_id int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 165,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `team_building_discount_point`
--
CREATE TABLE team_building_discount_point (
  id int(11) NOT NULL,
  team_rank int(11) NOT NULL,
  discount_value int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 546,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `team_building_discount_point_0_team_rank` on table `team_building_discount_point`
--
ALTER TABLE team_building_discount_point
ADD UNIQUE INDEX team_building_discount_point_0_team_rank (team_rank);

--
-- Create table `team_building_data`
--
CREATE TABLE team_building_data (
  team_building_event_id int(11) NOT NULL,
  bg_id int(11) NOT NULL,
  bg_sub_id int(11) NOT NULL,
  stamina_default int(11) NOT NULL,
  stamina_max int(11) NOT NULL,
  stamina_add int(11) NOT NULL,
  stamina_add_time text NOT NULL,
  start_add_scout_point int(11) NOT NULL,
  notice_date int(11) NOT NULL,
  start_date int(11) NOT NULL,
  ending_date int(11) NOT NULL,
  end_date int(11) NOT NULL,
  special_race_count int(11) NOT NULL,
  required_race_count int(11) NOT NULL,
  middle_date int(11) NOT NULL,
  PRIMARY KEY (team_building_event_id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 2730,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `team_building_consecutive_wins`
--
CREATE TABLE team_building_consecutive_wins (
  id int(11) NOT NULL,
  consecutive_wins_num int(11) NOT NULL,
  bonus_value int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1638,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `team_building_collection_set`
--
CREATE TABLE team_building_collection_set (
  id int(11) NOT NULL,
  team_building_event_id int(11) NOT NULL,
  chara_group_id int(11) NOT NULL,
  skill_id int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 585,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `team_building_collection_set_0_team_building_event_id` on table `team_building_collection_set`
--
ALTER TABLE team_building_collection_set
ADD INDEX team_building_collection_set_0_team_building_event_id (team_building_event_id);

--
-- Create table `team_building_collection_chara`
--
CREATE TABLE team_building_collection_chara (
  id int(11) NOT NULL,
  team_building_event_id int(11) NOT NULL,
  chara_id int(11) NOT NULL,
  condition_type_1 int(11) NOT NULL,
  bonus_type_1 int(11) NOT NULL,
  bonus_value_1 int(11) NOT NULL,
  condition_type_2 int(11) NOT NULL,
  bonus_type_2 int(11) NOT NULL,
  bonus_value_2 int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 132,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `team_building_collection_chara_0_chara_id` on table `team_building_collection_chara`
--
ALTER TABLE team_building_collection_chara
ADD INDEX team_building_collection_chara_0_chara_id (chara_id);

--
-- Create index `team_building_collection_chara_0_team_building_event_id` on table `team_building_collection_chara`
--
ALTER TABLE team_building_collection_chara
ADD INDEX team_building_collection_chara_0_team_building_event_id (team_building_event_id);

--
-- Create table `team_building_chara_group`
--
CREATE TABLE team_building_chara_group (
  id int(11) NOT NULL,
  chara_group_id int(11) NOT NULL,
  chara_id int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 292,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `team_building_chara_group_0_chara_group_id` on table `team_building_chara_group`
--
ALTER TABLE team_building_chara_group
ADD INDEX team_building_chara_group_0_chara_group_id (chara_group_id);

--
-- Create table `team_building_chara_count`
--
CREATE TABLE team_building_chara_count (
  id int(11) NOT NULL,
  collection_chara_min int(11) NOT NULL,
  collection_chara_max int(11) NOT NULL,
  bonus_value int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1638,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `support_card_unique_effect`
--
CREATE TABLE support_card_unique_effect (
  id int(11) NOT NULL,
  lv int(11) NOT NULL,
  type_0 int(11) NOT NULL,
  value_0 int(11) NOT NULL,
  value_0_1 int(11) NOT NULL,
  value_0_2 int(11) NOT NULL,
  value_0_3 int(11) NOT NULL,
  value_0_4 int(11) NOT NULL,
  type_1 int(11) NOT NULL,
  value_1 int(11) NOT NULL,
  value_1_1 int(11) NOT NULL,
  value_1_2 int(11) NOT NULL,
  value_1_3 int(11) NOT NULL,
  value_1_4 int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 136,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `support_card_team_score_bonus`
--
CREATE TABLE support_card_team_score_bonus (
  id int(11) NOT NULL,
  level int(11) NOT NULL,
  score_rate int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 2340,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `support_card_team_score_bonus_0_level` on table `support_card_team_score_bonus`
--
ALTER TABLE support_card_team_score_bonus
ADD INDEX support_card_team_score_bonus_0_level (level);

--
-- Create table `support_card_limit_break`
--
CREATE TABLE support_card_limit_break (
  id int(11) NOT NULL,
  rarity int(11) NOT NULL,
  item_id int(11) NOT NULL,
  item_num int(11) NOT NULL,
  disp_order int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 8192,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `support_card_limit`
--
CREATE TABLE support_card_limit (
  rarity int(11) NOT NULL,
  limit_0 int(11) NOT NULL,
  limit_1 int(11) NOT NULL,
  limit_2 int(11) NOT NULL,
  limit_3 int(11) NOT NULL,
  limit_4 int(11) NOT NULL,
  PRIMARY KEY (rarity)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 5461,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `support_card_level`
--
CREATE TABLE support_card_level (
  id int(11) NOT NULL,
  rarity int(11) NOT NULL,
  level int(11) NOT NULL,
  total_exp int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 121,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `rarity` on table `support_card_level`
--
ALTER TABLE support_card_level
ADD UNIQUE INDEX rarity (rarity, level);

--
-- Create index `support_card_level_0_rarity` on table `support_card_level`
--
ALTER TABLE support_card_level
ADD INDEX support_card_level_0_rarity (rarity);

--
-- Create table `support_card_group`
--
CREATE TABLE support_card_group (
  id int(11) NOT NULL,
  support_card_id int(11) NOT NULL,
  chara_id int(11) NOT NULL,
  outing_max int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1092,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `support_card_group_0_chara_id` on table `support_card_group`
--
ALTER TABLE support_card_group
ADD INDEX support_card_group_0_chara_id (chara_id);

--
-- Create index `support_card_group_0_support_card_id` on table `support_card_group`
--
ALTER TABLE support_card_group
ADD INDEX support_card_group_0_support_card_id (support_card_id);

--
-- Create table `support_card_effect_table`
--
CREATE TABLE support_card_effect_table (
  id int(11) NOT NULL,
  type int(11) NOT NULL,
  init int(11) NOT NULL,
  limit_lv5 int(11) NOT NULL,
  limit_lv10 int(11) NOT NULL,
  limit_lv15 int(11) NOT NULL,
  limit_lv20 int(11) NOT NULL,
  limit_lv25 int(11) NOT NULL,
  limit_lv30 int(11) NOT NULL,
  limit_lv35 int(11) NOT NULL,
  limit_lv40 int(11) NOT NULL,
  limit_lv45 int(11) NOT NULL,
  limit_lv50 int(11) NOT NULL,
  PRIMARY KEY (id, type)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 91,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `support_card_effect_table_0_id` on table `support_card_effect_table`
--
ALTER TABLE support_card_effect_table
ADD INDEX support_card_effect_table_0_id (id);

--
-- Create table `support_card_effect_filter_group`
--
CREATE TABLE support_card_effect_filter_group (
  group_id int(11) NOT NULL,
  sort_id int(11) NOT NULL,
  start_date int(11) NOT NULL,
  PRIMARY KEY (group_id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 4096,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `support_card_effect_filter`
--
CREATE TABLE support_card_effect_filter (
  type int(11) NOT NULL,
  group_id int(11) NOT NULL,
  sort_id int(11) NOT NULL,
  start_date int(11) NOT NULL,
  PRIMARY KEY (type)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 630,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `support_card_effect_filter_0_group_id` on table `support_card_effect_filter`
--
ALTER TABLE support_card_effect_filter
ADD INDEX support_card_effect_filter_0_group_id (group_id);

--
-- Create table `support_card_data`
--
CREATE TABLE support_card_data (
  id int(11) NOT NULL,
  chara_id int(11) NOT NULL,
  rarity int(11) NOT NULL,
  exchange_item_id int(11) NOT NULL,
  effect_table_id int(11) NOT NULL,
  unique_effect_id int(11) NOT NULL,
  command_type int(11) NOT NULL,
  command_id int(11) NOT NULL,
  support_card_type int(11) NOT NULL,
  skill_set_id int(11) NOT NULL,
  detail_pos_x int(11) NOT NULL,
  detail_pos_y int(11) NOT NULL,
  detail_scale int(11) NOT NULL,
  detail_rot_z int(11) NOT NULL,
  start_date int(11) NOT NULL,
  outing_max int(11) NOT NULL,
  effect_id int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 249,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `support_card_data_0_chara_id` on table `support_card_data`
--
ALTER TABLE support_card_data
ADD INDEX support_card_data_0_chara_id (chara_id);

--
-- Create table `succession_rental`
--
CREATE TABLE succession_rental (
  id int(11) NOT NULL,
  rental_rank int(11) NOT NULL,
  rental_num int(11) NOT NULL,
  use_value1 int(11) NOT NULL,
  use_value2 int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 83,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `succession_rental_0_rental_rank_1_rental_num` on table `succession_rental`
--
ALTER TABLE succession_rental
ADD INDEX succession_rental_0_rental_rank_1_rental_num (rental_rank, rental_num);

--
-- Create table `succession_relation_rank`
--
CREATE TABLE succession_relation_rank (
  relation_rank int(11) NOT NULL,
  rank_value_min int(11) NOT NULL,
  rank_value_max int(11) NOT NULL,
  PRIMARY KEY (relation_rank)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 5461,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `succession_relation_member`
--
CREATE TABLE succession_relation_member (
  id int(11) NOT NULL,
  relation_type int(11) NOT NULL,
  chara_id int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 55,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `succession_relation_member_0_chara_id` on table `succession_relation_member`
--
ALTER TABLE succession_relation_member
ADD INDEX succession_relation_member_0_chara_id (chara_id);

--
-- Create table `succession_relation`
--
CREATE TABLE succession_relation (
  relation_type int(11) NOT NULL,
  relation_point int(11) NOT NULL,
  PRIMARY KEY (relation_type)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 69,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `succession_initial_factor`
--
CREATE TABLE succession_initial_factor (
  id int(11) NOT NULL,
  factor_type int(11) NOT NULL,
  value_1 int(11) NOT NULL,
  value_2 int(11) NOT NULL,
  add_point int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 2340,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `succession_initial_factor_0_factor_type` on table `succession_initial_factor`
--
ALTER TABLE succession_initial_factor
ADD INDEX succession_initial_factor_0_factor_type (factor_type);

--
-- Create index `succession_initial_factor_0_factor_type_1_value_1` on table `succession_initial_factor`
--
ALTER TABLE succession_initial_factor
ADD INDEX succession_initial_factor_0_factor_type_1_value_1 (factor_type, value_1);

--
-- Create table `succession_factor_effect`
--
CREATE TABLE succession_factor_effect (
  id int(11) NOT NULL,
  factor_group_id int(11) NOT NULL,
  effect_id int(11) NOT NULL,
  target_type int(11) NOT NULL,
  value_1 int(11) NOT NULL,
  value_2 int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 72,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `succession_factor_effect_0_factor_group_id` on table `succession_factor_effect`
--
ALTER TABLE succession_factor_effect
ADD INDEX succession_factor_effect_0_factor_group_id (factor_group_id);

--
-- Create index `succession_factor_effect_0_factor_group_id_1_effect_id` on table `succession_factor_effect`
--
ALTER TABLE succession_factor_effect
ADD INDEX succession_factor_effect_0_factor_group_id_1_effect_id (factor_group_id, effect_id);

--
-- Create table `succession_factor`
--
CREATE TABLE succession_factor (
  factor_id int(11) NOT NULL,
  factor_group_id int(11) NOT NULL,
  rarity int(11) NOT NULL,
  grade int(11) NOT NULL,
  factor_type int(11) NOT NULL,
  effect_group_id int(11) NOT NULL,
  start_date int(11) NOT NULL,
  end_date int(11) NOT NULL,
  succession_search_hidden int(11) NOT NULL,
  PRIMARY KEY (factor_id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 93,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `succession_factor_0_factor_group_id_1_rarity` on table `succession_factor`
--
ALTER TABLE succession_factor
ADD UNIQUE INDEX succession_factor_0_factor_group_id_1_rarity (factor_group_id, rarity);

--
-- Create table `subscription_effect`
--
CREATE TABLE subscription_effect (
  id int(11) NOT NULL,
  target_type int(11) NOT NULL,
  effect_type_1 int(11) NOT NULL,
  effect_value_1 int(11) NOT NULL,
  user_show int(11) NOT NULL,
  image_icon_id int(11) NOT NULL,
  transition_type int(11) NOT NULL,
  start_time int(11) NOT NULL,
  end_time int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `subscription_effect_0_target_type` on table `subscription_effect`
--
ALTER TABLE subscription_effect
ADD INDEX subscription_effect_0_target_type (target_type);

--
-- Create table `story_wipe_dictionary`
--
CREATE TABLE story_wipe_dictionary (
  id int(11) NOT NULL,
  motion_root text NOT NULL,
  wipe_id int(11) NOT NULL,
  sub_id int(11) NOT NULL,
  type int(11) NOT NULL,
  default_length int(11) NOT NULL,
  offset_length int(11) NOT NULL,
  vertical_extend_length int(11) NOT NULL,
  ignore_tap_length int(11) NOT NULL,
  se_name text NOT NULL,
  sheet_name text NOT NULL,
  use_mini int(11) NOT NULL,
  mini_motion_name text NOT NULL,
  mini_motion_start int(11) NOT NULL,
  mini_motion_end int(11) NOT NULL,
  emotion_label text NOT NULL,
  emotion_label_start text NOT NULL,
  emotion_label_end text NOT NULL,
  emotion_icon text NOT NULL,
  emotion_icon_start text NOT NULL,
  emotion_icon_end text NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 252,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `story_wipe_dictionary_0_wipe_id_1_sub_id` on table `story_wipe_dictionary`
--
ALTER TABLE story_wipe_dictionary
ADD INDEX story_wipe_dictionary_0_wipe_id_1_sub_id (wipe_id, sub_id);

--
-- Create index `wipe_id` on table `story_wipe_dictionary`
--
ALTER TABLE story_wipe_dictionary
ADD UNIQUE INDEX wipe_id USING HASH (wipe_id, sub_id, type, use_mini, mini_motion_name);

--
-- Create table `story_still`
--
CREATE TABLE story_still (
  id int(11) NOT NULL,
  still_id int(11) NOT NULL,
  page_id int(11) NOT NULL,
  order_id int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 244,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `story_still_0_still_id` on table `story_still`
--
ALTER TABLE story_still
ADD INDEX story_still_0_still_id (still_id);

--
-- Create table `story_live_position`
--
CREATE TABLE story_live_position (
  id int(11) NOT NULL,
  set_id int(11) NOT NULL,
  music_id int(11) NOT NULL,
  position_id int(11) NOT NULL,
  chara_type int(11) NOT NULL,
  chara_id int(11) NOT NULL,
  dress_id int(11) NOT NULL,
  dress_color int(11) NOT NULL,
  second_dress_id int(11) NOT NULL,
  second_dress_color int(11) NOT NULL,
  vocal_chara_id int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 172,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `story_live_position_0_music_id` on table `story_live_position`
--
ALTER TABLE story_live_position
ADD INDEX story_live_position_0_music_id (music_id);

--
-- Create index `story_live_position_0_set_id` on table `story_live_position`
--
ALTER TABLE story_live_position
ADD INDEX story_live_position_0_set_id (set_id);

--
-- Create table `story_hip_offset`
--
CREATE TABLE story_hip_offset (
  category_id int(11) NOT NULL,
  chara_id int(11) NOT NULL,
  offset int(11) NOT NULL,
  PRIMARY KEY (category_id, chara_id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 496,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `story_extra_story_data`
--
CREATE TABLE story_extra_story_data (
  id int(11) NOT NULL,
  story_extra_id int(11) NOT NULL,
  episode_index_id int(11) NOT NULL,
  story_type_1 int(11) NOT NULL,
  story_id_1 int(11) NOT NULL,
  story_type_2 int(11) NOT NULL,
  story_id_2 int(11) NOT NULL,
  story_type_3 int(11) NOT NULL,
  story_id_3 int(11) NOT NULL,
  story_type_4 int(11) NOT NULL,
  story_id_4 int(11) NOT NULL,
  story_type_5 int(11) NOT NULL,
  story_id_5 int(11) NOT NULL,
  add_reward_category_1 int(11) NOT NULL,
  add_reward_id_1 int(11) NOT NULL,
  add_reward_num_1 int(11) NOT NULL,
  add_reward_category_2 int(11) NOT NULL,
  add_reward_id_2 int(11) NOT NULL,
  add_reward_num_2 int(11) NOT NULL,
  start_date int(11) NOT NULL,
  notice_end_date int(11) NOT NULL,
  end_date int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1260,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `story_extra_story_data_0_story_extra_id` on table `story_extra_story_data`
--
ALTER TABLE story_extra_story_data
ADD INDEX story_extra_story_data_0_story_extra_id (story_extra_id);

--
-- Create table `story_extra_movie_data`
--
CREATE TABLE story_extra_movie_data (
  id int(11) NOT NULL,
  movie_path text NOT NULL,
  sort int(11) NOT NULL,
  start_date int(11) NOT NULL,
  end_date int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 8192,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `story_extra_data`
--
CREATE TABLE story_extra_data (
  story_extra_id int(11) NOT NULL,
  start_date int(11) NOT NULL,
  end_date int(11) NOT NULL,
  PRIMARY KEY (story_extra_id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 8192,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `story_event_top_chara`
--
CREATE TABLE story_event_top_chara (
  id int(11) NOT NULL,
  story_event_id int(11) NOT NULL,
  min_episode_index int(11) NOT NULL,
  max_episode_index int(11) NOT NULL,
  ending_flag int(11) NOT NULL,
  character_id int(11) NOT NULL,
  dress_id int(11) NOT NULL,
  menu_bg_id int(11) NOT NULL,
  menu_bg_sub_id int(11) NOT NULL,
  bgm_cue_name text NOT NULL,
  bgm_cuesheet_name text NOT NULL,
  env_cue_name text NOT NULL,
  env_cuesheet_name text NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 396,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `story_event_top_chara_0_story_event_id` on table `story_event_top_chara`
--
ALTER TABLE story_event_top_chara
ADD INDEX story_event_top_chara_0_story_event_id (story_event_id);

--
-- Create table `story_event_story_data`
--
CREATE TABLE story_event_story_data (
  id int(11) NOT NULL,
  story_event_id int(11) NOT NULL,
  episode_index_id int(11) NOT NULL,
  story_condition_type int(11) NOT NULL,
  story_type_1 int(11) NOT NULL,
  story_id_1 int(11) NOT NULL,
  story_type_2 int(11) NOT NULL,
  story_id_2 int(11) NOT NULL,
  story_type_3 int(11) NOT NULL,
  story_id_3 int(11) NOT NULL,
  story_type_4 int(11) NOT NULL,
  story_id_4 int(11) NOT NULL,
  story_type_5 int(11) NOT NULL,
  story_id_5 int(11) NOT NULL,
  need_point int(11) NOT NULL,
  add_reward_category_1 int(11) NOT NULL,
  add_reward_id_1 int(11) NOT NULL,
  add_reward_num_1 int(11) NOT NULL,
  add_reward_category_2 int(11) NOT NULL,
  add_reward_id_2 int(11) NOT NULL,
  add_reward_num_2 int(11) NOT NULL,
  start_date int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 182,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `story_event_story_data_0_story_event_id` on table `story_event_story_data`
--
ALTER TABLE story_event_story_data
ADD INDEX story_event_story_data_0_story_event_id (story_event_id);

--
-- Create index `story_event_story_data_0_story_event_id_1_episode_index_id` on table `story_event_story_data`
--
ALTER TABLE story_event_story_data
ADD UNIQUE INDEX story_event_story_data_0_story_event_id_1_episode_index_id (story_event_id, episode_index_id);

--
-- Create table `story_event_roulette_bingo`
--
CREATE TABLE story_event_roulette_bingo (
  id int(11) NOT NULL,
  roulette_id int(11) NOT NULL,
  story_event_id int(11) NOT NULL,
  sheet_num int(11) NOT NULL,
  can_loop int(11) NOT NULL,
  use_item_category int(11) NOT NULL,
  use_item_id int(11) NOT NULL,
  use_item_num int(11) NOT NULL,
  character_id int(11) NOT NULL,
  dress_id int(11) NOT NULL,
  reset_line int(11) NOT NULL,
  reward_set_id int(11) NOT NULL,
  roulette_max_num int(11) NOT NULL,
  start_date int(11) NOT NULL,
  end_date int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 372,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `roulette_id` on table `story_event_roulette_bingo`
--
ALTER TABLE story_event_roulette_bingo
ADD UNIQUE INDEX roulette_id (roulette_id, story_event_id, sheet_num);

--
-- Create index `story_event_roulette_bingo_0_story_event_id` on table `story_event_roulette_bingo`
--
ALTER TABLE story_event_roulette_bingo
ADD INDEX story_event_roulette_bingo_0_story_event_id (story_event_id);

--
-- Create table `story_event_point_reward`
--
CREATE TABLE story_event_point_reward (
  id int(11) NOT NULL,
  story_event_id int(11) NOT NULL,
  item_category int(11) NOT NULL,
  item_id int(11) NOT NULL,
  item_num int(11) NOT NULL,
  point int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 76,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `story_event_point_reward_0_story_event_id` on table `story_event_point_reward`
--
ALTER TABLE story_event_point_reward
ADD INDEX story_event_point_reward_0_story_event_id (story_event_id);

--
-- Create table `story_event_nickname_bonus`
--
CREATE TABLE story_event_nickname_bonus (
  id int(11) NOT NULL,
  story_event_id int(11) NOT NULL,
  nickname_rank int(11) NOT NULL,
  bonus_point int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 496,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `story_event_id` on table `story_event_nickname_bonus`
--
ALTER TABLE story_event_nickname_bonus
ADD UNIQUE INDEX story_event_id (story_event_id, nickname_rank);

--
-- Create index `story_event_nickname_bonus_0_story_event_id` on table `story_event_nickname_bonus`
--
ALTER TABLE story_event_nickname_bonus
ADD INDEX story_event_nickname_bonus_0_story_event_id (story_event_id);

--
-- Create table `story_event_mission_top_chara`
--
CREATE TABLE story_event_mission_top_chara (
  id int(11) NOT NULL,
  story_event_id int(11) NOT NULL,
  ending_flag int(11) NOT NULL,
  character_id int(11) NOT NULL,
  dress_id int(11) NOT NULL,
  menu_bg_id int(11) NOT NULL,
  menu_bg_sub_id int(11) NOT NULL,
  bgm_cue_name text NOT NULL,
  bgm_cuesheet_name text NOT NULL,
  env_cue_name text NOT NULL,
  env_cuesheet_name text NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 744,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `story_event_mission_top_chara_0_story_event_id` on table `story_event_mission_top_chara`
--
ALTER TABLE story_event_mission_top_chara
ADD INDEX story_event_mission_top_chara_0_story_event_id (story_event_id);

--
-- Create table `story_event_mission`
--
CREATE TABLE story_event_mission (
  id int(11) NOT NULL,
  story_event_id int(11) NOT NULL,
  mission_type int(11) NOT NULL,
  condition_type int(11) NOT NULL,
  condition_value_1 int(11) NOT NULL,
  condition_value_2 int(11) NOT NULL,
  condition_value_3 int(11) NOT NULL,
  condition_value_4 int(11) NOT NULL,
  condition_num int(11) NOT NULL,
  step_group_id int(11) NOT NULL,
  step_order int(11) NOT NULL,
  disp_order int(11) NOT NULL,
  item_category int(11) NOT NULL,
  item_id int(11) NOT NULL,
  item_num int(11) NOT NULL,
  transition_type int(11) NOT NULL,
  date_check_flg int(11) NOT NULL,
  start_date int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 169,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `story_event_mission_0_story_event_id` on table `story_event_mission`
--
ALTER TABLE story_event_mission
ADD INDEX story_event_mission_0_story_event_id (story_event_id);

--
-- Create table `story_event_data`
--
CREATE TABLE story_event_data (
  story_event_id int(11) NOT NULL,
  announce_id int(11) NOT NULL,
  consume_tp_ratio int(11) NOT NULL,
  bonus_reward_ratio int(11) NOT NULL,
  notice_date int(11) NOT NULL,
  start_date int(11) NOT NULL,
  middle_date_01 int(11) NOT NULL,
  middle_date_02 int(11) NOT NULL,
  ending_date int(11) NOT NULL,
  end_date int(11) NOT NULL,
  PRIMARY KEY (story_event_id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1489,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `story_event_bonus_support_card`
--
CREATE TABLE story_event_bonus_support_card (
  id int(11) NOT NULL,
  story_event_id int(11) NOT NULL,
  chara_id int(11) NOT NULL,
  rarity int(11) NOT NULL,
  support_card_id int(11) NOT NULL,
  limit_0 int(11) NOT NULL,
  limit_1 int(11) NOT NULL,
  limit_2 int(11) NOT NULL,
  limit_3 int(11) NOT NULL,
  limit_4 int(11) NOT NULL,
  start_date int(11) NOT NULL,
  end_date int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 96,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `story_event_bonus_support_card_0_story_event_id` on table `story_event_bonus_support_card`
--
ALTER TABLE story_event_bonus_support_card
ADD INDEX story_event_bonus_support_card_0_story_event_id (story_event_id);

--
-- Create index `story_event_id` on table `story_event_bonus_support_card`
--
ALTER TABLE story_event_bonus_support_card
ADD UNIQUE INDEX story_event_id (story_event_id, chara_id, rarity, support_card_id);

--
-- Create table `story_event_bonus_group_support_card`
--
CREATE TABLE story_event_bonus_group_support_card (
  id int(11) NOT NULL,
  story_event_id int(11) NOT NULL,
  chara_id int(11) NOT NULL,
  support_card_id int(11) NOT NULL,
  limit_0 int(11) NOT NULL,
  limit_1 int(11) NOT NULL,
  limit_2 int(11) NOT NULL,
  limit_3 int(11) NOT NULL,
  limit_4 int(11) NOT NULL,
  start_date int(11) NOT NULL,
  end_date int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 910,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `story_event_bonus_group_support_card_0_story_event_id` on table `story_event_bonus_group_support_card`
--
ALTER TABLE story_event_bonus_group_support_card
ADD INDEX story_event_bonus_group_support_card_0_story_event_id (story_event_id);

--
-- Create index `story_event_bonus_group_support_card_0_support_card_id` on table `story_event_bonus_group_support_card`
--
ALTER TABLE story_event_bonus_group_support_card
ADD INDEX story_event_bonus_group_support_card_0_support_card_id (support_card_id);

--
-- Create index `story_event_id` on table `story_event_bonus_group_support_card`
--
ALTER TABLE story_event_bonus_group_support_card
ADD UNIQUE INDEX story_event_id (story_event_id, chara_id, support_card_id);

--
-- Create table `story_event_bonus_card`
--
CREATE TABLE story_event_bonus_card (
  id int(11) NOT NULL,
  story_event_id int(11) NOT NULL,
  chara_id int(11) NOT NULL,
  card_id int(11) NOT NULL,
  rarity_1 int(11) NOT NULL,
  rarity_2 int(11) NOT NULL,
  rarity_3 int(11) NOT NULL,
  rarity_4 int(11) NOT NULL,
  rarity_5 int(11) NOT NULL,
  start_date int(11) NOT NULL,
  end_date int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 237,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `story_event_bonus_card_0_story_event_id` on table `story_event_bonus_card`
--
ALTER TABLE story_event_bonus_card
ADD INDEX story_event_bonus_card_0_story_event_id (story_event_id);

--
-- Create index `story_event_id` on table `story_event_bonus_card`
--
ALTER TABLE story_event_bonus_card
ADD UNIQUE INDEX story_event_id (story_event_id, chara_id, card_id);

--
-- Create table `story_event_bingo_reward`
--
CREATE TABLE story_event_bingo_reward (
  id int(11) NOT NULL,
  reward_set_id int(11) NOT NULL,
  line_num int(11) NOT NULL,
  item_category int(11) NOT NULL,
  item_id int(11) NOT NULL,
  item_num int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 89,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `story_event_bingo_reward_0_reward_set_id` on table `story_event_bingo_reward`
--
ALTER TABLE story_event_bingo_reward
ADD INDEX story_event_bingo_reward_0_reward_set_id (reward_set_id);

--
-- Create table `skill_up_scenario_condition`
--
CREATE TABLE skill_up_scenario_condition (
  id INT(11) NOT NULL,
  scenario_id INT(11) NOT NULL,
  rank INT(11) NOT NULL,
  condition_id INT(11) NOT NULL,
  num INT(11) NOT NULL,
  sub_num INT(11) NOT NULL,
  timing_type INT(11) NOT NULL,
  count_type INT(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 4096,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `skill_up_scenario_condition_0_scenario_id` on table `skill_up_scenario_condition`
--
ALTER TABLE skill_up_scenario_condition
ADD INDEX skill_up_scenario_condition_0_scenario_id (scenario_id);

--
-- Create table `skill_upgrade_speciality`
--
CREATE TABLE skill_upgrade_speciality (
  id int(11) NOT NULL,
  scenario_id int(11) NOT NULL,
  base_skill_id int(11) NOT NULL,
  skill_id int(11) NOT NULL,
  start_date int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 862,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `scenario_id` on table `skill_upgrade_speciality`
--
ALTER TABLE skill_upgrade_speciality
ADD UNIQUE INDEX scenario_id (scenario_id, skill_id);

--
-- Create index `skill_upgrade_speciality_0_base_skill_id` on table `skill_upgrade_speciality`
--
ALTER TABLE skill_upgrade_speciality
ADD INDEX skill_upgrade_speciality_0_base_skill_id (base_skill_id);

--
-- Create index `skill_upgrade_speciality_0_scenario_id` on table `skill_upgrade_speciality`
--
ALTER TABLE skill_upgrade_speciality
ADD INDEX skill_upgrade_speciality_0_scenario_id (scenario_id);

--
-- Create table `skill_upgrade_description`
--
CREATE TABLE skill_upgrade_description (
  id INT(11) NOT NULL,
  card_id INT(11) NOT NULL,
  rank INT(11) NOT NULL,
  skill_id INT(11) NOT NULL,
  start_date INT(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 114,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `card_id` on table `skill_upgrade_description`
--
ALTER TABLE skill_upgrade_description
ADD UNIQUE INDEX card_id (card_id, skill_id);

--
-- Create index `skill_upgrade_description_0_card_id` on table `skill_upgrade_description`
--
ALTER TABLE skill_upgrade_description
ADD INDEX skill_upgrade_description_0_card_id (card_id);

--
-- Create index `skill_upgrade_description_0_card_id_1_rank` on table `skill_upgrade_description`
--
ALTER TABLE skill_upgrade_description
ADD INDEX skill_upgrade_description_0_card_id_1_rank (card_id, `rank`);

--
-- Create table `skill_upgrade_condition`
--
CREATE TABLE skill_upgrade_condition (
  id int(11) NOT NULL,
  description_id int(11) NOT NULL,
  num int(11) NOT NULL,
  sub_num int(11) NOT NULL,
  timing_type int(11) NOT NULL,
  count_type int(11) NOT NULL,
  upgrade_type int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 77,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `description_id` on table `skill_upgrade_condition`
--
ALTER TABLE skill_upgrade_condition
ADD UNIQUE INDEX description_id (description_id, num, sub_num);

--
-- Create index `skill_upgrade_condition_0_description_id` on table `skill_upgrade_condition`
--
ALTER TABLE skill_upgrade_condition
ADD INDEX skill_upgrade_condition_0_description_id (description_id);

--
-- Create table `skill_set`
--
CREATE TABLE skill_set (
  id int(11) NOT NULL,
  skill_id1 int(11) NOT NULL,
  skill_level1 int(11) NOT NULL,
  skill_id2 int(11) NOT NULL,
  skill_level2 int(11) NOT NULL,
  skill_id3 int(11) NOT NULL,
  skill_level3 int(11) NOT NULL,
  skill_id4 int(11) NOT NULL,
  skill_level4 int(11) NOT NULL,
  skill_id5 int(11) NOT NULL,
  skill_level5 int(11) NOT NULL,
  skill_id6 int(11) NOT NULL,
  skill_level6 int(11) NOT NULL,
  skill_id7 int(11) NOT NULL,
  skill_level7 int(11) NOT NULL,
  skill_id8 int(11) NOT NULL,
  skill_level8 int(11) NOT NULL,
  skill_id9 int(11) NOT NULL,
  skill_level9 int(11) NOT NULL,
  skill_id10 int(11) NOT NULL,
  skill_level10 int(11) NOT NULL,
  skill_id11 int(11) NOT NULL,
  skill_level11 int(11) NOT NULL,
  skill_id12 int(11) NOT NULL,
  skill_level12 int(11) NOT NULL,
  skill_id13 int(11) NOT NULL,
  skill_level13 int(11) NOT NULL,
  skill_id14 int(11) NOT NULL,
  skill_level14 int(11) NOT NULL,
  skill_id15 int(11) NOT NULL,
  skill_level15 int(11) NOT NULL,
  skill_id16 int(11) NOT NULL,
  skill_level16 int(11) NOT NULL,
  skill_id17 int(11) NOT NULL,
  skill_level17 int(11) NOT NULL,
  skill_id18 int(11) NOT NULL,
  skill_level18 int(11) NOT NULL,
  skill_id19 int(11) NOT NULL,
  skill_level19 int(11) NOT NULL,
  skill_id20 int(11) NOT NULL,
  skill_level20 int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 142,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `skill_level_value`
--
CREATE TABLE skill_level_value (
  id int(11) NOT NULL,
  ability_type int(11) NOT NULL,
  level int(11) NOT NULL,
  float_ability_value_coef int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 72,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `skill_level_value_0_ability_type` on table `skill_level_value`
--
ALTER TABLE skill_level_value
ADD INDEX skill_level_value_0_ability_type (ability_type);

--
-- Create table `skill_exp`
--
CREATE TABLE skill_exp (
  id int(11) NOT NULL,
  type int(11) NOT NULL,
  level int(11) NOT NULL,
  scale int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1638,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `skill_exp_0_type` on table `skill_exp`
--
ALTER TABLE skill_exp
ADD INDEX skill_exp_0_type (type);

--
-- Create table `skill_data`
--
CREATE TABLE skill_data (
  id int(11) NOT NULL,
  rarity int(11) NOT NULL,
  group_id int(11) NOT NULL,
  group_rate int(11) NOT NULL,
  filter_switch int(11) NOT NULL,
  grade_value int(11) NOT NULL,
  skill_category int(11) NOT NULL,
  tag_id text NOT NULL,
  unique_skill_id_1 int(11) NOT NULL,
  unique_skill_id_2 int(11) NOT NULL,
  exp_type int(11) NOT NULL,
  potential_per_default int(11) NOT NULL,
  activate_lot int(11) NOT NULL,
  precondition_1 text NOT NULL,
  condition_1 text NOT NULL,
  float_ability_time_1 int(11) NOT NULL,
  ability_time_usage_1 int(11) NOT NULL,
  float_cooldown_time_1 int(11) NOT NULL,
  ability_type_1_1 int(11) NOT NULL,
  ability_value_usage_1_1 int(11) NOT NULL,
  ability_value_level_usage_1_1 int(11) NOT NULL,
  float_ability_value_1_1 int(11) NOT NULL,
  target_type_1_1 int(11) NOT NULL,
  target_value_1_1 int(11) NOT NULL,
  ability_type_1_2 int(11) NOT NULL,
  ability_value_usage_1_2 int(11) NOT NULL,
  ability_value_level_usage_1_2 int(11) NOT NULL,
  float_ability_value_1_2 int(11) NOT NULL,
  target_type_1_2 int(11) NOT NULL,
  target_value_1_2 int(11) NOT NULL,
  ability_type_1_3 int(11) NOT NULL,
  ability_value_usage_1_3 int(11) NOT NULL,
  ability_value_level_usage_1_3 int(11) NOT NULL,
  float_ability_value_1_3 int(11) NOT NULL,
  target_type_1_3 int(11) NOT NULL,
  target_value_1_3 int(11) NOT NULL,
  precondition_2 text NOT NULL,
  condition_2 text NOT NULL,
  float_ability_time_2 int(11) NOT NULL,
  ability_time_usage_2 int(11) NOT NULL,
  float_cooldown_time_2 int(11) NOT NULL,
  ability_type_2_1 int(11) NOT NULL,
  ability_value_usage_2_1 int(11) NOT NULL,
  ability_value_level_usage_2_1 int(11) NOT NULL,
  float_ability_value_2_1 int(11) NOT NULL,
  target_type_2_1 int(11) NOT NULL,
  target_value_2_1 int(11) NOT NULL,
  ability_type_2_2 int(11) NOT NULL,
  ability_value_usage_2_2 int(11) NOT NULL,
  ability_value_level_usage_2_2 int(11) NOT NULL,
  float_ability_value_2_2 int(11) NOT NULL,
  target_type_2_2 int(11) NOT NULL,
  target_value_2_2 int(11) NOT NULL,
  ability_type_2_3 int(11) NOT NULL,
  ability_value_usage_2_3 int(11) NOT NULL,
  ability_value_level_usage_2_3 int(11) NOT NULL,
  float_ability_value_2_3 int(11) NOT NULL,
  target_type_2_3 int(11) NOT NULL,
  target_value_2_3 int(11) NOT NULL,
  popularity_add_param_1 int(11) NOT NULL,
  popularity_add_value_1 int(11) NOT NULL,
  popularity_add_param_2 int(11) NOT NULL,
  popularity_add_value_2 int(11) NOT NULL,
  disp_order int(11) NOT NULL,
  icon_id int(11) NOT NULL,
  plate_type int(11) NOT NULL,
  disable_singlemode int(11) NOT NULL,
  start_date int(11) NOT NULL,
  end_date int(11) NOT NULL,
  disable_count_condition int(11) NOT NULL,
  is_general_skill int(11) NOT NULL,
  additional_activate_type_1_1 int(11) NOT NULL,
  additional_activate_type_1_2 int(11) NOT NULL,
  additional_activate_type_1_3 int(11) NOT NULL,
  additional_activate_type_2_1 int(11) NOT NULL,
  additional_activate_type_2_2 int(11) NOT NULL,
  additional_activate_type_2_3 int(11) NOT NULL,
  priority int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 431,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `skill_data_0_group_id` on table `skill_data`
--
ALTER TABLE skill_data
ADD INDEX skill_data_0_group_id (group_id);

--
-- Create table `single_mode_wins_saddle`
--
CREATE TABLE single_mode_wins_saddle (
  id int(11) NOT NULL,
  priority int(11) NOT NULL,
  group_id int(11) NOT NULL,
  `condition` int(11) NOT NULL,
  win_saddle_type int(11) NOT NULL,
  race_instance_id_1 int(11) NOT NULL,
  race_instance_id_2 int(11) NOT NULL,
  race_instance_id_3 int(11) NOT NULL,
  race_instance_id_4 int(11) NOT NULL,
  race_instance_id_5 int(11) NOT NULL,
  race_instance_id_6 int(11) NOT NULL,
  race_instance_id_7 int(11) NOT NULL,
  race_instance_id_8 int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 105,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `single_mode_venus_sprace_data`
--
CREATE TABLE single_mode_venus_sprace_data (
  id int(11) NOT NULL,
  race_group_id int(11) NOT NULL,
  turn_num int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 5461,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `single_mode_venus_sprace_data_0_race_group_id` on table `single_mode_venus_sprace_data`
--
ALTER TABLE single_mode_venus_sprace_data
ADD INDEX single_mode_venus_sprace_data_0_race_group_id (race_group_id);

--
-- Create table `single_mode_venus_spirit_group`
--
CREATE TABLE single_mode_venus_spirit_group (
  spirit_id int(11) NOT NULL,
  chara_id int(11) NOT NULL,
  bonus_group int(11) NOT NULL,
  spirit_effect_group_id_1 int(11) NOT NULL,
  spirit_effect_group_id_2 int(11) NOT NULL,
  spirit_effect_group_id_3 int(11) NOT NULL,
  spirit_effect_group_id_4 int(11) NOT NULL,
  spirit_effect_group_id_5 int(11) NOT NULL,
  PRIMARY KEY (spirit_id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 910,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `single_mode_venus_spirit_effect`
--
CREATE TABLE single_mode_venus_spirit_effect (
  id int(11) NOT NULL,
  spirit_effect_group_id int(11) NOT NULL,
  effect_type int(11) NOT NULL,
  effect_value_1 int(11) NOT NULL,
  effect_value_2 int(11) NOT NULL,
  effect_value_3 int(11) NOT NULL,
  effect_value_4 int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 197,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `single_mode_venus_spirit_effect_0_spirit_effect_group_id` on table `single_mode_venus_spirit_effect`
--
ALTER TABLE single_mode_venus_spirit_effect
ADD INDEX single_mode_venus_spirit_effect_0_spirit_effect_group_id (spirit_effect_group_id);

--
-- Create table `single_mode_venus_crystal_group`
--
CREATE TABLE single_mode_venus_crystal_group (
  id int(11) NOT NULL,
  chara_id int(11) NOT NULL,
  venus_level int(11) NOT NULL,
  passive_effect_group_id int(11) NOT NULL,
  active_effect_group_id int(11) NOT NULL,
  active_effect_turn int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1092,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `single_mode_venus_crystal_group_0_chara_id` on table `single_mode_venus_crystal_group`
--
ALTER TABLE single_mode_venus_crystal_group
ADD INDEX single_mode_venus_crystal_group_0_chara_id (chara_id);

--
-- Create table `single_mode_unique_chara`
--
CREATE TABLE single_mode_unique_chara (
  id int(11) NOT NULL,
  partner_id int(11) NOT NULL,
  scenario_id int(11) NOT NULL,
  chara_id int(11) NOT NULL,
  period int(11) NOT NULL,
  training_placement int(11) NOT NULL,
  gain_flag_id int(11) NOT NULL,
  is_support_featured_stock int(11) NOT NULL,
  gain_role_id int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1170,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `single_mode_unique_chara_0_partner_id_1_scenario_id` on table `single_mode_unique_chara`
--
ALTER TABLE single_mode_unique_chara
ADD INDEX single_mode_unique_chara_0_partner_id_1_scenario_id (partner_id, scenario_id);

--
-- Create table `single_mode_turn`
--
CREATE TABLE single_mode_turn (
  id int(11) NOT NULL,
  turn_set_id int(11) NOT NULL,
  turn int(11) NOT NULL,
  year int(11) NOT NULL,
  month int(11) NOT NULL,
  half int(11) NOT NULL,
  period int(11) NOT NULL,
  unique_command int(11) NOT NULL,
  training_set_id int(11) NOT NULL,
  outing_set_id int(11) NOT NULL,
  top_cloth_id int(11) NOT NULL,
  top_bg_id int(11) NOT NULL,
  bgm_cue_name text NOT NULL,
  bgm_cuesheet_name text NOT NULL,
  env_cue_name text NOT NULL,
  env_cuesheet_name text NOT NULL,
  rest_type int(11) NOT NULL,
  health_room_type int(11) NOT NULL,
  race_entry_type int(11) NOT NULL,
  story_cloth_id int(11) NOT NULL,
  story_bg_id int(11) NOT NULL,
  story_bg_sub_id int(11) NOT NULL,
  bgm_unique_cue_name text NOT NULL,
  bgm_unique_cuesheet_name text NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 350,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `single_mode_turn_0_turn_set_id` on table `single_mode_turn`
--
ALTER TABLE single_mode_turn
ADD INDEX single_mode_turn_0_turn_set_id (turn_set_id);

--
-- Create table `single_mode_training_se`
--
CREATE TABLE single_mode_training_se (
  id int(11) NOT NULL,
  sheet_id varchar(750) NOT NULL,
  se_cue_name text NOT NULL,
  se_cuesheet_name text NOT NULL,
  skip_se_cue_name text NOT NULL,
  skip_se_cuesheet_name text NOT NULL,
  chara_index int(11) NOT NULL,
  voice_trigger_id int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 327,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `single_mode_training_se_0_sheet_id` on table `single_mode_training_se`
--
ALTER TABLE single_mode_training_se
ADD INDEX single_mode_training_se_0_sheet_id (sheet_id);

--
-- Create table `single_mode_training_plate`
--
CREATE TABLE single_mode_training_plate (
  id int(11) NOT NULL,
  scenario_id int(11) NOT NULL,
  value_min int(11) NOT NULL,
  value_max int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 5461,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `single_mode_training_plate_0_scenario_id` on table `single_mode_training_plate`
--
ALTER TABLE single_mode_training_plate
ADD INDEX single_mode_training_plate_0_scenario_id (scenario_id);

--
-- Create table `single_mode_training_effect`
--
CREATE TABLE single_mode_training_effect (
  id int(11) NOT NULL,
  command_id int(11) NOT NULL,
  sub_id int(11) NOT NULL,
  result_state int(11) NOT NULL,
  target_type int(11) NOT NULL,
  effect_value int(11) NOT NULL,
  scenario_id int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 97,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `single_mode_training_effect_0_command_id_1_result_state` on table `single_mode_training_effect`
--
ALTER TABLE single_mode_training_effect
ADD INDEX single_mode_training_effect_0_command_id_1_result_state (command_id, result_state);

--
-- Create table `single_mode_training_bg_chara`
--
CREATE TABLE single_mode_training_bg_chara (
  id int(11) NOT NULL,
  scenario_id int(11) NOT NULL,
  command_id int(11) NOT NULL,
  command_level int(11) NOT NULL,
  cut_id int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 546,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `single_mode_training_bg_chara_0_command_id_1_command_level` on table `single_mode_training_bg_chara`
--
ALTER TABLE single_mode_training_bg_chara
ADD INDEX single_mode_training_bg_chara_0_command_id_1_command_level (command_id, command_level);

--
-- Create index `single_mode_training_bg_chara_0_scenario_id` on table `single_mode_training_bg_chara`
--
ALTER TABLE single_mode_training_bg_chara
ADD INDEX single_mode_training_bg_chara_0_scenario_id (scenario_id);

--
-- Create table `single_mode_training`
--
CREATE TABLE single_mode_training (
  id int(11) NOT NULL,
  command_id int(11) NOT NULL,
  base_command_id int(11) NOT NULL,
  command_level int(11) NOT NULL,
  command_type int(11) NOT NULL,
  cutin_file_id int(11) NOT NULL,
  max_chara_num int(11) NOT NULL,
  failure_rate int(11) NOT NULL,
  menu_bg_id int(11) NOT NULL,
  menu_bg_sub_id int(11) NOT NULL,
  env_cue_name text NOT NULL,
  env_cuesheet_name text NOT NULL,
  motion_set int(11) NOT NULL,
  sabori_type int(11) NOT NULL,
  dress_type int(11) NOT NULL,
  dress_id int(11) NOT NULL,
  group_id int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 455,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `single_mode_training_0_command_id` on table `single_mode_training`
--
ALTER TABLE single_mode_training
ADD INDEX single_mode_training_0_command_id (command_id);

--
-- Create index `single_mode_training_0_command_id_1_command_level` on table `single_mode_training`
--
ALTER TABLE single_mode_training
ADD UNIQUE INDEX single_mode_training_0_command_id_1_command_level (command_id, command_level);

--
-- Create index `single_mode_training_0_command_type` on table `single_mode_training`
--
ALTER TABLE single_mode_training
ADD INDEX single_mode_training_0_command_type (command_type);

--
-- Create index `single_mode_training_0_cutin_file_id` on table `single_mode_training`
--
ALTER TABLE single_mode_training
ADD INDEX single_mode_training_0_cutin_file_id (cutin_file_id);

--
-- Create table `single_mode_top_bg_chara`
--
CREATE TABLE single_mode_top_bg_chara (
  id int(11) NOT NULL,
  scenario_id int(11) NOT NULL,
  bg_id int(11) NOT NULL,
  group_id int(11) NOT NULL,
  pos_x int(11) NOT NULL,
  pos_z int(11) NOT NULL,
  rotation_y int(11) NOT NULL,
  motion_set_id int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1365,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `single_mode_top_bg_chara_0_bg_id_1_scenario_id` on table `single_mode_top_bg_chara`
--
ALTER TABLE single_mode_top_bg_chara
ADD INDEX single_mode_top_bg_chara_0_bg_id_1_scenario_id (bg_id, scenario_id);

--
-- Create table `single_mode_top_bg`
--
CREATE TABLE single_mode_top_bg (
  id int(11) NOT NULL,
  month int(11) NOT NULL,
  bg_id int(11) NOT NULL,
  bg_sub_id int(11) NOT NULL,
  scenario_id int(11) NOT NULL,
  bg_progress int(11) NOT NULL,
  bg_effect text NOT NULL,
  bgm_cue_name text NOT NULL,
  bgm_cuesheet text NOT NULL,
  env_cue_name text NOT NULL,
  env_cuesheet_name text NOT NULL,
  max_placement int(11) NOT NULL,
  half_type int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 264,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `single_mode_top_bg_0_month_1_scenario_id` on table `single_mode_top_bg`
--
ALTER TABLE single_mode_top_bg
ADD INDEX single_mode_top_bg_0_month_1_scenario_id (month, scenario_id);

--
-- Create index `single_mode_top_bg_0_scenario_id` on table `single_mode_top_bg`
--
ALTER TABLE single_mode_top_bg
ADD INDEX single_mode_top_bg_0_scenario_id (scenario_id);

--
-- Create table `single_mode_team_race_set`
--
CREATE TABLE single_mode_team_race_set (
  id INT(11) NOT NULL,
  rank INT(11) NOT NULL,
  race_instance_id_1 INT(11) NOT NULL,
  race_instance_id_2 INT(11) NOT NULL,
  race_instance_id_3 INT(11) NOT NULL,
  race_instance_id_4 INT(11) NOT NULL,
  race_instance_id_5 INT(11) NOT NULL,
  status_correction INT(11) NOT NULL,
  super_team_chara_id INT(11) NOT NULL,
  motion_id INT(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 240,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `single_mode_team_race_set_0_super_team_chara_id` on table `single_mode_team_race_set`
--
ALTER TABLE single_mode_team_race_set
ADD INDEX single_mode_team_race_set_0_super_team_chara_id (super_team_chara_id);

--
-- Create table `single_mode_team_name`
--
CREATE TABLE single_mode_team_name (
  id int(11) NOT NULL,
  chara_id int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 4096,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `single_mode_tag_card_pos`
--
CREATE TABLE single_mode_tag_card_pos (
  id int(11) NOT NULL,
  support_card_id int(11) NOT NULL,
  pattern int(11) NOT NULL,
  pos_index int(11) NOT NULL,
  pos_x int(11) NOT NULL,
  pos_y int(11) NOT NULL,
  scale_x int(11) NOT NULL,
  scale_y int(11) NOT NULL,
  rot_z int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 67,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `single_mode_tag_card_pos_0_support_card_id` on table `single_mode_tag_card_pos`
--
ALTER TABLE single_mode_tag_card_pos
ADD INDEX single_mode_tag_card_pos_0_support_card_id (support_card_id);

--
-- Create table `single_mode_story_guide`
--
CREATE TABLE single_mode_story_guide (
  story_id int(11) NOT NULL,
  guide_id int(11) NOT NULL,
  PRIMARY KEY (story_id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 8192,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `single_mode_story_data`
--
CREATE TABLE single_mode_story_data (
  id int(11) NOT NULL,
  story_id int(11) NOT NULL,
  short_story_id int(11) NOT NULL,
  card_id int(11) NOT NULL,
  card_chara_id int(11) NOT NULL,
  support_card_id int(11) NOT NULL,
  support_chara_id int(11) NOT NULL,
  show_progress_1 int(11) NOT NULL,
  show_progress_2 int(11) NOT NULL,
  show_progress_3 int(11) NOT NULL,
  show_clear int(11) NOT NULL,
  show_succession int(11) NOT NULL,
  event_title_style int(11) NOT NULL,
  event_title_dress_icon int(11) NOT NULL,
  event_title_chara_icon int(11) NOT NULL,
  se_change int(11) NOT NULL,
  ending_type int(11) NOT NULL,
  race_event_flag int(11) NOT NULL,
  mini_game_result int(11) NOT NULL,
  gallery_main_scenario int(11) NOT NULL,
  gallery_flag int(11) NOT NULL,
  gallery_list_id int(11) NOT NULL,
  past_race_id int(11) NOT NULL,
  available_gallery_key int(11) NOT NULL,
  force_use_race_dress int(11) NOT NULL,
  event_category int(11) NOT NULL,
  past_race_id_2 int(11) NOT NULL,
  past_race_id_3 int(11) NOT NULL,
  past_race_id_4 int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 255,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `single_mode_story_data_0_card_chara_id` on table `single_mode_story_data`
--
ALTER TABLE single_mode_story_data
ADD INDEX single_mode_story_data_0_card_chara_id (card_chara_id);

--
-- Create index `single_mode_story_data_0_card_id` on table `single_mode_story_data`
--
ALTER TABLE single_mode_story_data
ADD INDEX single_mode_story_data_0_card_id (card_id);

--
-- Create index `single_mode_story_data_0_gallery_main_scenario` on table `single_mode_story_data`
--
ALTER TABLE single_mode_story_data
ADD INDEX single_mode_story_data_0_gallery_main_scenario (gallery_main_scenario);

--
-- Create index `single_mode_story_data_0_short_story_id` on table `single_mode_story_data`
--
ALTER TABLE single_mode_story_data
ADD INDEX single_mode_story_data_0_short_story_id (short_story_id);

--
-- Create index `single_mode_story_data_0_story_id` on table `single_mode_story_data`
--
ALTER TABLE single_mode_story_data
ADD INDEX single_mode_story_data_0_story_id (story_id);

--
-- Create index `single_mode_story_data_0_support_card_id` on table `single_mode_story_data`
--
ALTER TABLE single_mode_story_data
ADD INDEX single_mode_story_data_0_support_card_id (support_card_id);

--
-- Create index `single_mode_story_data_0_support_chara_id` on table `single_mode_story_data`
--
ALTER TABLE single_mode_story_data
ADD INDEX single_mode_story_data_0_support_chara_id (support_chara_id);

--
-- Create table `single_mode_sport_training_cut`
--
CREATE TABLE single_mode_sport_training_cut (
  id int(11) NOT NULL,
  command_id int(11) NOT NULL,
  training_level int(11) NOT NULL,
  success_cutin_name text NOT NULL,
  failure_cutin_name text NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 218,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `single_mode_sport_training_cut_0_command_id_1_training_level` on table `single_mode_sport_training_cut`
--
ALTER TABLE single_mode_sport_training_cut
ADD INDEX single_mode_sport_training_cut_0_command_id_1_training_level (command_id, training_level);

--
-- Create table `single_mode_sport_stance_effect`
--
CREATE TABLE single_mode_sport_stance_effect (
  id int(11) NOT NULL,
  effect_type int(11) NOT NULL,
  effect_value_1 int(11) NOT NULL,
  effect_value_2 int(11) NOT NULL,
  effect_value_3 int(11) NOT NULL,
  effect_value_4 int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 2048,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `single_mode_sport_stance`
--
CREATE TABLE single_mode_sport_stance (
  id int(11) NOT NULL,
  sport_type int(11) NOT NULL,
  total_sport_rank int(11) NOT NULL,
  stance_effect_id_1 int(11) NOT NULL,
  stance_effect_id_2 int(11) NOT NULL,
  stance_effect_id_3 int(11) NOT NULL,
  stance_effect_id_4 int(11) NOT NULL,
  stance_effect_id_5 int(11) NOT NULL,
  effect_turn int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 546,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `single_mode_sport_stance_0_sport_type` on table `single_mode_sport_stance`
--
ALTER TABLE single_mode_sport_stance
ADD INDEX single_mode_sport_stance_0_sport_type (sport_type);

--
-- Create table `single_mode_sport_sport_type`
--
CREATE TABLE single_mode_sport_sport_type (
  id int(11) NOT NULL,
  command_id int(11) NOT NULL,
  training_set_id int(11) NOT NULL,
  target_type int(11) NOT NULL,
  sport_type int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1092,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `single_mode_sport_sport_type_0_command_id` on table `single_mode_sport_sport_type`
--
ALTER TABLE single_mode_sport_sport_type
ADD INDEX single_mode_sport_sport_type_0_command_id (command_id);

--
-- Create index `single_mode_sport_sport_type_0_sport_type` on table `single_mode_sport_sport_type`
--
ALTER TABLE single_mode_sport_sport_type
ADD INDEX single_mode_sport_sport_type_0_sport_type (sport_type);

--
-- Create table `single_mode_sport_mob`
--
CREATE TABLE single_mode_sport_mob (
  id int(11) NOT NULL,
  mob_id int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 81,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `single_mode_sport_link`
--
CREATE TABLE single_mode_sport_link (
  id int(11) NOT NULL,
  command_id int(11) NOT NULL,
  training_level int(11) NOT NULL,
  target_type int(11) NOT NULL,
  effect_value int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 109,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `single_mode_sport_link_0_command_id` on table `single_mode_sport_link`
--
ALTER TABLE single_mode_sport_link
ADD INDEX single_mode_sport_link_0_command_id (command_id);

--
-- Create table `single_mode_sport_item_effect`
--
CREATE TABLE single_mode_sport_item_effect (
  id int(11) NOT NULL,
  item_id int(11) NOT NULL,
  effect_type int(11) NOT NULL,
  effect_value_1 int(11) NOT NULL,
  effect_value_2 int(11) NOT NULL,
  effect_value_3 int(11) NOT NULL,
  effect_value_4 int(11) NOT NULL,
  motion_id int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 2340,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `single_mode_sport_item_effect_0_item_id` on table `single_mode_sport_item_effect`
--
ALTER TABLE single_mode_sport_item_effect
ADD INDEX single_mode_sport_item_effect_0_item_id (item_id);

--
-- Create table `single_mode_sport_compe_se`
--
CREATE TABLE single_mode_sport_compe_se (
  id int(11) NOT NULL,
  sheet_id varchar(750) NOT NULL,
  se_cue_name text NOT NULL,
  se_cuesheet_name text NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1092,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `single_mode_sport_compe_se_0_sheet_id` on table `single_mode_sport_compe_se`
--
ALTER TABLE single_mode_sport_compe_se
ADD INDEX single_mode_sport_compe_se_0_sheet_id (sheet_id);

--
-- Create table `single_mode_sport_compe_effect`
--
CREATE TABLE single_mode_sport_compe_effect (
  id int(11) NOT NULL,
  sport_type int(11) NOT NULL,
  min_num int(11) NOT NULL,
  max_num int(11) NOT NULL,
  effect_type int(11) NOT NULL,
  effect_value_1 int(11) NOT NULL,
  effect_value_2 int(11) NOT NULL,
  effect_value_3 int(11) NOT NULL,
  effect_value_4 int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1092,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `single_mode_sport_compe_effect_0_sport_type` on table `single_mode_sport_compe_effect`
--
ALTER TABLE single_mode_sport_compe_effect
ADD INDEX single_mode_sport_compe_effect_0_sport_type (sport_type);

--
-- Create table `single_mode_sport_competition`
--
CREATE TABLE single_mode_sport_competition (
  id int(11) NOT NULL,
  compe_type int(11) NOT NULL,
  turn int(11) NOT NULL,
  win_num int(11) NOT NULL,
  win_sport_rank int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 3276,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `single_mode_sport_competition_0_compe_type` on table `single_mode_sport_competition`
--
ALTER TABLE single_mode_sport_competition
ADD INDEX single_mode_sport_competition_0_compe_type (compe_type);

--
-- Create index `single_mode_sport_competition_0_turn` on table `single_mode_sport_competition`
--
ALTER TABLE single_mode_sport_competition
ADD INDEX single_mode_sport_competition_0_turn (turn);

--
-- Create table `single_mode_special_chara`
--
CREATE TABLE single_mode_special_chara (
  id int(11) NOT NULL,
  scenario_id int(11) NOT NULL,
  chara_id int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 2730,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `single_mode_special_chara_0_scenario_id` on table `single_mode_special_chara`
--
ALTER TABLE single_mode_special_chara
ADD INDEX single_mode_special_chara_0_scenario_id (scenario_id);

--
-- Create index `single_mode_special_chara_0_scenario_id_1_chara_id` on table `single_mode_special_chara`
--
ALTER TABLE single_mode_special_chara
ADD INDEX single_mode_special_chara_0_scenario_id_1_chara_id (scenario_id, chara_id);

--
-- Create table `single_mode_skill_need_point`
--
CREATE TABLE single_mode_skill_need_point (
  id int(11) NOT NULL,
  need_skill_point int(11) NOT NULL,
  status_type int(11) NOT NULL,
  status_value int(11) NOT NULL,
  solvable_type int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 37,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `single_mode_scout_chara`
--
CREATE TABLE single_mode_scout_chara (
  id int(11) NOT NULL,
  support_card_id int(11) NOT NULL,
  chara_id int(11) NOT NULL,
  race_dress_id int(11) NOT NULL,
  live_dress_id int(11) NOT NULL,
  tag_support_card_id int(11) NOT NULL,
  speed int(11) NOT NULL,
  stamina int(11) NOT NULL,
  pow int(11) NOT NULL,
  guts int(11) NOT NULL,
  wiz int(11) NOT NULL,
  proper_distance_short int(11) NOT NULL,
  proper_distance_mile int(11) NOT NULL,
  proper_distance_middle int(11) NOT NULL,
  proper_distance_long int(11) NOT NULL,
  proper_running_style_nige int(11) NOT NULL,
  proper_running_style_senko int(11) NOT NULL,
  proper_running_style_sashi int(11) NOT NULL,
  proper_running_style_oikomi int(11) NOT NULL,
  proper_ground_turf int(11) NOT NULL,
  proper_ground_dirt int(11) NOT NULL,
  speed_limit int(11) NOT NULL,
  stamina_limit int(11) NOT NULL,
  pow_limit int(11) NOT NULL,
  guts_limit int(11) NOT NULL,
  wiz_limit int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 346,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `single_mode_scout_chara_0_chara_id` on table `single_mode_scout_chara`
--
ALTER TABLE single_mode_scout_chara
ADD INDEX single_mode_scout_chara_0_chara_id (chara_id);

--
-- Create table `single_mode_scenario_update`
--
CREATE TABLE single_mode_scenario_update (
  id int(11) NOT NULL,
  scenario_id int(11) NOT NULL,
  tips_group_id int(11) NOT NULL,
  page_index_from int(11) NOT NULL,
  page_index_to int(11) NOT NULL,
  start_date int(11) NOT NULL,
  end_date int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 8192,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `single_mode_scenario_update_0_scenario_id` on table `single_mode_scenario_update`
--
ALTER TABLE single_mode_scenario_update
ADD INDEX single_mode_scenario_update_0_scenario_id (scenario_id);

--
-- Create table `single_mode_scenario_record`
--
CREATE TABLE single_mode_scenario_record (
  id int(11) NOT NULL,
  scenario_id int(11) NOT NULL,
  need_record_min int(11) NOT NULL,
  reward_item_category int(11) NOT NULL,
  reward_item_id int(11) NOT NULL,
  reward_num int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 606,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `single_mode_scenario_record_0_scenario_id` on table `single_mode_scenario_record`
--
ALTER TABLE single_mode_scenario_record
ADD INDEX single_mode_scenario_record_0_scenario_id (scenario_id);

--
-- Create table `single_mode_scenario_group`
--
CREATE TABLE single_mode_scenario_group (
  id int(11) NOT NULL,
  group_id int(11) NOT NULL,
  scenario_id int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 348,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `single_mode_scenario_group_0_scenario_id` on table `single_mode_scenario_group`
--
ALTER TABLE single_mode_scenario_group
ADD INDEX single_mode_scenario_group_0_scenario_id (scenario_id);

--
-- Create table `single_mode_scenario`
--
CREATE TABLE single_mode_scenario (
  id int(11) NOT NULL,
  sort_id int(11) NOT NULL,
  scenario_image_id int(11) NOT NULL,
  prologue_id int(11) NOT NULL,
  turn_set_id int(11) NOT NULL,
  hint_rate int(11) NOT NULL,
  start_date int(11) NOT NULL,
  end_date int(11) NOT NULL,
  bg_id int(11) NOT NULL,
  bg_sub_id int(11) NOT NULL,
  bg_offset_x int(11) NOT NULL,
  sec_bg_id int(11) NOT NULL,
  sec_bg_sub_id int(11) NOT NULL,
  label_font_color text NOT NULL,
  label_bg_color text NOT NULL,
  chara_program_change_flag int(11) NOT NULL,
  max_speed int(11) NOT NULL,
  max_stamina int(11) NOT NULL,
  max_pow int(11) NOT NULL,
  max_guts int(11) NOT NULL,
  max_wiz int(11) NOT NULL,
  gimmick_discount_rate int(11) NOT NULL,
  additional_icon_set_id int(11) NOT NULL,
  skill_upgrade_num int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 5461,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `single_mode_route_race`
--
CREATE TABLE single_mode_route_race (
  id int(11) NOT NULL,
  race_set_id int(11) NOT NULL,
  target_type int(11) NOT NULL,
  sort_id int(11) NOT NULL,
  turn int(11) NOT NULL,
  race_type int(11) NOT NULL,
  condition_type int(11) NOT NULL,
  condition_id int(11) NOT NULL,
  condition_value_1 int(11) NOT NULL,
  condition_value_2 int(11) NOT NULL,
  determine_race int(11) NOT NULL,
  determine_race_flag int(11) NOT NULL,
  scenario_group_id int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 121,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `single_mode_route_race_0_race_set_id` on table `single_mode_route_race`
--
ALTER TABLE single_mode_route_race
ADD INDEX single_mode_route_race_0_race_set_id (race_set_id);

--
-- Create table `single_mode_route_condition`
--
CREATE TABLE single_mode_route_condition (
  id int(11) NOT NULL,
  condition_set_id int(11) NOT NULL,
  condition_type_1 int(11) NOT NULL,
  condition_value_1 int(11) NOT NULL,
  condition_value_2 int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1024,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `single_mode_route_condition_0_condition_set_id` on table `single_mode_route_condition`
--
ALTER TABLE single_mode_route_condition
ADD INDEX single_mode_route_condition_0_condition_set_id (condition_set_id);

--
-- Create table `single_mode_route_announce`
--
CREATE TABLE single_mode_route_announce (
  id int(11) NOT NULL,
  route_race_type int(11) NOT NULL,
  route_race_id int(11) NOT NULL,
  turn int(11) NOT NULL,
  target_type int(11) NOT NULL,
  target_value int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 910,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `single_mode_route_announce_0_route_race_type_1_route_race_id` on table `single_mode_route_announce`
--
ALTER TABLE single_mode_route_announce
ADD INDEX single_mode_route_announce_0_route_race_type_1_route_race_id (route_race_type, route_race_id);

--
-- Create table `single_mode_route`
--
CREATE TABLE single_mode_route (
  id int(11) NOT NULL,
  scenario_id int(11) NOT NULL,
  chara_id int(11) NOT NULL,
  race_set_id int(11) NOT NULL,
  condition_set_id int(11) NOT NULL,
  priority int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 282,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `single_mode_route_0_scenario_id` on table `single_mode_route`
--
ALTER TABLE single_mode_route
ADD INDEX single_mode_route_0_scenario_id (scenario_id);

--
-- Create index `single_mode_route_0_scenario_id_1_chara_id` on table `single_mode_route`
--
ALTER TABLE single_mode_route
ADD INDEX single_mode_route_0_scenario_id_1_chara_id (scenario_id, chara_id);

--
-- Create table `single_mode_rival`
--
CREATE TABLE single_mode_rival (
  id int(11) NOT NULL,
  chara_id int(11) NOT NULL,
  turn int(11) NOT NULL,
  race_program_id int(11) NOT NULL,
  rival_flag_id int(11) NOT NULL,
  condition_type int(11) NOT NULL,
  rival_chara_id int(11) NOT NULL,
  single_mode_npc_id int(11) NOT NULL,
  frame_order int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 63,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `chara_id` on table `single_mode_rival`
--
ALTER TABLE single_mode_rival
ADD UNIQUE INDEX chara_id (chara_id, turn, race_program_id, rival_chara_id, rival_flag_id, single_mode_npc_id);

--
-- Create index `single_mode_rival_0_race_program_id` on table `single_mode_rival`
--
ALTER TABLE single_mode_rival
ADD INDEX single_mode_rival_0_race_program_id (race_program_id);

--
-- Create table `single_mode_reward_set`
--
CREATE TABLE single_mode_reward_set (
  id int(11) NOT NULL,
  reward_set_id int(11) NOT NULL,
  order_min int(11) NOT NULL,
  order_max int(11) NOT NULL,
  reward_type int(11) NOT NULL,
  bonus int(11) NOT NULL,
  odds int(11) NOT NULL,
  item_category int(11) NOT NULL,
  item_id int(11) NOT NULL,
  item_num int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 111,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `single_mode_reward_set_0_reward_set_id` on table `single_mode_reward_set`
--
ALTER TABLE single_mode_reward_set
ADD INDEX single_mode_reward_set_0_reward_set_id (reward_set_id);

--
-- Create table `single_mode_restrict_support`
--
CREATE TABLE single_mode_restrict_support (
  id int(11) NOT NULL,
  scenario_id int(11) NOT NULL,
  support_card_id int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 2340,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `single_mode_restrict_support_0_scenario_id` on table `single_mode_restrict_support`
--
ALTER TABLE single_mode_restrict_support
ADD INDEX single_mode_restrict_support_0_scenario_id (scenario_id);

--
-- Create index `single_mode_restrict_support_0_support_card_id` on table `single_mode_restrict_support`
--
ALTER TABLE single_mode_restrict_support
ADD INDEX single_mode_restrict_support_0_support_card_id (support_card_id);

--
-- Create table `single_mode_recommend_setting`
--
CREATE TABLE single_mode_recommend_setting (
  id int(11) NOT NULL,
  recommend_course_id int(11) NOT NULL,
  header_font_color text NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 5461,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `single_mode_recommend_setting_0_recommend_course_id` on table `single_mode_recommend_setting`
--
ALTER TABLE single_mode_recommend_setting
ADD INDEX single_mode_recommend_setting_0_recommend_course_id (recommend_course_id);

--
-- Create table `single_mode_recommend`
--
CREATE TABLE single_mode_recommend (
  id int(11) NOT NULL,
  grade_upper_limit int(11) NOT NULL,
  grade_lower_limit int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1170,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `single_mode_rank`
--
CREATE TABLE single_mode_rank (
  id int(11) NOT NULL,
  min_value int(11) NOT NULL,
  max_value int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 167,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `single_mode_race_restrict_turn`
--
CREATE TABLE single_mode_race_restrict_turn (
  chara_id int(11) NOT NULL,
  turn int(11) NOT NULL,
  gain_id int(11) NOT NULL,
  PRIMARY KEY (chara_id, turn)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1820,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `single_mode_race_restrict_turn_0_chara_id` on table `single_mode_race_restrict_turn`
--
ALTER TABLE single_mode_race_restrict_turn
ADD INDEX single_mode_race_restrict_turn_0_chara_id (chara_id);

--
-- Create table `single_mode_race_live`
--
CREATE TABLE single_mode_race_live (
  id int(11) NOT NULL,
  grade int(11) NOT NULL,
  race_instance_id int(11) NOT NULL,
  music_id int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 131,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `single_mode_race_limit_reward`
--
CREATE TABLE single_mode_race_limit_reward (
  id int(11) NOT NULL,
  item_category int(11) NOT NULL,
  item_id int(11) NOT NULL,
  reward_num int(11) NOT NULL,
  reward_limit int(11) NOT NULL,
  start_date int(11) NOT NULL,
  end_date int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `single_mode_race_group`
--
CREATE TABLE single_mode_race_group (
  id int(11) NOT NULL,
  race_group_id int(11) NOT NULL,
  race_program_id int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 66,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `single_mode_race_group_0_race_group_id` on table `single_mode_race_group`
--
ALTER TABLE single_mode_race_group
ADD INDEX single_mode_race_group_0_race_group_id (race_group_id);

--
-- Create index `single_mode_race_group_0_race_program_id` on table `single_mode_race_group`
--
ALTER TABLE single_mode_race_group
ADD INDEX single_mode_race_group_0_race_program_id (race_program_id);

--
-- Create table `single_mode_program`
--
CREATE TABLE single_mode_program (
  id int(11) NOT NULL,
  base_program_id int(11) NOT NULL,
  program_group int(11) NOT NULL,
  race_instance_id int(11) NOT NULL,
  race_permission int(11) NOT NULL,
  month int(11) NOT NULL,
  half int(11) NOT NULL,
  grade_rate_id int(11) NOT NULL,
  entry_decrease int(11) NOT NULL,
  entry_decrease_flag int(11) NOT NULL,
  recommend_class_id int(11) NOT NULL,
  filly_only_flag int(11) NOT NULL,
  need_fan_count int(11) NOT NULL,
  fan_set_id int(11) NOT NULL,
  reward_set_id int(11) NOT NULL,
  reserve_program_id int(11) NOT NULL,
  random_group_id int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 133,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `single_mode_program_0_month` on table `single_mode_program`
--
ALTER TABLE single_mode_program
ADD INDEX single_mode_program_0_month (month);

--
-- Create table `single_mode_preview_bgm`
--
CREATE TABLE single_mode_preview_bgm (
  id int(11) NOT NULL,
  scenario_id int(11) NOT NULL,
  preview_order int(11) NOT NULL,
  cue_name text NOT NULL,
  cuesheet_name text NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 862,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `single_mode_preview_bgm_0_scenario_id` on table `single_mode_preview_bgm`
--
ALTER TABLE single_mode_preview_bgm
ADD INDEX single_mode_preview_bgm_0_scenario_id (scenario_id);

--
-- Create table `single_mode_outing_set`
--
CREATE TABLE single_mode_outing_set (
  id int(11) NOT NULL,
  command_group_id_1 int(11) NOT NULL,
  command_group_id_2 int(11) NOT NULL,
  command_group_id_3 int(11) NOT NULL,
  command_group_id_4 int(11) NOT NULL,
  command_group_id_5 int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 8192,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `single_mode_outing`
--
CREATE TABLE single_mode_outing (
  id int(11) NOT NULL,
  command_group_id int(11) NOT NULL,
  `condition` int(11) NOT NULL,
  is_play_cutt int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 5461,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `single_mode_outing_0_command_group_id` on table `single_mode_outing`
--
ALTER TABLE single_mode_outing
ADD INDEX single_mode_outing_0_command_group_id (command_group_id);

--
-- Create table `single_mode_npc`
--
CREATE TABLE single_mode_npc (
  id int(11) NOT NULL,
  npc_group_id int(11) NOT NULL,
  chara_id int(11) NOT NULL,
  mob_id int(11) NOT NULL,
  race_dress_id int(11) NOT NULL,
  speed int(11) NOT NULL,
  stamina int(11) NOT NULL,
  pow int(11) NOT NULL,
  guts int(11) NOT NULL,
  wiz int(11) NOT NULL,
  proper_distance_short int(11) NOT NULL,
  proper_distance_mile int(11) NOT NULL,
  proper_distance_middle int(11) NOT NULL,
  proper_distance_long int(11) NOT NULL,
  proper_running_style_nige int(11) NOT NULL,
  proper_running_style_senko int(11) NOT NULL,
  proper_running_style_sashi int(11) NOT NULL,
  proper_running_style_oikomi int(11) NOT NULL,
  proper_ground_turf int(11) NOT NULL,
  proper_ground_dirt int(11) NOT NULL,
  skill_set_id int(11) NOT NULL,
  motivation_min int(11) NOT NULL,
  motivation_max int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 143,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `single_mode_npc_0_npc_group_id` on table `single_mode_npc`
--
ALTER TABLE single_mode_npc
ADD INDEX single_mode_npc_0_npc_group_id (npc_group_id);

--
-- Create table `single_mode_message`
--
CREATE TABLE single_mode_message (
  id int(11) NOT NULL,
  priority int(11) NOT NULL,
  emergent int(11) NOT NULL,
  status_type_1 int(11) NOT NULL,
  status_value_1_1 int(11) NOT NULL,
  status_value_1_2 int(11) NOT NULL,
  status_type_2 int(11) NOT NULL,
  status_value_2_1 int(11) NOT NULL,
  status_value_2_2 int(11) NOT NULL,
  character_type int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 630,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `single_mode_member_rank_points`
--
CREATE TABLE single_mode_member_rank_points (
  id int(11) NOT NULL,
  rank_id int(11) NOT NULL,
  points int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 2048,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `single_mode_member_rank_points_0_rank_id` on table `single_mode_member_rank_points`
--
ALTER TABLE single_mode_member_rank_points
ADD INDEX single_mode_member_rank_points_0_rank_id (rank_id);

--
-- Create table `single_mode_member_rank`
--
CREATE TABLE single_mode_member_rank (
  id int(11) NOT NULL,
  value_min int(11) NOT NULL,
  value_max int(11) NOT NULL,
  member_rank_id int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 2048,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `single_mode_member_rank_0_member_rank_id` on table `single_mode_member_rank`
--
ALTER TABLE single_mode_member_rank
ADD INDEX single_mode_member_rank_0_member_rank_id (member_rank_id);

--
-- Create table `single_mode_live_square`
--
CREATE TABLE single_mode_live_square (
  id int(11) NOT NULL,
  square_title_text_id int(11) NOT NULL,
  square_content_text_id int(11) NOT NULL,
  master_bonus_id int(11) NOT NULL,
  square_type int(11) NOT NULL,
  perf_type_1 int(11) NOT NULL,
  perf_value_1 int(11) NOT NULL,
  perf_type_2 int(11) NOT NULL,
  perf_value_2 int(11) NOT NULL,
  perf_type_3 int(11) NOT NULL,
  perf_value_3 int(11) NOT NULL,
  perf_type_4 int(11) NOT NULL,
  perf_value_4 int(11) NOT NULL,
  perf_type_5 int(11) NOT NULL,
  perf_value_5 int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 182,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `single_mode_live_song_list`
--
CREATE TABLE single_mode_live_song_list (
  id int(11) NOT NULL,
  command_id int(11) NOT NULL,
  live_id int(11) NOT NULL,
  level int(11) NOT NULL,
  master_bonus_content_text_id int(11) NOT NULL,
  live_bonus_type int(11) NOT NULL,
  live_bonus_value int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 682,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `single_mode_live_song_list_0_command_id` on table `single_mode_live_song_list`
--
ALTER TABLE single_mode_live_song_list
ADD INDEX single_mode_live_song_list_0_command_id (command_id);

--
-- Create index `single_mode_live_song_list_0_live_id` on table `single_mode_live_song_list`
--
ALTER TABLE single_mode_live_song_list
ADD INDEX single_mode_live_song_list_0_live_id (live_id);

--
-- Create table `single_mode_live_master_bonus`
--
CREATE TABLE single_mode_live_master_bonus (
  id int(11) NOT NULL,
  master_bonus_type int(11) NOT NULL,
  master_bonus_type_value int(11) NOT NULL,
  master_bonus_gain_type_1 int(11) NOT NULL,
  master_bonus_gain_value_1_1 int(11) NOT NULL,
  master_bonus_gain_value_1_2 int(11) NOT NULL,
  master_bonus_gain_value_1_3 int(11) NOT NULL,
  master_bonus_gain_value_1_4 int(11) NOT NULL,
  master_bonus_gain_type_2 int(11) NOT NULL,
  master_bonus_gain_value_2_1 int(11) NOT NULL,
  master_bonus_gain_value_2_2 int(11) NOT NULL,
  master_bonus_gain_value_2_3 int(11) NOT NULL,
  master_bonus_gain_value_2_4 int(11) NOT NULL,
  master_bonus_gain_type_3 int(11) NOT NULL,
  master_bonus_gain_value_3_1 int(11) NOT NULL,
  master_bonus_gain_value_3_2 int(11) NOT NULL,
  master_bonus_gain_value_3_3 int(11) NOT NULL,
  master_bonus_gain_value_3_4 int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 123,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `single_mode_live_live_data`
--
CREATE TABLE single_mode_live_live_data (
  id int(11) NOT NULL,
  live_type int(11) NOT NULL,
  turn_num int(11) NOT NULL,
  great_success_num int(11) NOT NULL,
  song_num int(11) NOT NULL,
  normal_music_id int(11) NOT NULL,
  special_music_id int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 3276,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `single_mode_hint_gain`
--
CREATE TABLE single_mode_hint_gain (
  id int(11) NOT NULL,
  hint_id int(11) NOT NULL,
  support_card_id int(11) NOT NULL,
  hint_group int(11) NOT NULL,
  hint_gain_type int(11) NOT NULL,
  hint_value_1 int(11) NOT NULL,
  hint_value_2 int(11) NOT NULL,
  group_id int(11) NOT NULL,
  condition_set_id int(11) NOT NULL,
  priority int(11) NOT NULL
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 72,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `single_mode_hint_gain_0_hint_id` on table `single_mode_hint_gain`
--
ALTER TABLE single_mode_hint_gain
ADD INDEX single_mode_hint_gain_0_hint_id (hint_id);

--
-- Create table `single_mode_hide_chara_text`
--
CREATE TABLE single_mode_hide_chara_text (
  id int(11) NOT NULL,
  character_id int(11) NOT NULL,
  voice_id int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1260,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `single_mode_hide_chara_text_0_character_id` on table `single_mode_hide_chara_text`
--
ALTER TABLE single_mode_hide_chara_text
ADD INDEX single_mode_hide_chara_text_0_character_id (character_id);

--
-- Create table `single_mode_free_win_point`
--
CREATE TABLE single_mode_free_win_point (
  id int(11) NOT NULL,
  race_group_id int(11) NOT NULL,
  grade int(11) NOT NULL,
  order_min int(11) NOT NULL,
  order_max int(11) NOT NULL,
  point_num int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 248,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `single_mode_free_win_point_0_grade` on table `single_mode_free_win_point`
--
ALTER TABLE single_mode_free_win_point
ADD INDEX single_mode_free_win_point_0_grade (grade);

--
-- Create index `single_mode_free_win_point_0_race_group_id` on table `single_mode_free_win_point`
--
ALTER TABLE single_mode_free_win_point
ADD INDEX single_mode_free_win_point_0_race_group_id (race_group_id);

--
-- Create table `single_mode_free_training_plate`
--
CREATE TABLE single_mode_free_training_plate (
  id int(11) NOT NULL,
  condition_type int(11) NOT NULL,
  value_min int(11) NOT NULL,
  value_max int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 5461,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `single_mode_free_training_plate_0_condition_type` on table `single_mode_free_training_plate`
--
ALTER TABLE single_mode_free_training_plate
ADD INDEX single_mode_free_training_plate_0_condition_type (condition_type);

--
-- Create table `single_mode_free_shop_item`
--
CREATE TABLE single_mode_free_shop_item (
  id int(11) NOT NULL,
  item_id int(11) NOT NULL,
  effect_group_id int(11) NOT NULL,
  coin_num int(11) NOT NULL,
  limit_num int(11) NOT NULL,
  effect_group int(11) NOT NULL,
  effect_priority int(11) NOT NULL,
  motion_id int(11) NOT NULL,
  use_flag int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 309,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `single_mode_free_shop_item_0_item_id` on table `single_mode_free_shop_item`
--
ALTER TABLE single_mode_free_shop_item
ADD INDEX single_mode_free_shop_item_0_item_id (item_id);

--
-- Create table `single_mode_free_shop_effect`
--
CREATE TABLE single_mode_free_shop_effect (
  id int(11) NOT NULL,
  effect_group_id int(11) NOT NULL,
  effect_type int(11) NOT NULL,
  effect_value_1 int(11) NOT NULL,
  effect_value_2 int(11) NOT NULL,
  effect_value_3 int(11) NOT NULL,
  effect_value_4 int(11) NOT NULL,
  turn int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 256,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `single_mode_free_shop_effect_0_effect_group_id` on table `single_mode_free_shop_effect`
--
ALTER TABLE single_mode_free_shop_effect
ADD INDEX single_mode_free_shop_effect_0_effect_group_id (effect_group_id);

--
-- Create table `single_mode_free_shop_bg`
--
CREATE TABLE single_mode_free_shop_bg (
  id int(11) NOT NULL,
  start_turn int(11) NOT NULL,
  end_turn int(11) NOT NULL,
  bg_id int(11) NOT NULL,
  bg_sub_id int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 3276,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `single_mode_free_shop`
--
CREATE TABLE single_mode_free_shop (
  id int(11) NOT NULL,
  start_turn int(11) NOT NULL,
  end_turn int(11) NOT NULL,
  lineup_group_id int(11) NOT NULL,
  max_lineup_num int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1489,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `single_mode_free_coin_race`
--
CREATE TABLE single_mode_free_coin_race (
  id int(11) NOT NULL,
  grade int(11) NOT NULL,
  order_min int(11) NOT NULL,
  order_max int(11) NOT NULL,
  coin_num int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 455,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `single_mode_free_coin_race_0_grade` on table `single_mode_free_coin_race`
--
ALTER TABLE single_mode_free_coin_race
ADD INDEX single_mode_free_coin_race_0_grade (grade);

--
-- Create table `single_mode_fan_count`
--
CREATE TABLE single_mode_fan_count (
  id int(11) NOT NULL,
  fan_set_id int(11) NOT NULL,
  `order` int(11) NOT NULL,
  fan_count int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 72,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `single_mode_fan_count_0_fan_set_id` on table `single_mode_fan_count`
--
ALTER TABLE single_mode_fan_count
ADD INDEX single_mode_fan_count_0_fan_set_id (fan_set_id);

--
-- Create table `single_mode_event_production`
--
CREATE TABLE single_mode_event_production (
  story_id int(11) NOT NULL,
  event_category_id int(11) NOT NULL,
  max_item_id int(11) NOT NULL,
  item_dir text NOT NULL,
  item_name text NOT NULL,
  PRIMARY KEY (story_id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 268,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `single_mode_event_item_detail`
--
CREATE TABLE single_mode_event_item_detail (
  id int(11) NOT NULL,
  event_category_id int(11) NOT NULL,
  item_id int(11) NOT NULL,
  name_index int(11) NOT NULL,
  is_special int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1024,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `single_mode_event_item_detail_0_event_category_id_1_item_id` on table `single_mode_event_item_detail`
--
ALTER TABLE single_mode_event_item_detail
ADD INDEX single_mode_event_item_detail_0_event_category_id_1_item_id (event_category_id, item_id);

--
-- Create table `single_mode_event_conclusion`
--
CREATE TABLE single_mode_event_conclusion (
  id int(11) NOT NULL,
  chara_id int(11) NOT NULL,
  chara_motion_set_id int(11) NOT NULL,
  PRIMARY KEY (id, chara_id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 80,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `single_mode_evaluation`
--
CREATE TABLE single_mode_evaluation (
  id int(11) NOT NULL,
  evaluation int(11) NOT NULL,
  chara_id int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1365,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `single_mode_evaluation_0_chara_id` on table `single_mode_evaluation`
--
ALTER TABLE single_mode_evaluation
ADD INDEX single_mode_evaluation_0_chara_id (chara_id);

--
-- Create table `single_mode_difficulty_mode`
--
CREATE TABLE single_mode_difficulty_mode (
  difficulty_id int(11) NOT NULL,
  guide_id int(11) NOT NULL,
  chara_id int(11) NOT NULL,
  dress_id int(11) NOT NULL,
  in_motion int(11) NOT NULL,
  stand_motion int(11) NOT NULL,
  play_motion int(11) NOT NULL,
  gauge_motion int(11) NOT NULL,
  gauge_motion2 int(11) NOT NULL,
  gauge_motion3 int(11) NOT NULL,
  popout_motion int(11) NOT NULL,
  bgm_cue_name text NOT NULL,
  bgm_cuesheet_name text NOT NULL,
  reward_type int(11) NOT NULL,
  reward_set_id int(11) NOT NULL,
  gauge_max int(11) NOT NULL,
  gauge_up int(11) NOT NULL,
  firstclear_motion int(11) NOT NULL,
  prize_motion1 int(11) NOT NULL,
  prize_motion2 int(11) NOT NULL,
  prize_motion3 int(11) NOT NULL,
  item_category int(11) NOT NULL,
  item_id int(11) NOT NULL,
  max_num int(11) NOT NULL,
  consume_tp_ratio int(11) NOT NULL,
  consume_tp_bonus_ratio int(11) NOT NULL,
  PRIMARY KEY (difficulty_id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 8192,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `single_mode_difficulty_data`
--
CREATE TABLE single_mode_difficulty_data (
  difficulty_id int(11) NOT NULL,
  difficulty int(11) NOT NULL,
  difficulty_index int(11) NOT NULL,
  condition_type int(11) NOT NULL,
  condition_value int(11) NOT NULL,
  condition_type_2 int(11) NOT NULL,
  condition_value_2 int(11) NOT NULL,
  difficulty_rate int(11) NOT NULL,
  difficulty_motivation int(11) NOT NULL,
  continue_flag int(11) NOT NULL,
  special_flag int(11) NOT NULL,
  gauge_rate int(11) NOT NULL,
  item_category int(11) NOT NULL,
  item_id int(11) NOT NULL,
  max_num int(11) NOT NULL,
  description_id int(11) NOT NULL,
  result_type int(11) NOT NULL,
  addition_skill int(11) NOT NULL,
  firstclear_item_category int(11) NOT NULL,
  firstclear_item_id int(11) NOT NULL,
  firstclear_num int(11) NOT NULL,
  PRIMARY KEY (difficulty_id, difficulty)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 2730,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `single_mode_difficulty_data_0_difficulty_id_1_difficulty_index` on table `single_mode_difficulty_data`
--
ALTER TABLE single_mode_difficulty_data
ADD INDEX single_mode_difficulty_data_0_difficulty_id_1_difficulty_index (difficulty_id, difficulty_index);

--
-- Create table `single_mode_difficulty_box_reward`
--
CREATE TABLE single_mode_difficulty_box_reward (
  id int(11) NOT NULL,
  box_id int(11) NOT NULL,
  box_num int(11) NOT NULL,
  item_category int(11) NOT NULL,
  item_id int(11) NOT NULL,
  item_num int(11) NOT NULL,
  rate int(11) NOT NULL,
  prize_type int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 819,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `single_mode_difficulty_box_reward_0_box_id` on table `single_mode_difficulty_box_reward`
--
ALTER TABLE single_mode_difficulty_box_reward
ADD INDEX single_mode_difficulty_box_reward_0_box_id (box_id);

--
-- Create table `single_mode_difficulty_box_gauge`
--
CREATE TABLE single_mode_difficulty_box_gauge (
  id int(11) NOT NULL,
  difficulty_id int(11) NOT NULL,
  result_min int(11) NOT NULL,
  result_max int(11) NOT NULL,
  gauge_rate int(11) NOT NULL,
  scenario_id int(11) NOT NULL,
  add_condition_type int(11) NOT NULL,
  add_condition_min int(11) NOT NULL,
  add_condition_max int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 3276,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `single_mode_difficulty_box_gauge_0_difficulty_id` on table `single_mode_difficulty_box_gauge`
--
ALTER TABLE single_mode_difficulty_box_gauge
ADD INDEX single_mode_difficulty_box_gauge_0_difficulty_id (difficulty_id);

--
-- Create table `single_mode_difficulty_box`
--
CREATE TABLE single_mode_difficulty_box (
  reward_set_id int(11) NOT NULL,
  box_step int(11) NOT NULL,
  box_open_condition int(11) NOT NULL,
  box_type int(11) NOT NULL,
  box_id int(11) NOT NULL,
  cue_name_icon text NOT NULL,
  cue_name_popout text NOT NULL,
  cuesheet_name_icon text NOT NULL,
  cuesheet_name_popout text NOT NULL,
  PRIMARY KEY (reward_set_id, box_step)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 8192,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `single_mode_difficulty_box_0_box_id` on table `single_mode_difficulty_box`
--
ALTER TABLE single_mode_difficulty_box
ADD INDEX single_mode_difficulty_box_0_box_id (box_id);

--
-- Create index `single_mode_difficulty_box_0_box_step` on table `single_mode_difficulty_box`
--
ALTER TABLE single_mode_difficulty_box
ADD INDEX single_mode_difficulty_box_0_box_step (box_step);

--
-- Create index `single_mode_difficulty_box_0_reward_set_id` on table `single_mode_difficulty_box`
--
ALTER TABLE single_mode_difficulty_box
ADD INDEX single_mode_difficulty_box_0_reward_set_id (reward_set_id);

--
-- Create table `single_mode_cook_success_type`
--
CREATE TABLE single_mode_cook_success_type (
  id int(11) NOT NULL,
  success_motion_id int(11) NOT NULL,
  success_motion_swap1_id int(11) NOT NULL,
  success_motion_swap2_id int(11) NOT NULL,
  success_effect_name text NOT NULL,
  success_effect_position int(11) NOT NULL,
  success_effect_swap1_name text NOT NULL,
  success_effect_swap2_name text NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 4096,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `single_mode_cook_success_type_0_success_motion_id` on table `single_mode_cook_success_type`
--
ALTER TABLE single_mode_cook_success_type
ADD INDEX single_mode_cook_success_type_0_success_motion_id (success_motion_id);

--
-- Create table `single_mode_cook_success_odds`
--
CREATE TABLE single_mode_cook_success_odds (
  id int(11) NOT NULL,
  power_min int(11) NOT NULL,
  power_max int(11) NOT NULL,
  success_rate int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 2048,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `single_mode_cook_success_effect`
--
CREATE TABLE single_mode_cook_success_effect (
  id int(11) NOT NULL,
  effect_group_id int(11) NOT NULL,
  condition_type int(11) NOT NULL,
  condition_value_1 int(11) NOT NULL,
  condition_value_2 int(11) NOT NULL,
  effect_type int(11) NOT NULL,
  effect_value_1 int(11) NOT NULL,
  effect_value_2 int(11) NOT NULL,
  effect_value_3 int(11) NOT NULL,
  effect_value_4 int(11) NOT NULL,
  priority int(11) NOT NULL,
  rate int(11) NOT NULL,
  odds int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 819,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `single_mode_cook_stand_motion`
--
CREATE TABLE single_mode_cook_stand_motion (
  id int(11) NOT NULL,
  chara_id int(11) NOT NULL,
  type int(11) NOT NULL,
  condition_type int(11) NOT NULL,
  mini_chara_motion_id int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 546,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `single_mode_cook_stand_motion_0_type` on table `single_mode_cook_stand_motion`
--
ALTER TABLE single_mode_cook_stand_motion
ADD INDEX single_mode_cook_stand_motion_0_type (type);

--
-- Create index `single_mode_cook_stand_motion_0_type_1_chara_id` on table `single_mode_cook_stand_motion`
--
ALTER TABLE single_mode_cook_stand_motion
ADD INDEX single_mode_cook_stand_motion_0_type_1_chara_id (type, chara_id);

--
-- Create index `single_mode_cook_stand_motion_0_type_1_chara_id_2_condition_type` on table `single_mode_cook_stand_motion`
--
ALTER TABLE single_mode_cook_stand_motion
ADD INDEX single_mode_cook_stand_motion_0_type_1_chara_id_2_condition_type (type, chara_id, condition_type);

--
-- Create index `single_mode_cook_stand_motion_0_type_1_condition_type` on table `single_mode_cook_stand_motion`
--
ALTER TABLE single_mode_cook_stand_motion
ADD INDEX single_mode_cook_stand_motion_0_type_1_condition_type (type, condition_type);

--
-- Create table `single_mode_cook_power_data`
--
CREATE TABLE single_mode_cook_power_data (
  id int(11) NOT NULL,
  cook_type int(11) NOT NULL,
  turn_num int(11) NOT NULL,
  success_num int(11) NOT NULL,
  great_success_num int(11) NOT NULL,
  garden_lv int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 3276,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `single_mode_cook_motion_status`
--
CREATE TABLE single_mode_cook_motion_status (
  id int(11) NOT NULL,
  turn_progress int(11) NOT NULL,
  garden_progress int(11) NOT NULL,
  motion_id_1 int(11) NOT NULL,
  motion_id_2 int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1170,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `single_mode_cook_motion_status_0_turn_progress_1_garden_progress` on table `single_mode_cook_motion_status`
--
ALTER TABLE single_mode_cook_motion_status
ADD INDEX single_mode_cook_motion_status_0_turn_progress_1_garden_progress (turn_progress, garden_progress);

--
-- Create table `single_mode_cook_motion_group`
--
CREATE TABLE single_mode_cook_motion_group (
  id int(11) NOT NULL,
  bg_motion_id_1 int(11) NOT NULL,
  bg_swap_motion_id_1_1 int(11) NOT NULL,
  bg_swap_motion_speed_1_1 int(11) NOT NULL,
  bg_swap_motion_blend_1_1 int(11) NOT NULL,
  bg_swap_motion_id_1_2 int(11) NOT NULL,
  bg_swap_motion_speed_1_2 int(11) NOT NULL,
  bg_swap_motion_blend_1_2 int(11) NOT NULL,
  bg_motion_id_2 int(11) NOT NULL,
  bg_swap_motion_id_2_1 int(11) NOT NULL,
  bg_swap_motion_blend_2_1 int(11) NOT NULL,
  bg_swap_motion_id_2_2 int(11) NOT NULL,
  bg_swap_motion_blend_2_2 int(11) NOT NULL,
  bg_motion_id_3 int(11) NOT NULL,
  bg_swap_motion_id_3_1 int(11) NOT NULL,
  bg_swap_motion_blend_3_1 int(11) NOT NULL,
  bg_swap_motion_id_3_2 int(11) NOT NULL,
  bg_swap_motion_blend_3_2 int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 455,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `single_mode_cook_message`
--
CREATE TABLE single_mode_cook_message (
  id int(11) NOT NULL,
  view_type int(11) NOT NULL,
  condition_flag int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 4096,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `single_mode_cook_message_0_view_type` on table `single_mode_cook_message`
--
ALTER TABLE single_mode_cook_message
ADD INDEX single_mode_cook_message_0_view_type (view_type);

--
-- Create table `single_mode_cook_material_rate`
--
CREATE TABLE single_mode_cook_material_rate (
  id int(11) NOT NULL,
  boost_type int(11) NOT NULL,
  material_count int(11) NOT NULL,
  effect_type int(11) NOT NULL,
  material_quantity_rate int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 2048,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `single_mode_cook_material_rate_0_material_count_1_boost_type` on table `single_mode_cook_material_rate`
--
ALTER TABLE single_mode_cook_material_rate
ADD INDEX single_mode_cook_material_rate_0_material_count_1_boost_type (material_count, boost_type);

--
-- Create table `single_mode_cook_listener`
--
CREATE TABLE single_mode_cook_listener (
  id int(11) NOT NULL,
  camera text NOT NULL,
  pos_x int(11) NOT NULL,
  pos_y int(11) NOT NULL,
  pos_z int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 2730,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `single_mode_cook_listener_0_camera` on table `single_mode_cook_listener`
--
ALTER TABLE single_mode_cook_listener
ADD INDEX single_mode_cook_listener_0_camera (camera (768));

--
-- Create table `single_mode_cook_garden_level`
--
CREATE TABLE single_mode_cook_garden_level (
  id int(11) NOT NULL,
  facility_id int(11) NOT NULL,
  garden_lv int(11) NOT NULL,
  facility_lv int(11) NOT NULL,
  effect_group_id int(11) NOT NULL,
  coin_num int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 655,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `single_mode_cook_garden_level_0_facility_id` on table `single_mode_cook_garden_level`
--
ALTER TABLE single_mode_cook_garden_level
ADD INDEX single_mode_cook_garden_level_0_facility_id (facility_id);

--
-- Create index `single_mode_cook_garden_level_0_facility_id_1_garden_lv` on table `single_mode_cook_garden_level`
--
ALTER TABLE single_mode_cook_garden_level
ADD INDEX single_mode_cook_garden_level_0_facility_id_1_garden_lv (facility_id, garden_lv);

--
-- Create index `single_mode_cook_garden_level_0_garden_lv` on table `single_mode_cook_garden_level`
--
ALTER TABLE single_mode_cook_garden_level
ADD INDEX single_mode_cook_garden_level_0_garden_lv (garden_lv);

--
-- Create table `single_mode_cook_garden_effect`
--
CREATE TABLE single_mode_cook_garden_effect (
  id int(11) NOT NULL,
  effect_group_id int(11) NOT NULL,
  effect_type int(11) NOT NULL,
  effect_value_1 int(11) NOT NULL,
  effect_value_2 int(11) NOT NULL,
  effect_value_3 int(11) NOT NULL,
  effect_value_4 int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 156,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `single_mode_cook_garden_effect_0_effect_group_id` on table `single_mode_cook_garden_effect`
--
ALTER TABLE single_mode_cook_garden_effect
ADD INDEX single_mode_cook_garden_effect_0_effect_group_id (effect_group_id);

--
-- Create table `single_mode_cook_garden_bg`
--
CREATE TABLE single_mode_cook_garden_bg (
  id int(11) NOT NULL,
  month int(11) NOT NULL,
  half_type int(11) NOT NULL,
  progress int(11) NOT NULL,
  bg_id int(11) NOT NULL,
  sub_bg_id int(11) NOT NULL,
  mini_motion_group_id_min int(11) NOT NULL,
  mini_motion_group_id_max int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 409,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `single_mode_cook_garden_bg_0_bg_id` on table `single_mode_cook_garden_bg`
--
ALTER TABLE single_mode_cook_garden_bg
ADD INDEX single_mode_cook_garden_bg_0_bg_id (bg_id);

--
-- Create index `single_mode_cook_garden_bg_0_month_1_half_type` on table `single_mode_cook_garden_bg`
--
ALTER TABLE single_mode_cook_garden_bg
ADD INDEX single_mode_cook_garden_bg_0_month_1_half_type (month, half_type);

--
-- Create table `single_mode_cook_garden`
--
CREATE TABLE single_mode_cook_garden (
  facility_id int(11) NOT NULL,
  PRIMARY KEY (facility_id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 3276,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `single_mode_cook_dish_name`
--
CREATE TABLE single_mode_cook_dish_name (
  id int(11) NOT NULL,
  dish_group_id int(11) NOT NULL,
  effect_group_id int(11) NOT NULL,
  great_success_flag int(11) NOT NULL,
  chara_id int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 528,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `single_mode_cook_dish_name_0_dish_group_id` on table `single_mode_cook_dish_name`
--
ALTER TABLE single_mode_cook_dish_name
ADD INDEX single_mode_cook_dish_name_0_dish_group_id (dish_group_id);

--
-- Create table `single_mode_cook_dish_material`
--
CREATE TABLE single_mode_cook_dish_material (
  id int(11) NOT NULL,
  material_group_id int(11) NOT NULL,
  material_id int(11) NOT NULL,
  material_num int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 431,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `single_mode_cook_dish_material_0_material_group_id` on table `single_mode_cook_dish_material`
--
ALTER TABLE single_mode_cook_dish_material
ADD INDEX single_mode_cook_dish_material_0_material_group_id (material_group_id);

--
-- Create table `single_mode_cook_dish_icon`
--
CREATE TABLE single_mode_cook_dish_icon (
  dish_group_id int(11) NOT NULL,
  icon_id int(11) NOT NULL,
  PRIMARY KEY (dish_group_id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1260,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `single_mode_cook_dish_effect`
--
CREATE TABLE single_mode_cook_dish_effect (
  id int(11) NOT NULL,
  effect_group_id int(11) NOT NULL,
  effect_type int(11) NOT NULL,
  effect_value_1 int(11) NOT NULL,
  effect_value_2 int(11) NOT NULL,
  effect_value_3 int(11) NOT NULL,
  effect_value_4 int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 237,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `single_mode_cook_dish_effect_0_effect_group_id` on table `single_mode_cook_dish_effect`
--
ALTER TABLE single_mode_cook_dish_effect
ADD INDEX single_mode_cook_dish_effect_0_effect_group_id (effect_group_id);

--
-- Create table `single_mode_cook_dish_cutt_se`
--
CREATE TABLE single_mode_cook_dish_cutt_se (
  id int(11) NOT NULL,
  command_group_id int(11) NOT NULL,
  chara_type int(11) NOT NULL,
  se_cue_name text NOT NULL,
  se_cuesheet_name text NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 248,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `single_mode_cook_dish_cutt_se_0_chara_type` on table `single_mode_cook_dish_cutt_se`
--
ALTER TABLE single_mode_cook_dish_cutt_se
ADD INDEX single_mode_cook_dish_cutt_se_0_chara_type (chara_type);

--
-- Create index `single_mode_cook_dish_cutt_se_0_chara_type_1_command_group_id` on table `single_mode_cook_dish_cutt_se`
--
ALTER TABLE single_mode_cook_dish_cutt_se
ADD INDEX single_mode_cook_dish_cutt_se_0_chara_type_1_command_group_id (chara_type, command_group_id);

--
-- Create index `single_mode_cook_dish_cutt_se_0_command_group_id` on table `single_mode_cook_dish_cutt_se`
--
ALTER TABLE single_mode_cook_dish_cutt_se
ADD INDEX single_mode_cook_dish_cutt_se_0_command_group_id (command_group_id);

--
-- Create table `single_mode_cook_dish_cutt`
--
CREATE TABLE single_mode_cook_dish_cutt (
  id int(11) NOT NULL,
  command_group_id int(11) NOT NULL,
  material_group_id int(11) NOT NULL,
  is_success int(11) NOT NULL,
  cutt_id text NOT NULL,
  prop_id text NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 297,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `single_mode_cook_dish_cutt_0_command_group_id` on table `single_mode_cook_dish_cutt`
--
ALTER TABLE single_mode_cook_dish_cutt
ADD INDEX single_mode_cook_dish_cutt_0_command_group_id (command_group_id);

--
-- Create index `single_mode_cook_dish_cutt_0_command_group_id_material_group_id` on table `single_mode_cook_dish_cutt`
--
ALTER TABLE single_mode_cook_dish_cutt
ADD INDEX single_mode_cook_dish_cutt_0_command_group_id_material_group_id (command_group_id, material_group_id);

--
-- Create index `single_mode_cook_dish_cutt_0_cutt_id` on table `single_mode_cook_dish_cutt`
--
ALTER TABLE single_mode_cook_dish_cutt
ADD INDEX single_mode_cook_dish_cutt_0_cutt_id (cutt_id (768));

--
-- Create index `single_mode_cook_dish_cutt_0_material_group_id` on table `single_mode_cook_dish_cutt`
--
ALTER TABLE single_mode_cook_dish_cutt
ADD INDEX single_mode_cook_dish_cutt_0_material_group_id (material_group_id);

--
-- Create table `single_mode_cook_dish`
--
CREATE TABLE single_mode_cook_dish (
  id int(11) NOT NULL,
  dish_set_id int(11) NOT NULL,
  dish_group_id int(11) NOT NULL,
  priority int(11) NOT NULL,
  material_group_id int(11) NOT NULL,
  effect_group_id int(11) NOT NULL,
  success_effect_group_id int(11) NOT NULL,
  gain_coin int(11) NOT NULL,
  gain_power int(11) NOT NULL,
  sort_order int(11) NOT NULL,
  dish_type int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 468,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `single_mode_cook_cooking_type`
--
CREATE TABLE single_mode_cook_cooking_type (
  id int(11) NOT NULL,
  cooking_motion_id int(11) NOT NULL,
  swap_type int(11) NOT NULL,
  cooking_motion_swap_id int(11) NOT NULL,
  cooking_effect_name_1 text NOT NULL,
  cooking_effect_position_1 int(11) NOT NULL,
  cooking_effect_name_2 text NOT NULL,
  cooking_effect_position_2 int(11) NOT NULL,
  cooking_effect_swap_name_1 text NOT NULL,
  cooking_effect_swap_position_1 int(11) NOT NULL,
  cooking_effect_swap_name_2 text NOT NULL,
  cooking_effect_swap_position_2 int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 390,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `single_mode_cook_cooking_type_0_cooking_motion_id` on table `single_mode_cook_cooking_type`
--
ALTER TABLE single_mode_cook_cooking_type
ADD INDEX single_mode_cook_cooking_type_0_cooking_motion_id (cooking_motion_id);

--
-- Create index `single_mode_cook_cooking_type_0_cooking_motion_id_1_swap_type` on table `single_mode_cook_cooking_type`
--
ALTER TABLE single_mode_cook_cooking_type
ADD INDEX single_mode_cook_cooking_type_0_cooking_motion_id_1_swap_type (cooking_motion_id, swap_type);

--
-- Create table `single_mode_cook_cooking_rate`
--
CREATE TABLE single_mode_cook_cooking_rate (
  id int(11) NOT NULL,
  dish_type int(11) NOT NULL,
  cooking_cutt_id int(11) NOT NULL,
  cooking_num int(11) NOT NULL,
  success_rate int(11) NOT NULL,
  great_success_rate int(11) NOT NULL,
  confirmed_great_success_rate int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 146,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `single_mode_cook_cooking_rate_0_dish_type` on table `single_mode_cook_cooking_rate`
--
ALTER TABLE single_mode_cook_cooking_rate
ADD INDEX single_mode_cook_cooking_rate_0_dish_type (dish_type);

--
-- Create table `single_mode_cook_cooking_cutt`
--
CREATE TABLE single_mode_cook_cooking_cutt (
  id int(11) NOT NULL,
  cooking_num int(11) NOT NULL,
  cooking_motion_id_1 int(11) NOT NULL,
  cooking_motion_id_2 int(11) NOT NULL,
  cooking_motion_id_3 int(11) NOT NULL,
  cooking_motion_id_4 int(11) NOT NULL,
  success_motion_id int(11) NOT NULL,
  camera text NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 277,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `single_mode_cook_cooking_cutt_0_cooking_num` on table `single_mode_cook_cooking_cutt`
--
ALTER TABLE single_mode_cook_cooking_cutt
ADD INDEX single_mode_cook_cooking_cutt_0_cooking_num (cooking_num);

--
-- Create table `single_mode_cook_coin_rate`
--
CREATE TABLE single_mode_cook_coin_rate (
  id int(11) NOT NULL,
  period int(11) NOT NULL,
  material_count int(11) NOT NULL,
  coin_quantity_rate int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1820,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `single_mode_cook_coin_rate_0_material_count_1_period` on table `single_mode_cook_coin_rate`
--
ALTER TABLE single_mode_cook_coin_rate
ADD INDEX single_mode_cook_coin_rate_0_material_count_1_period (material_count, period);

--
-- Create table `single_mode_conclusion_set`
--
CREATE TABLE single_mode_conclusion_set (
  story_id int(11) NOT NULL,
  root_id int(11) NOT NULL,
  conclusion_id int(11) NOT NULL
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 90,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `single_mode_conclusion_set_0_story_id` on table `single_mode_conclusion_set`
--
ALTER TABLE single_mode_conclusion_set
ADD INDEX single_mode_conclusion_set_0_story_id (story_id);

--
-- Create table `single_mode_chara_program`
--
CREATE TABLE single_mode_chara_program (
  id int(11) NOT NULL,
  chara_id int(11) NOT NULL,
  program_group int(11) NOT NULL,
  program_group_2 int(11) NOT NULL,
  base_id int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 92,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `single_mode_chara_program_0_chara_id` on table `single_mode_chara_program`
--
ALTER TABLE single_mode_chara_program
ADD INDEX single_mode_chara_program_0_chara_id (chara_id);

--
-- Create table `single_mode_chara_grade`
--
CREATE TABLE single_mode_chara_grade (
  id int(11) NOT NULL,
  win_num int(11) NOT NULL,
  run_num int(11) NOT NULL,
  need_fan_count int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1638,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `single_mode_chara_effect_buff`
--
CREATE TABLE single_mode_chara_effect_buff (
  id int(11) NOT NULL,
  chara_id int(11) NOT NULL,
  effect_id int(11) NOT NULL,
  turn int(11) NOT NULL,
  program_id int(11) NOT NULL,
  speed_add int(11) NOT NULL,
  stamina_add int(11) NOT NULL,
  power_add int(11) NOT NULL,
  guts_add int(11) NOT NULL,
  wiz_add int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `single_mode_chara_effect_buff_0_chara_id` on table `single_mode_chara_effect_buff`
--
ALTER TABLE single_mode_chara_effect_buff
ADD INDEX single_mode_chara_effect_buff_0_chara_id (chara_id);

--
-- Create table `single_mode_chara_effect`
--
CREATE TABLE single_mode_chara_effect (
  id int(11) NOT NULL,
  effect_type int(11) NOT NULL,
  effect_category int(11) NOT NULL,
  effect_group_id int(11) NOT NULL,
  priority int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 819,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `single_mode_change_chara_route`
--
CREATE TABLE single_mode_change_chara_route (
  id int(11) NOT NULL,
  route_race_group_id int(11) NOT NULL,
  chara_id int(11) NOT NULL,
  route_race_id int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 321,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `single_mode_change_chara_route_0_route_race_group_id_1_chara_id` on table `single_mode_change_chara_route`
--
ALTER TABLE single_mode_change_chara_route
ADD INDEX single_mode_change_chara_route_0_route_race_group_id_1_chara_id (route_race_group_id, chara_id);

--
-- Create table `single_mode_arc_win_pt`
--
CREATE TABLE single_mode_arc_win_pt (
  id int(11) NOT NULL,
  race_instance_id int(11) NOT NULL,
  grade int(11) NOT NULL,
  order_min int(11) NOT NULL,
  order_max int(11) NOT NULL,
  point_num int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 134,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `single_mode_arc_win_pt_0_grade` on table `single_mode_arc_win_pt`
--
ALTER TABLE single_mode_arc_win_pt
ADD INDEX single_mode_arc_win_pt_0_grade (grade);

--
-- Create index `single_mode_arc_win_pt_0_race_instance_id` on table `single_mode_arc_win_pt`
--
ALTER TABLE single_mode_arc_win_pt
ADD INDEX single_mode_arc_win_pt_0_race_instance_id (race_instance_id);

--
-- Create table `single_mode_arc_training_eff`
--
CREATE TABLE single_mode_arc_training_eff (
  id int(11) NOT NULL,
  require_pt_min int(11) NOT NULL,
  require_pt_max int(11) NOT NULL,
  training_eff int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 528,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `single_mode_arc_taiman_peff_grp`
--
CREATE TABLE single_mode_arc_taiman_peff_grp (
  id int(11) NOT NULL,
  icon_id int(11) NOT NULL,
  sub_id int(11) NOT NULL,
  effect_id_1 int(11) NOT NULL,
  effect_id_2 int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1365,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `single_mode_arc_schedule`
--
CREATE TABLE single_mode_arc_schedule (
  id int(11) NOT NULL,
  race_program_id int(11) NOT NULL,
  turn_num int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 4096,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `single_mode_arc_schedule_0_race_program_id` on table `single_mode_arc_schedule`
--
ALTER TABLE single_mode_arc_schedule
ADD INDEX single_mode_arc_schedule_0_race_program_id (race_program_id);

--
-- Create table `single_mode_arc_race_debuff`
--
CREATE TABLE single_mode_arc_race_debuff (
  id int(11) NOT NULL,
  race_instance_id int(11) NOT NULL,
  debuff_id int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 341,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `single_mode_arc_race_debuff_0_debuff_id` on table `single_mode_arc_race_debuff`
--
ALTER TABLE single_mode_arc_race_debuff
ADD INDEX single_mode_arc_race_debuff_0_debuff_id (debuff_id);

--
-- Create index `single_mode_arc_race_debuff_0_race_instance_id` on table `single_mode_arc_race_debuff`
--
ALTER TABLE single_mode_arc_race_debuff
ADD INDEX single_mode_arc_race_debuff_0_race_instance_id (race_instance_id);

--
-- Create table `single_mode_arc_potential_level`
--
CREATE TABLE single_mode_arc_potential_level (
  id int(11) NOT NULL,
  potential_id int(11) NOT NULL,
  potential_lv int(11) NOT NULL,
  global_exp int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 910,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `single_mode_arc_potential_level_0_potential_id` on table `single_mode_arc_potential_level`
--
ALTER TABLE single_mode_arc_potential_level
ADD INDEX single_mode_arc_potential_level_0_potential_id (potential_id);

--
-- Create table `single_mode_arc_potential_cond`
--
CREATE TABLE single_mode_arc_potential_cond (
  id int(11) NOT NULL,
  potential_id int(11) NOT NULL,
  num int(11) NOT NULL,
  count_type int(11) NOT NULL,
  display_total_count int(11) NOT NULL,
  condition_type_1 int(11) NOT NULL,
  condition_value_1 int(11) NOT NULL,
  condition_value_2 int(11) NOT NULL,
  condition_value_3 int(11) NOT NULL,
  condition_value_4 int(11) NOT NULL,
  condition_value_5 int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1260,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `single_mode_arc_potential_cond_0_potential_id` on table `single_mode_arc_potential_cond`
--
ALTER TABLE single_mode_arc_potential_cond
ADD INDEX single_mode_arc_potential_cond_0_potential_id (potential_id);

--
-- Create table `single_mode_arc_potential_buff`
--
CREATE TABLE single_mode_arc_potential_buff (
  id int(11) NOT NULL,
  potential_id int(11) NOT NULL,
  potential_lv int(11) NOT NULL,
  speed int(11) NOT NULL,
  stamina int(11) NOT NULL,
  power int(11) NOT NULL,
  guts int(11) NOT NULL,
  wiz int(11) NOT NULL,
  turf int(11) NOT NULL,
  middle int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 2048,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `single_mode_arc_potential_buff_0_potential_id` on table `single_mode_arc_potential_buff`
--
ALTER TABLE single_mode_arc_potential_buff
ADD INDEX single_mode_arc_potential_buff_0_potential_id (potential_id);

--
-- Create index `single_mode_arc_potential_buff_0_potential_id_1_potential_lv` on table `single_mode_arc_potential_buff`
--
ALTER TABLE single_mode_arc_potential_buff
ADD INDEX single_mode_arc_potential_buff_0_potential_id_1_potential_lv (potential_id, potential_lv);

--
-- Create table `single_mode_arc_potential_bonus`
--
CREATE TABLE single_mode_arc_potential_bonus (
  id int(11) NOT NULL,
  potential_id int(11) NOT NULL,
  potential_lv int(11) NOT NULL,
  effect_type int(11) NOT NULL,
  effect_value_1 int(11) NOT NULL,
  effect_value_2 int(11) NOT NULL,
  effect_value_3 int(11) NOT NULL,
  effect_value_4 int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 862,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `single_mode_arc_potential_bonus_0_potential_id` on table `single_mode_arc_potential_bonus`
--
ALTER TABLE single_mode_arc_potential_bonus
ADD INDEX single_mode_arc_potential_bonus_0_potential_id (potential_id);

--
-- Create index `single_mode_arc_potential_bonus_0_potential_id_1_potential_lv` on table `single_mode_arc_potential_bonus`
--
ALTER TABLE single_mode_arc_potential_bonus
ADD INDEX single_mode_arc_potential_bonus_0_potential_id_1_potential_lv (potential_id, potential_lv);

--
-- Create table `single_mode_arc_potential`
--
CREATE TABLE single_mode_arc_potential (
  id INT(11) NOT NULL,
  row INT(11) NOT NULL,
  queue INT(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1638,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `single_mode_arc_debuff`
--
CREATE TABLE single_mode_arc_debuff (
  id int(11) NOT NULL,
  potential_id int(11) NOT NULL,
  potential_lv int(11) NOT NULL,
  speed int(11) NOT NULL,
  stamina int(11) NOT NULL,
  power int(11) NOT NULL,
  guts int(11) NOT NULL,
  wiz int(11) NOT NULL,
  turf int(11) NOT NULL,
  middle int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1820,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `single_mode_arc_debuff_0_potential_id` on table `single_mode_arc_debuff`
--
ALTER TABLE single_mode_arc_debuff
ADD INDEX single_mode_arc_debuff_0_potential_id (potential_id);

--
-- Create index `single_mode_arc_debuff_0_potential_id_1_potential_lv` on table `single_mode_arc_debuff`
--
ALTER TABLE single_mode_arc_debuff
ADD INDEX single_mode_arc_debuff_0_potential_id_1_potential_lv (potential_id, potential_lv);

--
-- Create table `single_mode_ao_offset`
--
CREATE TABLE single_mode_ao_offset (
  id int(11) NOT NULL,
  offset_1 int(11) NOT NULL,
  offset_2 int(11) NOT NULL,
  offset_3 int(11) NOT NULL,
  offset_4 int(11) NOT NULL,
  offset_5 int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 3276,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `single_mode_aoharu_schedule`
--
CREATE TABLE single_mode_aoharu_schedule (
  id int(11) NOT NULL,
  turn_num int(11) NOT NULL,
  notice_turn_1 int(11) NOT NULL,
  notice_turn_2 int(11) NOT NULL,
  notice_turn_3 int(11) NOT NULL,
  notice_turn_4 int(11) NOT NULL,
  notice_turn_5 int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 3276,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `single_mode_aoharu_result_cutt`
--
CREATE TABLE single_mode_aoharu_result_cutt (
  id int(11) NOT NULL,
  chara_id int(11) NOT NULL,
  cutt_id int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 4096,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `single_mode_aoharu_result_cutt_0_chara_id` on table `single_mode_aoharu_result_cutt`
--
ALTER TABLE single_mode_aoharu_result_cutt
ADD INDEX single_mode_aoharu_result_cutt_0_chara_id (chara_id);

--
-- Create table `single_mode_aoharu_cutt_type`
--
CREATE TABLE single_mode_aoharu_cutt_type (
  id int(11) NOT NULL,
  cutt_type int(11) NOT NULL,
  cutt_id int(11) NOT NULL,
  chara_type int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 682,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `single_mode_aoharu_cutt_type_0_chara_type` on table `single_mode_aoharu_cutt_type`
--
ALTER TABLE single_mode_aoharu_cutt_type
ADD INDEX single_mode_aoharu_cutt_type_0_chara_type (chara_type);

--
-- Create index `single_mode_aoharu_cutt_type_0_chara_type_1_cutt_type` on table `single_mode_aoharu_cutt_type`
--
ALTER TABLE single_mode_aoharu_cutt_type
ADD INDEX single_mode_aoharu_cutt_type_0_chara_type_1_cutt_type (chara_type, cutt_type);

--
-- Create index `single_mode_aoharu_cutt_type_0_cutt_type` on table `single_mode_aoharu_cutt_type`
--
ALTER TABLE single_mode_aoharu_cutt_type
ADD INDEX single_mode_aoharu_cutt_type_0_cutt_type (cutt_type);

--
-- Create table `single_mode_analyze_ticket`
--
CREATE TABLE single_mode_analyze_ticket (
  id int(11) NOT NULL,
  grade int(11) NOT NULL,
  cost_ticket int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 2340,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `single_mode_analyze_ticket_0_grade` on table `single_mode_analyze_ticket`
--
ALTER TABLE single_mode_analyze_ticket
ADD INDEX single_mode_analyze_ticket_0_grade (grade);

--
-- Create table `single_mode_analyze_message`
--
CREATE TABLE single_mode_analyze_message (
  id int(11) NOT NULL,
  proper_ground int(11) NOT NULL,
  proper_distance int(11) NOT NULL,
  popularity int(11) NOT NULL,
  year int(11) NOT NULL,
  priority int(11) NOT NULL,
  rate int(11) NOT NULL,
  motion_type int(11) NOT NULL,
  character_type int(11) NOT NULL,
  condition_set int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 309,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `single_mode_analyze_message_0_popularity` on table `single_mode_analyze_message`
--
ALTER TABLE single_mode_analyze_message
ADD INDEX single_mode_analyze_message_0_popularity (popularity);

--
-- Create table `single_mode_analyze_condition`
--
CREATE TABLE single_mode_analyze_condition (
  id int(11) NOT NULL,
  scenario_id int(11) NOT NULL,
  condition_type int(11) NOT NULL,
  condition_value_1 int(11) NOT NULL,
  condition_value_2 int(11) NOT NULL,
  condition_value_3 int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 3276,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `single_mode_09_training_boost`
--
CREATE TABLE single_mode_09_training_boost (
  id int(11) NOT NULL,
  boost_set_id int(11) NOT NULL,
  level_min int(11) NOT NULL,
  level_max int(11) NOT NULL,
  add_value int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 303,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `single_mode_09_training_boost_0_boost_set_id` on table `single_mode_09_training_boost`
--
ALTER TABLE single_mode_09_training_boost
ADD INDEX single_mode_09_training_boost_0_boost_set_id (boost_set_id);

--
-- Create table `single_mode_09_schedule`
--
CREATE TABLE single_mode_09_schedule (
  id int(11) NOT NULL,
  turn_num int(11) NOT NULL,
  target_pt int(11) NOT NULL,
  stock_num int(11) NOT NULL,
  dress_id int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 3276,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `single_mode_09_progress_rate`
--
CREATE TABLE single_mode_09_progress_rate (
  id int(11) NOT NULL,
  progress_min int(11) NOT NULL,
  progress_max int(11) NOT NULL,
  result_type int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 5461,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `single_mode_09_link_effect`
--
CREATE TABLE single_mode_09_link_effect (
  id int(11) NOT NULL,
  chara_id int(11) NOT NULL,
  effect_type int(11) NOT NULL,
  effect_value_1 int(11) NOT NULL,
  effect_value_2 int(11) NOT NULL,
  effect_value_3 int(11) NOT NULL,
  effect_value_4 int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1260,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `single_mode_09_link_effect_0_chara_id` on table `single_mode_09_link_effect`
--
ALTER TABLE single_mode_09_link_effect
ADD INDEX single_mode_09_link_effect_0_chara_id (chara_id);

--
-- Create table `single_mode_09_learning_bonus`
--
CREATE TABLE single_mode_09_learning_bonus (
  id int(11) NOT NULL,
  point_min int(11) NOT NULL,
  point_max int(11) NOT NULL,
  base_value int(11) NOT NULL,
  bonus_value int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 8192,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `single_mode_09_chip_effect`
--
CREATE TABLE single_mode_09_chip_effect (
  id int(11) NOT NULL,
  chip_id int(11) NOT NULL,
  point int(11) NOT NULL,
  group_id int(11) NOT NULL,
  effect_category int(11) NOT NULL,
  effect_type int(11) NOT NULL,
  effect_value_1 int(11) NOT NULL,
  effect_value_2 int(11) NOT NULL,
  effect_value_3 int(11) NOT NULL,
  effect_value_4 int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 234,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `single_mode_09_chip_effect_0_chip_id` on table `single_mode_09_chip_effect`
--
ALTER TABLE single_mode_09_chip_effect
ADD INDEX single_mode_09_chip_effect_0_chip_id (chip_id);

--
-- Create table `single_mode_09_chip`
--
CREATE TABLE single_mode_09_chip (
  id int(11) NOT NULL,
  schedule_id int(11) NOT NULL,
  type int(11) NOT NULL,
  board_id int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1260,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `single_mode_09_chip_0_board_id` on table `single_mode_09_chip`
--
ALTER TABLE single_mode_09_chip
ADD INDEX single_mode_09_chip_0_board_id (board_id);

--
-- Create table `single_mode_09_board`
--
CREATE TABLE single_mode_09_board (
  id int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 5461,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `short_episode`
--
CREATE TABLE short_episode (
  id int(11) NOT NULL,
  scene int(11) NOT NULL,
  sort int(11) NOT NULL,
  condition_type int(11) NOT NULL,
  condition_value_1 int(11) NOT NULL,
  story_id int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 2048,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `short_episode_0_scene` on table `short_episode`
--
ALTER TABLE short_episode
ADD INDEX short_episode_0_scene (scene);

--
-- Create table `select_pickup`
--
CREATE TABLE select_pickup (
  id int(11) NOT NULL,
  gacha_id int(11) NOT NULL,
  card_id int(11) NOT NULL,
  card_type int(11) NOT NULL,
  recommend_order int(11) NOT NULL,
  recommend_type int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 121,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `select_pickup_0_gacha_id` on table `select_pickup`
--
ALTER TABLE select_pickup
ADD INDEX select_pickup_0_gacha_id (gacha_id);

--
-- Create table `season_data`
--
CREATE TABLE season_data (
  id int(11) NOT NULL,
  type int(11) NOT NULL,
  season int(11) NOT NULL,
  priority int(11) NOT NULL,
  start_date text NOT NULL,
  end_date text NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 585,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `season_data_0_type` on table `season_data`
--
ALTER TABLE season_data
ADD INDEX season_data_0_type (type);

--
-- Create table `room_match_training_rank`
--
CREATE TABLE room_match_training_rank (
  id INT(11) NOT NULL,
  rank INT(11) NOT NULL,
  rule_line INT(11) NOT NULL,
  start_date TEXT NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 186,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `room_match_training_rank_0_rank` on table `room_match_training_rank`
--
ALTER TABLE room_match_training_rank
ADD INDEX room_match_training_rank_0_rank (`rank`);

--
-- Create table `rating_race_weekend_reward`
--
CREATE TABLE rating_race_weekend_reward (
  id int(11) NOT NULL,
  rating_race_data_id int(11) NOT NULL,
  rating_rank int(11) NOT NULL,
  weekend_reward_point int(11) NOT NULL,
  reward_group_id int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1820,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `rating_race_weekend_reward_0_rating_race_data_id` on table `rating_race_weekend_reward`
--
ALTER TABLE rating_race_weekend_reward
ADD INDEX rating_race_weekend_reward_0_rating_race_data_id (rating_race_data_id);

--
-- Create index `rating_race_weekend_reward_0_rating_race_data_id_1_rating_rank` on table `rating_race_weekend_reward`
--
ALTER TABLE rating_race_weekend_reward
ADD INDEX rating_race_weekend_reward_0_rating_race_data_id_1_rating_rank (rating_race_data_id, rating_rank);

--
-- Create table `rating_race_reward_group`
--
CREATE TABLE rating_race_reward_group (
  id int(11) NOT NULL,
  reward_group_id int(11) NOT NULL,
  item_category int(11) NOT NULL,
  item_id int(11) NOT NULL,
  item_num int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 94,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `rating_race_reward_group_0_reward_group_id` on table `rating_race_reward_group`
--
ALTER TABLE rating_race_reward_group
ADD INDEX rating_race_reward_group_0_reward_group_id (reward_group_id);

--
-- Create table `rating_race_rating_rank`
--
CREATE TABLE rating_race_rating_rank (
  id int(11) NOT NULL,
  rating_race_data_id int(11) NOT NULL,
  rating_rank int(11) NOT NULL,
  rating_score_min int(11) NOT NULL,
  rating_score_max int(11) NOT NULL,
  downgrade_permitted int(11) NOT NULL,
  npc_count int(11) NOT NULL,
  reward_group_id int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1638,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `rating_race_rating_rank_0_rating_race_data_id` on table `rating_race_rating_rank`
--
ALTER TABLE rating_race_rating_rank
ADD INDEX rating_race_rating_rank_0_rating_race_data_id (rating_race_data_id);

--
-- Create table `rating_race_phase_schedule`
--
CREATE TABLE rating_race_phase_schedule (
  id int(11) NOT NULL,
  rating_race_data_id int(11) NOT NULL,
  week int(11) NOT NULL,
  phase int(11) NOT NULL,
  rating_race_condition_id_short int(11) NOT NULL,
  rating_race_condition_id_mile int(11) NOT NULL,
  rating_race_condition_id_middle int(11) NOT NULL,
  rating_race_condition_id_long int(11) NOT NULL,
  rating_race_condition_id_dirt int(11) NOT NULL,
  start_date int(11) NOT NULL,
  end_date int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 2048,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `rating_race_phase_schedule_0_rating_race_data_id` on table `rating_race_phase_schedule`
--
ALTER TABLE rating_race_phase_schedule
ADD INDEX rating_race_phase_schedule_0_rating_race_data_id (rating_race_data_id);

--
-- Create table `rating_race_finale_reward`
--
CREATE TABLE rating_race_finale_reward (
  id int(11) NOT NULL,
  rating_race_data_id int(11) NOT NULL,
  rating_rank int(11) NOT NULL,
  finish_order int(11) NOT NULL,
  reward_group_id int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 151,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `rating_race_finale_reward_0_rating_race_data_id` on table `rating_race_finale_reward`
--
ALTER TABLE rating_race_finale_reward
ADD INDEX rating_race_finale_reward_0_rating_race_data_id (rating_race_data_id);

--
-- Create table `rating_race_data`
--
CREATE TABLE rating_race_data (
  id int(11) NOT NULL,
  notice_date int(11) NOT NULL,
  start_date int(11) NOT NULL,
  end_date int(11) NOT NULL,
  weekday_free_play_num int(11) NOT NULL,
  weekend_free_play_num int(11) NOT NULL,
  rating_rank_initial_limit int(11) NOT NULL,
  rating_rank_reset_limit int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `rating_race_condition`
--
CREATE TABLE rating_race_condition (
  id int(11) NOT NULL,
  race_instance_id int(11) NOT NULL,
  season int(11) NOT NULL,
  weather int(11) NOT NULL,
  ground int(11) NOT NULL,
  bg_id int(11) NOT NULL,
  bg_sub_id int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 655,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `random_ear_tail_motion`
--
CREATE TABLE random_ear_tail_motion (
  id int(11) NOT NULL,
  parts_type int(11) NOT NULL,
  motion_name text NOT NULL,
  ear_type int(11) NOT NULL,
  use_story int(11) NOT NULL,
  use_theater int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 606,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `random_ear_tail_motion_0_parts_type` on table `random_ear_tail_motion`
--
ALTER TABLE random_ear_tail_motion
ADD INDEX random_ear_tail_motion_0_parts_type (parts_type);

--
-- Create table `race_trophy`
--
CREATE TABLE race_trophy (
  id int(11) NOT NULL,
  trophy_id int(11) NOT NULL,
  race_instance_id int(11) NOT NULL,
  original_flag int(11) NOT NULL,
  disp_order int(11) NOT NULL,
  size int(11) NOT NULL,
  event_type int(11) NOT NULL,
  start_date text NOT NULL,
  display_end_date text NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 193,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `race_trophy_0_race_instance_id` on table `race_trophy`
--
ALTER TABLE race_trophy
ADD UNIQUE INDEX race_trophy_0_race_instance_id (race_instance_id);

--
-- Create index `race_trophy_0_trophy_id` on table `race_trophy`
--
ALTER TABLE race_trophy
ADD INDEX race_trophy_0_trophy_id (trophy_id);

--
-- Create table `race_track`
--
CREATE TABLE race_track (
  id int(11) NOT NULL,
  initial_lane_type int(11) NOT NULL,
  enable_half_gate int(11) NOT NULL,
  horse_num_gate_variation int(11) NOT NULL,
  turf_vision_type int(11) NOT NULL,
  footsmoke_color_type int(11) NOT NULL,
  area int(11) NOT NULL,
  flag_type int(11) NOT NULL,
  gate_panel_type int(11) NOT NULL,
  gate_lamp_type int(11) NOT NULL,
  board_condition_type int(11) NOT NULL,
  result_board_type int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1489,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `race_single_mode_team_status`
--
CREATE TABLE race_single_mode_team_status (
  id int(11) NOT NULL,
  team_rank_threshold int(11) NOT NULL,
  add_status int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 2730,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `race_proper_runningstyle_rate`
--
CREATE TABLE race_proper_runningstyle_rate (
  id int(11) NOT NULL,
  proper_rate int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1820,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `race_proper_ground_rate`
--
CREATE TABLE race_proper_ground_rate (
  id int(11) NOT NULL,
  proper_rate int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1820,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `race_proper_distance_rate`
--
CREATE TABLE race_proper_distance_rate (
  id int(11) NOT NULL,
  proper_rate_speed int(11) NOT NULL,
  proper_rate_power int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1820,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `race_player_camera`
--
CREATE TABLE race_player_camera (
  id int(11) NOT NULL,
  priority int(11) NOT NULL,
  prefab_name varchar(750) NOT NULL,
  category int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 168,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `race_player_camera_0_category` on table `race_player_camera`
--
ALTER TABLE race_player_camera
ADD INDEX race_player_camera_0_category (category);

--
-- Create index `race_player_camera_0_prefab_name` on table `race_player_camera`
--
ALTER TABLE race_player_camera
ADD INDEX race_player_camera_0_prefab_name (prefab_name);

--
-- Create table `race_overrun_pattern`
--
CREATE TABLE race_overrun_pattern (
  id int(11) NOT NULL,
  finish_order_0_type int(11) NOT NULL,
  finish_order_1_type int(11) NOT NULL,
  finish_order_2_type int(11) NOT NULL,
  finish_order_3_type int(11) NOT NULL,
  finish_order_4_type int(11) NOT NULL,
  finish_order_lose_type int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 3276,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `race_motivation_rate`
--
CREATE TABLE race_motivation_rate (
  id int(11) NOT NULL,
  motivation_rate int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 3276,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `race_jikkyo_trigger`
--
CREATE TABLE race_jikkyo_trigger (
  id int(11) NOT NULL,
  command int(11) NOT NULL,
  inequality int(11) NOT NULL,
  horse1 int(11) NOT NULL,
  horse2 int(11) NOT NULL,
  param1 int(11) NOT NULL,
  param2 int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 66,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `race_jikkyo_race`
--
CREATE TABLE race_jikkyo_race (
  id int(11) NOT NULL,
  cue_id int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 82,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `race_jikkyo_message`
--
CREATE TABLE race_jikkyo_message (
  id int(11) NOT NULL,
  group_id int(11) NOT NULL,
  message text NOT NULL,
  voice text NOT NULL,
  per int(11) NOT NULL,
  comment_group int(11) NOT NULL,
  reuse int(11) NOT NULL,
  omit_tag int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 171,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `race_jikkyo_message_0_comment_group` on table `race_jikkyo_message`
--
ALTER TABLE race_jikkyo_message
ADD INDEX race_jikkyo_message_0_comment_group (comment_group);

--
-- Create index `race_jikkyo_message_0_group_id` on table `race_jikkyo_message`
--
ALTER TABLE race_jikkyo_message
ADD INDEX race_jikkyo_message_0_group_id (group_id);

--
-- Create table `race_jikkyo_cue`
--
CREATE TABLE race_jikkyo_cue (
  id int(11) NOT NULL,
  cuesheet_id int(11) NOT NULL,
  cuesheet_type int(11) NOT NULL,
  condition_type_1 int(11) NOT NULL,
  condition_value_1 int(11) NOT NULL,
  condition_type_2 int(11) NOT NULL,
  condition_value_2 int(11) NOT NULL,
  condition_type_3 int(11) NOT NULL,
  condition_value_3 int(11) NOT NULL,
  cuesheet_name int(11) NOT NULL,
  PRIMARY KEY (id, cuesheet_type)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 57,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `race_jikkyo_cue_0_cuesheet_type` on table `race_jikkyo_cue`
--
ALTER TABLE race_jikkyo_cue
ADD INDEX race_jikkyo_cue_0_cuesheet_type (cuesheet_type);

--
-- Create table `race_jikkyo_comment`
--
CREATE TABLE race_jikkyo_comment (
  id int(11) NOT NULL,
  group_id int(11) NOT NULL,
  message text NOT NULL,
  voice text NOT NULL,
  per int(11) NOT NULL,
  message_group int(11) NOT NULL,
  omit_tag int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 257,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `race_jikkyo_comment_0_group_id` on table `race_jikkyo_comment`
--
ALTER TABLE race_jikkyo_comment
ADD INDEX race_jikkyo_comment_0_group_id (group_id);

--
-- Create table `race_jikkyo_base_venus`
--
CREATE TABLE race_jikkyo_base_venus (
  id int(11) NOT NULL,
  mode int(11) NOT NULL,
  sub_mode int(11) NOT NULL,
  sub_mode_jump int(11) NOT NULL,
  situation int(11) NOT NULL,
  sub_situation int(11) NOT NULL,
  situation_end int(11) NOT NULL,
  disable_reentry_situation int(11) NOT NULL,
  trigger0 int(11) NOT NULL,
  trigger1 int(11) NOT NULL,
  trigger2 int(11) NOT NULL,
  trigger3 int(11) NOT NULL,
  trigger4 int(11) NOT NULL,
  trigger5 int(11) NOT NULL,
  trigger6 int(11) NOT NULL,
  trigger7 int(11) NOT NULL,
  trigger8 int(11) NOT NULL,
  trigger9 int(11) NOT NULL,
  message_group int(11) NOT NULL,
  comment_group int(11) NOT NULL,
  priority int(11) NOT NULL,
  per int(11) NOT NULL,
  immediate int(11) NOT NULL,
  discard int(11) NOT NULL,
  tension int(11) NOT NULL,
  camera_id int(11) NOT NULL,
  camera_horse1 int(11) NOT NULL,
  camera_horse2 int(11) NOT NULL,
  disable_reuse int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 171,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `race_jikkyo_base_venus_0_mode` on table `race_jikkyo_base_venus`
--
ALTER TABLE race_jikkyo_base_venus
ADD INDEX race_jikkyo_base_venus_0_mode (mode);

--
-- Create table `race_jikkyo_base`
--
CREATE TABLE race_jikkyo_base (
  id int(11) NOT NULL,
  mode int(11) NOT NULL,
  sub_mode int(11) NOT NULL,
  sub_mode_jump int(11) NOT NULL,
  situation int(11) NOT NULL,
  sub_situation int(11) NOT NULL,
  situation_end int(11) NOT NULL,
  disable_reentry_situation int(11) NOT NULL,
  trigger0 int(11) NOT NULL,
  trigger1 int(11) NOT NULL,
  trigger2 int(11) NOT NULL,
  trigger3 int(11) NOT NULL,
  trigger4 int(11) NOT NULL,
  trigger5 int(11) NOT NULL,
  trigger6 int(11) NOT NULL,
  trigger7 int(11) NOT NULL,
  trigger8 int(11) NOT NULL,
  trigger9 int(11) NOT NULL,
  message_group int(11) NOT NULL,
  comment_group int(11) NOT NULL,
  priority int(11) NOT NULL,
  per int(11) NOT NULL,
  immediate int(11) NOT NULL,
  discard int(11) NOT NULL,
  tension int(11) NOT NULL,
  camera_id int(11) NOT NULL,
  camera_horse1 int(11) NOT NULL,
  camera_horse2 int(11) NOT NULL,
  disable_reuse int(11) NOT NULL,
  is_force_play_event_camera int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 416,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `race_jikkyo_base_0_mode` on table `race_jikkyo_base`
--
ALTER TABLE race_jikkyo_base
ADD INDEX race_jikkyo_base_0_mode (mode);

--
-- Create table `race_instance`
--
CREATE TABLE race_instance (
  id int(11) NOT NULL,
  race_id int(11) NOT NULL,
  npc_group_id int(11) NOT NULL,
  date int(11) NOT NULL,
  time int(11) NOT NULL,
  race_number int(11) NOT NULL,
  clock_time int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 68,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `race_instance_0_race_id` on table `race_instance`
--
ALTER TABLE race_instance
ADD INDEX race_instance_0_race_id (race_id);

--
-- Create table `race_fence_set`
--
CREATE TABLE race_fence_set (
  id int(11) NOT NULL,
  fence_1 int(11) NOT NULL,
  fence_2 int(11) NOT NULL,
  fence_3 int(11) NOT NULL,
  fence_4 int(11) NOT NULL,
  fence_5 int(11) NOT NULL,
  fence_6 int(11) NOT NULL,
  fence_7 int(11) NOT NULL,
  fence_8 int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 151,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `race_env_define`
--
CREATE TABLE race_env_define (
  id int(11) NOT NULL,
  race_track_id int(11) NOT NULL,
  season int(11) NOT NULL,
  weather int(11) NOT NULL,
  timezone int(11) NOT NULL,
  resource int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 74,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `race_env_define_0_race_track_id` on table `race_env_define`
--
ALTER TABLE race_env_define
ADD INDEX race_env_define_0_race_track_id (race_track_id);

--
-- Create table `race_course_set_status`
--
CREATE TABLE race_course_set_status (
  course_set_status_id int(11) NOT NULL,
  target_status_1 int(11) NOT NULL,
  target_status_2 int(11) NOT NULL,
  PRIMARY KEY (course_set_status_id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1820,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `race_course_set`
--
CREATE TABLE race_course_set (
  id int(11) NOT NULL,
  race_track_id int(11) NOT NULL,
  distance int(11) NOT NULL,
  ground int(11) NOT NULL,
  `inout` int(11) NOT NULL,
  turn int(11) NOT NULL,
  fence_set int(11) NOT NULL,
  float_lane_max int(11) NOT NULL,
  course_set_status_id int(11) NOT NULL,
  finish_time_min int(11) NOT NULL,
  finish_time_min_random_range int(11) NOT NULL,
  finish_time_max int(11) NOT NULL,
  finish_time_max_random_range int(11) NOT NULL,
  run_outside int(11) NOT NULL,
  ex_camera int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 153,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `race_course_set_0_race_track_id` on table `race_course_set`
--
ALTER TABLE race_course_set
ADD INDEX race_course_set_0_race_track_id (race_track_id);

--
-- Create table `race_condition`
--
CREATE TABLE race_condition (
  id int(11) NOT NULL,
  season int(11) NOT NULL,
  weather int(11) NOT NULL,
  ground int(11) NOT NULL,
  rate int(11) NOT NULL,
  area int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 512,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `race_condition_0_ground_1_weather` on table `race_condition`
--
ALTER TABLE race_condition
ADD INDEX race_condition_0_ground_1_weather (ground, weather);

--
-- Create index `race_condition_0_season_1_ground` on table `race_condition`
--
ALTER TABLE race_condition
ADD INDEX race_condition_0_season_1_ground (season, ground);

--
-- Create index `race_condition_0_season_1_weather` on table `race_condition`
--
ALTER TABLE race_condition
ADD INDEX race_condition_0_season_1_weather (season, weather);

--
-- Create index `race_condition_0_weather_1_ground` on table `race_condition`
--
ALTER TABLE race_condition
ADD INDEX race_condition_0_weather_1_ground (weather, ground);

--
-- Create table `race_bib_color`
--
CREATE TABLE race_bib_color (
  grade int(11) NOT NULL,
  race_id int(11) NOT NULL,
  bib_color int(11) NOT NULL,
  font_color int(11) NOT NULL,
  PRIMARY KEY (grade, race_id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 218,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `race_bgm_pattern`
--
CREATE TABLE race_bgm_pattern (
  id int(11) NOT NULL,
  bgm_time_1 int(11) NOT NULL,
  bgm_cue_name_1 text NOT NULL,
  bgm_cuesheet_name_1 text NOT NULL,
  bgm_time_2 int(11) NOT NULL,
  bgm_cue_name_2 text NOT NULL,
  bgm_cuesheet_name_2 text NOT NULL,
  bgm_time_3 int(11) NOT NULL,
  bgm_cue_name_3 text NOT NULL,
  bgm_cuesheet_name_3 text NOT NULL,
  bgm_time_4 int(11) NOT NULL,
  bgm_cue_name_4 text NOT NULL,
  bgm_cuesheet_name_4 text NOT NULL,
  bgm_time_5 int(11) NOT NULL,
  bgm_cue_name_5 text NOT NULL,
  bgm_cuesheet_name_5 text NOT NULL,
  bgm_time_6 int(11) NOT NULL,
  bgm_cue_name_6 text NOT NULL,
  bgm_cuesheet_name_6 text NOT NULL,
  bgm_time_7 int(11) NOT NULL,
  bgm_cue_name_7 text NOT NULL,
  bgm_cuesheet_name_7 text NOT NULL,
  bgm_time_8 int(11) NOT NULL,
  bgm_cue_name_8 text NOT NULL,
  bgm_cuesheet_name_8 text NOT NULL,
  bgm_time_9 int(11) NOT NULL,
  bgm_cue_name_9 text NOT NULL,
  bgm_cuesheet_name_9 text NOT NULL,
  bgm_time_10 int(11) NOT NULL,
  bgm_cue_name_10 text NOT NULL,
  bgm_cuesheet_name_10 text NOT NULL,
  bgm_time_11 int(11) NOT NULL,
  bgm_cue_name_11 text NOT NULL,
  bgm_cuesheet_name_11 text NOT NULL,
  bgm_time_12 int(11) NOT NULL,
  bgm_cue_name_12 text NOT NULL,
  bgm_cuesheet_name_12 text NOT NULL,
  bgm_time_13 int(11) NOT NULL,
  bgm_cue_name_13 text NOT NULL,
  bgm_cuesheet_name_13 text NOT NULL,
  bgm_time_14 int(11) NOT NULL,
  bgm_cue_name_14 text NOT NULL,
  bgm_cuesheet_name_14 text NOT NULL,
  bgm_time_15 int(11) NOT NULL,
  bgm_cue_name_15 text NOT NULL,
  bgm_cuesheet_name_15 text NOT NULL,
  bgm_time_16 int(11) NOT NULL,
  bgm_cue_name_16 text NOT NULL,
  bgm_cuesheet_name_16 text NOT NULL,
  bgm_time_17 int(11) NOT NULL,
  bgm_cue_name_17 text NOT NULL,
  bgm_cuesheet_name_17 text NOT NULL,
  bgm_time_18 int(11) NOT NULL,
  bgm_cue_name_18 text NOT NULL,
  bgm_cuesheet_name_18 text NOT NULL,
  bgm_time_19 int(11) NOT NULL,
  bgm_cue_name_19 text NOT NULL,
  bgm_cuesheet_name_19 text NOT NULL,
  bgm_time_20 int(11) NOT NULL,
  bgm_cue_name_20 text NOT NULL,
  bgm_cuesheet_name_20 text NOT NULL,
  bgm_time_21 int(11) NOT NULL,
  bgm_cue_name_21 text NOT NULL,
  bgm_cuesheet_name_21 text NOT NULL,
  bgm_time_22 int(11) NOT NULL,
  bgm_cue_name_22 text NOT NULL,
  bgm_cuesheet_name_22 text NOT NULL,
  bgm_time_23 int(11) NOT NULL,
  bgm_cue_name_23 text NOT NULL,
  bgm_cuesheet_name_23 text NOT NULL,
  bgm_time_24 int(11) NOT NULL,
  bgm_cue_name_24 text NOT NULL,
  bgm_cuesheet_name_24 text NOT NULL,
  bgm_time_25 int(11) NOT NULL,
  bgm_cue_name_25 text NOT NULL,
  bgm_cuesheet_name_25 text NOT NULL,
  bgm_time_26 int(11) NOT NULL,
  bgm_cue_name_26 text NOT NULL,
  bgm_cuesheet_name_26 text NOT NULL,
  bgm_time_27 int(11) NOT NULL,
  bgm_cue_name_27 text NOT NULL,
  bgm_cuesheet_name_27 text NOT NULL,
  bgm_time_28 int(11) NOT NULL,
  bgm_cue_name_28 text NOT NULL,
  bgm_cuesheet_name_28 text NOT NULL,
  bgm_time_29 int(11) NOT NULL,
  bgm_cue_name_29 text NOT NULL,
  bgm_cuesheet_name_29 text NOT NULL,
  bgm_time_30 int(11) NOT NULL,
  bgm_cue_name_30 text NOT NULL,
  bgm_cuesheet_name_30 text NOT NULL,
  bgm_trigger_time_ago int(11) NOT NULL,
  bgm_trigger_cue_name text NOT NULL,
  bgm_trigger_cuesheet_name text NOT NULL,
  bgm_skip_trigger_cue_name text NOT NULL,
  bgm_skip_trigger_cuesheet_name text NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 2114,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `race_bgm_cutin`
--
CREATE TABLE race_bgm_cutin (
  id int(11) NOT NULL,
  card_id int(11) NOT NULL,
  bgm_group_id int(11) NOT NULL,
  fadeout_time int(11) NOT NULL,
  exclusive_control int(11) NOT NULL,
  short_cutin_bgm_cue_name text NOT NULL,
  short_cutin_bgm_cuesheet_name text NOT NULL,
  long_cutin_bgm_cue_name text NOT NULL,
  long_cutin_bgm_cuesheet_name text NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 3276,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `race_bgm_cutin_0_bgm_group_id` on table `race_bgm_cutin`
--
ALTER TABLE race_bgm_cutin
ADD INDEX race_bgm_cutin_0_bgm_group_id (bgm_group_id);

--
-- Create index `race_bgm_cutin_0_card_id` on table `race_bgm_cutin`
--
ALTER TABLE race_bgm_cutin
ADD UNIQUE INDEX race_bgm_cutin_0_card_id (card_id);

--
-- Create index `race_bgm_cutin_0_card_id_1_bgm_group_id` on table `race_bgm_cutin`
--
ALTER TABLE race_bgm_cutin
ADD INDEX race_bgm_cutin_0_card_id_1_bgm_group_id (card_id, bgm_group_id);

--
-- Create table `race_bgm`
--
CREATE TABLE race_bgm (
  id int(11) NOT NULL,
  race_type int(11) NOT NULL,
  race_instance_id int(11) NOT NULL,
  grade int(11) NOT NULL,
  single_mode_route_race_id int(11) NOT NULL,
  single_mode_program_id int(11) NOT NULL,
  paddock_bgm_cue_name text NOT NULL,
  paddock_bgm_cuesheet_name text NOT NULL,
  entrytable_bgm_cue_name text NOT NULL,
  entrytable_bgm_cuesheet_name text NOT NULL,
  first_bgm_pattern int(11) NOT NULL,
  second_bgm_pattern int(11) NOT NULL,
  result_cutin_bgm_cue_name_1 text NOT NULL,
  result_cutin_bgm_cuesheet_name_1 text NOT NULL,
  result_cutin_bgm_cue_name_2 text NOT NULL,
  result_cutin_bgm_cuesheet_name_2 text NOT NULL,
  result_cutin_bgm_cue_name_3 text NOT NULL,
  result_cutin_bgm_cuesheet_name_3 text NOT NULL,
  result_list_bgm_cue_name_1 text NOT NULL,
  result_list_bgm_cuesheet_name_1 text NOT NULL,
  result_list_bgm_cue_name_2 text NOT NULL,
  result_list_bgm_cuesheet_name_2 text NOT NULL,
  result_list_bgm_cue_name_3 text NOT NULL,
  result_list_bgm_cuesheet_name_3 text NOT NULL,
  difficulty int(11) NOT NULL,
  condition_type int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 535,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `race_bgm_0_race_type` on table `race_bgm`
--
ALTER TABLE race_bgm
ADD INDEX race_bgm_0_race_type (race_type);

--
-- Create table `race`
--
CREATE TABLE race (
  id int(11) NOT NULL,
  `group` int(11) NOT NULL,
  grade int(11) NOT NULL,
  course_set int(11) NOT NULL,
  thumbnail_id int(11) NOT NULL,
  ff_cue_name text NOT NULL,
  ff_cuesheet_name text NOT NULL,
  ff_anim int(11) NOT NULL,
  ff_camera int(11) NOT NULL,
  ff_camera_sub int(11) NOT NULL,
  ff_sub int(11) NOT NULL,
  goal_gate int(11) NOT NULL,
  goal_flower int(11) NOT NULL,
  audience int(11) NOT NULL,
  entry_num int(11) NOT NULL,
  is_dirtgrade int(11) NOT NULL,
  start_date int(11) NOT NULL,
  start_gate int(11) NOT NULL,
  start_gate_panel int(11) NOT NULL,
  real_ff_cue_name text NOT NULL,
  real_ff_cuesheet_name text NOT NULL,
  result_podium int(11) NOT NULL,
  audience_group_id int(11) NOT NULL,
  paddock_bg_id int(11) NOT NULL,
  change_full_gate int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 134,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `race_0_course_set` on table `race`
--
ALTER TABLE race
ADD INDEX race_0_course_set (course_set);

--
-- Create index `race_0_group` on table `race`
--
ALTER TABLE race
ADD INDEX race_0_group (`group`);

--
-- Create table `price_change`
--
CREATE TABLE price_change (
  id int(11) NOT NULL,
  group_id int(11) NOT NULL,
  min_num int(11) NOT NULL,
  max_num int(11) NOT NULL,
  pay_item_num int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1820,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `price_change_0_group_id` on table `price_change`
--
ALTER TABLE price_change
ADD INDEX price_change_0_group_id (group_id);

--
-- Create table `piece_data`
--
CREATE TABLE piece_data (
  id int(11) NOT NULL,
  item_place_id int(11) NOT NULL,
  start_date text NOT NULL,
  end_date text NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 230,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `paid_gacha_button_type`
--
CREATE TABLE paid_gacha_button_type (
  id int(11) NOT NULL,
  gacha_count int(11) NOT NULL,
  paid_num int(11) NOT NULL,
  draw_guarantee_rarity int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `note_profile_text_type`
--
CREATE TABLE note_profile_text_type (
  id int(11) NOT NULL,
  text_type int(11) NOT NULL,
  text_category_id int(11) NOT NULL,
  sort int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 780,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `note_profile_text_type_0_text_type` on table `note_profile_text_type`
--
ALTER TABLE note_profile_text_type
ADD INDEX note_profile_text_type_0_text_type (text_type);

--
-- Create table `note_profile`
--
CREATE TABLE note_profile (
  id int(11) NOT NULL,
  chara_id int(11) NOT NULL,
  text_type int(11) NOT NULL,
  lock_type int(11) NOT NULL,
  lock_value int(11) NOT NULL,
  sort int(11) NOT NULL,
  secret_flg int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 564,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `note_profile_0_chara_id` on table `note_profile`
--
ALTER TABLE note_profile
ADD INDEX note_profile_0_chara_id (chara_id);

--
-- Create table `nickname`
--
CREATE TABLE nickname (
  id INT(11) NOT NULL,
  scenario_id INT(11) NOT NULL,
  disp_order INT(11) NOT NULL,
  group_id INT(11) NOT NULL,
  rank INT(11) NOT NULL,
  chara_data_id INT(11) NOT NULL,
  user_show INT(11) NOT NULL,
  receive_condition_type INT(11) NOT NULL,
  start_date INT(11) NOT NULL,
  end_date INT(11) NOT NULL,
  type INT(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 78,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `nickname_0_user_show` on table `nickname`
--
ALTER TABLE nickname
ADD INDEX nickname_0_user_show (user_show);

--
-- Create table `need_piece_num_data`
--
CREATE TABLE need_piece_num_data (
  id int(11) NOT NULL,
  rarity int(11) NOT NULL,
  piece_num int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 5461,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `need_piece_num_data_0_rarity` on table `need_piece_num_data`
--
ALTER TABLE need_piece_num_data
ADD UNIQUE INDEX need_piece_num_data_0_rarity (rarity);

--
-- Create table `name_card_bg`
--
CREATE TABLE name_card_bg (
  id int(11) NOT NULL,
  other_group int(11) NOT NULL,
  bg_group int(11) NOT NULL,
  time_group int(11) NOT NULL,
  bg_id int(11) NOT NULL,
  bg_sub int(11) NOT NULL,
  `order` int(11) NOT NULL,
  pos_x int(11) NOT NULL,
  pos_y int(11) NOT NULL,
  width int(11) NOT NULL,
  height int(11) NOT NULL,
  start_date int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 109,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `mob_hair_color_set`
--
CREATE TABLE mob_hair_color_set (
  id int(11) NOT NULL,
  hair_color_r1 text NOT NULL,
  hair_color_r2 text NOT NULL,
  hair_color_g1 text NOT NULL,
  hair_color_g2 text NOT NULL,
  hair_color_b1 text NOT NULL,
  hair_color_b2 text NOT NULL,
  hair_toon_color_r1 text NOT NULL,
  hair_toon_color_r2 text NOT NULL,
  hair_toon_color_g1 text NOT NULL,
  hair_toon_color_g2 text NOT NULL,
  hair_toon_color_b1 text NOT NULL,
  hair_toon_color_b2 text NOT NULL,
  mayu_color_r1 text NOT NULL,
  mayu_color_r2 text NOT NULL,
  mayu_color_g1 text NOT NULL,
  mayu_color_g2 text NOT NULL,
  mayu_color_b1 text NOT NULL,
  mayu_color_b2 text NOT NULL,
  mayu_toon_color_r1 text NOT NULL,
  mayu_toon_color_r2 text NOT NULL,
  mayu_toon_color_g1 text NOT NULL,
  mayu_toon_color_g2 text NOT NULL,
  mayu_toon_color_b1 text NOT NULL,
  mayu_toon_color_b2 text NOT NULL,
  eye_color_r1 text NOT NULL,
  eye_color_r2 text NOT NULL,
  eye_color_g1 text NOT NULL,
  eye_color_g2 text NOT NULL,
  eye_color_b1 text NOT NULL,
  eye_color_b2 text NOT NULL,
  tail_color_r1 text NOT NULL,
  tail_color_r2 text NOT NULL,
  tail_color_g1 text NOT NULL,
  tail_color_g2 text NOT NULL,
  tail_color_b1 text NOT NULL,
  tail_color_b2 text NOT NULL,
  tail_toon_color_r1 text NOT NULL,
  tail_toon_color_r2 text NOT NULL,
  tail_toon_color_g1 text NOT NULL,
  tail_toon_color_g2 text NOT NULL,
  tail_toon_color_b1 text NOT NULL,
  tail_toon_color_b2 text NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 736,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `mob_dress_color_set`
--
CREATE TABLE mob_dress_color_set (
  id int(11) NOT NULL,
  color_r1 text NOT NULL,
  color_r2 text NOT NULL,
  color_g1 text NOT NULL,
  color_g2 text NOT NULL,
  color_b1 text NOT NULL,
  color_b2 text NOT NULL,
  toon_color_r1 text NOT NULL,
  toon_color_r2 text NOT NULL,
  toon_color_g1 text NOT NULL,
  toon_color_g2 text NOT NULL,
  toon_color_b1 text NOT NULL,
  toon_color_b2 text NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 170,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `mob_data`
--
CREATE TABLE mob_data (
  mob_id int(11) NOT NULL,
  chara_face_model int(11) NOT NULL,
  chara_skin_color int(11) NOT NULL,
  chara_hair_model int(11) NOT NULL,
  chara_hair_color int(11) NOT NULL,
  chara_height int(11) NOT NULL,
  chara_bust_size int(11) NOT NULL,
  socks int(11) NOT NULL,
  default_personality int(11) NOT NULL,
  race_personality int(11) NOT NULL,
  race_running_type int(11) NOT NULL,
  sex int(11) NOT NULL,
  dress_id int(11) NOT NULL,
  dress_color_id int(11) NOT NULL,
  use_live int(11) NOT NULL,
  hair_cutoff int(11) NOT NULL,
  attachment_model_id int(11) NOT NULL,
  capture_type int(11) NOT NULL,
  mayu_visible_type int(11) NOT NULL,
  PRIMARY KEY (mob_id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 147,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `mission_race_scenario_group`
--
CREATE TABLE mission_race_scenario_group (
  id int(11) NOT NULL,
  scenario_id int(11) NOT NULL,
  race_instance_id int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 3276,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `mission_race_scenario_group_0_race_instance_id` on table `mission_race_scenario_group`
--
ALTER TABLE mission_race_scenario_group
ADD INDEX mission_race_scenario_group_0_race_instance_id (race_instance_id);

--
-- Create table `mission_race_equate`
--
CREATE TABLE mission_race_equate (
  id int(11) NOT NULL,
  input_id int(11) NOT NULL,
  equate_id int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 528,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `mission_race_equate_0_input_id` on table `mission_race_equate`
--
ALTER TABLE mission_race_equate
ADD INDEX mission_race_equate_0_input_id (input_id);

--
-- Create table `mission_data`
--
CREATE TABLE mission_data (
  id int(11) NOT NULL,
  mission_type int(11) NOT NULL,
  condition_type int(11) NOT NULL,
  condition_value_1 int(11) NOT NULL,
  condition_value_2 int(11) NOT NULL,
  condition_value_3 int(11) NOT NULL,
  condition_value_4 int(11) NOT NULL,
  condition_num int(11) NOT NULL,
  step_group_id int(11) NOT NULL,
  step_order int(11) NOT NULL,
  disp_order int(11) NOT NULL,
  item_category int(11) NOT NULL,
  item_id int(11) NOT NULL,
  item_num int(11) NOT NULL,
  event_id int(11) NOT NULL,
  user_show int(11) NOT NULL,
  date_check_flg int(11) NOT NULL,
  transition_type int(11) NOT NULL,
  start_date text NOT NULL,
  end_date text NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 150,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `mission_data_0_mission_type` on table `mission_data`
--
ALTER TABLE mission_data
ADD INDEX mission_data_0_mission_type (mission_type);

--
-- Create table `mini_mouth_type`
--
CREATE TABLE mini_mouth_type (
  id int(11) NOT NULL,
  type int(11) NOT NULL,
  reverse_mouth_id int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 512,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `mini_motion_set`
--
CREATE TABLE mini_motion_set (
  id int(11) NOT NULL,
  label varchar(300) NOT NULL,
  body_motion text NOT NULL,
  body_motion_type int(11) NOT NULL,
  body_motion_play_type int(11) NOT NULL,
  body_motion_scene_type int(11) NOT NULL,
  scene_sub_folder text NOT NULL,
  chara_type_target int(11) NOT NULL,
  add_layer_index int(11) NOT NULL,
  is_mirror int(11) NOT NULL,
  facial_motion text NOT NULL,
  chara_face_type text NOT NULL,
  transition_time int(11) NOT NULL,
  ear_motion text NOT NULL,
  is_enable_randome_ear int(11) NOT NULL,
  tail_motion text NOT NULL,
  tail_motion_type int(11) NOT NULL,
  is_enable_randome_tail int(11) NOT NULL,
  prop_id int(11) NOT NULL,
  prop_motion text NOT NULL,
  prop_motion_scene_type int(11) NOT NULL,
  prop_attach_node_name_type int(11) NOT NULL,
  is_prop_require_motion_end int(11) NOT NULL,
  prop_id_2 int(11) NOT NULL,
  prop_motion_2 text NOT NULL,
  prop_motion_scene_type_2 int(11) NOT NULL,
  prop_attach_node_name_type_2 int(11) NOT NULL,
  use_tail_in_body_motion int(11) NOT NULL,
  PRIMARY KEY (label)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 236,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `mini_motion_set_0_id` on table `mini_motion_set`
--
ALTER TABLE mini_motion_set
ADD INDEX mini_motion_set_0_id (id);

--
-- Create table `mini_mob`
--
CREATE TABLE mini_mob (
  id int(11) NOT NULL,
  type int(11) NOT NULL,
  `body` int(11) NOT NULL,
  hair int(11) NOT NULL,
  tail int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1365,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `mini_face_type_data`
--
CREATE TABLE mini_face_type_data (
  label varchar(300) NOT NULL,
  eyebrow_l int(11) NOT NULL,
  eyebrow_r int(11) NOT NULL,
  eye_l int(11) NOT NULL,
  eye_r int(11) NOT NULL,
  mouth int(11) NOT NULL,
  cheek int(11) NOT NULL,
  PRIMARY KEY (label)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 468,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `mini_bg_chara_motion`
--
CREATE TABLE mini_bg_chara_motion (
  id int(11) NOT NULL,
  bg_id int(11) NOT NULL,
  group_id int(11) NOT NULL,
  sub_group_id int(11) NOT NULL,
  is_mob int(11) NOT NULL,
  main_chara_num int(11) NOT NULL,
  pos_obj text NOT NULL,
  position_file text NOT NULL,
  grid_pos_x int(11) NOT NULL,
  grid_pos_y int(11) NOT NULL,
  priority int(11) NOT NULL,
  motion_name text NOT NULL,
  timeline text NOT NULL,
  timeline_actor text NOT NULL,
  direction int(11) NOT NULL,
  chara_pos_y text NOT NULL,
  chara_shadow int(11) NOT NULL,
  use_grid_pos_job_select int(11) NOT NULL,
  position_anim text NOT NULL,
  fixed_render_order int(11) NOT NULL,
  se_cue_name01 text NOT NULL,
  se_cue_sheet01 text NOT NULL,
  se_start_frame01 int(11) NOT NULL,
  se_cue_name02 text NOT NULL,
  se_cue_sheet02 text NOT NULL,
  se_start_frame02 int(11) NOT NULL,
  effect_id int(11) NOT NULL,
  effect_start_sec text NOT NULL,
  second_pos_obj text NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 195,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `mini_bg_chara_motion_0_bg_id` on table `mini_bg_chara_motion`
--
ALTER TABLE mini_bg_chara_motion
ADD INDEX mini_bg_chara_motion_0_bg_id (bg_id);

--
-- Create table `mini_bg`
--
CREATE TABLE mini_bg (
  id int(11) NOT NULL,
  scene_type int(11) NOT NULL,
  release_num int(11) NOT NULL,
  size_x int(11) NOT NULL,
  size_y int(11) NOT NULL,
  grid_offset_x text NOT NULL,
  grid_offset_y text NOT NULL,
  dress_id int(11) NOT NULL,
  `position` text NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 3276,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `mini_bg_0_scene_type` on table `mini_bg`
--
ALTER TABLE mini_bg
ADD INDEX mini_bg_0_scene_type (scene_type);

--
-- Create table `meta_r`
--
CREATE TABLE meta_r (
  f int(4) DEFAULT NULL,
  t int(4) DEFAULT NULL,
  d int(2) DEFAULT NULL
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 40,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `r0` on table `meta_r`
--
ALTER TABLE meta_r
ADD UNIQUE INDEX r0 (f, t);

--
-- Create index `r1` on table `meta_r`
--
ALTER TABLE meta_r
ADD INDEX r1 (d);

--
-- Create table `meta_i`
--
CREATE TABLE meta_i (
  k text DEFAULT NULL,
  v text DEFAULT NULL
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 16384,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `k` on table `meta_i`
--
ALTER TABLE meta_i
ADD UNIQUE INDEX k USING HASH (k);

--
-- Create table `meta_c`
--
CREATE TABLE meta_c (
  n text DEFAULT NULL,
  h text DEFAULT NULL
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 455,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `n` on table `meta_c`
--
ALTER TABLE meta_c
ADD UNIQUE INDEX n USING HASH (n);

--
-- Create table `meta_a`
--
CREATE TABLE meta_a (
  i int(11) NOT NULL,
  n text NOT NULL,
  d text DEFAULT NULL,
  g int(4) NOT NULL,
  l int(8) NOT NULL,
  c int(8) NOT NULL,
  h text NOT NULL,
  m text NOT NULL,
  k int(1) NOT NULL,
  s int(1) NOT NULL,
  p int(4) NOT NULL DEFAULT 0,
  PRIMARY KEY (i)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 184,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `a1` on table `meta_a`
--
ALTER TABLE meta_a
ADD INDEX a1 (s);

--
-- Create index `a3` on table `meta_a`
--
ALTER TABLE meta_a
ADD INDEX a3 (g, s);

--
-- Create index `a4` on table `meta_a`
--
ALTER TABLE meta_a
ADD INDEX a4 (p);

--
-- Create table `map_event_story_data`
--
CREATE TABLE map_event_story_data (
  id int(11) NOT NULL,
  event_id int(11) NOT NULL,
  episode_index_id int(11) NOT NULL,
  story_condition_type int(11) NOT NULL,
  story_id int(11) NOT NULL,
  point_condition_type int(11) NOT NULL,
  start_date int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 8192,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `map_event_story_data_0_event_id` on table `map_event_story_data`
--
ALTER TABLE map_event_story_data
ADD INDEX map_event_story_data_0_event_id (event_id);

--
-- Create table `map_event_mini_motion`
--
CREATE TABLE map_event_mini_motion (
  id int(11) NOT NULL,
  event_id int(11) NOT NULL,
  chara_id int(11) NOT NULL,
  dress_id int(11) NOT NULL,
  stand_motion int(11) NOT NULL,
  walk_motion int(11) NOT NULL,
  arrive_motion int(11) NOT NULL,
  checkpoint_motion int(11) NOT NULL,
  tap_motion int(11) NOT NULL,
  complete_motion int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 5461,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `map_event_mini_motion_0_event_id` on table `map_event_mini_motion`
--
ALTER TABLE map_event_mini_motion
ADD INDEX map_event_mini_motion_0_event_id (event_id);

--
-- Create table `map_event_map_point`
--
CREATE TABLE map_event_map_point (
  id int(11) NOT NULL,
  event_id int(11) NOT NULL,
  map_point_id int(11) NOT NULL,
  area_id int(11) NOT NULL,
  check_point_flag int(11) NOT NULL,
  disp_flag int(11) NOT NULL,
  next_episode_unlock_map_point_id int(11) NOT NULL,
  gauge_num int(11) NOT NULL,
  story_id_1 int(11) NOT NULL,
  story_id_2 int(11) NOT NULL,
  item_category_1 int(11) NOT NULL,
  item_id_1 int(11) NOT NULL,
  item_num_1 int(11) NOT NULL,
  chara_id int(11) NOT NULL,
  dress_id int(11) NOT NULL,
  motion_id int(11) NOT NULL,
  next_episode_id int(11) NOT NULL,
  start_date int(11) NOT NULL,
  movie_start_date int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1638,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `map_event_map_point_0_event_id` on table `map_event_map_point`
--
ALTER TABLE map_event_map_point
ADD INDEX map_event_map_point_0_event_id (event_id);

--
-- Create table `map_event_flavor_text`
--
CREATE TABLE map_event_flavor_text (
  id int(11) NOT NULL,
  event_id int(11) NOT NULL,
  image_type int(11) NOT NULL,
  story_id int(11) NOT NULL,
  story_condition_type int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 910,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `map_event_flavor_text_0_event_id` on table `map_event_flavor_text`
--
ALTER TABLE map_event_flavor_text
ADD INDEX map_event_flavor_text_0_event_id (event_id);

--
-- Create table `map_event_data`
--
CREATE TABLE map_event_data (
  event_id int(11) NOT NULL,
  gauge_max int(11) NOT NULL,
  gauge_up_singlemode int(11) NOT NULL,
  gauge_up_teamstadium int(11) NOT NULL,
  gauge_up_login int(11) NOT NULL,
  start_date int(11) NOT NULL,
  end_date int(11) NOT NULL,
  PRIMARY KEY (event_id)
)
ENGINE = INNODB,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `map_event_area_data`
--
CREATE TABLE map_event_area_data (
  id int(11) NOT NULL,
  area_id int(11) NOT NULL,
  event_id int(11) NOT NULL,
  start_date int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 4096,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `map_event_area_data_0_event_id` on table `map_event_area_data`
--
ALTER TABLE map_event_area_data
ADD INDEX map_event_area_data_0_event_id (event_id);

--
-- Create table `main_story_race_data`
--
CREATE TABLE main_story_race_data (
  id int(11) NOT NULL,
  race_instance_id int(11) NOT NULL,
  group_id int(11) NOT NULL,
  race_condition_id int(11) NOT NULL,
  clear_rank int(11) NOT NULL,
  bonus_group_id int(11) NOT NULL,
  bonus_chara_1 int(11) NOT NULL,
  bonus_chara_2 int(11) NOT NULL,
  bonus_chara_3 int(11) NOT NULL,
  gimmick_type int(11) NOT NULL,
  gimmick_trigger_skill int(11) NOT NULL,
  gimmick_match_race_asset int(11) NOT NULL,
  gimmick_unmatch_race_asset int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 819,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `main_story_race_chara_data`
--
CREATE TABLE main_story_race_chara_data (
  id int(11) NOT NULL,
  group_id int(11) NOT NULL,
  bracket_number int(11) NOT NULL,
  chara_id int(11) NOT NULL,
  mob_id int(11) NOT NULL,
  dress_id int(11) NOT NULL,
  chara_color_type int(11) NOT NULL,
  motivation int(11) NOT NULL,
  running_style int(11) NOT NULL,
  speed int(11) NOT NULL,
  stamina int(11) NOT NULL,
  pow int(11) NOT NULL,
  guts int(11) NOT NULL,
  wiz int(11) NOT NULL,
  proper_distance_short int(11) NOT NULL,
  proper_distance_mile int(11) NOT NULL,
  proper_distance_middle int(11) NOT NULL,
  proper_distance_long int(11) NOT NULL,
  proper_running_style_nige int(11) NOT NULL,
  proper_running_style_senko int(11) NOT NULL,
  proper_running_style_sashi int(11) NOT NULL,
  proper_running_style_oikomi int(11) NOT NULL,
  proper_ground_turf int(11) NOT NULL,
  proper_ground_dirt int(11) NOT NULL,
  skill_set_id int(11) NOT NULL,
  is_player int(11) NOT NULL,
  show_skill_type int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 307,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `main_story_race_chara_data_0_group_id` on table `main_story_race_chara_data`
--
ALTER TABLE main_story_race_chara_data
ADD INDEX main_story_race_chara_data_0_group_id (group_id);

--
-- Create index `main_story_race_chara_data_0_running_style` on table `main_story_race_chara_data`
--
ALTER TABLE main_story_race_chara_data
ADD INDEX main_story_race_chara_data_0_running_style (running_style);

--
-- Create table `main_story_race_bonus_condition`
--
CREATE TABLE main_story_race_bonus_condition (
  id int(11) NOT NULL,
  group_id int(11) NOT NULL,
  condition_type int(11) NOT NULL,
  condition_value_1 int(11) NOT NULL,
  condition_value_2 int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1489,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `main_story_race_bonus_condition_0_group_id` on table `main_story_race_bonus_condition`
--
ALTER TABLE main_story_race_bonus_condition
ADD INDEX main_story_race_bonus_condition_0_group_id (group_id);

--
-- Create table `main_story_race_bonus`
--
CREATE TABLE main_story_race_bonus (
  id int(11) NOT NULL,
  group_id int(11) NOT NULL,
  bonus_type int(11) NOT NULL,
  bonus_value int(11) NOT NULL,
  condition_group int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1024,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `main_story_race_bonus_0_group_id` on table `main_story_race_bonus`
--
ALTER TABLE main_story_race_bonus
ADD INDEX main_story_race_bonus_0_group_id (group_id);

--
-- Create table `main_story_part`
--
CREATE TABLE main_story_part (
  id int(11) NOT NULL,
  main_story_last_chapter int(11) NOT NULL,
  start_date int(11) NOT NULL,
  ui_color text NOT NULL,
  section_id int(11) NOT NULL,
  part_index int(11) NOT NULL,
  is_last_part int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 3276,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `main_story_data`
--
CREATE TABLE main_story_data (
  id int(11) NOT NULL,
  part_id int(11) NOT NULL,
  episode_index int(11) NOT NULL,
  story_number int(11) NOT NULL,
  story_type_1 int(11) NOT NULL,
  story_id_1 int(11) NOT NULL,
  story_type_2 int(11) NOT NULL,
  story_id_2 int(11) NOT NULL,
  story_type_3 int(11) NOT NULL,
  story_id_3 int(11) NOT NULL,
  story_type_4 int(11) NOT NULL,
  story_id_4 int(11) NOT NULL,
  story_type_5 int(11) NOT NULL,
  story_id_5 int(11) NOT NULL,
  lock_type_1 int(11) NOT NULL,
  lock_value_1_1 int(11) NOT NULL,
  lock_value_1_2 int(11) NOT NULL,
  lock_type_2 int(11) NOT NULL,
  lock_value_2_1 int(11) NOT NULL,
  lock_value_2_2 int(11) NOT NULL,
  lock_type_3 int(11) NOT NULL,
  lock_value_3_1 int(11) NOT NULL,
  lock_value_3_2 int(11) NOT NULL,
  add_reward_category_1 int(11) NOT NULL,
  add_reward_id_1 int(11) NOT NULL,
  add_reward_num_1 int(11) NOT NULL,
  prev_episode_index int(11) NOT NULL,
  next_episode_index int(11) NOT NULL,
  display_type int(11) NOT NULL,
  add_reward_category_2 int(11) NOT NULL,
  add_reward_id_2 int(11) NOT NULL,
  add_reward_num_2 int(11) NOT NULL,
  lock_reference_episode_id int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 190,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `main_story_data_0_part_id` on table `main_story_data`
--
ALTER TABLE main_story_data
ADD INDEX main_story_data_0_part_id (part_id);

--
-- Create index `story_id_1` on table `main_story_data`
--
ALTER TABLE main_story_data
ADD UNIQUE INDEX story_id_1 (story_id_1);

--
-- Create table `love_rank`
--
CREATE TABLE love_rank (
  id INT(11) NOT NULL,
  rank INT(11) NOT NULL,
  total_point INT(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1489,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `love_rank_0_rank` on table `love_rank`
--
ALTER TABLE love_rank
ADD UNIQUE INDEX love_rank_0_rank (`rank`);

--
-- Create table `login_bonus_detail`
--
CREATE TABLE login_bonus_detail (
  id int(11) NOT NULL,
  login_bonus_id int(11) NOT NULL,
  `count` int(11) NOT NULL,
  item_category int(11) NOT NULL,
  item_id int(11) NOT NULL,
  item_num int(11) NOT NULL,
  item_category_2 int(11) NOT NULL,
  item_id_2 int(11) NOT NULL,
  item_num_2 int(11) NOT NULL,
  item_category_3 int(11) NOT NULL,
  item_id_3 int(11) NOT NULL,
  item_num_3 int(11) NOT NULL,
  item_category_4 int(11) NOT NULL,
  item_id_4 int(11) NOT NULL,
  item_num_4 int(11) NOT NULL,
  item_category_5 int(11) NOT NULL,
  item_id_5 int(11) NOT NULL,
  item_num_5 int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 168,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `login_bonus_detail_0_login_bonus_id` on table `login_bonus_detail`
--
ALTER TABLE login_bonus_detail
ADD INDEX login_bonus_detail_0_login_bonus_id (login_bonus_id);

--
-- Create index `login_bonus_id` on table `login_bonus_detail`
--
ALTER TABLE login_bonus_detail
ADD UNIQUE INDEX login_bonus_id (login_bonus_id, `count`);

--
-- Create table `login_bonus_data`
--
CREATE TABLE login_bonus_data (
  id int(11) NOT NULL,
  type int(11) NOT NULL,
  count_num int(11) NOT NULL,
  disp_order int(11) NOT NULL,
  stamp_id int(11) NOT NULL,
  bg_id int(11) NOT NULL,
  group_id int(11) NOT NULL,
  step int(11) NOT NULL,
  gift_message_id int(11) NOT NULL,
  anime_file_id int(11) NOT NULL,
  anime_file_label text NOT NULL,
  new_start_date text NOT NULL,
  start_date text NOT NULL,
  end_date text NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 305,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `login_bonus_data_0_group_id` on table `login_bonus_data`
--
ALTER TABLE login_bonus_data
ADD INDEX login_bonus_data_0_group_id (group_id);

--
-- Create index `login_bonus_data_0_type` on table `login_bonus_data`
--
ALTER TABLE login_bonus_data
ADD INDEX login_bonus_data_0_type (type);

--
-- Create table `login_bonus_chara`
--
CREATE TABLE login_bonus_chara (
  id int(11) NOT NULL,
  login_bonus_detail_id int(11) NOT NULL,
  chara_num int(11) NOT NULL,
  chara_id int(11) NOT NULL,
  dress_id int(11) NOT NULL,
  pose_id int(11) NOT NULL,
  chara_id_2 int(11) NOT NULL,
  dress_id_2 int(11) NOT NULL,
  pose_id_2 int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1260,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `login_bonus_chara_0_login_bonus_detail_id` on table `login_bonus_chara`
--
ALTER TABLE login_bonus_chara
ADD UNIQUE INDEX login_bonus_chara_0_login_bonus_detail_id (login_bonus_detail_id);

--
-- Create table `live_permission_data`
--
CREATE TABLE live_permission_data (
  music_id int(11) NOT NULL,
  chara_id int(11) NOT NULL,
  PRIMARY KEY (music_id, chara_id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 82,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `live_permission_data_0_music_id` on table `live_permission_data`
--
ALTER TABLE live_permission_data
ADD INDEX live_permission_data_0_music_id (music_id);

--
-- Create table `live_extra_data`
--
CREATE TABLE live_extra_data (
  id int(11) NOT NULL,
  music_id int(11) NOT NULL,
  group_id int(11) NOT NULL,
  condition_type int(11) NOT NULL,
  condition_value_1 int(11) NOT NULL,
  condition_value_2 int(11) NOT NULL,
  next_music_id int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `live_extra_data_0_music_id` on table `live_extra_data`
--
ALTER TABLE live_extra_data
ADD INDEX live_extra_data_0_music_id (music_id);

--
-- Create table `live_data`
--
CREATE TABLE live_data (
  music_id int(11) NOT NULL,
  sort int(11) NOT NULL,
  music_type int(11) NOT NULL,
  title_color_top text NOT NULL,
  title_color_bottom text NOT NULL,
  condition_type int(11) NOT NULL,
  song_chara_type int(11) NOT NULL,
  live_member_number int(11) NOT NULL,
  default_main_dress int(11) NOT NULL,
  default_main_dress_color int(11) NOT NULL,
  default_mob_dress int(11) NOT NULL,
  default_mob_dress_color int(11) NOT NULL,
  backdancer_order int(11) NOT NULL,
  backdancer_dress int(11) NOT NULL,
  backdancer_dress_color int(11) NOT NULL,
  has_live int(11) NOT NULL,
  start_date int(11) NOT NULL,
  end_date int(11) NOT NULL,
  PRIMARY KEY (music_id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 655,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `sort` on table `live_data`
--
ALTER TABLE live_data
ADD UNIQUE INDEX sort (sort);

--
-- Create table `legend_race_npc`
--
CREATE TABLE legend_race_npc (
  id int(11) NOT NULL,
  npc_group_id int(11) NOT NULL,
  chara_id int(11) NOT NULL,
  mob_id int(11) NOT NULL,
  race_dress_id int(11) NOT NULL,
  race_instance_id int(11) NOT NULL,
  speed int(11) NOT NULL,
  stamina int(11) NOT NULL,
  pow int(11) NOT NULL,
  guts int(11) NOT NULL,
  wiz int(11) NOT NULL,
  proper_distance_short int(11) NOT NULL,
  proper_distance_mile int(11) NOT NULL,
  proper_distance_middle int(11) NOT NULL,
  proper_distance_long int(11) NOT NULL,
  proper_running_style_nige int(11) NOT NULL,
  proper_running_style_senko int(11) NOT NULL,
  proper_running_style_sashi int(11) NOT NULL,
  proper_running_style_oikomi int(11) NOT NULL,
  proper_ground_turf int(11) NOT NULL,
  proper_ground_dirt int(11) NOT NULL,
  skill_set_id int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 184,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `legend_race_cutt_chara_data`
--
CREATE TABLE legend_race_cutt_chara_data (
  id int(11) NOT NULL,
  sub_id int(11) NOT NULL,
  chara_num int(11) NOT NULL,
  chara_id int(11) NOT NULL,
  target_timeline int(11) NOT NULL,
  target_list_index int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `legend_race_cutt_chara_data_0_sub_id_1_chara_num` on table `legend_race_cutt_chara_data`
--
ALTER TABLE legend_race_cutt_chara_data
ADD INDEX legend_race_cutt_chara_data_0_sub_id_1_chara_num (sub_id, chara_num);

--
-- Create table `legend_race_boss_npc`
--
CREATE TABLE legend_race_boss_npc (
  id int(11) NOT NULL,
  chara_id int(11) NOT NULL,
  race_dress_id int(11) NOT NULL,
  nickname_id int(11) NOT NULL,
  card_rarity_data_id int(11) NOT NULL,
  post int(11) NOT NULL,
  speed int(11) NOT NULL,
  stamina int(11) NOT NULL,
  pow int(11) NOT NULL,
  guts int(11) NOT NULL,
  wiz int(11) NOT NULL,
  proper_distance_short int(11) NOT NULL,
  proper_distance_mile int(11) NOT NULL,
  proper_distance_middle int(11) NOT NULL,
  proper_distance_long int(11) NOT NULL,
  proper_running_style_nige int(11) NOT NULL,
  proper_running_style_senko int(11) NOT NULL,
  proper_running_style_sashi int(11) NOT NULL,
  proper_running_style_oikomi int(11) NOT NULL,
  proper_ground_turf int(11) NOT NULL,
  proper_ground_dirt int(11) NOT NULL,
  skill_set_id int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 512,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `legend_race_billing`
--
CREATE TABLE legend_race_billing (
  id int(11) NOT NULL,
  frequency int(11) NOT NULL,
  pay_cost int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 16384,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `legend_race`
--
CREATE TABLE legend_race (
  id int(11) NOT NULL,
  group_id int(11) NOT NULL,
  legend_bg_id int(11) NOT NULL,
  legend_bg_sub_id int(11) NOT NULL,
  image_id int(11) NOT NULL,
  difficulty int(11) NOT NULL,
  race_instance_id int(11) NOT NULL,
  season int(11) NOT NULL,
  weather int(11) NOT NULL,
  ground int(11) NOT NULL,
  legend_race_boss_npc_id int(11) NOT NULL,
  cost_num int(11) NOT NULL,
  drop_reward_odds_id int(11) NOT NULL,
  victory_reward_odds_id int(11) NOT NULL,
  first_clear_item_category_1 int(11) NOT NULL,
  first_clear_item_id_1 int(11) NOT NULL,
  first_clear_item_num_1 int(11) NOT NULL,
  first_clear_item_category_2 int(11) NOT NULL,
  first_clear_item_id_2 int(11) NOT NULL,
  first_clear_item_num_2 int(11) NOT NULL,
  first_clear_item_category_3 int(11) NOT NULL,
  first_clear_item_id_3 int(11) NOT NULL,
  first_clear_item_num_3 int(11) NOT NULL,
  pick_up_item_category_1 int(11) NOT NULL,
  pick_up_item_id_1 int(11) NOT NULL,
  pick_up_item_num_1 int(11) NOT NULL,
  pick_up_item_category_2 int(11) NOT NULL,
  pick_up_item_id_2 int(11) NOT NULL,
  pick_up_item_num_2 int(11) NOT NULL,
  pick_up_item_category_3 int(11) NOT NULL,
  pick_up_item_id_3 int(11) NOT NULL,
  pick_up_item_num_3 int(11) NOT NULL,
  notice_date int(11) NOT NULL,
  start_date int(11) NOT NULL,
  end_date int(11) NOT NULL,
  has_unique_bg_env int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 496,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `legend_race_0_group_id` on table `legend_race`
--
ALTER TABLE legend_race
ADD INDEX legend_race_0_group_id (group_id);

--
-- Create index `legend_race_0_race_instance_id` on table `legend_race`
--
ALTER TABLE legend_race
ADD INDEX legend_race_0_race_instance_id (race_instance_id);

--
-- Create table `jukebox_setlist_singer_data`
--
CREATE TABLE jukebox_setlist_singer_data (
  id int(11) NOT NULL,
  setlist_music_id int(11) NOT NULL,
  performer int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 48,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `jukebox_setlist_singer_data_0_setlist_music_id` on table `jukebox_setlist_singer_data`
--
ALTER TABLE jukebox_setlist_singer_data
ADD INDEX jukebox_setlist_singer_data_0_setlist_music_id (setlist_music_id);

--
-- Create table `jukebox_setlist_music_data`
--
CREATE TABLE jukebox_setlist_music_data (
  id int(11) NOT NULL,
  setlist_id int(11) NOT NULL,
  set_order int(11) NOT NULL,
  music_id int(11) NOT NULL,
  play_length int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 60,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `jukebox_setlist_music_data_0_setlist_id` on table `jukebox_setlist_music_data`
--
ALTER TABLE jukebox_setlist_music_data
ADD INDEX jukebox_setlist_music_data_0_setlist_id (setlist_id);

--
-- Create table `jukebox_setlist_data`
--
CREATE TABLE jukebox_setlist_data (
  id int(11) NOT NULL,
  start_date int(11) NOT NULL,
  end_date int(11) NOT NULL,
  disp_order int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1638,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `jukebox_music_data`
--
CREATE TABLE jukebox_music_data (
  music_id int(11) NOT NULL,
  sort int(11) NOT NULL,
  condition_type int(11) NOT NULL,
  is_hidden int(11) NOT NULL,
  version_type int(11) NOT NULL,
  request_type int(11) NOT NULL,
  lamp_color int(11) NOT NULL,
  lamp_animation int(11) NOT NULL,
  name_texture_length int(11) NOT NULL,
  song_type int(11) NOT NULL,
  bgm_cue_name_short text NOT NULL,
  bgm_cuesheet_name_short text NOT NULL,
  bgm_cue_name_gamesize text NOT NULL,
  bgm_cuesheet_name_gamesize text NOT NULL,
  short_length int(11) NOT NULL,
  start_date int(11) NOT NULL,
  end_date int(11) NOT NULL,
  alter_jacket int(11) NOT NULL,
  PRIMARY KEY (music_id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 819,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `jukebox_music_data_0_version_type` on table `jukebox_music_data`
--
ALTER TABLE jukebox_music_data
ADD INDEX jukebox_music_data_0_version_type (version_type);

--
-- Create index `sort` on table `jukebox_music_data`
--
ALTER TABLE jukebox_music_data
ADD UNIQUE INDEX sort (sort);

--
-- Create table `jukebox_motion_data`
--
CREATE TABLE jukebox_motion_data (
  id int(11) NOT NULL,
  song_type int(11) NOT NULL,
  motion_id int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1024,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `jukebox_motion_data_0_song_type` on table `jukebox_motion_data`
--
ALTER TABLE jukebox_motion_data
ADD INDEX jukebox_motion_data_0_song_type (song_type);

--
-- Create table `jukebox_comment`
--
CREATE TABLE jukebox_comment (
  id int(11) NOT NULL,
  comment_id int(11) NOT NULL,
  chara_id int(11) NOT NULL,
  comment_type int(11) NOT NULL,
  variation_type int(11) NOT NULL,
  variation_value int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 125,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `jukebox_comment_0_chara_id_1_comment_type` on table `jukebox_comment`
--
ALTER TABLE jukebox_comment
ADD INDEX jukebox_comment_0_chara_id_1_comment_type (chara_id, comment_type);

--
-- Create index `jukebox_comment_0_comment_id` on table `jukebox_comment`
--
ALTER TABLE jukebox_comment
ADD INDEX jukebox_comment_0_comment_id (comment_id);

--
-- Create table `jobs_reward_sort_disp_order`
--
CREATE TABLE jobs_reward_sort_disp_order (
  id int(11) NOT NULL,
  item_category int(11) NOT NULL,
  item_id int(11) NOT NULL,
  disp_order int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 409,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `jobs_reward_sort_disp_order_0_item_category_1_item_id` on table `jobs_reward_sort_disp_order`
--
ALTER TABLE jobs_reward_sort_disp_order
ADD INDEX jobs_reward_sort_disp_order_0_item_category_1_item_id (item_category, item_id);

--
-- Create table `jobs_reward`
--
CREATE TABLE jobs_reward (
  id int(11) NOT NULL,
  place_id int(11) NOT NULL,
  genre_id int(11) NOT NULL,
  main_reward_slots_id int(11) NOT NULL,
  main_reward_1_item_disp_type int(11) NOT NULL,
  main_reward_1_item_category int(11) NOT NULL,
  main_reward_1_item_id int(11) NOT NULL,
  main_reward_1_item_num int(11) NOT NULL,
  main_reward_2_item_disp_type int(11) NOT NULL,
  main_reward_2_item_category int(11) NOT NULL,
  main_reward_2_item_id int(11) NOT NULL,
  main_reward_2_item_num int(11) NOT NULL,
  main_reward_3_item_disp_type int(11) NOT NULL,
  main_reward_3_item_category int(11) NOT NULL,
  main_reward_3_item_id int(11) NOT NULL,
  main_reward_3_item_num int(11) NOT NULL,
  main_reward_4_item_disp_type int(11) NOT NULL,
  main_reward_4_item_category int(11) NOT NULL,
  main_reward_4_item_id int(11) NOT NULL,
  main_reward_4_item_num int(11) NOT NULL,
  main_reward_5_item_disp_type int(11) NOT NULL,
  main_reward_5_item_category int(11) NOT NULL,
  main_reward_5_item_id int(11) NOT NULL,
  main_reward_5_item_num int(11) NOT NULL,
  main_reward_6_item_disp_type int(11) NOT NULL,
  main_reward_6_item_category int(11) NOT NULL,
  main_reward_6_item_id int(11) NOT NULL,
  main_reward_6_item_num int(11) NOT NULL,
  main_reward_7_item_disp_type int(11) NOT NULL,
  main_reward_7_item_category int(11) NOT NULL,
  main_reward_7_item_id int(11) NOT NULL,
  main_reward_7_item_num int(11) NOT NULL,
  main_reward_8_item_disp_type int(11) NOT NULL,
  main_reward_8_item_category int(11) NOT NULL,
  main_reward_8_item_id int(11) NOT NULL,
  main_reward_8_item_num int(11) NOT NULL,
  main_reward_9_item_disp_type int(11) NOT NULL,
  main_reward_9_item_category int(11) NOT NULL,
  main_reward_9_item_id int(11) NOT NULL,
  main_reward_9_item_num int(11) NOT NULL,
  random_drop_reward_group_id int(11) NOT NULL,
  money_reward_item_odds_group_id int(11) NOT NULL,
  money_min int(11) NOT NULL,
  support_point_reward_item_odds_group_id int(11) NOT NULL,
  support_point_min int(11) NOT NULL,
  trainer_medal int(11) NOT NULL,
  fan_num_odds_group_id int(11) NOT NULL,
  fan_num_min int(11) NOT NULL,
  love_point int(11) NOT NULL,
  minutes_to_job_complete int(11) NOT NULL,
  story_event_event_pt int(11) NOT NULL,
  story_event_roulette_coin int(11) NOT NULL,
  factor_research_gauge_up int(11) NOT NULL,
  campaign_walking_gauge_up int(11) NOT NULL,
  training_challenge_reward_coin int(11) NOT NULL,
  training_report_pt int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 862,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `jobs_reward_0_place_id` on table `jobs_reward`
--
ALTER TABLE jobs_reward
ADD INDEX jobs_reward_0_place_id (place_id);

--
-- Create table `jobs_random_drop_reward`
--
CREATE TABLE jobs_random_drop_reward (
  id int(11) NOT NULL,
  group_id int(11) NOT NULL,
  item_category int(11) NOT NULL,
  item_id int(11) NOT NULL,
  item_num int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `jobs_random_drop_reward_0_group_id` on table `jobs_random_drop_reward`
--
ALTER TABLE jobs_random_drop_reward
ADD INDEX jobs_random_drop_reward_0_group_id (group_id);

--
-- Create table `jobs_point_limit`
--
CREATE TABLE jobs_point_limit (
  id int(11) NOT NULL,
  jobs_story_event_point_limit int(11) NOT NULL,
  jobs_story_event_roulette_coin_limit int(11) NOT NULL,
  jobs_training_challenge_coin_limit int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `jobs_place`
--
CREATE TABLE jobs_place (
  id int(11) NOT NULL,
  race_track_id int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1170,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `jobs_genre`
--
CREATE TABLE jobs_genre (
  id int(11) NOT NULL,
  mini_bg_id_1 int(11) NOT NULL,
  mini_bg_id_2 int(11) NOT NULL,
  mini_bg_id_3 int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 4096,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `item_place`
--
CREATE TABLE item_place (
  id int(11) NOT NULL,
  transition_type int(11) NOT NULL,
  transition_value int(11) NOT NULL,
  start_date int(11) NOT NULL
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 117,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `id` on table `item_place`
--
ALTER TABLE item_place
ADD UNIQUE INDEX id (id, transition_type, transition_value);

--
-- Create index `item_place_0_id` on table `item_place`
--
ALTER TABLE item_place
ADD INDEX item_place_0_id (id);

--
-- Create table `item_group`
--
CREATE TABLE item_group (
  id int(11) NOT NULL,
  group_id int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 468,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `item_group_0_group_id` on table `item_group`
--
ALTER TABLE item_group
ADD INDEX item_group_0_group_id (group_id);

--
-- Create table `item_exchange_top`
--
CREATE TABLE item_exchange_top (
  id int(11) NOT NULL,
  item_exchange_disp_order int(11) NOT NULL,
  item_exchange_type int(11) NOT NULL,
  item_top_category int(11) NOT NULL,
  start_date int(11) NOT NULL,
  end_date int(11) NOT NULL,
  is_anniv_shop_top int(11) NOT NULL,
  shop_enter_trigger int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 780,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `item_exchange_top_0_item_top_category` on table `item_exchange_top`
--
ALTER TABLE item_exchange_top
ADD INDEX item_exchange_top_0_item_top_category (item_top_category);

--
-- Create table `item_exchange`
--
CREATE TABLE item_exchange (
  id int(11) NOT NULL,
  item_exchange_top_id int(11) NOT NULL,
  disp_order int(11) NOT NULL,
  condition_type int(11) NOT NULL,
  condition_value_1 int(11) NOT NULL,
  condition_value_2 int(11) NOT NULL,
  change_item_limit_type int(11) NOT NULL,
  change_item_limit_num int(11) NOT NULL,
  change_item_category int(11) NOT NULL,
  change_item_id int(11) NOT NULL,
  change_item_num int(11) NOT NULL,
  additional_piece_num int(11) NOT NULL,
  pay_item_category int(11) NOT NULL,
  pay_item_id int(11) NOT NULL,
  pay_item_num int(11) NOT NULL,
  price_change_group_id int(11) NOT NULL,
  start_date int(11) NOT NULL,
  end_date int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 163,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `item_exchange_0_item_exchange_top_id` on table `item_exchange`
--
ALTER TABLE item_exchange
ADD INDEX item_exchange_0_item_exchange_top_id (item_exchange_top_id);

--
-- Create index `item_exchange_0_pay_item_id` on table `item_exchange`
--
ALTER TABLE item_exchange
ADD INDEX item_exchange_0_pay_item_id (pay_item_id);

--
-- Create table `item_data`
--
CREATE TABLE item_data (
  id int(11) NOT NULL,
  item_category int(11) NOT NULL,
  group_id int(11) NOT NULL,
  effect_type_1 int(11) NOT NULL,
  effect_target_1 int(11) NOT NULL,
  effect_value_1 int(11) NOT NULL,
  effect_type_2 int(11) NOT NULL,
  effect_target_2 int(11) NOT NULL,
  effect_value_2 int(11) NOT NULL,
  add_value_1 int(11) NOT NULL,
  add_value_2 int(11) NOT NULL,
  add_value_3 int(11) NOT NULL,
  limit_num int(11) NOT NULL,
  sort int(11) NOT NULL,
  rare int(11) NOT NULL,
  enable_request int(11) NOT NULL,
  request_reward int(11) NOT NULL,
  item_place_id int(11) NOT NULL,
  sell_item_id int(11) NOT NULL,
  sell_price int(11) NOT NULL,
  start_date text NOT NULL,
  end_date text NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 292,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `item_data_0_group_id` on table `item_data`
--
ALTER TABLE item_data
ADD INDEX item_data_0_group_id (group_id);

--
-- Create index `item_data_0_item_category` on table `item_data`
--
ALTER TABLE item_data
ADD INDEX item_data_0_item_category (item_category);

--
-- Create table `honor_data`
--
CREATE TABLE honor_data (
  id INT(11) NOT NULL,
  rank INT(11) NOT NULL,
  category INT(11) NOT NULL,
  start_date TEXT NOT NULL,
  end_date TEXT NOT NULL,
  condition_type INT(11) NOT NULL,
  condition_value INT(11) NOT NULL,
  condition_value_2 INT(11) NOT NULL,
  step_group_id INT(11) NOT NULL,
  step_order INT(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 158,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `home_walk_group`
--
CREATE TABLE home_walk_group (
  id int(11) NOT NULL,
  chara_id_1 int(11) NOT NULL,
  enable_eat_1 int(11) NOT NULL,
  chara_id_2 int(11) NOT NULL,
  enable_eat_2 int(11) NOT NULL,
  chara_id_3 int(11) NOT NULL,
  enable_eat_3 int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 321,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `home_story_trigger`
--
CREATE TABLE home_story_trigger (
  id int(11) NOT NULL,
  pos_id int(11) NOT NULL,
  home_event_type int(11) NOT NULL,
  num int(11) NOT NULL,
  story_id int(11) NOT NULL,
  chara_id_1 int(11) NOT NULL,
  chara_id_2 int(11) NOT NULL,
  chara_id_3 int(11) NOT NULL,
  condition_type int(11) NOT NULL,
  gallery_chara_id int(11) NOT NULL,
  disp_order int(11) NOT NULL,
  start_date int(11) NOT NULL,
  available_gallery_key int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 183,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `gallery_chara_id` on table `home_story_trigger`
--
ALTER TABLE home_story_trigger
ADD UNIQUE INDEX gallery_chara_id (gallery_chara_id, disp_order);

--
-- Create index `home_story_trigger_0_gallery_chara_id` on table `home_story_trigger`
--
ALTER TABLE home_story_trigger
ADD INDEX home_story_trigger_0_gallery_chara_id (gallery_chara_id);

--
-- Create index `home_story_trigger_0_home_event_type_1_story_id` on table `home_story_trigger`
--
ALTER TABLE home_story_trigger
ADD INDEX home_story_trigger_0_home_event_type_1_story_id (home_event_type, story_id);

--
-- Create index `home_story_trigger_0_pos_id` on table `home_story_trigger`
--
ALTER TABLE home_story_trigger
ADD INDEX home_story_trigger_0_pos_id (pos_id);

--
-- Create table `home_prop_setting`
--
CREATE TABLE home_prop_setting (
  pos_id int(11) NOT NULL,
  personality int(11) NOT NULL,
  prop_id int(11) NOT NULL,
  attach_node int(11) NOT NULL,
  PRIMARY KEY (pos_id, personality)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 819,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `home_poster_data`
--
CREATE TABLE home_poster_data (
  id int(11) NOT NULL,
  priority int(11) NOT NULL,
  height int(11) NOT NULL,
  width int(11) NOT NULL,
  posi_vertical int(11) NOT NULL,
  posi_horizontal int(11) NOT NULL,
  detail_value int(11) NOT NULL,
  url_value int(11) NOT NULL,
  url text NOT NULL,
  start_date int(11) NOT NULL,
  end_date int(11) NOT NULL,
  pos_index int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1170,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `home_poster_data_0_priority` on table `home_poster_data`
--
ALTER TABLE home_poster_data
ADD INDEX home_poster_data_0_priority (priority);

--
-- Create table `home_event_schedule`
--
CREATE TABLE home_event_schedule (
  id int(11) NOT NULL,
  event_id int(11) NOT NULL,
  start_date int(11) NOT NULL,
  end_date int(11) NOT NULL,
  event_story_type int(11) NOT NULL,
  event_walk_type int(11) NOT NULL,
  event_footer_type int(11) NOT NULL,
  event_walk_propid int(11) NOT NULL,
  event_footer_propid int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 8192,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `home_env_setting`
--
CREATE TABLE home_env_setting (
  id int(11) NOT NULL,
  home_set_id int(11) NOT NULL,
  home_event_type int(11) NOT NULL,
  resource_event_check int(11) NOT NULL,
  season int(11) NOT NULL,
  weather int(11) NOT NULL,
  timezone int(11) NOT NULL,
  resource int(11) NOT NULL,
  bgm_cue_name text NOT NULL,
  bgm_cuesheet_name text NOT NULL,
  env_cue_name text NOT NULL,
  env_cuesheet_name text NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 178,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `home_env_setting_index` on table `home_env_setting`
--
ALTER TABLE home_env_setting
ADD UNIQUE INDEX home_env_setting_index (home_set_id, home_event_type, season, weather, timezone);

--
-- Create table `home_eat`
--
CREATE TABLE home_eat (
  chara_id int(11) NOT NULL,
  body_shape int(11) NOT NULL,
  prop_id_right int(11) NOT NULL,
  prop_eat_animation_right text NOT NULL,
  override_motion_right text NOT NULL,
  prop_id_left int(11) NOT NULL,
  prop_eat_animation_left text NOT NULL,
  override_motion_left text NOT NULL,
  walk_motion text NOT NULL,
  walk_chara_face_type text NOT NULL,
  eat_motion text NOT NULL,
  eat_facial_motion text NOT NULL,
  odds int(11) NOT NULL,
  event_type int(11) NOT NULL
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 292,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `home_eat_0_chara_id` on table `home_eat`
--
ALTER TABLE home_eat
ADD INDEX home_eat_0_chara_id (chara_id);

--
-- Create table `home_character_type`
--
CREATE TABLE home_character_type (
  pos_id int(11) NOT NULL,
  original_personality int(11) NOT NULL,
  change_personality int(11) NOT NULL,
  PRIMARY KEY (pos_id, original_personality)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 712,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `homestory_hip_offset`
--
CREATE TABLE homestory_hip_offset (
  id int(11) NOT NULL,
  home_event_type int(11) NOT NULL,
  num int(11) NOT NULL,
  story_id int(11) NOT NULL,
  chara_id int(11) NOT NULL,
  offset int(11) NOT NULL
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1365,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `homestory_hip_offset_0_story_id_1_chara_id` on table `homestory_hip_offset`
--
ALTER TABLE homestory_hip_offset
ADD INDEX homestory_hip_offset_0_story_id_1_chara_id (story_id, chara_id);

--
-- Create table `highlight_interpolate`
--
CREATE TABLE highlight_interpolate (
  id int(11) NOT NULL,
  in_time int(11) NOT NULL,
  out_time int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 5461,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `heroes_stage_schedule`
--
CREATE TABLE heroes_stage_schedule (
  id int(11) NOT NULL,
  heroes_id int(11) NOT NULL,
  stage int(11) NOT NULL,
  stage_step int(11) NOT NULL,
  race_num int(11) NOT NULL,
  start_date int(11) NOT NULL,
  end_date int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 260,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `heroes_stage_schedule_0_heroes_id` on table `heroes_stage_schedule`
--
ALTER TABLE heroes_stage_schedule
ADD INDEX heroes_stage_schedule_0_heroes_id (heroes_id);

--
-- Create table `heroes_special_reward`
--
CREATE TABLE heroes_special_reward (
  id int(11) NOT NULL,
  condition_type int(11) NOT NULL,
  condition_value_1 int(11) NOT NULL,
  condition_value_2 int(11) NOT NULL,
  item_category int(11) NOT NULL,
  item_id int(11) NOT NULL,
  item_num int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1170,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `heroes_skill_motion`
--
CREATE TABLE heroes_skill_motion (
  character_id int(11) NOT NULL,
  race_dress_id int(11) NOT NULL,
  motion_set_1 int(11) NOT NULL,
  stay_motion_set_1 int(11) NOT NULL,
  motion_set_2 int(11) NOT NULL,
  time_motion_set_2 int(11) NOT NULL,
  PRIMARY KEY (character_id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 2048,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `heroes_skill_item`
--
CREATE TABLE heroes_skill_item (
  id int(11) NOT NULL,
  skill_id int(11) NOT NULL,
  item_category int(11) NOT NULL,
  item_id int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 2340,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `heroes_skill`
--
CREATE TABLE heroes_skill (
  id int(11) NOT NULL,
  league_rank_min int(11) NOT NULL,
  league_rank_max int(11) NOT NULL,
  skill_id int(11) NOT NULL,
  rate int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 2340,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `heroes_skill_0_skill_id` on table `heroes_skill`
--
ALTER TABLE heroes_skill
ADD UNIQUE INDEX heroes_skill_0_skill_id (skill_id);

--
-- Create table `heroes_race_mob_npc`
--
CREATE TABLE heroes_race_mob_npc (
  id int(11) NOT NULL,
  npc_group_id int(11) NOT NULL,
  mob_id int(11) NOT NULL,
  speed int(11) NOT NULL,
  stamina int(11) NOT NULL,
  pow int(11) NOT NULL,
  guts int(11) NOT NULL,
  wiz int(11) NOT NULL,
  proper_distance_short int(11) NOT NULL,
  proper_distance_mile int(11) NOT NULL,
  proper_distance_middle int(11) NOT NULL,
  proper_distance_long int(11) NOT NULL,
  proper_running_style_nige int(11) NOT NULL,
  proper_running_style_senko int(11) NOT NULL,
  proper_running_style_sashi int(11) NOT NULL,
  proper_running_style_oikomi int(11) NOT NULL,
  proper_ground_turf int(11) NOT NULL,
  proper_ground_dirt int(11) NOT NULL,
  skill_set_id_1 int(11) NOT NULL,
  skill_set_id_2 int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 273,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `heroes_race_default_user`
--
CREATE TABLE heroes_race_default_user (
  default_npc_team_id int(11) NOT NULL,
  PRIMARY KEY (default_npc_team_id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 260,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `heroes_race_default_npc`
--
CREATE TABLE heroes_race_default_npc (
  id int(11) NOT NULL,
  default_npc_group_id int(11) NOT NULL,
  default_npc_team_id int(11) NOT NULL,
  card_rarity_data_id int(11) NOT NULL,
  chara_id int(11) NOT NULL,
  race_dress_id int(11) NOT NULL,
  speed int(11) NOT NULL,
  stamina int(11) NOT NULL,
  pow int(11) NOT NULL,
  guts int(11) NOT NULL,
  wiz int(11) NOT NULL,
  proper_distance_short int(11) NOT NULL,
  proper_distance_mile int(11) NOT NULL,
  proper_distance_middle int(11) NOT NULL,
  proper_distance_long int(11) NOT NULL,
  proper_running_style_nige int(11) NOT NULL,
  proper_running_style_senko int(11) NOT NULL,
  proper_running_style_sashi int(11) NOT NULL,
  proper_running_style_oikomi int(11) NOT NULL,
  proper_ground_turf int(11) NOT NULL,
  proper_ground_dirt int(11) NOT NULL,
  skill_id int(11) NOT NULL,
  skill_level int(11) NOT NULL,
  skill_set_id int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 341,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `heroes_race_condition`
--
CREATE TABLE heroes_race_condition (
  id int(11) NOT NULL,
  heroes_id int(11) NOT NULL,
  stage int(11) NOT NULL,
  race_instance_id int(11) NOT NULL,
  season int(11) NOT NULL,
  weather int(11) NOT NULL,
  ground int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 606,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `heroes_race_condition_0_heroes_id` on table `heroes_race_condition`
--
ALTER TABLE heroes_race_condition
ADD INDEX heroes_race_condition_0_heroes_id (heroes_id);

--
-- Create table `heroes_lottery_message`
--
CREATE TABLE heroes_lottery_message (
  id int(11) NOT NULL,
  view_type int(11) NOT NULL,
  condition_flag int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 862,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `heroes_lottery_message_0_view_type` on table `heroes_lottery_message`
--
ALTER TABLE heroes_lottery_message
ADD INDEX heroes_lottery_message_0_view_type (view_type);

--
-- Create table `heroes_league_score`
--
CREATE TABLE heroes_league_score (
  id int(11) NOT NULL,
  league_rank int(11) NOT NULL,
  `order` int(11) NOT NULL,
  league_score int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1365,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `heroes_league_rank_reward_group`
--
CREATE TABLE heroes_league_rank_reward_group (
  id int(11) NOT NULL,
  reward_group_id int(11) NOT NULL,
  item_category int(11) NOT NULL,
  item_id int(11) NOT NULL,
  item_num int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 180,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `heroes_league_rank_reward_group_0_reward_group_id` on table `heroes_league_rank_reward_group`
--
ALTER TABLE heroes_league_rank_reward_group
ADD INDEX heroes_league_rank_reward_group_0_reward_group_id (reward_group_id);

--
-- Create table `heroes_league_rank`
--
CREATE TABLE heroes_league_rank (
  id int(11) NOT NULL,
  league_rank_type int(11) NOT NULL,
  league_rank int(11) NOT NULL,
  league_min_value int(11) NOT NULL,
  league_max_value int(11) NOT NULL,
  ticket_num int(11) NOT NULL,
  reward_group_id int(11) NOT NULL,
  top_bgm_cue_name text NOT NULL,
  top_bgm_cuesheet_name text NOT NULL,
  racing_base_bgm_cue_name text NOT NULL,
  racing_base_bgm_cuesheet_name text NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1024,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `heroes_league_rank_0_league_rank` on table `heroes_league_rank`
--
ALTER TABLE heroes_league_rank
ADD INDEX heroes_league_rank_0_league_rank (league_rank);

--
-- Create table `heroes_gauge`
--
CREATE TABLE heroes_gauge (
  id int(11) NOT NULL,
  priority int(11) NOT NULL,
  condition_type int(11) NOT NULL,
  condition_value_1 int(11) NOT NULL,
  condition_value_2 int(11) NOT NULL,
  gauge_up int(11) NOT NULL,
  add_timing int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 2048,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `heroes_final_stage_race`
--
CREATE TABLE heroes_final_stage_race (
  id int(11) NOT NULL,
  ranking_min int(11) NOT NULL,
  ranking_max int(11) NOT NULL,
  group_id int(11) NOT NULL,
  race_number int(11) NOT NULL,
  race_play int(11) NOT NULL,
  heroes_special_reward int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 682,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `heroes_data`
--
CREATE TABLE heroes_data (
  heroes_id int(11) NOT NULL,
  info_detail_1 int(11) NOT NULL,
  info_detail_2 int(11) NOT NULL,
  ticket_add int(11) NOT NULL,
  ticket_max int(11) NOT NULL,
  race_item_limit int(11) NOT NULL,
  hero_gauge_max int(11) NOT NULL,
  final_stage_user_num int(11) NOT NULL,
  start_date int(11) NOT NULL,
  end_date int(11) NOT NULL,
  PRIMARY KEY (heroes_id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1820,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `gift_message`
--
CREATE TABLE gift_message (
  id int(11) NOT NULL,
  type_1 int(11) NOT NULL,
  type_2 int(11) NOT NULL,
  type_3 int(11) NOT NULL,
  type_4 int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 221,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `gacha_top_bg`
--
CREATE TABLE gacha_top_bg (
  id int(11) NOT NULL,
  gacha_id int(11) NOT NULL,
  logo_size_x int(11) NOT NULL,
  logo_size_y int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 182,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `gacha_top_bg_0_gacha_id` on table `gacha_top_bg`
--
ALTER TABLE gacha_top_bg
ADD INDEX gacha_top_bg_0_gacha_id (gacha_id);

--
-- Create table `gacha_stepup`
--
CREATE TABLE gacha_stepup (
  id int(11) NOT NULL,
  stepup_id int(11) NOT NULL,
  target_gacha_id int(11) NOT NULL,
  stepup_step int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1092,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `gacha_stepup_0_stepup_id` on table `gacha_stepup`
--
ALTER TABLE gacha_stepup
ADD INDEX gacha_stepup_0_stepup_id (stepup_id);

--
-- Create index `gacha_stepup_0_stepup_id_1_stepup_step` on table `gacha_stepup`
--
ALTER TABLE gacha_stepup
ADD UNIQUE INDEX gacha_stepup_0_stepup_id_1_stepup_step (stepup_id, stepup_step);

--
-- Create index `gacha_stepup_0_target_gacha_id` on table `gacha_stepup`
--
ALTER TABLE gacha_stepup
ADD UNIQUE INDEX gacha_stepup_0_target_gacha_id (target_gacha_id);

--
-- Create table `gacha_prize_odds`
--
CREATE TABLE gacha_prize_odds (
  prize_odds_id int(11) NOT NULL,
  place int(11) NOT NULL,
  odds int(11) NOT NULL,
  piece_num int(11) NOT NULL,
  item_category_1 int(11) NOT NULL,
  item_id_1 int(11) NOT NULL,
  item_num_1 int(11) NOT NULL,
  item_category_2 int(11) NOT NULL,
  item_id_2 int(11) NOT NULL,
  item_num_2 int(11) NOT NULL,
  item_category_3 int(11) NOT NULL,
  item_id_3 int(11) NOT NULL,
  item_num_3 int(11) NOT NULL,
  item_category_4 int(11) NOT NULL,
  item_id_4 int(11) NOT NULL,
  item_num_4 int(11) NOT NULL,
  item_category_5 int(11) NOT NULL,
  item_id_5 int(11) NOT NULL,
  item_num_5 int(11) NOT NULL,
  item_category_6 int(11) NOT NULL,
  item_id_6 int(11) NOT NULL,
  item_num_6 int(11) NOT NULL,
  PRIMARY KEY (prize_odds_id, place)
)
ENGINE = INNODB,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `gacha_prize_odds_0_prize_odds_id` on table `gacha_prize_odds`
--
ALTER TABLE gacha_prize_odds
ADD INDEX gacha_prize_odds_0_prize_odds_id (prize_odds_id);

--
-- Create table `gacha_piece`
--
CREATE TABLE gacha_piece (
  id int(11) NOT NULL,
  rarity int(11) NOT NULL,
  piece_type int(11) NOT NULL,
  piece_num int(11) NOT NULL,
  item_category int(11) NOT NULL,
  item_id int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 5461,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `gacha_piece_0_rarity` on table `gacha_piece`
--
ALTER TABLE gacha_piece
ADD INDEX gacha_piece_0_rarity (rarity);

--
-- Create table `gacha_group`
--
CREATE TABLE gacha_group (
  id int(11) NOT NULL,
  group_id int(11) NOT NULL,
  target_gacha_id int(11) NOT NULL,
  disp_order int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 819,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `gacha_group_0_group_id` on table `gacha_group`
--
ALTER TABLE gacha_group
ADD INDEX gacha_group_0_group_id (group_id);

--
-- Create index `gacha_group_0_target_gacha_id` on table `gacha_group`
--
ALTER TABLE gacha_group
ADD UNIQUE INDEX gacha_group_0_target_gacha_id (target_gacha_id);

--
-- Create table `gacha_free_campaign`
--
CREATE TABLE gacha_free_campaign (
  id int(11) NOT NULL,
  gacha_id int(11) NOT NULL,
  target_draw_type int(11) NOT NULL,
  start_date int(11) NOT NULL,
  end_date int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1092,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `gacha_exchange`
--
CREATE TABLE gacha_exchange (
  gacha_id int(11) NOT NULL,
  card_id int(11) NOT NULL,
  card_type int(11) NOT NULL,
  pay_item_num int(11) NOT NULL,
  disp_order int(11) NOT NULL,
  PRIMARY KEY (gacha_id, card_id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 93,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `gacha_exchange_0_gacha_id` on table `gacha_exchange`
--
ALTER TABLE gacha_exchange
ADD INDEX gacha_exchange_0_gacha_id (gacha_id);

--
-- Create table `gacha_data`
--
CREATE TABLE gacha_data (
  id int(11) NOT NULL,
  type int(11) NOT NULL,
  card_type int(11) NOT NULL,
  daily_pay_cost int(11) NOT NULL,
  disp_order int(11) NOT NULL,
  only_once_flag int(11) NOT NULL,
  rarity_odds_id int(11) NOT NULL,
  draw_guarantee_rarity int(11) NOT NULL,
  draw_guarantee_num int(11) NOT NULL,
  cost_type int(11) NOT NULL,
  cost_single int(11) NOT NULL,
  prize_odds_id int(11) NOT NULL,
  additional_piece_target_card_type_1 int(11) NOT NULL,
  additional_piece_target_card_id_1 int(11) NOT NULL,
  additional_piece_target_rarity_1 int(11) NOT NULL,
  additional_piece_num_1 int(11) NOT NULL,
  additional_piece_target_card_type_2 int(11) NOT NULL,
  additional_piece_target_card_id_2 int(11) NOT NULL,
  additional_piece_target_rarity_2 int(11) NOT NULL,
  additional_piece_num_2 int(11) NOT NULL,
  additional_piece_target_card_type_3 int(11) NOT NULL,
  additional_piece_target_card_id_3 int(11) NOT NULL,
  additional_piece_target_rarity_3 int(11) NOT NULL,
  additional_piece_num_3 int(11) NOT NULL,
  additional_piece_target_card_type_4 int(11) NOT NULL,
  additional_piece_target_card_id_4 int(11) NOT NULL,
  additional_piece_target_rarity_4 int(11) NOT NULL,
  additional_piece_num_4 int(11) NOT NULL,
  additional_piece_target_card_type_5 int(11) NOT NULL,
  additional_piece_target_card_id_5 int(11) NOT NULL,
  additional_piece_target_rarity_5 int(11) NOT NULL,
  additional_piece_num_5 int(11) NOT NULL,
  additional_piece_target_card_type_6 int(11) NOT NULL,
  additional_piece_target_card_id_6 int(11) NOT NULL,
  additional_piece_target_rarity_6 int(11) NOT NULL,
  additional_piece_num_6 int(11) NOT NULL,
  bonus_target_draw_num int(11) NOT NULL,
  bonus_item_category_1 int(11) NOT NULL,
  bonus_item_id_1 int(11) NOT NULL,
  bonus_item_num_1 int(11) NOT NULL,
  bonus_item_category_2 int(11) NOT NULL,
  bonus_item_id_2 int(11) NOT NULL,
  bonus_item_num_2 int(11) NOT NULL,
  start_date int(11) NOT NULL,
  end_date int(11) NOT NULL,
  paid_gacha_button_type int(11) NOT NULL,
  gacha_odds_id int(11) NOT NULL,
  draw_guarantee_type int(11) NOT NULL,
  draw_limit int(11) NOT NULL,
  force_exchange int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 546,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `gacha_available`
--
CREATE TABLE gacha_available (
  gacha_id int(11) NOT NULL,
  card_id int(11) NOT NULL,
  card_type int(11) NOT NULL,
  rarity int(11) NOT NULL,
  odds int(11) NOT NULL,
  is_pickup int(11) NOT NULL,
  recommend_order int(11) NOT NULL,
  is_prize_selectable int(11) NOT NULL,
  PRIMARY KEY (gacha_id, card_id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 207,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `gacha_available_0_gacha_id` on table `gacha_available`
--
ALTER TABLE gacha_available
ADD INDEX gacha_available_0_gacha_id (gacha_id);

--
-- Create table `fan_raid_top_data`
--
CREATE TABLE fan_raid_top_data (
  id int(11) NOT NULL,
  fan_raid_id int(11) NOT NULL,
  bg_id int(11) NOT NULL,
  bg_sub_id int(11) NOT NULL,
  bgm_cue_name text NOT NULL,
  bgm_cuesheet_name text NOT NULL,
  env_cue_name text NOT NULL,
  env_cuesheet_name text NOT NULL,
  start_date int(11) NOT NULL,
  end_date int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 4096,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `fan_raid_top_data_0_fan_raid_id` on table `fan_raid_top_data`
--
ALTER TABLE fan_raid_top_data
ADD INDEX fan_raid_top_data_0_fan_raid_id (fan_raid_id);

--
-- Create table `fan_raid_top_chara`
--
CREATE TABLE fan_raid_top_chara (
  id int(11) NOT NULL,
  top_data_id int(11) NOT NULL,
  chara_id int(11) NOT NULL,
  dress_id int(11) NOT NULL,
  mini_motion_id int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1638,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `fan_raid_top_chara_0_top_data_id` on table `fan_raid_top_chara`
--
ALTER TABLE fan_raid_top_chara
ADD INDEX fan_raid_top_chara_0_top_data_id (top_data_id);

--
-- Create table `fan_raid_story_data`
--
CREATE TABLE fan_raid_story_data (
  id int(11) NOT NULL,
  fan_raid_id int(11) NOT NULL,
  story_condition_type int(11) NOT NULL,
  story_type_1 int(11) NOT NULL,
  story_id_1 int(11) NOT NULL,
  story_type_2 int(11) NOT NULL,
  story_id_2 int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 8192,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `fan_raid_story_data_0_fan_raid_id_1_story_condition_type` on table `fan_raid_story_data`
--
ALTER TABLE fan_raid_story_data
ADD INDEX fan_raid_story_data_0_fan_raid_id_1_story_condition_type (fan_raid_id, story_condition_type);

--
-- Create table `fan_raid_individual_reward`
--
CREATE TABLE fan_raid_individual_reward (
  id int(11) NOT NULL,
  fan_raid_id int(11) NOT NULL,
  individual_fan int(11) NOT NULL,
  item_category int(11) NOT NULL,
  item_id int(11) NOT NULL,
  item_num int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 2340,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `fan_raid_individual_reward_0_fan_raid_id` on table `fan_raid_individual_reward`
--
ALTER TABLE fan_raid_individual_reward
ADD INDEX fan_raid_individual_reward_0_fan_raid_id (fan_raid_id);

--
-- Create table `fan_raid_data`
--
CREATE TABLE fan_raid_data (
  fan_raid_id int(11) NOT NULL,
  condition_type int(11) NOT NULL,
  condition_value int(11) NOT NULL,
  chara_id int(11) NOT NULL,
  dress_id int(11) NOT NULL,
  result_se_cue_name text NOT NULL,
  result_se_cuesheet_name text NOT NULL,
  start_date int(11) NOT NULL,
  calc_start_date int(11) NOT NULL,
  calc_end_date int(11) NOT NULL,
  end_date int(11) NOT NULL,
  PRIMARY KEY (fan_raid_id)
)
ENGINE = INNODB,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `fan_raid_bonus_support_card`
--
CREATE TABLE fan_raid_bonus_support_card (
  id int(11) NOT NULL,
  fan_raid_id int(11) NOT NULL,
  support_card_id int(11) NOT NULL,
  add_fan int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 5461,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `fan_raid_bonus_support_card_0_fan_raid_id` on table `fan_raid_bonus_support_card`
--
ALTER TABLE fan_raid_bonus_support_card
ADD INDEX fan_raid_bonus_support_card_0_fan_raid_id (fan_raid_id);

--
-- Create table `fan_raid_bonus_chara`
--
CREATE TABLE fan_raid_bonus_chara (
  id int(11) NOT NULL,
  fan_raid_id int(11) NOT NULL,
  chara_id int(11) NOT NULL,
  add_fan int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `fan_raid_bonus_chara_0_fan_raid_id` on table `fan_raid_bonus_chara`
--
ALTER TABLE fan_raid_bonus_chara
ADD INDEX fan_raid_bonus_chara_0_fan_raid_id (fan_raid_id);

--
-- Create table `fan_raid_all_reward`
--
CREATE TABLE fan_raid_all_reward (
  id int(11) NOT NULL,
  fan_raid_id int(11) NOT NULL,
  all_fan int(11) NOT NULL,
  item_category int(11) NOT NULL,
  item_id int(11) NOT NULL,
  item_num int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 2340,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `fan_raid_all_reward_0_fan_raid_id` on table `fan_raid_all_reward`
--
ALTER TABLE fan_raid_all_reward
ADD INDEX fan_raid_all_reward_0_fan_raid_id (fan_raid_id);

--
-- Create table `factor_research_top`
--
CREATE TABLE factor_research_top (
  id int(11) NOT NULL,
  factor_research_event_id int(11) NOT NULL,
  ending_flag int(11) NOT NULL,
  character_id int(11) NOT NULL,
  dress_id int(11) NOT NULL,
  menu_bg_id int(11) NOT NULL,
  menu_bg_sub_id int(11) NOT NULL,
  bgm_cue_name text NOT NULL,
  bgm_cuesheet_name text NOT NULL,
  env_cue_name text NOT NULL,
  env_cuesheet_name text NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 682,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `factor_research_top_0_factor_research_event_id_1_ending_flag` on table `factor_research_top`
--
ALTER TABLE factor_research_top
ADD INDEX factor_research_top_0_factor_research_event_id_1_ending_flag (factor_research_event_id, ending_flag);

--
-- Create table `factor_research_factor_upgrade`
--
CREATE TABLE factor_research_factor_upgrade (
  id int(11) NOT NULL,
  factor_type int(11) NOT NULL,
  is_upgradable int(11) NOT NULL,
  factor_rarity int(11) NOT NULL,
  use_item_num int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1170,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `factor_research_factor_upgrade_0_factor_type` on table `factor_research_factor_upgrade`
--
ALTER TABLE factor_research_factor_upgrade
ADD INDEX factor_research_factor_upgrade_0_factor_type (factor_type);

--
-- Create table `factor_research_data`
--
CREATE TABLE factor_research_data (
  factor_research_event_id int(11) NOT NULL,
  consume_tp_ratio int(11) NOT NULL,
  bonus_reward_ratio int(11) NOT NULL,
  result_type int(11) NOT NULL,
  chara_id int(11) NOT NULL,
  dress_id int(11) NOT NULL,
  in_motion int(11) NOT NULL,
  stand_motion int(11) NOT NULL,
  prize_motion1 int(11) NOT NULL,
  prize_motion2 int(11) NOT NULL,
  notice_date int(11) NOT NULL,
  start_date int(11) NOT NULL,
  ending_date int(11) NOT NULL,
  end_date int(11) NOT NULL,
  special_event_type int(11) NOT NULL,
  PRIMARY KEY (factor_research_event_id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1820,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `factor_research_box_reward`
--
CREATE TABLE factor_research_box_reward (
  id int(11) NOT NULL,
  box_id int(11) NOT NULL,
  box_num int(11) NOT NULL,
  item_category int(11) NOT NULL,
  item_id int(11) NOT NULL,
  item_num int(11) NOT NULL,
  rate int(11) NOT NULL,
  prize_type int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 123,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `factor_research_box_reward_0_box_id` on table `factor_research_box_reward`
--
ALTER TABLE factor_research_box_reward
ADD INDEX factor_research_box_reward_0_box_id (box_id);

--
-- Create table `factor_research_box`
--
CREATE TABLE factor_research_box (
  box_id int(11) NOT NULL,
  factor_research_event_id int(11) NOT NULL,
  box_step int(11) NOT NULL,
  PRIMARY KEY (box_id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1820,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `factor_research_box_0_factor_research_event_id` on table `factor_research_box`
--
ALTER TABLE factor_research_box
ADD INDEX factor_research_box_0_factor_research_event_id (factor_research_event_id);

--
-- Create table `factor_research_animation_data`
--
CREATE TABLE factor_research_animation_data (
  id int(11) NOT NULL,
  special_event_type int(11) NOT NULL,
  prise_type int(11) NOT NULL,
  chara_order int(11) NOT NULL,
  chara_angle int(11) NOT NULL,
  chara_id int(11) NOT NULL,
  dress_id int(11) NOT NULL,
  in_motion int(11) NOT NULL,
  stand_motion int(11) NOT NULL,
  prize_motion int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 2340,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `factor_research_animation_data_0_special_event_type_1_prise_type` on table `factor_research_animation_data`
--
ALTER TABLE factor_research_animation_data
ADD INDEX factor_research_animation_data_0_special_event_type_1_prise_type (special_event_type, prise_type);

--
-- Create table `facial_mouth_change`
--
CREATE TABLE facial_mouth_change (
  id int(11) NOT NULL,
  chara_id int(11) NOT NULL,
  before_facialname text NOT NULL,
  after_facialname text NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1170,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `facial_mouth_change_0_chara_id` on table `facial_mouth_change`
--
ALTER TABLE facial_mouth_change
ADD INDEX facial_mouth_change_0_chara_id (chara_id);

--
-- Create index `facial_mouth_change_0_chara_id_1_before_facialname` on table `facial_mouth_change`
--
ALTER TABLE facial_mouth_change
ADD UNIQUE INDEX facial_mouth_change_0_chara_id_1_before_facialname USING HASH (chara_id, before_facialname);

--
-- Create table `face_type_data`
--
CREATE TABLE face_type_data (
  label varchar(300) NOT NULL,
  eyebrow_l text NOT NULL,
  eyebrow_r text NOT NULL,
  eye_l text NOT NULL,
  eye_r text NOT NULL,
  mouth text NOT NULL,
  mouth_shape_type int(11) NOT NULL,
  inverce_face_type text NOT NULL,
  set_face_group int(11) NOT NULL,
  PRIMARY KEY (label)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 143,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `exchange_ticket_detail`
--
CREATE TABLE exchange_ticket_detail (
  id int(11) NOT NULL,
  card_type int(11) NOT NULL,
  card_id int(11) NOT NULL,
  additional_piece_num int(11) NOT NULL,
  start_date int(11) NOT NULL,
  end_date int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 50,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `exchange_ticket_detail_0_card_type` on table `exchange_ticket_detail`
--
ALTER TABLE exchange_ticket_detail
ADD INDEX exchange_ticket_detail_0_card_type (card_type);

--
-- Create table `event_motion_plus_data`
--
CREATE TABLE event_motion_plus_data (
  id int(11) NOT NULL,
  command_name text NOT NULL,
  base_state_name varchar(750) NOT NULL,
  layer_index int(11) NOT NULL,
  tail_motion_type int(11) NOT NULL,
  start_blend_time int(11) NOT NULL,
  end_blend_time int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 109,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `event_motion_plus_data_0_base_state_name` on table `event_motion_plus_data`
--
ALTER TABLE event_motion_plus_data
ADD INDEX event_motion_plus_data_0_base_state_name (base_state_name);

--
-- Create index `event_motion_plus_data_0_layer_index` on table `event_motion_plus_data`
--
ALTER TABLE event_motion_plus_data
ADD INDEX event_motion_plus_data_0_layer_index (layer_index);

--
-- Create table `event_motion_data`
--
CREATE TABLE event_motion_data (
  id int(11) NOT NULL,
  command_name text NOT NULL,
  base_state_name text NOT NULL,
  pose_blend int(11) NOT NULL,
  type int(11) NOT NULL,
  state_group int(11) NOT NULL,
  category int(11) NOT NULL,
  start_blend_time int(11) NOT NULL,
  end_blend_time int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 109,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `command_name` on table `event_motion_data`
--
ALTER TABLE event_motion_data
ADD UNIQUE INDEX command_name USING HASH (command_name);

--
-- Create index `event_motion_data_0_type` on table `event_motion_data`
--
ALTER TABLE event_motion_data
ADD INDEX event_motion_data_0_type (type);

--
-- Create table `dress_data`
--
CREATE TABLE dress_data (
  id int(11) NOT NULL,
  condition_type int(11) NOT NULL,
  have_mini int(11) NOT NULL,
  general_purpose int(11) NOT NULL,
  chara_id int(11) NOT NULL,
  use_gender int(11) NOT NULL,
  body_shape int(11) NOT NULL,
  body_type int(11) NOT NULL,
  body_type_sub int(11) NOT NULL,
  body_setting int(11) NOT NULL,
  use_race int(11) NOT NULL,
  use_live int(11) NOT NULL,
  use_live_theater int(11) NOT NULL,
  use_home int(11) NOT NULL,
  is_wet int(11) NOT NULL,
  is_dirt int(11) NOT NULL,
  head_sub_id int(11) NOT NULL,
  use_season int(11) NOT NULL,
  dress_color_main text NOT NULL,
  dress_color_sub text NOT NULL,
  color_num int(11) NOT NULL,
  disp_order int(11) NOT NULL,
  tail_model_id int(11) NOT NULL,
  tail_model_sub_id int(11) NOT NULL,
  start_time int(11) NOT NULL,
  end_time int(11) NOT NULL,
  costume_type int(11) NOT NULL,
  use_dress_change int(11) NOT NULL,
  mini_mayu_shader_type int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 368,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `dress_data_0_body_type` on table `dress_data`
--
ALTER TABLE dress_data
ADD INDEX dress_data_0_body_type (body_type);

--
-- Create index `dress_data_0_chara_id` on table `dress_data`
--
ALTER TABLE dress_data
ADD INDEX dress_data_0_chara_id (chara_id);

--
-- Create index `dress_data_0_condition_type` on table `dress_data`
--
ALTER TABLE dress_data
ADD INDEX dress_data_0_condition_type (condition_type);

--
-- Create table `directory`
--
CREATE TABLE directory (
  id int(11) NOT NULL,
  required_point int(11) NOT NULL,
  rank_level int(11) NOT NULL,
  item_category_1 int(11) NOT NULL,
  item_id_1 int(11) NOT NULL,
  item_num_1 int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 81,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `directory_0_rank_level` on table `directory`
--
ALTER TABLE directory
ADD UNIQUE INDEX directory_0_rank_level (rank_level);

--
-- Create index `directory_0_required_point` on table `directory`
--
ALTER TABLE directory
ADD INDEX directory_0_required_point (required_point);

--
-- Create table `deck_recommend_organize`
--
CREATE TABLE deck_recommend_organize (
  id int(11) NOT NULL,
  distance_type int(11) NOT NULL,
  priority int(11) NOT NULL,
  command_id_1 int(11) NOT NULL,
  command_id_2 int(11) NOT NULL,
  command_id_3 int(11) NOT NULL,
  command_id_4 int(11) NOT NULL,
  command_id_5 int(11) NOT NULL,
  command_id_6 int(11) NOT NULL,
  start_date int(11) NOT NULL,
  end_date int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 3276,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `deck_recommend_organize_0_distance_type` on table `deck_recommend_organize`
--
ALTER TABLE deck_recommend_organize
ADD INDEX deck_recommend_organize_0_distance_type (distance_type);

--
-- Create table `deck_recommend_lv_correction`
--
CREATE TABLE deck_recommend_lv_correction (
  condition_type int(11) NOT NULL,
  correction_lv int(11) NOT NULL,
  PRIMARY KEY (condition_type)
)
ENGINE = INNODB,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `deck_recommend_exception`
--
CREATE TABLE deck_recommend_exception (
  support_card_id int(11) NOT NULL,
  distribution_flag int(11) NOT NULL,
  PRIMARY KEY (support_card_id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1820,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `daily_race_npc`
--
CREATE TABLE daily_race_npc (
  id int(11) NOT NULL,
  npc_group_id int(11) NOT NULL,
  chara_id int(11) NOT NULL,
  mob_id int(11) NOT NULL,
  race_dress_id int(11) NOT NULL,
  race_instance_id int(11) NOT NULL,
  speed int(11) NOT NULL,
  stamina int(11) NOT NULL,
  pow int(11) NOT NULL,
  guts int(11) NOT NULL,
  wiz int(11) NOT NULL,
  proper_distance_short int(11) NOT NULL,
  proper_distance_mile int(11) NOT NULL,
  proper_distance_middle int(11) NOT NULL,
  proper_distance_long int(11) NOT NULL,
  proper_running_style_nige int(11) NOT NULL,
  proper_running_style_senko int(11) NOT NULL,
  proper_running_style_sashi int(11) NOT NULL,
  proper_running_style_oikomi int(11) NOT NULL,
  proper_ground_turf int(11) NOT NULL,
  proper_ground_dirt int(11) NOT NULL,
  skill_set_id int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 122,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `daily_race_billing`
--
CREATE TABLE daily_race_billing (
  id int(11) NOT NULL,
  frequency int(11) NOT NULL,
  pay_cost int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 16384,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `daily_race`
--
CREATE TABLE daily_race (
  id int(11) NOT NULL,
  group_id int(11) NOT NULL,
  difficulty int(11) NOT NULL,
  race_instance_id int(11) NOT NULL,
  cost_num int(11) NOT NULL,
  unique_chara_npc_min int(11) NOT NULL,
  unique_chara_npc_max int(11) NOT NULL,
  normal_rewards_odds_id int(11) NOT NULL,
  bonus_rewards_odds_id int(11) NOT NULL,
  rare_reward_odds_id int(11) NOT NULL,
  first_clear_item_category_1 int(11) NOT NULL,
  first_clear_item_id_1 int(11) NOT NULL,
  first_clear_item_num_1 int(11) NOT NULL,
  first_clear_item_category_2 int(11) NOT NULL,
  first_clear_item_id_2 int(11) NOT NULL,
  first_clear_item_num_2 int(11) NOT NULL,
  first_clear_item_category_3 int(11) NOT NULL,
  first_clear_item_id_3 int(11) NOT NULL,
  first_clear_item_num_3 int(11) NOT NULL,
  pick_up_item_category_1 int(11) NOT NULL,
  pick_up_item_id_1 int(11) NOT NULL,
  pick_up_item_num_1 int(11) NOT NULL,
  pick_up_item_category_2 int(11) NOT NULL,
  pick_up_item_id_2 int(11) NOT NULL,
  pick_up_item_num_2 int(11) NOT NULL,
  pick_up_item_category_3 int(11) NOT NULL,
  pick_up_item_id_3 int(11) NOT NULL,
  pick_up_item_num_3 int(11) NOT NULL,
  start_date int(11) NOT NULL,
  end_date int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 2730,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `daily_race_0_race_instance_id` on table `daily_race`
--
ALTER TABLE daily_race
ADD INDEX daily_race_0_race_instance_id (race_instance_id);

--
-- Create table `daily_pack`
--
CREATE TABLE daily_pack (
  shop_data_id int(11) NOT NULL,
  platform_id int(11) NOT NULL,
  term int(11) NOT NULL,
  repurchase_day int(11) NOT NULL,
  group_id int(11) NOT NULL,
  daily_free_num int(11) NOT NULL,
  start_date text NOT NULL,
  end_date text NOT NULL,
  PRIMARY KEY (shop_data_id, platform_id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 5461,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `daily_pack_0_group_id` on table `daily_pack`
--
ALTER TABLE daily_pack
ADD INDEX daily_pack_0_group_id (group_id);

--
-- Create table `daily_legend_race`
--
CREATE TABLE daily_legend_race (
  id int(11) NOT NULL,
  group_id int(11) NOT NULL,
  legend_bg_id int(11) NOT NULL,
  legend_bg_sub_id int(11) NOT NULL,
  image_id int(11) NOT NULL,
  difficulty int(11) NOT NULL,
  race_instance_id int(11) NOT NULL,
  season int(11) NOT NULL,
  weather int(11) NOT NULL,
  ground int(11) NOT NULL,
  legend_race_boss_npc_id int(11) NOT NULL,
  cost_num int(11) NOT NULL,
  drop_reward_odds_id int(11) NOT NULL,
  victory_reward_odds_id int(11) NOT NULL,
  first_clear_item_category_1 int(11) NOT NULL,
  first_clear_item_id_1 int(11) NOT NULL,
  first_clear_item_num_1 int(11) NOT NULL,
  first_clear_item_category_2 int(11) NOT NULL,
  first_clear_item_id_2 int(11) NOT NULL,
  first_clear_item_num_2 int(11) NOT NULL,
  first_clear_item_category_3 int(11) NOT NULL,
  first_clear_item_id_3 int(11) NOT NULL,
  first_clear_item_num_3 int(11) NOT NULL,
  pick_up_item_category_1 int(11) NOT NULL,
  pick_up_item_id_1 int(11) NOT NULL,
  pick_up_item_num_1 int(11) NOT NULL,
  pick_up_item_category_2 int(11) NOT NULL,
  pick_up_item_id_2 int(11) NOT NULL,
  pick_up_item_num_2 int(11) NOT NULL,
  pick_up_item_category_3 int(11) NOT NULL,
  pick_up_item_id_3 int(11) NOT NULL,
  pick_up_item_num_3 int(11) NOT NULL,
  start_date int(11) NOT NULL,
  has_unique_bg_env int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 264,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `daily_legend_race_0_group_id` on table `daily_legend_race`
--
ALTER TABLE daily_legend_race
ADD INDEX daily_legend_race_0_group_id (group_id);

--
-- Create index `daily_legend_race_0_race_instance_id` on table `daily_legend_race`
--
ALTER TABLE daily_legend_race
ADD INDEX daily_legend_race_0_race_instance_id (race_instance_id);

--
-- Create table `crane_game_prop`
--
CREATE TABLE crane_game_prop (
  type int(11) NOT NULL,
  num int(11) NOT NULL,
  PRIMARY KEY (type)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 8192,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `crane_game_prize_pattern`
--
CREATE TABLE crane_game_prize_pattern (
  id int(11) NOT NULL,
  prop_pattern_id int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 5461,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `crane_game_prize_face`
--
CREATE TABLE crane_game_prize_face (
  id int(11) NOT NULL,
  face_type text NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 5461,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `crane_game_hidden_odds`
--
CREATE TABLE crane_game_hidden_odds (
  id int(11) NOT NULL,
  animation_id int(11) NOT NULL,
  crane_animation_id int(11) NOT NULL,
  type_id int(11) NOT NULL,
  num int(11) NOT NULL,
  big int(11) NOT NULL,
  big_index int(11) NOT NULL,
  odds_1 int(11) NOT NULL,
  odds_2 int(11) NOT NULL,
  odds_3 int(11) NOT NULL,
  odds_extra int(11) NOT NULL,
  rare_effect_odds int(11) NOT NULL,
  joint_type int(11) NOT NULL,
  lift_type int(11) NOT NULL,
  push_type int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 496,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `crane_game_extra_odds_condition`
--
CREATE TABLE crane_game_extra_odds_condition (
  credit int(11) NOT NULL,
  get_num int(11) NOT NULL,
  PRIMARY KEY (credit)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 16384,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `crane_game_define_param`
--
CREATE TABLE crane_game_define_param (
  id int(11) NOT NULL,
  distance1 text NOT NULL,
  distance2 text NOT NULL,
  move_speed_1 text NOT NULL,
  move_speed_2 text NOT NULL,
  move_speed_3 text NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 16384,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `crane_game_catch_result`
--
CREATE TABLE crane_game_catch_result (
  odds_id int(11) NOT NULL,
  get_num int(11) NOT NULL,
  lottery_weight_1_1 int(11) NOT NULL,
  lottery_weight_1_2 int(11) NOT NULL,
  lottery_weight_2_1 int(11) NOT NULL,
  lottery_weight_2_2 int(11) NOT NULL,
  lottery_weight_3_1 int(11) NOT NULL,
  lottery_weight_3_2 int(11) NOT NULL,
  lottery_weight_extra_1 int(11) NOT NULL,
  lottery_weight_extra_2 int(11) NOT NULL,
  PRIMARY KEY (odds_id, get_num)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 240,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `crane_game_arm_swing`
--
CREATE TABLE crane_game_arm_swing (
  result_type int(11) NOT NULL,
  odds_1 int(11) NOT NULL,
  odds_2 int(11) NOT NULL,
  odds_3 int(11) NOT NULL,
  PRIMARY KEY (result_type)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 5461,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `collect_raid_top_data`
--
CREATE TABLE collect_raid_top_data (
  id int(11) NOT NULL,
  collect_raid_id int(11) NOT NULL,
  cut_id int(11) NOT NULL,
  cut_sub_id int(11) NOT NULL,
  bgm_cue_name text NOT NULL,
  bgm_cuesheet_name text NOT NULL,
  env_cue_name text NOT NULL,
  env_cuesheet_name text NOT NULL,
  segment_cutt_id int(11) NOT NULL,
  condition_type int(11) NOT NULL,
  condition_value int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 2048,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `collect_raid_top_data_0_collect_raid_id` on table `collect_raid_top_data`
--
ALTER TABLE collect_raid_top_data
ADD INDEX collect_raid_top_data_0_collect_raid_id (collect_raid_id);

--
-- Create table `collect_raid_story`
--
CREATE TABLE collect_raid_story (
  id int(11) NOT NULL,
  story_set_id int(11) NOT NULL,
  story_condition_type int(11) NOT NULL,
  episode_index_id int(11) NOT NULL,
  story_type_1 int(11) NOT NULL,
  story_id_1 int(11) NOT NULL,
  story_type_2 int(11) NOT NULL,
  story_id_2 int(11) NOT NULL,
  story_type_3 int(11) NOT NULL,
  story_id_3 int(11) NOT NULL,
  collect_raid_id int(11) NOT NULL,
  unlock_condition int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 3276,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `collect_raid_story_0_story_set_id` on table `collect_raid_story`
--
ALTER TABLE collect_raid_story
ADD INDEX collect_raid_story_0_story_set_id (story_set_id);

--
-- Create table `collect_raid_staging_mini_chara`
--
CREATE TABLE collect_raid_staging_mini_chara (
  id int(11) NOT NULL,
  staging_mini_chara_group_id int(11) NOT NULL,
  staging_type int(11) NOT NULL,
  chara_id int(11) NOT NULL,
  dress_id int(11) NOT NULL,
  mini_motion_id int(11) NOT NULL,
  chara_angle int(11) NOT NULL,
  chara_id_2 int(11) NOT NULL,
  dress_id_2 int(11) NOT NULL,
  mini_motion_id_2 int(11) NOT NULL,
  chara_angle_2 int(11) NOT NULL,
  chara_id_3 int(11) NOT NULL,
  dress_id_3 int(11) NOT NULL,
  mini_motion_id_3 int(11) NOT NULL,
  chara_angle_3 int(11) NOT NULL,
  chara_id_4 int(11) NOT NULL,
  dress_id_4 int(11) NOT NULL,
  mini_motion_id_4 int(11) NOT NULL,
  chara_angle_4 int(11) NOT NULL,
  rate int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 780,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `collect_raid_staging_mini_chara_0_staging_mini_chara_group_id` on table `collect_raid_staging_mini_chara`
--
ALTER TABLE collect_raid_staging_mini_chara
ADD INDEX collect_raid_staging_mini_chara_0_staging_mini_chara_group_id (staging_mini_chara_group_id);

--
-- Create index `collect_raid_staging_mini_chara_0_staging_mini_chara_group_id_1` on table `collect_raid_staging_mini_chara`
--
ALTER TABLE collect_raid_staging_mini_chara
ADD INDEX collect_raid_staging_mini_chara_0_staging_mini_chara_group_id_1 (staging_mini_chara_group_id, staging_type);

--
-- Create table `collect_raid_segment_cutt`
--
CREATE TABLE collect_raid_segment_cutt (
  id int(11) NOT NULL,
  cut_id int(11) NOT NULL,
  cut_sub_id int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 5461,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `collect_raid_mission_top_chara`
--
CREATE TABLE collect_raid_mission_top_chara (
  id int(11) NOT NULL,
  mission_top_chara_group_id int(11) NOT NULL,
  ending_flag int(11) NOT NULL,
  chara_id int(11) NOT NULL,
  dress_id int(11) NOT NULL,
  bg_id int(11) NOT NULL,
  bg_sub_id int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 4096,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `collect_raid_mission_top_chara_0_mission_top_chara_group_id` on table `collect_raid_mission_top_chara`
--
ALTER TABLE collect_raid_mission_top_chara
ADD INDEX collect_raid_mission_top_chara_0_mission_top_chara_group_id (mission_top_chara_group_id);

--
-- Create table `collect_raid_mission`
--
CREATE TABLE collect_raid_mission (
  id int(11) NOT NULL,
  collect_raid_master_id int(11) NOT NULL,
  mission_data_id int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 910,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `collect_raid_mission_0_mission_data_id` on table `collect_raid_mission`
--
ALTER TABLE collect_raid_mission
ADD INDEX collect_raid_mission_0_mission_data_id (mission_data_id);

--
-- Create table `collect_raid_master`
--
CREATE TABLE collect_raid_master (
  id int(11) NOT NULL,
  collect_item_id int(11) NOT NULL,
  gain_collect_item_rate int(11) NOT NULL,
  gain_collect_item_min int(11) NOT NULL,
  individual_reward_set_id int(11) NOT NULL,
  all_reward_set_id int(11) NOT NULL,
  story_set_id int(11) NOT NULL,
  mission_top_chara_group_id int(11) NOT NULL,
  staging_mini_chara_group_id int(11) NOT NULL,
  story_list_bg_id int(11) NOT NULL,
  story_list_bg_sub_id int(11) NOT NULL,
  collect_event_map_master_id int(11) NOT NULL,
  notice_date int(11) NOT NULL,
  start_date int(11) NOT NULL,
  calc_start_date int(11) NOT NULL,
  calc_end_date int(11) NOT NULL,
  end_date int(11) NOT NULL,
  use_mission int(11) NOT NULL,
  use_transition_dialog int(11) NOT NULL,
  story_extra_id int(11) NOT NULL,
  story_voice_type int(11) NOT NULL,
  use_all_reward_voice int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 8192,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `collect_raid_master_0_individual_reward_set_id` on table `collect_raid_master`
--
ALTER TABLE collect_raid_master
ADD INDEX collect_raid_master_0_individual_reward_set_id (individual_reward_set_id);

--
-- Create table `collect_raid_individual_reward`
--
CREATE TABLE collect_raid_individual_reward (
  id int(11) NOT NULL,
  individual_reward_set_id int(11) NOT NULL,
  individual_collect_item_num int(11) NOT NULL,
  item_category int(11) NOT NULL,
  item_id int(11) NOT NULL,
  item_num int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1092,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `collect_raid_individual_reward_0_individual_reward_set_id` on table `collect_raid_individual_reward`
--
ALTER TABLE collect_raid_individual_reward
ADD INDEX collect_raid_individual_reward_0_individual_reward_set_id (individual_reward_set_id);

--
-- Create table `collect_raid_dress_color`
--
CREATE TABLE collect_raid_dress_color (
  id int(11) NOT NULL,
  collect_raid_id int(11) NOT NULL,
  chara_id int(11) NOT NULL,
  dress_id int(11) NOT NULL,
  color_id int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 4096,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `collect_raid_dress_color_0_collect_raid_id` on table `collect_raid_dress_color`
--
ALTER TABLE collect_raid_dress_color
ADD INDEX collect_raid_dress_color_0_collect_raid_id (collect_raid_id);

--
-- Create table `collect_raid_all_reward`
--
CREATE TABLE collect_raid_all_reward (
  id int(11) NOT NULL,
  all_reward_set_id int(11) NOT NULL,
  all_collect_item_num int(11) NOT NULL,
  item_category int(11) NOT NULL,
  item_id int(11) NOT NULL,
  item_num int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 963,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `collect_raid_all_reward_0_all_reward_set_id` on table `collect_raid_all_reward`
--
ALTER TABLE collect_raid_all_reward
ADD INDEX collect_raid_all_reward_0_all_reward_set_id (all_reward_set_id);

--
-- Create table `collect_event_map_master`
--
CREATE TABLE collect_event_map_master (
  id int(11) NOT NULL,
  bg_data_id int(11) NOT NULL,
  short_episode_id int(11) NOT NULL,
  tips_group_id int(11) NOT NULL,
  login_bonus_id int(11) NOT NULL,
  banner_id int(11) NOT NULL,
  collect_tap_max_pos_index int(11) NOT NULL,
  collect_tap_reward_set_id int(11) NOT NULL,
  collect_tap_end_date int(11) NOT NULL,
  start_date int(11) NOT NULL,
  event_end_date int(11) NOT NULL,
  end_date int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `collect_event_map_bg_data`
--
CREATE TABLE collect_event_map_bg_data (
  id int(11) NOT NULL,
  bg_id int(11) NOT NULL,
  bg_sub_id int(11) NOT NULL,
  bgm_cue_name text NOT NULL,
  bgm_cuesheet_name text NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `circle_stamp_data`
--
CREATE TABLE circle_stamp_data (
  id int(11) NOT NULL,
  type int(11) NOT NULL,
  disp_order int(11) NOT NULL,
  start_date text NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 409,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `disp_order` on table `circle_stamp_data`
--
ALTER TABLE circle_stamp_data
ADD UNIQUE INDEX disp_order (disp_order);

--
-- Create table `circle_rank_data`
--
CREATE TABLE circle_rank_data (
  id int(11) NOT NULL,
  need_ranking_max int(11) NOT NULL,
  need_ranking_min int(11) NOT NULL,
  reward_item_category_1 int(11) NOT NULL,
  reward_item_id_1 int(11) NOT NULL,
  reward_num_1 int(11) NOT NULL,
  reward_item_category_2 int(11) NOT NULL,
  reward_item_id_2 int(11) NOT NULL,
  reward_num_2 int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1489,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `chara_type`
--
CREATE TABLE chara_type (
  id varchar(20) NOT NULL,
  chara_id int(11) NOT NULL,
  target_scene int(11) NOT NULL,
  target_cut int(11) NOT NULL,
  target_type int(11) NOT NULL,
  value int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 102,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `chara_type_0_target_scene_1_target_cut` on table `chara_type`
--
ALTER TABLE chara_type
ADD INDEX chara_type_0_target_scene_1_target_cut (target_scene, target_cut);

--
-- Create table `chara_story_data`
--
CREATE TABLE chara_story_data (
  id int(11) NOT NULL,
  chara_id int(11) NOT NULL,
  episode_index int(11) NOT NULL,
  story_id int(11) NOT NULL,
  lock_type_1 int(11) NOT NULL,
  lock_value_1_1 int(11) NOT NULL,
  lock_value_1_2 int(11) NOT NULL,
  add_reward_category_1 int(11) NOT NULL,
  add_reward_id_1 int(11) NOT NULL,
  add_reward_num_1 int(11) NOT NULL,
  exp_type int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 137,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `chara_story_data_0_chara_id` on table `chara_story_data`
--
ALTER TABLE chara_story_data
ADD INDEX chara_story_data_0_chara_id (chara_id);

--
-- Create index `chara_story_data_0_chara_id_1_episode_index` on table `chara_story_data`
--
ALTER TABLE chara_story_data
ADD INDEX chara_story_data_0_chara_id_1_episode_index (chara_id, episode_index);

--
-- Create index `chara_story_data_0_story_id` on table `chara_story_data`
--
ALTER TABLE chara_story_data
ADD UNIQUE INDEX chara_story_data_0_story_id (story_id);

--
-- Create table `chara_motion_set`
--
CREATE TABLE chara_motion_set (
  id int(11) NOT NULL,
  body_motion text NOT NULL,
  body_motion_type int(11) NOT NULL,
  body_motion_play_type int(11) NOT NULL,
  face_type text NOT NULL,
  cheek int(11) NOT NULL,
  eye_default int(11) NOT NULL,
  ear_motion text NOT NULL,
  tail_motion text NOT NULL,
  tail_motion_type int(11) NOT NULL,
  body_motion_path_segment int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 79,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `chara_motion_act`
--
CREATE TABLE chara_motion_act (
  id int(11) NOT NULL,
  chara_id int(11) NOT NULL,
  target_motion int(11) NOT NULL,
  command_name text NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 455,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `chara_motion_act_0_chara_id` on table `chara_motion_act`
--
ALTER TABLE chara_motion_act
ADD INDEX chara_motion_act_0_chara_id (chara_id);

--
-- Create index `chara_motion_act_0_chara_id_1_command_name` on table `chara_motion_act`
--
ALTER TABLE chara_motion_act
ADD UNIQUE INDEX chara_motion_act_0_chara_id_1_command_name USING HASH (chara_id, command_name);

--
-- Create table `chara_dress_color_set_default`
--
CREATE TABLE chara_dress_color_set_default (
  id int(11) NOT NULL,
  chara_id int(11) NOT NULL,
  color_set_id int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `chara_dress_color_set_default_0_chara_id` on table `chara_dress_color_set_default`
--
ALTER TABLE chara_dress_color_set_default
ADD INDEX chara_dress_color_set_default_0_chara_id (chara_id);

--
-- Create table `chara_dress_color_set`
--
CREATE TABLE chara_dress_color_set (
  id int(11) NOT NULL,
  dress_id int(11) NOT NULL,
  area_map_id int(11) NOT NULL,
  color_r1 text NOT NULL,
  color_r2 text NOT NULL,
  color_g1 text NOT NULL,
  color_g2 text NOT NULL,
  color_b1 text NOT NULL,
  color_b2 text NOT NULL,
  toon_color_r1 text NOT NULL,
  toon_color_r2 text NOT NULL,
  toon_color_g1 text NOT NULL,
  toon_color_g2 text NOT NULL,
  toon_color_b1 text NOT NULL,
  toon_color_b2 text NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `chara_dress_color_set_0_dress_id` on table `chara_dress_color_set`
--
ALTER TABLE chara_dress_color_set
ADD INDEX chara_dress_color_set_0_dress_id (dress_id);

--
-- Create table `chara_data_group`
--
CREATE TABLE chara_data_group (
  id int(11) NOT NULL,
  group_id int(11) NOT NULL,
  chara_id int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 5461,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `chara_data_group_0_chara_id` on table `chara_data_group`
--
ALTER TABLE chara_data_group
ADD INDEX chara_data_group_0_chara_id (chara_id);

--
-- Create index `chara_data_group_0_group_id` on table `chara_data_group`
--
ALTER TABLE chara_data_group
ADD INDEX chara_data_group_0_group_id (group_id);

--
-- Create table `chara_data`
--
CREATE TABLE chara_data (
  id int(11) NOT NULL,
  birth_year int(11) NOT NULL,
  birth_month int(11) NOT NULL,
  birth_day int(11) NOT NULL,
  sex int(11) NOT NULL,
  image_color_main text NOT NULL,
  image_color_sub text NOT NULL,
  ui_color_main text NOT NULL,
  ui_color_sub text NOT NULL,
  ui_training_color_1 text NOT NULL,
  ui_training_color_2 text NOT NULL,
  ui_border_color text NOT NULL,
  ui_num_color_1 text NOT NULL,
  ui_num_color_2 text NOT NULL,
  ui_turn_color text NOT NULL,
  ui_wipe_color_1 text NOT NULL,
  ui_wipe_color_2 text NOT NULL,
  ui_wipe_color_3 text NOT NULL,
  ui_speech_color_1 text NOT NULL,
  ui_speech_color_2 text NOT NULL,
  ui_nameplate_color_1 text NOT NULL,
  ui_nameplate_color_2 text NOT NULL,
  height int(11) NOT NULL,
  bust int(11) NOT NULL,
  scale int(11) NOT NULL,
  skin int(11) NOT NULL,
  shape int(11) NOT NULL,
  socks int(11) NOT NULL,
  personal_dress int(11) NOT NULL,
  tail_model_id int(11) NOT NULL,
  race_running_type int(11) NOT NULL,
  ear_random_time_min int(11) NOT NULL,
  ear_random_time_max int(11) NOT NULL,
  tail_random_time_min int(11) NOT NULL,
  tail_random_time_max int(11) NOT NULL,
  story_ear_random_time_min int(11) NOT NULL,
  story_ear_random_time_max int(11) NOT NULL,
  story_tail_random_time_min int(11) NOT NULL,
  story_tail_random_time_max int(11) NOT NULL,
  attachment_model_id int(11) NOT NULL,
  mini_mayu_shader_type int(11) NOT NULL,
  start_date int(11) NOT NULL,
  chara_category int(11) NOT NULL,
  love_rank_limit int(11) NOT NULL,
  last_year int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 592,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `chara_category_motion`
--
CREATE TABLE chara_category_motion (
  chara_id int(11) NOT NULL,
  standby_motion_1 int(11) NOT NULL,
  standby_motion_2 int(11) NOT NULL,
  standby_motion_3 int(11) NOT NULL,
  standby_motion_4 int(11) NOT NULL,
  standby_motion_5 int(11) NOT NULL,
  standby_motion_6 int(11) NOT NULL,
  PRIMARY KEY (chara_id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 321,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `character_system_text`
--
CREATE TABLE character_system_text (
  character_id int(11) NOT NULL,
  voice_id int(11) NOT NULL,
  text text NOT NULL,
  cue_sheet text NOT NULL,
  cue_id int(11) NOT NULL,
  motion_set int(11) NOT NULL,
  scene int(11) NOT NULL,
  use_gallery int(11) NOT NULL,
  card_id int(11) NOT NULL,
  lip_sync_data text NOT NULL,
  gender int(11) NOT NULL,
  motion_second_set int(11) NOT NULL,
  motion_second_start int(11) NOT NULL,
  start_date int(11) NOT NULL,
  gallery_key_usage_condition int(11) NOT NULL,
  PRIMARY KEY (character_id, voice_id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 547,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `character_system_text_0_character_id` on table `character_system_text`
--
ALTER TABLE character_system_text
ADD INDEX character_system_text_0_character_id (character_id);

--
-- Create table `character_system_lottery`
--
CREATE TABLE character_system_lottery (
  id int(11) NOT NULL,
  chara_id int(11) NOT NULL,
  card_id int(11) NOT NULL,
  card_rarity_id int(11) NOT NULL,
  `trigger` int(11) NOT NULL,
  param1 int(11) NOT NULL,
  per int(11) NOT NULL,
  priority int(11) NOT NULL,
  sys_text_id int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 71,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `character_system_lottery_0_chara_id` on table `character_system_lottery`
--
ALTER TABLE character_system_lottery
ADD INDEX character_system_lottery_0_chara_id (chara_id);

--
-- Create index `character_system_lottery_0_chara_id_1_trigger` on table `character_system_lottery`
--
ALTER TABLE character_system_lottery
ADD INDEX character_system_lottery_0_chara_id_1_trigger (chara_id, `trigger`);

--
-- Create index `character_system_lottery_0_trigger_1_param1` on table `character_system_lottery`
--
ALTER TABLE character_system_lottery
ADD INDEX character_system_lottery_0_trigger_1_param1 (`trigger`, param1);

--
-- Create table `character_prop_animation`
--
CREATE TABLE character_prop_animation (
  id int(11) NOT NULL,
  prop_id int(11) NOT NULL,
  prop_anim_id int(11) NOT NULL,
  layer_index int(11) NOT NULL,
  use_state_name text NOT NULL,
  scene_type int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 963,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `character_prop_animation_0_prop_id_1_scene_type` on table `character_prop_animation`
--
ALTER TABLE character_prop_animation
ADD INDEX character_prop_animation_0_prop_id_1_scene_type (prop_id, scene_type);

--
-- Create table `champions_stand_motion`
--
CREATE TABLE champions_stand_motion (
  chara_id int(11) NOT NULL,
  type int(11) NOT NULL,
  race_dress_id int(11) NOT NULL,
  motion_set int(11) NOT NULL,
  PRIMARY KEY (chara_id, type)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 910,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `champions_schedule`
--
CREATE TABLE champions_schedule (
  id int(11) NOT NULL,
  resource_id int(11) NOT NULL,
  info_detail_1 int(11) NOT NULL,
  info_detail_2 int(11) NOT NULL,
  champions_bg_id int(11) NOT NULL,
  champions_league_select_bg_sub_id int(11) NOT NULL,
  champions_bg_sub_id int(11) NOT NULL,
  champions_finish_bg_sub_id int(11) NOT NULL,
  champions_bg_position_x int(11) NOT NULL,
  start_date int(11) NOT NULL,
  end_date int(11) NOT NULL,
  info_detail int(11) NOT NULL,
  champions_finish_bg_id int(11) NOT NULL,
  champions_finish_bg_position_x int(11) NOT NULL,
  notice_date int(11) NOT NULL,
  champions_chara_select_bg_id int(11) NOT NULL,
  champions_chara_select_bg_sub_id int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1638,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `champions_round_schedule`
--
CREATE TABLE champions_round_schedule (
  id int(11) NOT NULL,
  champions_id int(11) NOT NULL,
  round int(11) NOT NULL,
  round_detail int(11) NOT NULL,
  start_date int(11) NOT NULL,
  end_date int(11) NOT NULL,
  interval_start_time int(11) NOT NULL,
  interval_end_time int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 273,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `champions_round_schedule_0_champions_id` on table `champions_round_schedule`
--
ALTER TABLE champions_round_schedule
ADD INDEX champions_round_schedule_0_champions_id (champions_id);

--
-- Create table `champions_round_detail`
--
CREATE TABLE champions_round_detail (
  id int(11) NOT NULL,
  champions_id int(11) NOT NULL,
  league_type int(11) NOT NULL,
  round_id int(11) NOT NULL,
  round int(11) NOT NULL,
  tier int(11) NOT NULL,
  round_number int(11) NOT NULL,
  breakthrough_number_1 int(11) NOT NULL,
  breakthrough_number_2 int(11) NOT NULL,
  entry_number int(11) NOT NULL,
  free_entry_number int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 117,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `champions_round_detail_0_champions_id_1_league_type` on table `champions_round_detail`
--
ALTER TABLE champions_round_detail
ADD INDEX champions_round_detail_0_champions_id_1_league_type (champions_id, league_type);

--
-- Create table `champions_reward_rate`
--
CREATE TABLE champions_reward_rate (
  id int(11) NOT NULL,
  champions_id int(11) NOT NULL,
  league_type int(11) NOT NULL,
  round_id int(11) NOT NULL,
  win_count int(11) NOT NULL,
  ranking int(11) NOT NULL,
  rate int(11) NOT NULL,
  reward_set_id int(11) NOT NULL,
  box_grade int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 136,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `champions_reward_rate_0_champions_id_1_round_id` on table `champions_reward_rate`
--
ALTER TABLE champions_reward_rate
ADD INDEX champions_reward_rate_0_champions_id_1_round_id (champions_id, round_id);

--
-- Create table `champions_race_condition`
--
CREATE TABLE champions_race_condition (
  champions_id int(11) NOT NULL,
  round_id int(11) NOT NULL,
  race_instance_id int(11) NOT NULL,
  race_condition_id int(11) NOT NULL,
  PRIMARY KEY (champions_id, round_id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 234,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `champions_news_win_title`
--
CREATE TABLE champions_news_win_title (
  id int(11) NOT NULL,
  round_id int(11) NOT NULL,
  win_percent_type int(11) NOT NULL,
  resource_id int(11) NOT NULL,
  bashin_min int(11) NOT NULL,
  bashin_max int(11) NOT NULL,
  running_style int(11) NOT NULL,
  race_track_id int(11) NOT NULL,
  ground int(11) NOT NULL,
  distance int(11) NOT NULL,
  weather int(11) NOT NULL,
  sub_title int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 141,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `champions_news_win_comment`
--
CREATE TABLE champions_news_win_comment (
  id int(11) NOT NULL,
  round_id int(11) NOT NULL,
  chara_id int(11) NOT NULL,
  big_flag int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 64,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `champions_news_title`
--
CREATE TABLE champions_news_title (
  id int(11) NOT NULL,
  round_id int(11) NOT NULL,
  win_percent_type int(11) NOT NULL,
  resource_id int(11) NOT NULL,
  title int(11) NOT NULL,
  sub_title int(11) NOT NULL,
  race_track_id int(11) NOT NULL,
  ground int(11) NOT NULL,
  distance int(11) NOT NULL,
  weather int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 124,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `champions_news_title_0_round_id` on table `champions_news_title`
--
ALTER TABLE champions_news_title
ADD INDEX champions_news_title_0_round_id (round_id);

--
-- Create table `champions_news_race`
--
CREATE TABLE champions_news_race (
  id int(11) NOT NULL,
  round_id int(11) NOT NULL,
  win_percent_type int(11) NOT NULL,
  text_number int(11) NOT NULL,
  resource_id int(11) NOT NULL,
  race_track_id int(11) NOT NULL,
  ground int(11) NOT NULL,
  distance int(11) NOT NULL,
  weather int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 77,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `champions_news_race_0_round_id` on table `champions_news_race`
--
ALTER TABLE champions_news_race
ADD INDEX champions_news_race_0_round_id (round_id);

--
-- Create table `champions_news_chara_comment`
--
CREATE TABLE champions_news_chara_comment (
  id int(11) NOT NULL,
  round_id int(11) NOT NULL,
  chara_id int(11) NOT NULL,
  big_flag int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 98,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `champions_news_chara_comment_0_round_id` on table `champions_news_chara_comment`
--
ALTER TABLE champions_news_chara_comment
ADD INDEX champions_news_chara_comment_0_round_id (round_id);

--
-- Create table `champions_evaluation_rate`
--
CREATE TABLE champions_evaluation_rate (
  id int(11) NOT NULL,
  proper_type int(11) NOT NULL,
  proper_rank int(11) NOT NULL,
  rate int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1024,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `champions_entry_reward`
--
CREATE TABLE champions_entry_reward (
  champions_id int(11) NOT NULL,
  item_category int(11) NOT NULL,
  item_id int(11) NOT NULL,
  item_num int(11) NOT NULL,
  PRIMARY KEY (champions_id, item_id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 8192,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `champions_entry_reward_0_champions_id` on table `champions_entry_reward`
--
ALTER TABLE champions_entry_reward
ADD INDEX champions_entry_reward_0_champions_id (champions_id);

--
-- Create table `champions_bgm`
--
CREATE TABLE champions_bgm (
  id int(11) NOT NULL,
  round_id int(11) NOT NULL,
  scene_type int(11) NOT NULL,
  race_number int(11) NOT NULL,
  cue_name text NOT NULL,
  cuesheet_name text NOT NULL,
  first_bgm_pattern int(11) NOT NULL,
  second_bgm_pattern int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 297,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `champions_bgm_0_round_id_1_scene_type_2_race_number` on table `champions_bgm`
--
ALTER TABLE champions_bgm
ADD INDEX champions_bgm_0_round_id_1_scene_type_2_race_number (round_id, scene_type, race_number);

--
-- Create table `challenge_match_raw_point`
--
CREATE TABLE challenge_match_raw_point (
  id int(11) NOT NULL,
  priority int(11) NOT NULL,
  condition_type int(11) NOT NULL,
  condition_value_1 int(11) NOT NULL,
  condition_value_2 int(11) NOT NULL,
  point int(11) NOT NULL,
  race_point_name_id int(11) NOT NULL,
  sort_order int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 178,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `challenge_match_raw_point_0_condition_type` on table `challenge_match_raw_point`
--
ALTER TABLE challenge_match_raw_point
ADD INDEX challenge_match_raw_point_0_condition_type (condition_type);

--
-- Create index `challenge_match_raw_point_0_race_point_name_id` on table `challenge_match_raw_point`
--
ALTER TABLE challenge_match_raw_point
ADD INDEX challenge_match_raw_point_0_race_point_name_id (race_point_name_id);

--
-- Create table `challenge_match_race`
--
CREATE TABLE challenge_match_race (
  id int(11) NOT NULL,
  challenge_match_id int(11) NOT NULL,
  disp_order int(11) NOT NULL,
  challenge_match_bg_id int(11) NOT NULL,
  challenge_match_bg_sub_id int(11) NOT NULL,
  difficulty int(11) NOT NULL,
  race_type int(11) NOT NULL,
  race_appearance_rate int(11) NOT NULL,
  race_instance_id int(11) NOT NULL,
  season int(11) NOT NULL,
  weather int(11) NOT NULL,
  ground int(11) NOT NULL,
  challenge_match_race_boss_npc_id int(11) NOT NULL,
  cost_rp int(11) NOT NULL,
  drop_reward_odds_id int(11) NOT NULL,
  victory_reward_odds_id int(11) NOT NULL,
  first_clear_item_category_1 int(11) NOT NULL,
  first_clear_item_id_1 int(11) NOT NULL,
  first_clear_item_num_1 int(11) NOT NULL,
  first_clear_item_category_2 int(11) NOT NULL,
  first_clear_item_id_2 int(11) NOT NULL,
  first_clear_item_num_2 int(11) NOT NULL,
  first_clear_item_category_3 int(11) NOT NULL,
  first_clear_item_id_3 int(11) NOT NULL,
  first_clear_item_num_3 int(11) NOT NULL,
  pick_up_item_category_1 int(11) NOT NULL,
  pick_up_item_id_1 int(11) NOT NULL,
  pick_up_item_num_1 int(11) NOT NULL,
  pick_up_item_category_2 int(11) NOT NULL,
  pick_up_item_id_2 int(11) NOT NULL,
  pick_up_item_num_2 int(11) NOT NULL,
  pick_up_item_category_3 int(11) NOT NULL,
  pick_up_item_id_3 int(11) NOT NULL,
  pick_up_item_num_3 int(11) NOT NULL,
  pick_up_item_category_4 int(11) NOT NULL,
  pick_up_item_id_4 int(11) NOT NULL,
  pick_up_item_num_4 int(11) NOT NULL,
  pick_up_item_category_5 int(11) NOT NULL,
  pick_up_item_id_5 int(11) NOT NULL,
  pick_up_item_num_5 int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 2730,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `challenge_match_race_0_challenge_match_id` on table `challenge_match_race`
--
ALTER TABLE challenge_match_race
ADD INDEX challenge_match_race_0_challenge_match_id (challenge_match_id);

--
-- Create index `challenge_match_race_0_race_instance_id` on table `challenge_match_race`
--
ALTER TABLE challenge_match_race
ADD INDEX challenge_match_race_0_race_instance_id (race_instance_id);

--
-- Create table `challenge_match_data`
--
CREATE TABLE challenge_match_data (
  challenge_match_id int(11) NOT NULL,
  announce_id int(11) NOT NULL,
  bonus_skill_id int(11) NOT NULL,
  bonus_factor_id int(11) NOT NULL,
  item_exchange_top_id int(11) NOT NULL,
  notice_date int(11) NOT NULL,
  start_date int(11) NOT NULL,
  ending_date int(11) NOT NULL,
  end_date int(11) NOT NULL,
  challenge_match_top_bg_id int(11) NOT NULL,
  challenge_match_top_bg_sub_id int(11) NOT NULL,
  PRIMARY KEY (challenge_match_id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 16384,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `challenge_match_boss_npc`
--
CREATE TABLE challenge_match_boss_npc (
  id int(11) NOT NULL,
  chara_id int(11) NOT NULL,
  race_dress_id int(11) NOT NULL,
  nickname_id int(11) NOT NULL,
  card_rarity_data_id int(11) NOT NULL,
  post int(11) NOT NULL,
  speed int(11) NOT NULL,
  stamina int(11) NOT NULL,
  pow int(11) NOT NULL,
  guts int(11) NOT NULL,
  wiz int(11) NOT NULL,
  proper_distance_short int(11) NOT NULL,
  proper_distance_mile int(11) NOT NULL,
  proper_distance_middle int(11) NOT NULL,
  proper_distance_long int(11) NOT NULL,
  proper_running_style_nige int(11) NOT NULL,
  proper_running_style_senko int(11) NOT NULL,
  proper_running_style_sashi int(11) NOT NULL,
  proper_running_style_oikomi int(11) NOT NULL,
  proper_ground_turf int(11) NOT NULL,
  proper_ground_dirt int(11) NOT NULL,
  skill_set_id int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 2730,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `card_talent_upgrade`
--
CREATE TABLE card_talent_upgrade (
  id int(11) NOT NULL,
  talent_group_id int(11) NOT NULL,
  talent_level int(11) NOT NULL,
  item_category_1 int(11) NOT NULL,
  item_id_1 int(11) NOT NULL,
  item_num_1 int(11) NOT NULL,
  item_category_2 int(11) NOT NULL,
  item_id_2 int(11) NOT NULL,
  item_num_2 int(11) NOT NULL,
  item_category_3 int(11) NOT NULL,
  item_id_3 int(11) NOT NULL,
  item_num_3 int(11) NOT NULL,
  item_category_4 int(11) NOT NULL,
  item_id_4 int(11) NOT NULL,
  item_num_4 int(11) NOT NULL,
  item_category_5 int(11) NOT NULL,
  item_id_5 int(11) NOT NULL,
  item_num_5 int(11) NOT NULL,
  item_category_6 int(11) NOT NULL,
  item_id_6 int(11) NOT NULL,
  item_num_6 int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 230,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `card_talent_upgrade_0_talent_group_id_1_talent_level` on table `card_talent_upgrade`
--
ALTER TABLE card_talent_upgrade
ADD INDEX card_talent_upgrade_0_talent_group_id_1_talent_level (talent_group_id, talent_level);

--
-- Create table `card_talent_hint_upgrade`
--
CREATE TABLE card_talent_hint_upgrade (
  id int(11) NOT NULL,
  rarity int(11) NOT NULL,
  talent_level int(11) NOT NULL,
  item_category_1 int(11) NOT NULL,
  item_id_1 int(11) NOT NULL,
  item_disp_order_1 int(11) NOT NULL,
  item_num_1 int(11) NOT NULL,
  item_category_2 int(11) NOT NULL,
  item_id_2 int(11) NOT NULL,
  item_disp_order_2 int(11) NOT NULL,
  item_num_2 int(11) NOT NULL,
  money_num int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 2730,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `card_talent_hint_upgrade_0_rarity_1_talent_level` on table `card_talent_hint_upgrade`
--
ALTER TABLE card_talent_hint_upgrade
ADD INDEX card_talent_hint_upgrade_0_rarity_1_talent_level (rarity, talent_level);

--
-- Create table `card_rarity_data`
--
CREATE TABLE card_rarity_data (
  id int(11) NOT NULL,
  card_id int(11) NOT NULL,
  rarity int(11) NOT NULL,
  race_dress_id int(11) NOT NULL,
  skill_set int(11) NOT NULL,
  speed int(11) NOT NULL,
  stamina int(11) NOT NULL,
  pow int(11) NOT NULL,
  guts int(11) NOT NULL,
  wiz int(11) NOT NULL,
  max_speed int(11) NOT NULL,
  max_stamina int(11) NOT NULL,
  max_pow int(11) NOT NULL,
  max_guts int(11) NOT NULL,
  max_wiz int(11) NOT NULL,
  proper_distance_short int(11) NOT NULL,
  proper_distance_mile int(11) NOT NULL,
  proper_distance_middle int(11) NOT NULL,
  proper_distance_long int(11) NOT NULL,
  proper_running_style_nige int(11) NOT NULL,
  proper_running_style_senko int(11) NOT NULL,
  proper_running_style_sashi int(11) NOT NULL,
  proper_running_style_oikomi int(11) NOT NULL,
  proper_ground_turf int(11) NOT NULL,
  proper_ground_dirt int(11) NOT NULL,
  get_dress_id_1 int(11) NOT NULL,
  get_dress_id_2 int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 278,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `card_rarity_data_0_card_id` on table `card_rarity_data`
--
ALTER TABLE card_rarity_data
ADD INDEX card_rarity_data_0_card_id (card_id);

--
-- Create index `card_rarity_data_0_card_id_1_rarity` on table `card_rarity_data`
--
ALTER TABLE card_rarity_data
ADD UNIQUE INDEX card_rarity_data_0_card_id_1_rarity (card_id, rarity);

--
-- Create index `card_rarity_data_0_race_dress_id` on table `card_rarity_data`
--
ALTER TABLE card_rarity_data
ADD INDEX card_rarity_data_0_race_dress_id (race_dress_id);

--
-- Create table `card_data`
--
CREATE TABLE card_data (
  id int(11) NOT NULL,
  chara_id int(11) NOT NULL,
  default_rarity int(11) NOT NULL,
  limited_chara int(11) NOT NULL,
  available_skill_set_id int(11) NOT NULL,
  talent_speed int(11) NOT NULL,
  talent_stamina int(11) NOT NULL,
  talent_pow int(11) NOT NULL,
  talent_guts int(11) NOT NULL,
  talent_wiz int(11) NOT NULL,
  talent_group_id int(11) NOT NULL,
  bg_id int(11) NOT NULL,
  get_piece_id int(11) NOT NULL,
  running_style int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 234,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `card_data_0_chara_id` on table `card_data`
--
ALTER TABLE card_data
ADD INDEX card_data_0_chara_id (chara_id);

--
-- Create index `card_data_0_get_piece_id` on table `card_data`
--
ALTER TABLE card_data
ADD INDEX card_data_0_get_piece_id (get_piece_id);

--
-- Create table `campaign_walking_reward_set`
--
CREATE TABLE campaign_walking_reward_set (
  id int(11) NOT NULL,
  reward_set_id int(11) NOT NULL,
  limit_num int(11) NOT NULL,
  item_category int(11) NOT NULL,
  item_id int(11) NOT NULL,
  item_num int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 248,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `campaign_walking_reward_set_0_reward_set_id` on table `campaign_walking_reward_set`
--
ALTER TABLE campaign_walking_reward_set
ADD INDEX campaign_walking_reward_set_0_reward_set_id (reward_set_id);

--
-- Create table `campaign_walking_location`
--
CREATE TABLE campaign_walking_location (
  id int(11) NOT NULL,
  cut_id int(11) NOT NULL,
  cut_sub_id int(11) NOT NULL,
  material_id text NOT NULL,
  background_data_id int(11) NOT NULL,
  reward_set_id int(11) NOT NULL,
  love_point int(11) NOT NULL,
  bg_position_custom int(11) NOT NULL,
  bg_position_x int(11) NOT NULL,
  friend_list_id int(11) NOT NULL,
  place_position_x int(11) NOT NULL,
  place_position_y int(11) NOT NULL,
  place_color_main text NOT NULL,
  place_color_sub text NOT NULL,
  bgm_cue_name text NOT NULL,
  bgm_cuesheet_name text NOT NULL,
  env_cue_name text NOT NULL,
  env_cuesheet_name text NOT NULL,
  place_tail int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 249,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `campaign_walking_friend`
--
CREATE TABLE campaign_walking_friend (
  id int(11) NOT NULL,
  friend_list_id int(11) NOT NULL,
  chara_id int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 2730,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `campaign_walking_friend_0_friend_list_id` on table `campaign_walking_friend`
--
ALTER TABLE campaign_walking_friend
ADD INDEX campaign_walking_friend_0_friend_list_id (friend_list_id);

--
-- Create table `campaign_walking_data`
--
CREATE TABLE campaign_walking_data (
  id int(11) NOT NULL,
  campaign_id int(11) NOT NULL,
  walking_limit int(11) NOT NULL,
  gauge_max int(11) NOT NULL,
  gauge_up_singlemode int(11) NOT NULL,
  gauge_up_teamstadium int(11) NOT NULL,
  gauge_up_dailyrace int(11) NOT NULL,
  gauge_up_dailylegendrace int(11) NOT NULL,
  gauge_up_login int(11) NOT NULL,
  logo_id int(11) NOT NULL,
  map_id int(11) NOT NULL,
  icon_id_location_1 int(11) NOT NULL,
  icon_id_location_2 int(11) NOT NULL,
  icon_id_location_3 int(11) NOT NULL,
  special_campaign_type int(11) NOT NULL,
  gauge_consume_num int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 3276,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `campaign_walking_data_0_campaign_id` on table `campaign_walking_data`
--
ALTER TABLE campaign_walking_data
ADD INDEX campaign_walking_data_0_campaign_id (campaign_id);

--
-- Create table `campaign_walking_chara`
--
CREATE TABLE campaign_walking_chara (
  campaign_id int(11) NOT NULL,
  chara_id int(11) NOT NULL,
  location_1 int(11) NOT NULL,
  location_2 int(11) NOT NULL,
  location_3 int(11) NOT NULL
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 122,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `campaign_id` on table `campaign_walking_chara`
--
ALTER TABLE campaign_walking_chara
ADD UNIQUE INDEX campaign_id (campaign_id, chara_id);

--
-- Create index `campaign_walking_chara_0_chara_id` on table `campaign_walking_chara`
--
ALTER TABLE campaign_walking_chara
ADD INDEX campaign_walking_chara_0_chara_id (chara_id);

--
-- Create table `campaign_swap_motion_data`
--
CREATE TABLE campaign_swap_motion_data (
  id int(11) NOT NULL,
  dress_id int(11) NOT NULL,
  cut_id int(11) NOT NULL,
  cut_sub_id int(11) NOT NULL,
  replace_index int(11) NOT NULL,
  chara_id int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 237,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `campaign_swap_motion_data_0_dress_id` on table `campaign_swap_motion_data`
--
ALTER TABLE campaign_swap_motion_data
ADD INDEX campaign_swap_motion_data_0_dress_id (dress_id);

--
-- Create table `campaign_story_data`
--
CREATE TABLE campaign_story_data (
  id int(11) NOT NULL,
  campaign_id int(11) NOT NULL,
  condition_type int(11) NOT NULL,
  condition_value int(11) NOT NULL,
  story_id int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 2048,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `campaign_story_data_0_campaign_id` on table `campaign_story_data`
--
ALTER TABLE campaign_story_data
ADD INDEX campaign_story_data_0_campaign_id (campaign_id);

--
-- Create table `campaign_sp_present_bonus_data`
--
CREATE TABLE campaign_sp_present_bonus_data (
  id int(11) NOT NULL,
  target_type int(11) NOT NULL,
  card_id int(11) NOT NULL,
  `count` int(11) NOT NULL,
  item_category_1 int(11) NOT NULL,
  item_id_1 int(11) NOT NULL,
  item_num_1 int(11) NOT NULL,
  prop_id int(11) NOT NULL,
  location_id int(11) NOT NULL,
  motion_type int(11) NOT NULL,
  replace_index int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 104,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `campaign_sp_present_bonus_data_0_card_id` on table `campaign_sp_present_bonus_data`
--
ALTER TABLE campaign_sp_present_bonus_data
ADD INDEX campaign_sp_present_bonus_data_0_card_id (card_id);

--
-- Create index `campaign_sp_present_bonus_data_0_target_type_1_card_id` on table `campaign_sp_present_bonus_data`
--
ALTER TABLE campaign_sp_present_bonus_data
ADD INDEX campaign_sp_present_bonus_data_0_target_type_1_card_id (target_type, card_id);

--
-- Create table `campaign_single_race_add_reward`
--
CREATE TABLE campaign_single_race_add_reward (
  id int(11) NOT NULL,
  race_additional_reward_id int(11) NOT NULL,
  item_category int(11) NOT NULL,
  item_id int(11) NOT NULL,
  reward_type int(11) NOT NULL,
  reward_value int(11) NOT NULL,
  reward_rate int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1092,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `campaign_single_race_add_reward_0_race_additional_reward_id` on table `campaign_single_race_add_reward`
--
ALTER TABLE campaign_single_race_add_reward
ADD INDEX campaign_single_race_add_reward_0_race_additional_reward_id (race_additional_reward_id);

--
-- Create table `campaign_single_race_add_data`
--
CREATE TABLE campaign_single_race_add_data (
  id int(11) NOT NULL,
  race_additional_id int(11) NOT NULL,
  race_program_id int(11) NOT NULL,
  race_additional_reward_id int(11) NOT NULL,
  reward_limit int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 3276,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `campaign_single_race_add_data_0_race_additional_id` on table `campaign_single_race_add_data`
--
ALTER TABLE campaign_single_race_add_data
ADD INDEX campaign_single_race_add_data_0_race_additional_id (race_additional_id);

--
-- Create table `campaign_rental_support_data`
--
CREATE TABLE campaign_rental_support_data (
  id int(11) NOT NULL,
  rental_limit int(11) NOT NULL,
  start_date int(11) NOT NULL,
  end_date int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `campaign_rental_support_card`
--
CREATE TABLE campaign_rental_support_card (
  id int(11) NOT NULL,
  campaign_rental_support_data_id int(11) NOT NULL,
  support_card_id int(11) NOT NULL,
  limit_break_count int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1092,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `campaign_rental_support_card_0_campaign_rental_support_data_id` on table `campaign_rental_support_card`
--
ALTER TABLE campaign_rental_support_card
ADD INDEX campaign_rental_support_card_0_campaign_rental_support_data_id (campaign_rental_support_data_id);

--
-- Create table `campaign_present_bonus_detail`
--
CREATE TABLE campaign_present_bonus_detail (
  id int(11) NOT NULL,
  campaign_id int(11) NOT NULL,
  card_id int(11) NOT NULL,
  `count` int(11) NOT NULL,
  item_category_1 int(11) NOT NULL,
  item_id_1 int(11) NOT NULL,
  item_num_1 int(11) NOT NULL,
  item_category_2 int(11) NOT NULL,
  item_id_2 int(11) NOT NULL,
  item_num_2 int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 240,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `campaign_id` on table `campaign_present_bonus_detail`
--
ALTER TABLE campaign_present_bonus_detail
ADD UNIQUE INDEX campaign_id (campaign_id, card_id);

--
-- Create index `campaign_present_bonus_detail_0_card_id` on table `campaign_present_bonus_detail`
--
ALTER TABLE campaign_present_bonus_detail
ADD INDEX campaign_present_bonus_detail_0_card_id (card_id);

--
-- Create index `item_id_1` on table `campaign_present_bonus_detail`
--
ALTER TABLE campaign_present_bonus_detail
ADD UNIQUE INDEX item_id_1 (item_id_1);

--
-- Create table `campaign_n_present_bonus_data`
--
CREATE TABLE campaign_n_present_bonus_data (
  id int(11) NOT NULL,
  target_type int(11) NOT NULL,
  card_id int(11) NOT NULL,
  `count` int(11) NOT NULL,
  item_category_1 int(11) NOT NULL,
  item_id_1 int(11) NOT NULL,
  item_num_1 int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 104,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `campaign_n_present_bonus_data_0_card_id` on table `campaign_n_present_bonus_data`
--
ALTER TABLE campaign_n_present_bonus_data
ADD INDEX campaign_n_present_bonus_data_0_card_id (card_id);

--
-- Create index `campaign_n_present_bonus_data_0_target_type_1_card_id` on table `campaign_n_present_bonus_data`
--
ALTER TABLE campaign_n_present_bonus_data
ADD INDEX campaign_n_present_bonus_data_0_target_type_1_card_id (target_type, card_id);

--
-- Create table `campaign_data`
--
CREATE TABLE campaign_data (
  campaign_id int(11) NOT NULL,
  target_type int(11) NOT NULL,
  target_id int(11) NOT NULL,
  effect_type_1 int(11) NOT NULL,
  effect_value_1 int(11) NOT NULL,
  user_show int(11) NOT NULL,
  disp_order int(11) NOT NULL,
  image_icon_id int(11) NOT NULL,
  transition_type int(11) NOT NULL,
  image_change int(11) NOT NULL,
  logo_type int(11) NOT NULL,
  start_time int(11) NOT NULL,
  end_time int(11) NOT NULL,
  open_flag_id int(11) NOT NULL,
  PRIMARY KEY (campaign_id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 156,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `campaign_data_0_image_change` on table `campaign_data`
--
ALTER TABLE campaign_data
ADD INDEX campaign_data_0_image_change (image_change);

--
-- Create index `campaign_data_0_target_type` on table `campaign_data`
--
ALTER TABLE campaign_data
ADD INDEX campaign_data_0_target_type (target_type);

--
-- Create table `campaign_cutt_data`
--
CREATE TABLE campaign_cutt_data (
  id int(11) NOT NULL,
  chara_id int(11) NOT NULL,
  cut_id int(11) NOT NULL,
  cut_sub_id int(11) NOT NULL,
  motion_type int(11) NOT NULL,
  dress_id int(11) NOT NULL,
  campaign_id int(11) NOT NULL,
  color_type int(11) NOT NULL,
  motion_rate int(11) NOT NULL,
  chara_no_change int(11) NOT NULL,
  trainer_gender_type int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 92,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `campaign_cutt_data_0_chara_id` on table `campaign_cutt_data`
--
ALTER TABLE campaign_cutt_data
ADD INDEX campaign_cutt_data_0_chara_id (chara_id);

--
-- Create index `campaign_cutt_data_0_cut_id_1_cut_sub_id` on table `campaign_cutt_data`
--
ALTER TABLE campaign_cutt_data
ADD INDEX campaign_cutt_data_0_cut_id_1_cut_sub_id (cut_id, cut_sub_id);

--
-- Create table `campaign_chara_story_schedule`
--
CREATE TABLE campaign_chara_story_schedule (
  campaign_id int(11) NOT NULL,
  chara_id int(11) NOT NULL,
  story_id int(11) NOT NULL
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 93,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `campaign_chara_story_schedule_0_campaign_id` on table `campaign_chara_story_schedule`
--
ALTER TABLE campaign_chara_story_schedule
ADD INDEX campaign_chara_story_schedule_0_campaign_id (campaign_id);

--
-- Create index `campaign_chara_story_schedule_0_chara_id` on table `campaign_chara_story_schedule`
--
ALTER TABLE campaign_chara_story_schedule
ADD INDEX campaign_chara_story_schedule_0_chara_id (chara_id);

--
-- Create table `banner_data`
--
CREATE TABLE banner_data (
  id int(11) NOT NULL,
  banner_id int(11) NOT NULL,
  type int(11) NOT NULL,
  group_id int(11) NOT NULL,
  transition int(11) NOT NULL,
  priority int(11) NOT NULL,
  condition_value int(11) NOT NULL,
  start_date text NOT NULL,
  end_date text NOT NULL,
  banner_image_id int(11) NOT NULL,
  dialog_image_id int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 103,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `banner_data_0_group_id` on table `banner_data`
--
ALTER TABLE banner_data
ADD INDEX banner_data_0_group_id (group_id);

--
-- Create table `background_offset_data`
--
CREATE TABLE background_offset_data (
  id int(11) NOT NULL,
  bg_id int(11) NOT NULL,
  bg_sub int(11) NOT NULL,
  offset_id int(11) NOT NULL,
  pos_x int(11) NOT NULL,
  pos_y int(11) NOT NULL,
  width int(11) NOT NULL,
  height int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1260,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `background_offset_data_0_bg_id_1_bg_sub` on table `background_offset_data`
--
ALTER TABLE background_offset_data
ADD INDEX background_offset_data_0_bg_id_1_bg_sub (bg_id, bg_sub);

--
-- Create index `bg_id` on table `background_offset_data`
--
ALTER TABLE background_offset_data
ADD UNIQUE INDEX bg_id (bg_id, bg_sub, offset_id);

--
-- Create table `background_data`
--
CREATE TABLE background_data (
  id int(11) NOT NULL,
  bg_id int(11) NOT NULL,
  bg_sub int(11) NOT NULL,
  cue_name text NOT NULL,
  sheet_name text NOT NULL,
  bus_param_set_name text NOT NULL,
  pos_x int(11) NOT NULL,
  pos_y int(11) NOT NULL,
  width int(11) NOT NULL,
  height int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 207,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `background_data_0_bg_id_1_bg_sub` on table `background_data`
--
ALTER TABLE background_data
ADD UNIQUE INDEX background_data_0_bg_id_1_bg_sub (bg_id, bg_sub);

--
-- Create table `available_skill_set`
--
CREATE TABLE available_skill_set (
  id int(11) NOT NULL,
  available_skill_set_id int(11) NOT NULL,
  skill_id int(11) NOT NULL,
  need_rank int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 100,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `available_skill_set_0_available_skill_set_id` on table `available_skill_set`
--
ALTER TABLE available_skill_set
ADD INDEX available_skill_set_0_available_skill_set_id (available_skill_set_id);

--
-- Create table `audio_story_effect`
--
CREATE TABLE audio_story_effect (
  id int(11) NOT NULL,
  effect_name text NOT NULL,
  cue_name text NOT NULL,
  cue_sheet text NOT NULL,
  loop_set int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1365,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `audio_story_effect_0_effect_name` on table `audio_story_effect`
--
ALTER TABLE audio_story_effect
ADD UNIQUE INDEX audio_story_effect_0_effect_name USING HASH (effect_name);

--
-- Create table `audio_ignored_cue_on_highspeed`
--
CREATE TABLE audio_ignored_cue_on_highspeed (
  id int(11) NOT NULL,
  cue_name varchar(300) NOT NULL,
  cue_sheet varchar(300) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 2340,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `audio_ignored_cue_on_highspeed_0_cue_name_1_cue_sheet` on table `audio_ignored_cue_on_highspeed`
--
ALTER TABLE audio_ignored_cue_on_highspeed
ADD INDEX audio_ignored_cue_on_highspeed_0_cue_name_1_cue_sheet (cue_name, cue_sheet);

--
-- Create table `audio_cuesheet`
--
CREATE TABLE audio_cuesheet (
  id int(11) NOT NULL,
  cue_sheet text NOT NULL,
  attribute int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1365,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `audio_cuesheet_0_attribute` on table `audio_cuesheet`
--
ALTER TABLE audio_cuesheet
ADD INDEX audio_cuesheet_0_attribute (attribute);

--
-- Create table `audience_impostor_lottery`
--
CREATE TABLE audience_impostor_lottery (
  group_id int(11) NOT NULL,
  pattern int(11) NOT NULL,
  asset_id int(11) NOT NULL,
  odds int(11) NOT NULL
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 124,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `audience_impostor_lottery_0_group_id_1_pattern` on table `audience_impostor_lottery`
--
ALTER TABLE audience_impostor_lottery
ADD INDEX audience_impostor_lottery_0_group_id_1_pattern (group_id, pattern);

--
-- Create table `audience_impostor_color_set`
--
CREATE TABLE audience_impostor_color_set (
  color_group_id int(11) NOT NULL,
  color text NOT NULL,
  odds int(11) NOT NULL
)
ENGINE = INNODB,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `audience_impostor_color_set_0_color_group_id` on table `audience_impostor_color_set`
--
ALTER TABLE audience_impostor_color_set
ADD INDEX audience_impostor_color_set_0_color_group_id (color_group_id);

--
-- Create table `audience_impostor`
--
CREATE TABLE audience_impostor (
  scene_type int(11) NOT NULL,
  season int(11) NOT NULL,
  weather int(11) NOT NULL,
  group_id int(11) NOT NULL,
  pattern_1 int(11) NOT NULL,
  pattern_2 int(11) NOT NULL,
  pattern_3 int(11) NOT NULL,
  pattern_4 int(11) NOT NULL,
  pattern_5 int(11) NOT NULL,
  pattern_6 int(11) NOT NULL,
  pattern_7 int(11) NOT NULL,
  pattern_8 int(11) NOT NULL,
  pattern_9 int(11) NOT NULL,
  pattern_10 int(11) NOT NULL,
  audience_group_id int(11) NOT NULL
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 512,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create index `audience_impostor_0_season_1_weather` on table `audience_impostor`
--
ALTER TABLE audience_impostor
ADD INDEX audience_impostor_0_season_1_weather (season, weather);

--
-- Create table `audience_hair_color_set`
--
CREATE TABLE audience_hair_color_set (
  id int(11) NOT NULL,
  hair_color_r1 text NOT NULL,
  hair_color_r2 text NOT NULL,
  hair_color_g1 text NOT NULL,
  hair_color_g2 text NOT NULL,
  hair_color_b1 text NOT NULL,
  hair_color_b2 text NOT NULL,
  hair_toon_color_r1 text NOT NULL,
  hair_toon_color_r2 text NOT NULL,
  hair_toon_color_g1 text NOT NULL,
  hair_toon_color_g2 text NOT NULL,
  hair_toon_color_b1 text NOT NULL,
  hair_toon_color_b2 text NOT NULL,
  mayu_color_r1 text NOT NULL,
  mayu_color_r2 text NOT NULL,
  mayu_color_g1 text NOT NULL,
  mayu_color_g2 text NOT NULL,
  mayu_color_b1 text NOT NULL,
  mayu_color_b2 text NOT NULL,
  mayu_toon_color_r1 text NOT NULL,
  mayu_toon_color_r2 text NOT NULL,
  mayu_toon_color_g1 text NOT NULL,
  mayu_toon_color_g2 text NOT NULL,
  mayu_toon_color_b1 text NOT NULL,
  mayu_toon_color_b2 text NOT NULL,
  eye_color_r1 text NOT NULL,
  eye_color_r2 text NOT NULL,
  eye_color_g1 text NOT NULL,
  eye_color_g2 text NOT NULL,
  eye_color_b1 text NOT NULL,
  eye_color_b2 text NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 630,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `audience_dress_color_set`
--
CREATE TABLE audience_dress_color_set (
  id int(11) NOT NULL,
  color_r1 text NOT NULL,
  color_r2 text NOT NULL,
  color_g1 text NOT NULL,
  color_g2 text NOT NULL,
  color_b1 text NOT NULL,
  color_b2 text NOT NULL,
  toon_color_r1 text NOT NULL,
  toon_color_r2 text NOT NULL,
  toon_color_g1 text NOT NULL,
  toon_color_g2 text NOT NULL,
  toon_color_b1 text NOT NULL,
  toon_color_b2 text NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 210,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `audience_data`
--
CREATE TABLE audience_data (
  audience_id int(11) NOT NULL,
  chara_face_model int(11) NOT NULL,
  chara_skin_color int(11) NOT NULL,
  chara_hair_model int(11) NOT NULL,
  chara_hair_color int(11) NOT NULL,
  prop_id_1 int(11) NOT NULL,
  prop_attach_node_name_type_1 int(11) NOT NULL,
  prop_id_2 int(11) NOT NULL,
  prop_attach_node_name_type_2 int(11) NOT NULL,
  chara_height int(11) NOT NULL,
  shape int(11) NOT NULL,
  chara_bust_size int(11) NOT NULL,
  dress_id int(11) NOT NULL,
  dress_color_id int(11) NOT NULL,
  PRIMARY KEY (audience_id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 210,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `announce_support_card`
--
CREATE TABLE announce_support_card (
  id int(11) NOT NULL,
  type int(11) NOT NULL,
  cuts_pattern int(11) NOT NULL,
  support_card_id_a int(11) NOT NULL,
  support_card_id_b int(11) NOT NULL,
  support_card_id_c int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 630,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `announce_event`
--
CREATE TABLE announce_event (
  id int(11) NOT NULL,
  cue_name text NOT NULL,
  cue_sheet_name text NOT NULL,
  voice_text_asset int(11) NOT NULL,
  start_date int(11) NOT NULL,
  end_date int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1820,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `announce_data`
--
CREATE TABLE announce_data (
  id int(11) NOT NULL,
  announce_type int(11) NOT NULL,
  announce_id int(11) NOT NULL,
  priority int(11) NOT NULL,
  start_date int(11) NOT NULL,
  end_date int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 268,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;

--
-- Create table `announce_character`
--
CREATE TABLE announce_character (
  id int(11) NOT NULL,
  movie_id int(11) NOT NULL,
  can_end_second int(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 468,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci,
ROW_FORMAT = DYNAMIC;