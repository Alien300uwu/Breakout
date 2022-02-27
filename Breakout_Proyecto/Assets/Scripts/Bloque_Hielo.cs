using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloque_Hielo : Bloque
{
    public Opciones CambioDif;

    public int facil = (int)Opciones.dificultad.facil;
    //Este Cubo al ser golpeado ralentizará a la pelota
    private void Awake()
    {
        resistencia = 1;
    }

    // Start is called before the first frame update
    void Start()
    {
        var CambioDeDificultaduwu = (int)CambioDif.NivelDificultad;
        if (CambioDeDificultaduwu == facil)
        {
            resistencia = resistencia + 2;
        }
    }

    public override void RebotarBola(Collision collision)
    {
        base.RebotarBola(collision);
    }

}
