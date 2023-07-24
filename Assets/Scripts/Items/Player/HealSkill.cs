using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealSkill : MonoBehaviour
{
    public float healAmount = 20f;
    // Start is called before the first frame update
    void Start()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        //player.GetComponent<CharacterStats>().HealPlayer(healAmount);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //CharacterStats playerStats = collision.GetComponent<CharacterStats>();
        /*if (playerStats != null)
        {
            playerStats.HealPlayer(healAmount);

            Destroy(this.gameObject);
        }*/

    }
}
