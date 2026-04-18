using UnityEngine;

public class TriggerSoundOnBallFall : MonoBehaviour
{
    [Tooltip("SoundFile")]
    public AudioClip bounceSound;

    [Range(0f, 1f)]
    public float volume = 1f; // allows to set volume in inspector (0 to 1)

    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>(); // we need to gain AudioSource component to pass it audio
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
        // not to trigger it when scene is loaded
        audioSource.playOnAwake = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (bounceSound != null)
        {
            audioSource.PlayOneShot(bounceSound, volume);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}