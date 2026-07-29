using UnityEngine;
using System;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.InputSystem;





public class Shooting_Intruction : MonoBehaviour
{
    public GameObject textIntruction;
    public GameObject intructionTrigger;

    public Rigidbody2D rb;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        textIntruction.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {   
       

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {   
        if(collision.TryGetComponent(out Player player))
        {
            
            textIntruction.SetActive(true);
            StartCoroutine(GravityIntruction());
   
            
        }
        
    }

    private IEnumerator GravityIntruction()
    {
        
        yield return new WaitForSeconds(5f);
        textIntruction.SetActive(false);
    }
}
