using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#pragma warning disable 0649 
public class SwipeMenu : MonoBehaviour
{

    [SerializeField] private Transform [] imagenARotar;

    [SerializeField] private float sensibilidadCursor = 0.1f, sensibilidadMobile = 1f;

    [SerializeField] private MenusManager _menusManager;
    //Swipe Menu
    Vector2 firstPressPos;
    Vector2 secondPressPos;
    Vector2 currentSwipe;

    private float rotacion;
    private void Update()
    {
        Swipe();
    }

    public void Swipe()
    {
        //Usando input touch
        if (Input.touches.Length > 0)
        {
            Touch t = Input.GetTouch(0);
            if (t.phase == TouchPhase.Began)
            {
                //Guarda el punto inicial
                firstPressPos = new Vector2(t.position.x, t.position.y);
            }
            if (t.phase == TouchPhase.Moved)
            {
                ////Guarda el punto final
                secondPressPos = new Vector2(t.position.x, t.position.y);

                //Creando el vector entre 2 puntos
                currentSwipe = new Vector3(secondPressPos.x - firstPressPos.x, secondPressPos.y - firstPressPos.y);

                //normalizando el vector
                currentSwipe.Normalize();
                
                //arrastre a la izquierda
                if (currentSwipe.x < 0 && currentSwipe.y > -0.5f && currentSwipe.y < 0.5f)
                {
                    LeftSwipe(false);
                   
                }
                
                //arrastre a la derecha
                if (currentSwipe.x > 0 && currentSwipe.y > -0.5f && currentSwipe.y < 0.5f)
                {
                    RightSwipe(false);
                   
                }
            }
        }
        
        //Usando el Cursor
        if (Input.GetMouseButtonDown(0))
        {
            firstPressPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        }
        
        if (Input.GetMouseButton(0))
        {
           
            secondPressPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            
           
            currentSwipe = new Vector2(secondPressPos.x - firstPressPos.x, secondPressPos.y - firstPressPos.y);
            
            currentSwipe.Normalize();
            
            if (currentSwipe.x < 0 && currentSwipe.y > -0.5f && currentSwipe.y < 0.5f)
            {
                LeftSwipe(true);
            }
            
            if (currentSwipe.x > 0 && currentSwipe.y > -0.5f && currentSwipe.y < 0.5f)
            {
                RightSwipe(true);
            }
        }
    }

    public void LeftSwipe(bool usandoCursor)
    {
        if (_menusManager.Index > -1 && _menusManager.Index < imagenARotar.Length - 1)
        {
            if (usandoCursor)
            {
                imagenARotar[_menusManager.Index].Rotate(0, 0, -sensibilidadCursor);
            }
            else
            {
                imagenARotar[_menusManager.Index].Rotate(0, 0, -sensibilidadMobile);
            }
        }
    }

    public void RightSwipe(bool usandoCursor)
    {
        if (_menusManager.Index > -1 && _menusManager.Index < imagenARotar.Length - 1)
        {
            if (usandoCursor)
            {
                imagenARotar[_menusManager.Index].Rotate(0, 0, sensibilidadCursor);
            }
            else
            {
                imagenARotar[_menusManager.Index].Rotate(0, 0, sensibilidadMobile);
            }
        }
        
    }
}
