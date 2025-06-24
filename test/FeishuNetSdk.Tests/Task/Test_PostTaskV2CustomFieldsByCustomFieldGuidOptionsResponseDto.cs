// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostTaskV2CustomFieldsByCustomFieldGuidOptionsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 创建自定义任务选项 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Task;

/// <summary>
/// 测试 创建自定义任务选项 响应体
/// <para>接口ID：7270765454292287490</para>
/// <para>文档地址：https://open.feishu.cn/document/task-v2/custom_field-option/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftask-v2%2fcustom_field-option%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostTaskV2CustomFieldsByCustomFieldGuidOptionsResponseDto : TestBase
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
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Task.PostTaskV2CustomFieldsByCustomFieldGuidOptionsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}