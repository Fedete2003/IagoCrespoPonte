using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Month : MonoBehaviour
{
    //Zona Propiedades
    public int NumeroMes;
    private string _primerMes;
    private string _segundoMes;
    private string _tercerMes;
    private string _cuartoMes;
    private string _quintoMes;
    private string _sextoMes;
    private string _septimoMes;
    private string _octavoMes;
    private string _novenoMes;
    private string _decimoMes;
    private string _undecimoMes;
    private string _duodecimoMes;


    // Start is called before the first frame update
    void Start()
    {

        _primerMes = "Enero";
        _segundoMes = "Febrero";
        _tercerMes = "Marzo";
        _cuartoMes = "Abril";
        _quintoMes = "Mayo";
        _sextoMes = "Junio";
        _septimoMes = "Julio";
        _octavoMes = "Agosto";
        _novenoMes = "Septiembre";
        _decimoMes = "Octubre";
        _undecimoMes = "Noviembre";
        _duodecimoMes = "Diciembre";
        Debug.Log(SeleccionarMes());
    }
    // Update is called once per frame
    private string SeleccionarMes()
    {
        string entradaInvalida = "Mes no válido";
        if(NumeroMes == 1)
        {
            return _primerMes;
        }else if(NumeroMes == 2)
        {
            return _segundoMes;
        }
        if(NumeroMes == 3)
        {
            return _tercerMes;
        }else if(NumeroMes == 4) 
        {
            return _cuartoMes;
        }
        if(NumeroMes == 5)
        {
            return _quintoMes;
        }else if(NumeroMes == 6) 
        {
            return _sextoMes;
        }
        if(NumeroMes == 7)
        {
            return _septimoMes;
        }else if(NumeroMes == 8) 
        {
            return _octavoMes;
        }
        if(NumeroMes == 9)
        {
            return _novenoMes;
        }else if(NumeroMes == 10) 
        {
            return _decimoMes;
        }
        if(NumeroMes == 11)
        {
            return _undecimoMes;
        }else if(NumeroMes == 12) 
        {
            return _duodecimoMes;
        }else
        {
            return entradaInvalida;
        }
    }
}

