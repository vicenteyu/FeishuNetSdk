// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PatchBitableV1AppsByAppTokenTablesByTableIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 更新数据表 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Base;

/// <summary>
/// 测试 更新数据表 请求体
/// <para>接口ID：7182466310810402817</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/app-table/patch</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-table%2fpatch</para>
/// </summary>
[TestClass]
public class Test_PatchBitableV1AppsByAppTokenTablesByTableIdBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "name": "新的数据表名称"
}
""";
        var result = Deserialize<FeishuNetSdk.Base.PatchBitableV1AppsByAppTokenTablesByTableIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}