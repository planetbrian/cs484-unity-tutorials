using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int CollectedCoins;
    public int TotalNumberOfCoins;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.CollectedCoins = 0;
        this.TotalNumberOfCoins = FindObjectsByType<Coin>(FindObjectsSortMode.None).Length;
    }

    // Update is called once per frame
    void Update()
    {
        if(this.CollectedCoins >= this.TotalNumberOfCoins)
        {
            SceneManager.LoadScene("MenuScene");
        }
    }

    public void CoinCollected()
    {
        this.CollectedCoins++;
    }
}