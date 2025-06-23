namespace FeishuNetSdk.Tests.FeishuPeople;

/// <summary>
/// 测试 创建人员类型 请求体
/// <para>接口ID：7017707615190892547</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/basic-infomation/employee_type/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2femployee_type%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV1EmployeeTypesBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "name": [
        {
            "lang": "zh-CN",
            "value": "张三"
        }
    ],
    "default_employee_type": true,
    "active": true,
    "code": "1245",
    "custom_fields": [
        {
            "field_name": "name",
            "value": "\"Sandy\""
        }
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.FeishuPeople.PostCorehrV1EmployeeTypesBodyDto>(json);
        Assert.IsNotNull(result);
    }
}