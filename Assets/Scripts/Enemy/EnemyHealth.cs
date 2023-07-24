using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EnemyHealth : MonoBehaviour
{
    [HideInInspector] public float currentHealth;
    private float maxHealth = 100f;
    /*[Header("Boss Caný")]
    public bool usingBOSS = false;
    public float bossHealth;*/
    [Header("Enemy Health")]
    public float enemyHealth;
    

    public int ExpAmount = 10;
    public static event Action<int> onDeath;

    private void Awake()
    {
        currentHealth = maxHealth;
        /*if (usingBOSS == true)
        {
            if (gameObject.tag == "Boss")
            {
                currentHealth = bossHealth;
            }
        }*/
         
        if (gameObject.tag == "Enemy")
        {
            currentHealth = enemyHealth;
        }

    }

    public void TakeDamage(float amount)
    {
        currentHealth -= amount;
        print(amount);
        if (currentHealth <= 0)
        {
            Die();
        }

    }
    void Die()
    {
        GetComponent<LootBag>().InstantiateLoot(transform.position);
        Destroy(gameObject);
        onDeath(ExpAmount);
    }
}
