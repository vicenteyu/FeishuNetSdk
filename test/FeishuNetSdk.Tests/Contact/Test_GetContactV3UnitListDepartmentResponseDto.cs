namespace FeishuNetSdk.Tests.Contact;

/// <summary>
/// 测试 获取单位绑定的部门列表 响应体
/// <para>接口ID：7023995901275357187</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/unit/list_department</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2funit%2flist_department</para>
/// </summary>
[TestClass]
public class Test_GetContactV3UnitListDepartmentResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "departmentlist": [
            {
                "unit_id": "BU121",
                "department_id": "od-4e6ac4d14bcd5071a37a39de902c7141"
            }
        ],
        "has_more": true,
        "page_token": "AQD9/Rn9eij9Pm39ED40/dk53s4Ebp882DYfFaPFbz00L4CMZJrqGdzNyc8BcZtDbwVUvRmQTvyMYicnGWrde9X56TgdBuS+JdtW="
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Contact.GetContactV3UnitListDepartmentResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}