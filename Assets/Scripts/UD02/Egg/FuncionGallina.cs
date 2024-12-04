using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuncionGallina : MonoBehaviour
{

    //Zona Variables Globales
    private float _horizontal;
    private float _vertical;
    private float _cronometro = 5.0f;
    public GameObject Huevo;
    public Transform InstanciadorHuevo;
    [SerializeField]
    private float _velocidad = 3.0f,
                  _giroVelocidad = 80.0f,
                  _empujeHuevoY = 0.5f;


    void Update()
    {
        
        MoverGallina();
        PonerHuevos();

    }

    private void MoverGallina()
    {

        //Obtener eje horizontal
        _horizontal = Input.GetAxis("Horizontal");
        //Obtener eje vertical
        _vertical = Input.GetAxis("Vertical");

        //Multiplicar Translate por eje vertical por velocidad
        transform.Translate(Vector3.forward * _velocidad * _vertical * Time.deltaTime);
        //Multiplicar Rotate por eje horizontal por giro
        transform.Rotate(Vector3.up * _giroVelocidad * _horizontal * Time.deltaTime);

    }

    private void PonerHuevos()
    {

        if(Input.GetMouseButtonDown(0))
        {
            
            /*Instanciar cada huevo identificando cada uno mediante
                una propiedad */

           GameObject clonHuevo = Instantiate(Huevo, InstanciadorHuevo.position, 
                                                InstanciadorHuevo.rotation);

            //Obtener "rigidbody" de cada huevo 
            Rigidbody rbHuevo = clonHuevo.GetComponent<Rigidbody>();    

            //Aplicar fuerza a cada huevo
            rbHuevo.AddForce(Vector3.down * _empujeHuevoY);
            
            //Destruir clonHuevo
            
            
            
                Destroy(clonHuevo, _cronometro);
            
            
        
        
        }   



    }

    
}
