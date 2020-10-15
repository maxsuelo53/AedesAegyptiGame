using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class frases : MonoBehaviour
{
    public Text frase;
    public GameObject refJogador;
    public int escolhe;
    private string[] apareceFrase = new string[5];
    void Start()
    {
        
        apareceFrase[0] = "VOCÊ SE DESCUIDOU E DEIXOU ACUMULAR ÁGUA NO VASO DE FLOR.";
        apareceFrase[1] = "VOCÊ DEIXOU LIXO ESPALHADO E O MOSQUITO PROCRIOU. VOCÊ FOI CONTAMINADO!";
        apareceFrase[2] = "VOCÊ DEIXOU A CAIXA D'ÁGUA ABERTA E ENCONTRAMOS LARVAS DO MOSQUITO.";
        apareceFrase[3] = "A VASILHA DO SEU PET NÃO FOI HIGIENIZADO CORRETAMENTE, HAVIA OVOS DO MOSQUITO LÁ!";
        apareceFrase[4] = "PARABÉNS, VOCÊ FOI UM ÓTIMO AGENTE NO COMBATE AO AEDES!!!";

        if (jogador.tempojogoFrase >= 300.0)
        {
            GetComponent<Text>().color = Color.cyan;
            frase.text = apareceFrase[4];
        }
        else 
        {
            escolhe = Random.Range(0, 4);
            frase.text = apareceFrase[escolhe];
        }




    }

    void Update()
    {
        
    }
}
