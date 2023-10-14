using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventLogic : MonoBehaviour
{
    public void Event(string a,int b = -1)
    {
        switch (a)
        {
            case "nota":
            {
                GameManager.instance.GetUI().Nota();
            }
            break;
            case "boton":
            {
                GameManager.instance.GetAnimManager().GetPuerta(b).GetComponent<animGen>().PrenderAnim();
            }
            break;
            case "":break;
            default: 
                print("Evento No Encontrado: " + a);
            break;
        }
    }
}
