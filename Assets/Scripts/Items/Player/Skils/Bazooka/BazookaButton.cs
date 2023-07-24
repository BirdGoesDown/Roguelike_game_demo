using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class BazookaButton : MonoBehaviour, IPointerClickHandler
{
    public static int bazookaSkill = 0;
    public static float bazookaRate = 1f;

    public Button butoncuk;
    public void OnPointerClick(PointerEventData eventData)
    {
        if (bazookaSkill >= 6)
        {
            butoncuk.interactable = false;
        }
        else
        {
            bazookaSkill++;
        }
        print(bazookaSkill);
    }
}
