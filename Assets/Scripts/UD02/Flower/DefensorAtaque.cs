using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefensorAtaque : MonoBehaviour
{

    public GameObject Flor;
    public Transform Instanciador;
    private float _empujeY = 150.0f;
    private float _empujeZ = 350.0f;
    private float _tiempoFlor = 5.0f;
    private Animator _anim;

    private void Awake()
    {

        _anim = GetComponent<Animator>();

    }
    

    // Update is called once per frame
    void Update()
    {
        
        CrearFlor();

    }

    private void CrearFlor()
    {
        if(Input.GetMouseButtonDown(0))
        {    

            AnimacionAtaque();
            //Instanciar la flor como un clon para poder usar sus componentes despues
            GameObject clonFlor = Instantiate(Flor, Instanciador.position, Instanciador.rotation);

            //Obtengo el componente "Rigidbody" para poder impulsarlo mediante los ejes globales

            Rigidbody rbFlor = clonFlor.GetComponent<Rigidbody>();
            //"Vector3" para la posicion vertical del mundo
            rbFlor.AddForce(Vector3.up * _empujeY);
            //"transform" para la frontal del personaje
            rbFlor.AddForce(transform.forward * _empujeZ);

            //Destruir flor tras 7 segundos
            Destroy(clonFlor, _tiempoFlor);
        }
    }

    private void AnimacionAtaque()
    {

        //Ejecutar animacion de Ataque
        _anim.SetTrigger("Ataque");

    }


}
