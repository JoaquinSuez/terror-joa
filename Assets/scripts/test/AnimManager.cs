using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimManager : MonoBehaviour
{
    [SerializeField] private GameObject[] puerta;
    public GameObject GetPuerta(int a)
    {
        return puerta[a];
    }
}
