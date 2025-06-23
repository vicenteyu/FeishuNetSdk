namespace FeishuNetSdk.Tests.FeishuPeople;

/// <summary>
/// 测试 查询单个人员类型 响应体
/// <para>接口ID：7017707615190843395</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/corehr-v1/basic-infomation/employee_type/get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcorehr-v1%2femployee_type%2fget</para>
/// </summary>
[TestClass]
public class Test_GetCorehrV1EmployeeTypesByEmployeeTypeIdResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "employee_type": {
            "id": "6919732473504990727",
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
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.FeishuPeople.GetCorehrV1EmployeeTypesByEmployeeTypeIdResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}