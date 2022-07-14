using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFCaliber.Value;

namespace Caliber.Json
{
    public static partial class StaticObject
    {
        public class Static
        {
            public List<CharacterCard> CharacterCards { get; set; }

            public partial class AbilityConfigs
            {
                public Sprint Sprint { get; set; }
                public RecruitAssault RecruitAssault { get; set; }
                public RecruitSniper RecruitSniper { get; set; }
                public RecruitSupport RecruitSupport { get; set; }
                public RecruitMedic RecruitMedic { get; set; }
                public Fsb2004Assault Fsb2004Assault { get; set; }
                public Fsb2004Sniper Fsb2004Sniper { get; set; }
                public Fsb2004SniperPassive Fsb2004SniperPassive { get; set; }
                public Fsb2004Support Fsb2004Support { get; set; }
                public Fsb2016SupportGm94PassiveClass Fsb2016SupportGm94Passive { get; set; }
                public Fsb2004Medic Fsb2004Medic { get; set; }
                public Ksk2011Assault Ksk2011Assault { get; set; }
                public Ksk2011Sniper Ksk2011Sniper { get; set; }
                public EzapacAssaultPassiveClass Ksk2011SniperPassive { get; set; }
                public Ksk2011Support Ksk2011Support { get; set; }
                public Ksk2011SupportPassive Ksk2011SupportPassive { get; set; }
                public Ksk2011Medic Ksk2011Medic { get; set; }
                public Ksk2011MedicP1A6Passive Ksk2011MedicP1A6Passive { get; set; }
                public Sso2013Assault Sso2013Assault { get; set; }
                public Sso2013AssaultMinePassive Sso2013AssaultMinePassive { get; set; }
                public Sso2013Sniper Sso2013Sniper { get; set; }
                public Sso2013SniperPassive Sso2013SniperPassive { get; set; }
                public Sso2013Support Sso2013Support { get; set; }
                public Fsb2016MedicPassive2 Sso2013SupportRpoPassive { get; set; }
                public Sso2013Medic Sso2013Medic { get; set; }
                public Sso2013MedicPassive Sso2013MedicPassive { get; set; }
                public Grom2014Assault Grom2014Assault { get; set; }
                public Grom2014Sniper Grom2014Sniper { get; set; }
                public Grom2014SniperMovPassive Grom2014SniperMovPassive { get; set; }
                public Grom2014Support Grom2014Support { get; set; }
                public Grom2014Medic Grom2014Medic { get; set; }
                public Grom2014MedicM500PassiveClass Grom2014MedicM500Passive { get; set; }
                public Grom2014MedicP1A6Passive Grom2014MedicP1A6Passive { get; set; }
                public Fsb2016Assault Fsb2016Assault { get; set; }
                public Fsb2016Sniper Fsb2016Sniper { get; set; }
                public Fsb2016SniperMinePassive Fsb2016SniperMinePassive { get; set; }
                public Fsb2016Support Fsb2016Support { get; set; }
                public Fsb2016SupportPassive Fsb2016SupportPassive { get; set; }
                public Fsb2016Medic Fsb2016Medic { get; set; }
                public Fsb2016MedicPassive Fsb2016MedicPassive { get; set; }
                public Fsb2016MedicPassive2 Fsb2016MedicPassive2 { get; set; }
                public Fsb2016MedicZaryaPassive Fsb2016MedicZaryaPassive { get; set; }
                public Fsb2016AssaultZaryaPassive Fsb2016AssaultZaryaPassive { get; set; }
                public Seal2014Assault Seal2014Assault { get; set; }
                public Seal2014Sniper Seal2014Sniper { get; set; }
                public Seal2014SniperMk141Passive Seal2014SniperMk141Passive { get; set; }
                public Seal2014SniperMinePassive Seal2014SniperMinePassive { get; set; }
                public Seal2014Support Seal2014Support { get; set; }
                public Seal2014Medic Seal2014Medic { get; set; }
                public Seal2014MedicPassive Seal2014MedicPassive { get; set; }
                public The22Spn2016Support The22Spn2016Support { get; set; }
                public Consumable ConsumableStaminaRegenBooster { get; set; }
                public Consumable ConsumableHealthPack { get; set; }
                public ConsumableSpecialRevive ConsumableSpecialRevive { get; set; }
                public ConsumableSpecialRevive ConsumableSpecialReviveV2 { get; set; }
                public ConsumableArmorPack ConsumableArmorPack { get; set; }
                public ConsumableRandomBonus ConsumableRandomBonus { get; set; }
                public ConsumablePerkTierUpgrade ConsumablePerkTierUpgrade { get; set; }
                public ConsumableDefendPointsBooster ConsumableDefendPointsBooster { get; set; }
                public ConsumableAmmoPack ConsumableAmmoPack { get; set; }
                public PassiveRegen PassiveRegen { get; set; }
                public The22Spn2016SupportPassive The22Spn2016SupportPassive { get; set; }
                public The22_Spn2016AssautlHeavyPassive PassiveDotBleedOnHit { get; set; }
                public Grom2014MedicM500PassiveClass Seal2014MedicMk25Passive { get; set; }
                public Tfb2008MedicTripwirePassive Tfb2008MedicTripwirePassive { get; set; }
                public Tfb2008MedicPassive Tfb2008MedicPassive { get; set; }
                public The22Spn2016Medic The22Spn2016Medic { get; set; }
                public Tfb2008Medic Tfb2008Medic { get; set; }
                public Tfb2008SniperDebuff Tfb2008SniperDebuff { get; set; }
                public Tfb2008Sniper Tfb2008Sniper { get; set; }
                public Tfb2008Assault Tfb2008Assault { get; set; }
                public Tfb2008AssaultPassive Tfb2008AssaultPassive { get; set; }
                public Fsb2016SupportGm94PassiveClass Tfb2008AssaultL17A1Passive { get; set; }
                public Tfb2008Support Tfb2008Support { get; set; }
                public Fsb2004SniperPassive2 Fsb2004SniperPassive2 { get; set; }
                public Tfb2008SupportPassive Tfb2008SupportPassive { get; set; }
                public Tfb2008SniperPassive2 Tfb2008SniperPassive2 { get; set; }
                public The22Spn2016SniperHeavyPassive The22Spn2016SniperHeavyPassive { get; set; }
                public The22Spn2016SniperPassive The22Spn2016SniperPassive { get; set; }
                public The22Spn2016Sniper The22Spn2016Sniper { get; set; }
                public The22Spn2016Assault The22Spn2016Assault { get; set; }
                public The22_Spn2016AssautlHeavyPassive The22Spn2016AssautlHeavyPassive { get; set; }
                public Seal2014SniperPassive Seal2014SniperPassive { get; set; }
                public The22Spn2016MedicPassive The22Spn2016MedicPassive { get; set; }
                public Raid2017Sniper Raid2017Sniper { get; set; }
                public Raid2017Support Raid2017Support { get; set; }
                public Raid2017Assault Raid2017Assault { get; set; }
                public Raid2017Medic Raid2017Medic { get; set; }
                public Raid2017SupportHeavyPassive Raid2017SupportHeavyPassive { get; set; }
                public Raid2017AssaultHeavyPassive Raid2017AssaultHeavyPassive { get; set; }
                public Raid2017GunnerSecondPassive Raid2017GunnerSecondPassive { get; set; }
                public Nesher2015Assault Nesher2015Assault { get; set; }
                public Nesher2015Support Nesher2015Support { get; set; }
                public Nesher2015Sniper Nesher2015Sniper { get; set; }
                public Nesher2015Medic Nesher2015Medic { get; set; }
                public Nesher2015AssaultPassive Nesher2015AssaultPassive { get; set; }
                public QuartersArmor QuartersArmorStaminaBoost { get; set; }
                public QuartersArmor QuartersArmorHeal { get; set; }
                public QuartersArmorRegen QuartersArmorRegen { get; set; }
                public Quarters QuartersReviveStaminaBoost { get; set; }
                public QuartersArmorShield QuartersArmorShield { get; set; }
                public Quarters QuartersHealOnExecution { get; set; }
                public QuartersSmokeBuff QuartersSmokeBuff { get; set; }
                public QuartersAmbush QuartersAmbush { get; set; }
                public QuartersBloodRage QuartersBloodRage { get; set; }
                public Quarters QuartersRetaliation { get; set; }
                public Quarters QuartersHeadHunter { get; set; }
                public QuartersCounterAttack QuartersCounterAttack { get; set; }
                public QuartersThermalImager QuartersThermalImager { get; set; }
                public QuartersTightFit QuartersTightFit { get; set; }
                public Fsb2016MedicPassive2 QuartersSecondWind { get; set; }
                public QuartersWellRested QuartersWellRested { get; set; }
                public QuartersTakeAim QuartersTakeAim { get; set; }
                public EzapacMedic EzapacMedic { get; set; }
                public EzapacMedicHeavyPassive EzapacMedicHeavyPassive { get; set; }
                public EzapacSniper EzapacSniper { get; set; }
                public EzapacMedicPrimaryPassive EzapacMedicPrimaryPassive { get; set; }
                public EzapacAssaultPassiveClass EzapacSniperPassive { get; set; }
                public EzapacAssault EzapacAssault { get; set; }
                public EzapacSupport EzapacSupport { get; set; }
                public EzapacAssaultPassiveClass EzapacAssaultPassive { get; set; }
                public ArystanAssault ArystanAssault { get; set; }
                public ArystanMedic ArystanMedic { get; set; }
                public ArystanSniper ArystanSniper { get; set; }
                public ArystanSupport ArystanSupport { get; set; }
                public ArystanSupportHeavyPassive ArystanSupportHeavyPassive { get; set; }
                public ArystanAssaultPassive ArystanAssaultPassive { get; set; }
                public ArystanAssaultHeavyPassive ArystanAssaultHeavyPassive { get; set; }
                public BelssoSupport BelssoSupport { get; set; }
                public BelssoAssault BelssoAssault { get; set; }
                public BelssoSniper BelssoSniper { get; set; }
                public BelssoAssaultHeavyPassive BelssoAssaultHeavyPassive { get; set; }
                public BelssoMedic BelssoMedic { get; set; }
                public BelssoMedicHeavyPassive BelssoMedicHeavyPassive { get; set; }
                public BelssoSniperHeavyPassive BelssoSniperHeavyPassive { get; set; }
                public ArystanAssaultPassive Tfb2008SupportPassive2 { get; set; }
                public AmfAssault AmfAssault { get; set; }
                public AmfSupport AmfSupport { get; set; }
                public AmfSniper AmfSniper { get; set; }
                public AmfMedic AmfMedic { get; set; }
                public AmfMedicHeavyPassive AmfMedicHeavyPassive { get; set; }
                public AmfPassive AmfAssaultPassive { get; set; }
                public AmfPassive AmfSupportPassive { get; set; }
                public AmfMedicPassive AmfMedicPassive { get; set; }
                public AmfPassive AmfSniperPassive { get; set; }
                public Ww2Medic Ww2Medic { get; set; }
                public Ww2Assault Ww2Assault { get; set; }
                public Ww2Support Ww2Support { get; set; }
                public Ww2Sniper Ww2Sniper { get; set; }
                public Ww2SupportPassiveTier Ww2SupportPassiveTier1 { get; set; }
                public Ww2SupportPassiveTier Ww2SupportPassiveTier2 { get; set; }
                public Ww2AssaultPassiveTier2Class Ww2SupportPassiveTier3 { get; set; }
                public Ww2AssaultPassiveTier1 Ww2AssaultPassiveTier1 { get; set; }
                public Ww2AssaultPassiveTier2Class Ww2AssaultPassiveTier2 { get; set; }
                public Ww2AssaultPassiveTier2Class Ww2AssaultPassiveTier3 { get; set; }
                public Ww2SniperPassiveTier1 Ww2SniperPassiveTier1 { get; set; }
                public Ww2AssaultPassiveTier2Class Ww2SniperPassiveTier2 { get; set; }
                public Ww2SniperPassiveTier3 Ww2SniperPassiveTier3 { get; set; }
                public Ww2AssaultPassiveTier2Class Ww2MedicPassiveTier1 { get; set; }
                public Ww2AssaultPassiveTier2Class Ww2MedicPassiveTier2 { get; set; }
                public Ww2AssaultPassiveTier2Class Ww2MedicPassiveTier3 { get; set; }
                public ArystanAssaultPassive Ww2AssaultPassive2 { get; set; }
            }

            public partial class AmfAssault
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public string Cooldown { get; set; }
                public string Duration { get; set; }
                public string ActivationCost { get; set; }
                public bool ActivationOnRelease { get; set; }
                public AmfAssaultActivationConditions ActivationConditions { get; set; }
                public List<AmfAssaultGroup> Groups { get; set; }
                public AmfAssaultMetaData MetaData { get; set; }
            }

            public partial class AmfAssaultActivationConditions
            {
                public bool HasHeavyWeaponAmmo { get; set; }
            }

            public partial class AmfAssaultGroup
            {
                public string TargetSelectionTime { get; set; }
                public bool? StopBuffsWithAbility { get; set; }
                public SelfSuccessGroupRule Rule { get; set; }
                public List<IndigoBuff> Buffs { get; set; }
                public string IsEnabled { get; set; }
            }

            public partial class IndigoBuff
            {
                public string Name { get; set; }
                public List<string> Categories { get; set; }
                public long Priority { get; set; }
                public StaminaAdd? Duration { get; set; }
                public bool? WpnSwitchToHeavy { get; set; }
                public string SpeedScale { get; set; }
                public bool? Rebuff { get; set; }
                public PurpleIncomingDamageMod IncomingDamageMod { get; set; }
                public AbilityLimitedBorrowedTime AbilityLimitedBorrowedTime { get; set; }
                public long? RebuffStack { get; set; }
                public long? Period { get; set; }
                public string HealthAdd { get; set; }
            }

            public partial class AbilityLimitedBorrowedTime
            {
                public string X { get; set; }
                public long Y { get; set; }
            }

            public partial class PurpleIncomingDamageMod
            {
                public List<IconType> Flags { get; set; }
                public double Mod { get; set; }
            }

            public partial class SelfSuccessGroupRule
            {
                public PurpleType Type { get; set; }
                public List<DeactivatedEntitiesOwnersRuleElement> ChildRules { get; set; }
            }

            public partial class DeactivatedEntitiesOwnersRuleElement
            {
                public TriggerTypeEnum Type { get; set; }
            }

            public partial class AmfAssaultMetaData
            {
                public List<string> Upgrades { get; set; }
                public AmbitiousModifiers Modifiers { get; set; }
            }

            public partial class AmbitiousModifiers
            {
                public StickyAdditive Additive { get; set; }
                public StickyUi Ui { get; set; }
            }

            public partial class StickyAdditive
            {
                public long AbilityAmfAssaultCooldown { get; set; }
                public long AbilityAmfAssaultDuration { get; set; }
                public long AbilityAmfAssaultActivationcost { get; set; }
                public double AbilityAmfAssaultSpeedScale { get; set; }
                public long AbilityAmfAssaultBorrowedTime { get; set; }
                public long AbilityAmfAssaultHealOnKillAmount { get; set; }
                public long AbilityAmfAssaultBorrowedTimeGroupEnabled { get; set; }
            }

            public partial class StickyUi
            {
                public long UiDuration { get; set; }
                public long UiCooldown { get; set; }
                public long UiActivationcost { get; set; }
                public long UiSpeedScale { get; set; }
                public long UiHealAmount { get; set; }
                public long UiEffectAmount { get; set; }
            }

            public partial class AmfPassive
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public double Cooldown { get; set; }
                public List<AmfAssaultPassiveGroup> Groups { get; set; }
            }

            public partial class AmfAssaultPassiveGroup
            {
                public string TargetSelectionTime { get; set; }
                public FluffyRule Rule { get; set; }
                public List<IndecentBuff> Buffs { get; set; }
            }

            public partial class IndecentBuff
            {
                public string Name { get; set; }
                public long Priority { get; set; }
                public List<string> Categories { get; set; }
                public double? SpeedScale { get; set; }
                public double? Duration { get; set; }
                public bool? Rebuff { get; set; }
                public double? WpnDamagePrimaryScale { get; set; }
                public PurpleIncomingDamageMod IncomingDamageMod { get; set; }
                public double? Stun { get; set; }
                public long? RevivesCountAdd { get; set; }
                public bool? SprintLock { get; set; }
                public List<BuffImmuneAbsoluteAdd> BuffImmuneAbsoluteAdd { get; set; }
                public bool? CloakScan { get; set; }
                public bool? Invisible { get; set; }
                public long? ShieldAdd { get; set; }
                public string BollyBulletShoot { get; set; }
                public string HealthAdd { get; set; }
                public double? WarmingSpeed { get; set; }
                public long? CooldownSpeed { get; set; }
                public long? WpnDestructibleMultPrimary { get; set; }
                public bool? BotReactsToHardHit { get; set; }
                public long? Period { get; set; }
            }

            public partial class FluffyRule
            {
                public PurpleType Type { get; set; }
                public List<FluffyChildRule> ChildRules { get; set; }
            }

            public partial class FluffyChildRule
            {
                public TriggerTypeEnum Type { get; set; }
                public double? Range { get; set; }
                public long? ConeAngle { get; set; }
                public bool? OnlyVisible { get; set; }
                public bool? OnlyNearest { get; set; }
            }

            public partial class AmfMedic
            {
                public FxTypeEnum Type { get; set; }
                public string FxType { get; set; }
                public string FxRadius { get; set; }
                public string ClientName { get; set; }
                public string Cooldown { get; set; }
                public string Duration { get; set; }
                public string ActivationCost { get; set; }
                public bool ActivationOnRelease { get; set; }
                public string ActivationOnHold { get; set; }
                public long ActivationOnHoldDuration { get; set; }
                public List<AmfMedicGroup> Groups { get; set; }
                public AmfMedicMetaData MetaData { get; set; }
            }

            public partial class AmfMedicGroup
            {
                public string TargetSelectionTime { get; set; }
                public SelfSuccessGroupRule Rule { get; set; }
                public List<HilariousBuff> Buffs { get; set; }
                public string IsEnabled { get; set; }
            }

            public partial class HilariousBuff
            {
                public string Name { get; set; }
                public long Priority { get; set; }
                public List<string> Categories { get; set; }
                public WarmingSpeed Duration { get; set; }
                public string Period { get; set; }
                public string HealthAdd { get; set; }
                public bool? Rebuff { get; set; }
                public List<string> BuffImmuneAbsoluteAdd { get; set; }
                public string StaminaAdd { get; set; }
            }

            public partial class AmfMedicMetaData
            {
                public List<string> Upgrades { get; set; }
                public CunningModifiers Modifiers { get; set; }
            }

            public partial class CunningModifiers
            {
                public Dictionary<string, long> Additive { get; set; }
                public FluffyUi Ui { get; set; }
            }

            public partial class FluffyUi
            {
                public double UiDuration { get; set; }
                public long UiCooldown { get; set; }
                public long UiActivationcost { get; set; }
                public long? UiHealAmount { get; set; }
                public long? UiShield { get; set; }
                public long? UiSlowFactor { get; set; }
                public long? UiRange { get; set; }
                public double? UiEffectDuration { get; set; }
            }

            public partial class AmfMedicHeavyPassive
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public List<AmfMedicHeavyPassiveGroup> Groups { get; set; }
                public AmfMedicHeavyPassiveMetaData MetaData { get; set; }
            }

            public partial class AmfMedicHeavyPassiveGroup
            {
                public bool RequireTarget { get; set; }
                public SelfSuccessGroupRule Rule { get; set; }
                public List<AmbitiousBuff> Buffs { get; set; }
            }

            public partial class AmbitiousBuff
            {
                public string Name { get; set; }
                public long Priority { get; set; }
                public List<string> Categories { get; set; }
                public string Duration { get; set; }
                public double? Period { get; set; }
                public string StaminaAdd { get; set; }
                public bool Rebuff { get; set; }
                public double? SpeedScale { get; set; }
                public long? ReviveSpeed { get; set; }
            }

            public partial class AmfMedicHeavyPassiveMetaData
            {
                public List<object> Upgrades { get; set; }
                public MagentaModifiers Modifiers { get; set; }
            }

            public partial class MagentaModifiers
            {
                public IndigoAdditive Additive { get; set; }
            }

            public partial class IndigoAdditive
            {
                public long AmfMedicHeavyPassiveDuration { get; set; }
                public long AmfMedicHeavyPassiveStaminaAdd { get; set; }
            }

            public partial class AmfMedicPassive
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public double Cooldown { get; set; }
                public List<AmfMedicPassiveGroup> Groups { get; set; }
            }

            public partial class AmfMedicPassiveGroup
            {
                public string TargetSelectionTime { get; set; }
                public FluffyRule Rule { get; set; }
                public List<FluffyBuff> Buffs { get; set; }
            }

            public partial class FluffyBuff
            {
                public string Name { get; set; }
                public long? Priority { get; set; }
                public bool? IsActivatedOnPeriodEnd { get; set; }
                public List<string> Categories { get; set; }
                public double Duration { get; set; }
                public double? Period { get; set; }
                public StaminaAdd? HealthAdd { get; set; }
                public bool? Rebuff { get; set; }
                public StaminaAdd? BuffStaminaAdd { get; set; }
                public StaminaAdd? StaminaAdd { get; set; }
                public long? ArmorHealthAdd { get; set; }
                public long? RebuffStack { get; set; }
                public bool? IsCasterSpecialTrigger { get; set; }
                public double? SpeedScale { get; set; }
                public bool? MovementAbilityEnable { get; set; }
                public string HealthBonus { get; set; }
                public double? WpnRateOfFireModPrimary { get; set; }
                public bool? StopBuffsWithAbility { get; set; }
                public PurpleIncomingDamageMod IncomingDamageMod { get; set; }
                public List<BuffImmuneAddElement> BuffImmuneAdd { get; set; }
            }

            public partial class AmfSniper
            {
                public string Type { get; set; }
                public FxTypeEnum FxType { get; set; }
                public string ClientName { get; set; }
                public string Cooldown { get; set; }
                public string Duration { get; set; }
                public string ActivationCost { get; set; }
                public bool ActivationOnRelease { get; set; }
                public List<AmfSniperGroup> Groups { get; set; }
                public AmfSniperMetaData MetaData { get; set; }
            }

            public partial class AmfSniperGroup
            {
                public string TargetSelectionTime { get; set; }
                public bool StopBuffsWithAbility { get; set; }
                public TentacledRule Rule { get; set; }
                public bool? CastOnHumanLure { get; set; }
                public List<CunningBuff> Buffs { get; set; }
            }

            public partial class CunningBuff
            {
                public string Name { get; set; }
                public long Priority { get; set; }
                public List<BuffImmuneAbsoluteAdd> Categories { get; set; }
                public StaminaAdd Duration { get; set; }
                public bool? ForceVisible { get; set; }
                public bool? IsCasterSpecialTrigger { get; set; }
                public bool? ForcePersonallyVisible { get; set; }
                public bool? Rebuff { get; set; }
                public string WpnDamageBoostByDeadAllyCountPrimary { get; set; }
                public string WpnDamageBoostByDeadAllyCountSecondary { get; set; }
                public string WpnDamageBoostByDeadAllyCountHeavy { get; set; }
            }

            public partial class TentacledRule
            {
                public PurpleType Type { get; set; }
                public List<TentacledChildRule> ChildRules { get; set; }
            }

            public partial class TentacledChildRule
            {
                public string Type { get; set; }
                public ParametricCondition? ParametricCondition { get; set; }
                public double? ParametricValue { get; set; }
                public string BuffName { get; set; }
            }

            public partial class AmfSniperMetaData
            {
                public List<string> Upgrades { get; set; }
                public FriskyModifiers Modifiers { get; set; }
            }

            public partial class FriskyModifiers
            {
                public IndecentAdditive Additive { get; set; }
                public Dictionary<string, double> Ui { get; set; }
            }

            public partial class IndecentAdditive
            {
                public long AbilityAmfSniperCooldown { get; set; }
                public long AbilityAmfSniperDuration { get; set; }
                public long AbilityAmfSniperActivationcost { get; set; }
                public long AbilityAmfSniperMarkDuration { get; set; }
                public double AbilityAmfSniperDeadAllyBonus { get; set; }
            }

            public partial class AmfSupport
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public string Cooldown { get; set; }
                public string Duration { get; set; }
                public string ActivationCost { get; set; }
                public bool ActivationOnRelease { get; set; }
                public long DelaySfxTime { get; set; }
                public string DelaySfxName { get; set; }
                public List<PurpleGroup> Groups { get; set; }
                public AmfSupportBuffAura BuffAura { get; set; }
                public List<AmfSupportBuffAuraGroup> BuffAuraGroups { get; set; }
                public AmfSupportMetaData MetaData { get; set; }
            }

            public partial class AmfSupportBuffAura
            {
                public DisplayMarkerTeamRuleEnum TeamRule { get; set; }
                public string TriggerType { get; set; }
                public string Radius { get; set; }
                public double UpdatePeriod { get; set; }
                public string Duration { get; set; }
                public bool IgnoreHeightCheck { get; set; }
                public string FxType { get; set; }
                public long? Angle { get; set; }
            }

            public partial class AmfSupportBuffAuraGroup
            {
                public string TargetSelectionTime { get; set; }
                public DeactivatedEntitiesOwnersRuleElement Rule { get; set; }
                public List<IndecentBuff> Buffs { get; set; }
            }

            public partial class PurpleGroup
            {
                public string TargetSelectionTime { get; set; }
                public TentacledRule Rule { get; set; }
                public List<MagentaBuff> Buffs { get; set; }
            }

            public partial class MagentaBuff
            {
                public string Name { get; set; }
                public long Priority { get; set; }
                public string Duration { get; set; }
                public bool? Aura { get; set; }
                public string IsEnabled { get; set; }
                public List<string> Categories { get; set; }
                public bool? Rebuff { get; set; }
                public PurpleIncomingDamageMod IncomingDamageMod { get; set; }
                public long? SpeedScale { get; set; }
                public bool? ForcePersonallyVisible { get; set; }
            }

            public partial class AmfSupportMetaData
            {
                public List<string> Upgrades { get; set; }
                public MischievousModifiers Modifiers { get; set; }
            }

            public partial class MischievousModifiers
            {
                public HilariousAdditive Additive { get; set; }
                public Dictionary<string, double> Ui { get; set; }
            }

            public partial class HilariousAdditive
            {
                public long AbilityAmfSupportCooldown { get; set; }
                public long AbilityAmfSupportDuration { get; set; }
                public long AbilityAmfSupportActivationcost { get; set; }
                public long AbilityAmfSupportRange { get; set; }
                public long AbilityAmfSupportDamagemodGroupEnabled { get; set; }
                public long AbilityAmfSupportRootDuration { get; set; }
            }

            public partial class ArystanAssault
            {
                public string Type { get; set; }
                public FxTypeEnum FxType { get; set; }
                public string ClientName { get; set; }
                public long CastTime { get; set; }
                public string Cooldown { get; set; }
                public string Duration { get; set; }
                public string ActivationCost { get; set; }
                public bool ActivationOnRelease { get; set; }
                public List<ArystanAssaultGroup> Groups { get; set; }
                public ArystanAssaultMetaData MetaData { get; set; }
            }

            public partial class ArystanAssaultGroup
            {
                public bool StopBuffsWithAbility { get; set; }
                public SelfSuccessGroupRule Rule { get; set; }
                public bool? CastOnHumanLure { get; set; }
                public List<FriskyBuff> Buffs { get; set; }
                public string TargetSelectionTime { get; set; }
                public string IsEnabled { get; set; }
            }

            public partial class FriskyBuff
            {
                public string Name { get; set; }
                public long Priority { get; set; }
                public List<string> Categories { get; set; }
                public WarmingSpeed Duration { get; set; }
                public bool? ForcePersonallyVisible { get; set; }
                public bool? IsCasterSpecialTrigger { get; set; }
                public bool? ForceVisibleToAll { get; set; }
                public double? WarmingSpeed { get; set; }
                public double? Period { get; set; }
                public string StaminaAdd { get; set; }
                public bool? Rebuff { get; set; }
            }

            public partial class ArystanAssaultMetaData
            {
                public List<string> Upgrades { get; set; }
                public BraggadociousModifiers Modifiers { get; set; }
            }

            public partial class BraggadociousModifiers
            {
                public AmbitiousAdditive Additive { get; set; }
                public PurpleUi Ui { get; set; }
            }

            public partial class AmbitiousAdditive
            {
                public long AbilityArystanAssaultCooldown { get; set; }
                public long AbilityArystanAssaultDuration { get; set; }
                public long AbilityArystanAssaultActivationcost { get; set; }
                public long AbilityArystanAssaultMarkDuration { get; set; }
                public long AbilityArystanAssaultSelfMarkDuration { get; set; }
                public long AbilityArystanAssaultStaminaHealGroupEnabled { get; set; }
                public long AbilityArystanAssaultStaminaHealAmount { get; set; }
            }

            public partial class PurpleUi
            {
                public double UiDuration { get; set; }
                public long UiCooldown { get; set; }
                public long UiActivationcost { get; set; }
                public long? UiDropItemAmmount { get; set; }
                public double? UiEffectDuration { get; set; }
                public long? UiSelfSlow { get; set; }
                public long? UiRange { get; set; }
                public long? UiEffectRange { get; set; }
                public long? UiShield { get; set; }
                public long? UiHeadshotDamage { get; set; }
            }

            public partial class ArystanAssaultHeavyPassive
            {
                public string Type { get; set; }
                public List<ArystanAssaultHeavyPassiveGroup> Groups { get; set; }
            }

            public partial class ArystanAssaultHeavyPassiveGroup
            {
                public DeactivatedEntitiesOwnersRuleElement Rule { get; set; }
                public string TargetSelectionTime { get; set; }
                public bool StopBuffsWithAbility { get; set; }
                public List<MischievousBuff> Buffs { get; set; }
            }

            public partial class MischievousBuff
            {
                public ActionTarget Name { get; set; }
                public long Priority { get; set; }
                public long WpnWallPerforationLimitHeavy { get; set; }
            }

            public partial class ArystanAssaultPassive
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public List<ArystanAssaultPassiveGroup> Groups { get; set; }
            }

            public partial class ArystanAssaultPassiveGroup
            {
                public SelfSuccessGroupRule Rule { get; set; }
                public string TargetSelectionTime { get; set; }
                public List<BraggadociousBuff> Buffs { get; set; }
            }

            public partial class BraggadociousBuff
            {
                public ActionTarget Name { get; set; }
                public double Duration { get; set; }
                public long? WpnRefillHeavy { get; set; }
                public bool Rebuff { get; set; }
                public long? WpnRefillPrimary { get; set; }
            }

            public partial class ArystanMedic
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public string ActivationCost { get; set; }
                public string CastTime { get; set; }
                public string Duration { get; set; }
                public string Cooldown { get; set; }
                public long DropItemFlyGravityCompensation { get; set; }
                public long DropItemThrowSpeed { get; set; }
                public string DropItemReboundBehaviour { get; set; }
                public string TrajectoryFxType { get; set; }
                public long MaxDropItemsOnScene { get; set; }
                public bool ActivationOnRelease { get; set; }
                public double PrepareTimeRelease { get; set; }
                public string AnimationType { get; set; }
                public double AnimationTimeScale { get; set; }
                public bool BulletsCanBeDeactivated { get; set; }
                public The22Spn2016MedicMetaData MetaData { get; set; }
            }

            public partial class The22Spn2016MedicMetaData
            {
                public List<string> Upgrades { get; set; }
                public TentacledModifiers Modifiers { get; set; }
                public string DropItem { get; set; }
            }

            public partial class TentacledModifiers
            {
                public Dictionary<string, double> Additive { get; set; }
                public Dictionary<string, double> Ui { get; set; }
            }

            public partial class ArystanSniper
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public string Cooldown { get; set; }
                public string Duration { get; set; }
                public string ActivationCost { get; set; }
                public bool ActivationOnRelease { get; set; }
                public List<ArystanSniperGroup> Groups { get; set; }
                public ArystanSniperBuffAura BuffAura { get; set; }
                public List<ArystanSniperBuffAuraGroup> BuffAuraGroups { get; set; }
                public ArystanSniperMetaData MetaData { get; set; }
            }

            public partial class ArystanSniperBuffAura
            {
                public DisplayMarkerTeamRuleEnum TeamRule { get; set; }
                public TriggerType TriggerType { get; set; }
                public long Radius { get; set; }
                public Duration UpdatePeriod { get; set; }
                public Duration Duration { get; set; }
                public FxTypeEnum FxType { get; set; }
                public bool? IgnoreHeightCheck { get; set; }
            }

            public partial class ArystanSniperBuffAuraGroup
            {
                public AuraBuffGroupTargetSelectionTime TargetSelectionTime { get; set; }
                public SelfSuccessGroupRule Rule { get; set; }
                public List<Buff1> Buffs { get; set; }
            }

            public partial class Buff1
            {
                public string Name { get; set; }
                public long Priority { get; set; }
                public List<string> Categories { get; set; }
                public string Duration { get; set; }
                public bool? Rebuff { get; set; }
                public PurpleIncomingDamageMod IncomingDamageMod { get; set; }
                public string Stun { get; set; }
                public bool? CloakScan { get; set; }
                public bool? Aura { get; set; }
                public WarmingSpeed? SpeedScale { get; set; }
                public bool? SprintLock { get; set; }
                public bool? ForceVisible { get; set; }
            }

            public partial class ArystanSniperGroup
            {
                public StickyRule Rule { get; set; }
                public string TargetSelectionTime { get; set; }
                public List<Buff2> Buffs { get; set; }
                public string IsEnabled { get; set; }
            }

            public partial class Buff2
            {
                public string Name { get; set; }
                public long Priority { get; set; }
                public List<string> Categories { get; set; }
                public WarmingSpeed Duration { get; set; }
                public bool Rebuff { get; set; }
                public string KeptAfterDeathRemove { get; set; }
                public long? KnockDownTimeReminder { get; set; }
                public List<string> BuffImmuneAbsoluteAdd { get; set; }
                public bool? Aura { get; set; }
            }

            public partial class StickyRule
            {
                public PurpleType Type { get; set; }
                public bool? IncludeDead { get; set; }
                public List<DeactivatedEntitiesOwnersRuleElement> ChildRules { get; set; }
            }

            public partial class ArystanSniperMetaData
            {
                public List<string> Upgrades { get; set; }
                public Modifiers1 Modifiers { get; set; }
            }

            public partial class Modifiers1
            {
                public CunningAdditive Additive { get; set; }
                public PurpleUi Ui { get; set; }
            }

            public partial class CunningAdditive
            {
                public long AbilityArystanSniperCooldown { get; set; }
                public long AbilityArystanSniperDuration { get; set; }
                public long AbilityArystanSniperEffectDuration { get; set; }
                public long AbilityArystanSniperEffectDamagemodDuration { get; set; }
                public long AbilityArystanSniperActivationcost { get; set; }
                public long AbilityArystanSniperBuffOnHeadshotGroupEnabled { get; set; }
            }

            public partial class ArystanSupport
            {
                public string Type { get; set; }
                public FxTypeEnum FxType { get; set; }
                public string FxRadius { get; set; }
                public string ClientName { get; set; }
                public string Cooldown { get; set; }
                public string Duration { get; set; }
                public string ActivationCost { get; set; }
                public bool ActivationOnRelease { get; set; }
                public bool HideAuraFromEnemy { get; set; }
                public List<ArystanSupportGroup> Groups { get; set; }
                public ArystanSupportBuffAura BuffAura { get; set; }
                public List<ArystanSupportBuffAuraGroup> BuffAuraGroups { get; set; }
                public ArystanSupportMetaData MetaData { get; set; }
            }

            public partial class ArystanSupportBuffAura
            {
                public DisplayMarkerTeamRuleEnum TeamRule { get; set; }
                public TriggerType TriggerType { get; set; }
                public string Radius { get; set; }
                public double UpdatePeriod { get; set; }
                public double Duration { get; set; }
                public FxTypeEnum FxType { get; set; }
            }

            public partial class ArystanSupportBuffAuraGroup
            {
                public AuraBuffGroupTargetSelectionTime TargetSelectionTime { get; set; }
                public SelfSuccessGroupRule Rule { get; set; }
                public List<StickyBuff> Buffs { get; set; }
                public List<SelfSuccess> SelfSuccess { get; set; }
            }

            public partial class StickyBuff
            {
                public string Name { get; set; }
                public long Priority { get; set; }
                public List<string> Categories { get; set; }
                public string ShieldAdd { get; set; }
                public string Duration { get; set; }
                public bool? ForceVisible { get; set; }
                public bool? Rebuff { get; set; }
                public List<BuffImmuneAddElement> BuffImmuneAbsoluteAdd { get; set; }
                public double? WpnRateOfFireModPrimaryScale { get; set; }
                public double? WpnRecoilMultPrimary { get; set; }
                public string BuffStun { get; set; }
                public string Stun { get; set; }
                public bool? IsCasterSpecialTrigger { get; set; }
                public bool? Aura { get; set; }
                public string SprintType { get; set; }
            }

            public partial class SelfSuccess
            {
                public string IsEnabled { get; set; }
                public string TargetSelectionTime { get; set; }
                public DeactivatedEntitiesOwnersRuleElement Rule { get; set; }
                public long AffectedTargetsCountMin { get; set; }
                public List<SelfSuccessBuff> Buffs { get; set; }
            }

            public partial class SelfSuccessBuff
            {
                public string Name { get; set; }
                public long? Priority { get; set; }
                public List<string> Categories { get; set; }
                public List<BuffImmuneAbsoluteAdd> BuffImmuneAbsoluteAdd { get; set; }
                public bool? Rebuff { get; set; }
                public WarmingSpeed? WarmingSpeed { get; set; }
                public double? CooldownSpeed { get; set; }
                public double Duration { get; set; }
                public double? SpeedScale { get; set; }
                public bool? SprintLock { get; set; }
                public bool? ForcePersonallyVisible { get; set; }
                public double? WpnDamagePrimaryScale { get; set; }
                public double? WpnDamageSecondaryScale { get; set; }
                public PurpleIncomingDamageMod IncomingDamageMod { get; set; }
                public bool? CloakScan { get; set; }
                public long? WpnRefillHeavy { get; set; }
                public double? BuffSpeedScale { get; set; }
                public double? ReviveSpeed { get; set; }
                public long? PrimaryAbilityCooldownModifier { get; set; }
                public long? DropItemRadiusModifier { get; set; }
                public long? HealModifier { get; set; }
                public long? WpnWallPerforationLimitPrimary { get; set; }
                public double? Stun { get; set; }
                public bool? BotReactsToHardHit { get; set; }
                public bool? PrimaryAbilityStop { get; set; }
            }

            public partial class ArystanSupportGroup
            {
                public PurpleTargetSelectionTime TargetSelectionTime { get; set; }
                public SelfSuccessGroupRule Rule { get; set; }
                public List<DeactivatedEntitiesOwnersBuffElement> Buffs { get; set; }
            }

            public partial class DeactivatedEntitiesOwnersBuffElement
            {
                public string Name { get; set; }
                public long Priority { get; set; }
                public double Duration { get; set; }
                public bool? Aura { get; set; }
                public long? ArmorHealthAdd { get; set; }
                public List<BuffImmuneAddElement> Categories { get; set; }
                public long? HeatAdd { get; set; }
            }

            public partial class ArystanSupportMetaData
            {
                public List<string> Upgrades { get; set; }
                public Modifiers2 Modifiers { get; set; }
            }

            public partial class Modifiers2
            {
                public MagentaAdditive Additive { get; set; }
                public Dictionary<string, double> Ui { get; set; }
            }

            public partial class MagentaAdditive
            {
                public long AbilityArystanSupportCooldown { get; set; }
                public long AbilityArystanSupportDuration { get; set; }
                public long AbilityArystanSupportActivationcost { get; set; }
                public long AbilityArystanSupportShieldDuration { get; set; }
                public long AbilityArystanSupportShieldHealth { get; set; }
                public long AbilityArystanSupportRange { get; set; }
                public long AbilityArystanSupportSelfSuccessEnabled { get; set; }
            }

            public partial class ArystanSupportHeavyPassive
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public List<AmfAssaultPassiveGroup> Groups { get; set; }
            }

            public partial class BelssoAssault
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public string Cooldown { get; set; }
                public string Duration { get; set; }
                public string ActivationCost { get; set; }
                public bool ActivationOnRelease { get; set; }
                public double PrepareTimeRelease { get; set; }
                public double AnimationTimeScale { get; set; }
                public string AnimationType { get; set; }
                public long MaxDropItemsOnScene { get; set; }
                public List<BelssoAssaultGroup> Groups { get; set; }
                public BelssoAssaultMetaData MetaData { get; set; }
            }

            public partial class BelssoAssaultGroup
            {
                public IndigoRule Rule { get; set; }
                public string TargetSelectionTime { get; set; }
                public List<Buff3> Buffs { get; set; }
                public string IsEnabled { get; set; }
            }

            public partial class Buff3
            {
                public string Name { get; set; }
                public long Priority { get; set; }
                public List<string> Categories { get; set; }
                public List<string> BuffImmuneAbsoluteAdd { get; set; }
                public WarmingSpeed Duration { get; set; }
                public bool? Rebuff { get; set; }
                public bool? Invisible { get; set; }
                public double? Period { get; set; }
                public long? StaminaAdd { get; set; }
                public double? SpeedScale { get; set; }
                public CreatorBuffsByAffectingAuraIncomingDamageMod IncomingDamageMod { get; set; }
                public bool? Aura { get; set; }
            }

            public partial class CreatorBuffsByAffectingAuraIncomingDamageMod
            {
                public List<IconType> Flags { get; set; }
                public string Mod { get; set; }
            }

            public partial class IndigoRule
            {
                public PurpleType Type { get; set; }
                public List<StickyChildRule> ChildRules { get; set; }
            }

            public partial class StickyChildRule
            {
                public PurpleType Type { get; set; }
                public List<DeactivatedEntitiesOwnersRuleElement> ChildRules { get; set; }
                public string BuffName { get; set; }
            }

            public partial class BelssoAssaultMetaData
            {
                public Modifiers3 Modifiers { get; set; }
                public List<string> Upgrades { get; set; }
                public string DropItem { get; set; }
            }

            public partial class Modifiers3
            {
                public FriskyAdditive Additive { get; set; }
                public PurpleUi Ui { get; set; }
            }

            public partial class FriskyAdditive
            {
                public long AbilityBelssoAssaultActivationcost { get; set; }
                public long AbilityBelssoAssaultDuration { get; set; }
                public long AbilityBelssoAssaultCooldown { get; set; }
                public long AbilityBelssoAssaultStaminaRegenGroupEnabled { get; set; }
                public long AbilityBelssoAssaultCleanseGroupEnabled { get; set; }
            }

            public partial class BelssoAssaultHeavyPassive
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public List<BelssoAssaultHeavyPassiveGroup> Groups { get; set; }
                public BelssoAssaultHeavyPassiveMetaData MetaData { get; set; }
            }

            public partial class BelssoAssaultHeavyPassiveGroup
            {
                public DeactivatedEntitiesOwnersRuleElement Rule { get; set; }
                public AuraBuffGroupTargetSelectionTime TargetSelectionTime { get; set; }
                public List<Buff4> Buffs { get; set; }
                public bool? CastOnHumanLure { get; set; }
            }

            public partial class Buff4
            {
                public string Name { get; set; }
                public long Priority { get; set; }
                public bool IsActivatedOnPeriodEnd { get; set; }
                public List<string> Categories { get; set; }
                public List<BuffImmuneAddElement> BuffImmuneAbsoluteAdd { get; set; }
                public string Duration { get; set; }
                public string Period { get; set; }
                public string HealthAdd { get; set; }
                public bool Rebuff { get; set; }
                public bool UniqName { get; set; }
                public long Utility { get; set; }
            }

            public partial class BelssoAssaultHeavyPassiveMetaData
            {
                public List<object> Upgrades { get; set; }
                public Modifiers4 Modifiers { get; set; }
            }

            public partial class Modifiers4
            {
                public MischievousAdditive Additive { get; set; }
            }

            public partial class MischievousAdditive
            {
                public long AbilityBelssoAssaultHeavyPassiveDotDuration { get; set; }
                public double AbilityBelssoAssaultHeavyPassiveDotPeriod { get; set; }
                public long AbilityBelssoAssaultHeavyPassiveDotHealthAdd { get; set; }
            }

            public partial class BelssoMedic
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public string Cooldown { get; set; }
                public string Duration { get; set; }
                public string ActivationCost { get; set; }
                public bool ActivationOnRelease { get; set; }
                public bool ActivationOnHold { get; set; }
                public long ActivationOnHoldDuration { get; set; }
                public List<BelssoMedicGroup> Groups { get; set; }
                public BelssoMedicMetaData MetaData { get; set; }
            }

            public partial class BelssoMedicGroup
            {
                public string TargetSelectionTime { get; set; }
                public bool RequireTarget { get; set; }
                public bool? ShowTargets { get; set; }
                public IndecentRule Rule { get; set; }
                public List<Buff5> Buffs { get; set; }
                public string IsEnabled { get; set; }
            }

            public partial class Buff5
            {
                public string Name { get; set; }
                public long Priority { get; set; }
                public List<BuffImmuneAddElement> Categories { get; set; }
                public WarmingSpeed Duration { get; set; }
                public string Period { get; set; }
                public string HealthAdd { get; set; }
                public string ArmorHealthAdd { get; set; }
            }

            public partial class IndecentRule
            {
                public TentacledType Type { get; set; }
                public List<IndigoChildRule> ChildRules { get; set; }
            }

            public partial class IndigoChildRule
            {
                public TriggerTypeEnum Type { get; set; }
                public string Range { get; set; }
                public string ConeAngle { get; set; }
                public bool? OnlyNearest { get; set; }
                public bool? OnlyVisible { get; set; }
                public bool? IncludeTargeted { get; set; }
            }

            public partial class BelssoMedicMetaData
            {
                public List<string> Upgrades { get; set; }
                public TentacledModifiers Modifiers { get; set; }
            }

            public partial class BelssoMedicHeavyPassive
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public List<BelssoMedicHeavyPassiveGroup> Groups { get; set; }
                public BelssoMedicHeavyPassiveMetaData MetaData { get; set; }
            }

            public partial class BelssoMedicHeavyPassiveGroup
            {
                public DeactivatedEntitiesOwnersRuleElement Rule { get; set; }
                public AuraBuffGroupTargetSelectionTime TargetSelectionTime { get; set; }
                public List<Buff6> Buffs { get; set; }
            }

            public partial class Buff6
            {
                public string Name { get; set; }
                public long Priority { get; set; }
                public List<string> Categories { get; set; }
                public string Duration { get; set; }
                public long? WeaponsSwaySwingValue { get; set; }
                public long? WpnSpreadConeMaxModPrimary { get; set; }
                public long? WpnSpreadConeMaxModSecondary { get; set; }
                public long? WpnSpreadConeMaxModHeavy { get; set; }
                public long? WpnSpreadConeMinPrimary { get; set; }
                public long? WpnSpreadConeMinSecondary { get; set; }
                public long? WpnSpreadConeMinHeavy { get; set; }
                public double? SpeedScale { get; set; }
                public string Stun { get; set; }
                public bool? WeaponsAimRestricted { get; set; }
                public bool? Rebuff { get; set; }
            }

            public partial class BelssoMedicHeavyPassiveMetaData
            {
                public List<object> Upgrades { get; set; }
                public Modifiers5 Modifiers { get; set; }
            }

            public partial class Modifiers5
            {
                public BraggadociousAdditive Additive { get; set; }
                public FluffyUi Ui { get; set; }
            }

            public partial class BraggadociousAdditive
            {
                public long AbilityBelssoMedicHeavyPassiveStunDuration { get; set; }
            }

            public partial class BelssoSniper
            {
                public string ClientName { get; set; }
                public string Cooldown { get; set; }
                public string Duration { get; set; }
                public string ActivationCost { get; set; }
                public bool ActivationOnRelease { get; set; }
                public List<BelssoSniperGroup> Groups { get; set; }
                public BelssoSniperMetaData MetaData { get; set; }
            }

            public partial class BelssoSniperGroup
            {
                public PurpleTargetSelectionTime TargetSelectionTime { get; set; }
                public bool StopBuffsWithAbility { get; set; }
                public bool StopAbilityWithBuff { get; set; }
                public DeactivatedEntitiesOwnersRuleElement Rule { get; set; }
                public List<StickyBuff> Buffs { get; set; }
            }

            public partial class BelssoSniperMetaData
            {
                public List<string> Upgrades { get; set; }
                public Modifiers6 Modifiers { get; set; }
            }

            public partial class Modifiers6
            {
                public Additive1 Additive { get; set; }
                public FluffyUi Ui { get; set; }
            }

            public partial class Additive1
            {
                public long AbilityBelssoSniperCooldown { get; set; }
                public long AbilityBelssoSniperDuration { get; set; }
                public long AbilityBelssoSniperActivationcost { get; set; }
                public long AbilityBelssoSniperShieldShieldAdd { get; set; }
            }

            public partial class BelssoSniperHeavyPassive
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public List<The22Spn2016SniperPassiveGroup> Groups { get; set; }
                public BelssoSniperHeavyPassiveMetaData MetaData { get; set; }
            }

            public partial class The22Spn2016SniperPassiveGroup
            {
                public DeactivatedEntitiesOwnersRuleElement Rule { get; set; }
                public string TargetSelectionTime { get; set; }
                public List<FluffyBuff> Buffs { get; set; }
            }

            public partial class BelssoSniperHeavyPassiveMetaData
            {
                public List<object> Upgrades { get; set; }
                public Modifiers7 Modifiers { get; set; }
            }

            public partial class Modifiers7
            {
                public Additive2 Additive { get; set; }
            }

            public partial class Additive2
            {
                public long BelssoSniperHeavyPassiveEnabled { get; set; }
            }

            public partial class BelssoSupport
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public string Cooldown { get; set; }
                public string Duration { get; set; }
                public string ActivationCost { get; set; }
                public bool ActivationOnRelease { get; set; }
                public bool CanBeStoppedManually { get; set; }
                public List<BelssoSupportGroup> Groups { get; set; }
                public BelssoSupportMetaData MetaData { get; set; }
            }

            public partial class BelssoSupportGroup
            {
                public bool StopBuffsWithAbility { get; set; }
                public string TargetSelectionTime { get; set; }
                public PurpleRule Rule { get; set; }
                public List<Buff7> Buffs { get; set; }
                public string IsEnabled { get; set; }
            }

            public partial class Buff7
            {
                public string Name { get; set; }
                public long? Priority { get; set; }
                public List<string> Categories { get; set; }
                public WarmingSpeed Duration { get; set; }
                public bool? Rebuff { get; set; }
                public CreatorBuffsByAffectingAuraIncomingDamageMod IncomingDamageMod { get; set; }
                public double? SpeedScale { get; set; }
                public List<string> BuffImmuneAbsoluteAdd { get; set; }
                public bool? PrimaryAbilityLock { get; set; }
                public long? StaminaAdd { get; set; }
                public WarmingSpeed? Period { get; set; }
                public string HealthAdd { get; set; }
            }

            public partial class PurpleRule
            {
                public PurpleType Type { get; set; }
                public List<PurpleChildRule> ChildRules { get; set; }
            }

            public partial class PurpleChildRule
            {
                public FluffyType Type { get; set; }
                public string BuffName { get; set; }
            }

            public partial class BelssoSupportMetaData
            {
                public List<string> Upgrades { get; set; }
                public Modifiers8 Modifiers { get; set; }
            }

            public partial class Modifiers8
            {
                public Additive3 Additive { get; set; }
                public IndigoUi Ui { get; set; }
            }

            public partial class Additive3
            {
                public long AbilityBelssoSupportCooldown { get; set; }
                public long AbilityBelssoSupportDuration { get; set; }
                public long AbilityBelssoSupportActivationcost { get; set; }
                public double AbilityBelssoSupportDamagemod { get; set; }
                public double AbilityBelssoSupportDamagemodBipod { get; set; }
                public long AbilityBelssoSupportStunImmunityGroupEnabled { get; set; }
            }

            public partial class IndigoUi
            {
                public long UiDuration { get; set; }
                public long UiCooldown { get; set; }
                public long UiActivationcost { get; set; }
                public long UiDamageMod { get; set; }
                public long UiDamageModBipod { get; set; }
            }

            public partial class ConsumableAmmoPack
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public List<ConsumableAmmoPackGroup> Groups { get; set; }
                public ConsumableAmmoPackMetaData MetaData { get; set; }
            }

            public partial class ConsumableAmmoPackGroup
            {
                public string IsEnabled { get; set; }
                public bool RequireTarget { get; set; }
                public HilariousRule Rule { get; set; }
                public List<Buff8> Buffs { get; set; }
            }

            public partial class Buff8
            {
                public ActionTarget Name { get; set; }
                public long Priority { get; set; }
                public List<BuffImmuneAbsoluteAdd> Categories { get; set; }
                public double Duration { get; set; }
                public long? WpnRefillPrimary { get; set; }
                public long? WpnRefillSecondary { get; set; }
                public long? WpnRefillHeavyClip { get; set; }
                public bool? Rebuff { get; set; }
            }

            public partial class HilariousRule
            {
                public PurpleType Type { get; set; }
                public List<SelfSuccessGroupRule> ChildRules { get; set; }
            }

            public partial class ConsumableAmmoPackMetaData
            {
                public Modifiers9 Modifiers { get; set; }
            }

            public partial class Modifiers9
            {
                public Additive4 Additive { get; set; }
            }

            public partial class Additive4
            {
                public long RegularEnabled { get; set; }
                public long HeavyEnabled { get; set; }
            }

            public partial class ConsumableArmorPack
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public List<ConsumableArmorPackGroup> Groups { get; set; }
                public ConsumableArmorPackMetaData MetaData { get; set; }
            }

            public partial class ConsumableArmorPackGroup
            {
                public bool RequireTarget { get; set; }
                public SelfSuccessGroupRule Rule { get; set; }
                public List<FluffyBuff> Buffs { get; set; }
                public string IsEnabled { get; set; }
            }

            public partial class ConsumableArmorPackMetaData
            {
                public Modifiers10 Modifiers { get; set; }
            }

            public partial class Modifiers10
            {
                public Additive5 Additive { get; set; }
            }

            public partial class Additive5
            {
                public long SpecialArmorPackEnabled { get; set; }
            }

            public partial class ConsumableDefendPointsBooster
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public List<ConsumableDefendPointsBoosterGroup> Groups { get; set; }
            }

            public partial class ConsumableDefendPointsBoosterGroup
            {
                public bool RequireTarget { get; set; }
                public SelfSuccessGroupRule Rule { get; set; }
                public List<Buff9> Buffs { get; set; }
            }

            public partial class Buff9
            {
                public string Name { get; set; }
                public List<BuffImmuneAbsoluteAdd> Categories { get; set; }
                public long Duration { get; set; }
                public MultiplyClass DefendPointsBooster { get; set; }
            }

            public partial class MultiplyClass
            {
            }

            public partial class Consumable
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public List<ConsumableHealthPackGroup> Groups { get; set; }
                public ConsumableHealthPackMetaData MetaData { get; set; }
            }

            public partial class ConsumableHealthPackGroup
            {
                public bool RequireTarget { get; set; }
                public SelfSuccessGroupRule Rule { get; set; }
                public List<FluffyBuff> Buffs { get; set; }
            }

            public partial class ConsumableHealthPackMetaData
            {
                public List<object> Upgrades { get; set; }
                public Modifiers11 Modifiers { get; set; }
            }

            public partial class Modifiers11
            {
                public MultiplyClass Additive { get; set; }
                public FluffyUi Ui { get; set; }
            }

            public partial class ConsumablePerkTierUpgrade
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public List<ConsumablePerkTierUpgradeGroup> Groups { get; set; }
            }

            public partial class ConsumablePerkTierUpgradeGroup
            {
                public bool RequireTarget { get; set; }
                public PurpleRule Rule { get; set; }
                public List<Buff10> Buffs { get; set; }
            }

            public partial class Buff10
            {
                public ActionTarget Name { get; set; }
                public double Duration { get; set; }
                public MultiplyClass PerkTierUpgrade { get; set; }
            }

            public partial class ConsumableRandomBonus
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public List<ConsumableRandomBonusGroup> Groups { get; set; }
            }

            public partial class ConsumableRandomBonusGroup
            {
                public bool RequireTarget { get; set; }
                public SelfSuccessGroupRule Rule { get; set; }
                public List<Buff11> Buffs { get; set; }
            }

            public partial class Buff11
            {
                public ActionTarget Name { get; set; }
                public double Duration { get; set; }
                public MultiplyClass RandomBonus { get; set; }
            }

            public partial class ConsumableSpecialRevive
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public List<ConsumableSpecialReviveGroup> Groups { get; set; }
                public ConsumableHealthPackMetaData MetaData { get; set; }
            }

            public partial class ConsumableSpecialReviveGroup
            {
                public bool RequireTarget { get; set; }
                public SelfSuccessGroupRule Rule { get; set; }
                public List<IndecentBuff> Buffs { get; set; }
            }

            public partial class EzapacAssault
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public string ActivationCost { get; set; }
                public string CastTime { get; set; }
                public string Duration { get; set; }
                public string Cooldown { get; set; }
                public long DropItemFlyGravityCompensation { get; set; }
                public long DropItemThrowSpeed { get; set; }
                public long DropItemSpeed { get; set; }
                public string DropItemReboundBehaviour { get; set; }
                public long DropItemFlyDurationMax { get; set; }
                public FxTypeEnum TrajectoryFxType { get; set; }
                public string DropItemFreeFallTrajectoryFxType { get; set; }
                public double DropItemFreeFallTrajectorySimulationSecondsPerTick { get; set; }
                public long MaxDropItemsOnScene { get; set; }
                public bool ActivationOnRelease { get; set; }
                public double PrepareTimeRelease { get; set; }
                public string AnimationType { get; set; }
                public long AnimationTimeScale { get; set; }
                public List<EzapacAssaultGroup> Groups { get; set; }
                public EzapacAssaultMetaData MetaData { get; set; }
            }

            public partial class EzapacAssaultGroup
            {
                public string IsEnabled { get; set; }
                public string TargetSelectionTime { get; set; }
                public SelfSuccessGroupRule Rule { get; set; }
                public List<DeactivatedEntitiesOwnersBuffElement> Buffs { get; set; }
            }

            public partial class EzapacAssaultMetaData
            {
                public List<string> Upgrades { get; set; }
                public Modifiers12 Modifiers { get; set; }
                public string DropItem { get; set; }
            }

            public partial class Modifiers12
            {
                public Additive6 Additive { get; set; }
                public IndecentUi Ui { get; set; }
            }

            public partial class Additive6
            {
                public long AbilityEzapacAssaultCooldown { get; set; }
                public long AbilityEzapacAssaultDuration { get; set; }
                public long AbilityEzapacAssaultActivationcost { get; set; }
                public double AbilityEzapacAssaultResistanceStack { get; set; }
                public long AbilityEzapacAssaultArmorGroupEnabled { get; set; }
                public long AbilityEzapacAssaultRadius { get; set; }
            }

            public partial class IndecentUi
            {
                public long UiDuration { get; set; }
                public long UiCooldown { get; set; }
                public long UiActivationcost { get; set; }
                public long UiEffectDuration { get; set; }
                public long UiRange { get; set; }
                public long UiEffectAmount { get; set; }
                public long UiEffectAmountMax { get; set; }
                public long UiDotDuration { get; set; }
                public long UiDotDamage { get; set; }
                public long UiDotdps { get; set; }
            }

            public partial class EzapacAssaultPassiveClass
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public List<EzapacAssaultPassiveGroup> Groups { get; set; }
                public ConsumableHealthPackMetaData MetaData { get; set; }
            }

            public partial class EzapacAssaultPassiveGroup
            {
                public DeactivatedEntitiesOwnersRuleElement Rule { get; set; }
                public string TargetSelectionTime { get; set; }
                public List<Buff12> Buffs { get; set; }
            }

            public partial class Buff12
            {
                public PurpleName Name { get; set; }
                public long Priority { get; set; }
                public List<PurpleCategory> Categories { get; set; }
                public long Duration { get; set; }
                public double SpeedScale { get; set; }
                public bool Rebuff { get; set; }
            }

            public partial class EzapacMedic
            {
                public TypeElement Type { get; set; }
                public string ClientName { get; set; }
                public string ActivationCost { get; set; }
                public long CastTime { get; set; }
                public string Duration { get; set; }
                public string Cooldown { get; set; }
                public long MaxDropItemsOnScene { get; set; }
                public bool ActivationOnRelease { get; set; }
                public long DropItemFlyGravityCompensation { get; set; }
                public bool CanBeStoppedManually { get; set; }
                public long DropItemThrowSpeed { get; set; }
                public string DropItemReboundBehaviour { get; set; }
                public FxTypeEnum TrajectoryFxType { get; set; }
                public double PrepareTimeRelease { get; set; }
                public long AnimationTimeScale { get; set; }
                public string AnimationType { get; set; }
                public EzapacMedicMetaData MetaData { get; set; }
            }

            public partial class EzapacMedicMetaData
            {
                public List<string> Upgrades { get; set; }
                public Modifiers13 Modifiers { get; set; }
                public string DropItem { get; set; }
            }

            public partial class Modifiers13
            {
                public Dictionary<string, long> Additive { get; set; }
                public HilariousUi Ui { get; set; }
            }

            public partial class HilariousUi
            {
                public long UiDuration { get; set; }
                public long UiCooldown { get; set; }
                public long UiActivationcost { get; set; }
                public long UiDeployableHealth { get; set; }
                public long UiHealAmount { get; set; }
                public long UiHealInterval { get; set; }
            }

            public partial class EzapacMedicHeavyPassive
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public List<EzapacMedicHeavyPassiveGroup> Groups { get; set; }
                public EzapacMedicHeavyPassiveMetaData MetaData { get; set; }
            }

            public partial class EzapacMedicHeavyPassiveGroup
            {
                public bool IsEnabled { get; set; }
                public AmbitiousRule Rule { get; set; }
                public string TargetSelectionTime { get; set; }
                public List<Buff13> Buffs { get; set; }
            }

            public partial class Buff13
            {
                public SlotElement Name { get; set; }
                public long Priority { get; set; }
                public double Duration { get; set; }
                public string ForceRevive { get; set; }
                public string KeptAfterDeathRemove { get; set; }
            }

            public partial class AmbitiousRule
            {
                public TriggerTypeEnum Type { get; set; }
                public bool? IncludeDead { get; set; }
            }

            public partial class EzapacMedicHeavyPassiveMetaData
            {
                public List<string> Upgrades { get; set; }
                public Modifiers14 Modifiers { get; set; }
            }

            public partial class Modifiers14
            {
                public Additive7 Additive { get; set; }
            }

            public partial class Additive7
            {
                public long EzapacMedicHeavyPassiveReviveAmount { get; set; }
            }

            public partial class EzapacMedicPrimaryPassive
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public List<EzapacMedicPrimaryPassiveGroup> Groups { get; set; }
            }

            public partial class EzapacMedicPrimaryPassiveGroup
            {
                public DeactivatedEntitiesOwnersRuleElement Rule { get; set; }
                public string TargetSelectionTime { get; set; }
                public List<Buff14> Buffs { get; set; }
            }

            public partial class Buff14
            {
                public string Name { get; set; }
                public long Priority { get; set; }
                public bool? IsActivatedOnPeriodEnd { get; set; }
                public List<string> Categories { get; set; }
                public List<BuffImmuneAddElement> BuffImmuneAbsoluteAdd { get; set; }
                public long Duration { get; set; }
                public double? Period { get; set; }
                public long? HealthAdd { get; set; }
                public bool Rebuff { get; set; }
                public bool? UniqName { get; set; }
                public long? Utility { get; set; }
                public bool? ForceVisible { get; set; }
                public bool? IsCasterSpecialTrigger { get; set; }
            }

            public partial class EzapacSniper
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public string ActivationCost { get; set; }
                public string CastTime { get; set; }
                public string Duration { get; set; }
                public string Cooldown { get; set; }
                public bool ActivationOnRelease { get; set; }
                public List<FluffyGroup> Groups { get; set; }
                public EzapacSniperBuffAura BuffAura { get; set; }
                public List<BelssoAssaultHeavyPassiveGroup> BuffAuraGroups { get; set; }
                public EzapacSniperMetaData MetaData { get; set; }
            }

            public partial class EzapacSniperBuffAura
            {
                public DisplayMarkerTeamRuleEnum TeamRule { get; set; }
                public TriggerType TriggerType { get; set; }
                public bool Collision { get; set; }
                public string Radius { get; set; }
                public double UpdatePeriod { get; set; }
                public double Duration { get; set; }
                public bool IgnoreHeightCheck { get; set; }
                public string KeptAfterDeathRemove { get; set; }
                public long? AffectedHumansLimit { get; set; }
            }

            public partial class FluffyGroup
            {
                public AmbitiousRule Rule { get; set; }
                public string TargetSelectionTime { get; set; }
                public bool? CastOnHumanLure { get; set; }
                public List<Buff15> Buffs { get; set; }
                public string IsEnabled { get; set; }
            }

            public partial class Buff15
            {
                public string Name { get; set; }
                public long Priority { get; set; }
                public List<string> Categories { get; set; }
                public StaminaAdd Duration { get; set; }
                public bool Rebuff { get; set; }
                public bool? Aura { get; set; }
                public string KeptAfterDeathRemove { get; set; }
                public bool? IsActivatedOnPeriodEnd { get; set; }
                public List<string> BuffImmuneAbsoluteAdd { get; set; }
                public string Period { get; set; }
                public string HealthAdd { get; set; }
                public bool? UniqName { get; set; }
                public long? Utility { get; set; }
            }

            public partial class EzapacSniperMetaData
            {
                public List<string> Upgrades { get; set; }
                public Modifiers15 Modifiers { get; set; }
            }

            public partial class Modifiers15
            {
                public Dictionary<string, double> Additive { get; set; }
                public AmbitiousUi Ui { get; set; }
            }

            public partial class AmbitiousUi
            {
                public long UiDuration { get; set; }
                public long UiCooldown { get; set; }
                public long UiActivationcost { get; set; }
                public long UiDamage { get; set; }
                public long? UiDps { get; set; }
                public long? UiDpshs { get; set; }
                public long UiEffectDuration { get; set; }
                public long? UiEffectRange { get; set; }
                public long? UiRange { get; set; }
                public long? UiDeployableHealth { get; set; }
            }

            public partial class EzapacSupport
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public string Cooldown { get; set; }
                public string Duration { get; set; }
                public string ActivationCost { get; set; }
                public bool ActivationOnRelease { get; set; }
                public List<EzapacSupportGroup> Groups { get; set; }
                public EzapacSupportMetaData MetaData { get; set; }
            }

            public partial class EzapacSupportGroup
            {
                public bool StopBuffsWithAbility { get; set; }
                public string TargetSelectionTime { get; set; }
                public PurpleRule Rule { get; set; }
                public List<Buff16> Buffs { get; set; }
                public string IsEnabled { get; set; }
            }

            public partial class Buff16
            {
                public string Name { get; set; }
                public long? Priority { get; set; }
                public List<string> Categories { get; set; }
                public bool? WeaponsAimRestricted { get; set; }
                public long? WpnAutoAimPrimary { get; set; }
                public double? WpnSpreadConeMaxModPrimary { get; set; }
                public double? WpnSpreadConeMinPrimary { get; set; }
                public string SpeedScale { get; set; }
                public double? Duration { get; set; }
                public bool? Rebuff { get; set; }
                public long? StaminaAdd { get; set; }
            }

            public partial class EzapacSupportMetaData
            {
                public List<string> Upgrades { get; set; }
                public Modifiers16 Modifiers { get; set; }
            }

            public partial class Modifiers16
            {
                public Additive8 Additive { get; set; }
                public PurpleUi Ui { get; set; }
            }

            public partial class Additive8
            {
                public long AbilityEzapacSupportCooldown { get; set; }
                public long AbilityEzapacSupportDuration { get; set; }
                public long AbilityEzapacSupportActivationcost { get; set; }
                public long AbilityEzapacSupportSlowGroupEnabled { get; set; }
                public long AbilityEzapacSupportSlowDuration { get; set; }
                public double AbilityEzapacSupportSlowValue { get; set; }
                public double AbilityEzapacSupportSelfSlowValue { get; set; }
            }

            public partial class Fsb2004Assault
            {
                public NameEnum Type { get; set; }
                public string ClientName { get; set; }
                public string Cooldown { get; set; }
                public string Duration { get; set; }
                public string ActivationCost { get; set; }
                public bool ActivationOnRelease { get; set; }
                public bool CanBeStoppedManually { get; set; }
                public List<Fsb2004AssaultGroup> Groups { get; set; }
                public Fsb2004AssaultMetaData MetaData { get; set; }
            }

            public partial class Fsb2004AssaultGroup
            {
                public PurpleTargetSelectionTime TargetSelectionTime { get; set; }
                public bool StopBuffsWithAbility { get; set; }
                public SelfSuccessGroupRule Rule { get; set; }
                public List<Buff17> Buffs { get; set; }
                public string IsEnabled { get; set; }
            }

            public partial class Buff17
            {
                public string Name { get; set; }
                public long Priority { get; set; }
                public List<string> Categories { get; set; }
                public string Duration { get; set; }
                public double? WpnSpreadConeMaxModPrimary { get; set; }
                public double? WpnSpreadConeMinPrimary { get; set; }
                public double? WpnRecoilMultPrimary { get; set; }
                public List<string> BuffImmuneAbsoluteAdd { get; set; }
                public double? SpeedScale { get; set; }
                public bool? SprintLock { get; set; }
            }

            public partial class Fsb2004AssaultMetaData
            {
                public List<string> Upgrades { get; set; }
                public Modifiers17 Modifiers { get; set; }
            }

            public partial class Modifiers17
            {
                public Additive9 Additive { get; set; }
                public FluffyUi Ui { get; set; }
            }

            public partial class Additive9
            {
                public long AbilityFsb2004AssaultCooldown { get; set; }
                public long AbilityFsb2004AssaultDuration { get; set; }
                public long AbilityFsb2004AssaultActivationcost { get; set; }
                public long AbilityFsb2004AssaultSuppressImmunityGroupEnabled { get; set; }
            }

            public partial class Fsb2004Medic
            {
                public FxTypeEnum Type { get; set; }
                public string ClientName { get; set; }
                public string Cooldown { get; set; }
                public string Duration { get; set; }
                public string ActivationCost { get; set; }
                public bool ActivationOnRelease { get; set; }
                public bool ActivationOnHold { get; set; }
                public double ActivationOnHoldDuration { get; set; }
                public List<Fsb2004MedicGroup> Groups { get; set; }
                public Fsb2004MedicMetaData MetaData { get; set; }
            }

            public partial class Fsb2004MedicGroup
            {
                public string TargetSelectionTime { get; set; }
                public bool RequireTarget { get; set; }
                public bool? ShowTargets { get; set; }
                public IndecentRule Rule { get; set; }
                public List<PurpleBuff> Buffs { get; set; }
            }

            public partial class PurpleBuff
            {
                public string IsEnabled { get; set; }
                public string Name { get; set; }
                public long Priority { get; set; }
                public List<string> Categories { get; set; }
                public string Duration { get; set; }
                public string Period { get; set; }
                public string StaminaAdd { get; set; }
                public string HealthAdd { get; set; }
                public bool? Rebuff { get; set; }
                public bool? IsActivatedOnPeriodEnd { get; set; }
                public long? RebuffStack { get; set; }
            }

            public partial class Fsb2004MedicMetaData
            {
                public List<string> Upgrades { get; set; }
                public Modifiers18 Modifiers { get; set; }
            }

            public partial class Modifiers18
            {
                public Dictionary<string, long> Additive { get; set; }
                public Dictionary<string, double> Ui { get; set; }
            }

            public partial class Fsb2004Sniper
            {
                public string Type { get; set; }
                public FxTypeEnum FxType { get; set; }
                public string ClientName { get; set; }
                public string Cooldown { get; set; }
                public string Duration { get; set; }
                public string ActivationCost { get; set; }
                public string FxRadius { get; set; }
                public bool ActivationOnRelease { get; set; }
                public List<Fsb2004SniperGroup> Groups { get; set; }
                public Fsb2004SniperMetaData MetaData { get; set; }
            }

            public partial class Fsb2004SniperGroup
            {
                public CunningRule Rule { get; set; }
                public bool CastOnHumanLure { get; set; }
                public List<StickyBuff> Buffs { get; set; }
            }

            public partial class CunningRule
            {
                public PurpleType Type { get; set; }
                public List<IndecentChildRule> ChildRules { get; set; }
            }

            public partial class IndecentChildRule
            {
                public TriggerTypeEnum Type { get; set; }
                public string Range { get; set; }
                public string ConeAngle { get; set; }
            }

            public partial class Fsb2004SniperMetaData
            {
                public List<string> Upgrades { get; set; }
                public Modifiers19 Modifiers { get; set; }
            }

            public partial class Modifiers19
            {
                public Additive10 Additive { get; set; }
                public PurpleUi Ui { get; set; }
            }

            public partial class Additive10
            {
                public long AbilityFsb2004SniperCooldown { get; set; }
                public long AbilityFsb2004SniperDuration { get; set; }
                public long AbilityFsb2004SniperActivationcost { get; set; }
                public long AbilityFsb2004SniperRange { get; set; }
                public long AbilityFsb2004SniperConeAngle { get; set; }
                public double AbilityFsb2004SniperMarkDuration { get; set; }
            }

            public partial class Fsb2004SniperPassive
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public List<Fsb2004SniperPassiveGroup> Groups { get; set; }
                public Fsb2004SniperPassiveMetaData MetaData { get; set; }
            }

            public partial class Fsb2004SniperPassiveGroup
            {
                public SelfSuccessGroupRule Rule { get; set; }
                public string TargetSelectionTime { get; set; }
                public List<FluffyBuff> Buffs { get; set; }
            }

            public partial class Fsb2004SniperPassiveMetaData
            {
                public List<object> Upgrades { get; set; }
                public Modifiers20 Modifiers { get; set; }
            }

            public partial class Modifiers20
            {
                public Additive11 Additive { get; set; }
                public FluffyUi Ui { get; set; }
            }

            public partial class Additive11
            {
                public long AbilityFsb2004SniperPassiveStaminablowStaminaAdd { get; set; }
            }

            public partial class Fsb2004SniperPassive2
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public List<Fsb2004SniperPassive2Group> Groups { get; set; }
                public Fsb2004SniperPassive2MetaData MetaData { get; set; }
            }

            public partial class Fsb2004SniperPassive2Group
            {
                public DeactivatedEntitiesOwnersRuleElement Rule { get; set; }
                public string TargetSelectionTime { get; set; }
                public List<Buff18> Buffs { get; set; }
            }

            public partial class Buff18
            {
                public string Name { get; set; }
                public long Priority { get; set; }
                public List<BuffImmuneAbsoluteAdd> Categories { get; set; }
                public double Duration { get; set; }
                public double? WpnReloadTimeModPrimaryScale { get; set; }
                public double? WpnReloadTimeModSecondaryScale { get; set; }
                public double? WpnReloadTimeModHeavyScale { get; set; }
                public bool Rebuff { get; set; }
                public double? WpnDamagePrimaryScale { get; set; }
                public long? Stun { get; set; }
                public bool? ForceVisible { get; set; }
                public long? WpnRefillHeavyClip { get; set; }
            }

            public partial class Fsb2004SniperPassive2MetaData
            {
                public List<object> Upgrades { get; set; }
                public Modifiers21 Modifiers { get; set; }
            }

            public partial class Modifiers21
            {
                public MultiplyClass Additive { get; set; }
                public CunningUi Ui { get; set; }
            }

            public partial class CunningUi
            {
                public long UiEffectDuration { get; set; }
            }

            public partial class Fsb2004Support
            {
                public string ClientName { get; set; }
                public string Cooldown { get; set; }
                public string Duration { get; set; }
                public string ActivationCost { get; set; }
                public bool ActivationOnRelease { get; set; }
                public List<Fsb2004SupportGroup> Groups { get; set; }
                public Fsb2004SupportMetaData MetaData { get; set; }
            }

            public partial class Fsb2004SupportGroup
            {
                public PurpleTargetSelectionTime TargetSelectionTime { get; set; }
                public bool StopBuffsWithAbility { get; set; }
                public bool? StopAbilityWithBuff { get; set; }
                public DeactivatedEntitiesOwnersRuleElement Rule { get; set; }
                public List<Buff19> Buffs { get; set; }
                public string IsEnabled { get; set; }
            }

            public partial class Buff19
            {
                public string Name { get; set; }
                public long Priority { get; set; }
                public List<string> Categories { get; set; }
                public string ShieldAdd { get; set; }
                public bool? Rebuff { get; set; }
                public PurpleIncomingDamageMod IncomingDamageMod { get; set; }
                public string SpeedScale { get; set; }
                public bool? SprintLock { get; set; }
            }

            public partial class Fsb2004SupportMetaData
            {
                public List<string> Upgrades { get; set; }
                public Modifiers22 Modifiers { get; set; }
            }

            public partial class Modifiers22
            {
                public Additive12 Additive { get; set; }
                public FluffyUi Ui { get; set; }
            }

            public partial class Additive12
            {
                public long AbilityFsb2004SupportCooldown { get; set; }
                public double AbilityFsb2004SupportDuration { get; set; }
                public long AbilityFsb2004SupportActivationcost { get; set; }
                public double AbilityFsb2004SupportSelfSlowSlow { get; set; }
                public long AbilityFsb2004SupportShieldShieldAdd { get; set; }
                public long AbilityFsb2004SupportSelfSlowEnabled { get; set; }
            }

            public partial class Fsb2016Assault
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public string ActivationCost { get; set; }
                public string Duration { get; set; }
                public string Cooldown { get; set; }
                public bool ActivationOnRelease { get; set; }
                public bool CanBeStoppedManually { get; set; }
                public List<Fsb2016AssaultGroup> Groups { get; set; }
                public BelssoMedicMetaData MetaData { get; set; }
            }

            public partial class Fsb2016AssaultGroup
            {
                public bool? StopBuffsWithAbility { get; set; }
                public SelfSuccessGroupRule Rule { get; set; }
                public string TargetSelectionTime { get; set; }
                public List<Buff20> Buffs { get; set; }
                public string IsEnabled { get; set; }
            }

            public partial class Buff20
            {
                public string Name { get; set; }
                public long Priority { get; set; }
                public List<string> Categories { get; set; }
                public StaminaAdd Duration { get; set; }
                public long? WpnBurstShotPrimarySet { get; set; }
                public double? WpnRateOfBurstPrimarySet { get; set; }
                public double? WpnFirstShotModifierMultPrimary { get; set; }
                public long? WpnHumanPerforationLimitPrimaryAdd { get; set; }
                public string WpnDamagePrimaryScale { get; set; }
                public long? WpnArmorPenetrationPrimary { get; set; }
                public bool? WpnAutomaticFirePrimary { get; set; }
                public long? WpnKickHorMeanAimMultPrimary { get; set; }
                public long? WpnKickHorDeviationAimMultPrimary { get; set; }
                public double? WpnRateOfFireModPrimaryScale { get; set; }
                public long? RebuffStack { get; set; }
                public long? Period { get; set; }
                public string HealthAdd { get; set; }
                public bool? Rebuff { get; set; }
                public double? WpnReloadTimeModPrimaryScale { get; set; }
            }

            public partial class Fsb2016AssaultZaryaPassive
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public List<Fsb2016AssaultZaryaPassiveGroup> Groups { get; set; }
                public Fsb2016AssaultZaryaPassiveMetaData MetaData { get; set; }
            }

            public partial class Fsb2016AssaultZaryaPassiveGroup
            {
                public DeactivatedEntitiesOwnersRuleElement Rule { get; set; }
                public AuraBuffGroupTargetSelectionTime TargetSelectionTime { get; set; }
                public List<Buff21> Buffs { get; set; }
            }

            public partial class Buff21
            {
                public FluffyName Name { get; set; }
                public long Priority { get; set; }
                public List<BuffImmuneAbsoluteAdd> Categories { get; set; }
                public bool Rebuff { get; set; }
                public string Duration { get; set; }
                public string Stun { get; set; }
            }

            public partial class Fsb2016AssaultZaryaPassiveMetaData
            {
                public List<string> Upgrades { get; set; }
                public Modifiers23 Modifiers { get; set; }
            }

            public partial class Modifiers23
            {
                public Additive13 Additive { get; set; }
                public FluffyUi Ui { get; set; }
            }

            public partial class Additive13
            {
                public long AbilityFsb2016AssaultZaryaPassiveStunDuration { get; set; }
            }

            public partial class Fsb2016Medic
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public string Cooldown { get; set; }
                public string Duration { get; set; }
                public string UpkeepCost { get; set; }
                public long ActivationCost { get; set; }
                public bool ActivationOnHold { get; set; }
                public string CustomStopType { get; set; }
                public List<Fsb2016MedicGroup> Groups { get; set; }
                public BelssoMedicMetaData MetaData { get; set; }
            }

            public partial class Fsb2016MedicGroup
            {
                public string TargetSelectionTime { get; set; }
                public bool RequireTarget { get; set; }
                public bool ShowTargets { get; set; }
                public MagentaRule Rule { get; set; }
                public List<PurpleBuff> Buffs { get; set; }
            }

            public partial class MagentaRule
            {
                public PurpleType Type { get; set; }
                public List<HilariousChildRule> ChildRules { get; set; }
            }

            public partial class HilariousChildRule
            {
                public string Type { get; set; }
                public long? ConeAngle { get; set; }
                public string Range { get; set; }
                public bool? OnlyNearest { get; set; }
                public bool? OnlyVisible { get; set; }
                public bool? IncludeTargeted { get; set; }
                public BuffImmuneAddElement? BuffCategory { get; set; }
            }

            public partial class Fsb2016MedicPassive
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public List<The22Spn2016SniperPassiveGroup> Groups { get; set; }
                public Fsb2016MedicPassiveMetaData MetaData { get; set; }
            }

            public partial class Fsb2016MedicPassiveMetaData
            {
                public List<object> Upgrades { get; set; }
                public Modifiers24 Modifiers { get; set; }
            }

            public partial class Modifiers24
            {
                public MultiplyClass Additive { get; set; }
            }

            public partial class Fsb2016MedicPassive2
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public List<The22Spn2016SniperPassiveGroup> Groups { get; set; }
                public ConsumableHealthPackMetaData MetaData { get; set; }
            }

            public partial class Fsb2016MedicZaryaPassive
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public List<Fsb2016AssaultZaryaPassiveGroup> Groups { get; set; }
                public Fsb2016MedicZaryaPassiveMetaData MetaData { get; set; }
            }

            public partial class Fsb2016MedicZaryaPassiveMetaData
            {
                public List<string> Upgrades { get; set; }
                public Modifiers25 Modifiers { get; set; }
            }

            public partial class Modifiers25
            {
                public Additive14 Additive { get; set; }
                public FluffyUi Ui { get; set; }
            }

            public partial class Additive14
            {
                public long AbilityFsb2016MedicZaryaPassiveStunDuration { get; set; }
            }

            public partial class Fsb2016Sniper
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public string Cooldown { get; set; }
                public string Duration { get; set; }
                public string ActivationCost { get; set; }
                public bool ActivationOnRelease { get; set; }
                public List<Fsb2016SniperGroup> Groups { get; set; }
                public Fsb2016SniperMetaData MetaData { get; set; }
            }

            public partial class Fsb2016SniperGroup
            {
                public string IsEnabled { get; set; }
                public bool? StopBuffsWithAbility { get; set; }
                public StickyRule Rule { get; set; }
                public string TargetSelectionTime { get; set; }
                public List<Buff22> Buffs { get; set; }
            }

            public partial class Buff22
            {
                public string Name { get; set; }
                public long? Priority { get; set; }
                public List<string> Categories { get; set; }
                public StaminaAdd Duration { get; set; }
                public long? UsageLimit { get; set; }
                public string PrimaryAbilityActiveExtentionAdd { get; set; }
                public bool? Rebuff { get; set; }
                public long? WpnSpreadRestoreSpeedPrimaryScale { get; set; }
                public bool? WpnIsDamageCurveIgnoredPrimary { get; set; }
                public long? WpnRateOfFireModPrimaryScale { get; set; }
                public double? WpnSpreadRestoreDelayPrimaryScale { get; set; }
                public double? WpnReloadTimeModPrimaryScale { get; set; }
                public bool? WpnIsManuallyCycledPrimary { get; set; }
                public bool? WpnCycleBoltAnimationOffPrimary { get; set; }
                public double? WpnSpreadConeMovementAddPrimaryScale { get; set; }
                public bool? ForceVisibleToAll { get; set; }
                public double? ReviveMeOverideTime { get; set; }
                public string KeptAfterDeathRemove { get; set; }
            }

            public partial class Fsb2016SniperMetaData
            {
                public List<string> Upgrades { get; set; }
                public PurpleModifiers Modifiers { get; set; }
            }

            public partial class PurpleModifiers
            {
                public Dictionary<string, double> Additive { get; set; }
                public PurpleUi Ui { get; set; }
            }

            public partial class Fsb2016SniperMinePassive
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public List<Fsb2016SniperMinePassiveGroup> Groups { get; set; }
                public Fsb2016SniperMinePassiveMetaData MetaData { get; set; }
            }

            public partial class Fsb2016SniperMinePassiveGroup
            {
                public string IsEnabled { get; set; }
                public DeactivatedEntitiesOwnersRuleElement Rule { get; set; }
                public AuraBuffGroupTargetSelectionTime TargetSelectionTime { get; set; }
                public List<Buff23> Buffs { get; set; }
            }

            public partial class Buff23
            {
                public string Name { get; set; }
                public long Priority { get; set; }
                public List<BuffImmuneAddElement> Categories { get; set; }
                public bool Rebuff { get; set; }
                public long Duration { get; set; }
                public double? SpeedScale { get; set; }
                public bool? SprintLock { get; set; }
            }

            public partial class Fsb2016SniperMinePassiveMetaData
            {
                public List<object> Upgrades { get; set; }
                public Modifiers26 Modifiers { get; set; }
            }

            public partial class Modifiers26
            {
                public Additive15 Additive { get; set; }
                public FluffyUi Ui { get; set; }
            }

            public partial class Additive15
            {
                public long Fsb2016SniperMineSlowAoEOnImpactGroupEnabled { get; set; }
            }

            public partial class Fsb2016Support
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public string Cooldown { get; set; }
                public string Duration { get; set; }
                public string ActivationCost { get; set; }
                public bool HideAuraFromEnemy { get; set; }
                public bool ActivationOnRelease { get; set; }
                public List<Fsb2016SupportGroup> Groups { get; set; }
                public Fsb2016SupportBuffAura BuffAura { get; set; }
                public List<Fsb2016SupportBuffAuraGroup> BuffAuraGroups { get; set; }
                public BelssoMedicMetaData MetaData { get; set; }
            }

            public partial class Fsb2016SupportBuffAura
            {
                public DisplayMarkerTeamRuleEnum TeamRule { get; set; }
                public double Radius { get; set; }
                public long UpdatePeriod { get; set; }
                public string Duration { get; set; }
                public TriggerType TriggerType { get; set; }
                public string FxType { get; set; }
                public string KeptAfterDeathRemove { get; set; }
            }

            public partial class Fsb2016SupportBuffAuraGroup
            {
                public AuraBuffGroupTargetSelectionTime TargetSelectionTime { get; set; }
                public SelfSuccessGroupRule Rule { get; set; }
                public List<Buff24> Buffs { get; set; }
            }

            public partial class Buff24
            {
                public NameEnum Name { get; set; }
                public long Priority { get; set; }
                public List<BuffImmuneAbsoluteAdd> Categories { get; set; }
                public string Duration { get; set; }
                public bool Rebuff { get; set; }
                public double WpnReloadTimeModPrimaryScale { get; set; }
                public double WpnReloadTimeModSecondaryScale { get; set; }
            }

            public partial class Fsb2016SupportGroup
            {
                public SelfSuccessGroupRule Rule { get; set; }
                public string TargetSelectionTime { get; set; }
                public List<Buff25> Buffs { get; set; }
                public string IsEnabled { get; set; }
            }

            public partial class Buff25
            {
                public string Name { get; set; }
                public long Priority { get; set; }
                public List<string> Categories { get; set; }
                public string Duration { get; set; }
                public bool? WeaponsAimRestricted { get; set; }
                public bool? Rebuff { get; set; }
                public string WarmingSpeed { get; set; }
                public double? CooldownSpeed { get; set; }
                public long? WpnSpreadConeMaxModPrimary { get; set; }
                public long? WpnSpreadConeMaxModSecondary { get; set; }
                public long? WpnSpreadConeMaxModHeavy { get; set; }
                public long? WpnSpreadConeMinPrimary { get; set; }
                public long? WpnSpreadConeMinSecondary { get; set; }
                public long? WpnSpreadConeMinHeavy { get; set; }
                public bool? Aura { get; set; }
            }

            public partial class Fsb2016SupportGm94PassiveClass
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public List<Fsb2016SniperMinePassiveGroup> Groups { get; set; }
                public ConsumableHealthPackMetaData MetaData { get; set; }
            }

            public partial class Fsb2016SupportPassive
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public List<Fsb2004SniperPassiveGroup> Groups { get; set; }
                public ConsumableHealthPackMetaData MetaData { get; set; }
            }

            public partial class Grom2014Assault
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public string ActivationCost { get; set; }
                public string CastTime { get; set; }
                public string Duration { get; set; }
                public string Cooldown { get; set; }
                public bool ActivationOnRelease { get; set; }
                public List<Grom2014AssaultGroup> Groups { get; set; }
                public Grom2014AssaultMetaData MetaData { get; set; }
            }

            public partial class Grom2014AssaultGroup
            {
                public DeactivatedEntitiesOwnersRuleElement Rule { get; set; }
                public string TargetSelectionTime { get; set; }
                public List<Buff7> Buffs { get; set; }
                public string IsEnabled { get; set; }
            }

            public partial class Grom2014AssaultMetaData
            {
                public List<string> Upgrades { get; set; }
                public Modifiers27 Modifiers { get; set; }
            }

            public partial class Modifiers27
            {
                public Additive16 Additive { get; set; }
                public PurpleUi Ui { get; set; }
            }

            public partial class Additive16
            {
                public long AbilityGrom2014AssaultActivationcost { get; set; }
                public long AbilityGrom2014AssaultCasttime { get; set; }
                public long AbilityGrom2014AssaultDuration { get; set; }
                public long AbilityGrom2014AssaultCooldown { get; set; }
                public long AbilityGrom2014AssaultSilenceDuration { get; set; }
            }

            public partial class Grom2014Medic
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public string ActivationCost { get; set; }
                public string CastTime { get; set; }
                public string Duration { get; set; }
                public string Cooldown { get; set; }
                public string MaxDropItemsOnScene { get; set; }
                public bool ActivationOnRelease { get; set; }
                public The22Spn2016MedicMetaData MetaData { get; set; }
            }

            public partial class Grom2014MedicM500PassiveClass
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public List<The22Spn2016SupportPassiveGroup> Groups { get; set; }
                public ConsumableHealthPackMetaData MetaData { get; set; }
            }

            public partial class The22Spn2016SupportPassiveGroup
            {
                public DeactivatedEntitiesOwnersRuleElement Rule { get; set; }
                public string TargetSelectionTime { get; set; }
                public List<SelfSuccessBuff> Buffs { get; set; }
            }

            public partial class Grom2014MedicP1A6Passive
            {
                public TypeEnum Type { get; set; }
                public TypeEnum ClientName { get; set; }
                public List<Fsb2016AssaultZaryaPassiveGroup> Groups { get; set; }
                public Grom2014MedicP1A6PassiveMetaData MetaData { get; set; }
            }

            public partial class Grom2014MedicP1A6PassiveMetaData
            {
                public List<string> Upgrades { get; set; }
                public Modifiers28 Modifiers { get; set; }
            }

            public partial class Modifiers28
            {
                public Additive17 Additive { get; set; }
                public FluffyUi Ui { get; set; }
            }

            public partial class Additive17
            {
                public long Grom2014MedicP1A6PassiveStunDuration { get; set; }
            }

            public partial class Grom2014Sniper
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public string ActivationCost { get; set; }
                public string CastTime { get; set; }
                public string Duration { get; set; }
                public string Cooldown { get; set; }
                public bool ActivationOnRelease { get; set; }
                public List<Grom2014SniperGroup> Groups { get; set; }
                public Grom2014SniperMetaData MetaData { get; set; }
            }

            public partial class Grom2014SniperGroup
            {
                public DeactivatedEntitiesOwnersRuleElement Rule { get; set; }
                public string TargetSelectionTime { get; set; }
                public List<PurpleBuff> Buffs { get; set; }
            }

            public partial class Grom2014SniperMetaData
            {
                public List<string> Upgrades { get; set; }
                public Modifiers29 Modifiers { get; set; }
            }

            public partial class Modifiers29
            {
                public Dictionary<string, long> Additive { get; set; }
                public AmbitiousUi Ui { get; set; }
            }

            public partial class Grom2014SniperMovPassive
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public List<Grom2014SniperMovPassiveGroup> Groups { get; set; }
                public ConsumableHealthPackMetaData MetaData { get; set; }
            }

            public partial class Grom2014SniperMovPassiveGroup
            {
                public string TargetSelectionTime { get; set; }
                public SelfSuccessGroupRule Rule { get; set; }
                public List<IndecentBuff> Buffs { get; set; }
            }

            public partial class Grom2014Support
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public string ActivationCost { get; set; }
                public string CastTime { get; set; }
                public string Duration { get; set; }
                public string Cooldown { get; set; }
                public long DropItemFlyGravityCompensation { get; set; }
                public long DropItemThrowSpeed { get; set; }
                public string DropItemReboundBehaviour { get; set; }
                public bool HideAuraFromEnemy { get; set; }
                public FxTypeEnum TrajectoryFxType { get; set; }
                public long MaxDropItemsOnScene { get; set; }
                public bool ActivationOnRelease { get; set; }
                public double PrepareTimeRelease { get; set; }
                public string AnimationType { get; set; }
                public double AnimationTimeScale { get; set; }
                public List<TentacledGroup> Groups { get; set; }
                public Fsb2016SupportBuffAura BuffAura { get; set; }
                public List<Grom2014SupportBuffAuraGroup> BuffAuraGroups { get; set; }
                public Grom2014SupportMetaData MetaData { get; set; }
            }

            public partial class Grom2014SupportBuffAuraGroup
            {
                public string TargetSelectionTime { get; set; }
                public SelfSuccessGroupRule Rule { get; set; }
                public List<Buff26> Buffs { get; set; }
            }

            public partial class Buff26
            {
                public string Name { get; set; }
                public long Priority { get; set; }
                public List<BuffImmuneAbsoluteAdd> Categories { get; set; }
                public double Duration { get; set; }
                public bool CloakScan { get; set; }
                public bool Rebuff { get; set; }
            }

            public partial class TentacledGroup
            {
                public IndigoRule Rule { get; set; }
                public string TargetSelectionTime { get; set; }
                public List<Buff1> Buffs { get; set; }
                public string IsEnabled { get; set; }
            }

            public partial class Grom2014SupportMetaData
            {
                public List<string> Upgrades { get; set; }
                public Modifiers30 Modifiers { get; set; }
                public string DropItem { get; set; }
            }

            public partial class Modifiers30
            {
                public Dictionary<string, double> Additive { get; set; }
                public MagentaUi Ui { get; set; }
            }

            public partial class MagentaUi
            {
                public long UiDuration { get; set; }
                public long UiCooldown { get; set; }
                public long UiActivationcost { get; set; }
                public long UiEffectDuration { get; set; }
                public long UiEffectRange { get; set; }
                public long UiSmokeDuration { get; set; }
            }

            public partial class Ksk2011Assault
            {
                public string Type { get; set; }
                public FxTypeEnum FxType { get; set; }
                public string ClientName { get; set; }
                public string Cooldown { get; set; }
                public string Duration { get; set; }
                public string ActivationCost { get; set; }
                public string FxRadius { get; set; }
                public bool ActivationOnRelease { get; set; }
                public string ActivationOnHold { get; set; }
                public double ActivationOnHoldDuration { get; set; }
                public List<Ksk2011AssaultGroup> Groups { get; set; }
                public AmfMedicMetaData MetaData { get; set; }
            }

            public partial class Ksk2011AssaultGroup
            {
                public CunningRule Rule { get; set; }
                public List<Buff27> Buffs { get; set; }
                public string IsEnabled { get; set; }
                public List<PurpleSelfSuccessGroup> SelfSuccessGroup { get; set; }
                public string TargetSelectionTime { get; set; }
                public bool? RequireTarget { get; set; }
                public bool? CastOnHumanLure { get; set; }
            }

            public partial class Buff27
            {
                public string Name { get; set; }
                public long Priority { get; set; }
                public List<string> Categories { get; set; }
                public WarmingSpeed Duration { get; set; }
                public bool? PrimaryAbilityLock { get; set; }
                public bool? PrimaryAbilityStop { get; set; }
                public bool? Rebuff { get; set; }
                public bool? ForcePersonallyVisible { get; set; }
                public RemoveDropItems RemoveDropItems { get; set; }
                public bool? Aura { get; set; }
                public bool? HideAuraFromEnemy { get; set; }
            }

            public partial class RemoveDropItems
            {
                public string FxType { get; set; }
                public SoundFxEnum SoundFx { get; set; }
                public long Radius { get; set; }
            }

            public partial class PurpleSelfSuccessGroup
            {
                public string TargetSelectionTime { get; set; }
                public bool RequireTarget { get; set; }
                public SelfSuccessGroupRule Rule { get; set; }
                public List<SelfSuccessBuff> Buffs { get; set; }
            }

            public partial class Ksk2011Medic
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public string DeathGift { get; set; }
                public bool ActivationOnRelease { get; set; }
                public string ActivationCost { get; set; }
                public string CastTime { get; set; }
                public double Duration { get; set; }
                public string Cooldown { get; set; }
                public string MaxDropItemsOnScene { get; set; }
                public long DropItemFlyGravityCompensation { get; set; }
                public long DropItemThrowSpeed { get; set; }
                public string DropItemReboundBehaviour { get; set; }
                public string TrajectoryFxType { get; set; }
                public double PrepareTimeRelease { get; set; }
                public string AnimationType { get; set; }
                public double AnimationTimeScale { get; set; }
                public Ksk2011MedicMetaData MetaData { get; set; }
            }

            public partial class Ksk2011MedicMetaData
            {
                public List<string> Upgrades { get; set; }
                public Modifiers18 Modifiers { get; set; }
                public string DropItem { get; set; }
            }

            public partial class Ksk2011MedicP1A6Passive
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public List<Fsb2016AssaultZaryaPassiveGroup> Groups { get; set; }
                public Ksk2011MedicP1A6PassiveMetaData MetaData { get; set; }
            }

            public partial class Ksk2011MedicP1A6PassiveMetaData
            {
                public List<string> Upgrades { get; set; }
                public Modifiers31 Modifiers { get; set; }
            }

            public partial class Modifiers31
            {
                public Additive18 Additive { get; set; }
                public FluffyUi Ui { get; set; }
            }

            public partial class Additive18
            {
                public long Ksk2011MedicP1A6PassiveStunDuration { get; set; }
            }

            public partial class Ksk2011Sniper
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public string Cooldown { get; set; }
                public string Duration { get; set; }
                public string ActivationCost { get; set; }
                public bool ActivationOnRelease { get; set; }
                public List<Ksk2011SniperGroup> Groups { get; set; }
                public Fsb2016SupportBuffAura BuffAura { get; set; }
                public List<Ksk2011SniperBuffAuraGroup> BuffAuraGroups { get; set; }
                public Ksk2011SniperMetaData MetaData { get; set; }
            }

            public partial class Ksk2011SniperBuffAuraGroup
            {
                public AuraBuffGroupTargetSelectionTime TargetSelectionTime { get; set; }
                public DeactivatedEntitiesOwnersRuleElement Rule { get; set; }
                public bool CastOnHumanLure { get; set; }
                public List<StickyBuff> Buffs { get; set; }
            }

            public partial class Ksk2011SniperGroup
            {
                public AmbitiousRule Rule { get; set; }
                public string TargetSelectionTime { get; set; }
                public bool? CastOnHumanLure { get; set; }
                public List<Buff28> Buffs { get; set; }
                public string IsEnabled { get; set; }
            }

            public partial class Buff28
            {
                public long? Id { get; set; }
                public string Name { get; set; }
                public long Priority { get; set; }
                public List<string> Categories { get; set; }
                public string Duration { get; set; }
                public bool Rebuff { get; set; }
                public bool? ForceVisible { get; set; }
                public bool? Aura { get; set; }
                public bool? RemoveAuraWithBuff { get; set; }
                public string KeptAfterDeathRemove { get; set; }
                public bool? OneActiveAtATime { get; set; }
                public long? ReviveMeOverideTime { get; set; }
                public double? SpeedScale { get; set; }
                public bool? SprintLock { get; set; }
            }

            public partial class Ksk2011SniperMetaData
            {
                public List<string> Upgrades { get; set; }
                public Modifiers32 Modifiers { get; set; }
            }

            public partial class Modifiers32
            {
                public Dictionary<string, long> Additive { get; set; }
                public PurpleUi Ui { get; set; }
            }

            public partial class Ksk2011Support
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public string ActivationCost { get; set; }
                public string Duration { get; set; }
                public string Cooldown { get; set; }
                public Ksk2011SupportFxType FxType { get; set; }
                public string FxRadius { get; set; }
                public bool ActivationOnRelease { get; set; }
                public bool ActivationOnHold { get; set; }
                public double ActivationOnHoldDuration { get; set; }
                public List<Ksk2011SupportGroup> Groups { get; set; }
                public Ksk2011SniperMetaData MetaData { get; set; }
            }

            public partial class Ksk2011SupportGroup
            {
                public string TargetSelectionTime { get; set; }
                public bool? RequireTarget { get; set; }
                public bool? ShowTargets { get; set; }
                public FriskyRule Rule { get; set; }
                public List<StickyBuff> Buffs { get; set; }
                public List<FluffySelfSuccessGroup> SelfSuccessGroup { get; set; }
                public string IsEnabled { get; set; }
            }

            public partial class FriskyRule
            {
                public PurpleType Type { get; set; }
                public List<AmbitiousChildRule> ChildRules { get; set; }
                public bool? StopBuffsWithAbility { get; set; }
            }

            public partial class AmbitiousChildRule
            {
                public string Type { get; set; }
                public string Range { get; set; }
                public bool? OnlyVisible { get; set; }
            }

            public partial class FluffySelfSuccessGroup
            {
                public string TargetSelectionTime { get; set; }
                public bool RequireTarget { get; set; }
                public bool StopBuffsWithAbility { get; set; }
                public SelfSuccessGroupRule Rule { get; set; }
                public List<StickyBuff> Buffs { get; set; }
            }

            public partial class Ksk2011SupportPassive
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public List<Ksk2011SupportPassiveGroup> Groups { get; set; }
                public ConsumableHealthPackMetaData MetaData { get; set; }
            }

            public partial class Ksk2011SupportPassiveGroup
            {
                public MischievousRule Rule { get; set; }
                public string TargetSelectionTime { get; set; }
                public List<FluffyBuff> Buffs { get; set; }
            }

            public partial class MischievousRule
            {
                public List<FluffyChildRule> ChildRules { get; set; }
            }

            public partial class Nesher2015Assault
            {
                public string Type { get; set; }
                public FxTypeEnum FxType { get; set; }
                public string ClientName { get; set; }
                public string Cooldown { get; set; }
                public string Duration { get; set; }
                public string ActivationCost { get; set; }
                public string FxRadius { get; set; }
                public bool ActivationOnRelease { get; set; }
                public List<Nesher2015AssaultGroup> Groups { get; set; }
                public Nesher2015AssaultMetaData MetaData { get; set; }
            }

            public partial class Nesher2015AssaultGroup
            {
                public DeactivatedEntitiesOwnersRuleElement Rule { get; set; }
                public PurpleTargetSelectionTime TargetSelectionTime { get; set; }
                public bool? StopBuffsWithAbility { get; set; }
                public List<Buff29> Buffs { get; set; }
                public string IsEnabled { get; set; }
            }

            public partial class Buff29
            {
                public string Name { get; set; }
                public long Priority { get; set; }
                public List<string> Categories { get; set; }
                public string Duration { get; set; }
                public string WpnDamagePrimaryScale { get; set; }
                public string WpnDamageSecondaryScale { get; set; }
                public CreatorBuffsByAffectingAuraIncomingDamageMod IncomingDamageMod { get; set; }
                public string IsEnabled { get; set; }
                public DamageCurve BorrowedTime { get; set; }
                public List<BuffImmuneAbsoluteAdd> BuffImmuneAbsoluteAdd { get; set; }
                public bool? Rebuff { get; set; }
            }

            public partial class DamageCurve
            {
                public double X { get; set; }
                public double Y { get; set; }
            }

            public partial class Nesher2015AssaultMetaData
            {
                public List<string> Upgrades { get; set; }
                public Modifiers33 Modifiers { get; set; }
            }

            public partial class Modifiers33
            {
                public Additive19 Additive { get; set; }
                public FriskyUi Ui { get; set; }
            }

            public partial class Additive19
            {
                public long AbilityNesher2015AssaultActivationcost { get; set; }
                public long AbilityNesher2015AssaultDuration { get; set; }
                public long AbilityNesher2015AssaultCooldown { get; set; }
                public long AbilityNesher2015AssaultStunImmunityGroupEnabled { get; set; }
                public double AbilityNesher2015AssaultDamage { get; set; }
                public double AbilityNesher2015AssaultIncomingDamage { get; set; }
            }

            public partial class FriskyUi
            {
                public long UiDuration { get; set; }
                public long UiCooldown { get; set; }
                public long UiActivationcost { get; set; }
                public long UiDamage { get; set; }
                public long UiIncomingDamage { get; set; }
            }

            public partial class Nesher2015AssaultPassive
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public List<Nesher2015AssaultPassiveGroup> Groups { get; set; }
            }

            public partial class Nesher2015AssaultPassiveGroup
            {
                public SelfSuccessGroupRule Rule { get; set; }
                public string TargetSelectionTime { get; set; }
                public List<SelfSuccessBuff> Buffs { get; set; }
            }

            public partial class Nesher2015Medic
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public string Cooldown { get; set; }
                public string ActivationCost { get; set; }
                public string CustomStopType { get; set; }
                public bool ActivationOnRelease { get; set; }
                public bool CanBeStoppedManually { get; set; }
                public long CastTime { get; set; }
                public string WardApplyingCost { get; set; }
                public List<Nesher2015MedicGroup> Groups { get; set; }
                public Fsb2004MedicMetaData MetaData { get; set; }
            }

            public partial class Nesher2015MedicGroup
            {
                public bool? RequireTarget { get; set; }
                public bool StopBuffsWithAbility { get; set; }
                public string TargetSelectionTime { get; set; }
                public IndecentRule Rule { get; set; }
                public List<Buff30> Buffs { get; set; }
                public string IsEnabled { get; set; }
            }

            public partial class Buff30
            {
                public string Name { get; set; }
                public long Priority { get; set; }
                public List<string> Categories { get; set; }
                public string Ward { get; set; }
                public CreatorBuffsByAffectingAuraIncomingDamageMod IncomingDamageMod { get; set; }
                public long? Duration { get; set; }
                public bool? IsActivatedOnPeriodEnd { get; set; }
                public double? Period { get; set; }
                public string HealthAdd { get; set; }
                public bool? Rebuff { get; set; }
                public long? RebuffStack { get; set; }
                public long? StaminaAdd { get; set; }
            }

            public partial class Nesher2015Sniper
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public string ActivationCost { get; set; }
                public double CastTime { get; set; }
                public string Cooldown { get; set; }
                public bool ActivationOnRelease { get; set; }
                public string CustomStopType { get; set; }
                public Nesher2015SniperActivationConditions ActivationConditions { get; set; }
                public List<Nesher2015SniperGroup> Groups { get; set; }
                public Nesher2015SniperMetaData MetaData { get; set; }
            }

            public partial class Nesher2015SniperActivationConditions
            {
                public bool IsPrimaryWeaponSelected { get; set; }
            }

            public partial class Nesher2015SniperGroup
            {
                public string IsEnabled { get; set; }
                public DeactivatedEntitiesOwnersRuleElement Rule { get; set; }
                public string TargetSelectionTime { get; set; }
                public List<Buff6> Buffs { get; set; }
            }

            public partial class Nesher2015SniperMetaData
            {
                public List<string> Upgrades { get; set; }
                public Modifiers34 Modifiers { get; set; }
            }

            public partial class Modifiers34
            {
                public Dictionary<string, long> Additive { get; set; }
                public MischievousUi Ui { get; set; }
            }

            public partial class MischievousUi
            {
                public long UiDuration { get; set; }
                public long UiCooldown { get; set; }
                public long UiActivationcost { get; set; }
                public long UiSuppressDuration { get; set; }
                public long UiStunDuration { get; set; }
            }

            public partial class Nesher2015Support
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public string ActivationCost { get; set; }
                public string CastTime { get; set; }
                public long Duration { get; set; }
                public string Cooldown { get; set; }
                public string MaxDropItemsOnScene { get; set; }
                public long DropItemPickingUpCooldownReduce { get; set; }
                public bool ActivationOnRelease { get; set; }
                public List<Nesher2015SupportGroup> Groups { get; set; }
                public The22Spn2016MedicMetaData MetaData { get; set; }
            }

            public partial class Nesher2015SupportGroup
            {
                public string IsEnabled { get; set; }
                public DeactivatedEntitiesOwnersRuleElement Rule { get; set; }
                public string TargetSelectionTime { get; set; }
                public List<Buff31> Buffs { get; set; }
            }

            public partial class Buff31
            {
                public string Name { get; set; }
                public long Priority { get; set; }
                public List<BuffImmuneAbsoluteAdd> Categories { get; set; }
                public bool Rebuff { get; set; }
                public long Duration { get; set; }
                public bool ForceVisible { get; set; }
            }

            public partial class The22_Spn2016AssautlHeavyPassive
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public List<The22Spn2016AssautlHeavyPassiveGroup> Groups { get; set; }
                public The22Spn2016AssautlHeavyPassiveMetaData MetaData { get; set; }
            }

            public partial class The22Spn2016AssautlHeavyPassiveGroup
            {
                public DeactivatedEntitiesOwnersRuleElement Rule { get; set; }
                public string TargetSelectionTime { get; set; }
                public List<FluffyBuff> Buffs { get; set; }
                public string IsEnabled { get; set; }
            }

            public partial class The22Spn2016AssautlHeavyPassiveMetaData
            {
                public List<object> Upgrades { get; set; }
                public FluffyModifiers Modifiers { get; set; }
            }

            public partial class FluffyModifiers
            {
                public MultiplyClass Additive { get; set; }
                public MultiplyClass Ui { get; set; }
            }

            public partial class PassiveRegen
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public List<PassiveRegenGroup> Groups { get; set; }
                public ConsumableHealthPackMetaData MetaData { get; set; }
            }

            public partial class PassiveRegenGroup
            {
                public string TargetSelectionTime { get; set; }
                public TentacledRule Rule { get; set; }
                public List<FluffyBuff> Buffs { get; set; }
            }

            public partial class QuartersAmbush
            {
                public string Type { get; set; }
                public List<QuartersAmbushGroup> Groups { get; set; }
            }

            public partial class QuartersAmbushGroup
            {
                public string TargetSelectionTime { get; set; }
                public PurpleRule Rule { get; set; }
                public List<IndecentBuff> Buffs { get; set; }
            }

            public partial class QuartersArmor
            {
                public string Type { get; set; }
                public long UsagePerRound { get; set; }
                public List<The22Spn2016SniperPassiveGroup> Groups { get; set; }
            }

            public partial class QuartersArmorRegen
            {
                public string Type { get; set; }
                public List<The22Spn2016SniperPassiveGroup> Groups { get; set; }
            }

            public partial class QuartersArmorShield
            {
                public string Type { get; set; }
                public long UsagePerRound { get; set; }
                public List<AmfSupportBuffAuraGroup> Groups { get; set; }
            }

            public partial class QuartersBloodRage
            {
                public string Type { get; set; }
                public List<QuartersBloodRageGroup> Groups { get; set; }
            }

            public partial class QuartersBloodRageGroup
            {
                public string TargetSelectionTime { get; set; }
                public TentacledRule Rule { get; set; }
                public List<Buff32> Buffs { get; set; }
            }

            public partial class Buff32
            {
                public string Name { get; set; }
                public long Priority { get; set; }
                public List<string> Categories { get; set; }
                public double? SpeedScale { get; set; }
                public double Duration { get; set; }
                public bool? Rebuff { get; set; }
                public long? RebuffStack { get; set; }
                public double? Period { get; set; }
                public long? HealthAdd { get; set; }
                public long? StaminaAdd { get; set; }
                public double? WpnRateOfFireModPrimary { get; set; }
                public bool? StopBuffsWithAbility { get; set; }
                public double? WpnReloadTimeModPrimaryScale { get; set; }
                public double? WpnReloadTimeModSecondaryScale { get; set; }
                public bool? IsActivatedOnPeriodEnd { get; set; }
            }

            public partial class QuartersCounterAttack
            {
                public string Type { get; set; }
                public List<QuartersCounterAttackGroup> Groups { get; set; }
            }

            public partial class QuartersCounterAttackGroup
            {
                public string TargetSelectionTime { get; set; }
                public SelfSuccessGroupRule Rule { get; set; }
                public List<Buff33> Buffs { get; set; }
            }

            public partial class Buff33
            {
                public string Name { get; set; }
                public long? Priority { get; set; }
                public List<BuffImmuneAbsoluteAdd> Categories { get; set; }
                public double? WpnDamagePrimaryScale { get; set; }
                public double? WpnDamageSecondaryScale { get; set; }
                public double? WpnDamageHeavyScale { get; set; }
                public double Duration { get; set; }
                public bool? Rebuff { get; set; }
                public double WarmingSpeed { get; set; }
                public long? CooldownSpeed { get; set; }
            }

            public partial class Quarters
            {
                public string Type { get; set; }
                public List<Fsb2004SniperPassiveGroup> Groups { get; set; }
            }

            public partial class QuartersSmokeBuff
            {
                public string Type { get; set; }
                public List<QuartersSmokeBuffGroup> Groups { get; set; }
            }

            public partial class QuartersSmokeBuffGroup
            {
                public string TargetSelectionTime { get; set; }
                public PurpleRule Rule { get; set; }
                public List<SelfSuccessBuff> Buffs { get; set; }
            }

            public partial class QuartersTakeAim
            {
                public string Type { get; set; }
                public double Cooldown { get; set; }
                public List<Nesher2015AssaultPassiveGroup> Groups { get; set; }
            }

            public partial class QuartersThermalImager
            {
                public string Type { get; set; }
                public double Cooldown { get; set; }
                public List<Grom2014SupportBuffAuraGroup> Groups { get; set; }
            }

            public partial class QuartersTightFit
            {
                public string Type { get; set; }
                public double Cooldown { get; set; }
                public List<QuartersTightFitGroup> Groups { get; set; }
            }

            public partial class QuartersTightFitGroup
            {
                public SelfSuccessGroupRule Rule { get; set; }
                public string TargetSelectionTime { get; set; }
                public List<Buff34> Buffs { get; set; }
            }

            public partial class Buff34
            {
                public ActionTarget Name { get; set; }
                public long Priority { get; set; }
                public List<string> Categories { get; set; }
                public long Duration { get; set; }
                public long StaminaRegenAdd { get; set; }
                public bool Rebuff { get; set; }
                public long RebuffStack { get; set; }
            }

            public partial class QuartersWellRested
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public double Cooldown { get; set; }
                public List<QuartersWellRestedGroup> Groups { get; set; }
            }

            public partial class QuartersWellRestedGroup
            {
                public string TargetSelectionTime { get; set; }
                public TentacledRule Rule { get; set; }
                public List<AuraSelfSuccessGroupBuff> Buffs { get; set; }
            }

            public partial class AuraSelfSuccessGroupBuff
            {
                public string Name { get; set; }
                public long Priority { get; set; }
                public List<string> Categories { get; set; }
                public bool? Rebuff { get; set; }
                public double Duration { get; set; }
                public bool? ForceVisible { get; set; }
                public bool? PrimaryAbilityLock { get; set; }
                public bool? PrimaryAbilityStop { get; set; }
                public List<string> BuffImmuneAbsoluteAdd { get; set; }
                public double? Stun { get; set; }
                public long? WarmingSpeed { get; set; }
                public double? SpeedScale { get; set; }
            }

            public partial class Raid2017Assault
            {
                public string ClientName { get; set; }
                public string Cooldown { get; set; }
                public string Duration { get; set; }
                public string ActivationCost { get; set; }
                public bool ActivationOnRelease { get; set; }
                public bool RegisterIncomingDamage { get; set; }
                public List<Raid2017AssaultGroup> Groups { get; set; }
                public Raid2017AssaultMetaData MetaData { get; set; }
            }

            public partial class Raid2017AssaultGroup
            {
                public PurpleRule Rule { get; set; }
                public string TargetSelectionTime { get; set; }
                public List<Buff35> Buffs { get; set; }
                public bool? StopBuffsWithAbility { get; set; }
            }

            public partial class Buff35
            {
                public string Name { get; set; }
                public long Priority { get; set; }
                public List<string> Categories { get; set; }
                public string ShieldAdd { get; set; }
                public WarmingSpeed Duration { get; set; }
                public bool? ForceVisibleToAll { get; set; }
                public string BollyBulletReflect { get; set; }
                public long? RebuffStack { get; set; }
            }

            public partial class Raid2017AssaultMetaData
            {
                public List<string> Upgrades { get; set; }
                public Modifiers35 Modifiers { get; set; }
            }

            public partial class Modifiers35
            {
                public Additive20 Additive { get; set; }
                public Dictionary<string, double> Ui { get; set; }
            }

            public partial class Additive20
            {
                public long AbilityRaid2017AssaultCooldown { get; set; }
                public long AbilityRaid2017AssaultDuration { get; set; }
                public long AbilityRaid2017AssaultActivationcost { get; set; }
                public long AbilityRaid2017AssaultShieldShieldAdd { get; set; }
                public long AbilityRaid2017AssaultShieldDuration { get; set; }
                public double AbilityRaid2017AssaultReturnDamage { get; set; }
            }

            public partial class Raid2017AssaultHeavyPassive
            {
                public TypeEnum Type { get; set; }
                public TypeEnum ClientName { get; set; }
                public List<Raid2017AssaultHeavyPassiveGroup> Groups { get; set; }
                public The22Spn2016AssautlHeavyPassiveMetaData MetaData { get; set; }
            }

            public partial class Raid2017AssaultHeavyPassiveGroup
            {
                public DeactivatedEntitiesOwnersRuleElement Rule { get; set; }
                public AuraBuffGroupTargetSelectionTime TargetSelectionTime { get; set; }
                public List<Buff36> Buffs { get; set; }
                public bool? CastOnHumanLure { get; set; }
            }

            public partial class Buff36
            {
                public FluffyName Name { get; set; }
                public long Priority { get; set; }
                public List<BuffImmuneAbsoluteAdd> Categories { get; set; }
                public bool Rebuff { get; set; }
                public double Duration { get; set; }
                public double Stun { get; set; }
            }

            public partial class Raid2017GunnerSecondPassive
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public List<Raid2017GunnerSecondPassiveGroup> Groups { get; set; }
                public The22Spn2016AssautlHeavyPassiveMetaData MetaData { get; set; }
            }

            public partial class Raid2017GunnerSecondPassiveGroup
            {
                public DeactivatedEntitiesOwnersRuleElement Rule { get; set; }
                public string TargetSelectionTime { get; set; }
                public List<Buff37> Buffs { get; set; }
            }

            public partial class Buff37
            {
                public string Name { get; set; }
                public long Priority { get; set; }
                public List<SlotElement> Categories { get; set; }
                public bool StackableName { get; set; }
                public bool Rebuff { get; set; }
                public long MaxStackCount { get; set; }
                public long Duration { get; set; }
                public double SpeedScaleSet { get; set; }
            }

            public partial class Raid2017Medic
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public string HasDeathGift { get; set; }
                public bool ActivationOnRelease { get; set; }
                public string ActivationCost { get; set; }
                public string CastTime { get; set; }
                public double Duration { get; set; }
                public string Cooldown { get; set; }
                public string MaxDropItemsOnScene { get; set; }
                public bool DropItemFlyAffectedByGravity { get; set; }
                public long DropItemThrowSpeed { get; set; }
                public string DropItemReboundBehaviour { get; set; }
                public string TrajectoryFxType { get; set; }
                public double PrepareTimeRelease { get; set; }
                public string AnimationType { get; set; }
                public double AnimationTimeScale { get; set; }
                public Ksk2011MedicMetaData MetaData { get; set; }
            }

            public partial class Raid2017Sniper
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public string Cooldown { get; set; }
                public string Duration { get; set; }
                public string ActivationCost { get; set; }
                public bool ActivationOnRelease { get; set; }
                public List<Raid2017SniperGroup> Groups { get; set; }
                public EzapacSniperBuffAura BuffAura { get; set; }
                public List<Raid2017SniperBuffAuraGroup> BuffAuraGroups { get; set; }
                public Raid2017SniperMetaData MetaData { get; set; }
            }

            public partial class Raid2017SniperBuffAuraGroup
            {
                public AuraBuffGroupTargetSelectionTime TargetSelectionTime { get; set; }
                public PurpleRule Rule { get; set; }
                public bool CastOnHumanLure { get; set; }
                public List<IndecentBuff> Buffs { get; set; }
            }

            public partial class Raid2017SniperGroup
            {
                public AmbitiousRule Rule { get; set; }
                public string TargetSelectionTime { get; set; }
                public bool CastOnHumanLure { get; set; }
                public List<Buff38> Buffs { get; set; }
            }

            public partial class Buff38
            {
                public string Name { get; set; }
                public long Priority { get; set; }
                public List<string> Categories { get; set; }
                public long Duration { get; set; }
                public bool? Rebuff { get; set; }
                public bool? Aura { get; set; }
                public string KeptAfterDeathRemove { get; set; }
                public bool? BotReactsToHardHit { get; set; }
                public PurpleIncomingDamageMod IncomingDamageMod { get; set; }
                public bool? ForceVisible { get; set; }
            }

            public partial class Raid2017SniperMetaData
            {
                public List<string> Upgrades { get; set; }
                public Modifiers36 Modifiers { get; set; }
            }

            public partial class Modifiers36
            {
                public Additive21 Additive { get; set; }
                public AmbitiousUi Ui { get; set; }
            }

            public partial class Additive21
            {
                public long AbilityRaid2017SniperActivationcost { get; set; }
                public long AbilityRaid2017SniperCasttime { get; set; }
                public long AbilityRaid2017SniperDuration { get; set; }
                public long AbilityRaid2017SniperCooldown { get; set; }
                public long AbilityRaid2017SniperRadius { get; set; }
                public double AbilityRaid2017SniperDamage { get; set; }
            }

            public partial class Raid2017Support
            {
                public string ClientName { get; set; }
                public string Cooldown { get; set; }
                public string Duration { get; set; }
                public string ActivationCost { get; set; }
                public double CastTime { get; set; }
                public bool ActivationOnRelease { get; set; }
                public bool CanBeStoppedManually { get; set; }
                public List<Raid2017SupportGroup> Groups { get; set; }
                public Raid2017SupportMetaData MetaData { get; set; }
            }

            public partial class Raid2017SupportGroup
            {
                public string TargetSelectionTime { get; set; }
                public bool StopBuffsWithAbility { get; set; }
                public SelfSuccessGroupRule Rule { get; set; }
                public List<Buff39> Buffs { get; set; }
            }

            public partial class Buff39
            {
                public string Name { get; set; }
                public long? Priority { get; set; }
                public List<SlotElement> Categories { get; set; }
                public string SpeedScale { get; set; }
                public bool? SprintLock { get; set; }
                public bool? WpnSwitchToHeavy { get; set; }
                public string BollyBulletReflect { get; set; }
                public double? Duration { get; set; }
                public long? RebuffStack { get; set; }
            }

            public partial class Raid2017SupportMetaData
            {
                public List<string> Upgrades { get; set; }
                public Modifiers37 Modifiers { get; set; }
            }

            public partial class Modifiers37
            {
                public Dictionary<string, double> Additive { get; set; }
                public BraggadociousUi Ui { get; set; }
            }

            public partial class BraggadociousUi
            {
                public long UiDuration { get; set; }
                public long UiCooldown { get; set; }
                public long UiActivationcost { get; set; }
                public long UiRange { get; set; }
                public long UiSelfSlow { get; set; }
                public long UiDamageMod { get; set; }
            }

            public partial class Raid2017SupportHeavyPassive
            {
                public string Type { get; set; }
                public List<Raid2017SupportHeavyPassiveGroup> Groups { get; set; }
                public Raid2017SupportHeavyPassiveMetaData MetaData { get; set; }
            }

            public partial class Raid2017SupportHeavyPassiveGroup
            {
                public SelfSuccessGroupRule Rule { get; set; }
                public string TargetSelectionTime { get; set; }
                public bool StopBuffsWithAbility { get; set; }
                public List<Buff40> Buffs { get; set; }
            }

            public partial class Buff40
            {
                public ActionTarget Name { get; set; }
                public long Priority { get; set; }
                public List<string> Categories { get; set; }
                public bool? SprintLock { get; set; }
                public string StaminaRegen { get; set; }
                public bool? Rebuff { get; set; }
            }

            public partial class Raid2017SupportHeavyPassiveMetaData
            {
                public List<object> Upgrades { get; set; }
                public Modifiers38 Modifiers { get; set; }
            }

            public partial class Modifiers38
            {
                public Additive22 Additive { get; set; }
                public Ui1 Ui { get; set; }
            }

            public partial class Additive22
            {
                public long Raid2017ShieldStaminaRegen { get; set; }
            }

            public partial class Ui1
            {
                public long UiEffectAmount { get; set; }
            }

            public partial class RecruitAssault
            {
                public NameEnum Type { get; set; }
                public string ClientName { get; set; }
                public string Cooldown { get; set; }
                public string Duration { get; set; }
                public string ActivationCost { get; set; }
                public bool ActivationOnRelease { get; set; }
                public List<RecruitAssaultGroup> Groups { get; set; }
                public RecruitAssaultMetaData MetaData { get; set; }
            }

            public partial class RecruitAssaultGroup
            {
                public bool StopBuffsWithAbility { get; set; }
                public PurpleTargetSelectionTime TargetSelectionTime { get; set; }
                public SelfSuccessGroupRule Rule { get; set; }
                public List<StickyBuff> Buffs { get; set; }
            }

            public partial class RecruitAssaultMetaData
            {
                public List<string> Upgrades { get; set; }
                public Modifiers39 Modifiers { get; set; }
            }

            public partial class Modifiers39
            {
                public Additive23 Additive { get; set; }
                public FluffyUi Ui { get; set; }
            }

            public partial class Additive23
            {
                public long AbilityRecruitAssaultCooldown { get; set; }
                public long AbilityRecruitAssaultDuration { get; set; }
                public long AbilityRecruitAssaultActivationcost { get; set; }
                public long AbilityRecruitAssaultConcentrationDuration { get; set; }
            }

            public partial class RecruitMedic
            {
                public FxTypeEnum Type { get; set; }
                public string ClientName { get; set; }
                public string Cooldown { get; set; }
                public string Duration { get; set; }
                public string ActivationCost { get; set; }
                public bool ActivationOnRelease { get; set; }
                public List<RecruitMedicGroup> Groups { get; set; }
                public RecruitMedicMetaData MetaData { get; set; }
            }

            public partial class RecruitMedicGroup
            {
                public PurpleTargetSelectionTime TargetSelectionTime { get; set; }
                public bool RequireTarget { get; set; }
                public bool ShowTargets { get; set; }
                public FluffyRule Rule { get; set; }
                public List<Buff41> Buffs { get; set; }
                public List<TentacledSelfSuccessGroup> SelfSuccessGroup { get; set; }
            }

            public partial class Buff41
            {
                public string Name { get; set; }
                public long Priority { get; set; }
                public List<BuffImmuneAddElement> Categories { get; set; }
                public string Duration { get; set; }
                public long Period { get; set; }
                public string HealthAdd { get; set; }
                public bool? Rebuff { get; set; }
            }

            public partial class TentacledSelfSuccessGroup
            {
                public string TargetSelectionTime { get; set; }
                public bool RequireTarget { get; set; }
                public SelfSuccessGroupRule Rule { get; set; }
                public List<Buff41> Buffs { get; set; }
            }

            public partial class RecruitMedicMetaData
            {
                public List<string> Upgrades { get; set; }
                public Modifiers40 Modifiers { get; set; }
            }

            public partial class Modifiers40
            {
                public Additive24 Additive { get; set; }
                public Dictionary<string, double> Ui { get; set; }
            }

            public partial class Additive24
            {
                public long AbilityRecruitMedicCooldown { get; set; }
                public long AbilityRecruitMedicDuration { get; set; }
                public long AbilityRecruitMedicActivationcost { get; set; }
                public long AbilityRecruitMedicHealDuration { get; set; }
                public long AbilityRecruitMedicHealHealthAdd { get; set; }
                public long AbilityRecruitMedicSelfHealHealthAdd { get; set; }
            }

            public partial class RecruitSniper
            {
                public NameEnum Type { get; set; }
                public string ClientName { get; set; }
                public string Cooldown { get; set; }
                public string Duration { get; set; }
                public string ActivationCost { get; set; }
                public bool ActivationOnRelease { get; set; }
                public List<RecruitSniperGroup> Groups { get; set; }
                public RecruitSniperMetaData MetaData { get; set; }
            }

            public partial class RecruitSniperGroup
            {
                public bool? StopBuffsWithAbility { get; set; }
                public string TargetSelectionTime { get; set; }
                public SelfSuccessGroupRule Rule { get; set; }
                public List<Buff42> Buffs { get; set; }
                public string IsEnabled { get; set; }
                public bool? CastOnHumanLure { get; set; }
            }

            public partial class Buff42
            {
                public string Name { get; set; }
                public long Priority { get; set; }
                public List<string> Categories { get; set; }
                public string WpnHeadshotMultPrimaryAdd { get; set; }
                public double? WpnRecoilMultPrimary { get; set; }
                public double? WpnSpreadConeMaxModPrimaryScale { get; set; }
                public string Duration { get; set; }
                public bool? Rebuff { get; set; }
                public bool? ForceVisible { get; set; }
            }

            public partial class RecruitSniperMetaData
            {
                public List<string> Upgrades { get; set; }
                public Modifiers41 Modifiers { get; set; }
            }

            public partial class Modifiers41
            {
                public Additive25 Additive { get; set; }
                public PurpleUi Ui { get; set; }
            }

            public partial class Additive25
            {
                public long AbilityRecruitSniperMarkGroupEnabled { get; set; }
                public long AbilityRecruitSniperCooldown { get; set; }
                public long AbilityRecruitSniperDuration { get; set; }
                public long AbilityRecruitSniperActivationcost { get; set; }
                public double AbilityRecruitSniperConcentrationHeadshotMult { get; set; }
                public long AbilityRecruitSniperMarkDuration { get; set; }
            }

            public partial class RecruitSupport
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public string Cooldown { get; set; }
                public string Duration { get; set; }
                public string ActivationCost { get; set; }
                public bool ActivationOnRelease { get; set; }
                public List<RecruitSupportGroup> Groups { get; set; }
                public RecruitSupportMetaData MetaData { get; set; }
            }

            public partial class RecruitSupportGroup
            {
                public DeactivatedEntitiesOwnersRuleElement Rule { get; set; }
                public string TargetSelectionTime { get; set; }
                public List<Buff1> Buffs { get; set; }
            }

            public partial class RecruitSupportMetaData
            {
                public List<object> Upgrades { get; set; }
                public Modifiers42 Modifiers { get; set; }
            }

            public partial class Modifiers42
            {
                public Additive26 Additive { get; set; }
                public PurpleUi Ui { get; set; }
            }

            public partial class Additive26
            {
                public long AbilityRecruitSupportCooldown { get; set; }
                public long AbilityRecruitSupportDuration { get; set; }
                public long AbilityRecruitSupportActivationcost { get; set; }
                public double AbilityRecruitSupportSlowValue { get; set; }
                public long AbilityRecruitSupportSlowDuration { get; set; }
            }

            public partial class Seal2014Assault
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public string Cooldown { get; set; }
                public string Duration { get; set; }
                public string ActivationCost { get; set; }
                public bool ActivationOnRelease { get; set; }
                public List<Seal2014AssaultGroup> Groups { get; set; }
                public Fsb2016SniperMetaData MetaData { get; set; }
            }

            public partial class Seal2014AssaultGroup
            {
                public string TargetSelectionTime { get; set; }
                public bool? CastOnHumanLure { get; set; }
                public SelfSuccessGroupRule Rule { get; set; }
                public List<Buff43> Buffs { get; set; }
                public string IsEnabled { get; set; }
            }

            public partial class Buff43
            {
                public string Name { get; set; }
                public long Priority { get; set; }
                public List<string> Categories { get; set; }
                public bool Rebuff { get; set; }
                public bool? IsCleansedBySmoke { get; set; }
                public string Duration { get; set; }
                public bool? ForcePersonallyVisible { get; set; }
                public string KnockDownDurationScale { get; set; }
                public List<string> BuffImmuneAbsoluteAdd { get; set; }
                public string SpeedScale { get; set; }
            }

            public partial class Seal2014Medic
            {
                public string ClientName { get; set; }
                public string Cooldown { get; set; }
                public string CastTime { get; set; }
                public string Duration { get; set; }
                public string ActivationCost { get; set; }
                public bool ActivationOnRelease { get; set; }
                public bool ActivationOnHold { get; set; }
                public long ActivationOnHoldDuration { get; set; }
                public string AnimationType { get; set; }
                public double AnimationTimeScale { get; set; }
                public List<Seal2014MedicGroup> Groups { get; set; }
                public Fsb2004MedicMetaData MetaData { get; set; }
            }

            public partial class Seal2014MedicGroup
            {
                public bool RequireTarget { get; set; }
                public IndecentRule Rule { get; set; }
                public List<Buff44> Buffs { get; set; }
                public string IsEnabled { get; set; }
                public bool? ShowTargets { get; set; }
                public string TargetSelectionTime { get; set; }
            }

            public partial class Buff44
            {
                public string Name { get; set; }
                public List<string> Categories { get; set; }
                public StaminaAdd Duration { get; set; }
                public double? KnockDownSpeedMod { get; set; }
                public long? KnockDownDurationScale { get; set; }
                public double? ReviveMeOverideTime { get; set; }
                public string KeptAfterDeathRemove { get; set; }
                public long? Priority { get; set; }
                public double? SpeedScale { get; set; }
                public string Period { get; set; }
                public string HealthAdd { get; set; }
            }

            public partial class Seal2014MedicPassive
            {
                public NameEnum Type { get; set; }
                public string ClientName { get; set; }
                public double Cooldown { get; set; }
                public List<Seal2014MedicPassiveGroup> Groups { get; set; }
                public ConsumableHealthPackMetaData MetaData { get; set; }
            }

            public partial class Seal2014MedicPassiveGroup
            {
                public string TargetSelectionTime { get; set; }
                public TentacledRule Rule { get; set; }
                public List<Buff18> Buffs { get; set; }
            }

            public partial class Seal2014Sniper
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public string Cooldown { get; set; }
                public string Duration { get; set; }
                public string ActivationCost { get; set; }
                public bool ActivationOnRelease { get; set; }
                public string MaxDropItemsOnScene { get; set; }
                public long DropItemFlyGravityCompensation { get; set; }
                public string DropItemThrowSpeed { get; set; }
                public string DropItemReboundBehaviour { get; set; }
                public long DropItemPickingUpCooldownReduce { get; set; }
                public FxTypeEnum TrajectoryFxType { get; set; }
                public double PrepareTimeRelease { get; set; }
                public string AnimationType { get; set; }
                public double AnimationTimeScale { get; set; }
                public Ksk2011MedicMetaData MetaData { get; set; }
            }

            public partial class Seal2014SniperMinePassive
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public List<The22Spn2016SniperPassiveGroup> Groups { get; set; }
                public Seal2014SniperMinePassiveMetaData MetaData { get; set; }
            }

            public partial class Seal2014SniperMinePassiveMetaData
            {
                public List<object> Upgrades { get; set; }
                public Modifiers43 Modifiers { get; set; }
            }

            public partial class Modifiers43
            {
                public Additive27 Additive { get; set; }
                public FluffyUi Ui { get; set; }
            }

            public partial class Additive27
            {
                public long AbilitySeal2014SniperMineDamageRadius { get; set; }
            }

            public partial class Seal2014SniperMk141Passive
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public List<Fsb2016AssaultZaryaPassiveGroup> Groups { get; set; }
                public Seal2014SniperMk141PassiveMetaData MetaData { get; set; }
            }

            public partial class Seal2014SniperMk141PassiveMetaData
            {
                public List<string> Upgrades { get; set; }
                public Modifiers44 Modifiers { get; set; }
            }

            public partial class Modifiers44
            {
                public Additive28 Additive { get; set; }
                public FluffyUi Ui { get; set; }
            }

            public partial class Additive28
            {
                public long AbilitySeal2014SniperMk141StunDuration { get; set; }
            }

            public partial class Seal2014SniperPassive
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public List<Fsb2004SniperPassiveGroup> Groups { get; set; }
                public The22Spn2016AssautlHeavyPassiveMetaData MetaData { get; set; }
            }

            public partial class Seal2014Support
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public string ActivationCost { get; set; }
                public string Duration { get; set; }
                public string Cooldown { get; set; }
                public bool ActivationOnRelease { get; set; }
                public List<Seal2014SupportGroup> Groups { get; set; }
                public Seal2014SupportMetaData MetaData { get; set; }
            }

            public partial class Seal2014SupportGroup
            {
                public FluffyRule Rule { get; set; }
                public string TargetSelectionTime { get; set; }
                public List<Buff45> Buffs { get; set; }
                public string IsEnabled { get; set; }
            }

            public partial class Buff45
            {
                public string Name { get; set; }
                public long Priority { get; set; }
                public List<string> Categories { get; set; }
                public double? WarmingSpeed { get; set; }
                public double? CooldownSpeed { get; set; }
                public string Duration { get; set; }
                public string Stun { get; set; }
                public bool Rebuff { get; set; }
                public long? RebuffStack { get; set; }
                public bool? CanBeAppliedOncePerTarget { get; set; }
                public double? SpeedScale { get; set; }
                public long? Period { get; set; }
                public List<BuffImmuneAddElement> BuffImmuneAbsoluteAdd { get; set; }
            }

            public partial class Seal2014SupportMetaData
            {
                public List<string> Upgrades { get; set; }
                public Modifiers45 Modifiers { get; set; }
            }

            public partial class Modifiers45
            {
                public Additive29 Additive { get; set; }
                public FluffyUi Ui { get; set; }
            }

            public partial class Additive29
            {
                public long AbilitySeal2014SupportActivationcost { get; set; }
                public long AbilitySeal2014SupportDuration { get; set; }
                public long AbilitySeal2014SupportCooldown { get; set; }
                public long AbilitySeal2014SupportSpeedEnabled { get; set; }
                public long AbilitySeal2014SupportSlowImmunityEnabled { get; set; }
                public double AbilitySeal2014SupportStunDuration { get; set; }
            }

            public partial class Sprint
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public string Cooldown { get; set; }
                public string Duration { get; set; }
                public string UpkeepCost { get; set; }
                public SprintActivationConditions ActivationConditions { get; set; }
                public List<SprintGroup> Groups { get; set; }
            }

            public partial class SprintActivationConditions
            {
                public bool IsMovingForward { get; set; }
                public bool IsWantFire { get; set; }
            }

            public partial class SprintGroup
            {
                public bool StopBuffsWithAbility { get; set; }
                public DeactivatedEntitiesOwnersRuleElement Rule { get; set; }
                public List<StickyBuff> Buffs { get; set; }
            }

            public partial class Sso2013Assault
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public string ActivationCost { get; set; }
                public string Duration { get; set; }
                public string Cooldown { get; set; }
                public bool ActivationOnRelease { get; set; }
                public List<Sso2013AssaultGroup> Groups { get; set; }
                public Sso2013AssaultMetaData MetaData { get; set; }
            }

            public partial class Sso2013AssaultGroup
            {
                public string TargetSelectionTime { get; set; }
                public SelfSuccessGroupRule Rule { get; set; }
                public List<Buff7> Buffs { get; set; }
                public string IsEnabled { get; set; }
            }

            public partial class Sso2013AssaultMetaData
            {
                public List<string> Upgrades { get; set; }
                public Modifiers46 Modifiers { get; set; }
            }

            public partial class Modifiers46
            {
                public Additive30 Additive { get; set; }
                public Dictionary<string, double> Ui { get; set; }
            }

            public partial class Additive30
            {
                public long AbilitySso2013AssaultStaminaHealGroupEnabled { get; set; }
                public long AbilitySso2013AssaultCooldown { get; set; }
                public long AbilitySso2013AssaultDuration { get; set; }
                public long AbilitySso2013AssaultActivationcost { get; set; }
                public long AbilitySso2013AssaultSlowDuration { get; set; }
            }

            public partial class Sso2013AssaultMinePassive
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public List<The22Spn2016AssautlHeavyPassiveGroup> Groups { get; set; }
                public Sso2013AssaultMinePassiveMetaData MetaData { get; set; }
            }

            public partial class Sso2013AssaultMinePassiveMetaData
            {
                public List<object> Upgrades { get; set; }
                public Modifiers47 Modifiers { get; set; }
            }

            public partial class Modifiers47
            {
                public Additive31 Additive { get; set; }
                public FluffyUi Ui { get; set; }
            }

            public partial class Additive31
            {
                public long Sso2013AssaultMineDotAoEOnImpactGroupEnabled { get; set; }
            }

            public partial class Sso2013Medic
            {
                public FxTypeEnum Type { get; set; }
                public FxTypeEnum FxType { get; set; }
                public string FxRadius { get; set; }
                public string ClientName { get; set; }
                public string Cooldown { get; set; }
                public string Duration { get; set; }
                public string ActivationCost { get; set; }
                public bool ActivationOnRelease { get; set; }
                public bool ActivationOnHold { get; set; }
                public long ActivationOnHoldDuration { get; set; }
                public bool HideAuraFromEnemy { get; set; }
                public List<Sso2013MedicGroup> Groups { get; set; }
                public Sso2013MedicBuffAura BuffAura { get; set; }
                public List<Sso2013MedicBuffAuraGroup> BuffAuraGroups { get; set; }
                public BelssoMedicMetaData MetaData { get; set; }
            }

            public partial class Sso2013MedicBuffAura
            {
                public DisplayMarkerTeamRuleEnum TeamRule { get; set; }
                public TriggerType TriggerType { get; set; }
                public string Radius { get; set; }
                public string UpdatePeriod { get; set; }
                public string Duration { get; set; }
                public FxTypeEnum FxType { get; set; }
            }

            public partial class Sso2013MedicBuffAuraGroup
            {
                public AuraBuffGroupTargetSelectionTime TargetSelectionTime { get; set; }
                public HilariousRule Rule { get; set; }
                public List<FluffyBuff> Buffs { get; set; }
            }

            public partial class Sso2013MedicGroup
            {
                public string TargetSelectionTime { get; set; }
                public BraggadociousRule Rule { get; set; }
                public List<Buff46> Buffs { get; set; }
            }

            public partial class Buff46
            {
                public string Name { get; set; }
                public long Priority { get; set; }
                public List<string> Categories { get; set; }
                public bool? Rebuff { get; set; }
                public string Duration { get; set; }
                public long? Period { get; set; }
                public PurpleIncomingDamageMod IncomingDamageMod { get; set; }
                public bool? StopBuffsWithAbility { get; set; }
                public double? SpeedScale { get; set; }
                public bool? Aura { get; set; }
                public bool? HideAuraFromEnemy { get; set; }
            }

            public partial class BraggadociousRule
            {
                public bool? StopBuffsWithAbility { get; set; }
                public PurpleType Type { get; set; }
                public List<CunningChildRule> ChildRules { get; set; }
            }

            public partial class CunningChildRule
            {
                public PurpleType Type { get; set; }
                public List<ChildRuleChildRule> ChildRules { get; set; }
            }

            public partial class ChildRuleChildRule
            {
                public TriggerTypeEnum Type { get; set; }
                public string Range { get; set; }
                public long? ConeAngle { get; set; }
            }

            public partial class Sso2013MedicPassive
            {
                public FxTypeEnum Type { get; set; }
                public string ClientName { get; set; }
                public List<Sso2013MedicPassiveGroup> Groups { get; set; }
                public Sso2013MedicPassiveMetaData MetaData { get; set; }
            }

            public partial class Sso2013MedicPassiveGroup
            {
                public string IsEnabled { get; set; }
                public bool RequireTarget { get; set; }
                public SelfSuccessGroupRule Rule { get; set; }
                public string TargetSelectionTime { get; set; }
                public List<FluffyBuff> Buffs { get; set; }
            }

            public partial class Sso2013MedicPassiveMetaData
            {
                public List<string> Upgrades { get; set; }
                public Modifiers48 Modifiers { get; set; }
            }

            public partial class Modifiers48
            {
                public Additive32 Additive { get; set; }
                public FluffyUi Ui { get; set; }
            }

            public partial class Additive32
            {
                public long AbilitySso2013MedicPassiveGroupEnabled { get; set; }
            }

            public partial class Sso2013Sniper
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public string Cooldown { get; set; }
                public string Duration { get; set; }
                public string ActivationCost { get; set; }
                public bool ActivationOnRelease { get; set; }
                public List<Sso2013SniperGroup> Groups { get; set; }
                public Ksk2011SniperMetaData MetaData { get; set; }
            }

            public partial class Sso2013SniperGroup
            {
                public bool StopBuffsWithAbility { get; set; }
                public DeactivatedEntitiesOwnersRuleElement Rule { get; set; }
                public string TargetSelectionTime { get; set; }
                public List<Buff47> Buffs { get; set; }
                public string IsEnabled { get; set; }
                public bool? CastOnHumanLure { get; set; }
            }

            public partial class Buff47
            {
                public string Name { get; set; }
                public long Priority { get; set; }
                public List<BuffImmuneAbsoluteAdd> Categories { get; set; }
                public string Duration { get; set; }
                public long? WpnWallPerforationLimitPrimary { get; set; }
                public bool? ForcePersonallyVisible { get; set; }
                public bool? Rebuff { get; set; }
            }

            public partial class Sso2013SniperPassive
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public List<Fsb2004SniperPassive2Group> Groups { get; set; }
                public The22Spn2016AssautlHeavyPassiveMetaData MetaData { get; set; }
            }

            public partial class Sso2013Support
            {
                public TypeElement Type { get; set; }
                public string ClientName { get; set; }
                public string ActivationCost { get; set; }
                public long CastTime { get; set; }
                public string Duration { get; set; }
                public string Cooldown { get; set; }
                public long MaxDropItemsOnScene { get; set; }
                public bool ActivationOnRelease { get; set; }
                public long DropItemFlyGravityCompensation { get; set; }
                public bool CanBeStoppedManually { get; set; }
                public long DropItemThrowSpeed { get; set; }
                public string DropItemReboundBehaviour { get; set; }
                public FxTypeEnum TrajectoryFxType { get; set; }
                public double PrepareTimeRelease { get; set; }
                public long AnimationTimeScale { get; set; }
                public string AnimationType { get; set; }
                public bool BulletsCanBeDeactivated { get; set; }
                public Sso2013SupportMetaData MetaData { get; set; }
            }

            public partial class Sso2013SupportMetaData
            {
                public List<string> Upgrades { get; set; }
                public Modifiers29 Modifiers { get; set; }
                public string DropItem { get; set; }
            }

            public partial class Tfb2008Assault
            {
                public NameEnum Type { get; set; }
                public string ClientName { get; set; }
                public string Cooldown { get; set; }
                public string Duration { get; set; }
                public string ActivationCost { get; set; }
                public bool ActivationOnRelease { get; set; }
                public List<Tfb2008AssaultGroup> Groups { get; set; }
                public Tfb2008AssaultMetaData MetaData { get; set; }
            }

            public partial class Tfb2008AssaultGroup
            {
                public PurpleTargetSelectionTime TargetSelectionTime { get; set; }
                public Rule1 Rule { get; set; }
                public List<Buff48> Buffs { get; set; }
                public string IsEnabled { get; set; }
            }

            public partial class Buff48
            {
                public string Name { get; set; }
                public long Priority { get; set; }
                public string Duration { get; set; }
                public AbilityLimitedBorrowedTime SelfRevive { get; set; }
                public string KeptAfterDeathRemove { get; set; }
                public List<PurpleCategory> Categories { get; set; }
                public List<BuffImmuneAddElement> BuffImmuneAbsoluteAdd { get; set; }
                public bool? Rebuff { get; set; }
            }

            public partial class Rule1
            {
                public PurpleType Type { get; set; }
                public List<DeactivatedEntitiesOwnersRuleElement> ChildRules { get; set; }
                public bool? StopBuffsWithAbility { get; set; }
            }

            public partial class Tfb2008AssaultMetaData
            {
                public List<string> Upgrades { get; set; }
                public Modifiers49 Modifiers { get; set; }
            }

            public partial class Modifiers49
            {
                public Additive33 Additive { get; set; }
                public Dictionary<string, double> Ui { get; set; }
            }

            public partial class Additive33
            {
                public long AbilityTfb2008AssaultCooldown { get; set; }
                public long AbilityTfb2008AssaultDuration { get; set; }
                public long AbilityTfb2008AssaultActivationcost { get; set; }
                public long AbilityTfb2008AssaultSlowImmunityEnabled { get; set; }
                public long AbilityTfb2008AssaultReviveHealth { get; set; }
            }

            public partial class Tfb2008AssaultPassive
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public List<RecruitSupportGroup> Groups { get; set; }
                public Tfb2008AssaultPassiveMetaData MetaData { get; set; }
            }

            public partial class Tfb2008AssaultPassiveMetaData
            {
                public List<object> Upgrades { get; set; }
                public Modifiers50 Modifiers { get; set; }
            }

            public partial class Modifiers50
            {
                public Additive34 Additive { get; set; }
                public FluffyUi Ui { get; set; }
            }

            public partial class Additive34
            {
                public long AbilityTfb2008AssaultPassiveDuration { get; set; }
            }

            public partial class Tfb2008Medic
            {
                public FxTypeEnum Type { get; set; }
                public string ClientName { get; set; }
                public string Cooldown { get; set; }
                public string Duration { get; set; }
                public string ActivationCost { get; set; }
                public bool ActivationOnRelease { get; set; }
                public List<Tfb2008MedicGroup> Groups { get; set; }
                public Fsb2016SupportBuffAura BuffAura { get; set; }
                public List<Tfb2008MedicBuffAuraGroup> BuffAuraGroups { get; set; }
                public BelssoMedicMetaData MetaData { get; set; }
            }

            public partial class Tfb2008MedicBuffAuraGroup
            {
                public AuraBuffGroupTargetSelectionTime TargetSelectionTime { get; set; }
                public IndigoRule Rule { get; set; }
                public List<IndecentBuff> Buffs { get; set; }
            }

            public partial class Tfb2008MedicGroup
            {
                public PurpleTargetSelectionTime TargetSelectionTime { get; set; }
                public bool RequireTarget { get; set; }
                public bool ShowTargets { get; set; }
                public bool StopBuffsWithAbility { get; set; }
                public IndecentRule Rule { get; set; }
                public List<Buff3> Buffs { get; set; }
                public List<StickySelfSuccessGroup> SelfSuccessGroup { get; set; }
            }

            public partial class StickySelfSuccessGroup
            {
                public string TargetSelectionTime { get; set; }
                public bool RequireTarget { get; set; }
                public SelfSuccessGroupRule Rule { get; set; }
                public List<Buff3> Buffs { get; set; }
            }

            public partial class Tfb2008MedicPassive
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public List<Tfb2008MedicPassiveGroup> Groups { get; set; }
                public Tfb2008MedicPassiveMetaData MetaData { get; set; }
            }

            public partial class Tfb2008MedicPassiveGroup
            {
                public DeactivatedEntitiesOwnersRuleElement Rule { get; set; }
                public string TargetSelectionTime { get; set; }
                public List<StickyBuff> Buffs { get; set; }
            }

            public partial class Tfb2008MedicPassiveMetaData
            {
                public List<object> Upgrades { get; set; }
                public Modifiers51 Modifiers { get; set; }
            }

            public partial class Modifiers51
            {
                public Additive35 Additive { get; set; }
                public FluffyUi Ui { get; set; }
            }

            public partial class Additive35
            {
                public long AbilityTfb2008MedicPassiveDuration { get; set; }
            }

            public partial class Tfb2008MedicTripwirePassive
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public List<The22Spn2016SupportGroup> Groups { get; set; }
                public Tfb2008MedicTripwirePassiveMetaData MetaData { get; set; }
            }

            public partial class The22Spn2016SupportGroup
            {
                public string IsEnabled { get; set; }
                public string TargetSelectionTime { get; set; }
                public DeactivatedEntitiesOwnersRuleElement Rule { get; set; }
                public List<StickyBuff> Buffs { get; set; }
            }

            public partial class Tfb2008MedicTripwirePassiveMetaData
            {
                public List<string> Upgrades { get; set; }
                public Modifiers52 Modifiers { get; set; }
            }

            public partial class Modifiers52
            {
                public Additive36 Additive { get; set; }
                public FluffyUi Ui { get; set; }
            }

            public partial class Additive36
            {
                public long AbilityTfb2008MedicTripwirePassiveStunDuration { get; set; }
            }

            public partial class Tfb2008Sniper
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public string Cooldown { get; set; }
                public string Duration { get; set; }
                public string ActivationCost { get; set; }
                public bool ActivationOnRelease { get; set; }
                public List<Tfb2008SniperGroup> Groups { get; set; }
                public Tfb2008SniperMetaData MetaData { get; set; }
            }

            public partial class Tfb2008SniperGroup
            {
                public bool? StopBuffsWithAbility { get; set; }
                public string TargetSelectionTime { get; set; }
                public SelfSuccessGroupRule Rule { get; set; }
                public List<Buff49> Buffs { get; set; }
                public string IsEnabled { get; set; }
            }

            public partial class Buff49
            {
                public string Name { get; set; }
                public long Priority { get; set; }
                public List<string> Categories { get; set; }
                public Dictionary<string, DamageCurve> WpnAdditionalExplosionDamageCurvePrimary { get; set; }
                public string WpnAdditionalExplosionDamageMajorPrimary { get; set; }
                public long? WpnAdditionalExplosionDamageRadiusMajorPrimary { get; set; }
                public double? WpnAdditionalExplosionArmorPenetrationMajorPrimary { get; set; }
                public string WpnAdditionalExplosionDamageMinorPrimary { get; set; }
                public long? WpnAdditionalExplosionDamageRadiusMinorPrimary { get; set; }
                public double? WpnAdditionalExplosionArmorPenetrationMinorPrimary { get; set; }
                public StaminaAdd Duration { get; set; }
                public bool? WeaponsAimRestricted { get; set; }
                public bool? Rebuff { get; set; }
                public long? WpnSpreadConeMaxModPrimary { get; set; }
                public long? WpnSpreadConeMaxModSecondary { get; set; }
                public long? WpnSpreadConeMaxModHeavy { get; set; }
                public long? WpnSpreadConeMinPrimary { get; set; }
                public long? WpnSpreadConeMinSecondary { get; set; }
                public long? WpnSpreadConeMinHeavy { get; set; }
            }

            public partial class Tfb2008SniperMetaData
            {
                public List<string> Upgrades { get; set; }
                public Modifiers53 Modifiers { get; set; }
            }

            public partial class Modifiers53
            {
                public Additive37 Additive { get; set; }
                public Ui2 Ui { get; set; }
            }

            public partial class Additive37
            {
                public long AbilityTfb2008SniperCooldown { get; set; }
                public long AbilityTfb2008SniperDuration { get; set; }
                public long AbilityTfb2008SniperActivationcost { get; set; }
                public long AbilityTfb2008SniperSuppressionGroupEnabled { get; set; }
                public long AbilityTfb2008SniperDamage { get; set; }
            }

            public partial class Ui2
            {
                public long UiDuration { get; set; }
                public long UiCooldown { get; set; }
                public long UiActivationcost { get; set; }
                public long UiDamageMinor { get; set; }
                public long UiDamageMajor { get; set; }
                public long UiMinorRadius { get; set; }
                public long UiMajorRadius { get; set; }
                public long UiApMajor { get; set; }
                public long UiApMinor { get; set; }
            }

            public partial class Tfb2008SniperDebuff
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public List<Tfb2008SniperDebuffGroup> Groups { get; set; }
                public Tfb2008SniperDebuffMetaData MetaData { get; set; }
            }

            public partial class Tfb2008SniperDebuffGroup
            {
                public PurpleRule Rule { get; set; }
                public string TargetSelectionTime { get; set; }
                public List<Buff1> Buffs { get; set; }
            }

            public partial class Tfb2008SniperDebuffMetaData
            {
                public List<string> Upgrades { get; set; }
                public Modifiers54 Modifiers { get; set; }
            }

            public partial class Modifiers54
            {
                public Additive38 Additive { get; set; }
                public MultiplyClass Ui { get; set; }
            }

            public partial class Additive38
            {
                public double AbilityTfb2008SniperDebuffDuration { get; set; }
            }

            public partial class Tfb2008SniperPassive2
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public double Cooldown { get; set; }
                public List<Tfb2008SniperPassive2Group> Groups { get; set; }
                public ConsumableHealthPackMetaData MetaData { get; set; }
            }

            public partial class Tfb2008SniperPassive2Group
            {
                public string TargetSelectionTime { get; set; }
                public TentacledRule Rule { get; set; }
                public List<IndecentBuff> Buffs { get; set; }
            }

            public partial class Tfb2008Support
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public string DeathGift { get; set; }
                public bool ActivationOnRelease { get; set; }
                public string ActivationCost { get; set; }
                public string CastTime { get; set; }
                public double Duration { get; set; }
                public string Cooldown { get; set; }
                public string MaxDropItemsOnScene { get; set; }
                public long DropItemFlyGravityCompensation { get; set; }
                public long DropItemThrowSpeed { get; set; }
                public string DropItemReboundBehaviour { get; set; }
                public FxTypeEnum TrajectoryFxType { get; set; }
                public double PrepareTimeRelease { get; set; }
                public string AnimationType { get; set; }
                public double AnimationTimeScale { get; set; }
                public Ksk2011MedicMetaData MetaData { get; set; }
            }

            public partial class Tfb2008SupportPassive
            {
                public string Type { get; set; }
                public double Duration { get; set; }
                public double Cooldown { get; set; }
                public string ClientName { get; set; }
                public List<Tfb2008SupportPassiveGroup> Groups { get; set; }
                public Tfb2008SupportPassiveMetaData MetaData { get; set; }
            }

            public partial class Tfb2008SupportPassiveGroup
            {
                public DeactivatedEntitiesOwnersRuleElement Rule { get; set; }
                public string TargetSelectionTime { get; set; }
                public List<Buff50> Buffs { get; set; }
            }

            public partial class Buff50
            {
                public AbilityEnum Name { get; set; }
                public long Priority { get; set; }
                public List<PurpleCategory> Categories { get; set; }
                public bool Rebuff { get; set; }
                public string WarmingSpeed { get; set; }
                public double CooldownSpeed { get; set; }
                public double WpnSpreadConeMaxModPrimary { get; set; }
                public double WpnSpreadConeMinPrimary { get; set; }
                public double WpnSpreadConeMaxModHeavy { get; set; }
                public long WpnRecoilMultPrimary { get; set; }
                public double Duration { get; set; }
            }

            public partial class Tfb2008SupportPassiveMetaData
            {
                public List<object> Upgrades { get; set; }
                public Modifiers55 Modifiers { get; set; }
            }

            public partial class Modifiers55
            {
                public Additive39 Additive { get; set; }
                public MultiplyClass Ui { get; set; }
            }

            public partial class Additive39
            {
                public long AbilityTfb2008SupportPassiveWarmingSpeed { get; set; }
            }

            public partial class The22Spn2016Assault
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public bool ActivationOnRelease { get; set; }
                public string ActivationCost { get; set; }
                public string CastTime { get; set; }
                public string Duration { get; set; }
                public string Cooldown { get; set; }
                public string MaxDropItemsOnScene { get; set; }
                public double PrepareTimeRelease { get; set; }
                public string AnimationType { get; set; }
                public double AnimationTimeScale { get; set; }
                public List<The22Spn2016AssaultGroup> Groups { get; set; }
                public The22Spn2016AssaultMetaData MetaData { get; set; }
            }

            public partial class The22Spn2016AssaultGroup
            {
                public string TargetSelectionTime { get; set; }
                public SelfSuccessGroupRule Rule { get; set; }
                public List<PurpleBuff> Buffs { get; set; }
            }

            public partial class The22Spn2016AssaultMetaData
            {
                public List<string> Upgrades { get; set; }
                public PurpleModifiers Modifiers { get; set; }
                public string DropItem { get; set; }
            }

            public partial class The22Spn2016Medic
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public string DeathGift { get; set; }
                public bool ActivationOnRelease { get; set; }
                public string ActivationCost { get; set; }
                public string CastTime { get; set; }
                public double Duration { get; set; }
                public string Cooldown { get; set; }
                public string MaxDropItemsOnScene { get; set; }
                public long DropItemFlyGravityCompensation { get; set; }
                public string DropItemThrowSpeed { get; set; }
                public string DropItemReboundBehaviour { get; set; }
                public bool BulletsCanBeDeactivated { get; set; }
                public string TrajectoryFxType { get; set; }
                public double PrepareTimeRelease { get; set; }
                public string AnimationType { get; set; }
                public double AnimationTimeScale { get; set; }
                public List<object> Groups { get; set; }
                public The22Spn2016MedicMetaData MetaData { get; set; }
            }

            public partial class The22Spn2016MedicPassive
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public List<The22Spn2016MedicPassiveGroup> Groups { get; set; }
                public The22Spn2016AssautlHeavyPassiveMetaData MetaData { get; set; }
            }

            public partial class The22Spn2016MedicPassiveGroup
            {
                public string TargetSelectionTime { get; set; }
                public PurpleRule Rule { get; set; }
                public List<FluffyBuff> Buffs { get; set; }
            }

            public partial class The22Spn2016Sniper
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public string Cooldown { get; set; }
                public string Duration { get; set; }
                public string ActivationCost { get; set; }
                public bool ActivationOnRelease { get; set; }
                public List<The22Spn2016SniperGroup> Groups { get; set; }
                public The22Spn2016SniperMetaData MetaData { get; set; }
            }

            public partial class The22Spn2016SniperGroup
            {
                public DeactivatedEntitiesOwnersRuleElement Rule { get; set; }
                public PurpleTargetSelectionTime TargetSelectionTime { get; set; }
                public bool StopBuffsWithAbility { get; set; }
                public List<TentacledBuff> Buffs { get; set; }
            }

            public partial class TentacledBuff
            {
                public string Name { get; set; }
                public long Priority { get; set; }
                public List<string> Categories { get; set; }
                public List<BuffImmuneAbsoluteAdd> BuffImmuneAbsoluteAdd { get; set; }
                public string Duration { get; set; }
                public bool? Rebuff { get; set; }
                public bool? Invisible { get; set; }
                public double? SpeedScale { get; set; }
                public double? WpnRateOfFireModPrimaryScale { get; set; }
            }

            public partial class The22Spn2016SniperMetaData
            {
                public StickyModifiers Modifiers { get; set; }
                public List<string> Upgrades { get; set; }
            }

            public partial class StickyModifiers
            {
                public PurpleAdditive Additive { get; set; }
                public FluffyUi Ui { get; set; }
            }

            public partial class PurpleAdditive
            {
                public long Ability22Spn2016SniperActivationcost { get; set; }
                public long Ability22Spn2016SniperDuration { get; set; }
                public long Ability22Spn2016SniperCooldown { get; set; }
            }

            public partial class The22Spn2016SniperHeavyPassive
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public List<The22Spn2016SniperHeavyPassiveGroup> Groups { get; set; }
                public The22Spn2016SniperHeavyPassiveMetaData MetaData { get; set; }
            }

            public partial class The22Spn2016SniperHeavyPassiveGroup
            {
                public string IsEnabled { get; set; }
                public DeactivatedEntitiesOwnersRuleElement Rule { get; set; }
                public AuraBuffGroupTargetSelectionTime TargetSelectionTime { get; set; }
                public bool CastOnHumanLure { get; set; }
                public List<AuraSelfSuccessGroupBuff> Buffs { get; set; }
            }

            public partial class The22Spn2016SniperHeavyPassiveMetaData
            {
                public List<object> Upgrades { get; set; }
                public IndigoModifiers Modifiers { get; set; }
            }

            public partial class IndigoModifiers
            {
                public FluffyAdditive Additive { get; set; }
                public MultiplyClass Ui { get; set; }
            }

            public partial class FluffyAdditive
            {
                public long Ability22Spn2016SniperHeavyPassiveGroupEnabled { get; set; }
            }

            public partial class The22Spn2016SniperPassive
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public List<The22Spn2016SniperPassiveGroup> Groups { get; set; }
                public The22Spn2016AssautlHeavyPassiveMetaData MetaData { get; set; }
            }

            public partial class The22Spn2016Support
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public string ActivationCost { get; set; }
                public string CastTime { get; set; }
                public string Duration { get; set; }
                public string Cooldown { get; set; }
                public string MaxDropItemsOnScene { get; set; }
                public bool ActivationOnRelease { get; set; }
                public bool IgnoreHeightCheck { get; set; }
                public List<The22Spn2016SupportGroup> Groups { get; set; }
                public The22Spn2016SupportMetaData MetaData { get; set; }
            }

            public partial class The22Spn2016SupportMetaData
            {
                public List<string> Upgrades { get; set; }
                public IndecentModifiers Modifiers { get; set; }
                public string DropItem { get; set; }
            }

            public partial class IndecentModifiers
            {
                public Dictionary<string, double> Additive { get; set; }
                public TentacledUi Ui { get; set; }
            }

            public partial class TentacledUi
            {
                public long UiDuration { get; set; }
                public long UiCooldown { get; set; }
                public long UiActivationcost { get; set; }
                public long UiDropAmount { get; set; }
                public long UiHealAmount { get; set; }
                public long UiShieldSelf { get; set; }
                public long UiShield { get; set; }
                public long UiShieldDuration { get; set; }
                public long UiRange { get; set; }
            }

            public partial class The22Spn2016SupportPassive
            {
                public string Type { get; set; }
                public long Duration { get; set; }
                public double Cooldown { get; set; }
                public string ClientName { get; set; }
                public List<The22Spn2016SupportPassiveGroup> Groups { get; set; }
                public The22Spn2016SupportPassiveMetaData MetaData { get; set; }
            }

            public partial class The22Spn2016SupportPassiveMetaData
            {
                public List<object> Upgrades { get; set; }
                public HilariousModifiers Modifiers { get; set; }
            }

            public partial class HilariousModifiers
            {
                public TentacledAdditive Additive { get; set; }
                public MultiplyClass Ui { get; set; }
            }

            public partial class TentacledAdditive
            {
                public double Ability22Spn2016SupportPassiveWarmingSpeed { get; set; }
            }

            public partial class Ww2Assault
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public string Cooldown { get; set; }
                public string Duration { get; set; }
                public string ActivationCost { get; set; }
                public bool ActivationOnRelease { get; set; }
                public List<Ww2AssaultGroup> Groups { get; set; }
                public Ww2AssaultMetaData MetaData { get; set; }
            }

            public partial class Ww2AssaultGroup
            {
                public bool StopBuffsWithAbility { get; set; }
                public string TargetSelectionTime { get; set; }
                public PurpleRule Rule { get; set; }
                public List<Buff51> Buffs { get; set; }
            }

            public partial class Buff51
            {
                public string Name { get; set; }
                public long Priority { get; set; }
                public List<string> Categories { get; set; }
                public StaminaAdd Duration { get; set; }
                public string VampiricRage { get; set; }
                public long? Period { get; set; }
                public string StaminaAdd { get; set; }
                public bool? Rebuff { get; set; }
            }

            public partial class Ww2AssaultMetaData
            {
                public Modifiers56 Modifiers { get; set; }
            }

            public partial class Modifiers56
            {
                public Dictionary<string, double> Additive { get; set; }
                public Dictionary<string, long> Ui { get; set; }
            }

            public partial class Ww2AssaultPassiveTier1
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public List<Ww2AssaultPassiveTier1Group> Groups { get; set; }
            }

            public partial class Ww2AssaultPassiveTier1Group
            {
                public PurpleRule Rule { get; set; }
                public string TargetSelectionTime { get; set; }
                public List<AuraSelfSuccessGroupBuff> Buffs { get; set; }
            }

            public partial class Ww2AssaultPassiveTier2Class
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public List<QuartersSmokeBuffGroup> Groups { get; set; }
            }

            public partial class Ww2Medic
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public string ActivationCost { get; set; }
                public string CastTime { get; set; }
                public string Duration { get; set; }
                public string Cooldown { get; set; }
                public string MaxDropItemsOnScene { get; set; }
                public bool ActivationOnRelease { get; set; }
                public bool IgnoreHeightCheck { get; set; }
                public List<object> Groups { get; set; }
                public Ww2MedicMetaData MetaData { get; set; }
            }

            public partial class Ww2MedicMetaData
            {
                public List<object> Upgrades { get; set; }
                public TentacledModifiers Modifiers { get; set; }
                public string DropItem { get; set; }
            }

            public partial class Ww2Sniper
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public string ActivationCost { get; set; }
                public double CastTime { get; set; }
                public string Cooldown { get; set; }
                public bool ActivationOnRelease { get; set; }
                public string CustomStopType { get; set; }
                public Nesher2015SniperActivationConditions ActivationConditions { get; set; }
                public List<Ww2SniperGroup> Groups { get; set; }
                public Ww2SniperBuffAura BuffAura { get; set; }
                public List<Ww2SniperBuffAuraGroup> BuffAuraGroups { get; set; }
                public Ww2SniperMetaData MetaData { get; set; }
            }

            public partial class Ww2SniperBuffAura
            {
                public DisplayMarkerTeamRuleEnum TeamRule { get; set; }
                public TriggerType TriggerType { get; set; }
                public bool? Collision { get; set; }
                public long Radius { get; set; }
                public double UpdatePeriod { get; set; }
                public double Duration { get; set; }
                public Ksk2011SupportFxType FxType { get; set; }
                public bool IgnoreHeightCheck { get; set; }
                public string KeptAfterDeathRemove { get; set; }
            }

            public partial class Ww2SniperBuffAuraGroup
            {
                public AuraBuffGroupTargetSelectionTime TargetSelectionTime { get; set; }
                public SelfSuccessGroupRule Rule { get; set; }
                public List<Buff52> Buffs { get; set; }
            }

            public partial class Buff52
            {
                public AbilityEnum Name { get; set; }
                public long Priority { get; set; }
                public List<string> Categories { get; set; }
                public long Duration { get; set; }
                public double? SpeedScale { get; set; }
                public PurpleIncomingDamageMod IncomingDamageMod { get; set; }
                public long WpnSpreadConeMaxModPrimary { get; set; }
                public long WpnSpreadConeMaxModSecondary { get; set; }
                public long WpnSpreadConeMaxModHeavy { get; set; }
                public long WpnSpreadConeMinPrimary { get; set; }
                public long WpnSpreadConeMinSecondary { get; set; }
                public long WpnSpreadConeMinHeavy { get; set; }
                public bool Rebuff { get; set; }
                public bool? WeaponsAimRestricted { get; set; }
            }

            public partial class Ww2SniperGroup
            {
                public AmbitiousRule Rule { get; set; }
                public string TargetSelectionTime { get; set; }
                public List<Buff53> Buffs { get; set; }
            }

            public partial class Buff53
            {
                public NameEnum Name { get; set; }
                public List<BuffImmuneAddElement> Categories { get; set; }
                public long Priority { get; set; }
                public double Duration { get; set; }
                public bool? Aura { get; set; }
                public bool? MakeCry { get; set; }
                public bool? SprintLock { get; set; }
            }

            public partial class Ww2SniperMetaData
            {
                public Modifiers57 Modifiers { get; set; }
            }

            public partial class Modifiers57
            {
                public Additive40 Additive { get; set; }
                public Dictionary<string, double> Ui { get; set; }
            }

            public partial class Additive40
            {
                public long AbilityWw2SniperActivationcost { get; set; }
                public long AbilityWw2SniperCooldown { get; set; }
            }

            public partial class Ww2SniperPassiveTier1
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public List<Ww2SniperPassiveTier1Group> Groups { get; set; }
            }

            public partial class Ww2SniperPassiveTier1Group
            {
                public PurpleRule Rule { get; set; }
                public string TargetSelectionTime { get; set; }
                public List<Buff33> Buffs { get; set; }
            }

            public partial class Ww2SniperPassiveTier3
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public List<Ww2SniperPassiveTier3Group> Groups { get; set; }
            }

            public partial class Ww2SniperPassiveTier3Group
            {
                public PurpleRule Rule { get; set; }
                public string TargetSelectionTime { get; set; }
                public List<Buff54> Buffs { get; set; }
            }

            public partial class Buff54
            {
                public string Name { get; set; }
                public double WarmingSpeed { get; set; }
                public long CooldownSpeed { get; set; }
                public double Duration { get; set; }
                public long Priority { get; set; }
                public List<BuffImmuneAbsoluteAdd> BuffImmuneAbsoluteAdd { get; set; }
                public List<BuffImmuneAbsoluteAdd> Categories { get; set; }
                public bool? Rebuff { get; set; }
                public long? WpnDamagePrimaryScale { get; set; }
                public Dictionary<string, DamageCurve> WpnAdditionalExplosionDamageCurvePrimary { get; set; }
                public long? WpnAdditionalExplosionDamageMajorPrimary { get; set; }
                public long? WpnAdditionalExplosionDamageRadiusMajorPrimary { get; set; }
                public double? WpnAdditionalExplosionArmorPenetrationMajorPrimary { get; set; }
                public long? WpnAdditionalExplosionDamageMinorPrimary { get; set; }
                public long? WpnAdditionalExplosionDamageRadiusMinorPrimary { get; set; }
                public double? WpnAdditionalExplosionArmorPenetrationMinorPrimary { get; set; }
            }

            public partial class Ww2Support
            {
                public string Type { get; set; }
                public FxTypeEnum FxType { get; set; }
                public string ClientName { get; set; }
                public string Cooldown { get; set; }
                public string Duration { get; set; }
                public string ActivationCost { get; set; }
                public string AnimationType { get; set; }
                public long AnimationTimeScale { get; set; }
                public string FxRadius { get; set; }
                public bool ActivationOnRelease { get; set; }
                public List<StickyGroup> Groups { get; set; }
                public AmfSupportBuffAura BuffAura { get; set; }
                public List<Tfb2008MedicPassiveGroup> BuffAuraGroups { get; set; }
                public Ww2SupportMetaData MetaData { get; set; }
            }

            public partial class StickyGroup
            {
                public PurpleTargetSelectionTime TargetSelectionTime { get; set; }
                public SelfSuccessGroupRule Rule { get; set; }
                public List<StickyBuff> Buffs { get; set; }
            }

            public partial class Ww2SupportMetaData
            {
                public Modifiers58 Modifiers { get; set; }
            }

            public partial class Modifiers58
            {
                public Additive41 Additive { get; set; }
                public Dictionary<string, double> Ui { get; set; }
            }

            public partial class Additive41
            {
                public long AbilityWw2SupportCooldown { get; set; }
                public long AbilityWw2SupportDuration { get; set; }
                public long AbilityWw2SupportActivationcost { get; set; }
                public long AbilityWw2SupportRange { get; set; }
                public long AbilityWw2SupportConeAngle { get; set; }
                public long AbilityWw2SupportMarkDuration { get; set; }
            }

            public partial class Ww2SupportPassiveTier
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public List<QuartersAmbushGroup> Groups { get; set; }
            }

            public partial class Accesses
            {
                public AccountLevel AccountLevel { get; set; }
                public AccountLevel GamemodePve { get; set; }
                public AccountLevel Contacts { get; set; }
                public AccountLevel NewbieBuff { get; set; }
                public AccountLevel Consumables { get; set; }
                public AccountLevel Currency { get; set; }
                public AccountLevel Premium { get; set; }
                public AccountLevel GamemodePvp { get; set; }
                public AccountLevel Operator { get; set; }
                public ComplexQuests DailyQuests { get; set; }
                public AccountLevel Customization { get; set; }
                public AccountLevel Userbars { get; set; }
                public GamemodePveHard Medals { get; set; }
                public ComplexQuests FreeXp { get; set; }
                public ComplexQuests ComplexQuests { get; set; }
                public GamemodePveHard GamemodePveHard { get; set; }
                public GamemodePveHard HardQuests { get; set; }
                public AccountLevel AllOperators { get; set; }
                public AccountLevel BattlePass { get; set; }
                public AccountLevel GamemodeHacking { get; set; }
                public AccountLevel Marathon { get; set; }
                public AccountLevel GamemodePvPvE { get; set; }
                public AccountLevel RankedSeason { get; set; }
                public AccountLevel GamemodePvpRanked { get; set; }
                public AccountLevel Quarters { get; set; }
                public AccountLevel HqStyle { get; set; }
                public AccountLevel Expeditions { get; set; }
                public AccountLevel GamemodeOnslaughtEasy { get; set; }
                public AccountLevel GamemodeOnslaughtNormal { get; set; }
                public AccountLevel GamemodeOnslaughtHard { get; set; }
                public AccountLevel GamemodeIntercept { get; set; }
                public AccountLevel GamemodeDefend { get; set; }
            }

            public partial class AccountLevel
            {
                public ConditionsClass Visible { get; set; }
                public ConditionsClass Enabled { get; set; }
            }

            public partial class ConditionsClass
            {
                public long ActivationLevel { get; set; }
                public long DeactivationLevel { get; set; }
                public List<string> Triggers { get; set; }
            }

            public partial class ComplexQuests
            {
                public ComplexQuestsEnabled Visible { get; set; }
                public ComplexQuestsEnabled Enabled { get; set; }
            }

            public partial class ComplexQuestsEnabled
            {
                public long ActivationLevel { get; set; }
                public long DeactivationLevel { get; set; }
            }

            public partial class GamemodePveHard
            {
                public ConditionsClass Visible { get; set; }
                public ComplexQuestsEnabled Enabled { get; set; }
            }

            public partial class AccountLevelElement
            {
                public string Visual { get; set; }
                public long Xp { get; set; }
                public long MatchesPlayed { get; set; }
                public long MatchesWon { get; set; }
                public BattlePassRewardClass Reward { get; set; }
            }

            public partial class BattlePassRewardClass
            {
                public Dictionary<string, long> ShopEntries { get; set; }
                public long Xp { get; set; }
            }

            public partial class BattlePasses
            {
                public Battlepass1_Class Battlepass1 { get; set; }
                public Battlepass1_Class Battlepass2 { get; set; }
                public Battlepass1_Class Battlepass3 { get; set; }
                public Battlepass1_Class Battlepass4 { get; set; }
                public Battlepass1_Class Battlepass5 { get; set; }
                public Battlepass6_Class Battlepass6 { get; set; }
                public Battlepass7 Battlepass7 { get; set; }
                public Battlepass6_Class Battlepass8 { get; set; }
            }

            public partial class Battlepass1_Class
            {
                public string Visual { get; set; }
                public DateTimeOffset StartDate { get; set; }
                public DateTimeOffset EndDate { get; set; }
                public long HardToXpConversionRate { get; set; }
                public long AdditionalXpPercent { get; set; }
                public bool IsGlobal { get; set; }
                public List<Battlepass1_Step> Steps { get; set; }
            }

            public partial class Battlepass1_Step
            {
                public string Id { get; set; }
                public long Xp { get; set; }
                public BattlePassRewardClass EveryoneReward { get; set; }
                public BattlePassRewardClass BattlePassReward { get; set; }
            }

            public partial class Battlepass6_Class
            {
                public string Visual { get; set; }
                public DateTimeOffset StartDate { get; set; }
                public DateTimeOffset EndDate { get; set; }
                public long HardToXpConversionRate { get; set; }
                public long AdditionalXpPercent { get; set; }
                public string ProgressCurrency { get; set; }
                public bool IsGlobal { get; set; }
                public List<Battlepass6_Step> Steps { get; set; }
            }

            public partial class Battlepass6_Step
            {
                public string Id { get; set; }
                public long Xp { get; set; }
                public BattlePassRewardClass EveryoneReward { get; set; }
                public Item2 BattlePassReward { get; set; }
            }

            public partial class Item2
            {
                public MultiplyClass ShopEntries { get; set; }
                public long Xp { get; set; }
            }

            public partial class Battlepass7
            {
                public LocaleKeyEnum Visual { get; set; }
                public DateTimeOffset StartDate { get; set; }
                public DateTimeOffset EndDate { get; set; }
                public long HardToXpConversionRate { get; set; }
                public long AdditionalXpPercent { get; set; }
                public bool IsGlobal { get; set; }
                public List<Battlepass1_Step> Steps { get; set; }
            }

            public partial class BotConfigs
            {
                public AllyBotAssault AllyBotAssault { get; set; }
                public AllyBotFsb2004A AllyBotFsb2004A { get; set; }
                public AllyBotFsb2004 AllyBotFsb2004G { get; set; }
                public AllyBotFsb2004M AllyBotFsb2004M { get; set; }
                public AllyBotFsb2004 AllyBotFsb2004S { get; set; }
                public AllyBotHeavy AllyBotHeavy { get; set; }
                public AllyBotHostage AllyBotHostage { get; set; }
                public AllyBotHostage AllyBotHostage2 { get; set; }
                public AllyBotHostage AllyBotHostage3 { get; set; }
                public AllyBotInformer AllyBotInformer { get; set; }
                public AllyBotMedic AllyBotMedic { get; set; }
                public AllyBotRocketman AllyBotRocketman { get; set; }
                public AllyBotSniper AllyBotSniper { get; set; }
                public AllyOnboardingBotAssault AllyOnboardingBotAssault { get; set; }
                public Dummy Dummy { get; set; }
                public ManekenEnemy0_Class ManekenEnemy0 { get; set; }
                public ManekenEnemy1_Class ManekenEnemy1 { get; set; }
                public ManekenEnemy1_Class ManekenEnemy2 { get; set; }
                public ManekenEnemy0_Class Maneken0 { get; set; }
                public ManekenEnemy1_Class Maneken1 { get; set; }
                public ManekenEnemy1_Class Maneken2 { get; set; }
                public Onboarding OnboardingAssault { get; set; }
                public AllyBotMedic OnboardingHostage { get; set; }
                public AllyBotMedic OnboardingHostage2 { get; set; }
                public AllyBotMedic OnboardingHostage3 { get; set; }
                public AllyBotHostage OnboardingHostage4 { get; set; }
                public OnboardingOfficerMedic OnboardingOfficerMedic { get; set; }
                public OnboardingSniper OnboardingSniper { get; set; }
                public Onboarding OnboardingSupport { get; set; }
                public Onboarding OnboardingSupport2 { get; set; }
                public TaurusAssaultEmpowered0 TaurusAssaultEmpowered0 { get; set; }
                public TaurusAssaultHologramClass TaurusAssaultHologram { get; set; }
                public TaurusAssaultOnslaught0_Class TaurusAssaultOnslaught0 { get; set; }
                public TaurusAssaultOnslaught0_Class TaurusAssaultOnslaught1 { get; set; }
                public TaurusAssaultOnslaught0_Class TaurusAssaultOnslaught2 { get; set; }
                public TaurusAssaultWeak0 TaurusAssaultWeak0 { get; set; }
                public TaurusAssaultHologramClass TaurusAssault0 { get; set; }
                public TaurusAssaultOnslaught0_Class TaurusAssault1 { get; set; }
                public TaurusAssaultOnslaught0_Class TaurusAssault2 { get; set; }
                public TaurusAssaultOnslaught0_Class TaurusAssault3 { get; set; }
                public TaurusAssaultPvPvE TaurusAssaultPvPvE { get; set; }
                public TaurusChemistEmpowered0 TaurusChemistEmpowered0 { get; set; }
                public TaurusChemistOnslaught0 TaurusChemistOnslaught0 { get; set; }
                public Elimination TaurusChemistOnslaught0_Elimination { get; set; }
                public TaurusChemistOnslaught0 TaurusChemistOnslaught1 { get; set; }
                public Elimination TaurusChemistOnslaught1_Elimination { get; set; }
                public TaurusChemistOnslaught2 TaurusChemistOnslaught2 { get; set; }
                public Elimination TaurusChemistOnslaught2_Elimination { get; set; }
                public TaurusChemistWeak0 TaurusChemistWeak0 { get; set; }
                public TaurusChemistEmpowered0 TaurusChemist0 { get; set; }
                public TaurusChemistOnslaught2 TaurusChemist1 { get; set; }
                public TaurusChemistEmpowered0 TaurusChemist2 { get; set; }
                public TaurusChemistEmpowered0 TaurusChemist3 { get; set; }
                public TaurusCommander TaurusCommander { get; set; }
                public TaurusFighterEmpowered0 TaurusFighterEmpowered0 { get; set; }
                public TaurusFighterOnslaught0 TaurusFighterOnslaught0 { get; set; }
                public TaurusFighterOnslaught0 TaurusFighterOnslaught0_Elimination { get; set; }
                public TaurusFighterOnslaught0 TaurusFighterOnslaught1 { get; set; }
                public TaurusFighterOnslaught0 TaurusFighterOnslaught1_Elimination { get; set; }
                public FighterOnslaught2 TaurusFighterOnslaught2 { get; set; }
                public FighterOnslaught2__Elimination TaurusFighterOnslaught2_Elimination { get; set; }
                public TaurusFighter TaurusFighterWeak0 { get; set; }
                public TaurusFighter TaurusFighter0 { get; set; }
                public TaurusFighter1 TaurusFighter1 { get; set; }
                public TaurusFighter1 TaurusFighter2 { get; set; }
                public TaurusFighter1 TaurusFighter3 { get; set; }
                public TaurusFighter TaurusFighterPvPvE { get; set; }
                public TaurusGunnerEmpowered0 TaurusGunnerEmpowered0 { get; set; }
                public TaurusGunnerOnslaught0 TaurusGunnerOnslaught0 { get; set; }
                public TaurusGunnerOnslaught0 TaurusGunnerOnslaught1 { get; set; }
                public TaurusGunnerOnslaught0 TaurusGunnerOnslaught2 { get; set; }
                public TaurusGunnerOnslaught0 TaurusGunnerWeak0 { get; set; }
                public TaurusGunnerOnslaught0 TaurusGunner0 { get; set; }
                public TaurusGunnerOnslaught0 TaurusGunner1 { get; set; }
                public TaurusGunnerOnslaught0 TaurusGunner2 { get; set; }
                public TaurusGunnerOnslaught0 TaurusGunner3 { get; set; }
                public TaurusGunnerPvPvE TaurusGunnerPvPvE { get; set; }
                public TaurusHeavyFighterOnslaught TaurusHeavyFighterOnslaught { get; set; }
                public TaurusHeavyFighter TaurusHeavyFighter0 { get; set; }
                public TaurusHeavyFighter TaurusHeavyFighter1 { get; set; }
                public TaurusLeaderEmpowered0 TaurusLeaderEmpowered0 { get; set; }
                public TaurusLeaderEmpowered0 TaurusLeaderWeak0 { get; set; }
                public TaurusLeaderEmpowered0 TaurusLeader0 { get; set; }
                public TaurusLeaderEmpowered0 TaurusLeader1 { get; set; }
                public TaurusLeaderEmpowered0 TaurusLeader2 { get; set; }
                public TaurusLeaderEmpowered0 TaurusLeader3 { get; set; }
                public TaurusOfficerMedic TaurusOfficerMedic { get; set; }
                public TaurusOfficerMedicOnslaught TaurusOfficerMedicOnslaught0 { get; set; }
                public TaurusOfficerMedicOnslaught TaurusOfficerMedicOnslaught1 { get; set; }
                public TaurusOfficerMedicOnslaught TaurusOfficerMedicOnslaught2 { get; set; }
                public TaurusOfficerSupport TaurusOfficerSupport { get; set; }
                public TaurusOfficerSupportOnslaught0 TaurusOfficerSupportOnslaught0 { get; set; }
                public TaurusOfficerSupportOnslaught0 TaurusOfficerSupportOnslaught1 { get; set; }
                public TaurusOfficerSupportOnslaught0 TaurusOfficerSupportOnslaught2 { get; set; }
                public TaurusRocketmanEmpowered0 TaurusRocketmanEmpowered0 { get; set; }
                public TaurusRocketmanOnslaught TaurusRocketmanOnslaught0 { get; set; }
                public TaurusRocketmanOnslaughtElimination TaurusRocketmanOnslaught0_Elimination { get; set; }
                public TaurusRocketmanOnslaught TaurusRocketmanOnslaught1 { get; set; }
                public TaurusRocketmanOnslaughtElimination TaurusRocketmanOnslaught1_Elimination { get; set; }
                public TaurusRocketmanOnslaught TaurusRocketmanOnslaught2 { get; set; }
                public TaurusRocketmanOnslaughtElimination TaurusRocketmanOnslaught2_Elimination { get; set; }
                public TaurusRocketmanWeak0 TaurusRocketmanWeak0 { get; set; }
                public TaurusRocketman0 TaurusRocketman0 { get; set; }
                public TaurusRocketman TaurusRocketman1 { get; set; }
                public TaurusRocketman TaurusRocketman2 { get; set; }
                public TaurusRocketman TaurusRocketman3 { get; set; }
                public TaurusRocketmanPvPvE TaurusRocketmanPvPvE { get; set; }
                public TaurusScorpion TaurusScorpion { get; set; }
                public TaurusSergeantEmpowered0 TaurusSergeantEmpowered0 { get; set; }
                public TaurusSergeantEmpowered0 TaurusSergeant0 { get; set; }
                public TaurusSergeantEmpowered0 TaurusSergeant1 { get; set; }
                public TaurusSergeantEmpowered0 TaurusSergeant2 { get; set; }
                public TaurusSergeantEmpowered0 TaurusSergeant3 { get; set; }
                public TaurusShooterEmpowered0 TaurusShooterEmpowered0 { get; set; }
                public TaurusShooter TaurusShooterOnslaught0 { get; set; }
                public TaurusShooter TaurusShooterOnslaught0_Elimination { get; set; }
                public TaurusShooter TaurusShooterOnslaught1 { get; set; }
                public TaurusShooter TaurusShooterOnslaught1_Elimination { get; set; }
                public TaurusShooter TaurusShooterOnslaught2 { get; set; }
                public TaurusShooter TaurusShooterOnslaught2_Elimination { get; set; }
                public TaurusShooter TaurusShooterWeak0 { get; set; }
                public TaurusShooter TaurusShooter0 { get; set; }
                public TaurusShooter TaurusShooter1 { get; set; }
                public TaurusShooter TaurusShooter2 { get; set; }
                public TaurusShooter TaurusShooter3 { get; set; }
                public TaurusShooterPvPvE TaurusShooterPvPvE { get; set; }
                public TaurusSniperEmpowered0 TaurusSniperEmpowered0 { get; set; }
                public TaurusSniperEmpowered0 TaurusSniperOnslaught0 { get; set; }
                public TaurusSniperEmpowered0 TaurusSniperOnslaught0_Elimination { get; set; }
                public TaurusSniperEmpowered0 TaurusSniperOnslaught1 { get; set; }
                public TaurusSniperEmpowered0 TaurusSniperOnslaught1_Elimination { get; set; }
                public TaurusSniperEmpowered0 TaurusSniperOnslaught2 { get; set; }
                public TaurusSniperEmpowered0 TaurusSniperOnslaught2_Elimination { get; set; }
                public TaurusSniperWeak0 TaurusSniperWeak0 { get; set; }
                public TaurusSniperEmpowered0 TaurusSniper0 { get; set; }
                public TaurusSniperEmpowered0 TaurusSniper1 { get; set; }
                public TaurusSniperEmpowered0 TaurusSniper2 { get; set; }
                public TaurusSniperEmpowered0 TaurusSniper3 { get; set; }
                public TaurusSniperPvPvE TaurusSniperPvPvE { get; set; }
                public Ww2Assault0_Class Ww2Assault0 { get; set; }
                public Ww2Assault0_Class Ww2Assault0_Elimination { get; set; }
                public Ww2Assault0_Class Ww2Assault1 { get; set; }
                public Ww2Assault0_Class Ww2Assault1_Elimination { get; set; }
                public Ww2Gunner Ww2Gunner0 { get; set; }
                public Ww2Gunner Ww2Gunner0_Elimination { get; set; }
                public Ww2Gunner Ww2Gunner1 { get; set; }
                public Ww2Gunner Ww2Gunner1_Elimination { get; set; }
                public AllyBotHostage Ww2Hostage0 { get; set; }
                public AllyBotHostage Ww2Hostage1 { get; set; }
                public Ww2Officer0 Ww2Officer0 { get; set; }
                public Ww2Officer0 Ww2Officer0_Elimination { get; set; }
                public Ww2Assault0_Class Ww2Pilot1 { get; set; }
                public Ww2Rocketman Ww2Rocketman0 { get; set; }
                public Ww2Rocketman Ww2Rocketman1 { get; set; }
                public Ww2Shooter Ww2Shooter0 { get; set; }
                public Ww2Shooter Ww2Shooter1 { get; set; }
                public TaurusSniperEmpowered0 Ww2Sniper0 { get; set; }
                public TaurusSniperEmpowered0 Ww2Sniper1 { get; set; }
                public ZalessyeAssaultEmpowered0_Class ZalessyeAssaultEmpowered0 { get; set; }
                public ZalessyeAssaultHologramClass ZalessyeAssaultHologram { get; set; }
                public ZalessyeAssaultOnslaught ZalessyeAssaultOnslaught0 { get; set; }
                public ZalessyeAssaultOnslaught ZalessyeAssaultOnslaught1 { get; set; }
                public ZalessyeAssaultEmpowered0_Class ZalessyeAssaultOnslaught2 { get; set; }
                public ZalessyeAssaultHologramClass ZalessyeAssault0 { get; set; }
                public ZalessyeAssaultHologramClass ZalessyeAssault1 { get; set; }
                public ZalessyeAssaultHologramClass ZalessyeAssault2 { get; set; }
                public ZalessyeAssaultHologramClass ZalessyeAssault3 { get; set; }
                public ZalessyeAssaultEmpowered0_Class ZalessyeAssaultPvPvE { get; set; }
                public TaurusChemistEmpowered0 ZalessyeChemistEmpowered0 { get; set; }
                public TaurusChemistOnslaught0 ZalessyeChemistOnslaught0 { get; set; }
                public Elimination ZalessyeChemistOnslaught0_Elimination { get; set; }
                public TaurusChemistOnslaught0 ZalessyeChemistOnslaught1 { get; set; }
                public Elimination ZalessyeChemistOnslaught1_Elimination { get; set; }
                public TaurusChemistOnslaught0 ZalessyeChemistOnslaught2 { get; set; }
                public Elimination ZalessyeChemistOnslaught2_Elimination { get; set; }
                public TaurusChemistEmpowered0 ZalessyeChemist0 { get; set; }
                public TaurusChemistOnslaught2 ZalessyeChemist1 { get; set; }
                public TaurusChemistEmpowered0 ZalessyeChemist2 { get; set; }
                public TaurusChemistEmpowered0 ZalessyeChemist3 { get; set; }
                public ZalessyeFighterEmpowered0 ZalessyeFighterEmpowered0 { get; set; }
                public TaurusFighterOnslaught0 ZalessyeFighterOnslaught0 { get; set; }
                public TaurusFighterOnslaught0 ZalessyeFighterOnslaught0_Elimination { get; set; }
                public TaurusFighterOnslaught0 ZalessyeFighterOnslaught1 { get; set; }
                public TaurusFighterOnslaught0 ZalessyeFighterOnslaught1_Elimination { get; set; }
                public FighterOnslaught2 ZalessyeFighterOnslaught2 { get; set; }
                public FighterOnslaught2__Elimination ZalessyeFighterOnslaught2_Elimination { get; set; }
                public TaurusFighter1 ZalessyeFighter0 { get; set; }
                public TaurusFighter1 ZalessyeFighter1 { get; set; }
                public TaurusFighter1 ZalessyeFighter2 { get; set; }
                public TaurusFighter1 ZalessyeFighter3 { get; set; }
                public ZalessyeFighterPvPvE ZalessyeFighterPvPvE { get; set; }
                public TaurusGunnerOnslaught0 ZalessyeGunnerEmpowered0 { get; set; }
                public TaurusGunnerOnslaught0 ZalessyeGunnerOnslaught0 { get; set; }
                public TaurusGunnerOnslaught0 ZalessyeGunnerOnslaught1 { get; set; }
                public TaurusGunnerOnslaught0 ZalessyeGunnerOnslaught2 { get; set; }
                public TaurusGunnerOnslaught0 ZalessyeGunner0 { get; set; }
                public TaurusGunnerOnslaught0 ZalessyeGunner1 { get; set; }
                public TaurusGunnerOnslaught0 ZalessyeGunner2 { get; set; }
                public TaurusGunnerOnslaught0 ZalessyeGunner3 { get; set; }
                public TaurusGunnerOnslaught0 ZalessyeGunnerPvPvE { get; set; }
                public ZalessyeJuggernautOnslaught ZalessyeJuggernautOnslaught { get; set; }
                public ZalessyeJuggernaut0 ZalessyeJuggernaut0 { get; set; }
                public TaurusLeaderEmpowered0 ZalessyeLeaderEmpowered0 { get; set; }
                public ZalessyeLeader ZalessyeLeader0 { get; set; }
                public ZalessyeLeader ZalessyeLeader1 { get; set; }
                public ZalessyeLeader ZalessyeLeader2 { get; set; }
                public ZalessyeLeader ZalessyeLeader3 { get; set; }
                public ZalessyeOfficerMedic ZalessyeOfficerMedic { get; set; }
                public ZalessyeOfficerMedicOnslaught ZalessyeOfficerMedicOnslaught0 { get; set; }
                public ZalessyeOfficerMedicOnslaught ZalessyeOfficerMedicOnslaught1 { get; set; }
                public ZalessyeOfficerMedicOnslaught ZalessyeOfficerMedicOnslaught2 { get; set; }
                public TaurusGunnerEmpowered0 ZalessyeOfficerSupport { get; set; }
                public TaurusOfficerSupportOnslaught0 ZalessyeOfficerSupportOnslaught0 { get; set; }
                public TaurusOfficerSupportOnslaught0 ZalessyeOfficerSupportOnslaught1 { get; set; }
                public TaurusOfficerSupportOnslaught0 ZalessyeOfficerSupportOnslaught2 { get; set; }
                public TaurusGunnerEmpowered0 ZalessyeOfficerSupportPvPvE { get; set; }
                public ZalessyeRocketmanEmpowered0_Class ZalessyeRocketmanEmpowered0 { get; set; }
                public ZalessyeRocketmanOnslaught ZalessyeRocketmanOnslaught0 { get; set; }
                public ZalessyeRocketmanOnslaughtElimination ZalessyeRocketmanOnslaught0_Elimination { get; set; }
                public ZalessyeRocketmanOnslaught ZalessyeRocketmanOnslaught1 { get; set; }
                public ZalessyeRocketmanOnslaughtElimination ZalessyeRocketmanOnslaught1_Elimination { get; set; }
                public ZalessyeRocketmanEmpowered0_Class ZalessyeRocketmanOnslaught2 { get; set; }
                public ZalessyeRocketmanEmpowered0_Class ZalessyeRocketmanOnslaught2_Elimination { get; set; }
                public ZalessyeRocketmanEmpowered0_Class ZalessyeRocketman0 { get; set; }
                public ZalessyeRocketman1_Class ZalessyeRocketman1 { get; set; }
                public ZalessyeRocketman1_Class ZalessyeRocketman2 { get; set; }
                public ZalessyeRocketman1_Class ZalessyeRocketman3 { get; set; }
                public ZalessyeRocketmanPvPvE ZalessyeRocketmanPvPvE { get; set; }
                public TaurusSergeantEmpowered0 ZalessyeSergeantEmpowered0 { get; set; }
                public TaurusSergeantEmpowered0 ZalessyeSergeant0 { get; set; }
                public TaurusSergeantEmpowered0 ZalessyeSergeant1 { get; set; }
                public TaurusSergeantEmpowered0 ZalessyeSergeant2 { get; set; }
                public TaurusSergeantEmpowered0 ZalessyeSergeant3 { get; set; }
                public ZalessyeShooterEmpowered0 ZalessyeShooterEmpowered0 { get; set; }
                public ZalessyeShooter ZalessyeShooterOnslaught0 { get; set; }
                public ZalessyeShooter ZalessyeShooterOnslaught0_Elimination { get; set; }
                public ZalessyeShooter ZalessyeShooterOnslaught1 { get; set; }
                public ZalessyeShooter ZalessyeShooterOnslaught1_Elimination { get; set; }
                public ZalessyeShooter ZalessyeShooterOnslaught2 { get; set; }
                public ZalessyeShooter ZalessyeShooterOnslaught2_Elimination { get; set; }
                public ZalessyeShooter ZalessyeShooter0 { get; set; }
                public ZalessyeShooter ZalessyeShooter1 { get; set; }
                public ZalessyeShooter ZalessyeShooter2 { get; set; }
                public ZalessyeShooter ZalessyeShooter3 { get; set; }
                public ZalessyeShooter ZalessyeShooterPvPvE { get; set; }
                public ZalessyeShooter ZalessyeShooterPvPvENoInvest { get; set; }
                public TaurusSniperEmpowered0 ZalessyeSniperEmpowered0 { get; set; }
                public TaurusSniperEmpowered0 ZalessyeSniperOnslaught0 { get; set; }
                public TaurusSniperEmpowered0 ZalessyeSniperOnslaught0_Elimination { get; set; }
                public TaurusSniperEmpowered0 ZalessyeSniperOnslaught1 { get; set; }
                public TaurusSniperEmpowered0 ZalessyeSniperOnslaught1_Elimination { get; set; }
                public TaurusSniperEmpowered0 ZalessyeSniperOnslaught2 { get; set; }
                public TaurusSniperEmpowered0 ZalessyeSniperOnslaught2_Elimination { get; set; }
                public TaurusSniperEmpowered0 ZalessyeSniper0 { get; set; }
                public TaurusSniperEmpowered0 ZalessyeSniper1 { get; set; }
                public TaurusSniperEmpowered0 ZalessyeSniper2 { get; set; }
                public TaurusSniperEmpowered0 ZalessyeSniper3 { get; set; }
                public TaurusSniperEmpowered0 ZalessyeSniperPvPvE { get; set; }
            }

            public partial class AllyBotAssault
            {
                public long TeamId { get; set; }
                public AllyBotAssaultClientCard ClientCard { get; set; }
                public AllyBotAssaultGameData GameData { get; set; }
                public AllyBotAssaultBotCfg BotCfg { get; set; }
            }

            public partial class AllyBotAssaultBotCfg
            {
                public Role? Archetype { get; set; }
                public double RethinkTime { get; set; }
                public long RotationRateHorizontal { get; set; }
                public long RotationRateVertical { get; set; }
                public long StayInCoverTime { get; set; }
                public long OptimalCombatRange { get; set; }
                public double AttackFromCoverTime { get; set; }
                public double? GrenadeHappiness { get; set; }
                public PurplePrimaryWeaponStrategy PrimaryWeaponStrategy { get; set; }
                public bool? CanSprint { get; set; }
                public long? PathFindingVariationInterval { get; set; }
                public bool? ShouldStopAtStopDistance { get; set; }
                public bool? ReactsToHardHit { get; set; }
            }

            public partial class PurplePrimaryWeaponStrategy
            {
                public double FireTime { get; set; }
                public double FirePauseTime { get; set; }
            }

            public partial class AllyBotAssaultClientCard
            {
                public Role Role { get; set; }
                public AbilityEnum? Ability { get; set; }
                public string Visual { get; set; }
                public List<Skin> Items { get; set; }
                public ClientCardCustomAnims CustomAnims { get; set; }
                public CollectionEnum? Collection { get; set; }
            }

            public partial class ClientCardCustomAnims
            {
                public Greeting Greeting { get; set; }
            }

            public partial class Greeting
            {
                public List<Tion?> ActiveAnimations { get; set; }
                public List<Tion> AvaiableAnimations { get; set; }
            }

            public partial class Skin
            {
                public SlotElement Slot { get; set; }
                public string Visual { get; set; }
            }

            public partial class AllyBotAssaultGameData
            {
                public PurpleAryWeapon PrimaryWeapon { get; set; }
                public HeavyWeapon HeavyWeapon { get; set; }
                public long RevivesCount { get; set; }
                public long ReviveAmount { get; set; }
                public long ReviveSpeed { get; set; }
                public long HitMultHead { get; set; }
                public long HitMultBody { get; set; }
                public double HitMultLegs { get; set; }
                public long Health { get; set; }
                public long? ArmorHealth { get; set; }
                public double? ArmorResistance { get; set; }
                public MovementCfg MovementCfg { get; set; }
                public MultiplyClass Abilities { get; set; }
            }

            public partial class HeavyWeapon
            {
                public long ItemType { get; set; }
                public long WeaponType { get; set; }
                public long ItemPlantingType { get; set; }
                public bool Hitscan { get; set; }
                public bool IsClipfed { get; set; }
                public bool IsManuallyCycled { get; set; }
                public bool? HasOpticalSight { get; set; }
                public double BoltCycleTime { get; set; }
                public bool BurstShot { get; set; }
                public bool AutomaticFire { get; set; }
                public bool SoundAutomaticFire { get; set; }
                public long BulletsPerShot { get; set; }
                public double RateOfFire { get; set; }
                public bool? AmmoAmountForEntireMatch { get; set; }
                public long ClipSize { get; set; }
                public long MaxClipCount { get; set; }
                public long Damage { get; set; }
                public double DamageRadius { get; set; }
                public long DamageRadiusTrajectory { get; set; }
                public double DamageCoefOnUncovered { get; set; }
                public long HeadshotMult { get; set; }
                public double BulletSpeed { get; set; }
                public long MaxDistanceForBullet { get; set; }
                public long TimeToLife { get; set; }
                public bool ProjectileRebound { get; set; }
                public long HitTargetsLimit { get; set; }
                public long? FovStandart { get; set; }
                public long? FovAim { get; set; }
                public long? FovSniper { get; set; }
                public double? AimSensitivityModifier { get; set; }
                public long? AimGrenadeMidAngleOffset { get; set; }
                public double SwitchInTime { get; set; }
                public double SwitchOutTime { get; set; }
                public double ReloadTime { get; set; }
                public double? ReloadCombinedTime { get; set; }
                public long SpeedModOnRun { get; set; }
                public long SpeedModOnCrouch { get; set; }
                public long SpeedModOnAds { get; set; }
                public long SpeedModOnSprint { get; set; }
                public LocalCheckDirection SpreadConeMin { get; set; }
                public LocalCheckDirection SpreadConeMax { get; set; }
                public LocalCheckDirection SpreadConeMovementAdd { get; set; }
                public LocalCheckDirection SpreadIncreasePerShot { get; set; }
                public LocalCheckDirection SpreadIncreaseOnMove { get; set; }
                public LocalCheckDirection SpreadIncreaseOnRotate { get; set; }
                public LocalCheckDirection SpreadRestoreSpeed { get; set; }
                public LocalCheckDirection SpreadRestoreDelay { get; set; }
                public long? ShotFirstShotModifier { get; set; }
                public long? ShotFirstShotTimeOffset { get; set; }
                public long? ShotFovChangeLimit { get; set; }
                public LocalCheckDirection ShotKickUp { get; set; }
                public LocalCheckDirection ShotKickHorizontalMean { get; set; }
                public LocalCheckDirection ShotKickHorizontalDeviation { get; set; }
                public LocalCheckDirection ShotKickRestoreDelay { get; set; }
                public LocalCheckDirection ShotKickRestoreSpeed { get; set; }
                public LocalCheckDirection ShotFovChange { get; set; }
                public LocalCheckDirection ShotFovRestoreDelay { get; set; }
                public LocalCheckDirection ShotFovRestoreSpeed { get; set; }
                public LocalCheckDirection LooseRecoilRestoreDelay { get; set; }
                public LocalCheckDirection LooseRecoilRestoreSpeed { get; set; }
                public long? LooseRecoilMaxAngle { get; set; }
                public long? LooseRecoilElasticity { get; set; }
                public DamageCurve SwayAmplitudeStay { get; set; }
                public DamageCurve SwayAmplitudeSit { get; set; }
                public DamageCurve SwayPeriod { get; set; }
                public DamageCurve SwayFadeTime { get; set; }
                public DamageCurve SwayMoveAmplitudeStay { get; set; }
                public DamageCurve SwayMoveAmplitudeSit { get; set; }
                public DamageCurve SwayMovePeriod { get; set; }
                public DamageCurve SwayMoveFadeTime { get; set; }
                public DamageCurve SwayShotModifier { get; set; }
                public long? DropItemType { get; set; }
                public long? AuraRadius { get; set; }
                public long? AuraTeamRule { get; set; }
                public bool? AuraCollision { get; set; }
                public long? AuraUpdPeriod { get; set; }
                public long? AuraHealthRadius { get; set; }
                public long? AuraActivationDelay { get; set; }
                public long? CombatEffectRadius { get; set; }
                public long? CombatEffectTeamRule { get; set; }
                public bool? IsSmokeToxic { get; set; }
                public long? CombatEffectImpactPeriodPrimary { get; set; }
                public long? CombatEffectImpactValuePrimary { get; set; }
                public LocalCheckDirection CombatEffectTimes { get; set; }
                public LocalCheckDirection FirePrepareTime { get; set; }
                public bool? FirePrepareHold { get; set; }
                public bool? IsDamageCurveIgnored { get; set; }
                public Dictionary<string, DamageCurve> DamageCurve { get; set; }
                public List<object> PassiveAbilities { get; set; }
                public Ksk2011SupportFxType FxType { get; set; }
                public double FxRadius { get; set; }
                public long? GravityCompensation { get; set; }
                public long? WeaponExplosiveSubtype { get; set; }
                public SecondaryWeaponExplosionFxType? ExplosionFxType { get; set; }
                public bool? UnlimitedClips { get; set; }
                public double? ArmorPenetration { get; set; }
            }

            public partial class LocalCheckDirection
            {
                public double X { get; set; }
                public double Y { get; set; }
                public double Z { get; set; }
            }

            public partial class MovementCfg
            {
                public double CapsuleRadius { get; set; }
                public long MaxSlopeAngle { get; set; }
                public Params RunParams { get; set; }
                public Params SprintParams { get; set; }
                public Params CrouchParams { get; set; }
                public Params KnockdownParams { get; set; }
                public long Stamina { get; set; }
                public long SprintStartStaminaFraction { get; set; }
                public long StaminaRestoreTime { get; set; }
            }

            public partial class Params
            {
                public double CapsuleHeight { get; set; }
                public double HeadSize { get; set; }
                public double FirePosHeight { get; set; }
                public double Speed { get; set; }
                public DamageCurve SpeedProportions { get; set; }
                public double? InertiaTime { get; set; }
                public Speed SpeedUp { get; set; }
                public Speed SpeedDown { get; set; }
            }

            public partial class Speed
            {
                public long Ease { get; set; }
                public double Time { get; set; }
            }

            public partial class PurpleAryWeapon
            {
                public long ItemType { get; set; }
                public long WeaponType { get; set; }
                public long? ItemPlantingType { get; set; }
                public bool Hitscan { get; set; }
                public bool IsClipfed { get; set; }
                public bool? HasOpticalSight { get; set; }
                public double BoltCycleTime { get; set; }
                public bool AutomaticFire { get; set; }
                public bool? SoundAutomaticFire { get; set; }
                public long BulletsPerShot { get; set; }
                public double RateOfFire { get; set; }
                public long ClipSize { get; set; }
                public long MaxClipCount { get; set; }
                public bool? UnlimitedClips { get; set; }
                public long Damage { get; set; }
                public double HeadshotMult { get; set; }
                public long BulletSpeed { get; set; }
                public long MaxDistanceForBullet { get; set; }
                public long? HitTargetsLimit { get; set; }
                public double SwitchInTime { get; set; }
                public double SwitchOutTime { get; set; }
                public double ReloadTime { get; set; }
                public double? ReloadCombinedTime { get; set; }
                public long SpeedModOnRun { get; set; }
                public long SpeedModOnCrouch { get; set; }
                public long SpeedModOnAds { get; set; }
                public long SpeedModOnSprint { get; set; }
                public LocalCheckDirection SpreadConeMin { get; set; }
                public LocalCheckDirection SpreadConeMax { get; set; }
                public LocalCheckDirection SpreadConeMovementAdd { get; set; }
                public LocalCheckDirection SpreadIncreasePerShot { get; set; }
                public LocalCheckDirection SpreadIncreaseOnMove { get; set; }
                public LocalCheckDirection SpreadRestoreSpeed { get; set; }
                public LocalCheckDirection SpreadRestoreDelay { get; set; }
                public LocalCheckDirection ShotKickUp { get; set; }
                public LocalCheckDirection ShotKickHorizontalMean { get; set; }
                public LocalCheckDirection ShotKickHorizontalDeviation { get; set; }
                public LocalCheckDirection ShotKickRestoreDelay { get; set; }
                public LocalCheckDirection ShotKickRestoreSpeed { get; set; }
                public Dictionary<string, DamageCurve> DamageCurve { get; set; }
                public bool? IsManuallyCycled { get; set; }
                public bool? BurstShot { get; set; }
                public bool? AmmoAmountForEntireMatch { get; set; }
                public long? DamageRadius { get; set; }
                public long? DamageRadiusTrajectory { get; set; }
                public double? DamageCoefOnUncovered { get; set; }
                public long? TimeToLife { get; set; }
                public double? AimSensitivityModifier { get; set; }
                public long? AimGrenadeMidAngleOffset { get; set; }
                public bool? ProjectileRebound { get; set; }
                public double? ArmorPenetration { get; set; }
                public long? WeaponExplosiveSubtype { get; set; }
                public SecondaryWeaponExplosionFxType? ExplosionFxType { get; set; }
                public Ksk2011SupportFxType? FxType { get; set; }
                public double? FxRadius { get; set; }
                public double? GravityCompensation { get; set; }
                public long? BurstShotValue { get; set; }
                public long? RateOfBurst { get; set; }
                public long? DestructibleMult { get; set; }
                public long? SpreadConeActionAdd { get; set; }
                public LocalCheckDirection SpreadIncreaseOnRotate { get; set; }
                public long? SpreadIncreaseOnAction { get; set; }
                public long? SpreadRandomMin { get; set; }
                public long? ShotFirstShotModifier { get; set; }
                public double? ShotFirstShotTimeOffset { get; set; }
                public LocalCheckDirection FirePrepareTime { get; set; }
                public bool? BulletsCanBeDeactivated { get; set; }
                public long? CombatEffectRadius { get; set; }
                public long? CombatEffectTeamRule { get; set; }
                public long? CombatEffectType { get; set; }
                public double? CombatEffectImpactPeriodPrimary { get; set; }
                public long? CombatEffectImpactValuePrimary { get; set; }
                public long? CombatEffectImpactPeriodSecondary { get; set; }
                public LocalCheckDirection CombatEffectTimes { get; set; }
                public bool? FirePrepareHold { get; set; }
                public bool? IsDamageCurveIgnored { get; set; }
            }

            public partial class AllyBotFsb2004A
            {
                public long TeamId { get; set; }
                public AllyBotFsb2004AClientCard ClientCard { get; set; }
                public AllyBotFsb2004AGameData GameData { get; set; }
                public AllyBotFsb2004ABotCfg BotCfg { get; set; }
                public Ai Ai { get; set; }
            }

            public partial class Ai
            {
                public string Type { get; set; }
                public Role SquadRole { get; set; }
                public Dictionary<string, double> AiParams { get; set; }
            }

            public partial class AllyBotFsb2004ABotCfg
            {
                public Role Archetype { get; set; }
                public double RethinkTime { get; set; }
                public long RotationRateHorizontal { get; set; }
                public long RotationRateVertical { get; set; }
                public long StayInCoverTime { get; set; }
                public long OptimalCombatRange { get; set; }
                public bool CanSprint { get; set; }
                public YWeaponStrategy PrimaryWeaponStrategy { get; set; }
            }

            public partial class YWeaponStrategy
            {
                public double? LockOnTime { get; set; }
                public long? NonlethalFireDuration { get; set; }
                public double FireTime { get; set; }
                public double FirePauseTime { get; set; }
                public long? TargetingSwayMaxCycles { get; set; }
                public bool? SingleFire { get; set; }
            }

            public partial class AllyBotFsb2004AClientCard
            {
                public Role Role { get; set; }
                public AbilityEnum? Ability { get; set; }
                public string Visual { get; set; }
                public List<PurpleItem> Items { get; set; }
            }

            public partial class PurpleItem
            {
                public SlotElement Slot { get; set; }
                public string Visual { get; set; }
                public SkinVisualEnum? SkinVisual { get; set; }
            }

            public partial class AllyBotFsb2004AGameData
            {
                public PurpleYWeapon PrimaryWeapon { get; set; }
                public long RevivesCount { get; set; }
                public long ReviveAmount { get; set; }
                public long ReviveSpeed { get; set; }
                public long Health { get; set; }
                public long ArmorHealth { get; set; }
                public long ArmorResistance { get; set; }
                public long HitMultHead { get; set; }
                public long HitMultBody { get; set; }
                public double HitMultLegs { get; set; }
                public MovementCfg MovementCfg { get; set; }
                public MultiplyClass Abilities { get; set; }
            }

            public partial class PurpleYWeapon
            {
                public long ItemType { get; set; }
                public long WeaponType { get; set; }
                public long? ItemPlantingType { get; set; }
                public bool? Hitscan { get; set; }
                public bool IsClipfed { get; set; }
                public bool IsManuallyCycled { get; set; }
                public bool? HasOpticalSight { get; set; }
                public double BoltCycleTime { get; set; }
                public bool? BurstShot { get; set; }
                public bool AutomaticFire { get; set; }
                public bool? SoundAutomaticFire { get; set; }
                public long BulletsPerShot { get; set; }
                public double RateOfFire { get; set; }
                public bool AmmoAmountForEntireMatch { get; set; }
                public long ClipSize { get; set; }
                public long MaxClipCount { get; set; }
                public double Damage { get; set; }
                public double DamageRadius { get; set; }
                public long DamageRadiusTrajectory { get; set; }
                public double DamageCoefOnUncovered { get; set; }
                public double HeadshotMult { get; set; }
                public double BulletSpeed { get; set; }
                public long MaxDistanceForBullet { get; set; }
                public double TimeToLife { get; set; }
                public bool? ProjectileRebound { get; set; }
                public long? HitTargetsLimit { get; set; }
                public long? FovStandart { get; set; }
                public long? FovAim { get; set; }
                public long? FovSniper { get; set; }
                public double AimSensitivityModifier { get; set; }
                public long AimGrenadeMidAngleOffset { get; set; }
                public double SwitchInTime { get; set; }
                public double SwitchOutTime { get; set; }
                public double ReloadTime { get; set; }
                public double ReloadCombinedTime { get; set; }
                public long? SpeedModOnRun { get; set; }
                public long? SpeedModOnCrouch { get; set; }
                public double? SpeedModOnAds { get; set; }
                public long? SpeedModOnSprint { get; set; }
                public LocalCheckDirection SpreadConeMin { get; set; }
                public LocalCheckDirection SpreadConeMax { get; set; }
                public LocalCheckDirection SpreadConeMovementAdd { get; set; }
                public LocalCheckDirection SpreadIncreasePerShot { get; set; }
                public LocalCheckDirection SpreadIncreaseOnMove { get; set; }
                public LocalCheckDirection SpreadIncreaseOnRotate { get; set; }
                public LocalCheckDirection SpreadRestoreSpeed { get; set; }
                public LocalCheckDirection SpreadRestoreDelay { get; set; }
                public double ShotFirstShotModifier { get; set; }
                public double ShotFirstShotTimeOffset { get; set; }
                public double ShotFovChangeLimit { get; set; }
                public LocalCheckDirection ShotKickUp { get; set; }
                public LocalCheckDirection ShotKickHorizontalMean { get; set; }
                public LocalCheckDirection ShotKickHorizontalDeviation { get; set; }
                public LocalCheckDirection ShotKickRestoreDelay { get; set; }
                public LocalCheckDirection ShotKickRestoreSpeed { get; set; }
                public LocalCheckDirection ShotFovChange { get; set; }
                public LocalCheckDirection ShotFovRestoreDelay { get; set; }
                public LocalCheckDirection ShotFovRestoreSpeed { get; set; }
                public LocalCheckDirection LooseRecoilRestoreDelay { get; set; }
                public LocalCheckDirection LooseRecoilRestoreSpeed { get; set; }
                public double? LooseRecoilMaxAngle { get; set; }
                public double? LooseRecoilElasticity { get; set; }
                public DamageCurve SwayAmplitudeStay { get; set; }
                public DamageCurve SwayAmplitudeSit { get; set; }
                public DamageCurve SwayPeriod { get; set; }
                public DamageCurve SwayFadeTime { get; set; }
                public DamageCurve SwayMoveAmplitudeStay { get; set; }
                public DamageCurve SwayMoveAmplitudeSit { get; set; }
                public DamageCurve SwayMovePeriod { get; set; }
                public DamageCurve SwayMoveFadeTime { get; set; }
                public DamageCurve SwayShotModifier { get; set; }
                public long DropItemType { get; set; }
                public long AuraRadius { get; set; }
                public long AuraTeamRule { get; set; }
                public bool AuraCollision { get; set; }
                public long AuraUpdPeriod { get; set; }
                public long AuraHealthRadius { get; set; }
                public long AuraActivationDelay { get; set; }
                public long CombatEffectRadius { get; set; }
                public long CombatEffectTeamRule { get; set; }
                public bool? IsSmokeToxic { get; set; }
                public double CombatEffectImpactPeriodPrimary { get; set; }
                public long CombatEffectImpactValuePrimary { get; set; }
                public LocalCheckDirection CombatEffectTimes { get; set; }
                public LocalCheckDirection FirePrepareTime { get; set; }
                public bool FirePrepareHold { get; set; }
                public bool IsDamageCurveIgnored { get; set; }
                public Dictionary<string, DamageCurve> DamageCurve { get; set; }
                public List<object> PassiveAbilities { get; set; }
                public PrimaryWeaponFxType? FxType { get; set; }
                public double FxRadius { get; set; }
                public long? WeaponStrategy { get; set; }
                public long? WeaponExplosiveSubtype { get; set; }
                public long? GravityCompensation { get; set; }
                public bool? IsManuallyActivatable { get; set; }
                public double? ArmorPenetration { get; set; }
                public bool? HasBipod { get; set; }
                public bool? IsGuided { get; set; }
                public long? GuidanceActivationTime { get; set; }
                public long? GuidanceSensivity { get; set; }
                public long? BurstShotValue { get; set; }
                public long? RateOfBurst { get; set; }
                public double? DestructibleMult { get; set; }
                public long? ProjectileReboundBehaviour { get; set; }
                public long? RicochetsLimit { get; set; }
                public long? SpreadConeActionAdd { get; set; }
                public long? SpreadIncreaseOnAction { get; set; }
                public long? SpreadRandomMin { get; set; }
                public long? AdsSpeedMult { get; set; }
                public double? ShotRollAmplitude { get; set; }
                public long? ShotRollFrequency { get; set; }
                public double? ShotRollTime { get; set; }
                public double? ShotRollThirdPersonMultiplier { get; set; }
                public long? ShotKickCompensationCoef { get; set; }
                public long? MaxDropItemsOnScene { get; set; }
                public long? DeploymentType { get; set; }
                public long? DeploymentDuration { get; set; }
                public long? DeploymentCooldown { get; set; }
                public long? AirstrikeMaxDistance { get; set; }
                public SoundFxEnum? ExplosionFxType { get; set; }
                public bool? UnlimitedClips { get; set; }
                public long? HumanPerforationLimit { get; set; }
                public bool? IsAffectedByGravity { get; set; }
                public long? WeaponConsumableType { get; set; }
                public bool? BulletsCanBeDeactivated { get; set; }
                public double? BattleReadyAmmoClipFraction { get; set; }
                public double? LowAmmoClipFraction { get; set; }
                public long? ScanTargetRadius { get; set; }
                public long? ScanBuffDuration { get; set; }
                public long? CombatEffectType { get; set; }
                public long? Count { get; set; }
                public long? CombatEffectImpactPeriodSecondary { get; set; }
            }

            public partial class AllyBotFsb2004
            {
                public long TeamId { get; set; }
                public AllyBotFsb2004AClientCard ClientCard { get; set; }
                public AllyBotAssaultGameData GameData { get; set; }
                public AllyBotAssaultBotCfg BotCfg { get; set; }
                public Ai Ai { get; set; }
            }

            public partial class AllyBotFsb2004M
            {
                public long TeamId { get; set; }
                public AllyBotFsb2004AClientCard ClientCard { get; set; }
                public AllyBotFsb2004MGameData GameData { get; set; }
                public AllyBotFsb2004MBotCfg BotCfg { get; set; }
            }

            public partial class AllyBotFsb2004MBotCfg
            {
                public Role Archetype { get; set; }
                public bool DisplayAsHumanPlayer { get; set; }
                public long RethinkTime { get; set; }
                public long RotationRateHorizontal { get; set; }
                public long RotationRateVertical { get; set; }
                public long StayInCoverTime { get; set; }
                public long OptimalCombatRange { get; set; }
                public double AttackFromCoverTime { get; set; }
                public bool CanSprint { get; set; }
                public bool ReactsToHardHit { get; set; }
                public long HearingRadius { get; set; }
                public double GrenadeHappiness { get; set; }
                public long? UrgeToChangeToBetterPosition { get; set; }
                public double? PathFindingMaxVariation { get; set; }
                public long CommunicationRadius { get; set; }
                public PurplePrimaryWeaponStrategy PrimaryWeaponStrategy { get; set; }
                public bool? NeedFatality { get; set; }
                public YWeaponStrategy HeavyWeaponStrategy { get; set; }
            }

            public partial class AllyBotFsb2004MGameData
            {
                public PurpleYWeapon PrimaryWeapon { get; set; }
                public long RevivesCount { get; set; }
                public long ReviveAmount { get; set; }
                public long ReviveSpeed { get; set; }
                public long HitMultHead { get; set; }
                public long HitMultBody { get; set; }
                public long HitMultLegs { get; set; }
                public long Health { get; set; }
                public MovementCfg MovementCfg { get; set; }
                public MultiplyClass Abilities { get; set; }
            }

            public partial class AllyBotHeavy
            {
                public long TeamId { get; set; }
                public AllyBotAssaultClientCard ClientCard { get; set; }
                public AllyBotHeavyGameData GameData { get; set; }
                public AllyBotAssaultBotCfg BotCfg { get; set; }
            }

            public partial class AllyBotHeavyGameData
            {
                public PurpleAryWeapon PrimaryWeapon { get; set; }
                public long RevivesCount { get; set; }
                public long ReviveAmount { get; set; }
                public long ReviveSpeed { get; set; }
                public long HitMultHead { get; set; }
                public long HitMultBody { get; set; }
                public long HitMultLegs { get; set; }
                public long Health { get; set; }
                public MovementCfg MovementCfg { get; set; }
                public MultiplyClass Abilities { get; set; }
            }

            public partial class AllyBotHostage
            {
                public long TeamId { get; set; }
                public AllyBotAssaultClientCard ClientCard { get; set; }
                public AllyBotHostageGameData GameData { get; set; }
                public AllyBotHostageBotCfg BotCfg { get; set; }
            }

            public partial class AllyBotHostageBotCfg
            {
                public Role Archetype { get; set; }
                public long RethinkTime { get; set; }
                public long RotationRateHorizontal { get; set; }
                public long RotationRateVertical { get; set; }
                public long StayInCoverTime { get; set; }
                public bool ReactsToHardHit { get; set; }
                public long OptimalCombatRange { get; set; }
                public Duration AttackFromCoverTime { get; set; }
                public long PathFindingVariationInterval { get; set; }
                public bool ShouldStopAtStopDistance { get; set; }
                public PurplePrimaryWeaponStrategy PrimaryWeaponStrategy { get; set; }
            }

            public partial class AllyBotHostageGameData
            {
                public PurpleAryWeapon PrimaryWeapon { get; set; }
                public long RevivesCount { get; set; }
                public long ReviveAmount { get; set; }
                public long ReviveSpeed { get; set; }
                public long HitMultHead { get; set; }
                public long HitMultBody { get; set; }
                public double HitMultLegs { get; set; }
                public long Health { get; set; }
                public long? ArmorHealth { get; set; }
                public long? ArmorResistance { get; set; }
                public MovementCfg MovementCfg { get; set; }
                public MultiplyClass Abilities { get; set; }
            }

            public partial class AllyBotInformer
            {
                public long TeamId { get; set; }
                public AllyBotAssaultClientCard ClientCard { get; set; }
                public AllyBotInformerGameData GameData { get; set; }
                public AllyBotInformerBotCfg BotCfg { get; set; }
            }

            public partial class AllyBotInformerBotCfg
            {
                public double RethinkTime { get; set; }
                public long RotationRateHorizontal { get; set; }
                public long RotationRateVertical { get; set; }
                public double StayInCoverTime { get; set; }
                public long OptimalCombatRange { get; set; }
                public double AttackFromCoverTime { get; set; }
                public double? GrenadeTargetingTime { get; set; }
                public double? GrenadeHappiness { get; set; }
                public double? UrgeToChangeToBetterPosition { get; set; }
                public long? FinalOptimalCombatRange { get; set; }
                public long? FinalOptimalCombatRangeReachSeconds { get; set; }
                public bool? CanSprint { get; set; }
                public bool? AvoidPoison { get; set; }
                public bool AvoidFire { get; set; }
                public bool AvoidBullets { get; set; }
                public bool? ReactsToHardHit { get; set; }
                public PurplePrimaryWeaponStrategy PrimaryWeaponStrategy { get; set; }
                public PurpleArchetype? Archetype { get; set; }
                public long? StopDistance { get; set; }
                public bool? AvoidSmokes { get; set; }
                public bool? SearchReachablePath { get; set; }
                public long? PvpveKillScore { get; set; }
                public long? InvestigationPriority { get; set; }
                public long? HearingRadius { get; set; }
                public double? BattleReadyAmmoClipFraction { get; set; }
                public bool? AvoidSmoke { get; set; }
                public bool? FullStaminaOnSpawn { get; set; }
                public bool? AbilityActivationRequiresEnemyKnowledge { get; set; }
                public Tion? PrimaryAbilityEmotion { get; set; }
                public long? EnemyProximityRange { get; set; }
                public bool? NeedFatality { get; set; }
            }

            public partial class AllyBotInformerGameData
            {
                public PurpleAryWeapon PrimaryWeapon { get; set; }
                public PurpleAryWeapon SecondaryWeapon { get; set; }
                public long RevivesCount { get; set; }
                public long ReviveAmount { get; set; }
                public long ReviveSpeed { get; set; }
                public long HitMultHead { get; set; }
                public long HitMultBody { get; set; }
                public double HitMultLegs { get; set; }
                public long Health { get; set; }
                public long ArmorHealth { get; set; }
                public long ArmorResistance { get; set; }
                public MovementCfg MovementCfg { get; set; }
                public PurpleResistsCfg ResistsCfg { get; set; }
                public MultiplyClass Abilities { get; set; }
                public PurpleYWeapon HeavyWeapon { get; set; }
            }

            public partial class PurpleResistsCfg
            {
                public long ResistRateOfFire { get; set; }
                public long ResistReloadTime { get; set; }
                public long ResistSpreadConeMax { get; set; }
                public long ResistSpeedScale { get; set; }
                public long ImmuneFlags { get; set; }
                public MultiplyClass BuffDurationMods { get; set; }
                public MultiplyClass IncomingDamageMods { get; set; }
                public double? JumpDamageMult { get; set; }
            }

            public partial class AllyBotMedic
            {
                public long TeamId { get; set; }
                public AllyBotAssaultClientCard ClientCard { get; set; }
                public AllyBotHostageGameData GameData { get; set; }
                public AllyBotAssaultBotCfg BotCfg { get; set; }
            }

            public partial class AllyBotRocketman
            {
                public long TeamId { get; set; }
                public AllyBotAssaultClientCard ClientCard { get; set; }
                public AllyBotRocketmanGameData GameData { get; set; }
                public AllyBotFsb2004ABotCfg BotCfg { get; set; }
            }

            public partial class AllyBotRocketmanGameData
            {
                public PurpleAryWeapon PrimaryWeapon { get; set; }
                public long RevivesCount { get; set; }
                public long ReviveAmount { get; set; }
                public long ReviveSpeed { get; set; }
                public long HitMultHead { get; set; }
                public long HitMultBody { get; set; }
                public double HitMultLegs { get; set; }
                public long Health { get; set; }
                public long ArmorHealth { get; set; }
                public double ArmorResistance { get; set; }
                public MovementCfg MovementCfg { get; set; }
            }

            public partial class AllyBotSniper
            {
                public long TeamId { get; set; }
                public AllyBotAssaultClientCard ClientCard { get; set; }
                public AllyBotSniperGameData GameData { get; set; }
                public AllyBotAssaultBotCfg BotCfg { get; set; }
            }

            public partial class AllyBotSniperGameData
            {
                public PurplePrimaryWeapon PrimaryWeapon { get; set; }
                public long RevivesCount { get; set; }
                public long ReviveAmount { get; set; }
                public long ReviveSpeed { get; set; }
                public long HitMultHead { get; set; }
                public long HitMultBody { get; set; }
                public long HitMultLegs { get; set; }
                public long Health { get; set; }
                public MovementCfg MovementCfg { get; set; }
                public MultiplyClass Abilities { get; set; }
            }

            public partial class PurplePrimaryWeapon
            {
                public long? ItemType { get; set; }
                public long WeaponType { get; set; }
                public long? ItemPlantingType { get; set; }
                public bool Hitscan { get; set; }
                public bool IsClipfed { get; set; }
                public bool? HasOpticalSight { get; set; }
                public double? BoltCycleTime { get; set; }
                public bool? BurstShot { get; set; }
                public bool AutomaticFire { get; set; }
                public bool? SoundAutomaticFire { get; set; }
                public long BulletsPerShot { get; set; }
                public double RateOfFire { get; set; }
                public long ClipSize { get; set; }
                public long MaxClipCount { get; set; }
                public long Damage { get; set; }
                public double HeadshotMult { get; set; }
                public long BulletSpeed { get; set; }
                public long MaxDistanceForBullet { get; set; }
                public long? HitTargetsLimit { get; set; }
                public double SwitchInTime { get; set; }
                public double SwitchOutTime { get; set; }
                public double ReloadTime { get; set; }
                public double? ReloadCombinedTime { get; set; }
                public long SpeedModOnRun { get; set; }
                public long SpeedModOnCrouch { get; set; }
                public long SpeedModOnAds { get; set; }
                public long SpeedModOnSprint { get; set; }
                public LocalCheckDirection SpreadConeMin { get; set; }
                public LocalCheckDirection SpreadConeMax { get; set; }
                public Dictionary<string, DamageCurve> DamageCurve { get; set; }
                public double? ArmorPenetration { get; set; }
                public bool? IsManuallyCycled { get; set; }
                public bool? AmmoAmountForEntireMatch { get; set; }
                public long? DamageRadius { get; set; }
                public long? TimeToLife { get; set; }
                public bool? ProjectileRebound { get; set; }
                public LocalCheckDirection SpreadConeMovementAdd { get; set; }
                public LocalCheckDirection SpreadIncreasePerShot { get; set; }
                public LocalCheckDirection SpreadIncreaseOnMove { get; set; }
                public LocalCheckDirection SpreadRestoreSpeed { get; set; }
                public LocalCheckDirection SpreadRestoreDelay { get; set; }
                public LocalCheckDirection ShotKickUp { get; set; }
                public LocalCheckDirection ShotKickHorizontalMean { get; set; }
                public LocalCheckDirection ShotKickHorizontalDeviation { get; set; }
                public LocalCheckDirection ShotKickRestoreDelay { get; set; }
                public LocalCheckDirection ShotKickRestoreSpeed { get; set; }
                public long? Count { get; set; }
                public long? FovStandart { get; set; }
                public long? FovAim { get; set; }
                public long? FovSniper { get; set; }
                public long? FovChangePerShot { get; set; }
                public long? FovChangePerShotSniper { get; set; }
                public double? ReloadFullTime { get; set; }
                public long? ReloadDoubleTime { get; set; }
                public bool? UnlimitedClips { get; set; }
                public long? DamageRadiusTrajectory { get; set; }
                public double? DamageCoefOnUncovered { get; set; }
                public double? AimSensitivityModifier { get; set; }
                public long? AimGrenadeMidAngleOffset { get; set; }
                public bool? InfiniteAmmo { get; set; }
                public double? GravityCompensation { get; set; }
                public bool? BulletsCanBeDeactivated { get; set; }
                public long? WeaponExplosiveSubtype { get; set; }
                public SecondaryWeaponExplosionFxType? ExplosionFxType { get; set; }
                public Ksk2011SupportFxType? FxType { get; set; }
                public double? FxRadius { get; set; }
                public long? CombatEffectRadius { get; set; }
                public long? CombatEffectTeamRule { get; set; }
                public long? CombatEffectType { get; set; }
                public double? CombatEffectImpactPeriodPrimary { get; set; }
                public long? CombatEffectImpactValuePrimary { get; set; }
                public long? CombatEffectImpactPeriodSecondary { get; set; }
                public LocalCheckDirection CombatEffectTimes { get; set; }
                public LocalCheckDirection FirePrepareTime { get; set; }
                public bool? FirePrepareHold { get; set; }
                public bool? IsDamageCurveIgnored { get; set; }
                public long? RateOfBurst { get; set; }
                public long? BurstShotValue { get; set; }
            }

            public partial class AllyOnboardingBotAssault
            {
                public long TeamId { get; set; }
                public AllyBotAssaultClientCard ClientCard { get; set; }
                public AllyOnboardingBotAssaultGameData GameData { get; set; }
                public AllyBotAssaultBotCfg BotCfg { get; set; }
            }

            public partial class AllyOnboardingBotAssaultGameData
            {
                public FluffyAryWeapon PrimaryWeapon { get; set; }
                public long RevivesCount { get; set; }
                public long ReviveAmount { get; set; }
                public long ReviveSpeed { get; set; }
                public long HitMultHead { get; set; }
                public long HitMultBody { get; set; }
                public double HitMultLegs { get; set; }
                public long Health { get; set; }
                public long ArmorHealth { get; set; }
                public double ArmorResistance { get; set; }
                public MovementCfg MovementCfg { get; set; }
                public MultiplyClass Abilities { get; set; }
            }

            public partial class FluffyAryWeapon
            {
                public long ItemType { get; set; }
                public long WeaponType { get; set; }
                public bool Hitscan { get; set; }
                public bool IsClipfed { get; set; }
                public double BoltCycleTime { get; set; }
                public double ArmorPenetration { get; set; }
                public long SpeedModOnRun { get; set; }
                public long SpeedModOnCrouch { get; set; }
                public long SpeedModOnAds { get; set; }
                public long SpeedModOnSprint { get; set; }
                public long? BurstShotValue { get; set; }
                public bool AutomaticFire { get; set; }
                public bool SoundAutomaticFire { get; set; }
                public long BulletsPerShot { get; set; }
                public double RateOfFire { get; set; }
                public long? RateOfFireCold { get; set; }
                public long? RateOfFireWarmingTime { get; set; }
                public long? RateOfBurst { get; set; }
                public long ClipSize { get; set; }
                public long MaxClipCount { get; set; }
                public long Damage { get; set; }
                public double HeadshotMult { get; set; }
                public long? DestructibleMult { get; set; }
                public long BulletSpeed { get; set; }
                public long MaxDistanceForBullet { get; set; }
                public double? SwitchInTime { get; set; }
                public double? SwitchOutTime { get; set; }
                public double ReloadTime { get; set; }
                public double? ReloadCombinedTime { get; set; }
                public LocalCheckDirection SpreadConeMin { get; set; }
                public LocalCheckDirection SpreadConeMax { get; set; }
                public LocalCheckDirection SpreadConeMovementAdd { get; set; }
                public long? SpreadConeActionAdd { get; set; }
                public LocalCheckDirection SpreadIncreasePerShot { get; set; }
                public LocalCheckDirection SpreadIncreaseOnMove { get; set; }
                public LocalCheckDirection SpreadIncreaseOnRotate { get; set; }
                public long? SpreadIncreaseOnAction { get; set; }
                public LocalCheckDirection SpreadRestoreSpeed { get; set; }
                public LocalCheckDirection SpreadRestoreDelay { get; set; }
                public long? SpreadRandomMin { get; set; }
                public long? ShotFirstShotModifier { get; set; }
                public double? ShotFirstShotTimeOffset { get; set; }
                public LocalCheckDirection FirePrepareTime { get; set; }
                public Dictionary<string, DamageCurve> DamageCurve { get; set; }
                public long? ItemPlantingType { get; set; }
                public bool? HasOpticalSight { get; set; }
                public bool? UnlimitedClips { get; set; }
                public long? HitTargetsLimit { get; set; }
                public LocalCheckDirection ShotKickUp { get; set; }
                public LocalCheckDirection ShotKickHorizontalMean { get; set; }
                public LocalCheckDirection ShotKickHorizontalDeviation { get; set; }
                public LocalCheckDirection ShotKickRestoreDelay { get; set; }
                public LocalCheckDirection ShotKickRestoreSpeed { get; set; }
                public bool? IsManuallyCycled { get; set; }
                public bool? BurstShot { get; set; }
                public bool? AmmoAmountForEntireMatch { get; set; }
                public long? DamageRadius { get; set; }
                public long? DamageRadiusTrajectory { get; set; }
                public double? DamageCoefOnUncovered { get; set; }
                public long? TimeToLife { get; set; }
                public double? AimSensitivityModifier { get; set; }
                public long? AimGrenadeMidAngleOffset { get; set; }
                public double? GravityCompensation { get; set; }
                public bool? BulletsCanBeDeactivated { get; set; }
                public long? WeaponExplosiveSubtype { get; set; }
                public SecondaryWeaponExplosionFxType? ExplosionFxType { get; set; }
                public bool? ProjectileRebound { get; set; }
                public Ksk2011SupportFxType? FxType { get; set; }
                public double? FxRadius { get; set; }
                public double? BattleReadyAmmoClipFraction { get; set; }
                public double? LowAmmoClipFraction { get; set; }
                public bool? IsGuided { get; set; }
                public long? ProjectileReboundBehaviour { get; set; }
                public long? ScanTargetRadius { get; set; }
                public long? ScanBuffDuration { get; set; }
                public long? CombatEffectRadius { get; set; }
                public long? CombatEffectTeamRule { get; set; }
                public long? CombatEffectType { get; set; }
                public double? CombatEffectImpactPeriodPrimary { get; set; }
                public long? CombatEffectImpactValuePrimary { get; set; }
                public long? CombatEffectImpactPeriodSecondary { get; set; }
                public LocalCheckDirection CombatEffectTimes { get; set; }
                public bool? FirePrepareHold { get; set; }
                public bool? IsDamageCurveIgnored { get; set; }
            }

            public partial class Dummy
            {
                public long TeamId { get; set; }
                public AllyBotAssaultClientCard ClientCard { get; set; }
                public AllyBotInformerGameData GameData { get; set; }
                public AllyBotAssaultBotCfg BotCfg { get; set; }
            }

            public partial class ManekenEnemy0_Class
            {
                public long TeamId { get; set; }
                public AllyBotAssaultClientCard ClientCard { get; set; }
                public ManekenEnemy0_GameData GameData { get; set; }
                public ManekenEnemy0_BotCfg BotCfg { get; set; }
            }

            public partial class ManekenEnemy0_BotCfg
            {
                public Role Archetype { get; set; }
                public long RethinkTime { get; set; }
                public long RotationRateHorizontal { get; set; }
                public long RotationRateVertical { get; set; }
                public long StayInCoverTime { get; set; }
                public long OptimalCombatRange { get; set; }
                public long AttackFromCoverTime { get; set; }
                public long PathFindingVariationInterval { get; set; }
                public bool ShouldStopAtStopDistance { get; set; }
                public PurplePrimaryWeaponStrategy PrimaryWeaponStrategy { get; set; }
            }

            public partial class ManekenEnemy0_GameData
            {
                public FluffyPrimaryWeapon PrimaryWeapon { get; set; }
                public long RevivesCount { get; set; }
                public long ReviveAmount { get; set; }
                public long ReviveSpeed { get; set; }
                public long HitMultHead { get; set; }
                public long HitMultBody { get; set; }
                public double HitMultLegs { get; set; }
                public long Health { get; set; }
                public long ArmorHealth { get; set; }
                public double ArmorResistance { get; set; }
                public MovementCfg MovementCfg { get; set; }
                public PurpleResistsCfg ResistsCfg { get; set; }
                public long? ActionPointMax { get; set; }
                public PurpleAbilities Abilities { get; set; }
                public PurpleYWeapon HeavyWeapon { get; set; }
                public long? FatalityDelay { get; set; }
            }

            public partial class PurpleAbilities
            {
                public PurplePrimary Primary { get; set; }
            }

            public partial class PurplePrimary
            {
                public StickyType Type { get; set; }
                public PrimaryClientName ClientName { get; set; }
                public FxTypeEnum FxType { get; set; }
                public long FxRadius { get; set; }
                public long CastTime { get; set; }
                public double Cooldown { get; set; }
                public long Duration { get; set; }
                public long ActivationCost { get; set; }
                public bool ActivationOnRelease { get; set; }
                public List<IndigoGroup> Groups { get; set; }
                public ArystanSniperBuffAura BuffAura { get; set; }
                public List<PurpleBuffAuraGroup> BuffAuraGroups { get; set; }
            }

            public partial class PurpleBuffAuraGroup
            {
                public AuraBuffGroupTargetSelectionTime TargetSelectionTime { get; set; }
                public SelfSuccessGroupRule Rule { get; set; }
                public List<Buff55> Buffs { get; set; }
            }

            public partial class Buff55
            {
                public CreatorBuffsByAffectingAuraName Name { get; set; }
                public long Priority { get; set; }
                public List<FluffyCategory> Categories { get; set; }
                public long Duration { get; set; }
                public double? WpnSpreadConeMaxModPrimaryScale { get; set; }
                public double? WpnSpreadConeMinPrimaryScale { get; set; }
                public double? WpnSpreadConeMovementAddPrimaryScale { get; set; }
                public double? WpnRecoilMultPrimaryScale { get; set; }
                public long? WpnRecoilMultPrimary { get; set; }
                public bool Rebuff { get; set; }
                public PurpleIncomingDamageMod IncomingDamageMod { get; set; }
                public bool? StopBuffsWithAbility { get; set; }
                public double? WeaponsRecoilMultScale { get; set; }
                public long? WeaponsRecoilMult { get; set; }
            }

            public partial class IndigoGroup
            {
                public PurpleTargetSelectionTime TargetSelectionTime { get; set; }
                public DeactivatedEntitiesOwnersRuleElement Rule { get; set; }
                public List<Buff56> Buffs { get; set; }
            }

            public partial class Buff56
            {
                public CreatorBuffsByAffectingAuraName Name { get; set; }
                public long Priority { get; set; }
                public List<FluffyCategory> Categories { get; set; }
                public long Duration { get; set; }
                public bool? Aura { get; set; }
                public bool? Rebuff { get; set; }
                public bool? BotReactsToHardHit { get; set; }
                public PurpleIncomingDamageMod IncomingDamageMod { get; set; }
            }

            public partial class FluffyPrimaryWeapon
            {
                public long ItemType { get; set; }
                public long WeaponType { get; set; }
                public long ItemPlantingType { get; set; }
                public bool Hitscan { get; set; }
                public bool IsClipfed { get; set; }
                public bool IsManuallyCycled { get; set; }
                public double BoltCycleTime { get; set; }
                public bool BurstShot { get; set; }
                public bool AutomaticFire { get; set; }
                public bool SoundAutomaticFire { get; set; }
                public long BulletsPerShot { get; set; }
                public double RateOfFire { get; set; }
                public bool AmmoAmountForEntireMatch { get; set; }
                public long ClipSize { get; set; }
                public long MaxClipCount { get; set; }
                public long Damage { get; set; }
                public long DamageRadius { get; set; }
                public long DamageRadiusTrajectory { get; set; }
                public long DamageCoefOnUncovered { get; set; }
                public double HeadshotMult { get; set; }
                public double ArmorPenetration { get; set; }
                public long BulletSpeed { get; set; }
                public long MaxDistanceForBullet { get; set; }
                public long TimeToLife { get; set; }
                public long HitTargetsLimit { get; set; }
                public double AimSensitivityModifier { get; set; }
                public long AimGrenadeMidAngleOffset { get; set; }
                public double SwitchInTime { get; set; }
                public double SwitchOutTime { get; set; }
                public double ReloadTime { get; set; }
                public double ReloadCombinedTime { get; set; }
                public long SpeedModOnRun { get; set; }
                public long SpeedModOnCrouch { get; set; }
                public long SpeedModOnAds { get; set; }
                public long SpeedModOnSprint { get; set; }
                public LocalCheckDirection SpreadConeMin { get; set; }
                public LocalCheckDirection SpreadConeMax { get; set; }
                public LocalCheckDirection SpreadConeMovementAdd { get; set; }
                public LocalCheckDirection SpreadIncreasePerShot { get; set; }
                public LocalCheckDirection SpreadIncreaseOnMove { get; set; }
                public LocalCheckDirection SpreadRestoreSpeed { get; set; }
                public LocalCheckDirection SpreadRestoreDelay { get; set; }
                public LocalCheckDirection ShotKickUp { get; set; }
                public LocalCheckDirection ShotKickHorizontalMean { get; set; }
                public LocalCheckDirection ShotKickHorizontalDeviation { get; set; }
                public LocalCheckDirection ShotKickRestoreDelay { get; set; }
                public LocalCheckDirection ShotKickRestoreSpeed { get; set; }
                public Dictionary<string, DamageCurve> DamageCurve { get; set; }
            }

            public partial class ManekenEnemy1_Class
            {
                public long TeamId { get; set; }
                public AllyBotAssaultClientCard ClientCard { get; set; }
                public ManekenEnemy0_GameData GameData { get; set; }
                public AllyBotHostageBotCfg BotCfg { get; set; }
            }

            public partial class Onboarding
            {
                public long TeamId { get; set; }
                public AllyBotFsb2004AClientCard ClientCard { get; set; }
                public AllyBotAssaultGameData GameData { get; set; }
                public AllyBotFsb2004MBotCfg BotCfg { get; set; }
            }

            public partial class OnboardingOfficerMedic
            {
                public long TeamId { get; set; }
                public AllyBotAssaultClientCard ClientCard { get; set; }
                public OnboardingOfficerMedicGameData GameData { get; set; }
                public OnboardingOfficerMedicBotCfg BotCfg { get; set; }
            }

            public partial class OnboardingOfficerMedicBotCfg
            {
                public string Archetype { get; set; }
                public long InvestigationPriority { get; set; }
                public long OptimalCombatRange { get; set; }
                public double UrgeToActIncreaseOnAbilityActivation { get; set; }
                public bool CanSprint { get; set; }
                public bool FullStaminaOnSpawn { get; set; }
                public bool AbilityActivationRequiresEnemyKnowledge { get; set; }
                public bool? NeedFatality { get; set; }
                public long EnemyProximityRange { get; set; }
                public long StopDistance { get; set; }
                public long SprintMinAllowedDistToEnemy { get; set; }
                public long BattlePosMoveChanceToSprint { get; set; }
                public bool ShouldStopAtStopDistance { get; set; }
                public long DamageInCoverModifier { get; set; }
                public Tion PrimaryAbilityEmotion { get; set; }
                public bool AvoidSmokes { get; set; }
                public bool AvoidBullets { get; set; }
                public bool AvoidPoison { get; set; }
                public bool AvoidFire { get; set; }
                public bool AvoidDropItems { get; set; }
                public long AvoidDropItemsDelay { get; set; }
                public long? PvpveKillScore { get; set; }
                public double? UrgeToChangeToBetterPosition { get; set; }
                public long? FinalOptimalCombatRange { get; set; }
                public long? FinalOptimalCombatRangeReachSeconds { get; set; }
                public bool? SearchReachablePath { get; set; }
            }

            public partial class OnboardingOfficerMedicGameData
            {
                public PurpleYWeapon PrimaryWeapon { get; set; }
                public PurpleYWeapon HeavyWeapon { get; set; }
                public long ActionPointMax { get; set; }
                public long ActionPointMin { get; set; }
                public long ActionPointRegenRate { get; set; }
                public long RevivesCount { get; set; }
                public long ReviveAmount { get; set; }
                public long ReviveSpeed { get; set; }
                public long HitMultHead { get; set; }
                public long HitMultBody { get; set; }
                public double HitMultLegs { get; set; }
                public long Health { get; set; }
                public long ArmorHealth { get; set; }
                public MovementCfg MovementCfg { get; set; }
                public FluffyResistsCfg ResistsCfg { get; set; }
                public FluffyAbilities Abilities { get; set; }
            }

            public partial class FluffyAbilities
            {
                public FluffyPrimary Primary { get; set; }
            }

            public partial class FluffyPrimary
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public bool StopBuffsWithAbility { get; set; }
                public PrimaryWeaponFxType FxType { get; set; }
                public long FxRadius { get; set; }
                public long CastTime { get; set; }
                public long Cooldown { get; set; }
                public long Duration { get; set; }
                public long ActivationCost { get; set; }
                public bool ActivationOnRelease { get; set; }
                public List<IndecentGroup> Groups { get; set; }
                public ArystanSniperBuffAura BuffAura { get; set; }
                public List<FluffyBuffAuraGroup> BuffAuraGroups { get; set; }
            }

            public partial class FluffyBuffAuraGroup
            {
                public bool? StopBuffsWithAbility { get; set; }
                public AuraBuffGroupTargetSelectionTime TargetSelectionTime { get; set; }
                public SelfSuccessGroupRule Rule { get; set; }
                public List<Buff57> Buffs { get; set; }
            }

            public partial class Buff57
            {
                public PurpleName Name { get; set; }
                public long Priority { get; set; }
                public List<PurpleCategory> Categories { get; set; }
                public double Duration { get; set; }
                public double? Period { get; set; }
                public long? HealthAdd { get; set; }
                public bool Rebuff { get; set; }
                public double? WpnRateOfFireModPrimary { get; set; }
                public double? SpeedScale { get; set; }
            }

            public partial class IndecentGroup
            {
                public PurpleTargetSelectionTime TargetSelectionTime { get; set; }
                public DeactivatedEntitiesOwnersRuleElement Rule { get; set; }
                public List<Buff58> Buffs { get; set; }
            }

            public partial class Buff58
            {
                public NameEnum Name { get; set; }
                public long Priority { get; set; }
                public List<BuffImmuneAddElement> Categories { get; set; }
                public long Duration { get; set; }
                public bool Aura { get; set; }
            }

            public partial class FluffyResistsCfg
            {
                public double JumpDamageMult { get; set; }
            }

            public partial class OnboardingSniper
            {
                public long TeamId { get; set; }
                public AllyBotFsb2004AClientCard ClientCard { get; set; }
                public OnboardingSniperGameData GameData { get; set; }
                public OnboardingSniperBotCfg BotCfg { get; set; }
            }

            public partial class OnboardingSniperBotCfg
            {
                public Role Archetype { get; set; }
                public bool DisplayAsHumanPlayer { get; set; }
                public double RethinkTime { get; set; }
                public long RotationRateHorizontal { get; set; }
                public long RotationRateVertical { get; set; }
                public long StayInCoverTime { get; set; }
                public long OptimalCombatRange { get; set; }
                public bool CanSprint { get; set; }
                public bool ReactsToHardHit { get; set; }
                public long HearingRadius { get; set; }
                public long StopDistance { get; set; }
                public double FiringTimeOnTargetLoss { get; set; }
                public long CommunicationRadius { get; set; }
                public YWeaponStrategy PrimaryWeaponStrategy { get; set; }
                public AryWeaponStrategy SecondaryWeaponStrategy { get; set; }
                public CustomAbility CustomAbility { get; set; }
            }

            public partial class CustomAbility
            {
                public string Name { get; set; }
                public MultiplyClass Parameters { get; set; }
            }

            public partial class AryWeaponStrategy
            {
                public bool? SingleFire { get; set; }
                public double FireTime { get; set; }
                public double FirePauseTime { get; set; }
                public long? NonlethalFireDuration { get; set; }
                public double? LockOnTime { get; set; }
            }

            public partial class OnboardingSniperGameData
            {
                public TentacledPrimaryWeapon PrimaryWeapon { get; set; }
                public long RevivesCount { get; set; }
                public long ReviveAmount { get; set; }
                public long ReviveSpeed { get; set; }
                public long? ActionPointMax { get; set; }
                public long HitMultHead { get; set; }
                public long HitMultBody { get; set; }
                public double HitMultLegs { get; set; }
                public long Health { get; set; }
                public long ArmorHealth { get; set; }
                public long ArmorResistance { get; set; }
                public MovementCfg MovementCfg { get; set; }
                public TentacledAbilities Abilities { get; set; }
                public SecondaryWeapon SecondaryWeapon { get; set; }
                public FluffyResistsCfg ResistsCfg { get; set; }
            }

            public partial class TentacledAbilities
            {
                public TentacledPrimary Primary { get; set; }
            }

            public partial class TentacledPrimary
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public long Cooldown { get; set; }
                public long Duration { get; set; }
                public long ActivationCost { get; set; }
                public bool ActivationOnRelease { get; set; }
                public List<AmfSupportBuffAuraGroup> Groups { get; set; }
            }

            public partial class TentacledPrimaryWeapon
            {
                public long ItemType { get; set; }
                public long WeaponType { get; set; }
                public long ItemPlantingType { get; set; }
                public bool Hitscan { get; set; }
                public bool IsClipfed { get; set; }
                public bool HasOpticalSight { get; set; }
                public double BoltCycleTime { get; set; }
                public bool BurstShot { get; set; }
                public bool AutomaticFire { get; set; }
                public bool SoundAutomaticFire { get; set; }
                public long BulletsPerShot { get; set; }
                public double RateOfFire { get; set; }
                public long ClipSize { get; set; }
                public long MaxClipCount { get; set; }
                public long Damage { get; set; }
                public double HeadshotMult { get; set; }
                public double ArmorPenetration { get; set; }
                public long BulletSpeed { get; set; }
                public long MaxDistanceForBullet { get; set; }
                public long HitTargetsLimit { get; set; }
                public double SwitchInTime { get; set; }
                public double SwitchOutTime { get; set; }
                public double ReloadTime { get; set; }
                public long ReloadCombinedTime { get; set; }
                public long SpeedModOnRun { get; set; }
                public long SpeedModOnCrouch { get; set; }
                public long SpeedModOnAds { get; set; }
                public long SpeedModOnSprint { get; set; }
                public LocalCheckDirection SpreadConeMin { get; set; }
                public LocalCheckDirection SpreadConeMax { get; set; }
                public Dictionary<string, DamageCurve> DamageCurve { get; set; }
            }

            public partial class SecondaryWeapon
            {
                public long ItemType { get; set; }
                public long WeaponType { get; set; }
                public bool Hitscan { get; set; }
                public bool IsClipfed { get; set; }
                public double BoltCycleTime { get; set; }
                public double ArmorPenetration { get; set; }
                public long SpeedModOnRun { get; set; }
                public long SpeedModOnCrouch { get; set; }
                public long SpeedModOnAds { get; set; }
                public long SpeedModOnSprint { get; set; }
                public long BurstShotValue { get; set; }
                public bool AutomaticFire { get; set; }
                public bool SoundAutomaticFire { get; set; }
                public long BulletsPerShot { get; set; }
                public long RateOfFire { get; set; }
                public long RateOfBurst { get; set; }
                public long ClipSize { get; set; }
                public long MaxClipCount { get; set; }
                public long Damage { get; set; }
                public double HeadshotMult { get; set; }
                public long DestructibleMult { get; set; }
                public long BulletSpeed { get; set; }
                public long MaxDistanceForBullet { get; set; }
                public double SwitchInTime { get; set; }
                public double SwitchOutTime { get; set; }
                public double ReloadTime { get; set; }
                public double ReloadCombinedTime { get; set; }
                public LocalCheckDirection SpreadConeMin { get; set; }
                public LocalCheckDirection SpreadConeMax { get; set; }
                public LocalCheckDirection SpreadConeMovementAdd { get; set; }
                public long SpreadConeActionAdd { get; set; }
                public LocalCheckDirection SpreadIncreasePerShot { get; set; }
                public LocalCheckDirection SpreadIncreaseOnMove { get; set; }
                public LocalCheckDirection SpreadIncreaseOnRotate { get; set; }
                public long SpreadIncreaseOnAction { get; set; }
                public LocalCheckDirection SpreadRestoreSpeed { get; set; }
                public LocalCheckDirection SpreadRestoreDelay { get; set; }
                public long SpreadRandomMin { get; set; }
                public long ShotFirstShotModifier { get; set; }
                public double ShotFirstShotTimeOffset { get; set; }
                public LocalCheckDirection FirePrepareTime { get; set; }
                public Dictionary<string, DamageCurve> DamageCurve { get; set; }
            }

            public partial class TaurusAssaultHologramClass
            {
                public long TeamId { get; set; }
                public AllyBotAssaultClientCard ClientCard { get; set; }
                public TaurusAssaultHologramGameData GameData { get; set; }
                public TaurusAssaultHologramBotCfg BotCfg { get; set; }
            }

            public partial class TaurusAssaultHologramBotCfg
            {
                public Role Archetype { get; set; }
                public double RethinkTime { get; set; }
                public long RotationRateHorizontal { get; set; }
                public long RotationRateVertical { get; set; }
                public double StayInCoverTime { get; set; }
                public long OptimalCombatRange { get; set; }
                public double AttackFromCoverTime { get; set; }
                public long? NonlethalFireDuration { get; set; }
                public double GrenadeTargetingTime { get; set; }
                public double UrgeToChangeToBetterPosition { get; set; }
                public long FinalOptimalCombatRange { get; set; }
                public long FinalOptimalCombatRangeReachSeconds { get; set; }
                public bool CanSprint { get; set; }
                public bool AvoidBullets { get; set; }
                public bool AvoidPoison { get; set; }
                public bool AvoidFire { get; set; }
                public long? StopDistance { get; set; }
                public bool? ShouldStopAtStopDistance { get; set; }
                public TentacledPrimaryWeaponStrategy PrimaryWeaponStrategy { get; set; }
                public long? HearingRadius { get; set; }
                public long? PvpveKillScore { get; set; }
                public double? GrenadeHappiness { get; set; }
                public bool? AvoidSmokes { get; set; }
                public bool? SearchReachablePath { get; set; }
                public long? InvestigationPriority { get; set; }
            }

            public partial class TentacledPrimaryWeaponStrategy
            {
                public double LockOnTime { get; set; }
                public double FireTime { get; set; }
                public double FirePauseTime { get; set; }
            }

            public partial class TaurusAssaultHologramGameData
            {
                public StickyPrimaryWeapon PrimaryWeapon { get; set; }
                public FluffyYWeapon HeavyWeapon { get; set; }
                public long RevivesCount { get; set; }
                public long ReviveAmount { get; set; }
                public long ReviveSpeed { get; set; }
                public long HitMultHead { get; set; }
                public long HitMultBody { get; set; }
                public double HitMultLegs { get; set; }
                public long Health { get; set; }
                public long ArmorHealth { get; set; }
                public long ArmorResistance { get; set; }
                public MovementCfg MovementCfg { get; set; }
                public FluffyResistsCfg ResistsCfg { get; set; }
                public long? ActionPointMax { get; set; }
            }

            public partial class FluffyYWeapon
            {
                public long ItemType { get; set; }
                public long WeaponType { get; set; }
                public long WeaponStrategy { get; set; }
                public long WeaponExplosiveSubtype { get; set; }
                public bool Hitscan { get; set; }
                public double? GravityCompensation { get; set; }
                public bool IsClipfed { get; set; }
                public bool IsManuallyCycled { get; set; }
                public bool HasOpticalSight { get; set; }
                public double BoltCycleTime { get; set; }
                public bool IsManuallyActivatable { get; set; }
                public bool? BulletsCanBeDeactivated { get; set; }
                public double ArmorPenetration { get; set; }
                public bool HasBipod { get; set; }
                public bool IsGuided { get; set; }
                public long GuidanceActivationTime { get; set; }
                public long GuidanceSensivity { get; set; }
                public long SpeedModOnRun { get; set; }
                public long SpeedModOnCrouch { get; set; }
                public double SpeedModOnAds { get; set; }
                public long SpeedModOnSprint { get; set; }
                public long BurstShotValue { get; set; }
                public bool AutomaticFire { get; set; }
                public bool? SoundAutomaticFire { get; set; }
                public long BulletsPerShot { get; set; }
                public double RateOfFire { get; set; }
                public long RateOfBurst { get; set; }
                public bool AmmoAmountForEntireMatch { get; set; }
                public long ClipSize { get; set; }
                public long MaxClipCount { get; set; }
                public long Damage { get; set; }
                public long DamageRadius { get; set; }
                public long DamageRadiusTrajectory { get; set; }
                public long DamageCoefOnUncovered { get; set; }
                public double HeadshotMult { get; set; }
                public long DestructibleMult { get; set; }
                public long BulletSpeed { get; set; }
                public long MaxDistanceForBullet { get; set; }
                public double TimeToLife { get; set; }
                public long ProjectileReboundBehaviour { get; set; }
                public long? HitTargetsLimit { get; set; }
                public long? RicochetsLimit { get; set; }
                public long FovStandart { get; set; }
                public long FovAim { get; set; }
                public long FovSniper { get; set; }
                public double AimSensitivityModifier { get; set; }
                public long AimGrenadeMidAngleOffset { get; set; }
                public double SwitchInTime { get; set; }
                public double SwitchOutTime { get; set; }
                public double ReloadTime { get; set; }
                public double ReloadCombinedTime { get; set; }
                public LocalCheckDirection SpreadConeMin { get; set; }
                public LocalCheckDirection SpreadConeMax { get; set; }
                public LocalCheckDirection SpreadConeMovementAdd { get; set; }
                public long? SpreadConeActionAdd { get; set; }
                public LocalCheckDirection SpreadIncreasePerShot { get; set; }
                public LocalCheckDirection SpreadIncreaseOnMove { get; set; }
                public LocalCheckDirection SpreadIncreaseOnRotate { get; set; }
                public long? SpreadIncreaseOnAction { get; set; }
                public LocalCheckDirection SpreadRestoreSpeed { get; set; }
                public LocalCheckDirection SpreadRestoreDelay { get; set; }
                public Dictionary<string, DamageCurve> DamageCurve { get; set; }
                public List<Raid2017AssaultHeavyPassive> PassiveAbilities { get; set; }
                public PrimaryWeaponFxType? FxType { get; set; }
                public long? FxRadius { get; set; }
                public ExplosionFxTypeEnum? ExplosionFxType { get; set; }
                public bool? IsAffectedByGravity { get; set; }
                public long? HumanPerforationLimit { get; set; }
                public long? SpreadRandomMin { get; set; }
                public long? ShotFirstShotModifier { get; set; }
                public double? ShotFirstShotTimeOffset { get; set; }
                public long? ShotFovChangeLimit { get; set; }
                public LocalCheckDirection ShotKickUp { get; set; }
                public LocalCheckDirection ShotKickHorizontalMean { get; set; }
                public LocalCheckDirection ShotKickHorizontalDeviation { get; set; }
                public LocalCheckDirection ShotKickRestoreSpeed { get; set; }
                public LocalCheckDirection ShotFovChange { get; set; }
                public long? AirstrikeMaxDistance { get; set; }
                public long? WeaponConsumableType { get; set; }
                public long? QuitAimOnChamberEmptyDelay { get; set; }
                public long? HeatMin { get; set; }
                public long? RateOfFireCold { get; set; }
                public long? RateOfFireWarmingTime { get; set; }
                public long? HitBehaviourLimit { get; set; }
                public long? ScanTargetRadius { get; set; }
                public long? ScanBuffDuration { get; set; }
                public LocalCheckDirection ShotKickRestoreDelay { get; set; }
            }

            public partial class StickyPrimaryWeapon
            {
                public long ItemType { get; set; }
                public long WeaponType { get; set; }
                public long ItemPlantingType { get; set; }
                public bool Hitscan { get; set; }
                public bool IsClipfed { get; set; }
                public bool IsManuallyCycled { get; set; }
                public bool HasOpticalSight { get; set; }
                public double BoltCycleTime { get; set; }
                public bool BurstShot { get; set; }
                public bool AutomaticFire { get; set; }
                public bool SoundAutomaticFire { get; set; }
                public long BulletsPerShot { get; set; }
                public double RateOfFire { get; set; }
                public bool AmmoAmountForEntireMatch { get; set; }
                public long ClipSize { get; set; }
                public long MaxClipCount { get; set; }
                public long Damage { get; set; }
                public long DamageRadius { get; set; }
                public double HeadshotMult { get; set; }
                public double ArmorPenetration { get; set; }
                public long BulletSpeed { get; set; }
                public long MaxDistanceForBullet { get; set; }
                public long TimeToLife { get; set; }
                public bool ProjectileRebound { get; set; }
                public long HitTargetsLimit { get; set; }
                public double SwitchInTime { get; set; }
                public double SwitchOutTime { get; set; }
                public double ReloadTime { get; set; }
                public long SpeedModOnRun { get; set; }
                public long SpeedModOnCrouch { get; set; }
                public long SpeedModOnAds { get; set; }
                public long SpeedModOnSprint { get; set; }
                public LocalCheckDirection SpreadConeMin { get; set; }
                public LocalCheckDirection SpreadConeMax { get; set; }
                public LocalCheckDirection SpreadConeMovementAdd { get; set; }
                public LocalCheckDirection SpreadIncreasePerShot { get; set; }
                public LocalCheckDirection SpreadIncreaseOnMove { get; set; }
                public LocalCheckDirection SpreadRestoreSpeed { get; set; }
                public LocalCheckDirection SpreadRestoreDelay { get; set; }
                public LocalCheckDirection ShotKickUp { get; set; }
                public LocalCheckDirection ShotKickHorizontalMean { get; set; }
                public LocalCheckDirection ShotKickHorizontalDeviation { get; set; }
                public LocalCheckDirection ShotKickRestoreDelay { get; set; }
                public LocalCheckDirection ShotKickRestoreSpeed { get; set; }
                public Dictionary<string, DamageCurve> DamageCurve { get; set; }
            }

            public partial class TaurusAssaultOnslaught0_Class
            {
                public long TeamId { get; set; }
                public AllyBotAssaultClientCard ClientCard { get; set; }
                public TaurusAssaultHologramGameData GameData { get; set; }
                public TaurusAssaultEmpowered0_BotCfg BotCfg { get; set; }
            }

            public partial class TaurusAssaultEmpowered0_BotCfg
            {
                public string Archetype { get; set; }
                public double RethinkTime { get; set; }
                public long RotationRateHorizontal { get; set; }
                public long RotationRateVertical { get; set; }
                public double StayInCoverTime { get; set; }
                public long OptimalCombatRange { get; set; }
                public double? AttackFromCoverTime { get; set; }
                public bool CanSprint { get; set; }
                public bool? AvoidPoison { get; set; }
                public bool AvoidFire { get; set; }
                public bool AvoidBullets { get; set; }
                public double? UrgeToChangeToBetterPosition { get; set; }
                public long? FinalOptimalCombatRange { get; set; }
                public long? FinalOptimalCombatRangeReachSeconds { get; set; }
                public double? StopDistance { get; set; }
                public bool? ShouldStopAtStopDistance { get; set; }
                public double? GrenadeTargetingTime { get; set; }
                public FluffyPrimaryWeaponStrategy PrimaryWeaponStrategy { get; set; }
                public bool? SearchReachablePath { get; set; }
                public long? PvpveKillScore { get; set; }
                public bool? AvoidSmoke { get; set; }
                public YWeaponStrategy SecondaryWeaponStrategy { get; set; }
                public List<TypeElement> IgnoredDropItemTypes { get; set; }
                public long? InvestigationPriority { get; set; }
                public bool? AvoidSmokes { get; set; }
                public long? EnemyProximityRange { get; set; }
                public bool? IgnoreBlockNavigationUntilFirstCoverReached { get; set; }
                public double? GrenadeHappiness { get; set; }
                public double? BattleReadyAmmoClipFraction { get; set; }
                public bool? NeedFatality { get; set; }
                public bool? FullStaminaOnSpawn { get; set; }
                public bool? AbilityActivationRequiresEnemyKnowledge { get; set; }
                public Tion? PrimaryAbilityEmotion { get; set; }
                public bool? ReactsToHardHit { get; set; }
                public double? LookForTargetTime { get; set; }
                public long? BattlePosMoveChanceToSprint { get; set; }
                public long? SprintMinAllowedDistToEnemy { get; set; }
                public long? SprintMinAllowedDistToPathEnd { get; set; }
            }

            public partial class FluffyPrimaryWeaponStrategy
            {
                public double LockOnTime { get; set; }
                public long NonlethalFireDuration { get; set; }
                public double FireTime { get; set; }
                public double FirePauseTime { get; set; }
            }

            public partial class TaurusAssaultEmpowered0
            {
                public long TeamId { get; set; }
                public AllyBotAssaultClientCard ClientCard { get; set; }
                public TaurusAssaultEmpowered0_GameData GameData { get; set; }
                public TaurusAssaultEmpowered0_BotCfg BotCfg { get; set; }
            }

            public partial class TaurusAssaultEmpowered0_GameData
            {
                public PurplePrimaryWeapon PrimaryWeapon { get; set; }
                public FluffyYWeapon HeavyWeapon { get; set; }
                public long RevivesCount { get; set; }
                public long ReviveAmount { get; set; }
                public long ReviveSpeed { get; set; }
                public long HitMultHead { get; set; }
                public long HitMultBody { get; set; }
                public double HitMultLegs { get; set; }
                public long Health { get; set; }
                public long ActionPointMax { get; set; }
                public long ArmorHealth { get; set; }
                public long ArmorResistance { get; set; }
                public MovementCfg MovementCfg { get; set; }
                public FluffyResistsCfg ResistsCfg { get; set; }
            }

            public partial class TaurusAssaultPvPvE
            {
                public long TeamId { get; set; }
                public AllyBotAssaultClientCard ClientCard { get; set; }
                public TaurusAssaultPvPvEGameData GameData { get; set; }
                public TaurusAssaultHologramBotCfg BotCfg { get; set; }
            }

            public partial class TaurusAssaultPvPvEGameData
            {
                public PurpleAryWeapon PrimaryWeapon { get; set; }
                public FluffyYWeapon HeavyWeapon { get; set; }
                public long RevivesCount { get; set; }
                public long ReviveAmount { get; set; }
                public long ReviveSpeed { get; set; }
                public long HitMultHead { get; set; }
                public long HitMultBody { get; set; }
                public double HitMultLegs { get; set; }
                public long Health { get; set; }
                public long ArmorHealth { get; set; }
                public long ArmorResistance { get; set; }
                public MovementCfg MovementCfg { get; set; }
                public FluffyResistsCfg ResistsCfg { get; set; }
            }

            public partial class TaurusAssaultWeak0
            {
                public long TeamId { get; set; }
                public AllyBotAssaultClientCard ClientCard { get; set; }
                public TaurusAssaultHologramGameData GameData { get; set; }
                public TaurusAssaultWeak0_BotCfg BotCfg { get; set; }
            }

            public partial class TaurusAssaultWeak0_BotCfg
            {
                public Role Archetype { get; set; }
                public long RethinkTime { get; set; }
                public long RotationRateHorizontal { get; set; }
                public long RotationRateVertical { get; set; }
                public double StayInCoverTime { get; set; }
                public long OptimalCombatRange { get; set; }
                public long AttackFromCoverTime { get; set; }
                public bool CanSprint { get; set; }
                public bool AvoidPoison { get; set; }
                public bool AvoidFire { get; set; }
                public bool AvoidBullets { get; set; }
                public double GrenadeTargetingTime { get; set; }
                public YWeaponStrategy PrimaryWeaponStrategy { get; set; }
            }

            public partial class TaurusChemistEmpowered0
            {
                public long TeamId { get; set; }
                public AllyBotAssaultClientCard ClientCard { get; set; }
                public TaurusChemistEmpowered0_GameData GameData { get; set; }
                public TaurusChemistEmpowered0_BotCfg BotCfg { get; set; }
            }

            public partial class TaurusChemistEmpowered0_BotCfg
            {
                public Role Archetype { get; set; }
                public double RethinkTime { get; set; }
                public long RotationRateHorizontal { get; set; }
                public long RotationRateVertical { get; set; }
                public long StayInCoverTime { get; set; }
                public long OptimalCombatRange { get; set; }
                public long StopDistance { get; set; }
                public bool CanSprint { get; set; }
                public bool AvoidBullets { get; set; }
                public bool AvoidSmoke { get; set; }
                public bool AvoidFire { get; set; }
                public YWeaponStrategy PrimaryWeaponStrategy { get; set; }
                public YWeaponStrategy SecondaryWeaponStrategy { get; set; }
                public List<TypeElement> IgnoredDropItemTypes { get; set; }
            }

            public partial class TaurusChemistEmpowered0_GameData
            {
                public IndigoPrimaryWeapon PrimaryWeapon { get; set; }
                public SecondaryWeapon SecondaryWeapon { get; set; }
                public long RevivesCount { get; set; }
                public long ReviveAmount { get; set; }
                public long ReviveSpeed { get; set; }
                public long HitMultHead { get; set; }
                public long HitMultBody { get; set; }
                public double HitMultLegs { get; set; }
                public long Health { get; set; }
                public long ArmorHealth { get; set; }
                public double ArmorResistance { get; set; }
                public MovementCfg MovementCfg { get; set; }
                public PurpleResistsCfg ResistsCfg { get; set; }
            }

            public partial class IndigoPrimaryWeapon
            {
                public long ItemType { get; set; }
                public long WeaponType { get; set; }
                public long WeaponExplosiveSubtype { get; set; }
                public long ItemPlantingType { get; set; }
                public bool Hitscan { get; set; }
                public bool IsClipfed { get; set; }
                public bool IsManuallyCycled { get; set; }
                public bool BulletsCanBeDeactivated { get; set; }
                public double BoltCycleTime { get; set; }
                public double ArmorPenetration { get; set; }
                public double BattleReadyAmmoClipFraction { get; set; }
                public double LowAmmoClipFraction { get; set; }
                public bool IsGuided { get; set; }
                public long BurstShotValue { get; set; }
                public bool AutomaticFire { get; set; }
                public bool SoundAutomaticFire { get; set; }
                public long BulletsPerShot { get; set; }
                public long RateOfFire { get; set; }
                public long RateOfBurst { get; set; }
                public bool AmmoAmountForEntireMatch { get; set; }
                public long ClipSize { get; set; }
                public long MaxClipCount { get; set; }
                public double Damage { get; set; }
                public long DamageRadius { get; set; }
                public long DamageRadiusTrajectory { get; set; }
                public long DamageCoefOnUncovered { get; set; }
                public long HeadshotMult { get; set; }
                public long DestructibleMult { get; set; }
                public long BulletSpeed { get; set; }
                public long MaxDistanceForBullet { get; set; }
                public long TimeToLife { get; set; }
                public long ProjectileReboundBehaviour { get; set; }
                public long GravityCompensation { get; set; }
                public long ScanTargetRadius { get; set; }
                public long ScanBuffDuration { get; set; }
                public double AimSensitivityModifier { get; set; }
                public long AimGrenadeMidAngleOffset { get; set; }
                public double SwitchInTime { get; set; }
                public double SwitchOutTime { get; set; }
                public long ReloadTime { get; set; }
                public double ReloadCombinedTime { get; set; }
                public LocalCheckDirection SpreadConeMin { get; set; }
                public LocalCheckDirection SpreadConeMax { get; set; }
                public LocalCheckDirection SpreadConeMovementAdd { get; set; }
                public long SpreadConeActionAdd { get; set; }
                public LocalCheckDirection SpreadIncreasePerShot { get; set; }
                public LocalCheckDirection SpreadIncreaseOnMove { get; set; }
                public LocalCheckDirection SpreadIncreaseOnRotate { get; set; }
                public long SpreadIncreaseOnAction { get; set; }
                public LocalCheckDirection SpreadRestoreSpeed { get; set; }
                public LocalCheckDirection SpreadRestoreDelay { get; set; }
                public long SpreadRandomMin { get; set; }
                public long ShotFirstShotModifier { get; set; }
                public long ShotFirstShotTimeOffset { get; set; }
                public long ShotFovChangeLimit { get; set; }
                public double ShotRollAmplitude { get; set; }
                public long ShotRollFrequency { get; set; }
                public double ShotRollTime { get; set; }
                public double ShotRollThirdPersonMultiplier { get; set; }
                public long MaxDropItemsOnScene { get; set; }
                public long DropItemType { get; set; }
                public long AuraRadius { get; set; }
                public long AuraTeamRule { get; set; }
                public bool AuraCollision { get; set; }
                public long AuraUpdPeriod { get; set; }
                public long AuraHealthRadius { get; set; }
                public long AuraActivationDelay { get; set; }
                public long CombatEffectRadius { get; set; }
                public long CombatEffectTeamRule { get; set; }
                public long CombatEffectType { get; set; }
                public long CombatEffectImpactPeriodPrimary { get; set; }
                public long CombatEffectImpactValuePrimary { get; set; }
                public LocalCheckDirection CombatEffectTimes { get; set; }
                public LocalCheckDirection FirePrepareTime { get; set; }
                public bool FirePrepareHold { get; set; }
                public long DeploymentType { get; set; }
                public long DeploymentDuration { get; set; }
                public long DeploymentCooldown { get; set; }
                public bool IsDamageCurveIgnored { get; set; }
                public Dictionary<string, DamageCurve> DamageCurve { get; set; }
                public List<object> PassiveAbilities { get; set; }
                public long AirstrikeMaxDistance { get; set; }
                public PrimaryWeaponFxType FxType { get; set; }
                public double FxRadius { get; set; }
                public SoundFxEnum ExplosionFxType { get; set; }
            }

            public partial class TaurusChemistOnslaught2
            {
                public long TeamId { get; set; }
                public AllyBotAssaultClientCard ClientCard { get; set; }
                public TaurusChemistEmpowered0_GameData GameData { get; set; }
                public TaurusChemistOnslaught2_BotCfg BotCfg { get; set; }
            }

            public partial class TaurusChemistOnslaught2_BotCfg
            {
                public Role Archetype { get; set; }
                public double RethinkTime { get; set; }
                public long RotationRateHorizontal { get; set; }
                public long RotationRateVertical { get; set; }
                public double StayInCoverTime { get; set; }
                public long? OptimalCombatRange { get; set; }
                public long StopDistance { get; set; }
                public bool CanSprint { get; set; }
                public bool AvoidBullets { get; set; }
                public bool? AvoidSmoke { get; set; }
                public bool AvoidFire { get; set; }
                public FluffyPrimaryWeaponStrategy PrimaryWeaponStrategy { get; set; }
                public SecondaryWeaponStrategy SecondaryWeaponStrategy { get; set; }
                public List<TypeElement> IgnoredDropItemTypes { get; set; }
                public double? UrgeToChangeToBetterPosition { get; set; }
                public long? FinalOptimalCombatRange { get; set; }
                public long? FinalOptimalCombatRangeReachSeconds { get; set; }
                public bool? SearchReachablePath { get; set; }
                public long? InvestigationPriority { get; set; }
                public long? PvpveKillScore { get; set; }
                public bool? AvoidSmokes { get; set; }
                public bool? AvoidPoison { get; set; }
                public double? AttackFromCoverTime { get; set; }
                public bool? ShouldStopAtStopDistance { get; set; }
                public double? BattleReadyAmmoClipFraction { get; set; }
                public double? GrenadeTargetingTime { get; set; }
                public long? HearingRadius { get; set; }
            }

            public partial class SecondaryWeaponStrategy
            {
                public bool SingleFire { get; set; }
                public long NonlethalFireDuration { get; set; }
                public double FireTime { get; set; }
                public double FirePauseTime { get; set; }
            }

            public partial class TaurusChemistOnslaught0
            {
                public long TeamId { get; set; }
                public AllyBotAssaultClientCard ClientCard { get; set; }
                public TaurusChemistEmpowered0_GameData GameData { get; set; }
                public TaurusChemistOnslaught0_BotCfg BotCfg { get; set; }
            }

            public partial class TaurusChemistOnslaught0_BotCfg
            {
                public Role Archetype { get; set; }
                public double RethinkTime { get; set; }
                public long RotationRateHorizontal { get; set; }
                public long RotationRateVertical { get; set; }
                public long StayInCoverTime { get; set; }
                public long StopDistance { get; set; }
                public long OptimalCombatRange { get; set; }
                public bool CanSprint { get; set; }
                public bool AvoidBullets { get; set; }
                public bool AvoidSmoke { get; set; }
                public bool AvoidFire { get; set; }
                public double UrgeToChangeToBetterPosition { get; set; }
                public long FinalOptimalCombatRange { get; set; }
                public long FinalOptimalCombatRangeReachSeconds { get; set; }
                public bool SearchReachablePath { get; set; }
                public YWeaponStrategy PrimaryWeaponStrategy { get; set; }
                public SecondaryWeaponStrategy SecondaryWeaponStrategy { get; set; }
                public List<TypeElement> IgnoredDropItemTypes { get; set; }
            }

            public partial class Elimination
            {
                public long TeamId { get; set; }
                public AllyBotAssaultClientCard ClientCard { get; set; }
                public TaurusChemistEmpowered0_GameData GameData { get; set; }
                public TaurusChemistOnslaught0_EliminationBotCfg BotCfg { get; set; }
            }

            public partial class TaurusChemistOnslaught0_EliminationBotCfg
            {
                public Role Archetype { get; set; }
                public double RethinkTime { get; set; }
                public long RotationRateHorizontal { get; set; }
                public long RotationRateVertical { get; set; }
                public long StayInCoverTime { get; set; }
                public long StopDistance { get; set; }
                public long OptimalCombatRange { get; set; }
                public bool CanSprint { get; set; }
                public bool AvoidBullets { get; set; }
                public bool AvoidSmoke { get; set; }
                public bool AvoidFire { get; set; }
                public double UrgeToChangeToBetterPosition { get; set; }
                public long FinalOptimalCombatRange { get; set; }
                public long FinalOptimalCombatRangeReachSeconds { get; set; }
                public long InvestigationPriority { get; set; }
                public bool SearchReachablePath { get; set; }
                public YWeaponStrategy PrimaryWeaponStrategy { get; set; }
                public SecondaryWeaponStrategy SecondaryWeaponStrategy { get; set; }
                public List<TypeElement> IgnoredDropItemTypes { get; set; }
            }

            public partial class TaurusChemistWeak0
            {
                public long TeamId { get; set; }
                public AllyBotAssaultClientCard ClientCard { get; set; }
                public TaurusChemistWeak0_GameData GameData { get; set; }
                public TaurusChemistWeak0_BotCfg BotCfg { get; set; }
            }

            public partial class TaurusChemistWeak0_BotCfg
            {
                public Role Archetype { get; set; }
                public long RethinkTime { get; set; }
                public long RotationRateHorizontal { get; set; }
                public long RotationRateVertical { get; set; }
                public double StayInCoverTime { get; set; }
                public long OptimalCombatRange { get; set; }
                public long StopDistance { get; set; }
                public bool CanSprint { get; set; }
                public bool AvoidBullets { get; set; }
                public bool? AvoidSmoke { get; set; }
                public bool AvoidFire { get; set; }
                public AryWeaponStrategy PrimaryWeaponStrategy { get; set; }
                public AryWeaponStrategy SecondaryWeaponStrategy { get; set; }
                public List<TypeElement> IgnoredDropItemTypes { get; set; }
                public bool? AvoidSmokes { get; set; }
                public bool? AvoidPoison { get; set; }
            }

            public partial class TaurusChemistWeak0_GameData
            {
                public PurpleYWeapon PrimaryWeapon { get; set; }
                public FluffyAryWeapon SecondaryWeapon { get; set; }
                public long RevivesCount { get; set; }
                public long ReviveAmount { get; set; }
                public long ReviveSpeed { get; set; }
                public long HitMultHead { get; set; }
                public long HitMultBody { get; set; }
                public double HitMultLegs { get; set; }
                public long Health { get; set; }
                public long ArmorHealth { get; set; }
                public double ArmorResistance { get; set; }
                public MovementCfg MovementCfg { get; set; }
                public PurpleResistsCfg ResistsCfg { get; set; }
            }

            public partial class TaurusCommander
            {
                public long TeamId { get; set; }
                public AllyBotAssaultClientCard ClientCard { get; set; }
                public TaurusCommanderGameData GameData { get; set; }
                public TaurusCommanderBotCfg BotCfg { get; set; }
            }

            public partial class TaurusCommanderBotCfg
            {
                public Role Archetype { get; set; }
                public CustomAbility CustomAbility { get; set; }
                public long InvestigationPriority { get; set; }
                public long OptimalCombatRange { get; set; }
                public double UrgeToActIncreaseOnAbilityActivation { get; set; }
                public bool CanSprint { get; set; }
            }

            public partial class TaurusCommanderGameData
            {
                public FluffyYWeapon PrimaryWeapon { get; set; }
                public long ActionPointMax { get; set; }
                public long ActionPointMin { get; set; }
                public long ActionPointRegenRate { get; set; }
                public long RevivesCount { get; set; }
                public long ReviveAmount { get; set; }
                public long ReviveSpeed { get; set; }
                public long HitMultHead { get; set; }
                public long HitMultBody { get; set; }
                public long HitMultLegs { get; set; }
                public long Health { get; set; }
                public long ArmorHealth { get; set; }
                public MovementCfg MovementCfg { get; set; }
                public StickyAbilities Abilities { get; set; }
                public List<PurplePassiveAbility> PassiveAbilities { get; set; }
            }

            public partial class StickyAbilities
            {
                public StickyPrimary Primary { get; set; }
            }

            public partial class StickyPrimary
            {
                public string Type { get; set; }
                public PrimaryClientName ClientName { get; set; }
                public PrimaryWeaponFxType FxType { get; set; }
                public long FxRadius { get; set; }
                public long CastTime { get; set; }
                public long Cooldown { get; set; }
                public long Duration { get; set; }
                public long ActivationCost { get; set; }
                public bool ActivationOnRelease { get; set; }
                public List<AmfMedicPassiveGroup> Groups { get; set; }
            }

            public partial class PurplePassiveAbility
            {
                public string Name { get; set; }
                public List<HilariousGroup> Groups { get; set; }
            }

            public partial class HilariousGroup
            {
                public List<DeactivatedEntitiesOwnersBuffElement> Buffs { get; set; }
            }

            public partial class TaurusFighter
            {
                public long TeamId { get; set; }
                public AllyBotAssaultClientCard ClientCard { get; set; }
                public TaurusFighterWeak0_GameData GameData { get; set; }
                public AllyBotInformerBotCfg BotCfg { get; set; }
            }

            public partial class TaurusFighterWeak0_GameData
            {
                public PurpleAryWeapon PrimaryWeapon { get; set; }
                public PurpleYWeapon HeavyWeapon { get; set; }
                public long RevivesCount { get; set; }
                public long ReviveAmount { get; set; }
                public long ReviveSpeed { get; set; }
                public long HitMultHead { get; set; }
                public long HitMultBody { get; set; }
                public double HitMultLegs { get; set; }
                public long Health { get; set; }
                public long ArmorHealth { get; set; }
                public long ArmorResistance { get; set; }
                public MovementCfg MovementCfg { get; set; }
                public FluffyResistsCfg ResistsCfg { get; set; }
            }

            public partial class TaurusFighter1
            {
                public long TeamId { get; set; }
                public AllyBotAssaultClientCard ClientCard { get; set; }
                public TaurusFighterOnslaught0_GameData GameData { get; set; }
                public TaurusFighter1_BotCfg BotCfg { get; set; }
            }

            public partial class TaurusFighter1_BotCfg
            {
                public Role Archetype { get; set; }
                public double RethinkTime { get; set; }
                public long RotationRateHorizontal { get; set; }
                public long RotationRateVertical { get; set; }
                public double StayInCoverTime { get; set; }
                public long OptimalCombatRange { get; set; }
                public long StopDistance { get; set; }
                public double AttackFromCoverTime { get; set; }
                public double UrgeToChangeToBetterPosition { get; set; }
                public long FinalOptimalCombatRange { get; set; }
                public long FinalOptimalCombatRangeReachSeconds { get; set; }
                public double GrenadeHappiness { get; set; }
                public bool CanSprint { get; set; }
                public bool AvoidPoison { get; set; }
                public bool AvoidFire { get; set; }
                public bool AvoidBullets { get; set; }
                public PurplePrimaryWeaponStrategy PrimaryWeaponStrategy { get; set; }
            }

            public partial class TaurusFighterOnslaught0_GameData
            {
                public IndecentPrimaryWeapon PrimaryWeapon { get; set; }
                public PurpleYWeapon HeavyWeapon { get; set; }
                public long RevivesCount { get; set; }
                public long ReviveAmount { get; set; }
                public long ReviveSpeed { get; set; }
                public long HitMultHead { get; set; }
                public long HitMultBody { get; set; }
                public double HitMultLegs { get; set; }
                public long Health { get; set; }
                public long ArmorHealth { get; set; }
                public long ArmorResistance { get; set; }
                public MovementCfg MovementCfg { get; set; }
                public FluffyResistsCfg ResistsCfg { get; set; }
            }

            public partial class IndecentPrimaryWeapon
            {
                public long ItemType { get; set; }
                public long WeaponType { get; set; }
                public long ItemPlantingType { get; set; }
                public bool Hitscan { get; set; }
                public bool IsClipfed { get; set; }
                public bool HasOpticalSight { get; set; }
                public double BoltCycleTime { get; set; }
                public bool AutomaticFire { get; set; }
                public bool SoundAutomaticFire { get; set; }
                public long BulletsPerShot { get; set; }
                public long RateOfFire { get; set; }
                public long ClipSize { get; set; }
                public long MaxClipCount { get; set; }
                public bool UnlimitedClips { get; set; }
                public long Damage { get; set; }
                public double HeadshotMult { get; set; }
                public double ArmorPenetration { get; set; }
                public long BulletSpeed { get; set; }
                public long MaxDistanceForBullet { get; set; }
                public long HitTargetsLimit { get; set; }
                public double SwitchInTime { get; set; }
                public double SwitchOutTime { get; set; }
                public double ReloadTime { get; set; }
                public long ReloadCombinedTime { get; set; }
                public long SpeedModOnRun { get; set; }
                public long SpeedModOnCrouch { get; set; }
                public long SpeedModOnAds { get; set; }
                public long SpeedModOnSprint { get; set; }
                public LocalCheckDirection SpreadConeMin { get; set; }
                public LocalCheckDirection SpreadConeMax { get; set; }
                public LocalCheckDirection SpreadConeMovementAdd { get; set; }
                public LocalCheckDirection SpreadIncreasePerShot { get; set; }
                public LocalCheckDirection SpreadIncreaseOnMove { get; set; }
                public LocalCheckDirection SpreadRestoreSpeed { get; set; }
                public LocalCheckDirection SpreadRestoreDelay { get; set; }
                public LocalCheckDirection ShotKickUp { get; set; }
                public LocalCheckDirection ShotKickHorizontalMean { get; set; }
                public LocalCheckDirection ShotKickHorizontalDeviation { get; set; }
                public LocalCheckDirection ShotKickRestoreDelay { get; set; }
                public LocalCheckDirection ShotKickRestoreSpeed { get; set; }
                public Dictionary<string, DamageCurve> DamageCurve { get; set; }
            }

            public partial class TaurusFighterEmpowered0
            {
                public long TeamId { get; set; }
                public AllyBotAssaultClientCard ClientCard { get; set; }
                public TaurusFighterEmpowered0_GameData GameData { get; set; }
                public AllyBotInformerBotCfg BotCfg { get; set; }
            }

            public partial class TaurusFighterEmpowered0_GameData
            {
                public PurplePrimaryWeapon PrimaryWeapon { get; set; }
                public PurpleYWeapon HeavyWeapon { get; set; }
                public long RevivesCount { get; set; }
                public long ReviveAmount { get; set; }
                public long ReviveSpeed { get; set; }
                public long HitMultHead { get; set; }
                public long HitMultBody { get; set; }
                public double HitMultLegs { get; set; }
                public long Health { get; set; }
                public long ActionPointMax { get; set; }
                public long ArmorHealth { get; set; }
                public long ArmorResistance { get; set; }
                public MovementCfg MovementCfg { get; set; }
                public FluffyResistsCfg ResistsCfg { get; set; }
            }

            public partial class TaurusFighterOnslaught0
            {
                public long TeamId { get; set; }
                public AllyBotAssaultClientCard ClientCard { get; set; }
                public TaurusFighterOnslaught0_GameData GameData { get; set; }
                public AllyBotInformerBotCfg BotCfg { get; set; }
            }

            public partial class FighterOnslaught2
            {
                public long TeamId { get; set; }
                public AllyBotAssaultClientCard ClientCard { get; set; }
                public TaurusFighterOnslaught0_GameData GameData { get; set; }
                public TaurusFighterOnslaught2_BotCfg BotCfg { get; set; }
            }

            public partial class TaurusFighterOnslaught2_BotCfg
            {
                public Role Archetype { get; set; }
                public double RethinkTime { get; set; }
                public long RotationRateHorizontal { get; set; }
                public long RotationRateVertical { get; set; }
                public double StayInCoverTime { get; set; }
                public long OptimalCombatRange { get; set; }
                public double AttackFromCoverTime { get; set; }
                public double GrenadeHappiness { get; set; }
                public long StopDistance { get; set; }
                public bool CanSprint { get; set; }
                public bool AvoidSmokes { get; set; }
                public bool AvoidBullets { get; set; }
                public bool AvoidPoison { get; set; }
                public bool AvoidFire { get; set; }
                public long GrenadeTargetingTime { get; set; }
                public double UrgeToChangeToBetterPosition { get; set; }
                public long FinalOptimalCombatRange { get; set; }
                public long FinalOptimalCombatRangeReachSeconds { get; set; }
                public bool SearchReachablePath { get; set; }
                public PurplePrimaryWeaponStrategy PrimaryWeaponStrategy { get; set; }
            }

            public partial class FighterOnslaught2__Elimination
            {
                public long TeamId { get; set; }
                public AllyBotAssaultClientCard ClientCard { get; set; }
                public TaurusFighterOnslaught0_GameData GameData { get; set; }
                public TaurusFighterOnslaught2_EliminationBotCfg BotCfg { get; set; }
            }

            public partial class TaurusFighterOnslaught2_EliminationBotCfg
            {
                public Role Archetype { get; set; }
                public double RethinkTime { get; set; }
                public long RotationRateHorizontal { get; set; }
                public long RotationRateVertical { get; set; }
                public double StayInCoverTime { get; set; }
                public long OptimalCombatRange { get; set; }
                public double AttackFromCoverTime { get; set; }
                public double GrenadeHappiness { get; set; }
                public long StopDistance { get; set; }
                public bool CanSprint { get; set; }
                public bool AvoidSmokes { get; set; }
                public bool AvoidBullets { get; set; }
                public bool AvoidPoison { get; set; }
                public bool AvoidFire { get; set; }
                public long GrenadeTargetingTime { get; set; }
                public double UrgeToChangeToBetterPosition { get; set; }
                public long FinalOptimalCombatRange { get; set; }
                public long FinalOptimalCombatRangeReachSeconds { get; set; }
                public bool SearchReachablePath { get; set; }
                public long InvestigationPriority { get; set; }
                public PurplePrimaryWeaponStrategy PrimaryWeaponStrategy { get; set; }
            }

            public partial class TaurusGunnerOnslaught0
            {
                public long TeamId { get; set; }
                public AllyBotAssaultClientCard ClientCard { get; set; }
                public ManekenEnemy0_GameData GameData { get; set; }
                public AllyBotInformerBotCfg BotCfg { get; set; }
            }

            public partial class TaurusGunnerEmpowered0
            {
                public long TeamId { get; set; }
                public AllyBotAssaultClientCard ClientCard { get; set; }
                public TaurusGunnerEmpowered0_GameData GameData { get; set; }
                public AllyBotInformerBotCfg BotCfg { get; set; }
            }

            public partial class TaurusGunnerEmpowered0_GameData
            {
                public HilariousPrimaryWeapon PrimaryWeapon { get; set; }
                public long RevivesCount { get; set; }
                public long ReviveAmount { get; set; }
                public long ReviveSpeed { get; set; }
                public long HitMultHead { get; set; }
                public long HitMultBody { get; set; }
                public double HitMultLegs { get; set; }
                public long Health { get; set; }
                public long ArmorHealth { get; set; }
                public double ArmorResistance { get; set; }
                public MovementCfg MovementCfg { get; set; }
                public PurpleResistsCfg ResistsCfg { get; set; }
                public long? ActionPointMax { get; set; }
                public IndigoAbilities Abilities { get; set; }
            }

            public partial class IndigoAbilities
            {
                public IndigoPrimary Primary { get; set; }
            }

            public partial class IndigoPrimary
            {
                public StickyType Type { get; set; }
                public PrimaryClientName ClientName { get; set; }
                public FxTypeEnum FxType { get; set; }
                public long FxRadius { get; set; }
                public long CastTime { get; set; }
                public double Cooldown { get; set; }
                public long Duration { get; set; }
                public long ActivationCost { get; set; }
                public bool ActivationOnRelease { get; set; }
                public List<IndecentGroup> Groups { get; set; }
                public ArystanSniperBuffAura BuffAura { get; set; }
                public List<PurpleBuffAuraGroup> BuffAuraGroups { get; set; }
            }

            public partial class HilariousPrimaryWeapon
            {
                public long ItemType { get; set; }
                public long WeaponType { get; set; }
                public long ItemPlantingType { get; set; }
                public bool Hitscan { get; set; }
                public bool IsClipfed { get; set; }
                public bool IsManuallyCycled { get; set; }
                public double BoltCycleTime { get; set; }
                public bool BurstShot { get; set; }
                public bool AutomaticFire { get; set; }
                public bool SoundAutomaticFire { get; set; }
                public long BulletsPerShot { get; set; }
                public double RateOfFire { get; set; }
                public bool AmmoAmountForEntireMatch { get; set; }
                public long ClipSize { get; set; }
                public long MaxClipCount { get; set; }
                public long Damage { get; set; }
                public long DamageRadius { get; set; }
                public long DamageRadiusTrajectory { get; set; }
                public long DamageCoefOnUncovered { get; set; }
                public double HeadshotMult { get; set; }
                public double ArmorPenetration { get; set; }
                public long BulletSpeed { get; set; }
                public long MaxDistanceForBullet { get; set; }
                public long TimeToLife { get; set; }
                public long HitTargetsLimit { get; set; }
                public double AimSensitivityModifier { get; set; }
                public long AimGrenadeMidAngleOffset { get; set; }
                public double SwitchInTime { get; set; }
                public double SwitchOutTime { get; set; }
                public double ReloadTime { get; set; }
                public double ReloadCombinedTime { get; set; }
                public long SpeedModOnRun { get; set; }
                public long SpeedModOnCrouch { get; set; }
                public long SpeedModOnAds { get; set; }
                public long SpeedModOnSprint { get; set; }
                public LocalCheckDirection SpreadConeMin { get; set; }
                public LocalCheckDirection SpreadConeMax { get; set; }
                public LocalCheckDirection SpreadConeMovementAdd { get; set; }
                public LocalCheckDirection SpreadIncreasePerShot { get; set; }
                public LocalCheckDirection SpreadIncreaseOnMove { get; set; }
                public LocalCheckDirection SpreadRestoreSpeed { get; set; }
                public LocalCheckDirection SpreadRestoreDelay { get; set; }
                public Dictionary<string, DamageCurve> DamageCurve { get; set; }
            }

            public partial class TaurusGunnerPvPvE
            {
                public long TeamId { get; set; }
                public AllyBotAssaultClientCard ClientCard { get; set; }
                public TaurusGunnerPvPvEGameData GameData { get; set; }
                public AllyBotInformerBotCfg BotCfg { get; set; }
            }

            public partial class TaurusGunnerPvPvEGameData
            {
                public AmbitiousPrimaryWeapon PrimaryWeapon { get; set; }
                public long RevivesCount { get; set; }
                public long ReviveAmount { get; set; }
                public long ReviveSpeed { get; set; }
                public long HitMultHead { get; set; }
                public long HitMultBody { get; set; }
                public double HitMultLegs { get; set; }
                public long Health { get; set; }
                public long ArmorHealth { get; set; }
                public double ArmorResistance { get; set; }
                public MovementCfg MovementCfg { get; set; }
                public PurpleResistsCfg ResistsCfg { get; set; }
                public long? ActionPointMax { get; set; }
                public IndecentAbilities Abilities { get; set; }
            }

            public partial class IndecentAbilities
            {
                public IndecentPrimary Primary { get; set; }
            }

            public partial class IndecentPrimary
            {
                public StickyType Type { get; set; }
                public PrimaryClientName ClientName { get; set; }
                public FxTypeEnum FxType { get; set; }
                public long FxRadius { get; set; }
                public long CastTime { get; set; }
                public double Cooldown { get; set; }
                public long Duration { get; set; }
                public long ActivationCost { get; set; }
                public bool ActivationOnRelease { get; set; }
                public List<IndigoGroup> Groups { get; set; }
                public Ww2SniperBuffAura BuffAura { get; set; }
                public List<TentacledBuffAuraGroup> BuffAuraGroups { get; set; }
            }

            public partial class TentacledBuffAuraGroup
            {
                public AuraBuffGroupTargetSelectionTime TargetSelectionTime { get; set; }
                public DeactivatedEntitiesOwnersRuleElement Rule { get; set; }
                public List<Buff55> Buffs { get; set; }
            }

            public partial class AmbitiousPrimaryWeapon
            {
                public long ItemType { get; set; }
                public long WeaponType { get; set; }
                public long ItemPlantingType { get; set; }
                public bool Hitscan { get; set; }
                public bool IsClipfed { get; set; }
                public bool IsManuallyCycled { get; set; }
                public double BoltCycleTime { get; set; }
                public bool BurstShot { get; set; }
                public bool AutomaticFire { get; set; }
                public long BulletsPerShot { get; set; }
                public long RateOfFire { get; set; }
                public bool AmmoAmountForEntireMatch { get; set; }
                public long ClipSize { get; set; }
                public long MaxClipCount { get; set; }
                public long Damage { get; set; }
                public long DamageRadius { get; set; }
                public long DamageRadiusTrajectory { get; set; }
                public long DamageCoefOnUncovered { get; set; }
                public double HeadshotMult { get; set; }
                public double ArmorPenetration { get; set; }
                public long BulletSpeed { get; set; }
                public long MaxDistanceForBullet { get; set; }
                public long TimeToLife { get; set; }
                public long HitTargetsLimit { get; set; }
                public double AimSensitivityModifier { get; set; }
                public long AimGrenadeMidAngleOffset { get; set; }
                public double SwitchInTime { get; set; }
                public double SwitchOutTime { get; set; }
                public double ReloadTime { get; set; }
                public double ReloadCombinedTime { get; set; }
                public long SpeedModOnRun { get; set; }
                public long SpeedModOnCrouch { get; set; }
                public long SpeedModOnAds { get; set; }
                public long SpeedModOnSprint { get; set; }
                public LocalCheckDirection SpreadConeMin { get; set; }
                public LocalCheckDirection SpreadConeMax { get; set; }
                public LocalCheckDirection SpreadConeMovementAdd { get; set; }
                public LocalCheckDirection SpreadIncreasePerShot { get; set; }
                public LocalCheckDirection SpreadIncreaseOnMove { get; set; }
                public LocalCheckDirection SpreadRestoreSpeed { get; set; }
                public LocalCheckDirection SpreadRestoreDelay { get; set; }
                public LocalCheckDirection ShotKickUp { get; set; }
                public LocalCheckDirection ShotKickHorizontalMean { get; set; }
                public LocalCheckDirection ShotKickHorizontalDeviation { get; set; }
                public LocalCheckDirection ShotKickRestoreDelay { get; set; }
                public LocalCheckDirection ShotKickRestoreSpeed { get; set; }
                public Dictionary<string, DamageCurve> DamageCurve { get; set; }
            }

            public partial class TaurusHeavyFighter
            {
                public long TeamId { get; set; }
                public AllyBotAssaultClientCard ClientCard { get; set; }
                public TaurusHeavyFighter0_GameData GameData { get; set; }
                public TaurusHeavyFighterOnslaughtBotCfg BotCfg { get; set; }
            }

            public partial class TaurusHeavyFighterOnslaughtBotCfg
            {
                public Role Archetype { get; set; }
                public double RethinkTime { get; set; }
                public long DefensiveAbilityMinHealth { get; set; }
                public long RotationRateHorizontal { get; set; }
                public long RotationRateVertical { get; set; }
                public double StayInCoverTime { get; set; }
                public long OptimalCombatRange { get; set; }
                public long AttackFromCoverTime { get; set; }
                public long AbilityMaxMemoryAgeForUsage { get; set; }
                public bool CanSprint { get; set; }
                public bool AvoidSmokes { get; set; }
                public bool AvoidBullets { get; set; }
                public bool AvoidPoison { get; set; }
                public bool AvoidFire { get; set; }
                public bool AvoidDropItems { get; set; }
                public bool? HideWeaponOnClimb { get; set; }
                public long AvoidDropItemsDelay { get; set; }
                public double? UrgeToChangeToBetterPosition { get; set; }
                public long? FinalOptimalCombatRange { get; set; }
                public long? FinalOptimalCombatRangeReachSeconds { get; set; }
                public bool? SearchReachablePath { get; set; }
                public long HearingRadius { get; set; }
                public StickyPrimaryWeaponStrategy PrimaryWeaponStrategy { get; set; }
                public long PvpveKillScore { get; set; }
            }

            public partial class StickyPrimaryWeaponStrategy
            {
                public double FireTime { get; set; }
                public double FirePauseTime { get; set; }
                public double BattleReadyAmmoClipFraction { get; set; }
                public double LowAmmoClipFraction { get; set; }
            }

            public partial class TaurusHeavyFighter0_GameData
            {
                public FluffyAryWeapon PrimaryWeapon { get; set; }
                public long RevivesCount { get; set; }
                public long ReviveAmount { get; set; }
                public long ReviveSpeed { get; set; }
                public long ActionPointMax { get; set; }
                public long ActionPointMin { get; set; }
                public long ActionPointRegenRate { get; set; }
                public long ActionPointOffCombatRegenBonus { get; set; }
                public long HitMultHead { get; set; }
                public double HitMultBody { get; set; }
                public double HitMultLegs { get; set; }
                public long Health { get; set; }
                public long ArmorHealth { get; set; }
                public double ArmorResistance { get; set; }
                public MovementCfg MovementCfg { get; set; }
                public PurpleResistsCfg ResistsCfg { get; set; }
                public HilariousAbilities Abilities { get; set; }
                public List<TentacledPassiveAbility> PassiveAbilities { get; set; }
            }

            public partial class HilariousAbilities
            {
                public HilariousPrimary Primary { get; set; }
            }

            public partial class HilariousPrimary
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public long Cooldown { get; set; }
                public long Duration { get; set; }
                public long ActivationCost { get; set; }
                public bool ActivationOnRelease { get; set; }
                public List<AmbitiousGroup> Groups { get; set; }
            }

            public partial class AmbitiousGroup
            {
                public SelfSuccessGroupRule Rule { get; set; }
                public string TargetSelectionTime { get; set; }
                public double WarmingSpeed { get; set; }
                public double CooldownSpeed { get; set; }
                public List<Buff52> Buffs { get; set; }
            }

            public partial class TentacledPassiveAbility
            {
                public string Name { get; set; }
                public List<CunningGroup> Groups { get; set; }
            }

            public partial class CunningGroup
            {
                public DeactivatedEntitiesOwnersRuleElement Rule { get; set; }
                public List<Buff59> Buffs { get; set; }
            }

            public partial class Buff59
            {
                public TentacledName Name { get; set; }
                public long Priority { get; set; }
                public List<TentacledCategory> Categories { get; set; }
                public long Duration { get; set; }
                public double? WpnHeadshotMultPrimaryScale { get; set; }
                public long? ShieldAdd { get; set; }
                public double? WpnRateOfFireModPrimaryScale { get; set; }
            }

            public partial class TaurusHeavyFighterOnslaught
            {
                public long TeamId { get; set; }
                public AllyBotAssaultClientCard ClientCard { get; set; }
                public TaurusHeavyFighterOnslaughtGameData GameData { get; set; }
                public TaurusHeavyFighterOnslaughtBotCfg BotCfg { get; set; }
            }

            public partial class TaurusHeavyFighterOnslaughtGameData
            {
                public PurplePrimaryWeapon PrimaryWeapon { get; set; }
                public long RevivesCount { get; set; }
                public long ReviveAmount { get; set; }
                public long ReviveSpeed { get; set; }
                public long ActionPointMax { get; set; }
                public long ActionPointMin { get; set; }
                public long ActionPointRegenRate { get; set; }
                public long ActionPointOffCombatRegenBonus { get; set; }
                public long HitMultHead { get; set; }
                public double HitMultBody { get; set; }
                public double HitMultLegs { get; set; }
                public long Health { get; set; }
                public long ArmorHealth { get; set; }
                public double ArmorResistance { get; set; }
                public MovementCfg MovementCfg { get; set; }
                public PurpleResistsCfg ResistsCfg { get; set; }
                public HilariousAbilities Abilities { get; set; }
                public List<FluffyPassiveAbility> PassiveAbilities { get; set; }
            }

            public partial class FluffyPassiveAbility
            {
                public string Name { get; set; }
                public long Cooldown { get; set; }
                public List<CunningGroup> Groups { get; set; }
            }

            public partial class TaurusLeaderEmpowered0
            {
                public long TeamId { get; set; }
                public TaurusLeaderEmpowered0_ClientCard ClientCard { get; set; }
                public TaurusGunnerPvPvEGameData GameData { get; set; }
                public TaurusLeaderEmpowered0_BotCfg BotCfg { get; set; }
            }

            public partial class TaurusLeaderEmpowered0_BotCfg
            {
                public FluffyArchetype Archetype { get; set; }
                public long? InvestigationPriority { get; set; }
                public long AttackFromCoverTime { get; set; }
                public long DisappearedEnemyFocusTime { get; set; }
                public long FiringTimeOnTargetLoss { get; set; }
                public long StopDistance { get; set; }
                public long EnemyProximityRange { get; set; }
                public long HearingRadius { get; set; }
                public long RethinkTime { get; set; }
                public long BattlePosMoveMinTimeToReconsider { get; set; }
                public long RotationRateHorizontal { get; set; }
                public long RotationRateVertical { get; set; }
                public long OptimalCombatRange { get; set; }
                public bool CanSprint { get; set; }
                public bool FullStaminaOnSpawn { get; set; }
                public bool AbilityActivationRequiresEnemyKnowledge { get; set; }
                public bool CanActivateAbilityPassively { get; set; }
                public bool NeedFatality { get; set; }
                public IndigoPrimaryWeaponStrategy PrimaryWeaponStrategy { get; set; }
                public bool? AvoidSmokes { get; set; }
                public bool? AvoidBullets { get; set; }
                public long? InstantDamageForGrudge { get; set; }
                public long? GrudgeTime { get; set; }
            }

            public partial class IndigoPrimaryWeaponStrategy
            {
                public long LockOnTime { get; set; }
                public long FireTime { get; set; }
                public long FirePauseTime { get; set; }
                public long FirePauseTimeDeviation { get; set; }
                public long FireTimeDeviation { get; set; }
                public double BattleReadyAmmoClipFraction { get; set; }
                public double LowAmmoClipFraction { get; set; }
            }

            public partial class TaurusLeaderEmpowered0_ClientCard
            {
                public CollectionEnum? Collection { get; set; }
                public Role Role { get; set; }
                public string Visual { get; set; }
                public List<FluffyItem> Items { get; set; }
            }

            public partial class FluffyItem
            {
                public SlotElement Slot { get; set; }
                public string Visual { get; set; }
                public List<Upgrade> Upgrades { get; set; }
            }

            public partial class Upgrade
            {
                public ModuleType? ModuleType { get; set; }
                public Attachment AttachmentId { get; set; }
                public bool Enabled { get; set; }
                public bool? UninstallWhenDie { get; set; }
            }

            public partial class TaurusOfficerMedic
            {
                public long TeamId { get; set; }
                public AllyBotAssaultClientCard ClientCard { get; set; }
                public TaurusOfficerMedicGameData GameData { get; set; }
                public OnboardingOfficerMedicBotCfg BotCfg { get; set; }
            }

            public partial class TaurusOfficerMedicGameData
            {
                public FluffyYWeapon PrimaryWeapon { get; set; }
                public PurpleYWeapon HeavyWeapon { get; set; }
                public long ActionPointMax { get; set; }
                public long ActionPointMin { get; set; }
                public long ActionPointRegenRate { get; set; }
                public long RevivesCount { get; set; }
                public long ReviveAmount { get; set; }
                public long ReviveSpeed { get; set; }
                public long HitMultHead { get; set; }
                public long HitMultBody { get; set; }
                public double HitMultLegs { get; set; }
                public long Health { get; set; }
                public long ArmorHealth { get; set; }
                public MovementCfg MovementCfg { get; set; }
                public FluffyResistsCfg ResistsCfg { get; set; }
                public FluffyAbilities Abilities { get; set; }
            }

            public partial class TaurusOfficerMedicOnslaught
            {
                public long TeamId { get; set; }
                public AllyBotAssaultClientCard ClientCard { get; set; }
                public TaurusOfficerMedicOnslaught0_GameData GameData { get; set; }
                public OnboardingOfficerMedicBotCfg BotCfg { get; set; }
            }

            public partial class TaurusOfficerMedicOnslaught0_GameData
            {
                public PurpleYWeapon PrimaryWeapon { get; set; }
                public PurpleYWeapon HeavyWeapon { get; set; }
                public long ActionPointMax { get; set; }
                public long ActionPointMin { get; set; }
                public long ActionPointRegenRate { get; set; }
                public long RevivesCount { get; set; }
                public long ReviveAmount { get; set; }
                public long ReviveSpeed { get; set; }
                public long HitMultHead { get; set; }
                public long HitMultBody { get; set; }
                public double HitMultLegs { get; set; }
                public long Health { get; set; }
                public long ArmorHealth { get; set; }
                public MovementCfg MovementCfg { get; set; }
                public FluffyResistsCfg ResistsCfg { get; set; }
                public AmbitiousAbilities Abilities { get; set; }
            }

            public partial class AmbitiousAbilities
            {
                public AmbitiousPrimary Primary { get; set; }
            }

            public partial class AmbitiousPrimary
            {
                public string Type { get; set; }
                public string ClientName { get; set; }
                public bool StopBuffsWithAbility { get; set; }
                public PrimaryWeaponFxType FxType { get; set; }
                public long FxRadius { get; set; }
                public long CastTime { get; set; }
                public long Cooldown { get; set; }
                public long Duration { get; set; }
                public long ActivationCost { get; set; }
                public bool ActivationOnRelease { get; set; }
                public List<IndecentGroup> Groups { get; set; }
                public ArystanSniperBuffAura BuffAura { get; set; }
                public List<StickyBuffAuraGroup> BuffAuraGroups { get; set; }
            }

            public partial class StickyBuffAuraGroup
            {
                public bool? StopBuffsWithAbility { get; set; }
                public AuraBuffGroupTargetSelectionTime TargetSelectionTime { get; set; }
                public SelfSuccessGroupRule Rule { get; set; }
                public List<Buff60> Buffs { get; set; }
            }

            public partial class Buff60
            {
                public PurpleName Name { get; set; }
                public long Priority { get; set; }
                public List<PurpleCategory> Categories { get; set; }
                public long Duration { get; set; }
                public bool StopBuffsWithAbility { get; set; }
                public double? Period { get; set; }
                public long? HealthAdd { get; set; }
                public bool Rebuff { get; set; }
                public double? WpnRateOfFireModPrimary { get; set; }
                public double? SpeedScale { get; set; }
            }

            public partial class TaurusOfficerSupport
            {
                public long TeamId { get; set; }
                public AllyBotAssaultClientCard ClientCard { get; set; }
                public TaurusGunnerEmpowered0_GameData GameData { get; set; }
                public TaurusOfficerSupportBotCfg BotCfg { get; set; }
            }

            public partial class TaurusOfficerSupportBotCfg
            {
                public PurpleArchetype Archetype { get; set; }
                public double RethinkTime { get; set; }
                public long RotationRateHorizontal { get; set; }
                public long RotationRateVertical { get; set; }
                public double? BattleReadyAmmoClipFraction { get; set; }
                public double StayInCoverTime { get; set; }
                public long OptimalCombatRange { get; set; }
                public double AttackFromCoverTime { get; set; }
                public bool CanSprint { get; set; }
                public bool? AvoidSmokes { get; set; }
                public bool AvoidBullets { get; set; }
                public bool AvoidPoison { get; set; }
                public bool AvoidFire { get; set; }
                public bool? FullStaminaOnSpawn { get; set; }
                public bool? AbilityActivationRequiresEnemyKnowledge { get; set; }
                public Tion? PrimaryAbilityEmotion { get; set; }
                public long? EnemyProximityRange { get; set; }
                public bool? NeedFatality { get; set; }
                public PurplePrimaryWeaponStrategy PrimaryWeaponStrategy { get; set; }
                public long? PvpveKillScore { get; set; }
                public double? UrgeToChangeToBetterPosition { get; set; }
                public long? FinalOptimalCombatRange { get; set; }
                public long? FinalOptimalCombatRangeReachSeconds { get; set; }
                public bool? SearchReachablePath { get; set; }
                public double? GrenadeHappiness { get; set; }
                public long? StopDistance { get; set; }
                public long? GrenadeTargetingTime { get; set; }
                public long? InvestigationPriority { get; set; }
                public long? HearingRadius { get; set; }
            }

            public partial class TaurusOfficerSupportOnslaught0
            {
                public long TeamId { get; set; }
                public AllyBotAssaultClientCard ClientCard { get; set; }
                public ManekenEnemy0_GameData GameData { get; set; }
                public TaurusOfficerSupportOnslaught0_BotCfg BotCfg { get; set; }
            }

            public partial class TaurusOfficerSupportOnslaught0_BotCfg
            {
                public PurpleArchetype Archetype { get; set; }
                public double RethinkTime { get; set; }
                public long RotationRateHorizontal { get; set; }
                public long RotationRateVertical { get; set; }
                public double BattleReadyAmmoClipFraction { get; set; }
                public double StayInCoverTime { get; set; }
                public long OptimalCombatRange { get; set; }
                public long AttackFromCoverTime { get; set; }
                public bool CanSprint { get; set; }
                public bool FullStaminaOnSpawn { get; set; }
                public bool AbilityActivationRequiresEnemyKnowledge { get; set; }
                public Tion PrimaryAbilityEmotion { get; set; }
                public long EnemyProximityRange { get; set; }
                public double UrgeToChangeToBetterPosition { get; set; }
                public long FinalOptimalCombatRange { get; set; }
                public long FinalOptimalCombatRangeReachSeconds { get; set; }
                public bool AvoidSmokes { get; set; }
                public bool AvoidBullets { get; set; }
                public bool AvoidPoison { get; set; }
                public bool AvoidFire { get; set; }
                public bool SearchReachablePath { get; set; }
                public PurplePrimaryWeaponStrategy PrimaryWeaponStrategy { get; set; }
            }

            public partial class TaurusRocketman0
            {
                public long TeamId { get; set; }
                public AllyBotAssaultClientCard ClientCard { get; set; }
                public TaurusRocketmanWeak0_GameData GameData { get; set; }
                public TaurusChemistOnslaught2_BotCfg BotCfg { get; set; }
            }

            public partial class TaurusRocketmanWeak0_GameData
            {
                public MagentaPrimaryWeapon PrimaryWeapon { get; set; }
                public SecondaryWeapon SecondaryWeapon { get; set; }
                public long RevivesCount { get; set; }
                public long ReviveAmount { get; set; }
                public long ReviveSpeed { get; set; }
                public long HitMultHead { get; set; }
                public long HitMultBody { get; set; }
                public double HitMultLegs { get; set; }
                public long Health { get; set; }
                public long ArmorHealth { get; set; }
                public double ArmorResistance { get; set; }
                public MovementCfg MovementCfg { get; set; }
                public FluffyResistsCfg ResistsCfg { get; set; }
            }

            public partial class MagentaPrimaryWeapon
            {
                public long ItemType { get; set; }
                public long WeaponType { get; set; }
                public long ItemPlantingType { get; set; }
                public bool Hitscan { get; set; }
                public double GravityCompensation { get; set; }
                public bool IsClipfed { get; set; }
                public bool IsManuallyCycled { get; set; }
                public bool BulletsCanBeDeactivated { get; set; }
                public double BoltCycleTime { get; set; }
                public bool BurstShot { get; set; }
                public bool AutomaticFire { get; set; }
                public bool SoundAutomaticFire { get; set; }
                public long BulletsPerShot { get; set; }
                public double RateOfFire { get; set; }
                public long ClipSize { get; set; }
                public long MaxClipCount { get; set; }
                public long WeaponExplosiveSubtype { get; set; }
                public SecondaryWeaponExplosionFxType ExplosionFxType { get; set; }
                public long Damage { get; set; }
                public long DamageRadius { get; set; }
                public long DamageRadiusTrajectory { get; set; }
                public double DamageCoefOnUncovered { get; set; }
                public long HeadshotMult { get; set; }
                public double ArmorPenetration { get; set; }
                public long BulletSpeed { get; set; }
                public long MaxDistanceForBullet { get; set; }
                public long TimeToLife { get; set; }
                public bool ProjectileRebound { get; set; }
                public long HitTargetsLimit { get; set; }
                public double SwitchInTime { get; set; }
                public double SwitchOutTime { get; set; }
                public double ReloadTime { get; set; }
                public long ReloadCombinedTime { get; set; }
                public long SpeedModOnRun { get; set; }
                public long SpeedModOnCrouch { get; set; }
                public long SpeedModOnAds { get; set; }
                public long SpeedModOnSprint { get; set; }
                public LocalCheckDirection SpreadConeMin { get; set; }
                public LocalCheckDirection SpreadConeMax { get; set; }
                public LocalCheckDirection SpreadConeMovementAdd { get; set; }
                public LocalCheckDirection SpreadIncreasePerShot { get; set; }
                public LocalCheckDirection SpreadIncreaseOnMove { get; set; }
                public LocalCheckDirection SpreadRestoreSpeed { get; set; }
                public LocalCheckDirection SpreadRestoreDelay { get; set; }
                public LocalCheckDirection ShotKickUp { get; set; }
                public LocalCheckDirection ShotKickHorizontalMean { get; set; }
                public LocalCheckDirection ShotKickHorizontalDeviation { get; set; }
                public LocalCheckDirection ShotKickRestoreDelay { get; set; }
                public LocalCheckDirection ShotKickRestoreSpeed { get; set; }
                public Dictionary<string, DamageCurve> DamageCurve { get; set; }
                public Ksk2011SupportFxType FxType { get; set; }
                public double FxRadius { get; set; }
            }

            public partial class TaurusRocketman
            {
                public long TeamId { get; set; }
                public AllyBotAssaultClientCard ClientCard { get; set; }
                public TaurusRocketman1_GameData GameData { get; set; }
                public TaurusRocketman1_BotCfg BotCfg { get; set; }
            }

            public partial class TaurusRocketman1_BotCfg
            {
                public Role Archetype { get; set; }
                public double RethinkTime { get; set; }
                public long RotationRateHorizontal { get; set; }
                public long RotationRateVertical { get; set; }
                public long StayInCoverTime { get; set; }
                public long OptimalCombatRange { get; set; }
                public long StopDistance { get; set; }
                public bool CanSprint { get; set; }
                public bool AvoidSmokes { get; set; }
                public bool AvoidBullets { get; set; }
                public bool AvoidPoison { get; set; }
                public bool AvoidFire { get; set; }
                public YWeaponStrategy PrimaryWeaponStrategy { get; set; }
                public YWeaponStrategy SecondaryWeaponStrategy { get; set; }
            }

            public partial class TaurusRocketman1_GameData
            {
                public FluffyAryWeapon PrimaryWeapon { get; set; }
                public SecondaryWeapon SecondaryWeapon { get; set; }
                public long RevivesCount { get; set; }
                public long ReviveAmount { get; set; }
                public long ReviveSpeed { get; set; }
                public long HitMultHead { get; set; }
                public long HitMultBody { get; set; }
                public double HitMultLegs { get; set; }
                public long Health { get; set; }
                public long ArmorHealth { get; set; }
                public double ArmorResistance { get; set; }
                public MovementCfg MovementCfg { get; set; }
                public FluffyResistsCfg ResistsCfg { get; set; }
            }

            public partial class TaurusRocketmanEmpowered0
            {
                public long TeamId { get; set; }
                public AllyBotAssaultClientCard ClientCard { get; set; }
                public TaurusRocketmanEmpowered0_GameData GameData { get; set; }
                public TaurusAssaultEmpowered0_BotCfg BotCfg { get; set; }
            }

            public partial class TaurusRocketmanEmpowered0_GameData
            {
                public PurplePrimaryWeapon PrimaryWeapon { get; set; }
                public FluffyAryWeapon SecondaryWeapon { get; set; }
                public long RevivesCount { get; set; }
                public long ReviveAmount { get; set; }
                public long ReviveSpeed { get; set; }
                public long HitMultHead { get; set; }
                public long HitMultBody { get; set; }
                public double HitMultLegs { get; set; }
                public long Health { get; set; }
                public long ActionPointMax { get; set; }
                public long ArmorHealth { get; set; }
                public double ArmorResistance { get; set; }
                public MovementCfg MovementCfg { get; set; }
                public FluffyResistsCfg ResistsCfg { get; set; }
            }

            public partial class TaurusRocketmanOnslaught
            {
                public long TeamId { get; set; }
                public AllyBotAssaultClientCard ClientCard { get; set; }
                public TaurusRocketmanOnslaught0_GameData GameData { get; set; }
                public TaurusRocketmanOnslaught0_BotCfg BotCfg { get; set; }
            }

            public partial class TaurusRocketmanOnslaught0_BotCfg
            {
                public Role Archetype { get; set; }
                public double RethinkTime { get; set; }
                public long RotationRateHorizontal { get; set; }
                public long RotationRateVertical { get; set; }
                public long StayInCoverTime { get; set; }
                public long OptimalCombatRange { get; set; }
                public long StopDistance { get; set; }
                public bool CanSprint { get; set; }
                public bool AvoidSmokes { get; set; }
                public bool AvoidBullets { get; set; }
                public bool AvoidPoison { get; set; }
                public bool AvoidFire { get; set; }
                public double UrgeToChangeToBetterPosition { get; set; }
                public long FinalOptimalCombatRange { get; set; }
                public long FinalOptimalCombatRangeReachSeconds { get; set; }
                public bool SearchReachablePath { get; set; }
                public YWeaponStrategy PrimaryWeaponStrategy { get; set; }
                public SecondaryWeaponStrategy SecondaryWeaponStrategy { get; set; }
                public long PvpveKillScore { get; set; }
            }

            public partial class TaurusRocketmanOnslaught0_GameData
            {
                public CunningPrimaryWeapon PrimaryWeapon { get; set; }
                public FluffyAryWeapon SecondaryWeapon { get; set; }
                public long RevivesCount { get; set; }
                public long ReviveAmount { get; set; }
                public long ReviveSpeed { get; set; }
                public long HitMultHead { get; set; }
                public long HitMultBody { get; set; }
                public double HitMultLegs { get; set; }
                public long Health { get; set; }
                public long ArmorHealth { get; set; }
                public long ActionPointMax { get; set; }
                public double ArmorResistance { get; set; }
                public MovementCfg MovementCfg { get; set; }
                public FluffyResistsCfg ResistsCfg { get; set; }
            }

            public partial class CunningPrimaryWeapon
            {
                public long ItemType { get; set; }
                public long WeaponType { get; set; }
                public long ItemPlantingType { get; set; }
                public bool Hitscan { get; set; }
                public double GravityCompensation { get; set; }
                public bool IsClipfed { get; set; }
                public bool IsManuallyCycled { get; set; }
                public bool BulletsCanBeDeactivated { get; set; }
                public double BoltCycleTime { get; set; }
                public bool BurstShot { get; set; }
                public bool AutomaticFire { get; set; }
                public bool SoundAutomaticFire { get; set; }
                public long BulletsPerShot { get; set; }
                public double RateOfFire { get; set; }
                public long ClipSize { get; set; }
                public long MaxClipCount { get; set; }
                public long WeaponExplosiveSubtype { get; set; }
                public SecondaryWeaponExplosionFxType ExplosionFxType { get; set; }
                public bool UnlimitedClips { get; set; }
                public long Damage { get; set; }
                public long DamageRadius { get; set; }
                public long DamageRadiusTrajectory { get; set; }
                public double DamageCoefOnUncovered { get; set; }
                public long HeadshotMult { get; set; }
                public double ArmorPenetration { get; set; }
                public long BulletSpeed { get; set; }
                public long MaxDistanceForBullet { get; set; }
                public long TimeToLife { get; set; }
                public bool ProjectileRebound { get; set; }
                public long HitTargetsLimit { get; set; }
                public double SwitchInTime { get; set; }
                public double SwitchOutTime { get; set; }
                public double ReloadTime { get; set; }
                public long ReloadCombinedTime { get; set; }
                public long SpeedModOnRun { get; set; }
                public long SpeedModOnCrouch { get; set; }
                public long SpeedModOnAds { get; set; }
                public long SpeedModOnSprint { get; set; }
                public LocalCheckDirection SpreadConeMin { get; set; }
                public LocalCheckDirection SpreadConeMax { get; set; }
                public LocalCheckDirection SpreadConeMovementAdd { get; set; }
                public LocalCheckDirection SpreadIncreasePerShot { get; set; }
                public LocalCheckDirection SpreadIncreaseOnMove { get; set; }
                public LocalCheckDirection SpreadRestoreSpeed { get; set; }
                public LocalCheckDirection SpreadRestoreDelay { get; set; }
                public LocalCheckDirection ShotKickUp { get; set; }
                public LocalCheckDirection ShotKickHorizontalMean { get; set; }
                public LocalCheckDirection ShotKickHorizontalDeviation { get; set; }
                public LocalCheckDirection ShotKickRestoreDelay { get; set; }
                public LocalCheckDirection ShotKickRestoreSpeed { get; set; }
                public Dictionary<string, DamageCurve> DamageCurve { get; set; }
                public Ksk2011SupportFxType FxType { get; set; }
                public double FxRadius { get; set; }
            }

            public partial class TaurusRocketmanOnslaughtElimination
            {
                public long TeamId { get; set; }
                public AllyBotAssaultClientCard ClientCard { get; set; }
                public TaurusRocketmanOnslaught0_GameData GameData { get; set; }
                public TaurusChemistOnslaught2_BotCfg BotCfg { get; set; }
            }

            public partial class TaurusRocketmanPvPvE
            {
                public long TeamId { get; set; }
                public AllyBotAssaultClientCard ClientCard { get; set; }
                public TaurusRocketmanPvPvEGameData GameData { get; set; }
                public TaurusChemistOnslaught2_BotCfg BotCfg { get; set; }
            }

            public partial class TaurusRocketmanPvPvEGameData
            {
                public PurplePrimaryWeapon PrimaryWeapon { get; set; }
                public FluffyAryWeapon SecondaryWeapon { get; set; }
                public long RevivesCount { get; set; }
                public long ReviveAmount { get; set; }
                public long ReviveSpeed { get; set; }
                public long HitMultHead { get; set; }
                public long HitMultBody { get; set; }
                public double HitMultLegs { get; set; }
                public long Health { get; set; }
                public long ArmorHealth { get; set; }
                public double ArmorResistance { get; set; }
                public MovementCfg MovementCfg { get; set; }
                public FluffyResistsCfg ResistsCfg { get; set; }
            }

            public partial class TaurusRocketmanWeak0
            {
                public long TeamId { get; set; }
                public AllyBotAssaultClientCard ClientCard { get; set; }
                public TaurusRocketmanWeak0_GameData GameData { get; set; }
                public TaurusChemistWeak0_BotCfg BotCfg { get; set; }
            }

            public partial class TaurusScorpion
            {
                public long TeamId { get; set; }
                public AllyBotAssaultClientCard ClientCard { get; set; }
                public TaurusScorpionGameData GameData { get; set; }
                public TaurusLeaderEmpowered0_BotCfg BotCfg { get; set; }
            }

            public partial class TaurusScorpionGameData
            {
                public PurpleAryWeapon PrimaryWeapon { get; set; }
                public long RevivesCount { get; set; }
                public long ReviveAmount { get; set; }
                public long ReviveSpeed { get; set; }
                public long HitMultHead { get; set; }
                public long HitMultBody { get; set; }
                public double HitMultLegs { get; set; }
                public long Health { get; set; }
                public long ActionPointMax { get; set; }
                public long ArmorHealth { get; set; }
                public double ArmorResistance { get; set; }
                public MovementCfg MovementCfg { get; set; }
                public FluffyResistsCfg ResistsCfg { get; set; }
                public CunningAbilities Abilities { get; set; }
            }

            public partial class CunningAbilities
            {
                public CunningPrimary Primary { get; set; }
            }

            public partial class CunningPrimary
            {
                public StickyType Type { get; set; }
                public PrimaryClientName ClientName { get; set; }
                public FxTypeEnum FxType { get; set; }
                public long FxRadius { get; set; }
                public long CastTime { get; set; }
                public double Cooldown { get; set; }
                public long Duration { get; set; }
                public long ActivationCost { get; set; }
                public bool ActivationOnRelease { get; set; }
                public List<IndecentGroup> Groups { get; set; }
                public Ww2SniperBuffAura BuffAura { get; set; }
                public List<IndigoBuffAuraGroup> BuffAuraGroups { get; set; }
            }

            public partial class IndigoBuffAuraGroup
            {
                public PurpleTargetSelectionTime TargetSelectionTime { get; set; }
                public DeactivatedEntitiesOwnersRuleElement Rule { get; set; }
                public List<Buff61> Buffs { get; set; }
                public bool? StopBuffsWithAbility { get; set; }
            }

            public partial class Buff61
            {
                public CreatorBuffsByAffectingAuraName Name { get; set; }
                public long Priority { get; set; }
                public List<BuffImmuneAbsoluteAdd> Categories { get; set; }
                public bool Rebuff { get; set; }
                public long Duration { get; set; }
                public bool BotReactsToHardHit { get; set; }
                public PurpleIncomingDamageMod IncomingDamageMod { get; set; }
            }

            public partial class TaurusSergeantEmpowered0
            {
                public long TeamId { get; set; }
                public AllyBotAssaultClientCard ClientCard { get; set; }
                public TaurusSergeantEmpowered0_GameData GameData { get; set; }
                public TaurusSergeantEmpowered0_BotCfg BotCfg { get; set; }
            }

            public partial class TaurusSergeantEmpowered0_BotCfg
            {
                public Role Archetype { get; set; }
                public double RethinkTime { get; set; }
                public long RotationRateHorizontal { get; set; }
                public long RotationRateVertical { get; set; }
                public long StayInCoverTime { get; set; }
                public long OptimalCombatRange { get; set; }
                public long StopDistance { get; set; }
                public double AttackFromCoverTime { get; set; }
                public long GrenadeHappiness { get; set; }
                public double UrgeToChangeToBetterPosition { get; set; }
                public long FinalOptimalCombatRange { get; set; }
                public long FinalOptimalCombatRangeReachSeconds { get; set; }
                public bool CanSprint { get; set; }
                public bool AvoidFire { get; set; }
                public bool AvoidBullets { get; set; }
                public bool AvoidPoison { get; set; }
                public bool NeedFatality { get; set; }
                public PurplePrimaryWeaponStrategy PrimaryWeaponStrategy { get; set; }
            }

            public partial class TaurusSergeantEmpowered0_GameData
            {
                public PurpleYWeapon PrimaryWeapon { get; set; }
                public PurpleYWeapon HeavyWeapon { get; set; }
                public long RevivesCount { get; set; }
                public long ReviveAmount { get; set; }
                public long ReviveSpeed { get; set; }
                public long HitMultHead { get; set; }
                public long HitMultBody { get; set; }
                public double HitMultLegs { get; set; }
                public long Health { get; set; }
                public long ArmorHealth { get; set; }
                public long ArmorResistance { get; set; }
                public MovementCfg MovementCfg { get; set; }
                public FluffyResistsCfg ResistsCfg { get; set; }
            }

            public partial class TaurusShooter
            {
                public long TeamId { get; set; }
                public AllyBotAssaultClientCard ClientCard { get; set; }
                public TaurusShooterOnslaught0_GameData GameData { get; set; }
                public AllyBotInformerBotCfg BotCfg { get; set; }
            }

            public partial class TaurusShooterOnslaught0_GameData
            {
                public FriskyPrimaryWeapon PrimaryWeapon { get; set; }
                public FluffyYWeapon HeavyWeapon { get; set; }
                public long RevivesCount { get; set; }
                public long ReviveAmount { get; set; }
                public long ReviveSpeed { get; set; }
                public long HitMultHead { get; set; }
                public long HitMultBody { get; set; }
                public double HitMultLegs { get; set; }
                public long Health { get; set; }
                public long? ActionPointMax { get; set; }
                public long ArmorHealth { get; set; }
                public long ArmorResistance { get; set; }
                public MovementCfg MovementCfg { get; set; }
                public FluffyResistsCfg ResistsCfg { get; set; }
            }

            public partial class FriskyPrimaryWeapon
            {
                public long ItemType { get; set; }
                public long WeaponType { get; set; }
                public long ItemPlantingType { get; set; }
                public bool Hitscan { get; set; }
                public bool IsClipfed { get; set; }
                public bool HasOpticalSight { get; set; }
                public double BoltCycleTime { get; set; }
                public bool AutomaticFire { get; set; }
                public bool SoundAutomaticFire { get; set; }
                public long BulletsPerShot { get; set; }
                public double RateOfFire { get; set; }
                public long ClipSize { get; set; }
                public long MaxClipCount { get; set; }
                public long Damage { get; set; }
                public double HeadshotMult { get; set; }
                public double ArmorPenetration { get; set; }
                public long BulletSpeed { get; set; }
                public long MaxDistanceForBullet { get; set; }
                public long HitTargetsLimit { get; set; }
                public double SwitchInTime { get; set; }
                public double SwitchOutTime { get; set; }
                public double ReloadTime { get; set; }
                public long ReloadCombinedTime { get; set; }
                public long SpeedModOnRun { get; set; }
                public long SpeedModOnCrouch { get; set; }
                public long SpeedModOnAds { get; set; }
                public long SpeedModOnSprint { get; set; }
                public LocalCheckDirection SpreadConeMin { get; set; }
                public LocalCheckDirection SpreadConeMax { get; set; }
                public LocalCheckDirection SpreadConeMovementAdd { get; set; }
                public LocalCheckDirection SpreadIncreasePerShot { get; set; }
                public LocalCheckDirection SpreadIncreaseOnMove { get; set; }
                public LocalCheckDirection SpreadRestoreSpeed { get; set; }
                public LocalCheckDirection SpreadRestoreDelay { get; set; }
                public LocalCheckDirection ShotKickUp { get; set; }
                public LocalCheckDirection ShotKickHorizontalMean { get; set; }
                public LocalCheckDirection ShotKickHorizontalDeviation { get; set; }
                public LocalCheckDirection ShotKickRestoreDelay { get; set; }
                public LocalCheckDirection ShotKickRestoreSpeed { get; set; }
                public Dictionary<string, DamageCurve> DamageCurve { get; set; }
            }

            public partial class TaurusShooterEmpowered0
            {
                public long TeamId { get; set; }
                public AllyBotAssaultClientCard ClientCard { get; set; }
                public TaurusShooterEmpowered0_GameData GameData { get; set; }
                public AllyBotInformerBotCfg BotCfg { get; set; }
            }

            public partial class TaurusShooterEmpowered0_GameData
            {
                public PurpleAryWeapon PrimaryWeapon { get; set; }
                public FluffyYWeapon HeavyWeapon { get; set; }
                public long RevivesCount { get; set; }
                public long ReviveAmount { get; set; }
                public long ReviveSpeed { get; set; }
                public long HitMultHead { get; set; }
                public long HitMultBody { get; set; }
                public double HitMultLegs { get; set; }
                public long Health { get; set; }
                public long ActionPointMax { get; set; }
                public long ArmorHealth { get; set; }
                public long ArmorResistance { get; set; }
                public MovementCfg MovementCfg { get; set; }
                public FluffyResistsCfg ResistsCfg { get; set; }
            }

            public partial class TaurusShooterPvPvE
            {
                public long TeamId { get; set; }
                public AllyBotAssaultClientCard ClientCard { get; set; }
                public TaurusShooterPvPvEGameData GameData { get; set; }
                public AllyBotInformerBotCfg BotCfg { get; set; }
            }

            public partial class TaurusShooterPvPvEGameData
            {
                public PurplePrimaryWeapon PrimaryWeapon { get; set; }
                public FluffyYWeapon HeavyWeapon { get; set; }
                public long RevivesCount { get; set; }
                public long ReviveAmount { get; set; }
                public long ReviveSpeed { get; set; }
                public long HitMultHead { get; set; }
                public long HitMultBody { get; set; }
                public double HitMultLegs { get; set; }
                public long Health { get; set; }
                public long ArmorHealth { get; set; }
                public long ArmorResistance { get; set; }
                public MovementCfg MovementCfg { get; set; }
                public FluffyResistsCfg ResistsCfg { get; set; }
            }

            public partial class TaurusSniperEmpowered0
            {
                public long TeamId { get; set; }
                public TaurusSniperEmpowered0_ClientCard ClientCard { get; set; }
                public OnboardingSniperGameData GameData { get; set; }
                public TaurusSniperEmpowered0_BotCfg BotCfg { get; set; }
            }

            public partial class TaurusSniperEmpowered0_BotCfg
            {
                public Role Archetype { get; set; }
                public double RethinkTime { get; set; }
                public long RotationRateHorizontal { get; set; }
                public long RotationRateVertical { get; set; }
                public double StayInCoverTime { get; set; }
                public double? AttackFromCoverTime { get; set; }
                public long OptimalCombatRange { get; set; }
                public long StopDistance { get; set; }
                public long? InvestigationPriority { get; set; }
                public bool? AvoidSmokes { get; set; }
                public bool AvoidBullets { get; set; }
                public bool AvoidPoison { get; set; }
                public bool AvoidFire { get; set; }
                public double FiringTimeOnTargetLoss { get; set; }
                public double? UrgeToChangeToBetterPosition { get; set; }
                public YWeaponStrategy PrimaryWeaponStrategy { get; set; }
                public SecondaryWeaponStrategy SecondaryWeaponStrategy { get; set; }
                public CustomAbility CustomAbility { get; set; }
                public long? FinalOptimalCombatRange { get; set; }
                public long? FinalOptimalCombatRangeReachSeconds { get; set; }
                public bool? SearchReachablePath { get; set; }
                public long? PvpveKillScore { get; set; }
            }

            public partial class TaurusSniperEmpowered0_ClientCard
            {
                public Role Role { get; set; }
                public VisualEnum Visual { get; set; }
                public List<FluffyItem> Items { get; set; }
            }

            public partial class TaurusSniperPvPvE
            {
                public long TeamId { get; set; }
                public TaurusSniperEmpowered0_ClientCard ClientCard { get; set; }
                public TaurusSniperPvPvEGameData GameData { get; set; }
                public TaurusSniperWeak0_BotCfg BotCfg { get; set; }
            }

            public partial class TaurusSniperWeak0_BotCfg
            {
                public Role Archetype { get; set; }
                public double RethinkTime { get; set; }
                public long RotationRateHorizontal { get; set; }
                public long RotationRateVertical { get; set; }
                public double StayInCoverTime { get; set; }
                public long OptimalCombatRange { get; set; }
                public long StopDistance { get; set; }
                public bool AvoidPoison { get; set; }
                public bool AvoidFire { get; set; }
                public bool AvoidBullets { get; set; }
                public double FiringTimeOnTargetLoss { get; set; }
                public YWeaponStrategy PrimaryWeaponStrategy { get; set; }
                public AryWeaponStrategy SecondaryWeaponStrategy { get; set; }
                public long? PvpveKillScore { get; set; }
            }

            public partial class TaurusSniperPvPvEGameData
            {
                public PurpleAryWeapon PrimaryWeapon { get; set; }
                public FluffyAryWeapon SecondaryWeapon { get; set; }
                public long RevivesCount { get; set; }
                public long ReviveAmount { get; set; }
                public long ReviveSpeed { get; set; }
                public long HitMultHead { get; set; }
                public long HitMultBody { get; set; }
                public double HitMultLegs { get; set; }
                public long Health { get; set; }
                public long ArmorHealth { get; set; }
                public long ArmorResistance { get; set; }
                public MovementCfg MovementCfg { get; set; }
                public FluffyResistsCfg ResistsCfg { get; set; }
            }

            public partial class TaurusSniperWeak0
            {
                public long TeamId { get; set; }
                public TaurusSniperEmpowered0_ClientCard ClientCard { get; set; }
                public OnboardingSniperGameData GameData { get; set; }
                public TaurusSniperWeak0_BotCfg BotCfg { get; set; }
            }

            public partial class Ww2Assault0_Class
            {
                public long TeamId { get; set; }
                public AllyBotAssaultClientCard ClientCard { get; set; }
                public Ww2Assault0_GameData GameData { get; set; }
                public TaurusAssaultEmpowered0_BotCfg BotCfg { get; set; }
            }

            public partial class Ww2Assault0_GameData
            {
                public FluffyYWeapon PrimaryWeapon { get; set; }
                public PurpleYWeapon HeavyWeapon { get; set; }
                public long RevivesCount { get; set; }
                public long ReviveAmount { get; set; }
                public long ReviveSpeed { get; set; }
                public long HitMultHead { get; set; }
                public long HitMultBody { get; set; }
                public double HitMultLegs { get; set; }
                public long Health { get; set; }
                public long ArmorHealth { get; set; }
                public long ArmorResistance { get; set; }
                public MovementCfg MovementCfg { get; set; }
                public FluffyResistsCfg ResistsCfg { get; set; }
                public long? FatalityDelay { get; set; }
            }

            public partial class Ww2Gunner
            {
                public long TeamId { get; set; }
                public AllyBotAssaultClientCard ClientCard { get; set; }
                public ManekenEnemy0_GameData GameData { get; set; }
                public Ww2Gunner0_BotCfg BotCfg { get; set; }
            }

            public partial class Ww2Gunner0_BotCfg
            {
                public string Archetype { get; set; }
                public double RethinkTime { get; set; }
                public long RotationRateHorizontal { get; set; }
                public long RotationRateVertical { get; set; }
                public double BattleReadyAmmoClipFraction { get; set; }
                public long StayInCoverTime { get; set; }
                public long OptimalCombatRange { get; set; }
                public long AttackFromCoverTime { get; set; }
                public double GrenadeTargetingTime { get; set; }
                public long InvestigationPriority { get; set; }
                public double GrenadeHappiness { get; set; }
                public long EnemyProximityRange { get; set; }
                public bool CanSprint { get; set; }
                public bool AvoidBullets { get; set; }
                public bool AvoidSmoke { get; set; }
                public bool AvoidFire { get; set; }
                public bool SearchReachablePath { get; set; }
                public YWeaponStrategy PrimaryWeaponStrategy { get; set; }
                public long PvpveKillScore { get; set; }
                public bool? NeedFatality { get; set; }
            }

            public partial class Ww2Officer0
            {
                public long TeamId { get; set; }
                public AllyBotAssaultClientCard ClientCard { get; set; }
                public Ww2Officer0_GameData GameData { get; set; }
                public TaurusAssaultEmpowered0_BotCfg BotCfg { get; set; }
            }

            public partial class Ww2Officer0_GameData
            {
                public PurpleAryWeapon PrimaryWeapon { get; set; }
                public long RevivesCount { get; set; }
                public long ReviveAmount { get; set; }
                public long ReviveSpeed { get; set; }
                public long HitMultHead { get; set; }
                public long HitMultBody { get; set; }
                public double HitMultLegs { get; set; }
                public long Health { get; set; }
                public long ActionPointMax { get; set; }
                public long ArmorHealth { get; set; }
                public double ArmorResistance { get; set; }
                public long FatalityDelay { get; set; }
                public MovementCfg MovementCfg { get; set; }
                public PurpleResistsCfg ResistsCfg { get; set; }
                public IndigoAbilities Abilities { get; set; }
            }

            public partial class Ww2Rocketman
            {
                public long TeamId { get; set; }
                public AllyBotAssaultClientCard ClientCard { get; set; }
                public Ww2Rocketman0_GameData GameData { get; set; }
                public TaurusAssaultEmpowered0_BotCfg BotCfg { get; set; }
            }

            public partial class Ww2Rocketman0_GameData
            {
                public FluffyAryWeapon PrimaryWeapon { get; set; }
                public PurpleAryWeapon SecondaryWeapon { get; set; }
                public long RevivesCount { get; set; }
                public long ReviveAmount { get; set; }
                public long ReviveSpeed { get; set; }
                public long HitMultHead { get; set; }
                public long HitMultBody { get; set; }
                public double HitMultLegs { get; set; }
                public long Health { get; set; }
                public long ArmorHealth { get; set; }
                public double ArmorResistance { get; set; }
                public MovementCfg MovementCfg { get; set; }
                public PurpleResistsCfg ResistsCfg { get; set; }
            }

            public partial class Ww2Shooter
            {
                public long TeamId { get; set; }
                public AllyBotAssaultClientCard ClientCard { get; set; }
                public Ww2Shooter0_GameData GameData { get; set; }
                public TaurusAssaultEmpowered0_BotCfg BotCfg { get; set; }
            }

            public partial class Ww2Shooter0_GameData
            {
                public PurpleAryWeapon PrimaryWeapon { get; set; }
                public PurpleYWeapon HeavyWeapon { get; set; }
                public long RevivesCount { get; set; }
                public long ReviveAmount { get; set; }
                public long ReviveSpeed { get; set; }
                public long HitMultHead { get; set; }
                public long HitMultBody { get; set; }
                public double HitMultLegs { get; set; }
                public long Health { get; set; }
                public long ActionPointMax { get; set; }
                public long ArmorHealth { get; set; }
                public long ArmorResistance { get; set; }
                public MovementCfg MovementCfg { get; set; }
                public FluffyResistsCfg ResistsCfg { get; set; }
            }

            public partial class ZalessyeAssaultHologramClass
            {
                public long TeamId { get; set; }
                public AllyBotAssaultClientCard ClientCard { get; set; }
                public ZalessyeAssaultEmpowered0_GameData GameData { get; set; }
                public ZalessyeAssaultHologramBotCfg BotCfg { get; set; }
            }

            public partial class ZalessyeAssaultHologramBotCfg
            {
                public Role Archetype { get; set; }
                public double RethinkTime { get; set; }
                public long RotationRateHorizontal { get; set; }
                public long RotationRateVertical { get; set; }
                public double StayInCoverTime { get; set; }
                public long OptimalCombatRange { get; set; }
                public double AttackFromCoverTime { get; set; }
                public bool CanSprint { get; set; }
                public bool AvoidPoison { get; set; }
                public bool AvoidFire { get; set; }
                public bool AvoidBullets { get; set; }
                public long StopDistance { get; set; }
                public bool ShouldStopAtStopDistance { get; set; }
                public double BattleReadyAmmoClipFraction { get; set; }
                public double UrgeToChangeToBetterPosition { get; set; }
                public long FinalOptimalCombatRange { get; set; }
                public long FinalOptimalCombatRangeReachSeconds { get; set; }
                public double GrenadeTargetingTime { get; set; }
                public AryWeaponStrategy PrimaryWeaponStrategy { get; set; }
            }

            public partial class ZalessyeAssaultEmpowered0_GameData
            {
                public FluffyYWeapon PrimaryWeapon { get; set; }
                public FluffyYWeapon HeavyWeapon { get; set; }
                public long RevivesCount { get; set; }
                public long ReviveAmount { get; set; }
                public long ReviveSpeed { get; set; }
                public long HitMultHead { get; set; }
                public long HitMultBody { get; set; }
                public double HitMultLegs { get; set; }
                public long Health { get; set; }
                public long ArmorHealth { get; set; }
                public long ArmorResistance { get; set; }
                public MovementCfg MovementCfg { get; set; }
                public FluffyResistsCfg ResistsCfg { get; set; }
            }

            public partial class ZalessyeAssaultEmpowered0_Class
            {
                public long TeamId { get; set; }
                public AllyBotAssaultClientCard ClientCard { get; set; }
                public ZalessyeAssaultEmpowered0_GameData GameData { get; set; }
                public TaurusChemistOnslaught2_BotCfg BotCfg { get; set; }
            }

            public partial class ZalessyeAssaultOnslaught
            {
                public long TeamId { get; set; }
                public AllyBotAssaultClientCard ClientCard { get; set; }
                public ZalessyeAssaultEmpowered0_GameData GameData { get; set; }
                public ZalessyeAssaultOnslaught0_BotCfg BotCfg { get; set; }
            }

            public partial class ZalessyeAssaultOnslaught0_BotCfg
            {
                public Role Archetype { get; set; }
                public double RethinkTime { get; set; }
                public long RotationRateHorizontal { get; set; }
                public long RotationRateVertical { get; set; }
                public double StayInCoverTime { get; set; }
                public long OptimalCombatRange { get; set; }
                public double AttackFromCoverTime { get; set; }
                public bool CanSprint { get; set; }
                public bool AvoidPoison { get; set; }
                public bool AvoidFire { get; set; }
                public bool AvoidBullets { get; set; }
                public long StopDistance { get; set; }
                public bool ShouldStopAtStopDistance { get; set; }
                public double BattleReadyAmmoClipFraction { get; set; }
                public double UrgeToChangeToBetterPosition { get; set; }
                public long FinalOptimalCombatRange { get; set; }
                public long FinalOptimalCombatRangeReachSeconds { get; set; }
                public double GrenadeTargetingTime { get; set; }
                public bool SearchReachablePath { get; set; }
                public AryWeaponStrategy PrimaryWeaponStrategy { get; set; }
            }

            public partial class ZalessyeFighterEmpowered0
            {
                public long TeamId { get; set; }
                public AllyBotAssaultClientCard ClientCard { get; set; }
                public ZalessyeFighterEmpowered0_GameData GameData { get; set; }
                public AllyBotInformerBotCfg BotCfg { get; set; }
            }

            public partial class ZalessyeFighterEmpowered0_GameData
            {
                public PurplePrimaryWeapon PrimaryWeapon { get; set; }
                public PurpleYWeapon HeavyWeapon { get; set; }
                public long RevivesCount { get; set; }
                public long ReviveAmount { get; set; }
                public long ReviveSpeed { get; set; }
                public long HitMultHead { get; set; }
                public long HitMultBody { get; set; }
                public double HitMultLegs { get; set; }
                public long Health { get; set; }
                public long ArmorHealth { get; set; }
                public long ArmorResistance { get; set; }
                public MovementCfg MovementCfg { get; set; }
                public FluffyResistsCfg ResistsCfg { get; set; }
            }

            public partial class ZalessyeFighterPvPvE
            {
                public long TeamId { get; set; }
                public AllyBotAssaultClientCard ClientCard { get; set; }
                public TaurusFighterOnslaught0_GameData GameData { get; set; }
                public TaurusOfficerSupportBotCfg BotCfg { get; set; }
            }

            public partial class ZalessyeJuggernaut0
            {
                public long TeamId { get; set; }
                public TaurusLeaderEmpowered0_ClientCard ClientCard { get; set; }
                public ZalessyeJuggernaut0_GameData GameData { get; set; }
                public TaurusHeavyFighterOnslaughtBotCfg BotCfg { get; set; }
            }

            public partial class ZalessyeJuggernaut0_GameData
            {
                public PurplePrimaryWeapon PrimaryWeapon { get; set; }
                public long RevivesCount { get; set; }
                public long ReviveAmount { get; set; }
                public long ReviveSpeed { get; set; }
                public long ActionPointMax { get; set; }
                public long ActionPointMin { get; set; }
                public long ActionPointRegenRate { get; set; }
                public long ActionPointOffCombatRegenBonus { get; set; }
                public long HitMultHead { get; set; }
                public double HitMultBody { get; set; }
                public double HitMultLegs { get; set; }
                public long Health { get; set; }
                public long ArmorHealth { get; set; }
                public double ArmorResistance { get; set; }
                public MovementCfg MovementCfg { get; set; }
                public PurpleResistsCfg ResistsCfg { get; set; }
                public HilariousAbilities Abilities { get; set; }
                public List<TentacledPassiveAbility> PassiveAbilities { get; set; }
            }

            public partial class ZalessyeJuggernautOnslaught
            {
                public long TeamId { get; set; }
                public TaurusLeaderEmpowered0_ClientCard ClientCard { get; set; }
                public TaurusHeavyFighterOnslaughtGameData GameData { get; set; }
                public TaurusHeavyFighterOnslaughtBotCfg BotCfg { get; set; }
            }

            public partial class ZalessyeLeader
            {
                public long TeamId { get; set; }
                public TaurusLeaderEmpowered0_ClientCard ClientCard { get; set; }
                public ManekenEnemy0_GameData GameData { get; set; }
                public TaurusLeaderEmpowered0_BotCfg BotCfg { get; set; }
            }

            public partial class ZalessyeOfficerMedic
            {
                public long TeamId { get; set; }
                public AllyBotAssaultClientCard ClientCard { get; set; }
                public ZalessyeOfficerMedicGameData GameData { get; set; }
                public OnboardingOfficerMedicBotCfg BotCfg { get; set; }
            }

            public partial class ZalessyeOfficerMedicGameData
            {
                public PurpleYWeapon PrimaryWeapon { get; set; }
                public PurpleYWeapon HeavyWeapon { get; set; }
                public long ActionPointMax { get; set; }
                public long ActionPointMin { get; set; }
                public long ActionPointRegenRate { get; set; }
                public long RevivesCount { get; set; }
                public long ReviveAmount { get; set; }
                public long ReviveSpeed { get; set; }
                public long HitMultHead { get; set; }
                public long HitMultBody { get; set; }
                public double HitMultLegs { get; set; }
                public long Health { get; set; }
                public long ArmorHealth { get; set; }
                public MovementCfg MovementCfg { get; set; }
                public PurpleResistsCfg ResistsCfg { get; set; }
                public FluffyAbilities Abilities { get; set; }
            }

            public partial class ZalessyeOfficerMedicOnslaught
            {
                public long TeamId { get; set; }
                public AllyBotAssaultClientCard ClientCard { get; set; }
                public ZalessyeOfficerMedicOnslaught0_GameData GameData { get; set; }
                public OnboardingOfficerMedicBotCfg BotCfg { get; set; }
            }

            public partial class ZalessyeOfficerMedicOnslaught0_GameData
            {
                public PurpleYWeapon PrimaryWeapon { get; set; }
                public PurpleYWeapon HeavyWeapon { get; set; }
                public long ActionPointMax { get; set; }
                public long ActionPointMin { get; set; }
                public long ActionPointRegenRate { get; set; }
                public long RevivesCount { get; set; }
                public long ReviveAmount { get; set; }
                public long ReviveSpeed { get; set; }
                public long HitMultHead { get; set; }
                public long HitMultBody { get; set; }
                public double HitMultLegs { get; set; }
                public long Health { get; set; }
                public long ArmorHealth { get; set; }
                public MovementCfg MovementCfg { get; set; }
                public PurpleResistsCfg ResistsCfg { get; set; }
                public AmbitiousAbilities Abilities { get; set; }
            }

            public partial class ZalessyeRocketmanEmpowered0_Class
            {
                public long TeamId { get; set; }
                public AllyBotAssaultClientCard ClientCard { get; set; }
                public ZalessyeRocketmanEmpowered0_GameData GameData { get; set; }
                public TaurusChemistOnslaught2_BotCfg BotCfg { get; set; }
            }

            public partial class ZalessyeRocketmanEmpowered0_GameData
            {
                public MischievousPrimaryWeapon PrimaryWeapon { get; set; }
                public SecondaryWeapon SecondaryWeapon { get; set; }
                public long RevivesCount { get; set; }
                public long ReviveAmount { get; set; }
                public long ReviveSpeed { get; set; }
                public long HitMultHead { get; set; }
                public long HitMultBody { get; set; }
                public double HitMultLegs { get; set; }
                public long Health { get; set; }
                public long? ActionPointMax { get; set; }
                public long ArmorHealth { get; set; }
                public double ArmorResistance { get; set; }
                public MovementCfg MovementCfg { get; set; }
                public FluffyResistsCfg ResistsCfg { get; set; }
            }

            public partial class MischievousPrimaryWeapon
            {
                public long ItemType { get; set; }
                public long WeaponType { get; set; }
                public long ItemPlantingType { get; set; }
                public bool Hitscan { get; set; }
                public double GravityCompensation { get; set; }
                public bool IsClipfed { get; set; }
                public bool IsManuallyCycled { get; set; }
                public bool BulletsCanBeDeactivated { get; set; }
                public double BoltCycleTime { get; set; }
                public bool BurstShot { get; set; }
                public bool AutomaticFire { get; set; }
                public bool SoundAutomaticFire { get; set; }
                public long BulletsPerShot { get; set; }
                public double RateOfFire { get; set; }
                public long ClipSize { get; set; }
                public long MaxClipCount { get; set; }
                public long WeaponExplosiveSubtype { get; set; }
                public SecondaryWeaponExplosionFxType ExplosionFxType { get; set; }
                public long Damage { get; set; }
                public long DamageRadius { get; set; }
                public long DamageRadiusTrajectory { get; set; }
                public double DamageCoefOnUncovered { get; set; }
                public long HeadshotMult { get; set; }
                public double ArmorPenetration { get; set; }
                public long BulletSpeed { get; set; }
                public long MaxDistanceForBullet { get; set; }
                public long TimeToLife { get; set; }
                public bool ProjectileRebound { get; set; }
                public long HitTargetsLimit { get; set; }
                public double SwitchInTime { get; set; }
                public double SwitchOutTime { get; set; }
                public double ReloadTime { get; set; }
                public long ReloadCombinedTime { get; set; }
                public long SpeedModOnRun { get; set; }
                public long SpeedModOnCrouch { get; set; }
                public long SpeedModOnAds { get; set; }
                public long SpeedModOnSprint { get; set; }
                public LocalCheckDirection SpreadConeMin { get; set; }
                public LocalCheckDirection SpreadConeMax { get; set; }
                public LocalCheckDirection SpreadConeMovementAdd { get; set; }
                public LocalCheckDirection SpreadIncreasePerShot { get; set; }
                public LocalCheckDirection SpreadIncreaseOnMove { get; set; }
                public LocalCheckDirection SpreadRestoreSpeed { get; set; }
                public LocalCheckDirection SpreadRestoreDelay { get; set; }
                public LocalCheckDirection ShotKickUp { get; set; }
                public LocalCheckDirection ShotKickHorizontalMean { get; set; }
                public LocalCheckDirection ShotKickHorizontalDeviation { get; set; }
                public LocalCheckDirection ShotKickRestoreDelay { get; set; }
                public LocalCheckDirection ShotKickRestoreSpeed { get; set; }
                public long CombatEffectRadius { get; set; }
                public long CombatEffectTeamRule { get; set; }
                public long CombatEffectType { get; set; }
                public double CombatEffectImpactPeriodPrimary { get; set; }
                public long CombatEffectImpactValuePrimary { get; set; }
                public long CombatEffectImpactPeriodSecondary { get; set; }
                public LocalCheckDirection CombatEffectTimes { get; set; }
                public LocalCheckDirection FirePrepareTime { get; set; }
                public bool FirePrepareHold { get; set; }
                public bool IsDamageCurveIgnored { get; set; }
                public Dictionary<string, DamageCurve> DamageCurve { get; set; }
                public Ksk2011SupportFxType FxType { get; set; }
                public double FxRadius { get; set; }
            }

            public partial class ZalessyeRocketman1_Class
            {
                public long TeamId { get; set; }
                public AllyBotAssaultClientCard ClientCard { get; set; }
                public ZalessyeRocketmanOnslaught0_GameData GameData { get; set; }
                public TaurusRocketman1_BotCfg BotCfg { get; set; }
            }

            public partial class ZalessyeRocketmanOnslaught0_GameData
            {
                public BraggadociousPrimaryWeapon PrimaryWeapon { get; set; }
                public SecondaryWeapon SecondaryWeapon { get; set; }
                public long RevivesCount { get; set; }
                public long ReviveAmount { get; set; }
                public long ReviveSpeed { get; set; }
                public long HitMultHead { get; set; }
                public long HitMultBody { get; set; }
                public double HitMultLegs { get; set; }
                public long Health { get; set; }
                public long ArmorHealth { get; set; }
                public double ArmorResistance { get; set; }
                public MovementCfg MovementCfg { get; set; }
                public FluffyResistsCfg ResistsCfg { get; set; }
            }

            public partial class BraggadociousPrimaryWeapon
            {
                public long ItemType { get; set; }
                public long WeaponType { get; set; }
                public long ItemPlantingType { get; set; }
                public bool Hitscan { get; set; }
                public double GravityCompensation { get; set; }
                public bool IsClipfed { get; set; }
                public bool IsManuallyCycled { get; set; }
                public bool BulletsCanBeDeactivated { get; set; }
                public double BoltCycleTime { get; set; }
                public bool BurstShot { get; set; }
                public bool AutomaticFire { get; set; }
                public bool SoundAutomaticFire { get; set; }
                public long BulletsPerShot { get; set; }
                public double RateOfFire { get; set; }
                public long ClipSize { get; set; }
                public long MaxClipCount { get; set; }
                public long WeaponExplosiveSubtype { get; set; }
                public SecondaryWeaponExplosionFxType ExplosionFxType { get; set; }
                public bool UnlimitedClips { get; set; }
                public long Damage { get; set; }
                public long DamageRadius { get; set; }
                public long DamageRadiusTrajectory { get; set; }
                public double DamageCoefOnUncovered { get; set; }
                public long HeadshotMult { get; set; }
                public double ArmorPenetration { get; set; }
                public long BulletSpeed { get; set; }
                public long MaxDistanceForBullet { get; set; }
                public long TimeToLife { get; set; }
                public bool ProjectileRebound { get; set; }
                public long HitTargetsLimit { get; set; }
                public double SwitchInTime { get; set; }
                public double SwitchOutTime { get; set; }
                public double ReloadTime { get; set; }
                public long SpeedModOnRun { get; set; }
                public long SpeedModOnCrouch { get; set; }
                public long SpeedModOnAds { get; set; }
                public long SpeedModOnSprint { get; set; }
                public LocalCheckDirection SpreadConeMin { get; set; }
                public LocalCheckDirection SpreadConeMax { get; set; }
                public LocalCheckDirection SpreadConeMovementAdd { get; set; }
                public LocalCheckDirection SpreadIncreasePerShot { get; set; }
                public LocalCheckDirection SpreadIncreaseOnMove { get; set; }
                public LocalCheckDirection SpreadRestoreSpeed { get; set; }
                public LocalCheckDirection SpreadRestoreDelay { get; set; }
                public LocalCheckDirection ShotKickUp { get; set; }
                public LocalCheckDirection ShotKickHorizontalMean { get; set; }
                public LocalCheckDirection ShotKickHorizontalDeviation { get; set; }
                public LocalCheckDirection ShotKickRestoreDelay { get; set; }
                public LocalCheckDirection ShotKickRestoreSpeed { get; set; }
                public long CombatEffectRadius { get; set; }
                public long CombatEffectTeamRule { get; set; }
                public long CombatEffectType { get; set; }
                public double CombatEffectImpactPeriodPrimary { get; set; }
                public long CombatEffectImpactValuePrimary { get; set; }
                public long CombatEffectImpactPeriodSecondary { get; set; }
                public LocalCheckDirection CombatEffectTimes { get; set; }
                public LocalCheckDirection FirePrepareTime { get; set; }
                public bool FirePrepareHold { get; set; }
                public bool IsDamageCurveIgnored { get; set; }
                public Dictionary<string, DamageCurve> DamageCurve { get; set; }
                public Ksk2011SupportFxType FxType { get; set; }
                public double FxRadius { get; set; }
            }

            public partial class ZalessyeRocketmanOnslaught
            {
                public long TeamId { get; set; }
                public AllyBotAssaultClientCard ClientCard { get; set; }
                public ZalessyeRocketmanOnslaught0_GameData GameData { get; set; }
                public ZalessyeRocketmanOnslaught0_BotCfg BotCfg { get; set; }
            }

            public partial class ZalessyeRocketmanOnslaught0_BotCfg
            {
                public Role Archetype { get; set; }
                public double RethinkTime { get; set; }
                public long RotationRateHorizontal { get; set; }
                public long RotationRateVertical { get; set; }
                public long StayInCoverTime { get; set; }
                public long OptimalCombatRange { get; set; }
                public long StopDistance { get; set; }
                public bool CanSprint { get; set; }
                public bool AvoidSmokes { get; set; }
                public bool AvoidBullets { get; set; }
                public bool AvoidPoison { get; set; }
                public bool AvoidFire { get; set; }
                public double UrgeToChangeToBetterPosition { get; set; }
                public long FinalOptimalCombatRange { get; set; }
                public long FinalOptimalCombatRangeReachSeconds { get; set; }
                public bool SearchReachablePath { get; set; }
                public YWeaponStrategy PrimaryWeaponStrategy { get; set; }
                public YWeaponStrategy SecondaryWeaponStrategy { get; set; }
            }

            public partial class ZalessyeRocketmanOnslaughtElimination
            {
                public long TeamId { get; set; }
                public AllyBotAssaultClientCard ClientCard { get; set; }
                public ZalessyeRocketmanOnslaught0_GameData GameData { get; set; }
                public TaurusChemistOnslaught2_BotCfg BotCfg { get; set; }
            }

            public partial class ZalessyeRocketmanPvPvE
            {
                public long TeamId { get; set; }
                public AllyBotAssaultClientCard ClientCard { get; set; }
                public ZalessyeRocketmanEmpowered0_GameData GameData { get; set; }
                public TaurusAssaultEmpowered0_BotCfg BotCfg { get; set; }
            }

            public partial class ZalessyeShooter
            {
                public long TeamId { get; set; }
                public AllyBotAssaultClientCard ClientCard { get; set; }
                public ZalessyeShooterOnslaught0_GameData GameData { get; set; }
                public TaurusAssaultHologramBotCfg BotCfg { get; set; }
            }

            public partial class ZalessyeShooterOnslaught0_GameData
            {
                public PrimaryWeapon1 PrimaryWeapon { get; set; }
                public PurpleYWeapon HeavyWeapon { get; set; }
                public long RevivesCount { get; set; }
                public long ReviveAmount { get; set; }
                public long ReviveSpeed { get; set; }
                public long HitMultHead { get; set; }
                public long HitMultBody { get; set; }
                public double HitMultLegs { get; set; }
                public long Health { get; set; }
                public long ArmorHealth { get; set; }
                public long ArmorResistance { get; set; }
                public MovementCfg MovementCfg { get; set; }
                public FluffyResistsCfg ResistsCfg { get; set; }
            }

            public partial class PrimaryWeapon1
            {
                public long ItemType { get; set; }
                public long WeaponType { get; set; }
                public long ItemPlantingType { get; set; }
                public bool Hitscan { get; set; }
                public bool IsClipfed { get; set; }
                public bool HasOpticalSight { get; set; }
                public double BoltCycleTime { get; set; }
                public bool AutomaticFire { get; set; }
                public bool SoundAutomaticFire { get; set; }
                public long BulletsPerShot { get; set; }
                public long RateOfFire { get; set; }
                public long RateOfBurst { get; set; }
                public long BurstShotValue { get; set; }
                public long ClipSize { get; set; }
                public long MaxClipCount { get; set; }
                public long Damage { get; set; }
                public double HeadshotMult { get; set; }
                public double ArmorPenetration { get; set; }
                public long BulletSpeed { get; set; }
                public long MaxDistanceForBullet { get; set; }
                public long HitTargetsLimit { get; set; }
                public double SwitchInTime { get; set; }
                public double SwitchOutTime { get; set; }
                public double ReloadTime { get; set; }
                public long ReloadCombinedTime { get; set; }
                public long SpeedModOnRun { get; set; }
                public long SpeedModOnCrouch { get; set; }
                public long SpeedModOnAds { get; set; }
                public long SpeedModOnSprint { get; set; }
                public LocalCheckDirection SpreadConeMin { get; set; }
                public LocalCheckDirection SpreadConeMax { get; set; }
                public LocalCheckDirection SpreadConeMovementAdd { get; set; }
                public LocalCheckDirection SpreadIncreasePerShot { get; set; }
                public LocalCheckDirection SpreadIncreaseOnMove { get; set; }
                public LocalCheckDirection SpreadRestoreSpeed { get; set; }
                public LocalCheckDirection SpreadRestoreDelay { get; set; }
                public LocalCheckDirection ShotKickUp { get; set; }
                public LocalCheckDirection ShotKickHorizontalMean { get; set; }
                public LocalCheckDirection ShotKickHorizontalDeviation { get; set; }
                public LocalCheckDirection ShotKickRestoreDelay { get; set; }
                public LocalCheckDirection ShotKickRestoreSpeed { get; set; }
                public Dictionary<string, DamageCurve> DamageCurve { get; set; }
            }

            public partial class ZalessyeShooterEmpowered0
            {
                public long TeamId { get; set; }
                public AllyBotAssaultClientCard ClientCard { get; set; }
                public TaurusFighterWeak0_GameData GameData { get; set; }
                public TaurusAssaultHologramBotCfg BotCfg { get; set; }
            }

            public partial class CardLevel
            {
                public LevelType LevelType { get; set; }
                public long Xp { get; set; }
                public Unlock Unlock { get; set; }
            }

            public partial class Unlock
            {
                public List<string> Upgrades { get; set; }
                public List<string> ShopItems { get; set; }
            }

            public partial class CardPresetConfigs
            {
                public PresetCard PresetCardSeal2014A { get; set; }
                public PresetCard PresetCardKsk2011G { get; set; }
                public PresetCardFsb2004M PresetCardFsb2004M { get; set; }
                public PresetCardGrom2014S PresetCardGrom2014S { get; set; }
            }

            public partial class PresetCardFsb2004M
            {
                public bool EnabledInGame { get; set; }
                public BaseAvailableCard CardId { get; set; }
                public long Level { get; set; }
                public List<string> Unlocks { get; set; }
                public PresetCardFsb2004MConsumablesCount ConsumablesCount { get; set; }
                public string ConsumableOne { get; set; }
                public string ConsumableTwo { get; set; }
            }

            public partial class PresetCardFsb2004MConsumablesCount
            {
                public long SpecialRevive { get; set; }
                public long AmmoPack { get; set; }
            }

            public partial class PresetCardGrom2014S
            {
                public bool EnabledInGame { get; set; }
                public BaseAvailableCard CardId { get; set; }
                public long Level { get; set; }
                public List<string> Unlocks { get; set; }
                public PresetCardGrom2014SConsumablesCount ConsumablesCount { get; set; }
                public string ConsumableOne { get; set; }
                public string ConsumableTwo { get; set; }
            }

            public partial class PresetCardGrom2014SConsumablesCount
            {
                public long HealthPack { get; set; }
                public long ArmorPack { get; set; }
            }

            public partial class PresetCard
            {
                public bool EnabledInGame { get; set; }
                public BaseAvailableCard CardId { get; set; }
                public long Level { get; set; }
                public List<string> Unlocks { get; set; }
                public PresetCardKsk2011GConsumablesCount ConsumablesCount { get; set; }
                public string ConsumableOne { get; set; }
                public string ConsumableTwo { get; set; }
            }

            public partial class PresetCardKsk2011GConsumablesCount
            {
                public long StaminaRegenBooster { get; set; }
                public long ArmorPack { get; set; }
            }

            public partial class CharacterCard
            {
                public BaseAvailableCard CfgId { get; set; }
                public string Collection { get; set; }
                public Classes Role { get; set; }
                public FarmerBonus FarmerBonus { get; set; }
                public bool HasFarmerBonus { get; set; }
                public long CardType { get; set; }
                public long OwnedUnlocksCount { get; set; }
                public List<AbilityElement> Abilities { get; set; }
                public List<CharacterCardItem> Items { get; set; }
                public long ItemsCount { get; set; }
                public List<Perk> Perks { get; set; }
                public MajorLevelsXp MajorLevelsXp { get; set; }
                public List<object> OwnedSkinGroups { get; set; }
                public MultiplyClass EnabledSkinGroups { get; set; }
                public CharacterCardCustomAnims CustomAnims { get; set; }
                public List<object> MarkedEntities { get; set; }
                public MultiplyClass QuartersTechnologies { get; set; }
                public QuartersTechnologiesPrice QuartersTechnologiesPrice { get; set; }
                public long TotalExperience { get; set; }
                public int Id { get; set; }
                public bool Owned { get; set; }
                public bool Active { get; set; }
                public long Experience { get; set; }
                public long LockedExperience { get; set; }
                public bool IsUpgradable { get; set; }
                public bool IsLocked { get; set; }
                public string Visual { get; set; }
                public List<UiDatum> UiData { get; set; }
            }

            public partial class AbilityElement
            {
                public string Id { get; set; }
                public string Visual { get; set; }
                public AbilitySlot Slot { get; set; }
                public bool Unlocked { get; set; }
                public List<Perk> Upgrades { get; set; }
                public List<UiDatum> UiData { get; set; }
            }

            public partial class UiDatum
            {
                public long Type { get; set; }
                public string Name { get; set; }
                public string Value { get; set; }
                public long Min { get; set; }
                public long Max { get; set; }
                public double Current { get; set; }
            }

            public partial class Perk
            {
                public string Id { get; set; }
                public long Index { get; set; }
                public long XpCost { get; set; }
                public Price Cost { get; set; }
                public string Visual { get; set; }
                public bool WorkInProgress { get; set; }
                public bool Uninstallable { get; set; }
                public bool UninstallWhenDie { get; set; }
                public SlotElement Type { get; set; }
                public SoundUpgrade SoundUpgrade { get; set; }
                public Attachment AttachmentId { get; set; }
                public SlotElement UnlockableSlot { get; set; }
                public List<UiDatum> UiData { get; set; }
                public bool Unlocked { get; set; }
                public bool Enabled { get; set; }
                public string LocalesKey { get; set; }
                public string ModuleType { get; set; }
                public TypeLocalesKey? TypeLocalesKey { get; set; }
            }

            public partial class Price
            {
                public ResourseValue Values { get; set; }
            }

            public partial class CharacterCardCustomAnims
            {
                public KillingBlowClass Greeting { get; set; }
                public KillingBlowClass KillingBlow { get; set; }
            }

            public partial class KillingBlowClass
            {
                public List<object> ActiveAnimations { get; set; }
                public List<object> AvaiableAnimations { get; set; }
            }

            public partial class FarmerBonus
            {
                public long Soft { get; set; }
                public long Xp { get; set; }
            }

            public partial class CharacterCardItem
            {
                public SlotElement Slot { get; set; }
                public string CfgId { get; set; }
                public SkinVisualEnum? SkinVisual { get; set; }
                public ItemSpeciality ItemType { get; set; }
                public bool Unlocked { get; set; }
                public string Visual { get; set; }
                public long Id { get; set; }
                public List<UiDatum> UiData { get; set; }
                public List<Perk> Upgrades { get; set; }
                public SlotElement? LinkedVisualSlot { get; set; }
                public string LocalesKey { get; set; }
            }

            public partial class MajorLevelsXp
            {
                public long? Elite { get; set; }
                public long? Master { get; set; }
            }

            public partial class QuartersTechnologiesPrice
            {
                public AmmunitionClass Physical { get; set; }
                public AmmunitionClass Protective { get; set; }
                public AmmunitionClass Ammunition { get; set; }
                public AmmunitionClass Tactical { get; set; }
            }

            public partial class AmmunitionClass
            {
                public AmmunitionValues Values { get; set; }
            }

            public partial class AmmunitionValues
            {
                public long FreeXp { get; set; }
            }

            public partial class Collection
            {
                public bool EnabledInGame { get; set; }
                public string Visual { get; set; }
                public List<BaseAvailableCard> Cards { get; set; }
                public long LockedXpLimit { get; set; }
                public FreeXpPercent FreeXpPercent { get; set; }
            }

            public partial class FreeXpPercent
            {
                public long Regular { get; set; }
                public long Premium { get; set; }
                public long Elite { get; set; }
                public long Master { get; set; }
            }

            public partial class ConsumableConfigs
            {
                public AmmoPack StaminaRegenBooster { get; set; }
                public Pack HealthPack { get; set; }
                public AmmoPack SpecialRevive { get; set; }
                public AmmoPack SpecialReviveV2 { get; set; }
                public AmmoPack DefendPointsBooster { get; set; }
                public Pack ArmorPack { get; set; }
                public AmmoPack AmmoPack { get; set; }
                public AmmoPack RandomBonus { get; set; }
                public AmmoPack PerkTierUpgrade { get; set; }
            }

            public partial class AmmoPack
            {
                public string ConsumableType { get; set; }
                public List<string> CompatibleSlots { get; set; }
                public string CurrencyId { get; set; }
                public List<string> RestrictedCollections { get; set; }
                public AmmoPackDefault Default { get; set; }
                public string Slot { get; set; }
                public List<string> AllowedCollections { get; set; }
            }

            public partial class AmmoPackDefault
            {
                public bool EnabledInGame { get; set; }
                public string Visual { get; set; }
                public SlotElement? DropItem { get; set; }
                public string Slot { get; set; }
                public ItemSpeciality Speciality { get; set; }
                public SlotElement ExplosiveWeaponSubtype { get; set; }
                public ItemTypeEnum ItemType { get; set; }
                public StrategyType StrategyType { get; set; }
                public List<object> Upgrades { get; set; }
                public List<string> PassiveAbilities { get; set; }
                public Modifiers59 Modifiers { get; set; }
            }

            public partial class Modifiers59
            {
                public Dictionary<string, long> Additive { get; set; }
                public MultiplyClass Multiply { get; set; }
                public MultiplyClass Curves { get; set; }
                public MultiplyClass Reference { get; set; }
                public MultiplyClass Ui { get; set; }
            }

            public partial class Pack
            {
                public string ConsumableType { get; set; }
                public List<string> CompatibleSlots { get; set; }
                public string CurrencyId { get; set; }
                public List<string> RestrictedCollections { get; set; }
                public AmmoPackDefault Default { get; set; }
                public string Slot { get; set; }
            }

            public partial class ConsumableSlots
            {
                public List<long> StaminaRegenBooster { get; set; }
                public List<long> HealthPack { get; set; }
                public List<long> SpecialRevive { get; set; }
                public List<long> SpecialReviveV2 { get; set; }
                public List<long> DefendPointsBooster { get; set; }
                public List<long> ArmorPack { get; set; }
                public List<long> AmmoPack { get; set; }
                public List<long> RandomBonus { get; set; }
                public List<long> PerkTierUpgrade { get; set; }
            }

            public partial class Currencies
            {
                public Archive3Token Sc { get; set; }
                public Archive3Token Hc { get; set; }
                public Archive3Token Tokens { get; set; }
                public Archive3Token Tickets { get; set; }
                public Archive3Token FreeXp { get; set; }
                public Archive3Token CmT1Component { get; set; }
                public Archive3Token CmT1Medicine { get; set; }
                public Archive3Token CmT1Alloy { get; set; }
                public Archive3Token CmT1Fuel { get; set; }
                public Archive3Token CmT2Composite { get; set; }
                public Archive3Token CmT2Chemistry { get; set; }
                public Archive3Token CmT2Encryption { get; set; }
                public Archive3Token CmT3Microchip { get; set; }
                public Archive3Token CmT3Blueprint { get; set; }
                public Archive3Token CmT4Secretdev { get; set; }
                public Archive3Token XpBooster { get; set; }
                public Archive3Token CreditsBooster { get; set; }
                public Archive3Token DemoTokens { get; set; }
                public Archive3Token StaminaRegenBooster { get; set; }
                public Archive3Token HealthPack { get; set; }
                public Archive3Token SpecialRevive { get; set; }
                public May2022Token SpecialReviveV2 { get; set; }
                public Archive3Token AmmoPack { get; set; }
                public Archive3Token ArmorPack { get; set; }
                public May2022Token RandomBonus { get; set; }
                public May2022Token PerkTierUpgrade { get; set; }
                public May2022Token DefendPointsBooster { get; set; }
                public Archive3Token Thematic1Tokens { get; set; }
                public Archive3Token Thematic2Tokens { get; set; }
                public Archive3Token Feb23Token { get; set; }
                public Archive3Token Hacking2021Token { get; set; }
                public Archive3Token Hacking2021Ticket { get; set; }
                public Archive3Token Archive3Token { get; set; }
                public Archive3Token RankedToken { get; set; }
                public Archive3Token Front2021Token { get; set; }
                public Archive3Token Front2021Ticket { get; set; }
                public Archive3Token Onslaught2021Ticket { get; set; }
                public Archive3Token Onslaught2021Token { get; set; }
                public Archive3Token NewYear2022Token { get; set; }
                public Archive3Token Archive4Token { get; set; }
                public Archive3Token RefundToken { get; set; }
                public Archive3Token NewYear2022Key { get; set; }
                public Archive3Token Intercept2022Ticket { get; set; }
                public Archive3Token Intercept2022Token { get; set; }
                public Archive3Token Feb232022_Token { get; set; }
                public May2022Token May2022Token { get; set; }
            }

            public partial class Archive3Token
            {
                public bool EnabledInGame { get; set; }
                public Group Group { get; set; }
                public string Visual { get; set; }
                public long Order { get; set; }
                public bool NeedConfirmation { get; set; }
                public bool ShowInTokenExchangeWindow { get; set; }
                public DateTimeOffset? StartDate { get; set; }
                public DateTimeOffset? EndDate { get; set; }
                public List<string> Accesses { get; set; }
                public string ShortageScreenName { get; set; }
            }

            public partial class May2022Token
            {
                public bool EnabledInGame { get; set; }
                public Group Group { get; set; }
                public string Visual { get; set; }
                public long Order { get; set; }
                public bool NeedConfirmation { get; set; }
                public bool ShowInTokenExchangeWindow { get; set; }
                public bool ConvertAfterEndDate { get; set; }
                public double ConvertRate { get; set; }
                public string ConvertCurrency { get; set; }
                public DateTimeOffset StartDate { get; set; }
                public DateTimeOffset EndDate { get; set; }
            }

            public partial class CustomAnimation
            {
                public string Id { get; set; }
                public string Visual { get; set; }
                public long Type { get; set; }
                public List<BaseAvailableCard> CompatibleCards { get; set; }
            }

            public partial class DropItemConfigs
            {
                public Fsb2016SniperMine Fsb2016SniperMine { get; set; }
                public Sso2013AssaultMine Sso2013AssaultMine { get; set; }
                public Ksk2011SniperMine Ksk2011SniperMine { get; set; }
                public Seal2014ClaymoreMine Seal2014ClaymoreMine { get; set; }
                public Sso2013Airstrike Sso2013Airstrike { get; set; }
                public Seal2014Support40Mm Seal2014Support40Mm { get; set; }
                public Grom2014MedicMedkit Grom2014MedicMedkit { get; set; }
                public Sso2013GunnerDrone Sso2013GunnerDrone { get; set; }
                public Ksk2011MedicMedkit Ksk2011MedicMedkit { get; set; }
                public Seal2014MedicMedkit Seal2014MedicMedkit { get; set; }
                public Ksk2011Assault40Mm Ksk2011Assault40Mm { get; set; }
                public The22Spn2016SupportStandart The22Spn2016SupportStandart { get; set; }
                public Seal2014AssaultC4 Seal2014AssaultC4 { get; set; }
                public The22Spn2016GSupportMine The22Spn2016GSupportMine { get; set; }
                public Tfb2008MedicBandolier Tfb2008MedicBandolier { get; set; }
                public Tfb2008MedicLaserClaymore Tfb2008MedicLaserClaymore { get; set; }
                public The22Spn2016MedicMedkit The22Spn2016MedicMedkit { get; set; }
                public Tfb2008SniperMccm Tfb2008SniperMccm { get; set; }
                public Tfb2008SupportScrambler Tfb2008SupportScrambler { get; set; }
                public Grom2014Support40Mm Grom2014Support40Mm { get; set; }
                public The22Spn2016AssaultLure The22Spn2016AssaultLure { get; set; }
                public Seal2014SniperFlare Seal2014SniperFlare { get; set; }
                public The22_Spn2016MedicRop The22Spn2016MedicRop { get; set; }
                public Raid2017SniperDrone Raid2017SniperDrone { get; set; }
                public Raid2017MedicMedkit Raid2017MedicMedkit { get; set; }
                public Nesher2015SupportTurret Nesher2015SupportTurret { get; set; }
                public Nesher2015Tugs Nesher2015Tugs { get; set; }
                public Nesher2015MedicAmmoBag Nesher2015MedicAmmoBag { get; set; }
                public Nesher2015MedicHeavyAmmoBag Nesher2015MedicHeavyAmmoBag { get; set; }
                public EzapacMedicDrone EzapacMedicDrone { get; set; }
                public EzapacSupportShield EzapacSupportShield { get; set; }
                public EzapacSupportShieldWrongPlaced EzapacSupportShieldWrongPlaced { get; set; }
                public EzapacAssaultMine EzapacAssaultMine { get; set; }
                public EzapacAssaultFlare EzapacAssaultFlare { get; set; }
                public ArystanScrambler ArystanScrambler { get; set; }
                public ArystanMedic40Mm ArystanMedic40Mm { get; set; }
                public ArystanMedicAps ArystanMedicAps { get; set; }
                public The22_Spn2016MedicRop BelssoAssaultSmoke { get; set; }
                public AmfaAxe AmfaAxe { get; set; }
                public AmfsDrone AmfsDrone { get; set; }
                public Eleron Eleron { get; set; }
                public Ww2MedicStandart Ww2MedicStandart { get; set; }
                public Ww2SupportBarbedWire Ww2SupportBarbedWire { get; set; }
            }

            public partial class AmfaAxe
            {
                public TypeElement Type { get; set; }
                public string IconType { get; set; }
                public DisplayMarkerTeamRuleEnum DisplayMarkerTeamRule { get; set; }
                public string VisualModel { get; set; }
                public FxTypeEnum FxType { get; set; }
                public double FxRadius { get; set; }
                public string DestructionSoundFxType { get; set; }
                public string Health { get; set; }
                public string Duration { get; set; }
                public string ChargeDistribution { get; set; }
                public bool Destructible { get; set; }
                public The22Spn2016GSupportMineAuraConfig AuraConfig { get; set; }
                public List<AmfaAxeAuraBuffGroup> AuraBuffGroups { get; set; }
                public AmfaAxeMetaData MetaData { get; set; }
            }

            public partial class AmfaAxeAuraBuffGroup
            {
                public AuraBuffGroupTargetSelectionTime TargetSelectionTime { get; set; }
                public PurpleRule Rule { get; set; }
                public List<Buff63> Buffs { get; set; }
            }

            public partial class Buff63
            {
                public string Name { get; set; }
                public long Priority { get; set; }
                public double Duration { get; set; }
                public long WpnRefillHeavy { get; set; }
                public long RebuffStack { get; set; }
            }

            public partial class The22Spn2016GSupportMineAuraConfig
            {
                public AuraConfigTeamRule TeamRule { get; set; }
                public TriggerType TriggerType { get; set; }
                public double Radius { get; set; }
                public double? UpdatePeriod { get; set; }
                public bool? Collision { get; set; }
                public double? Angle { get; set; }
                public bool? IgnoreHeightCheck { get; set; }
            }

            public partial class AmfaAxeMetaData
            {
                public List<object> Upgrades { get; set; }
                public MultiplyClass Modifiers { get; set; }
            }

            public partial class AmfsDrone
            {
                public string Type { get; set; }
                public string IconType { get; set; }
                public DisplayMarkerTeamRuleEnum DisplayMarkerTeamRule { get; set; }
                public string VisualModel { get; set; }
                public string DestructionSoundFxType { get; set; }
                public string Health { get; set; }
                public long Duration { get; set; }
                public bool Destructible { get; set; }
                public bool ExplodeOnDamage { get; set; }
                public bool CanBeRemovedByBuff { get; set; }
                public ExplosionFxTypeEnum ExplosionFxType { get; set; }
                public double TakingOffDuration { get; set; }
                public long TakingOffFlySpeed { get; set; }
                public double LookingForTargetFlySpeed { get; set; }
                public string TargetLockedFlySpeed { get; set; }
                public long DamageRadius { get; set; }
                public long Damage { get; set; }
                public double ArmorPenetration { get; set; }
                public Dictionary<string, DamageCurve> DamageCurve { get; set; }
                public AmfsDroneAuraConfig AuraConfig { get; set; }
                public List<AmfsDroneAuraBuffGroup> AuraBuffGroups { get; set; }
                public AmfsDroneMetaData MetaData { get; set; }
            }

            public partial class AmfsDroneAuraBuffGroup
            {
                public AuraBuffGroupTargetSelectionTime TargetSelectionTime { get; set; }
                public DeactivatedEntitiesOwnersRuleElement Rule { get; set; }
                public List<BraggadociousBuff> Buffs { get; set; }
            }

            public partial class AmfsDroneAuraConfig
            {
                public AuraConfigTeamRule TeamRule { get; set; }
                public double UpdatePeriod { get; set; }
                public long Angle { get; set; }
                public long Radius { get; set; }
                public TriggerTypeEnum TriggerType { get; set; }
                public bool Collision { get; set; }
                public LocalCheckDirection LocalCheckDirection { get; set; }
            }

            public partial class AmfsDroneMetaData
            {
                public List<object> Upgrades { get; set; }
                public Modifiers61 Modifiers { get; set; }
            }

            public partial class Modifiers61
            {
                public Additive43 Additive { get; set; }
            }

            public partial class Additive43
            {
                public long AmfsDroneHealth { get; set; }
                public long AmfsDroneLockedFlySpeed { get; set; }
            }

            public partial class ArystanMedic40Mm
            {
                public TypeElement Type { get; set; }
                public string IconType { get; set; }
                public bool HideUnseenMarkerFromEnemy { get; set; }
                public string VisualModel { get; set; }
                public string FxType { get; set; }
                public string FxRadius { get; set; }
                public long ActivationDelay { get; set; }
                public string Duration { get; set; }
                public The22Spn2016SupportStandartAuraConfig AuraConfig { get; set; }
                public List<ArystanMedic40MmAuraBuffGroup> AuraBuffGroups { get; set; }
            }

            public partial class ArystanMedic40MmAuraBuffGroup
            {
                public AuraBuffGroupTargetSelectionTime TargetSelectionTime { get; set; }
                public HilariousRule Rule { get; set; }
                public List<IndecentBuff> Buffs { get; set; }
            }

            public partial class The22Spn2016SupportStandartAuraConfig
            {
                public string TeamRule { get; set; }
                public string Radius { get; set; }
                public string UpdatePeriod { get; set; }
                public TriggerType TriggerType { get; set; }
                public bool? IgnoreHeightCheck { get; set; }
                public string ChargeDistribution { get; set; }
            }

            public partial class ArystanMedicAps
            {
                public TypeElement Type { get; set; }
                public string IconType { get; set; }
                public DisplayMarkerTeamRuleEnum DisplayMarkerTeamRule { get; set; }
                public string MessageType { get; set; }
                public string VisualModel { get; set; }
                public FxTypeEnum FxType { get; set; }
                public bool CanBePickedUp { get; set; }
                public string DestructionSoundFxType { get; set; }
                public bool CanBeRemovedByBuff { get; set; }
                public double FxRadius { get; set; }
                public string Health { get; set; }
                public string ChargeDistribution { get; set; }
                public string Duration { get; set; }
                public long ProjectilesExplodingRadius { get; set; }
                public string DeactivatingFxType { get; set; }
                public string DeactivatingSelfFxType { get; set; }
                public string DeactivatingSfxType { get; set; }
                public long HeatMin { get; set; }
                public DeactivatedEntitiesOwnersRuleElement DeactivatedEntitiesOwnersRule { get; set; }
                public List<DeactivatedEntitiesOwnersBuffElement> DeactivatedEntitiesOwnersBuffs { get; set; }
                public ArystanMedicApsMetaData MetaData { get; set; }
            }

            public partial class ArystanMedicApsMetaData
            {
                public List<object> Upgrades { get; set; }
                public Modifiers62 Modifiers { get; set; }
            }

            public partial class Modifiers62
            {
                public Additive44 Additive { get; set; }
            }

            public partial class Additive44
            {
                public long ArystanMeidcApsLifetime { get; set; }
                public long ArystanMeidcApsRadius { get; set; }
                public long ArystanMeidcApsHealth { get; set; }
                public double ArystanMeidcApsEffectDuration { get; set; }
            }

            public partial class ArystanScrambler
            {
                public TypeElement Type { get; set; }
                public string IconType { get; set; }
                public DisplayMarkerTeamRuleEnum DisplayMarkerTeamRule { get; set; }
                public string MessageType { get; set; }
                public string VisualModel { get; set; }
                public FxTypeEnum FxType { get; set; }
                public bool CanBePickedUp { get; set; }
                public string DestructionSoundFxType { get; set; }
                public bool CanBeRemovedByBuff { get; set; }
                public string FxRadius { get; set; }
                public string Health { get; set; }
                public string ChargeDistribution { get; set; }
                public string Duration { get; set; }
                public The22Spn2016MedicMedkitAuraConfig AuraConfig { get; set; }
                public List<ArystanScramblerAuraBuffGroup> AuraBuffGroups { get; set; }
                public ArystanScramblerMetaData MetaData { get; set; }
            }

            public partial class ArystanScramblerAuraBuffGroup
            {
                public AuraBuffGroupTargetSelectionTime TargetSelectionTime { get; set; }
                public SelfSuccessGroupRule Rule { get; set; }
                public List<Buff64> Buffs { get; set; }
            }

            public partial class Buff64
            {
                public string Name { get; set; }
                public long Priority { get; set; }
                public List<string> Categories { get; set; }
                public List<BuffImmuneAbsoluteAdd> BuffImmuneAbsoluteAdd { get; set; }
                public string Duration { get; set; }
                public bool Rebuff { get; set; }
                public bool Invisible { get; set; }
                public long Heat { get; set; }
                public long HeatMax { get; set; }
                public long HeatMin { get; set; }
            }

            public partial class The22Spn2016MedicMedkitAuraConfig
            {
                public AuraConfigTeamRule TeamRule { get; set; }
                public string Radius { get; set; }
                public double UpdatePeriod { get; set; }
                public TriggerType TriggerType { get; set; }
                public bool? IgnoreHeightCheck { get; set; }
            }

            public partial class ArystanScramblerMetaData
            {
                public List<object> Upgrades { get; set; }
                public Modifiers63 Modifiers { get; set; }
            }

            public partial class Modifiers63
            {
                public Additive45 Additive { get; set; }
            }

            public partial class Additive45
            {
                public long ArystanScramblerLifetime { get; set; }
                public double ArystanScramblerRadius { get; set; }
                public long ArystanScramblerHealth { get; set; }
                public double ArystanScramblerEffectDuration { get; set; }
            }

            public partial class The22_Spn2016MedicRop
            {
                public TypeElement Type { get; set; }
                public IconType IconType { get; set; }
                public string VisualModel { get; set; }
                public long FxRadius { get; set; }
                public double ActivationDelay { get; set; }
                public bool? ActivationDelayOverridable { get; set; }
                public long Duration { get; set; }
                public long SmokeRadius { get; set; }
                public long SmokeExpand { get; set; }
                public double SmokeSteady { get; set; }
                public double SmokeShrink { get; set; }
                public Fsb2016MedicPassiveMetaData MetaData { get; set; }
                public FxTypeEnum? FxType { get; set; }
                public long? Health { get; set; }
            }

            public partial class Eleron
            {
                public string Type { get; set; }
                public string IconType { get; set; }
                public DisplayMarkerTeamRuleEnum DisplayMarkerTeamRule { get; set; }
                public string VisualModel { get; set; }
                public string DestructionSoundFxType { get; set; }
                public long Health { get; set; }
                public long Duration { get; set; }
                public bool Destructible { get; set; }
                public bool ExplodeOnDamage { get; set; }
                public ExplosionFxTypeEnum ExplosionFxType { get; set; }
                public long DamageRadius { get; set; }
                public long Damage { get; set; }
                public double ArmorPenetration { get; set; }
                public Dictionary<string, DamageCurve> DamageCurve { get; set; }
                public AmfsDroneAuraConfig AuraConfig { get; set; }
                public List<Nesher2015SupportGroup> AuraBuffGroups { get; set; }
                public AmfaAxeMetaData MetaData { get; set; }
            }

            public partial class EzapacAssaultFlare
            {
                public string Type { get; set; }
                public string IconType { get; set; }
                public string MessageType { get; set; }
                public DisplayMarkerTeamRuleEnum DisplayMarkerTeamRule { get; set; }
                public string VisualModel { get; set; }
                public FxTypeEnum FxType { get; set; }
                public long ActivationDelay { get; set; }
                public long Duration { get; set; }
                public double FreeFallGravityCompensation { get; set; }
                public bool CanBeAppliedInstantly { get; set; }
                public bool CanWorkWhileNotSnapped { get; set; }
                public EzapacAssaultFlareAuraConfig AuraConfig { get; set; }
                public List<EzapacMedicPrimaryPassiveGroup> AuraBuffGroups { get; set; }
                public List<CreatorBuffsByAffectingAura> CreatorBuffsByAffectingAura { get; set; }
                public Fsb2016MedicPassiveMetaData MetaData { get; set; }
            }

            public partial class EzapacAssaultFlareAuraConfig
            {
                public AuraConfigTeamRule TeamRule { get; set; }
                public string TriggerType { get; set; }
                public long Angle { get; set; }
                public string Radius { get; set; }
                public double UpdatePeriod { get; set; }
                public bool Collision { get; set; }
                public LocalCheckDirection CheckDirection { get; set; }
            }

            public partial class CreatorBuffsByAffectingAura
            {
                public CreatorBuffsByAffectingAuraName Name { get; set; }
                public long Priority { get; set; }
                public List<BuffImmuneAddElement> Categories { get; set; }
                public bool StackableName { get; set; }
                public long MaxStackCount { get; set; }
                public CreatorBuffsByAffectingAuraIncomingDamageMod IncomingDamageMod { get; set; }
                public string Duration { get; set; }
            }

            public partial class EzapacAssaultMine
            {
                public IconType Type { get; set; }
                public IconType IconType { get; set; }
                public bool HideUnseenMarkerFromEnemy { get; set; }
                public ExplosionFxTypeEnum MessageType { get; set; }
                public string VisualModel { get; set; }
                public Ksk2011SupportFxType FxType { get; set; }
                public long FxRadius { get; set; }
                public bool ExplodeOnDamage { get; set; }
                public bool CanBeRemovedByBuff { get; set; }
                public ExplosionFxTypeEnum ExplosionFxType { get; set; }
                public bool Attachable { get; set; }
                public long DamageRadius { get; set; }
                public long Damage { get; set; }
                public Dictionary<string, DamageCurve> DamageCurve { get; set; }
                public double ActivationDelay { get; set; }
                public double ActionDelay { get; set; }
                public bool CanBePickedUp { get; set; }
                public double ArmorPenetration { get; set; }
                public long Duration { get; set; }
                public long Health { get; set; }
                public The22Spn2016GSupportMineAuraConfig AuraConfig { get; set; }
                public List<The22Spn2016GSupportMineAuraBuffGroup> AuraBuffGroups { get; set; }
                public Fsb2016MedicPassiveMetaData MetaData { get; set; }
            }

            public partial class The22Spn2016GSupportMineAuraBuffGroup
            {
                public string TargetSelectionTime { get; set; }
                public DeactivatedEntitiesOwnersRuleElement Rule { get; set; }
                public List<Buff62> Buffs { get; set; }
            }

            public partial class Buff62
            {
                public NameEnum Name { get; set; }
                public long Priority { get; set; }
                public List<BuffImmuneAddElement> Categories { get; set; }
                public bool SprintLock { get; set; }
                public long Duration { get; set; }
            }

            public partial class EzapacMedicDrone
            {
                public TypeElement Type { get; set; }
                public string VisualModel { get; set; }
                public TypeElement MessageType { get; set; }
                public bool HideUnseenMarkerFromEnemy { get; set; }
                public long Speed { get; set; }
                public double MinSpeed { get; set; }
                public long Acceleration { get; set; }
                public long Deceleration { get; set; }
                public long DecelerationDistance { get; set; }
                public long RotationSpeed { get; set; }
                public string Health { get; set; }
                public long ActivationDelay { get; set; }
                public double OwnerFollowRadius { get; set; }
                public bool StopAbilityOnDestroy { get; set; }
                public double IdleDuration { get; set; }
                public string Duration { get; set; }
                public long SearchRadius { get; set; }
                public double EffectiveRadius { get; set; }
                public double SafetyRadius { get; set; }
                public bool CanInvestigate { get; set; }
                public bool CanChooseAffectedTarget { get; set; }
                public long TargetFollowDuration { get; set; }
                public ExplosionFxTypeEnum ExplosionFxType { get; set; }
                public long ArmorPenetration { get; set; }
                public double Height { get; set; }
                public long RiseSpeed { get; set; }
                public bool CanBeRemovedByBuff { get; set; }
                public EzapacMedicDroneAuraConfig AuraConfig { get; set; }
                public List<EzapacMedicDroneAuraBuffGroup> AuraBuffGroups { get; set; }
            }

            public partial class EzapacMedicDroneAuraBuffGroup
            {
                public AuraBuffGroupTargetSelectionTime TargetSelectionTime { get; set; }
                public Rule2 Rule { get; set; }
                public List<Buff41> Buffs { get; set; }
            }

            public partial class Rule2
            {
                public PurpleType Type { get; set; }
                public string Select { get; set; }
                public List<SelfSuccessGroupRule> ChildRules { get; set; }
            }

            public partial class EzapacMedicDroneAuraConfig
            {
                public AuraConfigTeamRule TeamRule { get; set; }
                public long Radius { get; set; }
                public string UpdatePeriod { get; set; }
                public TriggerType TriggerType { get; set; }
                public bool Collision { get; set; }
                public bool IgnoreHeightCheck { get; set; }
            }

            public partial class EzapacSupportShield
            {
                public TypeElement Type { get; set; }
                public DisplayMarkerTeamRuleEnum DisplayMarkerTeamRule { get; set; }
                public string VisualModel { get; set; }
                public string DestructionSoundFxType { get; set; }
                public long HeatMin { get; set; }
                public string Health { get; set; }
                public string Duration { get; set; }
                public bool CanBePickedUp { get; set; }
                public bool Destructible { get; set; }
                public bool BlockClimb { get; set; }
                public string PlacementCheckType { get; set; }
                public long SpawnRules { get; set; }
                public double PlacementNormalYMin { get; set; }
                public long MaxBotShootersPerSquadCount { get; set; }
                public EzapacSupportShieldMetaData MetaData { get; set; }
            }

            public partial class EzapacSupportShieldMetaData
            {
                public List<object> Upgrades { get; set; }
                public Modifiers64 Modifiers { get; set; }
            }

            public partial class Modifiers64
            {
                public Additive46 Additive { get; set; }
            }

            public partial class Additive46
            {
                public long EzapacSupportShieldLifetime { get; set; }
                public long EzapacSupportShieldHealth { get; set; }
            }

            public partial class EzapacSupportShieldWrongPlaced
            {
                public TypeElement Type { get; set; }
                public DisplayMarkerTeamRuleEnum DisplayMarkerTeamRule { get; set; }
                public string VisualModel { get; set; }
                public string DestructionSoundFxType { get; set; }
                public string Health { get; set; }
                public string Duration { get; set; }
                public bool CanBePickedUp { get; set; }
                public bool Destructible { get; set; }
                public EzapacSupportShieldMetaData MetaData { get; set; }
            }

            public partial class Fsb2016SniperMine
            {
                public IconType Type { get; set; }
                public IconType IconType { get; set; }
                public ExplosionFxTypeEnum MessageType { get; set; }
                public string VisualModel { get; set; }
                public Ksk2011SupportFxType FxType { get; set; }
                public double FxRadius { get; set; }
                public bool CanBeRemovedByBuff { get; set; }
                public bool ExplodeOnDamage { get; set; }
                public ExplosionFxTypeEnum ExplosionFxType { get; set; }
                public long DamageRadius { get; set; }
                public double ExplosionDelay { get; set; }
                public long Damage { get; set; }
                public Dictionary<string, DamageCurve> DamageCurve { get; set; }
                public long ActivationDelay { get; set; }
                public double ArmorPenetration { get; set; }
                public long Duration { get; set; }
                public long Health { get; set; }
                public The22Spn2016GSupportMineAuraConfig AuraConfig { get; set; }
            }

            public partial class Grom2014MedicMedkit
            {
                public TypeElement Type { get; set; }
                public string IconType { get; set; }
                public bool HideUnseenMarkerFromEnemy { get; set; }
                public string MessageType { get; set; }
                public string VisualModel { get; set; }
                public string FxType { get; set; }
                public string FxRadius { get; set; }
                public long Duration { get; set; }
                public long Health { get; set; }
                public string Charge { get; set; }
                public The22Spn2016SupportStandartAuraConfig AuraConfig { get; set; }
                public AuraSpecialRule AuraSpecialRule { get; set; }
                public List<Grom2014MedicMedkitAuraBuffGroup> AuraBuffGroups { get; set; }
            }

            public partial class Grom2014MedicMedkitAuraBuffGroup
            {
                public string TargetSelectionTime { get; set; }
                public SelfSuccessGroupRule Rule { get; set; }
                public List<Buff32> Buffs { get; set; }
                public string IsEnabled { get; set; }
            }

            public partial class AuraSpecialRule
            {
                public string RepeatType { get; set; }
                public DisplayMarkerTeamRuleEnum TeamRule { get; set; }
                public long? HumansMin { get; set; }
                public long Duration { get; set; }
                public long? TeamMembersMin { get; set; }
            }

            public partial class Grom2014Support40Mm
            {
                public TypeElement Type { get; set; }
                public IconType IconType { get; set; }
                public string VisualModel { get; set; }
                public FxTypeEnum FxType { get; set; }
                public string FxRadius { get; set; }
                public long ActivationDelay { get; set; }
                public string Duration { get; set; }
                public string SmokeRadius { get; set; }
                public double SmokeExpand { get; set; }
                public string SmokeSteady { get; set; }
                public double SmokeShrink { get; set; }
                public bool DisableDamageByFire { get; set; }
                public Grom2014Support40MmMetaData MetaData { get; set; }
            }

            public partial class Grom2014Support40MmMetaData
            {
                public List<object> Upgrades { get; set; }
                public Modifiers65 Modifiers { get; set; }
            }

            public partial class Modifiers65
            {
                public Additive47 Additive { get; set; }
            }

            public partial class Additive47
            {
                public long Grom2014Support40MmSmokeRadius { get; set; }
                public long Grom2014Support40MmSmokeDuration { get; set; }
            }

            public partial class Ksk2011Assault40Mm
            {
                public IconType Type { get; set; }
                public IconType IconType { get; set; }
                public ExplosionFxTypeEnum MessageType { get; set; }
                public string VisualModel { get; set; }
                public FxTypeEnum FxType { get; set; }
                public string FxRadius { get; set; }
                public ExplosionFxTypeEnum ExplosionFxType { get; set; }
                public string DamageRadius { get; set; }
                public string ChargeDistribution { get; set; }
                public long ActivationDelay { get; set; }
                public long Duration { get; set; }
                public long Health { get; set; }
                public The22Spn2016MedicMedkitAuraConfig AuraConfig { get; set; }
                public List<Ksk2011Assault40MmAuraBuffGroup> AuraBuffGroups { get; set; }
                public AuraSelfSuccessGroup AuraSelfSuccessGroup { get; set; }
            }

            public partial class Ksk2011Assault40MmAuraBuffGroup
            {
                public string TargetSelectionTime { get; set; }
                public DeactivatedEntitiesOwnersRuleElement Rule { get; set; }
                public List<SelfSuccessBuff> Buffs { get; set; }
                public string IsEnabled { get; set; }
            }

            public partial class AuraSelfSuccessGroup
            {
                public string IsEnabled { get; set; }
                public string TargetSelectionTime { get; set; }
                public bool RequireTarget { get; set; }
                public DeactivatedEntitiesOwnersRuleElement Rule { get; set; }
                public List<AuraSelfSuccessGroupBuff> Buffs { get; set; }
            }

            public partial class Ksk2011MedicMedkit
            {
                public TypeElement Type { get; set; }
                public string IconType { get; set; }
                public bool HideUnseenMarkerFromEnemy { get; set; }
                public string MessageType { get; set; }
                public string VisualModel { get; set; }
                public string FxType { get; set; }
                public double FxRadius { get; set; }
                public long Health { get; set; }
                public string ChargeDistribution { get; set; }
                public bool CanBeAppliedInstantly { get; set; }
                public long Duration { get; set; }
                public The22Spn2016GSupportMineAuraConfig AuraConfig { get; set; }
                public List<Ksk2011MedicMedkitAuraBuffGroup> AuraBuffGroups { get; set; }
                public Ksk2011MedicMedkitMetaData MetaData { get; set; }
            }

            public partial class Ksk2011MedicMedkitAuraBuffGroup
            {
                public string TargetSelectionTime { get; set; }
                public SelfSuccessGroupRule Rule { get; set; }
                public List<Buff65> Buffs { get; set; }
                public string IsEnabled { get; set; }
            }

            public partial class Buff65
            {
                public string Name { get; set; }
                public long Priority { get; set; }
                public List<string> Categories { get; set; }
                public long? RebuffStack { get; set; }
                public StaminaAdd Duration { get; set; }
                public long? Period { get; set; }
                public long? HealthAdd { get; set; }
                public bool? Rebuff { get; set; }
                public List<string> BuffImmuneAdd { get; set; }
            }

            public partial class Ksk2011MedicMedkitMetaData
            {
                public List<object> Upgrades { get; set; }
                public Modifiers66 Modifiers { get; set; }
            }

            public partial class Modifiers66
            {
                public Additive48 Additive { get; set; }
            }

            public partial class Additive48
            {
                public long AbilityKsk2011MedicImmunityGroupEnabled { get; set; }
            }

            public partial class Ksk2011SniperMine
            {
                public IconType Type { get; set; }
                public IconType IconType { get; set; }
                public ExplosionFxTypeEnum MessageType { get; set; }
                public string VisualModel { get; set; }
                public PrimaryWeaponFxType FxType { get; set; }
                public string FxRadius { get; set; }
                public bool ExplodeOnDamage { get; set; }
                public bool CanBeRemovedByBuff { get; set; }
                public ExplosionFxTypeEnum ExplosionFxType { get; set; }
                public double DamageRadius { get; set; }
                public double ExplosionDelay { get; set; }
                public string Damage { get; set; }
                public Dictionary<string, DamageCurve> DamageCurve { get; set; }
                public long ActivationDelay { get; set; }
                public double ArmorPenetration { get; set; }
                public long Duration { get; set; }
                public long Health { get; set; }
                public bool CanBePickedUp { get; set; }
                public EzapacAssaultFlareAuraConfig AuraConfig { get; set; }
                public Ksk2011SniperMineMetaData MetaData { get; set; }
            }

            public partial class Ksk2011SniperMineMetaData
            {
                public List<object> Upgrades { get; set; }
                public Modifiers67 Modifiers { get; set; }
            }

            public partial class Modifiers67
            {
                public Additive49 Additive { get; set; }
            }

            public partial class Additive49
            {
                public long Ksk2011SniperMineDamage { get; set; }
                public long Ksk2011SniperMineMineRadius { get; set; }
            }

            public partial class Nesher2015MedicAmmoBag
            {
                public TypeElement Type { get; set; }
                public string IconType { get; set; }
                public string MessageType { get; set; }
                public bool HideUnseenMarkerFromEnemy { get; set; }
                public string VisualModel { get; set; }
                public FxTypeEnum FxType { get; set; }
                public double FxRadius { get; set; }
                public long Health { get; set; }
                public long Charge { get; set; }
                public string ChargeDistribution { get; set; }
                public long Duration { get; set; }
                public bool CanBeManuallyUsed { get; set; }
                public List<Nesher2015MedicAmmoBagAuraBuffGroup> AuraBuffGroups { get; set; }
                public AmfaAxeMetaData MetaData { get; set; }
            }

            public partial class Nesher2015MedicAmmoBagAuraBuffGroup
            {
                public AuraBuffGroupTargetSelectionTime TargetSelectionTime { get; set; }
                public SelfSuccessGroupRule Rule { get; set; }
                public List<Buff8> Buffs { get; set; }
            }

            public partial class Nesher2015MedicHeavyAmmoBag
            {
                public TypeElement Type { get; set; }
                public string IconType { get; set; }
                public string MessageType { get; set; }
                public bool HideUnseenMarkerFromEnemy { get; set; }
                public string VisualModel { get; set; }
                public FxTypeEnum FxType { get; set; }
                public double FxRadius { get; set; }
                public long Health { get; set; }
                public long Charge { get; set; }
                public string ChargeDistribution { get; set; }
                public long Duration { get; set; }
                public bool CanBeManuallyUsed { get; set; }
                public long FireUseBulletsCount { get; set; }
                public List<Nesher2015MedicHeavyAmmoBagAuraBuffGroup> AuraBuffGroups { get; set; }
                public AmfaAxeMetaData MetaData { get; set; }
            }

            public partial class Nesher2015MedicHeavyAmmoBagAuraBuffGroup
            {
                public AuraBuffGroupTargetSelectionTime TargetSelectionTime { get; set; }
                public SelfSuccessGroupRule Rule { get; set; }
                public List<Buff18> Buffs { get; set; }
            }

            public partial class Nesher2015SupportTurret
            {
                public string Type { get; set; }
                public string Damage { get; set; }
                public string ArmorPenetration { get; set; }
                public string TargetMaxRange { get; set; }
                public long Speed { get; set; }
                public IconType IconType { get; set; }
                public bool HideUnseenMarkerFromEnemy { get; set; }
                public string MessageType { get; set; }
                public long HeatMin { get; set; }
                public long SearchAngleX { get; set; }
                public string VisualModel { get; set; }
                public ExplosionFxTypeEnum ExplosionFxType { get; set; }
                public bool StopAbilityOnDestroy { get; set; }
                public string FxType { get; set; }
                public long FxRadius { get; set; }
                public string Duration { get; set; }
                public string Health { get; set; }
                public string DestructionFxType { get; set; }
                public string DestructionSoundFxType { get; set; }
                public bool CanBeRemovedByBuff { get; set; }
                public bool CanBePickedUp { get; set; }
                public Dictionary<string, DamageCurve> DamageCurve { get; set; }
            }

            public partial class Nesher2015Tugs
            {
                public TypeElement Type { get; set; }
                public string IconType { get; set; }
                public DisplayMarkerTeamRuleEnum DisplayMarkerTeamRule { get; set; }
                public string MessageType { get; set; }
                public string VisualModel { get; set; }
                public FxTypeEnum FxType { get; set; }
                public bool CanBePickedUp { get; set; }
                public string DestructionSoundFxType { get; set; }
                public bool CanBeRemovedByBuff { get; set; }
                public string FxRadius { get; set; }
                public string Health { get; set; }
                public string ChargeDistribution { get; set; }
                public string Duration { get; set; }
                public The22Spn2016MedicMedkitAuraConfig AuraConfig { get; set; }
                public List<ArystanSniperBuffAuraGroup> AuraBuffGroups { get; set; }
                public Nesher2015TugsMetaData MetaData { get; set; }
            }

            public partial class Nesher2015TugsMetaData
            {
                public List<object> Upgrades { get; set; }
                public Modifiers68 Modifiers { get; set; }
            }

            public partial class Modifiers68
            {
                public Additive50 Additive { get; set; }
            }

            public partial class Additive50
            {
                public long Nesher2015TugsLifetime { get; set; }
                public long Nesher2015TugsRadius { get; set; }
                public long Nesher2015TugsHealth { get; set; }
                public long Nesher2015TugsEffectDuration { get; set; }
            }

            public partial class Raid2017MedicMedkit
            {
                public TypeElement Type { get; set; }
                public string IconType { get; set; }
                public bool HideUnseenMarkerFromEnemy { get; set; }
                public string MessageType { get; set; }
                public string VisualModel { get; set; }
                public string FxType { get; set; }
                public double FxRadius { get; set; }
                public long Health { get; set; }
                public long Charge { get; set; }
                public string ChargeDistribution { get; set; }
                public long Duration { get; set; }
                public bool CanBeManuallyUsed { get; set; }
                public List<Raid2017MedicMedkitAuraBuffGroup> AuraBuffGroups { get; set; }
                public Fsb2016MedicPassiveMetaData MetaData { get; set; }
            }

            public partial class Raid2017MedicMedkitAuraBuffGroup
            {
                public AuraBuffGroupTargetSelectionTime TargetSelectionTime { get; set; }
                public TentacledRule Rule { get; set; }
                public List<Buff66> Buffs { get; set; }
                public string IsEnabled { get; set; }
            }

            public partial class Buff66
            {
                public string Name { get; set; }
                public long Priority { get; set; }
                public List<BuffImmuneAddElement> Categories { get; set; }
                public long? RebuffStack { get; set; }
                public long Duration { get; set; }
                public long? Period { get; set; }
                public string HealthAdd { get; set; }
                public string ArmorHealthAdd { get; set; }
                public long? ArmorHealthAdditional { get; set; }
            }

            public partial class Raid2017SniperDrone
            {
                public TypeElement Type { get; set; }
                public string VisualModel { get; set; }
                public TypeElement MessageType { get; set; }
                public FxTypeEnum FxType { get; set; }
                public double FxRadius { get; set; }
                public double Speed { get; set; }
                public double InWaterSpeed { get; set; }
                public string Health { get; set; }
                public long ActivationDelay { get; set; }
                public double OwnerFollowRadius { get; set; }
                public double IdleDuration { get; set; }
                public long HeatMax { get; set; }
                public long Duration { get; set; }
                public long SearchRadius { get; set; }
                public double EffectiveRadius { get; set; }
                public double SafetyRadius { get; set; }
                public bool CanInvestigate { get; set; }
                public long TargetFollowDuration { get; set; }
                public ExplosionFxTypeEnum ExplosionFxType { get; set; }
                public bool CanBePickedUp { get; set; }
                public long DamageRadius { get; set; }
                public long Damage { get; set; }
                public Dictionary<string, DamageCurve> DamageCurve { get; set; }
                public long ArmorPenetration { get; set; }
                public The22Spn2016GSupportMineAuraConfig AuraConfig { get; set; }
                public List<Raid2017AssaultHeavyPassiveGroup> AuraBuffGroups { get; set; }
                public Raid2017SniperDroneMetaData MetaData { get; set; }
            }

            public partial class Raid2017SniperDroneMetaData
            {
                public Modifiers69 Modifiers { get; set; }
            }

            public partial class Modifiers69
            {
                public Additive51 Additive { get; set; }
            }

            public partial class Additive51
            {
                public long Raid2017SniperDroneHealth { get; set; }
            }

            public partial class Seal2014AssaultC4
            {
                public IconType Type { get; set; }
                public IconType IconType { get; set; }
                public string MessageType { get; set; }
                public string VisualModel { get; set; }
                public Ksk2011SupportFxType FxType { get; set; }
                public bool CanBeRemovedByBuff { get; set; }
                public long FxRadius { get; set; }
                public long Health { get; set; }
                public SoundFxEnum ExplosionFxType { get; set; }
                public bool RemoveOnRespawn { get; set; }
                public long DamageRadius { get; set; }
                public string Damage { get; set; }
                public Dictionary<string, DamageCurve> DamageCurve { get; set; }
                public bool IsManuallyActivatable { get; set; }
                public bool CanBePickedUp { get; set; }
                public bool HasManualAction { get; set; }
                public double ArmorPenetration { get; set; }
                public long Duration { get; set; }
                public Seal2014AssaultC4MetaData MetaData { get; set; }
            }

            public partial class Seal2014AssaultC4MetaData
            {
                public List<object> Upgrades { get; set; }
                public Modifiers70 Modifiers { get; set; }
            }

            public partial class Modifiers70
            {
                public Additive52 Additive { get; set; }
            }

            public partial class Additive52
            {
                public long Seal2014AssaultC4Damage { get; set; }
            }

            public partial class Seal2014ClaymoreMine
            {
                public IconType Type { get; set; }
                public IconType IconType { get; set; }
                public ExplosionFxTypeEnum MessageType { get; set; }
                public string VisualModel { get; set; }
                public PrimaryWeaponFxType FxType { get; set; }
                public string FxRadius { get; set; }
                public bool ExplodeOnDamage { get; set; }
                public ExplosionFxTypeEnum ExplosionFxType { get; set; }
                public bool CanBeRemovedByBuff { get; set; }
                public double DamageRadius { get; set; }
                public double ExplosionDelay { get; set; }
                public string Damage { get; set; }
                public Dictionary<string, DamageCurve> DamageCurve { get; set; }
                public long ActivationDelay { get; set; }
                public double ArmorPenetration { get; set; }
                public long Duration { get; set; }
                public long Health { get; set; }
                public bool CanBePickedUp { get; set; }
                public EzapacAssaultFlareAuraConfig AuraConfig { get; set; }
                public Seal2014ClaymoreMineMetaData MetaData { get; set; }
            }

            public partial class Seal2014ClaymoreMineMetaData
            {
                public List<object> Upgrades { get; set; }
                public Modifiers71 Modifiers { get; set; }
            }

            public partial class Modifiers71
            {
                public Additive53 Additive { get; set; }
            }

            public partial class Additive53
            {
                public long Seal2014ClaymoreMineDamage { get; set; }
                public long Seal2014ClaymoreMineMineRadius { get; set; }
            }

            public partial class Seal2014MedicMedkit
            {
                public TypeElement Type { get; set; }
                public string IconType { get; set; }
                public string MessageType { get; set; }
                public string VisualModel { get; set; }
                public string FxType { get; set; }
                public double FxRadius { get; set; }
                public long Health { get; set; }
                public long Charge { get; set; }
                public string ChargeDistribution { get; set; }
                public long Duration { get; set; }
                public The22Spn2016GSupportMineAuraConfig AuraConfig { get; set; }
                public List<Fsb2004SniperPassiveGroup> AuraBuffGroups { get; set; }
            }

            public partial class Seal2014SniperFlare
            {
                public TypeElement Type { get; set; }
                public string IconType { get; set; }
                public string MessageType { get; set; }
                public DisplayMarkerTeamRuleEnum DisplayMarkerTeamRule { get; set; }
                public string VisualModel { get; set; }
                public FxTypeEnum FxType { get; set; }
                public string FxRadius { get; set; }
                public string Duration { get; set; }
                public long Health { get; set; }
                public long BotAvoidDanger { get; set; }
                public bool CanBePickedUp { get; set; }
                public The22Spn2016MedicMedkitAuraConfig AuraConfig { get; set; }
                public List<Seal2014SniperFlareAuraBuffGroup> AuraBuffGroups { get; set; }
                public Fsb2016MedicPassiveMetaData MetaData { get; set; }
            }

            public partial class Seal2014SniperFlareAuraBuffGroup
            {
                public AuraBuffGroupTargetSelectionTime TargetSelectionTime { get; set; }
                public bool? CastOnHumanLure { get; set; }
                public SelfSuccessGroupRule Rule { get; set; }
                public List<Buff38> Buffs { get; set; }
                public string IsEnabled { get; set; }
            }

            public partial class Seal2014Support40Mm
            {
                public IconType Type { get; set; }
                public IconType IconType { get; set; }
                public string VisualModel { get; set; }
                public Ksk2011SupportFxType FxType { get; set; }
                public double FxRadius { get; set; }
                public SoundFxEnum ExplosionFxType { get; set; }
                public string DamageRadius { get; set; }
                public long ExplosionDelay { get; set; }
                public double ArmorPenetration { get; set; }
                public long Damage { get; set; }
                public Dictionary<string, DamageCurve> DamageCurve { get; set; }
                public string ActivationDelay { get; set; }
                public long Duration { get; set; }
                public long Health { get; set; }
                public Seal2014Support40MmMetaData MetaData { get; set; }
            }

            public partial class Seal2014Support40MmMetaData
            {
                public List<object> Upgrades { get; set; }
                public Modifiers72 Modifiers { get; set; }
            }

            public partial class Modifiers72
            {
                public Additive54 Additive { get; set; }
            }

            public partial class Additive54
            {
                public long Seal2014Support40MmActivationDelay { get; set; }
                public long Seal2014Support40MmDamageRadius { get; set; }
            }

            public partial class Sso2013Airstrike
            {
                public TypeElement Type { get; set; }
                public string VisualModel { get; set; }
                public Ksk2011SupportFxType FxType { get; set; }
                public long FxRadius { get; set; }
                public SecondaryWeaponExplosionFxType ExplosionFxType { get; set; }
                public long DamageRadius { get; set; }
                public long ArmorPenetration { get; set; }
                public long Damage { get; set; }
                public Dictionary<string, DamageCurve> DamageCurve { get; set; }
                public long ActivationDelay { get; set; }
                public long ExplosionDelay { get; set; }
            }

            public partial class Sso2013AssaultMine
            {
                public IconType Type { get; set; }
                public IconType IconType { get; set; }
                public ExplosionFxTypeEnum MessageType { get; set; }
                public string VisualModel { get; set; }
                public PrimaryWeaponFxType FxType { get; set; }
                public string FxRadius { get; set; }
                public bool ExplodeOnDamage { get; set; }
                public bool CanBeRemovedByBuff { get; set; }
                public ExplosionFxTypeEnum ExplosionFxType { get; set; }
                public double DamageRadius { get; set; }
                public double ExplosionDelay { get; set; }
                public string Damage { get; set; }
                public Dictionary<string, DamageCurve> DamageCurve { get; set; }
                public long ActivationDelay { get; set; }
                public double ArmorPenetration { get; set; }
                public long Duration { get; set; }
                public long Health { get; set; }
                public bool CanBePickedUp { get; set; }
                public EzapacAssaultFlareAuraConfig AuraConfig { get; set; }
                public Sso2013AssaultMineMetaData MetaData { get; set; }
            }

            public partial class Sso2013AssaultMineMetaData
            {
                public List<object> Upgrades { get; set; }
                public Modifiers73 Modifiers { get; set; }
            }

            public partial class Modifiers73
            {
                public Additive55 Additive { get; set; }
            }

            public partial class Additive55
            {
                public long Sso2013AssaultMineDamage { get; set; }
                public long Sso2013AssaultMineMineRadius { get; set; }
            }

            public partial class Sso2013GunnerDrone
            {
                public TypeElement Type { get; set; }
                public string VisualModel { get; set; }
                public TypeElement MessageType { get; set; }
                public FxTypeEnum FxType { get; set; }
                public double FxRadius { get; set; }
                public double Speed { get; set; }
                public double InWaterSpeed { get; set; }
                public string Health { get; set; }
                public long ActivationDelay { get; set; }
                public string Duration { get; set; }
                public long SearchRadius { get; set; }
                public double EffectiveRadius { get; set; }
                public bool CanBeRemovedByBuff { get; set; }
                public double SafetyRadius { get; set; }
                public long TargetFollowDuration { get; set; }
                public bool CanInvestigate { get; set; }
                public ExplosionFxTypeEnum ExplosionFxType { get; set; }
                public bool StopAbilityOnDestroy { get; set; }
                public string DamageRadius { get; set; }
                public string Damage { get; set; }
                public Dictionary<string, DamageCurve> DamageCurve { get; set; }
                public long ArmorPenetration { get; set; }
                public The22Spn2016GSupportMineAuraConfig AuraConfig { get; set; }
                public List<Ksk2011SniperBuffAuraGroup> AuraBuffGroups { get; set; }
            }

            public partial class Tfb2008MedicBandolier
            {
                public IconType Type { get; set; }
                public string VisualModel { get; set; }
                public Ksk2011SupportFxType FxType { get; set; }
                public long FxRadius { get; set; }
                public long Health { get; set; }
                public SoundFxEnum ExplosionFxType { get; set; }
                public long DamageRadius { get; set; }
                public string Damage { get; set; }
                public Dictionary<string, DamageCurve> DamageCurve { get; set; }
                public bool IsManuallyActivatable { get; set; }
                public bool HasManualAction { get; set; }
                public long ArmorPenetration { get; set; }
                public long Duration { get; set; }
                public Tfb2008MedicBandolierMetaData MetaData { get; set; }
            }

            public partial class Tfb2008MedicBandolierMetaData
            {
                public List<object> Upgrades { get; set; }
                public Modifiers74 Modifiers { get; set; }
            }

            public partial class Modifiers74
            {
                public Additive56 Additive { get; set; }
            }

            public partial class Additive56
            {
                public long Tfb2008MedicBandolierDamage { get; set; }
            }

            public partial class Tfb2008MedicLaserClaymore
            {
                public IconType Type { get; set; }
                public IconType IconType { get; set; }
                public string MessageType { get; set; }
                public string VisualModel { get; set; }
                public ExplosionFxTypeEnum ExplosionFxType { get; set; }
                public bool CanBeRemovedByBuff { get; set; }
                public bool CanBePickedUp { get; set; }
                public bool ExplodeOnDamage { get; set; }
                public double DamageRadius { get; set; }
                public double ExplosionDelay { get; set; }
                public long Damage { get; set; }
                public double ArmorPenetration { get; set; }
                public Dictionary<string, DamageCurve> DamageCurve { get; set; }
                public long ActivationDelay { get; set; }
                public long Duration { get; set; }
                public long Health { get; set; }
                public The22Spn2016GSupportMineAuraConfig AuraConfig { get; set; }
                public List<The22Spn2016SupportGroup> AuraBuffGroups { get; set; }
                public Tfb2008MedicLaserClaymoreMetaData MetaData { get; set; }
            }

            public partial class Tfb2008MedicLaserClaymoreMetaData
            {
                public List<object> Upgrades { get; set; }
                public Modifiers75 Modifiers { get; set; }
            }

            public partial class Modifiers75
            {
                public Additive57 Additive { get; set; }
            }

            public partial class Additive57
            {
                public long Tfb2008MedicTripwirePassiveStunDuration { get; set; }
                public long Tfb2008MedicTripwirePassiveStunGroupEnabled { get; set; }
            }

            public partial class Tfb2008SniperMccm
            {
                public IconType Type { get; set; }
                public IconType IconType { get; set; }
                public ExplosionFxTypeEnum MessageType { get; set; }
                public string VisualModel { get; set; }
                public PrimaryWeaponFxType FxType { get; set; }
                public string FxRadius { get; set; }
                public bool ExplodeOnDamage { get; set; }
                public bool CanBeRemovedByBuff { get; set; }
                public ExplosionFxTypeEnum ExplosionFxType { get; set; }
                public double DamageRadius { get; set; }
                public double ExplosionDelay { get; set; }
                public string Damage { get; set; }
                public Dictionary<string, DamageCurve> DamageCurve { get; set; }
                public double ActivationDelay { get; set; }
                public long ArmorPenetration { get; set; }
                public long Duration { get; set; }
                public long Health { get; set; }
                public EzapacAssaultFlareAuraConfig AuraConfig { get; set; }
                public List<RecruitSupportGroup> AuraBuffGroups { get; set; }
                public Tfb2008SniperMccmMetaData MetaData { get; set; }
            }

            public partial class Tfb2008SniperMccmMetaData
            {
                public List<object> Upgrades { get; set; }
                public Modifiers76 Modifiers { get; set; }
            }

            public partial class Modifiers76
            {
                public Additive58 Additive { get; set; }
            }

            public partial class Additive58
            {
                public long Tfb2008SniperMccmDamage { get; set; }
                public long Tfb2008SniperMccmMineRadius { get; set; }
                public long Tfb2008SniperMccmStunDuration { get; set; }
            }

            public partial class Tfb2008SupportScrambler
            {
                public TypeElement Type { get; set; }
                public string IconType { get; set; }
                public DisplayMarkerTeamRuleEnum DisplayMarkerTeamRule { get; set; }
                public string MessageType { get; set; }
                public string VisualModel { get; set; }
                public FxTypeEnum FxType { get; set; }
                public string FxRadius { get; set; }
                public string Health { get; set; }
                public string ChargeDistribution { get; set; }
                public long HeatMin { get; set; }
                public string Duration { get; set; }
                public bool CanBeRemovedByBuff { get; set; }
                public long BotAvoidDanger { get; set; }
                public The22Spn2016MedicMedkitAuraConfig AuraConfig { get; set; }
                public List<Tfb2008SupportScramblerAuraBuffGroup> AuraBuffGroups { get; set; }
                public Fsb2016MedicPassiveMetaData MetaData { get; set; }
            }

            public partial class Tfb2008SupportScramblerAuraBuffGroup
            {
                public string TargetSelectionTime { get; set; }
                public HilariousRule Rule { get; set; }
                public List<AuraSelfSuccessGroupBuff> Buffs { get; set; }
                public string IsEnabled { get; set; }
                public bool? CastOnHumanLure { get; set; }
            }

            public partial class The22Spn2016AssaultLure
            {
                public string Type { get; set; }
                public string MessageType { get; set; }
                public string VisualModel { get; set; }
                public long Duration { get; set; }
                public long Health { get; set; }
                public long HeatMax { get; set; }
                public long SearchRadius { get; set; }
                public double Speed { get; set; }
                public string DestructionFxType { get; set; }
                public string DestructionSoundFxType { get; set; }
                public List<Tfb2008MedicPassiveGroup> AuraBuffGroups { get; set; }
            }

            public partial class The22Spn2016GSupportMine
            {
                public IconType Type { get; set; }
                public IconType IconType { get; set; }
                public bool HideUnseenMarkerFromEnemy { get; set; }
                public ExplosionFxTypeEnum MessageType { get; set; }
                public string VisualModel { get; set; }
                public string ChargeDistribution { get; set; }
                public bool CanBeRemovedByBuff { get; set; }
                public Ksk2011SupportFxType FxType { get; set; }
                public long FxRadius { get; set; }
                public bool ExplodeOnDamage { get; set; }
                public ExplosionFxTypeEnum ExplosionFxType { get; set; }
                public long DamageRadius { get; set; }
                public string Damage { get; set; }
                public Dictionary<string, DamageCurve> DamageCurve { get; set; }
                public long ActivationDelay { get; set; }
                public double ActionDelay { get; set; }
                public double ArmorPenetration { get; set; }
                public long Duration { get; set; }
                public long Health { get; set; }
                public double JumpHeight { get; set; }
                public The22Spn2016GSupportMineAuraConfig AuraConfig { get; set; }
                public List<The22Spn2016GSupportMineAuraBuffGroup> AuraBuffGroups { get; set; }
                public The22Spn2016GSupportMineMetaData MetaData { get; set; }
            }

            public partial class The22Spn2016GSupportMineMetaData
            {
                public List<object> Upgrades { get; set; }
                public Modifiers60 Modifiers { get; set; }
            }

            public partial class Modifiers60
            {
                public Additive42 Additive { get; set; }
            }

            public partial class Additive42
            {
                public long The22Spn2016SupportDamage { get; set; }
            }

            public partial class The22Spn2016MedicMedkit
            {
                public TypeElement Type { get; set; }
                public string IconType { get; set; }
                public string MessageType { get; set; }
                public string VisualModel { get; set; }
                public string FxType { get; set; }
                public string FxRadius { get; set; }
                public string ChargeDistribution { get; set; }
                public double Duration { get; set; }
                public The22Spn2016MedicMedkitAuraConfig AuraConfig { get; set; }
                public List<The22Spn2016MedicMedkitAuraBuffGroup> AuraBuffGroups { get; set; }
                public Fsb2016MedicPassiveMetaData MetaData { get; set; }
            }

            public partial class The22Spn2016MedicMedkitAuraBuffGroup
            {
                public AuraBuffGroupTargetSelectionTime TargetSelectionTime { get; set; }
                public HilariousRule Rule { get; set; }
                public List<Buff7> Buffs { get; set; }
                public string IsEnabled { get; set; }
            }

            public partial class The22Spn2016SupportStandart
            {
                public TypeElement Type { get; set; }
                public string IconType { get; set; }
                public DisplayMarkerTeamRuleEnum DisplayMarkerTeamRule { get; set; }
                public string MessageType { get; set; }
                public string VisualModel { get; set; }
                public PrimaryWeaponFxType FxType { get; set; }
                public long FxRadius { get; set; }
                public string Duration { get; set; }
                public long Charge { get; set; }
                public string ChargeDistribution { get; set; }
                public long Health { get; set; }
                public long AuraRevives { get; set; }
                public long AuraReviveHealth { get; set; }
                public string DestructionFxType { get; set; }
                public string DestructionSoundFxType { get; set; }
                public bool CanBeRemovedByBuff { get; set; }
                public The22Spn2016SupportStandartAuraConfig AuraConfig { get; set; }
                public AuraSpecialRule AuraSpecialRule { get; set; }
                public List<Fsb2004SniperPassiveGroup> AuraBuffGroups { get; set; }
            }

            public partial class Ww2MedicStandart
            {
                public TypeElement Type { get; set; }
                public string IconType { get; set; }
                public DisplayMarkerTeamRuleEnum DisplayMarkerTeamRule { get; set; }
                public string MessageType { get; set; }
                public string VisualModel { get; set; }
                public string FxType { get; set; }
                public long FxRadius { get; set; }
                public string Duration { get; set; }
                public long Health { get; set; }
                public string DestructionFxType { get; set; }
                public string DestructionSoundFxType { get; set; }
                public The22Spn2016SupportStandartAuraConfig AuraConfig { get; set; }
                public List<Sso2013MedicBuffAuraGroup> AuraBuffGroups { get; set; }
            }

            public partial class Ww2SupportBarbedWire
            {
                public TypeElement Type { get; set; }
                public string VisualModel { get; set; }
                public FxTypeEnum FxType { get; set; }
                public double FxRadius { get; set; }
                public string ChargeDistribution { get; set; }
                public long Duration { get; set; }
                public The22Spn2016GSupportMineAuraConfig AuraConfig { get; set; }
                public List<Ww2SupportBarbedWireAuraBuffGroup> AuraBuffGroups { get; set; }
                public Fsb2016MedicPassiveMetaData MetaData { get; set; }
            }

            public partial class Ww2SupportBarbedWireAuraBuffGroup
            {
                public AuraBuffGroupTargetSelectionTime TargetSelectionTime { get; set; }
                public SelfSuccessGroupRule Rule { get; set; }
                public List<Buff32> Buffs { get; set; }
            }

            public partial class ExpeditionCardLevelConfigs
            {
                public ExpeditionCardLevels ExpeditionCardLevelsAll { get; set; }
                public ExpeditionCardLevels ExpeditionCardLevelsNoResources { get; set; }
                public ExpeditionCardLevels ExpeditionCardLevelsNonMaster { get; set; }
                public ExpeditionCardLevels ExpeditionCardLevelsResources { get; set; }
                public ExpeditionCardLevels ExpeditionCardLevelsLevel6Only { get; set; }
            }

            public partial class ExpeditionCardLevels
            {
                public List<ExpeditionCardLevelsAllVariant> Variants { get; set; }
            }

            public partial class ExpeditionCardLevelsAllVariant
            {
                public long Weight { get; set; }
                public long Level { get; set; }
                public long LevelType { get; set; }
            }

            public partial class ExpeditionCardRoleConfigs
            {
                public ExpeditionCardRoles ExpeditionCardRolesAll { get; set; }
                public ExpeditionCardRoles ExpeditionCardRolesSingle { get; set; }
                public ExpeditionCardRoles ExpeditionCardRolesDual { get; set; }
            }

            public partial class ExpeditionCardRoles
            {
                public List<ExpeditionCardRolesAllVariant> Variants { get; set; }
            }

            public partial class ExpeditionCardRolesAllVariant
            {
                public long Weight { get; set; }
                public List<long> Roles { get; set; }
            }

            public partial class ExpeditionConfigs
            {
                public ExpeditionDaily ExpeditionDaily { get; set; }
                public Expedition ExpeditionShortRisk1 { get; set; }
                public Expedition ExpeditionShortRisk2 { get; set; }
                public Expedition ExpeditionShortRisk3 { get; set; }
                public Expedition ExpeditionWeekly { get; set; }
                public Expedition ExpeditionPremium { get; set; }
                public ExpeditionOracle ExpeditionOracle { get; set; }
                public ExpeditionEventNordWind ExpeditionEventNordWind { get; set; }
                public ExpeditionEventNordWind ExpeditionEventNordWindNov { get; set; }
                public ExpeditionEvent ExpeditionEventNewYear2022Sc { get; set; }
                public ExpeditionEvent2022_FreeXp ExpeditionEventNewYear2022FreeXp { get; set; }
                public ExpeditionEvent2022_T4 ExpeditionEventNewYear2022T4 { get; set; }
                public ExpeditionEvent ExpeditionEventNewYear2022Key { get; set; }
                public ExpeditionFeb232022 ExpeditionFeb232022Skin { get; set; }
                public ExpeditionFeb232022 ExpeditionFeb232022Anim { get; set; }
                public ExpeditionFeb232022 ExpeditionFeb232022Hq { get; set; }
                public ExpeditionFeb232022 ExpeditionFeb232022Flask { get; set; }
                public ExpeditionEvent2022_FreeXp ExpeditionEventMay2022FreeXp { get; set; }
                public ExpeditionEvent2022_T4 ExpeditionEventMay2022T4 { get; set; }
                public ExpeditionEvent ExpeditionEventMay2022Sc { get; set; }
                public ExpeditionEvent ExpeditionEventMay2022Premium { get; set; }
            }

            public partial class ExpeditionDaily
            {
                public long EnableOnLevel { get; set; }
                public DateTimeOffset StartDate { get; set; }
                public DateTimeOffset EndDate { get; set; }
                public string IterationDuration { get; set; }
                public string IterationOffset { get; set; }
                public bool RequiredPremium { get; set; }
                public long Kind { get; set; }
                public string Visual { get; set; }
                public string ExpireDuration { get; set; }
                public DateTimeOffset DeployDuration { get; set; }
                public RerollPriceElement DeployPrice { get; set; }
                public ExpeditionEventNordWindRerollPrice RerollPrice { get; set; }
                public long ExpeditionSlotCount { get; set; }
                public long MaxCardRoleConditionCount { get; set; }
                public long MaxCardLevelConditionCount { get; set; }
                public long MinCardSlotCount { get; set; }
                public long MaxCardSlotCount { get; set; }
                public long RewardXp { get; set; }
                public List<string> Rewards { get; set; }
                public List<string> Visuals { get; set; }
                public string CardSlotRoles { get; set; }
                public string CardSlotLevels { get; set; }
            }

            public partial class RerollPriceElement
            {
                public MultiplyClass Values { get; set; }
            }

            public partial class ExpeditionEventNordWindRerollPrice
            {
                public RerollPriceValues Values { get; set; }
            }

            public partial class RerollPriceValues
            {
                public long Sc { get; set; }
            }

            public partial class ExpeditionEvent2022_FreeXp
            {
                public long EnableOnLevel { get; set; }
                public DateTimeOffset StartDate { get; set; }
                public DateTimeOffset EndDate { get; set; }
                public string IterationDuration { get; set; }
                public DateTimeOffset IterationOffset { get; set; }
                public bool RequiredPremium { get; set; }
                public long Kind { get; set; }
                public string Visual { get; set; }
                public string ExpireDuration { get; set; }
                public DateTimeOffset DeployDuration { get; set; }
                public AmmunitionClass DeployPrice { get; set; }
                public RerollPriceElement RerollPrice { get; set; }
                public long ExpeditionSlotCount { get; set; }
                public long MaxCardRoleConditionCount { get; set; }
                public long MaxCardLevelConditionCount { get; set; }
                public long MinCardSlotCount { get; set; }
                public long MaxCardSlotCount { get; set; }
                public long RewardXp { get; set; }
                public List<string> Rewards { get; set; }
                public List<string> Visuals { get; set; }
                public string CardSlotRoles { get; set; }
                public string CardSlotLevels { get; set; }
            }

            public partial class ExpeditionEvent
            {
                public long EnableOnLevel { get; set; }
                public DateTimeOffset StartDate { get; set; }
                public DateTimeOffset EndDate { get; set; }
                public string IterationDuration { get; set; }
                public string IterationOffset { get; set; }
                public bool RequiredPremium { get; set; }
                public long Kind { get; set; }
                public string Visual { get; set; }
                public string ExpireDuration { get; set; }
                public string DeployDuration { get; set; }
                public ExpeditionEventNordWindRerollPrice DeployPrice { get; set; }
                public RerollPriceElement RerollPrice { get; set; }
                public long ExpeditionSlotCount { get; set; }
                public long MaxCardRoleConditionCount { get; set; }
                public long MaxCardLevelConditionCount { get; set; }
                public long MinCardSlotCount { get; set; }
                public long MaxCardSlotCount { get; set; }
                public long RewardXp { get; set; }
                public List<string> Rewards { get; set; }
                public List<string> Visuals { get; set; }
                public string CardSlotRoles { get; set; }
                public string CardSlotLevels { get; set; }
            }

            public partial class ExpeditionEvent2022_T4
            {
                public long EnableOnLevel { get; set; }
                public DateTimeOffset StartDate { get; set; }
                public DateTimeOffset EndDate { get; set; }
                public string IterationDuration { get; set; }
                public DateTimeOffset IterationOffset { get; set; }
                public bool RequiredPremium { get; set; }
                public long Kind { get; set; }
                public string Visual { get; set; }
                public string ExpireDuration { get; set; }
                public DateTimeOffset DeployDuration { get; set; }
                public DeployPrice DeployPrice { get; set; }
                public RerollPriceElement RerollPrice { get; set; }
                public long ExpeditionSlotCount { get; set; }
                public long MaxCardRoleConditionCount { get; set; }
                public long MaxCardLevelConditionCount { get; set; }
                public long MinCardSlotCount { get; set; }
                public long MaxCardSlotCount { get; set; }
                public long RewardXp { get; set; }
                public List<string> Rewards { get; set; }
                public List<string> Visuals { get; set; }
                public string CardSlotRoles { get; set; }
                public string CardSlotLevels { get; set; }
            }

            public partial class DeployPrice
            {
                public PurpleValues Values { get; set; }
            }

            public partial class PurpleValues
            {
                public long CmT4Secretdev { get; set; }
            }

            public partial class ExpeditionEventNordWind
            {
                public long EnableOnLevel { get; set; }
                public DateTimeOffset StartDate { get; set; }
                public DateTimeOffset EndDate { get; set; }
                public string IterationDuration { get; set; }
                public DateTimeOffset IterationOffset { get; set; }
                public bool RequiredPremium { get; set; }
                public long Kind { get; set; }
                public string Visual { get; set; }
                public string ExpireDuration { get; set; }
                public DateTimeOffset DeployDuration { get; set; }
                public AmmunitionClass DeployPrice { get; set; }
                public ExpeditionEventNordWindRerollPrice RerollPrice { get; set; }
                public long ExpeditionSlotCount { get; set; }
                public long MaxCardRoleConditionCount { get; set; }
                public long MaxCardLevelConditionCount { get; set; }
                public long MinCardSlotCount { get; set; }
                public long MaxCardSlotCount { get; set; }
                public long RewardXp { get; set; }
                public List<string> Rewards { get; set; }
                public List<string> Visuals { get; set; }
                public string CardSlotRoles { get; set; }
                public string CardSlotLevels { get; set; }
            }

            public partial class ExpeditionFeb232022
            {
                public long EnableOnLevel { get; set; }
                public DateTimeOffset StartDate { get; set; }
                public DateTimeOffset EndDate { get; set; }
                public string IterationDuration { get; set; }
                public DateTimeOffset IterationOffset { get; set; }
                public bool RequiredPremium { get; set; }
                public long Kind { get; set; }
                public string Visual { get; set; }
                public string ExpireDuration { get; set; }
                public string DeployDuration { get; set; }
                public LootboxAccountLevelCustomizeDeployPrice DeployPrice { get; set; }
                public RerollPriceElement RerollPrice { get; set; }
                public long ExpeditionSlotCount { get; set; }
                public long MaxCardRoleConditionCount { get; set; }
                public long MaxCardLevelConditionCount { get; set; }
                public long MinCardSlotCount { get; set; }
                public long MaxCardSlotCount { get; set; }
                public long RewardXp { get; set; }
                public List<string> Rewards { get; set; }
                public List<string> Visuals { get; set; }
                public string CardSlotRoles { get; set; }
                public string CardSlotLevels { get; set; }
            }

            public partial class LootboxAccountLevelCustomizeDeployPrice
            {
                public FluffyValues Values { get; set; }
            }

            public partial class FluffyValues
            {
                public long? Feb232022_Token { get; set; }
            }

            public partial class ExpeditionOracle
            {
                public long EnableOnLevel { get; set; }
                public DateTimeOffset StartDate { get; set; }
                public DateTimeOffset EndDate { get; set; }
                public string IterationDuration { get; set; }
                public string IterationOffset { get; set; }
                public bool RequiredPremium { get; set; }
                public long Kind { get; set; }
                public string Visual { get; set; }
                public string ExpireDuration { get; set; }
                public DateTimeOffset DeployDuration { get; set; }
                public DeployPriceElement DeployPrice { get; set; }
                public ExpeditionEventNordWindRerollPrice RerollPrice { get; set; }
                public long ExpeditionSlotCount { get; set; }
                public long MaxCardRoleConditionCount { get; set; }
                public long MaxCardLevelConditionCount { get; set; }
                public long MinCardSlotCount { get; set; }
                public long MaxCardSlotCount { get; set; }
                public long RewardXp { get; set; }
                public List<string> Rewards { get; set; }
                public List<string> Visuals { get; set; }
                public string CardSlotRoles { get; set; }
                public string CardSlotLevels { get; set; }
            }

            public partial class DeployPriceElement
            {
                public RefundSiteValues Values { get; set; }
            }

            public partial class RefundSiteValues
            {
                public long? Hc { get; set; }
            }

            public partial class Expedition
            {
                public long EnableOnLevel { get; set; }
                public DateTimeOffset StartDate { get; set; }
                public DateTimeOffset EndDate { get; set; }
                public string IterationDuration { get; set; }
                public string IterationOffset { get; set; }
                public bool RequiredPremium { get; set; }
                public long Kind { get; set; }
                public string Visual { get; set; }
                public string ExpireDuration { get; set; }
                public string DeployDuration { get; set; }
                public ExpeditionEventNordWindRerollPrice DeployPrice { get; set; }
                public ExpeditionEventNordWindRerollPrice RerollPrice { get; set; }
                public long ExpeditionSlotCount { get; set; }
                public long MaxCardRoleConditionCount { get; set; }
                public long MaxCardLevelConditionCount { get; set; }
                public long MinCardSlotCount { get; set; }
                public long MaxCardSlotCount { get; set; }
                public long RewardXp { get; set; }
                public List<string> Rewards { get; set; }
                public List<string> Visuals { get; set; }
                public string CardSlotRoles { get; set; }
                public string CardSlotLevels { get; set; }
            }

            public partial class ExpeditionRewardConfigs
            {
                public ExpeditionRewardDailySlot ExpeditionRewardDailySlot1 { get; set; }
                public ExpeditionRewardDailySlot ExpeditionRewardDailySlot2 { get; set; }
                public ExpeditionRewardDailySlot ExpeditionRewardDailySlot3 { get; set; }
                public ExpeditionRewardEventNordWindNovSlot1Class ExpeditionRewardShortRisk1Slot1 { get; set; }
                public ExpeditionRewardEventNordWindNovSlot1Class ExpeditionRewardShortRisk1Slot2 { get; set; }
                public ExpeditionRewardEventNordWindNovSlot2Class ExpeditionRewardShortRisk2Slot1 { get; set; }
                public ExpeditionRewardEventNordWindNovSlot2Class ExpeditionRewardShortRisk2Slot2 { get; set; }
                public ExpeditionRewardEventNordWindNovSlot2Class ExpeditionRewardShortRisk3Slot1 { get; set; }
                public ExpeditionRewardEventNordWindNovSlot2Class ExpeditionRewardShortRisk3Slot2 { get; set; }
                public ExpeditionRewardEventNordWindSlotMatsClass ExpeditionRewardWeeklySlot1 { get; set; }
                public ExpeditionRewardEventNordWindSlotMatsClass ExpeditionRewardWeeklySlot2 { get; set; }
                public ExpeditionRewardEventNordWindSlotMatsClass ExpeditionRewardWeeklySlot3 { get; set; }
                public ExpeditionRewardWeeklySlot4 ExpeditionRewardWeeklySlot4 { get; set; }
                public ExpeditionRewardWeeklySlot5 ExpeditionRewardWeeklySlot5 { get; set; }
                public ExpeditionRewardPremiumSlot1 ExpeditionRewardPremiumSlot1 { get; set; }
                public ExpeditionRewardPremiumSlot2 ExpeditionRewardPremiumSlot2 { get; set; }
                public ExpeditionRewardEventNordWindSlotMatsClass ExpeditionRewardOracleSlot1 { get; set; }
                public ExpeditionRewardEventNordWindSlotMatsClass ExpeditionRewardOracleSlot2 { get; set; }
                public ExpeditionRewardEventNordWindSlotMatsClass ExpeditionRewardOracleSlot3 { get; set; }
                public ExpeditionRewardOracleSlot4 ExpeditionRewardOracleSlot4 { get; set; }
                public ExpeditionRewardEventNordWindSlotMatsClass ExpeditionRewardEventNordWindSlotMats { get; set; }
                public ExpeditionRewardEventNordWindNovSlot1Class ExpeditionRewardEventNordWindNovSlot1 { get; set; }
                public ExpeditionRewardEventNordWindNovSlot2Class ExpeditionRewardEventNordWindNovSlot2 { get; set; }
                public ExpeditionRewardEventNordWindNovSlot3 ExpeditionRewardEventNordWindNovSlot3 { get; set; }
                public ExpeditionRewardEventNordWindNovSlot4 ExpeditionRewardEventNordWindNovSlot4 { get; set; }
                public ExpeditionRewardEventNewYear2022Slot1 ExpeditionRewardEventNewYear2022Slot1 { get; set; }
                public ExpeditionRewardEventNewYear2022Slot2 ExpeditionRewardEventNewYear2022Slot2 { get; set; }
                public ExpeditionRewardFeb232022SkinSlot1 ExpeditionRewardFeb232022SkinSlot1 { get; set; }
                public ExpeditionRewardFeb232022AnimSlot1 ExpeditionRewardFeb232022AnimSlot1 { get; set; }
                public ExpeditionRewardFeb232022HqSlot1 ExpeditionRewardFeb232022HqSlot1 { get; set; }
                public ExpeditionRewardFeb232022FlaskSlot1 ExpeditionRewardFeb232022FlaskSlot1 { get; set; }
                public ExpeditionRewardFeb232022BoostersSlot2 ExpeditionRewardFeb232022SmallBoostersSlot2 { get; set; }
                public ExpeditionRewardFeb232022BoostersSlot3 ExpeditionRewardFeb232022SmallBoostersSlot3 { get; set; }
                public ExpeditionRewardFeb232022BoostersSlot2 ExpeditionRewardFeb232022BigBoostersSlot2 { get; set; }
                public ExpeditionRewardFeb232022BoostersSlot3 ExpeditionRewardFeb232022BigBoostersSlot3 { get; set; }
                public ExpeditionRewardEventMay2022Slot ExpeditionRewardEventMay2022Slot1 { get; set; }
                public ExpeditionRewardEventMay2022Slot ExpeditionRewardEventMay2022Slot2 { get; set; }
            }

            public partial class ExpeditionRewardDailySlot
            {
                public List<ExpeditionRewardDailySlot1Variant> Variants { get; set; }
            }

            public partial class ExpeditionRewardDailySlot1Variant
            {
                public string Name { get; set; }
                public long Weight { get; set; }
                public PurpleReward Reward { get; set; }
            }

            public partial class PurpleReward
            {
                public PurpleShopEntries ShopEntries { get; set; }
                public long Xp { get; set; }
            }

            public partial class PurpleShopEntries
            {
                public long? ShopCurrencySoft { get; set; }
                public long? ShopCurrencyXpBooster { get; set; }
                public long? ShopCurrencyCreditsBooster { get; set; }
            }

            public partial class ExpeditionRewardEventMay2022Slot
            {
                public List<ExpeditionRewardEventMay2022Slot1Variant> Variants { get; set; }
            }

            public partial class ExpeditionRewardEventMay2022Slot1Variant
            {
                public string Name { get; set; }
                public long Weight { get; set; }
                public FluffyReward Reward { get; set; }
            }

            public partial class FluffyReward
            {
                public FluffyShopEntries ShopEntries { get; set; }
                public long Xp { get; set; }
            }

            public partial class FluffyShopEntries
            {
                public long ShopCurrencyMay2022Token { get; set; }
            }

            public partial class ExpeditionRewardEventNewYear2022Slot1
            {
                public List<ExpeditionRewardEventNewYear2022Slot1Variant> Variants { get; set; }
            }

            public partial class ExpeditionRewardEventNewYear2022Slot1Variant
            {
                public string Name { get; set; }
                public long Weight { get; set; }
                public TentacledReward Reward { get; set; }
            }

            public partial class TentacledReward
            {
                public TentacledShopEntries ShopEntries { get; set; }
                public long Xp { get; set; }
            }

            public partial class TentacledShopEntries
            {
                public long ShopCurrencyNewYear2022Token { get; set; }
            }

            public partial class ExpeditionRewardEventNewYear2022Slot2
            {
                public List<ExpeditionRewardEventNewYear2022Slot2Variant> Variants { get; set; }
            }

            public partial class ExpeditionRewardEventNewYear2022Slot2Variant
            {
                public string Name { get; set; }
                public long Weight { get; set; }
                public StickyReward Reward { get; set; }
            }

            public partial class StickyReward
            {
                public StickyShopEntries ShopEntries { get; set; }
                public long Xp { get; set; }
            }

            public partial class StickyShopEntries
            {
                public long ShopCurrencyNewYear2022Key { get; set; }
            }

            public partial class ExpeditionRewardEventNordWindNovSlot1Class
            {
                public List<ExpeditionRewardEventNordWindNovSlot1Variant> Variants { get; set; }
            }

            public partial class ExpeditionRewardEventNordWindNovSlot1Variant
            {
                public StickyName Name { get; set; }
                public long Weight { get; set; }
                public IndigoReward Reward { get; set; }
            }

            public partial class IndigoReward
            {
                public IndigoShopEntries ShopEntries { get; set; }
                public long Xp { get; set; }
            }

            public partial class IndigoShopEntries
            {
                public long? ShopCurrencyCmT1Component { get; set; }
                public long? ShopCurrencyCmT1Medicine { get; set; }
                public long? ShopCurrencyCmT1Alloy { get; set; }
                public long? ShopCurrencyCmT1Fuel { get; set; }
            }

            public partial class ExpeditionRewardEventNordWindNovSlot2Class
            {
                public List<ExpeditionRewardEventNordWindNovSlot2Variant> Variants { get; set; }
            }

            public partial class ExpeditionRewardEventNordWindNovSlot2Variant
            {
                public StickyName Name { get; set; }
                public long Weight { get; set; }
                public BattlePassRewardClass Reward { get; set; }
            }

            public partial class ExpeditionRewardEventNordWindNovSlot3
            {
                public List<ExpeditionRewardEventNordWindNovSlot3Variant> Variants { get; set; }
            }

            public partial class ExpeditionRewardEventNordWindNovSlot3Variant
            {
                public StickyName Name { get; set; }
                public long Weight { get; set; }
                public IndecentReward Reward { get; set; }
            }

            public partial class IndecentReward
            {
                public IndecentShopEntries ShopEntries { get; set; }
                public long Xp { get; set; }
            }

            public partial class IndecentShopEntries
            {
                public long? ShopCurrencyCmT2Composite { get; set; }
                public long? ShopCurrencyCmT2Chemistry { get; set; }
                public long? ShopCurrencyCmT2Encryption { get; set; }
                public long? ShopCurrencyCmT3Microchip { get; set; }
                public long? ShopCurrencyCmT3Blueprint { get; set; }
            }

            public partial class ExpeditionRewardEventNordWindNovSlot4
            {
                public List<ExpeditionRewardEventNordWindNovSlot4Variant> Variants { get; set; }
            }

            public partial class ExpeditionRewardEventNordWindNovSlot4Variant
            {
                public string Name { get; set; }
                public long Weight { get; set; }
                public HilariousReward Reward { get; set; }
            }

            public partial class HilariousReward
            {
                public HilariousShopEntries ShopEntries { get; set; }
                public long Xp { get; set; }
            }

            public partial class HilariousShopEntries
            {
                public long? ShopCurrencyCmT4Secretdev { get; set; }
                public long? ShopLootboxMainMix1 { get; set; }
            }

            public partial class ExpeditionRewardEventNordWindSlotMatsClass
            {
                public List<ExpeditionRewardEventNordWindSlotMatsVariant> Variants { get; set; }
            }

            public partial class ExpeditionRewardEventNordWindSlotMatsVariant
            {
                public IndigoName Name { get; set; }
                public long Weight { get; set; }
                public BattlePassRewardClass Reward { get; set; }
            }

            public partial class ExpeditionRewardFeb232022AnimSlot1
            {
                public List<ExpeditionRewardFeb232022AnimSlot1Variant> Variants { get; set; }
            }

            public partial class ExpeditionRewardFeb232022AnimSlot1Variant
            {
                public string Name { get; set; }
                public long Weight { get; set; }
                public AmbitiousReward Reward { get; set; }
            }

            public partial class AmbitiousReward
            {
                public AmbitiousShopEntries ShopEntries { get; set; }
                public long Xp { get; set; }
            }

            public partial class AmbitiousShopEntries
            {
                public long ShopLootboxFeb232022_Anim { get; set; }
            }

            public partial class ExpeditionRewardFeb232022BoostersSlot2
            {
                public List<ExpeditionRewardFeb232022BigBoostersSlot2Variant> Variants { get; set; }
            }

            public partial class ExpeditionRewardFeb232022BigBoostersSlot2Variant
            {
                public IndecentName Name { get; set; }
                public long Weight { get; set; }
                public CunningReward Reward { get; set; }
            }

            public partial class CunningReward
            {
                public CunningShopEntries ShopEntries { get; set; }
                public long Xp { get; set; }
            }

            public partial class CunningShopEntries
            {
                public long ShopCurrencyXpBooster { get; set; }
            }

            public partial class ExpeditionRewardFeb232022BoostersSlot3
            {
                public List<ExpeditionRewardFeb232022BigBoostersSlot3Variant> Variants { get; set; }
            }

            public partial class ExpeditionRewardFeb232022BigBoostersSlot3Variant
            {
                public IndecentName Name { get; set; }
                public long Weight { get; set; }
                public MagentaReward Reward { get; set; }
            }

            public partial class MagentaReward
            {
                public MagentaShopEntries ShopEntries { get; set; }
                public long Xp { get; set; }
            }

            public partial class MagentaShopEntries
            {
                public long ShopCurrencyCreditsBooster { get; set; }
            }

            public partial class ExpeditionRewardFeb232022FlaskSlot1
            {
                public List<ExpeditionRewardFeb232022FlaskSlot1Variant> Variants { get; set; }
            }

            public partial class ExpeditionRewardFeb232022FlaskSlot1Variant
            {
                public string Name { get; set; }
                public long Weight { get; set; }
                public BattlePassRewardClass Reward { get; set; }
            }

            public partial class ExpeditionRewardFeb232022HqSlot1
            {
                public List<ExpeditionRewardFeb232022HqSlot1Variant> Variants { get; set; }
            }

            public partial class ExpeditionRewardFeb232022HqSlot1Variant
            {
                public string Name { get; set; }
                public long Weight { get; set; }
                public FriskyReward Reward { get; set; }
            }

            public partial class FriskyReward
            {
                public FriskyShopEntries ShopEntries { get; set; }
                public long Xp { get; set; }
            }

            public partial class FriskyShopEntries
            {
                public long ShopHqstyleFeb232022 { get; set; }
            }

            public partial class ExpeditionRewardFeb232022SkinSlot1
            {
                public List<ExpeditionRewardFeb232022SkinSlot1Variant> Variants { get; set; }
            }

            public partial class ExpeditionRewardFeb232022SkinSlot1Variant
            {
                public string Name { get; set; }
                public long Weight { get; set; }
                public MischievousReward Reward { get; set; }
            }

            public partial class MischievousReward
            {
                public MischievousShopEntries ShopEntries { get; set; }
                public long Xp { get; set; }
            }

            public partial class MischievousShopEntries
            {
                public long ShopLootboxFeb232022_Skin { get; set; }
            }

            public partial class ExpeditionRewardOracleSlot4
            {
                public List<ExpeditionRewardOracleSlot4Variant> Variants { get; set; }
            }

            public partial class ExpeditionRewardOracleSlot4Variant
            {
                public string Name { get; set; }
                public long Weight { get; set; }
                public BraggadociousReward Reward { get; set; }
            }

            public partial class BraggadociousReward
            {
                public BraggadociousShopEntries ShopEntries { get; set; }
                public long Xp { get; set; }
            }

            public partial class BraggadociousShopEntries
            {
                public long ShopLootboxExpeditionOracleSupplies { get; set; }
            }

            public partial class ExpeditionRewardPremiumSlot1
            {
                public List<ExpeditionRewardPremiumSlot1Variant> Variants { get; set; }
            }

            public partial class ExpeditionRewardPremiumSlot1Variant
            {
                public string Name { get; set; }
                public long Weight { get; set; }
                public Reward1 Reward { get; set; }
            }

            public partial class Reward1
            {
                public ShopEntries1 ShopEntries { get; set; }
                public long Xp { get; set; }
            }

            public partial class ShopEntries1
            {
                public long ShopLootboxExpeditionPremiumMaterials { get; set; }
            }

            public partial class ExpeditionRewardPremiumSlot2
            {
                public List<ExpeditionRewardPremiumSlot2Variant> Variants { get; set; }
            }

            public partial class ExpeditionRewardPremiumSlot2Variant
            {
                public string Name { get; set; }
                public long Weight { get; set; }
                public Reward2 Reward { get; set; }
            }

            public partial class Reward2
            {
                public ShopEntries2 ShopEntries { get; set; }
                public long Xp { get; set; }
            }

            public partial class ShopEntries2
            {
                public long ShopLootboxExpeditionPremiumSupplies { get; set; }
            }

            public partial class ExpeditionRewardWeeklySlot4
            {
                public List<ExpeditionRewardWeeklySlot4Variant> Variants { get; set; }
            }

            public partial class ExpeditionRewardWeeklySlot4Variant
            {
                public string Name { get; set; }
                public long Weight { get; set; }
                public Reward3 Reward { get; set; }
            }

            public partial class Reward3
            {
                public ShopEntries3 ShopEntries { get; set; }
                public long Xp { get; set; }
            }

            public partial class ShopEntries3
            {
                public long ShopLootboxExpeditionWeeklyMaterials { get; set; }
            }

            public partial class ExpeditionRewardWeeklySlot5
            {
                public List<ExpeditionRewardWeeklySlot5Variant> Variants { get; set; }
            }

            public partial class ExpeditionRewardWeeklySlot5Variant
            {
                public string Name { get; set; }
                public long Weight { get; set; }
                public Reward4 Reward { get; set; }
            }

            public partial class Reward4
            {
                public ShopEntries4 ShopEntries { get; set; }
                public long Xp { get; set; }
            }

            public partial class ShopEntries4
            {
                public long ShopLootboxExpeditionWeeklySupplies { get; set; }
            }

            public partial class ExpeditionVisualConfig
            {
                public List<ExpeditionVisualConfigVariant> Variants { get; set; }
            }

            public partial class ExpeditionVisualConfigVariant
            {
                public string Visual { get; set; }
                public long Weight { get; set; }
            }

            public partial class Firework
            {
                public bool EnabledInGame { get; set; }
                public string Visual { get; set; }
            }

            public partial class FoulPlayConfigs
            {
                public Ally AllyKilled { get; set; }
                public Ally AllyLightDamaged { get; set; }
                public Ally AllyHeavyDamaged { get; set; }
            }

            public partial class Ally
            {
                public bool EnabledInGame { get; set; }
                public long XpPenalty { get; set; }
                public long ConditionInt1 { get; set; }
                public long? ConditionInt2 { get; set; }
                public long? KickCount { get; set; }
            }

            public partial class GlobalParams
            {
                public long LastOnboardingLevel { get; set; }
                public long ExpeditionFarmerXpBonus { get; set; }
                public long FireworksGapSeconds { get; set; }
                public long FireworksUpdateSeconds { get; set; }
                public MetaAfk MetaAfk { get; set; }
                public GameAdvices GameAdvices { get; set; }
                public List<RankedSeasonPoint> RankedSeasonPoints { get; set; }
            }

            public partial class GameAdvices
            {
                public long SaveLastCount { get; set; }
                public List<LevelGroup> LevelGroups { get; set; }
                public Weights Weights { get; set; }
            }

            public partial class LevelGroup
            {
                public string Code { get; set; }
                public bool DisableOthers { get; set; }
                public long BeginLevel { get; set; }
                public long EndLevel { get; set; }
                public long Weight { get; set; }
            }

            public partial class Weights
            {
                public long Event { get; set; }
                public long Map { get; set; }
                public long Gamemode { get; set; }
                public long Operator { get; set; }
                public long Other { get; set; }
            }

            public partial class MetaAfk
            {
                public bool Enabled { get; set; }
                public long Delay { get; set; }
                public List<string> Emotions { get; set; }
            }

            public partial class RankedSeasonPoint
            {
                public long OldPoints { get; set; }
                public long NewPoints { get; set; }
            }

            public partial class HumanConfigs
            {
                public The22_Spn2016A Recruita { get; set; }
                public The22_Spn2016A Recruits { get; set; }
                public The22_Spn2016A Recruitg { get; set; }
                public The22_Spn2016A Recruitm { get; set; }
                public The22_Spn2016A Fsb2004A { get; set; }
                public The22_Spn2016A Fsb2004S { get; set; }
                public The22_Spn2016A Fsb2004G { get; set; }
                public The22_Spn2016A Fsb2004M { get; set; }
                public The22_Spn2016A Grom2014A { get; set; }
                public The22_Spn2016A Grom2014S { get; set; }
                public The22_Spn2016A Grom2014G { get; set; }
                public The22_Spn2016A Grom2014M { get; set; }
                public The22_Spn2016A Fsb2016A { get; set; }
                public The22_Spn2016A Fsb2016S { get; set; }
                public The22_Spn2016A Fsb2016G { get; set; }
                public The22_Spn2016A Fsb2016M { get; set; }
                public The22_Spn2016A Ksk2011A { get; set; }
                public The22_Spn2016A Ksk2011S { get; set; }
                public The22_Spn2016A Ksk2011G { get; set; }
                public The22_Spn2016A Ksk2011M { get; set; }
                public The22_Spn2016A Sso2013A { get; set; }
                public The22_Spn2016A Sso2013S { get; set; }
                public The22_Spn2016A Sso2013G { get; set; }
                public The22_Spn2016A Sso2013M { get; set; }
                public The22_Spn2016A Seal2014A { get; set; }
                public The22_Spn2016A Seal2014S { get; set; }
                public The22_Spn2016A Seal2014G { get; set; }
                public The22_Spn2016A Seal2014M { get; set; }
                public The22_Spn2016A Sek2015A { get; set; }
                public The22_Spn2016A Sek2015S { get; set; }
                public The22_Spn2016A Sek2015G { get; set; }
                public The22_Spn2016A Sek2015M { get; set; }
                public The22_Spn2016A Sobr2008G { get; set; }
                public The22_Spn2016A The22Spn2016A { get; set; }
                public The22_Spn2016A The22Spn2016S { get; set; }
                public The22_Spn2016A The22Spn2016G { get; set; }
                public The22_Spn2016A The22Spn2016M { get; set; }
                public The22_Spn2016A Tfb2008M { get; set; }
                public The22_Spn2016A Tfb2008S { get; set; }
                public The22_Spn2016A Tfb2008A { get; set; }
                public The22_Spn2016A Tfb2008G { get; set; }
                public The22_Spn2016A Raid2017G { get; set; }
                public The22_Spn2016A Raid2017M { get; set; }
                public The22_Spn2016A Raid2017A { get; set; }
                public The22_Spn2016A Raid2017S { get; set; }
                public The22_Spn2016A Nesher2015A { get; set; }
                public The22_Spn2016A Nesher2015S { get; set; }
                public The22_Spn2016A Nesher2015G { get; set; }
                public The22_Spn2016A Nesher2015M { get; set; }
                public The22_Spn2016A Ezapacs { get; set; }
                public The22_Spn2016A Ezapacm { get; set; }
                public The22_Spn2016A Ezapacg { get; set; }
                public The22_Spn2016A Ezapaca { get; set; }
                public The22_Spn2016A Arystana { get; set; }
                public The22_Spn2016A Arystans { get; set; }
                public The22_Spn2016A Arystanm { get; set; }
                public The22_Spn2016A Arystang { get; set; }
                public The22_Spn2016A Belssoa { get; set; }
                public The22_Spn2016A Belssos { get; set; }
                public The22_Spn2016A Belssog { get; set; }
                public The22_Spn2016A Belssom { get; set; }
                public The22_Spn2016A Amfa { get; set; }
                public The22_Spn2016A Amfg { get; set; }
                public The22_Spn2016A Amfm { get; set; }
                public The22_Spn2016A Amfs { get; set; }
                public Ww2AClass Ww2A { get; set; }
                public Ww2AClass Ww2S { get; set; }
                public Ww2AClass Ww2G { get; set; }
                public Ww2AClass Ww2M { get; set; }
            }

            public partial class The22_Spn2016A
            {
                public long NumId { get; set; }
                public bool EnabledInGame { get; set; }
                public string Visual { get; set; }
                public string Collection { get; set; }
                public Role Role { get; set; }
                public The22Spn2016AModifiers Modifiers { get; set; }
                public Items Items { get; set; }
                public The22Spn2016AAbilities Abilities { get; set; }
                public List<string> PassiveAbilities { get; set; }
                public List<string> DefaultShopItems { get; set; }
                public long MaxXp { get; set; }
                public List<CardLevel> Levelup { get; set; }
                public List<string> Upgrades { get; set; }
                public List<SlotElement> UnlockableSlots { get; set; }
                public FarmerBonus FarmerBonus { get; set; }
                public QuartersTechnologiesPrice QuartersTechnologiesPrice { get; set; }
            }

            public partial class The22Spn2016AAbilities
            {
                public string PrimaryAbility { get; set; }
                public SlotElement SecondaryAbility { get; set; }
            }

            public partial class Items
            {
                public string PrimaryWeapon { get; set; }
                public string SecondaryWeapon { get; set; }
                public string HeavyWeapon { get; set; }
                public string Head { get; set; }
                public string Body { get; set; }
                public string Outfit { get; set; }
                public string Hands { get; set; }
                public string Boots { get; set; }
            }

            public partial class The22Spn2016AModifiers
            {
                public Dictionary<string, double> Additive { get; set; }
                public MultiplyClass Multiply { get; set; }
                public MultiplyClass Curves { get; set; }
                public MultiplyClass Reference { get; set; }
                public Dictionary<string, double> Ui { get; set; }
            }

            public partial class Ww2AClass
            {
                public long NumId { get; set; }
                public bool EnabledInGame { get; set; }
                public string Visual { get; set; }
                public string Collection { get; set; }
                public Role Role { get; set; }
                public The22Spn2016AModifiers Modifiers { get; set; }
                public Items Items { get; set; }
                public The22Spn2016AAbilities Abilities { get; set; }
                public List<string> PassiveAbilities { get; set; }
                public List<string> DefaultShopItems { get; set; }
                public long MaxXp { get; set; }
                public List<CardLevel> Levelup { get; set; }
                public List<string> Upgrades { get; set; }
                public List<object> UnlockableSlots { get; set; }
                public FarmerBonus FarmerBonus { get; set; }
                public MultiplyClass QuartersTechnologiesPrice { get; set; }
            }

            public partial class LevelRewardsConfigs
            {
                public LevelsBracketT1 LevelsBracketT1 { get; set; }
                public LevelsBracketT2 LevelsBracketT2 { get; set; }
                public LevelsBracketT3 LevelsBracketT3 { get; set; }
                public LevelsBracketT4 LevelsBracketT4 { get; set; }
            }

            public partial class LevelsBracketT1
            {
                public long StartLevel { get; set; }
                public long EndLevel { get; set; }
                public LevelsBracketT1MatchWinReward MatchWinReward { get; set; }
                public LevelsBracketT1DailyQuestReward DailyQuestReward { get; set; }
            }

            public partial class LevelsBracketT1DailyQuestReward
            {
                public ShopEntries5 ShopEntries { get; set; }
                public long Xp { get; set; }
            }

            public partial class ShopEntries5
            {
                public long ShopLootboxTranspDailyQuestCMt1 { get; set; }
            }

            public partial class LevelsBracketT1MatchWinReward
            {
                public ShopEntries6 ShopEntries { get; set; }
                public long Xp { get; set; }
            }

            public partial class ShopEntries6
            {
                public long ShopLootboxTranspWinBattleCMt1 { get; set; }
            }

            public partial class LevelsBracketT2
            {
                public long StartLevel { get; set; }
                public long EndLevel { get; set; }
                public LevelsBracketT2MatchWinReward MatchWinReward { get; set; }
                public LevelsBracketT2DailyQuestReward DailyQuestReward { get; set; }
            }

            public partial class LevelsBracketT2DailyQuestReward
            {
                public ShopEntries7 ShopEntries { get; set; }
                public long Xp { get; set; }
            }

            public partial class ShopEntries7
            {
                public long ShopLootboxTranspDailyQuestCMt2 { get; set; }
            }

            public partial class LevelsBracketT2MatchWinReward
            {
                public ShopEntries8 ShopEntries { get; set; }
                public long Xp { get; set; }
            }

            public partial class ShopEntries8
            {
                public long ShopLootboxTranspWinBattleCMt2 { get; set; }
            }

            public partial class LevelsBracketT3
            {
                public long StartLevel { get; set; }
                public long EndLevel { get; set; }
                public LevelsBracketT3MatchWinReward MatchWinReward { get; set; }
                public LevelsBracketT3DailyQuestReward DailyQuestReward { get; set; }
            }

            public partial class LevelsBracketT3DailyQuestReward
            {
                public ShopEntries9 ShopEntries { get; set; }
                public long Xp { get; set; }
            }

            public partial class ShopEntries9
            {
                public long ShopLootboxTranspDailyQuestCMt3 { get; set; }
            }

            public partial class LevelsBracketT3MatchWinReward
            {
                public ShopEntries10 ShopEntries { get; set; }
                public long Xp { get; set; }
            }

            public partial class ShopEntries10
            {
                public long ShopLootboxTranspWinBattleCMt3 { get; set; }
            }

            public partial class LevelsBracketT4
            {
                public long StartLevel { get; set; }
                public long EndLevel { get; set; }
                public LevelsBracketT4MatchWinReward MatchWinReward { get; set; }
                public LevelsBracketT4DailyQuestReward DailyQuestReward { get; set; }
            }

            public partial class LevelsBracketT4DailyQuestReward
            {
                public ShopEntries11 ShopEntries { get; set; }
                public long Xp { get; set; }
            }

            public partial class ShopEntries11
            {
                public long ShopLootboxTranspDailyQuestCMt4 { get; set; }
            }

            public partial class LevelsBracketT4MatchWinReward
            {
                public ShopEntries12 ShopEntries { get; set; }
                public long Xp { get; set; }
            }

            public partial class ShopEntries12
            {
                public long ShopLootboxTranspWinBattleCMt4 { get; set; }
            }

            public partial class LootBoxes
            {
                public LootboxAccountLevelTranspConsumableClass LootboxBattlepass2Consumables1 { get; set; }
                public LootboxBattlepass2ShopAnimAcEmotionW0Guitar LootboxBattlepass2ShopAnimAcEmotionW0Guitar { get; set; }
                public LootboxBattlepass2ShopSkinsetPatternsavannahbp2 LootboxBattlepass2ShopSkinsetPatternsavannahbp2 { get; set; }
                public LootboxBattlepass2ShopSkinsetPatterncheetahbp2 LootboxBattlepass2ShopSkinsetPatterncheetahbp2 { get; set; }
                public LootboxBattlepass LootboxBattlepass2ShopSkinsetPatternwetlandsbp2 { get; set; }
                public LootboxBattlepass2ShopAnimAcFatalityW0Armpit LootboxBattlepass2ShopAnimAcFatalityW0Armpit { get; set; }
                public LootboxBattlepass2ShopSkinsetPatterntigerbp2 LootboxBattlepass2ShopSkinsetPatterntigerbp2 { get; set; }
                public LootboxBattlepass2ShopAnimAcEmotionW0Toast LootboxBattlepass2ShopAnimAcEmotionW0Toast { get; set; }
                public LootboxBattlepass2ShopCardRaid2017 LootboxBattlepass2ShopCardRaid2017 { get; set; }
                public LootboxAccountLevelTranspConsumableClass LootboxRankedS1DailyFirstVictoryBronze { get; set; }
                public LootboxAccountLevelCustomizeClass LootboxRankedS1DailyFirstVictorySilver { get; set; }
                public LootboxAccountLevelCustomizeClass LootboxRankedS1DailyFirstVictoryGold { get; set; }
                public LootboxAccountLevelCustomizeClass LootboxRankedS1DailyFirstVictoryPlatinum { get; set; }
                public LootboxAccountLevelCustomizeClass LootboxRankedS1DailyFirstVictoryDiamond { get; set; }
                public LootboxRankedS1 LootboxRankedS1MaxLeagueSilver { get; set; }
                public LootboxRankedS1 LootboxRankedS1MaxLeagueGold { get; set; }
                public LootboxRankedS1 LootboxRankedS1MaxLeaguePlatinum { get; set; }
                public LootboxRankedS1 LootboxRankedS1MaxLeagueDiamond { get; set; }
                public LootboxRankedS1 LootboxRankedS1FinishingLeagueBronze { get; set; }
                public LootboxRankedS1FinishingLeague LootboxRankedS1FinishingLeagueSilver { get; set; }
                public LootboxRankedS1FinishingLeague LootboxRankedS1FinishingLeagueGold { get; set; }
                public LootboxRankedS1FinishingLeague LootboxRankedS1FinishingLeaguePlatinumEmotion { get; set; }
                public LootboxRankedS1FinishingLeagueFatality LootboxRankedS1FinishingLeaguePlatinumFatality { get; set; }
                public LootboxRankedS1FinishingLeague LootboxRankedS1FinishingLeagueDiamondEmotion { get; set; }
                public LootboxRankedS1FinishingLeagueFatality LootboxRankedS1FinishingLeagueDiamondFatality { get; set; }
                public LootboxDailyQuestCMt1X2Class LootboxWinBattleCmT1 { get; set; }
                public LootboxDailyQuestCMt2X2Class LootboxWinBattleCmT2 { get; set; }
                public LootboxDailyQuestCMt2X2Class LootboxWinBattleCmT3 { get; set; }
                public LootboxDailyQuestCMt4X2Class LootboxWinBattleCmT4 { get; set; }
                public LootboxDailyQuestCMt1X2Class LootboxDailyQuestCmT1 { get; set; }
                public LootboxDailyQuestCMt2X2Class LootboxDailyQuestCmT2 { get; set; }
                public LootboxDailyQuestCMt2X2Class LootboxDailyQuestCmT3 { get; set; }
                public LootboxDailyQuestCMt4X2Class LootboxDailyQuestCmT4 { get; set; }
                public LootboxDailyQuestCMt4X2Class LootboxShopCmBundle { get; set; }
                public LootboxDailyQuestCMt4X2Class LootboxPremiumCmBundle { get; set; }
                public LootboxBattlepass LootboxBattlepass3SkinsetPatternjaggedurbanbp3 { get; set; }
                public LootboxBattlepass LootboxBattlepass3SkinsetPatterntrizebrabp3 { get; set; }
                public LootboxBattlepass LootboxBattlepass3SkinsetPatternflecktarnminimalbp3 { get; set; }
                public LootboxBattlepass LootboxBattlepass3SkinsetPatternredcanyonbp3 { get; set; }
                public LootboxBattlepass LootboxBattlepass3SkinsetPatternturqdesertbp3 { get; set; }
                public LootboxAccountLevelTranspConsumableClass LootboxBattlepass3Consumables1 { get; set; }
                public LootboxBattlepass3CardNesher2015 LootboxBattlepass3CardNesher2015 { get; set; }
                public LootboxBattlepass LootboxBattlepass3AnimAcEmotionW0BlowKiss { get; set; }
                public LootboxBattlepass LootboxBattlepass3AnimAcEmotionW0HeartSign { get; set; }
                public LootboxBattlepass LootboxBattlepass3AnimAcEmotionW1OrderToDrop { get; set; }
                public LootboxBattlepass LootboxBattlepass3AnimAcFatalityW0TigerKnee { get; set; }
                public LootboxOfferSkinset1Class LootboxOfferSkinset1 { get; set; }
                public LootboxCompensationOperators LootboxCompensationOperators { get; set; }
                public LootboxNy21Ny20Content LootboxNy21Ny20Content { get; set; }
                public LootboxRankedS2FinishingLeagueDiamondLsClass LootboxSkinsetLsFsb2016 { get; set; }
                public LootboxFeb232021_Userbar LootboxFeb232021_Userbar { get; set; }
                public LootboxPatternFeb232021SkinFsb2004 LootboxPatternFeb232021SkinFsb2004 { get; set; }
                public LootboxPatternFeb232021SkinFsb2016 LootboxPatternFeb232021SkinFsb2016 { get; set; }
                public LootboxPatternFeb232021SkinSso2013 LootboxPatternFeb232021SkinSso2013 { get; set; }
                public LootboxPatternFeb232021Skin22Spn2016 LootboxPatternFeb232021Skin22Spn2016 { get; set; }
                public LootboxPatternFeb232021SkinGrom2014 LootboxPatternFeb232021SkinGrom2014 { get; set; }
                public LootboxPatternFeb232021SkinTfb2008 LootboxPatternFeb232021SkinTfb2008 { get; set; }
                public LootboxPatternFeb232021SkinRaid2017 LootboxPatternFeb232021SkinRaid2017 { get; set; }
                public LootboxPatternFeb232021SkinNesher2015 LootboxPatternFeb232021SkinNesher2015 { get; set; }
                public LootboxPatternFeb232021SkinKsk2011 LootboxPatternFeb232021SkinKsk2011 { get; set; }
                public LootboxPatternFeb232021SkinSeal2014 LootboxPatternFeb232021SkinSeal2014 { get; set; }
                public LootboxArchive4DailyClass LootboxT1Daily { get; set; }
                public LootboxArchive3DailyClass LootboxT2Daily { get; set; }
                public LootboxOfferSkinset1Class LootboxT1SkinsetPatterncheetahbp2 { get; set; }
                public LootboxOfferSkinset1Class LootboxT1SkinsetPatternsavannahbp2 { get; set; }
                public LootboxOfferSkinset1Class LootboxT1SkinsetPatterntigerbp2 { get; set; }
                public LootboxOfferSkinset1Class LootboxT1SkinsetPatternwetlandsbp2 { get; set; }
                public LootboxT2SkinsetPatternttred LootboxT2SkinsetPatternttred { get; set; }
                public LootboxT2SkinsetPatternwldesert2 LootboxT2SkinsetPatternwldesert2 { get; set; }
                public LootboxT2SkinsetPatternwlblue LootboxT2SkinsetPatternwlblue { get; set; }
                public LootboxT2SkinsetPatterndptropical LootboxT2SkinsetPatterndptropical { get; set; }
                public LootboxAccountLevelTranspConsumableClass LootboxBattlepass4Consumables1 { get; set; }
                public LootboxOfferSkinset1Class LootboxT1AnimAcEmotionW0Toast { get; set; }
                public LootboxOfferSkinset1Class LootboxT1AnimAcEmotionW0Guitar { get; set; }
                public LootboxOfferSkinset1Class LootboxT1AnimAcFatalityW0Armpit { get; set; }
                public LootboxT2AnimAcFatalityW0MightyFoot LootboxT2AnimAcFatalityW0MightyFoot { get; set; }
                public LootboxT2AnimAcEmotionW0SaluteMilitary LootboxT2AnimAcEmotionW0SaluteMilitary { get; set; }
                public LootboxT2AnimAcEmotionW1TakeOffHat LootboxT2AnimAcEmotionW1TakeOffHat { get; set; }
                public LootboxT2AnimAcEmotionW0Choke LootboxT2AnimAcEmotionW0Choke { get; set; }
                public LootboxT2AnimAcEmotionW0Teaparty LootboxT2AnimAcEmotionW0Teaparty { get; set; }
                public LootboxT2AnimAcEmotionW0OldSchoolBoxing LootboxT2AnimAcEmotionW0OldSchoolBoxing { get; set; }
                public LootboxBattlepass LootboxBattlepass4SkinsetPatternbp4Skin1 { get; set; }
                public LootboxBattlepass LootboxBattlepass4SkinsetPatternbp4Skin2 { get; set; }
                public LootboxBattlepass LootboxBattlepass4SkinsetPatternbp4Skin3 { get; set; }
                public LootboxBattlepass LootboxBattlepass4SkinsetPatternbp4Skin4 { get; set; }
                public LootboxBattlepass LootboxBattlepass4SkinsetPatternbp4Skin5 { get; set; }
                public LootboxBattlepass LootboxBattlepass4SkinsetPatternbp4Skin6 { get; set; }
                public LootboxBattlepass LootboxBattlepass4AnimAcEmotionW1Heli { get; set; }
                public LootboxBattlepass LootboxBattlepass4AnimAcEmotionW0EmotionalSwear { get; set; }
                public LootboxBattlepass LootboxBattlepass4AnimAcEmotionW0Corrida { get; set; }
                public LootboxBattlepass LootboxBattlepass4AnimAcFatalityW0BrutalCut { get; set; }
                public LootboxDailyQuestCMt1X2Class LootboxWinBattleCMt1X2 { get; set; }
                public LootboxDailyQuestCMt2X2Class LootboxWinBattleCMt2X2 { get; set; }
                public LootboxDailyQuestCMt2X2Class LootboxWinBattleCMt3X2 { get; set; }
                public LootboxDailyQuestCMt4X2Class LootboxWinBattleCMt4X2 { get; set; }
                public LootboxDailyQuestCMt1X2Class LootboxDailyQuestCMt1X2 { get; set; }
                public LootboxDailyQuestCMt2X2Class LootboxDailyQuestCMt2X2 { get; set; }
                public LootboxDailyQuestCMt2X2Class LootboxDailyQuestCMt3X2 { get; set; }
                public LootboxDailyQuestCMt4X2Class LootboxDailyQuestCMt4X2 { get; set; }
                public LootboxDailyQuestCMt4X2Class LootboxBattlepass4CmBundle { get; set; }
                public LootboxDailyQuestCMt4X2Class LootboxT1ShopCmBundle { get; set; }
                public LootboxDailyQuestCMt4X2Class LootboxT2ShopCmBundle { get; set; }
                public LootboxDailyQuestCMt4X2Class LootboxExpeditionWeeklyMaterials { get; set; }
                public LootboxSupplies LootboxExpeditionWeeklySupplies { get; set; }
                public LootboxSupplies LootboxExpeditionOracleSupplies { get; set; }
                public LootboxDailyQuestCMt4X2Class LootboxExpeditionPremiumMaterials { get; set; }
                public LootboxSupplies LootboxExpeditionPremiumSupplies { get; set; }
                public LootboxSupplies LootboxComplexQuestChapter2Supplies { get; set; }
                public LootboxSupplies LootboxComplexQuestChapter3Supplies { get; set; }
                public LootboxDailyQuestCMt4X2Class LootboxMarathonHacking2021 { get; set; }
                public LootboxDailyQuestCMt1X2Class LootboxDailyQuestCMt1X4 { get; set; }
                public LootboxDailyQuestCMt2X2Class LootboxDailyQuestCMt2X4 { get; set; }
                public LootboxDailyQuestCMt2X2Class LootboxDailyQuestCMt3X4 { get; set; }
                public LootboxDailyQuestCMt4X2Class LootboxDailyQuestCMt4X4 { get; set; }
                public LootboxArchive3DailyClass LootboxArchive3Daily { get; set; }
                public LootboxArchive3Patternjaggedurbanbp3 LootboxArchive3Patternjaggedurbanbp3 { get; set; }
                public LootboxArchive3Patterntrizebrabp3 LootboxArchive3Patterntrizebrabp3 { get; set; }
                public LootboxArchive3Patternflecktarnminimalbp3 LootboxArchive3Patternflecktarnminimalbp3 { get; set; }
                public LootboxArchive3Patternredcanyonbp3 LootboxArchive3Patternredcanyonbp3 { get; set; }
                public LootboxArchive3Patternturqdesertbp3 LootboxArchive3Patternturqdesertbp3 { get; set; }
                public LootboxArchive3AcEmotionW0BlowKiss LootboxArchive3AcEmotionW0BlowKiss { get; set; }
                public LootboxArchive3AcEmotionW0HeartSign LootboxArchive3AcEmotionW0HeartSign { get; set; }
                public LootboxArchive3AcEmotionW1OrderToDrop LootboxArchive3AcEmotionW1OrderToDrop { get; set; }
                public LootboxArchive3AcFatalityW0TigerKnee LootboxArchive3AcFatalityW0TigerKnee { get; set; }
                public LootboxDailyQuestCMt4X2Class LootboxArchive3Shopcmbundle { get; set; }
                public LootboxDailyQuestCMt2X2Class LootboxOfferCmT1T2 { get; set; }
                public LootboxDailyQuestCMt2X2Class LootboxOfferCmT1T3 { get; set; }
                public LootboxDailyQuestCMt4X2Class LootboxOfferCmT1T4 { get; set; }
                public LootboxOper LootboxOfferOper { get; set; }
                public LootboxOfferEpicSkin LootboxOfferEpicSkin { get; set; }
                public LootboxAccountLevelCustomizeClass LootboxOfferSkinSet { get; set; }
                public LootboxAccountLevelTranspConsumableClass LootboxRankedConsumables { get; set; }
                public LootboxRankedS2Patternrankeds1Red LootboxRankedS2Patternrankeds1Red { get; set; }
                public LootboxRankedS2Patternrankeds1Blue LootboxRankedS2Patternrankeds1Blue { get; set; }
                public LootboxRankedS2AcFatalityW0Heartbreaker LootboxRankedS2AcFatalityW0Heartbreaker { get; set; }
                public LootboxRankedS2AcEmotionW0Bowling LootboxRankedS2AcEmotionW0Bowling { get; set; }
                public LootboxAccountLevelTranspConsumableClass LootboxRankedS2DailyFirstVictoryBronze { get; set; }
                public LootboxRankedS LootboxRankedS2DailyFirstVictorySilver { get; set; }
                public LootboxRankedS LootboxRankedS2DailyFirstVictoryGold { get; set; }
                public LootboxRankedS LootboxRankedS2DailyFirstVictoryPlatinum { get; set; }
                public LootboxRankedS LootboxRankedS2DailyFirstVictoryDiamond { get; set; }
                public LootboxDailyQuestCMt4X2Class LootboxRankedS2FinishingLeagueBronze { get; set; }
                public LootboxDailyQuestCMt4X2Class LootboxRankedS2FinishingLeagueSilver { get; set; }
                public LootboxDailyQuestCMt4X2Class LootboxRankedS2FinishingLeagueGold { get; set; }
                public LootboxDailyQuestCMt4X2Class LootboxRankedS2FinishingLeaguePlatinum { get; set; }
                public LootboxDailyQuestCMt4X2Class LootboxRankedS2FinishingLeagueDiamond { get; set; }
                public LootboxRankedS2FinishingLeagueDiamondLsClass LootboxRankedS2FinishingLeaguePlatinumLs { get; set; }
                public LootboxRankedS2FinishingLeagueDiamondLsClass LootboxRankedS2FinishingLeagueDiamondLs { get; set; }
                public LootboxRankedS2PatternRankedS2Sapphire LootboxRankedS2PatternRankedS2Sapphire { get; set; }
                public LootboxRankedS2PatternRankedS2Woodsplinter LootboxRankedS2PatternRankedS2Woodsplinter { get; set; }
                public LootboxRankedS2AcEmotionW0Bullet LootboxRankedS2AcEmotionW0Bullet { get; set; }
                public LootboxMay2022OperClass LootboxOnboardingOperators { get; set; }
                public LootboxAccountLevelCustomizeClass LootboxHardRotationEvent { get; set; }
                public LootboxPatternOnslaught2021Skin1 LootboxPatternOnslaught2021Skin1 { get; set; }
                public LootboxPatternOnslaught2021Skin2 LootboxPatternOnslaught2021Skin2 { get; set; }
                public LootboxOnslaught2021AcEmotionW0HurryUp LootboxOnslaught2021AcEmotionW0HurryUp { get; set; }
                public LootboxAccountLevelTranspConsumableClass LootboxBp5Consumables { get; set; }
                public LootboxPatternBp5Skin2 LootboxPatternBp5Skin2 { get; set; }
                public LootboxBp5CardArystan LootboxBp5CardArystan { get; set; }
                public LootboxDailyQuestCMt1X2Class LootboxTranspBp5CMt1 { get; set; }
                public LootboxTranspBp5CMt2 LootboxTranspBp5CMt2 { get; set; }
                public LootboxTranspBp5CMt3T4 LootboxTranspBp5CMt3T4 { get; set; }
                public LootboxSupplies LootboxAccountLevelSupplies { get; set; }
                public LootboxAccountLevelCustomizeClass LootboxAccountLevelCustomize { get; set; }
                public LootboxMainEmblems LootboxMainEmblems { get; set; }
                public LootboxMainHqStyle LootboxMainHqStyle { get; set; }
                public LootboxAccountLevelCustomizeClass LootboxMainEmotionOper { get; set; }
                public LootboxAccountLevelCustomizeClass LootboxMainFatalityOper { get; set; }
                public LootboxAccountLevelCustomizeClass LootboxMainSkinsetOper { get; set; }
                public LootboxAccountLevelCustomizeClass LootboxMainSkinGroupOper { get; set; }
                public LootboxAccountLevelCustomizeClass LootboxMainEmotionCol { get; set; }
                public LootboxAccountLevelCustomizeClass LootboxMainFatalityCol { get; set; }
                public LootboxAccountLevelCustomizeClass LootboxMainSkinsetCol { get; set; }
                public LootboxAccountLevelCustomizeClass LootboxMainSkinGroupCol { get; set; }
                public LootboxMainSkinsetLegendary LootboxMainSkinsetLegendary { get; set; }
                public LootboxAccountLevelCustomizeClass LootboxMainMix1 { get; set; }
                public LootboxDailyQuestCMt1X2Class LootboxTranspWinBattleCMt1 { get; set; }
                public LootboxDailyQuestCMt2X2Class LootboxTranspWinBattleCMt2 { get; set; }
                public LootboxDailyQuestCMt2X2Class LootboxTranspWinBattleCMt3 { get; set; }
                public LootboxDailyQuestCMt4X2Class LootboxTranspWinBattleCMt4 { get; set; }
                public LootboxDailyQuestCMt1X2Class LootboxTranspDailyQuestCMt1 { get; set; }
                public LootboxDailyQuestCMt2X2Class LootboxTranspDailyQuestCMt2 { get; set; }
                public LootboxDailyQuestCMt2X2Class LootboxTranspDailyQuestCMt3 { get; set; }
                public LootboxDailyQuestCMt4X2Class LootboxTranspDailyQuestCMt4 { get; set; }
                public LootboxDailyQuestCMt1X2Class LootboxTranspWinBattleCMt1X2 { get; set; }
                public LootboxDailyQuestCMt2X2Class LootboxTranspWinBattleCMt2X2 { get; set; }
                public LootboxDailyQuestCMt2X2Class LootboxTranspWinBattleCMt3X2 { get; set; }
                public LootboxDailyQuestCMt4X2Class LootboxTranspWinBattleCMt4X2 { get; set; }
                public LootboxDailyQuestCMt1X2Class LootboxTranspDailyQuestCMt1X2 { get; set; }
                public LootboxDailyQuestCMt2X2Class LootboxTranspDailyQuestCMt2X2 { get; set; }
                public LootboxDailyQuestCMt2X2Class LootboxTranspDailyQuestCMt3X2 { get; set; }
                public LootboxDailyQuestCMt4X2Class LootboxTranspDailyQuestCMt4X2 { get; set; }
                public LootboxDailyQuestCMt4X2Class LootboxTranspExpeditionWeeklyMaterials { get; set; }
                public LootboxDailyQuestCMt4X2Class LootboxTranspExpeditionPremiumMaterials { get; set; }
                public LootboxDailyQuestCMt4X2Class LootboxTranspShopCmBundle { get; set; }
                public LootboxDailyQuestCMt4X2Class LootboxTranspPremiumCmBundle { get; set; }
                public LootboxDailyQuestCMt4X2Class LootboxTranspArchive1ShopCmBundle { get; set; }
                public LootboxDailyQuestCMt4X2Class LootboxTranspArchive2ShopCmBundle { get; set; }
                public LootboxDailyQuestCMt4X2Class LootboxTranspArchive3ShopCmBundle { get; set; }
                public LootboxDailyQuestCMt4X2Class LootboxTranspArchive4ShopCmBundle { get; set; }
                public LootboxDailyQuestCMt2X2Class LootboxTranspOfferCMt1T2 { get; set; }
                public LootboxDailyQuestCMt2X2Class LootboxTranspOfferCMt1T3 { get; set; }
                public LootboxDailyQuestCMt4X2Class LootboxTranspOfferCMt1T4 { get; set; }
                public LootboxAccountLevelTranspConsumableClass LootboxRankedS3DailyFirstVictoryBronze { get; set; }
                public LootboxRankedS LootboxRankedS3DailyFirstVictorySilver { get; set; }
                public LootboxRankedS LootboxRankedS3DailyFirstVictoryGold { get; set; }
                public LootboxRankedS LootboxRankedS3DailyFirstVictoryPlatinum { get; set; }
                public LootboxRankedS LootboxRankedS3DailyFirstVictoryDiamond { get; set; }
                public LootboxDailyQuestCMt4X2Class LootboxRankedS3FinishingLeagueBronze { get; set; }
                public LootboxDailyQuestCMt4X2Class LootboxRankedS3FinishingLeagueSilver { get; set; }
                public LootboxDailyQuestCMt4X2Class LootboxRankedS3FinishingLeagueGold { get; set; }
                public LootboxDailyQuestCMt4X2Class LootboxRankedS3FinishingLeaguePlatinum { get; set; }
                public LootboxRankedS3FinishingLeagueLs LootboxRankedS3FinishingLeaguePlatinumLs { get; set; }
                public LootboxDailyQuestCMt4X2Class LootboxRankedS3FinishingLeagueDiamond { get; set; }
                public LootboxRankedS3FinishingLeagueLs LootboxRankedS3FinishingLeagueDiamondLs { get; set; }
                public LootboxBirthday2021 LootboxBirthday2021 { get; set; }
                public LootboxArchive4DailyClass LootboxArchive4Daily { get; set; }
                public LootboxArchive4PatternBp4Skin1 LootboxArchive4PatternBp4Skin1 { get; set; }
                public LootboxArchive4PatternBp4Skin2 LootboxArchive4PatternBp4Skin2 { get; set; }
                public LootboxArchive4PatternBp4Skin3 LootboxArchive4PatternBp4Skin3 { get; set; }
                public LootboxArchive4PatternBp4Skin4 LootboxArchive4PatternBp4Skin4 { get; set; }
                public LootboxArchive4PatternBp4Skin5 LootboxArchive4PatternBp4Skin5 { get; set; }
                public LootboxArchive4PatternBp4Skin6 LootboxArchive4PatternBp4Skin6 { get; set; }
                public LootboxArchive4AcEmotionW1Heli LootboxArchive4AcEmotionW1Heli { get; set; }
                public LootboxArchive4AcEmotionW0EmotionalSwear LootboxArchive4AcEmotionW0EmotionalSwear { get; set; }
                public LootboxArchive4AcEmotionW0Corrida LootboxArchive4AcEmotionW0Corrida { get; set; }
                public LootboxArchive4AcFatalityW0BrutalCutClass LootboxArchive4AcFatalityW0BrutalCut { get; set; }
                public LootboxAccountLevelTranspEmblems LootboxAccountLevelTranspEmblems { get; set; }
                public LootboxAccountLevelCustomizeClass LootboxAccountLevelTranspSkinSetCol { get; set; }
                public LootboxAccountLevelCustomizeClass LootboxAccountLevelTranspEmotionCol { get; set; }
                public LootboxAccountLevelTranspFatalityCol LootboxAccountLevelTranspFatalityCol { get; set; }
                public LootboxAccountLevelTranspConsumableClass LootboxAccountLevelTranspConsumable { get; set; }
                public LootboxBirthday2021Emotion LootboxBirthday2021Emotion { get; set; }
                public LootboxRankedS4PatternRankedS4ForestSunrise LootboxRankedS4PatternRankedS4ForestSunrise { get; set; }
                public LootboxRankedS4PatternRankedS4Pangolin LootboxRankedS4PatternRankedS4Pangolin { get; set; }
                public LootboxRankedS4AcFatalityW0Slap LootboxRankedS4AcFatalityW0Slap { get; set; }
                public LootboxAccountLevelTranspConsumableClass LootboxRankedS4DailyFirstVictoryBronze { get; set; }
                public LootboxRankedS LootboxRankedS4DailyFirstVictorySilver { get; set; }
                public LootboxRankedS LootboxRankedS4DailyFirstVictoryGold { get; set; }
                public LootboxRankedS LootboxRankedS4DailyFirstVictoryPlatinum { get; set; }
                public LootboxRankedS LootboxRankedS4DailyFirstVictoryDiamond { get; set; }
                public LootboxDailyQuestCMt4X2Class LootboxRankedS4FinishingLeagueBronze { get; set; }
                public LootboxDailyQuestCMt4X2Class LootboxRankedS4FinishingLeagueSilver { get; set; }
                public LootboxDailyQuestCMt4X2Class LootboxRankedS4FinishingLeagueGold { get; set; }
                public LootboxDailyQuestCMt4X2Class LootboxRankedS4FinishingLeaguePlatinum { get; set; }
                public LootboxRankedS4FinishingLeagueLs LootboxRankedS4FinishingLeaguePlatinumLs { get; set; }
                public LootboxDailyQuestCMt4X2Class LootboxRankedS4FinishingLeagueDiamond { get; set; }
                public LootboxRankedS4FinishingLeagueLs LootboxRankedS4FinishingLeagueDiamondLs { get; set; }
                public LootboxDailyQuestCMt4X2Class LootboxTranspNy22ShopCmBundle { get; set; }
                public LootboxMay2022OperClass LootboxNy22Oper { get; set; }
                public LootboxTwitchHard500 LootboxTwitchHard500 { get; set; }
                public LootboxTwitchPrem LootboxTwitchPrem1 { get; set; }
                public LootboxTwitchPrem LootboxTwitchPrem3 { get; set; }
                public LootboxTwitchPrem7 LootboxTwitchPrem7 { get; set; }
                public LootboxAccountLevelCustomizeClass LootboxTwitchEmotionOper { get; set; }
                public LootboxTwitchFatalityOper LootboxTwitchFatalityOper { get; set; }
                public LootboxTwitchPartyPopperAll LootboxTwitchPartyPopperAll { get; set; }
                public LootboxArchive4AcFatalityW0BrutalCutClass LootboxTwitchBrutalCutAll { get; set; }
                public LootboxTwitchPartyBlowerAll LootboxTwitchPartyBlowerAll { get; set; }
                public LootboxTwitchSoft LootboxTwitchSoft7500 { get; set; }
                public LootboxTwitchSoft LootboxTwitchSoft10000 { get; set; }
                public LootboxAccountLevelTranspConsumableClass LootboxTwitchConsumables1 { get; set; }
                public LootboxDailyQuestCMt4X2Class LootboxTwitchTranspShopCmBundle { get; set; }
                public LootboxTwitchLs22Spn2016M LootboxTwitchLs22Spn2016M { get; set; }
                public LootboxTwitchLsSeal2014G LootboxTwitchLsSeal2014G { get; set; }
                public LootboxTwitchLsSeal2014S LootboxTwitchLsSeal2014S { get; set; }
                public LootboxTwitchLs22Spn2016A LootboxTwitchLs22Spn2016A { get; set; }
                public LootboxOper LootboxTwitchOper { get; set; }
                public LootboxTranspPatternBp7Skin1 LootboxTranspPatternBp7Skin1 { get; set; }
                public LootboxTranspAcEmotionW0Laugh LootboxTranspAcEmotionW0Laugh { get; set; }
                public LootboxTranspAcEmotionW0ThreePoint LootboxTranspAcEmotionW0ThreePoint { get; set; }
                public LootboxAccountLevelTranspConsumableClass LootboxBp7Consumables { get; set; }
                public LootboxBp7CardSweden LootboxBp7CardSweden { get; set; }
                public LootboxDailyQuestCMt1X2Class LootboxTranspBp7CMt1 { get; set; }
                public LootboxDailyQuestCMt2X2Class LootboxTranspBp7CMt1T2 { get; set; }
                public LootboxDailyQuestCMt2X2Class LootboxTranspBp7CMt1T3 { get; set; }
                public LootboxDailyQuestCMt4X2Class LootboxTranspBp7CMt1T4 { get; set; }
                public LootboxAccountLevelTranspConsumableClass LootboxRankedS5DailyFirstVictoryBronze { get; set; }
                public LootboxRankedS5DailyFirstVictory LootboxRankedS5DailyFirstVictorySilver { get; set; }
                public LootboxRankedS5DailyFirstVictory LootboxRankedS5DailyFirstVictoryGold { get; set; }
                public LootboxRankedS5DailyFirstVictory LootboxRankedS5DailyFirstVictoryPlatinum { get; set; }
                public LootboxRankedS5PatternRankedS5Diswale LootboxRankedS5PatternRankedS5Diswale { get; set; }
                public LootboxRankedS5AcEmotionW0Ggwp LootboxRankedS5AcEmotionW0Ggwp { get; set; }
                public LootboxIntercept2022AcEmotionW0Fingerbang LootboxIntercept2022AcEmotionW0FingerbangCol { get; set; }
                public LootboxIntercept2022AcEmotionW0Fingerbang LootboxIntercept2022AcEmotionW0Fingerbang { get; set; }
                public LootboxIntercept2022PatternIntercept2022Giraffe LootboxIntercept2022PatternIntercept2022GiraffeCol { get; set; }
                public LootboxIntercept2022PatternIntercept2022Giraffe LootboxIntercept2022PatternIntercept2022Giraffe { get; set; }
                public LootboxAccountLevelCustomizeClass LootboxFeb232022_Anim { get; set; }
                public LootboxFeb232022_Skin LootboxFeb232022_Skin { get; set; }
                public LootboxMay2022Emblem LootboxMay2022Emblem { get; set; }
                public LootboxMay2022Skinset LootboxMay2022Skinset { get; set; }
                public LootboxMay2022Emotions LootboxMay2022Emotions { get; set; }
                public LootboxMay2022Fatality LootboxMay2022Fatality { get; set; }
                public LootboxMay2022OperClass LootboxMay2022Oper { get; set; }
                public LootboxMay2022Consumables LootboxMay2022Consumables { get; set; }
                public LootboxOfferRareOper LootboxOfferRareOper { get; set; }
                public LootboxAccountLevelTranspConsumableClass LootboxTwitch2022Consumables { get; set; }
                public LootboxTwitch2022Boosters LootboxTwitch2022Boosters { get; set; }
                public LootboxMay2022Skinset LootboxTwitch2022May2022Skinset { get; set; }
                public LootboxMay2022Emotions LootboxTwitch2022May2022Emotions { get; set; }
                public LootboxMay2022Fatality LootboxTwitch2022May2022Fatality { get; set; }
                public LootboxTwitch2022Emblem LootboxTwitch2022Emblem { get; set; }
                public LootboxTwitch2022EmotionClapperboardAll LootboxTwitch2022EmotionClapperboardAll { get; set; }
                public LootboxTwitch2022PatternTwitch2022Skin1 LootboxTwitch2022PatternTwitch2022Skin1 { get; set; }
                public LootboxTwitch2022May2022Token LootboxTwitch2022May2022Token { get; set; }
                public LootboxTwitch2022Es1Seal2014S LootboxTwitch2022Es1Seal2014S { get; set; }
            }

            public partial class LootboxAccountLevelCustomizeClass
            {
                public long Group { get; set; }
                public string Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<LootboxAccountLevelCustomizeSlot> Slots { get; set; }
                public List<LootboxAccountLevelCustomizeDeployPrice> OpenPrices { get; set; }
            }

            public partial class LootboxAccountLevelCustomizeSlot
            {
                public SlotName Name { get; set; }
                public long Weight { get; set; }
                public bool SuppressDoubles { get; set; }
                public List<ExpeditionRewardFeb232022FlaskSlot1Variant> Items { get; set; }
            }

            public partial class LootboxSupplies
            {
                public long Group { get; set; }
                public SkinVisualEnum Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<LootboxAccountLevelSuppliesSlot> Slots { get; set; }
            }

            public partial class LootboxAccountLevelSuppliesSlot
            {
                public SlotName Name { get; set; }
                public long Weight { get; set; }
                public bool SuppressDoubles { get; set; }
                public List<TentacledItem> Items { get; set; }
            }

            public partial class TentacledItem
            {
                public IndecentName Name { get; set; }
                public long Weight { get; set; }
                public Reward5 Reward { get; set; }
            }

            public partial class Reward5
            {
                public ShopEntries13 ShopEntries { get; set; }
                public long Xp { get; set; }
            }

            public partial class ShopEntries13
            {
                public long? ShopCurrencyStaminaRegenBooster { get; set; }
                public long? ShopCurrencyHealthPack { get; set; }
                public long? ShopCurrencySpecialRevive { get; set; }
                public long? ShopCurrencyArmorPack { get; set; }
                public long? ShopCurrencyAmmoPack { get; set; }
                public long? ShopCurrencyXpBooster { get; set; }
                public long? ShopCurrencyCreditsBooster { get; set; }
            }

            public partial class LootboxAccountLevelTranspConsumableClass
            {
                public long Group { get; set; }
                public string Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<RerollPriceElement> OpenPrices { get; set; }
                public List<LootboxAccountLevelTranspConsumableSlot> Slots { get; set; }
            }

            public partial class LootboxAccountLevelTranspConsumableSlot
            {
                public SlotName Name { get; set; }
                public long Weight { get; set; }
                public bool SuppressDoubles { get; set; }
                public List<StickyItem> Items { get; set; }
            }

            public partial class StickyItem
            {
                public IndecentName Name { get; set; }
                public long Weight { get; set; }
                public Reward6 Reward { get; set; }
            }

            public partial class Reward6
            {
                public ShopEntries14 ShopEntries { get; set; }
                public long Xp { get; set; }
            }

            public partial class ShopEntries14
            {
                public long? ShopCurrencyStaminaRegenBooster { get; set; }
                public long? ShopCurrencyHealthPack { get; set; }
                public long? ShopCurrencySpecialRevive { get; set; }
                public long? ShopCurrencyArmorPack { get; set; }
                public long? ShopCurrencyAmmoPack { get; set; }
            }

            public partial class LootboxAccountLevelTranspEmblems
            {
                public long Group { get; set; }
                public string Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<RerollPriceElement> OpenPrices { get; set; }
                public List<LootboxAccountLevelCustomizeSlot> Slots { get; set; }
            }

            public partial class LootboxAccountLevelTranspFatalityCol
            {
                public long Group { get; set; }
                public string Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<RerollPriceElement> OpenPrices { get; set; }
                public List<LootboxAccountLevelCustomizeSlot> Slots { get; set; }
            }

            public partial class LootboxArchive3AcEmotionW0BlowKiss
            {
                public long Group { get; set; }
                public string Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<LootboxAccountLevelCustomizeSlot> Slots { get; set; }
            }

            public partial class LootboxArchive3AcEmotionW0HeartSign
            {
                public long Group { get; set; }
                public string Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<LootboxAccountLevelCustomizeSlot> Slots { get; set; }
            }

            public partial class LootboxArchive3AcEmotionW1OrderToDrop
            {
                public long Group { get; set; }
                public string Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<LootboxAccountLevelCustomizeSlot> Slots { get; set; }
            }

            public partial class LootboxArchive3AcFatalityW0TigerKnee
            {
                public long Group { get; set; }
                public string Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<LootboxAccountLevelCustomizeSlot> Slots { get; set; }
            }

            public partial class LootboxArchive3DailyClass
            {
                public long Group { get; set; }
                public string Visual { get; set; }
                public LocaleKeyEnum LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<LootboxDailyQuestCMt4X2Slot> Slots { get; set; }
            }

            public partial class LootboxDailyQuestCMt4X2Slot
            {
                public SlotName Name { get; set; }
                public long Weight { get; set; }
                public bool SuppressDoubles { get; set; }
                public List<ExpeditionRewardEventNordWindSlotMatsVariant> Items { get; set; }
            }

            public partial class LootboxArchive3Patternflecktarnminimalbp3
            {
                public long Group { get; set; }
                public string Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<LootboxAccountLevelCustomizeSlot> Slots { get; set; }
            }

            public partial class LootboxArchive3Patternjaggedurbanbp3
            {
                public long Group { get; set; }
                public string Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<LootboxAccountLevelCustomizeSlot> Slots { get; set; }
            }

            public partial class LootboxArchive3Patternredcanyonbp3
            {
                public long Group { get; set; }
                public string Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<LootboxAccountLevelCustomizeSlot> Slots { get; set; }
            }

            public partial class LootboxArchive3Patterntrizebrabp3
            {
                public long Group { get; set; }
                public string Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<LootboxAccountLevelCustomizeSlot> Slots { get; set; }
            }

            public partial class LootboxArchive3Patternturqdesertbp3
            {
                public long Group { get; set; }
                public string Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<LootboxAccountLevelCustomizeSlot> Slots { get; set; }
            }

            public partial class LootboxDailyQuestCMt4X2Class
            {
                public long Group { get; set; }
                public string Visual { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<LootboxDailyQuestCMt4X2Slot> Slots { get; set; }
                public string LocaleKey { get; set; }
                public List<DeployPriceElement> OpenPrices { get; set; }
            }

            public partial class LootboxArchive4AcEmotionW0Corrida
            {
                public long Group { get; set; }
                public string Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<LootboxAccountLevelCustomizeSlot> Slots { get; set; }
            }

            public partial class LootboxArchive4AcEmotionW0EmotionalSwear
            {
                public long Group { get; set; }
                public string Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<LootboxAccountLevelCustomizeSlot> Slots { get; set; }
            }

            public partial class LootboxArchive4AcEmotionW1Heli
            {
                public long Group { get; set; }
                public string Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<LootboxAccountLevelCustomizeSlot> Slots { get; set; }
            }

            public partial class LootboxArchive4AcFatalityW0BrutalCutClass
            {
                public long Group { get; set; }
                public string Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<LootboxAccountLevelCustomizeSlot> Slots { get; set; }
            }

            public partial class LootboxArchive4DailyClass
            {
                public long Group { get; set; }
                public string Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<LootboxDailyQuestCMt2X2Slot> Slots { get; set; }
            }

            public partial class LootboxDailyQuestCMt2X2Slot
            {
                public SlotName Name { get; set; }
                public long Weight { get; set; }
                public bool SuppressDoubles { get; set; }
                public List<ExpeditionRewardEventNordWindNovSlot2Variant> Items { get; set; }
            }

            public partial class LootboxArchive4PatternBp4Skin1
            {
                public long Group { get; set; }
                public string Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<LootboxAccountLevelCustomizeSlot> Slots { get; set; }
            }

            public partial class LootboxArchive4PatternBp4Skin2
            {
                public long Group { get; set; }
                public string Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<LootboxAccountLevelCustomizeSlot> Slots { get; set; }
            }

            public partial class LootboxArchive4PatternBp4Skin3
            {
                public long Group { get; set; }
                public string Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<LootboxAccountLevelCustomizeSlot> Slots { get; set; }
            }

            public partial class LootboxArchive4PatternBp4Skin4
            {
                public long Group { get; set; }
                public string Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<LootboxAccountLevelCustomizeSlot> Slots { get; set; }
            }

            public partial class LootboxArchive4PatternBp4Skin5
            {
                public long Group { get; set; }
                public string Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<LootboxAccountLevelCustomizeSlot> Slots { get; set; }
            }

            public partial class LootboxArchive4PatternBp4Skin6
            {
                public long Group { get; set; }
                public string Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<LootboxAccountLevelCustomizeSlot> Slots { get; set; }
            }

            public partial class LootboxBattlepass2ShopAnimAcEmotionW0Guitar
            {
                public long Group { get; set; }
                public string Visual { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<LootboxAccountLevelCustomizeSlot> Slots { get; set; }
            }

            public partial class LootboxBattlepass2ShopAnimAcEmotionW0Toast
            {
                public long Group { get; set; }
                public string Visual { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<LootboxAccountLevelCustomizeSlot> Slots { get; set; }
            }

            public partial class LootboxBattlepass2ShopAnimAcFatalityW0Armpit
            {
                public long Group { get; set; }
                public string Visual { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<LootboxAccountLevelCustomizeSlot> Slots { get; set; }
            }

            public partial class LootboxBattlepass2ShopCardRaid2017
            {
                public long Group { get; set; }
                public string Visual { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<DeployPriceElement> OpenPrices { get; set; }
                public List<LootboxBattlepass2ShopCardRaid2017Slot> Slots { get; set; }
            }

            public partial class LootboxBattlepass2ShopCardRaid2017Slot
            {
                public SlotName Name { get; set; }
                public long Weight { get; set; }
                public bool SuppressDoubles { get; set; }
                public List<Item4> Items { get; set; }
            }

            public partial class Item4
            {
                public string Name { get; set; }
                public long Weight { get; set; }
                public Reward17 Reward { get; set; }
            }

            public partial class Reward17
            {
                public ShopEntries25 ShopEntries { get; set; }
                public long Xp { get; set; }
            }

            public partial class ShopEntries25
            {
                public long? ShopCardRaid2017A { get; set; }
                public long? ShopCardRaid2017G { get; set; }
                public long? ShopCardRaid2017M { get; set; }
                public long? ShopCardRaid2017S { get; set; }
            }

            public partial class LootboxBattlepass2ShopSkinsetPatterncheetahbp2
            {
                public long Group { get; set; }
                public string Visual { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<LootboxAccountLevelCustomizeSlot> Slots { get; set; }
            }

            public partial class LootboxBattlepass2ShopSkinsetPatternsavannahbp2
            {
                public long Group { get; set; }
                public string Visual { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<LootboxAccountLevelCustomizeSlot> Slots { get; set; }
            }

            public partial class LootboxBattlepass2ShopSkinsetPatterntigerbp2
            {
                public long Group { get; set; }
                public string Visual { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<LootboxAccountLevelCustomizeSlot> Slots { get; set; }
            }

            public partial class LootboxBattlepass
            {
                public long Group { get; set; }
                public string Visual { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<LootboxAccountLevelCustomizeSlot> Slots { get; set; }
            }

            public partial class LootboxBattlepass3CardNesher2015
            {
                public long Group { get; set; }
                public string Visual { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<DeployPriceElement> OpenPrices { get; set; }
                public List<LootboxBattlepass3CardNesher2015Slot> Slots { get; set; }
            }

            public partial class LootboxBattlepass3CardNesher2015Slot
            {
                public SlotName Name { get; set; }
                public long Weight { get; set; }
                public bool SuppressDoubles { get; set; }
                public List<Item5> Items { get; set; }
            }

            public partial class Item5
            {
                public string Name { get; set; }
                public long Weight { get; set; }
                public Reward18 Reward { get; set; }
            }

            public partial class Reward18
            {
                public ShopEntries26 ShopEntries { get; set; }
                public long Xp { get; set; }
            }

            public partial class ShopEntries26
            {
                public long? ShopCardNesher2015A { get; set; }
                public long? ShopCardNesher2015G { get; set; }
                public long? ShopCardNesher2015M { get; set; }
                public long? ShopCardNesher2015S { get; set; }
            }

            public partial class LootboxBirthday2021
            {
                public long Group { get; set; }
                public string Visual { get; set; }
                public LocaleKeyEnum LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<DeployPriceElement> OpenPrices { get; set; }
                public List<LootboxBirthday2021Slot> Slots { get; set; }
            }

            public partial class LootboxBirthday2021Slot
            {
                public SlotName Name { get; set; }
                public long Weight { get; set; }
                public bool SuppressDoubles { get; set; }
                public List<IndigoItem> Items { get; set; }
            }

            public partial class IndigoItem
            {
                public string Name { get; set; }
                public long Weight { get; set; }
                public Reward7 Reward { get; set; }
            }

            public partial class Reward7
            {
                public ShopEntries15 ShopEntries { get; set; }
                public long Xp { get; set; }
            }

            public partial class ShopEntries15
            {
                public long? ShopCardNesher2015A { get; set; }
                public long? ShopCardEzapacg { get; set; }
                public long? ShopCardEzapacm { get; set; }
                public long? ShopCardNesher2015S { get; set; }
            }

            public partial class LootboxBirthday2021Emotion
            {
                public long Group { get; set; }
                public string Visual { get; set; }
                public LocaleKeyEnum LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<LootboxAccountLevelCustomizeSlot> Slots { get; set; }
            }

            public partial class LootboxBp5CardArystan
            {
                public long Group { get; set; }
                public string Visual { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<DeployPriceElement> OpenPrices { get; set; }
                public List<LootboxBp5CardArystanSlot> Slots { get; set; }
            }

            public partial class LootboxBp5CardArystanSlot
            {
                public SlotName Name { get; set; }
                public long Weight { get; set; }
                public bool SuppressDoubles { get; set; }
                public List<IndecentItem> Items { get; set; }
            }

            public partial class IndecentItem
            {
                public string Name { get; set; }
                public long Weight { get; set; }
                public Reward8 Reward { get; set; }
            }

            public partial class Reward8
            {
                public ShopEntries16 ShopEntries { get; set; }
                public long Xp { get; set; }
            }

            public partial class ShopEntries16
            {
                public long? ShopCardArystana { get; set; }
                public long? ShopCardArystang { get; set; }
                public long? ShopCardArystanm { get; set; }
                public long? ShopCardArystans { get; set; }
            }

            public partial class LootboxBp7CardSweden
            {
                public long Group { get; set; }
                public string Visual { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<DeployPriceElement> OpenPrices { get; set; }
                public List<LootboxBp7CardSwedenSlot> Slots { get; set; }
            }

            public partial class LootboxBp7CardSwedenSlot
            {
                public SlotName Name { get; set; }
                public long Weight { get; set; }
                public bool SuppressDoubles { get; set; }
                public List<HilariousItem> Items { get; set; }
            }

            public partial class HilariousItem
            {
                public string Name { get; set; }
                public long Weight { get; set; }
                public Reward9 Reward { get; set; }
            }

            public partial class Reward9
            {
                public ShopEntries17 ShopEntries { get; set; }
                public long Xp { get; set; }
            }

            public partial class ShopEntries17
            {
                public long? ShopCardAmfa { get; set; }
                public long? ShopCardAmfg { get; set; }
                public long? ShopCardAmfm { get; set; }
                public long? ShopCardAmfs { get; set; }
            }

            public partial class LootboxCompensationOperators
            {
                public long Group { get; set; }
                public SkinVisualEnum Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<LootboxAccountLevelCustomizeSlot> Slots { get; set; }
            }

            public partial class LootboxDailyQuestCMt1X2Class
            {
                public long Group { get; set; }
                public LootboxDailyQuestCMt1X2Visual Visual { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<LootboxDailyQuestCMt1X2Slot> Slots { get; set; }
                public string LocaleKey { get; set; }
                public List<DeployPriceElement> OpenPrices { get; set; }
            }

            public partial class LootboxDailyQuestCMt1X2Slot
            {
                public SlotName Name { get; set; }
                public long Weight { get; set; }
                public bool SuppressDoubles { get; set; }
                public List<ExpeditionRewardEventNordWindNovSlot1Variant> Items { get; set; }
            }

            public partial class LootboxDailyQuestCMt2X2Class
            {
                public long Group { get; set; }
                public LootboxDailyQuestCMt1X2Visual Visual { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<LootboxDailyQuestCMt2X2Slot> Slots { get; set; }
                public string LocaleKey { get; set; }
                public List<DeployPriceElement> OpenPrices { get; set; }
            }

            public partial class LootboxFeb232021_Userbar
            {
                public long Group { get; set; }
                public string Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<OpenPrice> OpenPrices { get; set; }
                public List<LootboxFeb232021_UserbarSlot> Slots { get; set; }
            }

            public partial class OpenPrice
            {
                public TentacledValues Values { get; set; }
            }

            public partial class TentacledValues
            {
                public long? Feb23Token { get; set; }
            }

            public partial class LootboxFeb232021_UserbarSlot
            {
                public SlotName Name { get; set; }
                public long Weight { get; set; }
                public bool SuppressDoubles { get; set; }
                public List<Item6> Items { get; set; }
            }

            public partial class Item6
            {
                public string Name { get; set; }
                public long Weight { get; set; }
                public Reward19 Reward { get; set; }
            }

            public partial class Reward19
            {
                public ShopEntries27 ShopEntries { get; set; }
                public long Xp { get; set; }
            }

            public partial class ShopEntries27
            {
                public long? ShopUserbarFeb232021_Gold { get; set; }
                public long? ShopUserbarFeb232021_Iron { get; set; }
                public long? ShopUserbarFeb232021_Silver { get; set; }
            }

            public partial class LootboxFeb232022_Skin
            {
                public long Group { get; set; }
                public string Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<LootboxAccountLevelCustomizeDeployPrice> OpenPrices { get; set; }
                public List<LootboxAccountLevelCustomizeSlot> Slots { get; set; }
            }

            public partial class LootboxIntercept2022AcEmotionW0Fingerbang
            {
                public long Group { get; set; }
                public LocaleKeyEnum Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<LootboxAccountLevelCustomizeSlot> Slots { get; set; }
            }

            public partial class LootboxIntercept2022PatternIntercept2022Giraffe
            {
                public long Group { get; set; }
                public LocaleKeyEnum Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<LootboxAccountLevelCustomizeSlot> Slots { get; set; }
            }

            public partial class LootboxMainEmblems
            {
                public long Group { get; set; }
                public string Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<LootboxAccountLevelCustomizeSlot> Slots { get; set; }
            }

            public partial class LootboxMainHqStyle
            {
                public long Group { get; set; }
                public ItemTypeEnum Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<LootboxMainHqStyleSlot> Slots { get; set; }
            }

            public partial class LootboxMainHqStyleSlot
            {
                public SlotName Name { get; set; }
                public long Weight { get; set; }
                public bool SuppressDoubles { get; set; }
                public List<Item7> Items { get; set; }
            }

            public partial class Item7
            {
                public string Name { get; set; }
                public long Weight { get; set; }
                public Reward20 Reward { get; set; }
            }

            public partial class Reward20
            {
                public ShopEntries28 ShopEntries { get; set; }
                public long Xp { get; set; }
            }

            public partial class ShopEntries28
            {
                public long? ShopHqstyleSandstorm { get; set; }
                public long? ShopHqstyleWinter2020 { get; set; }
                public long? ShopHqstylePolygon { get; set; }
                public long? ShopHqstyleIndustrial { get; set; }
                public long? ShopHqstyleGraysmoke { get; set; }
                public long? ShopHqstyleDam { get; set; }
            }

            public partial class LootboxMainSkinsetLegendary
            {
                public long Group { get; set; }
                public string Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<LootboxAccountLevelCustomizeSlot> Slots { get; set; }
            }

            public partial class LootboxMay2022Consumables
            {
                public long Group { get; set; }
                public string Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<DeployPriceElement> OpenPrices { get; set; }
                public List<LootboxMay2022ConsumablesSlot> Slots { get; set; }
            }

            public partial class LootboxMay2022ConsumablesSlot
            {
                public SlotName Name { get; set; }
                public long Weight { get; set; }
                public bool SuppressDoubles { get; set; }
                public List<AmbitiousItem> Items { get; set; }
            }

            public partial class AmbitiousItem
            {
                public string Name { get; set; }
                public long Weight { get; set; }
                public Reward10 Reward { get; set; }
            }

            public partial class Reward10
            {
                public ShopEntries18 ShopEntries { get; set; }
                public long Xp { get; set; }
            }

            public partial class ShopEntries18
            {
                public long? ShopCurrencyPerkTierUpgrade { get; set; }
                public long? ShopCurrencyRandomBonus { get; set; }
                public long? ShopCurrencyDefendPointsBooster { get; set; }
                public long? ShopCurrencySpecialReviveV2 { get; set; }
            }

            public partial class LootboxMay2022Emblem
            {
                public long Group { get; set; }
                public string Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<DeployPriceElement> OpenPrices { get; set; }
                public List<LootboxMay2022EmblemSlot> Slots { get; set; }
            }

            public partial class LootboxMay2022EmblemSlot
            {
                public SlotName Name { get; set; }
                public long Weight { get; set; }
                public bool SuppressDoubles { get; set; }
                public List<CunningItem> Items { get; set; }
            }

            public partial class CunningItem
            {
                public string Name { get; set; }
                public long Weight { get; set; }
                public Reward11 Reward { get; set; }
            }

            public partial class Reward11
            {
                public ShopEntries19 ShopEntries { get; set; }
                public long Xp { get; set; }
            }

            public partial class ShopEntries19
            {
                public long? ShopUserbarMay2022Emblem1 { get; set; }
                public long? ShopUserbarMay2022Emblem2 { get; set; }
                public long? ShopUserbar9May2020_Participation { get; set; }
                public long? ShopUserbar9May2020_Commitment { get; set; }
            }

            public partial class LootboxMay2022Emotions
            {
                public long Group { get; set; }
                public string Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<DeployPriceElement> OpenPrices { get; set; }
                public List<LootboxAccountLevelCustomizeSlot> Slots { get; set; }
            }

            public partial class LootboxMay2022Fatality
            {
                public long Group { get; set; }
                public string Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<DeployPriceElement> OpenPrices { get; set; }
                public List<LootboxAccountLevelCustomizeSlot> Slots { get; set; }
            }

            public partial class LootboxMay2022OperClass
            {
                public long Group { get; set; }
                public string Visual { get; set; }
                public LocaleKeyEnum LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<LootboxAccountLevelCustomizeSlot> Slots { get; set; }
            }

            public partial class LootboxMay2022Skinset
            {
                public long Group { get; set; }
                public string Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<DeployPriceElement> OpenPrices { get; set; }
                public List<LootboxAccountLevelCustomizeSlot> Slots { get; set; }
            }

            public partial class LootboxNy21Ny20Content
            {
                public long Group { get; set; }
                public string Visual { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<LootboxAccountLevelCustomizeSlot> Slots { get; set; }
            }

            public partial class LootboxOfferEpicSkin
            {
                public long Group { get; set; }
                public string Visual { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<LootboxAccountLevelCustomizeSlot> Slots { get; set; }
            }

            public partial class LootboxOper
            {
                public long Group { get; set; }
                public string Visual { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<LootboxAccountLevelCustomizeSlot> Slots { get; set; }
                public string LocaleKey { get; set; }
            }

            public partial class LootboxOfferRareOper
            {
                public long Group { get; set; }
                public string Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<LootboxAccountLevelCustomizeSlot> Slots { get; set; }
            }

            public partial class LootboxOfferSkinset1Class
            {
                public long Group { get; set; }
                public string Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<LootboxAccountLevelCustomizeSlot> Slots { get; set; }
            }

            public partial class LootboxOnslaught2021AcEmotionW0HurryUp
            {
                public long Group { get; set; }
                public LocaleKeyEnum Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<LootboxAccountLevelCustomizeSlot> Slots { get; set; }
            }

            public partial class LootboxPatternBp5Skin2
            {
                public long Group { get; set; }
                public string Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<LootboxAccountLevelCustomizeSlot> Slots { get; set; }
            }

            public partial class LootboxPatternFeb232021Skin22Spn2016
            {
                public long Group { get; set; }
                public string Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<OpenPrice> OpenPrices { get; set; }
                public List<LootboxAccountLevelCustomizeSlot> Slots { get; set; }
            }

            public partial class LootboxPatternFeb232021SkinFsb2004
            {
                public long Group { get; set; }
                public string Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<OpenPrice> OpenPrices { get; set; }
                public List<LootboxAccountLevelCustomizeSlot> Slots { get; set; }
            }

            public partial class LootboxPatternFeb232021SkinFsb2016
            {
                public long Group { get; set; }
                public string Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<OpenPrice> OpenPrices { get; set; }
                public List<LootboxAccountLevelCustomizeSlot> Slots { get; set; }
            }

            public partial class LootboxPatternFeb232021SkinGrom2014
            {
                public long Group { get; set; }
                public string Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<OpenPrice> OpenPrices { get; set; }
                public List<LootboxAccountLevelCustomizeSlot> Slots { get; set; }
            }

            public partial class LootboxPatternFeb232021SkinKsk2011
            {
                public long Group { get; set; }
                public string Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<OpenPrice> OpenPrices { get; set; }
                public List<LootboxAccountLevelCustomizeSlot> Slots { get; set; }
            }

            public partial class LootboxPatternFeb232021SkinNesher2015
            {
                public long Group { get; set; }
                public string Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<OpenPrice> OpenPrices { get; set; }
                public List<LootboxAccountLevelCustomizeSlot> Slots { get; set; }
            }

            public partial class LootboxPatternFeb232021SkinRaid2017
            {
                public long Group { get; set; }
                public string Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<OpenPrice> OpenPrices { get; set; }
                public List<LootboxAccountLevelCustomizeSlot> Slots { get; set; }
            }

            public partial class LootboxPatternFeb232021SkinSeal2014
            {
                public long Group { get; set; }
                public string Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<OpenPrice> OpenPrices { get; set; }
                public List<LootboxAccountLevelCustomizeSlot> Slots { get; set; }
            }

            public partial class LootboxPatternFeb232021SkinSso2013
            {
                public long Group { get; set; }
                public string Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<OpenPrice> OpenPrices { get; set; }
                public List<LootboxAccountLevelCustomizeSlot> Slots { get; set; }
            }

            public partial class LootboxPatternFeb232021SkinTfb2008
            {
                public long Group { get; set; }
                public string Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<OpenPrice> OpenPrices { get; set; }
                public List<LootboxAccountLevelCustomizeSlot> Slots { get; set; }
            }

            public partial class LootboxPatternOnslaught2021Skin1
            {
                public long Group { get; set; }
                public LocaleKeyEnum Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<LootboxAccountLevelCustomizeSlot> Slots { get; set; }
            }

            public partial class LootboxPatternOnslaught2021Skin2
            {
                public long Group { get; set; }
                public LocaleKeyEnum Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<LootboxAccountLevelCustomizeSlot> Slots { get; set; }
            }

            public partial class LootboxRankedS1
            {
                public long Group { get; set; }
                public string Visual { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<LootboxAccountLevelCustomizeSlot> Slots { get; set; }
            }

            public partial class LootboxRankedS1FinishingLeague
            {
                public long Group { get; set; }
                public string Visual { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<LootboxAccountLevelCustomizeSlot> Slots { get; set; }
            }

            public partial class LootboxRankedS1FinishingLeagueFatality
            {
                public long Group { get; set; }
                public string Visual { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<LootboxAccountLevelCustomizeSlot> Slots { get; set; }
            }

            public partial class LootboxRankedS2AcEmotionW0Bowling
            {
                public long Group { get; set; }
                public LocaleKeyEnum Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<LootboxAccountLevelCustomizeSlot> Slots { get; set; }
            }

            public partial class LootboxRankedS2AcEmotionW0Bullet
            {
                public long Group { get; set; }
                public LocaleKeyEnum Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<LootboxAccountLevelCustomizeSlot> Slots { get; set; }
            }

            public partial class LootboxRankedS2AcFatalityW0Heartbreaker
            {
                public long Group { get; set; }
                public LocaleKeyEnum Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<LootboxAccountLevelCustomizeSlot> Slots { get; set; }
            }

            public partial class LootboxRankedS
            {
                public long Group { get; set; }
                public string Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<LootboxAccountLevelCustomizeSlot> Slots { get; set; }
            }

            public partial class LootboxRankedS2FinishingLeagueDiamondLsClass
            {
                public long Group { get; set; }
                public string Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<DeployPriceElement> OpenPrices { get; set; }
                public List<LootboxRankedS2FinishingLeagueDiamondLsSlot> Slots { get; set; }
            }

            public partial class LootboxRankedS2FinishingLeagueDiamondLsSlot
            {
                public SlotName Name { get; set; }
                public long Weight { get; set; }
                public bool SuppressDoubles { get; set; }
                public List<MagentaItem> Items { get; set; }
            }

            public partial class MagentaItem
            {
                public string Name { get; set; }
                public long Weight { get; set; }
                public Reward12 Reward { get; set; }
            }

            public partial class Reward12
            {
                public ShopEntries20 ShopEntries { get; set; }
                public long Xp { get; set; }
            }

            public partial class ShopEntries20
            {
                public long? ShopSkinsetLsFsb2016A { get; set; }
                public long? ShopSkinsetLsFsb2016G { get; set; }
                public long? ShopSkinsetLsFsb2016M { get; set; }
                public long? ShopSkinsetLsFsb2016S { get; set; }
            }

            public partial class LootboxRankedS2PatternRankedS2Sapphire
            {
                public long Group { get; set; }
                public LocaleKeyEnum Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<LootboxAccountLevelCustomizeSlot> Slots { get; set; }
            }

            public partial class LootboxRankedS2PatternRankedS2Woodsplinter
            {
                public long Group { get; set; }
                public LocaleKeyEnum Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<LootboxAccountLevelCustomizeSlot> Slots { get; set; }
            }

            public partial class LootboxRankedS2Patternrankeds1Blue
            {
                public long Group { get; set; }
                public LocaleKeyEnum Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<LootboxAccountLevelCustomizeSlot> Slots { get; set; }
            }

            public partial class LootboxRankedS2Patternrankeds1Red
            {
                public long Group { get; set; }
                public LocaleKeyEnum Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<LootboxAccountLevelCustomizeSlot> Slots { get; set; }
            }

            public partial class LootboxRankedS3FinishingLeagueLs
            {
                public long Group { get; set; }
                public string Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<DeployPriceElement> OpenPrices { get; set; }
                public List<LootboxRankedS3FinishingLeagueDiamondLsSlot> Slots { get; set; }
            }

            public partial class LootboxRankedS3FinishingLeagueDiamondLsSlot
            {
                public SlotName Name { get; set; }
                public long Weight { get; set; }
                public bool SuppressDoubles { get; set; }
                public List<FriskyItem> Items { get; set; }
            }

            public partial class FriskyItem
            {
                public string Name { get; set; }
                public long Weight { get; set; }
                public Reward13 Reward { get; set; }
            }

            public partial class Reward13
            {
                public ShopEntries21 ShopEntries { get; set; }
                public long Xp { get; set; }
            }

            public partial class ShopEntries21
            {
                public long? ShopSkinsetLsFsb2004A { get; set; }
                public long? ShopSkinsetLsFsb2004G { get; set; }
                public long? ShopSkinsetLsFsb2004M { get; set; }
                public long? ShopSkinsetLsFsb2004S { get; set; }
            }

            public partial class LootboxRankedS4AcFatalityW0Slap
            {
                public long Group { get; set; }
                public LocaleKeyEnum Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<LootboxAccountLevelCustomizeSlot> Slots { get; set; }
            }

            public partial class LootboxRankedS4FinishingLeagueLs
            {
                public long Group { get; set; }
                public string Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<DeployPriceElement> OpenPrices { get; set; }
                public List<LootboxRankedS4FinishingLeagueDiamondLsSlot> Slots { get; set; }
            }

            public partial class LootboxRankedS4FinishingLeagueDiamondLsSlot
            {
                public SlotName Name { get; set; }
                public long Weight { get; set; }
                public bool SuppressDoubles { get; set; }
                public List<MischievousItem> Items { get; set; }
            }

            public partial class MischievousItem
            {
                public string Name { get; set; }
                public long Weight { get; set; }
                public Reward14 Reward { get; set; }
            }

            public partial class Reward14
            {
                public ShopEntries22 ShopEntries { get; set; }
                public long Xp { get; set; }
            }

            public partial class ShopEntries22
            {
                public long? ShopSkinsetLsRaid2017A { get; set; }
                public long? ShopSkinsetLsRaid2017G { get; set; }
                public long? ShopSkinsetLsRaid2017M { get; set; }
                public long? ShopSkinsetLsRaid2017S { get; set; }
            }

            public partial class LootboxRankedS4PatternRankedS4ForestSunrise
            {
                public long Group { get; set; }
                public LocaleKeyEnum Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<LootboxAccountLevelCustomizeSlot> Slots { get; set; }
            }

            public partial class LootboxRankedS4PatternRankedS4Pangolin
            {
                public long Group { get; set; }
                public LocaleKeyEnum Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<LootboxAccountLevelCustomizeSlot> Slots { get; set; }
            }

            public partial class LootboxRankedS5AcEmotionW0Ggwp
            {
                public long Group { get; set; }
                public LocaleKeyEnum Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<LootboxAccountLevelCustomizeSlot> Slots { get; set; }
            }

            public partial class LootboxRankedS5DailyFirstVictory
            {
                public long Group { get; set; }
                public string Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<LootboxRankedS5DailyFirstVictoryGoldSlot> Slots { get; set; }
            }

            public partial class LootboxRankedS5DailyFirstVictoryGoldSlot
            {
                public SlotName Name { get; set; }
                public long Weight { get; set; }
                public bool SuppressDoubles { get; set; }
                public List<BraggadociousItem> Items { get; set; }
            }

            public partial class BraggadociousItem
            {
                public string Name { get; set; }
                public long Weight { get; set; }
                public ObtainingRewardClass Reward { get; set; }
            }

            public partial class ObtainingRewardClass
            {
                public ObtainingRewardShopEntries ShopEntries { get; set; }
                public long Xp { get; set; }
            }

            public partial class ObtainingRewardShopEntries
            {
                public long? ShopCurrencyStaminaRegenBooster { get; set; }
                public long? ShopCurrencyHealthPack { get; set; }
                public long? ShopCurrencySpecialRevive { get; set; }
                public long? ShopCurrencyArmorPack { get; set; }
                public long? ShopCurrencyAmmoPack { get; set; }
                public long? ShopCurrencySoft { get; set; }
                public long? ShopCurrencyFreeXp { get; set; }
                public long? ShopCurrencyHard { get; set; }
                public long? ShopCurrencyRankedToken { get; set; }
            }

            public partial class LootboxRankedS5PatternRankedS5Diswale
            {
                public long Group { get; set; }
                public LocaleKeyEnum Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<LootboxAccountLevelCustomizeSlot> Slots { get; set; }
            }

            public partial class LootboxT2AnimAcEmotionW0Choke
            {
                public long Group { get; set; }
                public string Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<LootboxAccountLevelCustomizeSlot> Slots { get; set; }
            }

            public partial class LootboxT2AnimAcEmotionW0OldSchoolBoxing
            {
                public long Group { get; set; }
                public string Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<LootboxAccountLevelCustomizeSlot> Slots { get; set; }
            }

            public partial class LootboxT2AnimAcEmotionW0SaluteMilitary
            {
                public long Group { get; set; }
                public string Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<LootboxAccountLevelCustomizeSlot> Slots { get; set; }
            }

            public partial class LootboxT2AnimAcEmotionW0Teaparty
            {
                public long Group { get; set; }
                public string Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<LootboxAccountLevelCustomizeSlot> Slots { get; set; }
            }

            public partial class LootboxT2AnimAcEmotionW1TakeOffHat
            {
                public long Group { get; set; }
                public string Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<LootboxAccountLevelCustomizeSlot> Slots { get; set; }
            }

            public partial class LootboxT2AnimAcFatalityW0MightyFoot
            {
                public long Group { get; set; }
                public string Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<LootboxAccountLevelCustomizeSlot> Slots { get; set; }
            }

            public partial class LootboxT2SkinsetPatterndptropical
            {
                public long Group { get; set; }
                public string Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<LootboxAccountLevelCustomizeSlot> Slots { get; set; }
            }

            public partial class LootboxT2SkinsetPatternttred
            {
                public long Group { get; set; }
                public string Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<LootboxAccountLevelCustomizeSlot> Slots { get; set; }
            }

            public partial class LootboxT2SkinsetPatternwlblue
            {
                public long Group { get; set; }
                public string Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<LootboxAccountLevelCustomizeSlot> Slots { get; set; }
            }

            public partial class LootboxT2SkinsetPatternwldesert2
            {
                public long Group { get; set; }
                public string Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<LootboxAccountLevelCustomizeSlot> Slots { get; set; }
            }

            public partial class LootboxTranspAcEmotionW0Laugh
            {
                public long Group { get; set; }
                public string Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<DeployPriceElement> OpenPrices { get; set; }
                public List<LootboxAccountLevelCustomizeSlot> Slots { get; set; }
            }

            public partial class LootboxTranspAcEmotionW0ThreePoint
            {
                public long Group { get; set; }
                public string Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<DeployPriceElement> OpenPrices { get; set; }
                public List<LootboxAccountLevelCustomizeSlot> Slots { get; set; }
            }

            public partial class LootboxTranspBp5CMt2
            {
                public long Group { get; set; }
                public LootboxDailyQuestCMt1X2Visual Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<DeployPriceElement> OpenPrices { get; set; }
                public List<LootboxTranspBp5CMt2Slot> Slots { get; set; }
            }

            public partial class LootboxTranspBp5CMt2Slot
            {
                public SlotName Name { get; set; }
                public long Weight { get; set; }
                public bool SuppressDoubles { get; set; }
                public List<Item1> Items { get; set; }
            }

            public partial class Item1
            {
                public StickyName Name { get; set; }
                public long Weight { get; set; }
                public Reward15 Reward { get; set; }
            }

            public partial class Reward15
            {
                public ShopEntries23 ShopEntries { get; set; }
                public long Xp { get; set; }
            }

            public partial class ShopEntries23
            {
                public long? ShopCurrencyCmT2Composite { get; set; }
                public long? ShopCurrencyCmT2Chemistry { get; set; }
                public long? ShopCurrencyCmT2Encryption { get; set; }
            }

            public partial class LootboxTranspBp5CMt3T4
            {
                public long Group { get; set; }
                public LootboxDailyQuestCMt1X2Visual Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<DeployPriceElement> OpenPrices { get; set; }
                public List<LootboxTranspBp5CMt3T4Slot> Slots { get; set; }
            }

            public partial class LootboxTranspBp5CMt3T4Slot
            {
                public SlotName Name { get; set; }
                public long Weight { get; set; }
                public bool SuppressDoubles { get; set; }
                public List<Item3> Items { get; set; }
            }

            public partial class Item3
            {
                public IndigoName Name { get; set; }
                public long Weight { get; set; }
                public Reward16 Reward { get; set; }
            }

            public partial class Reward16
            {
                public ShopEntries24 ShopEntries { get; set; }
                public long Xp { get; set; }
            }

            public partial class ShopEntries24
            {
                public long? ShopCurrencyCmT3Microchip { get; set; }
                public long? ShopCurrencyCmT3Blueprint { get; set; }
                public long? ShopCurrencyCmT4Secretdev { get; set; }
            }

            public partial class LootboxTranspPatternBp7Skin1
            {
                public long Group { get; set; }
                public string Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<DeployPriceElement> OpenPrices { get; set; }
                public List<LootboxAccountLevelCustomizeSlot> Slots { get; set; }
            }

            public partial class LootboxTwitch2022Boosters
            {
                public long Group { get; set; }
                public LocaleKeyEnum Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<LootboxTwitch2022BoostersSlot> Slots { get; set; }
            }

            public partial class LootboxTwitch2022BoostersSlot
            {
                public SlotName Name { get; set; }
                public long Weight { get; set; }
                public bool SuppressDoubles { get; set; }
                public List<Item9> Items { get; set; }
            }

            public partial class Item9
            {
                public IndecentName Name { get; set; }
                public long Weight { get; set; }
                public Reward22 Reward { get; set; }
            }

            public partial class Reward22
            {
                public ShopEntries30 ShopEntries { get; set; }
                public long Xp { get; set; }
            }

            public partial class ShopEntries30
            {
                public long? ShopCurrencyXpBooster { get; set; }
                public long? ShopCurrencyCreditsBooster { get; set; }
            }

            public partial class LootboxTwitch2022Emblem
            {
                public long Group { get; set; }
                public LocaleKeyEnum Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<LootboxTwitch2022EmblemSlot> Slots { get; set; }
            }

            public partial class LootboxTwitch2022EmblemSlot
            {
                public SlotName Name { get; set; }
                public long Weight { get; set; }
                public bool SuppressDoubles { get; set; }
                public List<Item10> Items { get; set; }
            }

            public partial class Item10
            {
                public string Name { get; set; }
                public long Weight { get; set; }
                public Reward23 Reward { get; set; }
            }

            public partial class Reward23
            {
                public ShopEntries31 ShopEntries { get; set; }
                public long Xp { get; set; }
            }

            public partial class ShopEntries31
            {
                public long ShopUserbarTwitch2022Emblem { get; set; }
            }

            public partial class LootboxTwitch2022EmotionClapperboardAll
            {
                public long Group { get; set; }
                public LocaleKeyEnum Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<LootboxTwitch2022EmotionClapperboardAllSlot> Slots { get; set; }
            }

            public partial class LootboxTwitch2022EmotionClapperboardAllSlot
            {
                public SlotName Name { get; set; }
                public long Weight { get; set; }
                public bool SuppressDoubles { get; set; }
                public List<Item11> Items { get; set; }
            }

            public partial class Item11
            {
                public string Name { get; set; }
                public long Weight { get; set; }
                public Reward24 Reward { get; set; }
            }

            public partial class Reward24
            {
                public ShopEntries32 ShopEntries { get; set; }
                public long Xp { get; set; }
            }

            public partial class ShopEntries32
            {
                public long ShopPackAcEmotionW0Clapperboard { get; set; }
            }

            public partial class LootboxTwitch2022Es1Seal2014S
            {
                public long Group { get; set; }
                public LocaleKeyEnum Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<LootboxTwitch2022Es1Seal2014SSlot> Slots { get; set; }
            }

            public partial class LootboxTwitch2022Es1Seal2014SSlot
            {
                public SlotName Name { get; set; }
                public long Weight { get; set; }
                public bool SuppressDoubles { get; set; }
                public List<Item12> Items { get; set; }
            }

            public partial class Item12
            {
                public string Name { get; set; }
                public long Weight { get; set; }
                public Reward25 Reward { get; set; }
            }

            public partial class Reward25
            {
                public ShopEntries33 ShopEntries { get; set; }
                public long Xp { get; set; }
            }

            public partial class ShopEntries33
            {
                public long ShopSkinsetEs1Seal2014S { get; set; }
            }

            public partial class LootboxTwitch2022May2022Token
            {
                public long Group { get; set; }
                public LocaleKeyEnum Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<LootboxTwitch2022May2022TokenSlot> Slots { get; set; }
            }

            public partial class LootboxTwitch2022May2022TokenSlot
            {
                public SlotName Name { get; set; }
                public long Weight { get; set; }
                public bool SuppressDoubles { get; set; }
                public List<ExpeditionRewardEventMay2022Slot1Variant> Items { get; set; }
            }

            public partial class LootboxTwitch2022PatternTwitch2022Skin1
            {
                public long Group { get; set; }
                public LocaleKeyEnum Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<LootboxTwitch2022PatternTwitch2022Skin1Slot> Slots { get; set; }
            }

            public partial class LootboxTwitch2022PatternTwitch2022Skin1Slot
            {
                public SlotName Name { get; set; }
                public long Weight { get; set; }
                public bool SuppressDoubles { get; set; }
                public List<Item8> Items { get; set; }
            }

            public partial class Item8
            {
                public string Name { get; set; }
                public long Weight { get; set; }
                public Reward21 Reward { get; set; }
            }

            public partial class Reward21
            {
                public ShopEntries29 ShopEntries { get; set; }
                public long Xp { get; set; }
            }

            public partial class ShopEntries29
            {
                public long ShopPackPatternTwitch2022Skin1 { get; set; }
            }

            public partial class LootboxTwitchFatalityOper
            {
                public long Group { get; set; }
                public LocaleKeyEnum Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<LootboxAccountLevelCustomizeSlot> Slots { get; set; }
            }

            public partial class LootboxTwitchHard500
            {
                public long Group { get; set; }
                public LocaleKeyEnum Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<LootboxTwitchHard500Slot> Slots { get; set; }
            }

            public partial class LootboxTwitchHard500Slot
            {
                public SlotName Name { get; set; }
                public long Weight { get; set; }
                public bool SuppressDoubles { get; set; }
                public List<Item13> Items { get; set; }
            }

            public partial class Item13
            {
                public string Name { get; set; }
                public long Weight { get; set; }
                public Reward26 Reward { get; set; }
            }

            public partial class Reward26
            {
                public ShopEntries34 ShopEntries { get; set; }
                public long Xp { get; set; }
            }

            public partial class ShopEntries34
            {
                public long ShopCurrencyHard { get; set; }
            }

            public partial class LootboxTwitchLs22Spn2016A
            {
                public long Group { get; set; }
                public LocaleKeyEnum Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<LootboxTwitchLs22Spn2016ASlot> Slots { get; set; }
            }

            public partial class LootboxTwitchLs22Spn2016ASlot
            {
                public SlotName Name { get; set; }
                public long Weight { get; set; }
                public bool SuppressDoubles { get; set; }
                public List<Item14> Items { get; set; }
            }

            public partial class Item14
            {
                public string Name { get; set; }
                public long Weight { get; set; }
                public Reward27 Reward { get; set; }
            }

            public partial class Reward27
            {
                public ShopEntries35 ShopEntries { get; set; }
                public long Xp { get; set; }
            }

            public partial class ShopEntries35
            {
                public long ShopSkinsetLs22Spn2016A { get; set; }
            }

            public partial class LootboxTwitchLs22Spn2016M
            {
                public long Group { get; set; }
                public LocaleKeyEnum Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<LootboxTwitchLs22Spn2016MSlot> Slots { get; set; }
            }

            public partial class LootboxTwitchLs22Spn2016MSlot
            {
                public SlotName Name { get; set; }
                public long Weight { get; set; }
                public bool SuppressDoubles { get; set; }
                public List<Item15> Items { get; set; }
            }

            public partial class Item15
            {
                public string Name { get; set; }
                public long Weight { get; set; }
                public Reward28 Reward { get; set; }
            }

            public partial class Reward28
            {
                public ShopEntries36 ShopEntries { get; set; }
                public long Xp { get; set; }
            }

            public partial class ShopEntries36
            {
                public long ShopSkinsetLs22Spn2016M { get; set; }
            }

            public partial class LootboxTwitchLsSeal2014G
            {
                public long Group { get; set; }
                public LocaleKeyEnum Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<LootboxTwitchLsSeal2014GSlot> Slots { get; set; }
            }

            public partial class LootboxTwitchLsSeal2014GSlot
            {
                public SlotName Name { get; set; }
                public long Weight { get; set; }
                public bool SuppressDoubles { get; set; }
                public List<Item16> Items { get; set; }
            }

            public partial class Item16
            {
                public string Name { get; set; }
                public long Weight { get; set; }
                public Reward29 Reward { get; set; }
            }

            public partial class Reward29
            {
                public ShopEntries37 ShopEntries { get; set; }
                public long Xp { get; set; }
            }

            public partial class ShopEntries37
            {
                public long ShopSkinsetLsSeal2014G { get; set; }
            }

            public partial class LootboxTwitchLsSeal2014S
            {
                public long Group { get; set; }
                public LocaleKeyEnum Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<LootboxTwitchLsSeal2014SSlot> Slots { get; set; }
            }

            public partial class LootboxTwitchLsSeal2014SSlot
            {
                public SlotName Name { get; set; }
                public long Weight { get; set; }
                public bool SuppressDoubles { get; set; }
                public List<Item17> Items { get; set; }
            }

            public partial class Item17
            {
                public string Name { get; set; }
                public long Weight { get; set; }
                public Reward30 Reward { get; set; }
            }

            public partial class Reward30
            {
                public ShopEntries38 ShopEntries { get; set; }
                public long Xp { get; set; }
            }

            public partial class ShopEntries38
            {
                public long ShopSkinsetLsSeal2014S { get; set; }
            }

            public partial class LootboxTwitchPartyBlowerAll
            {
                public long Group { get; set; }
                public LocaleKeyEnum Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<LootboxAccountLevelCustomizeSlot> Slots { get; set; }
            }

            public partial class LootboxTwitchPartyPopperAll
            {
                public long Group { get; set; }
                public LocaleKeyEnum Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<LootboxAccountLevelCustomizeSlot> Slots { get; set; }
            }

            public partial class LootboxTwitchPrem
            {
                public long Group { get; set; }
                public LocaleKeyEnum Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<LootboxTwitchPrem1Slot> Slots { get; set; }
            }

            public partial class LootboxTwitchPrem1Slot
            {
                public SlotName Name { get; set; }
                public long Weight { get; set; }
                public bool SuppressDoubles { get; set; }
                public List<Item18> Items { get; set; }
            }

            public partial class Item18
            {
                public string Name { get; set; }
                public long Weight { get; set; }
                public Reward31 Reward { get; set; }
            }

            public partial class Reward31
            {
                public ShopEntries39 ShopEntries { get; set; }
                public long Xp { get; set; }
            }

            public partial class ShopEntries39
            {
                public long ShopSubscriptionDay1 { get; set; }
            }

            public partial class LootboxTwitchPrem7
            {
                public long Group { get; set; }
                public LocaleKeyEnum Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<LootboxTwitchPrem7Slot> Slots { get; set; }
            }

            public partial class LootboxTwitchPrem7Slot
            {
                public SlotName Name { get; set; }
                public long Weight { get; set; }
                public bool SuppressDoubles { get; set; }
                public List<Item19> Items { get; set; }
            }

            public partial class Item19
            {
                public string Name { get; set; }
                public long Weight { get; set; }
                public Reward32 Reward { get; set; }
            }

            public partial class Reward32
            {
                public ShopEntries40 ShopEntries { get; set; }
                public long Xp { get; set; }
            }

            public partial class ShopEntries40
            {
                public long ShopSubscriptionDay7 { get; set; }
            }

            public partial class LootboxTwitchSoft
            {
                public long Group { get; set; }
                public LocaleKeyEnum Visual { get; set; }
                public string LocaleKey { get; set; }
                public bool TransparentSlots { get; set; }
                public bool ShuffleSlots { get; set; }
                public bool UniqueSlots { get; set; }
                public List<LootboxTwitchSoft10000Slot> Slots { get; set; }
            }

            public partial class LootboxTwitchSoft10000Slot
            {
                public SlotName Name { get; set; }
                public long Weight { get; set; }
                public bool SuppressDoubles { get; set; }
                public List<Item20> Items { get; set; }
            }

            public partial class Item20
            {
                public string Name { get; set; }
                public long Weight { get; set; }
                public Item2Class Reward { get; set; }
            }

            public partial class Item2Class
            {
                public Item2ShopEntries ShopEntries { get; set; }
                public long Xp { get; set; }
            }

            public partial class Item2ShopEntries
            {
                public long ShopCurrencySoft { get; set; }
            }

            public partial class MarathonConfigs
            {
                public Front2020 Front2020 { get; set; }
                public Hacking2020 Hacking2020 { get; set; }
                public Hacking2021 Hacking2021 { get; set; }
                public Front2021 Front2021 { get; set; }
                public Onslaught2021 Onslaught2021 { get; set; }
                public NewYear2022 NewYear2022 { get; set; }
                public Intercept2022 Intercept2022 { get; set; }
                public May2022 May2022 { get; set; }
            }

            public partial class Front2020
            {
                public DateTimeOffset StartDate { get; set; }
                public DateTimeOffset EndDate { get; set; }
                public DateTimeOffset EndShopDate { get; set; }
                public string TokensCurrency { get; set; }
                public string TicketsCurrency { get; set; }
                public long BattlesForTicket { get; set; }
                public long TicketTokenMultiplier { get; set; }
                public Dictionary<string, Mode> Modes { get; set; }
                public List<Front2020LadderReward> LadderRewards { get; set; }
                public long LadderThreshold { get; set; }
            }

            public partial class Front2020LadderReward
            {
                public long Place { get; set; }
                public Reward33 Reward { get; set; }
            }

            public partial class Reward33
            {
                public ShopEntries41 ShopEntries { get; set; }
                public long Xp { get; set; }
            }

            public partial class ShopEntries41
            {
                public long? ShopUserbarFront2020Ladder1 { get; set; }
                public long? ShopSubscriptionDay7 { get; set; }
                public long? ShopSubscriptionDay3 { get; set; }
                public long? ShopSubscriptionDay1 { get; set; }
                public long? ShopUserbarFront2020Ladder2 { get; set; }
                public long? ShopCurrencySoft { get; set; }
                public long? ShopUserbarFront2020Ladder3 { get; set; }
                public long? ShopCurrencyFreeXp { get; set; }
                public long? ShopUserbarFront2020Ladder4 { get; set; }
            }

            public partial class Mode
            {
                public bool ProduceTickets { get; set; }
                public bool ConsumeTickets { get; set; }
                public bool MaxRewardOnWin { get; set; }
                public ActionTarget ActionTarget { get; set; }
                public List<long> TokensPerAction { get; set; }
            }

            public partial class Front2021
            {
                public DateTimeOffset StartDate { get; set; }
                public DateTimeOffset EndDate { get; set; }
                public DateTimeOffset EndShopDate { get; set; }
                public string TokensCurrency { get; set; }
                public string TicketsCurrency { get; set; }
                public long BattlesForTicket { get; set; }
                public long TicketTokenMultiplier { get; set; }
                public Dictionary<string, Mode> Modes { get; set; }
                public List<Front2021LadderReward> LadderRewards { get; set; }
                public long LadderThreshold { get; set; }
            }

            public partial class Front2021LadderReward
            {
                public long Place { get; set; }
                public Reward34 Reward { get; set; }
            }

            public partial class Reward34
            {
                public ShopEntries42 ShopEntries { get; set; }
                public long Xp { get; set; }
            }

            public partial class ShopEntries42
            {
                public long? ShopCurrencyFreeXp { get; set; }
                public long? ShopCurrencySoft { get; set; }
                public long? ShopSubscriptionDay7 { get; set; }
                public long? ShopSubscriptionDay1 { get; set; }
                public long? ShopUserbarFront2021Top10 { get; set; }
                public long? ShopUserbarFront2021Top100 { get; set; }
                public long? ShopUserbarFront2021Top1000 { get; set; }
            }

            public partial class Hacking2020
            {
                public DateTimeOffset StartDate { get; set; }
                public DateTimeOffset EndDate { get; set; }
                public DateTimeOffset EndShopDate { get; set; }
                public string TokensCurrency { get; set; }
                public string TicketsCurrency { get; set; }
                public long BattlesForTicket { get; set; }
                public long TicketTokenMultiplier { get; set; }
                public Dictionary<string, Mode> Modes { get; set; }
                public List<Hacking2020LadderReward> LadderRewards { get; set; }
                public long LadderThreshold { get; set; }
            }

            public partial class Hacking2020LadderReward
            {
                public long Place { get; set; }
                public Reward35 Reward { get; set; }
            }

            public partial class Reward35
            {
                public ShopEntries43 ShopEntries { get; set; }
                public long Xp { get; set; }
            }

            public partial class ShopEntries43
            {
                public long? ShopUserbarVzlom2020Top1 { get; set; }
                public long? ShopSubscriptionDay7 { get; set; }
                public long? ShopSubscriptionDay3 { get; set; }
                public long? ShopSubscriptionDay1 { get; set; }
                public long? ShopUserbarVzlom2020Top10 { get; set; }
                public long? ShopCurrencyFreeXp { get; set; }
                public long? ShopUserbarVzlom2020Top100 { get; set; }
                public long? ShopCurrencySoft { get; set; }
            }

            public partial class Hacking2021
            {
                public DateTimeOffset StartDate { get; set; }
                public DateTimeOffset EndDate { get; set; }
                public DateTimeOffset EndShopDate { get; set; }
                public string TokensCurrency { get; set; }
                public string TicketsCurrency { get; set; }
                public long BattlesForTicket { get; set; }
                public long TicketTokenMultiplier { get; set; }
                public Dictionary<string, Mode> Modes { get; set; }
                public List<Hacking2021LadderReward> LadderRewards { get; set; }
                public long LadderThreshold { get; set; }
            }

            public partial class Hacking2021LadderReward
            {
                public long Place { get; set; }
                public BattlePassRewardClass Reward { get; set; }
            }

            public partial class Intercept2022
            {
                public DateTimeOffset StartDate { get; set; }
                public DateTimeOffset EndDate { get; set; }
                public DateTimeOffset EndShopDate { get; set; }
                public string TokensCurrency { get; set; }
                public string TicketsCurrency { get; set; }
                public long BattlesForTicket { get; set; }
                public long TicketTokenMultiplier { get; set; }
                public Dictionary<string, Mode> Modes { get; set; }
                public List<Intercept2022LadderReward> LadderRewards { get; set; }
                public long LadderThreshold { get; set; }
            }

            public partial class Intercept2022LadderReward
            {
                public long Place { get; set; }
                public Reward36 Reward { get; set; }
            }

            public partial class Reward36
            {
                public ShopEntries44 ShopEntries { get; set; }
                public long Xp { get; set; }
            }

            public partial class ShopEntries44
            {
                public long? ShopCurrencyHard { get; set; }
                public long? ShopCurrencySoft { get; set; }
                public long? ShopSubscriptionDay1 { get; set; }
                public long? ShopUserbarIntercept2022Top10 { get; set; }
                public long? ShopCurrencyFreeXp { get; set; }
                public long? ShopCurrencyXpBooster { get; set; }
                public long? ShopCurrencyCreditsBooster { get; set; }
                public long? ShopUserbarIntercept2022Top100 { get; set; }
                public long? ShopUserbarIntercept2022Top1000 { get; set; }
            }

            public partial class May2022
            {
                public DateTimeOffset StartDate { get; set; }
                public DateTimeOffset EndDate { get; set; }
                public DateTimeOffset EndShopDate { get; set; }
                public string TokensCurrency { get; set; }
                public long BattlesForTicket { get; set; }
                public long TicketTokenMultiplier { get; set; }
                public MultiplyClass Modes { get; set; }
                public List<Hacking2021LadderReward> LadderRewards { get; set; }
                public long LadderThreshold { get; set; }
            }

            public partial class NewYear2022
            {
                public DateTimeOffset StartDate { get; set; }
                public DateTimeOffset EndDate { get; set; }
                public DateTimeOffset EndShopDate { get; set; }
                public string TokensCurrency { get; set; }
                public long BattlesForTicket { get; set; }
                public long TicketTokenMultiplier { get; set; }
                public MultiplyClass Modes { get; set; }
                public List<NewYear2022LadderReward> LadderRewards { get; set; }
                public long LadderThreshold { get; set; }
            }

            public partial class NewYear2022LadderReward
            {
                public long Place { get; set; }
                public Reward37 Reward { get; set; }
            }

            public partial class Reward37
            {
                public ShopEntries45 ShopEntries { get; set; }
                public long Xp { get; set; }
            }

            public partial class ShopEntries45
            {
                public long? ShopCurrencyHard { get; set; }
                public long? ShopCurrencySoft { get; set; }
                public long? ShopSubscriptionDay1 { get; set; }
                public long? ShopUserbarNy22Top10 { get; set; }
                public long? ShopCurrencyFreeXp { get; set; }
                public long? ShopCurrencyXpBooster { get; set; }
                public long? ShopCurrencyCreditsBooster { get; set; }
                public long? ShopUserbarNy22Top100 { get; set; }
                public long? ShopUserbarNy22Top1000 { get; set; }
            }

            public partial class Onslaught2021
            {
                public DateTimeOffset StartDate { get; set; }
                public DateTimeOffset EndDate { get; set; }
                public DateTimeOffset EndShopDate { get; set; }
                public string TokensCurrency { get; set; }
                public string TicketsCurrency { get; set; }
                public long BattlesForTicket { get; set; }
                public long TicketTokenMultiplier { get; set; }
                public Dictionary<string, Mode> Modes { get; set; }
                public List<Onslaught2021LadderReward> LadderRewards { get; set; }
                public long LadderThreshold { get; set; }
            }

            public partial class Onslaught2021LadderReward
            {
                public long Place { get; set; }
                public Reward38 Reward { get; set; }
            }

            public partial class Reward38
            {
                public ShopEntries46 ShopEntries { get; set; }
                public long Xp { get; set; }
            }

            public partial class ShopEntries46
            {
                public long? ShopCurrencyHard { get; set; }
                public long? ShopCurrencySoft { get; set; }
                public long? ShopSubscriptionDay1 { get; set; }
                public long? ShopUserbarOnslaught2021Top10 { get; set; }
                public long? ShopCurrencyFreeXp { get; set; }
                public long? ShopCurrencyXpBooster { get; set; }
                public long? ShopCurrencyCreditsBooster { get; set; }
                public long? ShopUserbarOnslaught2021Top100 { get; set; }
                public long? ShopUserbarOnslaught2021Top1000 { get; set; }
            }

            public partial class MedalGroup
            {
                public string Id { get; set; }
                public string Visual { get; set; }
                public List<Medal> Medals { get; set; }
            }

            public partial class Medal
            {
                public string Visual { get; set; }
                public bool Enabled { get; set; }
                public long RibbonsCount { get; set; }
                public MedalReward Reward { get; set; }
                public BatchReward BatchReward { get; set; }
            }

            public partial class BatchReward
            {
                public long Item1 { get; set; }
                public BattlePassRewardClass Item2 { get; set; }
            }

            public partial class MedalReward
            {
                public ShopEntries47 ShopEntries { get; set; }
                public long Xp { get; set; }
            }

            public partial class ShopEntries47
            {
                public long ShopCurrencyFreeXp { get; set; }
            }

            public partial class ModesRewards
            {
                public Defend Pvp { get; set; }
                public Defend Pve { get; set; }
                public Defend Pvehard { get; set; }
                public Pvesolo Pvesolo { get; set; }
                public Defend Hacking { get; set; }
                public Defend Pvpve { get; set; }
                public Defend Pvpranked { get; set; }
                public Defend Onslaughteasy { get; set; }
                public Onslaughtnormal Onslaughtnormal { get; set; }
                public Onslaughthard Onslaughthard { get; set; }
                public Defend Defend { get; set; }
            }

            public partial class Defend
            {
                public Item2Class Item1 { get; set; }
                public Item2Class Item2 { get; set; }
            }

            public partial class Onslaughthard
            {
                public PurpleItem1 Item1 { get; set; }
                public Item2Class Item2 { get; set; }
            }

            public partial class PurpleItem1
            {
                public ShopEntries48 ShopEntries { get; set; }
                public long Xp { get; set; }
            }

            public partial class ShopEntries48
            {
                public long ShopLootboxMainSkinsetCol { get; set; }
                public long ShopCurrencySoft { get; set; }
            }

            public partial class Onslaughtnormal
            {
                public FluffyItem1 Item1 { get; set; }
                public Item2Class Item2 { get; set; }
            }

            public partial class FluffyItem1
            {
                public ShopEntries49 ShopEntries { get; set; }
                public long Xp { get; set; }
            }

            public partial class ShopEntries49
            {
                public long ShopLootboxMainSkinsetOper { get; set; }
                public long ShopCurrencySoft { get; set; }
            }

            public partial class Pvesolo
            {
                public Item2Class Item1 { get; set; }
                public Item2 Item2 { get; set; }
            }

            public partial class NewbieBuffModifiers
            {
                public NewbieBuffModifiersAdditive Additive { get; set; }
                public MultiplyClass Multiply { get; set; }
                public MultiplyClass Curves { get; set; }
                public MultiplyClass Reference { get; set; }
                public MultiplyClass Ui { get; set; }
            }

            public partial class NewbieBuffModifiersAdditive
            {
                public double ResistIncomingDamageModHeadshotMod { get; set; }
                public double ResistIncomingDamageModBulletMod { get; set; }
                public double ResistIncomingDamageModExplosiveMod { get; set; }
            }

            public partial class OnboardingScreen
            {
                public bool EnabledInGame { get; set; }
                public string Visual { get; set; }
                public bool PopupInMeta { get; set; }
                public Item2Class Reward { get; set; }
                public List<object> OptionalRewards { get; set; }
                public ConditionsClass Conditions { get; set; }
            }

            public partial class PremiumData
            {
                public long HcToScRate { get; set; }
                public Coefficients Coefficients { get; set; }
            }

            public partial class Coefficients
            {
                public long PlaysXpCoeff { get; set; }
                public long TeammatePlaysXp { get; set; }
                public long FullPremiumTeamPlaysXp { get; set; }
                public long RewardMoneyCoeff { get; set; }
                public long TeammateRewardMoneyCoeff { get; set; }
                public long FullPremiumTeamRewardMoneyCoeff { get; set; }
            }

            public partial class QuartersClass
            {
                public List<TechnologyLine> TechnologyLines { get; set; }
            }

            public partial class TechnologyLine
            {
                public string Name { get; set; }
                public List<Technology> Technologies { get; set; }
            }

            public partial class Technology
            {
                public string Name { get; set; }
                public Price Price { get; set; }
                public string Duration { get; set; }
                public UpgradeClass Upgrade { get; set; }
                public List<long> Roles { get; set; }
            }

            public partial class UpgradeClass
            {
                public Default Default { get; set; }
                public Overrides Overrides { get; set; }
            }

            public partial class Default
            {
                public SlotElement Slot { get; set; }
                public bool AutoInstall { get; set; }
                public bool Uninstallable { get; set; }
                public bool WorkInProgress { get; set; }
                public List<string> PassiveAbilities { get; set; }
                public DefaultModifiers Modifiers { get; set; }
            }

            public partial class DefaultModifiers
            {
                public Dictionary<string, double> Additive { get; set; }
                public Dictionary<string, double> Multiply { get; set; }
                public PurpleCurves Curves { get; set; }
                public MultiplyClass Reference { get; set; }
                public MultiplyClass Ui { get; set; }
            }

            public partial class PurpleCurves
            {
                public Dictionary<string, DamageCurve> PrimaryDamageOverDist { get; set; }
            }

            public partial class Overrides
            {
                public Arystang Arystang { get; set; }
                public Raid2017G Raid2017G { get; set; }
            }

            public partial class Arystang
            {
                public SlotElement Slot { get; set; }
                public bool AutoInstall { get; set; }
                public bool Uninstallable { get; set; }
                public bool WorkInProgress { get; set; }
                public List<object> PassiveAbilities { get; set; }
                public Modifiers77 Modifiers { get; set; }
            }

            public partial class Modifiers77
            {
                public Additive59 Additive { get; set; }
                public MultiplyClass Multiply { get; set; }
                public MultiplyClass Curves { get; set; }
                public MultiplyClass Reference { get; set; }
                public MultiplyClass Ui { get; set; }
            }

            public partial class Additive59
            {
                public double? ResistIncomingDamageModBulletMod { get; set; }
                public double? PrimaryGunArmorPenetration { get; set; }
                public double? SecondaryGunArmorPenetration { get; set; }
            }

            public partial class Raid2017G
            {
                public SlotElement Slot { get; set; }
                public bool AutoInstall { get; set; }
                public bool Uninstallable { get; set; }
                public bool WorkInProgress { get; set; }
                public List<object> PassiveAbilities { get; set; }
                public Modifiers78 Modifiers { get; set; }
            }

            public partial class Modifiers78
            {
                public Additive60 Additive { get; set; }
                public MultiplyClass Multiply { get; set; }
                public MultiplyClass Curves { get; set; }
                public MultiplyClass Reference { get; set; }
                public MultiplyClass Ui { get; set; }
            }

            public partial class Additive60
            {
                public double PrimaryGunArmorPenetration { get; set; }
                public double SecondaryGunArmorPenetration { get; set; }
            }

            public partial class QuartersBoosters
            {
                public QuartersBoosterH QuartersBoosterH1 { get; set; }
                public QuartersBoosterH QuartersBoosterH10 { get; set; }
                public QuartersBoosterH QuartersBoosterH50 { get; set; }
            }

            public partial class QuartersBoosterH
            {
                public string Visual { get; set; }
                public string Duration { get; set; }
            }

            public partial class RankedSeasonConfigs
            {
                public RankedSeason3 RankedSeason3 { get; set; }
                public RankedSeason4 RankedSeason4 { get; set; }
                public RankedSeason5 RankedSeason5 { get; set; }
            }

            public partial class RankedSeason3
            {
                public DateTimeOffset StartDate { get; set; }
                public DateTimeOffset EndDate { get; set; }
                public long NumWinsForReward { get; set; }
                public long FinishPlaceCount { get; set; }
                public List<string> GameModes { get; set; }
                public List<RankedSeason3League> Leagues { get; set; }
            }

            public partial class RankedSeason3League
            {
                public string Visual { get; set; }
                public string EmblemVisual { get; set; }
                public NumWinsReward NumWinsReward { get; set; }
                public ObtainingRewardClass ObtainingReward { get; set; }
                public PurpleRetentionReward RetentionReward { get; set; }
                public BattlePassRewardClass SeasonEndReward { get; set; }
                public bool IgnoreLostMatches { get; set; }
                public List<Rank> Ranks { get; set; }
                public long Midpoint { get; set; }
            }

            public partial class NumWinsReward
            {
                public NumWinsRewardShopEntries ShopEntries { get; set; }
                public long Xp { get; set; }
            }

            public partial class NumWinsRewardShopEntries
            {
                public long ShopCurrencyRankedToken { get; set; }
            }

            public partial class Rank
            {
                public RankVisual? Visual { get; set; }
                public long PointCount { get; set; }
                public long LadderSize { get; set; }
            }

            public partial class PurpleRetentionReward
            {
                public ShopEntries50 ShopEntries { get; set; }
                public long Xp { get; set; }
            }

            public partial class ShopEntries50
            {
                public long? ShopLootboxRankedS3DailyFirstVictoryBronze { get; set; }
                public long ShopCurrencyRankedToken { get; set; }
                public long? ShopLootboxRankedS3DailyFirstVictorySilver { get; set; }
                public long? ShopLootboxRankedS3DailyFirstVictoryGold { get; set; }
                public long? ShopLootboxRankedS3DailyFirstVictoryPlatinum { get; set; }
                public long? ShopLootboxRankedS3DailyFirstVictoryDiamond { get; set; }
            }

            public partial class RankedSeason4
            {
                public DateTimeOffset StartDate { get; set; }
                public DateTimeOffset EndDate { get; set; }
                public string PreviousRankedSeason { get; set; }
                public long NumWinsForReward { get; set; }
                public long FinishPlaceCount { get; set; }
                public List<string> GameModes { get; set; }
                public List<RankedSeason4League> Leagues { get; set; }
            }

            public partial class RankedSeason4League
            {
                public string Visual { get; set; }
                public string EmblemVisual { get; set; }
                public NumWinsReward NumWinsReward { get; set; }
                public ObtainingRewardClass ObtainingReward { get; set; }
                public FluffyRetentionReward RetentionReward { get; set; }
                public BattlePassRewardClass SeasonEndReward { get; set; }
                public bool IgnoreLostMatches { get; set; }
                public List<Rank> Ranks { get; set; }
                public long Midpoint { get; set; }
            }

            public partial class FluffyRetentionReward
            {
                public ShopEntries51 ShopEntries { get; set; }
                public long Xp { get; set; }
            }

            public partial class ShopEntries51
            {
                public long? ShopLootboxRankedS4DailyFirstVictoryBronze { get; set; }
                public long ShopCurrencyRankedToken { get; set; }
                public long? ShopLootboxRankedS4DailyFirstVictorySilver { get; set; }
                public long? ShopLootboxRankedS4DailyFirstVictoryGold { get; set; }
                public long? ShopLootboxRankedS4DailyFirstVictoryPlatinum { get; set; }
                public long? ShopLootboxRankedS4DailyFirstVictoryDiamond { get; set; }
            }

            public partial class RankedSeason5
            {
                public DateTimeOffset StartDate { get; set; }
                public DateTimeOffset EndDate { get; set; }
                public string PreviousRankedSeason { get; set; }
                public long NumWinsForReward { get; set; }
                public long FinishPlaceCount { get; set; }
                public Reward FinishPlaceReward { get; set; }
                public List<string> GameModes { get; set; }
                public List<RankedSeason5League> Leagues { get; set; }
            }

            public partial class Reward
            {
                public FinishPlaceRewardShopEntries ShopEntries { get; set; }
                public long Xp { get; set; }
            }

            public partial class FinishPlaceRewardShopEntries
            {
                public long ShopCurrencyRankedToken { get; set; }
                public long? ShopCurrencyHard { get; set; }
            }

            public partial class RankedSeason5League
            {
                public string Visual { get; set; }
                public string EmblemVisual { get; set; }
                public NumWinsReward NumWinsReward { get; set; }
                public ObtainingRewardClass ObtainingReward { get; set; }
                public TentacledRetentionReward RetentionReward { get; set; }
                public Reward SeasonEndReward { get; set; }
                public bool IgnoreLostMatches { get; set; }
                public List<Rank> Ranks { get; set; }
                public long Midpoint { get; set; }
            }

            public partial class TentacledRetentionReward
            {
                public ShopEntries52 ShopEntries { get; set; }
                public long Xp { get; set; }
            }

            public partial class ShopEntries52
            {
                public long? ShopLootboxRankedS5DailyFirstVictoryBronze { get; set; }
                public long ShopCurrencyRankedToken { get; set; }
                public long? ShopLootboxRankedS5DailyFirstVictorySilver { get; set; }
                public long? ShopLootboxRankedS5DailyFirstVictoryGold { get; set; }
                public long? ShopLootboxRankedS5DailyFirstVictoryPlatinum { get; set; }
            }

            public partial class ShopEntry
            {
                public long NumId { get; set; }
                public string EntryId { get; set; }
                public Quality Quality { get; set; }
                public long? Order { get; set; }
                public string ItemId { get; set; }
                public BaseAvailableCard? LinkedCardId { get; set; }
                public Dictionary<string, long> ChildShopItems { get; set; }
                public ItemTypeEnum ItemType { get; set; }
                public List<Price> Price { get; set; }
                public List<OldPrice> OldPrice { get; set; }
                public RefundSum RefundSum { get; set; }
                public long Amount { get; set; }
                public AcquisitionType AcquisitionType { get; set; }
                public LocaleKeyEnum? AcquisitionVisual { get; set; }
                public bool AllowPartialPurchase { get; set; }
                public bool WorkInProgress { get; set; }
                public ShopEntryCategory? Category { get; set; }
                public DeployPriceElement RefundSite { get; set; }
                public string ShopUrl { get; set; }
                public bool? Suspendable { get; set; }
                public long? BuyLimit { get; set; }
                public bool? FullProgression { get; set; }
            }

            public partial class OldPrice
            {
                public OldPriceValues Values { get; set; }
            }

            public partial class OldPriceValues
            {
                public long? Hc { get; set; }
                public long? Sc { get; set; }
                public long? FreeXp { get; set; }
            }

            public partial class RefundSum
            {
                public RefundSumValues Values { get; set; }
            }

            public partial class RefundSumValues
            {
                public long? RefundToken { get; set; }
                public long? Hc { get; set; }
                public long? Sc { get; set; }
                public long? RankedToken { get; set; }
            }

            public partial class SkinGroup
            {
                public string Visual { get; set; }
                public SkinGroupType Type { get; set; }
                public List<string> Skins { get; set; }
                public string ModelVisualPostfix { get; set; }
            }

            public partial class SpecialOffers
            {
                public FreeXpPackByMasterCap FreeXpPackByMasterCap { get; set; }
                public FreeXpPackByMasterCap TestOffer { get; set; }
                public OfferAssault10_Class OfferAssault7 { get; set; }
                public OfferAssault10_Class OfferAssault8 { get; set; }
                public OfferAssault10_Class OfferAssault9 { get; set; }
                public OfferAssault10_Class OfferAssault10 { get; set; }
                public OfferAssault10_Class OfferAssault11 { get; set; }
                public OfferAssault10_Class OfferAssault12 { get; set; }
                public OfferAssault10_Class OfferAssault13 { get; set; }
                public OfferAssault10_Class OfferAssault14 { get; set; }
                public OfferAssault10_Class OfferAssault15 { get; set; }
                public OfferAssault10_Class OfferGunner7 { get; set; }
                public OfferAssault10_Class OfferGunner8 { get; set; }
                public OfferAssault10_Class OfferGunner9 { get; set; }
                public OfferAssault10_Class OfferGunner10 { get; set; }
                public OfferAssault10_Class OfferGunner11 { get; set; }
                public OfferAssault10_Class OfferGunner12 { get; set; }
                public OfferAssault10_Class OfferGunner13 { get; set; }
                public OfferAssault10_Class OfferGunner14 { get; set; }
                public OfferAssault10_Class OfferGunner15 { get; set; }
                public OfferAssault10_Class OfferMedic7 { get; set; }
                public OfferAssault10_Class OfferMedic8 { get; set; }
                public OfferAssault10_Class OfferMedic9 { get; set; }
                public OfferAssault10_Class OfferMedic10 { get; set; }
                public OfferAssault10_Class OfferMedic11 { get; set; }
                public OfferAssault10_Class OfferMedic12 { get; set; }
                public OfferAssault10_Class OfferMedic13 { get; set; }
                public OfferAssault10_Class OfferMedic14 { get; set; }
                public OfferAssault10_Class OfferMedic15 { get; set; }
                public OfferAssault10_Class OfferSniper7 { get; set; }
                public OfferAssault10_Class OfferSniper8 { get; set; }
                public OfferAssault10_Class OfferSniper9 { get; set; }
                public OfferAssault10_Class OfferSniper10 { get; set; }
                public OfferAssault10_Class OfferSniper11 { get; set; }
                public OfferAssault10_Class OfferSniper12 { get; set; }
                public OfferAssault10_Class OfferSniper13 { get; set; }
                public OfferAssault10_Class OfferSniper14 { get; set; }
                public OfferAssault10_Class OfferSniper15 { get; set; }
                public OfferAssault10_Class OfferSoft50000 { get; set; }
                public OfferAssault10_Class OfferSoft100000 { get; set; }
                public FreeXpPackByMasterCap OfferOnboarding { get; set; }
                public FreeXpPackByMasterCap OfferAccount1 { get; set; }
                public FreeXpPackByMasterCap OfferFullprogResources { get; set; }
                public FreeXpPackByMasterCap Offer100Battles { get; set; }
                public FreeXpPackByMasterCap Offer250Battles { get; set; }
                public FreeXpPackByMasterCap Offer500Battles { get; set; }
                public FreeXpPackByMasterCap Offer1000Battles { get; set; }
                public OfferBuyOperLegend OfferBuyOperLegendSso2013A { get; set; }
                public OfferBuyOperLegend OfferBuyOperLegendSso2013G { get; set; }
                public OfferBuyOperLegend OfferBuyOperLegendSso2013M { get; set; }
                public OfferBuyOperLegend OfferBuyOperLegendSso2013S { get; set; }
                public OfferBuyOperLegend OfferBuyOperLegendFsb2004A { get; set; }
                public OfferBuyOperLegend OfferBuyOperLegendFsb2004G { get; set; }
                public OfferBuyOperLegend OfferBuyOperLegendFsb2004M { get; set; }
                public OfferBuyOperLegend OfferBuyOperLegendFsb2004S { get; set; }
                public OfferBuyOperLegend OfferBuyOperLegendFsb2016A { get; set; }
                public OfferBuyOperLegend OfferBuyOperLegendFsb2016G { get; set; }
                public OfferBuyOperLegend OfferBuyOperLegendFsb2016M { get; set; }
                public OfferBuyOperLegend OfferBuyOperLegendFsb2016S { get; set; }
                public OfferBuyOperLegend OfferBuyOperLegendGrom2014A { get; set; }
                public OfferBuyOperLegend OfferBuyOperLegendGrom2014G { get; set; }
                public OfferBuyOperLegend OfferBuyOperLegendGrom2014M { get; set; }
                public OfferBuyOperLegend OfferBuyOperLegendGrom2014S { get; set; }
                public OfferBuyOperLegend OfferBuyOperLegendRaid2017A { get; set; }
                public OfferBuyOperLegend OfferBuyOperLegendRaid2017G { get; set; }
                public OfferBuyOperLegend OfferBuyOperLegendRaid2017M { get; set; }
                public OfferBuyOperLegend OfferBuyOperLegendRaid2017S { get; set; }
                public OfferBuyOperLegend OfferBuyOperLegendSeal2014A { get; set; }
                public OfferBuyOperLegend OfferBuyOperLegendSeal2014G { get; set; }
                public OfferBuyOperLegend OfferBuyOperLegendSeal2014M { get; set; }
                public OfferBuyOperLegend OfferBuyOperLegendSeal2014S { get; set; }
                public OfferBuyOperLegend OfferBuyOperLegend22Spn2016A { get; set; }
                public OfferBuyOperLegend OfferBuyOperLegend22Spn2016G { get; set; }
                public OfferBuyOperLegend OfferBuyOperLegend22Spn2016M { get; set; }
                public OfferBuyOperLegend OfferBuyOperLegend22Spn2016S { get; set; }
                public FreeXpPackByMasterCap OfferAccount20 { get; set; }
                public FreeXpPackByMasterCap OfferAccount30 { get; set; }
                public FreeXpPackByMasterCap OfferAccount40 { get; set; }
                public OfferFeb232022Pack1000Class OfferHc200 { get; set; }
                public OfferFeb232022Pack1000Class OfferHc500 { get; set; }
                public OfferFeb232022Pack1000Class OfferHc1000 { get; set; }
                public OfferFeb232022Pack1000Class OfferHc2500 { get; set; }
                public OfferPrem OfferPremium168 { get; set; }
                public OfferPrem OfferPremium72 { get; set; }
                public OfferPrem OfferPremium24 { get; set; }
                public OfferAssault10_Class OfferFreexp25000 { get; set; }
                public OfferAssault10_Class OfferFreexp50000 { get; set; }
                public FreeXpPackByMasterCap OfferAccount50 { get; set; }
                public FreeXpPackByMasterCap OfferAccount60 { get; set; }
                public FreeXpPackByMasterCap OfferAccount70 { get; set; }
                public FreeXpPackByMasterCap OfferAccount80 { get; set; }
                public FreeXpPackByMasterCap Offer380Battles { get; set; }
                public OfferPrem OfferPrem16 { get; set; }
                public FreeXpPackByMasterCap OfferNy22 { get; set; }
                public FreeXpPackByMasterCap OfferTargetGrom2014M200Battles { get; set; }
                public FreeXpPackByMasterCap OfferTargetSso2013A200Battles { get; set; }
                public FreeXpPackByMasterCap OfferTarget22Spn2016G200Battles { get; set; }
                public FreeXpPackByMasterCap OfferTarget22Spn2016M200Battles { get; set; }
                public FreeXpPackByMasterCap OfferTarget22Spn2016S200Battles { get; set; }
                public FreeXpPackByMasterCap OfferTargetgrom2014S200Battles { get; set; }
                public FreeXpPackByMasterCap OfferTargetFsb2016G200Battles { get; set; }
                public FreeXpPackByMasterCap OfferTargetSso2013G200Battles { get; set; }
                public FreeXpPackByMasterCap OfferTargetFsb2004A200Battles { get; set; }
                public FreeXpPackByMasterCap OfferTargetSeal2014A200Battles { get; set; }
                public FreeXpPackByMasterCap OfferTargetPayersPack1 { get; set; }
                public OfferBuyOperLegend OfferBuyOperLegendKsk2011S { get; set; }
                public OfferBuyOperLegend OfferBuyOperLegendKsk2011A { get; set; }
                public OfferBuyOperLegend OfferBuyOperLegendKsk2011G { get; set; }
                public OfferBuyOperLegend OfferBuyOperLegendKsk2011M { get; set; }
                public FreeXpPackByMasterCap OfferFeb232022Pack450 { get; set; }
                public OfferFeb232022Pack1000Class OfferFeb232022Pack1000 { get; set; }
                public OfferFeb232022Pack1000Class OfferFeb232022Pack3000 { get; set; }
                public OfferFeb232022Pack1000Class OfferFeb232022Pack10000 { get; set; }
                public FreeXpPackByMasterCap OfferTargetEzapacaPayingSegment1 { get; set; }
                public FreeXpPackByMasterCap OfferTargetEzapacgPayingSegment1 { get; set; }
                public FreeXpPackByMasterCap OfferTargetEzapacmPayingSegment1 { get; set; }
                public FreeXpPackByMasterCap OfferTargetEzapacsPayingSegment1 { get; set; }
                public FreeXpPackByMasterCap OfferTargetEzapacaPayingSegment2 { get; set; }
                public FreeXpPackByMasterCap OfferTargetEzapacgPayingSegment2 { get; set; }
                public FreeXpPackByMasterCap OfferTargetEzapacmPayingSegment2 { get; set; }
                public FreeXpPackByMasterCap OfferTargetEzapacsPayingSegment2 { get; set; }
                public FreeXpPackByMasterCap OfferTargetEzapacaPayingSegment3 { get; set; }
                public FreeXpPackByMasterCap OfferTargetEzapacgPayingSegment3 { get; set; }
                public FreeXpPackByMasterCap OfferTargetEzapacmPayingSegment3 { get; set; }
                public FreeXpPackByMasterCap OfferTargetEzapacsPayingSegment3 { get; set; }
                public OfferBuyOperLegend OfferBuyOperLegendTfb2008M { get; set; }
                public OfferBuyOperLegend OfferBuyOperLegendTfb2008S { get; set; }
                public OfferBuyOperLegend OfferBuyOperLegendTfb2008A { get; set; }
                public OfferBuyOperLegend OfferBuyOperLegendTfb2008G { get; set; }
                public OfferBuyOperLegend OfferBuyOperLegendNesher2015G { get; set; }
                public OfferBuyOperLegend OfferBuyOperLegendNesher2015M { get; set; }
                public OfferBuyOperLegend OfferBuyOperLegendNesher2015S { get; set; }
                public OfferBuyOperLegend OfferBuyOperLegendNesher2015A { get; set; }
                public FreeXpPackByMasterCap OfferRareOperLevel10A { get; set; }
                public OfferFeb232022Pack1000Class OfferRareOperLevel10B { get; set; }
                public OfferFeb232022Pack1000Class OfferRareOperLevel10C { get; set; }
                public FreeXpPackByMasterCap OfferMay2022PrivateTier1 { get; set; }
                public OfferFeb232022Pack1000Class OfferMay2022PrivateTier2 { get; set; }
                public FreeXpPackByMasterCap OfferMay2022CommandTier1 { get; set; }
                public OfferFeb232022Pack1000Class OfferMay2022CommandTier2 { get; set; }
                public OfferFeb232022Pack1000Class OfferMay2022CommandTier3 { get; set; }
                public FreeXpPackByMasterCap OfferMay2022ConsumablesTier1 { get; set; }
                public OfferFeb232022Pack1000Class OfferMay2022ConsumablesTier2 { get; set; }
                public OfferFeb232022Pack1000Class OfferMay2022ConsumablesTier3 { get; set; }
            }

            public partial class FreeXpPackByMasterCap
            {
                public bool EnabledInGame { get; set; }
                public long ViewType { get; set; }
                public string Visual { get; set; }
                public string ShopEntryId { get; set; }
                public bool Targetable { get; set; }
                public bool Rejectable { get; set; }
                public long BuyLimit { get; set; }
                public long DurationInHours { get; set; }
                public List<FreeXpPackByMasterCapActivationCondition> ActivationConditions { get; set; }
                public string LocaleKey { get; set; }
                public DateTimeOffset? StartDate { get; set; }
                public DateTimeOffset? EndDate { get; set; }
            }

            public partial class FreeXpPackByMasterCapActivationCondition
            {
                public IndigoType Type { get; set; }
                public long IntValue1 { get; set; }
            }

            public partial class OfferAssault10_Class
            {
                public bool EnabledInGame { get; set; }
                public long ViewType { get; set; }
                public string Visual { get; set; }
                public string LocaleKey { get; set; }
                public string ShopEntryId { get; set; }
                public bool Targetable { get; set; }
                public bool Rejectable { get; set; }
                public long BuyLimit { get; set; }
                public long DurationInHours { get; set; }
                public List<OfferAssault10_ActivationCondition> ActivationConditions { get; set; }
            }

            public partial class OfferAssault10_ActivationCondition
            {
                public IndecentType Type { get; set; }
                public string StringValue1 { get; set; }
                public long? IntValue1 { get; set; }
            }

            public partial class OfferBuyOperLegend
            {
                public bool EnabledInGame { get; set; }
                public long ViewType { get; set; }
                public string Visual { get; set; }
                public string ShopEntryId { get; set; }
                public bool Targetable { get; set; }
                public bool Rejectable { get; set; }
                public long BuyLimit { get; set; }
                public long DurationInHours { get; set; }
                public List<OfferAssault10_ActivationCondition> ActivationConditions { get; set; }
            }

            public partial class OfferFeb232022Pack1000Class
            {
                public bool EnabledInGame { get; set; }
                public long ViewType { get; set; }
                public string Visual { get; set; }
                public string ShopEntryId { get; set; }
                public bool Targetable { get; set; }
                public bool Rejectable { get; set; }
                public long BuyLimit { get; set; }
                public long DurationInHours { get; set; }
                public List<OfferAssault10_ActivationCondition> ActivationConditions { get; set; }
                public DateTimeOffset? StartDate { get; set; }
                public DateTimeOffset? EndDate { get; set; }
                public string LocaleKey { get; set; }
            }

            public partial class OfferPrem
            {
                public bool EnabledInGame { get; set; }
                public long ViewType { get; set; }
                public string Visual { get; set; }
                public string LocaleKey { get; set; }
                public string ShopEntryId { get; set; }
                public bool Targetable { get; set; }
                public bool Rejectable { get; set; }
                public long BuyLimit { get; set; }
                public long DurationInHours { get; set; }
                public List<OfferPrem16ActivationCondition> ActivationConditions { get; set; }
            }

            public partial class OfferPrem16ActivationCondition
            {
                public string Type { get; set; }
                public long IntValue1 { get; set; }
                public long? IntValue2 { get; set; }
            }

            public partial class SurrenderConfigs
            {
                public Hacking Pvp { get; set; }
                public Hacking Hacking { get; set; }
                public Hacking Pvpranked { get; set; }
            }

            public partial class Hacking
            {
                public bool Enabled { get; set; }
                public long Round { get; set; }
                public long Time { get; set; }
            }

            public partial class UpgradeConfig
            {
                public string Visual { get; set; }
                public SlotElement Slot { get; set; }
                public string ModuleType { get; set; }
                public Attachment? Attachment { get; set; }
                public Price Price { get; set; }
                public bool AutoInstall { get; set; }
                public bool Uninstallable { get; set; }
                public bool WorkInProgress { get; set; }
                public List<string> PassiveAbilities { get; set; }
                public UpgradeConfigModifiers Modifiers { get; set; }
                public SlotElement? UnlockableSlot { get; set; }
                public string LocalesKey { get; set; }
                public TypeLocalesKey? TypeLocalesKey { get; set; }
                public string SoundUpgrade { get; set; }
            }

            public partial class UpgradeConfigModifiers
            {
                public Dictionary<string, double> Additive { get; set; }
                public Dictionary<string, double> Multiply { get; set; }
                public FluffyCurves Curves { get; set; }
                public MultiplyClass Reference { get; set; }
                public Dictionary<string, double> Ui { get; set; }
            }

            public partial class FluffyCurves
            {
                public Dictionary<string, DamageCurve> DamageOverDist { get; set; }
                public Dictionary<string, DamageCurve> HeavyDamageOverDist { get; set; }
            }

            public partial class Userbar
            {
                public bool EnabledInGame { get; set; }
                public string Visual { get; set; }
            }

            public partial class WeaponConfig
            {
                public WeaponConfigDefault Default { get; set; }
                public ActiveAbility ActiveAbility { get; set; }
            }

            public partial class ActiveAbility
            {
                public bool EnabledInGame { get; set; }
                public string Visual { get; set; }
                public SlotElement Slot { get; set; }
                public ItemSpeciality Speciality { get; set; }
                public SlotElement ExplosiveWeaponSubtype { get; set; }
                public IconType ItemType { get; set; }
                public string StrategyType { get; set; }
                public List<object> Upgrades { get; set; }
                public List<object> PassiveAbilities { get; set; }
                public ActiveAbilityModifiers Modifiers { get; set; }
            }

            public partial class ActiveAbilityModifiers
            {
                public Dictionary<string, double> Additive { get; set; }
                public MultiplyClass Multiply { get; set; }
                public MultiplyClass Curves { get; set; }
                public MultiplyClass Reference { get; set; }
                public MultiplyClass Ui { get; set; }
            }

            public partial class WeaponConfigDefault
            {
                public bool EnabledInGame { get; set; }
                public string Visual { get; set; }
                public SlotElement Slot { get; set; }
                public PurpleSpeciality Speciality { get; set; }
                public ExplosionFxTypeEnum ExplosiveWeaponSubtype { get; set; }
                public ItemSpeciality ItemType { get; set; }
                public StrategyType StrategyType { get; set; }
                public List<string> Upgrades { get; set; }
                public List<string> PassiveAbilities { get; set; }
                public Modifiers79 Modifiers { get; set; }
                public SlotElement? LinkedVisualSlot { get; set; }
                public PrimaryWeaponFxType? FxType { get; set; }
                public string ExplosionFxType { get; set; }
                public string DropItem { get; set; }
                public string LocalesKey { get; set; }
                public string ExplosionFxTypeInSky { get; set; }
                public string SecondDropItem { get; set; }
                public string WrongPlacementDropItem { get; set; }
            }

            public partial class Modifiers79
            {
                public Dictionary<string, double> Additive { get; set; }
                public MultiplyClass Multiply { get; set; }
                public TentacledCurves Curves { get; set; }
                public MultiplyClass Reference { get; set; }
                public Dictionary<string, double> Ui { get; set; }
            }

            public partial class TentacledCurves
            {
                public Dictionary<string, DamageCurve> DamageOverDist { get; set; }
                public string DamageOverDistOld { get; set; }
            }

            public enum IconType { Bullet, Explosive, Headshot };

            public enum TriggerTypeEnum { ActionPointsNotFull, All, ArmorDamaged, ArmorFull, Damaged, Enemies, Friends, HasNotBonus, HeavyAmmoNotFull, InCone, Inflictor, InflictorsFriends, Me, NoSprint, PrimaryAmmoNotFull, SecondaryAmmoNotFull };

            public enum PurpleType { And, Damaged, Enemies, Friends, HasBuff, Me, Or };

            public enum BuffImmuneAbsoluteAdd { NegativeVisibility, PositiveBuff, PositiveWeapon, Stun };

            public enum FxTypeEnum { Heal, Up, Visibility };

            public enum BuffImmuneAddElement { NegativeBuff, NegativeMovement, PositiveAim, PositiveHealth };

            public enum ParametricCondition { Equal, Less, More };

            public enum DisplayMarkerTeamRuleEnum { NotSame, Same };

            public enum ActionTarget { None, ScorePoints, WinRound };

            public enum TriggerType { Ray, SphereFull };

            public enum AuraBuffGroupTargetSelectionTime { OnAuraUpdate, OnExplosiveHit };

            public enum PurpleTargetSelectionTime { OnAuraUpdate, OnStartRelease };

            public enum TentacledType { ActionPointsNotFull, And, Damaged };

            public enum FluffyType { Enemies, HasBuff, Me, NoBuff };

            public enum PurpleCategory { PositiveAim, PositiveHealth, PositiveMovement };

            public enum PurpleName { Heal, SpeedUp };

            public enum TypeElement { Airstrike, Distributing, Drone, Explosive, Smoke };

            public enum SlotElement { Body, Boots, Hands, Head, HeavyWeapon, MovementAbility, None, Outfit, PrimaryWeapon, SecondaryWeapon };

            public enum NameEnum { BuffBullet, Concentration, Heal, Nosprint };

            public enum FluffyName { Stun };

            public enum TypeEnum { Grom2014MedicP1A6Passive, Raid2017AssaultHeavyPassive };

            public enum SoundFxEnum { Grenade, SmokeGrenade };

            public enum Ksk2011SupportFxType { Damage, FxTypeDamage, Heal, Up };

            public enum AbilityEnum { Concentration, Scan, Suppress };

            public enum BaseAvailableCard { Amfa, Amfg, Amfm, Amfs, Arystana, Arystang, Arystanm, Arystans, Belssoa, Belssog, Belssom, Belssos, Ezapaca, Ezapacg, Ezapacm, Ezapacs, Fsb2004A, Fsb2004G, Fsb2004M, Fsb2004S, Fsb2016A, Fsb2016G, Fsb2016M, Fsb2016S, Grom2014A, Grom2014G, Grom2014M, Grom2014S, Ksk2011A, Ksk2011G, Ksk2011M, Ksk2011S, Nesher2015A, Nesher2015G, Nesher2015M, Nesher2015S, Raid2017A, Raid2017G, Raid2017M, Raid2017S, Recruita, Recruitg, Recruitm, Recruits, Seal2014A, Seal2014G, Seal2014M, Seal2014S, Sso2013A, Sso2013G, Sso2013M, Sso2013S, Tfb2008A, Tfb2008G, Tfb2008M, Tfb2008S, The22Spn2016A, The22Spn2016G, The22Spn2016M, The22Spn2016S, Ww2A, Ww2G, Ww2M, Ww2S };

            public enum LocaleKeyEnum { Archive3, Archive3Es, Archive4, Archive4Es, Battlepass2, Battlepass3, Battlepass4, Battlepass5, Battlepass7, Birthday2021, Birthday2021Emotion, Birthday2021St, CaliberShop, Feb23, Feb232022, Front2021, Hacking2021, Hangar, Intercept2022, Lines, MainShowcase, May2022, May9, Ny, Ny21, Ny22, OnboardingOperators, Onslaught, Onslaught2021, Premiumop5Feb, Ranked, RankedLootbox, RankedPack, RankedSeason1, RankedShowcase, RecruitLocked, Refund, SmPreorder, SpecialOffer, Summerbrawl2020, The1April, The9May, Thematic1, Thematic2, Thematic2Es, Twitch, VisualBattlepass7, VisualFeb232022, VisualMay2022, Vzlom2020 };

            public enum Role { AggressiveSniper, Assault, Chemist, Commander, Dummy, Fighter, Gunner, HeavyFighter, Hostage, Informer, Medic, Rocketman, RoleGunner, Sergeant, Shooter, Sniper };

            public enum CollectionEnum { BotKarhad, BotWw2, BotZalessye };

            public enum Tion { AcEmotionW0Agree, AcEmotionW0BalloonWrench, AcEmotionW0PolitRuk, AcEmotionW0RefillPpsh, AcEmotionW0Rest, AcEmotionW0SaluteMilitary, AcEmotionW1Triumph, AcEmotionW1Way, AcEmotionW1Youdead };

            public enum SecondaryWeaponExplosionFxType { Rpg };

            public enum SkinVisualEnum { BlrForest, CcDesert, Default, DiForest, DpForest, EmrDesert, EmrForest, FtForest, McForest, MpDesert, ScBlack, ScDesert, ScKhaki, ScOlive, SweWoodland };

            public enum PrimaryWeaponFxType { Damage, Damageangle, None, Poison, Up, Visibility };

            public enum PurpleArchetype { AggressiveCommander, Fighter };

            public enum FluffyCategory { PositiveAim, PositiveBuff };

            public enum CreatorBuffsByAffectingAuraName { Concentration, IncomingDamageMod };

            public enum PrimaryClientName { BotKarhadCommander };

            public enum StickyType { OfficerGunnerBuff, OfficerSupportBuff };

            public enum ExplosionFxTypeEnum { Airstrike, Cloak, DirectedMine, FlashBang, Grenade, Mine, None, Poison, Rocket, Sticky };

            public enum TentacledCategory { PositiveAim, Shield };

            public enum TentacledName { Concentration, Shield };

            public enum FluffyArchetype { Leader };

            public enum Attachment { Ammo, Back, Front, Mag, None, Side, Top, Underbarrel, WearSlot };

            public enum ModuleType { SightLaser };

            public enum VisualEnum { BotTaurusSniper, BotWw2Shooter3, BotWw2Shooter4, BotZalessyeSniper };

            public enum LevelType { Elite, Master, Normal, Zero };

            public enum AbilitySlot { PrimaryAbility };

            public enum SoundUpgrade { Magnum, None };

            public enum TypeLocalesKey { Primaryweapon };

            public enum ItemSpeciality { AssaultRifle, Common, Explosive, Lmg, Melee, Pistol, Shotgun, Smg, SniperRifle };

            public enum ItemTypeEnum { Anim, BattlePassKey, Card, Consumable, Currency, ExtraPremium, Firework, FreeXp, HqStyle, LootBox, MarathonTicket, Pack, Premium, QuartersBooster, ShopItemDeactivator, SkinGroup, SkinSet, Userbar };

            public enum StrategyType { Buff, Deploy, Fire };

            public enum Group { Boosters, Consumables, Event, None, Resource };

            public enum AuraConfigTeamRule { All, Notsame, Same };

            public enum StickyName { ShopCurrencyArchive4Token, ShopCurrencyCmT1Alloy, ShopCurrencyCmT1Component, ShopCurrencyCmT1Fuel, ShopCurrencyCmT1Medicine, ShopCurrencyCmT2Chemistry, ShopCurrencyCmT2Composite, ShopCurrencyCmT2Encryption, ShopCurrencyCmT3Blueprint, ShopCurrencyCmT3Microchip, ShopCurrencyThematic1Tokens, ShopSkinsetEs1Seal2014M, ShopSkinsetEsSso2013A };

            public enum IndigoName { ShopCurrencyArchive3Token, ShopCurrencyCmT1Alloy, ShopCurrencyCmT1Component, ShopCurrencyCmT1Fuel, ShopCurrencyCmT1Medicine, ShopCurrencyCmT2Chemistry, ShopCurrencyCmT2Composite, ShopCurrencyCmT2Encryption, ShopCurrencyCmT3Blueprint, ShopCurrencyCmT3Microchip, ShopCurrencyCmT4Secretdev, ShopCurrencyThematic2Tokens, ShopSkinsetEsFsb2004G, ShopSkinsetEsKsk2011G };

            public enum IndecentName { ShopConsumableAmmoPack, ShopConsumableArmorPack, ShopConsumableHealthPack, ShopConsumableSpecialRevive, ShopConsumableStaminaRegenBooster, ShopCurrencyCreditsBooster, ShopCurrencyXpBooster };

            public enum SlotName { Slot1, Slot2, Slot3, Slot4, Slot5 };

            public enum LootboxDailyQuestCMt1X2Visual { Cm, TransparentCm };

            public enum RankVisual { I, Ii, Iii, Iv, V };

            public enum AcquisitionType { HiddenUntilAcquired, Reward, Shop, SpecialOffer, WebShop };

            public enum ShopEntryCategory { Collections, Competitive, Events, Exclusive, Flags, Rewards, Shop, Special };

            public enum Quality { Default, Epic, High, Highest, Historic, Legendary, Low, Master, Medium, NonHistoricEpic, None };

            public enum SkinGroupType { Gear, Head, Model, Suit, Weapons };

            public enum IndigoType { AccountLevelEqualOrHigher, AccountLevelStrictEqual, BattlesPlayed, MasterXpCap };

            public enum IndecentType { AccountLevelEqualOrHigher, AccountLevelStrictEqual, CurrencyAmount, HasShopEntry, RoleLevel, SpecialOfferUsed };

            public enum PurpleSpeciality { Common, Deploy, GrenadeLauncher, RocketLauncher, Sniper };

            public partial struct StaminaAdd
            {
                public long? Integer;
                public string String;

                public static implicit operator StaminaAdd(long Integer) => new StaminaAdd { Integer = Integer };
                public static implicit operator StaminaAdd(string String) => new StaminaAdd { String = String };
            }

            public partial struct WarmingSpeed
            {
                public double? Double;
                public string String;

                public static implicit operator WarmingSpeed(double Double) => new WarmingSpeed { Double = Double };
                public static implicit operator WarmingSpeed(string String) => new WarmingSpeed { String = String };
            }

            public partial struct Duration
            {
                public double? Double;
                public long? Integer;

                public static implicit operator Duration(double Double) => new Duration { Double = Double };
                public static implicit operator Duration(long Integer) => new Duration { Integer = Integer };
            }
        }
    }
}

