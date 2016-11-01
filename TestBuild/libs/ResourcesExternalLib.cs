using flash.events;
using RockiePlayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockiePlayer
{
    public class ResourcesExternalLib : EventDispatcher
    {
        protected string[] vectors = null;
        protected string[] graphics = null;

        private int totalCount = 0;

        public ResourcesExternalLib()
        {
        }

        public void Load()
        {
            for (var i = 0; i < this.vectors.Length; i++)
                Resources.LoadGraphicsData("vectors/" + this.vectors[i] + ".vec", (System.Action<Object>)onLoad);
            for (var i = 0; i < this.graphics.Length; i++)
                Resources.LoadBitmapData("graphics/" + this.graphics[i] + ".png", 0, 0, (System.Action<Object>)onLoad);
        }

        private void onLoad(Object data)
        {
            totalCount++;

            if (totalCount < this.vectors.Length + this.graphics.Length)
                return;
            dispatchEvent(new Event(Event.COMPLETE));
        }
    }
}
