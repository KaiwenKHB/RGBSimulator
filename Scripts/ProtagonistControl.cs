using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProtagonistControl : MonoBehaviour
{
    public Vector3 spawnPoint;
    public bool onGround = false;
    public float moveSpeed = 5.0f;
    public float jumpHeight = 5.0f;
    private Rigidbody2D rb;
    public SpriteRenderer sr;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spawnPoint = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (sr.enabled)
        {
            Jump();
            Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
            transform.position += movement * Time.deltaTime * moveSpeed;
        }
    }

    public void die()
    {
        StartCoroutine(diee());
    }

    void Jump()
    {
        if(Input.GetButtonDown("Jump") && onGround)
        {
            rb.AddForce(new Vector2(0f, jumpHeight), ForceMode2D.Impulse);
            onGround = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Ground")
        {
            this.onGround = true;
        }
    }

    

    IEnumerator diee()
    {
        //float oldMoveSpeed = 0+moveSpeed;
        //float oldJump = 0+jumpHeight;
        //moveSpeed = 0;
        //jumpHeight = 0;
        sr.enabled = false;
        yield return new WaitForSeconds(1.5f);
       //print("Jump: " + oldJump);
        //print("Speed:" + oldMoveSpeed);
        //moveSpeed = oldMoveSpeed;
        //jumpHeight = oldJump;
        sr.enabled = true;
        onGround = false;
        transform.position = spawnPoint;
    }
}
