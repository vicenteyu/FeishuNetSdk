namespace FeishuNetSdk.Tests.Task;

/// <summary>
/// 测试 将自定义字段加入资源 请求体
/// <para>接口ID：7270765454292189186</para>
/// <para>文档地址：https://open.feishu.cn/document/task-v2/custom_field/add</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftask-v2%2fcustom_field%2fadd</para>
/// </summary>
[TestClass]
public class Test_PostTaskV2CustomFieldsByCustomFieldGuidAddBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "resource_type": "tasklist",
    "resource_id": "0110a4bd-f24b-4a93-8c1a-1732b94f9593"
}
""";
        var result = Deserialize<FeishuNetSdk.Task.PostTaskV2CustomFieldsByCustomFieldGuidAddBodyDto>(json);
        Assert.IsNotNull(result);
    }
}