// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PatchContactV3UnitByUnitIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 修改单位信息 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Contact;

/// <summary>
/// 测试 修改单位信息 请求体
/// <para>接口ID：7023995901275258883</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/contact-v3/unit/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fcontact-v3%2funit%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchContactV3UnitByUnitIdBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "name": "消费者事业部"
}
""";
        var result = Deserialize<FeishuNetSdk.Contact.PatchContactV3UnitByUnitIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}