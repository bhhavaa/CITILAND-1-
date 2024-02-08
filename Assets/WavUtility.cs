using UnityEngine;

public static class WavUtility
{
    public static AudioClip ToAudioClip(byte[] audioData, int offsetSamples, int lengthSamples, int sampleRate, int channels, int bitDepth)
    {
        AudioClip audioClip = AudioClip.Create("GeneratedClip", lengthSamples, channels, sampleRate, false);

        audioClip.SetData(ConvertByteToFloat(audioData, offsetSamples, lengthSamples, bitDepth), 0);

        return audioClip;
    }

    private static float[] ConvertByteToFloat(byte[] audioData, int offsetSamples, int lengthSamples, int bitDepth)
    {
        float[] floatData = new float[lengthSamples];

        int bytesPerSample = bitDepth / 8;
        const float maxSampleValue = 32768f;

        for (int i = 0; i < lengthSamples; i++)
        {
            int byteOffset = (i + offsetSamples) * bytesPerSample;
            float sample = 0f;

            for (int byteIndex = 0; byteIndex < bytesPerSample; byteIndex++)
            {
                sample += audioData[byteOffset + byteIndex] << (byteIndex * 8);
            }

            floatData[i] = sample / maxSampleValue;
        }

        return floatData;
    }
}
