using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    [SerializeField] Transform Player;
    [SerializeField] Transform EndPos;
    [SerializeField] Slider progress;
    int LevelNow;
    int NextLevel;
    public Text LevelNowText;
    public Text NextLevelText;

    float maxDistance;

    void Start()
    {
        maxDistance = getDistance();

        if (!PlayerPrefs.HasKey("LevelGame"))
        {
            PlayerPrefs.SetInt("LevelGame", 1);
        }
        LevelNow = PlayerPrefs.GetInt("LevelGame");
        LevelNowText.text = LevelNow + "";
        NextLevel = LevelNow + 1;
        NextLevelText.text = NextLevel + "";

    }

    void Update()
    {
        if(Player.position.x<=maxDistance && Player.position.x <= EndPos.position.x)
        {
            float distance = 1 - (getDistance() / maxDistance);
            SetProgress(distance);
        }
    }
    float getDistance()
    {
        return Vector2.Distance(Player.position, EndPos.position);
    }
    void SetProgress(float p)
    {
        progress.value = p;
    }
}
