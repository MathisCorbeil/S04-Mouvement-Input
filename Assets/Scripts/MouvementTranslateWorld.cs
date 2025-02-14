using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouvementTranslateWorld : MonoBehaviour
{
    [SerializeField] float x = 0f;
    [SerializeField] float y = 0f;
    [SerializeField] float z = 0f;
    void Update()
    {
        transform.Translate(x * Time.deltaTime, y * Time.deltaTime, z * Time.deltaTime, Space.World);

        //Vector3 deplacement = new Vector3(1f, 0, 0);
        //transform.Translate(deplacement * Time.deltaTime, Space.World);
    }
}
