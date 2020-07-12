using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    [SerializeField] public CityGenerator cityGenerator;
    bool haveSpawned = false;

    private void Start()
    {
        cityGenerator = GameObject.FindGameObjectWithTag("City").GetComponent<CityGenerator>();
        haveSpawned = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!haveSpawned) { cityGenerator.SpawnChunk(); }
        haveSpawned = true;


    }
}
