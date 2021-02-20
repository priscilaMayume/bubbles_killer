using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleBlueGenerator : MonoBehaviour
{

    [SerializeField]
    private GameObject prefabBubbleBlue;
    [SerializeField]
    private GameObject prefabBubbleHeart;
    [SerializeField]
    private GameObject prefabBubbleRed;
    [SerializeField]
    private float time;
    [SerializeField]
    private float repeatTime;

    [SerializeField]
    private float timeHeart;
    [SerializeField]
    private float repeatTimeHeart;

    [SerializeField]
    private float timeBubbleRed;
    [SerializeField]
    private float repeatTimeBubbleRed;


    void Start()
    {
        InvokeRepeating("GerarBubbleBlue", time, repeatTime);
        InvokeRepeating("GerarBubbleHeart", timeHeart, repeatTimeHeart);
        InvokeRepeating("GerarBubbleRed", timeBubbleRed, repeatTimeBubbleRed);
    }

    public void GerarBubbleBlue()
    {
        float y = Random.Range(-4f, 4f);
        float x = 13.0f;

        Instantiate(prefabBubbleBlue, new Vector2(x, y), Quaternion.identity);


    }

    public void GerarBubbleHeart()
    {
        float y = Random.Range(-4f, 4f);
        float x = 13.0f;

        Instantiate(prefabBubbleHeart, new Vector2(x, y), Quaternion.identity);


    }

    public void GerarBubbleRed()
    {
        float y = Random.Range(-4f, 4f);
        float x = 13.0f;

        Instantiate(prefabBubbleRed, new Vector2(x, y), Quaternion.identity);


    }
}
