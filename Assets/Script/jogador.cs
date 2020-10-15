using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class jogador : MonoBehaviour
{
    private Rigidbody2D playerRb;
    public float velocidade;
    private SpriteRenderer playerSprite;
    public bool flipX;
    public GameObject pneuPrefab;
    public float tempocria;
    private Vector3 posicaopneu;
    private bool escolha = true;
    public GameObject baldePrefab;
    private Vector3 posicaobalde;
    public float tempojogo;
    public static float tempojogoFrase;
    public Text tempodojogo;
    
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        playerSprite = GetComponent<SpriteRenderer>();
        posicaopneu = pneuPrefab.transform.position;
        posicaobalde = baldePrefab.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            velocidade *= -1;
            flipX = !flipX;
            playerSprite.flipX = flipX;
        }
        playerRb.velocity = new Vector2(velocidade,playerRb.velocity.y);

        //criar os bonus
        tempocria += Time.deltaTime;

        tempojogo += Time.deltaTime;
        tempodojogo.text = tempojogo.ToString();
        
        if (tempojogo > 300.0)
        {
            tempojogoFrase = tempojogo;
            SceneManager.LoadScene("fimjogo");
        }

        if (tempocria>10)
        {
            escolha = !escolha;
            if (escolha == true)
            { 
                Instantiate(pneuPrefab, posicaopneu, transform.localRotation);
                tempocria = 0.0f;
            }else
            {
                Instantiate(baldePrefab, posicaobalde, transform.localRotation);
                tempocria = 0.0f;
            }
        }

    }

    void OnCollisionEnter2D(Collision2D colisao)
    {
        if (colisao.gameObject.tag == "mosquitoperigoso")
        {
            SceneManager.LoadScene("fimjogo");
        }
    }

    private void OnTriggerEnter2D(Collider2D colisao)
    {
        if (colisao.gameObject.tag == "mosquitoperigoso")
        {
            SceneManager.LoadScene("fimjogo");
        } 
        
    }
}
