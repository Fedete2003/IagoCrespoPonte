using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoEnemigo : MonoBehaviour
{

    //Zona variables globales
    [Header("Movimiento")]
    [SerializeField]
    private float _velocidad;
    [SerializeField]
    private float _distanciaAlJugador;
    private GameObject _jugador;



    private void Awake()
    {

        _jugador = GameObject.FindGameObjectWithTag("XWing");


    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        Mirar();
        Mover();

    }


    private void Mirar()
    {

        //Sin gameObject XWing no hacer nada
        if (_jugador == null)
        {

            return;

        }

        transform.LookAt(_jugador.transform.position);

    }

    private void Mover()
    {

        //Calcular distancia entre enemigo y jugador
        float distancia = Vector3.Distance(transform.position, _jugador.transform.position);

        if(distancia > _distanciaAlJugador)
        {

            //Movemos nave con "Translate"
            transform.Translate(Vector3.forward * _velocidad * Time.deltaTime);

        }
    }
}
