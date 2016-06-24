﻿#region Copyright
// COPYRIGHT 2015 JUSTIN COX (CONJI)
#endregion

using System;
using System.Windows.Forms;
using EmptyKeys.UserInterface.Controls;
using EmptyKeys.UserInterface.Generated;
using EmptyKeys.UserInterface.Mvvm;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Media;
using Welt.Controllers;

namespace Welt.Scenes
{
    public class SplashScene : Scene
    {
        //private const string SPLASH = "Images/splashscreen";
        //private float _o;

        protected override Color BackColor => Color.GhostWhite;
        internal override UIRoot UI => new Splash();
        internal override ViewModelBase DataContext { get; set; }

        public SplashScene(Game game) : base(game)
        {
            //AddComponent(new ImageComponent(SPLASH, "splash", -1, -1, game.GraphicsDevice)
            //{
            //    Opacity = 0f,
            //    HorizontalAlignment = HorizontalAlignment.Center
            //});
            Schedule(() =>
            {
                SceneController.Load(new MainMenuScene(game));
            }, TimeSpan.FromSeconds(5));

            var song = game.Content.Load<Song>("Music/feather");
            //MediaPlayer.Play(song);
        }

        public override void Initialize()
        {
            base.Initialize();
            //GetComponent("splash").Value.FadeIn(this, TimeSpan.FromSeconds(2));
        }
    }
}
