using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    public GameObject player;
    public float speed;

    private float distance;

    // float dirX, dirY, moveSpeed;

    // public SpriteRenderer spriteRenderer;
    // public GameObject Ordinary;
    // Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        // anim = Ordinary.GetComponent<Animator>();
        // moveSpeed = 5f;
    }

    // Create an enemy that follows the player
    void Update()
    {
        distance = Vector2.Distance(transform.position, player.transform.position);
        Vector2 direction = player.transform.position - transform.position;
        transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);

        


    }

    // If the enemy runs into a Collider, it will turn around and try a new direction
    // void OnCollisionEnter2D(Collision2D col)
    // {
    //     if (col.gameObject.tag == "Islands")
    //     {
    //         // Turn around
    //         speed *= -1;
    //     }
    // }



    // Update is called once per frame
    // void Update()
    // {
    //     // Create an enemy that follows the player

    //     // distance = Vector2.Distance(transform.position, player.transform.position);
    //     // Vector2 direction = player.transform.position - transform.position;
    //     // transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);
        



    //     // if(Input.GetKey("a") || Input.GetKey("s") || Input.GetKey("d") || Input.GetKey("w"))
    //     // {
    //     // }
    //     // else{
    //     //     dirX = Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime;
    //     //     dirY = Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime;
    //     //     transform.position = new Vector2(transform.position.x + dirX, transform.position.y + dirY);
    //     // }


    //     // if (dirX != 0)
    //     // {

    //     //     if (dirX < 0)
    //     //     {
    //     //         spriteRenderer.flipX = true;
    //     //     }
    //     //     else
    //     //     {
    //     //         spriteRenderer.flipX = false;
    //     //     }
    //     //     anim.SetInteger("Animate", 2); // walk
    //     // }
    //     // else
    //     // {
    //     //     anim.SetInteger("Animate", 0); // idle
    //     // }

    // }
}
