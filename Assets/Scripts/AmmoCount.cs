using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AmmoCount : MonoBehaviour
{
    public TextMeshProUGUI ammunitionText;
    public TextMeshProUGUI magText;

    public static AmmoCount occurence;

    private void Awake()
    {
        occurence = this;

    }
    public void UpdateAmmoText(int presentAmmounition)
    {
        ammunitionText.text = "Ammo." + presentAmmounition;
    }

    public void UpdateMagText(int mag)
    {
        magText.text = "Magazines." + mag;
    }
}
