namespace Beyond.NET.Builder;

[Flags]
public enum BuildTargets
{
    None =                  0,
        
    MacOSARM64 =            1 << 0,
    MacOSX64 =              1 << 1,
    iOSARM64 =              1 << 2,
    iOSSimulatorARM64 =     1 << 3,
    iOSSimulatorX64 =       1 << 4,
    MacOSCatalystARM64 =    1 << 5,
    MacOSCatalystX64 =      1 << 6,
    MacOSUniversal = MacOSARM64 | MacOSX64,
    iOSSimulatorUniversal = iOSSimulatorARM64 | iOSSimulatorX64,
    iOSUniversal = iOSARM64 | iOSSimulatorUniversal,
    MacCatalystUniversal = MacOSCatalystX64 | MacOSCatalystARM64,
    AppleUniversal = MacOSUniversal | iOSUniversal | MacCatalystUniversal
}

internal static class BuildTargets_Extensions
{
    public static bool ContainsAnyiOSTarget(this BuildTargets buildTargets)
    {
        return buildTargets.HasFlag(BuildTargets.iOSARM64) ||
               buildTargets.HasFlag(BuildTargets.iOSSimulatorARM64) ||
               buildTargets.HasFlag(BuildTargets.iOSSimulatorX64);
    }
    
    public static bool ContainsAnyiOSSimulatorTarget(this BuildTargets buildTargets)
    {
        return buildTargets.HasFlag(BuildTargets.iOSSimulatorARM64) ||
               buildTargets.HasFlag(BuildTargets.iOSSimulatorX64);
    }
    
    public static bool ContainsAnyMacOSTarget(this BuildTargets buildTargets)
    {
        return buildTargets.HasFlag(BuildTargets.MacOSARM64) ||
               buildTargets.HasFlag(BuildTargets.MacOSX64);
    }
    
    public static bool ContainsAnyMacCatalystTarget(this BuildTargets buildTargets)
    {
        return buildTargets.HasFlag(BuildTargets.MacOSCatalystX64) ||
               buildTargets.HasFlag(BuildTargets.MacOSCatalystARM64);
    }
}