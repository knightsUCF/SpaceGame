
class Score : MonoBehaviour
{

  public TextMeshProUGUI scoreText;
  
  
    public void AddScore(int newScoreValue)
    {
        State.SCORE += newScoreValue;
        UpdateScore();
    }

    void UpdateScore()
    {
        scoreText.text = "Score: " + State.SCORE;
    }


}

