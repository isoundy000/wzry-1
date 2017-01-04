﻿namespace CSProtocol
{
    using System;

    public enum CSCMD_ID_DEF
    {
        CSID_ACHIEVEHERO_REQ = 0x708,
        CSID_ACNT_QUITSETTLEUI_REQ = 0x1470,
        CSID_ACNT_REGISTER_REQ = 0x3f0,
        CSID_ACNT_VOICESTATE = 0x12f2,
        CSID_ACNTACTIVITYINFO_REQ = 0x9c4,
        CSID_ADD_NPC_REQ = 0x7df,
        CSID_ANTIDATA_REQ = 0xbb8,
        CSID_APPLY_JOIN_GUILD_REQ = 0x8ad,
        CSID_APPOINT_POSITION_REQ = 0x8c9,
        CSID_APPROVE_JOIN_GUILD_APPLY = 0x8b1,
        CSID_ASKINMULTGAME_REQ = 0x424,
        CSID_BAN_HERO_REQ = 0x145c,
        CSID_BATTLELIST_REQ = 0x70d,
        CSID_BUY_MATCHTICKET_REQ = 0x13f0,
        CSID_BUYHERO_REQ = 0x719,
        CSID_BUYHEROSKIN_REQ = 0x71b,
        CSID_CANCEL_SWAP_HERO_REQ = 0x146a,
        CSID_CHANGE_NAME_REQ = 0xc80,
        CSID_CHG_GUILD_HEADID_REQ = 0x8e0,
        CSID_CHG_GUILD_NOTICE_REQ = 0x8e2,
        CSID_CHGARENAFIGHTER_REQ = 0xb5b,
        CSID_CLEAN_OFFLINE_CHAT_REQ = 0x51c,
        CSID_CLIENTREPORT_TASK_DONE = 0x5e1,
        CSID_CLRCDLIMIT_REQ = 0x4ee,
        CSID_CLT_ACTION_STATISTICS = 0x138a,
        CSID_CLT_PERFORMANCE = 0x1388,
        CSID_CMD_ACNTCOUPONS = 0x47e,
        CSID_CMD_AKALIBUY = 0x57f,
        CSID_CMD_AKALIRANDOMZHEKOU = 0x581,
        CSID_CMD_AUTOREFRESH = 0x45e,
        CSID_CMD_BUY_SPECSALE = 0x481,
        CSID_CMD_CANCELDEFRIEND = 0x52f,
        CSID_CMD_CHAT_REQ = 0x514,
        CSID_CMD_CHEATCMD = 0x3f4,
        CSID_CMD_CHGSIGNATURE = 0x4a9,
        CSID_CMD_COINBUY = 0x45b,
        CSID_CMD_COUPONS_REWARDGET = 0x488,
        CSID_CMD_DEFRIEND = 0x52d,
        CSID_CMD_EQUIPENCHANT = 0x475,
        CSID_CMD_EQUIPSMELT = 0x474,
        CSID_CMD_EQUIPWEAR = 0x450,
        CSID_CMD_FIGHTHISTORY_REQ = 0x5a0,
        CSID_CMD_FIGHTHISTORYLIST_REQ = 0x5a1,
        CSID_CMD_FRIENDADD = 0x4b6,
        CSID_CMD_FRIENDADDCONFIRM = 0x4ba,
        CSID_CMD_FRIENDADDDENY = 0x4bc,
        CSID_CMD_FRIENDDEL = 0x4b8,
        CSID_CMD_FRIENDDONATEPOINT = 0x4c2,
        CSID_CMD_FRIENDDONATEPOINTALL = 0x4c6,
        CSID_CMD_FRIENDINVITEGAME = 0x4be,
        CSID_CMD_FRIENDINVITEINFO = 0x4cc,
        CSID_CMD_FRIENDLIST = 0x4b0,
        CSID_CMD_FRIENDRECALLPOINT = 0x4d4,
        CSID_CMD_FRIENDRECEIVEACHIEVE = 0x4c0,
        CSID_CMD_FRIENDREQLIST = 0x4b2,
        CSID_CMD_FRIREFUSERECALL = 0x52a,
        CSID_CMD_FUNCUNLOCK_REQ = 0x57a,
        CSID_CMD_GAINCHEST = 0x528,
        CSID_CMD_GAMELOGINREQ = 0x3ea,
        CSID_CMD_GAMELOGOUTREQ = 0x3f8,
        CSID_CMD_GEAR_ADVANCE = 0x47b,
        CSID_CMD_GEAR_LVLUP = 0x478,
        CSID_CMD_GEAR_LVLUPALL = 0x479,
        CSID_CMD_GET_CHAT_MSG_REQ = 0x515,
        CSID_CMD_GET_HORNMSG = 0x519,
        CSID_CMD_HEARTBEAT = 0x3e8,
        CSID_CMD_HERO_CONFIRM = 0x4da,
        CSID_CMD_HERO_WAKEOPT = 0x491,
        CSID_CMD_HEROADVANCE = 0x457,
        CSID_CMD_HORNUSE = 0x463,
        CSID_CMD_ITEMBUY = 0x465,
        CSID_CMD_ITEMCOMP = 0x456,
        CSID_CMD_ITEMSALE = 0x44d,
        CSID_CMD_LBSREMOVE = 0x534,
        CSID_CMD_LBSREPORT = 0x531,
        CSID_CMD_LBSSEARCH = 0x532,
        CSID_CMD_LICENSE_REQ = 0x546,
        CSID_CMD_LIKE_REQ = 0x535,
        CSID_CMD_LIST_FREC = 0x4d2,
        CSID_CMD_LOGINSYN_RSP = 0x3fb,
        CSID_CMD_MAILOPT = 0x578,
        CSID_CMD_MANUALREFRESH = 0x45f,
        CSID_CMD_NOTICE_INFO = 0x590,
        CSID_CMD_NOTICE_LIST = 0x58e,
        CSID_CMD_NOTICE_NEW = 0x58c,
        CSID_CMD_PKGQUERY = 0x454,
        CSID_CMD_PROPUSE = 0x453,
        CSID_CMD_RANDDRAW_REQ = 0x499,
        CSID_CMD_SALERECMD_BUY = 0x497,
        CSID_CMD_SEARCHPLAYER = 0x4b4,
        CSID_CMD_SHOPBUY = 0x459,
        CSID_CMD_SKILLUNLOCK_SEL = 0x48e,
        CSID_CMD_SYMBOL_BREAK = 0x484,
        CSID_CMD_SYMBOL_MAKE = 0x483,
        CSID_CMD_SYMBOLCOMP = 0x46a,
        CSID_CMD_SYMBOLNAMECHG = 0x461,
        CSID_CMD_SYMBOLOFF = 0x46f,
        CSID_CMD_SYMBOLPAGE_CLR = 0x48a,
        CSID_CMD_SYMBOLPAGESEL = 0x471,
        CSID_CMD_SYMBOLQUERY = 0x46c,
        CSID_CMD_SYMBOLRCMD_SEL = 0x49e,
        CSID_CMD_SYMBOLRCMD_WEAR = 0x49c,
        CSID_CMD_SYMBOLWEAR = 0x46e,
        CSID_CMD_TALENT_BUY = 0x48c,
        CSID_CMD_USEHONOR_REQ = 0x588,
        CSID_COIN_GET_PATH_REQ = 0x502,
        CSID_COMMONINFO_REPORT = 0xaf0,
        CSID_CONFIRM_SWAP_HERO_REQ = 0x1460,
        CSID_CREATE_GUILD_REQ = 0x8a1,
        CSID_CREATE_TEAM_REQ = 0x7e6,
        CSID_CREATEULTIGAMEREQ = 0x3fc,
        CSID_DEAL_GUILD_INVITE = 0x8b9,
        CSID_DEAL_SELF_RECOMMEND_REQ = 0x8d2,
        CSID_DIRECT_BUY_ITEM_REQ = 0x10cd,
        CSID_DRAWWEAL_REQ = 0x9c7,
        CSID_DYE_INBATTLE_NEWBIEBIT_REQ = 0x10d5,
        CSID_FIRE_GUILD_MEMBER_REQ = 0x8cc,
        CSID_FREEHERO_REQ = 0x716,
        CSID_GAMEDATA_REPORT = 0xaf1,
        CSID_GAMEDATA_REPORTOVER = 0xaf4,
        CSID_GAMELOG_REPORT = 0xaf2,
        CSID_GAMELOG_REPORTOVER = 0xaf5,
        CSID_GAMESVRPING = 0x4ed,
        CSID_GAMING_CCSYNC = 0x3ed,
        CSID_GAMING_CSSYNC = 0x3ec,
        CSID_GET_ACHIEVEMENT_REWARD_REQ = 0x1134,
        CSID_GET_ACNT_CREDIT_VALUE = 0x1456,
        CSID_GET_ACNT_DETAIL_INFO_REQ = 0xa2e,
        CSID_GET_ACNT_RANKINFO = 0xa32,
        CSID_GET_BURNING_PROGRESS_REQ = 0xa8c,
        CSID_GET_BURNING_REWARD_REQ = 0xa8e,
        CSID_GET_CHAPTER_REWARD_REQ = 0x420,
        CSID_GET_GREATMATCH_REQ = 0x1466,
        CSID_GET_GROUP_GUILD_ID_REQ = 0x8e9,
        CSID_GET_GUILD_APPLY_LIST_REQ = 0x8ab,
        CSID_GET_GUILD_DIVIDEND_REQ = 0x8d6,
        CSID_GET_GUILD_INFO_REQ = 0x89d,
        CSID_GET_GUILD_LIST_REQ = 0x899,
        CSID_GET_GUILD_MEMBER_GAME_STATE_REQ = 0x7f3,
        CSID_GET_GUILD_RECOMMEND_LIST_REQ = 0x8bd,
        CSID_GET_MATCHINFO_REQ = 0x13f2,
        CSID_GET_PREPARE_GUILD_INFO_REQ = 0x89f,
        CSID_GET_PREPARE_GUILD_LIST_REQ = 0x89b,
        CSID_GET_RANKING_ACNT_INFO_REQ = 0xa2c,
        CSID_GET_RANKING_LIST_REQ = 0xa2a,
        CSID_GET_RANKLIST_BY_SPECIAL_SCORE_REQ = 0xa35,
        CSID_GET_REWARDMATCH_INFO_REQ = 0x13f4,
        CSID_GET_SPECIAL_GUILD_RANK_INFO_REQ = 0xa37,
        CSID_GET_VIDEOFRAPS_REQ = 0x146c,
        CSID_GETARENADATA_REQ = 0xb59,
        CSID_GETARENAFIGHTHISTORY_REQ = 0xb5f,
        CSID_GETAWARDPOOL_REQ = 0x13ed,
        CSID_GETFRIEND_GAMESTATE_REQ = 0x1471,
        CSID_GETHUOYUEDUREWARD_REQ = 0x641,
        CSID_GETPVPLEVELREWARD_REQ = 0x64e,
        CSID_GETRANKREWARD_REQ = 0xb63,
        CSID_GETTOPFIGHTEROFARENA_REQ = 0xb5d,
        CSID_GUILD_BUILDING_UPGRADE_REQ = 0x8c3,
        CSID_GUILD_DONATE_REQ = 0x8d4,
        CSID_GUILD_INVITE_REQ = 0x8b5,
        CSID_GUILD_RECOMMEND_REQ = 0x8ba,
        CSID_GUILD_SELF_RECOMMEND_REQ = 0x8cf,
        CSID_GUILD_SIGNIN_REQ = 0x8e6,
        CSID_GUILD_SYMBOL_REQ = 0x8dd,
        CSID_HEADIMG_CHG_REQ = 0x11f9,
        CSID_HEADIMG_FLAGCLR_REQ = 0x11fb,
        CSID_INVITE_FRIEND_JOIN_ROOM_REQ = 0x7e1,
        CSID_INVITE_FRIEND_JOIN_TEAM_REQ = 0x7e8,
        CSID_INVITE_GUILD_MEMBER_JOIN_REQ = 0x7f2,
        CSID_INVITE_JOIN_GAME_RSP = 0x7e5,
        CSID_ISACCEPT_AIPLAYER_RSP = 0x415,
        CSID_JOIN_PREPARE_GUILD_REQ = 0x8a3,
        CSID_JOIN_TEAM_REQ = 0x145a,
        CSID_JOINARENA_REQ = 0xb57,
        CSID_JOINMULTIGAMEREQ = 0x1458,
        CSID_KFRAPLATERCHG_REQ = 0x448,
        CSID_KICKOUT_ROOM_MEMBER_REQ = 0x7e3,
        CSID_LEAVE_TEAM = 0x7eb,
        CSID_LUCKYDRAW_EXTERN_REQ = 0x12c3,
        CSID_LUCKYDRAW_REQ = 0x12c1,
        CSID_MATCH_REQ = 0x7da,
        CSID_MODIFY_GUILD_SETTING_REQ = 0x8a9,
        CSID_MULTGAME_DIE_REQ = 0x44a,
        CSID_MULTGAME_GAMEOVER = 0x438,
        CSID_MULTGAME_LOADFIN = 0x434,
        CSID_MULTGAME_LOADPROCESS = 0x43b,
        CSID_MULTGAME_RUNAWAY_REQ = 0x43e,
        CSID_OBSERVE_FRIEND_REQ = 0x1462,
        CSID_OBSERVE_GREAT_REQ = 0x1464,
        CSID_OFFINGRESTART_RSP = 0x411,
        CSID_OPER_HERO_REQ = 0x4d8,
        CSID_PRESENTHERO_REQ = 0x726,
        CSID_PRESENTSKIN_REQ = 0x728,
        CSID_PVE_REVIVE_REQ = 0x10cf,
        CSID_QQVIPINFO_REQ = 0x1068,
        CSID_QUIT_GUILD_REQ = 0x8b2,
        CSID_QUITMULTIGAMEREQ = 0x3ff,
        CSID_QUITOBSERVE_REQ = 0x146e,
        CSID_QUITSINGLEGAMEREQ = 0x422,
        CSID_RECOVER_SYSTEMEQUIP_REQ = 0x1453,
        CSID_RECOVERGAMEFRAP_REQ = 0x442,
        CSID_RECOVERGAMESUCC = 0x445,
        CSID_REJECT_GUILD_RECOMMEND = 0x8bf,
        CSID_RELAYHASHCHECK = 0x500,
        CSID_RELAYSVRPING = 0x4ec,
        CSID_REQUESTFRAPBOOTSINGLE = 0x40c,
        CSID_REQUESTFRAPBOOTTIMEOUT = 0x40d,
        CSID_RESET_BURNING_PROGRESS_REQ = 0xa90,
        CSID_REWARDMATCH_STATE_CHG_REQ = 0x13f6,
        CSID_ROOM_CHGMEMBERPOS_REQ = 0x7f1,
        CSID_ROOM_CHGPOS_CONFIRM_REQ = 0x7f5,
        CSID_ROOM_CONFIRM_REQ = 0x7ef,
        CSID_RSP_ACNT_TRANS_VISITORSVRDATA = 0x403,
        CSID_SEARCH_GUILD_REQ = 0x8b7,
        CSID_SEARCH_PREGUILD_REQ = 0x8c1,
        CSID_SECURE_INFO_START_REQ = 0x426,
        CSID_SELFDEFINE_CHATINFO_CHG_REQ = 0x1468,
        CSID_SELFDEFINE_HEROEQUIP_CHG_REQ = 0x1451,
        CSID_SEND_GUILD_MAIL_REQ = 0x596,
        CSID_SERVERTIME_REQ = 0xfa1,
        CSID_SET_ACNT_NEWBIE_TYPE_REQ = 0xa30,
        CSID_SET_GUILD_GROUP_OPENID_REQ = 0x8eb,
        CSID_SETBATTLELIST_OF_ARENA_REQ = 0xb54,
        CSID_SHARE_TLOG_REQ = 0x10d3,
        CSID_SINGLEGAMEFINREQ = 0x41c,
        CSID_SINGLEGAMESWEEPREQ = 0x41e,
        CSID_SKILLUPDATE_REQ = 0x713,
        CSID_START_MULTI_GAME_REQ = 0x7dd,
        CSID_STARTSINGLEGAMEREQ = 0x41a,
        CSID_SURRENDER_REQ = 0x1324,
        CSID_SWAP_HERO_REQ = 0x145e,
        CSID_TASKSUBMIT_REQ = 0x5de,
        CSID_TASKUPD_NTF = 0x5e0,
        CSID_TEAM_OPER_REQ = 0x7ec,
        CSID_TRANSDATA_RENAME_REQ = 0x1474,
        CSID_UPDATECLIENTBITS_NTF = 0xfa0,
        CSID_UPDNEWCLIENTBITS_NTF = 0xfa3,
        CSID_UPGRADE_GUILD_BY_COUPONS_REQ = 0x8e4,
        CSID_UPGRADESTAR_REQ = 0x710,
        CSID_UPHEROLVL_REQ = 0x720,
        CSID_UPLOADCLTLOG_NTF = 0x1477,
        CSID_USER_COMPLAINT_REQ = 0x10d1,
        CSID_USUALTASK_REQ = 0x5dc,
        CSID_WEAL_CONTENT_SHARE_DONE = 0x1472,
        CSID_WEAL_DATA_REQ = 0x9cb,
        CSID_WEARHEROSKIN_REQ = 0x71d,
        SCID_ACHIEVEHERO_RSP = 0x709,
        SCID_ACHIEVEMENT_DONE_DATA_CHG_NTF = 0x1133,
        SCID_ACHIEVEMENT_INFO_NTF = 0x1131,
        SCID_ACHIEVEMENT_STATE_CHG_NTF = 0x1132,
        SCID_ACNT_DETAILINFO_RSP = 0x57b,
        SCID_ACNT_HEAD_URL_CHG_NTF = 0x57c,
        SCID_ACNT_INFO_UPD = 0x3f2,
        SCID_ACNT_LEAVE_TEAM_RSP = 0x7ee,
        SCID_ACNT_RANKINFO_RSP = 0xa33,
        SCID_ACNT_REGISTER_RES = 0x3f1,
        SCID_ACNT_SELF_MSG_INFO_RSP = 0x57d,
        SCID_ACNTACTIVITYINFO_RSP = 0x9c5,
        SCID_ACNTHEROINFO_NTY = 0x70a,
        SCID_ACTIVITYENDDEPLETION_NTF = 0x9c6,
        SCID_ADD_GUILD_NTF = 0x8a6,
        SCID_ADD_NPC_RSP = 0x7e0,
        SCID_ADDHERO_NTY = 0x70c,
        SCID_ANTIDATA_SYN = 0xbb9,
        SCID_APPLY_JOIN_GUILD_RSP = 0x8ae,
        SCID_APPOINT_POSITION_RSP = 0x8ca,
        SCID_ASK_ACNT_TRANS_VISITORSVRDATA = 0x402,
        SCID_ASKINMULTGAME_RSP = 0x425,
        SCID_BAN_HERO_RSP = 0x145d,
        SCID_BATTLELIST_NTY = 0x70f,
        SCID_BATTLELIST_RSP = 0x70e,
        SCID_BUY_MATCHTICKET_RSP = 0x13f1,
        SCID_BUYHERO_RSP = 0x71a,
        SCID_BUYHEROSKIN_RSP = 0x71c,
        SCID_CANCEL_SWAP_HERO_RSP = 0x146b,
        SCID_CHANGE_NAME_RSP = 0xc81,
        SCID_CHG_GUILD_HEADID_RSP = 0x8e1,
        SCID_CHG_GUILD_NOTICE_RSP = 0x8e3,
        SCID_CHGARENAFIGHTER_RSP = 0xb5c,
        SCID_CLASSOFRANKDETAIL_NTF = 0xa28,
        SCID_CLRCDLIMIT_RSP = 0x4ef,
        SCID_CMD_ACNTCOUPONS = 0x47f,
        SCID_CMD_AKALIERROR = 0x580,
        SCID_CMD_AKALIRANDOMZHEKOU = 0x582,
        SCID_CMD_AKALISHOP_UPDATE = 0x583,
        SCID_CMD_AKALISHOPDETAIL = 0x57e,
        SCID_CMD_BANTIME_CHG = 0x413,
        SCID_CMD_BLACKLIST = 0x4d7,
        SCID_CMD_BUY_SPECSALE = 0x482,
        SCID_CMD_CANCELDEFRIEND = 0x530,
        SCID_CMD_CHAT_NTF = 0x516,
        SCID_CMD_CHGSIGNATURE = 0x4aa,
        SCID_CMD_COINBUY = 0x45c,
        SCID_CMD_COINDRAW_RESULT = 0x477,
        SCID_CMD_COUPONS_REWARDINFO = 0x489,
        SCID_CMD_DEFRIEND = 0x52e,
        SCID_CMD_EQUIPCHG = 0x452,
        SCID_CMD_EQUIPENCHANT = 0x476,
        SCID_CMD_FIGHTHISTORYLIST_RSP = 0x5a2,
        SCID_CMD_FRIENDADD = 0x4b7,
        SCID_CMD_FRIENDADDCONFIRM = 0x4bb,
        SCID_CMD_FRIENDADDDENY = 0x4bd,
        SCID_CMD_FRIENDDEL = 0x4b9,
        SCID_CMD_FRIENDDONATEPOINT = 0x4c3,
        SCID_CMD_FRIENDDONATEPOINTALL = 0x4c7,
        SCID_CMD_FRIENDINVITEGAME = 0x4bf,
        SCID_CMD_FRIENDINVITEINFO = 0x4cd,
        SCID_CMD_FRIENDLIST = 0x4b1,
        SCID_CMD_FRIENDRECALLPOINT = 0x4d5,
        SCID_CMD_FRIENDRECEIVEACHIEVE = 0x4c1,
        SCID_CMD_FRIENDREQLIST = 0x4b3,
        SCID_CMD_FRIREFUSERECALL = 0x52c,
        SCID_CMD_GAINCHEST = 0x529,
        SCID_CMD_GAMELOGINLIMIT = 0x412,
        SCID_CMD_GAMELOGINRSP = 0x3eb,
        SCID_CMD_GAMELOGOUTRSP = 0x3f9,
        SCID_CMD_GEAR_ADVANCE = 0x47c,
        SCID_CMD_GEAR_LEVELINFO = 0x47a,
        SCID_CMD_GET_HORNMSG = 0x51a,
        SCID_CMD_HERO_WAKECHG = 0x490,
        SCID_CMD_HERO_WAKESTEP = 0x492,
        SCID_CMD_HEROADVANCE = 0x458,
        SCID_CMD_HEROEXP_ADD = 0x70b,
        SCID_CMD_HEROWAKE_REWARD = 0x493,
        SCID_CMD_HONORINFO_RSP = 0x587,
        SCID_CMD_HONORINFOCHG_RSP = 0x586,
        SCID_CMD_HORNUSE = 0x464,
        SCID_CMD_ITEMADD = 0x44e,
        SCID_CMD_ITEMBUY = 0x466,
        SCID_CMD_ITEMDEL = 0x44f,
        SCID_CMD_LBSSEARCH = 0x533,
        SCID_CMD_LICENSE_RSP = 0x547,
        SCID_CMD_LIST_FREC = 0x4d3,
        SCID_CMD_LOGINFINISH_NTF = 0x3f5,
        SCID_CMD_LOGINSYN_REQ = 0x3fa,
        SCID_CMD_MAILOPT = 0x579,
        SCID_CMD_NOTICE_INFO = 0x591,
        SCID_CMD_NOTICE_LIST = 0x58f,
        SCID_CMD_NOTICE_NEW = 0x58d,
        SCID_CMD_NTF_CHGINTIMACY = 0x4c8,
        SCID_CMD_NTF_FRIEND_ADD = 0x4cf,
        SCID_CMD_NTF_FRIEND_DEL = 0x4d0,
        SCID_CMD_NTF_FRIEND_GAME_STATE = 0x1004,
        SCID_CMD_NTF_FRIEND_LOGIN_STATUS = 0x4d1,
        SCID_CMD_NTF_FRIEND_REQUEST = 0x4ce,
        SCID_CMD_NTF_RECALL_FRIEND = 0x4d6,
        SCID_CMD_NTF_REFUSERECALL = 0x52b,
        SCID_CMD_PROPUSE = 0x494,
        SCID_CMD_PROPUSE_GIFTGET = 0x47d,
        SCID_CMD_RANDDRAW_RSP = 0x49a,
        SCID_CMD_RELOGINNOW = 0x3f6,
        SCID_CMD_SALERECMD_BUY = 0x498,
        SCID_CMD_SEARCHPLAYER = 0x4b5,
        SCID_CMD_SHOPBUY = 0x45a,
        SCID_CMD_SHOPDETAIL = 0x460,
        SCID_CMD_SKILLUNLOCK_SEL = 0x48f,
        SCID_CMD_SPECIALDETAIL = 0x480,
        SCID_CMD_SYMBOL_BREAK = 0x486,
        SCID_CMD_SYMBOL_MAKE = 0x485,
        SCID_CMD_SYMBOLCHG = 0x470,
        SCID_CMD_SYMBOLCHG_LIST = 0x473,
        SCID_CMD_SYMBOLCOMP = 0x46b,
        SCID_CMD_SYMBOLDETAIL = 0x46d,
        SCID_CMD_SYMBOLNAMECHG = 0x462,
        SCID_CMD_SYMBOLPAGE_CLR = 0x48b,
        SCID_CMD_SYMBOLPAGESEL = 0x472,
        SCID_CMD_SYMBOLRCMD_SEL = 0x49f,
        SCID_CMD_SYMBOLRCMD_WEAR = 0x49d,
        SCID_CMD_TALENT_BUY = 0x48d,
        SCID_CMD_USEHONOR_RSP = 0x589,
        SCID_COIN_GET_PATH_RSP = 0x503,
        SCID_CREATE_GUILD_RSP = 0x8a2,
        SCID_CREATE_TVOIP_ROOM_NTF = 0xc1c,
        SCID_DAILY_ACTIVE_CHANGE_NTF = 0x8c8,
        SCID_DAILY_CHECK_DATA_NTF = 0x1194,
        SCID_DEAL_GUILD_INVITE_RSP = 0x8c0,
        SCID_DEAL_SELF_RECOMMEND_RSP = 0x8d3,
        SCID_DEFAULT_HERO_NTF = 0x4dc,
        SCID_DIRECT_BUY_ITEM_RSP = 0x10ce,
        SCID_DRAWWEAL_RSP = 0x9c8,
        SCID_DYE_INBATTLE_NEWBIEBIT_RSP = 0x10d6,
        SCID_ENTERTAINMENT_SYN_RAND_HERO_CNT = 0x138b,
        SCID_FIRE_GUILD_MEMBER_NTF = 0x8ce,
        SCID_FIRE_GUILD_MEMBER_RSP = 0x8cd,
        SCID_FRAPBOOT_SINGLE = 0x40a,
        SCID_FRAPBOOTINFO = 0x40b,
        SCID_FREEHERO_RSP = 0x717,
        SCID_FUNCTION_SWITCH_NTF = 0x100e,
        SCID_GAME_VIP_NTF = 0x11f8,
        SCID_GAMECONN_REDIRECT = 0x406,
        SCID_GAMELOGINDISPATCH = 0x3e9,
        SCID_GET_ACHIEVEMENT_REWARD_RSP = 0x1135,
        SCID_GET_ACNT_DETAIL_INFO_RSP = 0xa2f,
        SCID_GET_BURNING_PROGRESS_RSP = 0xa8d,
        SCID_GET_BURNING_REWARD_RSP = 0xa8f,
        SCID_GET_CHAPTER_REWARD_RSP = 0x421,
        SCID_GET_GREATMATCH_RSP = 0x1467,
        SCID_GET_GROUP_GUILD_ID_NTF = 0x8ea,
        SCID_GET_GUILD_APPLY_LIST_RSP = 0x8ac,
        SCID_GET_GUILD_DIVIDEND_RSP = 0x8d7,
        SCID_GET_GUILD_INFO_RSP = 0x89e,
        SCID_GET_GUILD_LIST_RSP = 0x89a,
        SCID_GET_GUILD_MEMBER_GAME_STATE_RSP = 0x7f4,
        SCID_GET_GUILD_RECOMMEND_LIST_RSP = 0x8be,
        SCID_GET_MATCHINFO_RSP = 0x13f3,
        SCID_GET_PREPARE_GUILD_INFO_RSP = 0x8a0,
        SCID_GET_PREPARE_GUILD_LIST_RSP = 0x89c,
        SCID_GET_RANKING_ACNT_INFO_RSP = 0xa2d,
        SCID_GET_RANKING_LIST_RSP = 0xa2b,
        SCID_GET_RANKLIST_BY_SPECIAL_SCORE_RSP = 0xa36,
        SCID_GET_REWARDMATCH_INFO_RSP = 0x13f5,
        SCID_GET_SPECIAL_GUILD_RANK_INFO_RSP = 0xa38,
        SCID_GET_VIDEOFRAPS_RSP = 0x146d,
        SCID_GETARENADATA_RSP = 0xb5a,
        SCID_GETARENAFIGHTHISTORY_RSP = 0xb60,
        SCID_GETAWARDPOOL_RSP = 0x13ee,
        SCID_GETHUOYUEDUREWARD_RSP = 0x642,
        SCID_GETPVPLEVELREWARD_RSP = 0x64f,
        SCID_GETRANKREWARD_RSP = 0xb64,
        SCID_GETTOPFIGHTEROFARENA_RSP = 0xb5e,
        SCID_GM_ADDALLSKIN_RSP = 0x725,
        SCID_GMADDHERO_RSP = 0x715,
        SCID_GMUNLOCKHEROPVP_RSP = 0x718,
        SCID_GUILD_ACTIVE_CHANGE_NTF = 0x8c7,
        SCID_GUILD_BUILDING_LEVEL_CHANGE_NTF = 0x8c5,
        SCID_GUILD_BUILDING_UPGRADE_RSP = 0x8c4,
        SCID_GUILD_CONSTRUCT_CHG = 0x8df,
        SCID_GUILD_CROSS_DAY_NTF = 0x8d8,
        SCID_GUILD_CROSS_WEEK_NTF = 0x8d9,
        SCID_GUILD_DONATE_RSP = 0x8d5,
        SCID_GUILD_INVITE_RSP = 0x8b6,
        SCID_GUILD_MONEY_CHANGE_NTF = 0x8c6,
        SCID_GUILD_NAME_CHG_NTF = 0xc82,
        SCID_GUILD_POSITION_CHG_NTF = 0x8cb,
        SCID_GUILD_RANK_RESET_NTF = 0x8dc,
        SCID_GUILD_RECOMMEND_NTF = 0x8bc,
        SCID_GUILD_RECOMMEND_RSP = 0x8bb,
        SCID_GUILD_SEASON_RESET_NTF = 0x8e8,
        SCID_GUILD_SELF_RECOMMEND_NTF = 0x8d1,
        SCID_GUILD_SELF_RECOMMEND_RSP = 0x8d0,
        SCID_GUILD_SIGNIN_RSP = 0x8e7,
        SCID_GUILD_SYMBOL_RSP = 0x8de,
        SCID_GUILDREWARDPOINT_NTF = 0x1459,
        SCID_HANGUP_NTF = 0x44b,
        SCID_HEADIMG_CHG_RSP = 0x11fa,
        SCID_HEADIMG_FLAGCLR_RSP = 0x11fc,
        SCID_HEADIMG_LIST_SYNC = 0x11fe,
        SCID_HERO_CONFIRM_NTF = 0x4db,
        SCID_HERO_INFO_UPD = 0x712,
        SCID_HEROSKIN_ADD = 0x71f,
        SCID_HUOYUEDUINFO_NTF = 0x640,
        SCID_HUOYUEDUREWARDERR_NTF = 0x643,
        SCID_INVITE_FRIEND_JOIN_ROOM_RSP = 0x7e2,
        SCID_INVITE_FRIEND_JOIN_TEAM_RSP = 0x7e9,
        SCID_INVITE_JOIN_GAME_REQ = 0x7e4,
        SCID_ISACCEPT_AIPLAYER_REQ = 0x414,
        SCID_JOIN_GUILD_APPLY_NTF = 0x8af,
        SCID_JOIN_PREPARE_GUILD_NTF = 0x8a5,
        SCID_JOIN_PREPARE_GUILD_RSP = 0x8a4,
        SCID_JOIN_TEAM_RSP = 0x7e7,
        SCID_JOIN_TVOIP_ROOM_NTF = 0xc1d,
        SCID_JOINARENA_RSP = 0xb58,
        SCID_JOINMULTIGAMERSP = 0x3fe,
        SCID_KFRAPLATERCHG_NTF = 0x449,
        SCID_LIMITSKIN_ADD = 0x722,
        SCID_LIMITSKIN_DEL = 0x723,
        SCID_LUCKYDRAW_DATA_NTF = 0x12c0,
        SCID_LUCKYDRAW_EXTERN_RSP = 0x12c4,
        SCID_LUCKYDRAW_RSP = 0x12c2,
        SCID_MATCH_RSP = 0x7db,
        SCID_MATCHPOINT_NTF = 0x13ef,
        SCID_MATCHTEAM_DESTROY_NTF = 0x1455,
        SCID_MEMBER_ONLINE_NTF = 0x8a7,
        SCID_MEMBER_RANK_POINT_NTF = 0x8db,
        SCID_MEMBER_TOP_KDA_NTF = 0x8da,
        SCID_MODIFY_GUILD_SETTING_RSP = 0x8aa,
        SCID_MONTH_WEEK_CARD_USE_RSP = 0xa34,
        SCID_MULTGAME_BEGINADJUST = 0x42f,
        SCID_MULTGAME_BEGINBAN = 0x42d,
        SCID_MULTGAME_BEGINFIGHT = 0x435,
        SCID_MULTGAME_BEGINLOAD = 0x433,
        SCID_MULTGAME_BEGINPICK = 0x42e,
        SCID_MULTGAME_DISCONN_NTF = 0x446,
        SCID_MULTGAME_GAMEOVER = 0x439,
        SCID_MULTGAME_LOADPROCESS = 0x43c,
        SCID_MULTGAME_NTF_CLT_GAMEOVER = 0x43d,
        SCID_MULTGAME_RECONN_NTF = 0x447,
        SCID_MULTGAME_RUNAWAY_NTF = 0x440,
        SCID_MULTGAME_RUNAWAY_RSP = 0x43f,
        SCID_MULTGAME_SETTLEGAIN = 0x43a,
        SCID_MULTGAMEABORTNTF = 0x437,
        SCID_MULTGAMEREADYNTF = 0x436,
        SCID_MULTGAMERECOVERNTF = 0x441,
        SCID_NEW_MEMBER_JOIN_GULD_NTF = 0x8b0,
        SCID_NEWTASKGET_NTF = 0x5e3,
        SCID_NEXTFIRSTWINSEC_NTF = 0x501,
        SCID_NOTICE_HANGUP = 0x416,
        SCID_NTF_ACNT_CREDIT_VALUE = 0x1457,
        SCID_NTF_ACNT_LEVELUP = 0x3f3,
        SCID_NTF_ACNT_PVPLEVELUP = 0x3f7,
        SCID_NTF_ACNT_REGISTER = 0x3ef,
        SCID_NTF_ACNT_SNSNAME = 0x1007,
        SCID_NTF_ADDCURSEASONRECORD = 0xb65,
        SCID_NTF_ADDPASTSEASONRECORD = 0xb66,
        SCID_NTF_CLRSHOPBUYLIMIT = 0x45d,
        SCID_NTF_CLRSHOPREFRESH = 0x468,
        SCID_NTF_CONFIRM_SWAP_HERO = 0x1461,
        SCID_NTF_CUR_BAN_PICK_INFO = 0x145b,
        SCID_NTF_ERRCODE = 0x4a6,
        SCID_NTF_HEADIMG_ADD = 0x11ff,
        SCID_NTF_HEADIMG_CHG = 0x11fd,
        SCID_NTF_HEADIMG_DEL = 0x1200,
        SCID_NTF_NEWIEALLBITSYN = 0x4a8,
        SCID_NTF_NEWIEBITSYN = 0x4a7,
        SCID_NTF_PKGDETAIL = 0x455,
        SCID_NTF_RANDDRAW_SYNID = 0x49b,
        SCID_NTF_SHOPTIMEOUT = 0x467,
        SCID_NTF_SNS_FRIEND = 0x1005,
        SCID_NTF_SNS_NICKNAME = 0x1008,
        SCID_NTF_SWAP_HERO = 0x145f,
        SCID_NTF_VOICESTATE = 0x12f3,
        SCID_OBSERVE_FRIEND_RSP = 0x1463,
        SCID_OBSERVE_GREAT_RSP = 0x1465,
        SCID_OFFINGRESTART_REQ = 0x410,
        SCID_OFFLINE_CHAT_NTF = 0x51b,
        SCID_OPER_HERO_NTF = 0x4d9,
        SCID_PREPARE_GUILD_BREAK_NTF = 0x8a8,
        SCID_PRESENTHERO_RSP = 0x727,
        SCID_PRESENTSKIN_RSP = 0x729,
        SCID_PROP_MULTIPLE_NTF = 0x9cd,
        SCID_PVE_REVIVE_RSP = 0x10d0,
        SCID_PVPCHK_NTF_CLIENT = 0xaf3,
        SCID_QQVIPINFO_RSP = 0x1069,
        SCID_QUIT_GUILD_NTF = 0x8b4,
        SCID_QUIT_GUILD_RSP = 0x8b3,
        SCID_QUITMULTIGAMERSP = 0x400,
        SCID_QUITOBSERVE_RSP = 0x146f,
        SCID_QUITSINGLEGAMERSP = 0x423,
        SCID_RANKCURSEASONHISTORY_NTF = 0xb61,
        SCID_RANKPASTSEASONHISTORY_NTF = 0xb62,
        SCID_RECONNGAME_NTF = 0x444,
        SCID_RECOVER_SYSTEMEQUIP_RSP = 0x1454,
        SCID_RECOVERGAMEFRAP_RSP = 0x443,
        SCID_RELAYHASHCHECK = 0x504,
        SCID_RES_DATA_NTF = 0x9ce,
        SCID_RESET_BURNING_PROGRESS_RSP = 0xa91,
        SCID_REWARDMATCH_INFO_CHG_NTF = 0x13f7,
        SCID_ROLLING_MSG_NTF = 0x5aa,
        SCID_ROOM_CHGPOS_NTF = 0x7f6,
        SCID_ROOM_CONFIRM_RSP = 0x7f0,
        SCID_ROOM_STARTSINGLEGAME_NTF = 0x7dc,
        SCID_ROOMCHGNTF = 0x401,
        SCID_SEARCH_GUILD_RSP = 0x8b8,
        SCID_SEARCH_PREGUILD_RSP = 0x8c2,
        SCID_SELF_BEKICK_FROM_TEAM = 0x7ed,
        SCID_SELFDEFINE_CHATINFO_CHG_RSP = 0x1469,
        SCID_SELFDEFINE_HEROEQUIP_CHG_RSP = 0x1452,
        SCID_SEND_GUILD_MAIL_RSP = 0x597,
        SCID_SERVERTIME_RSP = 0xfa2,
        SCID_SET_ACNT_NEWBIE_TYPE_RSP = 0xa31,
        SCID_SET_GUILD_GROUP_OPENID_NTF = 0x8ec,
        SCID_SETBATTLELIST_OF_ARENA_RSP = 0xb55,
        SCID_SHARE_TLOG_RSP = 0x10d4,
        SCID_SINGLEGAMEFINRSP = 0x41d,
        SCID_SINGLEGAMESWEEPRSP = 0x41f,
        SCID_SKILLUPDATE_RSP = 0x714,
        SCID_SNS_FRIEND_CHG_PROFILE = 0x1006,
        SCID_START_MULTI_GAME_RSP = 0x7de,
        SCID_STARTSINGLEGAMERSP = 0x41b,
        SCID_SURRENDER_NTF = 0x1326,
        SCID_SURRENDER_RSP = 0x1325,
        SCID_TASKSUBMIT_RES = 0x5df,
        SCID_TEAM_CHG = 0x7ea,
        SCID_TRANSDATA_RENAME_NTF = 0x1473,
        SCID_TRANSDATA_RENAME_RES = 0x1475,
        SCID_UPDRANKINFO_NTF = 0xa29,
        SCID_UPGRADE_GUILD_BY_COUPONS_RSP = 0x8e5,
        SCID_UPGRADESTAR_RSP = 0x711,
        SCID_UPHEROLVL_RSP = 0x721,
        SCID_UPLOADCLTLOG_REQ = 0x1476,
        SCID_USEEXPCARD_NTF = 0x724,
        SCID_USER_COMPLAINT_RSP = 0x10d2,
        SCID_USUALTASK_RES = 0x5dd,
        SCID_USUALTASKDISCARD_RES = 0x5e2,
        SCID_WEAL_CON_DATA_NTF = 0x9ca,
        SCID_WEAL_DATA_NTF = 0x9cc,
        SCID_WEAL_EXCHANGE_RES = 0x9cf,
        SCID_WEAL_POINTDATA_NTF = 0x9d0,
        SCID_WEALDETAIL_NTF = 0x9c9,
        SCID_WEARHEROSKIN_RSP = 0x71e
    }
}
