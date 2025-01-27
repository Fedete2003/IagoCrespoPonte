using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class XWingVida : MonoBehaviour
{

    //Zona de variables globales
    [Header("Vida")]
    //Salud Máxima
    [SerializeField]
    private float _maxVida;
    //Salud Actual
    [SerializeField]
    private float _vidaActual;
    //Daño balas
    [SerializeField]
    private float _danoBalaEnemiga;

    [Header("Barra de vida")]
    [SerializeField]
    private Image _barraVida;

    [Header("Particulas")]
    [SerializeField]
    private ParticleSystem _explosionGrande;
    [SerializeField]
    private ParticleSystem _explosionPequena;

    [Header("Game Over")]
    [SerializeField]
    private GameManagerStarWars _gameManager;


    private void Awake()
    {

        _explosionGrande.Stop();
        _explosionPequena.Stop();
        _vidaActual = _maxVida;
        _barraVida.fillAmount = 1;

    }

    private void OnTriggerEnter(Collider infoAcceso)
    {

        if(infoAcceso.CompareTag("BalaEnemiga"))
        {

            _explosionPequena.Play();
            _vidaActual -= _danoBalaEnemiga;

            _barraVida.fillAmount = _vidaActual / _maxVida;
            Destroy(infoAcceso.gameObject);

            if(_vidaActual <= 0)
            {

                _explosionGrande.Play();
                Morir();

            }

        }


    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void Morir()
    {

        _gameManager.GameOver();


        Camera.main.transform.SetParent(null);

        Destroy(gameObject, 1.0f);
    }
}
