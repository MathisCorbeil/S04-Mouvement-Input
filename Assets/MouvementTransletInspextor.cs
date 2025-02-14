using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouvementTransletInspextor : MonoBehaviour
{
    //[SerializeField] private float _x = 0f;
    //[SerializeField] private float _y = 0f;
    //[SerializeField] private float _z = 0f;

    //// Update is called once per frame
    //void Update()
    //{
    //    transform.Translate(_x * Time.deltaTime, _y * Time.deltaTime, _z * Time.deltaTime);

    //}

    [SerializeField] private Vector3 _deplacement;

    private void Update()
    {
        transform.Translate(_deplacement * Time.deltaTime, Space.World);
    }

}
