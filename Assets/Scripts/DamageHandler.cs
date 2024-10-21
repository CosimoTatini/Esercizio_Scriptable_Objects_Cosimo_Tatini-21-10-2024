using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageHandler : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        EntityStats entity = collision.gameObject.GetComponent<EntityStats>();
        EntityStats thisentity = GetComponent<EntityStats>();

        if(entity !=null)
        {
            thisentity.TakeDamage(entity.damage.Value);
            entity.TakeDamage(entity.damage.Value);

            Debug.Log("Damage taken!");
        }
    }
}
