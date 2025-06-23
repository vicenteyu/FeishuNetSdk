namespace FeishuNetSdk.Tests.Task;

/// <summary>
/// 测试 创建自定义任务选项 请求体
/// <para>接口ID：7270765454292287490</para>
/// <para>文档地址：https://open.feishu.cn/document/task-v2/custom_field-option/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftask-v2%2fcustom_field-option%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostTaskV2CustomFieldsByCustomFieldGuidOptionsBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "name": "高优",
    "color_index": 10,
    "insert_before": "2bd905f8-ef38-408b-aa1f-2b2ad33b2913",
    "insert_after": "b13adf3c-cad6-4e02-8929-550c112b5633",
    "is_hidden": false
}
""";
        var result = Deserialize<FeishuNetSdk.Task.PostTaskV2CustomFieldsByCustomFieldGuidOptionsBodyDto>(json);
        Assert.IsNotNull(result);
    }
}