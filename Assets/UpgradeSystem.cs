using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UpgradeSystem : MonoBehaviour, IPointerClickHandler
{
    public ItemDatabaseObject data;
    public BlacksmithInterface blacksmithInterface;
	public InventoryObjects inventory;
	public void OnPointerClick(PointerEventData eventData)
	{
        for (int i = 0; i < data.ItemObjects.LongLength; i++)
        {
			
            data.ItemObjects[i] = blacksmithInterface.Inventory.Container.Slots[0].ItemObject;
            print(blacksmithInterface.Inventory.Container.Slots[0].ItemObject);
            print(blacksmithInterface.Inventory.Container.Slots[3].ItemObject);
            if (data.ItemObjects[1])
            {
				inventory.SwapItems(blacksmithInterface.Inventory.Container.Slots[0], blacksmithInterface.Inventory.Container.Slots[3]);
				//data.ItemObjects[2] = blacksmithInterface.Inventory.Container.Slots[3].ItemObject;
                return;
            }
            if (data.ItemObjects[2])
            {
                inventory.SwapItems(blacksmithInterface.Inventory.Container.Slots[0], blacksmithInterface.Inventory.Container.Slots[3]);
                return;
            }
            if (data.ItemObjects[3])
            {
                inventory.SwapItems(blacksmithInterface.Inventory.Container.Slots[0], blacksmithInterface.Inventory.Container.Slots[3]);
                return;
            }
            
        }
    }
}
