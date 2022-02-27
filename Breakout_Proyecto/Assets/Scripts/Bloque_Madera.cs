using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloque_Madera : Bloque
{

    public Opciones CambioDif;

    public int normal = (int)Opciones.dificultad.normal;
    public int dificil = (int)Opciones.dificultad.dificil;


    private void Awake()
    {
        resistencia = 1;
    }
    // Start is called before the first frame update
    void Start()
    {
        
        var CambioDeDificultaduwu = (int)CambioDif.NivelDificultad;
        if (CambioDeDificultaduwu == normal)
        {
            resistencia = resistencia + 1;
        }
        if (CambioDeDificultaduwu == dificil)
        {
            resistencia = resistencia + 2;
        }

    }
    private void Update()
    {
        Debug.Log($"La dificultad actual es = {(int)CambioDif.NivelDificultad}");
    }



    public override void RebotarBola(Collision collision)
    {
        base.RebotarBola(collision);
    }

}
