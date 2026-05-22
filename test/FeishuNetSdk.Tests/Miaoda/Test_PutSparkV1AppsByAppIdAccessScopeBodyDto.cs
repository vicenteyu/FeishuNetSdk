// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2026-05-22
//
// Last Modified By : yxr
// Last Modified On : 2026-05-22
// ************************************************************************
// <copyright file="Test_PutSparkV1AppsByAppIdAccessScopeBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 更新妙搭应用可用范围 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Miaoda;

/// <summary>
/// 测试 更新妙搭应用可用范围 请求体
/// <para>接口ID：7642228089434868917</para>
/// <para>文档地址：https://open.feishu.cn/document/uAjLw4CM/ukTMukTMukTM/spark-v1/app/update_app_visibility</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fspark-v1%2fapp%2fupdate_app_visibility</para>
/// </summary>
[TestClass]
public class Test_PutSparkV1AppsByAppIdAccessScopeBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "users": [
        "ou_1234567890abcdef1234567890abcdef"
    ],
    "departments": [
        "od_1234567890abcdef1234567890abcdef"
    ],
    "chats": [
        "oc_1234567890abcdef1234567890abcdef"
    ],
    "apply_config": {
        "enabled": true,
        "approvers": [
            "ou_1234567890abcdef1234567890abcdef"
        ]
    },
    "require_login": true,
    "scope": "Range"
}
""";
        var result = Deserialize<FeishuNetSdk.Miaoda.PutSparkV1AppsByAppIdAccessScopeBodyDto>(json);
        Assert.IsNotNull(result);
    }
}