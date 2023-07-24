using UnityEngine;
using TMPro;

public class ItemDetails : MonoBehaviour
{
    public GameObject ItemName;
    public GameObject statNameText1;
    public GameObject statText1;
    public GameObject statNameText2;
    public GameObject statText2;
    public GameObject statNameText3;
    public GameObject statText3;
    public GameObject statNameText4;
    public GameObject statText4;
    public GameObject statNameText5;
    public GameObject statText5;
    public GameObject statNameText6;
    public GameObject statText6;

    UserInterface userInterface;
    InventoryObjects inventory;
    Attribute[] attributes;
    //InventorySlot _slot;
    private int currentLevel = 0;
    private int selectedLevel = 0;

    /*private void Start()
    {
        selectedLevel = mouseHoverSlotData.ItemObject.selectedLevel;
        currentLevel = selectedLevel;
        Debug.Log("seçilen2 " + mouseHoverSlotData.item.levels[currentLevel]);
        mouseHoverSlotData.item.levels[selectedLevel] = mouseHoverSlotData.item.levels[currentLevel];
        ItemLevelName.GetComponentInChildren<TextMeshProUGUI>().text = "" + (currentLevel + 1);
    }*/
    public void ItemDetail(InventorySlot _slot)
    {
        //ItemName.GetComponentInChildren<TextMeshProUGUI>().text = _slot.item.Name + _slot.item.levels[i];
        //MouseData.slotHoveredOver = obj;
        if (MouseData.slotHoveredOver == null)
        {
            return;
        }
        _slot = MouseData.interfaceMouseIsOver.slotsOnInterface[MouseData.slotHoveredOver];
        for (int i = 0; i < _slot.item.levels.Length; i++)
        {
            for (int j = 0; j < _slot.item.levels[i].buff.Length; j++)
            {
                ItemName.GetComponentInChildren<TextMeshProUGUI>().text = _slot.item.Name + " +" + i;
                if (_slot.item.Id > 0 && _slot.item.levels[i].buff[0].value >= 0 && j == 0)
                {
                    statText2.SetActive(false);
                    statNameText2.SetActive(false);
                    statText3.SetActive(false);
                    statNameText3.SetActive(false);
                    statText4.SetActive(false);
                    statNameText4.SetActive(false);
                    statText5.SetActive(false);
                    statNameText5.SetActive(false);
                    statText6.SetActive(false);
                    statNameText6.SetActive(false);

                    statText1.SetActive(true);
                    statNameText1.SetActive(true);
                    statText1.GetComponentInChildren<TextMeshProUGUI>().text = _slot.item.levels[i].buff[0].value.ToString();
                    statNameText1.GetComponentInChildren<TextMeshProUGUI>().text = _slot.item.levels[i].buff[0].attribute.ToString();

                }
                else if (_slot.item.Id > 0 && _slot.item.levels[i].buff[0].value >= 0 && j == 1)
                {
                    statText3.SetActive(false);
                    statNameText3.SetActive(false);
                    statText4.SetActive(false);
                    statNameText4.SetActive(false);
                    statText5.SetActive(false);
                    statNameText5.SetActive(false);
                    statText6.SetActive(false);
                    statNameText6.SetActive(false);

                    statText1.SetActive(true);
                    statNameText1.SetActive(true);
                    statText1.GetComponentInChildren<TextMeshProUGUI>().text = _slot.item.levels[i].buff[0].value.ToString();
                    statNameText1.GetComponentInChildren<TextMeshProUGUI>().text = _slot.item.levels[i].buff[0].attribute.ToString();
                    statText2.SetActive(true);
                    statNameText2.SetActive(true);
                    statText2.GetComponentInChildren<TextMeshProUGUI>().text = _slot.item.levels[i].buff[1].value.ToString();
                    statNameText2.GetComponentInChildren<TextMeshProUGUI>().text = _slot.item.levels[i].buff[1].attribute.ToString();
                }
                else if (_slot.item.Id > 0 && _slot.item.levels[i].buff[0].value >= 0 && j == 2)
                {
                    statText4.SetActive(false);
                    statNameText4.SetActive(false);
                    statText5.SetActive(false);
                    statNameText5.SetActive(false);
                    statText6.SetActive(false);
                    statNameText6.SetActive(false);

                    statText1.SetActive(true);
                    statNameText1.SetActive(true);
                    statText1.GetComponentInChildren<TextMeshProUGUI>().text = _slot.item.levels[i].buff[0].value.ToString();
                    statNameText1.GetComponentInChildren<TextMeshProUGUI>().text = _slot.item.levels[i].buff[0].attribute.ToString();
                    statText2.SetActive(true);
                    statNameText2.SetActive(true);
                    statText2.GetComponentInChildren<TextMeshProUGUI>().text = _slot.item.levels[i].buff[1].value.ToString();
                    statNameText2.GetComponentInChildren<TextMeshProUGUI>().text = _slot.item.levels[i].buff[1].attribute.ToString();
                    statText3.SetActive(true);
                    statNameText3.SetActive(true);
                    statText3.GetComponentInChildren<TextMeshProUGUI>().text = _slot.item.levels[i].buff[2].value.ToString();
                    statNameText3.GetComponentInChildren<TextMeshProUGUI>().text = _slot.item.levels[i].buff[2].attribute.ToString();
                }
                else if (_slot.item.Id > 0 && _slot.item.levels[i].buff[0].value >= 0 && j == 3)
                {
                    statText5.SetActive(false);
                    statNameText5.SetActive(false);
                    statText6.SetActive(false);
                    statNameText6.SetActive(false);

                    statText1.SetActive(true);
                    statNameText1.SetActive(true);
                    statText1.GetComponentInChildren<TextMeshProUGUI>().text = _slot.item.levels[i].buff[0].value.ToString();
                    statNameText1.GetComponentInChildren<TextMeshProUGUI>().text = _slot.item.levels[i].buff[0].attribute.ToString();
                    statText2.SetActive(true);
                    statNameText2.SetActive(true);
                    statText2.GetComponentInChildren<TextMeshProUGUI>().text = _slot.item.levels[i].buff[1].value.ToString();
                    statNameText2.GetComponentInChildren<TextMeshProUGUI>().text = _slot.item.levels[i].buff[1].attribute.ToString();
                    statText3.SetActive(true);
                    statNameText3.SetActive(true);
                    statText3.GetComponentInChildren<TextMeshProUGUI>().text = _slot.item.levels[i].buff[2].value.ToString();
                    statNameText3.GetComponentInChildren<TextMeshProUGUI>().text = _slot.item.levels[i].buff[2].attribute.ToString();
                    statText4.SetActive(true);
                    statNameText4.SetActive(true);
                    statText4.GetComponentInChildren<TextMeshProUGUI>().text = _slot.item.levels[i].buff[3].value.ToString();
                    statNameText4.GetComponentInChildren<TextMeshProUGUI>().text = _slot.item.levels[i].buff[3].attribute.ToString();
                }
                else if (_slot.item.Id > 0 && _slot.item.levels[i].buff[0].value >= 0 && j == 4)
                {
                    statText6.SetActive(false);
                    statNameText6.SetActive(false);

                    statText1.SetActive(true);
                    statNameText1.SetActive(true);
                    statText1.GetComponentInChildren<TextMeshProUGUI>().text = _slot.item.levels[i].buff[0].value.ToString();
                    statNameText1.GetComponentInChildren<TextMeshProUGUI>().text = _slot.item.levels[i].buff[0].attribute.ToString();
                    statText2.SetActive(true);
                    statNameText2.SetActive(true);
                    statText2.GetComponentInChildren<TextMeshProUGUI>().text = _slot.item.levels[i].buff[1].value.ToString();
                    statNameText2.GetComponentInChildren<TextMeshProUGUI>().text = _slot.item.levels[i].buff[1].attribute.ToString();
                    statText3.SetActive(true);
                    statNameText3.SetActive(true);
                    statText3.GetComponentInChildren<TextMeshProUGUI>().text = _slot.item.levels[i].buff[2].value.ToString();
                    statNameText3.GetComponentInChildren<TextMeshProUGUI>().text = _slot.item.levels[i].buff[2].attribute.ToString();
                    statText4.SetActive(true);
                    statNameText4.SetActive(true);
                    statText4.GetComponentInChildren<TextMeshProUGUI>().text = _slot.item.levels[i].buff[3].value.ToString();
                    statNameText4.GetComponentInChildren<TextMeshProUGUI>().text = _slot.item.levels[i].buff[3].attribute.ToString();
                    statText5.SetActive(true);
                    statNameText5.SetActive(true);
                    statText5.GetComponentInChildren<TextMeshProUGUI>().text = _slot.item.levels[i].buff[4].value.ToString();
                    statNameText5.GetComponentInChildren<TextMeshProUGUI>().text = _slot.item.levels[i].buff[4].attribute.ToString();
                }
                else if (_slot.item.Id > 0 && _slot.item.levels[i].buff[0].value >= 0 && j == 5)
                {
                    statText1.SetActive(true);
                    statNameText1.SetActive(true);
                    statText1.GetComponentInChildren<TextMeshProUGUI>().text = _slot.item.levels[i].buff[0].value.ToString();
                    statNameText1.GetComponentInChildren<TextMeshProUGUI>().text = _slot.item.levels[i].buff[0].attribute.ToString();
                    statText2.SetActive(true);
                    statNameText2.SetActive(true);
                    statText2.GetComponentInChildren<TextMeshProUGUI>().text = _slot.item.levels[i].buff[1].value.ToString();
                    statNameText2.GetComponentInChildren<TextMeshProUGUI>().text = _slot.item.levels[i].buff[1].attribute.ToString();
                    statText3.SetActive(true);
                    statNameText3.SetActive(true);
                    statText3.GetComponentInChildren<TextMeshProUGUI>().text = _slot.item.levels[i].buff[2].value.ToString();
                    statNameText3.GetComponentInChildren<TextMeshProUGUI>().text = _slot.item.levels[i].buff[2].attribute.ToString();
                    statText4.SetActive(true);
                    statNameText4.SetActive(true);
                    statText4.GetComponentInChildren<TextMeshProUGUI>().text = _slot.item.levels[i].buff[3].value.ToString();
                    statNameText4.GetComponentInChildren<TextMeshProUGUI>().text = _slot.item.levels[i].buff[3].attribute.ToString();
                    statText5.SetActive(true);
                    statNameText5.SetActive(true);
                    statText5.GetComponentInChildren<TextMeshProUGUI>().text = _slot.item.levels[i].buff[4].value.ToString();
                    statNameText5.GetComponentInChildren<TextMeshProUGUI>().text = _slot.item.levels[i].buff[4].attribute.ToString();
                    statText6.SetActive(true);
                    statNameText6.SetActive(true);
                    statText6.GetComponentInChildren<TextMeshProUGUI>().text = _slot.item.levels[i].buff[5].value.ToString();
                    statNameText6.GetComponentInChildren<TextMeshProUGUI>().text = _slot.item.levels[i].buff[5].attribute.ToString();
                }
                else
                {
                    statText1.SetActive(false);
                    statNameText1.SetActive(false);
                    statText2.SetActive(false);
                    statNameText2.SetActive(false);
                    statText3.SetActive(false);
                    statNameText3.SetActive(false);
                    statText4.SetActive(false);
                    statNameText4.SetActive(false);
                    statText5.SetActive(false);
                    statNameText5.SetActive(false);
                    statText6.SetActive(false);
                    statNameText6.SetActive(false);
                }
            }
            
        }
    }
    /*public void ItemDetail()
    {
        //MouseData.slotHoveredOver = obj;
        if (MouseData.slotHoveredOver == null)
        {
            return;
        }
       mouseHoverSlotData = MouseData.interfaceMouseIsOver.slotsOnInterface[MouseData.slotHoveredOver];
        print(MouseData.slotHoveredOver);
        for (int i = 0; i < mouseHoverSlotData.item.level.Length; i++)
        {
            print(mouseHoverSlotData.item.level[0].buff.Length);
            for (int j = 0; j < mouseHoverSlotData.item.level[i].buff.Length; j++)
            {
                ItemName.GetComponentInChildren<TextMeshProUGUI>().text = mouseHoverSlotData.item.Name;
                if (mouseHoverSlotData.item.Id >= 0 && mouseHoverSlotData.item.level[i].buff[0].value >= 0 && i == 0)
                {
                    statText2.SetActive(false);
                    statNameText2.SetActive(false);
                    statText3.SetActive(false);
                    statNameText3.SetActive(false);
                    statText4.SetActive(false);
                    statNameText4.SetActive(false);
                    statText5.SetActive(false);
                    statNameText5.SetActive(false);
                    statText6.SetActive(false);
                    statNameText6.SetActive(false);

                    statText1.SetActive(true);
                    statNameText1.SetActive(true);
                    statText1.GetComponentInChildren<TextMeshProUGUI>().text = mouseHoverSlotData.item.level[i].buff[0].value.ToString();
                    statNameText1.GetComponentInChildren<TextMeshProUGUI>().text = mouseHoverSlotData.item.level[i].buff[0].attribute.ToString();

                }
                else if (mouseHoverSlotData.item.Id >= 0 && mouseHoverSlotData.item.level[i].buff[0].value >= 0 && i == 1)
                {
                    statText3.SetActive(false);
                    statNameText3.SetActive(false);
                    statText4.SetActive(false);
                    statNameText4.SetActive(false);
                    statText5.SetActive(false);
                    statNameText5.SetActive(false);
                    statText6.SetActive(false);
                    statNameText6.SetActive(false);

                    statText1.SetActive(true);
                    statNameText1.SetActive(true);
                    statText1.GetComponentInChildren<TextMeshProUGUI>().text = mouseHoverSlotData.item.level[i].buff[0].value.ToString();
                    statNameText1.GetComponentInChildren<TextMeshProUGUI>().text = mouseHoverSlotData.item.level[i].buff[0].attribute.ToString();
                    statText2.SetActive(true);
                    statNameText2.SetActive(true);
                    statText2.GetComponentInChildren<TextMeshProUGUI>().text = mouseHoverSlotData.item.level[i].buff[1].value.ToString();
                    statNameText2.GetComponentInChildren<TextMeshProUGUI>().text = mouseHoverSlotData.item.level[i].buff[1].attribute.ToString();
                }
                else if (mouseHoverSlotData.item.Id >= 0 && mouseHoverSlotData.item.level[i].buff[0].value >= 0 && i == 2)
                {
                    statText4.SetActive(false);
                    statNameText4.SetActive(false);
                    statText5.SetActive(false);
                    statNameText5.SetActive(false);
                    statText6.SetActive(false);
                    statNameText6.SetActive(false);

                    statText1.SetActive(true);
                    statNameText1.SetActive(true);
                    statText1.GetComponentInChildren<TextMeshProUGUI>().text = mouseHoverSlotData.item.level[i].buff[0].value.ToString();
                    statNameText1.GetComponentInChildren<TextMeshProUGUI>().text = mouseHoverSlotData.item.level[i].buff[0].attribute.ToString();
                    statText2.SetActive(true);
                    statNameText2.SetActive(true);
                    statText2.GetComponentInChildren<TextMeshProUGUI>().text = mouseHoverSlotData.item.level[i].buff[1].value.ToString();
                    statNameText2.GetComponentInChildren<TextMeshProUGUI>().text = mouseHoverSlotData.item.level[i].buff[1].attribute.ToString();
                    statText3.SetActive(true);
                    statNameText3.SetActive(true);
                    statText3.GetComponentInChildren<TextMeshProUGUI>().text = mouseHoverSlotData.item.level[i].buff[2].value.ToString();
                    statNameText3.GetComponentInChildren<TextMeshProUGUI>().text = mouseHoverSlotData.item.level[i].buff[2].attribute.ToString();
                }
                else if (mouseHoverSlotData.item.Id >= 0 && mouseHoverSlotData.item.level[i].buff[0].value >= 0 && i == 3)
                {
                    statText5.SetActive(false);
                    statNameText5.SetActive(false);
                    statText6.SetActive(false);
                    statNameText6.SetActive(false);

                    statText1.SetActive(true);
                    statNameText1.SetActive(true);
                    statText1.GetComponentInChildren<TextMeshProUGUI>().text = mouseHoverSlotData.item.level[i].buff[0].value.ToString();
                    statNameText1.GetComponentInChildren<TextMeshProUGUI>().text = mouseHoverSlotData.item.level[i].buff[0].attribute.ToString();
                    statText2.SetActive(true);
                    statNameText2.SetActive(true);
                    statText2.GetComponentInChildren<TextMeshProUGUI>().text = mouseHoverSlotData.item.level[i].buff[1].value.ToString();
                    statNameText2.GetComponentInChildren<TextMeshProUGUI>().text = mouseHoverSlotData.item.level[i].buff[1].attribute.ToString();
                    statText3.SetActive(true);
                    statNameText3.SetActive(true);
                    statText3.GetComponentInChildren<TextMeshProUGUI>().text = mouseHoverSlotData.item.level[i].buff[2].value.ToString();
                    statNameText3.GetComponentInChildren<TextMeshProUGUI>().text = mouseHoverSlotData.item.level[i].buff[2].attribute.ToString();
                    statText4.SetActive(true);
                    statNameText4.SetActive(true);
                    statText4.GetComponentInChildren<TextMeshProUGUI>().text = mouseHoverSlotData.item.level[i].buff[3].value.ToString();
                    statNameText4.GetComponentInChildren<TextMeshProUGUI>().text = mouseHoverSlotData.item.level[i].buff[3].attribute.ToString();
                }
                else if (mouseHoverSlotData.item.Id >= 0 && mouseHoverSlotData.item.level[i].buff[0].value >= 0 && i == 4)
                {
                    statText6.SetActive(false);
                    statNameText6.SetActive(false);

                    statText1.SetActive(true);
                    statNameText1.SetActive(true);
                    statText1.GetComponentInChildren<TextMeshProUGUI>().text = mouseHoverSlotData.item.level[i].buff[0].value.ToString();
                    statNameText1.GetComponentInChildren<TextMeshProUGUI>().text = mouseHoverSlotData.item.level[i].buff[0].attribute.ToString();
                    statText2.SetActive(true);
                    statNameText2.SetActive(true);
                    statText2.GetComponentInChildren<TextMeshProUGUI>().text = mouseHoverSlotData.item.level[i].buff[1].value.ToString();
                    statNameText2.GetComponentInChildren<TextMeshProUGUI>().text = mouseHoverSlotData.item.level[i].buff[1].attribute.ToString();
                    statText3.SetActive(true);
                    statNameText3.SetActive(true);
                    statText3.GetComponentInChildren<TextMeshProUGUI>().text = mouseHoverSlotData.item.level[i].buff[2].value.ToString();
                    statNameText3.GetComponentInChildren<TextMeshProUGUI>().text = mouseHoverSlotData.item.level[i].buff[2].attribute.ToString();
                    statText4.SetActive(true);
                    statNameText4.SetActive(true);
                    statText4.GetComponentInChildren<TextMeshProUGUI>().text = mouseHoverSlotData.item.level[i].buff[3].value.ToString();
                    statNameText4.GetComponentInChildren<TextMeshProUGUI>().text = mouseHoverSlotData.item.level[i].buff[3].attribute.ToString();
                    statText5.SetActive(true);
                    statNameText5.SetActive(true);
                    statText5.GetComponentInChildren<TextMeshProUGUI>().text = mouseHoverSlotData.item.level[i].buff[4].value.ToString();
                    statNameText5.GetComponentInChildren<TextMeshProUGUI>().text = mouseHoverSlotData.item.level[i].buff[4].attribute.ToString();
                }
                else if (mouseHoverSlotData.item.Id >= 0 && mouseHoverSlotData.item.level[i].buff[0].value >= 0 && i == 5)
                {
                    statText1.SetActive(true);
                    statNameText1.SetActive(true);
                    statText1.GetComponentInChildren<TextMeshProUGUI>().text = mouseHoverSlotData.item.level[i].buff[0].value.ToString();
                    statNameText1.GetComponentInChildren<TextMeshProUGUI>().text = mouseHoverSlotData.item.level[i].buff[0].attribute.ToString();
                    statText2.SetActive(true);
                    statNameText2.SetActive(true);
                    statText2.GetComponentInChildren<TextMeshProUGUI>().text = mouseHoverSlotData.item.level[i].buff[1].value.ToString();
                    statNameText2.GetComponentInChildren<TextMeshProUGUI>().text = mouseHoverSlotData.item.level[i].buff[1].attribute.ToString();
                    statText3.SetActive(true);
                    statNameText3.SetActive(true);
                    statText3.GetComponentInChildren<TextMeshProUGUI>().text = mouseHoverSlotData.item.level[i].buff[2].value.ToString();
                    statNameText3.GetComponentInChildren<TextMeshProUGUI>().text = mouseHoverSlotData.item.level[i].buff[2].attribute.ToString();
                    statText4.SetActive(true);
                    statNameText4.SetActive(true);
                    statText4.GetComponentInChildren<TextMeshProUGUI>().text = mouseHoverSlotData.item.level[i].buff[3].value.ToString();
                    statNameText4.GetComponentInChildren<TextMeshProUGUI>().text = mouseHoverSlotData.item.level[i].buff[3].attribute.ToString();
                    statText5.SetActive(true);
                    statNameText5.SetActive(true);
                    statText5.GetComponentInChildren<TextMeshProUGUI>().text = mouseHoverSlotData.item.level[i].buff[4].value.ToString();
                    statNameText5.GetComponentInChildren<TextMeshProUGUI>().text = mouseHoverSlotData.item.level[i].buff[4].attribute.ToString();
                    statText6.SetActive(true);
                    statNameText6.SetActive(true);
                    statText6.GetComponentInChildren<TextMeshProUGUI>().text = mouseHoverSlotData.item.level[i].buff[5].value.ToString();
                    statNameText6.GetComponentInChildren<TextMeshProUGUI>().text = mouseHoverSlotData.item.level[i].buff[5].attribute.ToString();
                }
                else
                {
                    statText1.SetActive(false);
                    statNameText1.SetActive(false);
                    statText2.SetActive(false);
                    statNameText2.SetActive(false);
                    statText3.SetActive(false);
                    statNameText3.SetActive(false);
                    statText4.SetActive(false);
                    statNameText4.SetActive(false);
                    statText5.SetActive(false);
                    statNameText5.SetActive(false);
                    statText6.SetActive(false);
                    statNameText6.SetActive(false);
                }
            }
            
        }
    }*/

    public void Equip(InventorySlot _slot)
    {
        _slot = MouseData.interfaceMouseIsOver.slotsOnInterface[MouseData.slotHoveredOver];
        ItemObject item = _slot.ItemObject;
        print(item);
        if (MouseData.slotHoveredOver != null && _slot.item.Id >= 0)
        {

            inventory.SwapItems(userInterface.slotsOnInterface[MouseData.slotHoveredOver], _slot);

        }
    }
}
