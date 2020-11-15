using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField] int levelNumber;

    public GameObject level1;
    public GameObject level2;
    public GameObject level3;
    public GameObject level4;


    void Awake()
    {
        if (!PlayerPrefs.HasKey("LevelGame"))
        {
            PlayerPrefs.SetInt("LevelGame", 1);
        }
        levelNumber = PlayerPrefs.GetInt("LevelGame");
    }        
    void Start()
    {
        switch (levelNumber)
        {
            case (1):
                level1.SetActive(true);
                break;
            case (2):
                level2.SetActive(true);
                break;
            case (3):
                level3.SetActive(true);
                break;
            case (4):
                level4.SetActive(true);
                break;
            case (5):
                level4.SetActive(true);
                break;
            case (6):
                level1.SetActive(true);
                break;
            case (7):
                level2.SetActive(true);
                break;
            case (8):
                level3.SetActive(true);
                break;
            case (9):
                level4.SetActive(true);
                break;
            case (10):
                level4.SetActive(true);
                break;
        }
    }

}
