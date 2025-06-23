namespace FeishuNetSdk.Tests.Contact;

/// <summary>
/// 测试 批量获取部门信息 响应体
/// <para>接口ID：7243624444425519132</para>
/// <para>文档地址：https://open.feishu.cn/document/contact-v3/department/batch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fdepartment%2fbatch</para>
/// </summary>
[TestClass]
public class Test_GetContactV3DepartmentsBatchResponseDto : TestBase
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
                "name": "DemoName",
                "i18n_name": {
                    "zh_cn": "Demo名称",
                    "ja_jp": "デモ名",
                    "en_us": "Demo Name"
                },
                "parent_department_id": "D067",
                "department_id": "D096",
                "open_department_id": "od-4e6ac4d14bcd5071a37a39de902c7141",
                "leader_user_id": "ou_7dab8a3d3cdcc9da365777c7ad535d62",
                "chat_id": "oc_5ad11d72b830411d72b836c20",
                "order": "100",
                "unit_ids": [
                    "custom_unit_id"
                ],
                "member_count": 100,
                "status": {
                    "is_deleted": false
                },
                "leaders": [
                    {
                        "leaderType": 1,
                        "leaderID": "ou_7dab8a3d3cdcc9da365777c7ad535d62"
                    }
                ],
                "group_chat_employee_types": [
                    1
                ],
                "department_hrbps": [
                    "ou_7dab8a3d3cdcc9da365777c7ad535d62"
                ],
                "primary_member_count": 100
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Contact.GetContactV3DepartmentsBatchResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}