using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(SpriteRenderer))]
public class Player : MonoBehaviour
{
    [SerializeField] private float _health;
    [SerializeField] private HealthBar _healthBar;

    private float _maxHp = 1f;
    private float _oneHeart = 0.33f;

    public event UnityAction Died;

    public float Health => _health;
    public float MaxHealth => _maxHp;

    public void ApplyDamage()
    {
        _health -= _oneHeart;
        
        _healthBar.RefreshHeart();
        if( _health <= 0.1f)
        {
            Die();
        }
    }

    public void HealthPlayer()
    {
        _health += _oneHeart;
        if (_health >= 1)
            _health = 1;

        _healthBar.RefreshHeart();
    }

    public void Die()
    {
        Died?.Invoke();
    }
}