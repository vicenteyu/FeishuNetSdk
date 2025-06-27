// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetApaasV1SeatActivitiesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询席位活跃详情 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.AppEngine;

/// <summary>
/// 测试 查询席位活跃详情 响应体
/// <para>接口ID：7447484643136946177</para>
/// <para>文档地址：https://open.feishu.cn/document/apaas-v1/seat_activity/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapaas-v1%2fseat_activity%2flist</para>
/// </summary>
[TestClass]
public class Test_GetApaasV1SeatActivitiesResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "items": [
            {
                "user_id": 1803710089388154,
                "namespace": "package_35f605__c",
                "status": "in_use",
                "active_time": 1727199298656
            }
        ],
        "page_token": "eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0",
        "has_more": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.AppEngine.GetApaasV1SeatActivitiesResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}