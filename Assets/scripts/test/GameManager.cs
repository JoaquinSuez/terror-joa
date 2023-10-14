using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private UIManager UI;
    [SerializeField] private AnimManager Anim;
    public static GameManager instance;
    public void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        Destroy(this);
    }
    public UIManager GetUI()
    {
        return UI;
    }
    public AnimManager GetAnimManager()
    {
        return Anim;
    }
}
