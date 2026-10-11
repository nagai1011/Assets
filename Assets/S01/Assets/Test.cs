using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{

    public float speed = 5.0f;

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 movements = new Vector3(x,0,z);

        transform.Translate(movements * speed * Time.deltaTime);
    }
}
