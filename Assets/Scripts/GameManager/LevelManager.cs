using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LevelManager : MonoBehaviour
{
    public float currentExp;
    private int level;
    public float expToNextLevel;
    //public int GetLevel { get { return level + 1; } }
    public static LevelManager instance;

    public Image ExpBar;
    public Text LevelText;
    public TextMeshProUGUI statLevelText;
    public TextMeshProUGUI statExpToNextLvl;
    public TextMeshProUGUI statKillCount;
    //public ButtonController buttonController;
    public static bool skillPointing = false;

    public GameObject LevelUpGFX;
    private Transform Player;
    public static bool levelledUp = false;
    int killcounter = 0;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            //DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(gameObject);
        }
        level = 1;
        currentExp = 0;
        expToNextLevel = 100;
        ExpBar.fillAmount = 0f;
        UpdateLevelText();
        Player = GameObject.Find("Player").gameObject.transform;
       
    }
   
    public void AddExp(int amount)
    {
        currentExp += amount;
        int killCount = killcounter;
        killcounter++;
        
        ExpBar.fillAmount = (float)currentExp / expToNextLevel;
        statExpToNextLvl.text = (currentExp + "/" + expToNextLevel);
        statKillCount.text = killCount.ToString();
        if (currentExp >= expToNextLevel)
        {
            
            level++;
            levelledUp = true;
            GameObject LevelUpVFXClone = Instantiate(LevelUpGFX, Player.position, Quaternion.identity);
            LevelUpVFXClone.transform.SetParent(Player);
            UpdateLevelText();
            currentExp -= expToNextLevel;
            ExpBar.fillAmount = 0f;
        }
    }
    public void LevelUp()
    {
        if (levelledUp == true)
        {
            skillPointing = true;
            expToNextLevel *= 1.3f;
            levelledUp = false;
        }
    }
    public void UpdateLevelText()
    {
        LevelText.text = level.ToString();
        statLevelText.text = level.ToString();
    }
    private void OnEnable()
    {
        EnemyHealth.onDeath += AddExp;
    }
    private void OnDisable()
    {
        EnemyHealth.onDeath -= AddExp;
    }
}
