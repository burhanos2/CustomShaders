using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CollectFood : MonoBehaviour
{
    public Action FoodEaten;
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Foods")
        {
            Destroy(other.gameObject);
            FoodEaten?.Invoke();
        }
    }
    
}
