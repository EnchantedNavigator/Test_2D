using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RunnerPlayer : MonoBehaviour
{
    public event UnityAction<int> HealthChanged;
    public event UnityAction Died;
    [SerializeField] private int _health;
    public void Start()
    {
        HealthChanged?.Invoke(_health);
    }
    public void ApplyDamage(int damage)
    {
        _health -= damage;
        HealthChanged?.Invoke(_health);
        if(_health <= 0)
        {
            Die();
        }
    }
    public void Die()
    {
        Died?.Invoke();
    }
}
