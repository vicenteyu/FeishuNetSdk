// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostTaskV2CustomFieldsByCustomFieldGuidRemoveBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 将自定义字段移出资源 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Task;

/// <summary>
/// 测试 将自定义字段移出资源 请求体
/// <para>接口ID：7270765454292205570</para>
/// <para>文档地址：https://open.feishu.cn/document/task-v2/custom_field/remove</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2ftask-v2%2fcustom_field%2fremove</para>
/// </summary>
[TestClass]
public class Test_PostTaskV2CustomFieldsByCustomFieldGuidRemoveBodyDto : TestBase
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
        var result = Deserialize<FeishuNetSdk.Task.PostTaskV2CustomFieldsByCustomFieldGuidRemoveBodyDto>(json);
        Assert.IsNotNull(result);
    }
}