using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balas : MonoBehaviour
{

    //Zona De variables globales

    private float _velocidad = 160.0f;


    // Start is called before the first frame update
    void Start()
    {

        Destroy(gameObject, 8);

    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector3.forward * _velocidad * Time.deltaTime); 
     
    }
}
