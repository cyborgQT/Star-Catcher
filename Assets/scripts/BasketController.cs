using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using UnityEngine;

public class BasketController : MonoBehaviour
{
    Rigidbody2D basket;
    Vector2 initial;
    private bool canControl; 
    // Start is called before the first frame update
    void Start()
    {
        basket = GetComponent<Rigidbody2D>();
        initial = basket.transform.position;
        canControl = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (canControl)
        {
            if ((Input.GetKey(KeyCode.RightArrow)))
            {
                initial.x = initial.x + 0.10f;
                print("Right");
            }
            else if ((Input.GetKey(KeyCode.LeftArrow)))
            {
                initial.x = initial.x - 0.10f;
            }
            basket.MovePosition(initial);
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collision.gameObject.name == "Barrier")
        {
            //If the GameObject's name matches the one you suggest, output this message in the console
            print("We touchin");
        }
    }
        public void ToggleControl(bool toggle)
    {
        canControl = toggle;
    }
}
