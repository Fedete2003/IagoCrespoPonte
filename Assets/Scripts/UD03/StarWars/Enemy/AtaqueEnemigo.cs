using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtaqueEnemigo : MonoBehaviour
{

    //Zona de variables globales
    [Header("Ataque")]
    [SerializeField]
    private GameObject _balaPrefab;
    [SerializeField]
    private Transform[] _posRotBala;
    private GameObject _player;
    [SerializeField]
    private float _tiempoEntreBalas;


    private void Awake()
    {

        _player = GameObject.FindGameObjectWithTag("XWing");
        InvokeRepeating("Ataque", 1.0f, _tiempoEntreBalas);

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Ataque();
    }


    private void Ataque()
    {

        for (int i = 0; i < _posRotBala.Length; i++)
        {

            Instantiate(_balaPrefab, _posRotBala[i].position, _posRotBala[i].rotation);

        }

    }
}
