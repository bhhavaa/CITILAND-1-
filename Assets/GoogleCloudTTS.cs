using Google.Cloud.TextToSpeech.V1;
using System;
using System.IO;
using UnityEngine;
using Google.Apis.Auth.OAuth2;
using Grpc.Core;
using Google.Apis.Auth; 
using Grpc.Auth;
using Google.Api.Gax.Grpc.Rest;



public class TextToSpeechManager : MonoBehaviour
{
    public TextToSpeechClient client;
    // public TextToSpeechClient client = new TextToSpeechClientBuilder
    //     {
    //         GrpcAdapter = RestGrpcAdapter.Default
    //     }.Build();
    
    void Start()
    {
        try
        {
            // Use the default gRPC adapter
            client = new TextToSpeechClientBuilder().Build();
        }
        catch (Exception ex)
        {
            Debug.LogError("Failed to create TextToSpeechClient: " + ex.Message);
            Debug.LogError("- Exception Type: " + ex.GetType().FullName);
            Debug.LogError("- Exception Message: " + ex.Message);
            Debug.LogError("- Stack Trace: " + ex.StackTrace);

        }

        // // Use the default gRPC adapter
        // client = new TextToSpeechClientBuilder().Build();

        

        // // // Provide the path to your JSON credentials file
        // string keyFilePath = @"C:\Users\WZS21\Desktop\FYP_P4_Khairul\FSP_CITILand_FYP2023P3_UnityMultiPlayer\jsonfiles\credentials.json";

        // // // Authenticate with the credentials
        // // var credentials = GoogleCredential.FromFile(keyFilePath);

        // // // Create the client with the credentials (adjust for your library version)
        // // // client = TextToSpeechClient.Create(credentials); // Try direct approach first
        // // // If direct approach fails, use alternatives:
        // // // client = new TextToSpeechClientBuilder.WithCredentials(credentials).Build();
        // // // Or:
        // // var channelCredentials = credentials.ToChannelCredentials();
        // // client = new TextToSpeechClient(channelCredentials);



        // var credentials = GoogleCredential.FromFile(keyFilePath);

        // // Create the client with credentials
        // client = new TextToSpeechClient(credentials); // Assuming a compatible constructor

        // string keyFilePath = @"C:\Users\WZS21\Desktop\FYP_P4_Khairul\FSP_CITILAND_FYP2023P3_UnityMultiPlayer\jsonfiles\credentials.json";

        // // Load credentials from the JSON file
        // var credentials = GoogleCredential.FromFile(keyFilePath);

        // // Create the client using the loaded credentials
        // client = new TextToSpeechClientBuilder().WithCredentials(credentials).Build();    



        // // Provide the path to your JSON credentials file
        // string keyFilePath = @"C:\Users\WZS21\Desktop\FYP_P4_Khairul\FSP_CITILand_FYP2023P3_UnityMultiPlayer\jsonfiles\credentials.json";   //  1

        // client = new TextToSpeechClientBuilder().Build(); // Use the default gRPC adapter  ||  2
        // // var client = new TextToSpeechClient("asia-southeast1-a.cloud.google.com:443");

        // AppContext.SetSwitch("System.Net.Http.SocketsHttpHandler.Http2UnencryptedSupport", true);   // Now proceed with creating your gRPC client and making calls  ||  3
    }

    

    public void OnNPCClicked()
    {
        SynthesizeAndPlaySpeech();
    }   


    void SynthesizeAndPlaySpeech()
    {
        try
        {
            string textToSynthesize = "This is a demonstration of the Google Cloud Text-to-Speech API, Welcome to CITI LAND!";

            // Build the voice request
            var voiceSelection = new VoiceSelectionParams
            {
                LanguageCode = "en-SG",
                SsmlGender = SsmlVoiceGender.Male
            };

            // Specify the type of audio file
            var audioConfig = new AudioConfig
            {
                AudioEncoding = AudioEncoding.Mp3
            };

            // Create the SynthesisInput object
            var input = new SynthesisInput
            {
                Text = textToSynthesize
            };

            // Perform the text-to-speech request
            var response = client.SynthesizeSpeech(input, voiceSelection, audioConfig);

            // Write the response to a file in Unity's streamingAssets folder
            string outputPath = @"C:\Users\WZS21\Desktop\FYP_P4_Khairul\FSP_CITILand_FYP2023P3_UnityMultiPlayer\Assets\StreamingAssets\output.mp3";

            using (var output = File.Create(outputPath))
            {
                response.AudioContent.WriteTo(output);
            }

            Debug.Log("Audio content written to file: " + outputPath);

            // Load and play the generated audio (assuming an AudioSource component is attached)
            AudioSource audioSource = GetComponent<AudioSource>();
            audioSource.clip = (AudioClip)Resources.Load("output");
            audioSource.Play();
        }
        catch (Exception ex)
        {
            Debug.LogError("Error during text-to-speech or audio playback:");
            Debug.LogError("- Exception Type: " + ex.GetType().FullName);
            Debug.LogError("- Exception Message: " + ex.Message);
            Debug.LogError("- Stack Trace:");
            Debug.LogError(ex.StackTrace);

            if (ex is Grpc.Core.RpcException rpcException)
            {
                Debug.LogError("- gRPC Status Code: " + rpcException.StatusCode);
                Debug.LogError("- gRPC Status Detail: " + rpcException.Status.Detail);
            }

        }


        // // Text to synthesize
        // string textToSynthesize = "This is a demonstration of the Google Cloud Text-to-Speech API, Welcome to CITI LAND!";
            
        // // Build the voice request
        // var voiceSelection = new VoiceSelectionParams
        // {
        //     LanguageCode = "en-SG",
        //     SsmlGender = SsmlVoiceGender.Male
        // };

        // // Specify the type of audio file
        // var audioConfig = new AudioConfig
        // {
        //     AudioEncoding = AudioEncoding.Mp3
        // };

        // // Create the SynthesisInput object
        // var input = new SynthesisInput
        // {
        //     Text = textToSynthesize
        // };

        // // Perform the text-to-speech request
        // var response = client.SynthesizeSpeech(input, voiceSelection, audioConfig);


        // // Write the response to a file in Unity's streamingAssets folder
        // string outputPath = @"C:\Users\WZS21\Desktop\FYP_P4_Khairul\FSP_CITILand_FYP2023P3_UnityMultiPlayer\Assets\StreamingAssets\output.mp3";

        
        // using (var output = File.Create(outputPath))
        // {
        //     response.AudioContent.WriteTo(output);
        // }

        // Debug.Log("Audio content written to file: " + outputPath);


        // // // Load and play the generated audio (assuming an AudioSource component is attached)
        // AudioSource audioSource = GetComponent<AudioSource>();
        // audioSource.clip = (AudioClip)Resources.Load("output");
        // audioSource.Play();
    }
}



