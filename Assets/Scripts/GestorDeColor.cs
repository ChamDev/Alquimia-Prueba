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
      Debug.Log("Rotacion: " + rotacion.ToString());
      if (rotacion < 360 && rotacion > 300)
      {
         CambiarColor(morado);
      }
      /*
      else if (circuloRotacionTransf.rotation.z < -90 && circuloRotacionTransf.rotation.z > -149)
      {
         CambiarColor(azul);
      }
      else if (circuloRotacionTransf.rotation.z < -150 && circuloRotacionTransf.rotation.z > -180)
      {
         CambiarColor(rojo);
      }
      else if (circuloRotacionTransf.rotation.z > 150 && circuloRotacionTransf.rotation.z < 180)
      {
         CambiarColor(azulcielo);
      }
      else if (circuloRotacionTransf.rotation.z > 40 && circuloRotacionTransf.rotation.z < 80)
      {
         CambiarColor(verde);
      }
      else if (circuloRotacionTransf.rotation.z > -25 && circuloRotacionTransf.rotation.z < 25)
      {
         CambiarColor(amarillo);
      }
      */
   }

   void CambiarColor(Image imagen)
   {
      for (int i = 0; i < imagenACambiarDeColor.Length; i++)
      {
         imagenACambiarDeColor[i].color = imagen.color;
      }
   }
}
