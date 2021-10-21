using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird : MonoBehaviour
{
    public float jumpHeight = 10;
 
    private Rigidbody2D myRigidBody;

    // Start is called before the first frame update
    void Start()
    {
        myRigidBody = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            /*
            Vector3 currentPosition = gameObject.transform.position;

            Vector3 newPosition = currentPosition + new Vector3(0, 1, 0)

            gameObject.transform.position = newPosition;
            */

            myRigidBody.velocity = new Vector2(0, jumpHeight);
        }
    }
}