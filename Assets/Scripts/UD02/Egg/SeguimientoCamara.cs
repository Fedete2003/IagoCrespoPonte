using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguimientoCamara : MonoBehaviour
{
    
    //Zona Variables Globales 
    public Transform MiProta;
    

    // Update is called once per frame
    void Update()
    {

        SeguirProta();

    }

    private void SeguirProta()
    {

        transform.LookAt(MiProta);

    }
}
