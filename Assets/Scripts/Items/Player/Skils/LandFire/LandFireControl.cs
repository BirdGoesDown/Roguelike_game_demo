using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LandFireControl : MonoBehaviour
{
    //public LayerMask enemyLayer;
    //Rigidbody2D rb;
    //Vector2 direction;
    public GameObject gameManager;
    private Transform target;

    public float speed = 70f;

    public float damage;
    private void Awake()
    {
        damage = 100;
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
    private void OnTriggerEnter2D(Collider2D collision)
    {
        EnemyHealth enemyHealth = collision.GetComponent<EnemyHealth>();

        if (!collision.tag.Contains("Player"))
        {
            if (collision.tag.Contains("Enemy") && enemyHealth != null)
            {
                enemyHealth.TakeDamage(damage);
                if (enemyHealth.currentHealth <= 0)
                {
                    gameManager.GetComponent<GameManager>().RandomEnemySpawner();
                }
                
            }
        }
    }

    void Update()
    {
        if (target == null)
        {
            return;
        }
    }
}
