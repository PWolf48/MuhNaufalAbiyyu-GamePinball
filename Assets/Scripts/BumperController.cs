using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperController : MonoBehaviour
{
    public Collider ball;
    public float multiplier;
    public Color color;
    private Renderer rnd;
    private Animator animator;

    private void Start()
    {
        rnd = GetComponent<Renderer>();
        rnd.material.color = color;
        animator = GetComponent<Animator>();
    }
    private void OnCollisionEnter(Collision coll)
    {
        if(coll.collider == ball)
        {
            Rigidbody ballRig = ball.GetComponent<Rigidbody>();
            ballRig.velocity *= multiplier;
            animator.SetTrigger("hit");
        }
    }
}
