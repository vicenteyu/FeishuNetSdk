// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetTrustPartyV1CollaborationTenantsByTargetTenantKeyCollaborationUsersByTargetUserIdResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 获取关联组织成员详情 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.TrustParty;

/// <summary>
/// 测试 获取关联组织成员详情 响应体
/// <para>接口ID：7442539768884625436</para>
/// <para>文档地址：https://open.feishu.cn/document/trust_party-v1/-collaboraiton-organization/get-3</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftrust_party-v1%2fcollaboration_tenant-collaboration_user%2fget</para>
/// </summary>
[TestClass]
public class Test_GetTrustPartyV1CollaborationTenantsByTargetTenantKeyCollaborationUsersByTargetUserIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "target_user": {
            "open_id": "ou_4e6ac4d14bcd5071a37a39de902c7141",
            "user_id": "902c7141",
            "union_id": "on_cad4860e7af114fb4ff6c5d496d1dd76",
            "name": "test_name",
            "i18n_name": {
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
            "mobile": "+41446681800",
            "status": {
                "is_frozen": false,
                "is_resigned": false,
                "is_activated": true,
                "is_exited": true,
                "is_unjoin": false
            },
            "department_ids": [
                "od-4e6ac4d14bcd5071a37a39de902c7141"
            ],
            "leader_user_id": "ou_7dab8a3d3cdcc9da365777c7ad535d62",
            "job_title": "顾问",
            "custom_attrs": [
                {
                    "type": "ENUMERATION",
                    "id": "C-7245579267802529811",
                    "value": {
                        "text": "文本1",
                        "url": "https://www.feishu.cn",
                        "pc_url": "https://www.feishu.cn",
                        "option_value": "v2_d9033c89-a483-4efa-8d17-d02340fb16dj",
                        "picture_url": "https://www.xxxx.com/~?image_size=noop&cut_type=&quality=&format=png&sticker_format=.webp",
                        "name": "名字",
                        "generic_user": {
                            "id": "123456789",
                            "type": 1
                        }
                    }
                }
            ],
            "employee_no": "121212",
            "parent_department_ids": [
                {
                    "department_id": "902c7141",
                    "open_department_id": "od-4e6ac4d14bcd5071a37a39de902c7141"
                }
            ],
            "leader_id": {
                "user_id": "1dfsads",
                "open_id": "ou_8b8d8b4e310575fd7e4947cf6f1402ac",
                "union_id": "on_cad4860e7af114fb4ff6c5d496d1dd76"
            }
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.TrustParty.GetTrustPartyV1CollaborationTenantsByTargetTenantKeyCollaborationUsersByTargetUserIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}