// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PutBitableV1AppsByAppTokenBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 更新多维表格元数据 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Base;

/// <summary>
/// 测试 更新多维表格元数据 请求体
/// <para>接口ID：7073673019918811164</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/app/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp%2fupdate</para>
/// </summary>
[TestClass]
public class Test_PutBitableV1AppsByAppTokenBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "name": "新的多维表格名称",
    "is_advanced": true
}
""";
        var result = Deserialize<FeishuNetSdk.Base.PutBitableV1AppsByAppTokenBodyDto>(json);
        Assert.IsNotNull(result);
    }
}