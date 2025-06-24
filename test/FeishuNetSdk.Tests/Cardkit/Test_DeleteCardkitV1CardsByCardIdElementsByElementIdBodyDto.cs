// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_DeleteCardkitV1CardsByCardIdElementsByElementIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 删除组件 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Cardkit;

/// <summary>
/// 测试 删除组件 请求体
/// <para>接口ID：7397253002364600323</para>
/// <para>文档地址：https://open.feishu.cn/document/cardkit-v1/card-element/delete</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2fcardkit-v1%2fcard-element%2fdelete</para>
/// </summary>
[TestClass]
public class Test_DeleteCardkitV1CardsByCardIdElementsByElementIdBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "uuid": "191857678434",
    "sequence": 1
}
""";
        var result = Deserialize<FeishuNetSdk.Cardkit.DeleteCardkitV1CardsByCardIdElementsByElementIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}