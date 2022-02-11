using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalKingdom.Forms.Core.Interfaces
{
    public abstract class Animal : IAnimal
    {

        public abstract string Name { get; }

        public abstract string Sound { get; }

        public abstract string Description { get; }

        public void PlaySound()
        {

            Plugin.SimpleAudioPlayer.ISimpleAudioPlayer player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            player.Load(FileName);

            player.Play();

        }
        protected abstract string FileName { get; }
    }

}
