using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("w"))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 2);

        }

        if (Input.GetKeyDown("s"))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 2);

        }
        if (Input.GetKeyDown("a"))
        {
            transform.position = new Vector3(transform.position.x - 2, transform.position.y, transform.position.z);

        }
        if (Input.GetKeyDown("d"))
        {
            transform.position = new Vector3(transform.position.x + 2, transform.position.y, transform.position.z);

        }








    }
}
