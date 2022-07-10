using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public Spawner spawner;
    Restart restart;
    public ObjectOffset of;
    public Pause pause;
    Rigidbody2D rb;
    public Vector3 jump;
    public float speed;
    public float velocityy;
    public float force;
    bool isFacingRight = true;
    public bool isGrounded;
    public float curtime = 0;
    public bool isDead;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        isDead = false;
        rb.gravityScale = 0;
        of.objspeed = 0;
        spawner.maxtime = 0;
    }

    

    private void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("obstacle"))
        {
            //Destroy(gameObject);
            Time.timeScale = 0;
            isDead = true;
            pause.PauseWindow();
        }
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rb.gravityScale = 2;
            of.objspeed = 3;
            spawner.maxtime = 1.2f;
        }
    }

    private void FixedUpdate()
    {

        /*float move = Input.GetAxis("Horizontal");

        if(move < 0 )
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(move * speed, 0);
            //gameObject.transform.localScale = new Vector2(-1, 1);
            
        }

        if (move > 0)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(move * speed, 0);
            //gameObject.transform.localScale = new Vector2(1, 1);
           
        }

        if (move < 0 && isFacingRight)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(move * speed, 0);
            //gameObject.transform.localScale = new Vector2(-1, 1);
            Flip();
        }

        if (move > 0 && !isFacingRight)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(move * speed, 0);
            //gameObject.transform.localScale = new Vector2(1, 1);
            Flip();
        }*/


        //curheight = gameObject.transform.position.y;

        //curtime += Time.deltaTime;

        if (Input.GetKey(KeyCode.Space)) {
            //rb.AddForce(Vector3.up * force);

            rb.velocity = Vector2.up * velocityy;
            //curtime = 0;
        }


    }
    void Flip()
    {
        Vector3 curscal = gameObject.transform.localScale;
        curscal.x *= -1;
        gameObject.transform.localScale = curscal;
        isFacingRight = !isFacingRight;

    }

    void Fall()
    {
        //if (gameObject.transform.position.y )
        rb.gravityScale = 4;
    }
}
