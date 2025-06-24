// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_DirectoryDepartmentUpdatedV1EventBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 部门信息被修改 事件体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Directory.Events;

/// <summary>
/// 测试 部门信息被修改 事件体
/// <para>接口ID：7419214646853156868</para>
/// <para>文档地址：https://open.feishu.cn/document/directory-v1/department/events/updated</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fdirectory-v1%2fdepartment%2fevents%2fupdated</para>
/// </summary>
[TestClass]
public class Test_DirectoryDepartmentUpdatedV1EventBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "schema": "2.0",
    "header": {
        "event_id": "cf50fb434a9f25f84ab58b9bc7bbfde7",
        "token": "",
        "create_time": "1726228345000",
        "event_type": "directory.department.updated_v1",
        "tenant_key": "133c1eae3c0f1748",
        "app_id": "cli_a23f3400fe78901b"
    },
    "event": {
        "abnormal": {
            "row_error": 0
        },
        "changed_properties": [
            "name"
        ],
        "department_curr": {
            "department_id": "od-xxxx",
            "enabled_status": true,
            "leaders": [
                {
                    "leader_id": "ou_xxxx",
                    "leader_type": 1
                }
            ],
            "name": {
                "default_value": "xxxx",
                "i18n_value": {
                    "en_us": "",
                    "ja_jp": "",
                    "zh_cn": "11111123"
                }
            },
            "order_weight": 2000
        },
        "department_prev": {
            "department_id": "od-xxxx",
            "name": {
                "default_value": "xxxx",
                "i18n_value": {
                    "en_us": "",
                    "ja_jp": "",
                    "zh_cn": "1111112"
                }
            }
        }
    }
}
""";
        var result = Deserialize<EventV2Dto<FeishuNetSdk.Directory.Events.DirectoryDepartmentUpdatedV1EventBodyDto>>(json);
        Assert.IsNotNull(result);
    }
}