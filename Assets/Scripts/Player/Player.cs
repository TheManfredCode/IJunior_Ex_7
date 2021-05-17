using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private int _maxHealth;

    private int _currentHealth;
    private int _money = 0;

    public event UnityAction<int> MoneyChanged;
    public event UnityAction<int> HealthChanged;
    public event UnityAction Died;

    private void Start()
    {
        _currentHealth = _maxHealth;

        HealthChanged?.Invoke(_currentHealth);
        MoneyChanged?.Invoke(_money);
    }

    public void CollectCoin()
    {
        _money++;
        MoneyChanged?.Invoke(_money);
    }

    public void TakeDamage(int damage)
    {
        _currentHealth -= damage;
        HealthChanged?.Invoke(_currentHealth);

        if (_currentHealth <= 0)
            Died?.Invoke();
    }
}
