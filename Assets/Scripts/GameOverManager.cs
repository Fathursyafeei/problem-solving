using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverManager : MonoBehaviour
{
    public ScoreController score;
    public SpawerRectangle spawned;
    public GameObject gameOverScreen;
    

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float cScore = score.GetCurrentScore();
        if (cScore < 0)
        {
            SetGameOver();
        }
       
        Debug.Log(cScore);
    }

    void SetGameOver()
    {
        
        Destroy(gameObject);
        spawned.enabled = false;
        gameOverScreen.SetActive(true);
        score.SetCurrentScore();
    }
}
