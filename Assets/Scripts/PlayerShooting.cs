using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShooting : MonoBehaviour
{
    public GameObject prefab;
    public GameObject shootPoint;
    public ParticleSystem muzzleEffect;
    public AudioSource shootSound;
    public int bulletsAmount;
    public float fireRate;
    [SerializeField] private Animator animator;

    public void OnFire(InputValue value)
    {
        if (animator != null)
        {
            animator.SetBool("Shooting", value.isPressed);
        }

        if (value.isPressed)
        {
            if (fireRate > 0)
            {
                InvokeRepeating("Shoot", fireRate, fireRate);
            }
            else
            {
                Shoot();
            }
        }
        else
        {
            CancelInvoke();
        }
    }

    private void Shoot()
    {
        if (bulletsAmount > 0 && Time.timeScale > 0)
        {
            bulletsAmount--;

            GameObject clone = Instantiate(prefab);

            clone.transform.position = shootPoint.transform.position;
            clone.transform.rotation = shootPoint.transform.rotation;

            muzzleEffect.Play();
            shootSound.Play();
        }
    }

}
