namespace FeishuNetSdk.Tests.Directory;

/// <summary>
/// 测试 更新在职员工为待离职 请求体
/// <para>接口ID：7390661486131707906</para>
/// <para>文档地址：https://open.feishu.cn/document/directory-v1/employee/to_be_resigned</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fdirectory-v1%2femployee%2fto_be_resigned</para>
/// </summary>
[TestClass]
public class Test_PatchDirectoryV1EmployeesByEmployeeIdToBeResignedBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "employee": {
        "resign_date": "2024-06-21",
        "resign_reason": "1",
        "resign_type": "1",
        "resign_remark": "留学深造"
    }
}
""";
        var result = Deserialize<FeishuNetSdk.Directory.PatchDirectoryV1EmployeesByEmployeeIdToBeResignedBodyDto>(json);
        Assert.IsNotNull(result);
    }
}