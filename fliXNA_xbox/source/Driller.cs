using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace fliXNA_xbox
{
    public class Driller : FlxState
    {

        private Player p;
        private Follower f;

        public override void create()
        {
            base.create();

            p = new Player(200, 200);
            add(p);

            f = new Follower(p);
            add(f);

            //FlxG.camera.follow(p, FlxCamera.STYLE_TOPDOWN);

        }



        public override void update()
        {
            base.update();

        }

        public bool interactWithMap(FlxObject player, FlxObject map)
        {



            return true;
        }

    }
}