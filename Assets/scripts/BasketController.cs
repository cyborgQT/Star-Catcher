using System.Collections;
using System.Collections.Generic;
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
                initial.x = initial.x + 1.0f;
            }
            else if ((Input.GetKey(KeyCode.LeftArrow)))
            {
                initial.x = initial.x - 1.0f;
            }
            basket.MovePosition(initial);
        }
    }
    public void ToggleControl(bool toggle)
    {
        canControl = toggle;
    }
}
