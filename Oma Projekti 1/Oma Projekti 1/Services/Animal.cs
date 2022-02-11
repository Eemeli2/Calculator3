using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace Oma_Projekti_1.Services
{
    public abstract class Animal : IAnimal
    {

        public abstract string Name { get; }

        public abstract string Sound { get; }

        public abstract string Description { get; }

        public void PlaySound()
        {
            //var assembly = typeof(App).GetTypeInfo().Assembly;
            //Stream audioStream = assembly.GetManifestResourceStream("YourSharedAssemblyName." + "yoursound.wav");


            var player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            player.Load(FileName);


            player.Play();



        }

        protected abstract string FileName { get; }
    }
}
