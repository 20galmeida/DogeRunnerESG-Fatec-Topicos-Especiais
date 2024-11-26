using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpSound : MonoBehaviour
{
    public AudioSource src;
    public AudioClip jumpSfx;

    public void Jump()
    {
        src.clip = jumpSfx;
        src.Play();
    }
}
