using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archer : MonoBehaviour
{

    [SerializeField]
    private float speed = 8;
    

    private Rigidbody2D rb2dBody;
    
    public GameObject prefabArrowGreen;
    
    private float v;

    [SerializeField]
    private int vida = 5;

    [SerializeField]
    private float frameRate;
    [SerializeField]
    private float maxTime = 1;


    void Start()
    {
        rb2dBody = GetComponent<Rigidbody2D>();
        
    }

    
    void Update()
    {
       v = Input.GetAxisRaw("Vertical");

        frameRate += Time.deltaTime;

        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            if (frameRate >= maxTime)
            {
                //instanciar o laser, informando o prefab, a posicao e a rotação. A posição recebe uma soma de +1 no eixo y para evitar colisao
                Instantiate(prefabArrowGreen, transform.position + new Vector3(1, 0, 0), Quaternion.identity);
                //_rb2dBody.gravityScale = 1;
                frameRate = 0;
            }
        }


    }

    void FixedUpdate()
    {
        rb2dBody.MovePosition(rb2dBody.position + (new Vector2(0, v) * speed*Time.deltaTime));
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bubble"))
        {
            vida--;
        }
    }
}
