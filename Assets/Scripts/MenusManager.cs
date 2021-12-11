using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenusManager : MonoBehaviour
{
    [SerializeField] private GameObject[] menus;

    private int index;

    public int Index => index;

    public void LeftBtn()
    {
        if (index > 0)
        {
            menus[index].SetActive(false);
            index--;
            menus[index].SetActive(true);
        }
    }

    public void RightBtn()
    {
        if (index < menus.Length - 1)
        {
            menus[index].SetActive(false);
            index++;
            menus[index].SetActive(true);
        }
    }
}
