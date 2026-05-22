// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-05-22
//
// Last Modified By : yxr
// Last Modified On : 2026-05-22
// ************************************************************************
// <copyright file="Test_GetSparkV1AppsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 批量获取妙搭应用 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Miaoda;

/// <summary>
/// 测试 批量获取妙搭应用 响应体
/// <para>接口ID：7642228089434901685</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/spark-v1/app/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fspark-v1%2fapp%2flist</para>
/// </summary>
[TestClass]
public class Test_GetSparkV1AppsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "page_token": "eyJwYWdlX251bWJlciI6MiwiY29udGVudF9pZHMiOlsiMTIzNCIsIjU2NzgiXX0=",
        "items": [
            {
                "app_id": "app_7d2f8a4b1c9e6035",
                "app_type": "HTML",
                "name": "智能客服助手",
                "description": "提供7×24小时智能对话服务，支持常见问题自动解答与工单流转",
                "icon_url": "https://example.com/app-icons/customer-service.png",
                "created_at": "2026-05-18T10:00:00Z",
                "updated_at": "2026-06-20T14:30:00Z"
            }
        ],
        "has_more": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Miaoda.GetSparkV1AppsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}