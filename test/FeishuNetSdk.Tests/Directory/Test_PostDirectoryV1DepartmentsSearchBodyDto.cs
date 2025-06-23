namespace FeishuNetSdk.Tests.Directory;

/// <summary>
/// 测试 搜索部门 请求体
/// <para>接口ID：7359428154233569284</para>
/// <para>文档地址：https://open.feishu.cn/document/directory-v1/department/search</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fdirectory-v1%2fdepartment%2fsearch</para>
/// </summary>
[TestClass]
public class Test_PostDirectoryV1DepartmentsSearchBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "query": "zhang",
    "page_request": {
        "page_size": 100,
        "page_token": "xdcftvygbuhijhgrexr"
    },
    "required_fields": [
        "name"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Directory.PostDirectoryV1DepartmentsSearchBodyDto>(json);
        Assert.IsNotNull(result);
    }
}