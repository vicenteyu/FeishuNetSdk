namespace FeishuNetSdk.Tests.Directory;

/// <summary>
/// 测试 创建员工 响应体
/// <para>接口ID：7359428154233651204</para>
/// <para>文档地址：https://open.feishu.cn/document/directory-v1/employee/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fdirectory-v1%2femployee%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostDirectoryV1EmployeesResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "employee_id": "sderdt"
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Directory.PostDirectoryV1EmployeesResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}