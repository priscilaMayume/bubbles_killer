using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleHeart : MonoBehaviour
{
    [SerializeField]
    private float _speed = 0;
    [SerializeField]
    private Vector2 _direction;

    [SerializeField]
    private float time = 0;

    private Rigidbody2D _rb2dBody;



    void Start()
    {
        _rb2dBody = GetComponent<Rigidbody2D>();

    }

    void Update()
    {

        time += Time.deltaTime;
        if(time <= 1)
        {
            _direction.y = 1;
        } else if(time <= 2)
        {
            _direction.y = -1;
        }
        else
        {
            time = Random.Range(0f, 0.4f);
        }
    }



    void FixedUpdate()
    {
        _rb2dBody.MovePosition(_rb2dBody.position + (_direction * _speed * Time.deltaTime));
    }

    private void OnBecameInvisible()
    {
        Destroy(this.gameObject);

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            //other.GetComponent<LifeController>().DecrementLife(1);
            LifeController.instance.IncrementLife(1);
            Destroy(this.gameObject);

        }
    }
}
