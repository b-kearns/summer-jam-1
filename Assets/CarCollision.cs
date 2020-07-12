using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarCollision : MonoBehaviour
{
    [SerializeField] public GameObject explosion;
    [SerializeField] public GameOver gameOver;

    void Start()
    {
        explosion.SetActive(false);
        gameOver = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameOver>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.CompareTag("Ground"))
        { 
            explosion.SetActive(true);
            gameOver.OnCrash();
        }
    }
}
