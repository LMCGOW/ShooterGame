using UnityEngine;
using System.Collections;

public class GenerateBackground : MonoBehaviour
{

    public GameObject background;
    float backgroundSize;

    // Use this for initialization
    void Start()
    {

        backgroundSize = background.renderer.bounds.size.y;

        Debug.Log(backgroundSize);


        for (int i = 0; i < 5; i++)
        {
            Instantiate(background, new Vector2(0, i * backgroundSize), Quaternion.identity);
        }

    }

    // Update is called once per frame
    void Update()
    {

     
        
        
    }
    
}
