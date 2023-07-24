using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlacksmithController : MonoBehaviour
{
    public GameObject inventorybutton;
    public GameObject equipmentScreen;
    public GameObject characterStats;
    public GameObject BlacksmithScreen;
    public Button exitButton;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Time.timeScale = 0;
            inventorybutton.SetActive(true);
            equipmentScreen.SetActive(false);
            characterStats.SetActive(false);
            BlacksmithScreen.SetActive(true);
        }
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            equipmentScreen.SetActive(true);
            characterStats.SetActive(true);
            BlacksmithScreen.SetActive(false);
        }
        
    }

}