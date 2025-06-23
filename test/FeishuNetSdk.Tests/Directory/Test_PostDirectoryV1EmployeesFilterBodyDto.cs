namespace FeishuNetSdk.Tests.Directory;

/// <summary>
/// 测试 批量获取员工列表 请求体
/// <para>接口ID：7359428154233683972</para>
/// <para>文档地址：https://open.feishu.cn/document/directory-v1/employee/filter</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fdirectory-v1%2femployee%2ffilter</para>
/// </summary>
[TestClass]
public class Test_PostDirectoryV1EmployeesFilterBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "filter": {
        "conditions": [
            {
                "field": "base_info.mobile",
                "operator": "eq",
                "value": "\"8619922333322\""
            }
        ]
    },
    "required_fields": [
        "base_info.gender"
    ],
    "page_request": {
        "page_size": 10,
        "page_token": ""
    }
}
""";
        var result = Deserialize<FeishuNetSdk.Directory.PostDirectoryV1EmployeesFilterBodyDto>(json);
        Assert.IsNotNull(result);
    }
}