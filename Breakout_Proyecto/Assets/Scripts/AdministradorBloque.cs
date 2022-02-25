using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdministradorBloque : MonoBehaviour
{
    public GameObject MenuVictory;


    // Update is called once per frame
    void Update()
    {
        if(transform.childCount == 0)
        {
            MenuVictory.SetActive(true);
        }
    }
}
