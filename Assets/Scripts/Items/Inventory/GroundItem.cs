using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class GroundItem : MonoBehaviour, ISerializationCallbackReceiver
{
    public ItemObject item;
    [HideInInspector]
    public LootBag lootBag;
    public void OnAfterDeserialize()
    {

    }

    public void OnBeforeSerialize()
    {
        #if UNITY_EDITOR
            //GetComponent<SpriteRenderer>().sprite = lootBag.droppedItem.uiDisplay;
            EditorUtility.SetDirty(GetComponentInChildren<SpriteRenderer>());
        #endif
    }
}
