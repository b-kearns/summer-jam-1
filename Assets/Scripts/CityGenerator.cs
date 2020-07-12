using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CityGenerator : MonoBehaviour
{
    public GameObject chunkPrefab;
    public GameObject carGroup;

    private Queue<GameObject> cityBlocks = new Queue<GameObject>();

    private float nextChunk = 0;
    // Start is called before the first frame update
    void Start()
    {
        SpawnChunk();
        SpawnCars();
    }

    public void SpawnChunk()
    {
        var newChunk = GameObject.Instantiate(chunkPrefab);
        newChunk.transform.SetPositionAndRotation(new Vector3(0,0,nextChunk), Quaternion.identity);
        nextChunk += 24;

        newChunk.transform.parent = this.transform;
    }

    public void SpawnCars()
    {
        var newObject = GameObject.Instantiate(carGroup, this.transform);
        cityBlocks.Enqueue(newObject);

        if (cityBlocks.Count > 2) { GameObject.Destroy(cityBlocks.Dequeue()); }
        //Debug.Log("# of CityBlocks :: " + cityBlocks.Count);
    }
}
