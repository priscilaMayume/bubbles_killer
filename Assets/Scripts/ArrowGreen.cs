using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGreen : MonoBehaviour
{
    public float speed;
    private Rigidbody2D _rb2dBody;

    void Start()
    {
        _rb2dBody = GetComponent<Rigidbody2D>();
    }



    private void FixedUpdate()
    {
        _rb2dBody.MovePosition(_rb2dBody.position + (new Vector2(speed * Time.deltaTime, 0)));
    }

    void OnBecameInvisible()
    {
     
        Destroy(this.gameObject);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bubble"))
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
        
        if (other.CompareTag("BubbleHeart"))
        {
            LifeController.instance.IncrementLife(1);
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }

}
