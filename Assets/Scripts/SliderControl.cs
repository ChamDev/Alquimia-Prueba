using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SliderControl : MonoBehaviour
{
   private Slider _slider;
   [SerializeField] private Text textoBlanco, textoVerde, textoAzul, textoMultiplicadorVisual;
   [SerializeField] private InputField _inputField;

   private int numeroBlanco = 775, multiplicadorBlanco = 50, numeroVerde = 667, multiplicadorVerde = 240, numeroAzul = 567, multiplicadorAzul = 50;
   private float valorSlider;
   private void Awake()
   {
      _slider = GetComponent<Slider>();
   }

   private void Start()
   {
      _slider.onValueChanged.AddListener (delegate {OnValueCheck ();});
   }


   void OnValueCheck()
   {
      valorSlider = Mathf.RoundToInt(_slider.value);

      _inputField.text = valorSlider.ToString();
      
      textoBlanco.text = numeroBlanco.ToString() + "k" + "/" + (multiplicadorBlanco * valorSlider).ToString();
      
      textoVerde.text = numeroVerde.ToString() + "k" + "/" + (multiplicadorVerde * valorSlider).ToString();
      textoAzul.text = numeroAzul.ToString() + "k" + "/" + (multiplicadorAzul * valorSlider).ToString();
      
      
      
      
      textoMultiplicadorVisual.text = "X" + valorSlider.ToString();
   }

   public void BtnMas()
   {
      _slider.value += 1;
   }
   
   public void BtnMenos()
   {
      _slider.value -= 1;
   }

   public void InputNumber()
   {
      _slider.value =  int.Parse(_inputField.text);
   }
}
