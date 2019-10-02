using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShaderController : MonoBehaviour
{
    [SerializeField]
    private CollectFood foodtrigger;

    [SerializeField]
    private Renderer rend;

    private Material mat;

    private float size;

    [SerializeField]
    private float _minSize, _maxSize, _sizeIncreaseBy, _sizeDecreaseBy;

    [SerializeField] [Tooltip("Time in seconds it takes to lose hunger")]
    private float _timeToDecrease;

    private void Awake()
    {
        mat = rend.material;
        foodtrigger.FoodEaten += OnFoodEaten;
    }

    void OnFoodEaten()
    {
        size++;
        size = Mathf.Clamp(size, _minSize, _maxSize);
        mat.SetFloat("_Amount", size);
    }
}