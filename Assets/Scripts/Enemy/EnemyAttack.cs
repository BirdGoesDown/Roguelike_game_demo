using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public float damage = 10;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Player playerHealth = collision.GetComponent<Player>();
        if (playerHealth != null)
        {
            playerHealth.TakeDamage(damage);
        }

    }

}
