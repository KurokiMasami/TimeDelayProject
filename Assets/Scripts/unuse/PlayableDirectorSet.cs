using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class PlayableDirectorSet : MonoBehaviour {

    PlayableDirector playableDirector;

    // Use this for initialization
    void Awake ()
     {
        playableDirector = GetComponent<PlayableDirector>();
        playableDirector.playOnAwake = false;
        playableDirector.Stop();
    }

}
