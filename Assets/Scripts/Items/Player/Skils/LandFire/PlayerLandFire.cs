using UnityEngine;

public class PlayerLandFire : MonoBehaviour
{
    private Transform target;
    private LevelManager levelmanager;
    private LandFireControl landFireControl;
    Player player;
    [Header("General")]

    public float range = 15f;

    [Header("Use Bullets Default")]
    public GameObject landFirePrefab;
    private float LandFireCountdown1 = 0.1f;
    private float LandFireCountdown2 = 0.2f;
    private float LandFireCountdown3 = 0.3f;
    private float LandFireCountdown4 = 0.4f;
    private float LandFireCountdown5 = 0.6f;
    private float LandFireCountdown6 = 0.7f;

    [Header("Unity Setup Fields")]
    public string enemyTag = "Enemy";

    private void Awake()
    {
        player = gameObject.GetComponent<Player>();
        landFireControl = landFirePrefab.GetComponent<LandFireControl>();
    }
    void UpdateTarget()
    {
        if (target == null)
        {
            return;
        }
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");

    }
    void Update()
    {
        /*UpdateTarget();
        if (target == null)
        {
            return;
        }*/
        LandFireCountdown1 += Time.deltaTime;
        LandFireCountdown2 += Time.deltaTime;
        LandFireCountdown3 += Time.deltaTime;
        LandFireCountdown4 += Time.deltaTime;
        LandFireCountdown5 += Time.deltaTime;
        LandFireCountdown6 += Time.deltaTime;

        switch (LandFireButton.landFireSkill, LandFireButton.landFireArea)
        {
            case (1, 6f) n when LandFireButton.landFireArea < LandFireCountdown1:
                //Debug.Log("Area Level : 1");
                float randomNumber1 = Random.Range(1, 11);
                if (randomNumber1 <= player.critRate)
                {
                    landFireControl.HitDamage((50 + (player.physicalDmg * 15 / 100) + (player.magicalDmg * 12 / 100)) * (player.critRate * player.critDmg));
                }
                else
                {
                    landFireControl.HitDamage(50 + (player.physicalDmg * 15 / 100) + (player.magicalDmg * 12 / 100));
                }
                LandFire(1, LandFireButton.landFireArea);
                LandFireCountdown1 = 0f;
                break;
            case (2, 6f) n when LandFireButton.landFireArea < LandFireCountdown2:
                //Debug.Log("Area Level : 2");
                float randomNumber2 = Random.Range(1, 11);
                if (randomNumber2 <= player.critRate)
                {
                    landFireControl.HitDamage((50 + (player.physicalDmg * 22 / 100) + (player.magicalDmg * 20 / 100)) * (player.critRate * player.critDmg));
                }
                else
                {
                    landFireControl.HitDamage(50 + (player.physicalDmg * 22 / 100) + (player.magicalDmg * 20 / 100));
                }
                LandFire(2, LandFireButton.landFireArea);
                LandFireCountdown2 = 1f;
                break;
            case (3, 6f) n when LandFireButton.landFireArea < LandFireCountdown3:
                //Debug.Log("Area Level : 3");
                float randomNumber3 = Random.Range(1, 11);
                if (randomNumber3 <= player.critRate)
                {
                    landFireControl.HitDamage((50 + (player.physicalDmg * 35 / 100) + (player.magicalDmg * 28 / 100)) * (player.critRate * player.critDmg));
                }
                else
                {
                    landFireControl.HitDamage(50 + (player.physicalDmg * 35 / 100) + (player.magicalDmg * 28 / 100));
                }
                LandFire(3, LandFireButton.landFireArea);
                LandFireCountdown3 = 2f;
                break;
            case (4, 6f) n when LandFireButton.landFireArea < LandFireCountdown4:
                //Debug.Log("Area Level : 4");
                float randomNumber4 = Random.Range(1, 11);
                if (randomNumber4 <= player.critRate)
                {
                    landFireControl.HitDamage((50 + (player.physicalDmg * 42 / 100) + (player.magicalDmg * 38 / 100)) * (player.critRate * player.critDmg));
                }
                else
                {
                    landFireControl.HitDamage(50 + (player.physicalDmg * 42 / 100) + (player.magicalDmg * 38 / 100));
                }
                LandFire(4, LandFireButton.landFireArea);
                LandFireCountdown4 = 3f;
                break;
            case (5, 6f) n when LandFireButton.landFireArea < LandFireCountdown5:
                //Debug.Log("Area Level : 5");
                float randomNumber5 = Random.Range(1, 11);
                if (randomNumber5 <= player.critRate)
                {
                    landFireControl.HitDamage((50 + (player.physicalDmg * 54 / 100) + (player.magicalDmg * 46 / 100)) * (player.critRate * player.critDmg));
                }
                else
                {
                    landFireControl.HitDamage(50 + (player.physicalDmg * 54 / 100) + (player.magicalDmg * 46 / 100));
                }
                LandFire(5, LandFireButton.landFireArea);
                LandFireCountdown5 = 4f;
                break;
            case (6, 6f) n when LandFireButton.landFireArea < LandFireCountdown6:
                //Debug.Log("Area Level : 6");
                float randomNumber6 = Random.Range(1, 11);
                if (randomNumber6 <= player.critRate)
                {
                    landFireControl.HitDamage((50 + (player.physicalDmg * 65 / 100) + (player.magicalDmg * 54 / 100)) * (player.critRate * player.critDmg));
                }
                else
                {
                    landFireControl.HitDamage(50 + (player.physicalDmg * 65 / 100) + (player.magicalDmg * 54 / 100));
                }
                LandFire(6, LandFireButton.landFireArea);
                LandFireCountdown6 = 5f;
                break;
            default:
                //Debug.Log("Area Level : Full");
                break;
        }

    }

    public void LandFire(int skillLevel, float fireArea)
    {
        skillLevel = LandFireButton.landFireSkill;
        fireArea = LandFireButton.landFireArea;

        GameObject bulletGO = (GameObject)Instantiate(landFirePrefab, Random.insideUnitCircle * 8, Quaternion.identity);
        AreaSkillController bullet = bulletGO.GetComponent<AreaSkillController>();


        if (bullet != null)
            bullet.Seek(target);
    }
    //private void OnDrawGizmosSelected()
    //{
    //    UnityEditor.Handles.color = Color.yellow;
    //    UnityEditor.Handles.DrawWireDisc(transform.position, Vector3.back, range);
    //}
}

