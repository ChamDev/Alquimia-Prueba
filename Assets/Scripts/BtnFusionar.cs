using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BtnFusionar : MonoBehaviour
{
   [SerializeField] private GameObject menuCantidad, menuParticulas;
   private Button _button;

   private void Awake()
   {
      _button = gameObject.GetComponent<Button>();
   }

   private void Start()
   {
      _button.onClick.AddListener(ChangeMenus);
   }

   private void Update()
   {
      if (menuCantidad.activeSelf)
      {
         _button.enabled = true;
      }
      else
      {
         _button.enabled = false;
      }
   }

   void ChangeMenus()
   {
      menuCantidad.SetActive(false);
      menuParticulas.SetActive(true);
   }
}
