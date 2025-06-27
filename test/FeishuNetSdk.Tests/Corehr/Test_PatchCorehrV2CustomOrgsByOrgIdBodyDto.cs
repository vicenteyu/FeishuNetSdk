// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PatchCorehrV2CustomOrgsByOrgIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 更新自定义组织信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 更新自定义组织信息 请求体
/// <para>接口ID：7358017162446536708</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/organization-management/custom_org/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fcustom_org%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchCorehrV2CustomOrgsByOrgIdBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "object_api_name": "custom_org_01",
    "names": [
        {
            "lang": "zh-CN",
            "value": "中文示例"
        }
    ],
    "code": "MDPD00000023",
    "parent_id": "6862995757234914824",
    "manager_ids": [
        "6862995757234914824"
    ],
    "description": [
        {
            "lang": "zh-CN",
            "value": "中文示例"
        }
    ],
    "effective_time": "2020-01-01",
    "org_roles": [
        {
            "api_name": "hcm_corehr_xxxxxx",
            "security_group_id": "7034393015968122400",
            "employment_ids": [
                "6862995757234914824"
            ]
        }
    ],
    "custom_fields": [
        {
            "custom_api_name": "name",
            "value": "\"231\""
        }
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Corehr.PatchCorehrV2CustomOrgsByOrgIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}