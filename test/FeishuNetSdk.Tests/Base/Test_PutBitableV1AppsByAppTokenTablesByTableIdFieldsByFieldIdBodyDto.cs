// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PutBitableV1AppsByAppTokenTablesByTableIdFieldsByFieldIdBodyDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 更新字段 请求体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Base;

/// <summary>
/// 测试 更新字段 请求体
/// <para>接口ID：6960166873968508931</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/app-table-field/update</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-table-field%2fupdate</para>
/// </summary>
[TestClass]
public class Test_PutBitableV1AppsByAppTokenTablesByTableIdFieldsByFieldIdBodyDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "field_name": "人员",
    "type": 11,
    "property": {
        "multiple": true
    }
}
""";
        var result = Deserialize<FeishuNetSdk.Base.PutBitableV1AppsByAppTokenTablesByTableIdFieldsByFieldIdBodyDto>(json);
        Assert.IsNotNull(result);
    }
}