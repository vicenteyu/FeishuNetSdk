namespace FeishuNetSdk.Tests.CompensationManagement;

/// <summary>
/// 测试 批量查询员工薪资档案 请求体
/// <para>接口ID：7314129756769746948</para>
/// <para>文档地址：https://open.feishu.cn/document/corehr-v1/basic-compensation/archive/query</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcompensation-v1%2farchive%2fquery</para>
/// </summary>
[TestClass]
public class Test_PostCompensationV1ArchivesQueryBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "user_id_list": [
        "7117649868058789407"
    ],
    "tid_list": [
        "141541351"
    ],
    "effective_start_date": "2022-05-10",
    "effective_end_date": "2023-05-15"
}
""";
        var result = Deserialize<FeishuNetSdk.CompensationManagement.PostCompensationV1ArchivesQueryBodyDto>(json);
        Assert.IsNotNull(result);
    }
}