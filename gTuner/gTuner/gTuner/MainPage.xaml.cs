using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Plugin.SimpleAudioPlayer;
using System.Reflection;
using System.IO;

namespace gTuner
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Click_S1();
            Click_S2();
            Click_S3();
            Click_S4();
            Click_S5();
            Click_S6();
        }

        public void SelectTuning(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Tunings());
        }

        void Click_S1()
        {
            s1.GestureRecognizers.Add(new TapGestureRecognizer()
            {
                Command = new Command(() =>
                {
                    ISimpleAudioPlayer Tone;

                    Tone = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
                    Stream Tonee = GetType().Assembly.GetManifestResourceStream("gTuner.sounds.09 C#2.mp3");
                    Tone.Load(Tonee);
                    Tone.Play();
                })
            });
        }

        void Click_S2()
        {
            s2.GestureRecognizers.Add(new TapGestureRecognizer()
            {
                Command = new Command(() =>
                {
                    ISimpleAudioPlayer Tone;

                    Tone = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
                    Stream Tonee = GetType().Assembly.GetManifestResourceStream("gTuner.sounds.16 G#2.mp3");
                    Tone.Load(Tonee);
                    Tone.Play();
                })
            });
        }

        void Click_S3()
        {
            s3.GestureRecognizers.Add(new TapGestureRecognizer()
            {
                Command = new Command(() =>
                {
                    ISimpleAudioPlayer Tone;

                    Tone = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
                    Stream Tonee = GetType().Assembly.GetManifestResourceStream("gTuner.sounds.21 C#3.mp3");
                    Tone.Load(Tonee);
                    Tone.Play();
                })
            });
        }

        void Click_S4()
        {
            s4.GestureRecognizers.Add(new TapGestureRecognizer()
            {
                Command = new Command(() =>
                {
                    ISimpleAudioPlayer Tone;

                    Tone = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
                    Stream Tonee = GetType().Assembly.GetManifestResourceStream("gTuner.sounds.26 F#3.mp3");
                    Tone.Load(Tonee);
                    Tone.Play();
                })
            });
        }
        void Click_S5()
        {
            s5.GestureRecognizers.Add(new TapGestureRecognizer()
            {
                Command = new Command(() =>
                {
                    ISimpleAudioPlayer Tone;

                    Tone = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
                    Stream Tonee = GetType().Assembly.GetManifestResourceStream("gTuner.sounds.30 A#3.mp3");
                    Tone.Load(Tonee);
                    Tone.Play();
                })
            });
        }

        void Click_S6()
        {
            s6.GestureRecognizers.Add(new TapGestureRecognizer()
            {
                Command = new Command(() =>
                {
                    ISimpleAudioPlayer Tone;

                    Tone = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
                    Stream Tonee = GetType().Assembly.GetManifestResourceStream("gTuner.sounds.35 D#4.mp3");
                    Tone.Load(Tonee);
                    Tone.Play();
                })
            });
        }
    }
}