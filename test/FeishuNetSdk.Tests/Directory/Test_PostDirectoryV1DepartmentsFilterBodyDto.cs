namespace FeishuNetSdk.Tests.Directory;

/// <summary>
/// 测试 批量获取部门列表 请求体
/// <para>接口ID：7359428154233700356</para>
/// <para>文档地址：https://open.feishu.cn/document/directory-v1/department/filter</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fdirectory-v1%2fdepartment%2ffilter</para>
/// </summary>
[TestClass]
public class Test_PostDirectoryV1DepartmentsFilterBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "filter": {
        "conditions": [
            {
                "field": "parent_department_id",
                "operator": "eq",
                "value": "\"0\""
            }
        ]
    },
    "required_fields": [
        "name"
    ],
    "page_request": {
        "page_size": 100,
        "page_token": "iuu14140aknladna91ndas"
    }
}
""";
        var result = Deserialize<FeishuNetSdk.Directory.PostDirectoryV1DepartmentsFilterBodyDto>(json);
        Assert.IsNotNull(result);
    }
}