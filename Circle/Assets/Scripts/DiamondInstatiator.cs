
using UnityEngine;


public class DiamondInstatiator : MonoBehaviour
{
    Transform[] childTransform;
    public GameObject Diamond;
  
    void Awake()
    {
        childTransform = new Transform[transform.childCount];
        for (int i=0; i < childTransform.Length; i++)
        {
            childTransform[i] = transform.GetChild(i);
        }
        InstatiateDiamond();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void InstatiateDiamond()
    {
        for(int i=0; i< childTransform.Length; i++)
        {
            if (Random.value > 0.4f)
            {
                Instantiate(Diamond, childTransform[i].position, Quaternion.identity);
            }
        }
    }
}
