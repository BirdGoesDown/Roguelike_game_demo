using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //public Interactable focus;
    

    public float moveSpeed = 5f;

    public Rigidbody2D rb;
    public Animator animator;
    

    Vector2 movement;

    public static PlayerMovement instance;
    private void Start()
    {
        
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        
        movement.y = Input.GetAxisRaw("Vertical");
        //rb.AddForce(new Vector2(movement.x, movement.y) * 2);

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }
    /*private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Debug.Log("enter");
            gameObject.GetComponent<CircleCollider2D>().isTrigger = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag != "Enemy")
        {
            gameObject.GetComponent<CircleCollider2D>().isTrigger = false;
        }
            
    }*/
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
