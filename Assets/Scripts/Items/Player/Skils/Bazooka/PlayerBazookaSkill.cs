using UnityEngine;

public class PlayerBazookaSkill : MonoBehaviour
{
    private Transform target;
    private LevelManager levelmanager;
    private BazookaController bazookaController;
    private Player player;
    [Header("General")]

    public float range = 15f;

    [Header("Use Bullets Default")]
    public GameObject bazookaPrefab;
    private float fireCountdown = 0f;
    private float fireCountdown1 = 0.1f;
    private float fireCountdown2 = 0.2f;
    private float fireCountdown3 = 0.3f;
    private float fireCountdown4 = 0.4f;
    private float fireCountdown5 = 0.6f;

    [Header("Unity Setup Fields")]
    public string enemyTag = "Enemy";

    private void Awake()
    {
        player = gameObject.GetComponent<Player>();
        bazookaController = bazookaPrefab.GetComponent<BazookaController>();
    }
    void UpdateTarget()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        float shortestDistance = Mathf.Infinity;
        GameObject nearestEnemy = null;
        foreach (GameObject enemy in enemies)
        {
            float distanceToEnemy = Vector3.Distance(transform.position, enemy.transform.position);
            if (distanceToEnemy < shortestDistance)
            {
                shortestDistance = distanceToEnemy;
                nearestEnemy = enemy;
            }
        }
        if (nearestEnemy != null && shortestDistance <= range)
        {
            target = nearestEnemy.transform;
            //targetEnemy = nearestEnemy.GetComponent<EnemyHealth>();
        }
        else
        {
            target = null;
        }
    }
    void Update()
    {
        UpdateTarget();
        if (target == null)
        {
            return;
        }
        LockOnTarget();
       
        void LockOnTarget()
        {
            Vector3 dir = target.position - transform.position;
            Quaternion lookRotation = Quaternion.LookRotation(dir);
        }
        
        fireCountdown += Time.deltaTime;
        fireCountdown1 += Time.deltaTime;
        fireCountdown2 += Time.deltaTime;
        fireCountdown3 += Time.deltaTime;
        fireCountdown4 += Time.deltaTime;
        fireCountdown5 += Time.deltaTime;

        switch (BazookaButton.bazookaSkill, BazookaButton.bazookaRate)
        {
            case (1, 1f) n when BazookaButton.bazookaRate < fireCountdown:
                Debug.Log("Skill Level : 1");
                float randomNumber1 = Random.Range(1, 11);
                if (randomNumber1 <= player.critRate)
                {
                    bazookaController.HitDamage((50 + (player.physicalDmg * 15 / 100) + (player.magicalDmg * 25 / 100)) * (player.critRate * player.critDmg));
                }
                else
                {
                    bazookaController.HitDamage(50 + (player.physicalDmg * 15 / 100) + (player.magicalDmg * 25 / 100));
                }
                Bazooka(1, BazookaButton.bazookaRate);
                fireCountdown = 0f;
                break;
            case (2, 1f) n when BazookaButton.bazookaRate < fireCountdown:
            case (2, 1f) when BazookaButton.bazookaRate < fireCountdown1:
                Debug.Log("Skill Level : 2");
                float randomNumber2 = Random.Range(1, 11);
                if (randomNumber2 <= player.critRate)
                {
                    bazookaController.HitDamage((50 + (player.physicalDmg * 27 / 100) + (player.magicalDmg * 42 / 100)) * (player.critRate * player.critDmg));
                }
                else
                {
                    bazookaController.HitDamage(50 + (player.physicalDmg * 27 / 100) + (player.magicalDmg * 42 / 100));
                }
                Bazooka(1, BazookaButton.bazookaRate);
                fireCountdown = 0f;
                fireCountdown1 = 0.1f;
                break;
            case (3, 1f) n when BazookaButton.bazookaRate < fireCountdown:
            case (3, 1f) when BazookaButton.bazookaRate < fireCountdown1:
            case (3, 1f) when BazookaButton.bazookaRate < fireCountdown2:
                Debug.Log("Skill Level : 3");
                float randomNumber3 = Random.Range(1, 11);
                if (randomNumber3 <= player.critRate)
                {
                    bazookaController.HitDamage((50 + (player.physicalDmg * 38 / 100) + (player.magicalDmg * 58 / 100)) * (player.critRate * player.critDmg));
                }
                else
                {
                    bazookaController.HitDamage(50 + (player.physicalDmg * 38 / 100) + (player.magicalDmg * 58 / 100));
                }
                Bazooka(2, BazookaButton.bazookaRate);
                fireCountdown = 0f;
                fireCountdown1 = 0.1f;
                fireCountdown2 = 0.2f;
                break;
            case (4, 1f) n when BazookaButton.bazookaRate < fireCountdown:
            case (4, 1f) when BazookaButton.bazookaRate < fireCountdown1:
            case (4, 1f) when BazookaButton.bazookaRate < fireCountdown2:
            case (4, 1f) when BazookaButton.bazookaRate < fireCountdown3:
                Debug.Log("Skill Level : 4");
                float randomNumber4 = Random.Range(1, 11);
                if (randomNumber4 <= player.critRate)
                {
                    bazookaController.HitDamage((50 + (player.physicalDmg * 46 / 100) + (player.magicalDmg * 72 / 100)) * (player.critRate * player.critDmg));
                }
                else
                {
                    bazookaController.HitDamage(50 + (player.physicalDmg * 46 / 100) + (player.magicalDmg * 72 / 100));
                }
                Bazooka(3, BazookaButton.bazookaRate);
                fireCountdown = 0f;
                fireCountdown1 = 0.1f;
                fireCountdown2 = 0.2f;
                fireCountdown3 = 0.3f;
                break;
            case (5, 1f) n when BazookaButton.bazookaRate < fireCountdown:
            case (5, 1f) when BazookaButton.bazookaRate < fireCountdown1:
            case (5, 1f) when BazookaButton.bazookaRate < fireCountdown2:
            case (5, 1f) when BazookaButton.bazookaRate < fireCountdown3:
            case (5, 1f) when BazookaButton.bazookaRate < fireCountdown4:
                Debug.Log("Skill Level : 5");
                float randomNumber5 = Random.Range(1, 11);
                if (randomNumber5 <= player.critRate)
                {
                    bazookaController.HitDamage((50 + (player.physicalDmg * 59 / 100) + (player.magicalDmg * 86 / 100)) * (player.critRate * player.critDmg));
                }
                else
                {
                    bazookaController.HitDamage(50 + (player.physicalDmg * 59 / 100) + (player.magicalDmg * 86 / 100));
                }
                Bazooka(4, BazookaButton.bazookaRate);
                fireCountdown = 0f;
                fireCountdown1 = 0.1f;
                fireCountdown2 = 0.2f;
                fireCountdown3 = 0.3f;
                fireCountdown4 = 0.4f;
                break;
            case (6, 1f) n when BazookaButton.bazookaRate < fireCountdown:
            case (6, 1f) when BazookaButton.bazookaRate < fireCountdown1:
            case (6, 1f) when BazookaButton.bazookaRate < fireCountdown2:
            case (6, 1f) when BazookaButton.bazookaRate < fireCountdown3:
            case (6, 1f) when BazookaButton.bazookaRate < fireCountdown4:
            case (6, 1f) when BazookaButton.bazookaRate < fireCountdown5:
                Debug.Log("Skill Level : 6");
                float randomNumber6 = Random.Range(1, 11);
                if (randomNumber6 <= player.critRate)
                {
                    bazookaController.HitDamage((50 + (player.physicalDmg * 72 / 100) + (player.magicalDmg * 100 / 100)) * (player.critRate * player.critDmg));
                }
                else
                {
                    bazookaController.HitDamage(50 + (player.physicalDmg * 72 / 100) + (player.magicalDmg * 100 / 100));
                }
                Bazooka(5, BazookaButton.bazookaRate);
                fireCountdown = 0f;
                fireCountdown1 = 0.1f;
                fireCountdown2 = 0.2f;
                fireCountdown3 = 0.3f;
                fireCountdown4 = 0.4f;
                fireCountdown5 = 0.6f;
                break;
            default:
                //Debug.Log("Skill Level : Full");
                break;
        }
    }

    public void Bazooka(int skillLevel, float fireRate)
    {
        skillLevel = BazookaButton.bazookaSkill;
        fireRate = BazookaButton.bazookaRate;

        GameObject bulletGO = (GameObject)Instantiate(bazookaPrefab, transform.position, Quaternion.identity);
        BazookaController bullet = bulletGO.GetComponent<BazookaController>();


        if (bullet != null)
            bullet.Seek(target);
    }
    //private void OnDrawGizmosSelected()
    //{
    //    UnityEditor.Handles.color = Color.yellow;
    //    UnityEditor.Handles.DrawWireDisc(transform.position, Vector3.back, range);
    //}




}

