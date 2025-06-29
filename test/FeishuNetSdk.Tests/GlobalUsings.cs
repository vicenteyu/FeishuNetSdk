// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="GlobalUsings.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary></summary>
// ************************************************************************
global using FeishuNetSdk.Services;
global using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace FeishuNetSdk.Tests;

public static class Programs
{
    public static JsonSerializerOptions JsonSerializerOptions => new() { UnmappedMemberHandling = JsonUnmappedMemberHandling.Disallow };
}