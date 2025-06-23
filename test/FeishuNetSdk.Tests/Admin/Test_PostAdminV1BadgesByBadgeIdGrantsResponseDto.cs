namespace FeishuNetSdk.Tests.Admin;

/// <summary>
/// 测试 创建授予名单 响应体
/// <para>接口ID：7104154222309179395</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/admin-v1/badge/badge-grant/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fadmin-v1%2fbadge-grant%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostAdminV1BadgesByBadgeIdGrantsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "grant": {
            "id": "g_49Z7CQ",
            "badge_id": "m_qTR2HM",
            "name": "激励勋章的授予名单",
            "grant_type": 0,
            "time_zone": "Asia/Shanghai",
            "rule_detail": {
                "effective_time": "1649606400",
                "expiration_time": "1649692799",
                "anniversary": 1,
                "effective_period": 1
            },
            "is_grant_all": false,
            "user_ids": [
                "u273y71"
            ],
            "department_ids": [
                "h121921"
            ],
            "group_ids": [
                "g122817"
            ]
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Admin.PostAdminV1BadgesByBadgeIdGrantsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}