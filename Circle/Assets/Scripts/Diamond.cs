using UnityEngine;


public class Diamond : MonoBehaviour
{
    int allDiamond;

    void Start()
    {
        if (!PlayerPrefs.HasKey("Diamond"))
        {
            PlayerPrefs.SetInt("Diamond", 0);
        }
        allDiamond = PlayerPrefs.GetInt("Diamond");
     }
  
    void OnTriggerEnter2D(Collider2D Collision)
    {
        if (Collision.tag == "Player")
        {
            FindObjectOfType<ScoreScript>().IncrementDiamond(1);
            FindObjectOfType<ScorePointCanvas>().DiamondHit(Collision.transform.position);
            allDiamond = allDiamond + 1;
            PlayerPrefs.SetInt("Diamond", allDiamond);
            Destroy(gameObject);
        }
    }
}
