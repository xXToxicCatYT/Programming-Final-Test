using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FallingCubes : MonoBehaviour
{
    Rigidbody platform;

    void Start()
    {
        platform = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Ball")
        {
            Invoke("Gravity", 0.5f);
            Destroy(platform, 2);
        }
    }

    void Gravity()
    {
        platform.useGravity = true;
    }
}
