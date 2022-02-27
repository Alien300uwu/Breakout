using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloque_Electrico : Bloque
{

    public Opciones CambioDif;

    public int facil = (int)Opciones.dificultad.facil;
    public int dificil = (int)Opciones.dificultad.dificil;
    //Este Cubo al ser golpeado hará que la pelota se acelere

    private void Awake()
    {
        resistencia = 2;
    }
    // Start is called before the first frame update
    void Start()
    {
        var CambioDeDificultaduwu = (int)CambioDif.NivelDificultad;
        if (CambioDeDificultaduwu == facil)
        {
            resistencia = resistencia - 1;
        }
        if (CambioDeDificultaduwu == dificil)
        {
            resistencia = resistencia + 2;
        }
    }

    public override void RebotarBola(Collision collision)
    {
        base.RebotarBola(collision);
    }

}
