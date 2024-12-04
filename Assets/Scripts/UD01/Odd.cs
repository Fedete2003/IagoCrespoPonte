using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Odd : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {
        CalcularImpares();
    }


   
    private void CalcularImpares()
    {
        int i;
        for (i = 0; i <= 100; i++)
        {
            //Calcular si el numero es impar
            if (i % 2 != 0)
            {
                Debug.Log("Es impar: " + i);
            }
        }
    }
    
}
