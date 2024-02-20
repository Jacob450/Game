using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementspeed; 
    private Rigidbody2D player;
    private float inputH;
    private float inputV;
    private Animator animator;
    public GameObject sword;

    // Start is called before the first frame update
   
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
        animator = sword.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        move();
        Attack();
    }

    private void Attack()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0)) 
        {
            animator.SetTrigger("MouseClicked");
        }
    }

    private void move()
    {
        inputH = Input.GetAxisRaw("Horizontal");
        inputV = Input.GetAxisRaw("Vertical");

        player.velocity = new Vector2 (movementspeed*inputH,movementspeed * inputV);
    }
}
