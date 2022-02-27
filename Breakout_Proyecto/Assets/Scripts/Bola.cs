using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Bola : MonoBehaviour
{

    public Opciones CambioDif;

    public bool isGameStart = false;
    [SerializeField] public float velocidadBola = 10.0f; 
    Vector3 ultimaPosicion = Vector3.zero;
    Vector3 dirreccion = Vector3.zero;
    Rigidbody rigidbody;
    private ControlBordes control;
    public UnityEvent BolaDestruida;
    

    private void Awake()
    {
        control = GetComponent<ControlBordes>();

        velocidadBola = velocidadBola;
    }

    // Start is called before the first frame update
    void Start()
    {
        Vector3 posicionInicial = GameObject.FindGameObjectWithTag("Jugador").transform.position;
        posicionInicial.y += 3;
        this.transform.position = posicionInicial;
        this.transform.SetParent(GameObject.FindGameObjectWithTag("Jugador").transform);
        rigidbody = this.gameObject.GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        if(control.salioAbajo)
        {
            Debug.Log("La bola salió abajo");
            BolaDestruida.Invoke();
            Destroy(this.gameObject);
        }
        if(control.salioArriba)
        {
            dirreccion = transform.position - ultimaPosicion;
            Debug.Log("La bola toco el borde superior");
            dirreccion.y *= -1;
            dirreccion = dirreccion.normalized;
            rigidbody.velocity = velocidadBola * dirreccion;
            control.salioArriba = false;
            control.enabled = false;
            Invoke("HabilitarControl", 0.2f);
        }
        if (control.salioDerecha)
        {
            dirreccion = transform.position - ultimaPosicion;
            Debug.Log("La bola toco el borde derecho");
            dirreccion.x *= -1;
            dirreccion = dirreccion.normalized;
            rigidbody.velocity = velocidadBola * dirreccion;
            control.salioDerecha = false;
            control.enabled = false;
            Invoke("HabilitarControl", 0.2f);
        }
        if (control.salioIzquierda)
        {
            dirreccion = transform.position - ultimaPosicion;
            Debug.Log("La bola toco el borde izquierdo");
            dirreccion.x *= -1;
            dirreccion = dirreccion.normalized;
            rigidbody.velocity = velocidadBola * dirreccion;
            control.salioIzquierda = false;
            control.enabled = false;
            Invoke("HabilitarControl", 0.2f);
        }

        if (Input.GetKey(KeyCode.Space)|| Input.GetButton("Submit"))
        {
            if (!isGameStart)
            {
                isGameStart = true;
                this.transform.SetParent(null);
                GetComponent<Rigidbody>().velocity = velocidadBola * Vector3.up;
            }
        }


        var velobola = CambioDif.velocidadBola;
        Debug.Log(velobola);
        velocidadBola = velobola;


    }
    private void HabilitarControl()
    {
        control.enabled = true;
    }
    private void FixedUpdate()
    {
        ultimaPosicion = transform.position;  
    }
    private void LateUpdate()
    {
        if (dirreccion != Vector3.zero) dirreccion = Vector3.zero;
    }
}
