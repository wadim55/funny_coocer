using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Food : MonoBehaviour
{
  public int foodNumber;

  private void Start()
  {
    foodNumber = Random.Range(0, 5);
  }

  private void OnEnable()
  {
    Eventer.PovarPosition += FoodPosition;
  }

  private void OnDisable()
  {
    Eventer.PovarPosition -= FoodPosition;
  }

  private void FoodPosition(int a)
  {
    if (foodNumber == a)
    {
      print("Up!");
    }
  }
  
}
