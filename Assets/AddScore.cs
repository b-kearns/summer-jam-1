using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScore : MonoBehaviour
{
    [SerializeField] public Score score;

    private void Start()
    {
        score = GameObject.FindGameObjectWithTag("GameController").GetComponent<Score>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("score");
            score.playerScore += 100;
        }
    }
}