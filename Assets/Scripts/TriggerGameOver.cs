using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TriggerGameOver : MonoBehaviour
{
    public Collider ball;
    public GameObject gameOverCanvas;
    public GameObject scoreCanvas;
    private void OnTriggerEnter(Collider other) {
        gameOverCanvas.SetActive(true);
    }
}
