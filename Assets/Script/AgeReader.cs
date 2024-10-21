using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgeReader : MonoBehaviour
{
    private int currentAge= 21;
    [SerializeField] private int years = 1;
    

    // Start is called before the first frame update
    void Start()
    {
        currentAge = currentAge + years;
        Debug.Log("Arlyn is " + currentAge + " years old in " + years + " years");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
