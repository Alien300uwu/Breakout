using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloque_Hielo : Bloque
{
    //Este Cubo al ser golpeado ralentizará a la pelota


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
