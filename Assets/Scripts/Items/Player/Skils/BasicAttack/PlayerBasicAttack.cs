using UnityEngine;
using UnityEngine.UI;

public class PlayerBasicAttack : MonoBehaviour
{
    private Transform target;
    private LevelManager levelmanager;

    Player player;

    BasicAttackController bulletController;

    [Header("General")]

    public float range = 15f;

    [Header("Use Bullets Default")]
    public GameObject bulletPrefab;
    private float fireCountdown = 0f;
    private float fireCountdown1 = 0.1f;
    private float fireCountdown2 = 0.2f;
    private float fireCountdown3 = 0.3f;
    private float fireCountdown4 = 0.4f;
    private float fireCountdown5 = 0.6f;
    private float fireCountdown6 = 0.7f;

    [Header("Unity Setup Fields")]
    public string enemyTag = "Enemy";
    private void Awake()
    {
        
    }
    private void Start()
    {
        bulletController = bulletPrefab.GetComponent<BasicAttackController>();
        player = gameObject.GetComponent<Player>();
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
        fireCountdown6 += Time.deltaTime;

        

        switch (BasicSkillButton.basicSkill1, BasicSkillButton.basicFireRate)
        {

            case (0, 1f) n when BasicSkillButton.basicFireRate < fireCountdown:
                //Debug.Log("Skill Level :0");
                float randomNumber = Random.Range(1, 11);
                if (randomNumber <= player.critRate)
                {
                    bulletController.HitDamage((20 + (player.physicalDmg * 15 / 100) + (player.magicalDmg * 10 / 100))* (player.critRate * player.critDmg));
                }
                else
                {
                    bulletController.HitDamage(20 + (player.physicalDmg * 15 / 100) + (player.magicalDmg * 10 / 100));
                }
                
                Shoot(0, BasicSkillButton.basicFireRate);
                fireCountdown = 0f;
                break;
            case (1, 1f) n when BasicSkillButton.basicFireRate < fireCountdown:
            case (1, 1f) when BasicSkillButton.basicFireRate < fireCountdown1:
                //Debug.Log("Skill Level : 1");
                float randomNumber1 = Random.Range(1, 11);
                if (randomNumber1 <= player.critRate)
                {
                    bulletController.HitDamage((20 + (player.physicalDmg * 20 / 100) + (player.magicalDmg * 13 / 100)) * (player.critRate * player.critDmg));
                }
                else
                {
                    bulletController.HitDamage(20 + (player.physicalDmg * 20 / 100) + (player.magicalDmg * 13 / 100));
                }
                Shoot(1, BasicSkillButton.basicFireRate);
                fireCountdown = 0f;
                fireCountdown1 = 0.1f;
                break;
            case (2, 1f) n when BasicSkillButton.basicFireRate < fireCountdown:
            case (2, 1f) when BasicSkillButton.basicFireRate < fireCountdown1:
            case (2, 1f) when BasicSkillButton.basicFireRate < fireCountdown2:
                //Debug.Log("Skill Level : 2");
                float randomNumber2 = Random.Range(1, 11);
                if (randomNumber2 <= player.critRate)
                {
                    bulletController.HitDamage((20 + (player.physicalDmg * 25 / 100) + (player.magicalDmg * 15 / 100)) * (player.critRate * player.critDmg));
                }
                else
                {
                    bulletController.HitDamage(20 + (player.physicalDmg * 25 / 100) + (player.magicalDmg * 15 / 100));
                }
                Shoot(2, BasicSkillButton.basicFireRate);
                fireCountdown = 0f;
                fireCountdown1 = 0.1f;
                fireCountdown2 = 0.2f;
                break;
            case (3, 1f) n when BasicSkillButton.basicFireRate < fireCountdown:
            case (3, 1f) when BasicSkillButton.basicFireRate < fireCountdown1:
            case (3, 1f) when BasicSkillButton.basicFireRate < fireCountdown2:
            case (3, 1f) when BasicSkillButton.basicFireRate < fireCountdown3:
                //Debug.Log("Skill Level : 3");
                float randomNumber3 = Random.Range(1, 11);
                if (randomNumber3 <= player.critRate)
                {
                    bulletController.HitDamage((20 + (player.physicalDmg * 35 / 100) + (player.magicalDmg * 24 / 100)) * (player.critRate * player.critDmg));
                }
                else
                {
                    bulletController.HitDamage(20 + (player.physicalDmg * 35 / 100) + (player.magicalDmg * 24 / 100));
                }
                Shoot(3, BasicSkillButton.basicFireRate);
                fireCountdown = 0f;
                fireCountdown1 = 0.1f;
                fireCountdown2 = 0.2f;
                fireCountdown3 = 0.3f;
                break;
            case (4, 1f) n when BasicSkillButton.basicFireRate < fireCountdown:
            case (4, 1f) when BasicSkillButton.basicFireRate < fireCountdown1:
            case (4, 1f) when BasicSkillButton.basicFireRate < fireCountdown2:
            case (4, 1f) when BasicSkillButton.basicFireRate < fireCountdown3:
            case (4, 1f) when BasicSkillButton.basicFireRate < fireCountdown4:
                //Debug.Log("Skill Level : 4");
                float randomNumber4 = Random.Range(1, 11);
                if (randomNumber4 <= player.critRate)
                {
                    bulletController.HitDamage((20 + (player.physicalDmg * 48 / 100) + (player.magicalDmg * 32 / 100)) * (player.critRate * player.critDmg));
                }
                else
                {
                    bulletController.HitDamage(20 + (player.physicalDmg * 48 / 100) + (player.magicalDmg * 32 / 100));
                }
                Shoot(4, BasicSkillButton.basicFireRate);
                fireCountdown = 0f;
                fireCountdown1 = 0.1f;
                fireCountdown2 = 0.2f;
                fireCountdown3 = 0.3f;
                fireCountdown4 = 0.4f;
                break;
            case (5, 1f) n when BasicSkillButton.basicFireRate < fireCountdown:
            case (5, 1f) when BasicSkillButton.basicFireRate < fireCountdown1:
            case (5, 1f) when BasicSkillButton.basicFireRate < fireCountdown2:
            case (5, 1f) when BasicSkillButton.basicFireRate < fireCountdown3:
            case (5, 1f) when BasicSkillButton.basicFireRate < fireCountdown4:
            case (5, 1f) when BasicSkillButton.basicFireRate < fireCountdown5:
                //Debug.Log("Skill Level : 5");
                float randomNumber5 = Random.Range(1, 11);
                if (randomNumber5 <= player.critRate)
                {
                    bulletController.HitDamage((20 + (player.physicalDmg * 61 / 100) + (player.magicalDmg * 44 / 100)) * (player.critRate * player.critDmg));
                }
                else
                {
                    bulletController.HitDamage(20 + (player.physicalDmg * 61 / 100) + (player.magicalDmg * 44 / 100));
                }
                Shoot(5, BasicSkillButton.basicFireRate);
                fireCountdown = 0f;
                fireCountdown1 = 0.1f;
                fireCountdown2 = 0.2f;
                fireCountdown3 = 0.3f;
                fireCountdown4 = 0.4f;
                fireCountdown5 = 0.6f;
                break;
            case (6, 1f) n when BasicSkillButton.basicFireRate < fireCountdown:
            case (6, 1f) when BasicSkillButton.basicFireRate < fireCountdown1:
            case (6, 1f) when BasicSkillButton.basicFireRate < fireCountdown2:
            case (6, 1f) when BasicSkillButton.basicFireRate < fireCountdown3:
            case (6, 1f) when BasicSkillButton.basicFireRate < fireCountdown4:
            case (6, 1f) when BasicSkillButton.basicFireRate < fireCountdown5:
            case (6, 1f) when BasicSkillButton.basicFireRate < fireCountdown6:
                //Debug.Log("Skill Level : 6");
                float randomNumber6 = Random.Range(1, 11);
                if (randomNumber6 <= player.critRate)
                {
                    bulletController.HitDamage((20 + (player.physicalDmg * 75 / 100) + (player.magicalDmg * 55 / 100)) * (player.critRate * player.critDmg));
                }
                else
                {
                    bulletController.HitDamage(20 + (player.physicalDmg * 75 / 100) + (player.magicalDmg * 55 / 100));
                }
                bulletController.HitDamage(20 + (player.physicalDmg * 75 / 100) + (player.magicalDmg * 55 / 100));
                Shoot(6, BasicSkillButton.basicFireRate);
                fireCountdown = 0f;
                fireCountdown1 = 0.1f;
                fireCountdown2 = 0.2f;
                fireCountdown3 = 0.3f;
                fireCountdown4 = 0.4f;
                fireCountdown5 = 0.6f;
                fireCountdown6 = 0.7f;
                break;
            default:
                //Debug.Log("Skill Level : Full");
                break;
        }
    }

    public void Shoot(int skillLevel,float fireRate)
        {
        skillLevel = BasicSkillButton.basicSkill1;
        fireRate = BasicSkillButton.basicFireRate;
        Vector2 direction;

            GameObject bulletGO = (GameObject)Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            BasicAttackController bullet = bulletGO.GetComponent<BasicAttackController>();
        direction = (target.transform.position - transform.position).normalized;


        if (bullet != null)
                bullet.Seek(target);
        }
    //private void OnDrawGizmosSelected()
    //{
    //    UnityEditor.Handles.color = Color.yellow;
    //    UnityEditor.Handles.DrawWireDisc(transform.position, Vector3.back, range);
    //}




}
