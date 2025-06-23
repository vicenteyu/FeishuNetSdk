namespace FeishuNetSdk.Tests.Directory;

/// <summary>
/// 测试 批量获取部门信息 请求体
/// <para>接口ID：7359428234122854404</para>
/// <para>文档地址：https://open.feishu.cn/document/directory-v1/department/mget</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fdirectory-v1%2fdepartment%2fmget</para>
/// </summary>
[TestClass]
public class Test_PostDirectoryV1DepartmentsMgetBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "department_ids": [
        "adqwea"
    ],
    "required_fields": [
        "name"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Directory.PostDirectoryV1DepartmentsMgetBodyDto>(json);
        Assert.IsNotNull(result);
    }
}