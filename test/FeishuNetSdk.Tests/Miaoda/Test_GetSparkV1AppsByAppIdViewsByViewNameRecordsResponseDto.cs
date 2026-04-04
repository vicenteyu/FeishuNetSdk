// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-04-03
//
// Last Modified By : yxr
// Last Modified On : 2026-04-03
// ************************************************************************
// <copyright file="Test_GetSparkV1AppsByAppIdViewsByViewNameRecordsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询视图数据记录 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Miaoda;

/// <summary>
/// 测试 查询视图数据记录 响应体
/// <para>接口ID：7620858064161836239</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/spark-v1/app-view/get_view_record_list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fspark-v1%2fapp-view%2fget_view_record_list</para>
/// </summary>
[TestClass]
public class Test_GetSparkV1AppsByAppIdViewsByViewNameRecordsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "has_more": true,
        "page_token": "eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=",
        "total": 2,
        "items": "[{\"name\":\"王一一\",\"gender\":\"male\",\"age\":10},{\"name\":\"王二二\",\"gender\":\"female\",\"age\":10}]"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Miaoda.GetSparkV1AppsByAppIdViewsByViewNameRecordsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}