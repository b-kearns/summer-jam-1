using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarGroup : MonoBehaviour
{
    [SerializeField] public Camera camera = null;
    public float yOffset = 15f;
    public float zOffset = 15f;

    public GameObject[] cars;

    // Update is called once per frame
    void Update()
    {
        camera.transform.localPosition = FindCenter() + Vector3.up * yOffset + camera.transform.forward * -zOffset;
    }

    private Vector3 FindCenter()
    {
        Vector3 center = Vector3.zero;

        if (cars.Length == 0) { return Vector3.zero; }
        else if (cars.Length == 1) { return cars[0].transform.localPosition; }

        foreach (var car in cars)
        {
            center.x += car.transform.localPosition.x;
            center.z += car.transform.localPosition.z;
        }

        return center / cars.Length;
    }

    public void StopMovement()
    {
        foreach (var car in cars)
        {

        }
    }
}
