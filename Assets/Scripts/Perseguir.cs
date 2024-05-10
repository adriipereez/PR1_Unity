using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Perseguir : MonoBehaviour
{
    // Start is called before the first frame update
    private float _vel;
    void Start()
    {
        _vel = 4f;

        Invoke("destruirEnemic", 4);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 posjugador = GameObject.Find("Jugador").transform.position;

        Vector3 direccioCapAJugador = (posjugador - transform.position).normalized;

        transform.position += direccioCapAJugador * (_vel * Time.deltaTime);
    }

    private void destruirEnemic()
    {
        Destroy(gameObject);
    }

    private void OnCollisionEnter (Collision objecteTocat)
    {
        if (objecteTocat.gameObject.name == "Jugador")
        {
            Destroy(gameObject);
        }
    }
}
