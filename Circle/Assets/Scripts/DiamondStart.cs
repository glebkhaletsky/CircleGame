using UnityEngine;
using UnityEngine.UI;

public class DiamondStart : MonoBehaviour
{
    public TMPro.TextMeshProUGUI DiamondText;
    int allDiamond;

    void Start()
    {
        if (!PlayerPrefs.HasKey("Diamond"))
        {
            PlayerPrefs.SetInt("Diamond", 0);
        }
        allDiamond = PlayerPrefs.GetInt("Diamond");
        DiamondText.text = allDiamond.ToString();
    }
}
