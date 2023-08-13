using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;

public class MouseCounter : MonoBehaviour
{
    public GameObject[] Mouses = new GameObject[3];
    public int numberMouse=1;
   
    
    [ContextMenu("Mouse")]
    public void AddMouse()
    {
        if (numberMouse <= Mouses.Length)
        {
            for (int i = 0; i < numberMouse; i++)
            {
                Mouses[i].SetActive(true);
                      if (i == 2)
                    Eventer.Lost(3);
            }
            numberMouse++;
        }
    }
}

