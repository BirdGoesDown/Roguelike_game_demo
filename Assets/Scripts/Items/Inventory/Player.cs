using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    //public MouseData mouseItem = new MouseData();

    public InventoryObjects inventory;
    public InventoryObjects equipment;

    public TextMeshProUGUI[] verdikleri = new TextMeshProUGUI[6];
    
    [HideInInspector] float currentHealth;
    public float maxHealth;
    public float defense;
    public float evasion;
    public float physicalDmg;
    public float magicalDmg;
    public float critRate;
    public float critDmg = 2;
    public GameObject failPanel;

    private GameManager gameManager;

    public Image playerHpBar;

    public Attribute[] attributes;
    void Awake()
    {
        maxHealth = 1000f;
        currentHealth = maxHealth;
    }
    private void Start()
    {
        for (int i = 0; i < attributes.Length; i++)
        {
            attributes[i].SetParent(this);
        }
        for (int i = 0; i < equipment.GetSlots.Length; i++)
        {
           equipment.GetSlots[i].OnBeforeUpdate += OnBeforeSlotUpdate;
           equipment.GetSlots[i].OnAfterUpdate += OnAfterSlotUpdate;
        }
    }
    public void OnBeforeSlotUpdate(InventorySlot _slot)
    {
        if (_slot.ItemObject == null)
            return;
        switch (_slot.parent.Inventory.type)
        {
            case InterfaceType.Inventory:
                break;
            case InterfaceType.Equipment:
                //print(string.Concat("Removed ", _slot.ItemObject, " on ", _slot.parent.Inventory.type, ", AllowedItems: ", string.Join(", ", _slot.AllowedItems)));
                Debug.Log("deneme1 " + _slot.item.levels);
                for (int i = 0; i < _slot.item.levels.Length; i++)
                {
                    Debug.Log("deneme2 " + _slot.item.levels);
                    for (int z = 0; z < _slot.item.levels[i].buff.Length; z++)
                    {
                        Debug.Log("deneme3 " + _slot.item.levels[i].buff);
                        for (int j = 0; j < attributes.Length; j++)
                        {
                            Debug.Log("deneme4 " + attributes);
                            if (attributes[j].type == _slot.item.levels[i].buff[z].attribute)
                                attributes[j].value.RemoveModifier(_slot.item.levels[i].buff[z]);
                        }
                    }
                    
                }
                break;
            case InterfaceType.Chest:
                break;
            default:
                break;
        }

    }


    public void OnAfterSlotUpdate(InventorySlot _slot)
    {
        if (_slot.ItemObject == null)
            return;
        switch (_slot.parent.Inventory.type)
        {
            case InterfaceType.Inventory:
                break;
            case InterfaceType.Equipment:
                //print(string.Concat("Placed ", _slot.ItemObject, " on ", _slot.parent.Inventory.type, ", AllowedItems: ", string.Join(", ", _slot.AllowedItems)));
                Debug.Log("ses1 " + _slot.item.levels.Length);
                for (int i = 0; i < _slot.item.levels.Length; i++)
                {
                    Debug.Log("ses2 " + _slot.item.levels[i]);
                    for (int k = 0; k < _slot.item.levels[i].buff.Length; k++)
                    {
                        Debug.Log("ses3 " + _slot.item.levels[i].buff[k]);
                        for (int j = 0; j < attributes.Length; j++)
                        {
                            Debug.Log("ses4 " + attributes.Length);
                            if (attributes[j].type == _slot.item.levels[i].buff[k].attribute)
                                attributes[j].value.AddModifier(_slot.item.levels[i].buff[k]);
                        }
                    }

                }
                /*for (int i = 0; i < _slot.item.buffs.Length; i++)
                {
                    for (int j = 0; j < attributes.Length; j++)
                    {
                        if (attributes[j].type == _slot.item.buffs[i].attribute)
                            attributes[j].value.AddModifier(_slot.item.buffs[i]);
                    }
                }*/
                break;
            case InterfaceType.Chest:
                break;
            default:
                break;
        }
    }
    /*public void OnBeforeSlotUpdate(InventorySlot _slot)
    {
        if (_slot.ItemObject == null)
            return;
        switch (_slot.parent.Inventory.type)
        {
            case InterfaceType.Inventory:
                break;
            case InterfaceType.Equipment:
                //print(string.Concat("Removed ", _slot.ItemObject, " on ", _slot.parent.Inventory.type, ", AllowedItems: ", string.Join(", ", _slot.AllowedItems)));

                for (int i = 0; i < _slot.item.level.Length; i++)
                {
                    for (int z = 0; z < _slot.item.level[i].buff.Length; z++)
                    {
                        for (int j = 0; j < attributes.Length; j++)
                        {
                            if (attributes[j].type == _slot.item.level[0].buff[z].attribute)
                                attributes[j].value.RemoveModifier(_slot.item.level[0].buff[z]);
                        }
                    }
                    
                }
                break;
            case InterfaceType.Chest:
                break;
            default:
                break;
        }

    }


    public void OnAfterSlotUpdate(InventorySlot _slot)
    {
        if (_slot.ItemObject == null)
            return;
        switch (_slot.parent.Inventory.type)
        {
            case InterfaceType.Inventory:
                break;
            case InterfaceType.Equipment:
                //print(string.Concat("Placed ", _slot.ItemObject, " on ", _slot.parent.Inventory.type, ", AllowedItems: ", string.Join(", ", _slot.AllowedItems)));

                for (int i = 0; i < _slot.item.level.Length; i++)
                {
                    for (int z = 0; z < _slot.item.level[i].buff.Length; z++)
                    {
                        for (int j = 0; j < attributes.Length; j++)
                        {
                            if (attributes[j].type == _slot.item.level[0].buff[z].attribute)
                                attributes[j].value.AddModifier(_slot.item.level[0].buff[z]);
                        }
                    }

                }
                break;
            case InterfaceType.Chest:
                break;
            default:
                break;
        }
    }*/
    private void OnTriggerEnter2D(Collider2D collision)
    {
        var groundItem = collision.GetComponent<GroundItem>();

        if (groundItem)
        {
            Item _item = new Item(groundItem.item);
            if (inventory.AddItem(_item, 1))
            {
                Destroy(collision.gameObject);
            }
        }
    }
    private void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            inventory.Save();
            equipment.Save();
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            inventory.Load();
            equipment.Load();

        }
    }
    public void AttributeModified(Attribute attribute)
    {
        //Debug.Log(string.Concat(attribute.type, " was updated! Value is now ", attribute.value.ModifiedValue));
        for (int i = 0; i < attributes.Length; i++)
        {
            for (int j = 0; j < verdikleri.Length; j++)
            {
                string ozellik = attributes[0].value.ModifiedValue.ToString();
                verdikleri[0].text = ("" + ozellik);
                string ozellik1 = attributes[1].value.ModifiedValue.ToString();
                verdikleri[1].text = ("" + ozellik1);
                string ozellik2 = attributes[2].value.ModifiedValue.ToString();
                verdikleri[2].text = ("" + ozellik2);
                string ozellik3 = attributes[3].value.ModifiedValue.ToString();
                verdikleri[3].text = ("" + ozellik3);
                string ozellik4 = attributes[4].value.ModifiedValue.ToString();
                verdikleri[4].text = ("" + ozellik4);
                string ozellik5 = attributes[5].value.ModifiedValue.ToString();
                verdikleri[5].text = ("" + ozellik5);

                maxHealth = attributes[0].value.ModifiedValue;
                defense = attributes[1].value.ModifiedValue;
                evasion = attributes[2].value.ModifiedValue;
                physicalDmg = attributes[3].value.ModifiedValue;
                magicalDmg = attributes[4].value.ModifiedValue;
                critRate = 1 + attributes[5].value.ModifiedValue;

                
            }
        }
    }
    void PlayerDead()
    {
        Time.timeScale = 0;
        failPanel.SetActive(true);
        //gameManager.totalScoreText.text = "Total Score = " + gameManager.score;
    }
    public void TakeDamage(float amount)
    {
        float randomNumber = UnityEngine.Random.Range(1, 101);
        amount -= (defense * 10 / 100);
        amount = Mathf.Clamp(amount, 0, int.MaxValue);
        UpdateHealth();
        if (randomNumber <= evasion)
        {
            currentHealth -= 0;
        }
        else
        {
            currentHealth -= amount;
        }
        //Debug.Log(transform.name + " takes " + amount + " damage.");

        // If we hit 0. Die.
        if (currentHealth <= 0)
        {
            PlayerDead();
        }
    }
    public void HealPlayer(float amount)
    {
        currentHealth += amount;
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
        UpdateHealth();
    }
    public void UpdateHealth()
    {
        playerHpBar.fillAmount = currentHealth / maxHealth;
        //currentHealth = maxHealth * 0.5f;
    }
    /*private void OnTriggerEnter2D(Collider2D collision)
    {   if (collision.tag.Contains("Bonus"))
        {
            HealPlayer(currentHealth+10);
            if (currentHealth > maxHealth)
            {
                currentHealth = maxHealth;
                //gameManager.playerHpText.text = currentHealth + " / " + maxHealth;
                Destroy(collision.gameObject);

            }

        }
    }*/

    /*private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Contains("Enemy"))
        {
            currentHealth -= 10;
            gameManager.healthImage.fillAmount = currentHealth / maxHealth;
            gameManager.playerHpText.text = currentHealth + " / " + maxHealth;
            if (currentHealth <=0)
            {
                PlayerDead();
            }
        }
        else if (collision.tag.Contains("Bonus"))
        {
            if (currentHealth < maxHealth)
            {
                gameManager.healthImage.fillAmount = currentHealth / maxHealth;
                currentHealth += 10;
                gameManager.playerHpText.text = currentHealth + " / " + maxHealth;
                Destroy(collision.gameObject);

            }
            else if (currentHealth == maxHealth)
            {
                currentHealth = maxHealth;
                Destroy(collision.gameObject);
            }
            
        }
    }*/
    private void OnApplicationQuit()
    {
        inventory.Clear();
        equipment.Clear();
    }
}

[System.Serializable]
public class Attribute
{
    [System.NonSerialized]
    public Player parent;
    public Attributes type;
    public ModifiableInt value;

    public void SetParent(Player _parent)
    {
        parent = _parent;
        value = new ModifiableInt(AttributeModified);
    }
    public void AttributeModified()
    {
        parent.AttributeModified(this);
    }
}
