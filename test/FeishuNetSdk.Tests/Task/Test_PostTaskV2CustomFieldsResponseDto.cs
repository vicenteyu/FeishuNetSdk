namespace FeishuNetSdk.Tests.Task;

/// <summary>
/// 测试 创建自定义字段 响应体
/// <para>接口ID：7270765454292320258</para>
/// <para>文档地址：https://open.feishu.cn/document/task-v2/custom_field/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftask-v2%2fcustom_field%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostTaskV2CustomFieldsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "custom_field": {
            "guid": "34d4b29f-3d58-4bc5-b752-6be80fb687c8",
            "name": "优先级",
            "type": "number",
            "number_setting": {
                "format": "normal",
                "custom_symbol": "自定义符号",
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
                        "color_index": 1,
                        "is_hidden": false
                    }
                ]
            },
            "multi_select_setting": {
                "options": [
                    {
                        "guid": "4216f79b-3fda-4dc6-a0c4-a16022e47152",
                        "name": "高优",
                        "color_index": 1,
                        "is_hidden": false
                    }
                ]
            },
            "creator": {
                "id": "ou_2cefb2f014f8d0c6c2d2eb7bafb0e54f",
                "type": "user",
                "role": "creator"
            },
            "created_at": "1688196600000",
            "updated_at": "1688196600000",
            "text_setting": {}
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Task.PostTaskV2CustomFieldsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}