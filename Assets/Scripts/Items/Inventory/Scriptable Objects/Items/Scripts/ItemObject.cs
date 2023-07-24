using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    Consumable,
    Earring,
    Helmet,
    Amulet,
    Chest,
    Weapon,
    Shield,
    Belt,
    Ring,
    Pants,
    Gloves,
    Boots,
    Default,
    UpgradeItems,
    Trinas,
}

public enum Attributes
{
    Health,
    Defense,
    Evasion,
    PhysicalDamage,
    MagicalDamage,
    CriticalRate
}

public enum Quality
{
    Common,
    Uncommon,
    Rare,
    Epic,
    Legendary,
    Unique
}

[CreateAssetMenu(fileName = "New Consumable Object", menuName = "Inventory System/Items/Item")]
public class ItemObject : ScriptableObject
{
    public Sprite uiDisplay;
    public bool stackable;
    public ItemType type;
    public int dropChance;
    [TextArea(15, 20)]
    public string description;
    public int selectedLevel;
    public Item data = new Item();

    public Item CreateItem(int _dropChance)
    {
        this.dropChance = _dropChance;
        Item newItem = new Item(this);
        
        return newItem;
    }
}

[System.Serializable]
public class Item
{
    public string Name;
    public int Id = -1;

    //public ItemBuff[] buffs;
    //public int level;
    public Quality quality;
    public ItemLevel[] levels;

    public Item()
    {
        Name = "";
        Id = -1;
    }
    public Item(ItemObject item)
    {
        Name = item.name;
        Id = item.data.Id;
        levels = new ItemLevel[item.data.levels.Length];
        int currentIndex = 0;
        int selectedIndex = 0;
        selectedIndex = item.selectedLevel;
        currentIndex = selectedIndex;

        for (int i = 0; i < levels.Length; i++)
        {
            if (item.data.levels[i] == item.data.levels[0])
            {
                levels[0] = item.data.levels[currentIndex];
                //Debug.Log(levels[0].buff.Length);
                for (int j = 0; j < levels[0].buff.Length; j++)
                {
                    //Debug.Log(levels[0].buff[j]);
                    //Debug.Log(item.data.levels[0].buff[j].attribute);
                    levels[0].buff[j] = new ItemBuff(item.data.levels[0].buff[j].value);
                    {
                        levels[0].buff[j].attribute = item.data.levels[0].buff[j].attribute;
                    }
                }
            }
            

        }
        
    }
    [System.Serializable]
    public class ItemLevel
    {
        public ItemBuff[] buff;
    }

    [System.Serializable]
    public class ItemBuff : IModifiers
    {
        public Attributes attribute;
        public float value;
        public ItemBuff(float _value)
        {
            value = _value;
        }

        public void AddValue(ref float baseValue)
        {
            baseValue += value;
        }
    }
    
}