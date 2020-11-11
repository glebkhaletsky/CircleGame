using UnityEngine;


public class Diamond : MonoBehaviour
{
  
    void OnTriggerEnter2D(Collider2D Collision)
    {
        if (Collision.tag == "Player")
        {
            FindObjectOfType<ScoreScript>().IncrementDiamond(1);
            FindObjectOfType<ScorePointCanvas>().DiamondHit(Collision.transform.position);
            Destroy(gameObject);
        }
    }
}
