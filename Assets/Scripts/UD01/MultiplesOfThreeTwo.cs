using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplesOfThreeTwo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        CalcularMultiplos();
    }

    private void CalcularMultiplos()
   {
        int i;
        for (i = 1; i <= 100; i++)
        {
            //Calcular si el numero es mulitplo de tres
            if (i % 3 == 0)
            {
                Debug.Log(i + " es múltiplo de 3");
            }
             //Calcular si el numero es mulitplo de dos
            if(i % 2 == 0)
            {
                Debug.Log(i + " es múltiplo de 2");
            }
            //Calcular si es de los dos
            if(i % 3 == 0 && i % 2 == 0)
            {
                Debug.Log(i + " es múltiplo de 2 y 3");
            }
        }
   }
}
