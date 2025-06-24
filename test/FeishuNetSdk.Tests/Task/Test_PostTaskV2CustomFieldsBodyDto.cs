// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostTaskV2CustomFieldsBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 创建自定义字段 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Task;

/// <summary>
/// 测试 创建自定义字段 请求体
/// <para>接口ID：7270765454292320258</para>
/// <para>文档地址：https://open.feishu.cn/document/task-v2/custom_field/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftask-v2%2fcustom_field%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostTaskV2CustomFieldsBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "resource_type": "tasklist",
    "resource_id": "ec5ed63d-a4a9-44de-a935-7ba243471c0a",
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
                "name": "高优",
                "color_index": 1,
                "is_hidden": false
            }
        ]
    },
    "multi_select_setting": {
        "options": [
            {
                "name": "高优",
                "color_index": 1,
                "is_hidden": false
            }
        ]
    },
    "text_setting": {}
}
""";
        var result = Deserialize<FeishuNetSdk.Task.PostTaskV2CustomFieldsBodyDto>(json);
        Assert.IsNotNull(result);
    }
}