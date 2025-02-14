using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContraolPoissonDashDemo : MonoBehaviour
{
    private Rigidbody _rb;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void OnDash()
    {
        Debug.Log("DASH!");
        _rb.AddRelativeForce(0, 0, 2f, ForceMode.VelocityChange);
    }
}
