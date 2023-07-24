using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class LandFireButton : MonoBehaviour, IPointerClickHandler
{
    public static int landFireSkill = 0;
    public static float landFireArea = 6;

    public Button butoncuk;
    public void OnPointerClick(PointerEventData eventData)
    {
        if (landFireSkill >= 6)
        {
            butoncuk.interactable = false;
        }
        else
        {
            landFireSkill++;
        }
    }
}
