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
-- Drop table `campaign_data`
--
DROP TABLE IF EXISTS campaign_data;

--
-- Drop table `campaign_present_bonus_detail`
--
DROP TABLE IF EXISTS campaign_present_bonus_detail;

--
-- Drop table `campaign_single_race_add_data`
--
DROP TABLE IF EXISTS campaign_single_race_add_data;

--
-- Drop table `campaign_single_race_add_reward`
--
DROP TABLE IF EXISTS campaign_single_race_add_reward;

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
-- Drop table `challenge_match_race_npc`
--
DROP TABLE IF EXISTS challenge_match_race_npc;

--
-- Drop table `challenge_match_raw_point`
--
DROP TABLE IF EXISTS challenge_match_raw_point;

--
-- Drop table `challenge_match_retry_bonus`
--
DROP TABLE IF EXISTS challenge_match_retry_bonus;

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
-- Drop table `champions_news_chara_detail`
--
DROP TABLE IF EXISTS champions_news_chara_detail;

--
-- Drop table `champions_news_chara_wininfo`
--
DROP TABLE IF EXISTS champions_news_chara_wininfo;

--
-- Drop table `champions_news_race`
--
DROP TABLE IF EXISTS champions_news_race;

--
-- Drop table `champions_news_title`
--
DROP TABLE IF EXISTS champions_news_title;

--
-- Drop table `champions_news_trainer_detail`
--
DROP TABLE IF EXISTS champions_news_trainer_detail;

--
-- Drop table `champions_news_trainer_wininfo`
--
DROP TABLE IF EXISTS champions_news_trainer_wininfo;

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
-- Drop table `face_type_data`
--
DROP TABLE IF EXISTS face_type_data;

--
-- Drop table `facial_mouth_change`
--
DROP TABLE IF EXISTS facial_mouth_change;

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
-- Drop table `gacha_piece`
--
DROP TABLE IF EXISTS gacha_piece;

--
-- Drop table `gacha_prize_odds`
--
DROP TABLE IF EXISTS gacha_prize_odds;

--
-- Drop table `gacha_stock_campaign`
--
DROP TABLE IF EXISTS gacha_stock_campaign;

--
-- Drop table `gacha_stock_detail`
--
DROP TABLE IF EXISTS gacha_stock_detail;

--
-- Drop table `gacha_top_bg`
--
DROP TABLE IF EXISTS gacha_top_bg;

--
-- Drop table `gift_message`
--
DROP TABLE IF EXISTS gift_message;

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
-- Drop table `item_pack`
--
DROP TABLE IF EXISTS item_pack;

--
-- Drop table `item_place`
--
DROP TABLE IF EXISTS item_place;

--
-- Drop table `jukebox_chara_tag_data`
--
DROP TABLE IF EXISTS jukebox_chara_tag_data;

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
-- Drop table `jukebox_reaction_data`
--
DROP TABLE IF EXISTS jukebox_reaction_data;

--
-- Drop table `jukebox_request_data`
--
DROP TABLE IF EXISTS jukebox_request_data;

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
-- Drop table `legend_race_npc`
--
DROP TABLE IF EXISTS legend_race_npc;

--
-- Drop table `limited_exchange`
--
DROP TABLE IF EXISTS limited_exchange;

--
-- Drop table `limited_exchange_reward`
--
DROP TABLE IF EXISTS limited_exchange_reward;

--
-- Drop table `limited_exchange_reward_odds`
--
DROP TABLE IF EXISTS limited_exchange_reward_odds;

--
-- Drop table `live_data`
--
DROP TABLE IF EXISTS live_data;

--
-- Drop table `live_permission_data`
--
DROP TABLE IF EXISTS live_permission_data;

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
-- Drop table `race_bgm_cutin_extension_time`
--
DROP TABLE IF EXISTS race_bgm_cutin_extension_time;

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
-- Drop table `race_popularity_proper_value`
--
DROP TABLE IF EXISTS race_popularity_proper_value;

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
-- Drop table `race_trophy_reward`
--
DROP TABLE IF EXISTS race_trophy_reward;

--
-- Drop table `random_ear_tail_motion`
--
DROP TABLE IF EXISTS random_ear_tail_motion;

--
-- Drop table `season_data`
--
DROP TABLE IF EXISTS season_data;

--
-- Drop table `short_episode`
--
DROP TABLE IF EXISTS short_episode;

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
-- Drop table `single_mode_ao_training_plate`
--
DROP TABLE IF EXISTS single_mode_ao_training_plate;

--
-- Drop table `single_mode_change_chara_route`
--
DROP TABLE IF EXISTS single_mode_change_chara_route;

--
-- Drop table `single_mode_chara_effect`
--
DROP TABLE IF EXISTS single_mode_chara_effect;

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
-- Drop table `single_mode_hint_gain`
--
DROP TABLE IF EXISTS single_mode_hint_gain;

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
-- Drop table `single_mode_program`
--
DROP TABLE IF EXISTS single_mode_program;

--
-- Drop table `single_mode_race_group`
--
DROP TABLE IF EXISTS single_mode_race_group;

--
-- Drop table `single_mode_race_live`
--
DROP TABLE IF EXISTS single_mode_race_live;

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
-- Drop table `single_mode_scenario_record`
--
DROP TABLE IF EXISTS single_mode_scenario_record;

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
-- Drop table `single_mode_training_effect`
--
DROP TABLE IF EXISTS single_mode_training_effect;

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
-- Drop table `skill_rarity`
--
DROP TABLE IF EXISTS skill_rarity;

--
-- Drop table `skill_set`
--
DROP TABLE IF EXISTS skill_set;

--
-- Drop table `story_event_bingo_reward`
--
DROP TABLE IF EXISTS story_event_bingo_reward;

--
-- Drop table `story_event_bonus_card`
--
DROP TABLE IF EXISTS story_event_bonus_card;

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
-- Drop table `story_event_win_bonus`
--
DROP TABLE IF EXISTS story_event_win_bonus;

--
-- Drop table `story_extra_data`
--
DROP TABLE IF EXISTS story_extra_data;

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
-- Drop table `text_data_english`
--
DROP TABLE IF EXISTS text_data_english;

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
-- Drop table `training_challenge_total_score`
--
DROP TABLE IF EXISTS training_challenge_total_score;

--
-- Drop table `training_cutt_chara_data`
--
DROP TABLE IF EXISTS training_cutt_chara_data;

--
-- Drop table `training_cutt_data`
--
DROP TABLE IF EXISTS training_cutt_data;

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
-- Drop table `tutorial_guide_data`
--
DROP TABLE IF EXISTS tutorial_guide_data;

--
-- Set default database
--
USE umamusume;

--
-- Create table `tutorial_guide_data`
--
CREATE TABLE tutorial_guide_data
(
    id INT(11) NOT NULL
  , group_id INT(11) NOT NULL
  , page_index INT(11) NOT NULL
  , image_index INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 146,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `tutorial_guide_data_0_group_id_1_page_index` on table `tutorial_guide_data`
--
ALTER TABLE tutorial_guide_data
ADD UNIQUE INDEX tutorial_guide_data_0_group_id_1_page_index (group_id, page_index);

--
-- Create index `tutorial_guide_data_0_group_id` on table `tutorial_guide_data`
--
ALTER TABLE tutorial_guide_data
ADD INDEX tutorial_guide_data_0_group_id (group_id);

--
-- Create table `transfer_event_reward`
--
CREATE TABLE transfer_event_reward
(
    transfer_reward_id INT(11) NOT NULL
  , transfer_detail_id INT(11) NOT NULL
  , reward_rank INT(11) NOT NULL
  , item_category INT(11) NOT NULL
  , item_id INT(11) NOT NULL
  , item_num INT(11) NOT NULL
  , odds INT(11) NOT NULL
  , PRIMARY KEY (transfer_reward_id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 130,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `transfer_event_reward_0_transfer_detail_id` on table `transfer_event_reward`
--
ALTER TABLE transfer_event_reward
ADD INDEX transfer_event_reward_0_transfer_detail_id (transfer_detail_id);

--
-- Create table `transfer_event_detail`
--
CREATE TABLE transfer_event_detail
(
    transfer_detail_id INT(11) NOT NULL
  , transfer_event_id INT(11) NOT NULL
  , trainer_type INT(11) NOT NULL
  , difficulty INT(11) NOT NULL
  , limited_type INT(11) NOT NULL
  , start_date INT(11) NOT NULL
  , end_date INT(11) NOT NULL
  , cool_time INT(11) NOT NULL
  , condition1_type INT(11) NOT NULL
  , condition1_value1 INT(11) NOT NULL
  , condition1_value2 INT(11) NOT NULL
  , condition2_type INT(11) NOT NULL
  , condition2_value1 INT(11) NOT NULL
  , condition2_value2 INT(11) NOT NULL
  , condition3_type INT(11) NOT NULL
  , condition3_value1 INT(11) NOT NULL
  , condition3_value2 INT(11) NOT NULL
  , condition4_type INT(11) NOT NULL
  , condition4_value1 INT(11) NOT NULL
  , condition4_value2 INT(11) NOT NULL
  , condition5_type INT(11) NOT NULL
  , condition5_value1 INT(11) NOT NULL
  , condition5_value2 INT(11) NOT NULL
  , PRIMARY KEY (transfer_detail_id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 303,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `transfer_event_detail_0_transfer_event_id` on table `transfer_event_detail`
--
ALTER TABLE transfer_event_detail
ADD INDEX transfer_event_detail_0_transfer_event_id (transfer_event_id);

--
-- Create table `transfer_event_data`
--
CREATE TABLE transfer_event_data
(
    transfer_event_id INT(11) NOT NULL
  , pre_start_date INT(11) NOT NULL
  , start_date INT(11) NOT NULL
  , end_date INT(11) NOT NULL
  , PRIMARY KEY (transfer_event_id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 2048,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `training_cutt_data`
--
CREATE TABLE training_cutt_data
(
    command_id INT(11) NOT NULL
  , sub_id INT(11) NOT NULL
  , chara_num INT(11) NOT NULL
  , target_chara_index INT(11) NOT NULL
  , target_value INT(11) NOT NULL
  , cutt_index INT(11) NOT NULL
  , success_flg INT(11) NOT NULL
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 227,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `training_cutt_data_0_command_id_1_sub_id` on table `training_cutt_data`
--
ALTER TABLE training_cutt_data
ADD INDEX training_cutt_data_0_command_id_1_sub_id (command_id, sub_id);

--
-- Create table `training_cutt_chara_data`
--
CREATE TABLE training_cutt_chara_data
(
    id INT(11) NOT NULL
  , command_id INT(11) NOT NULL
  , sub_id INT(11) NOT NULL
  , chara_num INT(11) NOT NULL
  , chara_id INT(11) NOT NULL
  , target_timeline INT(11) NOT NULL
  , target_list_index INT(11) NOT NULL
  , prop_target INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 58,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `training_cutt_chara_data_0_command_id_1_sub_id` on table `training_cutt_chara_data`
--
ALTER TABLE training_cutt_chara_data
ADD INDEX training_cutt_chara_data_0_command_id_1_sub_id (command_id, sub_id);

--
-- Create table `training_challenge_total_score`
--
CREATE TABLE training_challenge_total_score
(
    id INT(11) NOT NULL
  , total_score INT(11) NOT NULL
  , reward_coin INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 546,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `training_challenge_score`
--
CREATE TABLE training_challenge_score
(
    id INT(11) NOT NULL
  , score_group_id INT(11) NOT NULL
  , score_type INT(11) NOT NULL
  , data INT(11) NOT NULL
  , disp_order INT(11) NOT NULL
  , bonus_score INT(11) NOT NULL
  , reward_coin INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 130,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `training_challenge_score_0_score_group_id` on table `training_challenge_score`
--
ALTER TABLE training_challenge_score
ADD INDEX training_challenge_score_0_score_group_id (score_group_id);

--
-- Create table `training_challenge_master`
--
CREATE TABLE training_challenge_master
(
    id INT(11) NOT NULL
  , target_main_scenario INT(11) NOT NULL
  , exam_id_1 INT(11) NOT NULL
  , exam_id_2 INT(11) NOT NULL
  , exam_id_3 INT(11) NOT NULL
  , exam_id_4 INT(11) NOT NULL
  , exam_id_5 INT(11) NOT NULL
  , ex_exam_id INT(11) NOT NULL
  , free_exam_id INT(11) NOT NULL
  , shop_id INT(11) NOT NULL
  , start_date INT(11) NOT NULL
  , end_date INT(11) NOT NULL
  , start_result_date INT(11) NOT NULL
  , end_result_date INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 16384,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `training_challenge_exam`
--
CREATE TABLE training_challenge_exam
(
    id INT(11) NOT NULL
  , feature_type INT(11) NOT NULL
  , good_score INT(11) NOT NULL
  , good_score_reward_coin INT(11) NOT NULL
  , great_score INT(11) NOT NULL
  , great_score_reward_coin INT(11) NOT NULL
  , exellent_score INT(11) NOT NULL
  , exellent_score_reward_coin INT(11) NOT NULL
  , score_group_id INT(11) NOT NULL
  , item_category_1 INT(11) NOT NULL
  , item_id_1 INT(11) NOT NULL
  , item_num_1 INT(11) NOT NULL
  , item_category_2 INT(11) NOT NULL
  , item_id_2 INT(11) NOT NULL
  , item_num_2 INT(11) NOT NULL
  , item_category_3 INT(11) NOT NULL
  , item_id_3 INT(11) NOT NULL
  , item_num_3 INT(11) NOT NULL
  , item_category_4 INT(11) NOT NULL
  , item_id_4 INT(11) NOT NULL
  , item_num_4 INT(11) NOT NULL
  , item_category_5 INT(11) NOT NULL
  , item_id_5 INT(11) NOT NULL
  , item_num_5 INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 2340,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `trained_chara_trade_item`
--
CREATE TABLE trained_chara_trade_item
(
    id INT(11) NOT NULL
  , trained_chara_rank INT(11) NOT NULL
  , trade_item_category INT(11) NOT NULL
  , trade_item_id INT(11) NOT NULL
  , trade_item_num INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 167,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `trained_chara_trade_item_0_trained_chara_rank` on table `trained_chara_trade_item`
--
ALTER TABLE trained_chara_trade_item
ADD UNIQUE INDEX trained_chara_trade_item_0_trained_chara_rank (trained_chara_rank);

--
-- Create table `topics`
--
CREATE TABLE topics
(
    id INT(11) NOT NULL
  , type INT(11) NOT NULL
  , value INT(11) NOT NULL
  , `index` INT(11) NOT NULL
  , start_date TEXT NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 144,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `topics_0_type` on table `topics`
--
ALTER TABLE topics
ADD INDEX topics_0_type (type);

--
-- Create table `timezone_data`
--
CREATE TABLE timezone_data
(
    timezone INT(11) NOT NULL
  , priority INT(11) NOT NULL
  , start_hour TEXT NOT NULL
  , end_hour TEXT NOT NULL
  , PRIMARY KEY (timezone)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 4096,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `text_data_english`
--
CREATE TABLE text_data_english
(
    text TEXT NOT NULL
  , translation TEXT NOT NULL
  , id INT(11) NOT NULL AUTO_INCREMENT
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AUTO_INCREMENT = 14461,
AVG_ROW_LENGTH = 312,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `text_data_english_text` on table `text_data_english`
--
ALTER TABLE text_data_english
ADD INDEX text_data_english_text (text (768));

--
-- Create table `text_data`
--
CREATE TABLE text_data
(
    id INT(11) NOT NULL
  , category INT(11) NOT NULL
  , `index` INT(11) NOT NULL
  , text TEXT NOT NULL
  , PRIMARY KEY (category, `index`)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 112,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `team_stadium_support_text`
--
CREATE TABLE team_stadium_support_text
(
    id INT(11) NOT NULL
  , type INT(11) NOT NULL
  , min_bonus INT(11) NOT NULL
  , max_bonus INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1638,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `team_stadium_support_text_0_type` on table `team_stadium_support_text`
--
ALTER TABLE team_stadium_support_text
ADD INDEX team_stadium_support_text_0_type (type);

--
-- Create table `team_stadium_stand_motion`
--
CREATE TABLE team_stadium_stand_motion
(
    character_id INT(11) NOT NULL
  , type INT(11) NOT NULL
  , race_dress_id INT(11) NOT NULL
  , position INT(11) NOT NULL
  , motion_set INT(11) NOT NULL
  , rotation INT(11) NOT NULL
  , position_x INT(11) NOT NULL
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1170,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `team_stadium_stand_motion_0_character_id_1_type` on table `team_stadium_stand_motion`
--
ALTER TABLE team_stadium_stand_motion
ADD INDEX team_stadium_stand_motion_0_character_id_1_type (character_id, type);

--
-- Create table `team_stadium_score_bonus`
--
CREATE TABLE team_stadium_score_bonus
(
    id INT(11) NOT NULL
  , priority INT(11) NOT NULL
  , condition_type INT(11) NOT NULL
  , condition_value_1 INT(11) NOT NULL
  , condition_value_2 INT(11) NOT NULL
  , score_rate INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 2340,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `team_stadium_score_bonus_0_condition_type` on table `team_stadium_score_bonus`
--
ALTER TABLE team_stadium_score_bonus
ADD INDEX team_stadium_score_bonus_0_condition_type (condition_type);

--
-- Create table `team_stadium_raw_score`
--
CREATE TABLE team_stadium_raw_score
(
    id INT(11) NOT NULL
  , priority INT(11) NOT NULL
  , condition_type INT(11) NOT NULL
  , condition_value_1 INT(11) NOT NULL
  , condition_value_2 INT(11) NOT NULL
  , score INT(11) NOT NULL
  , race_score_name_id INT(11) NOT NULL
  , sort_order INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 172,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

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
CREATE TABLE team_stadium_rank
(
    id INT(11) NOT NULL
  , team_rank INT(11) NOT NULL
  , team_rank_group INT(11) NOT NULL
  , team_min_value INT(11) NOT NULL
  , team_max_value INT(11) NOT NULL
  , item_category INT(11) NOT NULL
  , item_id INT(11) NOT NULL
  , item_num INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 546,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `team_stadium_race_result_motion`
--
CREATE TABLE team_stadium_race_result_motion
(
    character_id INT(11) NOT NULL
  , win_1 INT(11) NOT NULL
  , win_2 INT(11) NOT NULL
  , win_2_position_y INT(11) NOT NULL
  , win_3 INT(11) NOT NULL
  , win_3_position_y INT(11) NOT NULL
  , win_4 INT(11) NOT NULL
  , win_4_position_y INT(11) NOT NULL
  , win_5 INT(11) NOT NULL
  , lose_1 INT(11) NOT NULL
  , lose_2 INT(11) NOT NULL
  , lose_3 INT(11) NOT NULL
  , lose_4 INT(11) NOT NULL
  , lose_5 INT(11) NOT NULL
  , draw_1 INT(11) NOT NULL
  , draw_2 INT(11) NOT NULL
  , draw_3 INT(11) NOT NULL
  , draw_4 INT(11) NOT NULL
  , draw_5 INT(11) NOT NULL
  , position_y INT(11) NOT NULL
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 230,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `team_stadium_race_result_motion_0_character_id` on table `team_stadium_race_result_motion`
--
ALTER TABLE team_stadium_race_result_motion
ADD INDEX team_stadium_race_result_motion_0_character_id (character_id);

--
-- Create table `team_stadium_evaluation_rate`
--
CREATE TABLE team_stadium_evaluation_rate
(
    id INT(11) NOT NULL
  , proper_type INT(11) NOT NULL
  , proper_rank INT(11) NOT NULL
  , rate INT(11) NOT NULL
  , PRIMARY KEY (proper_type, proper_rank)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 682,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `team_stadium_class_reward`
--
CREATE TABLE team_stadium_class_reward
(
    id INT(11) NOT NULL
  , team_stadium_id INT(11) NOT NULL
  , team_class INT(11) NOT NULL
  , class_reward_type INT(11) NOT NULL
  , item_category_1 INT(11) NOT NULL
  , item_id_1 INT(11) NOT NULL
  , item_num_1 INT(11) NOT NULL
  , item_category_2 INT(11) NOT NULL
  , item_id_2 INT(11) NOT NULL
  , item_num_2 INT(11) NOT NULL
  , item_category_3 INT(11) NOT NULL
  , item_id_3 INT(11) NOT NULL
  , item_num_3 INT(11) NOT NULL
  , item_category_4 INT(11) NOT NULL
  , item_id_4 INT(11) NOT NULL
  , item_num_4 INT(11) NOT NULL
  , item_category_5 INT(11) NOT NULL
  , item_id_5 INT(11) NOT NULL
  , item_num_5 INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 963,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `team_stadium_class_reward_0_team_stadium_id_1_class_reward_type` on table `team_stadium_class_reward`
--
ALTER TABLE team_stadium_class_reward
ADD INDEX team_stadium_class_reward_0_team_stadium_id_1_class_reward_type (team_stadium_id, class_reward_type);

--
-- Create table `team_stadium_class`
--
CREATE TABLE team_stadium_class
(
    id INT(11) NOT NULL
  , team_stadium_id INT(11) NOT NULL
  , team_class INT(11) NOT NULL
  , unit_max_num INT(11) NOT NULL
  , class_up_range INT(11) NOT NULL
  , class_down_range INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 2730,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `team_stadium_class_0_team_stadium_id` on table `team_stadium_class`
--
ALTER TABLE team_stadium_class
ADD INDEX team_stadium_class_0_team_stadium_id (team_stadium_id);

--
-- Create table `team_stadium_bgm`
--
CREATE TABLE team_stadium_bgm
(
    id INT(11) NOT NULL
  , scene_type INT(11) NOT NULL
  , priority INT(11) NOT NULL
  , cue_name TEXT NOT NULL
  , cuesheet_name TEXT NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1489,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `team_stadium_bgm_0_scene_type` on table `team_stadium_bgm`
--
ALTER TABLE team_stadium_bgm
ADD INDEX team_stadium_bgm_0_scene_type (scene_type);

--
-- Create table `team_stadium`
--
CREATE TABLE team_stadium
(
    id INT(11) NOT NULL
  , race_start_date INT(11) NOT NULL
  , race_start_time TEXT NOT NULL
  , race_end_date INT(11) NOT NULL
  , race_end_time TEXT NOT NULL
  , interval_start_date INT(11) NOT NULL
  , interval_start_time TEXT NOT NULL
  , interval_end_date INT(11) NOT NULL
  , interval_end_time TEXT NOT NULL
  , calc_start_date INT(11) NOT NULL
  , calc_start_time TEXT NOT NULL
  , calc_end_date INT(11) NOT NULL
  , calc_end_time TEXT NOT NULL
  , start_date TEXT NOT NULL
  , end_date TEXT NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 16384,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `support_card_unique_effect`
--
CREATE TABLE support_card_unique_effect
(
    id INT(11) NOT NULL
  , lv INT(11) NOT NULL
  , type_0 INT(11) NOT NULL
  , value_0 INT(11) NOT NULL
  , value_0_1 INT(11) NOT NULL
  , value_0_2 INT(11) NOT NULL
  , value_0_3 INT(11) NOT NULL
  , value_0_4 INT(11) NOT NULL
  , type_1 INT(11) NOT NULL
  , value_1 INT(11) NOT NULL
  , value_1_1 INT(11) NOT NULL
  , value_1_2 INT(11) NOT NULL
  , value_1_3 INT(11) NOT NULL
  , value_1_4 INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 136,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `support_card_team_score_bonus`
--
CREATE TABLE support_card_team_score_bonus
(
    id INT(11) NOT NULL
  , level INT(11) NOT NULL
  , score_rate INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 2340,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `support_card_team_score_bonus_0_level` on table `support_card_team_score_bonus`
--
ALTER TABLE support_card_team_score_bonus
ADD INDEX support_card_team_score_bonus_0_level (level);

--
-- Create table `support_card_limit_break`
--
CREATE TABLE support_card_limit_break
(
    id INT(11) NOT NULL
  , rarity INT(11) NOT NULL
  , item_id INT(11) NOT NULL
  , item_num INT(11) NOT NULL
  , disp_order INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 8192,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `support_card_limit`
--
CREATE TABLE support_card_limit
(
    rarity INT(11) NOT NULL
  , limit_0 INT(11) NOT NULL
  , limit_1 INT(11) NOT NULL
  , limit_2 INT(11) NOT NULL
  , limit_3 INT(11) NOT NULL
  , limit_4 INT(11) NOT NULL
  , PRIMARY KEY (rarity)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 5461,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `support_card_level`
--
CREATE TABLE support_card_level
(
    id INT(11) NOT NULL
  , rarity INT(11) NOT NULL
  , level INT(11) NOT NULL
  , total_exp INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 121,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

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
CREATE TABLE support_card_group
(
    id INT(11) NOT NULL
  , support_card_id INT(11) NOT NULL
  , chara_id INT(11) NOT NULL
  , outing_max INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `support_card_group_0_support_card_id` on table `support_card_group`
--
ALTER TABLE support_card_group
ADD INDEX support_card_group_0_support_card_id (support_card_id);

--
-- Create index `support_card_group_0_chara_id` on table `support_card_group`
--
ALTER TABLE support_card_group
ADD INDEX support_card_group_0_chara_id (chara_id);

--
-- Create table `support_card_effect_table`
--
CREATE TABLE support_card_effect_table
(
    id INT(11) NOT NULL
  , type INT(11) NOT NULL
  , init INT(11) NOT NULL
  , limit_lv5 INT(11) NOT NULL
  , limit_lv10 INT(11) NOT NULL
  , limit_lv15 INT(11) NOT NULL
  , limit_lv20 INT(11) NOT NULL
  , limit_lv25 INT(11) NOT NULL
  , limit_lv30 INT(11) NOT NULL
  , limit_lv35 INT(11) NOT NULL
  , limit_lv40 INT(11) NOT NULL
  , limit_lv45 INT(11) NOT NULL
  , limit_lv50 INT(11) NOT NULL
  , PRIMARY KEY (id, type)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 91,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `support_card_effect_table_0_id` on table `support_card_effect_table`
--
ALTER TABLE support_card_effect_table
ADD INDEX support_card_effect_table_0_id (id);

--
-- Create table `support_card_data`
--
CREATE TABLE support_card_data
(
    id INT(11) NOT NULL
  , chara_id INT(11) NOT NULL
  , rarity INT(11) NOT NULL
  , exchange_item_id INT(11) NOT NULL
  , effect_table_id INT(11) NOT NULL
  , unique_effect_id INT(11) NOT NULL
  , command_type INT(11) NOT NULL
  , command_id INT(11) NOT NULL
  , support_card_type INT(11) NOT NULL
  , skill_set_id INT(11) NOT NULL
  , detail_pos_x INT(11) NOT NULL
  , detail_pos_y INT(11) NOT NULL
  , detail_scale INT(11) NOT NULL
  , detail_rot_z INT(11) NOT NULL
  , start_date INT(11) NOT NULL
  , outing_max INT(11) NOT NULL
  , effect_id INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 249,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `support_card_data_0_chara_id` on table `support_card_data`
--
ALTER TABLE support_card_data
ADD INDEX support_card_data_0_chara_id (chara_id);

--
-- Create table `succession_rental`
--
CREATE TABLE succession_rental
(
    id INT(11) NOT NULL
  , rental_rank INT(11) NOT NULL
  , rental_num INT(11) NOT NULL
  , use_value1 INT(11) NOT NULL
  , use_value2 INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 83,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `succession_rental_0_rental_rank_1_rental_num` on table `succession_rental`
--
ALTER TABLE succession_rental
ADD INDEX succession_rental_0_rental_rank_1_rental_num (rental_rank, rental_num);

--
-- Create table `succession_relation_rank`
--
CREATE TABLE succession_relation_rank
(
    relation_rank INT(11) NOT NULL
  , rank_value_min INT(11) NOT NULL
  , rank_value_max INT(11) NOT NULL
  , PRIMARY KEY (relation_rank)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 5461,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `succession_relation_member`
--
CREATE TABLE succession_relation_member
(
    id INT(11) NOT NULL
  , relation_type INT(11) NOT NULL
  , chara_id INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 55,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `succession_relation_member_0_chara_id` on table `succession_relation_member`
--
ALTER TABLE succession_relation_member
ADD INDEX succession_relation_member_0_chara_id (chara_id);

--
-- Create table `succession_relation`
--
CREATE TABLE succession_relation
(
    relation_type INT(11) NOT NULL
  , relation_point INT(11) NOT NULL
  , PRIMARY KEY (relation_type)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 69,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `succession_initial_factor`
--
CREATE TABLE succession_initial_factor
(
    id INT(11) NOT NULL
  , factor_type INT(11) NOT NULL
  , value_1 INT(11) NOT NULL
  , value_2 INT(11) NOT NULL
  , add_point INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 2340,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `succession_initial_factor_0_factor_type_1_value_1` on table `succession_initial_factor`
--
ALTER TABLE succession_initial_factor
ADD INDEX succession_initial_factor_0_factor_type_1_value_1 (factor_type, value_1);

--
-- Create index `succession_initial_factor_0_factor_type` on table `succession_initial_factor`
--
ALTER TABLE succession_initial_factor
ADD INDEX succession_initial_factor_0_factor_type (factor_type);

--
-- Create table `succession_factor_effect`
--
CREATE TABLE succession_factor_effect
(
    id INT(11) NOT NULL
  , factor_group_id INT(11) NOT NULL
  , effect_id INT(11) NOT NULL
  , target_type INT(11) NOT NULL
  , value_1 INT(11) NOT NULL
  , value_2 INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 72,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

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
CREATE TABLE succession_factor
(
    factor_id INT(11) NOT NULL
  , factor_group_id INT(11) NOT NULL
  , rarity INT(11) NOT NULL
  , grade INT(11) NOT NULL
  , factor_type INT(11) NOT NULL
  , effect_group_id INT(11) NOT NULL
  , start_date INT(11) NOT NULL
  , end_date INT(11) NOT NULL
  , PRIMARY KEY (factor_id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 93,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `succession_factor_0_factor_group_id_1_rarity` on table `succession_factor`
--
ALTER TABLE succession_factor
ADD UNIQUE INDEX succession_factor_0_factor_group_id_1_rarity (factor_group_id, rarity);

--
-- Create table `story_still`
--
CREATE TABLE story_still
(
    id INT(11) NOT NULL
  , still_id INT(11) NOT NULL
  , page_id INT(11) NOT NULL
  , order_id INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 244,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `story_still_0_still_id` on table `story_still`
--
ALTER TABLE story_still
ADD INDEX story_still_0_still_id (still_id);

--
-- Create table `story_live_position`
--
CREATE TABLE story_live_position
(
    id INT(11) NOT NULL
  , set_id INT(11) NOT NULL
  , music_id INT(11) NOT NULL
  , position_id INT(11) NOT NULL
  , chara_type INT(11) NOT NULL
  , chara_id INT(11) NOT NULL
  , dress_id INT(11) NOT NULL
  , dress_color INT(11) NOT NULL
  , second_dress_id INT(11) NOT NULL
  , second_dress_color INT(11) NOT NULL
  , vocal_chara_id INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 172,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `story_live_position_0_set_id` on table `story_live_position`
--
ALTER TABLE story_live_position
ADD INDEX story_live_position_0_set_id (set_id);

--
-- Create index `story_live_position_0_music_id` on table `story_live_position`
--
ALTER TABLE story_live_position
ADD INDEX story_live_position_0_music_id (music_id);

--
-- Create table `story_hip_offset`
--
CREATE TABLE story_hip_offset
(
    category_id INT(11) NOT NULL
  , chara_id INT(11) NOT NULL
  , offset INT(11) NOT NULL
  , PRIMARY KEY (category_id, chara_id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 496,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `story_extra_story_data`
--
CREATE TABLE story_extra_story_data
(
    id INT(11) NOT NULL
  , story_extra_id INT(11) NOT NULL
  , episode_index_id INT(11) NOT NULL
  , story_type_1 INT(11) NOT NULL
  , story_id_1 INT(11) NOT NULL
  , story_type_2 INT(11) NOT NULL
  , story_id_2 INT(11) NOT NULL
  , story_type_3 INT(11) NOT NULL
  , story_id_3 INT(11) NOT NULL
  , story_type_4 INT(11) NOT NULL
  , story_id_4 INT(11) NOT NULL
  , story_type_5 INT(11) NOT NULL
  , story_id_5 INT(11) NOT NULL
  , add_reward_category_1 INT(11) NOT NULL
  , add_reward_id_1 INT(11) NOT NULL
  , add_reward_num_1 INT(11) NOT NULL
  , add_reward_category_2 INT(11) NOT NULL
  , add_reward_id_2 INT(11) NOT NULL
  , add_reward_num_2 INT(11) NOT NULL
  , start_date INT(11) NOT NULL
  , notice_end_date INT(11) NOT NULL
  , end_date INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1260,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `story_extra_story_data_0_story_extra_id` on table `story_extra_story_data`
--
ALTER TABLE story_extra_story_data
ADD INDEX story_extra_story_data_0_story_extra_id (story_extra_id);

--
-- Create table `story_extra_data`
--
CREATE TABLE story_extra_data
(
    story_extra_id INT(11) NOT NULL
  , start_date INT(11) NOT NULL
  , end_date INT(11) NOT NULL
  , PRIMARY KEY (story_extra_id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 8192,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `story_event_win_bonus`
--
CREATE TABLE story_event_win_bonus
(
    id INT(11) NOT NULL
  , story_event_id INT(11) NOT NULL
  , min_win_count INT(11) NOT NULL
  , max_win_count INT(11) NOT NULL
  , bonus_point INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 58,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `story_event_win_bonus_0_story_event_id` on table `story_event_win_bonus`
--
ALTER TABLE story_event_win_bonus
ADD INDEX story_event_win_bonus_0_story_event_id (story_event_id);

--
-- Create table `story_event_top_chara`
--
CREATE TABLE story_event_top_chara
(
    id INT(11) NOT NULL
  , story_event_id INT(11) NOT NULL
  , min_episode_index INT(11) NOT NULL
  , max_episode_index INT(11) NOT NULL
  , ending_flag INT(11) NOT NULL
  , character_id INT(11) NOT NULL
  , dress_id INT(11) NOT NULL
  , menu_bg_id INT(11) NOT NULL
  , menu_bg_sub_id INT(11) NOT NULL
  , bgm_cue_name TEXT NOT NULL
  , bgm_cuesheet_name TEXT NOT NULL
  , env_cue_name TEXT NOT NULL
  , env_cuesheet_name TEXT NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 396,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `story_event_top_chara_0_story_event_id` on table `story_event_top_chara`
--
ALTER TABLE story_event_top_chara
ADD INDEX story_event_top_chara_0_story_event_id (story_event_id);

--
-- Create table `story_event_story_data`
--
CREATE TABLE story_event_story_data
(
    id INT(11) NOT NULL
  , story_event_id INT(11) NOT NULL
  , episode_index_id INT(11) NOT NULL
  , story_condition_type INT(11) NOT NULL
  , story_type_1 INT(11) NOT NULL
  , story_id_1 INT(11) NOT NULL
  , story_type_2 INT(11) NOT NULL
  , story_id_2 INT(11) NOT NULL
  , story_type_3 INT(11) NOT NULL
  , story_id_3 INT(11) NOT NULL
  , story_type_4 INT(11) NOT NULL
  , story_id_4 INT(11) NOT NULL
  , story_type_5 INT(11) NOT NULL
  , story_id_5 INT(11) NOT NULL
  , need_point INT(11) NOT NULL
  , add_reward_category_1 INT(11) NOT NULL
  , add_reward_id_1 INT(11) NOT NULL
  , add_reward_num_1 INT(11) NOT NULL
  , add_reward_category_2 INT(11) NOT NULL
  , add_reward_id_2 INT(11) NOT NULL
  , add_reward_num_2 INT(11) NOT NULL
  , start_date INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 182,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `story_event_story_data_0_story_event_id_1_episode_index_id` on table `story_event_story_data`
--
ALTER TABLE story_event_story_data
ADD UNIQUE INDEX story_event_story_data_0_story_event_id_1_episode_index_id (story_event_id, episode_index_id);

--
-- Create index `story_event_story_data_0_story_event_id` on table `story_event_story_data`
--
ALTER TABLE story_event_story_data
ADD INDEX story_event_story_data_0_story_event_id (story_event_id);

--
-- Create table `story_event_roulette_bingo`
--
CREATE TABLE story_event_roulette_bingo
(
    id INT(11) NOT NULL
  , roulette_id INT(11) NOT NULL
  , story_event_id INT(11) NOT NULL
  , sheet_num INT(11) NOT NULL
  , can_loop INT(11) NOT NULL
  , use_item_category INT(11) NOT NULL
  , use_item_id INT(11) NOT NULL
  , use_item_num INT(11) NOT NULL
  , character_id INT(11) NOT NULL
  , dress_id INT(11) NOT NULL
  , reset_line INT(11) NOT NULL
  , reward_set_id INT(11) NOT NULL
  , roulette_max_num INT(11) NOT NULL
  , start_date INT(11) NOT NULL
  , end_date INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 372,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

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
CREATE TABLE story_event_point_reward
(
    id INT(11) NOT NULL
  , story_event_id INT(11) NOT NULL
  , item_category INT(11) NOT NULL
  , item_id INT(11) NOT NULL
  , item_num INT(11) NOT NULL
  , point INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 76,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `story_event_point_reward_0_story_event_id` on table `story_event_point_reward`
--
ALTER TABLE story_event_point_reward
ADD INDEX story_event_point_reward_0_story_event_id (story_event_id);

--
-- Create table `story_event_nickname_bonus`
--
CREATE TABLE story_event_nickname_bonus
(
    id INT(11) NOT NULL
  , story_event_id INT(11) NOT NULL
  , nickname_rank INT(11) NOT NULL
  , bonus_point INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 496,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

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
CREATE TABLE story_event_mission_top_chara
(
    id INT(11) NOT NULL
  , story_event_id INT(11) NOT NULL
  , ending_flag INT(11) NOT NULL
  , character_id INT(11) NOT NULL
  , dress_id INT(11) NOT NULL
  , menu_bg_id INT(11) NOT NULL
  , menu_bg_sub_id INT(11) NOT NULL
  , bgm_cue_name TEXT NOT NULL
  , bgm_cuesheet_name TEXT NOT NULL
  , env_cue_name TEXT NOT NULL
  , env_cuesheet_name TEXT NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 744,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `story_event_mission_top_chara_0_story_event_id` on table `story_event_mission_top_chara`
--
ALTER TABLE story_event_mission_top_chara
ADD INDEX story_event_mission_top_chara_0_story_event_id (story_event_id);

--
-- Create table `story_event_mission`
--
CREATE TABLE story_event_mission
(
    id INT(11) NOT NULL
  , story_event_id INT(11) NOT NULL
  , mission_type INT(11) NOT NULL
  , condition_type INT(11) NOT NULL
  , condition_value_1 INT(11) NOT NULL
  , condition_value_2 INT(11) NOT NULL
  , condition_value_3 INT(11) NOT NULL
  , condition_value_4 INT(11) NOT NULL
  , condition_num INT(11) NOT NULL
  , step_group_id INT(11) NOT NULL
  , step_order INT(11) NOT NULL
  , disp_order INT(11) NOT NULL
  , item_category INT(11) NOT NULL
  , item_id INT(11) NOT NULL
  , item_num INT(11) NOT NULL
  , transition_type INT(11) NOT NULL
  , date_check_flg INT(11) NOT NULL
  , start_date INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 169,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `story_event_mission_0_story_event_id` on table `story_event_mission`
--
ALTER TABLE story_event_mission
ADD INDEX story_event_mission_0_story_event_id (story_event_id);

--
-- Create table `story_event_data`
--
CREATE TABLE story_event_data
(
    story_event_id INT(11) NOT NULL
  , announce_id INT(11) NOT NULL
  , consume_tp_ratio INT(11) NOT NULL
  , bonus_reward_ratio INT(11) NOT NULL
  , notice_date INT(11) NOT NULL
  , start_date INT(11) NOT NULL
  , middle_date_01 INT(11) NOT NULL
  , middle_date_02 INT(11) NOT NULL
  , ending_date INT(11) NOT NULL
  , end_date INT(11) NOT NULL
  , PRIMARY KEY (story_event_id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1489,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `story_event_bonus_support_card`
--
CREATE TABLE story_event_bonus_support_card
(
    id INT(11) NOT NULL
  , story_event_id INT(11) NOT NULL
  , chara_id INT(11) NOT NULL
  , rarity INT(11) NOT NULL
  , support_card_id INT(11) NOT NULL
  , limit_0 INT(11) NOT NULL
  , limit_1 INT(11) NOT NULL
  , limit_2 INT(11) NOT NULL
  , limit_3 INT(11) NOT NULL
  , limit_4 INT(11) NOT NULL
  , start_date INT(11) NOT NULL
  , end_date INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 96,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `story_event_id` on table `story_event_bonus_support_card`
--
ALTER TABLE story_event_bonus_support_card
ADD UNIQUE INDEX story_event_id (story_event_id, chara_id, rarity, support_card_id);

--
-- Create index `story_event_bonus_support_card_0_story_event_id` on table `story_event_bonus_support_card`
--
ALTER TABLE story_event_bonus_support_card
ADD INDEX story_event_bonus_support_card_0_story_event_id (story_event_id);

--
-- Create table `story_event_bonus_card`
--
CREATE TABLE story_event_bonus_card
(
    id INT(11) NOT NULL
  , story_event_id INT(11) NOT NULL
  , chara_id INT(11) NOT NULL
  , card_id INT(11) NOT NULL
  , rarity_1 INT(11) NOT NULL
  , rarity_2 INT(11) NOT NULL
  , rarity_3 INT(11) NOT NULL
  , rarity_4 INT(11) NOT NULL
  , rarity_5 INT(11) NOT NULL
  , start_date INT(11) NOT NULL
  , end_date INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 237,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `story_event_id` on table `story_event_bonus_card`
--
ALTER TABLE story_event_bonus_card
ADD UNIQUE INDEX story_event_id (story_event_id, chara_id, card_id);

--
-- Create index `story_event_bonus_card_0_story_event_id` on table `story_event_bonus_card`
--
ALTER TABLE story_event_bonus_card
ADD INDEX story_event_bonus_card_0_story_event_id (story_event_id);

--
-- Create table `story_event_bingo_reward`
--
CREATE TABLE story_event_bingo_reward
(
    id INT(11) NOT NULL
  , reward_set_id INT(11) NOT NULL
  , line_num INT(11) NOT NULL
  , item_category INT(11) NOT NULL
  , item_id INT(11) NOT NULL
  , item_num INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 89,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `story_event_bingo_reward_0_reward_set_id` on table `story_event_bingo_reward`
--
ALTER TABLE story_event_bingo_reward
ADD INDEX story_event_bingo_reward_0_reward_set_id (reward_set_id);

--
-- Create table `skill_set`
--
CREATE TABLE skill_set
(
    id INT(11) NOT NULL
  , skill_id1 INT(11) NOT NULL
  , skill_level1 INT(11) NOT NULL
  , skill_id2 INT(11) NOT NULL
  , skill_level2 INT(11) NOT NULL
  , skill_id3 INT(11) NOT NULL
  , skill_level3 INT(11) NOT NULL
  , skill_id4 INT(11) NOT NULL
  , skill_level4 INT(11) NOT NULL
  , skill_id5 INT(11) NOT NULL
  , skill_level5 INT(11) NOT NULL
  , skill_id6 INT(11) NOT NULL
  , skill_level6 INT(11) NOT NULL
  , skill_id7 INT(11) NOT NULL
  , skill_level7 INT(11) NOT NULL
  , skill_id8 INT(11) NOT NULL
  , skill_level8 INT(11) NOT NULL
  , skill_id9 INT(11) NOT NULL
  , skill_level9 INT(11) NOT NULL
  , skill_id10 INT(11) NOT NULL
  , skill_level10 INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 142,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `skill_rarity`
--
CREATE TABLE skill_rarity
(
    id INT(11) NOT NULL
  , value INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 3276,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `skill_level_value`
--
CREATE TABLE skill_level_value
(
    id INT(11) NOT NULL
  , ability_type INT(11) NOT NULL
  , level INT(11) NOT NULL
  , float_ability_value_coef INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 72,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `skill_level_value_0_ability_type` on table `skill_level_value`
--
ALTER TABLE skill_level_value
ADD INDEX skill_level_value_0_ability_type (ability_type);

--
-- Create table `skill_exp`
--
CREATE TABLE skill_exp
(
    id INT(11) NOT NULL
  , type INT(11) NOT NULL
  , level INT(11) NOT NULL
  , scale INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1638,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `skill_exp_0_type` on table `skill_exp`
--
ALTER TABLE skill_exp
ADD INDEX skill_exp_0_type (type);

--
-- Create table `skill_data`
--
CREATE TABLE skill_data
(
    id INT(11) NOT NULL
  , rarity INT(11) NOT NULL
  , group_id INT(11) NOT NULL
  , group_rate INT(11) NOT NULL
  , filter_switch INT(11) NOT NULL
  , grade_value INT(11) NOT NULL
  , skill_category INT(11) NOT NULL
  , tag_id TEXT NOT NULL
  , unique_skill_id_1 INT(11) NOT NULL
  , unique_skill_id_2 INT(11) NOT NULL
  , exp_type INT(11) NOT NULL
  , potential_per_default INT(11) NOT NULL
  , activate_lot INT(11) NOT NULL
  , precondition_1 TEXT NOT NULL
  , condition_1 TEXT NOT NULL
  , float_ability_time_1 INT(11) NOT NULL
  , ability_time_usage_1 INT(11) NOT NULL
  , float_cooldown_time_1 INT(11) NOT NULL
  , ability_type_1_1 INT(11) NOT NULL
  , ability_value_usage_1_1 INT(11) NOT NULL
  , ability_value_level_usage_1_1 INT(11) NOT NULL
  , float_ability_value_1_1 INT(11) NOT NULL
  , target_type_1_1 INT(11) NOT NULL
  , target_value_1_1 INT(11) NOT NULL
  , ability_type_1_2 INT(11) NOT NULL
  , ability_value_usage_1_2 INT(11) NOT NULL
  , ability_value_level_usage_1_2 INT(11) NOT NULL
  , float_ability_value_1_2 INT(11) NOT NULL
  , target_type_1_2 INT(11) NOT NULL
  , target_value_1_2 INT(11) NOT NULL
  , ability_type_1_3 INT(11) NOT NULL
  , ability_value_usage_1_3 INT(11) NOT NULL
  , ability_value_level_usage_1_3 INT(11) NOT NULL
  , float_ability_value_1_3 INT(11) NOT NULL
  , target_type_1_3 INT(11) NOT NULL
  , target_value_1_3 INT(11) NOT NULL
  , precondition_2 TEXT NOT NULL
  , condition_2 TEXT NOT NULL
  , float_ability_time_2 INT(11) NOT NULL
  , ability_time_usage_2 INT(11) NOT NULL
  , float_cooldown_time_2 INT(11) NOT NULL
  , ability_type_2_1 INT(11) NOT NULL
  , ability_value_usage_2_1 INT(11) NOT NULL
  , ability_value_level_usage_2_1 INT(11) NOT NULL
  , float_ability_value_2_1 INT(11) NOT NULL
  , target_type_2_1 INT(11) NOT NULL
  , target_value_2_1 INT(11) NOT NULL
  , ability_type_2_2 INT(11) NOT NULL
  , ability_value_usage_2_2 INT(11) NOT NULL
  , ability_value_level_usage_2_2 INT(11) NOT NULL
  , float_ability_value_2_2 INT(11) NOT NULL
  , target_type_2_2 INT(11) NOT NULL
  , target_value_2_2 INT(11) NOT NULL
  , ability_type_2_3 INT(11) NOT NULL
  , ability_value_usage_2_3 INT(11) NOT NULL
  , ability_value_level_usage_2_3 INT(11) NOT NULL
  , float_ability_value_2_3 INT(11) NOT NULL
  , target_type_2_3 INT(11) NOT NULL
  , target_value_2_3 INT(11) NOT NULL
  , popularity_add_param_1 INT(11) NOT NULL
  , popularity_add_value_1 INT(11) NOT NULL
  , popularity_add_param_2 INT(11) NOT NULL
  , popularity_add_value_2 INT(11) NOT NULL
  , disp_order INT(11) NOT NULL
  , icon_id INT(11) NOT NULL
  , plate_type INT(11) NOT NULL
  , disable_singlemode INT(11) NOT NULL
  , start_date INT(11) NOT NULL
  , end_date INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 431,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `skill_data_0_group_id` on table `skill_data`
--
ALTER TABLE skill_data
ADD INDEX skill_data_0_group_id (group_id);

--
-- Create table `single_mode_wins_saddle`
--
CREATE TABLE single_mode_wins_saddle
(
    id INT(11) NOT NULL
  , priority INT(11) NOT NULL
  , group_id INT(11) NOT NULL
  , `condition` INT(11) NOT NULL
  , win_saddle_type INT(11) NOT NULL
  , race_instance_id_1 INT(11) NOT NULL
  , race_instance_id_2 INT(11) NOT NULL
  , race_instance_id_3 INT(11) NOT NULL
  , race_instance_id_4 INT(11) NOT NULL
  , race_instance_id_5 INT(11) NOT NULL
  , race_instance_id_6 INT(11) NOT NULL
  , race_instance_id_7 INT(11) NOT NULL
  , race_instance_id_8 INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 105,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `single_mode_unique_chara`
--
CREATE TABLE single_mode_unique_chara (
  id INT(11) NOT NULL,
  partner_id INT(11) NOT NULL,
  scenario_id INT(11) NOT NULL,
  chara_id INT(11) NOT NULL,
  period INT(11) NOT NULL,
  training_placement INT(11) NOT NULL,
  gain_flag_id INT(11) NOT NULL,
  is_support_featured_stock INT(11) NOT NULL,
  gain_role_id INT(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1170,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `single_mode_unique_chara_0_partner_id_1_scenario_id` on table `single_mode_unique_chara`
--
ALTER TABLE single_mode_unique_chara
ADD INDEX single_mode_unique_chara_0_partner_id_1_scenario_id (partner_id, scenario_id);

--
-- Create table `single_mode_turn`
--
CREATE TABLE single_mode_turn (
  id INT(11) NOT NULL,
  turn_set_id INT(11) NOT NULL,
  turn INT(11) NOT NULL,
  year INT(11) NOT NULL,
  month INT(11) NOT NULL,
  half INT(11) NOT NULL,
  period INT(11) NOT NULL,
  unique_command INT(11) NOT NULL,
  training_set_id INT(11) NOT NULL,
  outing_set_id INT(11) NOT NULL,
  top_cloth_id INT(11) NOT NULL,
  top_bg_id INT(11) NOT NULL,
  bgm_cue_name TEXT NOT NULL,
  bgm_cuesheet_name TEXT NOT NULL,
  env_cue_name TEXT NOT NULL,
  env_cuesheet_name TEXT NOT NULL,
  rest_type INT(11) NOT NULL,
  health_room_type INT(11) NOT NULL,
  race_entry_type INT(11) NOT NULL,
  story_cloth_id INT(11) NOT NULL,
  story_bg_id INT(11) NOT NULL,
  story_bg_sub_id INT(11) NOT NULL,
  PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 350,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `single_mode_turn_0_turn_set_id` on table `single_mode_turn`
--
ALTER TABLE single_mode_turn
ADD INDEX single_mode_turn_0_turn_set_id (turn_set_id);

--
-- Create table `single_mode_training_se`
--
CREATE TABLE single_mode_training_se
(
    id INT(11) NOT NULL
  , sheet_id VARCHAR(750) NOT NULL
  , se_cue_name TEXT NOT NULL
  , se_cuesheet_name TEXT NOT NULL
  , skip_se_cue_name TEXT NOT NULL
  , skip_se_cuesheet_name TEXT NOT NULL
  , chara_index INT(11) NOT NULL
  , voice_trigger_id INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 327,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `single_mode_training_se_0_sheet_id` on table `single_mode_training_se`
--
ALTER TABLE single_mode_training_se
ADD INDEX single_mode_training_se_0_sheet_id (sheet_id);

--
-- Create table `single_mode_training_effect`
--
CREATE TABLE single_mode_training_effect
(
    id INT(11) NOT NULL
  , command_id INT(11) NOT NULL
  , sub_id INT(11) NOT NULL
  , result_state INT(11) NOT NULL
  , target_type INT(11) NOT NULL
  , effect_value INT(11) NOT NULL
  , scenario_id INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 97,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `single_mode_training_effect_0_command_id_1_result_state` on table `single_mode_training_effect`
--
ALTER TABLE single_mode_training_effect
ADD INDEX single_mode_training_effect_0_command_id_1_result_state (command_id, result_state);

--
-- Create table `single_mode_training`
--
CREATE TABLE single_mode_training
(
    id INT(11) NOT NULL
  , command_id INT(11) NOT NULL
  , base_command_id INT(11) NOT NULL
  , command_level INT(11) NOT NULL
  , command_type INT(11) NOT NULL
  , cutin_file_id INT(11) NOT NULL
  , max_chara_num INT(11) NOT NULL
  , failure_rate INT(11) NOT NULL
  , menu_bg_id INT(11) NOT NULL
  , menu_bg_sub_id INT(11) NOT NULL
  , env_cue_name TEXT NOT NULL
  , env_cuesheet_name TEXT NOT NULL
  , motion_set INT(11) NOT NULL
  , sabori_type INT(11) NOT NULL
  , dress_type INT(11) NOT NULL
  , dress_id INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 455,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `single_mode_training_0_command_id_1_command_level` on table `single_mode_training`
--
ALTER TABLE single_mode_training
ADD UNIQUE INDEX single_mode_training_0_command_id_1_command_level (command_id, command_level);

--
-- Create index `single_mode_training_0_command_id` on table `single_mode_training`
--
ALTER TABLE single_mode_training
ADD INDEX single_mode_training_0_command_id (command_id);

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
CREATE TABLE single_mode_top_bg_chara
(
    id INT(11) NOT NULL
  , scenario_id INT(11) NOT NULL
  , bg_id INT(11) NOT NULL
  , group_id INT(11) NOT NULL
  , pos_x INT(11) NOT NULL
  , pos_z INT(11) NOT NULL
  , rotation_y INT(11) NOT NULL
  , motion_set_id INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1365,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `single_mode_top_bg_chara_0_bg_id_1_scenario_id` on table `single_mode_top_bg_chara`
--
ALTER TABLE single_mode_top_bg_chara
ADD INDEX single_mode_top_bg_chara_0_bg_id_1_scenario_id (bg_id, scenario_id);

--
-- Create table `single_mode_top_bg`
--
CREATE TABLE single_mode_top_bg
(
    id INT(11) NOT NULL
  , month INT(11) NOT NULL
  , bg_id INT(11) NOT NULL
  , bg_sub_id INT(11) NOT NULL
  , scenario_id INT(11) NOT NULL
  , bg_progress INT(11) NOT NULL
  , bg_effect TEXT NOT NULL
  , bgm_cue_name TEXT NOT NULL
  , bgm_cuesheet TEXT NOT NULL
  , env_cue_name TEXT NOT NULL
  , env_cuesheet_name TEXT NOT NULL
  , max_placement INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 264,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

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
-- Create table `single_mode_team_name`
--
CREATE TABLE single_mode_team_name
(
    id INT(11) NOT NULL
  , chara_id INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 4096,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `single_mode_tag_card_pos`
--
CREATE TABLE single_mode_tag_card_pos
(
    id INT(11) NOT NULL
  , support_card_id INT(11) NOT NULL
  , pattern INT(11) NOT NULL
  , pos_index INT(11) NOT NULL
  , pos_x INT(11) NOT NULL
  , pos_y INT(11) NOT NULL
  , scale_x INT(11) NOT NULL
  , scale_y INT(11) NOT NULL
  , rot_z INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 67,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `single_mode_tag_card_pos_0_support_card_id` on table `single_mode_tag_card_pos`
--
ALTER TABLE single_mode_tag_card_pos
ADD INDEX single_mode_tag_card_pos_0_support_card_id (support_card_id);

--
-- Create table `single_mode_story_guide`
--
CREATE TABLE single_mode_story_guide
(
    story_id INT(11) NOT NULL
  , guide_id INT(11) NOT NULL
  , PRIMARY KEY (story_id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 8192,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `single_mode_story_data`
--
CREATE TABLE single_mode_story_data
(
    id INT(11) NOT NULL
  , story_id INT(11) NOT NULL
  , short_story_id INT(11) NOT NULL
  , card_id INT(11) NOT NULL
  , card_chara_id INT(11) NOT NULL
  , support_card_id INT(11) NOT NULL
  , support_chara_id INT(11) NOT NULL
  , show_progress_1 INT(11) NOT NULL
  , show_progress_2 INT(11) NOT NULL
  , show_progress_3 INT(11) NOT NULL
  , show_clear INT(11) NOT NULL
  , show_succession INT(11) NOT NULL
  , event_title_style INT(11) NOT NULL
  , event_title_dress_icon INT(11) NOT NULL
  , event_title_chara_icon INT(11) NOT NULL
  , se_change INT(11) NOT NULL
  , ending_type INT(11) NOT NULL
  , race_event_flag INT(11) NOT NULL
  , mini_game_result INT(11) NOT NULL
  , gallery_main_scenario INT(11) NOT NULL
  , gallery_flag INT(11) NOT NULL
  , gallery_list_id INT(11) NOT NULL
  , past_race_id INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 255,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `single_mode_story_data_0_story_id` on table `single_mode_story_data`
--
ALTER TABLE single_mode_story_data
ADD INDEX single_mode_story_data_0_story_id (story_id);

--
-- Create index `single_mode_story_data_0_card_id` on table `single_mode_story_data`
--
ALTER TABLE single_mode_story_data
ADD INDEX single_mode_story_data_0_card_id (card_id);

--
-- Create index `single_mode_story_data_0_card_chara_id` on table `single_mode_story_data`
--
ALTER TABLE single_mode_story_data
ADD INDEX single_mode_story_data_0_card_chara_id (card_chara_id);

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
-- Create table `single_mode_special_chara`
--
CREATE TABLE single_mode_special_chara
(
    id INT(11) NOT NULL
  , scenario_id INT(11) NOT NULL
  , chara_id INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 2730,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

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
CREATE TABLE single_mode_skill_need_point
(
    id INT(11) NOT NULL
  , need_skill_point INT(11) NOT NULL
  , status_type INT(11) NOT NULL
  , status_value INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 37,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `single_mode_scout_chara`
--
CREATE TABLE single_mode_scout_chara
(
    id INT(11) NOT NULL
  , support_card_id INT(11) NOT NULL
  , chara_id INT(11) NOT NULL
  , race_dress_id INT(11) NOT NULL
  , live_dress_id INT(11) NOT NULL
  , tag_support_card_id INT(11) NOT NULL
  , speed INT(11) NOT NULL
  , stamina INT(11) NOT NULL
  , pow INT(11) NOT NULL
  , guts INT(11) NOT NULL
  , wiz INT(11) NOT NULL
  , proper_distance_short INT(11) NOT NULL
  , proper_distance_mile INT(11) NOT NULL
  , proper_distance_middle INT(11) NOT NULL
  , proper_distance_long INT(11) NOT NULL
  , proper_running_style_nige INT(11) NOT NULL
  , proper_running_style_senko INT(11) NOT NULL
  , proper_running_style_sashi INT(11) NOT NULL
  , proper_running_style_oikomi INT(11) NOT NULL
  , proper_ground_turf INT(11) NOT NULL
  , proper_ground_dirt INT(11) NOT NULL
  , speed_limit INT(11) NOT NULL
  , stamina_limit INT(11) NOT NULL
  , pow_limit INT(11) NOT NULL
  , guts_limit INT(11) NOT NULL
  , wiz_limit INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 346,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `single_mode_scout_chara_0_chara_id` on table `single_mode_scout_chara`
--
ALTER TABLE single_mode_scout_chara
ADD INDEX single_mode_scout_chara_0_chara_id (chara_id);

--
-- Create table `single_mode_scenario_record`
--
CREATE TABLE single_mode_scenario_record
(
    id INT(11) NOT NULL
  , scenario_id INT(11) NOT NULL
  , need_record_min INT(11) NOT NULL
  , reward_item_category INT(11) NOT NULL
  , reward_item_id INT(11) NOT NULL
  , reward_num INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 606,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `single_mode_scenario_record_0_scenario_id` on table `single_mode_scenario_record`
--
ALTER TABLE single_mode_scenario_record
ADD INDEX single_mode_scenario_record_0_scenario_id (scenario_id);

--
-- Create table `single_mode_scenario`
--
CREATE TABLE single_mode_scenario
(
    id INT(11) NOT NULL
  , sort_id INT(11) NOT NULL
  , scenario_image_id INT(11) NOT NULL
  , prologue_id INT(11) NOT NULL
  , turn_set_id INT(11) NOT NULL
  , hint_rate INT(11) NOT NULL
  , start_date INT(11) NOT NULL
  , end_date INT(11) NOT NULL
  , bg_id INT(11) NOT NULL
  , bg_sub_id INT(11) NOT NULL
  , bg_offset_x INT(11) NOT NULL
  , sec_bg_id INT(11) NOT NULL
  , sec_bg_sub_id INT(11) NOT NULL
  , label_font_color TEXT NOT NULL
  , label_bg_color TEXT NOT NULL
  , chara_program_change_flag INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 5461,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `single_mode_route_race`
--
CREATE TABLE single_mode_route_race
(
    id INT(11) NOT NULL
  , race_set_id INT(11) NOT NULL
  , target_type INT(11) NOT NULL
  , sort_id INT(11) NOT NULL
  , turn INT(11) NOT NULL
  , race_type INT(11) NOT NULL
  , condition_type INT(11) NOT NULL
  , condition_id INT(11) NOT NULL
  , condition_value_1 INT(11) NOT NULL
  , condition_value_2 INT(11) NOT NULL
  , determine_race INT(11) NOT NULL
  , determine_race_flag INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 121,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `single_mode_route_race_0_race_set_id` on table `single_mode_route_race`
--
ALTER TABLE single_mode_route_race
ADD INDEX single_mode_route_race_0_race_set_id (race_set_id);

--
-- Create table `single_mode_route_condition`
--
CREATE TABLE single_mode_route_condition
(
    id INT(11) NOT NULL
  , condition_set_id INT(11) NOT NULL
  , condition_type_1 INT(11) NOT NULL
  , condition_value_1 INT(11) NOT NULL
  , condition_value_2 INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1024,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `single_mode_route_condition_0_condition_set_id` on table `single_mode_route_condition`
--
ALTER TABLE single_mode_route_condition
ADD INDEX single_mode_route_condition_0_condition_set_id (condition_set_id);

--
-- Create table `single_mode_route_announce`
--
CREATE TABLE single_mode_route_announce
(
    id INT(11) NOT NULL
  , route_race_type INT(11) NOT NULL
  , route_race_id INT(11) NOT NULL
  , turn INT(11) NOT NULL
  , target_type INT(11) NOT NULL
  , target_value INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 910,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `single_mode_route_announce_0_route_race_type_1_route_race_id` on table `single_mode_route_announce`
--
ALTER TABLE single_mode_route_announce
ADD INDEX single_mode_route_announce_0_route_race_type_1_route_race_id (route_race_type, route_race_id);

--
-- Create table `single_mode_route`
--
CREATE TABLE single_mode_route
(
    id INT(11) NOT NULL
  , scenario_id INT(11) NOT NULL
  , chara_id INT(11) NOT NULL
  , race_set_id INT(11) NOT NULL
  , condition_set_id INT(11) NOT NULL
  , priority INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 282,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

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
CREATE TABLE single_mode_rival
(
    id INT(11) NOT NULL
  , chara_id INT(11) NOT NULL
  , turn INT(11) NOT NULL
  , race_program_id INT(11) NOT NULL
  , rival_flag_id INT(11) NOT NULL
  , condition_type INT(11) NOT NULL
  , rival_chara_id INT(11) NOT NULL
  , single_mode_npc_id INT(11) NOT NULL
  , frame_order INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 83,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `chara_id` on table `single_mode_rival`
--
ALTER TABLE single_mode_rival
ADD UNIQUE INDEX chara_id (chara_id, turn, race_program_id, rival_chara_id);

--
-- Create index `single_mode_rival_0_race_program_id` on table `single_mode_rival`
--
ALTER TABLE single_mode_rival
ADD INDEX single_mode_rival_0_race_program_id (race_program_id);

--
-- Create table `single_mode_reward_set`
--
CREATE TABLE single_mode_reward_set
(
    id INT(11) NOT NULL
  , reward_set_id INT(11) NOT NULL
  , order_min INT(11) NOT NULL
  , order_max INT(11) NOT NULL
  , reward_type INT(11) NOT NULL
  , bonus INT(11) NOT NULL
  , odds INT(11) NOT NULL
  , item_category INT(11) NOT NULL
  , item_id INT(11) NOT NULL
  , item_num INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 111,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `single_mode_reward_set_0_reward_set_id` on table `single_mode_reward_set`
--
ALTER TABLE single_mode_reward_set
ADD INDEX single_mode_reward_set_0_reward_set_id (reward_set_id);

--
-- Create table `single_mode_restrict_support`
--
CREATE TABLE single_mode_restrict_support
(
    id INT(11) NOT NULL
  , scenario_id INT(11) NOT NULL
  , support_card_id INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

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
CREATE TABLE single_mode_recommend_setting
(
    id INT(11) NOT NULL
  , recommend_course_id INT(11) NOT NULL
  , header_font_color TEXT NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 5461,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `single_mode_recommend_setting_0_recommend_course_id` on table `single_mode_recommend_setting`
--
ALTER TABLE single_mode_recommend_setting
ADD INDEX single_mode_recommend_setting_0_recommend_course_id (recommend_course_id);

--
-- Create table `single_mode_recommend`
--
CREATE TABLE single_mode_recommend
(
    id INT(11) NOT NULL
  , grade_upper_limit INT(11) NOT NULL
  , grade_lower_limit INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1170,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `single_mode_rank`
--
CREATE TABLE single_mode_rank
(
    id INT(11) NOT NULL
  , min_value INT(11) NOT NULL
  , max_value INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 167,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `single_mode_race_live`
--
CREATE TABLE single_mode_race_live
(
    id INT(11) NOT NULL
  , grade INT(11) NOT NULL
  , race_instance_id INT(11) NOT NULL
  , music_id INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 131,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `single_mode_race_group`
--
CREATE TABLE single_mode_race_group
(
    id INT(11) NOT NULL
  , race_group_id INT(11) NOT NULL
  , race_program_id INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 66,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

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
CREATE TABLE single_mode_program
(
    id INT(11) NOT NULL
  , base_program_id INT(11) NOT NULL
  , program_group INT(11) NOT NULL
  , race_instance_id INT(11) NOT NULL
  , race_permission INT(11) NOT NULL
  , month INT(11) NOT NULL
  , half INT(11) NOT NULL
  , grade_rate_id INT(11) NOT NULL
  , entry_decrease INT(11) NOT NULL
  , entry_decrease_flag INT(11) NOT NULL
  , recommend_class_id INT(11) NOT NULL
  , filly_only_flag INT(11) NOT NULL
  , need_fan_count INT(11) NOT NULL
  , fan_set_id INT(11) NOT NULL
  , reward_set_id INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 133,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `single_mode_program_0_month` on table `single_mode_program`
--
ALTER TABLE single_mode_program
ADD INDEX single_mode_program_0_month (month);

--
-- Create table `single_mode_outing_set`
--
CREATE TABLE single_mode_outing_set
(
    id INT(11) NOT NULL
  , command_group_id_1 INT(11) NOT NULL
  , command_group_id_2 INT(11) NOT NULL
  , command_group_id_3 INT(11) NOT NULL
  , command_group_id_4 INT(11) NOT NULL
  , command_group_id_5 INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 8192,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `single_mode_outing`
--
CREATE TABLE single_mode_outing
(
    id INT(11) NOT NULL
  , command_group_id INT(11) NOT NULL
  , `condition` INT(11) NOT NULL
  , is_play_cutt INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 5461,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `single_mode_outing_0_command_group_id` on table `single_mode_outing`
--
ALTER TABLE single_mode_outing
ADD INDEX single_mode_outing_0_command_group_id (command_group_id);

--
-- Create table `single_mode_npc`
--
CREATE TABLE single_mode_npc
(
    id INT(11) NOT NULL
  , npc_group_id INT(11) NOT NULL
  , chara_id INT(11) NOT NULL
  , mob_id INT(11) NOT NULL
  , race_dress_id INT(11) NOT NULL
  , speed INT(11) NOT NULL
  , stamina INT(11) NOT NULL
  , pow INT(11) NOT NULL
  , guts INT(11) NOT NULL
  , wiz INT(11) NOT NULL
  , proper_distance_short INT(11) NOT NULL
  , proper_distance_mile INT(11) NOT NULL
  , proper_distance_middle INT(11) NOT NULL
  , proper_distance_long INT(11) NOT NULL
  , proper_running_style_nige INT(11) NOT NULL
  , proper_running_style_senko INT(11) NOT NULL
  , proper_running_style_sashi INT(11) NOT NULL
  , proper_running_style_oikomi INT(11) NOT NULL
  , proper_ground_turf INT(11) NOT NULL
  , proper_ground_dirt INT(11) NOT NULL
  , skill_set_id INT(11) NOT NULL
  , motivation_min INT(11) NOT NULL
  , motivation_max INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 143,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `single_mode_npc_0_npc_group_id` on table `single_mode_npc`
--
ALTER TABLE single_mode_npc
ADD INDEX single_mode_npc_0_npc_group_id (npc_group_id);

--
-- Create table `single_mode_message`
--
CREATE TABLE single_mode_message
(
    id INT(11) NOT NULL
  , priority INT(11) NOT NULL
  , emergent INT(11) NOT NULL
  , status_type_1 INT(11) NOT NULL
  , status_value_1_1 INT(11) NOT NULL
  , status_value_1_2 INT(11) NOT NULL
  , status_type_2 INT(11) NOT NULL
  , status_value_2_1 INT(11) NOT NULL
  , status_value_2_2 INT(11) NOT NULL
  , character_type INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 630,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `single_mode_member_rank_points`
--
CREATE TABLE single_mode_member_rank_points
(
    id INT(11) NOT NULL
  , rank_id INT(11) NOT NULL
  , points INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 2048,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `single_mode_member_rank_points_0_rank_id` on table `single_mode_member_rank_points`
--
ALTER TABLE single_mode_member_rank_points
ADD INDEX single_mode_member_rank_points_0_rank_id (rank_id);

--
-- Create table `single_mode_member_rank`
--
CREATE TABLE single_mode_member_rank
(
    id INT(11) NOT NULL
  , value_min INT(11) NOT NULL
  , value_max INT(11) NOT NULL
  , member_rank_id INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 2048,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `single_mode_member_rank_0_member_rank_id` on table `single_mode_member_rank`
--
ALTER TABLE single_mode_member_rank
ADD INDEX single_mode_member_rank_0_member_rank_id (member_rank_id);

--
-- Create table `single_mode_hint_gain`
--
CREATE TABLE single_mode_hint_gain
(
    id INT(11) NOT NULL
  , hint_id INT(11) NOT NULL
  , support_card_id INT(11) NOT NULL
  , hint_group INT(11) NOT NULL
  , hint_gain_type INT(11) NOT NULL
  , hint_value_1 INT(11) NOT NULL
  , hint_value_2 INT(11) NOT NULL
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 72,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `single_mode_hint_gain_0_hint_id` on table `single_mode_hint_gain`
--
ALTER TABLE single_mode_hint_gain
ADD INDEX single_mode_hint_gain_0_hint_id (hint_id);

--
-- Create table `single_mode_free_win_point`
--
CREATE TABLE single_mode_free_win_point
(
    id INT(11) NOT NULL
  , race_group_id INT(11) NOT NULL
  , grade INT(11) NOT NULL
  , order_min INT(11) NOT NULL
  , order_max INT(11) NOT NULL
  , point_num INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 248,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `single_mode_free_win_point_0_race_group_id` on table `single_mode_free_win_point`
--
ALTER TABLE single_mode_free_win_point
ADD INDEX single_mode_free_win_point_0_race_group_id (race_group_id);

--
-- Create index `single_mode_free_win_point_0_grade` on table `single_mode_free_win_point`
--
ALTER TABLE single_mode_free_win_point
ADD INDEX single_mode_free_win_point_0_grade (grade);

--
-- Create table `single_mode_free_training_plate`
--
CREATE TABLE single_mode_free_training_plate
(
    id INT(11) NOT NULL
  , condition_type INT(11) NOT NULL
  , value_min INT(11) NOT NULL
  , value_max INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 5461,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `single_mode_free_training_plate_0_condition_type` on table `single_mode_free_training_plate`
--
ALTER TABLE single_mode_free_training_plate
ADD INDEX single_mode_free_training_plate_0_condition_type (condition_type);

--
-- Create table `single_mode_free_shop_item`
--
CREATE TABLE single_mode_free_shop_item
(
    id INT(11) NOT NULL
  , item_id INT(11) NOT NULL
  , effect_group_id INT(11) NOT NULL
  , coin_num INT(11) NOT NULL
  , limit_num INT(11) NOT NULL
  , effect_group INT(11) NOT NULL
  , effect_priority INT(11) NOT NULL
  , motion_id INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 309,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `single_mode_free_shop_item_0_item_id` on table `single_mode_free_shop_item`
--
ALTER TABLE single_mode_free_shop_item
ADD INDEX single_mode_free_shop_item_0_item_id (item_id);

--
-- Create table `single_mode_free_shop_effect`
--
CREATE TABLE single_mode_free_shop_effect
(
    id INT(11) NOT NULL
  , effect_group_id INT(11) NOT NULL
  , effect_type INT(11) NOT NULL
  , effect_value_1 INT(11) NOT NULL
  , effect_value_2 INT(11) NOT NULL
  , effect_value_3 INT(11) NOT NULL
  , effect_value_4 INT(11) NOT NULL
  , turn INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 256,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `single_mode_free_shop_effect_0_effect_group_id` on table `single_mode_free_shop_effect`
--
ALTER TABLE single_mode_free_shop_effect
ADD INDEX single_mode_free_shop_effect_0_effect_group_id (effect_group_id);

--
-- Create table `single_mode_free_shop_bg`
--
CREATE TABLE single_mode_free_shop_bg
(
    id INT(11) NOT NULL
  , start_turn INT(11) NOT NULL
  , end_turn INT(11) NOT NULL
  , bg_id INT(11) NOT NULL
  , bg_sub_id INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 3276,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `single_mode_free_shop`
--
CREATE TABLE single_mode_free_shop
(
    id INT(11) NOT NULL
  , start_turn INT(11) NOT NULL
  , end_turn INT(11) NOT NULL
  , lineup_group_id INT(11) NOT NULL
  , max_lineup_num INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1489,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `single_mode_free_coin_race`
--
CREATE TABLE single_mode_free_coin_race
(
    id INT(11) NOT NULL
  , grade INT(11) NOT NULL
  , order_min INT(11) NOT NULL
  , order_max INT(11) NOT NULL
  , coin_num INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 455,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `single_mode_free_coin_race_0_grade` on table `single_mode_free_coin_race`
--
ALTER TABLE single_mode_free_coin_race
ADD INDEX single_mode_free_coin_race_0_grade (grade);

--
-- Create table `single_mode_fan_count`
--
CREATE TABLE single_mode_fan_count
(
    id INT(11) NOT NULL
  , fan_set_id INT(11) NOT NULL
  , `order` INT(11) NOT NULL
  , fan_count INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 72,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `single_mode_fan_count_0_fan_set_id` on table `single_mode_fan_count`
--
ALTER TABLE single_mode_fan_count
ADD INDEX single_mode_fan_count_0_fan_set_id (fan_set_id);

--
-- Create table `single_mode_event_production`
--
CREATE TABLE single_mode_event_production
(
    story_id INT(11) NOT NULL
  , event_category_id INT(11) NOT NULL
  , max_item_id INT(11) NOT NULL
  , item_dir TEXT NOT NULL
  , item_name TEXT NOT NULL
  , PRIMARY KEY (story_id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 268,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `single_mode_event_item_detail`
--
CREATE TABLE single_mode_event_item_detail
(
    id INT(11) NOT NULL
  , event_category_id INT(11) NOT NULL
  , item_id INT(11) NOT NULL
  , name_index INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1024,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `single_mode_event_item_detail_0_event_category_id_1_item_id` on table `single_mode_event_item_detail`
--
ALTER TABLE single_mode_event_item_detail
ADD INDEX single_mode_event_item_detail_0_event_category_id_1_item_id (event_category_id, item_id);

--
-- Create table `single_mode_event_conclusion`
--
CREATE TABLE single_mode_event_conclusion
(
    id INT(11) NOT NULL
  , chara_id INT(11) NOT NULL
  , chara_motion_set_id INT(11) NOT NULL
  , PRIMARY KEY (id, chara_id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 80,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `single_mode_evaluation`
--
CREATE TABLE single_mode_evaluation
(
    id INT(11) NOT NULL
  , evaluation INT(11) NOT NULL
  , chara_id INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1365,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `single_mode_evaluation_0_chara_id` on table `single_mode_evaluation`
--
ALTER TABLE single_mode_evaluation
ADD INDEX single_mode_evaluation_0_chara_id (chara_id);

--
-- Create table `single_mode_difficulty_mode`
--
CREATE TABLE single_mode_difficulty_mode
(
    difficulty_id INT(11) NOT NULL
  , guide_id INT(11) NOT NULL
  , chara_id INT(11) NOT NULL
  , dress_id INT(11) NOT NULL
  , in_motion INT(11) NOT NULL
  , stand_motion INT(11) NOT NULL
  , play_motion INT(11) NOT NULL
  , gauge_motion INT(11) NOT NULL
  , gauge_motion2 INT(11) NOT NULL
  , gauge_motion3 INT(11) NOT NULL
  , popout_motion INT(11) NOT NULL
  , bgm_cue_name TEXT NOT NULL
  , bgm_cuesheet_name TEXT NOT NULL
  , reward_type INT(11) NOT NULL
  , reward_set_id INT(11) NOT NULL
  , gauge_max INT(11) NOT NULL
  , gauge_up INT(11) NOT NULL
  , PRIMARY KEY (difficulty_id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 8192,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `single_mode_difficulty_data`
--
CREATE TABLE single_mode_difficulty_data
(
    difficulty_id INT(11) NOT NULL
  , difficulty INT(11) NOT NULL
  , difficulty_index INT(11) NOT NULL
  , condition_type INT(11) NOT NULL
  , condition_value INT(11) NOT NULL
  , condition_type_2 INT(11) NOT NULL
  , condition_value_2 INT(11) NOT NULL
  , difficulty_rate INT(11) NOT NULL
  , difficulty_motivation INT(11) NOT NULL
  , continue_flag INT(11) NOT NULL
  , special_flag INT(11) NOT NULL
  , gauge_rate INT(11) NOT NULL
  , item_category INT(11) NOT NULL
  , item_id INT(11) NOT NULL
  , max_num INT(11) NOT NULL
  , PRIMARY KEY (difficulty_id, difficulty)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 2730,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `single_mode_difficulty_data_0_difficulty_id_1_difficulty_index` on table `single_mode_difficulty_data`
--
ALTER TABLE single_mode_difficulty_data
ADD INDEX single_mode_difficulty_data_0_difficulty_id_1_difficulty_index (difficulty_id, difficulty_index);

--
-- Create table `single_mode_difficulty_box_reward`
--
CREATE TABLE single_mode_difficulty_box_reward
(
    id INT(11) NOT NULL
  , box_id INT(11) NOT NULL
  , box_num INT(11) NOT NULL
  , item_category INT(11) NOT NULL
  , item_id INT(11) NOT NULL
  , item_num INT(11) NOT NULL
  , rate INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 819,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `single_mode_difficulty_box_reward_0_box_id` on table `single_mode_difficulty_box_reward`
--
ALTER TABLE single_mode_difficulty_box_reward
ADD INDEX single_mode_difficulty_box_reward_0_box_id (box_id);

--
-- Create table `single_mode_difficulty_box_gauge`
--
CREATE TABLE single_mode_difficulty_box_gauge
(
    id INT(11) NOT NULL
  , difficulty_id INT(11) NOT NULL
  , result_min INT(11) NOT NULL
  , result_max INT(11) NOT NULL
  , gauge_rate INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 3276,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `single_mode_difficulty_box_gauge_0_difficulty_id` on table `single_mode_difficulty_box_gauge`
--
ALTER TABLE single_mode_difficulty_box_gauge
ADD INDEX single_mode_difficulty_box_gauge_0_difficulty_id (difficulty_id);

--
-- Create table `single_mode_difficulty_box`
--
CREATE TABLE single_mode_difficulty_box
(
    reward_set_id INT(11) NOT NULL
  , box_step INT(11) NOT NULL
  , box_open_condition INT(11) NOT NULL
  , box_type INT(11) NOT NULL
  , box_id INT(11) NOT NULL
  , cue_name_icon TEXT NOT NULL
  , cue_name_popout TEXT NOT NULL
  , cuesheet_name_icon TEXT NOT NULL
  , cuesheet_name_popout TEXT NOT NULL
  , PRIMARY KEY (reward_set_id, box_step)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 8192,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `single_mode_difficulty_box_0_reward_set_id` on table `single_mode_difficulty_box`
--
ALTER TABLE single_mode_difficulty_box
ADD INDEX single_mode_difficulty_box_0_reward_set_id (reward_set_id);

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
-- Create table `single_mode_conclusion_set`
--
CREATE TABLE single_mode_conclusion_set
(
    story_id INT(11) NOT NULL
  , root_id INT(11) NOT NULL
  , conclusion_id INT(11) NOT NULL
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 90,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `single_mode_conclusion_set_0_story_id` on table `single_mode_conclusion_set`
--
ALTER TABLE single_mode_conclusion_set
ADD INDEX single_mode_conclusion_set_0_story_id (story_id);

--
-- Create table `single_mode_chara_program`
--
CREATE TABLE single_mode_chara_program
(
    id INT(11) NOT NULL
  , chara_id INT(11) NOT NULL
  , program_group INT(11) NOT NULL
  , program_group_2 INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 92,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `single_mode_chara_program_0_chara_id` on table `single_mode_chara_program`
--
ALTER TABLE single_mode_chara_program
ADD INDEX single_mode_chara_program_0_chara_id (chara_id);

--
-- Create table `single_mode_chara_grade`
--
CREATE TABLE single_mode_chara_grade
(
    id INT(11) NOT NULL
  , win_num INT(11) NOT NULL
  , run_num INT(11) NOT NULL
  , need_fan_count INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1638,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `single_mode_chara_effect`
--
CREATE TABLE single_mode_chara_effect
(
    id INT(11) NOT NULL
  , effect_type INT(11) NOT NULL
  , effect_category INT(11) NOT NULL
  , effect_group_id INT(11) NOT NULL
  , priority INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 819,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `single_mode_change_chara_route`
--
CREATE TABLE single_mode_change_chara_route
(
    id INT(11) NOT NULL
  , route_race_group_id INT(11) NOT NULL
  , chara_id INT(11) NOT NULL
  , route_race_id INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 321,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `single_mode_change_chara_route_0_route_race_group_id_1_chara_id` on table `single_mode_change_chara_route`
--
ALTER TABLE single_mode_change_chara_route
ADD INDEX single_mode_change_chara_route_0_route_race_group_id_1_chara_id (route_race_group_id, chara_id);

--
-- Create table `single_mode_ao_training_plate`
--
CREATE TABLE single_mode_ao_training_plate
(
    id INT(11) NOT NULL
  , value_min INT(11) NOT NULL
  , value_max INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 5461,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `single_mode_ao_offset`
--
CREATE TABLE single_mode_ao_offset
(
    id INT(11) NOT NULL
  , offset_1 INT(11) NOT NULL
  , offset_2 INT(11) NOT NULL
  , offset_3 INT(11) NOT NULL
  , offset_4 INT(11) NOT NULL
  , offset_5 INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 3276,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `single_mode_aoharu_schedule`
--
CREATE TABLE single_mode_aoharu_schedule
(
    id INT(11) NOT NULL
  , turn_num INT(11) NOT NULL
  , notice_turn_1 INT(11) NOT NULL
  , notice_turn_2 INT(11) NOT NULL
  , notice_turn_3 INT(11) NOT NULL
  , notice_turn_4 INT(11) NOT NULL
  , notice_turn_5 INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 3276,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `single_mode_aoharu_result_cutt`
--
CREATE TABLE single_mode_aoharu_result_cutt
(
    id INT(11) NOT NULL
  , chara_id INT(11) NOT NULL
  , cutt_id INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 4096,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `single_mode_aoharu_result_cutt_0_chara_id` on table `single_mode_aoharu_result_cutt`
--
ALTER TABLE single_mode_aoharu_result_cutt
ADD INDEX single_mode_aoharu_result_cutt_0_chara_id (chara_id);

--
-- Create table `single_mode_aoharu_cutt_type`
--
CREATE TABLE single_mode_aoharu_cutt_type
(
    id INT(11) NOT NULL
  , cutt_type INT(11) NOT NULL
  , cutt_id INT(11) NOT NULL
  , chara_type INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 682,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `single_mode_aoharu_cutt_type_0_cutt_type` on table `single_mode_aoharu_cutt_type`
--
ALTER TABLE single_mode_aoharu_cutt_type
ADD INDEX single_mode_aoharu_cutt_type_0_cutt_type (cutt_type);

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
-- Create table `single_mode_analyze_ticket`
--
CREATE TABLE single_mode_analyze_ticket
(
    id INT(11) NOT NULL
  , grade INT(11) NOT NULL
  , cost_ticket INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 2340,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `single_mode_analyze_ticket_0_grade` on table `single_mode_analyze_ticket`
--
ALTER TABLE single_mode_analyze_ticket
ADD INDEX single_mode_analyze_ticket_0_grade (grade);

--
-- Create table `single_mode_analyze_message`
--
CREATE TABLE single_mode_analyze_message
(
    id INT(11) NOT NULL
  , proper_ground INT(11) NOT NULL
  , proper_distance INT(11) NOT NULL
  , popularity INT(11) NOT NULL
  , year INT(11) NOT NULL
  , priority INT(11) NOT NULL
  , rate INT(11) NOT NULL
  , motion_type INT(11) NOT NULL
  , character_type INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 309,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `single_mode_analyze_message_0_popularity` on table `single_mode_analyze_message`
--
ALTER TABLE single_mode_analyze_message
ADD INDEX single_mode_analyze_message_0_popularity (popularity);

--
-- Create table `short_episode`
--
CREATE TABLE short_episode
(
    id INT(11) NOT NULL
  , scene INT(11) NOT NULL
  , sort INT(11) NOT NULL
  , condition_type INT(11) NOT NULL
  , condition_value_1 INT(11) NOT NULL
  , story_id INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 2048,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `short_episode_0_scene` on table `short_episode`
--
ALTER TABLE short_episode
ADD INDEX short_episode_0_scene (scene);

--
-- Create table `season_data`
--
CREATE TABLE season_data
(
    id INT(11) NOT NULL
  , type INT(11) NOT NULL
  , season INT(11) NOT NULL
  , priority INT(11) NOT NULL
  , start_date TEXT NOT NULL
  , end_date TEXT NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 585,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `season_data_0_type` on table `season_data`
--
ALTER TABLE season_data
ADD INDEX season_data_0_type (type);

--
-- Create table `random_ear_tail_motion`
--
CREATE TABLE random_ear_tail_motion
(
    id INT(11) NOT NULL
  , parts_type INT(11) NOT NULL
  , motion_name TEXT NOT NULL
  , ear_type INT(11) NOT NULL
  , use_story INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 606,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `random_ear_tail_motion_0_parts_type` on table `random_ear_tail_motion`
--
ALTER TABLE random_ear_tail_motion
ADD INDEX random_ear_tail_motion_0_parts_type (parts_type);

--
-- Create table `race_trophy_reward`
--
CREATE TABLE race_trophy_reward
(
    trophy_id INT(11) NOT NULL
  , item_category INT(11) NOT NULL
  , item_id INT(11) NOT NULL
  , item_num INT(11) NOT NULL
  , PRIMARY KEY (trophy_id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 91,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `race_trophy`
--
CREATE TABLE race_trophy
(
    id INT(11) NOT NULL
  , trophy_id INT(11) NOT NULL
  , race_instance_id INT(11) NOT NULL
  , original_flag INT(11) NOT NULL
  , disp_order INT(11) NOT NULL
  , size INT(11) NOT NULL
  , event_type INT(11) NOT NULL
  , start_date TEXT NOT NULL
  , display_end_date TEXT NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 193,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

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
CREATE TABLE race_track
(
    id INT(11) NOT NULL
  , initial_lane_type INT(11) NOT NULL
  , enable_half_gate INT(11) NOT NULL
  , horse_num_gate_variation INT(11) NOT NULL
  , turf_vision_type INT(11) NOT NULL
  , footsmoke_color_type INT(11) NOT NULL
  , area INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1489,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `race_single_mode_team_status`
--
CREATE TABLE race_single_mode_team_status
(
    id INT(11) NOT NULL
  , team_rank_threshold INT(11) NOT NULL
  , add_status INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 2730,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `race_proper_runningstyle_rate`
--
CREATE TABLE race_proper_runningstyle_rate
(
    id INT(11) NOT NULL
  , proper_rate INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1820,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `race_proper_ground_rate`
--
CREATE TABLE race_proper_ground_rate
(
    id INT(11) NOT NULL
  , proper_rate INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1820,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `race_proper_distance_rate`
--
CREATE TABLE race_proper_distance_rate
(
    id INT(11) NOT NULL
  , proper_rate_speed INT(11) NOT NULL
  , proper_rate_power INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1820,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `race_popularity_proper_value`
--
CREATE TABLE race_popularity_proper_value
(
    id INT(11) NOT NULL
  , proper_type INT(11) NOT NULL
  , proper_grade INT(11) NOT NULL
  , value INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1024,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `race_popularity_proper_value_0_proper_type` on table `race_popularity_proper_value`
--
ALTER TABLE race_popularity_proper_value
ADD INDEX race_popularity_proper_value_0_proper_type (proper_type);

--
-- Create table `race_player_camera`
--
CREATE TABLE race_player_camera
(
    id INT(11) NOT NULL
  , priority INT(11) NOT NULL
  , prefab_name VARCHAR(750) NOT NULL
  , category INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 168,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `race_player_camera_0_prefab_name` on table `race_player_camera`
--
ALTER TABLE race_player_camera
ADD INDEX race_player_camera_0_prefab_name (prefab_name);

--
-- Create index `race_player_camera_0_category` on table `race_player_camera`
--
ALTER TABLE race_player_camera
ADD INDEX race_player_camera_0_category (category);

--
-- Create table `race_overrun_pattern`
--
CREATE TABLE race_overrun_pattern
(
    id INT(11) NOT NULL
  , finish_order_0_type INT(11) NOT NULL
  , finish_order_1_type INT(11) NOT NULL
  , finish_order_2_type INT(11) NOT NULL
  , finish_order_3_type INT(11) NOT NULL
  , finish_order_4_type INT(11) NOT NULL
  , finish_order_lose_type INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 3276,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `race_motivation_rate`
--
CREATE TABLE race_motivation_rate
(
    id INT(11) NOT NULL
  , motivation_rate INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 3276,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `race_jikkyo_trigger`
--
CREATE TABLE race_jikkyo_trigger
(
    id INT(11) NOT NULL
  , command INT(11) NOT NULL
  , inequality INT(11) NOT NULL
  , horse1 INT(11) NOT NULL
  , horse2 INT(11) NOT NULL
  , param1 INT(11) NOT NULL
  , param2 INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 66,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `race_jikkyo_race`
--
CREATE TABLE race_jikkyo_race
(
    id INT(11) NOT NULL
  , cue_id INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 82,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `race_jikkyo_message`
--
CREATE TABLE race_jikkyo_message
(
    id INT(11) NOT NULL
  , group_id INT(11) NOT NULL
  , message TEXT NOT NULL
  , voice TEXT NOT NULL
  , per INT(11) NOT NULL
  , comment_group INT(11) NOT NULL
  , reuse INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 171,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `race_jikkyo_message_0_group_id` on table `race_jikkyo_message`
--
ALTER TABLE race_jikkyo_message
ADD INDEX race_jikkyo_message_0_group_id (group_id);

--
-- Create index `race_jikkyo_message_0_comment_group` on table `race_jikkyo_message`
--
ALTER TABLE race_jikkyo_message
ADD INDEX race_jikkyo_message_0_comment_group (comment_group);

--
-- Create table `race_jikkyo_cue`
--
CREATE TABLE race_jikkyo_cue
(
    id INT(11) NOT NULL
  , cuesheet_id INT(11) NOT NULL
  , cuesheet_type INT(11) NOT NULL
  , PRIMARY KEY (id, cuesheet_type)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 57,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `race_jikkyo_cue_0_cuesheet_type` on table `race_jikkyo_cue`
--
ALTER TABLE race_jikkyo_cue
ADD INDEX race_jikkyo_cue_0_cuesheet_type (cuesheet_type);

--
-- Create table `race_jikkyo_comment`
--
CREATE TABLE race_jikkyo_comment
(
    id INT(11) NOT NULL
  , group_id INT(11) NOT NULL
  , message TEXT NOT NULL
  , voice TEXT NOT NULL
  , per INT(11) NOT NULL
  , message_group INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 257,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `race_jikkyo_comment_0_group_id` on table `race_jikkyo_comment`
--
ALTER TABLE race_jikkyo_comment
ADD INDEX race_jikkyo_comment_0_group_id (group_id);

--
-- Create table `race_jikkyo_base`
--
CREATE TABLE race_jikkyo_base
(
    id INT(11) NOT NULL
  , mode INT(11) NOT NULL
  , sub_mode INT(11) NOT NULL
  , sub_mode_jump INT(11) NOT NULL
  , situation INT(11) NOT NULL
  , sub_situation INT(11) NOT NULL
  , situation_end INT(11) NOT NULL
  , disable_reentry_situation INT(11) NOT NULL
  , trigger0 INT(11) NOT NULL
  , trigger1 INT(11) NOT NULL
  , trigger2 INT(11) NOT NULL
  , trigger3 INT(11) NOT NULL
  , trigger4 INT(11) NOT NULL
  , trigger5 INT(11) NOT NULL
  , trigger6 INT(11) NOT NULL
  , trigger7 INT(11) NOT NULL
  , trigger8 INT(11) NOT NULL
  , trigger9 INT(11) NOT NULL
  , message_group INT(11) NOT NULL
  , comment_group INT(11) NOT NULL
  , priority INT(11) NOT NULL
  , per INT(11) NOT NULL
  , immediate INT(11) NOT NULL
  , discard INT(11) NOT NULL
  , tension INT(11) NOT NULL
  , camera_id INT(11) NOT NULL
  , camera_horse1 INT(11) NOT NULL
  , camera_horse2 INT(11) NOT NULL
  , disable_reuse INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 416,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `race_jikkyo_base_0_mode` on table `race_jikkyo_base`
--
ALTER TABLE race_jikkyo_base
ADD INDEX race_jikkyo_base_0_mode (mode);

--
-- Create table `race_instance`
--
CREATE TABLE race_instance
(
    id INT(11) NOT NULL
  , race_id INT(11) NOT NULL
  , npc_group_id INT(11) NOT NULL
  , date INT(11) NOT NULL
  , time INT(11) NOT NULL
  , race_number INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 68,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `race_instance_0_race_id` on table `race_instance`
--
ALTER TABLE race_instance
ADD INDEX race_instance_0_race_id (race_id);

--
-- Create table `race_fence_set`
--
CREATE TABLE race_fence_set
(
    id INT(11) NOT NULL
  , fence_1 INT(11) NOT NULL
  , fence_2 INT(11) NOT NULL
  , fence_3 INT(11) NOT NULL
  , fence_4 INT(11) NOT NULL
  , fence_5 INT(11) NOT NULL
  , fence_6 INT(11) NOT NULL
  , fence_7 INT(11) NOT NULL
  , fence_8 INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 151,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `race_env_define`
--
CREATE TABLE race_env_define
(
    id INT(11) NOT NULL
  , race_track_id INT(11) NOT NULL
  , season INT(11) NOT NULL
  , weather INT(11) NOT NULL
  , timezone INT(11) NOT NULL
  , resource INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 74,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `race_env_define_0_race_track_id` on table `race_env_define`
--
ALTER TABLE race_env_define
ADD INDEX race_env_define_0_race_track_id (race_track_id);

--
-- Create table `race_course_set_status`
--
CREATE TABLE race_course_set_status
(
    course_set_status_id INT(11) NOT NULL
  , target_status_1 INT(11) NOT NULL
  , target_status_2 INT(11) NOT NULL
  , PRIMARY KEY (course_set_status_id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1820,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `race_course_set`
--
CREATE TABLE race_course_set
(
    id INT(11) NOT NULL
  , race_track_id INT(11) NOT NULL
  , distance INT(11) NOT NULL
  , ground INT(11) NOT NULL
  , `inout` INT(11) NOT NULL
  , turn INT(11) NOT NULL
  , fence_set INT(11) NOT NULL
  , float_lane_max INT(11) NOT NULL
  , course_set_status_id INT(11) NOT NULL
  , finish_time_min INT(11) NOT NULL
  , finish_time_min_random_range INT(11) NOT NULL
  , finish_time_max INT(11) NOT NULL
  , finish_time_max_random_range INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 153,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `race_course_set_0_race_track_id` on table `race_course_set`
--
ALTER TABLE race_course_set
ADD INDEX race_course_set_0_race_track_id (race_track_id);

--
-- Create table `race_condition`
--
CREATE TABLE race_condition
(
    id INT(11) NOT NULL
  , season INT(11) NOT NULL
  , weather INT(11) NOT NULL
  , ground INT(11) NOT NULL
  , rate INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 512,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

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
-- Create index `race_condition_0_ground_1_weather` on table `race_condition`
--
ALTER TABLE race_condition
ADD INDEX race_condition_0_ground_1_weather (ground, weather);

--
-- Create table `race_bib_color`
--
CREATE TABLE race_bib_color
(
    grade INT(11) NOT NULL
  , race_id INT(11) NOT NULL
  , bib_color INT(11) NOT NULL
  , font_color INT(11) NOT NULL
  , PRIMARY KEY (grade, race_id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 218,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `race_bgm_pattern`
--
CREATE TABLE race_bgm_pattern
(
    id INT(11) NOT NULL
  , bgm_time_1 INT(11) NOT NULL
  , bgm_cue_name_1 TEXT NOT NULL
  , bgm_cuesheet_name_1 TEXT NOT NULL
  , bgm_time_2 INT(11) NOT NULL
  , bgm_cue_name_2 TEXT NOT NULL
  , bgm_cuesheet_name_2 TEXT NOT NULL
  , bgm_time_3 INT(11) NOT NULL
  , bgm_cue_name_3 TEXT NOT NULL
  , bgm_cuesheet_name_3 TEXT NOT NULL
  , bgm_time_4 INT(11) NOT NULL
  , bgm_cue_name_4 TEXT NOT NULL
  , bgm_cuesheet_name_4 TEXT NOT NULL
  , bgm_time_5 INT(11) NOT NULL
  , bgm_cue_name_5 TEXT NOT NULL
  , bgm_cuesheet_name_5 TEXT NOT NULL
  , bgm_time_6 INT(11) NOT NULL
  , bgm_cue_name_6 TEXT NOT NULL
  , bgm_cuesheet_name_6 TEXT NOT NULL
  , bgm_time_7 INT(11) NOT NULL
  , bgm_cue_name_7 TEXT NOT NULL
  , bgm_cuesheet_name_7 TEXT NOT NULL
  , bgm_time_8 INT(11) NOT NULL
  , bgm_cue_name_8 TEXT NOT NULL
  , bgm_cuesheet_name_8 TEXT NOT NULL
  , bgm_time_9 INT(11) NOT NULL
  , bgm_cue_name_9 TEXT NOT NULL
  , bgm_cuesheet_name_9 TEXT NOT NULL
  , bgm_time_10 INT(11) NOT NULL
  , bgm_cue_name_10 TEXT NOT NULL
  , bgm_cuesheet_name_10 TEXT NOT NULL
  , bgm_time_11 INT(11) NOT NULL
  , bgm_cue_name_11 TEXT NOT NULL
  , bgm_cuesheet_name_11 TEXT NOT NULL
  , bgm_time_12 INT(11) NOT NULL
  , bgm_cue_name_12 TEXT NOT NULL
  , bgm_cuesheet_name_12 TEXT NOT NULL
  , bgm_time_13 INT(11) NOT NULL
  , bgm_cue_name_13 TEXT NOT NULL
  , bgm_cuesheet_name_13 TEXT NOT NULL
  , bgm_time_14 INT(11) NOT NULL
  , bgm_cue_name_14 TEXT NOT NULL
  , bgm_cuesheet_name_14 TEXT NOT NULL
  , bgm_time_15 INT(11) NOT NULL
  , bgm_cue_name_15 TEXT NOT NULL
  , bgm_cuesheet_name_15 TEXT NOT NULL
  , bgm_time_16 INT(11) NOT NULL
  , bgm_cue_name_16 TEXT NOT NULL
  , bgm_cuesheet_name_16 TEXT NOT NULL
  , bgm_time_17 INT(11) NOT NULL
  , bgm_cue_name_17 TEXT NOT NULL
  , bgm_cuesheet_name_17 TEXT NOT NULL
  , bgm_time_18 INT(11) NOT NULL
  , bgm_cue_name_18 TEXT NOT NULL
  , bgm_cuesheet_name_18 TEXT NOT NULL
  , bgm_time_19 INT(11) NOT NULL
  , bgm_cue_name_19 TEXT NOT NULL
  , bgm_cuesheet_name_19 TEXT NOT NULL
  , bgm_time_20 INT(11) NOT NULL
  , bgm_cue_name_20 TEXT NOT NULL
  , bgm_cuesheet_name_20 TEXT NOT NULL
  , bgm_time_21 INT(11) NOT NULL
  , bgm_cue_name_21 TEXT NOT NULL
  , bgm_cuesheet_name_21 TEXT NOT NULL
  , bgm_time_22 INT(11) NOT NULL
  , bgm_cue_name_22 TEXT NOT NULL
  , bgm_cuesheet_name_22 TEXT NOT NULL
  , bgm_time_23 INT(11) NOT NULL
  , bgm_cue_name_23 TEXT NOT NULL
  , bgm_cuesheet_name_23 TEXT NOT NULL
  , bgm_time_24 INT(11) NOT NULL
  , bgm_cue_name_24 TEXT NOT NULL
  , bgm_cuesheet_name_24 TEXT NOT NULL
  , bgm_time_25 INT(11) NOT NULL
  , bgm_cue_name_25 TEXT NOT NULL
  , bgm_cuesheet_name_25 TEXT NOT NULL
  , bgm_time_26 INT(11) NOT NULL
  , bgm_cue_name_26 TEXT NOT NULL
  , bgm_cuesheet_name_26 TEXT NOT NULL
  , bgm_time_27 INT(11) NOT NULL
  , bgm_cue_name_27 TEXT NOT NULL
  , bgm_cuesheet_name_27 TEXT NOT NULL
  , bgm_time_28 INT(11) NOT NULL
  , bgm_cue_name_28 TEXT NOT NULL
  , bgm_cuesheet_name_28 TEXT NOT NULL
  , bgm_time_29 INT(11) NOT NULL
  , bgm_cue_name_29 TEXT NOT NULL
  , bgm_cuesheet_name_29 TEXT NOT NULL
  , bgm_time_30 INT(11) NOT NULL
  , bgm_cue_name_30 TEXT NOT NULL
  , bgm_cuesheet_name_30 TEXT NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 2114,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `race_bgm_cutin_extension_time`
--
CREATE TABLE race_bgm_cutin_extension_time
(
    id INT(11) NOT NULL
  , cutin_category INT(11) NOT NULL
  , card_id INT(11) NOT NULL
  , chara_id INT(11) NOT NULL
  , extension_sec INT(11) NOT NULL
  , extension_sec_long INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 134,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `race_bgm_cutin_extension_time_0_cutin_category` on table `race_bgm_cutin_extension_time`
--
ALTER TABLE race_bgm_cutin_extension_time
ADD INDEX race_bgm_cutin_extension_time_0_cutin_category (cutin_category);

--
-- Create table `race_bgm`
--
CREATE TABLE race_bgm
(
    id INT(11) NOT NULL
  , race_type INT(11) NOT NULL
  , race_instance_id INT(11) NOT NULL
  , grade INT(11) NOT NULL
  , single_mode_route_race_id INT(11) NOT NULL
  , single_mode_program_id INT(11) NOT NULL
  , paddock_bgm_cue_name TEXT NOT NULL
  , paddock_bgm_cuesheet_name TEXT NOT NULL
  , entrytable_bgm_cue_name TEXT NOT NULL
  , entrytable_bgm_cuesheet_name TEXT NOT NULL
  , first_bgm_pattern INT(11) NOT NULL
  , second_bgm_pattern INT(11) NOT NULL
  , result_cutin_bgm_cue_name_1 TEXT NOT NULL
  , result_cutin_bgm_cuesheet_name_1 TEXT NOT NULL
  , result_cutin_bgm_cue_name_2 TEXT NOT NULL
  , result_cutin_bgm_cuesheet_name_2 TEXT NOT NULL
  , result_cutin_bgm_cue_name_3 TEXT NOT NULL
  , result_cutin_bgm_cuesheet_name_3 TEXT NOT NULL
  , result_list_bgm_cue_name_1 TEXT NOT NULL
  , result_list_bgm_cuesheet_name_1 TEXT NOT NULL
  , result_list_bgm_cue_name_2 TEXT NOT NULL
  , result_list_bgm_cuesheet_name_2 TEXT NOT NULL
  , result_list_bgm_cue_name_3 TEXT NOT NULL
  , result_list_bgm_cuesheet_name_3 TEXT NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 535,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `race_bgm_0_race_type` on table `race_bgm`
--
ALTER TABLE race_bgm
ADD INDEX race_bgm_0_race_type (race_type);

--
-- Create table `race`
--
CREATE TABLE race
(
    id INT(11) NOT NULL
  , `group` INT(11) NOT NULL
  , grade INT(11) NOT NULL
  , course_set INT(11) NOT NULL
  , thumbnail_id INT(11) NOT NULL
  , ff_cue_name TEXT NOT NULL
  , ff_cuesheet_name TEXT NOT NULL
  , ff_anim INT(11) NOT NULL
  , ff_camera INT(11) NOT NULL
  , ff_camera_sub INT(11) NOT NULL
  , ff_sub INT(11) NOT NULL
  , goal_gate INT(11) NOT NULL
  , goal_flower INT(11) NOT NULL
  , audience INT(11) NOT NULL
  , entry_num INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 134,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

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
CREATE TABLE price_change
(
    id INT(11) NOT NULL
  , group_id INT(11) NOT NULL
  , min_num INT(11) NOT NULL
  , max_num INT(11) NOT NULL
  , pay_item_num INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1820,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `price_change_0_group_id` on table `price_change`
--
ALTER TABLE price_change
ADD INDEX price_change_0_group_id (group_id);

--
-- Create table `piece_data`
--
CREATE TABLE piece_data
(
    id INT(11) NOT NULL
  , item_place_id INT(11) NOT NULL
  , start_date TEXT NOT NULL
  , end_date TEXT NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 230,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `note_profile_text_type`
--
CREATE TABLE note_profile_text_type
(
    id INT(11) NOT NULL
  , text_type INT(11) NOT NULL
  , text_category_id INT(11) NOT NULL
  , sort INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 780,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `note_profile_text_type_0_text_type` on table `note_profile_text_type`
--
ALTER TABLE note_profile_text_type
ADD INDEX note_profile_text_type_0_text_type (text_type);

--
-- Create table `note_profile`
--
CREATE TABLE note_profile
(
    id INT(11) NOT NULL
  , chara_id INT(11) NOT NULL
  , text_type INT(11) NOT NULL
  , lock_type INT(11) NOT NULL
  , lock_value INT(11) NOT NULL
  , sort INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 564,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `note_profile_0_chara_id` on table `note_profile`
--
ALTER TABLE note_profile
ADD INDEX note_profile_0_chara_id (chara_id);

--
-- Create table `nickname`
--
CREATE TABLE nickname
(
    id INT(11) NOT NULL
  , scenario_id INT(11) NOT NULL
  , disp_order INT(11) NOT NULL
  , group_id INT(11) NOT NULL
  , rank INT(11) NOT NULL
  , chara_data_id INT(11) NOT NULL
  , user_show INT(11) NOT NULL
  , receive_condition_type INT(11) NOT NULL
  , start_date INT(11) NOT NULL
  , end_date INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 78,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `nickname_0_user_show` on table `nickname`
--
ALTER TABLE nickname
ADD INDEX nickname_0_user_show (user_show);

--
-- Create table `need_piece_num_data`
--
CREATE TABLE need_piece_num_data
(
    id INT(11) NOT NULL
  , rarity INT(11) NOT NULL
  , piece_num INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 5461,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `need_piece_num_data_0_rarity` on table `need_piece_num_data`
--
ALTER TABLE need_piece_num_data
ADD UNIQUE INDEX need_piece_num_data_0_rarity (rarity);

--
-- Create table `mob_hair_color_set`
--
CREATE TABLE mob_hair_color_set
(
    id INT(11) NOT NULL
  , hair_color_r1 TEXT NOT NULL
  , hair_color_r2 TEXT NOT NULL
  , hair_color_g1 TEXT NOT NULL
  , hair_color_g2 TEXT NOT NULL
  , hair_color_b1 TEXT NOT NULL
  , hair_color_b2 TEXT NOT NULL
  , hair_toon_color_r1 TEXT NOT NULL
  , hair_toon_color_r2 TEXT NOT NULL
  , hair_toon_color_g1 TEXT NOT NULL
  , hair_toon_color_g2 TEXT NOT NULL
  , hair_toon_color_b1 TEXT NOT NULL
  , hair_toon_color_b2 TEXT NOT NULL
  , mayu_color_r1 TEXT NOT NULL
  , mayu_color_r2 TEXT NOT NULL
  , mayu_color_g1 TEXT NOT NULL
  , mayu_color_g2 TEXT NOT NULL
  , mayu_color_b1 TEXT NOT NULL
  , mayu_color_b2 TEXT NOT NULL
  , mayu_toon_color_r1 TEXT NOT NULL
  , mayu_toon_color_r2 TEXT NOT NULL
  , mayu_toon_color_g1 TEXT NOT NULL
  , mayu_toon_color_g2 TEXT NOT NULL
  , mayu_toon_color_b1 TEXT NOT NULL
  , mayu_toon_color_b2 TEXT NOT NULL
  , eye_color_r1 TEXT NOT NULL
  , eye_color_r2 TEXT NOT NULL
  , eye_color_g1 TEXT NOT NULL
  , eye_color_g2 TEXT NOT NULL
  , eye_color_b1 TEXT NOT NULL
  , eye_color_b2 TEXT NOT NULL
  , tail_color_r1 TEXT NOT NULL
  , tail_color_r2 TEXT NOT NULL
  , tail_color_g1 TEXT NOT NULL
  , tail_color_g2 TEXT NOT NULL
  , tail_color_b1 TEXT NOT NULL
  , tail_color_b2 TEXT NOT NULL
  , tail_toon_color_r1 TEXT NOT NULL
  , tail_toon_color_r2 TEXT NOT NULL
  , tail_toon_color_g1 TEXT NOT NULL
  , tail_toon_color_g2 TEXT NOT NULL
  , tail_toon_color_b1 TEXT NOT NULL
  , tail_toon_color_b2 TEXT NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 736,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `mob_dress_color_set`
--
CREATE TABLE mob_dress_color_set
(
    id INT(11) NOT NULL
  , color_r1 TEXT NOT NULL
  , color_r2 TEXT NOT NULL
  , color_g1 TEXT NOT NULL
  , color_g2 TEXT NOT NULL
  , color_b1 TEXT NOT NULL
  , color_b2 TEXT NOT NULL
  , toon_color_r1 TEXT NOT NULL
  , toon_color_r2 TEXT NOT NULL
  , toon_color_g1 TEXT NOT NULL
  , toon_color_g2 TEXT NOT NULL
  , toon_color_b1 TEXT NOT NULL
  , toon_color_b2 TEXT NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 170,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `mob_data`
--
CREATE TABLE mob_data
(
    mob_id INT(11) NOT NULL
  , chara_face_model INT(11) NOT NULL
  , chara_skin_color INT(11) NOT NULL
  , chara_hair_model INT(11) NOT NULL
  , chara_hair_color INT(11) NOT NULL
  , chara_height INT(11) NOT NULL
  , chara_bust_size INT(11) NOT NULL
  , socks INT(11) NOT NULL
  , default_personality INT(11) NOT NULL
  , race_personality INT(11) NOT NULL
  , race_running_type INT(11) NOT NULL
  , sex INT(11) NOT NULL
  , dress_id INT(11) NOT NULL
  , dress_color_id INT(11) NOT NULL
  , use_live INT(11) NOT NULL
  , hair_cutoff INT(11) NOT NULL
  , attachment_model_id INT(11) NOT NULL
  , capture_type INT(11) NOT NULL
  , PRIMARY KEY (mob_id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 147,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `mission_data`
--
CREATE TABLE mission_data
(
    id INT(11) NOT NULL
  , mission_type INT(11) NOT NULL
  , condition_type INT(11) NOT NULL
  , condition_value_1 INT(11) NOT NULL
  , condition_value_2 INT(11) NOT NULL
  , condition_value_3 INT(11) NOT NULL
  , condition_value_4 INT(11) NOT NULL
  , condition_num INT(11) NOT NULL
  , step_group_id INT(11) NOT NULL
  , step_order INT(11) NOT NULL
  , disp_order INT(11) NOT NULL
  , item_category INT(11) NOT NULL
  , item_id INT(11) NOT NULL
  , item_num INT(11) NOT NULL
  , event_id INT(11) NOT NULL
  , user_show INT(11) NOT NULL
  , date_check_flg INT(11) NOT NULL
  , transition_type INT(11) NOT NULL
  , start_date TEXT NOT NULL
  , end_date TEXT NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 150,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `mission_data_0_mission_type` on table `mission_data`
--
ALTER TABLE mission_data
ADD INDEX mission_data_0_mission_type (mission_type);

--
-- Create table `mini_mouth_type`
--
CREATE TABLE mini_mouth_type
(
    id INT(11) NOT NULL
  , type INT(11) NOT NULL
  , reverse_mouth_id INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 512,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `mini_motion_set`
--
CREATE TABLE mini_motion_set
(
    id INT(11) NOT NULL
  , label VARCHAR(300) NOT NULL
  , body_motion TEXT NOT NULL
  , body_motion_type INT(11) NOT NULL
  , body_motion_play_type INT(11) NOT NULL
  , body_motion_scene_type INT(11) NOT NULL
  , scene_sub_folder TEXT NOT NULL
  , chara_type_target INT(11) NOT NULL
  , add_layer_index INT(11) NOT NULL
  , is_mirror INT(11) NOT NULL
  , facial_motion TEXT NOT NULL
  , chara_face_type TEXT NOT NULL
  , transition_time INT(11) NOT NULL
  , ear_motion TEXT NOT NULL
  , is_enable_randome_ear INT(11) NOT NULL
  , tail_motion TEXT NOT NULL
  , tail_motion_type INT(11) NOT NULL
  , is_enable_randome_tail INT(11) NOT NULL
  , prop_id INT(11) NOT NULL
  , prop_motion TEXT NOT NULL
  , prop_motion_scene_type INT(11) NOT NULL
  , prop_attach_node_name_type INT(11) NOT NULL
  , is_prop_require_motion_end INT(11) NOT NULL
  , PRIMARY KEY (label)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 236,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `mini_motion_set_0_id` on table `mini_motion_set`
--
ALTER TABLE mini_motion_set
ADD INDEX mini_motion_set_0_id (id);

--
-- Create table `mini_face_type_data`
--
CREATE TABLE mini_face_type_data
(
    label VARCHAR(300) NOT NULL
  , eyebrow_l INT(11) NOT NULL
  , eyebrow_r INT(11) NOT NULL
  , eye_l INT(11) NOT NULL
  , eye_r INT(11) NOT NULL
  , mouth INT(11) NOT NULL
  , cheek INT(11) NOT NULL
  , PRIMARY KEY (label)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 468,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `mini_bg_chara_motion`
--
CREATE TABLE mini_bg_chara_motion
(
    id INT(11) NOT NULL
  , bg_id INT(11) NOT NULL
  , group_id INT(11) NOT NULL
  , sub_group_id INT(11) NOT NULL
  , is_mob INT(11) NOT NULL
  , main_chara_num INT(11) NOT NULL
  , pos_obj TEXT NOT NULL
  , position_file TEXT NOT NULL
  , grid_pos_x INT(11) NOT NULL
  , grid_pos_y INT(11) NOT NULL
  , priority INT(11) NOT NULL
  , motion_name TEXT NOT NULL
  , timeline TEXT NOT NULL
  , timeline_actor TEXT NOT NULL
  , direction INT(11) NOT NULL
  , chara_pos_y TEXT NOT NULL
  , chara_shadow INT(11) NOT NULL
  , use_grid_pos_job_select INT(11) NOT NULL
  , position_anim TEXT NOT NULL
  , fixed_render_order INT(11) NOT NULL
  , se_cue_name01 TEXT NOT NULL
  , se_cue_sheet01 TEXT NOT NULL
  , se_start_frame01 INT(11) NOT NULL
  , se_cue_name02 TEXT NOT NULL
  , se_cue_sheet02 TEXT NOT NULL
  , se_start_frame02 INT(11) NOT NULL
  , effect_id INT(11) NOT NULL
  , effect_start_sec TEXT NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 195,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `mini_bg_chara_motion_0_bg_id` on table `mini_bg_chara_motion`
--
ALTER TABLE mini_bg_chara_motion
ADD INDEX mini_bg_chara_motion_0_bg_id (bg_id);

--
-- Create table `mini_bg`
--
CREATE TABLE mini_bg
(
    id INT(11) NOT NULL
  , scene_type INT(11) NOT NULL
  , release_num INT(11) NOT NULL
  , size_x INT(11) NOT NULL
  , size_y INT(11) NOT NULL
  , grid_offset_x TEXT NOT NULL
  , grid_offset_y TEXT NOT NULL
  , dress_id INT(11) NOT NULL
  , position TEXT NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 3276,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `mini_bg_0_scene_type` on table `mini_bg`
--
ALTER TABLE mini_bg
ADD INDEX mini_bg_0_scene_type (scene_type);

--
-- Create table `main_story_race_data`
--
CREATE TABLE main_story_race_data
(
    id INT(11) NOT NULL
  , race_instance_id INT(11) NOT NULL
  , group_id INT(11) NOT NULL
  , race_condition_id INT(11) NOT NULL
  , clear_rank INT(11) NOT NULL
  , bonus_group_id INT(11) NOT NULL
  , bonus_chara_1 INT(11) NOT NULL
  , bonus_chara_2 INT(11) NOT NULL
  , bonus_chara_3 INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 819,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `main_story_race_chara_data`
--
CREATE TABLE main_story_race_chara_data
(
    id INT(11) NOT NULL
  , group_id INT(11) NOT NULL
  , bracket_number INT(11) NOT NULL
  , chara_id INT(11) NOT NULL
  , mob_id INT(11) NOT NULL
  , dress_id INT(11) NOT NULL
  , chara_color_type INT(11) NOT NULL
  , motivation INT(11) NOT NULL
  , running_style INT(11) NOT NULL
  , speed INT(11) NOT NULL
  , stamina INT(11) NOT NULL
  , pow INT(11) NOT NULL
  , guts INT(11) NOT NULL
  , wiz INT(11) NOT NULL
  , proper_distance_short INT(11) NOT NULL
  , proper_distance_mile INT(11) NOT NULL
  , proper_distance_middle INT(11) NOT NULL
  , proper_distance_long INT(11) NOT NULL
  , proper_running_style_nige INT(11) NOT NULL
  , proper_running_style_senko INT(11) NOT NULL
  , proper_running_style_sashi INT(11) NOT NULL
  , proper_running_style_oikomi INT(11) NOT NULL
  , proper_ground_turf INT(11) NOT NULL
  , proper_ground_dirt INT(11) NOT NULL
  , skill_set_id INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 307,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

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
CREATE TABLE main_story_race_bonus_condition
(
    id INT(11) NOT NULL
  , group_id INT(11) NOT NULL
  , condition_type INT(11) NOT NULL
  , condition_value_1 INT(11) NOT NULL
  , condition_value_2 INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1489,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `main_story_race_bonus_condition_0_group_id` on table `main_story_race_bonus_condition`
--
ALTER TABLE main_story_race_bonus_condition
ADD INDEX main_story_race_bonus_condition_0_group_id (group_id);

--
-- Create table `main_story_race_bonus`
--
CREATE TABLE main_story_race_bonus
(
    id INT(11) NOT NULL
  , group_id INT(11) NOT NULL
  , bonus_type INT(11) NOT NULL
  , bonus_value INT(11) NOT NULL
  , condition_group INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1024,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `main_story_race_bonus_0_group_id` on table `main_story_race_bonus`
--
ALTER TABLE main_story_race_bonus
ADD INDEX main_story_race_bonus_0_group_id (group_id);

--
-- Create table `main_story_part`
--
CREATE TABLE main_story_part
(
    id INT(11) NOT NULL
  , main_story_last_chapter INT(11) NOT NULL
  , start_date INT(11) NOT NULL
  , ui_color TEXT NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 3276,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `main_story_data`
--
CREATE TABLE main_story_data
(
    id INT(11) NOT NULL
  , part_id INT(11) NOT NULL
  , episode_index INT(11) NOT NULL
  , story_number INT(11) NOT NULL
  , story_type_1 INT(11) NOT NULL
  , story_id_1 INT(11) NOT NULL
  , story_type_2 INT(11) NOT NULL
  , story_id_2 INT(11) NOT NULL
  , story_type_3 INT(11) NOT NULL
  , story_id_3 INT(11) NOT NULL
  , story_type_4 INT(11) NOT NULL
  , story_id_4 INT(11) NOT NULL
  , story_type_5 INT(11) NOT NULL
  , story_id_5 INT(11) NOT NULL
  , lock_type_1 INT(11) NOT NULL
  , lock_value_1_1 INT(11) NOT NULL
  , lock_value_1_2 INT(11) NOT NULL
  , lock_type_2 INT(11) NOT NULL
  , lock_value_2_1 INT(11) NOT NULL
  , lock_value_2_2 INT(11) NOT NULL
  , lock_type_3 INT(11) NOT NULL
  , lock_value_3_1 INT(11) NOT NULL
  , lock_value_3_2 INT(11) NOT NULL
  , add_reward_category_1 INT(11) NOT NULL
  , add_reward_id_1 INT(11) NOT NULL
  , add_reward_num_1 INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 190,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `story_id_1` on table `main_story_data`
--
ALTER TABLE main_story_data
ADD UNIQUE INDEX story_id_1 (story_id_1);

--
-- Create index `main_story_data_0_part_id` on table `main_story_data`
--
ALTER TABLE main_story_data
ADD INDEX main_story_data_0_part_id (part_id);

--
-- Create table `love_rank`
--
CREATE TABLE love_rank
(
    id INT(11) NOT NULL
  , rank INT(11) NOT NULL
  , total_point INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1489,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `love_rank_0_rank` on table `love_rank`
--
ALTER TABLE love_rank
ADD UNIQUE INDEX love_rank_0_rank (rank);

--
-- Create table `login_bonus_detail`
--
CREATE TABLE login_bonus_detail
(
    id INT(11) NOT NULL
  , login_bonus_id INT(11) NOT NULL
  , count INT(11) NOT NULL
  , item_category INT(11) NOT NULL
  , item_id INT(11) NOT NULL
  , item_num INT(11) NOT NULL
  , item_category_2 INT(11) NOT NULL
  , item_id_2 INT(11) NOT NULL
  , item_num_2 INT(11) NOT NULL
  , item_category_3 INT(11) NOT NULL
  , item_id_3 INT(11) NOT NULL
  , item_num_3 INT(11) NOT NULL
  , item_category_4 INT(11) NOT NULL
  , item_id_4 INT(11) NOT NULL
  , item_num_4 INT(11) NOT NULL
  , item_category_5 INT(11) NOT NULL
  , item_id_5 INT(11) NOT NULL
  , item_num_5 INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 168,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `login_bonus_id` on table `login_bonus_detail`
--
ALTER TABLE login_bonus_detail
ADD UNIQUE INDEX login_bonus_id (login_bonus_id, count);

--
-- Create index `login_bonus_detail_0_login_bonus_id` on table `login_bonus_detail`
--
ALTER TABLE login_bonus_detail
ADD INDEX login_bonus_detail_0_login_bonus_id (login_bonus_id);

--
-- Create table `login_bonus_data`
--
CREATE TABLE login_bonus_data
(
    id INT(11) NOT NULL
  , type INT(11) NOT NULL
  , count_num INT(11) NOT NULL
  , disp_order INT(11) NOT NULL
  , start_date TEXT NOT NULL
  , end_date TEXT NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 442,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `disp_order` on table `login_bonus_data`
--
ALTER TABLE login_bonus_data
ADD UNIQUE INDEX disp_order (disp_order);

--
-- Create index `login_bonus_data_0_type` on table `login_bonus_data`
--
ALTER TABLE login_bonus_data
ADD INDEX login_bonus_data_0_type (type);

--
-- Create table `live_permission_data`
--
CREATE TABLE live_permission_data
(
    music_id INT(11) NOT NULL
  , chara_id INT(11) NOT NULL
  , PRIMARY KEY (music_id, chara_id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 82,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `live_permission_data_0_music_id` on table `live_permission_data`
--
ALTER TABLE live_permission_data
ADD INDEX live_permission_data_0_music_id (music_id);

--
-- Create table `live_data`
--
CREATE TABLE live_data
(
    music_id INT(11) NOT NULL
  , sort INT(11) NOT NULL
  , music_type INT(11) NOT NULL
  , title_color_top TEXT NOT NULL
  , title_color_bottom TEXT NOT NULL
  , condition_type INT(11) NOT NULL
  , song_chara_type INT(11) NOT NULL
  , live_member_number INT(11) NOT NULL
  , default_main_dress INT(11) NOT NULL
  , default_main_dress_color INT(11) NOT NULL
  , default_mob_dress INT(11) NOT NULL
  , default_mob_dress_color INT(11) NOT NULL
  , backdancer_order INT(11) NOT NULL
  , backdancer_dress INT(11) NOT NULL
  , backdancer_dress_color INT(11) NOT NULL
  , has_live INT(11) NOT NULL
  , start_date INT(11) NOT NULL
  , end_date INT(11) NOT NULL
  , PRIMARY KEY (music_id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 655,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `sort` on table `live_data`
--
ALTER TABLE live_data
ADD UNIQUE INDEX sort (sort);

--
-- Create table `limited_exchange_reward_odds`
--
CREATE TABLE limited_exchange_reward_odds
(
    id INT(11) NOT NULL
  , odds_id INT(11) NOT NULL
  , group_id INT(11) NOT NULL
  , disp_order INT(11) NOT NULL
  , odds INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 819,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `limited_exchange_reward`
--
CREATE TABLE limited_exchange_reward
(
    id INT(11) NOT NULL
  , group_id INT(11) NOT NULL
  , odds INT(11) NOT NULL
  , item_exchange_id INT(11) NOT NULL
  , ribbon_value INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 74,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `limited_exchange`
--
CREATE TABLE limited_exchange
(
    id INT(11) NOT NULL
  , item_exchange_top_id INT(11) NOT NULL
  , open_value INT(11) NOT NULL
  , item_lineup_value INT(11) NOT NULL
  , odds_id INT(11) NOT NULL
  , daily_race_odds INT(11) NOT NULL
  , daily_race_ceiling INT(11) NOT NULL
  , legend_race_odds INT(11) NOT NULL
  , legend_race_ceiling INT(11) NOT NULL
  , single_mode_odds INT(11) NOT NULL
  , single_mode_ceiling INT(11) NOT NULL
  , team_stadium_odds INT(11) NOT NULL
  , team_stadium_ceiling INT(11) NOT NULL
  , start_date INT(11) NOT NULL
  , end_date INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 5461,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `legend_race_npc`
--
CREATE TABLE legend_race_npc
(
    id INT(11) NOT NULL
  , npc_group_id INT(11) NOT NULL
  , chara_id INT(11) NOT NULL
  , mob_id INT(11) NOT NULL
  , race_dress_id INT(11) NOT NULL
  , race_instance_id INT(11) NOT NULL
  , speed INT(11) NOT NULL
  , stamina INT(11) NOT NULL
  , pow INT(11) NOT NULL
  , guts INT(11) NOT NULL
  , wiz INT(11) NOT NULL
  , proper_distance_short INT(11) NOT NULL
  , proper_distance_mile INT(11) NOT NULL
  , proper_distance_middle INT(11) NOT NULL
  , proper_distance_long INT(11) NOT NULL
  , proper_running_style_nige INT(11) NOT NULL
  , proper_running_style_senko INT(11) NOT NULL
  , proper_running_style_sashi INT(11) NOT NULL
  , proper_running_style_oikomi INT(11) NOT NULL
  , proper_ground_turf INT(11) NOT NULL
  , proper_ground_dirt INT(11) NOT NULL
  , skill_set_id INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 184,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `legend_race_boss_npc`
--
CREATE TABLE legend_race_boss_npc
(
    id INT(11) NOT NULL
  , chara_id INT(11) NOT NULL
  , race_dress_id INT(11) NOT NULL
  , nickname_id INT(11) NOT NULL
  , card_rarity_data_id INT(11) NOT NULL
  , post INT(11) NOT NULL
  , speed INT(11) NOT NULL
  , stamina INT(11) NOT NULL
  , pow INT(11) NOT NULL
  , guts INT(11) NOT NULL
  , wiz INT(11) NOT NULL
  , proper_distance_short INT(11) NOT NULL
  , proper_distance_mile INT(11) NOT NULL
  , proper_distance_middle INT(11) NOT NULL
  , proper_distance_long INT(11) NOT NULL
  , proper_running_style_nige INT(11) NOT NULL
  , proper_running_style_senko INT(11) NOT NULL
  , proper_running_style_sashi INT(11) NOT NULL
  , proper_running_style_oikomi INT(11) NOT NULL
  , proper_ground_turf INT(11) NOT NULL
  , proper_ground_dirt INT(11) NOT NULL
  , skill_set_id INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 512,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `legend_race_billing`
--
CREATE TABLE legend_race_billing
(
    id INT(11) NOT NULL
  , frequency INT(11) NOT NULL
  , pay_cost INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 16384,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `legend_race`
--
CREATE TABLE legend_race
(
    id INT(11) NOT NULL
  , group_id INT(11) NOT NULL
  , legend_bg_id INT(11) NOT NULL
  , legend_bg_sub_id INT(11) NOT NULL
  , image_id INT(11) NOT NULL
  , difficulty INT(11) NOT NULL
  , race_instance_id INT(11) NOT NULL
  , season INT(11) NOT NULL
  , weather INT(11) NOT NULL
  , ground INT(11) NOT NULL
  , legend_race_boss_npc_id INT(11) NOT NULL
  , cost_num INT(11) NOT NULL
  , drop_reward_odds_id INT(11) NOT NULL
  , victory_reward_odds_id INT(11) NOT NULL
  , first_clear_item_category_1 INT(11) NOT NULL
  , first_clear_item_id_1 INT(11) NOT NULL
  , first_clear_item_num_1 INT(11) NOT NULL
  , first_clear_item_category_2 INT(11) NOT NULL
  , first_clear_item_id_2 INT(11) NOT NULL
  , first_clear_item_num_2 INT(11) NOT NULL
  , first_clear_item_category_3 INT(11) NOT NULL
  , first_clear_item_id_3 INT(11) NOT NULL
  , first_clear_item_num_3 INT(11) NOT NULL
  , pick_up_item_category_1 INT(11) NOT NULL
  , pick_up_item_id_1 INT(11) NOT NULL
  , pick_up_item_num_1 INT(11) NOT NULL
  , pick_up_item_category_2 INT(11) NOT NULL
  , pick_up_item_id_2 INT(11) NOT NULL
  , pick_up_item_num_2 INT(11) NOT NULL
  , pick_up_item_category_3 INT(11) NOT NULL
  , pick_up_item_id_3 INT(11) NOT NULL
  , pick_up_item_num_3 INT(11) NOT NULL
  , notice_date INT(11) NOT NULL
  , start_date INT(11) NOT NULL
  , end_date INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 496,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

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
-- Create table `jukebox_request_data`
--
CREATE TABLE jukebox_request_data
(
    id INT(11) NOT NULL
  , music_id INT(11) NOT NULL
  , request_type INT(11) NOT NULL
  , request_value INT(11) NOT NULL
  , start_date INT(11) NOT NULL
  , end_date INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 141,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `jukebox_reaction_data`
--
CREATE TABLE jukebox_reaction_data
(
    id INT(11) NOT NULL
  , chara_id INT(11) NOT NULL
  , reaction_chara_id INT(11) NOT NULL
  , start_date INT(11) NOT NULL
  , end_date INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 72,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `jukebox_music_data`
--
CREATE TABLE jukebox_music_data
(
    music_id INT(11) NOT NULL
  , sort INT(11) NOT NULL
  , condition_type INT(11) NOT NULL
  , is_hidden INT(11) NOT NULL
  , version_type INT(11) NOT NULL
  , request_type INT(11) NOT NULL
  , lamp_color INT(11) NOT NULL
  , lamp_animation INT(11) NOT NULL
  , name_texture_length INT(11) NOT NULL
  , song_type INT(11) NOT NULL
  , bgm_cue_name_short TEXT NOT NULL
  , bgm_cuesheet_name_short TEXT NOT NULL
  , bgm_cue_name_gamesize TEXT NOT NULL
  , bgm_cuesheet_name_gamesize TEXT NOT NULL
  , short_length INT(11) NOT NULL
  , start_date INT(11) NOT NULL
  , end_date INT(11) NOT NULL
  , PRIMARY KEY (music_id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 819,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `sort` on table `jukebox_music_data`
--
ALTER TABLE jukebox_music_data
ADD UNIQUE INDEX sort (sort);

--
-- Create index `jukebox_music_data_0_version_type` on table `jukebox_music_data`
--
ALTER TABLE jukebox_music_data
ADD INDEX jukebox_music_data_0_version_type (version_type);

--
-- Create table `jukebox_motion_data`
--
CREATE TABLE jukebox_motion_data
(
    id INT(11) NOT NULL
  , song_type INT(11) NOT NULL
  , motion_id INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1024,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `jukebox_motion_data_0_song_type` on table `jukebox_motion_data`
--
ALTER TABLE jukebox_motion_data
ADD INDEX jukebox_motion_data_0_song_type (song_type);

--
-- Create table `jukebox_comment`
--
CREATE TABLE jukebox_comment
(
    id INT(11) NOT NULL
  , comment_id INT(11) NOT NULL
  , chara_id INT(11) NOT NULL
  , comment_type INT(11) NOT NULL
  , variation_type INT(11) NOT NULL
  , variation_value INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 125,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `jukebox_comment_0_comment_id` on table `jukebox_comment`
--
ALTER TABLE jukebox_comment
ADD INDEX jukebox_comment_0_comment_id (comment_id);

--
-- Create index `jukebox_comment_0_chara_id_1_comment_type` on table `jukebox_comment`
--
ALTER TABLE jukebox_comment
ADD INDEX jukebox_comment_0_chara_id_1_comment_type (chara_id, comment_type);

--
-- Create table `jukebox_chara_tag_data`
--
CREATE TABLE jukebox_chara_tag_data
(
    id INT(11) NOT NULL
  , chara_id INT(11) NOT NULL
  , tag INT(11) NOT NULL
  , start_date INT(11) NOT NULL
  , end_date INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 66,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `item_place`
--
CREATE TABLE item_place
(
    id INT(11) NOT NULL
  , transition_type INT(11) NOT NULL
  , transition_value INT(11) NOT NULL
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 117,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

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
-- Create table `item_pack`
--
CREATE TABLE item_pack
(
    id INT(11) NOT NULL
  , item_pack_id INT(11) NOT NULL
  , item_category INT(11) NOT NULL
  , item_id INT(11) NOT NULL
  , item_num INT(11) NOT NULL
  , start_date TEXT NOT NULL
  , end_date TEXT NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 4096,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `item_group`
--
CREATE TABLE item_group
(
    id INT(11) NOT NULL
  , group_id INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 468,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `item_group_0_group_id` on table `item_group`
--
ALTER TABLE item_group
ADD INDEX item_group_0_group_id (group_id);

--
-- Create table `item_exchange_top`
--
CREATE TABLE item_exchange_top
(
    id INT(11) NOT NULL
  , item_exchange_disp_order INT(11) NOT NULL
  , item_exchange_type INT(11) NOT NULL
  , item_top_category INT(11) NOT NULL
  , start_date INT(11) NOT NULL
  , end_date INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 780,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `item_exchange_top_0_item_top_category` on table `item_exchange_top`
--
ALTER TABLE item_exchange_top
ADD INDEX item_exchange_top_0_item_top_category (item_top_category);

--
-- Create table `item_exchange`
--
CREATE TABLE item_exchange
(
    id INT(11) NOT NULL
  , item_exchange_top_id INT(11) NOT NULL
  , disp_order INT(11) NOT NULL
  , condition_type INT(11) NOT NULL
  , condition_value_1 INT(11) NOT NULL
  , condition_value_2 INT(11) NOT NULL
  , change_item_limit_type INT(11) NOT NULL
  , change_item_limit_num INT(11) NOT NULL
  , change_item_category INT(11) NOT NULL
  , change_item_id INT(11) NOT NULL
  , change_item_num INT(11) NOT NULL
  , additional_piece_num INT(11) NOT NULL
  , pay_item_category INT(11) NOT NULL
  , pay_item_id INT(11) NOT NULL
  , pay_item_num INT(11) NOT NULL
  , price_change_group_id INT(11) NOT NULL
  , start_date INT(11) NOT NULL
  , end_date INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 163,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

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
CREATE TABLE item_data
(
    id INT(11) NOT NULL
  , item_category INT(11) NOT NULL
  , group_id INT(11) NOT NULL
  , effect_type_1 INT(11) NOT NULL
  , effect_target_1 INT(11) NOT NULL
  , effect_value_1 INT(11) NOT NULL
  , effect_type_2 INT(11) NOT NULL
  , effect_target_2 INT(11) NOT NULL
  , effect_value_2 INT(11) NOT NULL
  , add_value_1 INT(11) NOT NULL
  , add_value_2 INT(11) NOT NULL
  , add_value_3 INT(11) NOT NULL
  , limit_num INT(11) NOT NULL
  , sort INT(11) NOT NULL
  , rare INT(11) NOT NULL
  , enable_request INT(11) NOT NULL
  , request_reward INT(11) NOT NULL
  , item_place_id INT(11) NOT NULL
  , sell_item_id INT(11) NOT NULL
  , sell_price INT(11) NOT NULL
  , start_date TEXT NOT NULL
  , end_date TEXT NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 292,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `item_data_0_item_category` on table `item_data`
--
ALTER TABLE item_data
ADD INDEX item_data_0_item_category (item_category);

--
-- Create index `item_data_0_group_id` on table `item_data`
--
ALTER TABLE item_data
ADD INDEX item_data_0_group_id (group_id);

--
-- Create table `honor_data`
--
CREATE TABLE honor_data
(
    id INT(11) NOT NULL
  , rank INT(11) NOT NULL
  , category INT(11) NOT NULL
  , start_date TEXT NOT NULL
  , end_date TEXT NOT NULL
  , condition_type INT(11) NOT NULL
  , condition_value INT(11) NOT NULL
  , condition_value_2 INT(11) NOT NULL
  , step_group_id INT(11) NOT NULL
  , step_order INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 158,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `home_walk_group`
--
CREATE TABLE home_walk_group
(
    id INT(11) NOT NULL
  , chara_id_1 INT(11) NOT NULL
  , enable_eat_1 INT(11) NOT NULL
  , chara_id_2 INT(11) NOT NULL
  , enable_eat_2 INT(11) NOT NULL
  , chara_id_3 INT(11) NOT NULL
  , enable_eat_3 INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 321,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `home_story_trigger`
--
CREATE TABLE home_story_trigger
(
    id INT(11) NOT NULL
  , pos_id INT(11) NOT NULL
  , home_event_type INT(11) NOT NULL
  , num INT(11) NOT NULL
  , story_id INT(11) NOT NULL
  , chara_id_1 INT(11) NOT NULL
  , chara_id_2 INT(11) NOT NULL
  , chara_id_3 INT(11) NOT NULL
  , condition_type INT(11) NOT NULL
  , gallery_chara_id INT(11) NOT NULL
  , disp_order INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 183,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `gallery_chara_id` on table `home_story_trigger`
--
ALTER TABLE home_story_trigger
ADD UNIQUE INDEX gallery_chara_id (gallery_chara_id, disp_order);

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
-- Create index `home_story_trigger_0_gallery_chara_id` on table `home_story_trigger`
--
ALTER TABLE home_story_trigger
ADD INDEX home_story_trigger_0_gallery_chara_id (gallery_chara_id);

--
-- Create table `home_prop_setting`
--
CREATE TABLE home_prop_setting
(
    pos_id INT(11) NOT NULL
  , personality INT(11) NOT NULL
  , prop_id INT(11) NOT NULL
  , attach_node INT(11) NOT NULL
  , PRIMARY KEY (pos_id, personality)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 819,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `home_poster_data`
--
CREATE TABLE home_poster_data
(
    id INT(11) NOT NULL
  , priority INT(11) NOT NULL
  , height INT(11) NOT NULL
  , width INT(11) NOT NULL
  , posi_vertical INT(11) NOT NULL
  , posi_horizontal INT(11) NOT NULL
  , detail_value INT(11) NOT NULL
  , url_value INT(11) NOT NULL
  , url TEXT NOT NULL
  , start_date INT(11) NOT NULL
  , end_date INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1170,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `home_poster_data_0_priority` on table `home_poster_data`
--
ALTER TABLE home_poster_data
ADD INDEX home_poster_data_0_priority (priority);

--
-- Create table `home_event_schedule`
--
CREATE TABLE home_event_schedule
(
    id INT(11) NOT NULL
  , event_id INT(11) NOT NULL
  , start_date INT(11) NOT NULL
  , end_date INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 8192,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `home_env_setting`
--
CREATE TABLE home_env_setting
(
    id INT(11) NOT NULL
  , home_set_id INT(11) NOT NULL
  , home_event_type INT(11) NOT NULL
  , resource_event_check INT(11) NOT NULL
  , season INT(11) NOT NULL
  , weather INT(11) NOT NULL
  , timezone INT(11) NOT NULL
  , resource INT(11) NOT NULL
  , bgm_cue_name TEXT NOT NULL
  , bgm_cuesheet_name TEXT NOT NULL
  , env_cue_name TEXT NOT NULL
  , env_cuesheet_name TEXT NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 178,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `home_env_setting_index` on table `home_env_setting`
--
ALTER TABLE home_env_setting
ADD UNIQUE INDEX home_env_setting_index (home_set_id, home_event_type, season, weather, timezone);

--
-- Create table `home_eat`
--
CREATE TABLE home_eat
(
    chara_id INT(11) NOT NULL
  , body_shape INT(11) NOT NULL
  , prop_id_right INT(11) NOT NULL
  , prop_eat_animation_right TEXT NOT NULL
  , override_motion_right TEXT NOT NULL
  , prop_id_left INT(11) NOT NULL
  , prop_eat_animation_left TEXT NOT NULL
  , override_motion_left TEXT NOT NULL
  , walk_motion TEXT NOT NULL
  , walk_chara_face_type TEXT NOT NULL
  , eat_motion TEXT NOT NULL
  , eat_facial_motion TEXT NOT NULL
  , odds INT(11) NOT NULL
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 292,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `home_eat_0_chara_id` on table `home_eat`
--
ALTER TABLE home_eat
ADD INDEX home_eat_0_chara_id (chara_id);

--
-- Create table `home_character_type`
--
CREATE TABLE home_character_type
(
    pos_id INT(11) NOT NULL
  , original_personality INT(11) NOT NULL
  , change_personality INT(11) NOT NULL
  , PRIMARY KEY (pos_id, original_personality)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 712,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `homestory_hip_offset`
--
CREATE TABLE homestory_hip_offset
(
    id INT(11) NOT NULL
  , home_event_type INT(11) NOT NULL
  , num INT(11) NOT NULL
  , story_id INT(11) NOT NULL
  , chara_id INT(11) NOT NULL
  , offset INT(11) NOT NULL
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1365,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `homestory_hip_offset_0_story_id_1_chara_id` on table `homestory_hip_offset`
--
ALTER TABLE homestory_hip_offset
ADD INDEX homestory_hip_offset_0_story_id_1_chara_id (story_id, chara_id);

--
-- Create table `highlight_interpolate`
--
CREATE TABLE highlight_interpolate
(
    id INT(11) NOT NULL
  , in_time INT(11) NOT NULL
  , out_time INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 5461,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `gift_message`
--
CREATE TABLE gift_message
(
    id INT(11) NOT NULL
  , type_1 INT(11) NOT NULL
  , type_2 INT(11) NOT NULL
  , type_3 INT(11) NOT NULL
  , type_4 INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 221,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `gacha_top_bg`
--
CREATE TABLE gacha_top_bg
(
    id INT(11) NOT NULL
  , gacha_id INT(11) NOT NULL
  , logo_size_x INT(11) NOT NULL
  , logo_size_y INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 182,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `gacha_top_bg_0_gacha_id` on table `gacha_top_bg`
--
ALTER TABLE gacha_top_bg
ADD INDEX gacha_top_bg_0_gacha_id (gacha_id);

--
-- Create table `gacha_stock_detail`
--
CREATE TABLE gacha_stock_detail
(
    id INT(11) NOT NULL
  , gacha_stock_id INT(11) NOT NULL
  , gacha_id INT(11) NOT NULL
  , start_date INT(11) NOT NULL
  , end_date INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 4096,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `gacha_stock_detail_0_gacha_stock_id` on table `gacha_stock_detail`
--
ALTER TABLE gacha_stock_detail
ADD INDEX gacha_stock_detail_0_gacha_stock_id (gacha_stock_id);

--
-- Create table `gacha_stock_campaign`
--
CREATE TABLE gacha_stock_campaign
(
    id INT(11) NOT NULL
  , start_date INT(11) NOT NULL
  , end_date INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 8192,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `gacha_prize_odds`
--
CREATE TABLE gacha_prize_odds
(
    prize_odds_id INT(11) NOT NULL
  , place INT(11) NOT NULL
  , odds INT(11) NOT NULL
  , piece_num INT(11) NOT NULL
  , item_category_1 INT(11) NOT NULL
  , item_id_1 INT(11) NOT NULL
  , item_num_1 INT(11) NOT NULL
  , item_category_2 INT(11) NOT NULL
  , item_id_2 INT(11) NOT NULL
  , item_num_2 INT(11) NOT NULL
  , item_category_3 INT(11) NOT NULL
  , item_id_3 INT(11) NOT NULL
  , item_num_3 INT(11) NOT NULL
  , item_category_4 INT(11) NOT NULL
  , item_id_4 INT(11) NOT NULL
  , item_num_4 INT(11) NOT NULL
  , item_category_5 INT(11) NOT NULL
  , item_id_5 INT(11) NOT NULL
  , item_num_5 INT(11) NOT NULL
  , item_category_6 INT(11) NOT NULL
  , item_id_6 INT(11) NOT NULL
  , item_num_6 INT(11) NOT NULL
  , PRIMARY KEY (prize_odds_id, place)
)
ENGINE = INNODB,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `gacha_prize_odds_0_prize_odds_id` on table `gacha_prize_odds`
--
ALTER TABLE gacha_prize_odds
ADD INDEX gacha_prize_odds_0_prize_odds_id (prize_odds_id);

--
-- Create table `gacha_piece`
--
CREATE TABLE gacha_piece
(
    id INT(11) NOT NULL
  , rarity INT(11) NOT NULL
  , piece_type INT(11) NOT NULL
  , piece_num INT(11) NOT NULL
  , item_category INT(11) NOT NULL
  , item_id INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 5461,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `gacha_piece_0_rarity` on table `gacha_piece`
--
ALTER TABLE gacha_piece
ADD INDEX gacha_piece_0_rarity (rarity);

--
-- Create table `gacha_free_campaign`
--
CREATE TABLE gacha_free_campaign
(
    id INT(11) NOT NULL
  , gacha_id INT(11) NOT NULL
  , target_draw_type INT(11) NOT NULL
  , start_date INT(11) NOT NULL
  , end_date INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1092,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `gacha_exchange`
--
CREATE TABLE gacha_exchange
(
    gacha_id INT(11) NOT NULL
  , card_id INT(11) NOT NULL
  , card_type INT(11) NOT NULL
  , pay_item_num INT(11) NOT NULL
  , disp_order INT(11) NOT NULL
  , PRIMARY KEY (gacha_id, card_id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 93,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `gacha_exchange_0_gacha_id` on table `gacha_exchange`
--
ALTER TABLE gacha_exchange
ADD INDEX gacha_exchange_0_gacha_id (gacha_id);

--
-- Create table `gacha_data`
--
CREATE TABLE gacha_data
(
    id INT(11) NOT NULL
  , type INT(11) NOT NULL
  , card_type INT(11) NOT NULL
  , daily_pay_cost INT(11) NOT NULL
  , disp_order INT(11) NOT NULL
  , only_once_flag INT(11) NOT NULL
  , rarity_odds_id INT(11) NOT NULL
  , draw_guarantee_rarity INT(11) NOT NULL
  , draw_guarantee_num INT(11) NOT NULL
  , cost_type INT(11) NOT NULL
  , cost_single INT(11) NOT NULL
  , prize_odds_id INT(11) NOT NULL
  , additional_piece_target_card_type_1 INT(11) NOT NULL
  , additional_piece_target_card_id_1 INT(11) NOT NULL
  , additional_piece_target_rarity_1 INT(11) NOT NULL
  , additional_piece_num_1 INT(11) NOT NULL
  , additional_piece_target_card_type_2 INT(11) NOT NULL
  , additional_piece_target_card_id_2 INT(11) NOT NULL
  , additional_piece_target_rarity_2 INT(11) NOT NULL
  , additional_piece_num_2 INT(11) NOT NULL
  , additional_piece_target_card_type_3 INT(11) NOT NULL
  , additional_piece_target_card_id_3 INT(11) NOT NULL
  , additional_piece_target_rarity_3 INT(11) NOT NULL
  , additional_piece_num_3 INT(11) NOT NULL
  , additional_piece_target_card_type_4 INT(11) NOT NULL
  , additional_piece_target_card_id_4 INT(11) NOT NULL
  , additional_piece_target_rarity_4 INT(11) NOT NULL
  , additional_piece_num_4 INT(11) NOT NULL
  , additional_piece_target_card_type_5 INT(11) NOT NULL
  , additional_piece_target_card_id_5 INT(11) NOT NULL
  , additional_piece_target_rarity_5 INT(11) NOT NULL
  , additional_piece_num_5 INT(11) NOT NULL
  , additional_piece_target_card_type_6 INT(11) NOT NULL
  , additional_piece_target_card_id_6 INT(11) NOT NULL
  , additional_piece_target_rarity_6 INT(11) NOT NULL
  , additional_piece_num_6 INT(11) NOT NULL
  , bonus_target_draw_num INT(11) NOT NULL
  , bonus_item_category_1 INT(11) NOT NULL
  , bonus_item_id_1 INT(11) NOT NULL
  , bonus_item_num_1 INT(11) NOT NULL
  , bonus_item_category_2 INT(11) NOT NULL
  , bonus_item_id_2 INT(11) NOT NULL
  , bonus_item_num_2 INT(11) NOT NULL
  , start_date INT(11) NOT NULL
  , end_date INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 546,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `gacha_available`
--
CREATE TABLE gacha_available
(
    gacha_id INT(11) NOT NULL
  , card_id INT(11) NOT NULL
  , card_type INT(11) NOT NULL
  , rarity INT(11) NOT NULL
  , odds INT(11) NOT NULL
  , is_pickup INT(11) NOT NULL
  , recommend_order INT(11) NOT NULL
  , is_prize_selectable INT(11) NOT NULL
  , PRIMARY KEY (gacha_id, card_id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 207,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `gacha_available_0_gacha_id` on table `gacha_available`
--
ALTER TABLE gacha_available
ADD INDEX gacha_available_0_gacha_id (gacha_id);

--
-- Create table `facial_mouth_change`
--
CREATE TABLE facial_mouth_change
(
    id INT(11) NOT NULL
  , chara_id INT(11) NOT NULL
  , before_facialname TEXT NOT NULL
  , after_facialname TEXT NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1170,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `facial_mouth_change_0_chara_id_1_before_facialname` on table `facial_mouth_change`
--
ALTER TABLE facial_mouth_change
ADD UNIQUE INDEX facial_mouth_change_0_chara_id_1_before_facialname USING HASH (chara_id, before_facialname);

--
-- Create index `facial_mouth_change_0_chara_id` on table `facial_mouth_change`
--
ALTER TABLE facial_mouth_change
ADD INDEX facial_mouth_change_0_chara_id (chara_id);

--
-- Create table `face_type_data`
--
CREATE TABLE face_type_data
(
    label VARCHAR(300) NOT NULL
  , eyebrow_l TEXT NOT NULL
  , eyebrow_r TEXT NOT NULL
  , eye_l TEXT NOT NULL
  , eye_r TEXT NOT NULL
  , mouth TEXT NOT NULL
  , mouth_shape_type INT(11) NOT NULL
  , inverce_face_type TEXT NOT NULL
  , set_face_group INT(11) NOT NULL
  , PRIMARY KEY (label)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 143,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `event_motion_plus_data`
--
CREATE TABLE event_motion_plus_data
(
    id INT(11) NOT NULL
  , command_name TEXT NOT NULL
  , base_state_name VARCHAR(750) NOT NULL
  , layer_index INT(11) NOT NULL
  , tail_motion_type INT(11) NOT NULL
  , start_blend_time INT(11) NOT NULL
  , end_blend_time INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 109,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

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
CREATE TABLE event_motion_data
(
    id INT(11) NOT NULL
  , command_name TEXT NOT NULL
  , base_state_name TEXT NOT NULL
  , pose_blend INT(11) NOT NULL
  , type INT(11) NOT NULL
  , state_group INT(11) NOT NULL
  , category INT(11) NOT NULL
  , start_blend_time INT(11) NOT NULL
  , end_blend_time INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 109,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

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
CREATE TABLE dress_data
(
    id INT(11) NOT NULL
  , condition_type INT(11) NOT NULL
  , have_mini INT(11) NOT NULL
  , general_purpose INT(11) NOT NULL
  , chara_id INT(11) NOT NULL
  , use_gender INT(11) NOT NULL
  , body_shape INT(11) NOT NULL
  , body_type INT(11) NOT NULL
  , body_type_sub INT(11) NOT NULL
  , body_setting INT(11) NOT NULL
  , use_race INT(11) NOT NULL
  , use_live INT(11) NOT NULL
  , use_live_theater INT(11) NOT NULL
  , use_home INT(11) NOT NULL
  , is_wet INT(11) NOT NULL
  , is_dirt INT(11) NOT NULL
  , head_sub_id INT(11) NOT NULL
  , use_season INT(11) NOT NULL
  , dress_color_main TEXT NOT NULL
  , dress_color_sub TEXT NOT NULL
  , color_num INT(11) NOT NULL
  , disp_order INT(11) NOT NULL
  , tail_model_id INT(11) NOT NULL
  , tail_model_sub_id INT(11) NOT NULL
  , start_time INT(11) NOT NULL
  , end_time INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 368,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

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
-- Create index `dress_data_0_body_type` on table `dress_data`
--
ALTER TABLE dress_data
ADD INDEX dress_data_0_body_type (body_type);

--
-- Create table `directory`
--
CREATE TABLE directory
(
    id INT(11) NOT NULL
  , required_point INT(11) NOT NULL
  , rank_level INT(11) NOT NULL
  , item_category_1 INT(11) NOT NULL
  , item_id_1 INT(11) NOT NULL
  , item_num_1 INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 81,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

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
-- Create table `daily_race_npc`
--
CREATE TABLE daily_race_npc
(
    id INT(11) NOT NULL
  , npc_group_id INT(11) NOT NULL
  , chara_id INT(11) NOT NULL
  , mob_id INT(11) NOT NULL
  , race_dress_id INT(11) NOT NULL
  , race_instance_id INT(11) NOT NULL
  , speed INT(11) NOT NULL
  , stamina INT(11) NOT NULL
  , pow INT(11) NOT NULL
  , guts INT(11) NOT NULL
  , wiz INT(11) NOT NULL
  , proper_distance_short INT(11) NOT NULL
  , proper_distance_mile INT(11) NOT NULL
  , proper_distance_middle INT(11) NOT NULL
  , proper_distance_long INT(11) NOT NULL
  , proper_running_style_nige INT(11) NOT NULL
  , proper_running_style_senko INT(11) NOT NULL
  , proper_running_style_sashi INT(11) NOT NULL
  , proper_running_style_oikomi INT(11) NOT NULL
  , proper_ground_turf INT(11) NOT NULL
  , proper_ground_dirt INT(11) NOT NULL
  , skill_set_id INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 122,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `daily_race_billing`
--
CREATE TABLE daily_race_billing
(
    id INT(11) NOT NULL
  , frequency INT(11) NOT NULL
  , pay_cost INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 16384,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `daily_race`
--
CREATE TABLE daily_race
(
    id INT(11) NOT NULL
  , group_id INT(11) NOT NULL
  , difficulty INT(11) NOT NULL
  , race_instance_id INT(11) NOT NULL
  , cost_num INT(11) NOT NULL
  , unique_chara_npc_min INT(11) NOT NULL
  , unique_chara_npc_max INT(11) NOT NULL
  , normal_rewards_odds_id INT(11) NOT NULL
  , bonus_rewards_odds_id INT(11) NOT NULL
  , rare_reward_odds_id INT(11) NOT NULL
  , first_clear_item_category_1 INT(11) NOT NULL
  , first_clear_item_id_1 INT(11) NOT NULL
  , first_clear_item_num_1 INT(11) NOT NULL
  , first_clear_item_category_2 INT(11) NOT NULL
  , first_clear_item_id_2 INT(11) NOT NULL
  , first_clear_item_num_2 INT(11) NOT NULL
  , first_clear_item_category_3 INT(11) NOT NULL
  , first_clear_item_id_3 INT(11) NOT NULL
  , first_clear_item_num_3 INT(11) NOT NULL
  , pick_up_item_category_1 INT(11) NOT NULL
  , pick_up_item_id_1 INT(11) NOT NULL
  , pick_up_item_num_1 INT(11) NOT NULL
  , pick_up_item_category_2 INT(11) NOT NULL
  , pick_up_item_id_2 INT(11) NOT NULL
  , pick_up_item_num_2 INT(11) NOT NULL
  , pick_up_item_category_3 INT(11) NOT NULL
  , pick_up_item_id_3 INT(11) NOT NULL
  , pick_up_item_num_3 INT(11) NOT NULL
  , start_date INT(11) NOT NULL
  , end_date INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 2730,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `daily_race_0_race_instance_id` on table `daily_race`
--
ALTER TABLE daily_race
ADD INDEX daily_race_0_race_instance_id (race_instance_id);

--
-- Create table `daily_pack`
--
CREATE TABLE daily_pack
(
    shop_data_id INT(11) NOT NULL
  , platform_id INT(11) NOT NULL
  , term INT(11) NOT NULL
  , repurchase_day INT(11) NOT NULL
  , group_id INT(11) NOT NULL
  , daily_free_num INT(11) NOT NULL
  , start_date TEXT NOT NULL
  , end_date TEXT NOT NULL
  , PRIMARY KEY (shop_data_id, platform_id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 5461,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `daily_pack_0_group_id` on table `daily_pack`
--
ALTER TABLE daily_pack
ADD INDEX daily_pack_0_group_id (group_id);

--
-- Create table `crane_game_prop`
--
CREATE TABLE crane_game_prop
(
    type INT(11) NOT NULL
  , num INT(11) NOT NULL
  , PRIMARY KEY (type)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 8192,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `crane_game_prize_pattern`
--
CREATE TABLE crane_game_prize_pattern
(
    id INT(11) NOT NULL
  , prop_pattern_id INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 5461,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `crane_game_prize_face`
--
CREATE TABLE crane_game_prize_face
(
    id INT(11) NOT NULL
  , face_type TEXT NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 5461,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `crane_game_hidden_odds`
--
CREATE TABLE crane_game_hidden_odds
(
    id INT(11) NOT NULL
  , animation_id INT(11) NOT NULL
  , crane_animation_id INT(11) NOT NULL
  , type_id INT(11) NOT NULL
  , num INT(11) NOT NULL
  , big INT(11) NOT NULL
  , big_index INT(11) NOT NULL
  , odds_1 INT(11) NOT NULL
  , odds_2 INT(11) NOT NULL
  , odds_3 INT(11) NOT NULL
  , odds_extra INT(11) NOT NULL
  , rare_effect_odds INT(11) NOT NULL
  , joint_type INT(11) NOT NULL
  , lift_type INT(11) NOT NULL
  , push_type INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 496,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `crane_game_extra_odds_condition`
--
CREATE TABLE crane_game_extra_odds_condition
(
    credit INT(11) NOT NULL
  , get_num INT(11) NOT NULL
  , PRIMARY KEY (credit)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 16384,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `crane_game_define_param`
--
CREATE TABLE crane_game_define_param
(
    id INT(11) NOT NULL
  , distance1 TEXT NOT NULL
  , distance2 TEXT NOT NULL
  , move_speed_1 TEXT NOT NULL
  , move_speed_2 TEXT NOT NULL
  , move_speed_3 TEXT NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 16384,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `crane_game_catch_result`
--
CREATE TABLE crane_game_catch_result
(
    odds_id INT(11) NOT NULL
  , get_num INT(11) NOT NULL
  , lottery_weight_1_1 INT(11) NOT NULL
  , lottery_weight_1_2 INT(11) NOT NULL
  , lottery_weight_2_1 INT(11) NOT NULL
  , lottery_weight_2_2 INT(11) NOT NULL
  , lottery_weight_3_1 INT(11) NOT NULL
  , lottery_weight_3_2 INT(11) NOT NULL
  , lottery_weight_extra_1 INT(11) NOT NULL
  , lottery_weight_extra_2 INT(11) NOT NULL
  , PRIMARY KEY (odds_id, get_num)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 240,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `crane_game_arm_swing`
--
CREATE TABLE crane_game_arm_swing
(
    result_type INT(11) NOT NULL
  , odds_1 INT(11) NOT NULL
  , odds_2 INT(11) NOT NULL
  , odds_3 INT(11) NOT NULL
  , PRIMARY KEY (result_type)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 5461,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `circle_stamp_data`
--
CREATE TABLE circle_stamp_data
(
    id INT(11) NOT NULL
  , type INT(11) NOT NULL
  , disp_order INT(11) NOT NULL
  , start_date TEXT NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 409,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `disp_order` on table `circle_stamp_data`
--
ALTER TABLE circle_stamp_data
ADD UNIQUE INDEX disp_order (disp_order);

--
-- Create table `circle_rank_data`
--
CREATE TABLE circle_rank_data
(
    id INT(11) NOT NULL
  , need_ranking_max INT(11) NOT NULL
  , need_ranking_min INT(11) NOT NULL
  , reward_item_category_1 INT(11) NOT NULL
  , reward_item_id_1 INT(11) NOT NULL
  , reward_num_1 INT(11) NOT NULL
  , reward_item_category_2 INT(11) NOT NULL
  , reward_item_id_2 INT(11) NOT NULL
  , reward_num_2 INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1489,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `chara_type`
--
CREATE TABLE chara_type
(
    id VARCHAR(20) NOT NULL
  , chara_id INT(11) NOT NULL
  , target_scene INT(11) NOT NULL
  , target_cut INT(11) NOT NULL
  , target_type INT(11) NOT NULL
  , value INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 102,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `chara_type_0_target_scene_1_target_cut` on table `chara_type`
--
ALTER TABLE chara_type
ADD INDEX chara_type_0_target_scene_1_target_cut (target_scene, target_cut);

--
-- Create table `chara_story_data`
--
CREATE TABLE chara_story_data
(
    id INT(11) NOT NULL
  , chara_id INT(11) NOT NULL
  , episode_index INT(11) NOT NULL
  , story_id INT(11) NOT NULL
  , lock_type_1 INT(11) NOT NULL
  , lock_value_1_1 INT(11) NOT NULL
  , lock_value_1_2 INT(11) NOT NULL
  , add_reward_category_1 INT(11) NOT NULL
  , add_reward_id_1 INT(11) NOT NULL
  , add_reward_num_1 INT(11) NOT NULL
  , exp_type INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 137,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `chara_story_data_0_story_id` on table `chara_story_data`
--
ALTER TABLE chara_story_data
ADD UNIQUE INDEX chara_story_data_0_story_id (story_id);

--
-- Create index `chara_story_data_0_chara_id_1_episode_index` on table `chara_story_data`
--
ALTER TABLE chara_story_data
ADD INDEX chara_story_data_0_chara_id_1_episode_index (chara_id, episode_index);

--
-- Create index `chara_story_data_0_chara_id` on table `chara_story_data`
--
ALTER TABLE chara_story_data
ADD INDEX chara_story_data_0_chara_id (chara_id);

--
-- Create table `chara_motion_set`
--
CREATE TABLE chara_motion_set
(
    id INT(11) NOT NULL
  , body_motion TEXT NOT NULL
  , body_motion_type INT(11) NOT NULL
  , body_motion_play_type INT(11) NOT NULL
  , face_type TEXT NOT NULL
  , cheek INT(11) NOT NULL
  , eye_default INT(11) NOT NULL
  , ear_motion TEXT NOT NULL
  , tail_motion TEXT NOT NULL
  , tail_motion_type INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 79,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `chara_motion_act`
--
CREATE TABLE chara_motion_act
(
    id INT(11) NOT NULL
  , chara_id INT(11) NOT NULL
  , target_motion INT(11) NOT NULL
  , command_name TEXT NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 455,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `chara_motion_act_0_chara_id_1_command_name` on table `chara_motion_act`
--
ALTER TABLE chara_motion_act
ADD UNIQUE INDEX chara_motion_act_0_chara_id_1_command_name USING HASH (chara_id, command_name);

--
-- Create index `chara_motion_act_0_chara_id` on table `chara_motion_act`
--
ALTER TABLE chara_motion_act
ADD INDEX chara_motion_act_0_chara_id (chara_id);

--
-- Create table `chara_data`
--
CREATE TABLE chara_data
(
    id INT(11) NOT NULL
  , birth_year INT(11) NOT NULL
  , birth_month INT(11) NOT NULL
  , birth_day INT(11) NOT NULL
  , sex INT(11) NOT NULL
  , image_color_main TEXT NOT NULL
  , image_color_sub TEXT NOT NULL
  , ui_color_main TEXT NOT NULL
  , ui_color_sub TEXT NOT NULL
  , ui_training_color_1 TEXT NOT NULL
  , ui_training_color_2 TEXT NOT NULL
  , ui_border_color TEXT NOT NULL
  , ui_num_color_1 TEXT NOT NULL
  , ui_num_color_2 TEXT NOT NULL
  , ui_turn_color TEXT NOT NULL
  , ui_wipe_color_1 TEXT NOT NULL
  , ui_wipe_color_2 TEXT NOT NULL
  , ui_wipe_color_3 TEXT NOT NULL
  , ui_speech_color_1 TEXT NOT NULL
  , ui_speech_color_2 TEXT NOT NULL
  , ui_nameplate_color_1 TEXT NOT NULL
  , ui_nameplate_color_2 TEXT NOT NULL
  , height INT(11) NOT NULL
  , bust INT(11) NOT NULL
  , scale INT(11) NOT NULL
  , skin INT(11) NOT NULL
  , shape INT(11) NOT NULL
  , socks INT(11) NOT NULL
  , personal_dress INT(11) NOT NULL
  , tail_model_id INT(11) NOT NULL
  , race_running_type INT(11) NOT NULL
  , ear_random_time_min INT(11) NOT NULL
  , ear_random_time_max INT(11) NOT NULL
  , tail_random_time_min INT(11) NOT NULL
  , tail_random_time_max INT(11) NOT NULL
  , story_ear_random_time_min INT(11) NOT NULL
  , story_ear_random_time_max INT(11) NOT NULL
  , story_tail_random_time_min INT(11) NOT NULL
  , story_tail_random_time_max INT(11) NOT NULL
  , attachment_model_id INT(11) NOT NULL
  , mini_mayu_shader_type INT(11) NOT NULL
  , start_date INT(11) NOT NULL
  , chara_category INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 592,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `chara_category_motion`
--
CREATE TABLE chara_category_motion
(
    chara_id INT(11) NOT NULL
  , standby_motion_1 INT(11) NOT NULL
  , standby_motion_2 INT(11) NOT NULL
  , standby_motion_3 INT(11) NOT NULL
  , standby_motion_4 INT(11) NOT NULL
  , standby_motion_5 INT(11) NOT NULL
  , standby_motion_6 INT(11) NOT NULL
  , PRIMARY KEY (chara_id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 321,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `character_system_text`
--
CREATE TABLE character_system_text
(
    character_id INT(11) NOT NULL
  , voice_id INT(11) NOT NULL
  , text TEXT NOT NULL
  , cue_sheet TEXT NOT NULL
  , cue_id INT(11) NOT NULL
  , motion_set INT(11) NOT NULL
  , scene INT(11) NOT NULL
  , use_gallery INT(11) NOT NULL
  , card_id INT(11) NOT NULL
  , lip_sync_data TEXT NOT NULL
  , gender INT(11) NOT NULL
  , motion_second_set INT(11) NOT NULL
  , motion_second_start INT(11) NOT NULL
  , start_date INT(11) NOT NULL
  , PRIMARY KEY (character_id, voice_id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 547,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `character_system_text_0_character_id` on table `character_system_text`
--
ALTER TABLE character_system_text
ADD INDEX character_system_text_0_character_id (character_id);

--
-- Create table `character_system_lottery`
--
CREATE TABLE character_system_lottery
(
    id INT(11) NOT NULL
  , chara_id INT(11) NOT NULL
  , card_id INT(11) NOT NULL
  , card_rarity_id INT(11) NOT NULL
  , `trigger` INT(11) NOT NULL
  , param1 INT(11) NOT NULL
  , per INT(11) NOT NULL
  , priority INT(11) NOT NULL
  , sys_text_id INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 71,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

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
CREATE TABLE character_prop_animation
(
    id INT(11) NOT NULL
  , prop_id INT(11) NOT NULL
  , prop_anim_id INT(11) NOT NULL
  , layer_index INT(11) NOT NULL
  , use_state_name TEXT NOT NULL
  , scene_type INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 963,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `character_prop_animation_0_prop_id_1_scene_type` on table `character_prop_animation`
--
ALTER TABLE character_prop_animation
ADD INDEX character_prop_animation_0_prop_id_1_scene_type (prop_id, scene_type);

--
-- Create table `champions_stand_motion`
--
CREATE TABLE champions_stand_motion
(
    chara_id INT(11) NOT NULL
  , type INT(11) NOT NULL
  , race_dress_id INT(11) NOT NULL
  , motion_set INT(11) NOT NULL
  , PRIMARY KEY (chara_id, type)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 910,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `champions_schedule`
--
CREATE TABLE champions_schedule
(
    id INT(11) NOT NULL
  , resource_id INT(11) NOT NULL
  , info_detail_1 INT(11) NOT NULL
  , info_detail_2 INT(11) NOT NULL
  , champions_bg_id INT(11) NOT NULL
  , champions_league_select_bg_sub_id INT(11) NOT NULL
  , champions_bg_sub_id INT(11) NOT NULL
  , champions_finish_bg_sub_id INT(11) NOT NULL
  , champions_bg_position_x INT(11) NOT NULL
  , start_date INT(11) NOT NULL
  , end_date INT(11) NOT NULL
  , info_detail INT(11) NOT NULL
  , champions_finish_bg_id INT(11) NOT NULL
  , champions_finish_bg_position_x INT(11) NOT NULL
  , notice_date INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1638,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `champions_round_schedule`
--
CREATE TABLE champions_round_schedule
(
    id INT(11) NOT NULL
  , champions_id INT(11) NOT NULL
  , round INT(11) NOT NULL
  , round_detail INT(11) NOT NULL
  , start_date INT(11) NOT NULL
  , end_date INT(11) NOT NULL
  , interval_start_time INT(11) NOT NULL
  , interval_end_time INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 273,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `champions_round_schedule_0_champions_id` on table `champions_round_schedule`
--
ALTER TABLE champions_round_schedule
ADD INDEX champions_round_schedule_0_champions_id (champions_id);

--
-- Create table `champions_round_detail`
--
CREATE TABLE champions_round_detail
(
    id INT(11) NOT NULL
  , champions_id INT(11) NOT NULL
  , league_type INT(11) NOT NULL
  , round_id INT(11) NOT NULL
  , round INT(11) NOT NULL
  , tier INT(11) NOT NULL
  , round_number INT(11) NOT NULL
  , breakthrough_number_1 INT(11) NOT NULL
  , breakthrough_number_2 INT(11) NOT NULL
  , entry_number INT(11) NOT NULL
  , free_entry_number INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 117,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `champions_round_detail_0_champions_id_1_league_type` on table `champions_round_detail`
--
ALTER TABLE champions_round_detail
ADD INDEX champions_round_detail_0_champions_id_1_league_type (champions_id, league_type);

--
-- Create table `champions_reward_rate`
--
CREATE TABLE champions_reward_rate
(
    id INT(11) NOT NULL
  , champions_id INT(11) NOT NULL
  , league_type INT(11) NOT NULL
  , round_id INT(11) NOT NULL
  , win_count INT(11) NOT NULL
  , ranking INT(11) NOT NULL
  , rate INT(11) NOT NULL
  , reward_set_id INT(11) NOT NULL
  , box_grade INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 136,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `champions_reward_rate_0_champions_id_1_round_id` on table `champions_reward_rate`
--
ALTER TABLE champions_reward_rate
ADD INDEX champions_reward_rate_0_champions_id_1_round_id (champions_id, round_id);

--
-- Create table `champions_race_condition`
--
CREATE TABLE champions_race_condition
(
    champions_id INT(11) NOT NULL
  , round_id INT(11) NOT NULL
  , race_instance_id INT(11) NOT NULL
  , race_condition_id INT(11) NOT NULL
  , PRIMARY KEY (champions_id, round_id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 234,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `champions_news_trainer_wininfo`
--
CREATE TABLE champions_news_trainer_wininfo
(
    id INT(11) NOT NULL
  , round_id INT(11) NOT NULL
  , race_count_type INT(11) NOT NULL
  , win_min INT(11) NOT NULL
  , win_max INT(11) NOT NULL
  , trainer_text_group INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 341,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `champions_news_trainer_wininfo_0_round_id` on table `champions_news_trainer_wininfo`
--
ALTER TABLE champions_news_trainer_wininfo
ADD INDEX champions_news_trainer_wininfo_0_round_id (round_id);

--
-- Create table `champions_news_trainer_detail`
--
CREATE TABLE champions_news_trainer_detail
(
    id INT(11) NOT NULL
  , trainer_text_group INT(11) NOT NULL
  , text_number INT(11) NOT NULL
  , resource_id INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 130,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `champions_news_title`
--
CREATE TABLE champions_news_title
(
    id INT(11) NOT NULL
  , round_id INT(11) NOT NULL
  , win_percent_type INT(11) NOT NULL
  , resource_id INT(11) NOT NULL
  , title INT(11) NOT NULL
  , sub_title INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 124,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `champions_news_title_0_round_id` on table `champions_news_title`
--
ALTER TABLE champions_news_title
ADD INDEX champions_news_title_0_round_id (round_id);

--
-- Create table `champions_news_race`
--
CREATE TABLE champions_news_race
(
    id INT(11) NOT NULL
  , round_id INT(11) NOT NULL
  , win_percent_type INT(11) NOT NULL
  , text_number INT(11) NOT NULL
  , resource_id INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 77,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `champions_news_race_0_round_id` on table `champions_news_race`
--
ALTER TABLE champions_news_race
ADD INDEX champions_news_race_0_round_id (round_id);

--
-- Create table `champions_news_chara_wininfo`
--
CREATE TABLE champions_news_chara_wininfo
(
    id INT(11) NOT NULL
  , round_id INT(11) NOT NULL
  , race_count_type INT(11) NOT NULL
  , win_min INT(11) NOT NULL
  , win_max INT(11) NOT NULL
  , chara_text_group INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 315,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `champions_news_chara_detail`
--
CREATE TABLE champions_news_chara_detail
(
    id INT(11) NOT NULL
  , chara_text_group INT(11) NOT NULL
  , text_number INT(11) NOT NULL
  , resource_id INT(11) NOT NULL
  , chara_id INT(11) NOT NULL
  , single_win INT(11) NOT NULL
  , nickname_id INT(11) NOT NULL
  , parameter_type INT(11) NOT NULL
  , parameter_min INT(11) NOT NULL
  , running_style INT(11) NOT NULL
  , proper_running_style_min INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 140,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `champions_news_chara_comment`
--
CREATE TABLE champions_news_chara_comment
(
    id INT(11) NOT NULL
  , round_id INT(11) NOT NULL
  , chara_id INT(11) NOT NULL
  , big_flag INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 98,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `champions_news_chara_comment_0_round_id` on table `champions_news_chara_comment`
--
ALTER TABLE champions_news_chara_comment
ADD INDEX champions_news_chara_comment_0_round_id (round_id);

--
-- Create table `champions_evaluation_rate`
--
CREATE TABLE champions_evaluation_rate
(
    id INT(11) NOT NULL
  , proper_type INT(11) NOT NULL
  , proper_rank INT(11) NOT NULL
  , rate INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1024,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `champions_entry_reward`
--
CREATE TABLE champions_entry_reward
(
    champions_id INT(11) NOT NULL
  , item_category INT(11) NOT NULL
  , item_id INT(11) NOT NULL
  , item_num INT(11) NOT NULL
  , PRIMARY KEY (champions_id, item_id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 8192,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `champions_entry_reward_0_champions_id` on table `champions_entry_reward`
--
ALTER TABLE champions_entry_reward
ADD INDEX champions_entry_reward_0_champions_id (champions_id);

--
-- Create table `champions_bgm`
--
CREATE TABLE champions_bgm
(
    id INT(11) NOT NULL
  , round_id INT(11) NOT NULL
  , scene_type INT(11) NOT NULL
  , race_number INT(11) NOT NULL
  , cue_name TEXT NOT NULL
  , cuesheet_name TEXT NOT NULL
  , first_bgm_pattern INT(11) NOT NULL
  , second_bgm_pattern INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 297,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `champions_bgm_0_round_id_1_scene_type_2_race_number` on table `champions_bgm`
--
ALTER TABLE champions_bgm
ADD INDEX champions_bgm_0_round_id_1_scene_type_2_race_number (round_id, scene_type, race_number);

--
-- Create table `challenge_match_retry_bonus`
--
CREATE TABLE challenge_match_retry_bonus
(
    id INT(11) NOT NULL
  , retry_min INT(11) NOT NULL
  , retry_max INT(11) NOT NULL
  , bonus_rate INT(11) NOT NULL
  , resimulate_num INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 3276,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `challenge_match_raw_point`
--
CREATE TABLE challenge_match_raw_point
(
    id INT(11) NOT NULL
  , priority INT(11) NOT NULL
  , condition_type INT(11) NOT NULL
  , condition_value_1 INT(11) NOT NULL
  , condition_value_2 INT(11) NOT NULL
  , point INT(11) NOT NULL
  , race_point_name_id INT(11) NOT NULL
  , sort_order INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 178,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

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
-- Create table `challenge_match_race_npc`
--
CREATE TABLE challenge_match_race_npc
(
    id INT(11) NOT NULL
  , npc_group_id INT(11) NOT NULL
  , chara_id INT(11) NOT NULL
  , mob_id INT(11) NOT NULL
  , race_dress_id INT(11) NOT NULL
  , race_instance_id INT(11) NOT NULL
  , speed INT(11) NOT NULL
  , stamina INT(11) NOT NULL
  , pow INT(11) NOT NULL
  , guts INT(11) NOT NULL
  , wiz INT(11) NOT NULL
  , proper_distance_short INT(11) NOT NULL
  , proper_distance_mile INT(11) NOT NULL
  , proper_distance_middle INT(11) NOT NULL
  , proper_distance_long INT(11) NOT NULL
  , proper_running_style_nige INT(11) NOT NULL
  , proper_running_style_senko INT(11) NOT NULL
  , proper_running_style_sashi INT(11) NOT NULL
  , proper_running_style_oikomi INT(11) NOT NULL
  , proper_ground_turf INT(11) NOT NULL
  , proper_ground_dirt INT(11) NOT NULL
  , skill_set_id INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 248,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `challenge_match_race`
--
CREATE TABLE challenge_match_race
(
    id INT(11) NOT NULL
  , challenge_match_id INT(11) NOT NULL
  , disp_order INT(11) NOT NULL
  , challenge_match_bg_id INT(11) NOT NULL
  , challenge_match_bg_sub_id INT(11) NOT NULL
  , difficulty INT(11) NOT NULL
  , race_type INT(11) NOT NULL
  , race_appearance_rate INT(11) NOT NULL
  , race_instance_id INT(11) NOT NULL
  , season INT(11) NOT NULL
  , weather INT(11) NOT NULL
  , ground INT(11) NOT NULL
  , challenge_match_race_boss_npc_id INT(11) NOT NULL
  , cost_rp INT(11) NOT NULL
  , drop_reward_odds_id INT(11) NOT NULL
  , victory_reward_odds_id INT(11) NOT NULL
  , first_clear_item_category_1 INT(11) NOT NULL
  , first_clear_item_id_1 INT(11) NOT NULL
  , first_clear_item_num_1 INT(11) NOT NULL
  , first_clear_item_category_2 INT(11) NOT NULL
  , first_clear_item_id_2 INT(11) NOT NULL
  , first_clear_item_num_2 INT(11) NOT NULL
  , first_clear_item_category_3 INT(11) NOT NULL
  , first_clear_item_id_3 INT(11) NOT NULL
  , first_clear_item_num_3 INT(11) NOT NULL
  , pick_up_item_category_1 INT(11) NOT NULL
  , pick_up_item_id_1 INT(11) NOT NULL
  , pick_up_item_num_1 INT(11) NOT NULL
  , pick_up_item_category_2 INT(11) NOT NULL
  , pick_up_item_id_2 INT(11) NOT NULL
  , pick_up_item_num_2 INT(11) NOT NULL
  , pick_up_item_category_3 INT(11) NOT NULL
  , pick_up_item_id_3 INT(11) NOT NULL
  , pick_up_item_num_3 INT(11) NOT NULL
  , pick_up_item_category_4 INT(11) NOT NULL
  , pick_up_item_id_4 INT(11) NOT NULL
  , pick_up_item_num_4 INT(11) NOT NULL
  , pick_up_item_category_5 INT(11) NOT NULL
  , pick_up_item_id_5 INT(11) NOT NULL
  , pick_up_item_num_5 INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 2730,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

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
CREATE TABLE challenge_match_data
(
    challenge_match_id INT(11) NOT NULL
  , announce_id INT(11) NOT NULL
  , bonus_skill_id INT(11) NOT NULL
  , bonus_factor_id INT(11) NOT NULL
  , item_exchange_top_id INT(11) NOT NULL
  , notice_date INT(11) NOT NULL
  , start_date INT(11) NOT NULL
  , ending_date INT(11) NOT NULL
  , end_date INT(11) NOT NULL
  , PRIMARY KEY (challenge_match_id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 16384,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `challenge_match_boss_npc`
--
CREATE TABLE challenge_match_boss_npc
(
    id INT(11) NOT NULL
  , chara_id INT(11) NOT NULL
  , race_dress_id INT(11) NOT NULL
  , nickname_id INT(11) NOT NULL
  , card_rarity_data_id INT(11) NOT NULL
  , post INT(11) NOT NULL
  , speed INT(11) NOT NULL
  , stamina INT(11) NOT NULL
  , pow INT(11) NOT NULL
  , guts INT(11) NOT NULL
  , wiz INT(11) NOT NULL
  , proper_distance_short INT(11) NOT NULL
  , proper_distance_mile INT(11) NOT NULL
  , proper_distance_middle INT(11) NOT NULL
  , proper_distance_long INT(11) NOT NULL
  , proper_running_style_nige INT(11) NOT NULL
  , proper_running_style_senko INT(11) NOT NULL
  , proper_running_style_sashi INT(11) NOT NULL
  , proper_running_style_oikomi INT(11) NOT NULL
  , proper_ground_turf INT(11) NOT NULL
  , proper_ground_dirt INT(11) NOT NULL
  , skill_set_id INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 2730,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `card_talent_upgrade`
--
CREATE TABLE card_talent_upgrade
(
    id INT(11) NOT NULL
  , talent_group_id INT(11) NOT NULL
  , talent_level INT(11) NOT NULL
  , item_category_1 INT(11) NOT NULL
  , item_id_1 INT(11) NOT NULL
  , item_num_1 INT(11) NOT NULL
  , item_category_2 INT(11) NOT NULL
  , item_id_2 INT(11) NOT NULL
  , item_num_2 INT(11) NOT NULL
  , item_category_3 INT(11) NOT NULL
  , item_id_3 INT(11) NOT NULL
  , item_num_3 INT(11) NOT NULL
  , item_category_4 INT(11) NOT NULL
  , item_id_4 INT(11) NOT NULL
  , item_num_4 INT(11) NOT NULL
  , item_category_5 INT(11) NOT NULL
  , item_id_5 INT(11) NOT NULL
  , item_num_5 INT(11) NOT NULL
  , item_category_6 INT(11) NOT NULL
  , item_id_6 INT(11) NOT NULL
  , item_num_6 INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 230,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `card_talent_upgrade_0_talent_group_id_1_talent_level` on table `card_talent_upgrade`
--
ALTER TABLE card_talent_upgrade
ADD INDEX card_talent_upgrade_0_talent_group_id_1_talent_level (talent_group_id, talent_level);

--
-- Create table `card_talent_hint_upgrade`
--
CREATE TABLE card_talent_hint_upgrade
(
    id INT(11) NOT NULL
  , rarity INT(11) NOT NULL
  , talent_level INT(11) NOT NULL
  , item_category_1 INT(11) NOT NULL
  , item_id_1 INT(11) NOT NULL
  , item_disp_order_1 INT(11) NOT NULL
  , item_num_1 INT(11) NOT NULL
  , item_category_2 INT(11) NOT NULL
  , item_id_2 INT(11) NOT NULL
  , item_disp_order_2 INT(11) NOT NULL
  , item_num_2 INT(11) NOT NULL
  , money_num INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `card_talent_hint_upgrade_0_rarity_1_talent_level` on table `card_talent_hint_upgrade`
--
ALTER TABLE card_talent_hint_upgrade
ADD INDEX card_talent_hint_upgrade_0_rarity_1_talent_level (rarity, talent_level);

--
-- Create table `card_rarity_data`
--
CREATE TABLE card_rarity_data
(
    id INT(11) NOT NULL
  , card_id INT(11) NOT NULL
  , rarity INT(11) NOT NULL
  , race_dress_id INT(11) NOT NULL
  , skill_set INT(11) NOT NULL
  , speed INT(11) NOT NULL
  , stamina INT(11) NOT NULL
  , pow INT(11) NOT NULL
  , guts INT(11) NOT NULL
  , wiz INT(11) NOT NULL
  , max_speed INT(11) NOT NULL
  , max_stamina INT(11) NOT NULL
  , max_pow INT(11) NOT NULL
  , max_guts INT(11) NOT NULL
  , max_wiz INT(11) NOT NULL
  , proper_distance_short INT(11) NOT NULL
  , proper_distance_mile INT(11) NOT NULL
  , proper_distance_middle INT(11) NOT NULL
  , proper_distance_long INT(11) NOT NULL
  , proper_running_style_nige INT(11) NOT NULL
  , proper_running_style_senko INT(11) NOT NULL
  , proper_running_style_sashi INT(11) NOT NULL
  , proper_running_style_oikomi INT(11) NOT NULL
  , proper_ground_turf INT(11) NOT NULL
  , proper_ground_dirt INT(11) NOT NULL
  , get_dress_id_1 INT(11) NOT NULL
  , get_dress_id_2 INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 278,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `card_rarity_data_0_card_id_1_rarity` on table `card_rarity_data`
--
ALTER TABLE card_rarity_data
ADD UNIQUE INDEX card_rarity_data_0_card_id_1_rarity (card_id, rarity);

--
-- Create index `card_rarity_data_0_card_id` on table `card_rarity_data`
--
ALTER TABLE card_rarity_data
ADD INDEX card_rarity_data_0_card_id (card_id);

--
-- Create index `card_rarity_data_0_race_dress_id` on table `card_rarity_data`
--
ALTER TABLE card_rarity_data
ADD INDEX card_rarity_data_0_race_dress_id (race_dress_id);

--
-- Create table `card_data`
--
CREATE TABLE card_data
(
    id INT(11) NOT NULL
  , chara_id INT(11) NOT NULL
  , default_rarity INT(11) NOT NULL
  , limited_chara INT(11) NOT NULL
  , available_skill_set_id INT(11) NOT NULL
  , talent_speed INT(11) NOT NULL
  , talent_stamina INT(11) NOT NULL
  , talent_pow INT(11) NOT NULL
  , talent_guts INT(11) NOT NULL
  , talent_wiz INT(11) NOT NULL
  , talent_group_id INT(11) NOT NULL
  , bg_id INT(11) NOT NULL
  , get_piece_id INT(11) NOT NULL
  , running_style INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 234,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

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
-- Create table `campaign_single_race_add_reward`
--
CREATE TABLE campaign_single_race_add_reward
(
    id INT(11) NOT NULL
  , race_additional_reward_id INT(11) NOT NULL
  , item_category INT(11) NOT NULL
  , item_id INT(11) NOT NULL
  , reward_type INT(11) NOT NULL
  , reward_value INT(11) NOT NULL
  , reward_rate INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1092,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `campaign_single_race_add_reward_0_race_additional_reward_id` on table `campaign_single_race_add_reward`
--
ALTER TABLE campaign_single_race_add_reward
ADD INDEX campaign_single_race_add_reward_0_race_additional_reward_id (race_additional_reward_id);

--
-- Create table `campaign_single_race_add_data`
--
CREATE TABLE campaign_single_race_add_data
(
    id INT(11) NOT NULL
  , race_additional_id INT(11) NOT NULL
  , race_program_id INT(11) NOT NULL
  , race_additional_reward_id INT(11) NOT NULL
  , reward_limit INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 3276,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `campaign_single_race_add_data_0_race_additional_id` on table `campaign_single_race_add_data`
--
ALTER TABLE campaign_single_race_add_data
ADD INDEX campaign_single_race_add_data_0_race_additional_id (race_additional_id);

--
-- Create table `campaign_present_bonus_detail`
--
CREATE TABLE campaign_present_bonus_detail
(
    id INT(11) NOT NULL
  , campaign_id INT(11) NOT NULL
  , card_id INT(11) NOT NULL
  , count INT(11) NOT NULL
  , item_category_1 INT(11) NOT NULL
  , item_id_1 INT(11) NOT NULL
  , item_num_1 INT(11) NOT NULL
  , item_category_2 INT(11) NOT NULL
  , item_id_2 INT(11) NOT NULL
  , item_num_2 INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 240,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `campaign_id` on table `campaign_present_bonus_detail`
--
ALTER TABLE campaign_present_bonus_detail
ADD UNIQUE INDEX campaign_id (campaign_id, card_id);

--
-- Create index `item_id_1` on table `campaign_present_bonus_detail`
--
ALTER TABLE campaign_present_bonus_detail
ADD UNIQUE INDEX item_id_1 (item_id_1);

--
-- Create index `campaign_present_bonus_detail_0_card_id` on table `campaign_present_bonus_detail`
--
ALTER TABLE campaign_present_bonus_detail
ADD INDEX campaign_present_bonus_detail_0_card_id (card_id);

--
-- Create table `campaign_data`
--
CREATE TABLE campaign_data
(
    campaign_id INT(11) NOT NULL
  , target_type INT(11) NOT NULL
  , target_id INT(11) NOT NULL
  , effect_type_1 INT(11) NOT NULL
  , effect_value_1 INT(11) NOT NULL
  , user_show INT(11) NOT NULL
  , disp_order INT(11) NOT NULL
  , image_icon_id INT(11) NOT NULL
  , transition_type INT(11) NOT NULL
  , image_change INT(11) NOT NULL
  , logo_type INT(11) NOT NULL
  , start_time INT(11) NOT NULL
  , end_time INT(11) NOT NULL
  , PRIMARY KEY (campaign_id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 156,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `campaign_data_0_target_type` on table `campaign_data`
--
ALTER TABLE campaign_data
ADD INDEX campaign_data_0_target_type (target_type);

--
-- Create index `campaign_data_0_image_change` on table `campaign_data`
--
ALTER TABLE campaign_data
ADD INDEX campaign_data_0_image_change (image_change);

--
-- Create table `campaign_chara_story_schedule`
--
CREATE TABLE campaign_chara_story_schedule
(
    campaign_id INT(11) NOT NULL
  , chara_id INT(11) NOT NULL
  , story_id INT(11) NOT NULL
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 93,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `campaign_chara_story_schedule_0_chara_id` on table `campaign_chara_story_schedule`
--
ALTER TABLE campaign_chara_story_schedule
ADD INDEX campaign_chara_story_schedule_0_chara_id (chara_id);

--
-- Create index `campaign_chara_story_schedule_0_campaign_id` on table `campaign_chara_story_schedule`
--
ALTER TABLE campaign_chara_story_schedule
ADD INDEX campaign_chara_story_schedule_0_campaign_id (campaign_id);

--
-- Create table `banner_data`
--
CREATE TABLE banner_data
(
    id INT(11) NOT NULL
  , banner_id INT(11) NOT NULL
  , type INT(11) NOT NULL
  , group_id INT(11) NOT NULL
  , transition INT(11) NOT NULL
  , priority INT(11) NOT NULL
  , condition_value INT(11) NOT NULL
  , start_date TEXT NOT NULL
  , end_date TEXT NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 103,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `banner_data_0_group_id` on table `banner_data`
--
ALTER TABLE banner_data
ADD INDEX banner_data_0_group_id (group_id);

--
-- Create table `background_offset_data`
--
CREATE TABLE background_offset_data
(
    id INT(11) NOT NULL
  , bg_id INT(11) NOT NULL
  , bg_sub INT(11) NOT NULL
  , offset_id INT(11) NOT NULL
  , pos_x INT(11) NOT NULL
  , pos_y INT(11) NOT NULL
  , width INT(11) NOT NULL
  , height INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1260,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `bg_id` on table `background_offset_data`
--
ALTER TABLE background_offset_data
ADD UNIQUE INDEX bg_id (bg_id, bg_sub, offset_id);

--
-- Create index `background_offset_data_0_bg_id_1_bg_sub` on table `background_offset_data`
--
ALTER TABLE background_offset_data
ADD INDEX background_offset_data_0_bg_id_1_bg_sub (bg_id, bg_sub);

--
-- Create table `background_data`
--
CREATE TABLE background_data
(
    id INT(11) NOT NULL
  , bg_id INT(11) NOT NULL
  , bg_sub INT(11) NOT NULL
  , cue_name TEXT NOT NULL
  , sheet_name TEXT NOT NULL
  , bus_param_set_name TEXT NOT NULL
  , pos_x INT(11) NOT NULL
  , pos_y INT(11) NOT NULL
  , width INT(11) NOT NULL
  , height INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 207,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `background_data_0_bg_id_1_bg_sub` on table `background_data`
--
ALTER TABLE background_data
ADD UNIQUE INDEX background_data_0_bg_id_1_bg_sub (bg_id, bg_sub);

--
-- Create table `available_skill_set`
--
CREATE TABLE available_skill_set
(
    id INT(11) NOT NULL
  , available_skill_set_id INT(11) NOT NULL
  , skill_id INT(11) NOT NULL
  , need_rank INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 100,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `available_skill_set_0_available_skill_set_id` on table `available_skill_set`
--
ALTER TABLE available_skill_set
ADD INDEX available_skill_set_0_available_skill_set_id (available_skill_set_id);

--
-- Create table `audio_story_effect`
--
CREATE TABLE audio_story_effect
(
    id INT(11) NOT NULL
  , effect_name TEXT NOT NULL
  , cue_name TEXT NOT NULL
  , cue_sheet TEXT NOT NULL
  , loop_set INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1365,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `audio_story_effect_0_effect_name` on table `audio_story_effect`
--
ALTER TABLE audio_story_effect
ADD UNIQUE INDEX audio_story_effect_0_effect_name USING HASH (effect_name);

--
-- Create table `audio_ignored_cue_on_highspeed`
--
CREATE TABLE audio_ignored_cue_on_highspeed
(
    id INT(11) NOT NULL
  , cue_name VARCHAR(300) NOT NULL
  , cue_sheet VARCHAR(300) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 2340,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `audio_ignored_cue_on_highspeed_0_cue_name_1_cue_sheet` on table `audio_ignored_cue_on_highspeed`
--
ALTER TABLE audio_ignored_cue_on_highspeed
ADD INDEX audio_ignored_cue_on_highspeed_0_cue_name_1_cue_sheet (cue_name, cue_sheet);

--
-- Create table `audio_cuesheet`
--
CREATE TABLE audio_cuesheet
(
    id INT(11) NOT NULL
  , cue_sheet TEXT NOT NULL
  , attribute INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1365,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `audio_cuesheet_0_attribute` on table `audio_cuesheet`
--
ALTER TABLE audio_cuesheet
ADD INDEX audio_cuesheet_0_attribute (attribute);

--
-- Create table `audience_impostor_lottery`
--
CREATE TABLE audience_impostor_lottery
(
    group_id INT(11) NOT NULL
  , pattern INT(11) NOT NULL
  , asset_id INT(11) NOT NULL
  , odds INT(11) NOT NULL
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 124,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `audience_impostor_lottery_0_group_id_1_pattern` on table `audience_impostor_lottery`
--
ALTER TABLE audience_impostor_lottery
ADD INDEX audience_impostor_lottery_0_group_id_1_pattern (group_id, pattern);

--
-- Create table `audience_impostor_color_set`
--
CREATE TABLE audience_impostor_color_set
(
    color_group_id INT(11) NOT NULL
  , color TEXT NOT NULL
  , odds INT(11) NOT NULL
)
ENGINE = INNODB,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `audience_impostor_color_set_0_color_group_id` on table `audience_impostor_color_set`
--
ALTER TABLE audience_impostor_color_set
ADD INDEX audience_impostor_color_set_0_color_group_id (color_group_id);

--
-- Create table `audience_impostor`
--
CREATE TABLE audience_impostor
(
    scene_type INT(11) NOT NULL
  , season INT(11) NOT NULL
  , weather INT(11) NOT NULL
  , group_id INT(11) NOT NULL
  , pattern_1 INT(11) NOT NULL
  , pattern_2 INT(11) NOT NULL
  , pattern_3 INT(11) NOT NULL
  , pattern_4 INT(11) NOT NULL
  , pattern_5 INT(11) NOT NULL
  , pattern_6 INT(11) NOT NULL
  , pattern_7 INT(11) NOT NULL
  , pattern_8 INT(11) NOT NULL
  , pattern_9 INT(11) NOT NULL
  , pattern_10 INT(11) NOT NULL
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 512,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create index `audience_impostor_0_season_1_weather` on table `audience_impostor`
--
ALTER TABLE audience_impostor
ADD INDEX audience_impostor_0_season_1_weather (season, weather);

--
-- Create table `audience_hair_color_set`
--
CREATE TABLE audience_hair_color_set
(
    id INT(11) NOT NULL
  , hair_color_r1 TEXT NOT NULL
  , hair_color_r2 TEXT NOT NULL
  , hair_color_g1 TEXT NOT NULL
  , hair_color_g2 TEXT NOT NULL
  , hair_color_b1 TEXT NOT NULL
  , hair_color_b2 TEXT NOT NULL
  , hair_toon_color_r1 TEXT NOT NULL
  , hair_toon_color_r2 TEXT NOT NULL
  , hair_toon_color_g1 TEXT NOT NULL
  , hair_toon_color_g2 TEXT NOT NULL
  , hair_toon_color_b1 TEXT NOT NULL
  , hair_toon_color_b2 TEXT NOT NULL
  , mayu_color_r1 TEXT NOT NULL
  , mayu_color_r2 TEXT NOT NULL
  , mayu_color_g1 TEXT NOT NULL
  , mayu_color_g2 TEXT NOT NULL
  , mayu_color_b1 TEXT NOT NULL
  , mayu_color_b2 TEXT NOT NULL
  , mayu_toon_color_r1 TEXT NOT NULL
  , mayu_toon_color_r2 TEXT NOT NULL
  , mayu_toon_color_g1 TEXT NOT NULL
  , mayu_toon_color_g2 TEXT NOT NULL
  , mayu_toon_color_b1 TEXT NOT NULL
  , mayu_toon_color_b2 TEXT NOT NULL
  , eye_color_r1 TEXT NOT NULL
  , eye_color_r2 TEXT NOT NULL
  , eye_color_g1 TEXT NOT NULL
  , eye_color_g2 TEXT NOT NULL
  , eye_color_b1 TEXT NOT NULL
  , eye_color_b2 TEXT NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 630,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `audience_dress_color_set`
--
CREATE TABLE audience_dress_color_set
(
    id INT(11) NOT NULL
  , color_r1 TEXT NOT NULL
  , color_r2 TEXT NOT NULL
  , color_g1 TEXT NOT NULL
  , color_g2 TEXT NOT NULL
  , color_b1 TEXT NOT NULL
  , color_b2 TEXT NOT NULL
  , toon_color_r1 TEXT NOT NULL
  , toon_color_r2 TEXT NOT NULL
  , toon_color_g1 TEXT NOT NULL
  , toon_color_g2 TEXT NOT NULL
  , toon_color_b1 TEXT NOT NULL
  , toon_color_b2 TEXT NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 210,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `audience_data`
--
CREATE TABLE audience_data
(
    audience_id INT(11) NOT NULL
  , chara_face_model INT(11) NOT NULL
  , chara_skin_color INT(11) NOT NULL
  , chara_hair_model INT(11) NOT NULL
  , chara_hair_color INT(11) NOT NULL
  , prop_id_1 INT(11) NOT NULL
  , prop_attach_node_name_type_1 INT(11) NOT NULL
  , prop_id_2 INT(11) NOT NULL
  , prop_attach_node_name_type_2 INT(11) NOT NULL
  , chara_height INT(11) NOT NULL
  , shape INT(11) NOT NULL
  , chara_bust_size INT(11) NOT NULL
  , dress_id INT(11) NOT NULL
  , dress_color_id INT(11) NOT NULL
  , PRIMARY KEY (audience_id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 210,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `announce_support_card`
--
CREATE TABLE announce_support_card
(
    id INT(11) NOT NULL
  , type INT(11) NOT NULL
  , cuts_pattern INT(11) NOT NULL
  , support_card_id_a INT(11) NOT NULL
  , support_card_id_b INT(11) NOT NULL
  , support_card_id_c INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 630,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `announce_event`
--
CREATE TABLE announce_event
(
    id INT(11) NOT NULL
  , cue_name TEXT NOT NULL
  , cue_sheet_name TEXT NOT NULL
  , voice_text_asset INT(11) NOT NULL
  , start_date INT(11) NOT NULL
  , end_date INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 1820,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `announce_data`
--
CREATE TABLE announce_data
(
    id INT(11) NOT NULL
  , announce_type INT(11) NOT NULL
  , announce_id INT(11) NOT NULL
  , priority INT(11) NOT NULL
  , start_date INT(11) NOT NULL
  , end_date INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 268,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;

--
-- Create table `announce_character`
--
CREATE TABLE announce_character
(
    id INT(11) NOT NULL
  , movie_id INT(11) NOT NULL
  , can_end_second INT(11) NOT NULL
  , PRIMARY KEY (id)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 468,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_general_ci;