using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFCaliber.Value;

namespace Caliber.Json.Accaunt
{
    public static partial class LogObject
    {
        // static Accaunt myDeserializedClass = JsonConvert.DeserializeObject<Accaunt>(myJsonResponse);
        public class Account
        {
            public int version { get; set; }
            public DateTime metaTime { get; set; }
            public string nickname { get; set; }
            public string selectedCardId { get; set; }
            public string selectedCardPresetId { get; set; }
            public List<object> modifiedCards { get; set; }
            public LockedCards lockedCards { get; set; }
            public Money money { get; set; }
            public int level { get; set; }
            public int nextLevelProgress { get; set; }
            public int totalXp { get; set; }
            public Access access { get; set; }
            public List<string> triggers { get; set; }
            public bool hasPremium { get; set; }
            public DateTime premiumExpiration { get; set; }
            public string currentUserbar { get; set; }
            public string currentHqStyle { get; set; }
            public BannedGameModes bannedGameModes { get; set; }
            public MatchCount matchCount { get; set; }
            public MatchesWon matchesWon { get; set; }
            public Settings settings { get; set; }
            public List<Quest> quests { get; set; }
            public List<ComplexQuest> complexQuests { get; set; }
            public DateTime lastQuestAssignDate { get; set; }
            public DateTime nextQuestAssignDate { get; set; }
            public DateTime nextWeeklyQuestAssignDate { get; set; }
            public DateTime nextHardQuestAssignDate { get; set; }
            public RerollPrice rerollPrice { get; set; }
            public Ribbons ribbons { get; set; }
            public Medals medals { get; set; }
            public PurchasedShopItems PurchasedShopItems { get; set; }
            public List<string> userbars { get; set; }
            public List<string> hqStyles { get; set; }
            public List<string> watchedVideos { get; set; }
            public int battlePassXp { get; set; }
            public bool hasBattlePassKey { get; set; }
            public List<LootBox> lootBoxes { get; set; }
            public List<RankedSeason> rankedSeasons { get; set; }
            public List<SpecialOffer> specialOffers { get; set; }
            public Quarters quarters { get; set; }
            public List<object> restrictions { get; set; }
            public List<Expedition> expeditions { get; set; }
        }
        public class Access
        {
            public long Enabled { get; set; }
            public long Visible { get; set; }
        }

        public class BannedGameModes
        {
        }

        public class Boosters
        {
        }

        public class CardSlot
        {
            public int MinLevel { get; set; }
            public int LevelType { get; set; }
            public List<int> Roles { get; set; }
        }

        public class ChaptersProgress
        {
            public string id { get; set; }
            public string visual { get; set; }
            public bool finished { get; set; }
            public bool hadPremiumWhenFinished { get; set; }
            public bool marked { get; set; }
            public Reward reward { get; set; }
            public List<QuestsProgress> questsProgress { get; set; }
            public PremiumReward premiumReward { get; set; }
        }

        public class ComplexQuest
        {
            public string id { get; set; }
            public string visual { get; set; }
            public int group { get; set; }
            public int currentChapterIdx { get; set; }
            public bool finished { get; set; }
            public bool marked { get; set; }
            public DateTime dueDate { get; set; }
            public bool prolonged { get; set; }
            public ProlongPrice prolongPrice { get; set; }
            public int prolongDuration { get; set; }
            public List<ChaptersProgress> chaptersProgress { get; set; }
        }

        public class Conditions
        {
            public List<string> PlayerRole { get; set; }
            public List<object> TargetPlayerRole { get; set; }
            public List<object> BotType { get; set; }
            public List<object> ItemType { get; set; }
            public List<string> MatchType { get; set; }
            public List<object> Additional { get; set; }
            public List<object> BuffType { get; set; }
            public List<object> TargetTeam { get; set; }
            public List<string> TargetDistance { get; set; }
            public List<object> RibbonType { get; set; }
        }

        public class ConsumablesBuyingAmount
        {
            public int StaminaRegenBooster { get; set; }
            public int HealthPack { get; set; }
            public int SpecialRevive { get; set; }
            public int ArmorPack { get; set; }
            public int AmmoPack { get; set; }
            public int SpecialReviveV2 { get; set; }
            public int DefendPointsBooster { get; set; }
            public int RandomBonus { get; set; }
            public int PerkTierUpgrade { get; set; }
        }

        public class Counter
        {
            public double target { get; set; }
            public double current { get; set; }
        }

        public class CurrentResearch
        {
            public string TechnologyLine { get; set; }
            public int TechnologyIndex { get; set; }
            public DateTime FinishTime { get; set; }
        }

        public class Expedition
        {
            public int Id { get; set; }
            public string CfgName { get; set; }
            public MapPosition MapPosition { get; set; }
            public string Visual { get; set; }
            public DateTime ExpireAt { get; set; }
            public DateTime CompleteAt { get; set; }
            public List<RewardSlot> RewardSlots { get; set; }
            public List<CardSlot> CardSlots { get; set; }
        }

        public class LockedCards
        {
        }

        public class LootBox
        {
            public string CfgName { get; set; }
            public int Count { get; set; }
            public bool LootBoxOpened { get; set; }
            public List<OpenedSlot> OpenedSlots { get; set; }
            public List<RolledSlot> RolledSlots { get; set; }
        }

        public class MapPosition
        {
            public int ZoneIndex { get; set; }
            public int ZoneX { get; set; }
            public int ZoneY { get; set; }
        }

        public class MatchCount
        {
            public int polygon { get; set; }
            public int pve { get; set; }
            public int pvp { get; set; }
            public int pvehard { get; set; }
            public int pvpve { get; set; }
            public int hacking { get; set; }
            public int onboarding { get; set; }
            public int pvpranked { get; set; }
            public int onslaughthard { get; set; }
            public int onslaughtnormal { get; set; }
            public int intercept { get; set; }
            public int defend { get; set; }
            public int onslaughteasy { get; set; }
        }

        public class MatchesWon
        {
            public int pve { get; set; }
            public int pvp { get; set; }
            public int pvehard { get; set; }
            public int pvpve { get; set; }
            public int hacking { get; set; }
            public int pvpranked { get; set; }
            public int onslaughthard { get; set; }
            public int onslaughtnormal { get; set; }
            public int intercept { get; set; }
            public int defend { get; set; }
            public int onslaughteasy { get; set; }
        }

        public class Medals
        {
            public int BotKill { get; set; }
            public int BotDoubleKill { get; set; }
            public int CleanKill { get; set; }
            public int Defender { get; set; }
            public int EnemySuppressed { get; set; }
            public int WinHardPVE { get; set; }
            public int DemolitionLight { get; set; }
            public int Assist { get; set; }
            public int BullsEye { get; set; }
            public int BotTripleKill { get; set; }
            public int TopDamage { get; set; }
            public int Revenge { get; set; }
            public int TopKill { get; set; }
            public int KillTheShooter { get; set; }
            public int SidearmKill { get; set; }
            public int JustScratch { get; set; }
            public int DebuffAssist { get; set; }
            public int CloseCall { get; set; }
            public int Reanimation { get; set; }
            public int FirstBlood { get; set; }
            public int TopRevive { get; set; }
            public int BlownAway { get; set; }
            public int ExplosiveKill { get; set; }
            public int LastBulletKill { get; set; }
            public int EnemySlowed { get; set; }
            public int ReinforceAlly { get; set; }
            public int BaseCapture { get; set; }
            public int BuffAssist { get; set; }
            public int Payback { get; set; }
            public int WinPVP { get; set; }
            public int PlayerExecution { get; set; }
            public int WinPVE { get; set; }
            public int FastReanimation { get; set; }
            public int PlayerIncapacitation { get; set; }
            public int Heal { get; set; }
            public int BaseCaptureAssist { get; set; }
            public int TopHeal { get; set; }
            public int PlayerDoubleIncapacitation { get; set; }
            public int WinHacking { get; set; }
            public int StaminaHeal { get; set; }
            public int ShieldAlly { get; set; }
            public int DemolitionHeavy { get; set; }
            public int FromTheGrave { get; set; }
            public int TeamElimination { get; set; }
            public int KillHacktoolCarrier { get; set; }
            public int SmokeDeployed { get; set; }
            public int DamageBlocked { get; set; }
            public int EnemyStunned { get; set; }
            public int WinPVPVE { get; set; }
            public int EnemyDetected { get; set; }
            public int HacktoolPlanted { get; set; }
            public int PlayerTripleIncapacitation { get; set; }
            public int EnemyPoisoned { get; set; }
            public int KillTheExecutor { get; set; }
            public int SpeedUpAlly { get; set; }
            public int EnemyBleeding { get; set; }
            public int HacktoolDefused { get; set; }
            public int KillHacktoolDefuser { get; set; }
            public int EnemyBurning { get; set; }
            public int WinRankedPVP { get; set; }
            public int TeamIntelFront { get; set; }
            public int CollectIntelFront { get; set; }
            public int MainIntelFront { get; set; }
            public int KillCarrierFront { get; set; }
            public int CapturePointFront { get; set; }
            public int SideIntelFront { get; set; }
            public int CapturePointAssistFront { get; set; }
            public int CapturePointEndgame { get; set; }
            public int WinR3Onslaught { get; set; }
            public int WaveCompleteR3Onslaught { get; set; }
            public int EvacuationR3Onslaught { get; set; }
            public int EvacuationReviveOnslaught { get; set; }
            public int WinR2Onslaught { get; set; }
            public int JuggernautKill { get; set; }
            public int EvacuationR2Onslaught { get; set; }
            public int WaveCompleteR2Onslaught { get; set; }
            public int HacktoolSuccess { get; set; }
            public int WinIntercept { get; set; }
        }

        public class Money
        {
            public ResourseValue values { get; set; }
        }

        public class OpenedSlot
        {
            public string SlotName { get; set; }
            public bool Refunded { get; set; }
        }

        public class PremiumReward
        {
            public ShopEntries shopEntries { get; set; }
            public int xp { get; set; }
        }

        public class ProlongPrice
        {
            public ResourseValue values { get; set; }
        }

        public class PurchasedShopItems
        {
            public int shop_pack_FxpEvent_500000 { get; set; }
            public int shop_lootbox_mainSkinsetCol { get; set; }
            public int shop_pack_Onslaught2021_Consumables { get; set; }
            public int shop_currency_Onslaught2021_CmT4Secretdev { get; set; }
            public int shop_currency_Onslaught2021_CmT1Components { get; set; }
            public int shop_currency_Onslaught2021_CmT1Medicine { get; set; }
            public int shop_currency_Onslaught2021_CmT1Alloy { get; set; }
            public int shop_currency_Onslaught2021_CmT2Chemistry { get; set; }
            public int shop_currency_Onslaught2021_CmT1Fuel { get; set; }
            public int shop_currency_Onslaught2021_CmT2Composite { get; set; }
            public int shop_currency_Onslaught2021_CmT2Encription { get; set; }
            public int shop_currency_Onslaught2021_CmT3Blueprint { get; set; }
            public int shop_currency_Onslaught2021_CmT3Microchip { get; set; }
            public int shop_lootbox_Onslaught2021_AC_Emotion_W0_HurryUp { get; set; }
            public int shop_pack_Onslaught2021_Boosters { get; set; }
            public int shop_lootbox_Onslaught2021_PatternOnslaught2021Skin1 { get; set; }
            public int shop_lootbox_Onslaught2021_PatternOnslaught2021Skin2 { get; set; }
            public int shop_lootbox_mainSkinsetOper { get; set; }
            public int shop_lootbox_RankedS2PatternRankedS2Sapphire { get; set; }
            public int shop_lootbox_Intercept2022_PatternIntercept2022giraffeCol { get; set; }
            public int shop_lootbox_Intercept2022_PatternIntercept2022giraffe { get; set; }
            public int shop_lootbox_Intercept2022_AC_Emotion_W0_FingerbangCol { get; set; }
            public int shop_lootbox_Intercept2022_AC_Emotion_W0_Fingerbang { get; set; }
        }

        public class Quarters
        {
            public Technologies Technologies { get; set; }
            public CurrentResearch CurrentResearch { get; set; }
            public Boosters Boosters { get; set; }
            public bool IsActive { get; set; }
        }

        public class Quest
        {
            public string id { get; set; }
            public string visual { get; set; }
            public string type { get; set; }
            public int group { get; set; }
            public bool isFinished { get; set; }
            public bool hadPremiumWhenFinished { get; set; }
            public Target target { get; set; }
            public Counter counter { get; set; }
            public double totalProgress { get; set; }
            public Reward reward { get; set; }
            public bool marked { get; set; }
            public PremiumReward premiumReward { get; set; }
        }

        public class QuestsProgress
        {
            public string id { get; set; }
            public string visual { get; set; }
            public string type { get; set; }
            public int group { get; set; }
            public bool isFinished { get; set; }
            public bool hadPremiumWhenFinished { get; set; }
            public Target target { get; set; }
            public Counter counter { get; set; }
            public double totalProgress { get; set; }
            public Reward reward { get; set; }
            public bool marked { get; set; }
            public PremiumReward premiumReward { get; set; }
        }

        public class RankedSeason
        {
            public string CfgName { get; set; }
            public int Points { get; set; }
            public int MaxPoints { get; set; }
            public int NumBattles { get; set; }
            public int NumWins { get; set; }
            public DateTime LastRetentionDate { get; set; }
        }

        public class RerollPrice
        {
            public ResourseValue values { get; set; }
        }

        public class Reward
        {
            public ShopEntries shopEntries { get; set; }
            public int xp { get; set; }
        }

        public class RewardSlot
        {
            public string SlotName { get; set; }
            public string RewardName { get; set; }
        }

        public class Ribbons
        {
            public int BotKill { get; set; }
            public int FirstBlood { get; set; }
            public int CleanKill { get; set; }
            public int Reanimation { get; set; }
            public int TopKill { get; set; }
            public int TopRevive { get; set; }
            public int TopDamage { get; set; }
            public int EnemySuppressed { get; set; }
            public int Assist { get; set; }
            public int DebuffAssist { get; set; }
            public int PlayerIncapacitation { get; set; }
            public int KillTheShooter { get; set; }
            public int DemolitionLight { get; set; }
            public int Revenge { get; set; }
            public int WinPVP { get; set; }
            public int Payback { get; set; }
            public int PlayerDoubleIncapacitation { get; set; }
            public int PlayerExecution { get; set; }
            public int BotDoubleKill { get; set; }
            public int EnemySlowed { get; set; }
            public int Heal { get; set; }
            public int CloseCall { get; set; }
            public int BotTripleKill { get; set; }
            public int SidearmKill { get; set; }
            public int Defender { get; set; }
            public int BullsEye { get; set; }
            public int WinHardPVE { get; set; }
            public int JustScratch { get; set; }
            public int LastBulletKill { get; set; }
            public int ExplosiveKill { get; set; }
            public int BaseCaptureAssist { get; set; }
            public int BlownAway { get; set; }
            public int BaseCapture { get; set; }
            public int DemolitionHeavy { get; set; }
            public int TopHeal { get; set; }
            public int SmokeDeployed { get; set; }
            public int WinPVPVE { get; set; }
            public int WinHacking { get; set; }
            public int FastReanimation { get; set; }
            public int ReinforceAlly { get; set; }
            public int BuffAssist { get; set; }
            public int WinPVE { get; set; }
            public int FromTheGrave { get; set; }
            public int PlayerTripleIncapacitation { get; set; }
            public int StaminaHeal { get; set; }
            public int DamageBlocked { get; set; }
            public int TeamElimination { get; set; }
            public int ShieldAlly { get; set; }
            public int KillHacktoolCarrier { get; set; }
            public int KillTheExecutor { get; set; }
            public int EnemyDetected { get; set; }
            public int HacktoolDefused { get; set; }
            public int EnemyStunned { get; set; }
            public int HacktoolPlanted { get; set; }
            public int KillHacktoolDefuser { get; set; }
            public int EnemyPoisoned { get; set; }
            public int HacktoolSuccess { get; set; }
            public int EnemyBleeding { get; set; }
            public int CapturePointAssistFront { get; set; }
            public int CapturePointFront { get; set; }
            public int KillCarrierFront { get; set; }
            public int SpeedUpAlly { get; set; }
            public int CollectIntelFront { get; set; }
            public int MainIntelFront { get; set; }
            public int SideIntelFront { get; set; }
            public int EnemyBurning { get; set; }
            public int TeamIntelFront { get; set; }
            public int WinRankedPVP { get; set; }
            public int CapturePointEndgame { get; set; }
            public int WaveCompleteR3Onslaught { get; set; }
            public int EvacuationR3Onslaught { get; set; }
            public int WinR3Onslaught { get; set; }
            public int EvacuationReviveOnslaught { get; set; }
            public int WaveCompleteR2Onslaught { get; set; }
            public int EvacuationR2Onslaught { get; set; }
            public int WinR2Onslaught { get; set; }
            public int JuggernautKill { get; set; }
            public int WinIntercept { get; set; }
            public int WaveCompleteR1Onslaught { get; set; }
            public int EvacuationR1Onslaught { get; set; }
            public int WinR1Onslaught { get; set; }
        }

        public class RolledSlot
        {
            public string SlotName { get; set; }
            public int SlotIndex { get; set; }
            public string ItemName { get; set; }
        }


        public class Settings
        {
            public ConsumablesBuyingAmount ConsumablesBuyingAmount { get; set; }
        }

        public class ShopEntries
        {
            public int shop_currency_hard { get; set; }
            public int shop_userbar_assault { get; set; }
            public int? shop_userbar_support { get; set; }
            public int? shop_userbar_sniper { get; set; }
            public int? shop_currency_soft { get; set; }
            public int shop_userbar_onboarding_all_missions { get; set; }
            public int? shop_lootbox_ComplexQuestChapter2Supplies { get; set; }
            public int? shop_lootbox_ComplexQuestChapter3Supplies { get; set; }
            public int? shop_userbar_medic { get; set; }
        }

        public class SpecialOffer
        {
            public string CfgId { get; set; }
            public int BuyLimit { get; set; }
            public int PurchasesCount { get; set; }
            public DateTime StartDate { get; set; }
        }

        public class Target
        {
            public string Trigger { get; set; }
            public double Count { get; set; }
            public double DoTimes { get; set; }
            public Conditions Conditions { get; set; }
        }

        public class Technologies
        {
            public int Physical { get; set; }
            public int Protective { get; set; }
            public int Ammunition { get; set; }
            public int Tactical { get; set; }
        }



        /*public class ResourseValue   
        {
            public int sc { get; set; }
            public int hc { get; set; }
            public int ammo_pack { get; set; }
            public int stamina_regen_booster { get; set; }
            public int armor_pack { get; set; }
            public int health_pack { get; set; }
            public int special_revive { get; set; }
            public int free_xp { get; set; }
            public int cm_t2_encryption { get; set; }
            public int cm_t3_microchip { get; set; }
            public int cm_t4_secretdev { get; set; }
            public int cm_t2_chemistry { get; set; }
            public int cm_t3_blueprint { get; set; }
            public int cm_t1_fuel { get; set; }
            public int cm_t1_alloy { get; set; }
            public int cm_t2_composite { get; set; }
            public int xp_booster { get; set; }
            public int cm_t1_component { get; set; }
            public int cm_t1_medicine { get; set; }
            public int credits_booster { get; set; }
            public int feb23_token { get; set; }
            public int thematic1_tokens { get; set; }
            public int thematic2_tokens { get; set; }
            public int Hacking2021Ticket { get; set; }
            public int Hacking2021Token { get; set; }
            public int RankedToken { get; set; }
            public int Archive3Token { get; set; }
            public int Front2021Ticket { get; set; }
            public int Front2021Token { get; set; }
            public int Onslaught2021Ticket { get; set; }
            public int Onslaught2021Token { get; set; }
            public int Archive4Token { get; set; }
            public int NewYear2022Key { get; set; }
            public int NewYear2022Token { get; set; }
            public int RefundToken { get; set; }
            public int Feb23_2022_token { get; set; }
            public int Intercept2022Ticket { get; set; }
            public int Intercept2022Token { get; set; }
        }*/


    }
}
