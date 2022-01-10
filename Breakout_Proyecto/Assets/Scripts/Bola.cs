using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{

    public bool isGameStart = false;
    [SerializeField] public float velocidadBola = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 posicionInicial = GameObject.FindGameObjectWithTag("Jugador").transform.position;
        posicionInicial.y += 3;
        this.transform.position = posicionInicial;
        this.transform.SetParent(GameObject.FindGameObjectWithTag("Jugador").transform);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space)|| Input.GetButton("Submit"))
        {
            if (!isGameStart)
            {
                isGameStart = true;
                this.transform.SetParent(null);
                GetComponent<Rigidbody>().velocity = velocidadBola * Vector3.up;
            }
        }
    }
}
