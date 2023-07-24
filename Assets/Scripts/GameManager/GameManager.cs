using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [Header("GameObjeler")]
    public GameObject player;
    public GameObject enemy;
    public GameObject bonusHP;
    public GameObject succesPanel;

    [Header("Textler")]
    //public Text playerHpText;
    /*public Text scoreText;
    public Text totalScoreText;
    public Text totalScoreSuccesText;*/

    [Header("Sayýsal Deðiþkenler")]
    //public int score;
    float timer = 2f;
    float fixTimer;
    float fixTÝmerValue;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
        /*fixTimer = Random.Range(30, 60);
        fixTÝmerValue = fixTimer;*/

        for (int i = 0; i < Random.Range(50,150); i++)
        {
            RandomEnemySpawner();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < Time.time)
        {
            RandomBonusSpawner();

            timer = Time.time + 2;
        }
        //FixVirus();
    }

    public void RandomEnemySpawner()
    {
        Instantiate(enemy, Random.insideUnitCircle * 50, Quaternion.identity);
    }
    void RandomBonusSpawner()
    {
        Instantiate(bonusHP, Random.insideUnitCircle * 9, Quaternion.identity);
    }
    /*void FixVirus()
    {
        fixTimer -= Time.deltaTime;
        fixTimerImage.GetComponent<Image>().fillAmount = fixTimer / fixTÝmerValue;
        if (fixTimer <= 0)
        {
            Time.timeScale = 0;
            succesPanel.SetActive(true);
            totalScoreSuccesText.text = "Total Score = " + score;
        }
    }*/
    public void RetryButton()
    {
        SceneManager.LoadScene(0);
    }
}
