using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Rendering.Universal;


public class magicbookofwonders : MonoBehaviour

{
    public magicstats magicdatafile; // Assign in Inspector or find in code

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Start()
    {
        if (magicdatafile != null)
        {
            Debug.Log("Value from stats: " + magicdatafile.mana);
        }
        else if (magicdatafile == null)
        {
            Debug.Log("magicdatafile is not found");
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1)) {
            if (magicdatafile.spell1Acess == true) // CASTING
            {
                magicdatafile.mana -= -10;
                Debug.Log("-10 mana / " + magicdatafile.mana);



            }
        }
        
        
            
                

        
    }
}
