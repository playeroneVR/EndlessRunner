using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    [SerializeField] Text distancedTraveled;
    [SerializeField] GameObject gameOverScreen;
    [SerializeField] Player player;
    [SerializeField] Text coinsCollected;


    public void ShowGameOverScreen()
    {
        gameOverScreen.SetActive(true);
        //distancedTraveled.text = player.distancedTraveled.ToString();
        float distancedRounded = Mathf.Ceil(player.distancedTraveled);
        distancedTraveled.text = "" + distancedRounded;
        coinsCollected.text = "" + player.collectedCoins;
    }

    public void GameRestart()
    {
        Debug.Log("Restart the game");
        SceneManager.LoadScene("EndlessRunner");
    }
}
