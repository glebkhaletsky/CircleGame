using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    int Score=0, Diamond=0;
    public TMPro.TextMeshProUGUI ScoreText;
    public TMPro.TextMeshProUGUI DiamondText;
    public Button Replay;
    public Button Next;
    public void IncrementScore(int value)
    {
        Score += value;
        UpdateDisplay();
    }

    public void IncrementDiamond(int value)
    {
        Diamond += value;
        UpdateDisplay();
    }

    void UpdateDisplay()
    {
        ScoreText.text = "Tap:"+Score.ToString();
        DiamondText.text = Diamond.ToString();
    }

    void Update()
    {
        if (FindObjectOfType<GameManager>().GameOver == true)
        {
            Replay.gameObject.SetActive(true);
        }
        if (FindObjectOfType<GameManager>().GameEnd == true)
        {
            Next.gameObject.SetActive(true);
        }
    }
}
