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

        private AnimationDef MediumArtilleryBarrelAnimation => new AnimationDef
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
                        [Firing] =
                            new[] //Firing, Reloading, Overheated, Tracking, TurnOn, TurnOff, BurstReload, OutOfAmmo, PreFire define a new[] for each
                            {
                                new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 3, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = Linear, // ExpoGrowth (speedsup),  ExpoDecay (slows down), Linear, Delay, Show, Hide
                                    //EmissiveName = "LaserEmissive",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0, 0f, 0.4f), //linear movement
                                    },
                                    Rotation = Transformation(0, 0, 0f), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
                                new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 35, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = ExpoGrowth, // ExpoGrowth (speedsup),  ExpoDecay (slows down), Linear, Delay, Show, Hide
                                    //EmissiveName = "LaserEmissive",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0, 0f, -0.4f), //linear movement
                                    },
                                    Rotation = Transformation(0, 0, 0f), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
                                
                                new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 17, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = Delay, // ExpoGrowth (speedsup),  ExpoDecay (slows down), Linear, Delay, Show, Hide
                                    //EmissiveName = "LaserEmissive",//name of defined emissive 
                                    LinearPoints = new XYZ[0],
                                    Rotation = Transformation(0, 0, 0f), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
                            },
                    }
                },

                new PartAnimationSetDef()
                {
                    SubpartId = Names("GatBarrel2"),
                    BarrelId = "muzzle_missile_2", //only used for firing, use "Any" for all muzzles
                    StartupFireDelay = 0,
                    AnimationDelays = Delays(firingDelay : 0, reloadingDelay: 0, overheatedDelay: 0, trackingDelay: 0, lockedDelay: 0, onDelay: 0, offDelay: 0, burstReloadDelay: 0, outOfAmmoDelay: 0, preFireDelay: 0),//Delay before animation starts
                    Reverse = Events(),
                    Loop = Events(Firing),
					TriggerOnce = Events(),
                    EventMoveSets = new Dictionary<PartAnimationSetDef.EventTriggers, RelMove[]>
                    {
                        [Firing] =
                            new[] //Firing, Reloading, Overheated, Tracking, TurnOn, TurnOff, BurstReload, OutOfAmmo, PreFire define a new[] for each
                            {
                                new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 3, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = Linear, // ExpoGrowth (speedsup),  ExpoDecay (slows down), Linear, Delay, Show, Hide
                                    //EmissiveName = "LaserEmissive",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0, 0f, 0.4f), //linear movement
                                    },
                                    Rotation = Transformation(0, 0, 0f), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
                                new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 35, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = ExpoGrowth, // ExpoGrowth (speedsup),  ExpoDecay (slows down), Linear, Delay, Show, Hide
                                    //EmissiveName = "LaserEmissive",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0, 0f, -0.4f), //linear movement
                                    },
                                    Rotation = Transformation(0, 0, 0f), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
                                
                                new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 17, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = Delay, // ExpoGrowth (speedsup),  ExpoDecay (slows down), Linear, Delay, Show, Hide
                                    //EmissiveName = "LaserEmissive",//name of defined emissive 
                                    LinearPoints = new XYZ[0],
                                    Rotation = Transformation(0, 0, 0f), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
                            },
                    }
                },
                 new PartAnimationSetDef()
                {
                    SubpartId = Names("GatBarrel3"),
                    BarrelId = "muzzle_missile_3", //only used for firing, use "Any" for all muzzles
                    StartupFireDelay = 0,
                    AnimationDelays = Delays(firingDelay : 0, reloadingDelay: 0, overheatedDelay: 0, trackingDelay: 0, lockedDelay: 0, onDelay: 0, offDelay: 0, burstReloadDelay: 0, outOfAmmoDelay: 0, preFireDelay: 0),//Delay before animation starts
                    Reverse = Events(),
                    Loop = Events(Firing),
					TriggerOnce = Events(),
                    EventMoveSets = new Dictionary<PartAnimationSetDef.EventTriggers, RelMove[]>
                    {
                        [Firing] =
                            new[] //Firing, Reloading, Overheated, Tracking, TurnOn, TurnOff, BurstReload, OutOfAmmo, PreFire define a new[] for each
                            {
                                new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 3, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = Linear, // ExpoGrowth (speedsup),  ExpoDecay (slows down), Linear, Delay, Show, Hide
                                    //EmissiveName = "LaserEmissive",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0, 0f, 0.4f), //linear movement
                                    },
                                    Rotation = Transformation(0, 0, 0f), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
                                new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 35, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = ExpoGrowth, // ExpoGrowth (speedsup),  ExpoDecay (slows down), Linear, Delay, Show, Hide
                                    //EmissiveName = "LaserEmissive",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0, 0f, -0.4f), //linear movement
                                    },
                                    Rotation = Transformation(0, 0, 0f), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
                                
                                new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 17, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = Delay, // ExpoGrowth (speedsup),  ExpoDecay (slows down), Linear, Delay, Show, Hide
                                    //EmissiveName = "LaserEmissive",//name of defined emissive 
                                    LinearPoints = new XYZ[0],
                                    Rotation = Transformation(0, 0, 0f), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
                            },
                    }
                },
                 new PartAnimationSetDef()
                {
                    SubpartId = Names("GatBarrel4"),
                    BarrelId = "muzzle_missile_4", //only used for firing, use "Any" for all muzzles
                    StartupFireDelay = 0,
                    AnimationDelays = Delays(firingDelay : 0, reloadingDelay: 0, overheatedDelay: 0, trackingDelay: 0, lockedDelay: 0, onDelay: 0, offDelay: 0, burstReloadDelay: 0, outOfAmmoDelay: 0, preFireDelay: 0),//Delay before animation starts
                    Reverse = Events(),
                    Loop = Events(Firing),
					TriggerOnce = Events(),
                    EventMoveSets = new Dictionary<PartAnimationSetDef.EventTriggers, RelMove[]>
                    {
                        [Firing] =
                            new[] //Firing, Reloading, Overheated, Tracking, TurnOn, TurnOff, BurstReload, OutOfAmmo, PreFire define a new[] for each
                            {
                                new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 3, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = Linear, // ExpoGrowth (speedsup),  ExpoDecay (slows down), Linear, Delay, Show, Hide
                                    //EmissiveName = "LaserEmissive",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0, 0f, 0.4f), //linear movement
                                    },
                                    Rotation = Transformation(0, 0, 0f), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
                                new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 35, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = ExpoGrowth, // ExpoGrowth (speedsup),  ExpoDecay (slows down), Linear, Delay, Show, Hide
                                    //EmissiveName = "LaserEmissive",//name of defined emissive 
                                    LinearPoints = new[]
                                    {
                                        Transformation(0, 0f, -0.4f), //linear movement
                                    },
                                    Rotation = Transformation(0, 0, 0f), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
                                
                                new RelMove
                                {
                                    CenterEmpty = "",//Specifiy an empty on the subpart to rotate around
                                    TicksToMove = 17, //number of ticks to complete motion, 60 = 1 second

                                    MovementType = Delay, // ExpoGrowth (speedsup),  ExpoDecay (slows down), Linear, Delay, Show, Hide
                                    //EmissiveName = "LaserEmissive",//name of defined emissive 
                                    LinearPoints = new XYZ[0],
                                    Rotation = Transformation(0, 0, 0f), //degrees
                                    RotAroundCenter = Transformation(0, 0, 0), //degrees, rotates around CenterEmpty
                                },
                            },
                    }
                },
				#endregion


            }
        };
    }
}
