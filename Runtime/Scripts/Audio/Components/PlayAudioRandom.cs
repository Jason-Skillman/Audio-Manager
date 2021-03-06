﻿using UnityEngine;

namespace Audio.Components {
	public class PlayAudioRandom : MonoBehaviour {
		
		[SerializeField]
		private AudioClip[] audioClips = default;
		[SerializeField]
		private AudioConfiguration audioConfig = default;
		[SerializeField]
		private bool use3DPosition = default;

		public void Play() {
			int randomIndex = Random.Range(0, audioClips.Length);
			AudioClip audioClip = audioClips[randomIndex];
			
			Vector3 position = Vector3.zero;
			if(use3DPosition)
				position = transform.position;
			
			if(audioClip)
				AudioManager.Instance.PlayAudio(audioClip, position, audioConfig);
		}
		
	}
}