// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostBitableV1AppsByAppTokenTablesByTableIdFieldsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 新增字段 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Base;

/// <summary>
/// 测试 新增字段 响应体
/// <para>接口ID：6960166873968427011</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/app-table-field/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-table-field%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostBitableV1AppsByAppTokenTablesByTableIdFieldsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "data": {
        "field": {
            "field_id": "fld4bocNLY",
            "field_name": "文本",
            "type": 1,
            "property": null
        }
    },
    "msg": "Success"
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Base.PostBitableV1AppsByAppTokenTablesByTableIdFieldsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}