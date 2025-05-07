using UnityEngine;

public class MusicZone : MonoBehaviour
{
    public AudioClip areaMusic; // assign in Inspector

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            FindObjectOfType<AreaMusicSwitcher>().SwitchMusic(areaMusic);
        }
    }
}
