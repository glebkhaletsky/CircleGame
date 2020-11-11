using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rgdb; 
    Vector2 JumpForce;
    Vector2 currentVelocity;
    GameManager gameManager;
    ScoreScript score;
    public bool final;
   
    void Start()
    {
        rgdb = GetComponent<Rigidbody2D>();
        rgdb.gravityScale = 0;
        JumpForce = new Vector2(20, 85);
        gameManager = FindObjectOfType<GameManager>();
        score = FindObjectOfType<ScoreScript>();


    }

    void OnTriggerEnter2D(Collider2D Collision)
    {
        if (Collision.tag == "Finish")
        {
            final = true;
            rgdb.bodyType = RigidbodyType2D.Kinematic;
            return;

        }
    }
    void Update()
    {
        if(gameManager.GameOver) 
        {
            if (final == true)
            {
                rgdb.bodyType = RigidbodyType2D.Kinematic;
                return;
            }
            else
            {
                rgdb.bodyType = RigidbodyType2D.Static;
                return;
            }
        }

        
        if (Input.GetMouseButtonDown(0))
        {
            if (rgdb.gravityScale != 1)
            {
                rgdb.gravityScale = 1;
            }
            rgdb.AddForce(JumpForce);
            SpeedControl();
            score.IncrementScore(1);
        }
        
    }

    void SpeedControl()
    {
        currentVelocity = rgdb.velocity;
        currentVelocity.x = Mathf.Clamp(currentVelocity.x, 2, 2);
        currentVelocity.y = Mathf.Clamp(currentVelocity.y, 2, 2);
        rgdb.velocity = currentVelocity;

    }
}
