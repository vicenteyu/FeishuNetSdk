// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetTrustPartyV1CollaborationTenantsByTargetTenantKeyResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取关联组织详情 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.TrustParty;

/// <summary>
/// 测试 获取关联组织详情 响应体
/// <para>接口ID：7442539768884690972</para>
/// <para>文档地址：https://open.feishu.cn/document/trust_party-v1/-collaboraiton-organization/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftrust_party-v1%2fcollaboration_tenant%2fget</para>
/// </summary>
[TestClass]
public class Test_GetTrustPartyV1CollaborationTenantsByTargetTenantKeyResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "target_tenant": {
            "tenant_key": "abcd",
            "tenant_name": "name",
            "i18n_tenant_name": {
                "zh_cn": "zh_cn_name",
                "ja_jp": "ja_jp_name",
                "en_us": "en_name"
            },
            "tenant_short_name": "tenant_short_name",
            "i18n_tenant_short_name": {
                "zh_cn": "zh_cn_name",
                "ja_jp": "ja_jp_name",
                "en_us": "en_name"
            },
            "connect_time": 1671107493,
            "tenant_tag": "协作",
            "i18n_tenant_tag": {
                "zh_cn": "zh_cn_name",
                "ja_jp": "ja_jp_name",
                "en_us": "en_name"
            },
            "avatar": {
                "avatar_72": "https://foo.icon.com/xxxx",
                "avatar_240": "https://foo.icon.com/xxxx",
                "avatar_640": "https://foo.icon.com/xxxx",
                "avatar_origin": "https://foo.icon.com/xxxx"
            },
            "brand": "feishu"
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.TrustParty.GetTrustPartyV1CollaborationTenantsByTargetTenantKeyResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}