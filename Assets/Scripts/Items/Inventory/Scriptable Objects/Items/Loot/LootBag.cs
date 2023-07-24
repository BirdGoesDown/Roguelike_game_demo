using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class LootBag : MonoBehaviour//, ISerializationCallbackReceiver
{
    public GameObject droppedItemPrefab;
    [HideInInspector]
    public Sprite dusenItem;
    public List<ItemObject> lootList = new List<ItemObject>();

    [HideInInspector]
    public ItemObject droppedItem;

    //public ItemObject item;

    /* public void OnAfterDeserialize()
     {

     }

     public void OnBeforeSerialize()
     {
 #if UNITY_EDITOR
         GetComponentInChildren<SpriteRenderer>().sprite = item.uiDisplay;
         EditorUtility.SetDirty(GetComponentInChildren<SpriteRenderer>());
 #endif
     }*/
    public ItemObject GetDroppedItems()
    {
        int randomNumber = Random.Range(1, 101);
        List<ItemObject> possibleItems = new List<ItemObject>();
        foreach (ItemObject item in lootList)
        {
            if (randomNumber <= item.dropChance)
            {
                possibleItems.Add(item);
            }
        }
        if (possibleItems.Count > 0)
        {
            droppedItem = possibleItems[Random.Range(0, possibleItems.Count)];
            return droppedItem;
        }
        //Debug.Log("No loot dropped");
        return null;
    }
    public void InstantiateLoot(Vector3 spawnPosition)
    {
        droppedItem = GetDroppedItems();
        if (droppedItem != null)
        {
            GameObject lootGameObject = Instantiate(droppedItemPrefab, spawnPosition, Quaternion.identity);
            lootGameObject.GetComponent<SpriteRenderer>().sprite = droppedItem.uiDisplay;
            lootGameObject.GetComponent<GroundItem>().item = droppedItem;
            dusenItem = droppedItem.uiDisplay;

            /*float dropForce = 300f;
            Vector2 dropDirection = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f));
            lootGameObject.GetComponent<Rigidbody2D>().AddForce(dropDirection * dropForce, ForceMode2D.Impulse);*/

        }
    }
}
