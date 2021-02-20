using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeControllerUI : MonoBehaviour
{
    public static LifeControllerUI instance;

    [SerializeField]
    private Image[] hearts;
    [SerializeField]
    private Sprite fullHeart, emptyHeart;
    
    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        
    }


    public void UpdateLifeUI()
    {
        for(int i = 0; i < hearts.Length; i++)
        {
            if(i < LifeController.instance.Life)
            {
                hearts[i].sprite = fullHeart;
            } else
            {
                hearts[i].sprite = emptyHeart;
            }
        }
    }

}
