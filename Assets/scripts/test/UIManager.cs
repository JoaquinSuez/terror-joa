using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject nota;
    [SerializeField] private GameObject tip;
    private TextMeshProUGUI tipText;
    private void Start()
    {
        tipText = tip.GetComponent<TextMeshProUGUI>();
    }
    public void Nota()
    {
        nota.GetComponent<Animator>().SetInteger("anim",1);
    }
    public void SetTip(string a)
    {
        tipText.text = a;
    }
}
