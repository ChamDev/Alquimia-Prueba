using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#pragma warning disable 0649 
public class SwipeMenu : MonoBehaviour
{

    [SerializeField] private Transform imagenARotar;
    
    //Swipe Menu
    Vector2 firstPressPos;
    Vector2 secondPressPos;
    Vector2 currentSwipe;
    

    private void Update()
    {
        Swipe();
    }

    public void Swipe()
    {
        if (Input.touches.Length > 0)
        {
            Touch t = Input.GetTouch(0);
            if (t.phase == TouchPhase.Began)
            {
                //save began touch 2d point
                firstPressPos = new Vector2(t.position.x, t.position.y);
            }
            if (t.phase == TouchPhase.Ended)
            {
                //save ended touch 2d point
                secondPressPos = new Vector2(t.position.x, t.position.y);

                //create vector from the two points
                currentSwipe = new Vector3(secondPressPos.x - firstPressPos.x, secondPressPos.y - firstPressPos.y);

                //normalize the 2d vector
                currentSwipe.Normalize();
                
                //swipe left
                if (currentSwipe.x < 0 && currentSwipe.y > -0.5f && currentSwipe.y < 0.5f)
                {
                    LeftSwipe();
                    //startGameManager.DogSelected = dogSelected;
                }
                //swipe right
                if (currentSwipe.x > 0 && currentSwipe.y > -0.5f && currentSwipe.y < 0.5f)
                {
                    RightSwipe();
                    //startGameManager.DogSelected = dogSelected;
                }
            }
        }
    }

    public void LeftSwipe()
    {
       
    }

    public void RightSwipe()
    {

    }
}
