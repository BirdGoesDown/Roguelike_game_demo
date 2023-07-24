using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public GameObject player;
    public float speed;
    public Vector2 direction;
    public Animator anim;
    bool shouldRotate;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        MoveToPlayer();
    }

    void MoveToPlayer()
    {
        if (player != null)
        {
            direction = (player.transform.position - transform.position).normalized;
            transform.position = Vector3.Lerp(transform.position, player.transform.position, speed * Time.deltaTime);
            anim.SetFloat("Vertical", direction.x);

        }
        
    }
}
