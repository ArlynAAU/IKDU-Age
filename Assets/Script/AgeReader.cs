using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgeReader : MonoBehaviour
{
    [SerializeField] private int years = 3;
    private void AddAge(int currentAge)
    {
        currentAge++;
        Debug.Log("Arlyn is " + currentAge + " years old.");
    }

    void Start()
    {
        for (int i = 0; i < years; i++)
        {
            AddAge(21+i);
        }
    }
}
