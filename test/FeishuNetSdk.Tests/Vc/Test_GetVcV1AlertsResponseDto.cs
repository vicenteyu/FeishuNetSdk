namespace FeishuNetSdk.Tests.Vc;

/// <summary>
/// 测试 获取告警记录 响应体
/// <para>接口ID：7146108826851770396</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/vc-v1/alert/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fvc-v1%2falert%2flist</para>
/// </summary>
[TestClass]
public class Test_GetVcV1AlertsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "has_more": true,
        "page_token": "50",
        "items": [
            {
                "alert_id": "7115030004018184212",
                "resource_scope": "XX层级",
                "monitor_target": 2,
                "alert_strategy": "连续1个周期（共1分钟），控制器电量 < 50%，则告警",
                "alert_time": "1656914944",
                "alert_level": 2,
                "contacts": [
                    {
                        "contact_type": 1,
                        "contact_name": "张三"
                    }
                ],
                "notifyMethods": [
                    [
                        0,
                        1
                    ]
                ],
                "alertRule": "签到板断开连接",
                "process_time": "1656914944",
                "recover_time": "1656914944",
                "process_status": 2,
                "alert_rule_id": "100",
                "monitor_target_room_id": "omm_4de32cf10a4358788ff4e09e37ebbf9b",
                "monitor_target_room_mac": "52:60:19:9c:97:21"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Vc.GetVcV1AlertsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}