using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
#pragma warning disable 0649 
[RequireComponent(typeof(Button))]
public class BtnShowHideCanvas : MonoBehaviour
{
    Button button;
    [SerializeField] GameObject [] objectsToHide;
    [SerializeField] GameObject objectsToShow;
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(ChangeShowAndHide);
    }

    void ChangeShowAndHide()
    {
        if (objectsToShow != null)
        {
            objectsToShow.SetActive(true);
        }

        for (int i = 0; i < objectsToHide.Length; i++)
        {
            objectsToHide[i].SetActive(false);
        }
       
    }
}
