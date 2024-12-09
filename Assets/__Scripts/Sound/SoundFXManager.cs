using UnityEngine;

public class SoundFXManager : MonoBehaviour
{
    public static SoundFXManager Instance;

    [SerializeField] AudioSource soundFXObject;

    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
            return;
        }
        Instance = this;

    }

    public void PlaySoundFXClip(AudioClip audioClip, Transform spawnTransform, float volume)
    {
        AudioSource audiosource = Instantiate(soundFXObject, spawnTransform.position, Quaternion.identity);

        audiosource.clip = audioClip;

        audiosource.volume = volume;

        audiosource.Play();

        float clipLength = audiosource.clip.length;

        Destroy(audiosource.gameObject, clipLength);

    }

    public void PlayRandomSoundFXClip(AudioClip[] audioClip, Transform spawnTransform, float volume)
    {
        int rand = Random.Range(0, audioClip.Length);

        AudioSource audiosource = Instantiate(soundFXObject, spawnTransform.position, Quaternion.identity);

        audiosource.clip = audioClip[rand];

        audiosource.volume = volume;

        audiosource.Play();

        float clipLength = audiosource.clip.length;

        Destroy(audiosource.gameObject, clipLength);

    }
    public void PlayRandomPitchSoundFXClip(AudioClip audioClip, Transform spawnTransform, float volume, float minPitch, float maxPitch)
    {
        float rand = Random.Range(minPitch, maxPitch);

        AudioSource audiosource = Instantiate(soundFXObject, spawnTransform.position, Quaternion.identity);

        audiosource.clip = audioClip;

        audiosource.volume = volume;

        audiosource.pitch = rand;

        audiosource.Play();

        float clipLength = audiosource.clip.length;

        Destroy(audiosource.gameObject, clipLength);
    }
}
