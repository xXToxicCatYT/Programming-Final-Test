using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondCollide : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Ball")
        {
            Destroy(gameObject);
        }
    }

}
