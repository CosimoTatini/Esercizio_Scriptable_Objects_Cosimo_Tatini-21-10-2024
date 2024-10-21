using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HealthUi : MonoBehaviour
{
    public EntityStats entityStats;
    public Slider healthslider;
    public TextMeshProUGUI charactertext;

    private void Start()
    {
        charactertext.text = entityStats.playername.Value;
    }

    private void Update()
    {
        if (  entityStats != null && healthslider!=null)
        {
            healthslider.value = entityStats.hp.Value / entityStats._maxHp.Value;
        }
    }
    
}
