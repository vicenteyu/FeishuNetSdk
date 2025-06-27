// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostHireV1EcoAccountCustomFieldsBatchDeleteBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 删除账号自定义字段 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 删除账号自定义字段 请求体
/// <para>接口ID：7195815976042545154</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/ecological-docking/eco_account_custom_field/batch_delete</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2feco_account_custom_field%2fbatch_delete</para>
/// </summary>
[TestClass]
public class Test_PostHireV1EcoAccountCustomFieldsBatchDeleteBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "scope": 1,
    "custom_field_key_list": [
        "account_token_v1"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Hire.PostHireV1EcoAccountCustomFieldsBatchDeleteBodyDto>(json);
        Assert.IsNotNull(result);
    }
}