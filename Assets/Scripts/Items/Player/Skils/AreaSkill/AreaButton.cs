using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class AreaButton : MonoBehaviour, IPointerClickHandler
{
    public static int areaSkill1 = 0;
    public static bool isRuning = false;
    public static bool RunningWithRifles = false;
    public static float areaRate = 1;
    public GameObject areaSkill;
    public GameObject areaPrefab;
    private Vector3 sizeScale;


    public Button butoncuk;

    private void Awake()
    {
        sizeScale = new Vector3(1f, 1f, 0f);
        areaPrefab.transform.localScale = new Vector3(2f,2f,0f);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (areaSkill1 >= 6)
        {
            butoncuk.interactable = false;
        }
        else
        {
            areaSkill1++;
            isRuning = true;
            RunningWithRifles = true;
        }
    }
}
