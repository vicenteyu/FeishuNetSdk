namespace FeishuNetSdk.Tests.Application;

/// <summary>
/// 测试 查看待审核的应用列表 响应体
/// <para>接口ID：6989432329400254465</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/application-v6/application/underauditlist</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapplication-v6%2fapplication%2funderauditlist</para>
/// </summary>
[TestClass]
public class Test_GetApplicationV6ApplicationsUnderauditlistResponseDto : TestBase
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
                "app_id": "cli_9b445f5258795107",
                "creator_id": "ou_d317f090b7258ad0372aa53963cda70d",
                "status": 1,
                "scene_type": 0,
                "payment_type": 0,
                "create_source": "base",
                "redirect_urls": [
                    "https://www.example.com"
                ],
                "online_version_id": "oav_d317f090b7258ad0372aa53963cda70d",
                "unaudit_version_id": "oav_d317f090b7258ad0372aa53963cda70d",
                "app_name": "应用名称",
                "avatar_url": "https://sf1-ttcdn-tos.pstatp.com/img/avatar/d279000ca4d3f7f6aaff~72x72.jpg",
                "description": "应用描述",
                "scopes": [
                    {
                        "scope": "contact:user.base",
                        "description": "获取应用信息",
                        "level": 1
                    }
                ],
                "back_home_url": "https://www.example.com",
                "i18n": [
                    {
                        "i18n_key": "zh_cn",
                        "name": "应用名称",
                        "description": "应用描述",
                        "help_use": "https://www.example.com"
                    }
                ],
                "primary_language": "zh_cn",
                "common_categories": [
                    "分析工具"
                ],
                "owner": {
                    "type": 0,
                    "owner_id": "ou_d317f090b7258ad0372aa53963cda70d",
                    "name": "test tenant",
                    "help_desk": "https://applink.feishu.cn/client/helpdesk/open?id=6940534140529803284",
                    "email": "test123@163.com",
                    "phone": "1234534234234",
                    "customer_service_account": "feishu@bytedance.com"
                },
                "mobile_default_ability": "gadget",
                "pc_default_ability": "gadget"
            }
        ],
        "has_more": true,
        "page_token": "new-xxxxxxxxxxx"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Application.GetApplicationV6ApplicationsUnderauditlistResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}