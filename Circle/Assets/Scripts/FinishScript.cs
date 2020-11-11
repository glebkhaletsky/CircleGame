using UnityEngine;

public class FinishScript : MonoBehaviour
{
      
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Debug.Log("you win!");
            FindObjectOfType<GameManager>().GameEnd=true;
            FindObjectOfType<GameManager>().LevelEnd++;
            PlayerPrefs.SetInt("LevelGame", FindObjectOfType<GameManager>().LevelEnd);
                        
        }
    }
}
