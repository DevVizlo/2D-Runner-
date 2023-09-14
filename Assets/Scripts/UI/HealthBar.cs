using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class HealthBar : MonoBehaviour
{
    [SerializeField] private Image _image;
    [SerializeField] private Player _player;
        
    public void RefreshHeart()
    {
        _image.fillAmount = _player.Health / _player.MaxHealth;
    }
}
