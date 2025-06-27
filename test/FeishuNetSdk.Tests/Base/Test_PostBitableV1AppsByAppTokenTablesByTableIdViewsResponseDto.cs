// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_PostBitableV1AppsByAppTokenTablesByTableIdViewsResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 新增视图 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Base;

/// <summary>
/// 测试 新增视图 响应体
/// <para>接口ID：6978670625209614338</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/app-table-view/create</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-table-view%2fcreate</para>
/// </summary>
[TestClass]
public class Test_PostBitableV1AppsByAppTokenTablesByTableIdViewsResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "view": {
            "view_id": "vewTpR1urY",
            "view_name": "表格视图 1",
            "view_type": "grid"
        }
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Base.PostBitableV1AppsByAppTokenTablesByTableIdViewsResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}