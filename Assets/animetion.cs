using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animetion : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Vector3 velocity = new Vector3(0, 0, 0.02f);

        }
    }
}
