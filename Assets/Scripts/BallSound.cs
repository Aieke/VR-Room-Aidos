using UnityEngine;

[RequireComponent(typeof(AudioSource), typeof(Rigidbody))]
public class BallSound : MonoBehaviour
{
    private AudioSource audioSource;
    private Rigidbody rb;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision collision)
    {
        // Play sound on collision
        float volume = CalculateVolumeBasedOnSpeed();
        audioSource.PlayOneShot(audioSource.clip, volume);
    }

    private float CalculateVolumeBasedOnSpeed()
    {
        // Adjust the volume based on the ball's speed
        // You can adjust the scale factor to suit your needs
        float scaleFactor = 0.1f;
        return Mathf.Clamp(rb.velocity.magnitude * scaleFactor, 0.1f, 1f);
    }
}
