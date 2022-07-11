﻿using UnityEngine;

public class DamageDealer
{
    public void DamageTarget(Transform target, int damageToDeal)
    {
        var damageable = target.GetComponent<IDamageable>();
        if (damageable == null) { return; }
        damageable.DealDamage(damageToDeal);
    }
}