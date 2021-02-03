using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

    float horizontal;
    float vertical;
    float moveLimiter = 0.7f;
    public float runSpeed = 20.0f;

    // Start is called before the first frame update
    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        //geeft een waarde -1 of 1.
        horizontal = Input.GetAxisRaw("Horizontal");//-1 is links
        vertical = Input.GetAxisRaw("Vertical");//-1 is naar beneden
    }

    private void FixedUpdate()
    {
        if (horizontal != 0 && vertical !=0) //kijkt voor diagonaal movement
        {
            horizontal *= moveLimiter;
            vertical *= moveLimiter;
        }
    }
}
