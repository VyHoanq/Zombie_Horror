using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objectives2 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            //complete objectives
            ObjectivesComplete.occurrence.GetObjectivesDone(true, true, false, false);
            Destroy(gameObject,2f);
        }
    }
}
