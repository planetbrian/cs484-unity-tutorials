using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{
    public int CollectedCoins;
    public int TotalNumberOfCoins;
    public TextMeshProUGUI ScoreText;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.CollectedCoins = 0;
        this.TotalNumberOfCoins = FindObjectsByType<Coin>(FindObjectsSortMode.None).Length;
        Debug.Log("Total number of coins to collect: " + this.TotalNumberOfCoins);

        // extra credit #3
        this.ScoreText = FindAnyObjectByType<TextMeshProUGUI>();
        this.ScoreText.SetText("Coins: " + this.CollectedCoins + " / " + this.TotalNumberOfCoins);
    }

    // Update is called once per frame
    void Update()
    {
        if(this.CollectedCoins >= this.TotalNumberOfCoins)
        {
            Debug.Log("You won!");
            //Debug.Break();

            // extra credit #2
            SceneManager.LoadScene("MenuScene");
        }
    }
    
    public void CoinCollected()
    {
        this.CollectedCoins += 1;
        Debug.Log("Collected " + this.CollectedCoins + " / " + this.TotalNumberOfCoins + " coins.");

        // extra credit #3
        this.ScoreText.SetText("Coins: " + this.CollectedCoins + " / " + this.TotalNumberOfCoins);
    }
}
