using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GestorDeColor : MonoBehaviour
{
   [SerializeField] private Transform circuloRotacionTransf;
   [SerializeField] private Image [] imagenACambiarDeColor;
   [SerializeField] private Image morado, amarillo, verde, rojo, azul, azulcielo;
   private float rotacion;
   
   private void Update()
   {
      rotacion = circuloRotacionTransf.localEulerAngles.z;
      //Debug.Log("Rotacion: " + rotacion.ToString());
      
      if (rotacion >= 327 || rotacion < 30)
      {
         CambiarColor(amarillo);
      }
      else if (rotacion > 274 && rotacion < 327)
      {
         CambiarColor(morado);
      }
      else if (rotacion > 217 && rotacion < 274)
      {
         CambiarColor(azul);
      }
      else if (rotacion > 148 && rotacion < 217)
      {
         CambiarColor(rojo);
      }
      else if (rotacion > 91 && rotacion < 148)
      {
         CambiarColor(azulcielo);
      }
      else if (rotacion > 30 && rotacion < 91)
      {
         CambiarColor(verde);
      }
      
   }

   void CambiarColor(Image imagen)
   {
      for (int i = 0; i < imagenACambiarDeColor.Length; i++)
      {
         imagenACambiarDeColor[i].color = imagen.color;
      }
   }
}
