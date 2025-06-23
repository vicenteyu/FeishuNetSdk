namespace FeishuNetSdk.Tests.Directory;

/// <summary>
/// 测试 获取关联组织双方共享成员范围 响应体
/// <para>接口ID：7442539768884609052</para>
/// <para>文档地址：https://open.feishu.cn/document/trust_party-v1/-collaboraiton-organization/list-3</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fdirectory-v1%2fcollboration_share_entity%2flist</para>
/// </summary>
[TestClass]
public class Test_GetDirectoryV1ShareEntitiesResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "page_token": "eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=",
        "has_more": true,
        "share_departments": [
            {
                "open_department_id": "ou-12121xxxx",
                "name": {
                    "default_value": "张三",
                    "i18n_value": {
                        "en_us": "test"
                    }
                }
            }
        ],
        "share_groups": [
            {
                "open_group_id": "ou-12121212",
                "name": {
                    "default_value": "张三",
                    "i18n_value": {
                        "en_us": "test"
                    }
                }
            }
        ],
        "share_users": [
            {
                "open_user_id": "ou-12121212",
                "name": {
                    "default_value": "张三",
                    "i18n_value": {
                        "en_us": "test"
                    }
                },
                "avatar": {
                    "avatar_72": "http://qwed.com",
                    "avatar_240": "http://wssd.com",
                    "avatar_640": "http://wssd.com",
                    "avatar_origin": "https:inernal-api/image"
                }
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Directory.GetDirectoryV1ShareEntitiesResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}