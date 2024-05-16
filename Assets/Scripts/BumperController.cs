using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperController : MonoBehaviour
{
    public Collider ball;
    public float multiplier;
    public float score;
    public Color color;
    private Renderer rnd;
    private Animator animator;
    public AudioManager audioManager;
    public VFXManager vfxManager;
    public ScoreManager scoreManager;

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
            audioManager.PlaySFX(coll.transform.position);
            vfxManager.PlayVFX(coll.transform.position);
            scoreManager.AddScore(score);
        }
    }
}
