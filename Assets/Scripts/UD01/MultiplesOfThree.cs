using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplesOfThree : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        CalcularMultiplosTres();
    }

    private void CalcularMultiplosTres()
   {
        int i;
        for (i = 1; i <= 100; i++)
        {
            //Calcular si el numero es multiplo de 3
            if (i % 3 == 0)
            {
                Debug.Log(i + " es múltiplo de 3");
            }
        }
   }
}
