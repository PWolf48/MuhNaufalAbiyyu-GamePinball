using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggreRampController : MonoBehaviour
{
    public float score;
    public Collider ball;
    public ScoreManager scoreManager;
    private void OnTriggerEnter(Collider other) {
        if(other == ball)
        {
            scoreManager.AddScore(score);
        }
    }
}
