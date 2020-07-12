using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarCollision : MonoBehaviour
{
    [SerializeField] public GameObject explosion;

    void Start()
    {
        explosion.SetActive(false);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground")) { return; }
        // GAME OVER
        else
        {
            explosion.SetActive(true);
        }
    }
}
