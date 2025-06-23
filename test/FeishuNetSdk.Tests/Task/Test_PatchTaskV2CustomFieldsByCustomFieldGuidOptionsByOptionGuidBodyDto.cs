namespace FeishuNetSdk.Tests.Task;

/// <summary>
/// 测试 更新自定义字段选项 请求体
/// <para>接口ID：7270765454292221954</para>
/// <para>文档地址：https://open.feishu.cn/document/task-v2/custom_field-option/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftask-v2%2fcustom_field-option%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchTaskV2CustomFieldsByCustomFieldGuidOptionsByOptionGuidBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "option": {
        "name": "高优",
        "color_index": 10,
        "insert_before": "2bd905f8-ef38-408b-aa1f-2b2ad33b2913",
        "insert_after": "b13adf3c-cad6-4e02-8929-550c112b5633",
        "is_hidden": false
    },
    "update_fields": [
        "name"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Task.PatchTaskV2CustomFieldsByCustomFieldGuidOptionsByOptionGuidBodyDto>(json);
        Assert.IsNotNull(result);
    }
}