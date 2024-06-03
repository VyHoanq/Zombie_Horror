using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using TMPro;
using UnityEngine;

public class ObjectivesComplete : MonoBehaviour
{
    [Header("Objectives to Complete")]
    public TextMeshProUGUI objectives1;
    public TextMeshProUGUI objectives2;
    public TextMeshProUGUI objectives3;
    public TextMeshProUGUI objectives4;

    public static ObjectivesComplete occurrence;

    private void Awake()
    {
        occurrence = this;
    }
    public void GetObjectivesDone(bool obj1, bool obj2, bool obj3, bool obj4)
    {
        if (obj1 == true)
        {
            objectives1.text = "01. Completed";
            objectives1.color = Color.green;
        }
        else
        {
            objectives1.text = "01. Find the wenpons";
            objectives1.color = Color.white;
        }

        if (obj2 == true)
        {
            objectives2.text = "02. Completed";
            objectives2.color = Color.green;
        }
        else
        {
            objectives2.text = "02. The survivor in church";
            objectives2.color = Color.white;
        }

        if (obj3 == true)
        {
            objectives3.text = "03. Completed";
            objectives3.color = Color.green;
        }
        else
        {
            objectives3.text = "03. Find vehicle";
            objectives3.color = Color.white;
        }
        if (obj4 == true)
        {
            objectives4.text = "04. Completed";
            objectives4.color = Color.green;
        }
        else
        {
            objectives4.text = "04. Get all villagers into vehicle";
            objectives4.color = Color.white;
        }
    }
}
