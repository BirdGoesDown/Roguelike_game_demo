using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BazookaController : MonoBehaviour
{
    //public LayerMask enemyLayer;
    //Rigidbody2D rb;
    //Vector2 direction;
    public GameObject gameManager;
    private Transform target;



    public float speed = 70f;

    public float damage;

    public float explosionRadius = 0f;
    //public GameObject impactEffect;
    private void Awake()
    {
        damage = 50;
    }

    public void Seek(Transform _target)
    {
        target = _target;
        Update();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        EnemyHealth enemyHealth = collision.GetComponent<EnemyHealth>();
        if (enemyHealth != null)
        {
            enemyHealth.TakeDamage(damage);
            if (enemyHealth.currentHealth <= 0)
            {
                gameManager.GetComponent<GameManager>().RandomEnemySpawner();
            }
        }

    }

    void Update()
    {
        if (target == null)
        {
            return;
        }
        Vector3 dir =  target.position - transform.position;
        // Vector3 dir = new Vector3(UnityEngine.Random.Range(-200, 200), UnityEngine.Random.Range(-200, 200));
        RaycastHit[] hits;

        hits = Physics.RaycastAll(transform.position, target.position, 100.0f);
        Ray ray = new Ray(transform.position, target.position);
        foreach (RaycastHit hit in hits)
        {
            if (hit.transform.CompareTag("Enemy"))
            {
                //Add damage
            }
        }
            float distanceThisFrame = speed + Time.deltaTime;

        /*if (dir.magnitude <= distanceThisFrame)
        {
            // HitTarget();
            return;
        }*/

        transform.Translate(ray.direction * 10 * speed * Time.deltaTime, Space.World);
        print("ray "+ ray.direction);

    }
    public void HitDamage(float amount)
    {
        damage = amount;
        /*if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }*/

    }


    /*void HitTarget()
    {
        //GameObject effectIns = Instantiate(impactEffect, transform.position, transform.rotation);
        //Destroy(effectIns, 5f);

        if (explosionRadius > 0f)
        {
            Explode();
        }
        else
        {
            Damage(target);
        }

        Destroy(gameObject);
    }

    void Explode()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, explosionRadius);
        foreach (Collider collider in colliders)
        {
            if (collider.tag == "Enemy")
            {
                Damage(collider.transform);
            }
        }
    }

    void Damage(Transform enemy)
    {
        EnemyHealth e = enemy.GetComponent<EnemyHealth>();

        if (e != null)
        {
            e.TakeDamage(damage);
        }
    }*/
    // Start is called before the first frame update
    /*void Start()
        {
            rb = GetComponent<Rigidbody2D>();
            gameManager = GameObject.FindGameObjectWithTag("GameController");

            direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;

            rb.AddForce(direction.normalized * 10, ForceMode2D.Impulse);

            Destroy(gameObject, 3);
        }

        // Update is called once per frame
        void Update()
        {

        }
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (!collision.tag.Contains("Player"))
            {
                if (collision.tag.Contains("Enemy"))
                {
                    gameManager.GetComponent<GameManager>().RandomEnemySpawner();
                    /*gameManager.GetComponent<GameManager>().score += 1;
                    gameManager.GetComponent<GameManager>().scoreText.text = "Point = " + gameManager.GetComponent<GameManager>().score;

                    Destroy(collision.gameObject);

                    Destroy(gameObject);
                }

            }

        }*/
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, explosionRadius);
    }
}
