namespace FeishuNetSdk.Tests.FeishuPeople;

/// <summary>
/// 测试 更新人员类型 请求体
/// <para>接口ID：7021731966426415107</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/basic-infomation/employee_type/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2femployee_type%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchCorehrV1EmployeeTypesByEmployeeTypeIdBodyDto : TestBase
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
        var result = Deserialize<FeishuNetSdk.FeishuPeople.PatchCorehrV1EmployeeTypesByEmployeeTypeIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}