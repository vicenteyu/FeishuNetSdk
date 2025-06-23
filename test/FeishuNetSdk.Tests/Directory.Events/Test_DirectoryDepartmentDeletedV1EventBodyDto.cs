namespace FeishuNetSdk.Tests.Directory.Events;

/// <summary>
/// 测试 部门被删除 事件体
/// <para>接口ID：7419214646853189636</para>
/// <para>文档地址：https://open.feishu.cn/document/directory-v1/department/events/deleted</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fdirectory-v1%2fdepartment%2fevents%2fdeleted</para>
/// </summary>
[TestClass]
public class Test_DirectoryDepartmentDeletedV1EventBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "schema": "2.0",
    "header": {
        "event_id": "b47727586e16bc609ca6d3b4c356a5d9",
        "token": "",
        "create_time": "1726211309000",
        "event_type": "directory.department.deleted_v1",
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
                "default_value": "11111223231",
                "i18n_value": {
                    "en_us": "",
                    "ja_jp": "",
                    "zh_cn": "11111223231"
                }
            },
            "order_weight": 4000,
            "parent_department_id": "od-xxxx"
        }
    }
}
""";
        var result = Deserialize<EventV2Dto<FeishuNetSdk.Directory.Events.DirectoryDepartmentDeletedV1EventBodyDto>>(json);
        Assert.IsNotNull(result);
    }
}