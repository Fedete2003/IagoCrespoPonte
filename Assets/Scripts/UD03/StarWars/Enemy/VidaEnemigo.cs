using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VidaEnemigo : MonoBehaviour
{
    //Zona variables globales
    [Header("Vida")]
    [SerializeField]
    private float _vidaMax;
    [SerializeField]
    private float _vidaActual;
    [SerializeField]
    private float _danoBala;

    [Header("Barra de vida")]
    [SerializeField]
    private Image _barraVida;

    [Header("Explosiones")]
    [SerializeField]
    private ParticleSystem _explosionPequena;
    [SerializeField]
    private ParticleSystem _explosionGrande;

    void Awake()
    {

        _explosionPequena.Stop();
        _explosionGrande.Stop();
        _vidaActual = _vidaMax;
        _barraVida.fillAmount = 1.0f;

    }

    private void OnTriggerEnter(Collider infoAcceso)
    {

        if(infoAcceso.CompareTag("BalaAliada"))
        {
            //Reproducir explosión al contacto con balas del XWing
            _explosionPequena.Play();
            //Calcular el daño de cada bala y restarlo a la vida
            _vidaActual -= _danoBala;
            //Reflefar el daño en la barra de vida
            _barraVida.fillAmount = _vidaActual / _vidaMax;
            Destroy(infoAcceso.gameObject);

            if(_vidaActual <= 0.0f)
            {

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

        _explosionGrande.Play();

        Destroy(gameObject, 1.0f);

    }
}
