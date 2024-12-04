using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FromLargestToSmallest : MonoBehaviour
{
    
    //Zona Propiedades
    public int PrimerNumero,
                SegundoNumero,
                TercerNumero;


    // Start is called before the first frame update
    void Start()
    {
        MayorAMenor(); 
    }

    private void MayorAMenor()
    {
        if(PrimerNumero >= SegundoNumero && SegundoNumero >= TercerNumero)
        {
            //1>2>3
            Debug.Log("El orden ascendente es: " + PrimerNumero + " > " + SegundoNumero + " > " + TercerNumero);
            
        }else if(SegundoNumero >= TercerNumero && TercerNumero >= PrimerNumero)
        {
            //2>3>1
            Debug.Log("El orden ascendente es: " + SegundoNumero + " > " + TercerNumero + " > " + PrimerNumero);
            
        }else if(TercerNumero >= PrimerNumero && PrimerNumero >= SegundoNumero)
        {
            //3>1>2
            Debug.Log("El orden ascendente es: " + TercerNumero + " > " + PrimerNumero + " > " + SegundoNumero);

        }else if(PrimerNumero >= SegundoNumero && SegundoNumero <= TercerNumero)
        {
            //1>3>2
            Debug.Log("El orden ascendente es: " + PrimerNumero + " > " + TercerNumero + " > " + SegundoNumero);

        }else if(SegundoNumero >= TercerNumero && TercerNumero <= PrimerNumero)
        {
            //2>1>3
            Debug.Log("El orden ascendente es: " + SegundoNumero + " > " + PrimerNumero + " > " + TercerNumero);

        }else if(TercerNumero >= PrimerNumero && PrimerNumero <= SegundoNumero)
        {
            //3>2>1
            Debug.Log("El orden ascendente es: " + TercerNumero + " > " + SegundoNumero + " > " + PrimerNumero);
        }
    }
}
