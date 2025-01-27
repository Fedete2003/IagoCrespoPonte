using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestorEnemigos : MonoBehaviour
{

    //Zona variables globales
    [Header("Instanciación")]
    [SerializeField]
    private GameObject _prefabEnemigo;
    [SerializeField]
    private Transform[] _posRotEnemigo;
    [SerializeField]
    private float _tiempoEntreEnemigos;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CrearEnemigo", _tiempoEntreEnemigos, _tiempoEntreEnemigos);
    }

    // Update is called once per frame
    void Update()
    {

        

    }

    private void CrearEnemigo()
    {
        int n = Random.Range(0, _posRotEnemigo.Length);

        Instantiate(_prefabEnemigo, _posRotEnemigo[n].position, 
                        _posRotEnemigo[n].rotation);

    }
}
