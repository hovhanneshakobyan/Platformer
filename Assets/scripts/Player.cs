using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public int health;
    public int score;
    public int keys;
    public Text keyText;
    public Text healthText;
    public Text moneyText;

    void Start()
    {
        keys = 0;
        score = 0;
        health = 100;
        
    }

    // Update is called once per frame
    void Update()
    {
        keyText.text = "Keys: " + keys.ToString();
        healthText.text = "Health: " + health.ToString();
        moneyText.text = "Money: " + score.ToString();

        if(health <= 0)
        {
            SceneManager.LoadScene("Lose");
        }
    }
}
