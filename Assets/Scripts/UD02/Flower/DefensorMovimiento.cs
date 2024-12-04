using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefensorMovimento : MonoBehaviour
{

    //Zona de variables globales
    
    //Giro
    private float _horizontal;
    
    //Desplazamiento
    private float _velocidad = 0.8f,
             _giroVelocidad = 90.0f,
             _aumentoCorrer = -1.5f;
    public float FuerzaSalto;

    //Animacion
    private Animator _anim;
    private Rigidbody _rb;

    //Salto
    private Ray _rayo;
    private RaycastHit _impacto;
    private bool _estaSuelo,
                 _puedeSaltar;

    public LayerMask CapaSuelo;
    public float LongitudRayo;

   
   void Awake()
   {

        //Obtengo el "Animator" del personaje
        _anim = GetComponent<Animator>();
        //Obtengo el "Rigidbody"
        _rb = GetComponent<Rigidbody>();

   }

    // Update is called once per frame
    void Update()
    {
        ControlJugador();
        Movimiento();
        Giro();
        Animacion();
        PuedeSaltar();
    }

    private void FixedUpdate()
    {

        ActivarRaycast();
        if(_puedeSaltar)
        {

            _puedeSaltar = false;
            //Llamar al metodo saltar
            Saltar();
        }

    }

    private void ActivarRaycast()
    {

        //El rayo empieza en el pivote del personaje
        _rayo.origin = transform.position;
        //Lo disparamos hacia abajo
        _rayo.direction = -transform.up;

        if(Physics.Raycast(_rayo, out _impacto, LongitudRayo))
        {
                            
            _estaSuelo = true;

        }else
        {

            _estaSuelo = false;
        }

    }

    private void ControlJugador()
    {

        _horizontal = Input.GetAxis("Horizontal");
        
    }

    private void Movimiento()
    {

        //Avanzar y correr
        if(Input.GetKey(KeyCode.W))
        {
        
           transform.Translate(Vector3.forward * _velocidad * Time.deltaTime);
        
        }else if(Input.GetKey(KeyCode.LeftShift))
        {

            transform.Translate(Vector3.forward * _velocidad * _aumentoCorrer 
                                * Time.deltaTime);

        }

        //Retroceder y correr
        if(Input.GetKey(KeyCode.S))
        {
        
            transform.Translate(Vector3.back * _velocidad  * Time.deltaTime);
        
        }else if(Input.GetKey(KeyCode.LeftShift))
        {

            transform.Translate(Vector3.back * _velocidad * _aumentoCorrer 
                                * Time.deltaTime);

        }

        
    }
    private void PuedeSaltar()
    {
        //Puede saltar
        if(Input.GetKey(KeyCode.Space) && _estaSuelo)
        {
            
            _puedeSaltar = true;

        }
    }

    private void Saltar()
    {

        _rb.AddForce(Vector3.up * FuerzaSalto);

    }

    private void Giro()
    {
        //Rotacion personaje
        transform.Rotate(Vector3.up * _giroVelocidad *_horizontal
                         * Time.deltaTime);

    }

    private void Animacion()
    {
        ////Animacion movimiento hacia delante
        if(Input.GetKey(KeyCode.W))
        {
            _anim.SetBool("EstaCaminando", true);
        
        }else
        {
            _anim.SetBool("EstaCaminando", false);
        }
        
        //Se activa al correr
        if(Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.LeftShift))
        {
            _anim.SetBool("EstaCorriendo", true);
        }else
        {
            _anim.SetBool("EstaCorriendo", false);
        }


        //Animacion movimiento hacia atras
        if(Input.GetKey(KeyCode.S))
        {
            _anim.SetBool("EstaAtras", true);
        
        }else
        {
            _anim.SetBool("EstaAtras", false);
        }

        //Se activa al correr
        if(Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.LeftShift))
        {
            _anim.SetBool("EstaCorriendoAtras", true);
        }else
        {
            _anim.SetBool("EstaCorriendoAtras", false);
        }

        //Animacion saltar
        if(_puedeSaltar == false)
        {
            _anim.SetBool("EstaSaltando", true);

        }else
        {
            _anim.SetBool("EstaSaltando", false);
        }

    }
    
}
