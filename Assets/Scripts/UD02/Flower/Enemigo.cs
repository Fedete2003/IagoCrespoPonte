using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{


    //Zona de variables globales
    private float _velocidad = 0.4f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        MoverZombie();

    }

    private void MoverZombie()
    {

            //Multiplico la velocidad por el vector "forward" para permitir que el zombie avance
            transform.Translate(Vector3.forward * _velocidad * Time.deltaTime);

    }
}
