using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerController : MonoBehaviour
{
     void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name != "Barrier")
        {
            Destroy(other.gameObject);
        }
    }
}
