using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermov : MonoBehaviour
{
    private Rigidbody2D rb2d;
    
    private float moveSpeed ;
    private float jumpForce;
    private bool isJumping;
    private float moveHorizontal;
    private float moveVertical;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = gameObject.GetComponent<Rigidbody2D>();
        moveSpeed = 0.75f;
        jumpForce = 6f;
       
        
    }

    // Update is called once per frame
    void Update()
    {
        moveHorizontal = Input.GetAxisRaw("Horizontal");
        moveVertical = Input.GetAxisRaw("Vertical");
    }
    void FixedUpdate(){
        if(moveHorizontal > 0.1f || moveHorizontal < -0.1f){
            rb2d.AddForce(new Vector2(moveHorizontal * moveSpeed, 0f), ForceMode2D.Impulse);
        }

        if(moveVertical > 0.1f ){
            rb2d.AddForce(new Vector2(0f, moveVertical * jumpForce), ForceMode2D.Impulse);
        }

    }
}
