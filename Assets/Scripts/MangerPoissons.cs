using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MangerPoissons : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {   
        if (other.gameObject.CompareTag("Poisson"))
        {
            Debug.Log("touche");
            Destroy(other.gameObject);
        }
    }
}
