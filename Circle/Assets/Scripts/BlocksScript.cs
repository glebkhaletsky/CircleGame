using UnityEngine;

public class BlocksScript : MonoBehaviour
{

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Debug.Log("hit by player");
            FindObjectOfType<GameManager>().GameOver = true;

        }
    }
}
