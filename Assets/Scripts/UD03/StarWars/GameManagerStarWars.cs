using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerStarWars : MonoBehaviour
{

    //Zona variables globales
    [Header("Game Over")]
    [SerializeField]
    private GameObject _panelGameOver;
    [SerializeField]
    private GestorEnemigos _gestorEnemigos;


    public void GameOver()
    {
        //Activamos el panel de Game Over
        _panelGameOver.SetActive(true);
        //Desactivamos el script de aparición de enemigos
        _gestorEnemigos.enabled = false;
        //Reactivar el cursor
        Cursor.lockState = CursorLockMode.Confined;

    }

    //Método que recarga la escena de juego

    public void CargarEscena()
    {

        SceneManager.LoadScene(0);

    }
}
