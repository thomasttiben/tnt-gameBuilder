using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidbodyMovement2D : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rigidbody2D;
    [SerializeField] private float horizontalspeed;
    [SerializeField] private float jumpforce;
    [SerializeField] private float jumpCount;
    [SerializeField] private SpriteRenderer spriteRenderer;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(rigidbody2D.velocity.x < -0.5)
        {
            spriteRenderer.flipX = true;
            
            
        }
        else if (rigidbody2D.velocity.x > 0.5)
        {
            spriteRenderer.flipX=false;
            

        }

        

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        jumpCount = 0;
    }

    public void jump()
    {
        if(jumpCount <=0)
        {

            jumpCount++;

           rigidbody2D.AddForce(new Vector2(0, jumpforce));
        }

   
    }
    public void Move(float direction)
    {
        rigidbody2D.velocity = new Vector3(horizontalspeed, rigidbody2D.velocity. y, 0);

    }

}
