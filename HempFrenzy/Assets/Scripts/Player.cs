using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public static Player s;
    public Main sn;

    public Text ImpactPointValue;
    private uint ImpactPoints = 0;

    private float speed = 4.0f;
    private Vector3 jump;
    private float jumpForce = 2.5f;
    bool isGrounded;
    Rigidbody2D rb;
    public AudioSource jumpSound;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        jump = new Vector3(0.0f, 4.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(speed, rb.velocity.y);

        if(Input.GetKeyDown("space") && isGrounded)
        {
            jumpSound.Play();
            rb.AddForce(jump * jumpForce, ForceMode2D.Impulse);
            isGrounded = false;
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "ground")
        {
            isGrounded = true;
        }
        if (other.gameObject.tag == "thunder")
        {
            Destroy(this.gameObject);
            sn.GameOver();
        }
        if (other.gameObject.tag == "coin")
        {
            sn.YouWin();
        }
    }
    // When coin intersects the collider (player) when 'is trigger' checked
    void OnTriggerEnter2D(Collider2D col)
    {
        // checks to see if collision is with player
        if (col.gameObject.tag == "hemp")
        {
            col.gameObject.SetActive(false);
            ImpactPoints++;
            ImpactPointValue.text = ImpactPoints.ToString();
        }
        if(col.gameObject.tag == "saw")
        {
            Destroy(this.gameObject);
            sn.GameOver();
        }
    }
}
