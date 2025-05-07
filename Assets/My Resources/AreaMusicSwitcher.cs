using UnityEngine;

public class AreaMusicSwitcher : MonoBehaviour
{
    public AudioSource musicSource; // assign in Inspector
    public AudioClip defaultMusic;
    
    void Start()
    {
        musicSource.clip = defaultMusic;
        musicSource.loop = true;
        musicSource.Play();
    }

    public void SwitchMusic(AudioClip newClip)
    {
        if (newClip != null && musicSource.clip != newClip)
        {
            musicSource.Stop();
            musicSource.clip = newClip;
            musicSource.Play();
        }
    }
}
