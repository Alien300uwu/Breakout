using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Opciones", menuName ="Herramientas/Opciones" , order = 1)]

public class Opciones : PuntajePersistente
{
    public float velocidadBola = 30;
    public dificultad NivelDificultad = dificultad.facil;
    // Start is called before the first frame update
public enum dificultad
    {
        facil,
        normal,
        dificil,
    }
    public void CambiarVelocidad(float nuevaVelocidad)
    {
        velocidadBola = nuevaVelocidad;
    }
    public void CambiarDificultad(int nuevaDificultad)
    {
        NivelDificultad = (dificultad)nuevaDificultad;
    }
}

