using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build;
using UnityEngine;

public class ChickenController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject egg;
    private int count;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        count ++;
        if (count >=100)
        {
            Instantiate(egg, transform.position, Quaternion.identity  );
            count = 0;
        }
    }
}
