using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunnerEnemy : MonoBehaviour
{
    [SerializeField] private int _damage;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent(out RunnerPlayer player))
        {
            player.ApplyDamage(_damage);
        }
        Die();
    }
    private void Die()
    {
        gameObject.SetActive(false);
    }
}
