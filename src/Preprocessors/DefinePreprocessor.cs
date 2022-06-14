using System.Collections.Generic;

namespace RapNet.Preprocessors;

/// <summary>
/// Represents valid raP EntryTypes.RapValue names used for #define preprocessors.
/// </summary>
internal class DefinePreprocessors 
{
    private static readonly List<RapDefinePreprocessor> Booleans =
        new List<RapDefinePreprocessor> {
            new("false", 0),
            new("true", 1)
        };

    private static readonly List<RapDefinePreprocessor> Accessors =
        new List<RapDefinePreprocessor> {
            new("private", 0),
            new("protected", 1),
            new("public", 2)
        };

    private static readonly List<RapDefinePreprocessor> WeaponMagazineTypes =
        new List<RapDefinePreprocessor> {
            new("WeaponNoSlot", 0),
            new("WeaponSlotPrimary", 1),
            new("WeaponSlotHandGun", 2),
            new("WeaponSlotSecondary", 16),
            new("WeaponSlotHandGunItem", 32),
            new("WeaponSlotItem", 256),
            new("WeaponSlotBinocular", 4096),
            new("WeaponHardMounted", 65536),
            new("WeaponSmallItems", 131072)
        };

    private static readonly Dictionary<string, List<RapDefinePreprocessor>> Defines =
        new Dictionary<string, List<RapDefinePreprocessor>> {
            {"scope", Accessors},
            {"scopeWeapon", Accessors},
            {"scopeMagazine", Accessors},

            {"weaponType", WeaponMagazineTypes},
            {"magazineType", WeaponMagazineTypes}, {
                "canLock", new List<RapDefinePreprocessor> {
                    new("LockDisabled", 0),
                    new("LockCadet", 1),
                    new("LockAlways", 2),
                }
            }, {
                "type", new List<RapDefinePreprocessor> {
                    new("VSoft", 0),
                    new("VArmor", 1),
                    new("VAir", 2)
                }
            }, {
                "side", new List<RapDefinePreprocessor> {
                    new("TEast", 0),
                    new("TWest", 1),
                    new("TGuerrila", 2),
                    new("TCivilian", 3),
                    new("TSideUnknown", 4),
                    new("TEnemy", 5),
                    new("TFriendly", 6),
                    new("TLogic", 7)
                }
            }, {
                "access", new List<RapDefinePreprocessor> {
                    new("ReadAndWrite", 0),
                    new("ReadAndCreate", 1),
                    new("ReadOnly", 2),
                    new("ReadOnlyVerified", 3)
                }
            }, {
                "aiAmmoUsageFlags", new List<RapDefinePreprocessor> {
                    new("None", 0),
                    new("Light", 1),
                    new("Marking", 2),
                    new("Concealment", 4),
                    new("CounterMeasures", 8),
                    new("Mine", 16),
                    new("Underwater", 32),
                    new("OffensiveInf", 64),
                    new("OffensiveVeh", 128),
                    new("OffensiveAir", 256),
                    new("OffensiveArmour", 512)
                }
            }, {
                "weaponLockSystem", new List<RapDefinePreprocessor> {
                    new("Undetectable", 0),
                    new("VisualContrast", 1),
                    new("InfraRed", 2),
                    new("LaserGuided", 4),
                    new("RadarGuided", 8),
                    new("Missile", 16)
                }
            }, {
                "brakeDistance", new List<RapDefinePreprocessor> {
                    new("BrakeDistanceMan", 1),
                    new("BrakeDistanceTank", 14),
                    new("BrakeDistanceBoat", 50),
                    new("BrakeDistancePlane", 500)
                }
            }, {
                "canSee", new List<RapDefinePreprocessor> {
                    new("CanSeeRadar", 1),
                    new("CanSeeEye", 2),
                    new("CanSeeOptics", 4),
                    new("CanSeeEar", 8),
                    new("CanSeeCompass", 16),
                    new("CanSeeAll", 31),
                    new("CanSeePeripheral", 32),
                    new("CanSeeRadarC", 17)
                }
            },

            {"disableWeapons", Booleans},
            {"rightHandIKEnd", Booleans},
            {"gunnerUsesPilotView", Booleans},
            {"explosive", Booleans},
            {"hasCollShapeSafe", Booleans},
            {"enableAttack", Booleans},
            {"showWeaponAim", Booleans},
            {"laserScanner", Booleans},
            {"onLadder", Booleans},
            {"shadow", Booleans},
            {"animated", Booleans},
            {"forceHideDriver", Booleans},
            {"showItemInRightHand", Booleans},
            {"unloadInCombat", Booleans},
            {"hasDriver", Booleans},
            {"ejectDeadCargo", Booleans},
            {"crewVulnerable", Booleans},
            {"canDeactivateMines", Booleans},
            {"attendant", Booleans},
            {"enableBinocular", Booleans},
            {"viewGunnerInExternal", Booleans},
            {"isBicycle", Booleans},
            {"boundingSphere", Booleans},
            {"preferRoads", Booleans},
            {"autoAimEnabled", Booleans},
            {"castDriverShadow", Booleans},
            {"viewDriverShadow", Booleans},
            {"canPullTrigger", Booleans},
            {"driverIsCommander", Booleans},
            {"hideWeaponsDriver", Booleans},
            {"ejectDeadDriver", Booleans},
            {"gearRetracting", Booleans},
            {"onLandBeg", Booleans},
            {"manualControl", Booleans},
            {"hasGunner", Booleans},
            {"enableAutoActions", Booleans},
            {"lockWhenDriverOut", Booleans},
            {"gunnerForceOptics", Booleans},
            {"hideWeaponsCargo", Booleans},
            {"east", Booleans},
            {"west", Booleans},
            {"enableOptics", Booleans},
            {"useAction", Booleans},
            {"useAsBinocular", Booleans},
            {"hasCommander", Booleans},
            {"useInternalLODInVehicles", Booleans},
            {"preload", Booleans},
            {"showAimCursorInternal", Booleans},
            {"shotFromTurret", Booleans},
            {"enableMissile", Booleans},
            {"rightHandIKBeg", Booleans},
            {"autoReload", Booleans},
            {"inGunnerMayFire", Booleans},
            {"airLock", Booleans},
            {"woman", Booleans},
            {"disableWeaponsLong", Booleans},
            {"canHideBodies", Booleans},
            {"opticsFlare", Booleans},
            {"laserLock", Booleans},
            {"ejectDeadGunner", Booleans},
            {"isMan", Booleans},
            {"onLandEnd", Booleans},
            {"irScanGround", Booleans},
            {"canFloat", Booleans},
            {"showHandGun", Booleans},
            {"primary", Booleans},
            {"gunnerHasFlares", Booleans},
            {"leftHandIKEnd", Booleans},
            {"opticsDisablePeripherialVision", Booleans},
            {"canBeShot", Booleans},
            {"viewCargoShadow", Booleans},
            {"leftHandIKBeg", Booleans},
            {"irLock", Booleans},
            {"autoFire", Booleans},
            {"soundEnabled", Booleans},
            {"forceOptics", Booleans},
            {"enableSweep", Booleans},
            {"looped", Booleans},
            {"optics", Booleans},
            {"laser", Booleans},
            {"showEmpty", Booleans},
            {"driverForceOptics", Booleans},
            {"reversed", Booleans},
            {"castGunnerShadow", Booleans},
            {"showSwitchAction", Booleans},
            {"hideWeaponsGunner", Booleans},
            {"hideProxyInCombat", Booleans},
            {"disappearAtContact", Booleans},
            {"limitGunMovement", Booleans},
            {"outGunnerMayFire", Booleans},
            {"autocenter", Booleans},
            {"textureTrackWheel", Booleans},
            {"showItemInHand", Booleans},
            {"startEngine", Booleans},
            {"forceHideGunner", Booleans},
            {"laserTarget", Booleans},
            {"backgroundReload", Booleans},
            {"showToPlayer", Booleans},
            {"canDrop", Booleans},
            {"ballisticsComputer", Booleans},
            {"soundBurst", Booleans},
            {"soundContinuous", Booleans},
            {"nightVision", Booleans},
            {"blinking", Booleans},
            {"interpolationRestart", Booleans},
            {"terminal", Booleans},
            {"hideUnitInfo", Booleans},
            {"irTarget", Booleans},
            {"viewGunnerShadow", Booleans},
            {"castCargoShadow", Booleans},
            {"passThrough", Booleans}
        };

    /// <summary>
    /// Gets a list of defines associated with raP value name.
    /// </summary>
    /// <param name="rapValueName">raP value name.</param>
    /// <returns>Returns a list of defines associated with rapValueName param.</returns>
    public static List<RapDefinePreprocessor> GetDefinesForRapValue(string rapValueName) =>
        Defines.TryGetValue(rapValueName, out var defines) 
            ? defines 
            : new List<RapDefinePreprocessor>(0);
    
}
