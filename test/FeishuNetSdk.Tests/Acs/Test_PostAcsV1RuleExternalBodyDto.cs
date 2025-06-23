namespace FeishuNetSdk.Tests.Acs;

/// <summary>
/// 测试 创建或更新权限组 请求体
/// <para>接口ID：7321978105899122716</para>
/// <para>文档地址：https://open.feishu.cn/document/acs-v1/rule_external/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2facs-v1%2frule_external%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostAcsV1RuleExternalBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "rule": {
        "id": "34252345234523",
        "name": "南门",
        "devices": [
            {
                "id": "534545234523452345",
                "name": "北门"
            }
        ],
        "user_count": "3",
        "users": [
            {
                "user_type": 1,
                "user_id": "ou_7dab8a3d3cdcc9da365777c7ad535d62",
                "user_name": "张三",
                "phone_num": "1357890001",
                "department_id": "od-f7d44ab733f7602f5cc5194735fd9aaf"
            }
        ],
        "visitor_count": "3",
        "visitors": [
            {
                "user_type": 1,
                "user_id": "ou_7dab8a3d3cdcc9da365777c7ad535d62",
                "user_name": "张三",
                "phone_num": "1357890001",
                "department_id": "od-f7d44ab733f7602f5cc5194735fd9aaf"
            }
        ],
        "remind_face": false,
        "opening_time": {
            "valid_day": {
                "start_day": 1699031483,
                "end_day": 1699931483
            },
            "weekdays": [
                1,
                2,
                3
            ],
            "day_times": [
                {
                    "start_hhmm": 1200,
                    "end_hhmm": 1400
                }
            ]
        },
        "is_temp": false
    }
}
""";
        var result = Deserialize<FeishuNetSdk.Acs.PostAcsV1RuleExternalBodyDto>(json);
        Assert.IsNotNull(result);
    }
}