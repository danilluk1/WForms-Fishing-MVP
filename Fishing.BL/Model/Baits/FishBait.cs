﻿using Fishing.BL.Model.Items;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace Fishing.BL.Model.Baits {

    [Serializable]
    public abstract class FishBait : Item {
        public static List<FishBait> FishBaits = new List<FishBait>();

        public FishBait(string name, int price, Bitmap picture) : base(name, price, picture) {
        }

        public static FishBait GetFishBaitByName(string name) {
            return FishBaits.Find(b => b.Name == name);
        }
    }
}