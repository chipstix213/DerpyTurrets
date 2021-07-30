
namespace Scripts
{
    partial class Parts
    {
        internal Parts()
        {
            // file convention: Name.cs - See Example.cs file for PART property details.
            //
            // Enable your config files using the follow syntax, don't include the ".cs" extension:
            // PartFiles(Your1stConfigFile, Your2ndConfigFile, Your3rdConfigFile);
            PartFiles(SmalllTurret, MediumTurret, LargeTurret, SmallRailTurret, MediumRailTurret, LargeRailTurret, SmalllArtilleryTurret, MediumArtilleryTurret, LargeArtilleryTurret, SmallMissileTurret, MediumMissileTurret, LargeMissileTurret);
            ArmorFiles();
            SupportFiles();
            UpgradeFiles();

        }
    }
}
