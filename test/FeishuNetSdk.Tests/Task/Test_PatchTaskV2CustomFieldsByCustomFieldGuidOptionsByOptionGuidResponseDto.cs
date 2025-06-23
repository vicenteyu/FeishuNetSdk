namespace FeishuNetSdk.Tests.Task;

/// <summary>
/// 测试 更新自定义字段选项 响应体
/// <para>接口ID：7270765454292221954</para>
/// <para>文档地址：https://open.feishu.cn/document/task-v2/custom_field-option/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftask-v2%2fcustom_field-option%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchTaskV2CustomFieldsByCustomFieldGuidOptionsByOptionGuidResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "option": {
            "guid": "4216f79b-3fda-4dc6-a0c4-a16022e47152",
            "name": "高优",
            "color_index": 1,
            "is_hidden": false
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Task.PatchTaskV2CustomFieldsByCustomFieldGuidOptionsByOptionGuidResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}