using UnityEngine;

public class GameManager : MonoBehaviour
{

    public bool GameOver;
    public bool GameEnd;
    public int LevelEnd;
    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("LevelGame"))
        {
            PlayerPrefs.SetInt("LevelGame", 1);
        }
        LevelEnd = PlayerPrefs.GetInt("LevelGame");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
