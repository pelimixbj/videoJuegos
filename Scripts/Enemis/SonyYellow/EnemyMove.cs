﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    [Header("Movement")]
    public float maxSpeed;
    public float horizontalForce;


    [Header("Physics")]
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        rb.AddForce(ForceDirection(transform.localScale.x) * horizontalForce,
            ForceMode2D.Force);

        LimitVelocity();
    }

    private void LimitVelocity()
    {
        if (Mathf.Abs(rb.velocity.x) > maxSpeed)
            rb.velocity = rb.velocity.normalized * maxSpeed;
    }

    private Vector2 ForceDirection(float sing)
    {
        Vector2 vector;
        if (sing > 0)
            vector = Vector2.right;
        else
            vector = Vector2.left;

        return vector;

    }

}
