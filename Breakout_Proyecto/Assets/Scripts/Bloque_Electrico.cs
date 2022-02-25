using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloque_Electrico : Bloque
{
    //Este Cubo al ser golpeado hará que la pelota se acelere


    // Start is called before the first frame update
    void Start()
    {
        resistencia = 2;
    }

    public override void RebotarBola(Collision collision)
    {
        base.RebotarBola(collision);
    }

}
