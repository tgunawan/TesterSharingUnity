using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private float score;
    public GameObject gameOverScreen;
    private bool gameOver = false;
    public Text scoreText;
    public Text scoreText2;
    public static GameManager instance;
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {   
        if (gameOver == false)
        {
            score += Time.deltaTime;
            scoreText.text = "Score :"+ Mathf.Round(score);
            scoreText2.text = "Score :" + Mathf.Round(score);
        }
    }

    public void GameOverScreen()
    {
        gameOver = true;
        gameOverScreen.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene("GameScene");
    }
}
