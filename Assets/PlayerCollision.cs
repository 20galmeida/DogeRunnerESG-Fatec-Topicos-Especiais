using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    [SerializeField] private AudioSource src;
    [SerializeField] private AudioClip collisionSfx;

    private void Start()
    {
        GameManager.Instance.onPlay.AddListener(ActivatePlayer);
    }

    private void ActivatePlayer()
    {
        gameObject.SetActive(true);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.CompareTag("Obstacle"))
        {
            StartCoroutine(HandleCollision());
        }
    }

    private IEnumerator HandleCollision()
    {
        src.PlayOneShot(collisionSfx, 0.5f);

        yield return new WaitForSeconds(collisionSfx.length);

        gameObject.SetActive(false);
        GameManager.Instance.GameOver();
    }

}
