namespace FeishuNetSdk.Tests.Directory;

/// <summary>
/// 测试 查询可搜可见规则 响应体
/// <para>接口ID：7442539768884543516</para>
/// <para>文档地址：https://open.feishu.cn/document/trust_party-v1/searchable-and-visible-rules/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fdirectory-v1%2fcollaboration_rule%2flist</para>
/// </summary>
[TestClass]
public class Test_GetDirectoryV1CollaborationRulesResponseDto : TestBase
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
                "rule_id": "12121",
                "subjects": {
                    "open_user_ids": [
                        "od-112121"
                    ],
                    "open_department_ids": [
                        "od-12121212"
                    ],
                    "open_group_ids": [
                        "od-12121"
                    ]
                },
                "subject_is_valid": true,
                "objects": {
                    "open_user_ids": [
                        "od-112121"
                    ],
                    "open_department_ids": [
                        "od-12121212"
                    ],
                    "open_group_ids": [
                        "od-12121"
                    ]
                },
                "object_is_valid": true
            }
        ],
        "page_token": "eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=",
        "has_more": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Directory.GetDirectoryV1CollaborationRulesResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}