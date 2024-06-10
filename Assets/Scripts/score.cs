using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class score : MonoBehaviour
{
    public float point = 0;
    public TextMeshProUGUI scorePoint;
    public bool isDead = false;

    void Update()
    {
        scorePoint.text = point.ToString();
    }

    public void addScore() 
    {
        point = point + 1;
        Debug.Log(point);
        Debug.Log(scorePoint.text);
    }

    public float getScore() 
    {
        return point;
    }

    public void setScore(float score)
    {
        point =  score;
    }

    public bool isGameOver() 
    {
        return isDead;
    }

    public void gameOver() 
    {
        isDead = true;
    }
}
