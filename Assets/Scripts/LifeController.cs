using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LifeController : MonoBehaviour
{

    public static LifeController instance;

    [SerializeField]
    private int life;

    public int Life { get { return this.life; } }

    [SerializeField]
    private int maxLife;

    public GameObject gameOver;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        life = maxLife;
    }

    public void DecrementLife(int value)
    {
        life -= value;

        if(life <= 0)
        {
            life = 0;
            instance.ShowGameOver();
        }

        LifeControllerUI.instance.UpdateLifeUI();

    }

    public void IncrementLife (int value)
    {
        life += value;

        if (life >= maxLife)
        {
            life = maxLife;
        }

        LifeControllerUI.instance.UpdateLifeUI();
    }

    public void ShowGameOver()
    {
        gameOver.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

}
