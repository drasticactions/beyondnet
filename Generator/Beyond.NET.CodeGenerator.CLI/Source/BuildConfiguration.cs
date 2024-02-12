namespace Beyond.NET.CodeGenerator.CLI;

public record BuildConfiguration
(
    string Target,
    
    string? ProductName,
    string? ProductBundleIdentifier,
    string? ProductOutputPath,
    
    string? MacOSDeploymentTarget,
    string? MacCatalystDeploymentTarget,
    string? iOSDeploymentTarget,
    
    bool DisableParallelBuild,
    bool DisableStripDotNETSymbols
);

internal static class BuildTargets
{
    public const string APPLE_UNIVERSAL = "apple-universal";
    public const string MACOS_UNIVERSAL = "macos-universal";
    public const string MACCATALYST_UNIVERSAL = "maccatalyst-universal";
    public const string IOS_UNIVERSAL = "ios-universal";
}

internal static class AppleDeploymentTargets
{
    public const string MACOS_DEFAULT = "13.0";
    public const string MACCATALYST_DEFAULT = "16.0";
    public const string IOS_DEFAULT = "16.0";
}