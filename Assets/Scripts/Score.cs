using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public Transform player;
    public Text scoreText;
    public float score;
    public float maxScore;

    private void Update()
    {

        setMaxScore(player.position.y + 3f);

        scoreText.text = "Score : " + maxScore.ToString("0");

    }

    public void setMaxScore(float x)
    {

        if (x > maxScore) {

            maxScore = x;

        }

    }

}
