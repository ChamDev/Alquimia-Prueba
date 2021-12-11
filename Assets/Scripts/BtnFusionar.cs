using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BtnFusionar : MonoBehaviour
{
   [SerializeField] private GameObject menuCantidad, menuParticulas;
   [SerializeField] private Transform sphereTransform;
   [SerializeField] private int maximumSize = 3;
   private Vector3 animationVector3;
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
         _button.interactable = true;
      }
      else
      {
         _button.interactable = false;
      }
   }

   void ChangeMenus()
   {
      menuCantidad.SetActive(false);
      menuParticulas.SetActive(true);
      StartCoroutine(SphereAnimation());
   }

   IEnumerator SphereAnimation()
   {
      yield return new WaitForSeconds(2);

      while (sphereTransform.transform.localScale.x < maximumSize)
      {
         animationVector3.x += 0.1f;
         animationVector3.y += 0.1f;
         animationVector3.z += 0.1f;
         
         sphereTransform.transform.localScale = animationVector3;

         yield return new WaitForFixedUpdate();
      }

      yield return null;
   }
}
