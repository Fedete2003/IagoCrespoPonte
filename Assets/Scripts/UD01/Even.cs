using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Even : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        CalcularPares();
    }

   private void CalcularPares()
   {
        int i;
        for (i = 0; i <= 100; i++)
        {
            //Calcular si el numero es par
            if (i % 2 == 0)
            {
                Debug.Log("Es par: " + i);
            }
        }
   }
}
