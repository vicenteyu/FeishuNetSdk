#nullable enable
// 解决 .NET Standard 2.0 下 Record 报错问题
#pragma warning disable IDE0130
namespace System.Runtime.CompilerServices
{
    using global::System.ComponentModel;

    [EditorBrowsable(EditorBrowsableState.Never)]
    internal static class IsExternalInit { }
}