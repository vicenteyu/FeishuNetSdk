namespace FeishuNetSdk.Tests.Admin.Spec;

/// <summary>
/// 测试 获取行为审计日志数据 响应体
/// <para>接口ID：6921713375245352988</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/security_and_compliance-v1/audit_log/audit_data_get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuQjM5YjL0ITO24CNykjN%2faudit_log%2faudit_data_get</para>
/// </summary>
[TestClass]
public class Test_GetAdminV1AuditInfosResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
      "msg": "success",
    "data": {
        "has_more": false,
        "items": [
            {
                  "event_id": "7254062411181719572",
                "unique_id": "7254062413199179796",
                "event_module": 1,
                "event_name": "space_edit_doc",
                  "operator_type": 1,
                "operator_value": "4a3b8541",
                "operator_tenant": "F686619755",
                "event_time": 1688968015,
                "audit_context": {
                    "terminal_type": 3,
                    "web_context": {
                        "IP": "fdbd:dc02:ff:1:1:174:246:126",
                        "user_agent": "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_7) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/114.0.0.0 Safari/537.36"
                    }
                },
                "audit_detail": {
                    "city": "",
                    "device_model": "",
                    "mc": "",
                    "os": ""
                },
                "common_drawers": {
                    "common_draw_info_list": [
                        {
                            "info_key": "CCM_op_status",
                            "info_val": "success",
                            "key_i18n_key": "SuiteAdmin_DrawerKeyspaceeditdoc_Kccmopstatus",
                            "val_i18n_key": "SuiteAdmin_DrawerValspaceeditdoc_Kccmopstatusvsuccess",
                            "val_type": "1"
                        },
                        {
                            "info_key": "ccm_edit_part",
                            "info_val": "0",
                            "key_i18n_key": "SuiteAdmin_DrawerKeyspaceeditdoc_Kccmeditpart",
                            "val_i18n_key": "SuiteAdmin_DrawerValspaceeditdoc_Kccmeditpartv0",
                            "val_type": "1"
                        },
                        {
                            "info_key": "ccm_folder_id",
                            "info_val": "nodbcMQRCwBJ5aWEWxQsWsTA5zg",
                            "key_i18n_key": "SuiteAdmin_DrawerKeyspaceeditdoc_Kccmfolderid",
                            "val_i18n_key": "SuiteAdmin_DrawerValspaceeditdoc_Kccmfolderidvnodbcmqrcwbj5awewxqswsta5zg",
                            "val_type": "1"
                        },
                        {
                            "info_key": "ccm_folder_name",
                            "info_val": "",
                            "key_i18n_key": "SuiteAdmin_DrawerKeyspaceeditdoc_Kccmfoldername",
                            "val_i18n_key": "SuiteAdmin_DrawerValspaceeditdoc_Kccmfoldernamev",
                            "val_type": "1"
                        },
                        {
                            "info_key": "ccm",
                            "info_val": "[{\"key\":\"title\",\"keyName\":\"文件名称\",\"value\":\"\",\"valueType\":\"1\",\"valueExtInfo\":null,\"eventFieldInfoList\":null},{\"key\":\"owner\",\"keyName\":\"文件所有者\",\"value\":\"\",\"valueType\":\"3\",\"valueExtInfo\":\"{\\\"type\\\":3,\\\"id\\\":\\\"0\\\",\\\"name\\\":\\\"\\\",\\\"avatar\\\":\\\"\\\",\\\"employee_id\\\":\\\"\\\"}\",\"eventFieldInfoList\":null},{\"key\":\"create_time\",\"keyName\":\"创建时间\",\"value\":\"\",\"valueType\":\"8\",\"valueExtInfo\":null,\"eventFieldInfoList\":null},{\"key\":\"sec_label\",\"keyName\":\"密级标签\",\"value\":\"\",\"valueType\":\"1\",\"valueExtInfo\":null,\"eventFieldInfoList\":null},{\"key\":\"doc_belong_tenant\",\"keyName\":\"是否属于本组织\",\"value\":\"否\",\"valueType\":\"1\",\"valueExtInfo\":null,\"eventFieldInfoList\":null}]",
                            "key_i18n_key": "文件 ID",
                            "val_type": "Lwd1smp3nl01AndDEMzbsfqacBb"
                        },
                        {
                            "info_key": "ccm_type",
                            "info_val": "-",
                            "key_i18n_key": "文件类型"
                        }
                    ]
                },
                "department_ids": [
                    "0",
                    "od-ab89476fbcf901c3e5ccd78f788f85bf"
                ],
                
                "extend": {},
                "ip": "fdbd:dc02:ff:1:1:174:246:126",
                "objects": [
                    {
                        "object_detail": {},
                        "object_name": "",
                        "object_owner": "",
                        "object_type": "106",
                        "object_value": "Lwd1smp3nl01AndDEMzbsfqacBb"
                    }
                ],
                "operator_app": "",
                "operator_app_name": "",
                "recipients": [
                      {
                        "recipient_type": "",
                        "recipient_value": "",
                        "recipient_detail": {
                            "permission_action_type": ""
                        }
                    }
                  ]
            }
        ],
        "page_token": "LC39/f1%2B/Sz9Uv39Gf39/ew/cd5WY0gfGYFdixOW9cW8qPuyh59mg7cXBJKifnqatoP8P2g8URSUi2/4fj5NPJh8VxaPH3yTCnbSZeXzNs4mpQYaUVbp7lTIy1YfIsZ1i0UPASt4qAPObiCewWErhlEG6Qg%2B/6zX7JFBCRsatVcctGTHeL9bb8ssmfdt0Yag"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Admin.Spec.GetAdminV1AuditInfosResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}