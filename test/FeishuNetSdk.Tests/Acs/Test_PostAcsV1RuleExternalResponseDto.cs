// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostAcsV1RuleExternalResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 创建或更新权限组 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Acs;

/// <summary>
/// 测试 创建或更新权限组 响应体
/// <para>接口ID：7321978105899122716</para>
/// <para>文档地址：https://open.feishu.cn/document/acs-v1/rule_external/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2facs-v1%2frule_external%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostAcsV1RuleExternalResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "rule_id": "7298933941867135276"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Acs.PostAcsV1RuleExternalResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}