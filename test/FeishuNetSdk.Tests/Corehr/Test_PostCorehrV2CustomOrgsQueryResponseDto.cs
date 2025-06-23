namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 查询自定义组织信息 响应体
/// <para>接口ID：7358017162446520324</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/organization-management/custom_org/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fcustom_org%2fquery</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2CustomOrgsQueryResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "items": [
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
                        "api_name": "hcm_corehr_xxx",
                        "security_group_id": "7034393015968122400",
                        "employment_ids": [
                            "123456789"
                        ],
                        "inherit_employment_ids": [
                            "123456789"
                        ]
                    }
                ],
                "match_rule_groups": [
                    {
                        "match_rules": [
                            {
                                "left_value": "department",
                                "operator": "contains",
                                "right_values": [
                                    "123456789"
                                ]
                            }
                        ]
                    }
                ],
                "active": true,
                "org_id": "6862995757234914824",
                "custom_fields": [
                    {
                        "custom_api_name": "name",
                        "name": {
                            "zh_cn": "自定义姓名",
                            "en_us": "Custom Name"
                        },
                        "type": 1,
                        "value": "\"231\""
                    }
                ]
            }
        ],
        "page_token": "eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=",
        "has_more": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Corehr.PostCorehrV2CustomOrgsQueryResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}