using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearEnemigo : MonoBehaviour
{
    
    public GameObject Zombie;
    private GameObject clonZombie;
    public Transform Instanciador;
    private float _tiempoInicio;
    private float _repeticion = 5.0f;
    
    

    // Update is called once per frame
    void Update()
    {
        _tiempoInicio = _tiempoInicio + Time.deltaTime;
        CrearZombie();
        
    }

    private void CrearZombie()
    {
        if(_tiempoInicio >= _repeticion)
        {
            //Instanciar el zombie como un clon para poder usar sus componentes despues
            clonZombie = Instantiate(Zombie, Instanciador.position, Instanciador.rotation);
            _tiempoInicio = 0.0f;
        }
    }

    
}
