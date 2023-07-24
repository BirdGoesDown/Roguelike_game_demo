using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class BasicSkillButton : MonoBehaviour, IPointerClickHandler
{
    public static int  basicSkill1 = 0;
    public static float  basicFireRate = 1;

    public Button butoncuk;
    public Text butonText;
    public void OnPointerClick(PointerEventData eventData)
    {
        if (basicSkill1 >= 6)
        {
            butoncuk.interactable = false;
        }
        else
        {
            basicSkill1++;
        }
        switch (basicSkill1)
        {
            case 1:
                butonText.text = ("Atış hızı %20 artar ve Hasarı 10 artar");
                break;
            case 2:
                butonText.text = ("Atış hızı %30 artar ve Hasarı 20 artar");
                break;
            case 3:
                butonText.text = ("Atış hızı %40 artar ve Hasarı 30 artar");
                break;
            case 4:
                butonText.text = ("Atış hızı %50 artar ve Hasarı 40 artar");
                break;
            case 5:
                butonText.text = ("Atış hızı %60 artar ve Hasarı 50 artar");
                break;
            case 6:
                butonText.text = ("Atış hızı %70 artar ve Hasarı 60 artar");
                break;
            default:
                //Debug.Log("Area Level : Full");
                break;
        }

    }
}
