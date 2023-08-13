using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using Unity.VisualScripting;
using UnityEngine;

public class test : MonoBehaviour
{
    public MouseCounter Msc;

    private int numberPovar = 0;
    public GameObject[] Cockers= new GameObject[4];
    

    private void OnEnable()
    {
        Eventer.MyButton += PrintButtonName;
        Eventer.CoockerPos += Coock;
    }
    private void OnDisable()
    {
        Eventer.MyButton -= PrintButtonName;
        Eventer.CoockerPos -= Coock;
    }

    private void PrintButtonName(string name)
    {
        print(name);
    }

   //dgfhdjgfhdjgfjdgf
   
    
    private void Coock(string a)
    {
        if (a == "right_button")
        {
            if (numberPovar < 3)
            {
                numberPovar++;
                for (var i = 0; i < Cockers.LongLength; i++)
                {
                    Cockers[i].SetActive(false);
                }

                Cockers[numberPovar].SetActive(true);
            }
            
        }

        if (a == "left_button")
        {
            if (numberPovar > 0)
            {
                numberPovar--;
                for (var i = 0; i < Cockers.LongLength; i++)
                {
                    Cockers[i].SetActive(false);
                }

                Cockers[numberPovar].SetActive(true);
            }
            
        }

    }
    }

