namespace FeishuNetSdk.Tests.Task;

/// <summary>
/// 测试 更新自定义字段 请求体
/// <para>接口ID：7270765454292254722</para>
/// <para>文档地址：https://open.feishu.cn/document/task-v2/custom_field/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftask-v2%2fcustom_field%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchTaskV2CustomFieldsByCustomFieldGuidBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "custom_field": {
        "name": "优先级",
        "number_setting": {
            "format": "normal",
            "custom_symbol": "€",
            "custom_symbol_position": "left",
            "separator": "thousand",
            "decimal_count": 2
        },
        "member_setting": {
            "multi": true
        },
        "datetime_setting": {
            "format": "yyyy/mm/dd"
        },
        "single_select_setting": {
            "options": [
                {
                    "guid": "4216f79b-3fda-4dc6-a0c4-a16022e47152",
                    "name": "高优",
                    "color_index": 1
                }
            ]
        },
        "multi_select_setting": {
            "options": [
                {
                    "guid": "4216f79b-3fda-4dc6-a0c4-a16022e47152",
                    "name": "高优",
                    "color_index": 1
                }
            ]
        },
        "text_setting": {}
    },
    "update_fields": [
        "name"
    ]
}
""";
        var result = Deserialize<FeishuNetSdk.Task.PatchTaskV2CustomFieldsByCustomFieldGuidBodyDto>(json);
        Assert.IsNotNull(result);
    }
}