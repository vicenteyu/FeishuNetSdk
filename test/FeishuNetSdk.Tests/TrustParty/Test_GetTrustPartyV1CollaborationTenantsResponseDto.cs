namespace FeishuNetSdk.Tests.TrustParty;

/// <summary>
/// 测试 获取可见关联组织的列表 响应体
/// <para>接口ID：7442539768884641820</para>
/// <para>文档地址：https://open.feishu.cn/document/trust_party-v1/-collaboraiton-organization/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftrust_party-v1%2fcollaboration_tenant%2flist</para>
/// </summary>
[TestClass]
public class Test_GetTrustPartyV1CollaborationTenantsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "target_tenant_list": [
            {
                "tenant_key": "130426ba5b8f174f",
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
                "connect_time": 1642041636,
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
                "brand": "飞书"
            }
        ],
        "has_more": true,
        "page_token": "AQD9/Rn9eij9Pm39ED40/TIx6jupqdAcfLY%2B51xMvNU="
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.TrustParty.GetTrustPartyV1CollaborationTenantsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}