using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WPFCaliber.Value;

namespace Caliber
{
    public static class Technologylines
    {
        public static JsonParseQuarersPrise.Technologyline[] TechnologyLines { get; set; }
        static Technologylines()
        {
            string json = File.ReadAllText(SysConfig.GetStaticPath());
            TechnologyLines = JsonConvert.DeserializeObject<JsonParseQuarersPrise.Technologyline[]>(json);
        }
    }
    public static class JsonParseQuarersPrise
    {
        public class Technologyline
        {
            public string? Name { get; set; }
            public Technology[]? Technologies { get; set; }
        }

        public class Technology
        {
            public string? Name { get; set; }
            public Price? Price { get; set; }
            public string? Duration { get; set; }
            public Upgrade? Upgrade { get; set; }
            public int[]? Roles { get; set; }
        }

        public class Price
        {
            public ResourseValue? values { get; set; }
        }

        /*public class Value
        {
            public int sc { get; set; }
            public int cm_t1_medicine { get; set; }
            public int health_pack { get; set; }
            public int stamina_regen_booster { get; set; }
            public int cm_t1_alloy { get; set; }
            public int cm_t1_fuel { get; set; }
            public int cm_t2_composite { get; set; }
            public int cm_t2_chemistry { get; set; }
            public int cm_t2_encryption { get; set; }
            public int cm_t3_blueprint { get; set; }
            public int cm_t4_secretdev { get; set; }
            public int cm_t3_microchip { get; set; }
            public int free_xp { get; set; }
            public int armor_pack { get; set; }
            public int cm_t1_component { get; set; }
            public int ammo_pack { get; set; }
            public int special_revive { get; set; }
        }*/

        public class Upgrade
        {
            public Default? Default { get; set; }
            public Overrides? Overrides { get; set; }
        }

        public class Default
        {
            public string? slot { get; set; }
            public bool autoInstall { get; set; }
            public bool uninstallable { get; set; }
            public bool workInProgress { get; set; }
            public string[]? passiveAbilities { get; set; }
            public Modifiers? modifiers { get; set; }
        }

        public class Modifiers
        {
            public Additive? additive { get; set; }
            public Multiply? multiply { get; set; }
            public Curves? curves { get; set; }
            public Reference? reference { get; set; }
            public Ui? ui { get; set; }
        }

        public class Additive
        {
            public int ActionPointRegenRate { get; set; }
            public int ActionPointMinLimit { get; set; }
            public float ResistIncomingDamageModBulletMod { get; set; }
            public int ResistIncomingDamageModBulletRule { get; set; }
            public float ResistBuffTimeModNegativeAim { get; set; }
            public float ResistBuffTimeModStun { get; set; }
            public int HealthInitial { get; set; }
            public float ResistIncomingDamageModFireDOTMod { get; set; }
            public float ResistIncomingDamageModGasDOTMod { get; set; }
            public float ResistIncomingDamageModExplosiveMod { get; set; }
            public int TimerNoDamage { get; set; }
            public int ArmorPackspecialArmorPackEnabled { get; set; }
            public float HitBoxMultHead { get; set; }
            public int PrimaryGunIsManuallyCycled { get; set; }
            public float PrimaryGunShootRateOfFire { get; set; }
            public float PrimaryGunArmorPenetration { get; set; }
            public int AmmoPackregularEnabled { get; set; }
            public int AmmoPackheavyEnabled { get; set; }
            public int AmmoPackDeployCooldownRoundResetRestricted { get; set; }
            public int AmmoPackDeployCooldown { get; set; }
            public int AmmoPackDeployDuration { get; set; }
            public int PrimaryGunIsHitScan { get; set; }
            public int RevivesCount { get; set; }
            public float ResistJumpDamageMult { get; set; }
            public int TimerBipodAmbush { get; set; }
        }

        public class Multiply
        {
            public float StaminaRegenBoosterDeployDuration { get; set; }
            public float StaminaRegenBoosterDeployCooldown { get; set; }
            public float PrimaryWeaponModSprintSpeed { get; set; }
            public float ArmorPackDeployDuration { get; set; }
            public float ArmorPackDeployCooldown { get; set; }
            public float PrimaryGunShotKickUpStay { get; set; }
            public float PrimaryGunShotKickUpAim { get; set; }
            public float PrimaryGunShotKickUpSit { get; set; }
            public float PrimaryGunSpreadConeMaxStay { get; set; }
            public float PrimaryGunSpreadConeMaxAim { get; set; }
            public float PrimaryGunSpreadConeMaxSit { get; set; }
            public float PrimaryGunReloadTime { get; set; }
            public float SecondaryGunReloadTime { get; set; }
            public float PrimaryGunReloadCombinedTime { get; set; }
            public float SecondaryGunReloadCombinedTime { get; set; }
            public float PrimaryGunProjectileSpeed { get; set; }
            public float PrimaryGunProjectileHeadshotMult { get; set; }
            public float MoveSprintUpkeepCost { get; set; }
            public float ReviveSpeed { get; set; }
        }

        public class Curves
        {
            public PrimaryDamageoverdist PrimarydamageOverDist { get; set; }
        }

        public class PrimaryDamageoverdist
        {
            public _0 _0 { get; set; }
            public _1 _1 { get; set; }
            public _2 _2 { get; set; }
            public _3 _3 { get; set; }
        }

        public class _0
        {
            public int x { get; set; }
            public int y { get; set; }
        }

        public class _1
        {
            public int x { get; set; }
            public int y { get; set; }
        }

        public class _2
        {
            public int x { get; set; }
            public int y { get; set; }
        }

        public class _3
        {
            public int x { get; set; }
            public int y { get; set; }
        }

        public class Reference
        {
        }

        public class Ui
        {
        }

        public class Overrides
        {
            public Arystang? arystang { get; set; }
            public Raid2017g? raid2017g { get; set; }
        }

        public class Arystang
        {
            public string? slot { get; set; }
            public bool autoInstall { get; set; }
            public bool uninstallable { get; set; }
            public bool workInProgress { get; set; }
            public object[]? passiveAbilities { get; set; }
            public Modifiers1? modifiers { get; set; }
        }

        public class Modifiers1
        {
            public Additive1? additive { get; set; }
            public Multiply? multiply { get; set; }
            public Curves? curves { get; set; }
            public Reference? reference { get; set; }
            public Ui? ui { get; set; }
        }

        public class Additive1
        {
            public float ResistIncomingDamageModBulletMod { get; set; }
            public float PrimaryGunArmorPenetration { get; set; }
            public float SecondaryGunArmorPenetration { get; set; }
        }

        public class Raid2017g
        {
            public string? slot { get; set; }
            public bool autoInstall { get; set; }
            public bool uninstallable { get; set; }
            public bool workInProgress { get; set; }
            public object[]? passiveAbilities { get; set; }
            public Modifiers2? modifiers { get; set; }
        }

        public class Modifiers2
        {
            public Additive2? additive { get; set; }
            public Multiply? multiply { get; set; }
            public Curves? curves { get; set; }
            public Reference? reference { get; set; }
            public Ui? ui { get; set; }
        }

        public class Additive2
        {
            public float PrimaryGunArmorPenetration { get; set; }
            public float SecondaryGunArmorPenetration { get; set; }
        }
    }
}
