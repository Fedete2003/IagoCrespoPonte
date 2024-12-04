using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{

    public Transform Jugador;
    private float _suavizado;
    private Vector3 _compesacion;
    // Start is called before the first frame update
    void Start()
    {
        //Calcular la distancia entre la camara y el jugador
        _compesacion = transform.position - Jugador.position;
        _suavizado = 0.5f;

    }

    // Update is called once per frame
    void Update()
    {
        
        Vector3 posicionCamara = Jugador.position + _compesacion;
        transform.position = Vector3.Lerp(transform.position, posicionCamara, _suavizado);

    }
}
