using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class siguimiento : MonoBehaviour
{
    private Rigidbody rbEnemigo;
    private GameObject jugador;

    // Start is called before the first frame update
    void Start()
    {
        rbEnemigo = GetComponent<Rigidbody>();
        jugador = GameObject.Find("numero 1");
    }

    // Update is called once per frame
    void Update()
    {
        rbEnemigo.AddForce(jugador.transform.position - transform.position);
    }
}
