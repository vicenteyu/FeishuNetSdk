namespace FeishuNetSdk.Tests.Hire;

/// <summary>
/// 测试 更新 e-HR 导入任务结果 请求体
/// <para>接口ID：6992933256561426436</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/hire-v1/candidate-management/delivery-process-management/onboard/patch-2</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fukTMukTMukTM%2fuMzM1YjLzMTN24yMzUjN%2fhire-v1%2fehr_import_task%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchHireV1EhrImportTasksByEhrImportTaskIdBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "fail_reason": "当前 HC 不可用",
    "redirect_url": "https://example.com",
    "state": 2
}
""";
        var result = Deserialize<FeishuNetSdk.Hire.PatchHireV1EhrImportTasksByEhrImportTaskIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}