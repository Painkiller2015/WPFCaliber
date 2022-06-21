using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caliber.Json.Character
{
    public static partial class LogObject
    {
        public class Character
        {
            public string cfgId { get; set; }
            public string collection { get; set; }
            public Classes role { get; set; } // мб сломается
            public FarmerBonus farmerBonus { get; set; }
            public bool HasFarmerBonus { get; set; }
            public int CardType { get; set; }
            public int OwnedUnlocksCount { get; set; }
            public List<Ability> abilities { get; set; }
            public List<Item> items { get; set; }
            public int itemsCount { get; set; }
            public SelectedConsumables SelectedConsumables { get; set; }
            public List<Perk> perks { get; set; }
            public MajorLevelsXp MajorLevelsXp { get; set; }
            public List<string> OwnedSkinGroups { get; set; }
            public EnabledSkinGroups EnabledSkinGroups { get; set; }
            public CustomAnims customAnims { get; set; }
            public List<string> MarkedEntities { get; set; }
            public QuartersTechnologies QuartersTechnologies { get; set; }
            public QuartersTechnologiesPrice QuartersTechnologiesPrice { get; set; }
            public int TotalExperience { get; set; }
            public int id { get; set; }
            public bool Owned { get; set; }
            public bool Active { get; set; }
            public int Experience { get; set; }
            public int LockedExperience { get; set; }
            public bool IsUpgradable { get; set; }
            public bool IsLocked { get; set; }
            public string Visual { get; set; }
            public List<UiDatum> uiData { get; set; }
        }
        public class Ability
        {
            public string id { get; set; }
            public string visual { get; set; }
            public string slot { get; set; }
            public bool unlocked { get; set; }
            public List<Upgrade> upgrades { get; set; }
            public List<UiDatum> uiData { get; set; }
        }

        public class Ammunition
        {
            public Values values { get; set; }
        }

        public class Cost
        {
            public Values values { get; set; }
        }

        public class CustomAnims
        {
            public Greeting Greeting { get; set; }
            public KillingBlow KillingBlow { get; set; }
        }

        public class EnabledSkinGroups
        {
            public string Suit { get; set; }
            public string Gear { get; set; }
            public string Head { get; set; }
            public string Weapons { get; set; }
            public string Model { get; set; }
        }

        public class FarmerBonus
        {
            public int Soft { get; set; }
            public int Xp { get; set; }
        }

        public class Greeting
        {
            public List<string> activeAnimations { get; set; }
            public List<string> avaiableAnimations { get; set; }
        }

        public class Item
        {
            public string slot { get; set; }
            public string cfgId { get; set; }
            public string skinVisual { get; set; }
            public string itemType { get; set; }
            public bool unlocked { get; set; }
            public string visual { get; set; }
            public int id { get; set; }
            public List<UiDatum> uiData { get; set; }
            public List<Upgrade> upgrades { get; set; }
            public string localesKey { get; set; }
            public string linkedVisualSlot { get; set; }
        }

        public class KillingBlow
        {
            public List<string> activeAnimations { get; set; }
            public List<string> avaiableAnimations { get; set; }
        }

        public class MajorLevelsXp
        {
            public int? Elite { get; set; }
            public int? Master { get; set; }
        }

        public class Perk
        {
            public string id { get; set; }
            public int index { get; set; }
            public int xpCost { get; set; }
            public Cost cost { get; set; }
            public string visual { get; set; }
            public bool workInProgress { get; set; }
            public bool uninstallable { get; set; }
            public bool uninstallWhenDie { get; set; }
            public string type { get; set; }
            public string soundUpgrade { get; set; }
            public string attachmentId { get; set; }
            public string unlockableSlot { get; set; }
            public List<UiDatum> uiData { get; set; }
            public bool unlocked { get; set; }
            public bool enabled { get; set; }
            public string localesKey { get; set; }
            public string typeLocalesKey { get; set; }
            public string moduleType { get; set; }
        }

        public class Physical
        {
            public Values values { get; set; }
        }

        public class Protective
        {
            public Values values { get; set; }
        }

        public class QuartersTechnologies
        {
            public string Tactical { get; set; }
            public string Ammunition { get; set; }
            public string Protective { get; set; }
            public string Physical { get; set; }
        }

        public class QuartersTechnologiesPrice
        {
            public Physical Physical { get; set; }
            public Protective Protective { get; set; }
            public Ammunition Ammunition { get; set; }
            public Tactical Tactical { get; set; }
        }


        public class SelectedConsumables
        {
            public int ConsumableOne { get; set; }
            public int ConsumableTwo { get; set; }
        }

        public class Tactical
        {
            public Values values { get; set; }
        }

        public class UiDatum
        {
            public int type { get; set; }
            public string name { get; set; }
            public string value { get; set; }
            public double min { get; set; }
            public double max { get; set; }
            public double current { get; set; }
        }

        public class Upgrade
        {
            public string id { get; set; }
            public int index { get; set; }
            public int xpCost { get; set; }
            public Cost cost { get; set; }
            public string visual { get; set; }
            public bool workInProgress { get; set; }
            public bool uninstallable { get; set; }
            public bool uninstallWhenDie { get; set; }
            public string type { get; set; }
            public string soundUpgrade { get; set; }
            public string attachmentId { get; set; }
            public string unlockableSlot { get; set; }
            public List<UiDatum> uiData { get; set; }
            public bool unlocked { get; set; }
            public bool enabled { get; set; }
            public string localesKey { get; set; }
            public string moduleType { get; set; }
            public string typeLocalesKey { get; set; }
        }

        public class Values
        {
            public int sc { get; set; }
            public int? cm_t1_alloy { get; set; }
            public int? cm_t1_component { get; set; }
            public int? cm_t2_chemistry { get; set; }
            public int? cm_t2_encryption { get; set; }
            public int? cm_t3_blueprint { get; set; }
            public int? cm_t3_microchip { get; set; }
            public int? cm_t1_medicine { get; set; }
            public int? cm_t2_composite { get; set; }
            public int? cm_t4_secretdev { get; set; }
            public int? cm_t1_fuel { get; set; }
            public int free_xp { get; set; }
        }


    }
}
