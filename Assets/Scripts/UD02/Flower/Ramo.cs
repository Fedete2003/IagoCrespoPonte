using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ramo : MonoBehaviour
{

    
    private void OnCollisionEnter(Collision infoColision)
    {

        if(infoColision.collider.CompareTag("Enemigo"))
        {

            Destroy(infoColision.gameObject);

        }

    }
    
}
