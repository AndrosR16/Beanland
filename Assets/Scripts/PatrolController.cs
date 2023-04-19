using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolController : MonoBehaviour
{
    public float radioDeteccion = 5f;
    public float tiempoEspera = 5f;
    public GameObject personajePrincipal;

    bool personajeDentroDelRadio = false;

    void Update()
    {
        personajeDentroDelRadio = Physics.CheckSphere(transform.position, radioDeteccion, LayerMask.GetMask("Personaje"));

        if (personajeDentroDelRadio)
        {
            Invoke("ActivarContador", tiempoEspera);
        }
        else
        {
            CancelInvoke("ActivarContador");
        }
    }

    void ActivarContador()
    {
        

        Invoke("PerderPartida", tiempoEspera);
    }

    void PerderPartida()
    {
       
    }
}






        
    

