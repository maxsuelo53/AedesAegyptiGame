using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ponto : MonoBehaviour
{
    public static int pontos;
    public Text pontoTxt;

    // Start is called before the first frame update
    void Start()
    {
        pontos = 0;

    }

    // Update is called once per frame
    void Update()
    {
        pontoTxt.text = pontos.ToString();

    }
}
