using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecreasingOrder : MonoBehaviour
{
    //Zona de variables
    public int PrimerNumero,
                SegundoNumero,
                TercerNumero;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(OrdenDescendente());
    }

    private bool OrdenDescendente()
    {

        if(PrimerNumero < SegundoNumero && SegundoNumero < TercerNumero)
        {
            return true;
        }else
        {
            return false;
        }
    }
}
