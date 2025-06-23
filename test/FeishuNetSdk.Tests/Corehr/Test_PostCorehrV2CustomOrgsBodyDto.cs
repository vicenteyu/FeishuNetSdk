namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 创建自定义组织 请求体
/// <para>接口ID：7358017162446503940</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/organization-management/custom_org/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fcustom_org%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2CustomOrgsBodyDto : TestBase
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
            "value": "飞书人事"
        }
    ],
    "code": "000001（格式和配置的匹配规则相关）",
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
    ],
    "custom_fields": [
        {
            "custom_api_name": "name",
            "value": "\"231\""
        }
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Corehr.PostCorehrV2CustomOrgsBodyDto>(json);
        Assert.IsNotNull(result);
    }
}