using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int appleAmount;
    public float remainingTime;
    public TMP_Text timerText;
    public TMP_Text appleText;
    public TMP_Text scoreText;
    public Wheelbarrow wheelbarrow;
    public int score;
    public LevelLoader loader;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (remainingTime > 0)
        {
            remainingTime -= Time.deltaTime;
        }
        else if (remainingTime < 0)
        {
            remainingTime = 0;
            loader.LoadNextLevel("Ending");
        }

        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);
        timerText.text = string.Format("{0}:{1:00}", minutes, seconds);

        appleText.text = wheelbarrow.appleCount + "/10";
        scoreText.text = "" + score;
    }

    public void IncreaseScore(int i)
    {
        score += i;
    }

}
