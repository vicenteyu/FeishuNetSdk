namespace FeishuNetSdk.Tests.Contact;

/// <summary>
/// 测试 更新部门所有信息 响应体
/// <para>接口ID：6943913881477021723</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/department/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2fdepartment%2fupdate</para>
/// </summary>
[TestClass]
public class Test_PutContactV3DepartmentsByDepartmentIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "department": {
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
                    "leaderID": "ou_357368f98775f04bea02afc6b1d33478",
                    "leaderType": 1
                }
            ],
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Contact.PutContactV3DepartmentsByDepartmentIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}