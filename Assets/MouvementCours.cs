using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouvementCours : MonoBehaviour
{
    private float _vitesse ;
    private void Start()
    {
        _vitesse = Random.Range(1f, 5f);
    }

   
    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,0, _vitesse * Time.deltaTime);
        if(transform.position.x > 5f)
        {
            Debug.Log(gameObject.name);
        }
    }
}
