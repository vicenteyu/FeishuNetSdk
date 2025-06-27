// ************************************************************************
// Assembly         : FeishuNetSdk
// Author           : yxr
// Created          : 2025-06-24
//
// Last Modified By : yxr
// Last Modified On : 2025-06-24
// ************************************************************************
// <copyright file="Test_GetBitableV1AppsByAppTokenTablesResponseDto.cs" company="Vicente Yu">
//     MIT
// </copyright>
// <summary>测试 列出数据表 响应体</summary>
// ************************************************************************
namespace FeishuNetSdk.Tests.Base;

/// <summary>
/// 测试 列出数据表 响应体
/// <para>接口ID：6960166873968476163</para>
/// <para>文档地址：https://open.feishu.cn/document/server-docs/docs/bitable-v1/app-table/list</para>
/// <para>JSON地址：https://open.feishu.cn/document_portal/v1/document/get_detail?fullPath=%2fuAjLw4CM%2fukTMukTMukTM%2freference%2fbitable-v1%2fapp-table%2flist</para>
/// </summary>
[TestClass]
public class Test_GetBitableV1AppsByAppTokenTablesResponseDto : TestBase
{
    [TestMethod]
    public void TestDto()
    {
        var json = """
{
    "code": 0,
    "msg": "success",
    "data": {
        "has_more": false,
        "page_token": "tblKz5D60T4JlfcT",
        "total": 1,
        "items": [
            {
                "table_id": "tblKz5D60T4JlfcT",
                "revision": 1,
                "name": "数据表1"
            }
        ]
    }
}
""";
        var result = Deserialize<FeishuResponse<FeishuNetSdk.Base.GetBitableV1AppsByAppTokenTablesResponseDto>>(json);
        Assert.IsNotNull(result);
    }
}