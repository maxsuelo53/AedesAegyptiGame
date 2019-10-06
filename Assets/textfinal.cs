using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textfinal : MonoBehaviour
{
    public Text textofinal;
    // Start is called before the first frame update
    void Start()
    {
        textofinal.text = ponto.pontos.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
