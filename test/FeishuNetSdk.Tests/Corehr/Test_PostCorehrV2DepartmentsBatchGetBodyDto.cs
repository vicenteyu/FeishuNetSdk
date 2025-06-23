namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 批量查询部门 请求体
/// <para>接口ID：7280432392631549953</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/organization-management/department/batch_get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2fdepartment%2fbatch_get</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2DepartmentsBatchGetBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "department_id_list": [
        "7094136522860922111"
    ],
    "fields": [
        "version_id"
    ],
    "department_name_list": [
        "综合部"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Corehr.PostCorehrV2DepartmentsBatchGetBodyDto>(json);
        Assert.IsNotNull(result);
    }
}