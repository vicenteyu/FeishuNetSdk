namespace FeishuNetSdk.Tests.Ccm.Events;

/// <summary>
/// 测试 多维表格字段变更 事件体
/// <para>接口ID：7152791669179596804</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/drive-v1/event/list/bitable_field_changed</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fdrive-v1%2ffile%2fevents%2fbitable_field_changed</para>
/// </summary>
[TestClass]
public class Test_DriveFileBitableFieldChangedV1EventBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "schema": "2.0",
    "header": {
        "event_id": "5e3702a84e847582be8db7fb73283c02",
        "event_type": "drive.file.bitable_field_changed_v1",
        "create_time": "1608725989000",
        "token": "rvaYgkND1GOiu5MM0E1rncYC6PLtF7JV",
        "app_id": "cli_9f5343c580712544",
        "tenant_key": "2ca1d211f64f6438"
    },
    "event": {
        "file_type": "bitable",
        "file_token": "bascntUPmnoH9kZbGJ8RWeabcef",
        "table_id": "tblWXe2d0I0abcef",
        "operator_id": {
            "union_id": "on_8ed6aa67826108097d9ee143816345",
            "user_id": "e33ggbyz",
            "open_id": "ou_84aad35d084aa403a838cf73ee18467"
        },
        "action_list": [
            {
                "action": "field_edited",
                "field_id": "fldmj5qNii",
                "before_value": {
                    "id": "fldmj5qNii",
                    "name": "field name",
                    "type": 20,
                    "description": "description",
                    "property": {
                        "formatter": "1,000",
                        "date_formatter": "yyyyMMdd",
                        "auto_fill": true,
                        "multiple": true,
                        "table_id": "tblIniLz0Ic8oXyN",
                        "table_name": "table name",
                        "back_field_name": "field name",
                        "input_type": "only_mobile",
                        "back_field_id": "fldmj5qNii",
                        "auto_serial": {
                            "type": "custom",
                            "options": [
                                {
                                    "type": "created_time",
                                    "value": "yyyyMMdd"
                                }
                            ]
                        },
                        "options": [
                            {
                                "name": "option name",
                                "id": "optabcef",
                                "color": 3
                            }
                        ],
                        "formula_expression": "bitable::$table[tblIniLz0Ic8oXyN].$field[fldqatAwxx]*6+333"
                    }
                },
                "after_value": {
                    "id": "fldmj5qNii",
                    "name": "field name",
                    "type": 20,
                    "description": "description",
                    "property": {
                        "formatter": "1,000",
                        "date_formatter": "yyyyMMdd",
                        "auto_fill": true,
                        "multiple": true,
                        "table_id": "tblIniLz0Ic8oXyN",
                        "table_name": "table name",
                        "back_field_name": "field name",
                        "input_type": "only_mobile",
                        "back_field_id": "fldmj5qNii",
                        "auto_serial": {
                            "type": "custom",
                            "options": [
                                {
                                    "type": "created_time",
                                    "value": "yyyyMMdd"
                                }
                            ]
                        },
                        "options": [
                            {
                                "name": "option name",
                                "id": "optabcef",
                                "color": 3
                            }
                        ],
                        "formula_expression": "bitable::$table[tblIniLz0Ic8oXyN].$field[fldqatAwxx]*6+333"
                    }
                }
            }
        ],
        "revision": 10,
        "subscriber_id_list": [
            {
                "union_id": "on_876b570a984d02ab1c0906a49e4abcef",
                "user_id": "638474b8",
                "open_id": "ou_9bc587355789fc049904ae7c736abcef"
            }
        ],
        "update_time": 1663727688
    }
}
""";
        var result = Deserialize<EventV2Dto<FeishuNetSdk.Ccm.Events.DriveFileBitableFieldChangedV1EventBodyDto>>(json);
        Assert.IsNotNull(result);
    }
}