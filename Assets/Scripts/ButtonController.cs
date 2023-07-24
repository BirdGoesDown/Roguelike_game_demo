using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonController : MonoBehaviour
{
    public GameObject buttonControl;
    public GameObject baseButton;

    public bool opened;

    LevelManager levelManager;

    int skillPoint;
    //public TextMeshProUGUI skillPointText;
    //public bool skillPointing = false;

    public void SkillPanelButton()
    {
        Time.timeScale = 0;
        buttonControl.SetActive(true);
        baseButton.SetActive(false);
        opened = true;
    }
    public void SkillPanelExitButton()
    {
        Time.timeScale = 1;
        buttonControl.SetActive(false);
        baseButton.SetActive(true);
    }

    /*private void Update()
    {
        SkillPoint();
    }
    public void SkillPoint()
    {
        if (LevelManager.skillPointing == true)
        {
            skillPoint += 1;
            skillPointText.text = "Skill Point = " + skillPoint;
            LevelManager.skillPointing = false;
        }
    }*/
}
