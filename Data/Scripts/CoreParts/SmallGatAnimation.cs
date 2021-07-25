using System.Collections.Generic;
using static Scripts.Structure.WeaponDefinition;
using static Scripts.Structure.WeaponDefinition.AnimationDef;
using static Scripts.Structure.WeaponDefinition.AnimationDef.PartAnimationSetDef.EventTriggers;
using static Scripts.Structure.WeaponDefinition.AnimationDef.RelMove.MoveType;
using static Scripts.Structure.WeaponDefinition.AnimationDef.RelMove;
namespace Scripts
{ // Don't edit above this line
    partial class Parts
    {

        private AnimationDef SmallArtilleryBarrelAnimation => new AnimationDef
        {

            AnimationSets = new[]
            {
				#region Barrels Animations
                new PartAnimationSetDef()
                {
                    SubpartId = Names("GatBarrel1"),
                    BarrelId = "muzzle_missile_1", //only used for firing, use "Any" for all muzzles
                    StartupFireDelay = 0,
                    AnimationDelays = Delays(firingDelay : 0, reloadingDelay: 0, overheatedDelay: 0, trackingDelay: 0, lockedDelay: 0, onDelay: 0, offDelay: 0, burstReloadDelay: 0, outOfAmmoDelay: 0, preFireDelay: 0),//Delay before animation starts
                    Reverse = Events(),
                    Loop = Events(Firing),
					TriggerOnce = Events(),
                    EventMoveSets = new Dictionary<PartAnimationSetDef.EventTriggers, RelMove[]>
                    {
                                               [Firing] = new[] //Firing, Reloading, etc, see Possible Events,  define a new[] for each
                            {
                                new RelMove
                                {
                                    CenterEmpty = "",
                                    EmissiveName = "", //EmissiveName: from above Emissives definitions, TurnOn TurnOff
                                    TicksToMove = 10, //number of ticks to complete motion, 60 = 1 second
                                    MovementType = Linear,
                                    LinearPoints = new XYZ[0],
                                    Rotation = Transformation(0, 0,  360f), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotation is around CenterEmpty
                                },
                            },
                        
                        [StopFiring] = new[] //Firing, Reloading, etc, see Possible Events,  define a new[] for each
                            {
                                new RelMove
                                {
                                    CenterEmpty = "",
                                    EmissiveName = "", //EmissiveName: from above Emissives definitions, TurnOn TurnOff
                                    TicksToMove = 1, //number of ticks to complete motion, 60 = 1 second
                                    MovementType = Linear,
                                    LinearPoints = new XYZ[0],
                                    Rotation = Transformation(0, 0, 0f), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotation is around CenterEmpty
                                },
                            },
                    }
                },

				#endregion


            }
        };
    }
}
