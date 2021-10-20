using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(ParticleSystem))]

public class Enemy : MonoBehaviour
{
    [SerializeField] private AudioSource _destroySound;
    
    private ParticleSystem _particleSystemExplosion;

    private Animator _animator;
    private const string _isDestroy = "isDestroy";

    private void Start()
    {
        _animator = GetComponent<Animator>();
        _particleSystemExplosion = GetComponent<ParticleSystem>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Player player))
        {
            player.AddScore();
            Die();
        }
    }

    private void Die()
    {
        _particleSystemExplosion.Play();
        _animator.SetBool(_isDestroy, true);
        _destroySound.Play();
        Destroy(gameObject, 0.9f);
    }
}