global using FeishuNetSdk.Services;
global using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace FeishuNetSdk.Tests;

public static class Programs
{
    public static JsonSerializerOptions JsonSerializerOptions => new() { UnmappedMemberHandling = JsonUnmappedMemberHandling.Disallow };
}