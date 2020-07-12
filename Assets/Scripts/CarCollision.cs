using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarCollision : MonoBehaviour
{
    [SerializeField] public GameObject explosion;
    [SerializeField] public GameOver gameOver;

    public AudioSource crashSFX;

    void Start()
    {
        explosion.SetActive(false);
        gameOver = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameOver>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.collider.CompareTag("Ground"))
        {
            crashSFX.Play();

            explosion.SetActive(true);

            gameOver.OnCrash();
        }
    }
}
