using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    [HideInInspector] float currentHealth;
    public float maxHealth = 500;
    public GameObject failPanel;

    private GameManager gameManager;

    public Image playerHpBar;

    // Start is called before the first frame update
    void Awake()
    {
        currentHealth = maxHealth;
    }
    void PlayerDead()
    {
        Time.timeScale = 0;
        failPanel.SetActive(true);
        //gameManager.totalScoreText.text = "Total Score = " + gameManager.score;
    }
    public void TakeDamage(float amount)
    {
            currentHealth -= amount;
            UpdateHealth();

            if (currentHealth <= 0)
            {
                PlayerDead();
            }
    }
    public void HealPlayer(float amount)
    {
        currentHealth += amount;
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
        UpdateHealth();
    }
    public void UpdateHealth()
    {
        playerHpBar.fillAmount = currentHealth / maxHealth;
    }
    /*private void OnTriggerEnter2D(Collider2D collision)
    {   if (collision.tag.Contains("Bonus"))
        {
            HealPlayer(currentHealth+10);
            if (currentHealth > maxHealth)
            {
                currentHealth = maxHealth;
                //gameManager.playerHpText.text = currentHealth + " / " + maxHealth;
                Destroy(collision.gameObject);

            }

        }
    }*/

    /*private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Contains("Enemy"))
        {
            currentHealth -= 10;
            gameManager.healthImage.fillAmount = currentHealth / maxHealth;
            gameManager.playerHpText.text = currentHealth + " / " + maxHealth;
            if (currentHealth <=0)
            {
                PlayerDead();
            }
        }
        else if (collision.tag.Contains("Bonus"))
        {
            if (currentHealth < maxHealth)
            {
                gameManager.healthImage.fillAmount = currentHealth / maxHealth;
                currentHealth += 10;
                gameManager.playerHpText.text = currentHealth + " / " + maxHealth;
                Destroy(collision.gameObject);

            }
            else if (currentHealth == maxHealth)
            {
                currentHealth = maxHealth;
                Destroy(collision.gameObject);
            }
            
        }
    }*/
}
