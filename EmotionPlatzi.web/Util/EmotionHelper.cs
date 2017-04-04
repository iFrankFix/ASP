using EmotionPlatzi.web.Models;
using Microsoft.ProjectOxford.Common.Contract;
using Microsoft.ProjectOxford.Emotion;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Collections.ObjectModel;

namespace EmotionPlatzi.web.Util
{
    public class EmotionHelper 
    {
        public EmotionServiceClient emoClient;

        public EmotionHelper(string key)
        {
            emoClient = new EmotionServiceClient(key);
        }

        public async void DetectAndExtractFaces(Stream imageStream)
        {
            Emotion[] emotions =  await emoClient.RecognizeAsync(imageStream);

            var emoPicture = new EmoPicture();
            //emoPicture.Faces = ExtractFaces(emotions,emoPicture);
        }

        //private ObservableCollection<EmoFace> ExtractFaces(Emotion[] emotions, EmoPicture emoPicture)
        //{
        //    foreach (var emotion in emotions)
        //    {

        //    }
        //}
    }
}