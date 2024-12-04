using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreasingOrder : MonoBehaviour
{
    //Zona de Variables
    public int PrimerNumero,
                SegundoNumero,
                TercerNumero;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(OrdenAscendente());
    }

    private bool OrdenAscendente()
    {

        if(PrimerNumero > SegundoNumero && SegundoNumero > TercerNumero)
        {
            return true;
        }else
        {
            return false;
        }
    }
}
