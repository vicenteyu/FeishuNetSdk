namespace FeishuNetSdk.Tests.TrustParty;

/// <summary>
/// 测试 获取关联组织的部门和成员信息 响应体
/// <para>接口ID：7442539768884707356</para>
/// <para>文档地址：https://open.feishu.cn/document/trust_party-v1/-collaboraiton-organization/visible_organization</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftrust_party-v1%2fcollaboration_tenant%2fvisible_organization</para>
/// </summary>
[TestClass]
public class Test_GetTrustPartyV1CollaborationTenantsByTargetTenantKeyVisibleOrganizationResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "collaboration_entity_list": [
            {
                "collaboration_entity_type": "user",
                "department_id": "D096",
                "open_department_id": "od-4e6ac4d14bcd5071a37a39de902c7141",
                "user_id": "a0121196",
                "open_user_id": "ou_4e6ac4d14bcd5071a37a39de902c7141",
                "union_user_id": "on_4e6ac4d14bcd5071a37a39de902c7141",
                "department_name": "test",
                "i18n_department_name": {
                    "zh_cn": "zh_cn_name",
                    "ja_jp": "ja_jp_name",
                    "en_us": "en_name"
                },
                "department_order": "2000",
                "user_name": "test_user_name",
                "i18n_user_name": {
                    "zh_cn": "zh_cn_name",
                    "ja_jp": "ja_jp_name",
                    "en_us": "en_name"
                },
                "user_avatar": {
                    "avatar_72": "https://foo.icon.com/xxxx",
                    "avatar_240": "https://foo.icon.com/xxxx",
                    "avatar_640": "https://foo.icon.com/xxxx",
                    "avatar_origin": "https://foo.icon.com/xxxx"
                },
                "group_id": "a0121196",
                "open_group_id": "ou_4e6ac4d14bcd5071a37a39de902c7141",
                "group_name": "test_user_name",
                "i18n_group_name": {
                    "zh_cn": "zh_cn_name",
                    "ja_jp": "ja_jp_name",
                    "en_us": "en_name"
                }
            }
        ],
        "has_more": true,
        "page_token": "AQD9/Rn9eij9Pm39ED40/TIx6jupqdAcfLY%2B51xMvNU="
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.TrustParty.GetTrustPartyV1CollaborationTenantsByTargetTenantKeyVisibleOrganizationResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}