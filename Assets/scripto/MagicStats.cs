using System;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

public class magicstats : MonoBehaviour
{
    public int mana = 100; // ammo
    private int PREV_mana; // comparason setup ammo
    public bool allowCast;

    public bool spell1Acess = true; // gun
        private int spell_1_MinMana = 10;
         private int spell_1_manaRequirement = 10;

    public bool spell2Acess = true; // testicular torsion
      private int spell_2_MinMana = 15;
         private int spell_2_manaRequirement = 15;

    public bool spell3Acess = true; // divorce
         private int spell_3_MinMana = 25;
          private int spell_3_manaRequirement = 25;

    //check mana amount every change & spell access

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PREV_mana = mana; // set old value up
    }

    // Update is called once per frame
    void Update()
    {


        if (mana != PREV_mana) // check 4 change 
        {
            if (mana <= 15)
            {
                allowCast = false;
                Console.WriteLine("CAST NO MANA");
            }

            else
            {
                allowCast = true;
                Console.WriteLine("CAST ALLOWED");
            }
        }
    }
}
