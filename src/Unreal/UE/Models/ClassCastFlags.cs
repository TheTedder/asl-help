namespace AslHelp.UE.Models;

[Flags]
public enum ClassCastFlags : ulong
{
    None = 0x000000000000,
    UField = 0x000000000001,
    UInt8Property = 0x000000000002,
    UEnum = 0x000000000004,
    UStruct = 0x000000000008,
    UScriptStruct = 0x000000000010,
    UClass = 0x000000000020,
    UByteProperty = 0x000000000040,
    UIntProperty = 0x000000000080,
    UFloatProperty = 0x000000000100,
    UUInt64Property = 0x000000000200,
    UClassProperty = 0x000000000400,
    UUInt32Property = 0x000000000800,
    UInterfaceProperty = 0x000000001000,
    UNameProperty = 0x000000002000,
    UStrProperty = 0x000000004000,
    UProperty = 0x000000008000,
    UObjectProperty = 0x000000010000,
    UBoolProperty = 0x000000020000,
    UUInt16Property = 0x000000040000,
    UFunction = 0x000000080000,
    UStructProperty = 0x000000100000,
    UArrayProperty = 0x000000200000,
    UInt64Property = 0x000000400000,
    UDelegateProperty = 0x000000800000,
    UNumericProperty = 0x000001000000,
    UMulticastDelegateProperty = 0x000002000000,
    UObjectPropertyBase = 0x000004000000,
    UWeakObjectProperty = 0x000008000000,
    ULazyObjectProperty = 0x000010000000,
    UAssetObjectProperty = 0x000020000000,
    UTextProperty = 0x000040000000,
    UInt16Property = 0x000080000000,
    UDoubleProperty = 0x000100000000,
    UAssetClassProperty = 0x000200000000,
    UPackage = 0x000400000000,
    ULevel = 0x000800000000,
    AActor = 0x001000000000,
    APlayerController = 0x002000000000,
    APawn = 0x004000000000,
    USceneComponent = 0x008000000000,
    UPrimitiveComponent = 0x010000000000,
    USkinnedMeshComponent = 0x020000000000,
    USkeletalMeshComponent = 0x040000000000,
    UBlueprint = 0x080000000000,
    UDelegateFunction = 0x100000000000,
    UStaticMeshComponent = 0x200000000000,
    UMapProperty = 0x400000000000,
    USetProperty = 0x800000000000
}