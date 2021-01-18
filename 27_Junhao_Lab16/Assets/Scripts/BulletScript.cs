using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    float xLimit = 5f;
    float zLimit = 5f;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 3);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
        if(transform.position.x > xLimit)
        {
            Destroy(gameObject);
        }
        if (transform.position.x < -xLimit)
        {
            Destroy(gameObject);
        }
        if (transform.position.z > zLimit)
        {
            Destroy(gameObject);
        }
        if (transform.position.z < -zLimit)
        {
            Destroy(gameObject);
        }
    }
}
