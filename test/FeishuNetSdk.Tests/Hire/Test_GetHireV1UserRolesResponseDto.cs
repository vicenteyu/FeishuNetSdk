namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 获取用户角色列表 响应体
/// <para>接口ID：7044464966434390044</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/recruitment-related-configuration/auth/list-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fuser_role%2flist</para>
/// </summary>
[TestClass]
public class Test_GetHireV1UserRolesResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "SUCCESS",
    "data": {
        "items": [
            {
                "user_id": "7326856229396906012",
                "role_id": "101",
                "modify_time": "1618500278663",
                "role_name": {
                    "zh_cn": "招聘 HRBP",
                    "en_us": "Recruitment HRBP"
                },
                "role_description": {
                    "zh_cn": "赋予HRBP的权限",
                    "en_us": "Authority given to HRBP"
                },
                "business_management_scopes": [
                    {
                        "entity": {
                            "code": "application",
                            "name": {
                                "zh_cn": "测试",
                                "en_us": "test"
                            }
                        },
                        "scope_rule": {
                            "rule_type": 1
                        }
                    }
                ]
            }
        ],
        "has_more": true,
        "page_token": "eyJvZmZzZXQiOjEwLCJ0aW1lc3RhbXAiOjE2Mjc1NTUyMjM2NzIsImlkIjpudWxsfQ=="
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Hire.GetHireV1UserRolesResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}