using UnityEngine;

public class PlayerAreaSkill : MonoBehaviour
{
    private Transform target;
    private LevelManager levelmanager;
    private Player player;
    [Header("General")]


    public float range = 15f;

    [Header("Use Bullets Default")]
    public GameObject areaPrefab;
    public static GameObject newAreaPrefab;
    AreaSkillController areaSkillController;

    [Header("Unity Setup Fields")]
    public string enemyTag = "Enemy";

    

    private void Awake()
    {
        player = gameObject.GetComponent<Player>();
        areaSkillController = areaPrefab.GetComponent<AreaSkillController>();
    }


    /*void UpdateTarget()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        
    }*/
    void Update()
    {
        


        switch (AreaButton.areaSkill1, AreaButton.areaRate)
        {
            case (1, 1f) n when AreaButton.isRuning == true:
            case (1, 1f) when areaSkillController.damageCountdown1 == 1:
                //Debug.Log("Area Level : 1");
                float randomNumber1 = Random.Range(1, 11);
                if (randomNumber1 <= player.critRate)
                {
                    areaSkillController.HitDamage((50 + (player.physicalDmg * 15 / 100) + (player.magicalDmg * 20 / 100)) * (player.critRate * player.critDmg));
                }
                else
                {
                    areaSkillController.HitDamage(50 + (player.physicalDmg * 15 / 100) + (player.magicalDmg * 20 / 100));
                }
                Area(1, AreaButton.areaRate);
                AreaButton.isRuning = false;
                areaSkillController.damageCountdown1 = 0;
                
                break;
            case (2, 1f) n when AreaButton.isRuning == true:
                //Debug.Log("Area Level : 2");
                float randomNumber2 = Random.Range(1, 11);
                if (randomNumber2 <= player.critRate)
                {
                    areaSkillController.HitDamage((50 + (player.physicalDmg * 22 / 100) + (player.magicalDmg * 33 / 100)) * (player.critRate * player.critDmg));
                }
                else
                {
                    areaSkillController.HitDamage(50 + (player.physicalDmg * 22 / 100) + (player.magicalDmg * 33 / 100));
                }
                areaPrefab.transform.localScale = areaPrefab.transform.localScale + new Vector3(1f,1f,0f);
                Area(2, AreaButton.areaRate);
                AreaButton.isRuning = false;
                areaSkillController.damageCountdown1 = 0;
                areaSkillController.damageCountdown2 = 0;
                break;
            case (3, 1f) n when AreaButton.isRuning == true:
                //Debug.Log("Area Level : 3");
                float randomNumber3 = Random.Range(1, 11);
                if (randomNumber3 <= player.critRate)
                {
                    areaSkillController.HitDamage((50 + (player.physicalDmg * 31 / 100) + (player.magicalDmg * 46 / 100)) * (player.critRate * player.critDmg));
                }
                else
                {
                    areaSkillController.HitDamage(50 + (player.physicalDmg * 31 / 100) + (player.magicalDmg * 46 / 100));
                }
                areaPrefab.transform.localScale = areaPrefab.transform.localScale + new Vector3(1f, 1f, 0f);
                Area(3, AreaButton.areaRate);
                AreaButton.isRuning = false;
                areaSkillController.damageCountdown1 = 0;
                areaSkillController.damageCountdown2 = 0;
                areaSkillController.damageCountdown3 = 0;
                break;
            case (4, 1f) n when AreaButton.isRuning == true:
                //Debug.Log("Area Level : 4");
                float randomNumber4 = Random.Range(1, 11);
                if (randomNumber4 <= player.critRate)
                {
                    areaSkillController.HitDamage((50 + (player.physicalDmg * 39 / 100) + (player.magicalDmg * 55 / 100)) * (player.critRate * player.critDmg));
                }
                else
                {
                    areaSkillController.HitDamage(50 + (player.physicalDmg * 39 / 100) + (player.magicalDmg * 55 / 100));
                }
                areaPrefab.transform.localScale = areaPrefab.transform.localScale + new Vector3(1f, 1f, 0f);
                Area(4, AreaButton.areaRate);
                AreaButton.isRuning = false;
                areaSkillController.damageCountdown1 = 0;
                areaSkillController.damageCountdown2 = 0;
                areaSkillController.damageCountdown3 = 0;
                areaSkillController.damageCountdown4 = 0;
                break;
            case (5, 1f) n when AreaButton.isRuning == true:
                //Debug.Log("Area Level : 5");
                float randomNumber5 = Random.Range(1, 11);
                if (randomNumber5 <= player.critRate)
                {
                    areaSkillController.HitDamage((50 + (player.physicalDmg * 47 / 100) + (player.magicalDmg * 64 / 100)) * (player.critRate * player.critDmg));
                }
                else
                {
                    areaSkillController.HitDamage(50 + (player.physicalDmg * 47 / 100) + (player.magicalDmg * 64 / 100));
                }
                areaPrefab.transform.localScale = areaPrefab.transform.localScale + new Vector3(1f, 1f, 0f);
                Area(5, AreaButton.areaRate);
                AreaButton.isRuning = false;
                areaSkillController.damageCountdown1 = 0;
                areaSkillController.damageCountdown2 = 0;
                areaSkillController.damageCountdown3 = 0;
                areaSkillController.damageCountdown4 = 0;
                areaSkillController.damageCountdown5 = 0;
                break;
            case (6, 1f) n when AreaButton.isRuning == true:
                //Debug.Log("Area Level : 6");
                float randomNumber6 = Random.Range(1, 11);
                if (randomNumber6 <= player.critRate)
                {
                    areaSkillController.HitDamage((50 + (player.physicalDmg * 54 / 100) + (player.magicalDmg * 78 / 100)) * (player.critRate * player.critDmg));
                }
                else
                {
                    areaSkillController.HitDamage(50 + (player.physicalDmg * 54 / 100) + (player.magicalDmg * 78 / 100));
                }
                areaPrefab.transform.localScale = areaPrefab.transform.localScale + new Vector3(1f, 1f, 0f);
                Area(6, AreaButton.areaRate);
                AreaButton.isRuning = false;
                areaSkillController.damageCountdown1 = 0;
                areaSkillController.damageCountdown2 = 0;
                areaSkillController.damageCountdown3 = 0;
                areaSkillController.damageCountdown4 = 0;
                areaSkillController.damageCountdown5 = 0;
                areaSkillController.damageCountdown6 = 0;
                break;
            default:
                //Debug.Log("Area Level : Full");
                break;
        }



    }

    public void Area(int skillLevel, float fireRate)
    {
        skillLevel = AreaButton.areaSkill1;
        fireRate = AreaButton.areaRate;
            GameObject bulletGO = (GameObject)Instantiate(areaPrefab, this.transform.position, Quaternion.identity);
            AreaSkillController bullet = bulletGO.GetComponent<AreaSkillController>();
            bulletGO.transform.parent = gameObject.transform;
           newAreaPrefab = bulletGO;
        
    }
    /*private void OnDrawGizmosSelected()
    {
        UnityEditor.Handles.color = Color.yellow;
        UnityEditor.Handles.DrawWireDisc(transform.position, Vector3.back, range);
    }*/
}
