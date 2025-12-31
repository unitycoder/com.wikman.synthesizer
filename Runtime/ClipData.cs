using UnityEngine;

namespace com.unitycoder.sfxr
{
    public class ClipData
    {
        public AudioClip clip { get; }
        public int seed { get; }
        public EffectType fxType { get; }
        public EffectParameters parameters { get; }

        public ClipData(AudioClip clip, int seed, EffectType fxType, EffectParameters effectParameters)
        {
            this.clip = clip;
            this.seed = seed;
            this.fxType = fxType;
            parameters = effectParameters;
        }
    }
}
