using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipespawner : MonoBehaviour
{
    public GameObject pipePair;


    // Update is called once per frame
    void Update()
    {
        Instantiate(pipePair, gameObject.transform.position, Quaternion.identity);
    }
}
