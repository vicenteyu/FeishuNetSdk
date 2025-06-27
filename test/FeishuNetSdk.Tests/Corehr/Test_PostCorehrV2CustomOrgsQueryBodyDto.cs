// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostCorehrV2CustomOrgsQueryBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 查询自定义组织信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 查询自定义组织信息 请求体
/// <para>接口ID：7358017162446520324</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/organization-management/custom_org/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fcustom_org%2fquery</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2CustomOrgsQueryBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "object_api_name": "custom_org_01",
    "org_fields": [
        "names"
    ],
    "org_role_fields": [
        "hcm_corehr_xxxx"
    ],
    "org_ids": [
        "7140964208476371111"
    ],
    "code": "MDPD00000023",
    "parent_id": "7140964208476371111",
    "active": true,
    "need_match_rule": false
}
""";
        var result = Deserialize<FeishuNetSdk.Corehr.PostCorehrV2CustomOrgsQueryBodyDto>(json);
        Assert.IsNotNull(result);
    }
}