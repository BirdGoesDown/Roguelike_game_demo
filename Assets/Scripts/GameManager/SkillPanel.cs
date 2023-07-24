using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillPanel : MonoBehaviour
{
    /* public GameObject skillMenu;
     private PlayerBasicAttack playerBasicAttack;


     private LevelManager levelManager;

     BuildManager buildManager;
     public Button skillLevelButton1;
     public Button skillLevelButton2;
     public Button skillLevelButton3;
     public Button skillLevelButton4;
     public Button skillLevelButton5;
     public Button skillLevelButton6;
     void Start()
     {
         buildManager = BuildManager.instance;
         LevelUpBasicAttack();

     }
     public void LevelUpBasicAttack()
     {
         if (LevelManager.levelledUp == true)
         {
                 skillMenu.SetActive(true);
                 Time.timeScale = 0f;
         }
        else
             {
                 skillMenu.SetActive(false);
                 Time.timeScale = 1f;
                 skillLevelButton1.interactable = false;
             }

     }
     private void Update()
     {
         if (LevelManager.levelledUp == true)
         {
             Time.timeScale = 0f;
             skillMenu.SetActive(true);
             OnMouseDown();
         }

     }
     private void OnMouseDown()
     {
         if (skillLevelButton1.interactable == true)
         {

             playerBasicAttack.FireCountDown2();
             Debug.Log("vuruyomu");

         }
         else
         {
             skillMenu.SetActive(false);
             Time.timeScale = 1f;
             skillLevelButton1.interactable = false;
         }
     }*/


    public GameObject skillPanel;
    private readonly PlayerBasicAttack playerBasicAttack;
    GameObject player;

    /*private void Update()
    {
        if (LevelManager.levelledUp == true)
        {
            Time.timeScale = 0f;
            skillPanel.SetActive(true);
            LevelManager.levelledUp = false;

        }
    }*/
    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    public void Upgrading()
    {
        GameResuming();
    }
    public void GameResuming()
    {
        Time.timeScale = 1f;
        skillPanel.SetActive(false);
        /*if (Time.timeScale == 1f)
        {
            skillPanel.SetActive(false);
        }  */     
    }


















}