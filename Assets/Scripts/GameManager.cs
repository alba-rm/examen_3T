using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public bool isGameOver;

    public Text coinText;
    int coins;

    public List<GameObject> enemiesInScreen = new List<GameObject>();


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            KillAllEnemies();
        }
    }

    public void GameOver()
    {
        isGameOver = true;
    }

    public void AddCoin()
    {
        coins++;
        coinText.text = coins.ToString();
    }
    
    void KillAllEnemies()
    {
        for (int i = 0; i < enemiesInScreen.Count; i++)
        {
            Destroy(enemiesInScreen[i]);
        }
    }
}
