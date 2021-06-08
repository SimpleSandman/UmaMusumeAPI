-- 
-- Set character set the client will use to send SQL statements to the server
--
SET NAMES 'utf8mb4';

--
-- Set default database
--
USE umamusume;

--
-- Drop view `vw_basic_chara_data_info`
--
DROP VIEW IF EXISTS vw_basic_chara_data_info CASCADE;

--
-- Drop view `vw_basic_dress_data_info`
--
DROP VIEW IF EXISTS vw_basic_dress_data_info CASCADE;

--
-- Drop view `vw_basic_gacha_data_info`
--
DROP VIEW IF EXISTS vw_basic_gacha_data_info CASCADE;

--
-- Drop view `vw_basic_gift_message_info`
--
DROP VIEW IF EXISTS vw_basic_gift_message_info CASCADE;

--
-- Drop view `vw_basic_item_data_info`
--
DROP VIEW IF EXISTS vw_basic_item_data_info CASCADE;

--
-- Drop view `vw_basic_item_exchange_info`
--
DROP VIEW IF EXISTS vw_basic_item_exchange_info CASCADE;

--
-- Drop view `vw_basic_item_exchange_top_info`
--
DROP VIEW IF EXISTS vw_basic_item_exchange_top_info CASCADE;

--
-- Drop view `vw_basic_live_data_info`
--
DROP VIEW IF EXISTS vw_basic_live_data_info CASCADE;

--
-- Drop view `vw_basic_login_bonus_data_info`
--
DROP VIEW IF EXISTS vw_basic_login_bonus_data_info CASCADE;

--
-- Drop view `vw_basic_main_story_data_info`
--
DROP VIEW IF EXISTS vw_basic_main_story_data_info CASCADE;

--
-- Drop view `vw_basic_mission_data_info`
--
DROP VIEW IF EXISTS vw_basic_mission_data_info CASCADE;

--
-- Drop view `vw_basic_mob_data_info`
--
DROP VIEW IF EXISTS vw_basic_mob_data_info CASCADE;

--
-- Drop view `vw_basic_piece_data_info`
--
DROP VIEW IF EXISTS vw_basic_piece_data_info CASCADE;

--
-- Drop view `vw_basic_race_info`
--
DROP VIEW IF EXISTS vw_basic_race_info CASCADE;

--
-- Drop view `vw_basic_race_instance_info`
--
DROP VIEW IF EXISTS vw_basic_race_instance_info CASCADE;

--
-- Drop view `vw_basic_race_track_info`
--
DROP VIEW IF EXISTS vw_basic_race_track_info CASCADE;

--
-- Drop view `vw_basic_single_mode_chara_grade_info`
--
DROP VIEW IF EXISTS vw_basic_single_mode_chara_grade_info CASCADE;

--
-- Drop view `vw_basic_skill_data_info`
--
DROP VIEW IF EXISTS vw_basic_skill_data_info CASCADE;

--
-- Drop view `vw_basic_story_event_data_info`
--
DROP VIEW IF EXISTS vw_basic_story_event_data_info CASCADE;

--
-- Drop view `vw_basic_story_event_mission_info`
--
DROP VIEW IF EXISTS vw_basic_story_event_mission_info CASCADE;

--
-- Drop view `vw_basic_story_event_story_data_info`
--
DROP VIEW IF EXISTS vw_basic_story_event_story_data_info CASCADE;

--
-- Drop view `vw_basic_support_card_data_info`
--
DROP VIEW IF EXISTS vw_basic_support_card_data_info CASCADE;

--
-- Drop view `vw_basic_support_card_unique_effect_info`
--
DROP VIEW IF EXISTS vw_basic_support_card_unique_effect_info CASCADE;

--
-- Drop view `vw_basic_team_stadium_score_bonus_info`
--
DROP VIEW IF EXISTS vw_basic_team_stadium_score_bonus_info CASCADE;

--
-- Drop view `vw_error_messages`
--
DROP VIEW IF EXISTS vw_error_messages CASCADE;

--
-- Drop view `vw_nice_chara_bio_info`
--
DROP VIEW IF EXISTS vw_nice_chara_bio_info CASCADE;

--
-- Drop view `vw_nice_chara_data_info`
--
DROP VIEW IF EXISTS vw_nice_chara_data_info CASCADE;

--
-- Drop view `vw_nice_item_names_comments_info`
--
DROP VIEW IF EXISTS vw_nice_item_names_comments_info CASCADE;

--
-- Drop view `vw_nice_objectives_info`
--
DROP VIEW IF EXISTS vw_nice_objectives_info CASCADE;

--
-- Drop view `vw_nice_race_info`
--
DROP VIEW IF EXISTS vw_nice_race_info CASCADE;

--
-- Drop view `vw_succession_relation_member_types`
--
DROP VIEW IF EXISTS vw_succession_relation_member_types CASCADE;

--
-- Drop view `vw_tutorial_messages`
--
DROP VIEW IF EXISTS vw_tutorial_messages CASCADE;

--
-- Set default database
--
USE umamusume;

--
-- Create view `vw_tutorial_messages`
--
CREATE
VIEW vw_tutorial_messages
AS
SELECT `text_data`.`id` AS `tutorial_id`
     , `text_data`.`index` AS `tutorial_index`
     , `text_data`.`text` AS `tutorial_text`
FROM `text_data`
WHERE `text_data`.`category` = 3;

--
-- Create view `vw_succession_relation_member_types`
--
CREATE
VIEW vw_succession_relation_member_types
AS
SELECT `srm`.`id` AS `srm_id`
     , `srm`.`chara_id` AS `chara_id`
     , `srm`.`relation_type` AS `relation_type`
     , `sr`.`relation_point` AS `relation_point`
FROM (`succession_relation_member` `srm`
    JOIN `succession_relation` `sr`
        ON (`srm`.`relation_type` = `sr`.`relation_type`))
ORDER BY `srm`.`chara_id`
       , `sr`.`relation_type`;

--
-- Create view `vw_nice_race_info`
--
CREATE
VIEW vw_nice_race_info
AS
SELECT `race_instance`.`id` AS `race_instance_id`
     , `race_instance`.`race_id` AS `race_id`
     , `race`.`group` AS `group`
     , `race`.`grade` AS `grade`
     , `race`.`course_set` AS `course_set`
     , `race`.`entry_num` AS `entry_num`
     , `course`.`race_track_id` AS `race_track_id`
     , `course`.`distance` AS `distance`
     , `course`.`ground` AS `terrain`
     , `course`.`inout` AS `course`
     , `course`.`turn` AS `direction`
     , `program`.`month` AS `month`
     , `program`.`half` AS `half`
     , `program`.`need_fan_count` AS `required_fans`
     , `program`.`race_permission` AS `class`
     , `fan_sets`.`fan_count` AS `fan_count`
FROM ((((`race_instance`
    LEFT JOIN `race`
        ON (`race`.`id` = `race_instance`.`race_id`))
    LEFT JOIN `race_course_set` `course`
        ON (`course`.`id` = `race`.`course_set`))
    LEFT JOIN `single_mode_program` `program`
        ON (`program`.`race_instance_id` = `race_instance`.`id`
                AND `program`.`base_program_id` = 0))
    LEFT JOIN `single_mode_fan_count` `fan_sets`
        ON (`program`.`fan_set_id` = `fan_sets`.`fan_set_id`
                AND `fan_sets`.`order` = 1));

--
-- Create view `vw_nice_objectives_info`
--
CREATE
VIEW vw_nice_objectives_info
AS
SELECT `route`.`id` AS `route_id`
     , `route`.`race_set_id` AS `race_set_id`
     , `route`.`target_type` AS `target_type`
     , `route`.`sort_id` AS `sort_id`
     , `route`.`turn` AS `turn`
     , `route`.`race_type` AS `race_type`
     , `route`.`condition_type` AS `condition_type`
     , `route`.`condition_id` AS `condition_id`
     , `route`.`condition_value_1` AS `condition_value_1`
     , `route`.`condition_value_2` AS `condition_value_2`
     , `route`.`determine_race` AS `determine_race`
     , `route`.`determine_race_flag` AS `determine_race_flag`
     , `single_mode_program`.`race_instance_id` AS `race_instance_id`
FROM (`single_mode_route_race` `route`
    LEFT JOIN `single_mode_program`
        ON (`single_mode_program`.`id` = `route`.`condition_id`));

--
-- Create view `vw_nice_item_names_comments_info`
--
CREATE
VIEW vw_nice_item_names_comments_info
AS
SELECT `i_data`.`id` AS `item_id`
     , `txt_name`.`text` AS `item_name`
     , `txt_comment`.`text` AS `item_comment`
     , `txt_comment_2`.`text` AS `item_comment_2`
FROM (((`item_data` `i_data`
    JOIN `text_data` `txt_name`
        ON (`i_data`.`id` = `txt_name`.`index`))
    JOIN `text_data` `txt_comment`
        ON (`i_data`.`id` = `txt_comment`.`index`))
    LEFT JOIN `text_data` `txt_comment_2`
        ON (`i_data`.`id` = `txt_comment_2`.`index`
                AND `txt_comment_2`.`category` = 25))
WHERE `txt_name`.`category` = 23
    AND `txt_comment`.`category` = 24;

--
-- Create view `vw_nice_chara_data_info`
--
CREATE
VIEW vw_nice_chara_data_info
AS
SELECT `card_data`.`id` AS `card_id`
     , `card_data`.`chara_id` AS `chara_id`
     , `card_data`.`default_rarity` AS `default_rarity`
     , `card_data`.`talent_speed` AS `talent_speed`
     , `card_data`.`talent_stamina` AS `talent_stamina`
     , `card_data`.`talent_pow` AS `talent_pow`
     , `card_data`.`talent_guts` AS `talent_guts`
     , `card_data`.`talent_wiz` AS `talent_wiz`
     , `card_data`.`limited_chara` AS `limited_chara`
     , `r1`.`speed` AS `speed1`
     , `r1`.`stamina` AS `stamina1`
     , `r1`.`pow` AS `power1`
     , `r1`.`guts` AS `guts1`
     , `r1`.`wiz` AS `wisdom1`
     , `r2`.`speed` AS `speed2`
     , `r2`.`stamina` AS `stamina2`
     , `r2`.`pow` AS `power2`
     , `r2`.`guts` AS `guts2`
     , `r2`.`wiz` AS `wisdom2`
     , `r3`.`speed` AS `speed3`
     , `r3`.`stamina` AS `stamina3`
     , `r3`.`pow` AS `power3`
     , `r3`.`guts` AS `guts3`
     , `r3`.`wiz` AS `wisdom3`
     , `r4`.`speed` AS `speed4`
     , `r4`.`stamina` AS `stamina4`
     , `r4`.`pow` AS `power4`
     , `r4`.`guts` AS `guts4`
     , `r4`.`wiz` AS `wisdom4`
     , `r5`.`speed` AS `speed5`
     , `r5`.`stamina` AS `stamina5`
     , `r5`.`pow` AS `power5`
     , `r5`.`guts` AS `guts5`
     , `r5`.`wiz` AS `wisdom5`
     , `r5`.`proper_ground_turf` AS `aptitude_turf`
     , `r5`.`proper_ground_dirt` AS `aptitude_dirt`
     , `r5`.`proper_distance_short` AS `aptitude_short`
     , `r5`.`proper_distance_mile` AS `aptitude_mile`
     , `r5`.`proper_distance_middle` AS `aptitude_middle`
     , `r5`.`proper_distance_long` AS `aptitude_long`
     , `r5`.`proper_running_style_nige` AS `aptitude_runner`
     , `r5`.`proper_running_style_senko` AS `aptitude_leader`
     , `r5`.`proper_running_style_sashi` AS `aptitude_betweener`
     , `r5`.`proper_running_style_oikomi` AS `aptitude_chaser`
FROM (((((`card_data`
    LEFT JOIN `card_rarity_data` `r1`
        ON (`r1`.`card_id` = `card_data`.`id`
                AND `r1`.`rarity` = 1))
    LEFT JOIN `card_rarity_data` `r2`
        ON (`r2`.`card_id` = `card_data`.`id`
                AND `r2`.`rarity` = 2))
    LEFT JOIN `card_rarity_data` `r3`
        ON (`r3`.`card_id` = `card_data`.`id`
                AND `r3`.`rarity` = 3))
    LEFT JOIN `card_rarity_data` `r4`
        ON (`r4`.`card_id` = `card_data`.`id`
                AND `r4`.`rarity` = 4))
    LEFT JOIN `card_rarity_data` `r5`
        ON (`r5`.`card_id` = `card_data`.`id`
                AND `r5`.`rarity` = 5));

--
-- Create view `vw_nice_chara_bio_info`
--
CREATE
VIEW vw_nice_chara_bio_info
AS
SELECT `chara_data`.`id` AS `chara_id`
     , `chara_data`.`birth_year` AS `birth_year`
     , `chara_data`.`birth_month` AS `birth_month`
     , `chara_data`.`birth_day` AS `birth_day`
     , `chara_data`.`sex` AS `sex`
     , `chara_data`.`image_color_main` AS `image_color_main`
     , `chara_data`.`image_color_sub` AS `image_color_sub`
     , `chara_data`.`ui_color_main` AS `ui_color_main`
     , `chara_data`.`ui_color_sub` AS `ui_color_sub`
     , `chara_data`.`ui_training_color_1` AS `ui_training_color_1`
     , `chara_data`.`ui_training_color_2` AS `ui_training_color_2`
     , `chara_data`.`ui_border_color` AS `ui_border_color`
     , `chara_data`.`ui_num_color_1` AS `ui_num_color_1`
     , `chara_data`.`ui_num_color_2` AS `ui_num_color_2`
     , `chara_data`.`ui_turn_color` AS `ui_turn_color`
     , `chara_data`.`ui_wipe_color_1` AS `ui_wipe_color_1`
     , `chara_data`.`ui_wipe_color_2` AS `ui_wipe_color_2`
     , `chara_data`.`ui_wipe_color_3` AS `ui_wipe_color_3`
     , `chara_data`.`ui_speech_color_1` AS `ui_speech_color_1`
     , `chara_data`.`ui_speech_color_2` AS `ui_speech_color_2`
     , `chara_data`.`ui_nameplate_color_1` AS `ui_nameplate_color_1`
     , `chara_data`.`ui_nameplate_color_2` AS `ui_nameplate_color_2`
     , `chara_data`.`height` AS `height`
     , `chara_data`.`bust` AS `bust`
     , `chara_data`.`scale` AS `scale`
     , `chara_data`.`skin` AS `skin`
     , `chara_data`.`shape` AS `shape`
     , `chara_data`.`socks` AS `socks`
     , `chara_data`.`personal_dress` AS `personal_dress`
     , `chara_data`.`tail_model_id` AS `tail_model_id`
     , `chara_data`.`race_running_type` AS `race_running_type`
     , `chara_data`.`ear_random_time_min` AS `ear_random_time_min`
     , `chara_data`.`ear_random_time_max` AS `ear_random_time_max`
     , `chara_data`.`tail_random_time_min` AS `tail_random_time_min`
     , `chara_data`.`tail_random_time_max` AS `tail_random_time_max`
     , `chara_data`.`story_ear_random_time_min` AS `story_ear_random_time_min`
     , `chara_data`.`story_ear_random_time_max` AS `story_ear_random_time_max`
     , `chara_data`.`story_tail_random_time_min` AS `story_tail_random_time_min`
     , `chara_data`.`story_tail_random_time_max` AS `story_tail_random_time_max`
     , `chara_data`.`attachment_model_id` AS `attachment_model_id`
     , `chara_data`.`mini_mayu_shader_type` AS `mini_mayu_shader_type`
     , `FROM_UNIXTIME_SECONDS`(`chara_data`.`start_date`) AS `start_date`
     , `chara_data`.`chara_category` AS `chara_category`
     , `ura_route`.`race_set_id` AS `ura_objectives`
FROM (`chara_data`
    LEFT JOIN `single_mode_route` `ura_route`
        ON (`ura_route`.`chara_id` = `chara_data`.`id`
                AND `ura_route`.`scenario_id` = 0));

--
-- Create view `vw_error_messages`
--
CREATE
VIEW vw_error_messages
AS
SELECT `text_data`.`id` AS `error_id`
     , `text_data`.`index` AS `error_index`
     , `text_data`.`text` AS `error_text`
FROM `text_data`
WHERE `text_data`.`category` = 1;

--
-- Create view `vw_basic_team_stadium_score_bonus_info`
--
CREATE
VIEW vw_basic_team_stadium_score_bonus_info
AS
SELECT `tssb`.`id` AS `team_stadium_score_bonus_id`
     , `tssb`.`priority` AS `priority`
     , `tssb`.`condition_type` AS `condition_type`
     , `tssb`.`condition_value_1` AS `condition_value_1`
     , `tssb`.`condition_value_2` AS `condition_value_2`
     , `tssb`.`score_rate` AS `score_rate`
     , `td`.`text` AS `score_bonus_name`
FROM (`team_stadium_score_bonus` `tssb`
    JOIN `text_data` `td`
        ON (`tssb`.`id` = `td`.`index`))
WHERE `td`.`category` = 148;

--
-- Create view `vw_basic_support_card_unique_effect_info`
--
CREATE
VIEW vw_basic_support_card_unique_effect_info
AS
SELECT `scue`.`id` AS `support_card_unique_effect_id`
     , `scue`.`lv` AS `lv`
     , `scue`.`type_0` AS `type_0`
     , `scue`.`value_0` AS `value_0`
     , `scue`.`type_1` AS `type_1`
     , `scue`.`value_1` AS `value_1`
     , `td`.`text` AS `score_bonus_name`
FROM (`support_card_unique_effect` `scue`
    JOIN `text_data` `td`
        ON (`scue`.`id` = `td`.`index`))
WHERE `td`.`category` = 155;

--
-- Create view `vw_basic_support_card_data_info`
--
CREATE
VIEW vw_basic_support_card_data_info
AS
SELECT `scd`.`id` AS `support_card_id`
     , `scd`.`chara_id` AS `chara_id`
     , `scd`.`rarity` AS `rarity`
     , `scd`.`skill_set_id` AS `skill_set_id`
     , `td`.`text` AS `support_card_title_name`
FROM (`support_card_data` `scd`
    JOIN `text_data` `td`
        ON (`scd`.`id` = `td`.`index`))
WHERE `td`.`category` = 76;

--
-- Create view `vw_basic_story_event_story_data_info`
--
CREATE
VIEW vw_basic_story_event_story_data_info
AS
SELECT `sesd`.`id` AS `story_event_story_id`
     , `sesd`.`story_event_id` AS `story_event_id`
     , `sesd`.`episode_index_id` AS `episode_index_id`
     , `sesd`.`need_point` AS `need_point`
     , `FROM_UNIXTIME_SECONDS`(`sesd`.`start_date`) AS `start_date`
     , `td`.`text` AS `story_event_episode_title`
FROM (`story_event_story_data` `sesd`
    JOIN `text_data` `td`
        ON (`sesd`.`id` = `td`.`index`))
WHERE `td`.`category` = 191;

--
-- Create view `vw_basic_story_event_mission_info`
--
CREATE
VIEW vw_basic_story_event_mission_info
AS
SELECT `sem`.`id` AS `story_event_mission_id`
     , `sem`.`story_event_id` AS `story_event_id`
     , `sem`.`mission_type` AS `mission_type`
     , `sem`.`step_group_id` AS `step_group_id`
     , `sem`.`item_category` AS `item_category`
     , `sem`.`item_id` AS `item_id`
     , `sem`.`item_num` AS `item_num`
     , `td`.`text` AS `story_event_mission_name`
FROM (`story_event_mission` `sem`
    JOIN `text_data` `td`
        ON (`sem`.`id` = `td`.`index`))
WHERE `td`.`category` = 190;

--
-- Create view `vw_basic_story_event_data_info`
--
CREATE
VIEW vw_basic_story_event_data_info
AS
SELECT `sed`.`story_event_id` AS `story_event_id`
     , `FROM_UNIXTIME_SECONDS`(`sed`.`notice_date`) AS `notice_date`
     , `FROM_UNIXTIME_SECONDS`(`sed`.`start_date`) AS `start_date`
     , `FROM_UNIXTIME_SECONDS`(`sed`.`middle_date_01`) AS `middle_date_01`
     , `FROM_UNIXTIME_SECONDS`(`sed`.`middle_date_02`) AS `middle_date_02`
     , `FROM_UNIXTIME_SECONDS`(`sed`.`ending_date`) AS `ending_date`
     , `FROM_UNIXTIME_SECONDS`(`sed`.`end_date`) AS `end_date`
     , `td`.`text` AS `story_event_title`
FROM (`story_event_data` `sed`
    JOIN `text_data` `td`
        ON (`sed`.`story_event_id` = `td`.`index`))
WHERE `td`.`category` = 189;

--
-- Create view `vw_basic_skill_data_info`
--
CREATE
VIEW vw_basic_skill_data_info
AS
SELECT `sd`.`id` AS `skill_id`
     , `sd`.`rarity` AS `rarity`
     , `sd`.`group_id` AS `group_id`
     , `sd`.`skill_category` AS `skill_category`
     , `sd`.`condition_1` AS `condition_1`
     , `sd`.`condition_2` AS `condition_2`
     , `td_name`.`text` AS `skill_name`
     , `td_desc`.`text` AS `skill_desc`
FROM ((`skill_data` `sd`
    JOIN `text_data` `td_name`
        ON (`sd`.`id` = `td_name`.`index`))
    JOIN `text_data` `td_desc`
        ON (`sd`.`id` = `td_desc`.`index`))
WHERE `td_name`.`category` = 47
    AND `td_desc`.`category` = 48;

--
-- Create view `vw_basic_single_mode_chara_grade_info`
--
CREATE
VIEW vw_basic_single_mode_chara_grade_info
AS
SELECT `smcg`.`id` AS `single_mode_chara_grade_id`
     , `smcg`.`win_num` AS `win_num`
     , `smcg`.`run_num` AS `run_num`
     , `smcg`.`need_fan_count` AS `need_fan_count`
     , `td`.`text` AS `single_mode_chara_grade_name`
FROM (`single_mode_chara_grade` `smcg`
    JOIN `text_data` `td`
        ON (`smcg`.`id` = `td`.`index`))
WHERE `td`.`category` = 121;

--
-- Create view `vw_basic_race_track_info`
--
CREATE
VIEW vw_basic_race_track_info
AS
SELECT `rt`.`id` AS `race_track_id`
     , `td`.`text` AS `race_track_name`
FROM (`race_track` `rt`
    JOIN `text_data` `td`
        ON (`rt`.`id` = `td`.`index`))
WHERE `td`.`category` = 34;

--
-- Create view `vw_basic_race_instance_info`
--
CREATE
VIEW vw_basic_race_instance_info
AS
SELECT `ri`.`id` AS `race_instance_id`
     , `ri`.`race_id` AS `race_id`
     , `td`.`text` AS `race_instance_name`
FROM (`race_instance` `ri`
    JOIN `text_data` `td`
        ON (`ri`.`id` = `td`.`index`))
WHERE `td`.`category` = 28;

--
-- Create view `vw_basic_race_info`
--
CREATE
VIEW vw_basic_race_info
AS
SELECT `r`.`id` AS `race_id`
     , `r`.`course_set` AS `race_course_set`
     , `td`.`text` AS `race_name`
FROM (`race` `r`
    JOIN `text_data` `td`
        ON (`r`.`id` = `td`.`index`))
WHERE `td`.`category` = 32;

--
-- Create view `vw_basic_piece_data_info`
--
CREATE
VIEW vw_basic_piece_data_info
AS
SELECT `pd`.`id` AS `piece_id`
     , `pd`.`item_place_id` AS `item_place_id`
     , CAST(`pd`.`start_date` AS DATETIME) AS `start_date`
     , CAST(`pd`.`end_date` AS DATETIME) AS `end_date`
     , `td`.`text` AS `character_piece_name`
FROM (`piece_data` `pd`
    JOIN `text_data` `td`
        ON (`pd`.`id` = `td`.`index`))
WHERE `td`.`category` = 113;

--
-- Create view `vw_basic_mob_data_info`
--
CREATE
VIEW vw_basic_mob_data_info
AS
SELECT `md`.`mob_id` AS `mob_id`
     , `md`.`chara_face_model` AS `chara_face_model`
     , `md`.`chara_hair_model` AS `chara_hair_model`
     , `md`.`chara_hair_color` AS `chara_hair_color`
     , `md`.`dress_id` AS `dress_id`
     , `md`.`dress_color_id` AS `dress_color_id`
     , `td`.`text` AS `mob_name`
FROM (`mob_data` `md`
    JOIN `text_data` `td`
        ON (`md`.`mob_id` = `td`.`index`))
WHERE `td`.`category` = 59;

--
-- Create view `vw_basic_mission_data_info`
--
CREATE
VIEW vw_basic_mission_data_info
AS
SELECT `md`.`id` AS `mission_id`
     , `md`.`mission_type` AS `mission_type`
     , CAST(`md`.`start_date` AS DATETIME) AS `start_date`
     , CAST(`md`.`end_date` AS DATETIME) AS `end_date`
     , `td`.`text` AS `mission_name`
FROM (`mission_data` `md`
    JOIN `text_data` `td`
        ON (`md`.`id` = `td`.`index`))
WHERE `td`.`category` = 67;

--
-- Create view `vw_basic_main_story_data_info`
--
CREATE
VIEW vw_basic_main_story_data_info
AS
SELECT `msd`.`id` AS `main_story_id`
     , `msd`.`part_id` AS `part_id`
     , `msd`.`episode_index` AS `episode_index`
     , `msd`.`story_number` AS `story_number`
     , `td`.`text` AS `main_story_episode_title`
FROM (`main_story_data` `msd`
    JOIN `text_data` `td`
        ON (`msd`.`id` = `td`.`index`))
WHERE `td`.`category` = 94;

--
-- Create view `vw_basic_login_bonus_data_info`
--
CREATE
VIEW vw_basic_login_bonus_data_info
AS
SELECT `lbd`.`id` AS `login_bonus_id`
     , `lbd`.`type` AS `type`
     , `lbd`.`count_num` AS `count_num`
     , CAST(`lbd`.`start_date` AS DATETIME) AS `start_date`
     , CAST(`lbd`.`end_date` AS DATETIME) AS `end_date`
     , `td`.`text` AS `login_bonus_name`
FROM (`login_bonus_data` `lbd`
    JOIN `text_data` `td`
        ON (`lbd`.`id` = `td`.`index`))
WHERE `td`.`category` = 70;

--
-- Create view `vw_basic_live_data_info`
--
CREATE
VIEW vw_basic_live_data_info
AS
SELECT `ld`.`music_id` AS `music_id`
     , `FROM_UNIXTIME_SECONDS`(`ld`.`start_date`) AS `start_date`
     , `FROM_UNIXTIME_SECONDS`(`ld`.`end_date`) AS `end_date`
     , `td`.`text` AS `song_name`
FROM (`live_data` `ld`
    JOIN `text_data` `td`
        ON (`ld`.`music_id` = `td`.`index`))
WHERE `td`.`category` = 16;

--
-- Create view `vw_basic_item_exchange_top_info`
--
CREATE
VIEW vw_basic_item_exchange_top_info
AS
SELECT `iet`.`id` AS `item_exchange_top_id`
     , `iet`.`item_exchange_disp_order` AS `item_exchange_disp_order`
     , `td_name`.`text` AS `item_exchange_name`
     , `td_desc`.`text` AS `item_exchange_description`
FROM ((`item_exchange_top` `iet`
    JOIN `text_data` `td_name`
        ON (`iet`.`id` = `td_name`.`index`))
    JOIN `text_data` `td_desc`
        ON (`iet`.`id` = `td_desc`.`index`))
WHERE `td_name`.`category` = 39
    AND `td_desc`.`category` = 40;

--
-- Create view `vw_basic_item_exchange_info`
--
CREATE
VIEW vw_basic_item_exchange_info
AS
SELECT `ie`.`id` AS `item_exchange_id`
     , `ie`.`item_exchange_top_id` AS `item_exchange_top_id`
     , `FROM_UNIXTIME_SECONDS`(`ie`.`start_date`) AS `start_date`
     , `FROM_UNIXTIME_SECONDS`(`ie`.`end_date`) AS `end_date`
     , `td`.`text` AS `item_exchange_condition`
FROM (`item_exchange` `ie`
    LEFT JOIN `text_data` `td`
        ON (`ie`.`id` = `td`.`index`
                AND `td`.`category` = 41));

--
-- Create view `vw_basic_item_data_info`
--
CREATE
VIEW vw_basic_item_data_info
AS
SELECT `item`.`id` AS `item_id`
     , `item`.`item_category` AS `item_category`
     , `item`.`group_id` AS `group_id`
     , `item`.`item_place_id` AS `item_place_id`
     , CAST(`item`.`start_date` AS DATETIME) AS `start_date`
     , CAST(`item`.`end_date` AS DATETIME) AS `end_date`
     , `td_item_name`.`text` AS `item_name`
FROM (`item_data` `item`
    JOIN `text_data` `td_item_name`
        ON (`item`.`id` = `td_item_name`.`index`))
WHERE `td_item_name`.`category` = 23;

--
-- Create view `vw_basic_gift_message_info`
--
CREATE
VIEW vw_basic_gift_message_info
AS
SELECT `gm`.`id` AS `gift_message_id`
     , `td`.`text` AS `gift_message`
FROM (`gift_message` `gm`
    JOIN `text_data` `td`
        ON (`gm`.`id` = `td`.`index`))
WHERE `td`.`category` = 64;

--
-- Create view `vw_basic_gacha_data_info`
--
CREATE
VIEW vw_basic_gacha_data_info
AS
SELECT `gd`.`id` AS `gacha_id`
     , `gd`.`card_type` AS `card_type`
     , `gd`.`daily_pay_cost` AS `daily_pay_cost`
     , `gd`.`only_once_flag` AS `only_once_flag`
     , `gd`.`cost_type` AS `cost_type`
     , `gd`.`cost_single` AS `cost_single`
     , `FROM_UNIXTIME_SECONDS`(`gd`.`start_date`) AS `start_date`
     , `FROM_UNIXTIME_SECONDS`(`gd`.`end_date`) AS `end_date`
     , `FROM_UNIXTIME_SECONDS`(`gfc`.`start_date`) AS `free_campaign_start_date`
     , `FROM_UNIXTIME_SECONDS`(`gfc`.`end_date`) AS `free_campaign_end_date`
     , `td`.`text` AS `gacha_text`
FROM ((`gacha_data` `gd`
    JOIN `text_data` `td`
        ON (`gd`.`id` = `td`.`index`))
    LEFT JOIN `gacha_free_campaign` `gfc`
        ON (`gd`.`id` = `gfc`.`gacha_id`))
WHERE `td`.`category` = 13;

--
-- Create view `vw_basic_dress_data_info`
--
CREATE
VIEW vw_basic_dress_data_info
AS
SELECT `dd`.`id` AS `dress_id`
     , `dd`.`chara_id` AS `chara_id`
     , `td`.`text` AS `text`
     , `dd`.`dress_color_main` AS `dress_color_main`
     , `dd`.`dress_color_sub` AS `dress_color_sub`
FROM (`dress_data` `dd`
    LEFT JOIN `text_data` `td`
        ON (`dd`.`id` = `td`.`index`
                AND `td`.`category` = 14));

--
-- Create view `vw_basic_chara_data_info`
--
CREATE
VIEW vw_basic_chara_data_info
AS
SELECT `chara`.`id` AS `chara_id`
     , `card`.`id` AS `chara_version_id`
     , `FROM_UNIXTIME_SECONDS`(`chara`.`start_date`) AS `chara_start_date`
     , `td`.`text` AS `horse_name`
FROM ((`chara_data` `chara`
    JOIN `text_data` `td`
        ON (`chara`.`id` = `td`.`index`))
    LEFT JOIN `card_data` `card`
        ON (`chara`.`id` = `card`.`chara_id`))
WHERE `td`.`category` = 6;