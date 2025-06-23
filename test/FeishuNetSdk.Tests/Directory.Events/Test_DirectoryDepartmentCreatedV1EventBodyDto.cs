namespace FeishuNetSdk.Tests.Directory.Events;

/// <summary>
/// 测试 部门新建 事件体
/// <para>接口ID：7419214646853238788</para>
/// <para>文档地址：https://open.feishu.cn/document/directory-v1/department/events/created</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fdirectory-v1%2fdepartment%2fevents%2fcreated</para>
/// </summary>
[TestClass]
public class Test_DirectoryDepartmentCreatedV1EventBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "schema": "2.0",
    "header": {
        "event_id": "44e76372af7ca7f9a74100dd10ef7932",
        "token": "",
        "create_time": "1726211336000",
        "event_type": "directory.department.created_v1",
        "tenant_key": "133c1eae3c0f1748",
        "app_id": "cli_a23f3400fe78901b"
    },
    "event": {
        "abnormal": {
            "row_error": 0
        },
        "department": {
            "enabled_status": true,
            "leaders": [
                {
                    "leader_id": "ou_xxxx",
                    "leader_type": 1
                },
                {
                    "leader_id": "ou_xxxx",
                    "leader_type": 2
                }
            ],
            "name": {
                "default_value": "部门创建",
                "i18n_value": {
                    "en_us": "",
                    "ja_jp": "",
                    "ms_my": "部门创建",
                    "zh_cn": "部门创建"
                }
            },
            "order_weight": 2000,
            "parent_department_id": "od-xxxx"
        }
    }
}
""";
        var result = Deserialize<EventV2Dto<FeishuNetSdk.Directory.Events.DirectoryDepartmentCreatedV1EventBodyDto>>(json);
        Assert.IsNotNull(result);
    }
}