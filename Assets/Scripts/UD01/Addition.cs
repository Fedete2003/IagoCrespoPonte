using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Addition : MonoBehaviour
{
    //Zona variables
    public int NumeroAjustable;
    // Start is called before the first frame update
    void Start()
    {
        CalcularSuma();
    }

    private void CalcularSuma()
    {
        int Suma = 0;
        int i;
        //Calcular todos los numeros hasta el seleccionado
        for(i = 1; i <= NumeroAjustable; i++)
        {
            Suma += i;
        }

        Debug.Log("La suma total es de todos los números del 1 al " + NumeroAjustable + " es " + Suma);

    }
}
