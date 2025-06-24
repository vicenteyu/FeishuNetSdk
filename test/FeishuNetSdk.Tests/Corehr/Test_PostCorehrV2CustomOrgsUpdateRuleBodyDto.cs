// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostCorehrV2CustomOrgsUpdateRuleBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 更新自定义组织的匹配规则 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 更新自定义组织的匹配规则 请求体
/// <para>接口ID：7358017162446553092</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/organization-management/custom_org/update_rule</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fcustom_org%2fupdate_rule</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2CustomOrgsUpdateRuleBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "object_api_name": "custom_org_01",
    "org_id": "6862995757234914824",
    "match_rule_groups": [
        {
            "match_rules": [
                {
                    "left_value": "department",
                    "operator": "contains",
                    "right_values": [
                        "6862995757234914824"
                    ]
                }
            ]
        }
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Corehr.PostCorehrV2CustomOrgsUpdateRuleBodyDto>(json);
        Assert.IsNotNull(result);
    }
}