// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-05-22
//
// Last Modified By : yxr
// Last Modified On : 2026-05-22
// ************************************************************************
// <copyright file="Test_PatchSparkV1AppsByAppIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 更新妙搭应用信息 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Miaoda;

/// <summary>
/// 测试 更新妙搭应用信息 响应体
/// <para>接口ID：7642228089434934453</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/spark-v1/app/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fspark-v1%2fapp%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchSparkV1AppsByAppIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "app": {
            "app_id": "app_7d2f8a4b1c9e6035",
            "app_type": "HTML",
            "name": "智能客服助手",
            "description": "提供7×24小时智能对话服务，支持常见问题自动解答与工单流转",
            "icon_url": "https://example.com/app-icons/customer-service.png",
            "created_at": "2026-05-18T10:00:00Z",
            "updated_at": "2026-06-20T14:30:00Z"
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Miaoda.PatchSparkV1AppsByAppIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}