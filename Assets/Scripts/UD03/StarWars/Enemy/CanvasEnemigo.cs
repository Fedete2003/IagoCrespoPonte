using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasEnemigo : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        
        //Mira hacia la cámara de la escena con la etiqueta "main"
        transform.LookAt(Camera.main.transform.position);


    }
}
