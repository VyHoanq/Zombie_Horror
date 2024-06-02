using System.Collections;
using System.Collections.Generic;
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
        if(obj1 == true)
        {
            objectives1.text = "01. Complete";
            objectives1.color = Color.green;
        }
        else
        {
            objectives1.text = "01. FIND THE RIFLE";
            objectives1.color = Color.white;
        }

        if (obj2 == true)
        {
            objectives1.text = "02. Complete";
            objectives1.color = Color.green;
        }
        else
        {
            objectives1.text = "02. LOCATION THE VILLAGERS";
            objectives1.color = Color.white;
        }

        if (obj3 == true)
        {
            objectives1.text = "03. Complete";
            objectives1.color = Color.green;
        }
        else
        {
            objectives1.text = "03. Find vehicle";
            objectives1.color = Color.white;
        }

        if (obj4 == true)
        {
            objectives1.text = "04. Complete";
            objectives1.color = Color.green;
        }
        else
        {
            objectives1.text = "04. Get all villagers into vehicle";
            objectives1.color = Color.white;
        }
    }
}
