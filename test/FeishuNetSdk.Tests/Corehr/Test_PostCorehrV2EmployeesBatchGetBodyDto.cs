namespace FeishuNetSdk.Tests.Corehr;

/// <summary>
/// 测试 批量查询员工信息 请求体
/// <para>接口ID：7252969409509490692</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/employee/batch_get</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcorehr-v2%2femployee%2fbatch_get</para>
/// </summary>
[TestClass]
public class Test_PostCorehrV2EmployeesBatchGetBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "fields": [
        "person_info.phone_number"
    ],
    "employment_ids": [
        "7140964208476371111"
    ],
    "person_ids": [
        "7051837122449458732"
    ],
    "work_emails": [
        "zhangsan@example.feishu.cn"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Corehr.PostCorehrV2EmployeesBatchGetBodyDto>(json);
        Assert.IsNotNull(result);
    }
}