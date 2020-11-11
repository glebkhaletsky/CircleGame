using UnityEngine;

public class ScorePointCanvas : MonoBehaviour
{
    Animator animator;
   
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void DiamondHit(Vector2 position)
    {
        position = transform.position;
        animator.SetTrigger("Play");
    }
}
