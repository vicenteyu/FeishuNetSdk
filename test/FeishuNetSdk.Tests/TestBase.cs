// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="TestBase.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary></summary>
// ************************************************************************
using System.Text.Json;

namespace FeishuNetSdk.Tests;

public class TestBase
{
    protected static T? Deserialize<T>(string json)
    {
        return JsonSerializer.Deserialize<T>(json, Programs.JsonSerializerOptions);
    }
}
