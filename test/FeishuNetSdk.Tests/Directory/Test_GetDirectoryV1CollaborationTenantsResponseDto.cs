namespace FeishuNetSdk.Tests.Directory;

/// <summary>
/// 测试 管理员获取所有关联组织列表 响应体
/// <para>接口ID：7442539768884592668</para>
/// <para>文档地址：https://open.feishu.cn/document/trust_party-v1/-collaboraiton-organization/list-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fdirectory-v1%2fcollaboration_tenant%2flist</para>
/// </summary>
[TestClass]
public class Test_GetDirectoryV1CollaborationTenantsResponseDto : TestBase
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
                "tenant_key": "121s121234df",
                "connect_time": 1724296400,
                "avatar": {
                    "avatar_72": "http://qwed.com",
                    "avatar_240": "http://wssd.com",
                    "avatar_640": "http://wssd.com",
                    "avatar_origin": "https:inernal-api/image"
                },
                "brand": "feishu",
                "name": {
                    "default_value": "张三",
                    "i18n_value": {
                        "en_us": "test"
                    }
                },
                "short_name": {
                    "default_value": "张三",
                    "i18n_value": {
                        "en_us": "test"
                    }
                }
            }
        ],
        "page_token": "eVQrYzJBNDNONlk4VFZBZVlSdzlKdFJ4bVVHVExENDNKVHoxaVdiVnViQT0=",
        "has_more": true
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Directory.GetDirectoryV1CollaborationTenantsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}