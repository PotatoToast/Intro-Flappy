using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipemover : MonoBehaviour
{
    public float pipeSpeed = .01f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentPosition = gameObject.transform.position;

        Vector3 newPosition = currentPosition + new Vector3(-pipeSpeed, 0, 0);

        gameObject.transform.position = newPosition;
    }
}
