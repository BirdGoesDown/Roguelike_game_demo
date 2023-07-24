using System.Collections;
using UnityEngine;

public class AreaSkillController : MonoBehaviour
{
    //public LayerMask enemyLayer;
    //Rigidbody2D rb;
    //Vector2 direction;
    public GameObject gameManager;
    private Transform target;
    GameObject player;
    public float damageCountdown1 = 0.1f;
    public float damageCountdown2 = 0.2f;
    public float damageCountdown3 = 0.3f;
    public float damageCountdown4 = 0.4f;
    public float damageCountdown5 = 0.6f;
    public float damageCountdown6 = 0.7f;

    public float damage;
    private void Awake()
    {
        damage = 100;
    }

    private void Update()
    {
        damageCountdown1 += Time.deltaTime;
        damageCountdown2 += Time.deltaTime;
        damageCountdown3 += Time.deltaTime;
        damageCountdown4 += Time.deltaTime;
        damageCountdown5 += Time.deltaTime;
        damageCountdown6 += Time.deltaTime;
        if (AreaButton.RunningWithRifles == true && AreaButton.areaSkill1 >= 1 && (damageCountdown1 == 1 || damageCountdown2 == 1
            || damageCountdown3 == 1 || damageCountdown4 == 1 || damageCountdown5 == 1 || damageCountdown6 == 1))
        {
            //Destroy(gameObject);
            AreaButton.RunningWithRifles = false;
            damageCountdown1 = 0;
        }

        //print("1 "+ damageCountdown1);
        //print("2 "  + damageCountdown2);
        //print("3 " + damageCountdown3);
        //print("4 " + damageCountdown4);
        //print("5 "  + damageCountdown5);
        //print("6 " + damageCountdown6);
    }

    public void Seek(Transform _target)
    {
        target = _target;
    }
    public void HitDamage(float amount)
    {
        damage = amount;
        /*if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }*/

    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        EnemyHealth enemyHealth = collision.GetComponent<EnemyHealth>();

        if (!collision.tag.Contains("Player"))
        {
            if (collision.tag.Contains("Enemy") && enemyHealth != null)
            {
                if (AreaButton.RunningWithRifles == true && AreaButton.areaSkill1 > 0 && (damageCountdown1 >= 1 || damageCountdown2 == 1
            || damageCountdown3 == 1 || damageCountdown4 == 1 || damageCountdown5 == 1 || damageCountdown6 == 1))
                {
                    //Destroy(gameObject);
                    AreaButton.RunningWithRifles = false;
                    damageCountdown1 = 0;
                    enemyHealth.TakeDamage(damage * Time.deltaTime);
                    if (enemyHealth.currentHealth <= 0)
                    {
                        gameManager.GetComponent<GameManager>().RandomEnemySpawner();
                    }
                }

            }
        }
    }
}
    /*public bool isFire;
    public bool isIce;

    public bool isTicking = true;

    public float ammountHealthDmg = 10f;

    public float tickHealthDmg = 1f;
    public float ticks = 0;
    EnemyHealth health1;


    void Start()
    {
        StartCoroutine("CountSeconds");
    }
    IEnumerator CountSeconds()
    {
        int seconds = 0;

        while (isTicking == true)
        {
            for (float timer = 0; timer < 1; timer += Time.deltaTime)
                yield return 0;

            decrementStats(tickHealthDmg);
            seconds++;
            Debug.Log(seconds + " seconds have passed since the Coroutine started.");

            if (seconds == 10)
            {
                StopCoroutine("CountSeconds");
            }
        }
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (isFire)//Damage to Health and Physical TODO add tick damage
            {
                decrementStats(ammountHealthDmg);
            }
            if (isIce)//Damage to Health and Mental TODO add tick damage
            {
                decrementStats(ammountHealthDmg);
            }
        }
    }
    // -or+ stat values (!!im sure there is a better way to do this!!)
    void decrementStats(float health)
    {
        health1.currentHealth -= health;
    }
    void applyDoT()
    {
        // ticks increments 60 times per second, as an example
        ticks++;
        // Condition is true once every second
        if (ticks % 60 == 0)
        {
            // Apply damage
        }
        if (ticks % (0.5f * Time.deltaTime) == 0)
        {
            // Apply damage
        }
    }
}*/

