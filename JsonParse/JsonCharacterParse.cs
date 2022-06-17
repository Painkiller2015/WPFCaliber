using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFCaliber.Value;
using Newtonsoft.Json;

namespace Caliber
{
    public class JsonCharacterParse
    {
        public Characters[] CharactersList { get; set; }
    }

    public class Characters
    {
        public string cfgId { get; set; }
        public string collection { get; set; }
        public Classes role { get; set; }
        public Farmerbonus farmerBonus { get; set; }
        public bool HasFarmerBonus { get; set; }
        public int CardType { get; set; }
        public int OwnedUnlocksCount { get; set; }
        public Ability[] abilities { get; set; }
        public Item[] items { get; set; }
        public int itemsCount { get; set; }
        public Selectedconsumables SelectedConsumables { get; set; }
        public Perk[] perks { get; set; }
        public Majorlevelsxp MajorLevelsXp { get; set; }
        public string[] OwnedSkinGroups { get; set; }
        public Enabledskingroups EnabledSkinGroups { get; set; }
        public Customanims customAnims { get; set; }
        public string[] MarkedEntities { get; set; }
        public Quarterstechnologies QuartersTechnologies { get; set; }
        public Quarterstechnologiesprice QuartersTechnologiesPrice { get; set; }
        public int TotalExperience { get; set; }
        public int id { get; set; }
        public bool Owned { get; set; }
        public bool Active { get; set; }
        public int Experience { get; set; }
        public int LockedExperience { get; set; }
        public bool IsUpgradable { get; set; }
        public bool IsLocked { get; set; }
        public string Visual { get; set; }
        public Uidata[] uiData { get; set; }
    }

    public class Farmerbonus
    {
        public int Soft { get; set; }
        public int Xp { get; set; }
    }

    public class Selectedconsumables
    {
        public int ConsumableOne { get; set; }
        public int ConsumableTwo { get; set; }
    }

    public class Majorlevelsxp
    {
        public int Elite { get; set; }
        public int Master { get; set; }
    }

    public class Enabledskingroups
    {
        public string Suit { get; set; }
        public string Gear { get; set; }
        public string Head { get; set; }
        public string Weapons { get; set; }
        public string Model { get; set; }
    }

    public class Customanims
    {
        public Greeting Greeting { get; set; }
        public Killingblow KillingBlow { get; set; }
    }

    public class Greeting
    {
        public string[] activeAnimations { get; set; }
        public string[] avaiableAnimations { get; set; }
    }

    public class Killingblow
    {
        public string[] activeAnimations { get; set; }
        public string[] avaiableAnimations { get; set; }
    }

    public class Quarterstechnologies
    {
        public string Tactical { get; set; }
        public string Ammunition { get; set; }
        public string Protective { get; set; }
        public string Physical { get; set; }
    }

    public class Quarterstechnologiesprice
    {
        public Physical Physical { get; set; }
        public Protective Protective { get; set; }
        public Ammunition Ammunition { get; set; }
        public Tactical Tactical { get; set; }
    }

    public class Physical
    {
        public Values values { get; set; }
    }

    public class Values
    {
        public int free_xp { get; set; }
    }

    public class Protective
    {
        public Values values { get; set; }
    }

    public class Ammunition
    {
        public Values values { get; set; }
    }

    public class Tactical
    {
        public Values values { get; set; }
    }

    public class Ability
    {
        public string id { get; set; }
        public string visual { get; set; }
        public string slot { get; set; }
        public bool unlocked { get; set; }
        public Upgrade[] upgrades { get; set; }
        public Uidata[] uiData { get; set; }
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
        public Uidata[] uiData { get; set; }
        public bool unlocked { get; set; }
        public bool enabled { get; set; }
        public string localesKey { get; set; }
        public string moduleType { get; set; }
    }

    public class Cost
    {
        public WPFCaliber.Value.ResourseValue values { get; set; }
    }


    public class Uidata
    {
        public int type { get; set; }
        public string name { get; set; }
        public string value { get; set; }
        public float min { get; set; }
        public float max { get; set; }
        public float current { get; set; }
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
        public Uidata[] uiData { get; set; }
        public Upgrade[] upgrades { get; set; }
        public string localesKey { get; set; }
        public string linkedVisualSlot { get; set; }
    }

    public class Cost1
    {
        public WPFCaliber.Value.ResourseValue values { get; set; }
    }



    public class Perk
    {
        public string id { get; set; }
        public int index { get; set; }
        public int xpCost { get; set; }
        public Cost2 cost { get; set; }
        public string visual { get; set; }
        public bool workInProgress { get; set; }
        public bool uninstallable { get; set; }
        public bool uninstallWhenDie { get; set; }
        public string type { get; set; }
        public string soundUpgrade { get; set; }
        public string attachmentId { get; set; }
        public string unlockableSlot { get; set; }
        public Uidata[] uiData { get; set; }
        public bool unlocked { get; set; }
        public bool enabled { get; set; }
        public string localesKey { get; set; }
        public string typeLocalesKey { get; set; }
        public string moduleType { get; set; }
    }

    public class Cost2
    {
        public ResourseValue values { get; set; }
    }

}
