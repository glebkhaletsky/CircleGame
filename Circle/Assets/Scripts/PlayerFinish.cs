using UnityEngine;

public class PlayerFinish : MonoBehaviour
{
    //Vector2 StartPos;
    Vector2 EndPos;
    float step;
    float progress;
    int level;
    void Start()
    {
        //StartPos = new Vector2(36.17f, 1);
        EndPos = new Vector2(37.7f, 0.99f);
        step = 0.05f;
    }

    void FixedUpdate()
    {
        if (FindObjectOfType<GameManager>().GameEnd == true)
        {
            transform.position = Vector2.Lerp(transform.position, EndPos, progress);
            progress += step;
        }
    }
}
