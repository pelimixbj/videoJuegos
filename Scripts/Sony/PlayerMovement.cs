using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float movX, movY, jump;
    private Vector2 forceVector;
    public Animator anim;
    public float forceMultiplier, jumpMultiplier;
    private Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
	    movX = Input.GetAxis("Horizontal");
	    movY = Input.GetAxis("Vertical");
        jump = Input.GetAxis("Jump");

        anim.SetFloat("Speed_X",Mathf.Abs(movX));

        if (movX < 0f)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }
        else
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
        Debug.Log(Time.deltaTime);
        /*transform.position = new Vector3(transform.position.x + movX * Time.deltaTime,
            transform.position.y,
            transform.position.z
            transform.position += new Vector3(0f, movY, 0f) * Time.deltaTime;
            transform.position = transform.position + new Vector3(movX, 0f, 0f) * Time.deltaTime;
            );
        transform.position += new Vector3(movX, movY, 0f) * Time.deltaTime;*/

        forceVector = new Vector2(movX, 0f) * forceMultiplier;
        rb.AddForce(forceVector, ForceMode2D.Force);

        if (jump > 0)
        {
            rb.AddForce(Vector2.up * jumpMultiplier, ForceMode2D.Impulse);

        }


    }
}
