// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostApplicationV6ApplicationsByAppIdAppUsageOverviewResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取应用使用概览 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Application;

/// <summary>
/// 测试 获取应用使用概览 响应体
/// <para>接口ID：6995148762798178332</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/application-v6/app-usage/overview</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapplication-v6%2fapplication-app_usage%2foverview</para>
/// </summary>
[TestClass]
public class Test_PostApplicationV6ApplicationsByAppIdAppUsageOverviewResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "data": {
        "items": [
            {
                "metric_name": "uv",
                "metric_value": 0
            },
            {
                "metric_name": "total_users",
                "metric_value": 2
            },
            {
                "metric_name": "new_users",
                "metric_value": 0
            },
            {
                "metric_name": "pv",
                "metric_value": 0
            },
            {
                "metric_name": "lifecycle",
                "metric_value": 0
            }
        ]
    },
    "msg": "success"
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Application.PostApplicationV6ApplicationsByAppIdAppUsageOverviewResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}