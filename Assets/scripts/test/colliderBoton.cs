using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class colliderBoton : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("player") && Input.GetKey(KeyCode.E))
        {
            string a = this.tag;
            string b = a[a.Length-1].ToString();
            int c = int.Parse(b);
            EventManager.instance.Event("boton",c);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("player"))
        {
            GameManager.instance.GetUI().SetTip("E");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("player"))
        {
            GameManager.instance.GetUI().SetTip("");
        }
    }
}
