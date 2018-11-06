using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChrTreeHandler : MonoBehaviour
{
    private Skill[] skillTree = new Skill[3];

    private Skill circuitry;
    private Skill laserOptics;
    private Skill ThermoMechanics;

	// Use this for initialization
	void Start ()
    {
        //initialize circuitry skill
        circuitry.skillName = "Electronic Circuitry";
        circuitry.skillLvl = 8;
        skillTree[0] = circuitry;
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void Augment(float amount, Skill chosenSkill)
    {
        for (int i = 0; i < skillTree.Length; i++)
        {
            if (chosenSkill.skillName == skillTree[i].skillName)
            {
                skillTree[i].skillLvl += amount;
            }
        }
    }
}
