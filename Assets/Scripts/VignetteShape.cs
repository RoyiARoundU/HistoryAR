using UnityEngine;
using System.Collections;
using UnityEngine.InputSystem.Interactions;

public class VignetteShape : MonoBehaviour
{
    [SerializeField] private GameObject imagePrefab;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onImageCreated()
    {
        if (imagePrefab != null)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = imagePrefab.GetComponent<SpriteRenderer>().sprite;
        }
    }
    
}
