using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XWingMovimiento : MonoBehaviour
{

    //Zona Variables globales 
    [Header("Movimiento")]
    [SerializeField]
    private float _velocidad;
    [SerializeField]
    private float _giroVelocidad;

    [Header("Ataque")]
    [SerializeField]
    private GameObject _balaPrefab;
    [SerializeField]
    private Transform[] _posRotBalasArray;

    private AudioSource _audioDisparo;



    private void Awake()
    {

        Cursor.lockState = CursorLockMode.Locked;
        _audioDisparo = GetComponent<AudioSource>();


    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Mover();
        Girar();
        Atacar();
    }

    private void Mover()
    {
        //Obtengo los ejes
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        //Creamos un Vector con ambas coordenadas para mover la nave
        Vector3 direccion = new Vector3 (horizontal, 0.0f, vertical);
        transform.Translate(direccion.normalized * _velocidad * Time.deltaTime);

    }

    private void Girar()
    {
        //Recogemos desplazamiento en X e Y del ratón
        float xRaton = Input.GetAxis("Mouse X");
        float yRaton = Input.GetAxis("Mouse Y");

        //Guardamos los datos en un Vector separado
        Vector3 rotacion = new Vector3(yRaton, xRaton, 0.0f);
        transform.Rotate(rotacion * _giroVelocidad * Time.deltaTime);

    }

    private void Atacar()
    {

        if(Input.GetMouseButtonDown(0))
        {

            _audioDisparo.Play();

            //Recorremos el Array
            for (int i = 0; i < _posRotBalasArray.Length; i++)
            {
                                
                Instantiate(_balaPrefab, _posRotBalasArray[i].position, _posRotBalasArray[i].rotation);

            }

        }

    }


}
