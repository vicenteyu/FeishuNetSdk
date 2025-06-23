namespace FeishuNetSdk.Tests.Application;

/// <summary>
/// 测试 获取应用版本中开发者申请的通讯录权限范围 响应体
/// <para>接口ID：7218093640928165892</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/application-v6/application/contacts_range_suggest</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fapplication-v6%2fapplication-app_version%2fcontacts_range_suggest</para>
/// </summary>
[TestClass]
public class Test_GetApplicationV6ApplicationsByAppIdAppVersionsByVersionIdContactsRangeSuggestResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "contacts_range": {
            "contacts_scope_type": "some",
            "visible_list": {
                "open_ids": [
                    "ou_4065981088f8ef67a504ba8bd6b24d85"
                ],
                "department_ids": [
                    "od-4b4a6907ad726ea07b27b0d2882b7c65"
                ],
                "group_ids": [
                    "b6d1g5dd6fd26186"
                ]
            }
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Application.GetApplicationV6ApplicationsByAppIdAppVersionsByVersionIdContactsRangeSuggestResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}