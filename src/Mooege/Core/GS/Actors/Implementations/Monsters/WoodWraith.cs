﻿﻿/*
 * Copyright (C) 2011 mooege project
 *
 * This program is free software; you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation; either version 2 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, write to the Free Software
 * Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mooege.Core.GS.Map;
using Mooege.Core.GS.Common.Types.TagMap;
using Mooege.Core.GS.AI.Brains;
using Mooege.Net.GS.Message;

namespace Mooege.Core.GS.Actors.Implementations.Monsters
{
    //Unknown: Doesn't spawn them?
    [HandledSNO(6572, 139454, 139456, 170324, 170325, 495)]
    public class WoodWraith : Monster
    {
        public WoodWraith(World world, int snoId, TagMap tags)
            : base(world, snoId, tags)
        {
            this.Brain = new MonsterBrain(this);
            (Brain as MonsterBrain).AddPresetPower(30596); //Static_Pose/Unique
            (Brain as MonsterBrain).AddPresetPower(29990); //Static_Pose/Unique 
            (Brain as MonsterBrain).AddPresetPower(30800); //Unique
            //if WoodWraith uses 30800, release spores. -> this is only for unique woodwraith.

            this.Attributes[GameAttribute.Hitpoints_Max_Total] = 5f;
            this.Attributes[GameAttribute.Hitpoints_Max] = 5f;
            this.Attributes[GameAttribute.Hitpoints_Total_From_Level] = 0f;
            this.Attributes[GameAttribute.Hitpoints_Cur] = 5f;
            this.Attributes[GameAttribute.Attacks_Per_Second_Total] = 1.0f;
            this.Attributes[GameAttribute.Damage_Weapon_Min_Total, 0] = 5f;
            this.Attributes[GameAttribute.Damage_Weapon_Delta_Total, 0] = 7f;

        }
    }
}