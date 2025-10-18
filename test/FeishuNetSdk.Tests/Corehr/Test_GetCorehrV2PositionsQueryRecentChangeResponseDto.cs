// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-10-18
//
// Last Modified By : yxr
// Last Modified On : 2025-10-18
// ************************************************************************
// <copyright file="Test_GetCorehrV2PositionsQueryRecentChangeResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询指定时范围内当前版本信息发生变更的岗位 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 查询指定时范围内当前版本信息发生变更的岗位 响应体
/// <para>接口ID：7452973109948645378</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/job-management/position/query_recent_change</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fposition%2fquery_recent_change</para>
/// </summary>
[TestClass]
public class Test_GetCorehrV2PositionsQueryRecentChangeResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "position_ids": [
            "7094136522860922111"
        ],
        "page_token": "eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=",
        "has_more": true,
        "deleted_position_ids": [
            "7094136522860922111"
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Corehr.GetCorehrV2PositionsQueryRecentChangeResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}