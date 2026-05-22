// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-05-22
//
// Last Modified By : yxr
// Last Modified On : 2026-05-22
// ************************************************************************
// <copyright file="Test_GetSparkV1AppsByAppIdAccessScopeResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取妙搭应用可用范围 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Miaoda;

/// <summary>
/// 测试 获取妙搭应用可用范围 响应体
/// <para>接口ID：7642228089434885301</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/spark-v1/app/get_app_visibility</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fspark-v1%2fapp%2fget_app_visibility</para>
/// </summary>
[TestClass]
public class Test_GetSparkV1AppsByAppIdAccessScopeResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "scope": "Range",
        "users": [
            "ou_75e71dde59ef1cbbaf25875b20cc54ef"
        ],
        "departments": [
            "od-3f65aa8f59e512bfabde0d71e04c26d7"
        ],
        "chats": [
            "oc_aa8b35fdab3813ef837f91b8ffe61ec6"
        ],
        "apply_config": {
            "enabled": true,
            "approvers": [
                "ou_75e71dde59ef1cbbaf25875b20cc54ef"
            ]
        },
        "require_login": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Miaoda.GetSparkV1AppsByAppIdAccessScopeResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}