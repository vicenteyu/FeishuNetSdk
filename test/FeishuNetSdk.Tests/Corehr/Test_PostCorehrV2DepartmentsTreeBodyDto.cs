namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 查询指定生效日期的部门架构树 请求体
/// <para>接口ID：7405851978397581314</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/organization-management/department/tree</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fdepartment%2ftree</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2DepartmentsTreeBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "department_id": "6893014062142064111",
    "need_inactive": false,
    "effective_date": "2024-01-01"
}
""";
        var result = Deserialize<FeishuNetSdk.Corehr.PostCorehrV2DepartmentsTreeBodyDto>(json);
        Assert.IsNotNull(result);
    }
}