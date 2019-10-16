using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookScript : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Mouse X") < 0)
            transform.Rotate(Vector3.up* speed);
        if (Input.GetAxis("Mouse X") > 0)
            transform.Rotate(Vector3.down* speed);
    }
}
